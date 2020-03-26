Public Class frmShoeType
    Private Sub picClassic_Click(sender As Object, e As EventArgs) Handles picClassic.Click
        'Clicking on the shoe brings you to the customization
        frmClassicQuarter.Show()
        Me.Hide()

    End Sub

    Private Sub picRetro_Click(sender As Object, e As EventArgs) Handles picRetro.Click
        'Clicking on the shoe brings you to the customization
        frmRetroQuarter.Show()
        Me.Hide()

    End Sub

    Private Sub picVintage_Click(sender As Object, e As EventArgs) Handles picVintage.Click
        'Clicking on the shoe brings you to the customization
        frmVintageQuarter.Show()
        Me.Hide()

    End Sub
End Class