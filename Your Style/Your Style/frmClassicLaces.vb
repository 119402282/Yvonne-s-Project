Public Class frmClassicLaces

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    'Declaring a string to hold the color value across the different pages
    Public strClassicLaces As String = " "

    Private Sub picClassicLaces_Click(sender As Object, e As EventArgs) Handles picClassicLaces.Click

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
        'The variable strClassicLaces will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        Select Case intTick
            Case 1
                picClassicLaces.Image = ResMgr.GetObject("ClassicAquaLaces")
                strClassicLaces = "Aqua"
                lblClassicLaces.Text = "The selected color for the Classic Laces is: " & strClassicLaces
            Case 2
                picClassicLaces.Image = ResMgr.GetObject("ClassicBlackLaces")
                strClassicLaces = "Black"
                lblClassicLaces.Text = "The selected color for the Classic Laces is: " & strClassicLaces
            Case 3
                picClassicLaces.Image = ResMgr.GetObject("ClassicBlueLaces")
                strClassicLaces = "Blue"
                lblClassicLaces.Text = "The selected color for the Classic Laces is: " & strClassicLaces
            Case 4
                picClassicLaces.Image = ResMgr.GetObject("ClassicGrayLaces")
                strClassicLaces = "Gray"
                lblClassicLaces.Text = "The selected color for the Classic Laces is: " & strClassicLaces
            Case 5
                picClassicLaces.Image = ResMgr.GetObject("ClassicGreenLaces")
                strClassicLaces = "Green"
                lblClassicLaces.Text = "The selected color for the Classic Laces is: " & strClassicLaces
            Case 6
                picClassicLaces.Image = ResMgr.GetObject("ClassicLimeLaces")
                strClassicLaces = "Lime"
                lblClassicLaces.Text = "The selected color for the Classic Laces is: " & strClassicLaces
            Case 7
                picClassicLaces.Image = ResMgr.GetObject("ClassicPinkLaces")
                strClassicLaces = "Pink"
                lblClassicLaces.Text = "The selected color for the Classic Laces is: " & strClassicLaces
            Case 8
                picClassicLaces.Image = ResMgr.GetObject("ClassicRedLaces")
                strClassicLaces = "Red"
                lblClassicLaces.Text = "The selected color for the Classic Laces is: " & strClassicLaces
            Case 9
                picClassicLaces.Image = ResMgr.GetObject("ClassicWhiteLaces")
                strClassicLaces = "White"
                lblClassicLaces.Text = "The selected color for the Classic Laces is: " & strClassicLaces
                intTick = 0
        End Select





    End Sub

    Private Sub frmClassicLaces_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picClassicLaces.Image = ResMgr.GetObject("ClassicWhiteLaces")
        strClassicLaces = "White"
        lblClassicLaces.Text = "The selected color for the Classic Laces is: " & strClassicLaces

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Next form
        frmClassicHeelTab.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Going back a form
        frmClassicEyestay.Show()
        Me.Hide()
    End Sub
End Class


