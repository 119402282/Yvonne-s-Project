Public Class frmRetroQuarter

    'Declaring the tick which controls the colors
    Dim intTick As Integer = 0

    'Declaring a string to hold the color value across the different pages
    Public strRetroQuarter As String = " "

    Private Sub picRetroQuarter_Click(sender As Object, e As EventArgs) Handles picRetroQuarter.Click

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
        'The variable strRetroQuarter will also be used when transfering the data to a datasheet
        'and for the receipt and billing form
        Select Case intTick
            Case 1
                picRetroQuarter.Image = ResMgr.GetObject("RetroAquaQuarter")
                strRetroQuarter = "Aqua"
                lblRetroQuarter.Text = "The selected color for the Retro Quarter is: " & strRetroQuarter
            Case 2
                picRetroQuarter.Image = ResMgr.GetObject("RetroBlackQuarter")
                strRetroQuarter = "Black"
                lblRetroQuarter.Text = "The selected color for the Retro Quarter is: " & strRetroQuarter
            Case 3
                picRetroQuarter.Image = ResMgr.GetObject("RetroBlueQuarter")
                strRetroQuarter = "Blue"
                lblRetroQuarter.Text = "The selected color for the Retro Quarter is: " & strRetroQuarter
            Case 4
                picRetroQuarter.Image = ResMgr.GetObject("RetroGrayQuarter")
                strRetroQuarter = "Gray"
                lblRetroQuarter.Text = "The selected color for the Retro Quarter is: " & strRetroQuarter
            Case 5
                picRetroQuarter.Image = ResMgr.GetObject("RetroGreenQuarter")
                strRetroQuarter = "Green"
                lblRetroQuarter.Text = "The selected color for the Retro Quarter is: " & strRetroQuarter
            Case 6
                picRetroQuarter.Image = ResMgr.GetObject("RetroLimeQuarter")
                strRetroQuarter = "Lime"
                lblRetroQuarter.Text = "The selected color for the Retro Quarter is: " & strRetroQuarter
            Case 7
                picRetroQuarter.Image = ResMgr.GetObject("RetroPinkQuarter")
                strRetroQuarter = "Pink"
                lblRetroQuarter.Text = "The selected color for the Retro Quarter is: " & strRetroQuarter
            Case 8
                picRetroQuarter.Image = ResMgr.GetObject("RetroRedQuarter")
                strRetroQuarter = "Red"
                lblRetroQuarter.Text = "The selected color for the Retro Quarter is: " & strRetroQuarter
            Case 9
                picRetroQuarter.Image = ResMgr.GetObject("RetroWhiteQuarter")
                strRetroQuarter = "White"
                lblRetroQuarter.Text = "The selected color for the Retro Quarter is: " & strRetroQuarter
                intTick = 0
        End Select





    End Sub

    Private Sub frmRetroQuarter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Using the Resource Manager code again
        Dim ResMgr As Resources.ResourceManager
        ResMgr = New Resources.ResourceManager("Your_Style.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'Setting initial the initial color to white
        picRetroQuarter.Image = ResMgr.GetObject("RetroWhiteQuarter")
        strRetroQuarter = "White"
        lblRetroQuarter.Text = "The selected color for the Retro Quarter is: " & strRetroQuarter

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Forward Navigation through the forms
        frmRetroVamp.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        'Going back a form
        frmShoeType.Show()
        Me.Hide()
        'Closing the forms to reset the color values
        Me.Close()
        frmRetroVamp.Close()
        frmRetroEyestay.Close()
        frmRetroLaces.Close()
        frmRetroHeelTab.Close()
        frmRetroBackCounter.Close()

        'Reseting the Strings
        strRetroQuarter = " "
        frmRetroVamp.strRetroVamp = " "
        frmRetroEyestay.strRetroEyestay = " "
        frmRetroLaces.strRetroLaces = " "
        frmRetroHeelTab.strRetroHeelTab = " "
        frmRetroBackCounter.strRetroBackCounter = " "




    End Sub
End Class
