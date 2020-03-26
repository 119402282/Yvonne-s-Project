Public Class frmRetroVamp

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    'Declaring a string to hold the color value across the different pages
    Public strRetroVamp As String = " "

    Private Sub picRetroVamp_Click(sender As Object, e As EventArgs) Handles picRetroVamp.Click

        'Declaring Resource Manager to use to retrieve the images
        'I found this while traversing stack overflow.
        'I haven't seen it since so I can't provide a url
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Making the tick increase each click of the picturebox
        intTick += 1

        'Select Case statement to change the picbox out output
        'It also changes the outputof the label to notify the user of their selection
        'The variable strRetroVamp will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        'Here's a video of a similar demo https://youtu.be/FEfST1-9oFk
        Select Case intTick
            Case 1
                picRetroVamp.Image = ResMgr.GetObject("RetroAquaVamp")
                strRetroVamp = "Aqua"
                lblRetroVamp.Text = "The selected color for the Retro Vamp is: " & strRetroVamp
            Case 2
                picRetroVamp.Image = ResMgr.GetObject("RetroBlackVamp")
                strRetroVamp = "Black"
                lblRetroVamp.Text = "The selected color for the Retro Vamp is: " & strRetroVamp
            Case 3
                picRetroVamp.Image = ResMgr.GetObject("RetroBlueVamp")
                strRetroVamp = "Blue"
                lblRetroVamp.Text = "The selected color for the Retro Vamp is: " & strRetroVamp
            Case 4
                picRetroVamp.Image = ResMgr.GetObject("RetroGrayVamp")
                strRetroVamp = "Gray"
                lblRetroVamp.Text = "The selected color for the Retro Vamp is: " & strRetroVamp
            Case 5
                picRetroVamp.Image = ResMgr.GetObject("RetroGreenVamp")
                strRetroVamp = "Green"
                lblRetroVamp.Text = "The selected color for the Retro Vamp is: " & strRetroVamp
            Case 6
                picRetroVamp.Image = ResMgr.GetObject("RetroLimeVamp")
                strRetroVamp = "Lime"
                lblRetroVamp.Text = "The selected color for the Retro Vamp is: " & strRetroVamp
            Case 7
                picRetroVamp.Image = ResMgr.GetObject("RetroPinkVamp")
                strRetroVamp = "Pink"
                lblRetroVamp.Text = "The selected color for the Retro Vamp is: " & strRetroVamp
            Case 8
                picRetroVamp.Image = ResMgr.GetObject("RetroRedVamp")
                strRetroVamp = "Red"
                lblRetroVamp.Text = "The selected color for the Retro Vamp is: " & strRetroVamp
            Case 9
                picRetroVamp.Image = ResMgr.GetObject("RetroWhiteVamp")
                strRetroVamp = "White"
                lblRetroVamp.Text = "The selected color for the Retro Vamp is: " & strRetroVamp
                intTick = 0
        End Select





    End Sub

    Private Sub frmRetroVamp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picRetroVamp.Image = ResMgr.GetObject("RetroWhiteVamp")
        strRetroVamp = "White"
        lblRetroVamp.Text = "The selected color for the Retro Vamp is: " & strRetroVamp

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Next form
        frmRetroEyestay.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Going back a form
        frmRetroQuarter.Show()
        Me.Hide()
    End Sub
End Class



