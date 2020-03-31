Public Class frmVintageQuarter

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    Private Sub picVintageQuarter_Click(sender As Object, e As EventArgs) Handles picVintageQuarter.Click

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
        'The variable modGlobalVariables.strQuarterColor will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        Select Case intTick
            Case 1
                picVintageQuarter.Image = ResMgr.GetObject("VintageAquaQuarter")
                modGlobalVariables.strQuarterColor = "Aqua"
                lblVintageQuarter.Text = "The selected color for the Vintage Quarter is: " & modGlobalVariables.strQuarterColor
            Case 2
                picVintageQuarter.Image = ResMgr.GetObject("VintageBlackQuarter")
                modGlobalVariables.strQuarterColor = "Black"
                lblVintageQuarter.Text = "The selected color for the Vintage Quarter is: " & modGlobalVariables.strQuarterColor
            Case 3
                picVintageQuarter.Image = ResMgr.GetObject("VintageBlueQuarter")
                modGlobalVariables.strQuarterColor = "Blue"
                lblVintageQuarter.Text = "The selected color for the Vintage Quarter is: " & modGlobalVariables.strQuarterColor
            Case 4
                picVintageQuarter.Image = ResMgr.GetObject("VintageGrayQuarter")
                modGlobalVariables.strQuarterColor = "Gray"
                lblVintageQuarter.Text = "The selected color for the Vintage Quarter is: " & modGlobalVariables.strQuarterColor
            Case 5
                picVintageQuarter.Image = ResMgr.GetObject("VintageGreenQuarter")
                modGlobalVariables.strQuarterColor = "Green"
                lblVintageQuarter.Text = "The selected color for the Vintage Quarter is: " & modGlobalVariables.strQuarterColor
            Case 6
                picVintageQuarter.Image = ResMgr.GetObject("VintageLimeQuarter")
                modGlobalVariables.strQuarterColor = "Lime"
                lblVintageQuarter.Text = "The selected color for the Vintage Quarter is: " & modGlobalVariables.strQuarterColor
            Case 7
                picVintageQuarter.Image = ResMgr.GetObject("VintagePinkQuarter")
                modGlobalVariables.strQuarterColor = "Pink"
                lblVintageQuarter.Text = "The selected color for the Vintage Quarter is: " & modGlobalVariables.strQuarterColor
            Case 8
                picVintageQuarter.Image = ResMgr.GetObject("VintageRedQuarter")
                modGlobalVariables.strQuarterColor = "Red"
                lblVintageQuarter.Text = "The selected color for the Vintage Quarter is: " & modGlobalVariables.strQuarterColor
            Case 9
                picVintageQuarter.Image = ResMgr.GetObject("VintageWhiteQuarter")
                modGlobalVariables.strQuarterColor = "White"
                lblVintageQuarter.Text = "The selected color for the Vintage Quarter is: " & modGlobalVariables.strQuarterColor
                intTick = 0
        End Select





    End Sub

    Private Sub frmVintageQuarter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picVintageQuarter.Image = ResMgr.GetObject("VintageWhiteQuarter")
        modGlobalVariables.strQuarterColor = "White"
        lblVintageQuarter.Text = "The selected color for the Vintage Quarter is: " & modGlobalVariables.strQuarterColor

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Forward Navigation through the forms
        frmVintageVamp.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Alerts user that all customizations will be lost if the go back to the intial shoe type page
        MessageBox.Show("Warning! All active customizations that have not been completed will be lost if you go back.", "Warning")

        'Going back a form
        frmShoeType.Show()
        Me.Hide()
        'Closing the forms to reset the color values
        Me.Close()
        frmVintageVamp.Close()
        frmVintageEyestay.Close()
        frmVintageLaces.Close()
        frmVintageBackCounter.Close()

        'Reseting the Strings
        modGlobalVariables.strQuarterColor = ""
        modGlobalVariables.strVampColor = ""
        modGlobalVariables.strEyestayColor = ""
        modGlobalVariables.strLacesColor = ""
        modGlobalVariables.strHeelTabColor = ""
        modGlobalVariables.strBackCounterColor = ""




    End Sub

    Private Sub frmVintageQuarter_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'Informing user on how they can switch colors
        MessageBox.Show("Click the part to cylcle through the different colors", "Information")

    End Sub
End Class
