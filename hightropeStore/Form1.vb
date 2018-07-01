Public Class Form1
    Dim currentlyInstallingApp As String = "Application"
    Dim currentlyInstallingAppDeveloper As String = "Application Developer"
    Dim currentlyOpenTab As String = "Featured"
    Dim currentTheme As String = "Dark"
    Dim themeTimerUse As String = ""
    Dim version As String = 0.1
    Dim deepTextColor As Color = Color.FromArgb(168, 170, 240)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkForThemeTimer.Start()
        settingsLabel8.Text = "Hightrope Store, v." + version
    End Sub
    'Settings

    'Theme
    Private Sub settingsDarkColorButton_Click(sender As Object, e As EventArgs) Handles settingsDarkColorButton.Click
        currentTheme = "Dark"

    End Sub

    Private Sub settingsLightColorButton_Click(sender As Object, e As EventArgs) Handles settingsLightColorButton.Click
        currentTheme = "Light"
    End Sub
    Private Sub settingsDeepColorButton_Click(sender As Object, e As EventArgs) Handles settingsDeepColorButton.Click
        currentTheme = "Deep"
    End Sub
    Private Sub checkForThemeTimer_Tick(sender As Object, e As EventArgs) Handles checkForThemeTimer.Tick
        If currentTheme = "Dark" Then

            'apply dark theme
            If themeTimerUse <> "Dark" Then
                themeTimerUse = "Dark"
                settingsDarkColorButton.BackColor = Color.FromArgb(161, 161, 161)
                settingsLightColorButton.BackColor = Color.FromArgb(64, 64, 64)
                settingsDeepColorButton.BackColor = Color.FromArgb(64, 64, 64)
                settingsPage.BackColor = Color.FromArgb(18, 18, 18)
                featuredPage.BackColor = Color.FromArgb(18, 18, 18)
                gamesPage.BackColor = Color.FromArgb(18, 18, 18)
                appsPage.BackColor = Color.FromArgb(18, 18, 18)
                searchPage.BackColor = Color.FromArgb(18, 18, 18)
                uploadPage.BackColor = Color.FromArgb(18, 18, 18)
                RichTextBox1.BackColor = Color.FromArgb(18, 18, 18)
                settingsLabel1.ForeColor = Color.White
                settingsLabel2.ForeColor = Color.White
                settingsLabel3.ForeColor = Color.White
                settingsLabel4.ForeColor = Color.White
                settingsLabel5.ForeColor = Color.White
                settingsLabel6.ForeColor = Color.White
                settingsLabel7.ForeColor = Color.Silver
                settingsLabel8.ForeColor = Color.Silver
                settingsLabel9.ForeColor = Color.FromArgb(30, 56, 91)
                settingsButton2.BackColor = Color.FromArgb(47, 47, 47)
                settingsButton1.BackColor = Color.FromArgb(47, 47, 47)
                Panel1.BackColor = Color.FromArgb(15, 15, 15)
                Button1.ForeColor = Color.White
                Button2.ForeColor = Color.White
                Button3.ForeColor = Color.White
                Button4.ForeColor = Color.White
                Button5.ForeColor = Color.White
                Button6.ForeColor = Color.White
                Button7.BackColor = Color.FromArgb(47, 47, 47)
                Button8.BackColor = Color.FromArgb(47, 47, 47)
                RichTextBox1.ForeColor = Color.White
            End If
        End If


        If currentTheme = "Light" Then
            'apply light theme
            If themeTimerUse <> "Light" Then
                themeTimerUse = "Light"
                settingsDarkColorButton.BackColor = Color.FromArgb(161, 161, 161)
                settingsLightColorButton.BackColor = Color.FromArgb(64, 64, 64)
                settingsDeepColorButton.BackColor = Color.FromArgb(161, 161, 161)
                settingsPage.BackColor = Color.FromArgb(233, 233, 233)
                featuredPage.BackColor = Color.FromArgb(233, 233, 233)
                gamesPage.BackColor = Color.FromArgb(233, 233, 233)
                appsPage.BackColor = Color.FromArgb(233, 233, 233)
                searchPage.BackColor = Color.FromArgb(233, 233, 233)
                uploadPage.BackColor = Color.FromArgb(233, 233, 233)
                RichTextBox1.BackColor = Color.FromArgb(233, 233, 233)
                settingsLabel1.ForeColor = Color.Black
                settingsLabel2.ForeColor = Color.Black
                settingsLabel3.ForeColor = Color.Black
                settingsLabel4.ForeColor = Color.Black
                settingsLabel5.ForeColor = Color.Black
                settingsLabel6.ForeColor = Color.Black
                settingsLabel7.ForeColor = Color.DimGray
                settingsLabel8.ForeColor = Color.DimGray
                settingsLabel9.ForeColor = Color.FromArgb(30, 56, 91)
                settingsButton2.BackColor = Color.DimGray
                settingsButton1.BackColor = Color.DimGray
                Panel1.BackColor = Color.FromArgb(220, 220, 220)
                Button1.ForeColor = Color.Black
                Button2.ForeColor = Color.Black
                Button3.ForeColor = Color.Black
                Button4.ForeColor = Color.Black
                Button5.ForeColor = Color.Black
                Button6.ForeColor = Color.Black
                Button7.BackColor = Color.DimGray
                Button8.BackColor = Color.DimGray
                RichTextBox1.ForeColor = Color.Black
            End If
        End If


        If currentTheme = "Deep" Then
            'apply deep theme
            If themeTimerUse <> "Deep" Then
                themeTimerUse = "Deep"
                settingsDarkColorButton.BackColor = Color.FromArgb(119, 121, 205)
                settingsLightColorButton.BackColor = Color.FromArgb(119, 121, 205)
                settingsDeepColorButton.BackColor = Color.FromArgb(33, 34, 80)
                settingsPage.BackColor = Color.FromArgb(12, 14, 35)
                featuredPage.BackColor = Color.FromArgb(12, 14, 35)
                gamesPage.BackColor = Color.FromArgb(12, 14, 35)
                appsPage.BackColor = Color.FromArgb(12, 14, 35)
                searchPage.BackColor = Color.FromArgb(12, 14, 35)
                uploadPage.BackColor = Color.FromArgb(12, 14, 35)
                RichTextBox1.BackColor = Color.FromArgb(12, 14, 35)
                settingsLabel1.ForeColor = deepTextColor
                settingsLabel2.ForeColor = deepTextColor
                settingsLabel3.ForeColor = deepTextColor
                settingsLabel4.ForeColor = deepTextColor
                settingsLabel5.ForeColor = deepTextColor
                settingsLabel6.ForeColor = deepTextColor
                settingsLabel7.ForeColor = Color.Silver
                settingsLabel8.ForeColor = Color.Silver
                settingsLabel9.ForeColor = Color.FromArgb(220, 126, 65)
                settingsButton2.BackColor = Color.FromArgb(33, 34, 80)
                settingsButton1.BackColor = Color.FromArgb(33, 34, 80)
                Panel1.BackColor = Color.FromArgb(9, 11, 32)
                Button1.ForeColor = deepTextColor
                Button2.ForeColor = deepTextColor
                Button3.ForeColor = deepTextColor
                Button4.ForeColor = deepTextColor
                Button5.ForeColor = deepTextColor
                Button6.ForeColor = deepTextColor
                Button7.BackColor = Color.FromArgb(33, 34, 80)
                Button8.BackColor = Color.FromArgb(33, 34, 80)
                RichTextBox1.ForeColor = deepTextColor
            End If
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles settingsLabel9.Click
        Process.Start("https://hightrope.ml/store.html")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles settingsButton2.Click
        licenseForm.Show()
    End Sub
    Private Sub settingsButton1_Click(sender As Object, e As EventArgs) Handles settingsButton1.Click
        Form2.Show()
    End Sub

    Private Sub settingsLabel2_MouseHover(sender As Object, e As EventArgs) Handles settingsLabel2.MouseHover
        settingsPictureBox.BackgroundImage = My.Resources.themePreviews.lightPreview
    End Sub
    Private Sub settingsLabel3_MouseHover(sender As Object, e As EventArgs) Handles settingsLabel3.MouseHover
        settingsPictureBox.BackgroundImage = My.Resources.themePreviews.darkPreview
    End Sub
    Private Sub settingsLabel4_MouseHover(sender As Object, e As EventArgs) Handles settingsLabel4.MouseHover
        settingsPictureBox.BackgroundImage = My.Resources.themePreviews.deepPreview
    End Sub
    'Panel Buttons
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TabControl1.SelectedTab = settingsPage
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedTab = featuredPage
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectedTab = gamesPage
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectedTab = appsPage
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabControl1.SelectedTab = searchPage
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = uploadPage
    End Sub
    'Upload screen
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Process.Start("mailto:" & "hightropestore@gmail.com?subject=Application Submission&body=
Developer name: Dohn Joe, 
Developer email: UsedToVerify@A.Developer, 
Application name: ..., 
Application description: ..., 
Application link: dropbox.com/blahblahblah 

")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        emailtemplate.Show()
    End Sub
End Class
