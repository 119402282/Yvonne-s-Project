Public Class frmVintageQuarter

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    'Declaring a string to hold the color value across the different pages
    Public strVintageQuarter As String = " "

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
        'The variable strVintageQuarter will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        Select Case intTick
            Case 1
                picVintageQuarter.Image = ResMgr.GetObject("VintageAquaQuarter")
                strVintageQuarter = "Aqua"
                lblVintageQuarter.Text = "The selected color for the Vintage Quarter is: " & strVintageQuarter
            Case 2
                picVintageQuarter.Image = ResMgr.GetObject("VintageBlackQuarter")
                strVintageQuarter = "Black"
                lblVintageQuarter.Text = "The selected color for the Vintage Quarter is: " & strVintageQuarter
            Case 3
                picVintageQuarter.Image = ResMgr.GetObject("VintageBlueQuarter")
                strVintageQuarter = "Blue"
                lblVintageQuarter.Text = "The selected color for the Vintage Quarter is: " & strVintageQuarter
            Case 4
                picVintageQuarter.Image = ResMgr.GetObject("VintageGrayQuarter")
                strVintageQuarter = "Gray"
                lblVintageQuarter.Text = "The selected color for the Vintage Quarter is: " & strVintageQuarter
            Case 5
                picVintageQuarter.Image = ResMgr.GetObject("VintageGreenQuarter")
                strVintageQuarter = "Green"
                lblVintageQuarter.Text = "The selected color for the Vintage Quarter is: " & strVintageQuarter
            Case 6
                picVintageQuarter.Image = ResMgr.GetObject("VintageLimeQuarter")
                strVintageQuarter = "Lime"
                lblVintageQuarter.Text = "The selected color for the Vintage Quarter is: " & strVintageQuarter
            Case 7
                picVintageQuarter.Image = ResMgr.GetObject("VintagePinkQuarter")
                strVintageQuarter = "Pink"
                lblVintageQuarter.Text = "The selected color for the Vintage Quarter is: " & strVintageQuarter
            Case 8
                picVintageQuarter.Image = ResMgr.GetObject("VintageRedQuarter")
                strVintageQuarter = "Red"
                lblVintageQuarter.Text = "The selected color for the Vintage Quarter is: " & strVintageQuarter
            Case 9
                picVintageQuarter.Image = ResMgr.GetObject("VintageWhiteQuarter")
                strVintageQuarter = "White"
                lblVintageQuarter.Text = "The selected color for the Vintage Quarter is: " & strVintageQuarter
                intTick = 0
        End Select





    End Sub

    Private Sub frmVintageQuarter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picVintageQuarter.Image = ResMgr.GetObject("VintageWhiteQuarter")
        strVintageQuarter = "White"
        lblVintageQuarter.Text = "The selected color for the Vintage Quarter is: " & strVintageQuarter

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Forward Navigation through the forms
        frmVintageVamp.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
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
        strVintageQuarter = " "
        frmVintageVamp.strVintageVamp = " "
        frmVintageEyestay.strVintageEyestay = " "
        frmVintageLaces.strVintageLaces = " "
        frmVintageBackCounter.strVintageBackCounter = " "




    End Sub
End Class
