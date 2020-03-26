<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClassicEyestay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClassicEyestay))
        Me.lblClassicEyestay = New System.Windows.Forms.Label()
        Me.picClassicEyestay = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.picBack = New System.Windows.Forms.PictureBox()
        CType(Me.picClassicEyestay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblClassicEyestay
        '
        Me.lblClassicEyestay.AutoSize = True
        Me.lblClassicEyestay.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassicEyestay.ForeColor = System.Drawing.Color.White
        Me.lblClassicEyestay.Location = New System.Drawing.Point(233, 134)
        Me.lblClassicEyestay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClassicEyestay.Name = "lblClassicEyestay"
        Me.lblClassicEyestay.Size = New System.Drawing.Size(750, 31)
        Me.lblClassicEyestay.TabIndex = 3
        Me.lblClassicEyestay.Text = "The selected color for the classic quarter is:"
        '
        'picClassicEyestay
        '
        Me.picClassicEyestay.BackColor = System.Drawing.Color.Transparent
        Me.picClassicEyestay.Image = Global.Your_Style.My.Resources.Resources.ClassicWhiteEyestay
        Me.picClassicEyestay.Location = New System.Drawing.Point(42, -4)
        Me.picClassicEyestay.Margin = New System.Windows.Forms.Padding(0)
        Me.picClassicEyestay.Name = "picClassicEyestay"
        Me.picClassicEyestay.Size = New System.Drawing.Size(1030, 715)
        Me.picClassicEyestay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picClassicEyestay.TabIndex = 2
        Me.picClassicEyestay.TabStop = False
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
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "&NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'picBack
        '
        Me.picBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.picBack.Image = CType(resources.GetObject("picBack.Image"), System.Drawing.Image)
        Me.picBack.Location = New System.Drawing.Point(12, 12)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(100, 72)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBack.TabIndex = 6
        Me.picBack.TabStop = False
        '
        'frmClassicEyestay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BackgroundImage = Global.Your_Style.My.Resources.Resources.ClassicBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1265, 666)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.picBack)
        Me.Controls.Add(Me.lblClassicEyestay)
        Me.Controls.Add(Me.picClassicEyestay)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmClassicEyestay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Classic - Eyestay"
        CType(Me.picClassicEyestay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblClassicEyestay As Label
    Friend WithEvents picClassicEyestay As PictureBox
    Friend WithEvents btnNext As Button
    Friend WithEvents picBack As PictureBox
End Class
