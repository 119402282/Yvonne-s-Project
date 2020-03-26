<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetroBackCounter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRetroBackCounter))
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblRetroBackCounter = New System.Windows.Forms.Label()
        Me.picRetroBackCounter = New System.Windows.Forms.PictureBox()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRetroBackCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBack
        '
        Me.picBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.picBack.Image = CType(resources.GetObject("picBack.Image"), System.Drawing.Image)
        Me.picBack.Location = New System.Drawing.Point(12, 12)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(100, 72)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBack.TabIndex = 29
        Me.picBack.TabStop = False
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
        Me.btnNext.TabIndex = 28
        Me.btnNext.Text = "&NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblRetroBackCounter
        '
        Me.lblRetroBackCounter.AutoSize = True
        Me.lblRetroBackCounter.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetroBackCounter.ForeColor = System.Drawing.Color.White
        Me.lblRetroBackCounter.Location = New System.Drawing.Point(233, 134)
        Me.lblRetroBackCounter.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRetroBackCounter.Name = "lblRetroBackCounter"
        Me.lblRetroBackCounter.Size = New System.Drawing.Size(750, 31)
        Me.lblRetroBackCounter.TabIndex = 27
        Me.lblRetroBackCounter.Text = "The selected color for the classic quarter is:"
        '
        'picRetroBackCounter
        '
        Me.picRetroBackCounter.BackColor = System.Drawing.Color.Transparent
        Me.picRetroBackCounter.Image = Global.Your_Style.My.Resources.Resources.RetroWhiteBackCounter
        Me.picRetroBackCounter.Location = New System.Drawing.Point(346, 321)
        Me.picRetroBackCounter.Margin = New System.Windows.Forms.Padding(0)
        Me.picRetroBackCounter.Name = "picRetroBackCounter"
        Me.picRetroBackCounter.Size = New System.Drawing.Size(237, 129)
        Me.picRetroBackCounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picRetroBackCounter.TabIndex = 26
        Me.picRetroBackCounter.TabStop = False
        '
        'frmRetroBackCounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BackgroundImage = Global.Your_Style.My.Resources.Resources.RetroBacking
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1265, 666)
        Me.Controls.Add(Me.picBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblRetroBackCounter)
        Me.Controls.Add(Me.picRetroBackCounter)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmRetroBackCounter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retro - Back Counter"
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRetroBackCounter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBack As PictureBox
    Friend WithEvents btnNext As Button
    Friend WithEvents lblRetroBackCounter As Label
    Friend WithEvents picRetroBackCounter As PictureBox
End Class
