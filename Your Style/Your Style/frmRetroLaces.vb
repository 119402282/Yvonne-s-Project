Public Class frmRetroLaces

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    Private Sub picRetroLaces_Click(sender As Object, e As EventArgs) Handles picRetroLaces.Click

        'Declaring Resource Manager to use to retrieve the images
        'I found this while traversing stack overflow.
        'I haven't seen it since so I can't provide a url
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Making the tick increase each click of the picturebox
        intTick += 1

        'Select Case statement to change the picbox out output
        'It also changes the outputof the label to notify the user of their selection
        'The variable modGlobalVariables.strLacesColor will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        'Here's a video of a similar demo https://youtu.be/FEfST1-9oFk
        Select Case intTick
            Case 1
                picRetroLaces.Image = ResMgr.GetObject("RetroAquaLaces")
                modGlobalVariables.strLacesColor = "Aqua"
                lblRetroLaces.Text = "The selected color for the Retro Laces is: " & modGlobalVariables.strLacesColor
            Case 2
                picRetroLaces.Image = ResMgr.GetObject("RetroBlackLaces")
                modGlobalVariables.strLacesColor = "Black"
                lblRetroLaces.Text = "The selected color for the Retro Laces is: " & modGlobalVariables.strLacesColor
            Case 3
                picRetroLaces.Image = ResMgr.GetObject("RetroBlueLaces")
                modGlobalVariables.strLacesColor = "Blue"
                lblRetroLaces.Text = "The selected color for the Retro Laces is: " & modGlobalVariables.strLacesColor
            Case 4
                picRetroLaces.Image = ResMgr.GetObject("RetroGrayLaces")
                modGlobalVariables.strLacesColor = "Gray"
                lblRetroLaces.Text = "The selected color for the Retro Laces is: " & modGlobalVariables.strLacesColor
            Case 5
                picRetroLaces.Image = ResMgr.GetObject("RetroGreenLaces")
                modGlobalVariables.strLacesColor = "Green"
                lblRetroLaces.Text = "The selected color for the Retro Laces is: " & modGlobalVariables.strLacesColor
            Case 6
                picRetroLaces.Image = ResMgr.GetObject("RetroLimeLaces")
                modGlobalVariables.strLacesColor = "Lime"
                lblRetroLaces.Text = "The selected color for the Retro Laces is: " & modGlobalVariables.strLacesColor
            Case 7
                picRetroLaces.Image = ResMgr.GetObject("RetroPinkLaces")
                modGlobalVariables.strLacesColor = "Pink"
                lblRetroLaces.Text = "The selected color for the Retro Laces is: " & modGlobalVariables.strLacesColor
            Case 8
                picRetroLaces.Image = ResMgr.GetObject("RetroRedLaces")
                modGlobalVariables.strLacesColor = "Red"
                lblRetroLaces.Text = "The selected color for the Retro Laces is: " & modGlobalVariables.strLacesColor
            Case 9
                picRetroLaces.Image = ResMgr.GetObject("RetroWhiteLaces")
                modGlobalVariables.strLacesColor = "White"
                lblRetroLaces.Text = "The selected color for the Retro Laces is: " & modGlobalVariables.strLacesColor
                intTick = 0
        End Select





    End Sub

    Private Sub frmRetroLaces_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picRetroLaces.Image = ResMgr.GetObject("RetroWhiteLaces")
        modGlobalVariables.strLacesColor = "White"
        lblRetroLaces.Text = "The selected color for the Retro Laces is: " & modGlobalVariables.strLacesColor

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Next form
        frmRetroHeelTab.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Going back a form
        frmRetroEyestay.Show()
        Me.Hide()
    End Sub
End Class



