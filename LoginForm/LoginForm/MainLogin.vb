Public Class MainLogin
    Dim username As String
    Dim password As String
    Dim WithEvents timer As New Timer
    Dim milliseconds As Integer
    'animation down
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Panel2.Height = 182 Then
            Panel2.Height = 10
        ElseIf Panel2.Height = 10 Then
            While (Panel1.Height < 182)
                Panel1.Height += 1
            End While
        End If
    End Sub
    'animation up
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        While (Panel1.Height > 10)
            Panel1.Height -= 1
        End While
    End Sub
    'minimize form
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WindowState = FormWindowState.Minimized
    End Sub
    'close
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim m As String
        m = MsgBox("Do you want to close the application?", vbYesNo)
        If m = MsgBoxResult.Yes Then
            Close()
        Else
        End If
    End Sub
    'login cashier
    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        username = txtusername.Text
        password = txtpassword.Text
        If Me.EmployeeTableAdapter1.login(username, password) Then
            MsgBox("Welcome")
            Me.Visible = False
            TableStatus.Show()

        Else
            MsgBox("Invalid username or password")
        End If
    End Sub
    'enter cashier
    Private Sub txtusername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusername.KeyDown, txtpassword.KeyDown
        username = txtusername.Text
        password = txtpassword.Text
        If e.KeyCode = Keys.Enter Then

            If Me.EmployeeTableAdapter1.login(username, password) Then
                MsgBox("Welcome")
                TableStatus.Show()
                Me.Visible = False
            Else
                MsgBox("Invalid username or password")
            End If
        End If

    End Sub
    'enter manager
    Private Sub txtusername1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtusername1.KeyDown, txtpassword1.KeyDown
        username = txtusername1.Text
        password = txtpassword1.Text
        If Me.EmployeeTableAdapter1.loginmanager(username, password) Then
            MsgBox("Welcome Manager")
            ManagerMainForm.Show()
            Me.Close()
        Else
            MsgBox("Invalid username or password")
        End If
    End Sub
    'dropdown manager login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Panel1.Height = 182 Then
            Panel1.Height = 10
        ElseIf Panel1.Height = 10 Then
            While (Panel2.Height < 182)
                Panel2.Height += 1
            End While
        End If
    End Sub
    'login manager
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        username = txtusername1.Text
        password = txtpassword1.Text
        If Me.EmployeeTableAdapter1.loginmanager(username, password) Then
            MsgBox("Welcome Manager")
            ManagerMainForm.Show()
            Me.Close()
        Else
            MsgBox("Invalid username or password")
        End If
    End Sub
    'animationup for manager
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        While (Panel2.Height > 10)
            Panel2.Height -= 1
        End While
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        While (Panel3.Width < 170)
            Panel3.Width = Panel3.Width + 1
        End While
        If Panel3.Width = 170 Then
            Panel4.Visible = True
            While (Panel4.Height < 102)
                Panel4.Height = Panel4.Height + 1
            End While
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        milliseconds += 1
    End Sub

    Private Sub Button8_MouseDown(sender As Object, e As MouseEventArgs) Handles Button8.MouseDown
        timer.Start()
    End Sub

    Private Sub Button8_MouseUp(sender As Object, e As MouseEventArgs) Handles Button8.MouseUp
        timer.Stop()
        If milliseconds >= 5 Then 'Mouse has been down for one second
            Panel4.Visible = False
            While (Panel3.Width > 10)
                Panel3.Width = Panel3.Width - 1
            End While
        End If
        milliseconds = 0
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        While (Panel5.Width < 170)
            Panel5.Width = Panel5.Width + 1
        End While
        If Panel5.Width = 170 Then
            Panel4.Visible = True
            While (Panel4.Height < 102)
                Panel4.Height = Panel4.Height + 1
            End While
        End If
    End Sub

    Private Sub Button9_MouseDown(sender As Object, e As MouseEventArgs) Handles Button9.MouseDown
        timer.Start()
    End Sub

    Private Sub Button9_MouseUp(sender As Object, e As MouseEventArgs) Handles Button9.MouseUp
        If Panel3.Width = 10 Then
            timer.Stop()
            If milliseconds >= 5 Then 'Mouse has been down for one second
                Panel4.Visible = False
                While (Panel5.Width > 10)
                    Panel5.Width = Panel5.Width - 1
                End While
            End If
            milliseconds = 0
        End If
    End Sub

    Private Sub MainLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        time.Text = Date.Now.ToString
    End Sub

    Private Sub time_Click(sender As Object, e As EventArgs) Handles time.Click

    End Sub
End Class