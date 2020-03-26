Public Class frmRetroEyestay

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    'Declaring a string to hold the color value across the different pages
    Public strRetroEyestay As String = " "

    Private Sub picRetroEyestay_Click(sender As Object, e As EventArgs) Handles picRetroEyestay.Click

        'Declaring Resource Manager to use to retrieve the images
        'I found this while traversing stack overflow.
        'I haven't seen it since so I can't provide a url
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Making the tick increase each click of the picturebox
        intTick += 1

        'Select Case statement to change the picbox out output
        'It also changes the outputof the label to notify the user of their selection
        'The variable strRetroEyestay will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        'Here's a video of a similar demo https://youtu.be/FEfST1-9oFk
        Select Case intTick
            Case 1
                picRetroEyestay.Image = ResMgr.GetObject("RetroAquaEyestay")
                strRetroEyestay = "Aqua"
                lblRetroEyestay.Text = "The selected color for the Retro Eyestay is: " & strRetroEyestay
            Case 2
                picRetroEyestay.Image = ResMgr.GetObject("RetroBlackEyestay")
                strRetroEyestay = "Black"
                lblRetroEyestay.Text = "The selected color for the Retro Eyestay is: " & strRetroEyestay
            Case 3
                picRetroEyestay.Image = ResMgr.GetObject("RetroBlueEyestay")
                strRetroEyestay = "Blue"
                lblRetroEyestay.Text = "The selected color for the Retro Eyestay is: " & strRetroEyestay
            Case 4
                picRetroEyestay.Image = ResMgr.GetObject("RetroGrayEyestay")
                strRetroEyestay = "Gray"
                lblRetroEyestay.Text = "The selected color for the Retro Eyestay is: " & strRetroEyestay
            Case 5
                picRetroEyestay.Image = ResMgr.GetObject("RetroGreenEyestay")
                strRetroEyestay = "Green"
                lblRetroEyestay.Text = "The selected color for the Retro Eyestay is: " & strRetroEyestay
            Case 6
                picRetroEyestay.Image = ResMgr.GetObject("RetroLimeEyestay")
                strRetroEyestay = "Lime"
                lblRetroEyestay.Text = "The selected color for the Retro Eyestay is: " & strRetroEyestay
            Case 7
                picRetroEyestay.Image = ResMgr.GetObject("RetroPinkEyestay")
                strRetroEyestay = "Pink"
                lblRetroEyestay.Text = "The selected color for the Retro Eyestay is: " & strRetroEyestay
            Case 8
                picRetroEyestay.Image = ResMgr.GetObject("RetroRedEyestay")
                strRetroEyestay = "Red"
                lblRetroEyestay.Text = "The selected color for the Retro Eyestay is: " & strRetroEyestay
            Case 9
                picRetroEyestay.Image = ResMgr.GetObject("RetroWhiteEyestay")
                strRetroEyestay = "White"
                lblRetroEyestay.Text = "The selected color for the Retro Eyestay is: " & strRetroEyestay
                intTick = 0
        End Select





    End Sub

    Private Sub frmRetroEyestay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picRetroEyestay.Image = ResMgr.GetObject("RetroWhiteEyestay")
        strRetroEyestay = "White"
        lblRetroEyestay.Text = "The selected color for the Retro Eyestay is: " & strRetroEyestay

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Next form
        frmRetroLaces.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Going back a form
        frmRetroVamp.Show()
        Me.Hide()
    End Sub
End Class



