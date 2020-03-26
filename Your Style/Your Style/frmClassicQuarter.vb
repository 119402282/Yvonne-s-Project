Public Class frmClassicQuarter

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    'Declaring a string to hold the color value across the different pages
    Public strClassicQuarter As String = " "

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
        'The variable strClassicQuarter will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        Select Case intTick
            Case 1
                picClassicQuarter.Image = ResMgr.GetObject("ClassicAquaQuarter")
                strClassicQuarter = "Aqua"
                lblClassicQuarter.Text = "The selected color for the Classic Quarter is: " & strClassicQuarter
            Case 2
                picClassicQuarter.Image = ResMgr.GetObject("ClassicBlackQuarter")
                strClassicQuarter = "Black"
                lblClassicQuarter.Text = "The selected color for the Classic Quarter is: " & strClassicQuarter
            Case 3
                picClassicQuarter.Image = ResMgr.GetObject("ClassicBlueQuarter")
                strClassicQuarter = "Blue"
                lblClassicQuarter.Text = "The selected color for the Classic Quarter is: " & strClassicQuarter
            Case 4
                picClassicQuarter.Image = ResMgr.GetObject("ClassicGrayQuarter")
                strClassicQuarter = "Gray"
                lblClassicQuarter.Text = "The selected color for the Classic Quarter is: " & strClassicQuarter
            Case 5
                picClassicQuarter.Image = ResMgr.GetObject("ClassicGreenQuarter")
                strClassicQuarter = "Green"
                lblClassicQuarter.Text = "The selected color for the Classic Quarter is: " & strClassicQuarter
            Case 6
                picClassicQuarter.Image = ResMgr.GetObject("ClassicLimeQuarter")
                strClassicQuarter = "Lime"
                lblClassicQuarter.Text = "The selected color for the Classic Quarter is: " & strClassicQuarter
            Case 7
                picClassicQuarter.Image = ResMgr.GetObject("ClassicPinkQuarter")
                strClassicQuarter = "Pink"
                lblClassicQuarter.Text = "The selected color for the Classic Quarter is: " & strClassicQuarter
            Case 8
                picClassicQuarter.Image = ResMgr.GetObject("ClassicRedQuarter")
                strClassicQuarter = "Red"
                lblClassicQuarter.Text = "The selected color for the Classic Quarter is: " & strClassicQuarter
            Case 9
                picClassicQuarter.Image = ResMgr.GetObject("ClassicWhiteQuarter")
                strClassicQuarter = "White"
                lblClassicQuarter.Text = "The selected color for the Classic Quarter is: " & strClassicQuarter
                intTick = 0
        End Select





    End Sub

    Private Sub frmClassicQuarter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picClassicQuarter.Image = ResMgr.GetObject("ClassicWhiteQuarter")
        strClassicQuarter = "White"
        lblClassicQuarter.Text = "The selected color for the Classic Quarter is: " & strClassicQuarter

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Forward Navigation through the forms
        frmClassicVamp.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
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
        strClassicQuarter = " "
        frmClassicVamp.strClassicVamp = " "
        frmClassicEyestay.strClassicEyestay = " "
        frmClassicLaces.strClassicLaces = " "
        frmClassicHeelTab.strClassicHeelTab = " "
        frmClassicBackCounter.strClassicBackCounter = " "




    End Sub
End Class
