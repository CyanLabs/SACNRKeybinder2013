<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim MouseHook1 As SACNR_Keybinder_Evolution.MouseHook = New SACNR_Keybinder_Evolution.MouseHook()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.imgLogo2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnLaunch = New SACNR_Keybinder_Evolution.ReactorButton()
        Me.KbPanelPage1 = New SACNR_Keybinder_Evolution.KBPanel()
        Me.X360Panel1 = New SACNR_Keybinder_Evolution.X360Panel()
        Me.AboutPanel1 = New SACNR_Keybinder_Evolution.AboutPanel()
        Me.MousePanel1 = New SACNR_Keybinder_Evolution.MousePanel()
        Me.SettingsPanel1 = New SACNR_Keybinder_Evolution.SettingsPanel()
        Me.KbPanelPage2 = New SACNR_Keybinder_Evolution.KBPanel()
        CType(Me.imgLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Minimized To Tray"
        Me.NotifyIcon1.BalloonTipTitle = "SACNR KeyBinder"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "SACNR KeyBinder 2013 Edition"
        Me.NotifyIcon1.Visible = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'imgLogo2
        '
        Me.imgLogo2.Image = CType(resources.GetObject("imgLogo2.Image"), System.Drawing.Image)
        Me.imgLogo2.Location = New System.Drawing.Point(3, 1)
        Me.imgLogo2.Name = "imgLogo2"
        Me.imgLogo2.Size = New System.Drawing.Size(475, 75)
        Me.imgLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLogo2.TabIndex = 44
        Me.imgLogo2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 35)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Keyboard"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(12, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 34)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Mouse"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(12, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 34)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Xbox 360"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(12, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 34)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Whats New?"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(100, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Page 2"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(47, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Page 1"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(67, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(369, 23)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Cyanlabs presents SACnR Keybinder Evolution"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(18, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(514, 13)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Please watch the video below to understand how to fully use SACnR Keybinder Evolu" & _
    "tion"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowWebBrowserDrop = False
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(44, 118)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(440, 267)
        Me.WebBrowser1.TabIndex = 63
        Me.WebBrowser1.WebBrowserShortcutsEnabled = False
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainPanel.Controls.Add(Me.Label8)
        Me.MainPanel.Controls.Add(Me.Label7)
        Me.MainPanel.Controls.Add(Me.WebBrowser1)
        Me.MainPanel.Controls.Add(Me.imgLogo2)
        Me.MainPanel.ForeColor = System.Drawing.Color.White
        Me.MainPanel.Location = New System.Drawing.Point(186, 9)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(550, 430)
        Me.MainPanel.TabIndex = 65
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(12, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 34)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Settings"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.SACNR_Keybinder_Evolution.My.Resources.Resources.close
        Me.PictureBox2.Location = New System.Drawing.Point(132, 388)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 50)
        Me.PictureBox2.TabIndex = 66
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.SACNR_Keybinder_Evolution.My.Resources.Resources.minimize
        Me.PictureBox3.Location = New System.Drawing.Point(74, 382)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(59, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 67
        Me.PictureBox3.TabStop = False
        '
        'btnLaunch
        '
        Me.btnLaunch.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btnLaunch.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaunch.Location = New System.Drawing.Point(184, 400)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(538, 41)
        Me.btnLaunch.TabIndex = 50
        Me.btnLaunch.Text = "Launch ""San Andreas Cops N Robbers"""
        '
        'KbPanelPage1
        '
        Me.KbPanelPage1.BackColor = System.Drawing.Color.Transparent
        Me.KbPanelPage1.Location = New System.Drawing.Point(186, 9)
        Me.KbPanelPage1.Name = "KbPanelPage1"
        Me.KbPanelPage1.Size = New System.Drawing.Size(550, 430)
        Me.KbPanelPage1.TabIndex = 64
        Me.KbPanelPage1.Visible = False
        '
        'X360Panel1
        '
        Me.X360Panel1.BackColor = System.Drawing.Color.Transparent
        Me.X360Panel1.ForeColor = System.Drawing.Color.White
        Me.X360Panel1.Location = New System.Drawing.Point(186, 9)
        Me.X360Panel1.Name = "X360Panel1"
        Me.X360Panel1.Size = New System.Drawing.Size(550, 430)
        Me.X360Panel1.TabIndex = 54
        Me.X360Panel1.Visible = False
        '
        'AboutPanel1
        '
        Me.AboutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.AboutPanel1.ForeColor = System.Drawing.Color.White
        Me.AboutPanel1.Location = New System.Drawing.Point(186, 9)
        Me.AboutPanel1.Name = "AboutPanel1"
        Me.AboutPanel1.Size = New System.Drawing.Size(550, 430)
        Me.AboutPanel1.TabIndex = 57
        Me.AboutPanel1.Visible = False
        '
        'MousePanel1
        '
        Me.MousePanel1.BackColor = System.Drawing.Color.Transparent
        Me.MousePanel1.Location = New System.Drawing.Point(186, 9)
        Me.MousePanel1.mHook = MouseHook1
        Me.MousePanel1.Name = "MousePanel1"
        Me.MousePanel1.Size = New System.Drawing.Size(550, 430)
        Me.MousePanel1.TabIndex = 53
        Me.MousePanel1.Visible = False
        '
        'SettingsPanel1
        '
        Me.SettingsPanel1.BackColor = System.Drawing.Color.Transparent
        Me.SettingsPanel1.ForeColor = System.Drawing.Color.White
        Me.SettingsPanel1.Location = New System.Drawing.Point(186, 9)
        Me.SettingsPanel1.Name = "SettingsPanel1"
        Me.SettingsPanel1.Size = New System.Drawing.Size(550, 430)
        Me.SettingsPanel1.TabIndex = 55
        Me.SettingsPanel1.Visible = False
        '
        'KbPanelPage2
        '
        Me.KbPanelPage2.BackColor = System.Drawing.Color.Transparent
        Me.KbPanelPage2.Location = New System.Drawing.Point(186, 9)
        Me.KbPanelPage2.Name = "KbPanelPage2"
        Me.KbPanelPage2.Size = New System.Drawing.Size(550, 430)
        Me.KbPanelPage2.TabIndex = 68
        Me.KbPanelPage2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Magenta
        Me.BackgroundImage = Global.SACNR_Keybinder_Evolution.My.Resources.Resources.backgroundwithoutheader
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(757, 450)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnLaunch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.KbPanelPage1)
        Me.Controls.Add(Me.X360Panel1)
        Me.Controls.Add(Me.AboutPanel1)
        Me.Controls.Add(Me.MousePanel1)
        Me.Controls.Add(Me.SettingsPanel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.KbPanelPage2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SACNR Keybinder 2013 Edition"
        Me.TransparencyKey = System.Drawing.Color.Magenta
        CType(Me.imgLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents imgLogo2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnLaunch As SACNR_Keybinder_Evolution.ReactorButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MousePanel1 As SACNR_Keybinder_Evolution.MousePanel
    Friend WithEvents X360Panel1 As SACNR_Keybinder_Evolution.X360Panel
    Friend WithEvents SettingsPanel1 As SACNR_Keybinder_Evolution.SettingsPanel
    Friend WithEvents AboutPanel1 As SACNR_Keybinder_Evolution.AboutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents KbPanelPage1 As SACNR_Keybinder_Evolution.KBPanel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents KbPanelPage2 As SACNR_Keybinder_Evolution.KBPanel
End Class
