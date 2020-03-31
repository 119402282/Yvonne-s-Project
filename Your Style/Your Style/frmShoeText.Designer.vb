<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShoeText
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShoeText))
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.RichTextBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.trkFontSize = New System.Windows.Forms.TrackBar()
        Me.lblStyle = New System.Windows.Forms.Label()
        Me.cmbStyle = New System.Windows.Forms.ComboBox()
        Me.lblFont = New System.Windows.Forms.Label()
        Me.cmbFont = New System.Windows.Forms.ComboBox()
        Me.lblEnterText = New System.Windows.Forms.Label()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.picColor = New System.Windows.Forms.PictureBox()
        Me.chkText = New System.Windows.Forms.CheckBox()
        Me.btnNext = New System.Windows.Forms.Button()
        CType(Me.trkFontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblResult.ForeColor = System.Drawing.Color.White
        Me.lblResult.Location = New System.Drawing.Point(180, 444)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(158, 31)
        Me.lblResult.TabIndex = 15
        Me.lblResult.Text = "Text Here"
        '
        'txtInput
        '
        Me.txtInput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInput.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtInput.Location = New System.Drawing.Point(186, 335)
        Me.txtInput.Margin = New System.Windows.Forms.Padding(10)
        Me.txtInput.MaxLength = 23
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(399, 47)
        Me.txtInput.TabIndex = 14
        Me.txtInput.Text = ""
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblSize.ForeColor = System.Drawing.Color.White
        Me.lblSize.Location = New System.Drawing.Point(817, 127)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(286, 31)
        Me.lblSize.TabIndex = 13
        Me.lblSize.Text = "Change Font Size:"
        '
        'trkFontSize
        '
        Me.trkFontSize.LargeChange = 10
        Me.trkFontSize.Location = New System.Drawing.Point(823, 179)
        Me.trkFontSize.Maximum = 48
        Me.trkFontSize.Minimum = 12
        Me.trkFontSize.Name = "trkFontSize"
        Me.trkFontSize.Size = New System.Drawing.Size(280, 45)
        Me.trkFontSize.SmallChange = 2
        Me.trkFontSize.TabIndex = 12
        Me.trkFontSize.TickFrequency = 2
        Me.trkFontSize.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.trkFontSize.Value = 12
        '
        'lblStyle
        '
        Me.lblStyle.AutoSize = True
        Me.lblStyle.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblStyle.ForeColor = System.Drawing.Color.White
        Me.lblStyle.Location = New System.Drawing.Point(495, 127)
        Me.lblStyle.Name = "lblStyle"
        Me.lblStyle.Size = New System.Drawing.Size(222, 31)
        Me.lblStyle.TabIndex = 11
        Me.lblStyle.Text = "Select Style:"
        '
        'cmbStyle
        '
        Me.cmbStyle.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold)
        Me.cmbStyle.FormattingEnabled = True
        Me.cmbStyle.Items.AddRange(New Object() {"Regular", "Italic", "Bold"})
        Me.cmbStyle.Location = New System.Drawing.Point(501, 185)
        Me.cmbStyle.Name = "cmbStyle"
        Me.cmbStyle.Size = New System.Drawing.Size(280, 39)
        Me.cmbStyle.TabIndex = 10
        '
        'lblFont
        '
        Me.lblFont.AutoSize = True
        Me.lblFont.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblFont.ForeColor = System.Drawing.Color.White
        Me.lblFont.Location = New System.Drawing.Point(180, 127)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(206, 31)
        Me.lblFont.TabIndex = 9
        Me.lblFont.Text = "Select Font:"
        '
        'cmbFont
        '
        Me.cmbFont.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold)
        Me.cmbFont.FormattingEnabled = True
        Me.cmbFont.Location = New System.Drawing.Point(186, 185)
        Me.cmbFont.Name = "cmbFont"
        Me.cmbFont.Size = New System.Drawing.Size(280, 39)
        Me.cmbFont.TabIndex = 8
        '
        'lblEnterText
        '
        Me.lblEnterText.AutoSize = True
        Me.lblEnterText.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblEnterText.ForeColor = System.Drawing.Color.White
        Me.lblEnterText.Location = New System.Drawing.Point(180, 269)
        Me.lblEnterText.Name = "lblEnterText"
        Me.lblEnterText.Size = New System.Drawing.Size(190, 31)
        Me.lblEnterText.TabIndex = 16
        Me.lblEnterText.Text = "Enter Text:"
        '
        'picBack
        '
        Me.picBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.picBack.Image = CType(resources.GetObject("picBack.Image"), System.Drawing.Image)
        Me.picBack.Location = New System.Drawing.Point(12, 12)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(100, 72)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBack.TabIndex = 17
        Me.picBack.TabStop = False
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblColor.ForeColor = System.Drawing.Color.White
        Me.lblColor.Location = New System.Drawing.Point(817, 269)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(302, 31)
        Me.lblColor.TabIndex = 18
        Me.lblColor.Text = "Select Text Color:"
        '
        'picColor
        '
        Me.picColor.Image = CType(resources.GetObject("picColor.Image"), System.Drawing.Image)
        Me.picColor.Location = New System.Drawing.Point(823, 335)
        Me.picColor.Name = "picColor"
        Me.picColor.Size = New System.Drawing.Size(234, 199)
        Me.picColor.TabIndex = 19
        Me.picColor.TabStop = False
        '
        'chkText
        '
        Me.chkText.AutoSize = True
        Me.chkText.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold)
        Me.chkText.ForeColor = System.Drawing.Color.White
        Me.chkText.Location = New System.Drawing.Point(186, 49)
        Me.chkText.Name = "chkText"
        Me.chkText.Size = New System.Drawing.Size(305, 35)
        Me.chkText.TabIndex = 21
        Me.chkText.Text = "Text Caption: y/n"
        Me.chkText.UseVisualStyleBackColor = True
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
        Me.btnNext.TabIndex = 22
        Me.btnNext.Text = "&NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'frmShoeText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1265, 667)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.chkText)
        Me.Controls.Add(Me.picColor)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.picBack)
        Me.Controls.Add(Me.lblEnterText)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.trkFontSize)
        Me.Controls.Add(Me.lblStyle)
        Me.Controls.Add(Me.cmbStyle)
        Me.Controls.Add(Me.lblFont)
        Me.Controls.Add(Me.cmbFont)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmShoeText"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customization - Text"
        CType(Me.trkFontSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblResult As Label
    Friend WithEvents txtInput As RichTextBox
    Friend WithEvents lblSize As Label
    Friend WithEvents trkFontSize As TrackBar
    Friend WithEvents lblStyle As Label
    Friend WithEvents cmbStyle As ComboBox
    Friend WithEvents lblFont As Label
    Friend WithEvents cmbFont As ComboBox
    Friend WithEvents lblEnterText As Label
    Friend WithEvents picBack As PictureBox
    Friend WithEvents lblColor As Label
    Friend WithEvents picColor As PictureBox
    Friend WithEvents chkText As CheckBox
    Friend WithEvents btnNext As Button
End Class
