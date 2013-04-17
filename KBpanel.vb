Imports System.Threading

Public Class KBPanel
    Private trd2 As Thread
    Dim keybinderdisabled As Boolean = False
    Dim captxt As String = ""
    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox9.KeyDown, TextBox8.KeyDown, TextBox7.KeyDown, TextBox6.KeyDown, TextBox5.KeyDown, TextBox4.KeyDown, TextBox3.KeyDown, TextBox2.KeyDown, TextBox10.KeyDown, TextBox1.KeyDown
        sender.text = ""
        sender.tag = e.KeyCode
        sender.text = e.KeyCode.ToString.ToUpper
        e.SuppressKeyPress = True
    End Sub
    Dim param_obj(2) As Object
    Public Sub kbHook(ByVal Key As System.Windows.Forms.Keys)
        trd2 = New Thread(AddressOf Form1.macro)
        trd2.IsBackground = True
        If Form1.DebugCheck() = "GTA:SA:MP" Then
            If keybinderdisabled = False Then
                param_obj(0) = Key.ToString.ToUpper
                If ReactorCheckBox1.Checked = True Then
                    If Key.ToString.ToUpper = TextBox1.Text.ToUpper Then
                        param_obj(1) = ReactorTextBox1.Text
                        trd2.Start(param_obj)
                    End If
                End If
                If ReactorCheckBox2.Checked = True Then
                    If Key.ToString.ToUpper = TextBox2.Text.ToUpper Then
                        param_obj(1) = ReactorTextBox2.Text
                        trd2.Start(param_obj)
                    End If
                End If
                If ReactorCheckBox3.Checked = True Then
                    If Key.ToString.ToUpper = TextBox3.Text.ToUpper Then
                        param_obj(1) = ReactorTextBox3.Text
                        trd2.Start(param_obj)
                    End If
                End If
                If ReactorCheckBox4.Checked = True Then
                    If Key.ToString.ToUpper = TextBox4.Text.ToUpper Then
                        param_obj(1) = ReactorTextBox4.Text
                        trd2.Start(param_obj)
                    End If
                End If
                If ReactorCheckBox5.Checked = True Then
                    If Key.ToString.ToUpper = TextBox5.Text.ToUpper Then
                        param_obj(1) = ReactorTextBox5.Text
                        trd2.Start(param_obj)
                    End If
                End If
                If ReactorCheckBox6.Checked = True Then
                    If Key.ToString.ToUpper = TextBox6.Text.ToUpper Then
                        param_obj(1) = ReactorTextBox6.Text
                        trd2.Start(param_obj)
                    End If
                End If
                If ReactorCheckBox7.Checked = True Then
                    If Key.ToString.ToUpper = TextBox7.Text.ToUpper Then
                        param_obj(1) = ReactorTextBox7.Text
                        trd2.Start(param_obj)
                    End If
                End If
                If ReactorCheckBox8.Checked = True Then
                    If Key.ToString.ToUpper = TextBox8.Text.ToUpper Then
                        param_obj(1) = ReactorTextBox8.Text
                        trd2.Start(param_obj)
                    End If
                End If
                If ReactorCheckBox9.Checked = True Then
                    If Key.ToString.ToUpper = TextBox9.Text.ToUpper Then
                        param_obj(1) = ReactorTextBox9.Text
                        trd2.Start(param_obj)
                    End If
                End If
                If ReactorCheckBox10.Checked = True Then
                    If Key.ToString.ToUpper = TextBox10.Text.ToUpper Then
                        param_obj(1) = ReactorTextBox10.Text
                        trd2.Start(param_obj)
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
End Class
