<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShoeType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShoeType))
        Me.picClassic = New System.Windows.Forms.PictureBox()
        Me.picRetro = New System.Windows.Forms.PictureBox()
        Me.picVintage = New System.Windows.Forms.PictureBox()
        Me.lblSelectShoe = New System.Windows.Forms.Label()
        Me.lblClassic = New System.Windows.Forms.Label()
        Me.lblRetro = New System.Windows.Forms.Label()
        Me.lblVintage = New System.Windows.Forms.Label()
        Me.picBack = New System.Windows.Forms.PictureBox()
        CType(Me.picClassic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRetro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVintage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picClassic
        '
        Me.picClassic.BackColor = System.Drawing.Color.Blue
        Me.picClassic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picClassic.Image = Global.Your_Style.My.Resources.Resources.Classic
        Me.picClassic.Location = New System.Drawing.Point(155, 215)
        Me.picClassic.Name = "picClassic"
        Me.picClassic.Size = New System.Drawing.Size(300, 280)
        Me.picClassic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picClassic.TabIndex = 0
        Me.picClassic.TabStop = False
        '
        'picRetro
        '
        Me.picRetro.BackColor = System.Drawing.Color.White
        Me.picRetro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picRetro.Image = Global.Your_Style.My.Resources.Resources.Retro
        Me.picRetro.Location = New System.Drawing.Point(494, 215)
        Me.picRetro.Name = "picRetro"
        Me.picRetro.Size = New System.Drawing.Size(300, 280)
        Me.picRetro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRetro.TabIndex = 1
        Me.picRetro.TabStop = False
        '
        'picVintage
        '
        Me.picVintage.BackColor = System.Drawing.Color.Red
        Me.picVintage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picVintage.Image = Global.Your_Style.My.Resources.Resources.Vintage
        Me.picVintage.Location = New System.Drawing.Point(833, 215)
        Me.picVintage.Name = "picVintage"
        Me.picVintage.Size = New System.Drawing.Size(300, 280)
        Me.picVintage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVintage.TabIndex = 2
        Me.picVintage.TabStop = False
        '
        'lblSelectShoe
        '
        Me.lblSelectShoe.AutoSize = True
        Me.lblSelectShoe.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectShoe.ForeColor = System.Drawing.Color.White
        Me.lblSelectShoe.Location = New System.Drawing.Point(233, 134)
        Me.lblSelectShoe.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSelectShoe.Name = "lblSelectShoe"
        Me.lblSelectShoe.Size = New System.Drawing.Size(254, 31)
        Me.lblSelectShoe.TabIndex = 12
        Me.lblSelectShoe.Text = "Select a Runner"
        '
        'lblClassic
        '
        Me.lblClassic.AutoSize = True
        Me.lblClassic.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassic.ForeColor = System.Drawing.Color.White
        Me.lblClassic.Location = New System.Drawing.Point(242, 542)
        Me.lblClassic.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClassic.Name = "lblClassic"
        Me.lblClassic.Size = New System.Drawing.Size(126, 31)
        Me.lblClassic.TabIndex = 14
        Me.lblClassic.Text = "Classic"
        '
        'lblRetro
        '
        Me.lblRetro.AutoSize = True
        Me.lblRetro.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetro.ForeColor = System.Drawing.Color.White
        Me.lblRetro.Location = New System.Drawing.Point(597, 542)
        Me.lblRetro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRetro.Name = "lblRetro"
        Me.lblRetro.Size = New System.Drawing.Size(94, 31)
        Me.lblRetro.TabIndex = 15
        Me.lblRetro.Text = "Retro"
        '
        'lblVintage
        '
        Me.lblVintage.AutoSize = True
        Me.lblVintage.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVintage.ForeColor = System.Drawing.Color.White
        Me.lblVintage.Location = New System.Drawing.Point(920, 542)
        Me.lblVintage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVintage.Name = "lblVintage"
        Me.lblVintage.Size = New System.Drawing.Size(126, 31)
        Me.lblVintage.TabIndex = 16
        Me.lblVintage.Text = "Vintage"
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
        'frmShoeType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1265, 666)
        Me.Controls.Add(Me.picBack)
        Me.Controls.Add(Me.lblVintage)
        Me.Controls.Add(Me.lblRetro)
        Me.Controls.Add(Me.lblClassic)
        Me.Controls.Add(Me.lblSelectShoe)
        Me.Controls.Add(Me.picVintage)
        Me.Controls.Add(Me.picRetro)
        Me.Controls.Add(Me.picClassic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmShoeType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Your Style - Runners"
        CType(Me.picClassic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRetro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVintage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picClassic As PictureBox
    Friend WithEvents picRetro As PictureBox
    Friend WithEvents picVintage As PictureBox
    Friend WithEvents lblSelectShoe As Label
    Friend WithEvents lblClassic As Label
    Friend WithEvents lblRetro As Label
    Friend WithEvents lblVintage As Label
    Friend WithEvents picBack As PictureBox
End Class
