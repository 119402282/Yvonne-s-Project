Public Class frmVintageBackCounter

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

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
        'The variable modGlobalVariables.strBackCounterColor will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        Select Case intTick
            Case 1
                picVintageBackCounter.Image = ResMgr.GetObject("VintageAquaBackCounter")
                modGlobalVariables.strBackCounterColor = "Aqua"
                lblVintageBackCounter.Text = "The selected color for the Vintage Back Counter is: " & modGlobalVariables.strBackCounterColor
            Case 2
                picVintageBackCounter.Image = ResMgr.GetObject("VintageBlackBackCounter")
                modGlobalVariables.strBackCounterColor = "Black"
                lblVintageBackCounter.Text = "The selected color for the Vintage Back Counter is: " & modGlobalVariables.strBackCounterColor
            Case 3
                picVintageBackCounter.Image = ResMgr.GetObject("VintageBlueBackCounter")
                modGlobalVariables.strBackCounterColor = "Blue"
                lblVintageBackCounter.Text = "The selected color for the Vintage Back Counter is: " & modGlobalVariables.strBackCounterColor
            Case 4
                picVintageBackCounter.Image = ResMgr.GetObject("VintageGrayBackCounter")
                modGlobalVariables.strBackCounterColor = "Gray"
                lblVintageBackCounter.Text = "The selected color for the Vintage Back Counter is: " & modGlobalVariables.strBackCounterColor
            Case 5
                picVintageBackCounter.Image = ResMgr.GetObject("VintageGreenBackCounter")
                modGlobalVariables.strBackCounterColor = "Green"
                lblVintageBackCounter.Text = "The selected color for the Vintage Back Counter is: " & modGlobalVariables.strBackCounterColor
            Case 6
                picVintageBackCounter.Image = ResMgr.GetObject("VintageLimeBackCounter")
                modGlobalVariables.strBackCounterColor = "Lime"
                lblVintageBackCounter.Text = "The selected color for the Vintage Back Counter is: " & modGlobalVariables.strBackCounterColor
            Case 7
                picVintageBackCounter.Image = ResMgr.GetObject("VintagePinkBackCounter")
                modGlobalVariables.strBackCounterColor = "Pink"
                lblVintageBackCounter.Text = "The selected color for the Vintage Back Counter is: " & modGlobalVariables.strBackCounterColor
            Case 8
                picVintageBackCounter.Image = ResMgr.GetObject("VintageRedBackCounter")
                modGlobalVariables.strBackCounterColor = "Red"
                lblVintageBackCounter.Text = "The selected color for the Vintage Back Counter is: " & modGlobalVariables.strBackCounterColor
            Case 9
                picVintageBackCounter.Image = ResMgr.GetObject("VintageWhiteBackCounter")
                modGlobalVariables.strBackCounterColor = "White"
                lblVintageBackCounter.Text = "The selected color for the Vintage Back Counter is: " & modGlobalVariables.strBackCounterColor
                intTick = 0
        End Select





    End Sub

    Private Sub frmVintageBackCounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picVintageBackCounter.Image = ResMgr.GetObject("VintageWhiteBackCounter")
        modGlobalVariables.strBackCounterColor = "White"
        lblVintageBackCounter.Text = "The selected color for the Vintage Back Counter is: " & modGlobalVariables.strBackCounterColor

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Next form
        frmShoeText.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Going back a form
        frmVintageLaces.Show()
        Me.Hide()
    End Sub
End Class



