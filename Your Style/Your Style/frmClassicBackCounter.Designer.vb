<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassicBackCounter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClassicBackCounter))
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblClassicBackCounter = New System.Windows.Forms.Label()
        Me.picClassicBackCounter = New System.Windows.Forms.PictureBox()
        Me.picBack = New System.Windows.Forms.PictureBox()
        CType(Me.picClassicBackCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = "&NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblClassicBackCounter
        '
        Me.lblClassicBackCounter.AutoSize = True
        Me.lblClassicBackCounter.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassicBackCounter.ForeColor = System.Drawing.Color.White
        Me.lblClassicBackCounter.Location = New System.Drawing.Point(233, 134)
        Me.lblClassicBackCounter.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClassicBackCounter.Name = "lblClassicBackCounter"
        Me.lblClassicBackCounter.Size = New System.Drawing.Size(750, 31)
        Me.lblClassicBackCounter.TabIndex = 11
        Me.lblClassicBackCounter.Text = "The selected color for the classic quarter is:"
        '
        'picClassicBackCounter
        '
        Me.picClassicBackCounter.BackColor = System.Drawing.Color.Transparent
        Me.picClassicBackCounter.Image = Global.Your_Style.My.Resources.Resources.ClassicWhiteBackCounter
        Me.picClassicBackCounter.Location = New System.Drawing.Point(107, 185)
        Me.picClassicBackCounter.Margin = New System.Windows.Forms.Padding(0)
        Me.picClassicBackCounter.Name = "picClassicBackCounter"
        Me.picClassicBackCounter.Size = New System.Drawing.Size(687, 465)
        Me.picClassicBackCounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picClassicBackCounter.TabIndex = 10
        Me.picClassicBackCounter.TabStop = False
        '
        'picBack
        '
        Me.picBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.picBack.Image = CType(resources.GetObject("picBack.Image"), System.Drawing.Image)
        Me.picBack.Location = New System.Drawing.Point(12, 12)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(100, 72)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBack.TabIndex = 13
        Me.picBack.TabStop = False
        '
        'frmClassicBackCounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BackgroundImage = Global.Your_Style.My.Resources.Resources.ClassicBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1265, 666)
        Me.Controls.Add(Me.picBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblClassicBackCounter)
        Me.Controls.Add(Me.picClassicBackCounter)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmClassicBackCounter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Classic - Back Counter"
        CType(Me.picClassicBackCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents lblClassicBackCounter As Label
    Friend WithEvents picClassicBackCounter As PictureBox
    Friend WithEvents picBack As PictureBox
End Class
