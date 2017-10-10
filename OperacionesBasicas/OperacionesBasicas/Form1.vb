Public Class Calculadora
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim suma1 As Integer = Val(txt1.Text)
        Dim suma2 As Integer = Val(txt2.Text)
        Dim resultado As Integer = suma1 + suma2
        lblresultadosuma.Text = resultado
    End Sub

    Private Sub btnresultado2_Click(sender As Object, e As EventArgs) Handles btnresultado2.Click
        Dim var1 As Integer = Val(txt4.Text)
        Dim var2 As Integer = Val(txt3.Text)
        Dim resultado As Integer = var1 - var2
        lblresultadoresta.Text = resultado
    End Sub

    Private Sub btnresultado3_Click(sender As Object, e As EventArgs) Handles btnresultado3.Click
        Dim var1 As Integer = Val(txt6.Text)
        Dim var2 As Integer = Val(txt5.Text)
        Dim resultado As Integer = var1 * var2
        txtbox7.Text = resultado
    End Sub

    Private Sub btnresultado4_Click(sender As Object, e As EventArgs) Handles btnresultado4.Click
        Dim var1 As Integer = Val(txt10.Text)
        Dim var2 As Integer = Val(txt9.Text)
        Dim resultado As Integer = var1 / var2
        txt8.Text = resultado
    End Sub
End Class
