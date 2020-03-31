Public Class frmClassicEyestay

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    Private Sub picClassicEyestay_Click(sender As Object, e As EventArgs) Handles picClassicEyestay.Click

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
        'The variable modGlobalVariables.strEyestayColor will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        Select Case intTick
            Case 1
                picClassicEyestay.Image = ResMgr.GetObject("ClassicAquaEyestay")
                modGlobalVariables.strEyestayColor = "Aqua"
                lblClassicEyestay.Text = "The selected color for the Classic Eyestay is: " & modGlobalVariables.strEyestayColor
            Case 2
                picClassicEyestay.Image = ResMgr.GetObject("ClassicBlackEyestay")
                modGlobalVariables.strEyestayColor = "Black"
                lblClassicEyestay.Text = "The selected color for the Classic Eyestay is: " & modGlobalVariables.strEyestayColor
            Case 3
                picClassicEyestay.Image = ResMgr.GetObject("ClassicBlueEyestay")
                modGlobalVariables.strEyestayColor = "Blue"
                lblClassicEyestay.Text = "The selected color for the Classic Eyestay is: " & modGlobalVariables.strEyestayColor
            Case 4
                picClassicEyestay.Image = ResMgr.GetObject("ClassicGrayEyestay")
                modGlobalVariables.strEyestayColor = "Gray"
                lblClassicEyestay.Text = "The selected color for the Classic Eyestay is: " & modGlobalVariables.strEyestayColor
            Case 5
                picClassicEyestay.Image = ResMgr.GetObject("ClassicGreenEyestay")
                modGlobalVariables.strEyestayColor = "Green"
                lblClassicEyestay.Text = "The selected color for the Classic Eyestay is: " & modGlobalVariables.strEyestayColor
            Case 6
                picClassicEyestay.Image = ResMgr.GetObject("ClassicLimeEyestay")
                modGlobalVariables.strEyestayColor = "Lime"
                lblClassicEyestay.Text = "The selected color for the Classic Eyestay is: " & modGlobalVariables.strEyestayColor
            Case 7
                picClassicEyestay.Image = ResMgr.GetObject("ClassicPinkEyestay")
                modGlobalVariables.strEyestayColor = "Pink"
                lblClassicEyestay.Text = "The selected color for the Classic Eyestay is: " & modGlobalVariables.strEyestayColor
            Case 8
                picClassicEyestay.Image = ResMgr.GetObject("ClassicRedEyestay")
                modGlobalVariables.strEyestayColor = "Red"
                lblClassicEyestay.Text = "The selected color for the Classic Eyestay is: " & modGlobalVariables.strEyestayColor
            Case 9
                picClassicEyestay.Image = ResMgr.GetObject("ClassicWhiteEyestay")
                modGlobalVariables.strEyestayColor = "White"
                lblClassicEyestay.Text = "The selected color for the Classic Eyestay is: " & modGlobalVariables.strEyestayColor
                intTick = 0
        End Select





    End Sub

    Private Sub frmClassicEyestay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picClassicEyestay.Image = ResMgr.GetObject("ClassicWhiteEyestay")
        modGlobalVariables.strEyestayColor = "White"
        lblClassicEyestay.Text = "The selected color for the Classic Eyestay is: " & modGlobalVariables.strEyestayColor

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Next form
        frmClassicLaces.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Going back a form
        frmClassicVamp.Show()
        Me.Hide()
    End Sub
End Class

