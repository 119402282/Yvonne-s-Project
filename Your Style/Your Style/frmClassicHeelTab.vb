Public Class frmClassicHeelTab

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    Private Sub picClassicHeelTab_Click(sender As Object, e As EventArgs) Handles picClassicHeelTab.Click

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
                picClassicHeelTab.Image = ResMgr.GetObject("ClassicAquaHeelTab")
                modGlobalVariables.strHeelTabColor = "Aqua"
                lblClassicHeelTab.Text = "The selected color for the Classic Heel Tab is: " & modGlobalVariables.strHeelTabColor
            Case 2
                picClassicHeelTab.Image = ResMgr.GetObject("ClassicBlackHeelTab")
                modGlobalVariables.strHeelTabColor = "Black"
                lblClassicHeelTab.Text = "The selected color for the Classic Heel Tab is: " & modGlobalVariables.strHeelTabColor
            Case 3
                picClassicHeelTab.Image = ResMgr.GetObject("ClassicBlueHeelTab")
                modGlobalVariables.strHeelTabColor = "Blue"
                lblClassicHeelTab.Text = "The selected color for the Classic Heel Tab is: " & modGlobalVariables.strHeelTabColor
            Case 4
                picClassicHeelTab.Image = ResMgr.GetObject("ClassicGrayHeelTab")
                modGlobalVariables.strHeelTabColor = "Gray"
                lblClassicHeelTab.Text = "The selected color for the Classic Heel Tab is: " & modGlobalVariables.strHeelTabColor
            Case 5
                picClassicHeelTab.Image = ResMgr.GetObject("ClassicGreenHeelTab")
                modGlobalVariables.strHeelTabColor = "Green"
                lblClassicHeelTab.Text = "The selected color for the Classic Heel Tab is: " & modGlobalVariables.strHeelTabColor
            Case 6
                picClassicHeelTab.Image = ResMgr.GetObject("ClassicLimeHeelTab")
                modGlobalVariables.strHeelTabColor = "Lime"
                lblClassicHeelTab.Text = "The selected color for the Classic Heel Tab is: " & modGlobalVariables.strHeelTabColor
            Case 7
                picClassicHeelTab.Image = ResMgr.GetObject("ClassicPinkHeelTab")
                modGlobalVariables.strHeelTabColor = "Pink"
                lblClassicHeelTab.Text = "The selected color for the Classic Heel Tab is: " & modGlobalVariables.strHeelTabColor
            Case 8
                picClassicHeelTab.Image = ResMgr.GetObject("ClassicRedHeelTab")
                modGlobalVariables.strHeelTabColor = "Red"
                lblClassicHeelTab.Text = "The selected color for the Classic Heel Tab is: " & modGlobalVariables.strHeelTabColor
            Case 9
                picClassicHeelTab.Image = ResMgr.GetObject("ClassicWhiteHeelTab")
                modGlobalVariables.strHeelTabColor = "White"
                lblClassicHeelTab.Text = "The selected color for the Classic Heel Tab is: " & modGlobalVariables.strHeelTabColor
                intTick = 0
        End Select





    End Sub

    Private Sub frmClassicHeelTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picClassicHeelTab.Image = ResMgr.GetObject("ClassicWhiteHeelTab")
        modGlobalVariables.strHeelTabColor = "White"
        lblClassicHeelTab.Text = "The selected color for the Classic Heel Tab is: " & modGlobalVariables.strHeelTabColor

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Next form
        frmClassicBackCounter.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Going back a form
        frmClassicLaces.Show()
        Me.Hide()
    End Sub
End Class



