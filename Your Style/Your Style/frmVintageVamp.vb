Public Class frmVintageVamp

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    'Declaring a string to hold the color value across the different pages
    Public strVintageVamp As String = " "

    Private Sub picVintageVamp_Click(sender As Object, e As EventArgs) Handles picVintageVamp.Click

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
        'The variable strVintageVamp will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        Select Case intTick
            Case 1
                picVintageVamp.Image = ResMgr.GetObject("VintageAquaVamp")
                strVintageVamp = "Aqua"
                lblVintageVamp.Text = "The selected color for the Vintage Vamp is: " & strVintageVamp
            Case 2
                picVintageVamp.Image = ResMgr.GetObject("VintageBlackVamp")
                strVintageVamp = "Black"
                lblVintageVamp.Text = "The selected color for the Vintage Vamp is: " & strVintageVamp
            Case 3
                picVintageVamp.Image = ResMgr.GetObject("VintageBlueVamp")
                strVintageVamp = "Blue"
                lblVintageVamp.Text = "The selected color for the Vintage Vamp is: " & strVintageVamp
            Case 4
                picVintageVamp.Image = ResMgr.GetObject("VintageGrayVamp")
                strVintageVamp = "Gray"
                lblVintageVamp.Text = "The selected color for the Vintage Vamp is: " & strVintageVamp
            Case 5
                picVintageVamp.Image = ResMgr.GetObject("VintageGreenVamp")
                strVintageVamp = "Green"
                lblVintageVamp.Text = "The selected color for the Vintage Vamp is: " & strVintageVamp
            Case 6
                picVintageVamp.Image = ResMgr.GetObject("VintageLimeVamp")
                strVintageVamp = "Lime"
                lblVintageVamp.Text = "The selected color for the Vintage Vamp is: " & strVintageVamp
            Case 7
                picVintageVamp.Image = ResMgr.GetObject("VintagePinkVamp")
                strVintageVamp = "Pink"
                lblVintageVamp.Text = "The selected color for the Vintage Vamp is: " & strVintageVamp
            Case 8
                picVintageVamp.Image = ResMgr.GetObject("VintageRedVamp")
                strVintageVamp = "Red"
                lblVintageVamp.Text = "The selected color for the Vintage Vamp is: " & strVintageVamp
            Case 9
                picVintageVamp.Image = ResMgr.GetObject("VintageWhiteVamp")
                strVintageVamp = "White"
                lblVintageVamp.Text = "The selected color for the Vintage Vamp is: " & strVintageVamp
                intTick = 0
        End Select





    End Sub

    Private Sub frmVintageVamp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picVintageVamp.Image = ResMgr.GetObject("VintageWhiteVamp")
        strVintageVamp = "White"
        lblVintageVamp.Text = "The selected color for the Vintage Vamp is: " & strVintageVamp

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Forward Navigation through the forms
        frmVintageEyestay.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Going back a form
        frmVintageQuarter.Show()
        Me.Hide()
    End Sub
End Class

