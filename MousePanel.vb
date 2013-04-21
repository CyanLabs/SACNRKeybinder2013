Imports System.Threading

Public Class MousePanel
    Public WithEvents mHook As New MouseHook
    Dim keybinderdisabled As Boolean = keybinderdisabled
    Private trd2 As Thread
    '    Private Sub mHook_Mouse_Down(ByVal button As String) Handles mHook.Mouse_Down
    '        trd2 = New Thread(AddressOf Form1.macro)
    '        trd2.IsBackground = True
    'If Form1.DebugCheck() = "GTA:SA:MP" Then
    '            For Each ctrl In Me.Controls
    '                If TypeOf ctrl Is ReactorTextBox Then
    '                    If ctrl.Name.Replace("txt", "") = button Then
    '                        Dim param_obj(2) As Object
    '                        param_obj(0) = button.ToString
    '                        param_obj(1) = ctrl.text
    '                        trd2.Start(param_obj)
    '                    End If
    '                End If
    '            Next
    '        End If
    '    End Sub

    Public Sub Mouse_Left()
        trd2 = New Thread(AddressOf Form1.macro)
        trd2.IsBackground = True
        If keybinderdisabled = False Then
            If chkLMB.Checked = True Then
                Dim param_obj(2) As Object
                param_obj(0) = "lmb"
                param_obj(1) = txtlmb.Text
                trd2.Start(param_obj)
            End If
        End If
    End Sub

    Public Sub Mouse_Middle()
        trd2 = New Thread(AddressOf Form1.macro)
        trd2.IsBackground = True
        If keybinderdisabled = False Then
            If chkMMB.Checked = True Then
                Dim param_obj(2) As Object
                param_obj(0) = "mmb"
                param_obj(1) = txtMMB.Text
                trd2.Start(param_obj)
            End If
        End If
    End Sub
    Public Sub Mouse_Right()
        trd2 = New Thread(AddressOf Form1.macro)
        trd2.IsBackground = True
        If keybinderdisabled = False Then
            If chkRMB.Checked = True Then
                Dim param_obj(2) As Object
                param_obj(0) = "rmb"
                param_obj(1) = txtRMB.Text
                trd2.Start(param_obj)
            End If
        End If
    End Sub

    Public Sub Mouse_Wheel(ByVal Direction As MouseHook.Wheel_Direction)
        trd2 = New Thread(AddressOf Form1.macro)
        trd2.IsBackground = True
        If keybinderdisabled = False Then
            If Direction.ToString = "WheelUp" Then
                If chkWheelUp.Checked = True Then
                    Dim param_obj(2) As Object
                    param_obj(0) = "wheelup"
                    param_obj(1) = txtWheelUp.Text
                    trd2.Start(param_obj)
                End If
            Else
                If chkWheelDown.Checked = True Then
                    Dim param_obj(2) As Object
                    param_obj(0) = "wheeldown"
                    param_obj(1) = txtWheelDown.Text
                    trd2.Start(param_obj)
                End If
            End If
        End If
    End Sub
    Public Sub Mouse_XButton1()
        trd2 = New Thread(AddressOf Form1.macro)
        trd2.IsBackground = True
        If keybinderdisabled = False Then
            If chkSB1.Checked = True Then
                Dim param_obj(2) As Object
                param_obj(0) = "sb1"
                param_obj(1) = txtSB1.Text
                trd2.Start(param_obj)
            End If
        End If

    End Sub
    Public Sub Mouse_XButton2()
        trd2 = New Thread(AddressOf Form1.macro)
        trd2.IsBackground = True
        If keybinderdisabled = False Then
            If chkSB2.Checked = True Then
                Dim param_obj(2) As Object
                param_obj(0) = "sb2"
                param_obj(1) = txtSB2.Text
                trd2.Start(param_obj)
            End If
        End If
    End Sub

    Sub loadsettings()
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
