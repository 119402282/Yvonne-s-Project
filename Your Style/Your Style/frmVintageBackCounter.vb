Public Class frmVintageBackCounter

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    'Declaring a string to hold the color value across the different pages
    Public strVintageBackCounter As String = " "

    Private Sub picVintageBackCounter_Click(sender As Object, e As EventArgs) Handles picVintageBackCounter.Click

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
        'The variable strVintageBackCounter will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        Select Case intTick
            Case 1
                picVintageBackCounter.Image = ResMgr.GetObject("VintageAquaBackCounter")
                strVintageBackCounter = "Aqua"
                lblVintageBackCounter.Text = "The selected color for the Vintage Back Counter is: " & strVintageBackCounter
            Case 2
                picVintageBackCounter.Image = ResMgr.GetObject("VintageBlackBackCounter")
                strVintageBackCounter = "Black"
                lblVintageBackCounter.Text = "The selected color for the Vintage Back Counter is: " & strVintageBackCounter
            Case 3
                picVintageBackCounter.Image = ResMgr.GetObject("VintageBlueBackCounter")
                strVintageBackCounter = "Blue"
                lblVintageBackCounter.Text = "The selected color for the Vintage Back Counter is: " & strVintageBackCounter
            Case 4
                picVintageBackCounter.Image = ResMgr.GetObject("VintageGrayBackCounter")
                strVintageBackCounter = "Gray"
                lblVintageBackCounter.Text = "The selected color for the Vintage Back Counter is: " & strVintageBackCounter
            Case 5
                picVintageBackCounter.Image = ResMgr.GetObject("VintageGreenBackCounter")
                strVintageBackCounter = "Green"
                lblVintageBackCounter.Text = "The selected color for the Vintage Back Counter is: " & strVintageBackCounter
            Case 6
                picVintageBackCounter.Image = ResMgr.GetObject("VintageLimeBackCounter")
                strVintageBackCounter = "Lime"
                lblVintageBackCounter.Text = "The selected color for the Vintage Back Counter is: " & strVintageBackCounter
            Case 7
                picVintageBackCounter.Image = ResMgr.GetObject("VintagePinkBackCounter")
                strVintageBackCounter = "Pink"
                lblVintageBackCounter.Text = "The selected color for the Vintage Back Counter is: " & strVintageBackCounter
            Case 8
                picVintageBackCounter.Image = ResMgr.GetObject("VintageRedBackCounter")
                strVintageBackCounter = "Red"
                lblVintageBackCounter.Text = "The selected color for the Vintage Back Counter is: " & strVintageBackCounter
            Case 9
                picVintageBackCounter.Image = ResMgr.GetObject("VintageWhiteBackCounter")
                strVintageBackCounter = "White"
                lblVintageBackCounter.Text = "The selected color for the Vintage Back Counter is: " & strVintageBackCounter
                intTick = 0
        End Select





    End Sub

    Private Sub frmVintageBackCounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picVintageBackCounter.Image = ResMgr.GetObject("VintageWhiteBackCounter")
        strVintageBackCounter = "White"
        lblVintageBackCounter.Text = "The selected color for the Vintage Back Counter is: " & strVintageBackCounter

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Next form
        'frmVintageText.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Going back a form
        frmVintageLaces.Show()
        Me.Hide()
    End Sub
End Class



