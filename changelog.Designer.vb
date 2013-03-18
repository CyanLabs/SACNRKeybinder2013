<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changelog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(changelog))
        Me.ReactorTheme1 = New SACNR_Keybinder_2013_Edition.ReactorTheme()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReactorButton1 = New SACNR_Keybinder_2013_Edition.ReactorButton()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ReactorTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReactorTheme1
        '
        Me.ReactorTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ReactorTheme1.Controls.Add(Me.Label1)
        Me.ReactorTheme1.Controls.Add(Me.ReactorButton1)
        Me.ReactorTheme1.Controls.Add(Me.WebBrowser1)
        Me.ReactorTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReactorTheme1.Font = New System.Drawing.Font("Verdana", 6.75!)
        Me.ReactorTheme1.Location = New System.Drawing.Point(0, 0)
        Me.ReactorTheme1.Name = "ReactorTheme1"
        Me.ReactorTheme1.Size = New System.Drawing.Size(683, 500)
        Me.ReactorTheme1.TabIndex = 0
        Me.ReactorTheme1.Text = "Changelog"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(127, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Updated to vX.X.X.X successfully"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ReactorButton1
        '
        Me.ReactorButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ReactorButton1.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReactorButton1.Location = New System.Drawing.Point(4, 454)
        Me.ReactorButton1.Name = "ReactorButton1"
        Me.ReactorButton1.Size = New System.Drawing.Size(674, 42)
        Me.ReactorButton1.TabIndex = 3
        Me.ReactorButton1.Text = "Close Changelog"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(7, 52)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(670, 402)
        Me.WebBrowser1.TabIndex = 2
        Me.WebBrowser1.Url = New System.Uri("http://cyanlabs.co.uk/keybinder/changelog.html", System.UriKind.Absolute)
        '
        'changelog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 500)
        Me.Controls.Add(Me.ReactorTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "changelog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "changelog"
        Me.TopMost = True
        Me.ReactorTheme1.ResumeLayout(False)
        Me.ReactorTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReactorTheme1 As SACNR_Keybinder_2013_Edition.ReactorTheme
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents ReactorButton1 As SACNR_Keybinder_2013_Edition.ReactorButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
