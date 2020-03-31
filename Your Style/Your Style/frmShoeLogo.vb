Public Class frmShoeLogo
    Public Function ImagesFolder()

        'This took me a decent hour or two 
        'I finally found a work around so that the file location would be the same on all computers that would run my program
        'I punched the air when it finally worked!!
        'Finds the index where "\Your Style\Your Style\bin\" is within the file path
        Dim intIndex As Integer = My.Application.Info.DirectoryPath.IndexOf("\Your Style\Your Style\bin\")
        'Shortens the path to a parent directory in the project folder
        Dim strPath As String = My.Application.Info.DirectoryPath.Substring(0, intIndex)
        'Adds the sub-directories to give us the path name for the folder I want, in this case: Images for logo
        Return strPath = strPath & "\Your Style\Images for logo\"

    End Function

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Go back a form
        frmShoeText.Show()
        Me.Hide()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        ' I learned about Open File Dialogs here: https://youtu.be/-yMo8apiMdM
        ofdLogo.InitialDirectory = ImagesFolder()
        ofdLogo.Title = "Select Logo Image"
        ofdLogo.ShowDialog()
        txtLogo.Text = ofdLogo.FileName
        picLogo.Image = Image.FromFile(ofdLogo.FileName)
    End Sub

    Private Sub chkLogo_CheckedChanged(sender As Object, e As EventArgs) Handles chkLogo.CheckedChanged
        'Validation for all the items on the form
        If chkLogo.Checked = True Then
            txtLogo.Enabled = True
            lblLocate.Enabled = True
            lblLogo.Enabled = True
            btnBrowse.Enabled = True
            picLogo.Visible = True
        Else
            picLogo.Visible = False
            picLogo.Image = Nothing
            txtLogo.Enabled = False
            lblLocate.Enabled = False
            lblLogo.Enabled = False
            btnBrowse.Enabled = False
            txtLogo.Text = ""
        End If
    End Sub

    Private Sub frmShoeLogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Validation on loadup
        chkLogo.Checked = False
        txtLogo.Enabled = False
        lblLocate.Enabled = False
        lblLogo.Enabled = False
        btnBrowse.Enabled = False
        txtLogo.Text = ""
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'User warning about shoe logo
        MessageBox.Show("If you have checked the logo checkbox but have not selected a logo you will still be charged even though your shoe will have no logo.", "Logo Disclaimer")
        'Next form
        'frmBill.Show()
        Me.Hide()
    End Sub
End Class