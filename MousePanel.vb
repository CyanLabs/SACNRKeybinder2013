Imports System.Threading

Public Class MousePanel
    Public WithEvents mHook As MouseHook
    Private trd2 As Thread
    Dim captxt As String = ""
    Private Sub mHook_Mouse_Down(ByVal button As String) Handles mHook.Mouse_Down
        trd2 = New Thread(AddressOf Form1.macro)
        trd2.IsBackground = True
If Form1.DebugCheck() = "GTA:SA:MP" Then
            For Each ctrl In Me.Controls
                If TypeOf ctrl Is ReactorTextBox Then
                    If ctrl.Name.Replace("txt", "") = button Then
                        Dim param_obj(2) As Object
                        param_obj(0) = button.ToString
                        param_obj(1) = ctrl.text
                        trd2.Start(param_obj)
                    End If
                End If
            Next
        End If
    End Sub
    Sub loadsettings()
        mHook = New MouseHook
        txtlmb.Text = Form1.inisettings.GetString("Mouse", "LeftClick", Nothing)
        txtRMB.Text = Form1.inisettings.GetString("Mouse", "RightClick", Nothing)
        txtMMB.Text = Form1.inisettings.GetString("Mouse", "MiddleClick", Nothing)
        txtWheelUp.Text = Form1.inisettings.GetString("Mouse", "WheelUp", Nothing)
        txtWheelDown.Text = Form1.inisettings.GetString("Mouse", "WheelDown", Nothing)
        txtSB1.Text = Form1.inisettings.GetString("Mouse", "SB1Click", Nothing)
        txtSB2.Text = Form1.inisettings.GetString("Mouse", "SB2Click", Nothing)
        chkLMB.Checked = Form1.inisettings.GetString("Mouse", "LeftClickActivated", False)
        chkRMB.Checked = Form1.inisettings.GetString("Mouse", "RightClickActivated", False)
        chkMMB.Checked = Form1.inisettings.GetString("Mouse", "MiddleClickActivated", False)
        chkWheelUp.Checked = Form1.inisettings.GetString("Mouse", "WheelUpActivated", False)
        chkWheelDown.Checked = Form1.inisettings.GetString("Mouse", "WheelDownActivated", False)
        chkSB1.Checked = Form1.inisettings.GetString("Mouse", "SB1ClickActivated", False)
        chkSB2.Checked = Form1.inisettings.GetString("Mouse", "SB2ClickActivated", False)
    End Sub
    Sub savesettings()
        Form1.inisettings.WriteString("Mouse", "LeftClick", txtlmb.Text)
        Form1.inisettings.WriteString("Mouse", "RightClick", txtRMB.Text)
        Form1.inisettings.WriteString("Mouse", "MiddleClick", txtMMB.Text)
        Form1.inisettings.WriteString("Mouse", "WheelUp", txtWheelUp.Text)
        Form1.inisettings.WriteString("Mouse", "WheelDown", txtWheelDown.Text)
        Form1.inisettings.WriteString("Mouse", "SB1Click", txtSB1.Text)
        Form1.inisettings.WriteString("Mouse", "SB2Click", txtSB2.Text)
        Form1.inisettings.WriteString("Mouse", "LeftClickActivated", chkLMB.Checked.ToString)
        Form1.inisettings.WriteString("Mouse", "RightClickActivated", chkRMB.Checked.ToString)
        Form1.inisettings.WriteString("Mouse", "MiddleClickActivated", chkmMB.Checked.ToString)
        Form1.inisettings.WriteString("Mouse", "WheelUpActivated", chkwheelup.Checked.ToString)
        Form1.inisettings.WriteString("Mouse", "WheelDownActivated", chkwheeldown.Checked.ToString)
        Form1.inisettings.WriteString("Mouse", "SB1ClickActivated", chksb1.Checked.ToString)
        Form1.inisettings.WriteString("Mouse", "SB2ClickActivated", chksb2.Checked.ToString)
    End Sub
    'Private Sub MousePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'chkLMB.Checked = Form1.inisettings.GetString("Mouse", "LeftClickActivated", False)
        'chkRMB.Checked = Form1.inisettings.GetString("Mouse", "RightClickActivated", False)
        'chkMMB.Checked = Form1.inisettings.GetString("Mouse", "MiddleClickActivated", False)
        'chkWheelUp.Checked = Form1.inisettings.GetString("Mouse", "WheelUpActivated", False)
        'chkWheelDown.Checked = Form1.inisettings.GetString("Mouse", "WheelDownActivated", False)
        'chkSB1.Checked = Form1.inisettings.GetString("Mouse", "SB1ClickActivated", False)
        'chkSB2.Checked = Form1.inisettings.GetString("Mouse", "SB2ClickActivated", False)
    'End Sub
End Class
