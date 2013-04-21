'' ''This program is free software: you can redistribute it and/or modify
'' ''it under the terms of the GNU General Public License as published by
'' ''the Free Software Foundation, either version 3 of the License, or
'' ''(at your option) any later version.

'' ''This program is distributed in the hope that it will be useful,
'' ''but WITHOUT ANY WARRANTY; without even the implied warranty of
'' ''MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'' ''GNU General Public License for more details.
'' ''You should have received a copy of the GNU General Public License
'' ''along with this program.  If not, see <http://www.gnu.org/licenses/>.
Option Strict Off
Imports System.Threading
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Net.Mail

Public Class Form1
    Dim youtubeurl As String = "http://www.youtube.com/embed/T23exzRYxmM"
    Public WithEvents kbhook As KBhook
    Public WithEvents mHook As MouseHook
    Public Shared SAMPUsername As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\SAMP", "PlayerName", "Keybinds")
    Dim ProgramName As String = System.Reflection.Assembly.GetEntryAssembly().GetName().Name.Replace(" ", "_")
    Dim loglocation As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\GTA San Andreas User Files\SAMP"
    Dim drag As Boolean, mousex As Integer, mousey As Integer
    Dim running As Integer = 1
    Dim wClient As WebClient
    Dim finishedload As Boolean = False
    Private updatethread As Thread
    Public Shared skipsavesettings As Boolean = False
    Private trd2 As Thread
    Private Declare Function GetForegroundWindow Lib "user32" Alias "GetForegroundWindow" () As IntPtr
    Private Declare Auto Function GetWindowText Lib "user32" (ByVal hWnd As System.IntPtr, ByVal lpString As System.Text.StringBuilder, ByVal cch As Integer) As Integer
    Dim CurrentVersion As String = "v" & System.Reflection.Assembly.GetEntryAssembly.GetName().Version.ToString
    Public Shared inisettings As ini
    Public Shared keybinderdisabled As Boolean = False

    Private Sub mHook_Mouse_Left() Handles mHook.Mouse_Left
        If DebugCheck() = "GTA:SA:MP" Then
            MousePanel1.Mouse_Left()
        End If

    End Sub

    Private Sub mHook_Mouse_Middle() Handles mHook.Mouse_Middle
        If DebugCheck() = "GTA:SA:MP" Then
            MousePanel1.Mouse_Middle()
        End If

    End Sub
    Private Sub mHook_Mouse_Right() Handles mHook.Mouse_Right
        If DebugCheck() = "GTA:SA:MP" Then
            MousePanel1.Mouse_Right()
        End If
    End Sub

    Private Sub mHook_Mouse_Wheel(ByVal Direction As MouseHook.Wheel_Direction) Handles mHook.Mouse_Wheel
        If DebugCheck() = "GTA:SA:MP" Then
            MousePanel1.Mouse_Wheel(Direction)
        End If
    End Sub
    Private Sub mHook_Mouse_XButton1() Handles mHook.Mouse_XButton1
        If DebugCheck() = "GTA:SA:MP" Then
            MousePanel1.Mouse_XButton1()
        End If
    End Sub
    Private Sub mHook_Mouse_XButton2() Handles mHook.Mouse_XButton2
        If DebugCheck() = "GTA:SA:MP" Then
            MousePanel1.Mouse_XButton2()
        End If
    End Sub

    Public Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbhook.KeyDown
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is KBPanel Then
                ctrl.kbHook(Key)
            End If
        Next
    End Sub
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, imgLogo2.MouseDown, KbPanelPage2.MouseDown, KbPanelPage1.MouseDown, AboutPanel1.MouseDown, SettingsPanel1.MouseDown, X360Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            drag = True
            mousex = Windows.Forms.Cursor.Position.X - Me.Left
            mousey = Windows.Forms.Cursor.Position.Y - Me.Top
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp, imgLogo2.MouseUp, KbPanelPage2.MouseUp, KbPanelPage1.MouseUp, AboutPanel1.MouseUp, SettingsPanel1.MouseUp, X360Panel1.MouseUp
        drag = False
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove, imgLogo2.MouseMove, KbPanelPage2.MouseMove, KbPanelPage1.MouseMove, AboutPanel1.MouseMove, SettingsPanel1.MouseMove, X360Panel1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Public Function GetCaption() As String
        Dim Caption As New System.Text.StringBuilder(256)
        Dim hWnd As IntPtr = GetForegroundWindow()
        GetWindowText(hWnd, Caption, Caption.Capacity)
        Return Caption.ToString()
    End Function
    Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
        Dim gtalocation As String = ""
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\SAMP", "gta_sa_exe", Nothing) Is Nothing Then
            MsgBox("GTA_SA.exe Not Detected (SACNR can not be directly launched)", vbCritical, "ERROR")
        Else
            gtalocation = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\SAMP", "gta_sa_exe", Nothing)
        End If
        gtalocation = gtalocation.Replace("gta_sa.exe", "samp.exe")
        gtalocation = Chr(34) + gtalocation + Chr(34) + " server.sacnr.com:7777"
        Shell(gtalocation)
    End Sub
    Dim param_obj(2) As Object
    Dim Togdims As String()
    Dim CMDNumber As New Dictionary(Of String, Integer)()
    Sub macro(ByVal param_obj() As Object)
        Dim substr As String = param_obj(1)
        Dim pressed As String = param_obj(0)
        If substr.Contains("#") Then
            If Not CMDNumber.ContainsKey(pressed) Then
                CMDNumber(pressed) = 1
            End If
            Dim splitstring() As String = Split(substr, "#")
            Dim x As Integer = 0
            For Each item In splitstring
                x = x + 1
                If x >= CMDNumber(pressed) Then
                    SendKeys.SendWait("t" + item + "{Enter}")
                    CMDNumber(pressed) = CMDNumber(pressed) + 1
                    Debug.WriteLine("cmdnumber = " & CMDNumber(pressed))
                    Debug.WriteLine("x = " & x)
                    If splitstring.GetLength(0) = x Then
                        CMDNumber(pressed) = 1
                    End If
                    Exit Sub
                End If
            Next
        Else
            Dim splitstring() As String = Split(substr, "*")
            For Each item In splitstring
                SendKeys.SendWait("t" + item + "{Enter}")
                Thread.Sleep(Convert.ToInt32(inisettings.GetString("Settings", "MacroDelay", 1000)))
            Next
        End If
    End Sub

    Private Sub imgLogo2_Click(sender As Object, e As EventArgs) Handles imgLogo2.DoubleClick
        Process.Start("http://sacnr.com")
    End Sub
    Sub savesettings()
        If finishedload = True Then
            For Each ctrl In KbPanelPage1.Controls
                If TypeOf ctrl Is ReactorTextBox Then
                    Dim optionname As String = ctrl.name.replace("ReactorTextBox", "Send")
                    inisettings.WriteString("SendKey", optionname, ctrl.Text)
                End If
                If TypeOf ctrl Is TextBox Then
                    Dim optionname As String = ctrl.name.replace("TextBox", "Key")
                    If ctrl.text = Nothing Then
                    Else
                        inisettings.WriteString("HotKey", optionname, ctrl.text.ToString)
                    End If
                End If
                If TypeOf ctrl Is ReactorCheckBox Then
                    Dim activation As String = ctrl.name.replace("ReactorCheckBox", "act")
                    inisettings.WriteString("Activate", activation, ctrl.checked.ToString)
                End If
            Next
            For Each ctrl In KbPanelPage2.Controls
                If TypeOf ctrl Is ReactorTextBox Then
                    Dim optionname As String = ctrl.name.replace("ReactorTextBox", "SendPage2")
                    inisettings.WriteString("SendKey", optionname, ctrl.Text)
                End If
                If TypeOf ctrl Is TextBox Then
                    Dim optionname As String = ctrl.name.replace("TextBox", "KeyPage2")
                    If ctrl.text = Nothing Then
                    Else
                        inisettings.WriteString("HotKey", optionname, ctrl.text.ToString)
                    End If
                End If
                If TypeOf ctrl Is ReactorCheckBox Then
                    Dim activation As String = ctrl.name.replace("ReactorCheckBox", "actPage2")
                    inisettings.WriteString("Activate", activation, ctrl.checked.ToString)
                End If
            Next
            X360Panel1.savesettings()
            MousePanel1.savesettings()
        End If
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If skipsavesettings = False Then
            savesettings()
        End If
    End Sub

    Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs) Handles NotifyIcon1.Click
        NotifyIcon1.Visible = False
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            Me.ShowInTaskbar = False
        End If
    End Sub
    Public Function GetChangelog(ByVal PageURL As String) As String
        Dim S As String = ""
        Try
            Dim Request As HttpWebRequest = WebRequest.Create(PageURL)
            Dim Response As HttpWebResponse = Request.GetResponse()
            Using Reader As IO.StreamReader = New IO.StreamReader(Response.GetResponseStream())
                S = Reader.ReadToEnd
            End Using
        Catch ex As Exception
            MsgBox("Failed to retrieve changelog", MsgBoxStyle.Exclamation, "Error")
        End Try
        Return S
    End Function
    Function DebugCheck()
        If Not My.Application.CommandLineArgs.Count = 0 Then
            If My.Application.CommandLineArgs(0) = "-debug" Then
                Return "GTA:SA:MP"
            End If
        End If
        Return GetCaption()
    End Function
    Private Sub Form1_shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        AboutPanel1.Controls("lblVersion").Text = CurrentVersion
        If Not IO.Directory.Exists(Application.StartupPath & "\keybinds") Then IO.Directory.CreateDirectory(Application.StartupPath & "\keybinds")
        If IO.File.Exists(Application.StartupPath & "\keybinds.sav") Then
            IO.File.Copy(Application.StartupPath & "\keybinds.sav", Application.StartupPath & "\keybinds\" & SettingsPanel1.Controls("txtSAMPUsername").Text & "_keybinds.sav", True)
            IO.File.Delete(Application.StartupPath & "\keybinds.sav")
        End If
        inisettings = New ini(Application.StartupPath & "\keybinds\" & SAMPUsername & "_keybinds.sav")

        If Not My.Application.CommandLineArgs.Count = 0 Then
            If My.Application.CommandLineArgs(0) = "updated" Then
                AboutPanel1.Visible = True
                KbPanelPage1.Visible = False
                Label5.Visible = False
                Label6.Visible = False
                KbPanelPage2.Visible = False
                MousePanel1.Visible = False
                SettingsPanel1.Visible = False
                X360Panel1.Visible = False
            End If
        End If
        WebBrowser1.DocumentText = "<body style='background-color:black;margin:0;border:none;'><iframe frameborder='0' src='" & youtubeurl & "?HD=1;rel=0;showinfo=0;controls=0' style='position:fixed; top:0px; left:0px; bottom:0px; right:0px; width:100%; height:100%; border:none; margin:0; padding:0; overflow:hidden; z-index:999999;' allowfullscreen></body>"

        CheckForIllegalCrossThreadCalls = False

        If inisettings.GetString("Settings", "AutoUpdate", False) = True Then
            Dim NewVersion As String = ""
            wClient = New WebClient
            Try
                NewVersion = wClient.DownloadString("http://cyanlabs.co.uk/updatechecker/" & ProductName.Replace(" ", "_") & "/version.html")
                If Not NewVersion = Nothing Then
                    If NewVersion > "v" & System.Reflection.Assembly.GetEntryAssembly.GetName().Version.ToString = True Then
                        If IO.File.Exists(Application.StartupPath & "\AutoUpdater.exe") Then IO.File.Delete(Application.StartupPath & "\AutoUpdater.exe")
                        DownloadUpdater("http://cyanlabs.co.uk/updatechecker/AutoUpdater.exe", Application.StartupPath & "\AutoUpdater.exe")
                    End If
                End If
            Catch webex As WebException
                MsgBox(webex.Message.ToString)
            End Try
        End If
        For Each ctrl In KbPanelPage1.Controls
            If TypeOf ctrl Is ReactorTextBox Then
                Dim optionname As String = ctrl.name.replace("ReactorTextBox", "Send")
                ctrl.text = inisettings.GetString("SendKey", optionname, ctrl.text)
            ElseIf TypeOf ctrl Is TextBox Then
                Dim optionname As String = ctrl.name.replace("TextBox", "Key")
                ctrl.text = inisettings.GetString("HotKey", optionname, "")
            ElseIf TypeOf ctrl Is ReactorCheckBox Then
                Dim activation As String = ctrl.name.replace("ReactorCheckBox", "act")
                ctrl.checked = inisettings.GetString("Activate", activation, False)
            End If
        Next
        For Each ctrl In KbPanelPage2.Controls
            If TypeOf ctrl Is ReactorTextBox Then
                Dim optionname As String = ctrl.name.replace("ReactorTextBox", "SendPage2")
                ctrl.text = inisettings.GetString("SendKey", optionname, ctrl.text)
            ElseIf TypeOf ctrl Is TextBox Then
                Dim optionname As String = ctrl.name.replace("TextBox", "KeyPage2")
                ctrl.text = inisettings.GetString("HotKey", optionname, "")
            ElseIf TypeOf ctrl Is ReactorCheckBox Then
                Dim activation As String = ctrl.name.replace("ReactorCheckBox", "actPage2")
                ctrl.checked = inisettings.GetString("Activate", activation, False)
            End If
        Next
        For Each ctrl In X360Panel1.Controls
            If TypeOf ctrl Is ReactorTextBox Then
                Dim optionname As String = ctrl.name.replace("txt", "360")
                ctrl.text = inisettings.GetString("360", optionname, ctrl.text)
            ElseIf TypeOf ctrl Is ReactorCheckBox Then
                Dim activation As String = ctrl.name.replace("chk", "360act")
                ctrl.checked = inisettings.GetString("360", activation, False)
            End If
        Next
        MousePanel1.loadsettings()
        SettingsPanel1.LoadSettings()
        KbPanelPage2.Controls("lblPage").Text = KbPanelPage2.Name.Replace("KbPanelPage", "Page ")
        kbhook = New KBhook
        mHook = New MouseHook
        finishedload = True
    End Sub

    Private Sub DownloadUpdater(ByVal input As String, ByVal output As String)
        wClient = New WebClient
        Try
            wClient.DownloadFile(New Uri(input), output)
            Process.Start(Application.StartupPath & "\AutoUpdater.exe ", ProgramName)
            Application.Exit()
        Catch webex As WebException
            MsgBox(webex.Message.ToString)
        End Try
    End Sub
    Public Function IsProcessRunning(name As String) As Boolean
        For Each clsProcess As Process In Process.GetProcesses()
            If clsProcess.ProcessName.StartsWith(name) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If IsProcessRunning("gta_sa") = False AndAlso running = 2 Then
            Me.running = 0
        End If
        If (IsProcessRunning("gta_sa") = True) Then
            Me.running = 2
        End If
        If Me.running = 0 Then
            Dim str As String = (DateTime.Now.ToString("dd-MM-yy") & "_" & DateTime.Now.ToString("HH-mm"))
            If My.Computer.FileSystem.FileExists(loglocation & "\chatlog.txt") Then
                If Not IO.Directory.Exists(loglocation & "\Logs") Then IO.Directory.CreateDirectory(loglocation & "\Logs")
                My.Computer.FileSystem.CopyFile(loglocation & "\chatlog.txt", loglocation & "\Logs\chatlog_" & str & ".txt", True)
                Me.NotifyIcon1.ShowBalloonTip(5000, "SACNR Keybinder 2013 Edition", "Log Saved (" & str & ")", ToolTipIcon.Info)
                Me.running = 1
            End If
        End If
    End Sub
    Private Sub ReactorButton1_Click(sender As Object, e As EventArgs)
        For Each ctrl In KbPanelPage2.Controls
            MsgBox(ctrl.name)
        Next
    End Sub
    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label6.MouseHover, Label5.MouseHover, Label4.MouseHover, Label3.MouseHover, Label2.MouseHover, Label1.MouseHover, Label9.MouseHover
        sender.forecolor = Color.White
    End Sub
    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave, Label5.MouseLeave, Label4.MouseLeave, Label3.MouseLeave, Label2.MouseLeave, Label1.MouseLeave, Label9.MouseLeave
        sender.forecolor = Color.Gray
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label6.Click
        KbPanelPage1.Visible = True
        Label5.ForeColor = Color.Gray
        Label6.ForeColor = Color.White
        Label6.Visible = True
        Label5.Visible = True

        KbPanelPage2.Visible = False
        MousePanel1.Visible = False
        SettingsPanel1.Visible = False
        AboutPanel1.Visible = False
        X360Panel1.Visible = False
        MainPanel.Visible = False
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label5.Click
        KbPanelPage2.Visible = True
        Label5.ForeColor = Color.White
        Label6.ForeColor = Color.Gray
        Label6.Visible = True
        Label5.Visible = True
        KbPanelPage1.Visible = False
        MousePanel1.Visible = False
        SettingsPanel1.Visible = False
        AboutPanel1.Visible = False
        X360Panel1.Visible = False
        MainPanel.Visible = False
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        MousePanel1.Visible = True
        KbPanelPage1.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        KbPanelPage2.Visible = False
        SettingsPanel1.Visible = False
        AboutPanel1.Visible = False
        X360Panel1.Visible = False
        MainPanel.Visible = False
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        X360Panel1.Visible = True
        KbPanelPage2.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        KbPanelPage1.Visible = False
        MousePanel1.Visible = False
        SettingsPanel1.Visible = False
        AboutPanel1.Visible = False
        MainPanel.Visible = False
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        AboutPanel1.Visible = True
        MainPanel.Visible = False
        KbPanelPage2.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        KbPanelPage1.Visible = False
        MousePanel1.Visible = False
        SettingsPanel1.Visible = False
        X360Panel1.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        AboutPanel1.Visible = False
        MainPanel.Visible = False
        KbPanelPage2.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        KbPanelPage1.Visible = False
        MousePanel1.Visible = False
        SettingsPanel1.Visible = True
        X360Panel1.Visible = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If DebugCheck() = "GTA:SA:MP" Then
            X360Panel1.Timer2()
        End If
    End Sub
End Class