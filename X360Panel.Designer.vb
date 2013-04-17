<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class X360Panel
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.chkEnable360 = New SACNR_Keybinder_Evolution.ReactorCheckBox()
        Me.chkLeftStick = New SACNR_Keybinder_Evolution.ReactorCheckBox()
        Me.chkDpadLeft = New SACNR_Keybinder_Evolution.ReactorCheckBox()
        Me.chkButtonX = New SACNR_Keybinder_Evolution.ReactorCheckBox()
        Me.chkLB = New SACNR_Keybinder_Evolution.ReactorCheckBox()
        Me.chkDpadUp = New SACNR_Keybinder_Evolution.ReactorCheckBox()
        Me.chkButtonA = New SACNR_Keybinder_Evolution.ReactorCheckBox()
        Me.chkRightStick = New SACNR_Keybinder_Evolution.ReactorCheckBox()
        Me.chkDpadRight = New SACNR_Keybinder_Evolution.ReactorCheckBox()
        Me.chkButtonY = New SACNR_Keybinder_Evolution.ReactorCheckBox()
        Me.chkRB = New SACNR_Keybinder_Evolution.ReactorCheckBox()
        Me.chkDpadDown = New SACNR_Keybinder_Evolution.ReactorCheckBox()
        Me.chkButtonB = New SACNR_Keybinder_Evolution.ReactorCheckBox()
        Me.txtLeftStickPress = New SACNR_Keybinder_Evolution.ReactorTextBox()
        Me.txtDpadLeft = New SACNR_Keybinder_Evolution.ReactorTextBox()
        Me.txtButtonX = New SACNR_Keybinder_Evolution.ReactorTextBox()
        Me.txtRightStickPress = New SACNR_Keybinder_Evolution.ReactorTextBox()
        Me.txtDpadRight = New SACNR_Keybinder_Evolution.ReactorTextBox()
        Me.txtButtonY = New SACNR_Keybinder_Evolution.ReactorTextBox()
        Me.txtLb = New SACNR_Keybinder_Evolution.ReactorTextBox()
        Me.txtRB = New SACNR_Keybinder_Evolution.ReactorTextBox()
        Me.txtDpadUp = New SACNR_Keybinder_Evolution.ReactorTextBox()
        Me.txtDpadDown = New SACNR_Keybinder_Evolution.ReactorTextBox()
        Me.txtButtonA = New SACNR_Keybinder_Evolution.ReactorTextBox()
        Me.txtButtonB = New SACNR_Keybinder_Evolution.ReactorTextBox()
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
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Manage X360 Controller Binds!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.White
        Me.Label56.Location = New System.Drawing.Point(26, 361)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(69, 17)
        Me.Label56.TabIndex = 165
        Me.Label56.Text = "Right Stick:"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.White
        Me.Label52.Location = New System.Drawing.Point(26, 266)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(70, 17)
        Me.Label52.TabIndex = 164
        Me.Label52.Text = "Dpad Right:"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.White
        Me.Label43.Location = New System.Drawing.Point(40, 169)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(57, 17)
        Me.Label43.TabIndex = 163
        Me.Label43.Text = "Button  Y:"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.White
        Me.Label55.Location = New System.Drawing.Point(11, 313)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(85, 17)
        Me.Label55.TabIndex = 162
        Me.Label55.Text = "Right Bumper:"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.Location = New System.Drawing.Point(26, 217)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(71, 17)
        Me.Label46.TabIndex = 161
        Me.Label46.Text = "Dpad Down:"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.White
        Me.Label47.Location = New System.Drawing.Point(41, 121)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(58, 17)
        Me.Label47.TabIndex = 160
        Me.Label47.Text = "Button  B:"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.White
        Me.Label54.Location = New System.Drawing.Point(35, 337)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(60, 17)
        Me.Label54.TabIndex = 154
        Me.Label54.Text = "Left Stick:"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.White
        Me.Label45.Location = New System.Drawing.Point(35, 241)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(61, 17)
        Me.Label45.TabIndex = 155
        Me.Label45.Text = "Dpad Left:"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Location = New System.Drawing.Point(42, 145)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(56, 17)
        Me.Label42.TabIndex = 159
        Me.Label42.Text = "Button  X:"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.White
        Me.Label53.Location = New System.Drawing.Point(20, 289)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(76, 17)
        Me.Label53.TabIndex = 156
        Me.Label53.Text = "Left Bumper:"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(42, 193)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(55, 17)
        Me.Label44.TabIndex = 157
        Me.Label44.Text = "Dpad Up:"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(41, 97)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(58, 17)
        Me.Label48.TabIndex = 158
        Me.Label48.Text = "Button  A:"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.White
        Me.Label50.Location = New System.Drawing.Point(102, 72)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(93, 17)
        Me.Label50.TabIndex = 153
        Me.Label50.Text = "Enter Command"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.White
        Me.Label51.Location = New System.Drawing.Point(491, 72)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(45, 17)
        Me.Label51.TabIndex = 152
        Me.Label51.Text = "Enable"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(287, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 13)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "Enable Xbox 360 Controller Binds"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'chkEnable360
        '
        Me.chkEnable360.BackColor = System.Drawing.Color.Black
        Me.chkEnable360.Checked = False
        Me.chkEnable360.ForeColor = System.Drawing.Color.White
        Me.chkEnable360.Location = New System.Drawing.Point(271, 72)
        Me.chkEnable360.Name = "chkEnable360"
        Me.chkEnable360.Size = New System.Drawing.Size(16, 16)
        Me.chkEnable360.TabIndex = 166
        '
        'chkLeftStick
        '
        Me.chkLeftStick.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.chkLeftStick.Checked = False
        Me.chkLeftStick.ForeColor = System.Drawing.Color.White
        Me.chkLeftStick.Location = New System.Drawing.Point(504, 338)
        Me.chkLeftStick.Name = "chkLeftStick"
        Me.chkLeftStick.Size = New System.Drawing.Size(15, 16)
        Me.chkLeftStick.TabIndex = 145
        '
        'chkDpadLeft
        '
        Me.chkDpadLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.chkDpadLeft.Checked = False
        Me.chkDpadLeft.ForeColor = System.Drawing.Color.White
        Me.chkDpadLeft.Location = New System.Drawing.Point(504, 242)
        Me.chkDpadLeft.Name = "chkDpadLeft"
        Me.chkDpadLeft.Size = New System.Drawing.Size(15, 16)
        Me.chkDpadLeft.TabIndex = 143
        '
        'chkButtonX
        '
        Me.chkButtonX.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.chkButtonX.Checked = False
        Me.chkButtonX.ForeColor = System.Drawing.Color.White
        Me.chkButtonX.Location = New System.Drawing.Point(504, 146)
        Me.chkButtonX.Name = "chkButtonX"
        Me.chkButtonX.Size = New System.Drawing.Size(15, 16)
        Me.chkButtonX.TabIndex = 142
        '
        'chkLB
        '
        Me.chkLB.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.chkLB.Checked = False
        Me.chkLB.ForeColor = System.Drawing.Color.White
        Me.chkLB.Location = New System.Drawing.Point(504, 290)
        Me.chkLB.Name = "chkLB"
        Me.chkLB.Size = New System.Drawing.Size(15, 16)
        Me.chkLB.TabIndex = 141
        '
        'chkDpadUp
        '
        Me.chkDpadUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.chkDpadUp.Checked = False
        Me.chkDpadUp.ForeColor = System.Drawing.Color.White
        Me.chkDpadUp.Location = New System.Drawing.Point(504, 194)
        Me.chkDpadUp.Name = "chkDpadUp"
        Me.chkDpadUp.Size = New System.Drawing.Size(15, 16)
        Me.chkDpadUp.TabIndex = 144
        '
        'chkButtonA
        '
        Me.chkButtonA.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.chkButtonA.Checked = False
        Me.chkButtonA.ForeColor = System.Drawing.Color.White
        Me.chkButtonA.Location = New System.Drawing.Point(504, 98)
        Me.chkButtonA.Name = "chkButtonA"
        Me.chkButtonA.Size = New System.Drawing.Size(15, 16)
        Me.chkButtonA.TabIndex = 140
        '
        'chkRightStick
        '
        Me.chkRightStick.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.chkRightStick.Checked = False
        Me.chkRightStick.ForeColor = System.Drawing.Color.White
        Me.chkRightStick.Location = New System.Drawing.Point(504, 362)
        Me.chkRightStick.Name = "chkRightStick"
        Me.chkRightStick.Size = New System.Drawing.Size(15, 16)
        Me.chkRightStick.TabIndex = 146
        '
        'chkDpadRight
        '
        Me.chkDpadRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.chkDpadRight.Checked = False
        Me.chkDpadRight.ForeColor = System.Drawing.Color.White
        Me.chkDpadRight.Location = New System.Drawing.Point(504, 266)
        Me.chkDpadRight.Name = "chkDpadRight"
        Me.chkDpadRight.Size = New System.Drawing.Size(15, 16)
        Me.chkDpadRight.TabIndex = 147
        '
        'chkButtonY
        '
        Me.chkButtonY.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.chkButtonY.Checked = False
        Me.chkButtonY.ForeColor = System.Drawing.Color.White
        Me.chkButtonY.Location = New System.Drawing.Point(504, 170)
        Me.chkButtonY.Name = "chkButtonY"
        Me.chkButtonY.Size = New System.Drawing.Size(15, 16)
        Me.chkButtonY.TabIndex = 148
        '
        'chkRB
        '
        Me.chkRB.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.chkRB.Checked = False
        Me.chkRB.ForeColor = System.Drawing.Color.White
        Me.chkRB.Location = New System.Drawing.Point(504, 314)
        Me.chkRB.Name = "chkRB"
        Me.chkRB.Size = New System.Drawing.Size(15, 16)
        Me.chkRB.TabIndex = 149
        '
        'chkDpadDown
        '
        Me.chkDpadDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.chkDpadDown.Checked = False
        Me.chkDpadDown.ForeColor = System.Drawing.Color.White
        Me.chkDpadDown.Location = New System.Drawing.Point(504, 218)
        Me.chkDpadDown.Name = "chkDpadDown"
        Me.chkDpadDown.Size = New System.Drawing.Size(15, 16)
        Me.chkDpadDown.TabIndex = 150
        '
        'chkButtonB
        '
        Me.chkButtonB.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.chkButtonB.Checked = False
        Me.chkButtonB.ForeColor = System.Drawing.Color.White
        Me.chkButtonB.Location = New System.Drawing.Point(504, 122)
        Me.chkButtonB.Name = "chkButtonB"
        Me.chkButtonB.Size = New System.Drawing.Size(15, 16)
        Me.chkButtonB.TabIndex = 151
        '
        'txtLeftStickPress
        '
        Me.txtLeftStickPress.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txtLeftStickPress.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeftStickPress.ForeColor = System.Drawing.Color.White
        Me.txtLeftStickPress.Location = New System.Drawing.Point(105, 335)
        Me.txtLeftStickPress.MaxCharacters = 32767
        Me.txtLeftStickPress.Name = "txtLeftStickPress"
        Me.txtLeftStickPress.Size = New System.Drawing.Size(375, 24)
        Me.txtLeftStickPress.TabIndex = 132
        Me.txtLeftStickPress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLeftStickPress.UsePasswordMask = False
        '
        'txtDpadLeft
        '
        Me.txtDpadLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txtDpadLeft.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDpadLeft.ForeColor = System.Drawing.Color.White
        Me.txtDpadLeft.Location = New System.Drawing.Point(105, 239)
        Me.txtDpadLeft.MaxCharacters = 32767
        Me.txtDpadLeft.Name = "txtDpadLeft"
        Me.txtDpadLeft.Size = New System.Drawing.Size(375, 24)
        Me.txtDpadLeft.TabIndex = 131
        Me.txtDpadLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDpadLeft.UsePasswordMask = False
        '
        'txtButtonX
        '
        Me.txtButtonX.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txtButtonX.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtButtonX.ForeColor = System.Drawing.Color.White
        Me.txtButtonX.Location = New System.Drawing.Point(105, 143)
        Me.txtButtonX.MaxCharacters = 32767
        Me.txtButtonX.Name = "txtButtonX"
        Me.txtButtonX.Size = New System.Drawing.Size(375, 24)
        Me.txtButtonX.TabIndex = 130
        Me.txtButtonX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtButtonX.UsePasswordMask = False
        '
        'txtRightStickPress
        '
        Me.txtRightStickPress.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txtRightStickPress.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRightStickPress.ForeColor = System.Drawing.Color.White
        Me.txtRightStickPress.Location = New System.Drawing.Point(105, 359)
        Me.txtRightStickPress.MaxCharacters = 32767
        Me.txtRightStickPress.Name = "txtRightStickPress"
        Me.txtRightStickPress.Size = New System.Drawing.Size(375, 24)
        Me.txtRightStickPress.TabIndex = 139
        Me.txtRightStickPress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtRightStickPress.UsePasswordMask = False
        '
        'txtDpadRight
        '
        Me.txtDpadRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txtDpadRight.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDpadRight.ForeColor = System.Drawing.Color.White
        Me.txtDpadRight.Location = New System.Drawing.Point(105, 263)
        Me.txtDpadRight.MaxCharacters = 32767
        Me.txtDpadRight.Name = "txtDpadRight"
        Me.txtDpadRight.Size = New System.Drawing.Size(375, 24)
        Me.txtDpadRight.TabIndex = 138
        Me.txtDpadRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDpadRight.UsePasswordMask = False
        '
        'txtButtonY
        '
        Me.txtButtonY.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txtButtonY.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtButtonY.ForeColor = System.Drawing.Color.White
        Me.txtButtonY.Location = New System.Drawing.Point(105, 167)
        Me.txtButtonY.MaxCharacters = 32767
        Me.txtButtonY.Name = "txtButtonY"
        Me.txtButtonY.Size = New System.Drawing.Size(375, 24)
        Me.txtButtonY.TabIndex = 137
        Me.txtButtonY.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtButtonY.UsePasswordMask = False
        '
        'txtLb
        '
        Me.txtLb.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txtLb.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLb.ForeColor = System.Drawing.Color.White
        Me.txtLb.Location = New System.Drawing.Point(105, 287)
        Me.txtLb.MaxCharacters = 32767
        Me.txtLb.Name = "txtLb"
        Me.txtLb.Size = New System.Drawing.Size(375, 24)
        Me.txtLb.TabIndex = 129
        Me.txtLb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLb.UsePasswordMask = False
        '
        'txtRB
        '
        Me.txtRB.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txtRB.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRB.ForeColor = System.Drawing.Color.White
        Me.txtRB.Location = New System.Drawing.Point(105, 311)
        Me.txtRB.MaxCharacters = 32767
        Me.txtRB.Name = "txtRB"
        Me.txtRB.Size = New System.Drawing.Size(375, 24)
        Me.txtRB.TabIndex = 136
        Me.txtRB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtRB.UsePasswordMask = False
        '
        'txtDpadUp
        '
        Me.txtDpadUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txtDpadUp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDpadUp.ForeColor = System.Drawing.Color.White
        Me.txtDpadUp.Location = New System.Drawing.Point(105, 191)
        Me.txtDpadUp.MaxCharacters = 32767
        Me.txtDpadUp.Name = "txtDpadUp"
        Me.txtDpadUp.Size = New System.Drawing.Size(375, 24)
        Me.txtDpadUp.TabIndex = 128
        Me.txtDpadUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDpadUp.UsePasswordMask = False
        '
        'txtDpadDown
        '
        Me.txtDpadDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txtDpadDown.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDpadDown.ForeColor = System.Drawing.Color.White
        Me.txtDpadDown.Location = New System.Drawing.Point(105, 215)
        Me.txtDpadDown.MaxCharacters = 32767
        Me.txtDpadDown.Name = "txtDpadDown"
        Me.txtDpadDown.Size = New System.Drawing.Size(375, 24)
        Me.txtDpadDown.TabIndex = 135
        Me.txtDpadDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDpadDown.UsePasswordMask = False
        '
        'txtButtonA
        '
        Me.txtButtonA.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txtButtonA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtButtonA.ForeColor = System.Drawing.Color.White
        Me.txtButtonA.Location = New System.Drawing.Point(105, 95)
        Me.txtButtonA.MaxCharacters = 32767
        Me.txtButtonA.Name = "txtButtonA"
        Me.txtButtonA.Size = New System.Drawing.Size(375, 24)
        Me.txtButtonA.TabIndex = 133
        Me.txtButtonA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtButtonA.UsePasswordMask = False
        '
        'txtButtonB
        '
        Me.txtButtonB.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.txtButtonB.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtButtonB.ForeColor = System.Drawing.Color.White
        Me.txtButtonB.Location = New System.Drawing.Point(105, 119)
        Me.txtButtonB.MaxCharacters = 32767
        Me.txtButtonB.Name = "txtButtonB"
        Me.txtButtonB.Size = New System.Drawing.Size(375, 24)
        Me.txtButtonB.TabIndex = 134
        Me.txtButtonB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtButtonB.UsePasswordMask = False
        '
        'X360Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkEnable360)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.chkLeftStick)
        Me.Controls.Add(Me.chkDpadLeft)
        Me.Controls.Add(Me.chkButtonX)
        Me.Controls.Add(Me.chkLB)
        Me.Controls.Add(Me.chkDpadUp)
        Me.Controls.Add(Me.chkButtonA)
        Me.Controls.Add(Me.chkRightStick)
        Me.Controls.Add(Me.chkDpadRight)
        Me.Controls.Add(Me.chkButtonY)
        Me.Controls.Add(Me.chkRB)
        Me.Controls.Add(Me.chkDpadDown)
        Me.Controls.Add(Me.chkButtonB)
        Me.Controls.Add(Me.txtLeftStickPress)
        Me.Controls.Add(Me.txtDpadLeft)
        Me.Controls.Add(Me.txtButtonX)
        Me.Controls.Add(Me.txtRightStickPress)
        Me.Controls.Add(Me.txtDpadRight)
        Me.Controls.Add(Me.txtButtonY)
        Me.Controls.Add(Me.txtLb)
        Me.Controls.Add(Me.txtRB)
        Me.Controls.Add(Me.txtDpadUp)
        Me.Controls.Add(Me.txtDpadDown)
        Me.Controls.Add(Me.txtButtonA)
        Me.Controls.Add(Me.txtButtonB)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "X360Panel"
        Me.Size = New System.Drawing.Size(550, 430)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkEnable360 As SACNR_Keybinder_Evolution.ReactorCheckBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents chkLeftStick As SACNR_Keybinder_Evolution.ReactorCheckBox
    Friend WithEvents chkDpadLeft As SACNR_Keybinder_Evolution.ReactorCheckBox
    Friend WithEvents chkButtonX As SACNR_Keybinder_Evolution.ReactorCheckBox
    Friend WithEvents chkLB As SACNR_Keybinder_Evolution.ReactorCheckBox
    Friend WithEvents chkDpadUp As SACNR_Keybinder_Evolution.ReactorCheckBox
    Friend WithEvents chkButtonA As SACNR_Keybinder_Evolution.ReactorCheckBox
    Friend WithEvents chkRightStick As SACNR_Keybinder_Evolution.ReactorCheckBox
    Friend WithEvents chkDpadRight As SACNR_Keybinder_Evolution.ReactorCheckBox
    Friend WithEvents chkButtonY As SACNR_Keybinder_Evolution.ReactorCheckBox
    Friend WithEvents chkRB As SACNR_Keybinder_Evolution.ReactorCheckBox
    Friend WithEvents chkDpadDown As SACNR_Keybinder_Evolution.ReactorCheckBox
    Friend WithEvents chkButtonB As SACNR_Keybinder_Evolution.ReactorCheckBox
    Friend WithEvents txtLeftStickPress As SACNR_Keybinder_Evolution.ReactorTextBox
    Friend WithEvents txtDpadLeft As SACNR_Keybinder_Evolution.ReactorTextBox
    Friend WithEvents txtButtonX As SACNR_Keybinder_Evolution.ReactorTextBox
    Friend WithEvents txtRightStickPress As SACNR_Keybinder_Evolution.ReactorTextBox
    Friend WithEvents txtDpadRight As SACNR_Keybinder_Evolution.ReactorTextBox
    Friend WithEvents txtButtonY As SACNR_Keybinder_Evolution.ReactorTextBox
    Friend WithEvents txtLb As SACNR_Keybinder_Evolution.ReactorTextBox
    Friend WithEvents txtRB As SACNR_Keybinder_Evolution.ReactorTextBox
    Friend WithEvents txtDpadUp As SACNR_Keybinder_Evolution.ReactorTextBox
    Friend WithEvents txtDpadDown As SACNR_Keybinder_Evolution.ReactorTextBox
    Friend WithEvents txtButtonA As SACNR_Keybinder_Evolution.ReactorTextBox
    Friend WithEvents txtButtonB As SACNR_Keybinder_Evolution.ReactorTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
