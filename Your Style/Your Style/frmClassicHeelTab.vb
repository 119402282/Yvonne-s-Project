Public Class frmClassicHeelTab

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    'Declaring a string to hold the color value across the different pages
    Public strClassicHeelTab As String = " "

    Private Sub picClassicHeelTab_Click(sender As Object, e As EventArgs) Handles picClassicHeelTab.Click

        'Declaring Resource Manager to use to retrieve the images
        'I found this while traversing stack overflow.
        'I haven't seen it since so I can't provide a url
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Making the tick increase each click of the picturebox
        intTick += 1

        'Select Case statement to change the picbox out output
        'It also changes the outputof the label to notify the user of their selection
        'The variable strClassicHeelTab will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        'Here's a video of a similar demo https://youtu.be/FEfST1-9oFk
        Select Case intTick
            Case 1
                picClassicHeelTab.Image = ResMgr.GetObject("ClassicAquaHeelTab")
                strClassicHeelTab = "Aqua"
                lblClassicHeelTab.Text = "The selected color for the Classic Heel Tab is: " & strClassicHeelTab
            Case 2
                picClassicHeelTab.Image = ResMgr.GetObject("ClassicBlackHeelTab")
                strClassicHeelTab = "Black"
                lblClassicHeelTab.Text = "The selected color for the Classic Heel Tab is: " & strClassicHeelTab
            Case 3
                picClassicHeelTab.Image = ResMgr.GetObject("ClassicBlueHeelTab")
                strClassicHeelTab = "Blue"
                lblClassicHeelTab.Text = "The selected color for the Classic Heel Tab is: " & strClassicHeelTab
            Case 4
                picClassicHeelTab.Image = ResMgr.GetObject("ClassicGrayHeelTab")
                strClassicHeelTab = "Gray"
                lblClassicHeelTab.Text = "The selected color for the Classic Heel Tab is: " & strClassicHeelTab
            Case 5
                picClassicHeelTab.Image = ResMgr.GetObject("ClassicGreenHeelTab")
                strClassicHeelTab = "Green"
                lblClassicHeelTab.Text = "The selected color for the Classic Heel Tab is: " & strClassicHeelTab
            Case 6
                picClassicHeelTab.Image = ResMgr.GetObject("ClassicLimeHeelTab")
                strClassicHeelTab = "Lime"
                lblClassicHeelTab.Text = "The selected color for the Classic Heel Tab is: " & strClassicHeelTab
            Case 7
                picClassicHeelTab.Image = ResMgr.GetObject("ClassicPinkHeelTab")
                strClassicHeelTab = "Pink"
                lblClassicHeelTab.Text = "The selected color for the Classic Heel Tab is: " & strClassicHeelTab
            Case 8
                picClassicHeelTab.Image = ResMgr.GetObject("ClassicRedHeelTab")
                strClassicHeelTab = "Red"
                lblClassicHeelTab.Text = "The selected color for the Classic Heel Tab is: " & strClassicHeelTab
            Case 9
                picClassicHeelTab.Image = ResMgr.GetObject("ClassicWhiteHeelTab")
                strClassicHeelTab = "White"
                lblClassicHeelTab.Text = "The selected color for the Classic Heel Tab is: " & strClassicHeelTab
                intTick = 0
        End Select





    End Sub

    Private Sub frmClassicHeelTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picClassicHeelTab.Image = ResMgr.GetObject("ClassicWhiteHeelTab")
        strClassicHeelTab = "White"
        lblClassicHeelTab.Text = "The selected color for the Classic Heel Tab is: " & strClassicHeelTab

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Next form
        frmClassicBackCounter.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Going back a form
        frmClassicLaces.Show()
        Me.Hide()
    End Sub
End Class



