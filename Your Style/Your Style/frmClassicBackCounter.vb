Public Class frmClassicBackCounter

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

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
        'The variable modGlobalVariables.strBackCounterColor will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        Select Case intTick
            Case 1
                picClassicBackCounter.Image = ResMgr.GetObject("ClassicAquaBackCounter")
                modGlobalVariables.strBackCounterColor = "Aqua"
                lblClassicBackCounter.Text = "The selected color for the Classic Back Counter is: " & modGlobalVariables.strBackCounterColor
            Case 2
                picClassicBackCounter.Image = ResMgr.GetObject("ClassicBlackBackCounter")
                modGlobalVariables.strBackCounterColor = "Black"
                lblClassicBackCounter.Text = "The selected color for the Classic Back Counter is: " & modGlobalVariables.strBackCounterColor
            Case 3
                picClassicBackCounter.Image = ResMgr.GetObject("ClassicBlueBackCounter")
                modGlobalVariables.strBackCounterColor = "Blue"
                lblClassicBackCounter.Text = "The selected color for the Classic Back Counter is: " & modGlobalVariables.strBackCounterColor
            Case 4
                picClassicBackCounter.Image = ResMgr.GetObject("ClassicGrayBackCounter")
                modGlobalVariables.strBackCounterColor = "Gray"
                lblClassicBackCounter.Text = "The selected color for the Classic Back Counter is: " & modGlobalVariables.strBackCounterColor
            Case 5
                picClassicBackCounter.Image = ResMgr.GetObject("ClassicGreenBackCounter")
                modGlobalVariables.strBackCounterColor = "Green"
                lblClassicBackCounter.Text = "The selected color for the Classic Back Counter is: " & modGlobalVariables.strBackCounterColor
            Case 6
                picClassicBackCounter.Image = ResMgr.GetObject("ClassicLimeBackCounter")
                modGlobalVariables.strBackCounterColor = "Lime"
                lblClassicBackCounter.Text = "The selected color for the Classic Back Counter is: " & modGlobalVariables.strBackCounterColor
            Case 7
                picClassicBackCounter.Image = ResMgr.GetObject("ClassicPinkBackCounter")
                modGlobalVariables.strBackCounterColor = "Pink"
                lblClassicBackCounter.Text = "The selected color for the Classic Back Counter is: " & modGlobalVariables.strBackCounterColor
            Case 8
                picClassicBackCounter.Image = ResMgr.GetObject("ClassicRedBackCounter")
                modGlobalVariables.strBackCounterColor = "Red"
                lblClassicBackCounter.Text = "The selected color for the Classic Back Counter is: " & modGlobalVariables.strBackCounterColor
            Case 9
                picClassicBackCounter.Image = ResMgr.GetObject("ClassicWhiteBackCounter")
                modGlobalVariables.strBackCounterColor = "White"
                lblClassicBackCounter.Text = "The selected color for the Classic Back Counter is: " & modGlobalVariables.strBackCounterColor
                intTick = 0
        End Select





    End Sub

    Private Sub frmClassicBackCounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picClassicBackCounter.Image = ResMgr.GetObject("ClassicWhiteBackCounter")
        modGlobalVariables.strBackCounterColor = "White"
        lblClassicBackCounter.Text = "The selected color for the Classic Back Counter is: " & modGlobalVariables.strBackCounterColor

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Next form
        frmShoeText.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Going back a form
        frmClassicHeelTab.Show()
        Me.Hide()
    End Sub
End Class



