<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassicHeelTab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClassicHeelTab))
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblClassicHeelTab = New System.Windows.Forms.Label()
        Me.picClassicHeelTab = New System.Windows.Forms.PictureBox()
        Me.picBack = New System.Windows.Forms.PictureBox()
        CType(Me.picClassicHeelTab, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "&NEXT"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblClassicHeelTab
        '
        Me.lblClassicHeelTab.AutoSize = True
        Me.lblClassicHeelTab.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassicHeelTab.ForeColor = System.Drawing.Color.White
        Me.lblClassicHeelTab.Location = New System.Drawing.Point(233, 134)
        Me.lblClassicHeelTab.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClassicHeelTab.Name = "lblClassicHeelTab"
        Me.lblClassicHeelTab.Size = New System.Drawing.Size(750, 31)
        Me.lblClassicHeelTab.TabIndex = 8
        Me.lblClassicHeelTab.Text = "The selected color for the classic quarter is:"
        '
        'picClassicHeelTab
        '
        Me.picClassicHeelTab.BackColor = System.Drawing.Color.Transparent
        Me.picClassicHeelTab.Image = Global.Your_Style.My.Resources.Resources.ClassicWhiteHeelTab
        Me.picClassicHeelTab.Location = New System.Drawing.Point(100, 84)
        Me.picClassicHeelTab.Margin = New System.Windows.Forms.Padding(0)
        Me.picClassicHeelTab.Name = "picClassicHeelTab"
        Me.picClassicHeelTab.Size = New System.Drawing.Size(687, 465)
        Me.picClassicHeelTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picClassicHeelTab.TabIndex = 7
        Me.picClassicHeelTab.TabStop = False
        '
        'picBack
        '
        Me.picBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.picBack.Image = CType(resources.GetObject("picBack.Image"), System.Drawing.Image)
        Me.picBack.Location = New System.Drawing.Point(12, 9)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(100, 72)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBack.TabIndex = 10
        Me.picBack.TabStop = False
        '
        'frmClassicHeelTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BackgroundImage = Global.Your_Style.My.Resources.Resources.ClassicBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1265, 666)
        Me.Controls.Add(Me.picBack)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblClassicHeelTab)
        Me.Controls.Add(Me.picClassicHeelTab)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmClassicHeelTab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Classic - Heel Tab"
        CType(Me.picClassicHeelTab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents lblClassicHeelTab As Label
    Friend WithEvents picClassicHeelTab As PictureBox
    Friend WithEvents picBack As PictureBox
End Class
