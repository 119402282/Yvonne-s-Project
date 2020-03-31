Public Class frmVintageEyestay

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    Private Sub picVintageEyestay_Click(sender As Object, e As EventArgs) Handles picVintageEyestay.Click

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
                picVintageEyestay.Image = ResMgr.GetObject("VintageAquaEyestay")
                modGlobalVariables.strEyestayColor = "Aqua"
                lblVintageEyestay.Text = "The selected color for the Vintage Eyestay is: " & modGlobalVariables.strEyestayColor
            Case 2
                picVintageEyestay.Image = ResMgr.GetObject("VintageBlackEyestay")
                modGlobalVariables.strEyestayColor = "Black"
                lblVintageEyestay.Text = "The selected color for the Vintage Eyestay is: " & modGlobalVariables.strEyestayColor
            Case 3
                picVintageEyestay.Image = ResMgr.GetObject("VintageBlueEyestay")
                modGlobalVariables.strEyestayColor = "Blue"
                lblVintageEyestay.Text = "The selected color for the Vintage Eyestay is: " & modGlobalVariables.strEyestayColor
            Case 4
                picVintageEyestay.Image = ResMgr.GetObject("VintageGrayEyestay")
                modGlobalVariables.strEyestayColor = "Gray"
                lblVintageEyestay.Text = "The selected color for the Vintage Eyestay is: " & modGlobalVariables.strEyestayColor
            Case 5
                picVintageEyestay.Image = ResMgr.GetObject("VintageGreenEyestay")
                modGlobalVariables.strEyestayColor = "Green"
                lblVintageEyestay.Text = "The selected color for the Vintage Eyestay is: " & modGlobalVariables.strEyestayColor
            Case 6
                picVintageEyestay.Image = ResMgr.GetObject("VintageLimeEyestay")
                modGlobalVariables.strEyestayColor = "Lime"
                lblVintageEyestay.Text = "The selected color for the Vintage Eyestay is: " & modGlobalVariables.strEyestayColor
            Case 7
                picVintageEyestay.Image = ResMgr.GetObject("VintagePinkEyestay")
                modGlobalVariables.strEyestayColor = "Pink"
                lblVintageEyestay.Text = "The selected color for the Vintage Eyestay is: " & modGlobalVariables.strEyestayColor
            Case 8
                picVintageEyestay.Image = ResMgr.GetObject("VintageRedEyestay")
                modGlobalVariables.strEyestayColor = "Red"
                lblVintageEyestay.Text = "The selected color for the Vintage Eyestay is: " & modGlobalVariables.strEyestayColor
            Case 9
                picVintageEyestay.Image = ResMgr.GetObject("VintageWhiteEyestay")
                modGlobalVariables.strEyestayColor = "White"
                lblVintageEyestay.Text = "The selected color for the Vintage Eyestay is: " & modGlobalVariables.strEyestayColor
                intTick = 0
        End Select





    End Sub

    Private Sub frmVintageEyestay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picVintageEyestay.Image = ResMgr.GetObject("VintageWhiteEyestay")
        modGlobalVariables.strEyestayColor = "White"
        lblVintageEyestay.Text = "The selected color for the Vintage Eyestay is: " & modGlobalVariables.strEyestayColor

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Next form
        frmVintageLaces.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Going back a form
        frmVintageVamp.Show()
        Me.Hide()
    End Sub
End Class

