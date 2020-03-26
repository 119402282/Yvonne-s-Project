Public Class frmVintageLaces

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    'Declaring a string to hold the color value across the different pages
    Public strVintageLaces As String = " "

    Private Sub picVintageLaces_Click(sender As Object, e As EventArgs) Handles picVintageLaces.Click

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
        'The variable strVintageLaces will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        Select Case intTick
            Case 1
                picVintageLaces.Image = ResMgr.GetObject("VintageAquaLaces")
                strVintageLaces = "Aqua"
                lblVintageLaces.Text = "The selected color for the Vintage Laces is: " & strVintageLaces
            Case 2
                picVintageLaces.Image = ResMgr.GetObject("VintageBlackLaces")
                strVintageLaces = "Black"
                lblVintageLaces.Text = "The selected color for the Vintage Laces is: " & strVintageLaces
            Case 3
                picVintageLaces.Image = ResMgr.GetObject("VintageBlueLaces")
                strVintageLaces = "Blue"
                lblVintageLaces.Text = "The selected color for the Vintage Laces is: " & strVintageLaces
            Case 4
                picVintageLaces.Image = ResMgr.GetObject("VintageGrayLaces")
                strVintageLaces = "Gray"
                lblVintageLaces.Text = "The selected color for the Vintage Laces is: " & strVintageLaces
            Case 5
                picVintageLaces.Image = ResMgr.GetObject("VintageGreenLaces")
                strVintageLaces = "Green"
                lblVintageLaces.Text = "The selected color for the Vintage Laces is: " & strVintageLaces
            Case 6
                picVintageLaces.Image = ResMgr.GetObject("VintageLimeLaces")
                strVintageLaces = "Lime"
                lblVintageLaces.Text = "The selected color for the Vintage Laces is: " & strVintageLaces
            Case 7
                picVintageLaces.Image = ResMgr.GetObject("VintagePinkLaces")
                strVintageLaces = "Pink"
                lblVintageLaces.Text = "The selected color for the Vintage Laces is: " & strVintageLaces
            Case 8
                picVintageLaces.Image = ResMgr.GetObject("VintageRedLaces")
                strVintageLaces = "Red"
                lblVintageLaces.Text = "The selected color for the Vintage Laces is: " & strVintageLaces
            Case 9
                picVintageLaces.Image = ResMgr.GetObject("VintageWhiteLaces")
                strVintageLaces = "White"
                lblVintageLaces.Text = "The selected color for the Vintage Laces is: " & strVintageLaces
                intTick = 0
        End Select





    End Sub

    Private Sub frmVintageLaces_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picVintageLaces.Image = ResMgr.GetObject("VintageWhiteLaces")
        strVintageLaces = "White"
        lblVintageLaces.Text = "The selected color for the Vintage Laces is: " & strVintageLaces

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Next form
        frmVintageBackCounter.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Going back a form
        frmVintageEyestay.Show()
        Me.Hide()
    End Sub
End Class


