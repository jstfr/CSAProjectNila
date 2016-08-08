
Public Class ManagerMainForm
    Dim lname, fname, Contact, Address, gender, midname, birthday, user, pass, sq, sqa, pos, customdate As String
    Dim age As Integer
    'age trap for letters
    Private Sub txtage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtage.KeyPress
        Dim allowedChars As String = "0123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub
    'pick customdate for bday
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        customdate = DateTimePicker1.Value.ToString("MM/d/yyyy")
    End Sub
    Private Sub ManagerMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    'timer show
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time1.Text = Date.Now.ToString
    End Sub
    'create employee
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lname = txtlname.Text
        fname = txtfname.Text
        Contact = txtcontact.Text
        Address = txtaddress.Text
        age = txtage.Text
        midname = mname.Text
        gender = cbxgender.Text
        pos = cbxpos.Text
        user = txtuser.Text
        pass = txtpass.Text
        sq = cbxsq.Text
        sqa = txtsqa.Text
        birthday = customdate

        If txtlname.Text <> "" And txtfname.Text <> "" And mname.Text <> "" And txtcontact.Text <> "" And txtaddress.Text <> "" And txtage.Text <> "" And cbxgender.Text <> "" And cbxpos.Text <> "" And txtuser.Text <> "" And txtpass.Text <> "" And cbxsq.Text <> "" And txtsqa.Text <> "" Then
            MsgBox("Completed all the fields above")
            Try
                Me.EmployeeTableAdapter2.InsertQuery(lname, fname, midname, age, gender, birthday, Contact, Address, pos, pass, sq, sqa, user)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("Please complete all the fields above")
        End If

    End Sub
End Class