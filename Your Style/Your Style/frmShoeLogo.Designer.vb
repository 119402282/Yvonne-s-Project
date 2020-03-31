<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShoeLogo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShoeLogo))
        Me.chkLogo = New System.Windows.Forms.CheckBox()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.txtLogo = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblLocate = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.ofdLogo = New System.Windows.Forms.OpenFileDialog()
        Me.btnNext = New System.Windows.Forms.Button()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkLogo
        '
        Me.chkLogo.AutoSize = True
        Me.chkLogo.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold)
        Me.chkLogo.ForeColor = System.Drawing.Color.White
        Me.chkLogo.Location = New System.Drawing.Point(186, 49)
        Me.chkLogo.Name = "chkLogo"
        Me.chkLogo.Size = New System.Drawing.Size(177, 35)
        Me.chkLogo.TabIndex = 23
        Me.chkLogo.Text = "Logo: y/n"
        Me.chkLogo.UseVisualStyleBackColor = True
        '
        'picBack
        '
        Me.picBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.picBack.Image = CType(resources.GetObject("picBack.Image"), System.Drawing.Image)
        Me.picBack.Location = New System.Drawing.Point(12, 12)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(100, 72)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBack.TabIndex = 22
        Me.picBack.TabStop = False
        '
        'txtLogo
        '
        Me.txtLogo.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtLogo.Location = New System.Drawing.Point(186, 206)
        Me.txtLogo.Name = "txtLogo"
        Me.txtLogo.ReadOnly = True
        Me.txtLogo.Size = New System.Drawing.Size(773, 26)
        Me.txtLogo.TabIndex = 24
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.White
        Me.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBrowse.Location = New System.Drawing.Point(1008, 195)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(180, 38)
        Me.btnBrowse.TabIndex = 25
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'lblLocate
        '
        Me.lblLocate.AutoSize = True
        Me.lblLocate.ForeColor = System.Drawing.Color.White
        Me.lblLocate.Location = New System.Drawing.Point(180, 125)
        Me.lblLocate.Name = "lblLocate"
        Me.lblLocate.Size = New System.Drawing.Size(238, 31)
        Me.lblLocate.TabIndex = 26
        Me.lblLocate.Text = "File Location:"
        '
        'picLogo
        '
        Me.picLogo.Location = New System.Drawing.Point(561, 283)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(280, 280)
        Me.picLogo.TabIndex = 27
        Me.picLogo.TabStop = False
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.ForeColor = System.Drawing.Color.White
        Me.lblLogo.Location = New System.Drawing.Point(376, 408)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(94, 31)
        Me.lblLogo.TabIndex = 28
        Me.lblLogo.Text = "Logo:"
        '
        'ofdLogo
        '
        Me.ofdLogo.FileName = "ofdLogo"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.White
        Me.btnNext.Font = New System.Drawing.Font("Gill Sans MT", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNext.Location = New System.Drawing.Point(1023, 573)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnNext.Size = New System.Drawing.Size(143, 60)
        Me.btnNext.TabIndex = 29
        Me.btnNext.Text = "&NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'frmShoeLogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1265, 667)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblLogo)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblLocate)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtLogo)
        Me.Controls.Add(Me.chkLogo)
        Me.Controls.Add(Me.picBack)
        Me.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "frmShoeLogo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customization - Logo"
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkLogo As CheckBox
    Friend WithEvents picBack As PictureBox
    Friend WithEvents txtLogo As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblLocate As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblLogo As Label
    Friend WithEvents ofdLogo As OpenFileDialog
    Friend WithEvents btnNext As Button
End Class
