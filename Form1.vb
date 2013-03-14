'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.

'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'You should have received a copy of the GNU General Public License
'along with this program.  If not, see <http://www.gnu.org/licenses/>.
Option Strict Off
Imports System.Threading
Imports System.Net
Imports System.Text.RegularExpressions

Public Class Form1
    Dim wClient As WebClient
    Dim varchar As Char = "*"
    Dim currentpage As Integer = 0
    Dim CapTxt As String = ""
    Private trd0 As Thread
    Private updatethread As Thread
    Dim skipsavesettings As Boolean = False
    Private WithEvents kbHook As New kbhook
    Private WithEvents mHook As New MouseHook
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Long) As Integer
    Private Declare Function GetForegroundWindow Lib "user32" Alias "GetForegroundWindow" () As IntPtr
    Private Declare Auto Function GetWindowText Lib "user32" (ByVal hWnd As System.IntPtr, ByVal lpString As System.Text.StringBuilder, ByVal cch As Integer) As Integer
    Dim CurrentVersion As String = "v" & System.Reflection.Assembly.GetEntryAssembly.GetName().Version.ToString
    Dim ProgramName As String = System.Reflection.Assembly.GetEntryAssembly().GetName().Name.Replace(" ", "_")
    Dim VersionCHK, GetVer, GetVerLink As String
    Dim GetUpd As Integer
    Dim inisettings As New ini(Application.StartupPath & "\Keybinds.sav")
    Dim GTALocation As String = ""
    Dim keybinderdisabled As Boolean = False
    Private Function GetCaption() As String
        Dim Caption As New System.Text.StringBuilder(256)
        Dim hWnd As IntPtr = GetForegroundWindow()
        GetWindowText(hWnd, Caption, Caption.Capacity)
        Return Caption.ToString()
    End Function
    Sub Thread1()
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\SAMP", "gta_sa_exe", Nothing) Is Nothing Then
            MsgBox("GTA_SA.exe Not Detected (SACNR can not be directly launched)", vbCritical, "ERROR")
        Else
            GTALocation = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\SAMP", "gta_sa_exe", Nothing)
        End If
        GTALocation = GTALocation.Replace("gta_sa.exe", "samp.exe")
        GTALocation = Chr(34) + GTALocation + Chr(34) + " server.sacnr.com:7777"
        For Each ctrl In Me.ReactorTabControl2.TabPages(0).Controls
            If TypeOf ctrl Is ReactorTextBox Then
                Dim optionname As String = ctrl.name.replace("ReactorTextBox", "Send")
                ctrl.text = inisettings.GetString("SendKey", optionname, ctrl.text)
            ElseIf TypeOf ctrl Is TextBox Then
                Dim optionname As String = ctrl.name.replace("TextBox", "Key")
                ctrl.text = inisettings.GetString("HotKey", optionname, "")
                ReactorProgressBar1.Value = ReactorProgressBar1.Value + 1
            ElseIf TypeOf ctrl Is ReactorCheckBox Then
                Dim activation As String = ctrl.name.replace("ReactorCheckBox", "act")
                ctrl.checked = inisettings.GetString("Activate", activation, False)
            End If
        Next
        For Each ctrl In Me.ReactorTabControl2.TabPages(1).Controls
            If TypeOf ctrl Is ReactorTextBox Then
                Dim optionname As String = ctrl.name.replace("ReactorTextBox", "Send")
                ctrl.text = inisettings.GetString("SendKey", optionname, ctrl.text)
            ElseIf TypeOf ctrl Is TextBox Then
                Dim optionname As String = ctrl.name.replace("TextBox", "Key")
                ctrl.text = inisettings.GetString("HotKey", optionname, "")
                ReactorProgressBar1.Value = ReactorProgressBar1.Value + 1
            ElseIf TypeOf ctrl Is ReactorCheckBox Then
                Dim activation As String = ctrl.name.replace("ReactorCheckBox", "act")
                ctrl.checked = inisettings.GetString("Activate", activation, False)
            End If
        Next
        chkSettingToggle.Checked = inisettings.GetString("Settings", "EnableToggle", False)
        If chkSettingToggle.Checked = True Then
            currentpage = 1
        End If
        TextBox21.Text = inisettings.GetString("Settings", "ToggleKey", "")
        txtlmb.Text = inisettings.GetString("Mouse", "LeftClick", Nothing)
        txtRMB.Text = inisettings.GetString("Mouse", "RightClick", Nothing)
        txtMMB.Text = inisettings.GetString("Mouse", "MiddleClick", Nothing)
        txtWheelUp.Text = inisettings.GetString("Mouse", "WheelUp", Nothing)
        txtWheelDown.Text = inisettings.GetString("Mouse", "WheelDown", Nothing)
        txtSB1.Text = inisettings.GetString("Mouse", "SB1Click", Nothing)
        txtSB2.Text = inisettings.GetString("Mouse", "SB2Click", Nothing)
        chkLMB.Checked = inisettings.GetString("Mouse", "LeftClickActivated", False)
        chkRMB.Checked = inisettings.GetString("Mouse", "RightClickActivated", False)
        chkMMB.Checked = inisettings.GetString("Mouse", "MiddleClickActivated", False)
        chkWheelUp.Checked = inisettings.GetString("Mouse", "WheelUpActivated", False)
        chkWheelDown.Checked = inisettings.GetString("Mouse", "WheelDownActivated", False)
        chkSB1.Checked = inisettings.GetString("Mouse", "SB1ClickActivated", False)
        chkSB2.Checked = inisettings.GetString("Mouse", "SB2ClickActivated", False)
        chkAutoupdates.Checked = inisettings.GetString("Settings", "AutoUpdate", False)
        ReactorProgressBar1.Visible = False
    End Sub
    Private Sub mHook_Mouse_Left() Handles mHook.Mouse_Left
        CapTxt = GetCaption()
        If DebugChkSkipWindowCheck.Checked = True Then
            CapTxt = "GTA:SA:MP"
        End If
        If CapTxt = "GTA:SA:MP" Then
            If keybinderdisabled = False Then
                If chkLMB.Checked = True Then
                    SendKeys.SendWait("t" + txtlmb.Text + "{Enter}")
                End If
            End If
        End If
    End Sub

    Private Sub mHook_Mouse_Middle() Handles mHook.Mouse_Middle
        CapTxt = GetCaption()
        If DebugChkSkipWindowCheck.Checked = True Then
            CapTxt = "GTA:SA:MP"
        End If
        If CapTxt = "GTA:SA:MP" Then
            If keybinderdisabled = False Then
                If chkMMB.Checked = True Then
                    SendKeys.SendWait("t" + txtMMB.Text + "{Enter}")
                End If
            End If
        End If
    End Sub
    Private Sub mHook_Mouse_Right() Handles mHook.Mouse_Right
        CapTxt = GetCaption()
        If DebugChkSkipWindowCheck.Checked = True Then
            CapTxt = "GTA:SA:MP"
        End If
        If CapTxt = "GTA:SA:MP" Then
            If keybinderdisabled = False Then
                If chkRMB.Checked = True Then
                    SendKeys.SendWait("t" + txtRMB.Text + "{Enter}")
                End If
            End If
        End If
    End Sub

    Private Sub mHook_Mouse_Wheel(ByVal Direction As MouseHook.Wheel_Direction) Handles mHook.Mouse_Wheel
        CapTxt = GetCaption()
        If DebugChkSkipWindowCheck.Checked = True Then
            CapTxt = "GTA:SA:MP"
        End If
        If CapTxt = "GTA:SA:MP" Then
            If keybinderdisabled = False Then
                If Direction.ToString = "WheelUp" Then
                    If chkWheelUp.Checked = True Then
                        SendKeys.SendWait("t" + txtWheelUp.Text + "{Enter}")
                    End If
                Else
                    If chkWheelDown.Checked = True Then
                        SendKeys.SendWait("t" + txtWheelDown.Text + "{Enter}")
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub mHook_Mouse_XButton1() Handles mHook.Mouse_XButton1
        CapTxt = GetCaption()
        If DebugChkSkipWindowCheck.Checked = True Then
            CapTxt = "GTA:SA:MP"
        End If
        If CapTxt = "GTA:SA:MP" Then
            If keybinderdisabled = False Then
                If chkSB1.Checked = True Then
                    SendKeys.SendWait("t" + txtSB1.Text + "{Enter}")
                End If
            End If
        End If
    End Sub
    Private Sub mHook_Mouse_XButton2() Handles mHook.Mouse_XButton2
        CapTxt = GetCaption()
        If DebugChkSkipWindowCheck.Checked = True Then
            CapTxt = "GTA:SA:MP"
        End If
        If CapTxt = "GTA:SA:MP" Then
            If keybinderdisabled = False Then
                If chkSB2.Checked = True Then
                    SendKeys.SendWait("t" + txtSB2.Text + "{Enter}")
                End If
            End If
        End If
    End Sub
    Sub macro(ByVal TextBox As ReactorTextBox)
        Dim substr As String = TextBox.Text
        Do
            If substr.Contains(varchar) Then
                Dim subsubstr As String
                subsubstr = substr
                subsubstr = subsubstr.Remove(subsubstr.IndexOf(varchar))
                substr = substr.Replace(subsubstr & varchar, "")
                SendKeys.Send("t" + subsubstr + "{Enter}")
                Thread.Sleep(inisettings.GetInteger("Settings", "MacroDelay", 1000))
            End If
        Loop While substr.Contains(varchar) = True
        SendKeys.Send("t" + substr + "{Enter}")
    End Sub

    Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown
        'Debug.WriteLine("Key = " & Key.ToString.ToUpper & " Textbox = " & TextBox3.Text)
        If chkSettingToggle.Checked = True Then
            If Key.ToString.ToUpper = TextBox21.Text.ToUpper Then
                If currentpage <> 1 Then
                    currentpage = 1
                Else
                    currentpage = 2
                End If
            End If
        End If

        CapTxt = GetCaption()
        If DebugChkSkipWindowCheck.Checked = True Then
            CapTxt = "GTA:SA:MP"
        End If
        If CapTxt = "GTA:SA:MP" Then
            If keybinderdisabled = False Then
                If currentpage <> 2 Then
                    If ReactorCheckBox1.Checked = True Then
                        If Key.ToString.ToUpper = TextBox1.Text.ToUpper Then
                            macro(ReactorTextBox1)
                        End If
                    End If
                    If ReactorCheckBox2.Checked = True Then
                        If Key.ToString.ToUpper = TextBox2.Text.ToUpper Then
                            SendKeys.SendWait("t" + ReactorTextBox2.Text + "{Enter}")
                        End If
                    End If
                    If ReactorCheckBox3.Checked = True Then
                        If Key.ToString.ToUpper = TextBox3.Text.ToUpper Then
                            SendKeys.SendWait("t" + ReactorTextBox3.Text + "{Enter}")
                        End If
                    End If
                    If ReactorCheckBox4.Checked = True Then
                        If Key.ToString.ToUpper = TextBox4.Text.ToUpper Then
                            SendKeys.SendWait("t" + ReactorTextBox4.Text + "{Enter}")
                        End If
                    End If
                    If ReactorCheckBox5.Checked = True Then
                        If Key.ToString.ToUpper = TextBox5.Text.ToUpper Then
                            SendKeys.SendWait("t" + ReactorTextBox5.Text + "{Enter}")
                        End If
                    End If
                    If ReactorCheckBox6.Checked = True Then
                        If Key.ToString.ToUpper = TextBox6.Text.ToUpper Then
                            SendKeys.SendWait("t" + ReactorTextBox6.Text + "{Enter}")
                        End If
                    End If
                    If ReactorCheckBox7.Checked = True Then
                        If Key.ToString.ToUpper = TextBox7.Text.ToUpper Then
                            SendKeys.SendWait("t" + ReactorTextBox7.Text + "{Enter}")
                        End If
                    End If
                    If ReactorCheckBox8.Checked = True Then
                        If Key.ToString.ToUpper = TextBox8.Text.ToUpper Then
                            SendKeys.SendWait("t" + ReactorTextBox8.Text + "{Enter}")
                        End If
                    End If
                    If ReactorCheckBox9.Checked = True Then
                        If Key.ToString.ToUpper = TextBox9.Text.ToUpper Then
                            SendKeys.SendWait("t" + ReactorTextBox9.Text + "{Enter}")
                        End If
                    End If
                    If ReactorCheckBox10.Checked = True Then
                        If Key.ToString.ToUpper = TextBox10.Text.ToUpper Then
                            SendKeys.SendWait("t" + ReactorTextBox10.Text + "{Enter}")
                        End If
                    End If
                End If
                If currentpage <> 1 Then
                    If ReactorCheckBox11.Checked = True Then
                        If Key.ToString.ToUpper = TextBox11.Text.ToUpper Then
                            SendKeys.SendWait("t" + ReactorTextBox11.Text + "{Enter}")
                        End If
                    End If
                    If ReactorCheckBox12.Checked = True Then
                        If Key.ToString.ToUpper = TextBox12.Text.ToUpper Then
                            SendKeys.SendWait("t" + ReactorTextBox12.Text + "{Enter}")
                        End If
                    End If
                    If ReactorCheckBox13.Checked = True Then
                        If Key.ToString.ToUpper = TextBox13.Text.ToUpper Then
                            SendKeys.SendWait("t" + ReactorTextBox13.Text + "{Enter}")
                        End If
                    End If
                    If ReactorCheckBox14.Checked = True Then
                        If Key.ToString.ToUpper = TextBox14.Text.ToUpper Then
                            SendKeys.SendWait("t" + ReactorTextBox14.Text + "{Enter}")
                        End If
                    End If
                    If ReactorCheckBox15.Checked = True Then
                        If Key.ToString.ToUpper = TextBox15.Text.ToUpper Then
                            SendKeys.SendWait("t" + ReactorTextBox15.Text + "{Enter}")
                        End If
                    End If
                    If ReactorCheckBox16.Checked = True Then
                        If Key.ToString.ToUpper = TextBox16.Text.ToUpper Then
                            SendKeys.SendWait("t" + ReactorTextBox16.Text + "{Enter}")
                        End If
                    End If
                    If ReactorCheckBox17.Checked = True Then
                        If Key.ToString.ToUpper = TextBox17.Text.ToUpper Then
                            SendKeys.SendWait("t" + ReactorTextBox17.Text + "{Enter}")
                        End If
                    End If
                    If ReactorCheckBox18.Checked = True Then
                        If Key.ToString.ToUpper = TextBox18.Text.ToUpper Then
                            SendKeys.SendWait("t" + ReactorTextBox18.Text + "{Enter}")
                        End If
                    End If
                    If ReactorCheckBox19.Checked = True Then
                        If Key.ToString.ToUpper = TextBox19.Text.ToUpper Then
                            SendKeys.SendWait("t" + ReactorTextBox19.Text + "{Enter}")
                        End If
                    End If
                    If ReactorCheckBox20.Checked = True Then
                        If Key.ToString.ToUpper = TextBox20.Text.ToUpper Then
                            SendKeys.SendWait("t" + ReactorTextBox20.Text + "{Enter}")
                        End If
                    End If
                End If
            End If
        End If
        If Key.ToString = "F6" Then
            keybinderdisabled = True
        End If
        If Key.ToString = "Return" Then
            keybinderdisabled = False
        End If
        If Key.ToString = "Escape" Then
            keybinderdisabled = False
        End If
        If Key.ToString = "T" Then
            keybinderdisabled = True
        End If
        If Key.ToString = "`" Then
            keybinderdisabled = True
        End If
    End Sub
    Private Sub imgLogo2_Click(sender As Object, e As EventArgs) Handles imgLogo2.Click
        Process.Start("http://sacnr.com")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim result = MsgBox("Are you sure you wish to reset all settings and keybinds?", vbYesNo + MsgBoxStyle.Question, "Confirmation")
        If result = vbYes Then
            skipsavesettings = True
            If IO.File.Exists(Application.StartupPath & "\Keybinds.sav") Then IO.File.Delete(Application.StartupPath & "\Keybinds.sav")
            MsgBox("Default settings restored! Application will now restart", vbInformation, "Success!")
            Application.Restart()
        End If
    End Sub
    Sub savesettings()
        For Each ctrl In Me.ReactorTabControl2.TabPages(0).Controls
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
        For Each ctrl In Me.ReactorTabControl2.TabPages(1).Controls
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
        inisettings.WriteString("Settings", "EnableToggle", chkSettingToggle.Checked.ToString)
        inisettings.WriteString("Settings", "ToggleKey", TextBox21.Text)
        inisettings.WriteString("Mouse", "LeftClick", txtlmb.Text)
        inisettings.WriteString("Mouse", "RightClick", txtRMB.Text)
        inisettings.WriteString("Mouse", "MiddleClick", txtMMB.Text)
        inisettings.WriteString("Mouse", "WheelUp", txtWheelUp.Text)
        inisettings.WriteString("Mouse", "WheelDown", txtWheelDown.Text)
        inisettings.WriteString("Mouse", "SB1Click", txtSB1.Text)
        inisettings.WriteString("Mouse", "SB2Click", txtSB2.Text)
        inisettings.WriteString("Mouse", "LeftClickActivated", chkLMB.Checked.ToString)
        inisettings.WriteString("Mouse", "RightClickActivated", chkRMB.Checked.ToString)
        inisettings.WriteString("Mouse", "MiddleClickActivated", chkMMB.Checked.ToString)
        inisettings.WriteString("Mouse", "WheelUpActivated", chkWheelUp.Checked.ToString)
        inisettings.WriteString("Mouse", "WheelDownActivated", chkWheelDown.Checked.ToString)
        inisettings.WriteString("Mouse", "SB1ClickActivated", chkSB1.Checked.ToString)
        inisettings.WriteString("Mouse", "SB2ClickActivated", chkSB2.Checked.ToString)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        savesettings()
    End Sub

    Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
        Shell(GTALocation)
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        trd0 = New Thread(AddressOf Thread1)
        trd0.IsBackground = True
        trd0.Start()
        If inisettings.GetString("Settings", "AutoUpdate", False) = True Then

            Dim NewVersion As String = ""

            wClient = New WebClient
            Try
                NewVersion = wClient.DownloadString("http://cyanlabs.co.uk/updatechecker/" & ProductName.Replace(" ", "_") & "/version.html")

                If Not NewVersion = Nothing Then
                    If NewVersion > CurrentVersion = True Then
                        If IO.File.Exists(Application.StartupPath & "\AutoUpdater.exe") Then IO.File.Delete(Application.StartupPath & "\AutoUpdater.exe")
                        DownloadUpdater("http://cyanlabs.co.uk/updatechecker/AutoUpdater.exe", Application.StartupPath & "\AutoUpdater.exe")
                    End If
                End If
            Catch webex As WebException
                MsgBox(webex.Message.ToString)
            End Try
            '     ' DownloadFile("http://cyanlabs.co.uk/autoupdates/sacnrkeybinder2013/SACNR Keybinder 2013 Edition.exe", "C:\SACNR Keybinder 2013 Edition.exe")
        End If
    End Sub

    ''' <summary>Download file</summary>
    ''' <param name="input">URI to grab</param>
    ''' <param name="output">Save Location including Filename.</param>
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
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox9.KeyDown, TextBox8.KeyDown, TextBox7.KeyDown, TextBox6.KeyDown, TextBox5.KeyDown, TextBox4.KeyDown, TextBox3.KeyDown, TextBox2.KeyDown, TextBox10.KeyDown, TextBox1.KeyDown, TextBox20.KeyDown, TextBox19.KeyDown, TextBox18.KeyDown, TextBox17.KeyDown, TextBox16.KeyDown, TextBox15.KeyDown, TextBox14.KeyDown, TextBox13.KeyDown, TextBox12.KeyDown, TextBox11.KeyDown, TextBox21.KeyDown
        sender.text = ""
        sender.tag = e.KeyCode
        sender.text = e.KeyCode.ToString.ToUpper
        e.SuppressKeyPress = True
    End Sub

    Private Sub chkSettingToggle_CheckedChanged(sender As Object) Handles chkSettingToggle.CheckedChanged
        If sender.checked = False Then
            currentpage = 0
        End If
    End Sub

    Private Sub chkAutoupdates_CheckedChanged(sender As Object) Handles chkAutoupdates.CheckedChanged
        inisettings.WriteString("Settings", "AutoUpdate", sender.checked.ToString)
    End Sub
End Class