Public Class frmVintageLaces

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    Private Sub picVintageLaces_Click(sender As Object, e As EventArgs) Handles picVintageLaces.Click

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
        'The variable modGlobalVariables.strLacesColor will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        Select Case intTick
            Case 1
                picVintageLaces.Image = ResMgr.GetObject("VintageAquaLaces")
                modGlobalVariables.strLacesColor = "Aqua"
                lblVintageLaces.Text = "The selected color for the Vintage Laces is: " & modGlobalVariables.strLacesColor
            Case 2
                picVintageLaces.Image = ResMgr.GetObject("VintageBlackLaces")
                modGlobalVariables.strLacesColor = "Black"
                lblVintageLaces.Text = "The selected color for the Vintage Laces is: " & modGlobalVariables.strLacesColor
            Case 3
                picVintageLaces.Image = ResMgr.GetObject("VintageBlueLaces")
                modGlobalVariables.strLacesColor = "Blue"
                lblVintageLaces.Text = "The selected color for the Vintage Laces is: " & modGlobalVariables.strLacesColor
            Case 4
                picVintageLaces.Image = ResMgr.GetObject("VintageGrayLaces")
                modGlobalVariables.strLacesColor = "Gray"
                lblVintageLaces.Text = "The selected color for the Vintage Laces is: " & modGlobalVariables.strLacesColor
            Case 5
                picVintageLaces.Image = ResMgr.GetObject("VintageGreenLaces")
                modGlobalVariables.strLacesColor = "Green"
                lblVintageLaces.Text = "The selected color for the Vintage Laces is: " & modGlobalVariables.strLacesColor
            Case 6
                picVintageLaces.Image = ResMgr.GetObject("VintageLimeLaces")
                modGlobalVariables.strLacesColor = "Lime"
                lblVintageLaces.Text = "The selected color for the Vintage Laces is: " & modGlobalVariables.strLacesColor
            Case 7
                picVintageLaces.Image = ResMgr.GetObject("VintagePinkLaces")
                modGlobalVariables.strLacesColor = "Pink"
                lblVintageLaces.Text = "The selected color for the Vintage Laces is: " & modGlobalVariables.strLacesColor
            Case 8
                picVintageLaces.Image = ResMgr.GetObject("VintageRedLaces")
                modGlobalVariables.strLacesColor = "Red"
                lblVintageLaces.Text = "The selected color for the Vintage Laces is: " & modGlobalVariables.strLacesColor
            Case 9
                picVintageLaces.Image = ResMgr.GetObject("VintageWhiteLaces")
                modGlobalVariables.strLacesColor = "White"
                lblVintageLaces.Text = "The selected color for the Vintage Laces is: " & modGlobalVariables.strLacesColor
                intTick = 0
        End Select





    End Sub

    Private Sub frmVintageLaces_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picVintageLaces.Image = ResMgr.GetObject("VintageWhiteLaces")
        modGlobalVariables.strLacesColor = "White"
        lblVintageLaces.Text = "The selected color for the Vintage Laces is: " & modGlobalVariables.strLacesColor

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Next form
        frmVintageBackCounter.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Going back a form
        frmVintageEyestay.Show()
        Me.Hide()
    End Sub
End Class


