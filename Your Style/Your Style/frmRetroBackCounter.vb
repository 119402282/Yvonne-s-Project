Public Class frmRetroBackCounter

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    'Declaring a string to hold the color value across the different pages
    Public strRetroBackCounter As String = " "

    Private Sub picRetroBackCounter_Click(sender As Object, e As EventArgs) Handles picRetroBackCounter.Click

        'Declaring Resource Manager to use to retrieve the images
        'I found this while traversing stack overflow.
        'I haven't seen it since so I can't provide a url
        'Here's a video of a similar demo https://youtu.be/FEfST1-9oFk
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Making the tick increase each click of the picturebox
        intTick += 1

        'Select Case statement to change the picbox out output
        'It also changes the outputof the label to notify the user of their selection
        'The variable strRetroBackCounter will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        Select Case intTick
            Case 1
                picRetroBackCounter.Image = ResMgr.GetObject("RetroAquaBackCounter")
                strRetroBackCounter = "Aqua"
                lblRetroBackCounter.Text = "The selected color for the Retro Back Counter is: " & strRetroBackCounter
            Case 2
                picRetroBackCounter.Image = ResMgr.GetObject("RetroBlackBackCounter")
                strRetroBackCounter = "Black"
                lblRetroBackCounter.Text = "The selected color for the Retro Back Counter is: " & strRetroBackCounter
            Case 3
                picRetroBackCounter.Image = ResMgr.GetObject("RetroBlueBackCounter")
                strRetroBackCounter = "Blue"
                lblRetroBackCounter.Text = "The selected color for the Retro Back Counter is: " & strRetroBackCounter
            Case 4
                picRetroBackCounter.Image = ResMgr.GetObject("RetroGrayBackCounter")
                strRetroBackCounter = "Gray"
                lblRetroBackCounter.Text = "The selected color for the Retro Back Counter is: " & strRetroBackCounter
            Case 5
                picRetroBackCounter.Image = ResMgr.GetObject("RetroGreenBackCounter")
                strRetroBackCounter = "Green"
                lblRetroBackCounter.Text = "The selected color for the Retro Back Counter is: " & strRetroBackCounter
            Case 6
                picRetroBackCounter.Image = ResMgr.GetObject("RetroLimeBackCounter")
                strRetroBackCounter = "Lime"
                lblRetroBackCounter.Text = "The selected color for the Retro Back Counter is: " & strRetroBackCounter
            Case 7
                picRetroBackCounter.Image = ResMgr.GetObject("RetroPinkBackCounter")
                strRetroBackCounter = "Pink"
                lblRetroBackCounter.Text = "The selected color for the Retro Back Counter is: " & strRetroBackCounter
            Case 8
                picRetroBackCounter.Image = ResMgr.GetObject("RetroRedBackCounter")
                strRetroBackCounter = "Red"
                lblRetroBackCounter.Text = "The selected color for the Retro Back Counter is: " & strRetroBackCounter
            Case 9
                picRetroBackCounter.Image = ResMgr.GetObject("RetroWhiteBackCounter")
                strRetroBackCounter = "White"
                lblRetroBackCounter.Text = "The selected color for the Retro Back Counter is: " & strRetroBackCounter
                intTick = 0
        End Select





    End Sub

    Private Sub frmRetroBackCounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picRetroBackCounter.Image = ResMgr.GetObject("RetroWhiteBackCounter")
        strRetroBackCounter = "White"
        lblRetroBackCounter.Text = "The selected color for the Retro Back Counter is: " & strRetroBackCounter

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Next form
        'frmRetroText.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Going back a form
        frmRetroHeelTab.Show()
        Me.Hide()
    End Sub
End Class



