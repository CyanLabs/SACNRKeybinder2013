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
Imports System.Threading

Public Class Form1
    Private WithEvents kbHook As New kbhook
    Private WithEvents mHook As New MouseHook
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Long) As Integer
    Private Declare Function GetForegroundWindow Lib "user32" Alias "GetForegroundWindow" () As IntPtr
    Private Declare Auto Function GetWindowText Lib "user32" (ByVal hWnd As System.IntPtr, ByVal lpString As System.Text.StringBuilder, ByVal cch As Integer) As Integer
    'Dim KeyList As New ArrayList
    Dim inisettings As New ini(Application.StartupPath & "\Keybinds.sav")
    Dim GTALocation As String = ""
    Dim keybinderdisabled As Boolean = False
    Private Function GetCaption() As String
        Dim Caption As New System.Text.StringBuilder(256)
        Dim hWnd As IntPtr = GetForegroundWindow()
        GetWindowText(hWnd, Caption, Caption.Capacity)
        Return Caption.ToString()
    End Function
    Sub Thread1Sub()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\SAMP", "gta_sa_exe", Nothing) Is Nothing Then
            MsgBox("GTA_SA.exe Not Detected (SACNR can not be directly launched)", vbCritical, "ERROR")
        Else
            GTALocation = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\SAMP", "gta_sa_exe", Nothing)
        End If
        GTALocation = GTALocation.Replace("gta_sa.exe", "samp.exe")
        GTALocation = Chr(34) + GTALocation + Chr(34) + " server.sacnr.com:7777"

        'Dim Keylist1 As ArrayList = KeyList.Clone
        'Dim Keylist2 As ArrayList = KeyList.Clone
        'Dim Keylist3 As ArrayList = KeyList.Clone
        'Dim Keylist4 As ArrayList = KeyList.Clone
        'Dim Keylist5 As ArrayList = KeyList.Clone
        'Dim Keylist6 As ArrayList = KeyList.Clone
        'Dim Keylist7 As ArrayList = KeyList.Clone
        'Dim Keylist8 As ArrayList = KeyList.Clone
        'Dim Keylist9 As ArrayList = KeyList.Clone
        'Dim Keylist10 As ArrayList = KeyList.Clone
        'Dim Keylist11 As ArrayList = KeyList.Clone
        'Dim Keylist12 As ArrayList = KeyList.Clone
        'Dim Keylist13 As ArrayList = KeyList.Clone
        'Dim Keylist14 As ArrayList = KeyList.Clone
        'Dim Keylist15 As ArrayList = KeyList.Clone
        'Dim Keylist16 As ArrayList = KeyList.Clone
        'Dim Keylist17 As ArrayList = KeyList.Clone
        'Dim Keylist18 As ArrayList = KeyList.Clone
        'Dim Keylist19 As ArrayList = KeyList.Clone
        'ReactorComboBox1.DataSource = KeyList
        'ReactorComboBox2.DataSource = Keylist1
        'ReactorComboBox3.DataSource = Keylist2
        'ReactorComboBox4.DataSource = Keylist3
        'ReactorComboBox5.DataSource = Keylist4
        'ReactorComboBox6.DataSource = Keylist5
        'ReactorComboBox7.DataSource = Keylist6
        'ReactorComboBox8.DataSource = Keylist7
        'ReactorComboBox9.DataSource = Keylist8
        'ReactorComboBox10.DataSource = Keylist9
        'ReactorComboBox11.DataSource = Keylist10
        'ReactorComboBox12.DataSource = Keylist11
        'ReactorComboBox13.DataSource = Keylist12
        'ReactorComboBox14.DataSource = Keylist13
        'ReactorComboBox15.DataSource = Keylist14
        'ReactorComboBox16.DataSource = Keylist15
        'ReactorComboBox17.DataSource = Keylist16
        'ReactorComboBox18.DataSource = Keylist17
        'ReactorComboBox19.DataSource = Keylist18
        'ReactorComboBox20.DataSource = Keylist19
        For Each ctrl In Me.ReactorTabControl1.TabPages(0).Controls
            If TypeOf ctrl Is ReactorTextBox Then
                Dim optionname As String = ctrl.name.replace("ReactorTextBox", "Send")
                ctrl.text = inisettings.GetString("SendKey", optionname, ctrl.text)
            ElseIf TypeOf ctrl Is ReactorComboBox Then
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.D1, "1"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.D2, "2"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.D3, "3"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.D4, "4"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.D5, "5"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.D6, "6"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.D7, "7"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.D8, "8"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.D9, "9"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.D0, "0"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.Add, "+"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.Multiply, "*"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.Subtract, "-"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.Divide, "/"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.NumPad0, "NumPad0"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.NumPad1, "NumPad1"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.NumPad2, "NumPad2"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.NumPad3, "NumPad3"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.NumPad4, "NumPad4"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.NumPad5, "NumPad5"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.NumPad6, "NumPad6"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.NumPad7, "NumPad7"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.NumPad8, "NumPad8"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.NumPad9, "NumPad9"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.Decimal, "Decimal"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.A, "A"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.B, "B"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.C, "C"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.D, "D"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.E, "E"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.F, "F"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.G, "G"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.H, "H"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.I, "I"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.J, "J"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.K, "K"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.L, "L"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.M, "M"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.N, "N"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.O, "O"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.P, "P"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.Q, "Q"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.R, "R"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.S, "S"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.U, "U"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.V, "V"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.W, "W"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.X, "X"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.Y, "Y"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.Z, "Z"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.F2, "F2"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.F3, "F3"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.F4, "F4"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.F5, "F5"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.F6, "F6"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.F7, "F7"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.F8, "F8"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.F9, "F9"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.F10, "F10"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.F11, "F11"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.F12, "F12"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.Insert, "Insert"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.Delete, "Delete"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.Home, "Home"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.End, "End"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.PageUp, "PageUp"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.PageDown, "PageDown"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.LControlKey, "Left Control"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.RControlKey, "Right Control"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.Up, "Up"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.Down, "Down"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.Left, "Left"))
                ctrl.items.add(New ValueDescriptionPair(System.Windows.Forms.Keys.Right, "Right"))
                Dim optionname As String = ctrl.name.replace("ReactorComboBox", "Key")
                ctrl.text = inisettings.GetString("HotKey", optionname, "N/A")
            ElseIf TypeOf ctrl Is ReactorCheckBox Then
                Dim activation As String = ctrl.name.replace("ReactorCheckBox", "act")
                ctrl.checked = inisettings.GetString("Activate", activation, False)
            End If
        Next
    End Sub
    Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown
        Dim CapTxt As String = GetCaption()
        If CapTxt = "GTA:SA:MP" Then
            If keybinderdisabled = False Then
                If ReactorCheckBox1.Checked = True Then
                    If Key = ReactorComboBox1.SelectedValue Then
                        SendKeys.Send("t" + ReactorTextBox1.Text + "{Enter}")
                    End If
                End If
                If ReactorCheckBox2.Checked = True Then
                    If Key = ReactorComboBox2.SelectedValue Then
                        SendKeys.Send("t" + ReactorTextBox2.Text + "{Enter}")
                    End If
                End If
                If ReactorCheckBox3.Checked = True Then
                    If Key = ReactorComboBox3.SelectedValue Then
                        SendKeys.Send("t" + ReactorTextBox3.Text + "{Enter}")
                    End If
                End If
                If ReactorCheckBox4.Checked = True Then
                    If Key = ReactorComboBox4.SelectedValue Then
                        SendKeys.Send("t" + ReactorTextBox4.Text + "{Enter}")
                    End If
                End If
                If ReactorCheckBox5.Checked = True Then
                    If Key = ReactorComboBox5.SelectedValue Then
                        SendKeys.Send("t" + ReactorTextBox5.Text + "{Enter}")
                    End If
                End If
                If ReactorCheckBox6.Checked = True Then
                    If Key = ReactorComboBox6.SelectedValue Then
                        SendKeys.Send("t" + ReactorTextBox6.Text + "{Enter}")
                    End If
                End If
                If ReactorCheckBox7.Checked = True Then
                    If Key = ReactorComboBox7.SelectedValue Then
                        SendKeys.Send("t" + ReactorTextBox7.Text + "{Enter}")
                    End If
                End If
                If ReactorCheckBox8.Checked = True Then
                    If Key = ReactorComboBox8.SelectedValue Then
                        SendKeys.Send("t" + ReactorTextBox8.Text + "{Enter}")
                    End If
                End If
                If ReactorCheckBox9.Checked = True Then
                    If Key = ReactorComboBox9.SelectedValue Then
                        SendKeys.Send("t" + ReactorTextBox9.Text + "{Enter}")
                    End If
                End If
                If ReactorCheckBox10.Checked = True Then
                    If Key = ReactorComboBox10.SelectedValue Then
                        SendKeys.Send("t" + ReactorTextBox10.Text + "{Enter}")
                    End If
                End If
                If ReactorCheckBox11.Checked = True Then
                    If Key = ReactorComboBox11.SelectedValue Then
                        SendKeys.Send("t" + ReactorTextBox11.Text + "{Enter}")
                    End If
                End If
                If ReactorCheckBox12.Checked = True Then
                    If Key = ReactorComboBox12.SelectedValue Then
                        SendKeys.Send("t" + ReactorTextBox12.Text + "{Enter}")
                    End If
                End If
                If ReactorCheckBox13.Checked = True Then
                    If Key = ReactorComboBox13.SelectedValue Then
                        SendKeys.Send("t" + ReactorTextBox13.Text + "{Enter}")
                    End If
                End If
                If ReactorCheckBox14.Checked = True Then
                    If Key = ReactorComboBox14.SelectedValue Then
                        SendKeys.Send("t" + ReactorTextBox14.Text + "{Enter}")
                    End If
                End If
                If ReactorCheckBox15.Checked = True Then
                    If Key = ReactorComboBox15.SelectedValue Then
                        SendKeys.Send("t" + ReactorTextBox15.Text + "{Enter}")
                    End If
                End If
                If ReactorCheckBox16.Checked = True Then
                    If Key = ReactorComboBox16.SelectedValue Then
                        SendKeys.Send("t" + ReactorTextBox16.Text + "{Enter}")
                    End If
                End If
                If ReactorCheckBox17.Checked = True Then
                    If Key = ReactorComboBox17.SelectedValue Then
                        SendKeys.Send("t" + ReactorTextBox17.Text + "{Enter}")
                    End If
                End If
                If ReactorCheckBox18.Checked = True Then
                    If Key = ReactorComboBox18.SelectedValue Then
                        SendKeys.Send("t" + ReactorTextBox18.Text + "{Enter}")
                    End If
                End If
                If ReactorCheckBox19.Checked = True Then
                    If Key = ReactorComboBox19.SelectedValue Then
                        SendKeys.Send("t" + ReactorTextBox19.Text + "{Enter}")
                    End If
                End If
                If ReactorCheckBox20.Checked = True Then
                    If Key = ReactorComboBox20.SelectedValue Then
                        SendKeys.Send("t" + ReactorTextBox20.Text + "{Enter}")
                    End If
                End If
            End If
        End If
        If Key = System.Windows.Forms.Keys.F6 Then
            keybinderdisabled = True
        End If
        If Key = System.Windows.Forms.Keys.Enter Then
            keybinderdisabled = False
        End If
        If Key = System.Windows.Forms.Keys.Escape Then
            keybinderdisabled = False
        End If
        If Key = System.Windows.Forms.Keys.T Then
            keybinderdisabled = True
        End If
    End Sub
    Private Sub imgLogo2_Click(sender As Object, e As EventArgs) Handles imgLogo2.Click
        Process.Start("http://sacnr.com")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\Keybinds.sav") Then
            IO.File.Delete(Application.StartupPath & "\Keybinds.sav")
        End If
        MsgBox("Default settings restored! Application will now restart", vbInformation, "Success!")
        Application.Restart()
    End Sub
    Sub savesettings()
        For Each ctrl In Me.ReactorTabControl1.TabPages(0).Controls
            If TypeOf ctrl Is ReactorTextBox Then
                Dim optionname As String = ctrl.name.replace("ReactorTextBox", "Send")
                inisettings.WriteString("SendKey", optionname, ctrl.Text)
            End If
            If TypeOf ctrl Is ReactorComboBox Then
                Dim optionname As String = ctrl.name.replace("ReactorComboBox", "Key")
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
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveSettings()
    End Sub

    Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
        Shell(GTALocation)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        savesettings()
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
End Class


Public Class ValueDescriptionPair
    Private m_Value As Object
    Private m_Description As String
    Public ReadOnly Property Value() As Object
        Get
            Return m_Value
        End Get
    End Property
    Public ReadOnly Property Description() As String
        Get
            Return m_Description
        End Get
    End Property
    Public Sub New(ByVal NewValue As Object, ByVal NewDescription As String)
        m_Value = NewValue
        m_Description = NewDescription
    End Sub
    Public Overrides Function ToString() As String
        Return m_Description
    End Function
End Class