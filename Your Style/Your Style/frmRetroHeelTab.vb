Public Class frmRetroHeelTab

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    Private Sub picRetroHeelTab_Click(sender As Object, e As EventArgs) Handles picRetroHeelTab.Click

        'Declaring Resource Manager to use to retrieve the images
        'I found this while traversing stack overflow.
        'I haven't seen it since so I can't provide a url
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Making the tick increase each click of the picturebox
        intTick += 1

        'Select Case statement to change the picbox out output
        'It also changes the outputof the label to notify the user of their selection
        'The variable modGlobalVariables.strHeelTabColor will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        'Here's a video of a similar demo https://youtu.be/FEfST1-9oFk
        Select Case intTick
            Case 1
                picRetroHeelTab.Image = ResMgr.GetObject("RetroAquaHeelTab")
                modGlobalVariables.strHeelTabColor = "Aqua"
                lblRetroHeelTab.Text = "The selected color for the Retro Heel Tab is: " & modGlobalVariables.strHeelTabColor
            Case 2
                picRetroHeelTab.Image = ResMgr.GetObject("RetroBlackHeelTab")
                modGlobalVariables.strHeelTabColor = "Black"
                lblRetroHeelTab.Text = "The selected color for the Retro Heel Tab is: " & modGlobalVariables.strHeelTabColor
            Case 3
                picRetroHeelTab.Image = ResMgr.GetObject("RetroBlueHeelTab")
                modGlobalVariables.strHeelTabColor = "Blue"
                lblRetroHeelTab.Text = "The selected color for the Retro Heel Tab is: " & modGlobalVariables.strHeelTabColor
            Case 4
                picRetroHeelTab.Image = ResMgr.GetObject("RetroGrayHeelTab")
                modGlobalVariables.strHeelTabColor = "Gray"
                lblRetroHeelTab.Text = "The selected color for the Retro Heel Tab is: " & modGlobalVariables.strHeelTabColor
            Case 5
                picRetroHeelTab.Image = ResMgr.GetObject("RetroGreenHeelTab")
                modGlobalVariables.strHeelTabColor = "Green"
                lblRetroHeelTab.Text = "The selected color for the Retro Heel Tab is: " & modGlobalVariables.strHeelTabColor
            Case 6
                picRetroHeelTab.Image = ResMgr.GetObject("RetroLimeHeelTab")
                modGlobalVariables.strHeelTabColor = "Lime"
                lblRetroHeelTab.Text = "The selected color for the Retro Heel Tab is: " & modGlobalVariables.strHeelTabColor
            Case 7
                picRetroHeelTab.Image = ResMgr.GetObject("RetroPinkHeelTab")
                modGlobalVariables.strHeelTabColor = "Pink"
                lblRetroHeelTab.Text = "The selected color for the Retro Heel Tab is: " & modGlobalVariables.strHeelTabColor
            Case 8
                picRetroHeelTab.Image = ResMgr.GetObject("RetroRedHeelTab")
                modGlobalVariables.strHeelTabColor = "Red"
                lblRetroHeelTab.Text = "The selected color for the Retro Heel Tab is: " & modGlobalVariables.strHeelTabColor
            Case 9
                picRetroHeelTab.Image = ResMgr.GetObject("RetroWhiteHeelTab")
                modGlobalVariables.strHeelTabColor = "White"
                lblRetroHeelTab.Text = "The selected color for the Retro Heel Tab is: " & modGlobalVariables.strHeelTabColor
                intTick = 0
        End Select





    End Sub

    Private Sub frmRetroHeelTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picRetroHeelTab.Image = ResMgr.GetObject("RetroWhiteHeelTab")
        modGlobalVariables.strHeelTabColor = "White"
        lblRetroHeelTab.Text = "The selected color for the Retro Heel Tab is: " & modGlobalVariables.strHeelTabColor

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Next form
        frmRetroBackCounter.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Going back a form
        frmRetroLaces.Show()
        Me.Hide()
    End Sub
End Class



