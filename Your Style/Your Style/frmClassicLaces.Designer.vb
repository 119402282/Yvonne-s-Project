<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassicLaces
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClassicLaces))
        Me.lblClassicLaces = New System.Windows.Forms.Label()
        Me.picClassicLaces = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.picBack = New System.Windows.Forms.PictureBox()
        CType(Me.picClassicLaces, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblClassicLaces
        '
        Me.lblClassicLaces.AutoSize = True
        Me.lblClassicLaces.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassicLaces.ForeColor = System.Drawing.Color.White
        Me.lblClassicLaces.Location = New System.Drawing.Point(233, 134)
        Me.lblClassicLaces.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClassicLaces.Name = "lblClassicLaces"
        Me.lblClassicLaces.Size = New System.Drawing.Size(750, 31)
        Me.lblClassicLaces.TabIndex = 5
        Me.lblClassicLaces.Text = "The selected color for the classic quarter is:"
        '
        'picClassicLaces
        '
        Me.picClassicLaces.BackColor = System.Drawing.Color.Transparent
        Me.picClassicLaces.Image = Global.Your_Style.My.Resources.Resources.ClassicWhiteLaces
        Me.picClassicLaces.Location = New System.Drawing.Point(369, 97)
        Me.picClassicLaces.Margin = New System.Windows.Forms.Padding(0)
        Me.picClassicLaces.Name = "picClassicLaces"
        Me.picClassicLaces.Size = New System.Drawing.Size(687, 465)
        Me.picClassicLaces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picClassicLaces.TabIndex = 4
        Me.picClassicLaces.TabStop = False
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
        Me.btnNext.TabIndex = 6
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
        Me.picBack.TabIndex = 7
        Me.picBack.TabStop = False
        '
        'frmClassicLaces
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BackgroundImage = Global.Your_Style.My.Resources.Resources.ClassicBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1265, 666)
        Me.Controls.Add(Me.picBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblClassicLaces)
        Me.Controls.Add(Me.picClassicLaces)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmClassicLaces"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Classic - Laces"
        CType(Me.picClassicLaces, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblClassicLaces As Label
    Friend WithEvents picClassicLaces As PictureBox
    Friend WithEvents btnNext As Button
    Friend WithEvents picBack As PictureBox
End Class
