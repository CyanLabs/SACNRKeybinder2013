<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReactorGroupBox9 = New SACNR_Keybinder_Evolution.ReactorGroupBox()
        Me.btnSendRequest = New SACNR_Keybinder_Evolution.ReactorButton()
        Me.ReactorGroupBox6 = New SACNR_Keybinder_Evolution.ReactorGroupBox()
        Me.btnLogs = New SACNR_Keybinder_Evolution.ReactorButton()
        Me.chkEnableLogs = New SACNR_Keybinder_Evolution.ReactorCheckBox()
        Me.ReactorGroupBox8 = New SACNR_Keybinder_Evolution.ReactorGroupBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.ReactorGroupBox7 = New SACNR_Keybinder_Evolution.ReactorGroupBox()
        Me.btnSaveRestart = New SACNR_Keybinder_Evolution.ReactorButton()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtSAMPUsername = New SACNR_Keybinder_Evolution.ReactorTextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.ReactorGroupBox5 = New SACNR_Keybinder_Evolution.ReactorGroupBox()
        Me.btnReset = New SACNR_Keybinder_Evolution.ReactorButton()
        Me.ReactorGroupBox4 = New SACNR_Keybinder_Evolution.ReactorGroupBox()
        Me.txtMacroDelay = New SACNR_Keybinder_Evolution.ReactorTextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.ReactorGroupBox2 = New SACNR_Keybinder_Evolution.ReactorGroupBox()
        Me.chkAutoupdates = New SACNR_Keybinder_Evolution.ReactorCheckBox()
        Me.txtFeedback = New SACNR_Keybinder_Evolution.ReactorMultiLineTextBox()
        Me.ReactorGroupBox9.SuspendLayout()
        Me.ReactorGroupBox6.SuspendLayout()
        Me.ReactorGroupBox8.SuspendLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReactorGroupBox7.SuspendLayout()
        Me.ReactorGroupBox5.SuspendLayout()
        Me.ReactorGroupBox4.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReactorGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(549, 23)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Tweak Settings!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ReactorGroupBox9
        '
        Me.ReactorGroupBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ReactorGroupBox9.Controls.Add(Me.txtFeedback)
        Me.ReactorGroupBox9.Controls.Add(Me.btnSendRequest)
        Me.ReactorGroupBox9.Location = New System.Drawing.Point(0, 246)
        Me.ReactorGroupBox9.Name = "ReactorGroupBox9"
        Me.ReactorGroupBox9.Size = New System.Drawing.Size(542, 85)
        Me.ReactorGroupBox9.TabIndex = 137
        Me.ReactorGroupBox9.Text = "Feedback and Suggestions"
        '
        'btnSendRequest
        '
        Me.btnSendRequest.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnSendRequest.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendRequest.Location = New System.Drawing.Point(456, 26)
        Me.btnSendRequest.Name = "btnSendRequest"
        Me.btnSendRequest.Size = New System.Drawing.Size(83, 57)
        Me.btnSendRequest.TabIndex = 57
        Me.btnSendRequest.Text = "Submit Feedback"
        '
        'ReactorGroupBox6
        '
        Me.ReactorGroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ReactorGroupBox6.Controls.Add(Me.btnLogs)
        Me.ReactorGroupBox6.Controls.Add(Me.chkEnableLogs)
        Me.ReactorGroupBox6.Location = New System.Drawing.Point(0, 63)
        Me.ReactorGroupBox6.Name = "ReactorGroupBox6"
        Me.ReactorGroupBox6.Size = New System.Drawing.Size(139, 93)
        Me.ReactorGroupBox6.TabIndex = 136
        Me.ReactorGroupBox6.Text = "Log Management"
        '
        'btnLogs
        '
        Me.btnLogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnLogs.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogs.Location = New System.Drawing.Point(10, 60)
        Me.btnLogs.Name = "btnLogs"
        Me.btnLogs.Size = New System.Drawing.Size(125, 30)
        Me.btnLogs.TabIndex = 57
        Me.btnLogs.Text = "Open Log Folder"
        '
        'chkEnableLogs
        '
        Me.chkEnableLogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.chkEnableLogs.Checked = False
        Me.chkEnableLogs.ForeColor = System.Drawing.Color.White
        Me.chkEnableLogs.Location = New System.Drawing.Point(14, 30)
        Me.chkEnableLogs.Name = "chkEnableLogs"
        Me.chkEnableLogs.Size = New System.Drawing.Size(126, 16)
        Me.chkEnableLogs.TabIndex = 3
        Me.chkEnableLogs.Text = "Copy logs to ""\Logs"""
        '
        'ReactorGroupBox8
        '
        Me.ReactorGroupBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ReactorGroupBox8.Controls.Add(Me.Label59)
        Me.ReactorGroupBox8.Controls.Add(Me.Label58)
        Me.ReactorGroupBox8.Controls.Add(Me.Label60)
        Me.ReactorGroupBox8.Controls.Add(Me.Label57)
        Me.ReactorGroupBox8.Controls.Add(Me.Label65)
        Me.ReactorGroupBox8.Controls.Add(Me.Label66)
        Me.ReactorGroupBox8.Controls.Add(Me.TrackBar2)
        Me.ReactorGroupBox8.Location = New System.Drawing.Point(145, 63)
        Me.ReactorGroupBox8.Name = "ReactorGroupBox8"
        Me.ReactorGroupBox8.Size = New System.Drawing.Size(156, 93)
        Me.ReactorGroupBox8.TabIndex = 135
        Me.ReactorGroupBox8.Text = "                                    360 Controller Settings"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.ForeColor = System.Drawing.Color.White
        Me.Label59.Location = New System.Drawing.Point(65, 70)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(25, 13)
        Me.Label59.TabIndex = 62
        Me.Label59.Text = "300"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.ForeColor = System.Drawing.Color.White
        Me.Label58.Location = New System.Drawing.Point(37, 70)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(25, 13)
        Me.Label58.TabIndex = 62
        Me.Label58.Text = "200"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.ForeColor = System.Drawing.Color.White
        Me.Label60.Location = New System.Drawing.Point(121, 70)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(25, 13)
        Me.Label60.TabIndex = 61
        Me.Label60.Text = "500"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.ForeColor = System.Drawing.Color.White
        Me.Label57.Location = New System.Drawing.Point(93, 70)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(25, 13)
        Me.Label57.TabIndex = 61
        Me.Label57.Text = "400"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.ForeColor = System.Drawing.Color.White
        Me.Label65.Location = New System.Drawing.Point(10, 70)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(25, 13)
        Me.Label65.TabIndex = 57
        Me.Label65.Text = "100"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.ForeColor = System.Drawing.Color.White
        Me.Label66.Location = New System.Drawing.Point(4, 26)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(138, 13)
        Me.Label66.TabIndex = 53
        Me.Label66.Text = "Check interval (miliseconds)"
        '
        'TrackBar2
        '
        Me.TrackBar2.AutoSize = False
        Me.TrackBar2.LargeChange = 1
        Me.TrackBar2.Location = New System.Drawing.Point(14, 44)
        Me.TrackBar2.Maximum = 4
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(129, 44)
        Me.TrackBar2.TabIndex = 56
        '
        'ReactorGroupBox7
        '
        Me.ReactorGroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ReactorGroupBox7.Controls.Add(Me.btnSaveRestart)
        Me.ReactorGroupBox7.Controls.Add(Me.Label33)
        Me.ReactorGroupBox7.Controls.Add(Me.txtSAMPUsername)
        Me.ReactorGroupBox7.Controls.Add(Me.Label32)
        Me.ReactorGroupBox7.Location = New System.Drawing.Point(0, 159)
        Me.ReactorGroupBox7.Name = "ReactorGroupBox7"
        Me.ReactorGroupBox7.Size = New System.Drawing.Size(394, 81)
        Me.ReactorGroupBox7.TabIndex = 134
        Me.ReactorGroupBox7.Text = "Username Settings"
        '
        'btnSaveRestart
        '
        Me.btnSaveRestart.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnSaveRestart.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveRestart.Location = New System.Drawing.Point(306, 27)
        Me.btnSaveRestart.Name = "btnSaveRestart"
        Me.btnSaveRestart.Size = New System.Drawing.Size(88, 49)
        Me.btnSaveRestart.TabIndex = 56
        Me.btnSaveRestart.Text = "Save And Restart"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(13, 31)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(276, 13)
        Me.Label33.TabIndex = 6
        Me.Label33.Text = "Changes SAMP Username and name of keybinds.sav file"
        '
        'txtSAMPUsername
        '
        Me.txtSAMPUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txtSAMPUsername.ForeColor = System.Drawing.Color.White
        Me.txtSAMPUsername.Location = New System.Drawing.Point(105, 54)
        Me.txtSAMPUsername.MaxCharacters = 32767
        Me.txtSAMPUsername.Name = "txtSAMPUsername"
        Me.txtSAMPUsername.Size = New System.Drawing.Size(199, 23)
        Me.txtSAMPUsername.TabIndex = 5
        Me.txtSAMPUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSAMPUsername.UsePasswordMask = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(11, 59)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(94, 13)
        Me.Label32.TabIndex = 4
        Me.Label32.Text = "SAMP Username: "
        '
        'ReactorGroupBox5
        '
        Me.ReactorGroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ReactorGroupBox5.Controls.Add(Me.btnReset)
        Me.ReactorGroupBox5.Location = New System.Drawing.Point(469, 63)
        Me.ReactorGroupBox5.Name = "ReactorGroupBox5"
        Me.ReactorGroupBox5.Size = New System.Drawing.Size(73, 93)
        Me.ReactorGroupBox5.TabIndex = 133
        Me.ReactorGroupBox5.Text = "Reset"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnReset.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(2, 25)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(70, 67)
        Me.btnReset.TabIndex = 56
        Me.btnReset.Text = "Reset Keybinds"
        '
        'ReactorGroupBox4
        '
        Me.ReactorGroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ReactorGroupBox4.Controls.Add(Me.txtMacroDelay)
        Me.ReactorGroupBox4.Controls.Add(Me.Label24)
        Me.ReactorGroupBox4.Controls.Add(Me.TrackBar1)
        Me.ReactorGroupBox4.Controls.Add(Me.Label41)
        Me.ReactorGroupBox4.Controls.Add(Me.Label40)
        Me.ReactorGroupBox4.Controls.Add(Me.Label39)
        Me.ReactorGroupBox4.Controls.Add(Me.Label38)
        Me.ReactorGroupBox4.Controls.Add(Me.Label35)
        Me.ReactorGroupBox4.Controls.Add(Me.Label37)
        Me.ReactorGroupBox4.Controls.Add(Me.Label34)
        Me.ReactorGroupBox4.Controls.Add(Me.Label36)
        Me.ReactorGroupBox4.Controls.Add(Me.Label25)
        Me.ReactorGroupBox4.Controls.Add(Me.Label49)
        Me.ReactorGroupBox4.Controls.Add(Me.Label61)
        Me.ReactorGroupBox4.Location = New System.Drawing.Point(307, 63)
        Me.ReactorGroupBox4.Name = "ReactorGroupBox4"
        Me.ReactorGroupBox4.Size = New System.Drawing.Size(156, 93)
        Me.ReactorGroupBox4.TabIndex = 132
        Me.ReactorGroupBox4.Text = "Macro Settings"
        '
        'txtMacroDelay
        '
        Me.txtMacroDelay.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txtMacroDelay.ForeColor = System.Drawing.Color.White
        Me.txtMacroDelay.Location = New System.Drawing.Point(21, 67)
        Me.txtMacroDelay.MaxCharacters = 4
        Me.txtMacroDelay.Name = "txtMacroDelay"
        Me.txtMacroDelay.Size = New System.Drawing.Size(117, 23)
        Me.txtMacroDelay.TabIndex = 62
        ' Me.txtMacroDelay.Text = "1000"
        Me.txtMacroDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtMacroDelay.UsePasswordMask = False
        Me.txtMacroDelay.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(19, 25)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(116, 13)
        Me.Label24.TabIndex = 53
        Me.Label24.Text = "Macro Delay (seconds)"
        '
        'TrackBar1
        '
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.LargeChange = 1
        Me.TrackBar1.Location = New System.Drawing.Point(8, 35)
        Me.TrackBar1.Maximum = 9
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(140, 22)
        Me.TrackBar1.TabIndex = 56
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.ForeColor = System.Drawing.Color.White
        Me.Label41.Location = New System.Drawing.Point(119, 55)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(13, 13)
        Me.Label41.TabIndex = 61
        Me.Label41.Text = "8"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(107, 55)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(13, 13)
        Me.Label40.TabIndex = 60
        Me.Label40.Text = "7"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(92, 55)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(13, 13)
        Me.Label39.TabIndex = 59
        Me.Label39.Text = "6"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(80, 55)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(13, 13)
        Me.Label38.TabIndex = 58
        Me.Label38.Text = "5"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(40, 55)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(13, 13)
        Me.Label35.TabIndex = 58
        Me.Label35.Text = "2"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(66, 55)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(13, 13)
        Me.Label37.TabIndex = 57
        Me.Label37.Text = "4"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(26, 55)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(13, 13)
        Me.Label34.TabIndex = 57
        Me.Label34.Text = "1"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(54, 55)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(13, 13)
        Me.Label36.TabIndex = 57
        Me.Label36.Text = "3"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(13, 55)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(13, 13)
        Me.Label25.TabIndex = 57
        Me.Label25.Text = "0"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.ForeColor = System.Drawing.Color.White
        Me.Label49.Location = New System.Drawing.Point(132, 55)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(14, 13)
        Me.Label49.TabIndex = 63
        Me.Label49.Text = "C"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.ForeColor = System.Drawing.Color.White
        Me.Label61.Location = New System.Drawing.Point(22, 74)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(107, 13)
        Me.Label61.TabIndex = 64
        Me.Label61.Text = "Set to ""C"" for custom"
        '
        'ReactorGroupBox2
        '
        Me.ReactorGroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ReactorGroupBox2.Controls.Add(Me.chkAutoupdates)
        Me.ReactorGroupBox2.Location = New System.Drawing.Point(397, 160)
        Me.ReactorGroupBox2.Name = "ReactorGroupBox2"
        Me.ReactorGroupBox2.Size = New System.Drawing.Size(145, 81)
        Me.ReactorGroupBox2.TabIndex = 131
        Me.ReactorGroupBox2.Text = "                           Miscellaneous Settings"
        '
        'chkAutoupdates
        '
        Me.chkAutoupdates.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.chkAutoupdates.Checked = False
        Me.chkAutoupdates.ForeColor = System.Drawing.Color.White
        Me.chkAutoupdates.Location = New System.Drawing.Point(13, 41)
        Me.chkAutoupdates.Name = "chkAutoupdates"
        Me.chkAutoupdates.Size = New System.Drawing.Size(126, 16)
        Me.chkAutoupdates.TabIndex = 2
        Me.chkAutoupdates.Text = "Enable AutoUpdates"
        '
        'txtFeedback
        '
        Me.txtFeedback.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txtFeedback.ForeColor = System.Drawing.Color.White
        Me.txtFeedback.Location = New System.Drawing.Point(5, 26)
        Me.txtFeedback.MaxCharacters = 32767
        Me.txtFeedback.Name = "txtFeedback"
        Me.txtFeedback.Size = New System.Drawing.Size(450, 56)
        Me.txtFeedback.TabIndex = 58
        Me.txtFeedback.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'SettingsPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.ReactorGroupBox9)
        Me.Controls.Add(Me.ReactorGroupBox6)
        Me.Controls.Add(Me.ReactorGroupBox8)
        Me.Controls.Add(Me.ReactorGroupBox7)
        Me.Controls.Add(Me.ReactorGroupBox5)
        Me.Controls.Add(Me.ReactorGroupBox4)
        Me.Controls.Add(Me.ReactorGroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "SettingsPanel"
        Me.Size = New System.Drawing.Size(550, 430)
        Me.ReactorGroupBox9.ResumeLayout(False)
        Me.ReactorGroupBox6.ResumeLayout(False)
        Me.ReactorGroupBox8.ResumeLayout(False)
        Me.ReactorGroupBox8.PerformLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReactorGroupBox7.ResumeLayout(False)
        Me.ReactorGroupBox7.PerformLayout()
        Me.ReactorGroupBox5.ResumeLayout(False)
        Me.ReactorGroupBox4.ResumeLayout(False)
        Me.ReactorGroupBox4.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReactorGroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReactorGroupBox9 As SACNR_Keybinder_Evolution.ReactorGroupBox
    ' Friend WithEvents txtFeedback As SACNR_Keybinder_2013_Edition.ReactorMultiLineTextBox
    Friend WithEvents btnSendRequest As SACNR_Keybinder_Evolution.ReactorButton
    Friend WithEvents ReactorGroupBox6 As SACNR_Keybinder_Evolution.ReactorGroupBox
    Friend WithEvents btnLogs As SACNR_Keybinder_Evolution.ReactorButton
    Friend WithEvents chkEnableLogs As SACNR_Keybinder_Evolution.ReactorCheckBox
    Friend WithEvents ReactorGroupBox8 As SACNR_Keybinder_Evolution.ReactorGroupBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents TrackBar2 As System.Windows.Forms.TrackBar
    Friend WithEvents ReactorGroupBox7 As SACNR_Keybinder_Evolution.ReactorGroupBox
    Friend WithEvents btnSaveRestart As SACNR_Keybinder_Evolution.ReactorButton
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtSAMPUsername As SACNR_Keybinder_Evolution.ReactorTextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents ReactorGroupBox5 As SACNR_Keybinder_Evolution.ReactorGroupBox
    Friend WithEvents btnReset As SACNR_Keybinder_Evolution.ReactorButton
    Friend WithEvents ReactorGroupBox4 As SACNR_Keybinder_Evolution.ReactorGroupBox
    Friend WithEvents txtMacroDelay As SACNR_Keybinder_Evolution.ReactorTextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents ReactorGroupBox2 As SACNR_Keybinder_Evolution.ReactorGroupBox
    Friend WithEvents chkAutoupdates As SACNR_Keybinder_Evolution.ReactorCheckBox
    Friend WithEvents txtFeedback As SACNR_Keybinder_Evolution.ReactorMultiLineTextBox

End Class
