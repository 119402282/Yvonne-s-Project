Public Class frmVintageEyestay

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    'Declaring a string to hold the color value across the different pages
    Public strVintageEyestay As String = " "

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
        'The variable strVintageEyestay will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        Select Case intTick
            Case 1
                picVintageEyestay.Image = ResMgr.GetObject("VintageAquaEyestay")
                strVintageEyestay = "Aqua"
                lblVintageEyestay.Text = "The selected color for the Vintage Eyestay is: " & strVintageEyestay
            Case 2
                picVintageEyestay.Image = ResMgr.GetObject("VintageBlackEyestay")
                strVintageEyestay = "Black"
                lblVintageEyestay.Text = "The selected color for the Vintage Eyestay is: " & strVintageEyestay
            Case 3
                picVintageEyestay.Image = ResMgr.GetObject("VintageBlueEyestay")
                strVintageEyestay = "Blue"
                lblVintageEyestay.Text = "The selected color for the Vintage Eyestay is: " & strVintageEyestay
            Case 4
                picVintageEyestay.Image = ResMgr.GetObject("VintageGrayEyestay")
                strVintageEyestay = "Gray"
                lblVintageEyestay.Text = "The selected color for the Vintage Eyestay is: " & strVintageEyestay
            Case 5
                picVintageEyestay.Image = ResMgr.GetObject("VintageGreenEyestay")
                strVintageEyestay = "Green"
                lblVintageEyestay.Text = "The selected color for the Vintage Eyestay is: " & strVintageEyestay
            Case 6
                picVintageEyestay.Image = ResMgr.GetObject("VintageLimeEyestay")
                strVintageEyestay = "Lime"
                lblVintageEyestay.Text = "The selected color for the Vintage Eyestay is: " & strVintageEyestay
            Case 7
                picVintageEyestay.Image = ResMgr.GetObject("VintagePinkEyestay")
                strVintageEyestay = "Pink"
                lblVintageEyestay.Text = "The selected color for the Vintage Eyestay is: " & strVintageEyestay
            Case 8
                picVintageEyestay.Image = ResMgr.GetObject("VintageRedEyestay")
                strVintageEyestay = "Red"
                lblVintageEyestay.Text = "The selected color for the Vintage Eyestay is: " & strVintageEyestay
            Case 9
                picVintageEyestay.Image = ResMgr.GetObject("VintageWhiteEyestay")
                strVintageEyestay = "White"
                lblVintageEyestay.Text = "The selected color for the Vintage Eyestay is: " & strVintageEyestay
                intTick = 0
        End Select





    End Sub

    Private Sub frmVintageEyestay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picVintageEyestay.Image = ResMgr.GetObject("VintageWhiteEyestay")
        strVintageEyestay = "White"
        lblVintageEyestay.Text = "The selected color for the Vintage Eyestay is: " & strVintageEyestay

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

