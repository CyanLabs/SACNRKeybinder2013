Imports System.Net.Mail

Public Class SettingsPanel

    'Dim loglocation As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\GTA San Andreas User Files\SAMP"
    Private Sub txtFeedback_Enter(sender As Object, e As EventArgs) Handles txtFeedback.Enter
        If sender.text = "Leave feedback or suggest a new feature or change here." Then
            sender.text = ""
        End If
    End Sub
    Private Sub btnSaveRestart_Click(sender As Object, e As EventArgs) Handles btnSaveRestart.Click
        Dim result = MsgBox("This will change the SAMP username." & vbNewLine & "All settings and keybinds will be saved as 'OLDNAME_Keybinds.sav' and a new file called '" & txtSAMPUsername.Text & "_keybinds.sav' will be used. You can switch back to your old username at any time by changing this textbox back." & vbNewLine & vbNewLine & "Are you sure you want to change SAMP Username?", vbYesNo + MsgBoxStyle.Question, "Confirmation")
        If result = vbYes Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\SAMP", "PlayerName", txtSAMPUsername.Text)
            Application.Restart()
        End If
    End Sub

    Private Sub chkEnableLogs_CheckedChanged(sender As Object) Handles chkEnableLogs.CheckedChanged
        Form1.inisettings.WriteString("Settings", "EnableLogManager", sender.checked.ToString)
        If sender.Checked = True Then
            Form1.Timer1.Start()
        Else
            Form1.Timer1.Stop()
        End If
    End Sub
    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        Form1.inisettings.WriteInteger("360", "Interval", sender.value)
    End Sub
    Private Sub txtMacroDelay_TextChanged(sender As Object, e As EventArgs) Handles txtMacroDelay.TextChanged
        If IsNumeric(sender.text) Then
            Form1.inisettings.WriteInteger("Settings", "Delay ", Convert.ToInt32(sender.text))
        Else
            MsgBox("You did not enter a numerical value, please enter only numbers and decimals", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        Try
            'Process.Start("explorer.exe", loglocation & "\Logs")
        Catch ex As Exception
            MsgBox("Log directory could not be opened as the directory does not seem to exist.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnSendRequest_Click(sender As Object, e As EventArgs) Handles btnSendRequest.Click
        Dim emailcontents As String = txtFeedback.Text
        Dim result = MsgBox("This will send the feedback below to CyanLabs." & vbNewLine & vbNewLine & """" & emailcontents & """" & vbNewLine & vbNewLine & "Are you sure?", vbYesNo + MsgBoxStyle.Question, "Confirmation")
        If result = vbYes Then
            result = MsgBox("Do you want to include your SA-MP username with the email?", vbYesNo + MsgBoxStyle.Question, "Confirmation")

            If result = vbYes Then
                emailcontents &= vbNewLine & vbNewLine & "Feedback/Suggestion was posted by """ & txtSAMPUsername.Text & """"
            End If
            Try
                Dim SmtpServer As New SmtpClient()
                Dim mail As New MailMessage()
                SmtpServer.Port = 2525
                SmtpServer.Host = "smtpcorp.com"
                mail = New MailMessage()
                mail.From = New MailAddress("sacnrkeybinder2013@cyanlabs.co.uk")
                mail.To.Add("fma96580@gmail.com")
                mail.Subject = "SACNR Keybinder 2013 Edition - Feedback and Suggestions"
                mail.Body = "New feedback or suggestion for 'SACNR Keybinder 2013 Edition' has been recieved!" & vbNewLine & vbNewLine & emailcontents
                SmtpServer.Send(mail)
                MsgBox("Your feedback has been sent successfully, Thank you for helping make SACNR Keybinder 2013 Edition better!")
            Catch ex As Exception
                MsgBox("The following error occured:" & vbNewLine & vbNewLine & ex.ToString, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim result = MsgBox("Are you sure you wish to reset all settings and keybinds?", vbYesNo + MsgBoxStyle.Question, "Confirmation")
        If result = vbYes Then
            Form1.skipsavesettings = True
            If IO.File.Exists(Application.StartupPath & "\keybinds\" & txtSAMPUsername.Text & "_keybinds.sav") Then IO.File.Delete(Application.StartupPath & "\keybinds\" & txtSAMPUsername.Text & "_keybinds.sav")
            MsgBox("Default settings restored! Application will now restart", vbInformation, "Success!")
            Application.Restart()
        End If
    End Sub
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If sender.value = 9 Then
            txtMacroDelay.Visible = True
            MsgBox("Enter your custom value in miliseconds in the textbox below", MsgBoxStyle.Information, "Information")
        Else
            txtMacroDelay.Visible = False
            Form1.inisettings.WriteInteger("Settings", "MacroDelay", sender.value * 1000)
            txtMacroDelay.Text = Convert.ToInt32(sender.value * 1000)
        End If
    End Sub
    Private Sub chkAutoupdates_CheckedChanged(sender As Object) Handles chkAutoupdates.CheckedChanged
        Form1.inisettings.WriteString("Settings", "AutoUpdate", sender.checked.ToString)
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Form1.savesettings()
    End Sub
    Public Sub LoadSettings()
        chkEnableLogs.Checked = Form1.inisettings.GetString("Settings", "EnableLogManager", False)
        txtSAMPUsername.Text = Form1.SAMPUsername
        chkAutoupdates.Checked = Form1.inisettings.GetString("Settings", "AutoUpdate", False)
        TrackBar1.Value = Form1.inisettings.GetInteger("Settings", "MacroDelay", 0) / 1000
        txtMacroDelay.Text = Convert.ToInt32(Form1.inisettings.GetInteger("Settings", "MacroDelay", 0))
        TrackBar2.Value = Form1.inisettings.GetInteger("360", "Interval", 1)
        If chkEnableLogs.Checked = True Then
            Form1.Timer1.Start()
        Else
            Form1.Timer1.Stop()
        End If
    End Sub
End Class
