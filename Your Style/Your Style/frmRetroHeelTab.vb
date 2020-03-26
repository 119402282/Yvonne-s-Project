Public Class frmRetroHeelTab

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    'Declaring a string to hold the color value across the different pages
    Public strRetroHeelTab As String = " "

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
        'The variable strRetroHeelTab will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        'Here's a video of a similar demo https://youtu.be/FEfST1-9oFk
        Select Case intTick
            Case 1
                picRetroHeelTab.Image = ResMgr.GetObject("RetroAquaHeelTab")
                strRetroHeelTab = "Aqua"
                lblRetroHeelTab.Text = "The selected color for the Retro Heel Tab is: " & strRetroHeelTab
            Case 2
                picRetroHeelTab.Image = ResMgr.GetObject("RetroBlackHeelTab")
                strRetroHeelTab = "Black"
                lblRetroHeelTab.Text = "The selected color for the Retro Heel Tab is: " & strRetroHeelTab
            Case 3
                picRetroHeelTab.Image = ResMgr.GetObject("RetroBlueHeelTab")
                strRetroHeelTab = "Blue"
                lblRetroHeelTab.Text = "The selected color for the Retro Heel Tab is: " & strRetroHeelTab
            Case 4
                picRetroHeelTab.Image = ResMgr.GetObject("RetroGrayHeelTab")
                strRetroHeelTab = "Gray"
                lblRetroHeelTab.Text = "The selected color for the Retro Heel Tab is: " & strRetroHeelTab
            Case 5
                picRetroHeelTab.Image = ResMgr.GetObject("RetroGreenHeelTab")
                strRetroHeelTab = "Green"
                lblRetroHeelTab.Text = "The selected color for the Retro Heel Tab is: " & strRetroHeelTab
            Case 6
                picRetroHeelTab.Image = ResMgr.GetObject("RetroLimeHeelTab")
                strRetroHeelTab = "Lime"
                lblRetroHeelTab.Text = "The selected color for the Retro Heel Tab is: " & strRetroHeelTab
            Case 7
                picRetroHeelTab.Image = ResMgr.GetObject("RetroPinkHeelTab")
                strRetroHeelTab = "Pink"
                lblRetroHeelTab.Text = "The selected color for the Retro Heel Tab is: " & strRetroHeelTab
            Case 8
                picRetroHeelTab.Image = ResMgr.GetObject("RetroRedHeelTab")
                strRetroHeelTab = "Red"
                lblRetroHeelTab.Text = "The selected color for the Retro Heel Tab is: " & strRetroHeelTab
            Case 9
                picRetroHeelTab.Image = ResMgr.GetObject("RetroWhiteHeelTab")
                strRetroHeelTab = "White"
                lblRetroHeelTab.Text = "The selected color for the Retro Heel Tab is: " & strRetroHeelTab
                intTick = 0
        End Select





    End Sub

    Private Sub frmRetroHeelTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picRetroHeelTab.Image = ResMgr.GetObject("RetroWhiteHeelTab")
        strRetroHeelTab = "White"
        lblRetroHeelTab.Text = "The selected color for the Retro Heel Tab is: " & strRetroHeelTab

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



