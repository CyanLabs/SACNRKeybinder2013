Imports System.Threading
Imports Microsoft.Xna.Framework.Input

Public Class X360Panel
    Private trd2 As Thread
    Private Sub chkEnable360_CheckedChanged(sender As Object) Handles chkEnable360.CheckedChanged
        Form1.inisettings.WriteInteger("360", "MasterToggle", sender.value)
        If sender.Checked = True Then
            Form1.Timer2.Start()
        Else
            Form1.Timer2.Stop()
        End If
    End Sub
    Sub savesettings()
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is ReactorTextBox Then
                Dim optionname As String = ctrl.name.replace("txt", "360")
                Form1.inisettings.WriteString("360", optionname, ctrl.text)
            ElseIf TypeOf ctrl Is ReactorCheckBox Then
                Dim activation As String = ctrl.name.replace("chk", "360act")
                Form1.inisettings.WriteString("360", activation, ctrl.checked.ToString)
            End If
        Next
    End Sub
    Sub LoadSettings()
        Form1.Timer2.Interval = Form1.inisettings.GetInteger("360", "Interval", 1000)
        chkEnable360.Checked = Form1.inisettings.GetString("360", "MasterToggle", False)
        If chkEnable360.Checked = True Then
            Form1.Timer2.Start()
        Else
            Form1.Timer2.Stop()
        End If
    End Sub
    Dim currentState As GamePadState = GamePad.GetState(Microsoft.Xna.Framework.PlayerIndex.One)
    Public Sub Timer2()
        If currentState.IsConnected Then
            If chkButtonA.Checked = True Then
                If currentState.Buttons.A = ButtonState.Pressed Then
                    trd2 = New Thread(AddressOf Form1.macro)
                    trd2.Start(txtButtonA)
                End If
            End If
            If chkButtonX.Checked = True Then
                If currentState.Buttons.X = ButtonState.Pressed Then
                    trd2 = New Thread(AddressOf Form1.macro)
                    trd2.Start(txtButtonX)
                End If
            End If
            If chkButtonY.Checked = True Then
                If currentState.Buttons.Y = ButtonState.Pressed Then
                    trd2 = New Thread(AddressOf Form1.macro)
                    trd2.Start(txtButtonY)
                End If
            End If
            If chkButtonB.Checked = True Then
                If currentState.Buttons.B = ButtonState.Pressed Then
                    trd2 = New Thread(AddressOf Form1.macro)
                    trd2.Start(txtButtonB)
                End If
            End If
            If chkRB.Checked = True Then
                If currentState.Buttons.RightShoulder = ButtonState.Pressed Then
                    trd2 = New Thread(AddressOf Form1.macro)
                    trd2.Start(txtRB)
                End If
            End If
            If chkLB.Checked = True Then
                If currentState.Buttons.LeftShoulder = ButtonState.Pressed Then
                    trd2 = New Thread(AddressOf Form1.macro)
                    trd2.Start(txtLb)
                End If
            End If
            If chkDpadDown.Checked = True Then
                If currentState.DPad.Down = ButtonState.Pressed Then
                    trd2 = New Thread(AddressOf Form1.macro)
                    trd2.Start(txtDpadDown)
                End If
            End If
            If chkDpadLeft.Checked = True Then
                If currentState.DPad.Left = ButtonState.Pressed Then
                    trd2 = New Thread(AddressOf Form1.macro)
                    trd2.Start(txtDpadLeft)
                End If
            End If
            If chkDpadRight.Checked = True Then
                If currentState.DPad.Right = ButtonState.Pressed Then
                    trd2 = New Thread(AddressOf Form1.macro)
                    trd2.Start(txtDpadRight)
                End If
            End If
            If chkDpadUp.Checked = True Then
                If currentState.DPad.Up = ButtonState.Pressed Then
                    trd2 = New Thread(AddressOf Form1.macro)
                    trd2.Start(txtDpadUp)
                End If
            End If
            If chkRightStick.Checked = True Then
                If currentState.Buttons.RightStick = ButtonState.Pressed Then
                    trd2 = New Thread(AddressOf Form1.macro)
                    trd2.Start(txtRightStickPress)
                End If
            End If
            If chkLeftStick.Checked = True Then
                If currentState.Buttons.LeftStick = ButtonState.Pressed Then
                    trd2 = New Thread(AddressOf Form1.macro)
                    trd2.Start(txtLeftStickPress)
                End If
            End If
        End If
    End Sub
End Class
