Public Class frmRetroVamp

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

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
        'The variable modGlobalVariables.strVampColor will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        'Here's a video of a similar demo https://youtu.be/FEfST1-9oFk
        Select Case intTick
            Case 1
                picRetroVamp.Image = ResMgr.GetObject("RetroAquaVamp")
                modGlobalVariables.strVampColor = "Aqua"
                lblRetroVamp.Text = "The selected color for the Retro Vamp is: " & modGlobalVariables.strVampColor
            Case 2
                picRetroVamp.Image = ResMgr.GetObject("RetroBlackVamp")
                modGlobalVariables.strVampColor = "Black"
                lblRetroVamp.Text = "The selected color for the Retro Vamp is: " & modGlobalVariables.strVampColor
            Case 3
                picRetroVamp.Image = ResMgr.GetObject("RetroBlueVamp")
                modGlobalVariables.strVampColor = "Blue"
                lblRetroVamp.Text = "The selected color for the Retro Vamp is: " & modGlobalVariables.strVampColor
            Case 4
                picRetroVamp.Image = ResMgr.GetObject("RetroGrayVamp")
                modGlobalVariables.strVampColor = "Gray"
                lblRetroVamp.Text = "The selected color for the Retro Vamp is: " & modGlobalVariables.strVampColor
            Case 5
                picRetroVamp.Image = ResMgr.GetObject("RetroGreenVamp")
                modGlobalVariables.strVampColor = "Green"
                lblRetroVamp.Text = "The selected color for the Retro Vamp is: " & modGlobalVariables.strVampColor
            Case 6
                picRetroVamp.Image = ResMgr.GetObject("RetroLimeVamp")
                modGlobalVariables.strVampColor = "Lime"
                lblRetroVamp.Text = "The selected color for the Retro Vamp is: " & modGlobalVariables.strVampColor
            Case 7
                picRetroVamp.Image = ResMgr.GetObject("RetroPinkVamp")
                modGlobalVariables.strVampColor = "Pink"
                lblRetroVamp.Text = "The selected color for the Retro Vamp is: " & modGlobalVariables.strVampColor
            Case 8
                picRetroVamp.Image = ResMgr.GetObject("RetroRedVamp")
                modGlobalVariables.strVampColor = "Red"
                lblRetroVamp.Text = "The selected color for the Retro Vamp is: " & modGlobalVariables.strVampColor
            Case 9
                picRetroVamp.Image = ResMgr.GetObject("RetroWhiteVamp")
                modGlobalVariables.strVampColor = "White"
                lblRetroVamp.Text = "The selected color for the Retro Vamp is: " & modGlobalVariables.strVampColor
                intTick = 0
        End Select





    End Sub

    Private Sub frmRetroVamp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picRetroVamp.Image = ResMgr.GetObject("RetroWhiteVamp")
        modGlobalVariables.strVampColor = "White"
        lblRetroVamp.Text = "The selected color for the Retro Vamp is: " & modGlobalVariables.strVampColor

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



