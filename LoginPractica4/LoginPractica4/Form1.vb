Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "usuario" And TextBox2.Text = "pass" Then
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Login incorrecto")
        End If
    End Sub
End Class
