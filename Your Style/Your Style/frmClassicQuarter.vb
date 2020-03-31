Public Class frmClassicQuarter

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    Private Sub picClassicQuarter_Click(sender As Object, e As EventArgs) Handles picClassicQuarter.Click

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
                picClassicQuarter.Image = ResMgr.GetObject("ClassicAquaQuarter")
                modGlobalVariables.strQuarterColor = "Aqua"
                lblClassicQuarter.Text = "The selected color for the Classic Quarter is: " & modGlobalVariables.strQuarterColor
            Case 2
                picClassicQuarter.Image = ResMgr.GetObject("ClassicBlackQuarter")
                modGlobalVariables.strQuarterColor = "Black"
                lblClassicQuarter.Text = "The selected color for the Classic Quarter is: " & modGlobalVariables.strQuarterColor
            Case 3
                picClassicQuarter.Image = ResMgr.GetObject("ClassicBlueQuarter")
                modGlobalVariables.strQuarterColor = "Blue"
                lblClassicQuarter.Text = "The selected color for the Classic Quarter is: " & modGlobalVariables.strQuarterColor
            Case 4
                picClassicQuarter.Image = ResMgr.GetObject("ClassicGrayQuarter")
                modGlobalVariables.strQuarterColor = "Gray"
                lblClassicQuarter.Text = "The selected color for the Classic Quarter is: " & modGlobalVariables.strQuarterColor
            Case 5
                picClassicQuarter.Image = ResMgr.GetObject("ClassicGreenQuarter")
                modGlobalVariables.strQuarterColor = "Green"
                lblClassicQuarter.Text = "The selected color for the Classic Quarter is: " & modGlobalVariables.strQuarterColor
            Case 6
                picClassicQuarter.Image = ResMgr.GetObject("ClassicLimeQuarter")
                modGlobalVariables.strQuarterColor = "Lime"
                lblClassicQuarter.Text = "The selected color for the Classic Quarter is: " & modGlobalVariables.strQuarterColor
            Case 7
                picClassicQuarter.Image = ResMgr.GetObject("ClassicPinkQuarter")
                modGlobalVariables.strQuarterColor = "Pink"
                lblClassicQuarter.Text = "The selected color for the Classic Quarter is: " & modGlobalVariables.strQuarterColor
            Case 8
                picClassicQuarter.Image = ResMgr.GetObject("ClassicRedQuarter")
                modGlobalVariables.strQuarterColor = "Red"
                lblClassicQuarter.Text = "The selected color for the Classic Quarter is: " & modGlobalVariables.strQuarterColor
            Case 9
                picClassicQuarter.Image = ResMgr.GetObject("ClassicWhiteQuarter")
                modGlobalVariables.strQuarterColor = "White"
                lblClassicQuarter.Text = "The selected color for the Classic Quarter is: " & modGlobalVariables.strQuarterColor
                intTick = 0
        End Select





    End Sub

    Private Sub frmClassicQuarter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picClassicQuarter.Image = ResMgr.GetObject("ClassicWhiteQuarter")
        modGlobalVariables.strQuarterColor = "White"
        lblClassicQuarter.Text = "The selected color for the Classic Quarter is: " & modGlobalVariables.strQuarterColor

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Forward Navigation through the forms
        frmClassicVamp.Show()
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
        frmClassicVamp.Close()
        frmClassicEyestay.Close()
        frmClassicLaces.Close()
        frmClassicHeelTab.Close()
        frmClassicBackCounter.Close()

        'Reseting the Strings
        modGlobalVariables.strQuarterColor = ""
        modGlobalVariables.strVampColor = ""
        modGlobalVariables.strEyestayColor = ""
        modGlobalVariables.strLacesColor = ""
        modGlobalVariables.strHeelTabColor = ""
        modGlobalVariables.strBackCounterColor = ""

    End Sub

    Private Sub frmClassicQuarter_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'Informing user on how they can switch colors
        MessageBox.Show("Click the part to cylcle through the different colors", "Information")

    End Sub
End Class
