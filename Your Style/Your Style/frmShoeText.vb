'Also in the youtube video https://youtu.be/Lzc56H6MTbI
Imports System.Drawing.Text

Public Class frmShoeText
    Dim intFontSize As Integer = 12

    Private Sub frmShoeText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Validation for objects on the form
        cmbFont.Enabled = False
        cmbStyle.Enabled = False
        trkFontSize.Enabled = False
        picColor.Enabled = False
        txtInput.Enabled = False
        lblColor.Enabled = False
        lblEnterText.Enabled = False
        lblFont.Enabled = False
        lblResult.Enabled = False
        lblSize.Enabled = False
        lblStyle.Enabled = False

        'This is something I found on youtube https://youtu.be/Lzc56H6MTbI
        'It populates the cmbFont with all installed fonts on the computer
        Dim Fonts As New InstalledFontCollection
        For Each FontName As FontFamily In Fonts.Families
            cmbFont.Items.Add(FontName.Name)
        Next
    End Sub



    Private Sub cmbStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStyle.SelectedIndexChanged

        'Updates the label and Fontsize when the style is changed
        intFontSize = trkFontSize.Value
        If cmbStyle.Text = "Regular" Then
            lblResult.Font = New Font(cmbFont.Text, intFontSize, FontStyle.Regular)
        ElseIf cmbStyle.Text = "Bold" Then
            lblResult.Font = New Font(cmbFont.Text, intFontSize, FontStyle.Bold)
        ElseIf cmbStyle.Text = "Italic" Then
            lblResult.Font = New Font(cmbFont.Text, intFontSize, FontStyle.Italic)
        End If

    End Sub

    Private Sub cmbFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFont.SelectedIndexChanged

        'Updates the label and Fontsize when the font is changed
        intFontSize = trkFontSize.Value
        If cmbStyle.Text = "Regular" Then
            lblResult.Font = New Font(cmbFont.Text, intFontSize, FontStyle.Regular)
        ElseIf cmbStyle.Text = "Bold" Then
            lblResult.Font = New Font(cmbFont.Text, intFontSize, FontStyle.Bold)
        ElseIf cmbStyle.Text = "Italic" Then
            lblResult.Font = New Font(cmbFont.Text, intFontSize, FontStyle.Italic)
        End If

    End Sub


    Private Sub trkFontSize_ValueChanged(sender As Object, e As EventArgs) Handles trkFontSize.ValueChanged

        'Updates the label and Fontsize when the trackbar value is changed is changed
        intFontSize = trkFontSize.Value
        If cmbStyle.Text = "Regular" Then
            lblResult.Font = New Font(cmbFont.Text, intFontSize, FontStyle.Regular)
        ElseIf cmbStyle.Text = "Bold" Then
            lblResult.Font = New Font(cmbFont.Text, intFontSize, FontStyle.Bold)
        ElseIf cmbStyle.Text = "Italic" Then
            lblResult.Font = New Font(cmbFont.Text, intFontSize, FontStyle.Italic)
        End If

    End Sub

    Private Sub txtInput_MouseDown(sender As Object, e As MouseEventArgs) Handles txtInput.MouseDown
        'Output the text when the user clicks in
        lblResult.Text = txtInput.Text

    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        'output the text as it changes
        lblResult.Text = txtInput.Text
    End Sub

    Private Sub picColor_Click(sender As Object, e As EventArgs) Handles picColor.Click

        'I found this in the same video https://youtu.be/Lzc56H6MTbI
        'It allows the user to select a color through a dialog box
        Dim dlgColor As New ColorDialog
        If dlgColor.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblResult.ForeColor = dlgColor.Color
        End If
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click

        Select Case modGlobalVariables.strShoeType
            Case "Classic"
                'Going back a form when the user has selected Classic
                frmClassicBackCounter.Show()
                Me.Hide()
            Case "Retro"
                'Going back a form when the user has selected Retro
                frmRetroBackCounter.Show()
                Me.Hide()
            Case "Vintage"
                'Going back a form when the user has selected Vintage
                frmVintageBackCounter.Show()
                Me.Hide()
            Case Else
                'Returning to the first form for any exceptions
                frmShoeType.Show()
                Me.Close()
        End Select

    End Sub

    Private Sub chkText_CheckedChanged(sender As Object, e As EventArgs) Handles chkText.CheckedChanged
        'Validation so that text styling must be on an opt in basis
        'Also reseting to format and selections that appear on load up
        If chkText.Checked = True Then
            cmbFont.Enabled = True
            cmbStyle.Enabled = True
            trkFontSize.Enabled = True
            picColor.Enabled = True
            txtInput.Enabled = True
            lblColor.Enabled = True
            lblEnterText.Enabled = True
            lblFont.Enabled = True
            lblResult.Enabled = True
            lblSize.Enabled = True
            lblStyle.Enabled = True
        Else
            cmbFont.Enabled = False
            cmbFont.SelectedItem = "Calibri"
            cmbStyle.Enabled = False
            cmbStyle.SelectedItem = "Regular"
            trkFontSize.Enabled = False
            trkFontSize.Value = 12
            intFontSize = 12
            picColor.Enabled = False
            txtInput.Enabled = False
            txtInput.Text = " "
            lblColor.Enabled = False
            lblResult.Text = "Text Here"
            lblColor.ForeColor = Color.White
            lblEnterText.Enabled = False
            lblFont.Enabled = False
            lblResult.Enabled = False
            lblSize.Enabled = False
            lblStyle.Enabled = False
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Next form
        frmShoeLogo.Show()
        Me.Hide()
    End Sub
End Class