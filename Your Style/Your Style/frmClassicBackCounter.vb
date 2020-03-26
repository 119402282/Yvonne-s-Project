Public Class frmClassicBackCounter

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    'Declaring a string to hold the color value across the different pages
    Public strClassicBackCounter As String = " "

    Private Sub picClassicBackCounter_Click(sender As Object, e As EventArgs) Handles picClassicBackCounter.Click

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
        'The variable strClassicBackCounter will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        Select Case intTick
            Case 1
                picClassicBackCounter.Image = ResMgr.GetObject("ClassicAquaBackCounter")
                strClassicBackCounter = "Aqua"
                lblClassicBackCounter.Text = "The selected color for the Classic Back Counter is: " & strClassicBackCounter
            Case 2
                picClassicBackCounter.Image = ResMgr.GetObject("ClassicBlackBackCounter")
                strClassicBackCounter = "Black"
                lblClassicBackCounter.Text = "The selected color for the Classic Back Counter is: " & strClassicBackCounter
            Case 3
                picClassicBackCounter.Image = ResMgr.GetObject("ClassicBlueBackCounter")
                strClassicBackCounter = "Blue"
                lblClassicBackCounter.Text = "The selected color for the Classic Back Counter is: " & strClassicBackCounter
            Case 4
                picClassicBackCounter.Image = ResMgr.GetObject("ClassicGrayBackCounter")
                strClassicBackCounter = "Gray"
                lblClassicBackCounter.Text = "The selected color for the Classic Back Counter is: " & strClassicBackCounter
            Case 5
                picClassicBackCounter.Image = ResMgr.GetObject("ClassicGreenBackCounter")
                strClassicBackCounter = "Green"
                lblClassicBackCounter.Text = "The selected color for the Classic Back Counter is: " & strClassicBackCounter
            Case 6
                picClassicBackCounter.Image = ResMgr.GetObject("ClassicLimeBackCounter")
                strClassicBackCounter = "Lime"
                lblClassicBackCounter.Text = "The selected color for the Classic Back Counter is: " & strClassicBackCounter
            Case 7
                picClassicBackCounter.Image = ResMgr.GetObject("ClassicPinkBackCounter")
                strClassicBackCounter = "Pink"
                lblClassicBackCounter.Text = "The selected color for the Classic Back Counter is: " & strClassicBackCounter
            Case 8
                picClassicBackCounter.Image = ResMgr.GetObject("ClassicRedBackCounter")
                strClassicBackCounter = "Red"
                lblClassicBackCounter.Text = "The selected color for the Classic Back Counter is: " & strClassicBackCounter
            Case 9
                picClassicBackCounter.Image = ResMgr.GetObject("ClassicWhiteBackCounter")
                strClassicBackCounter = "White"
                lblClassicBackCounter.Text = "The selected color for the Classic Back Counter is: " & strClassicBackCounter
                intTick = 0
        End Select





    End Sub

    Private Sub frmClassicBackCounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picClassicBackCounter.Image = ResMgr.GetObject("ClassicWhiteBackCounter")
        strClassicBackCounter = "White"
        lblClassicBackCounter.Text = "The selected color for the Classic Back Counter is: " & strClassicBackCounter

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Next form
        'frmClassicText.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Going back a form
        frmClassicHeelTab.Show()
        Me.Hide()
    End Sub
End Class



