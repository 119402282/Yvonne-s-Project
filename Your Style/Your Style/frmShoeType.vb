Public Class frmShoeType
    Private Sub picClassic_Click(sender As Object, e As EventArgs) Handles picClassic.Click

        'Value of shoe chosen is passed on through a public string
        modGlobalVariables.strShoeType = "Classic"
        'Clicking on the shoe brings you to the customization
        frmClassicQuarter.Show()
        Me.Hide()

    End Sub

    Private Sub picRetro_Click(sender As Object, e As EventArgs) Handles picRetro.Click

        'Value of shoe chosen is passed on through a public string
        modGlobalVariables.strShoeType = "Retro"
        'Clicking on the shoe brings you to the customization
        frmRetroQuarter.Show()
        Me.Hide()

    End Sub

    Private Sub picVintage_Click(sender As Object, e As EventArgs) Handles picVintage.Click

        'Value of shoe chosen is passed on through a public string
        modGlobalVariables.strShoeType = "Vintage"
        'Clicking on the shoe brings you to the customization
        frmVintageQuarter.Show()
        Me.Hide()

    End Sub

    Private Sub frmShoeType_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Closing the text form to reset the values
        frmShoeText.Close()
        frmShoeLogo.Close()
        modGlobalVariables.strShoeType = ""
    End Sub

End Class