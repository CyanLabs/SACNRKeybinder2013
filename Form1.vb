Imports System.Threading

Public Class Main
    Dim CurrentVersion As String = "v" & System.Reflection.Assembly.GetEntryAssembly.GetName().Version.ToString
    Dim settings As ini
    Private trd2 As Thread
    Private WithEvents kbHook As New kbhook
    Private Declare Function GetForegroundWindow Lib "user32" Alias "GetForegroundWindow" () As IntPtr
    Private Declare Auto Function GetWindowText Lib "user32" (ByVal hWnd As System.IntPtr, ByVal lpString As System.Text.StringBuilder, ByVal cch As Integer) As Integer
    Dim CapTxt As String = ""
    Dim convertedkeycode As String = ""
    Public Function FixKey(ByVal keycode As Integer)
        Select Case keycode
            Case 48 To 57
                If My.Computer.Keyboard.ShiftKeyDown Then
                    Select Case keycode
                        Case 48
                            convertedkeycode = ")"
                        Case 49
                            convertedkeycode = "!"
                        Case 50
                            convertedkeycode = """"
                        Case 51
                            convertedkeycode = "£"
                        Case 52
                            convertedkeycode = "$"
                        Case 53
                            convertedkeycode = "%"
                        Case 54
                            convertedkeycode = "^"
                        Case 55
                            convertedkeycode = "&"
                        Case 56
                            convertedkeycode = "*"
                        Case 57
                            convertedkeycode = "("
                    End Select
                Else
                    convertedkeycode = Convert.ToChar(keycode)
                End If
            Case 65 To 90
                If My.Computer.Keyboard.ShiftKeyDown Or My.Computer.Keyboard.CapsLock Then
                    convertedkeycode = Convert.ToChar(keycode)
                Else
                    convertedkeycode = Convert.ToChar(keycode + 32)
                End If
            Case 1
                convertedkeycode = ""
                'Case 2
                '    convertedkeycode = "<RCLICK>"
            Case 8
                convertedkeycode = ""
                'Case 9
                '    convertedkeycode = "<TAB>"
            Case 12
                convertedkeycode = "5"
            Case 13
                convertedkeycode = "{ENTER}"
                'Case 17
                '    convertedkeycode = "<CTRL>"
                'Case 18
                '    convertedkeycode = "<ALT>"
                'Case 19
                '    convertedkeycode = "<PAUSE>"
            Case 20
                convertedkeycode = ""
                'Case 27
                '    convertedkeycode = "<ESC>"
            Case 32
                convertedkeycode = " "
                'Case 33
                '    convertedkeycode = "<PAGEUP>"
                'Case 34
                '    convertedkeycode = "<PAGEDOWN>"
                'Case 35
                '    convertedkeycode = "<END>"
                'Case 36
                '    convertedkeycode = "<HOME>"
                'Case 37
                '    convertedkeycode = "<LEFT>"
                'Case 38
                '    convertedkeycode = "<UP>"
                'Case 39
                '    convertedkeycode = "<RIGHT>"
                'Case 40
                '    convertedkeycode = "<DOWN>"
                'Case 44
                '    convertedkeycode = "<PRNTSCRN>"
                'Case 45
                '    convertedkeycode = "<INSERT>"
                'Case 46
                '    convertedkeycode = "<DEL>"
                'Case 47
                '    convertedkeycode = "<HELP>"
                'Case 91
                '    convertedkeycode = "<WIN>"
                'Case 93
                '    convertedkeycode = "<CONTEXT>"
            Case 96
                convertedkeycode = "0"
            Case 97
                convertedkeycode = "1"
            Case 98
                convertedkeycode = "2"
            Case 99
                convertedkeycode = "3"
            Case 100
                convertedkeycode = "4"
            Case 101
                convertedkeycode = "5"
            Case 102
                convertedkeycode = "6"
            Case 103
                convertedkeycode = "7"
            Case 104
                convertedkeycode = "8"
            Case 105
                convertedkeycode = "9"
            Case 106
                convertedkeycode = "*"
            Case 107
                convertedkeycode = "+"
            Case 109
                convertedkeycode = "-"
            Case 110
                convertedkeycode = "."
            Case 111
                convertedkeycode = "/"
            Case 112
                convertedkeycode = "F1"
            Case 113
                convertedkeycode = "F2"
            Case 114
                convertedkeycode = "F3"
            Case 115
                convertedkeycode = "F4"
            Case 116
                convertedkeycode = "F5"
            Case 117
                convertedkeycode = "F6"
            Case 118
                convertedkeycode = "F7"
            Case 119
                convertedkeycode = "F8"
            Case 120
                convertedkeycode = "F9"
            Case 121
                convertedkeycode = "F10"
            Case 122
                convertedkeycode = "F11"
            Case 123
                convertedkeycode = "F12"
                'Case 144
                '    convertedkeycode = "<NUMLOCK>"
                'Case 162
                '    convertedkeycode = "<LCTRL>"
                'Case 163
                '    convertedkeycode = "<RCTRL>"
                'Case 164
                '    convertedkeycode = "<ALT>"
                'Case 165
                '    convertedkeycode = "<ALTGR>"
            Case 186
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = ":"
                Else
                    convertedkeycode = ";"
                End If
            Case 187
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = "+"
                Else
                    convertedkeycode = "="
                End If
            Case 188
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = "<"
                Else
                    convertedkeycode = ","
                End If
            Case 189
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = "_"
                Else
                    convertedkeycode = "-"
                End If
            Case 190
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = ">"
                Else
                    convertedkeycode = "."
                End If
            Case 191
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = "?"
                Else
                    convertedkeycode = "/"
                End If
            Case 192
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = "@"
                Else
                    convertedkeycode = "'"
                End If
            Case 219
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = "{"
                Else
                    convertedkeycode = "["
                End If
            Case 220
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = "|"
                Else
                    convertedkeycode = "\"
                End If
            Case 221
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = "}"
                Else
                    convertedkeycode = "]"
                End If
            Case 222
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = "~"
                Else
                    convertedkeycode = "#"
                End If
            Case 223
                If My.Computer.Keyboard.ShiftKeyDown Then
                    convertedkeycode = "¬"
                Else
                    convertedkeycode = "`"
                End If
            Case Else
                convertedkeycode = ""
        End Select
        Return convertedkeycode
    End Function

    Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown
        'If DebugChkSkipWindowCheck.Checked = True Then
        trd2 = New Thread(AddressOf macro)
        trd2.IsBackground = True
        CapTxt = GetCaption()
        CapTxt = "GTA:SA:MP"
        'End If
        If CapTxt = "GTA:SA:MP" Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("BindEnabled").Value = True Then
                    If Key.ToString.ToUpper = row.Cells("Key").Value.ToUpper Then
                        'trd2.Start(row.Cells("Command").Value)
                        Debug.WriteLine("test")
                    End If
                End If
            Next
        End If
    End Sub
    Private Function GetCaption() As String
        Dim Caption As New System.Text.StringBuilder(256)
        Dim hWnd As IntPtr = GetForegroundWindow()
        GetWindowText(hWnd, Caption, Caption.Capacity)
        Return Caption.ToString()
    End Function
    Dim varchar As Char = "*"
    Sub macro(ByVal Command As String)
        Dim substr As String = Command
        Do
            If substr.Contains(varchar) Then
                Dim subsubstr As String
                subsubstr = substr
                subsubstr = subsubstr.Remove(subsubstr.IndexOf(varchar))
                substr = substr.Replace(subsubstr & varchar, "")
                SendKeys.SendWait("t" + subsubstr + "{Enter}")
                'Thread.Sleep(Convert.ToInt32(txtMacroDelay.Text))
                Thread.Sleep(1000)
            End If
        Loop While substr.Contains(varchar) = True
        SendKeys.SendWait("t" + substr + "{Enter}")
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'SaveBinds(DataGridView1, keybindfile)
        'SaveBinds(DataGridView2, mousebindfile, 1)
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersion.Text = CurrentVersion.ToString
        Dim txtSAMPUsername = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\SAMP", "PlayerName", "Keybinds")
        If Not IO.Directory.Exists(Application.StartupPath & "\keybinds") Then IO.Directory.CreateDirectory(Application.StartupPath & "\keybinds")
        settings = New ini(Application.StartupPath & "\keybinds\" & txtSAMPUsername & "_keybinds.sav")
        DataGridView2.Rows.Add(6)
        DataGridView2.Rows(0).Cells.Item(0).Value = "Left Button"
        DataGridView2.Rows(1).Cells.Item(0).Value = "Right Button"
        DataGridView2.Rows(2).Cells.Item(0).Value = "Middle Button"
        DataGridView2.Rows(3).Cells.Item(0).Value = "Side Button 1"
        DataGridView2.Rows(4).Cells.Item(0).Value = "Side Button 2"
        DataGridView2.Rows(5).Cells.Item(0).Value = "Wheel Up"
        DataGridView2.Rows(6).Cells.Item(0).Value = "Wheel Down"
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.Index = DataGridView1.Rows.Count - 1 Then
                row.Cells(3).Value = "Delete"
            End If
            For Each row2 As DataGridViewRow In DataGridView2.Rows
                If row2.Index > 6 Then
                    DataGridView2.Rows.Remove(row2)
                End If
            Next
        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView2.CellContentClick
        If e.ColumnIndex = 3 Then
            sender.Rows.Remove(sender.CurrentRow)
        End If
    End Sub

    ''' <summary>Load Bind file to datagridview</summary>
    ''' <param name="file">File to load into datagridview</param>
    ''' <param name="DataGridView">datagridview to use</param>
    Private Sub LoadBinds(ByVal file As String, ByVal DataGridView As DataGridView)
    End Sub
    ''' <summary>Load Bind file to datagridview</summary>
    ''' <param name="DataGridView">datagridview to use</param>
    ''' <param name="file">File to save datagridview contents to</param>
    Private Sub SaveBinds(ByVal DataGridView As DataGridView, ByVal file As String, Optional ByVal x As Integer = 2)
    End Sub

    Private Sub DataGridView1_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.UserAddedRow
        sender.CurrentRow.Cells.Item(3).Value = "Delete"
       End Sub

    Private Sub DataGridView1_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowLeave
        settings.WriteString("HotKey", "Key" & e.RowIndex + 1, DataGridView1.CurrentRow.Cells.Item(0).Value)
        settings.WriteString("SendKey", "Send" & e.RowIndex + 1, DataGridView1.CurrentRow.Cells.Item(1).Value)
        settings.WriteBoolean("Activate", "act" & e.RowIndex + 1, DataGridView1.CurrentRow.Cells.Item(2).Value)
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        Button5.BackgroundImage = Global.SACNR_Keybinder_2013_Edition.My.Resources.Resources.buttonbg_hover
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.BackgroundImage = Global.SACNR_Keybinder_2013_Edition.My.Resources.Resources.buttonbg
    End Sub
    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        DataGridView1.CurrentCell.Value = FixKey(e.KeyCode)
    End Sub

End Class