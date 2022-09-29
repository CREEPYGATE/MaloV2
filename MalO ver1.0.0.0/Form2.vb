Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Panel1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 100 Then
            Label3.Text = "Installed"
            Panel7.Show()
            Timer4.Start()
            Button5.Enabled = True
            Button8.Show()
            Timer1.Stop()
            Label11.Text = "Messages (1)"
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel8.Hide()
        Button8.Hide()
        Button5.Enabled = False
        Panel7.Hide()
        Panel4.Hide()
        Panel6.Hide()
        Timer2.Start()
        Panel1.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.Hide()
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label9.Text = TimeOfDay.ToString("h:mm:ss tt")

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel4.Show()
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Label15.Text = TextBox1.Text
        If Label15.Text = TextBox1.Text Then
            TextBox1.Clear()
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Panel6.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Panel4.Hide()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)

        Panel6.Hide()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs)
        Panel7.Hide()
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Timer4_Tick_1(sender As Object, e As EventArgs) Handles Timer4.Tick
        Panel7.Width = Panel7.Width + 1
        If Panel7.Width > 314 Then
            Timer4.Stop()
            Panel7.Hide()
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Form1.Close()
        Me.Close()
    End Sub

    Dim InitialMouseDownLocation As Point

    Private Sub PictureBox5_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseDown
        If e.Button = MouseButtons.Left Then
            InitialMouseDownLocation = e.Location
            Cursor.Current = Cursors.NoMove2D
        End If
    End Sub

    Private Sub PictureBox5_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseMove
        If e.Button = MouseButtons.Left Then
            Location = New Point(Location.X - InitialMouseDownLocation.X + e.X, Location.Y - InitialMouseDownLocation.Y + e.Y)
        End If
    End Sub

    Private Sub PictureBox5_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseUp
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Panel8.Show()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        Panel8.Hide()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)

        BackColor = Color.Silver
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        BackColor = Color.Snow
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        My.Computer.Audio.Play(My.Resources.click, AudioPlayMode.Background)
        BackColor = Color.LightBlue
    End Sub
End Class