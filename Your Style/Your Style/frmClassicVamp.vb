Public Class frmClassicVamp

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    'Declaring a string to hold the color value across the different pages
    Public strClassicVamp As String = " "

    Private Sub picClassicVamp_Click(sender As Object, e As EventArgs) Handles picClassicVamp.Click

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
        'The variable strClassicVamp will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        Select Case intTick
            Case 1
                picClassicVamp.Image = ResMgr.GetObject("ClassicAquaVamp")
                strClassicVamp = "Aqua"
                lblClassicVamp.Text = "The selected color for the Classic Vamp is: " & strClassicVamp
            Case 2
                picClassicVamp.Image = ResMgr.GetObject("ClassicBlackVamp")
                strClassicVamp = "Black"
                lblClassicVamp.Text = "The selected color for the Classic Vamp is: " & strClassicVamp
            Case 3
                picClassicVamp.Image = ResMgr.GetObject("ClassicBlueVamp")
                strClassicVamp = "Blue"
                lblClassicVamp.Text = "The selected color for the Classic Vamp is: " & strClassicVamp
            Case 4
                picClassicVamp.Image = ResMgr.GetObject("ClassicGrayVamp")
                strClassicVamp = "Gray"
                lblClassicVamp.Text = "The selected color for the Classic Vamp is: " & strClassicVamp
            Case 5
                picClassicVamp.Image = ResMgr.GetObject("ClassicGreenVamp")
                strClassicVamp = "Green"
                lblClassicVamp.Text = "The selected color for the Classic Vamp is: " & strClassicVamp
            Case 6
                picClassicVamp.Image = ResMgr.GetObject("ClassicLimeVamp")
                strClassicVamp = "Lime"
                lblClassicVamp.Text = "The selected color for the Classic Vamp is: " & strClassicVamp
            Case 7
                picClassicVamp.Image = ResMgr.GetObject("ClassicPinkVamp")
                strClassicVamp = "Pink"
                lblClassicVamp.Text = "The selected color for the Classic Vamp is: " & strClassicVamp
            Case 8
                picClassicVamp.Image = ResMgr.GetObject("ClassicRedVamp")
                strClassicVamp = "Red"
                lblClassicVamp.Text = "The selected color for the Classic Vamp is: " & strClassicVamp
            Case 9
                picClassicVamp.Image = ResMgr.GetObject("ClassicWhiteVamp")
                strClassicVamp = "White"
                lblClassicVamp.Text = "The selected color for the Classic Vamp is: " & strClassicVamp
                intTick = 0
        End Select





    End Sub

    Private Sub frmClassicVamp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picClassicVamp.Image = ResMgr.GetObject("ClassicWhiteVamp")
        strClassicVamp = "White"
        lblClassicVamp.Text = "The selected color for the Classic Vamp is: " & strClassicVamp

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Forward Navigation through the forms
        frmClassicEyestay.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Going back a form
        frmClassicQuarter.Show()
        Me.Hide()
    End Sub
End Class

