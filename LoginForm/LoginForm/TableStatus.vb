Public Class TableStatus
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged



    End Sub
    'close form
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim m As String
        m = MsgBox("Do you want to close the application?", vbYesNo)
        If m = MsgBoxResult.Yes Then
            MainLogin.Close()
            Me.Close()
        Else
        End If
    End Sub
    'minimize form
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MainLogin.Show()
    End Sub

    Private Sub pictable1_Click(sender As Object, e As EventArgs) Handles pictable1.Click, pictable2.Click, pictable3.Click, pictable4.Click, pictable5.Click, pictable6.Click, pictable7.Click, pictable8.Click, pictable9.Click, pictable10.Click, pictable11.Click, pictable12.Click

        'Select Case 

        '    Case pictable1
        '        If ComboBox1.Text = "Paid" Then
        '            pictable1.BackgroundImage = Image.FromFile("C:\Users\Robert\Desktop\System\greenTable.png")
        '        ElseIf ComboBox1.Text = "Not paid" Then
        '            pictable1.BackgroundImage = Image.FromFile("C:\Users\Robert\Desktop\System\redTable.png")
        '        ElseIf ComboBox1.Text = "None" Then
        '            pictable1.BackgroundImage = Image.FromFile("C:\Users\Robert\Desktop\System\white table.png")
        '        End If
        '    Case 2

        'End Select
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles pictable11.Click

    End Sub
End Class