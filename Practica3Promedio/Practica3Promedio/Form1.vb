Public Class Form1
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uniti, unitii, unitiii, unitiv, unitv, suma, promedio As Decimal
        uniti = txtunidadi.Text
        unitii = txtunidadii.Text
        unitiii = txtunidadiii.Text
        unitiv = txtunidadiv.Text
        unitv = txtunidadv.Text
        suma = uniti + unitii + unitiii + unitiv + unitv
        promedio = suma / 5
        MsgBox("El promedio obtenido es: " & promedio)
        lblresult.Text = lblresult.Text & promedio
        txtresult.Text = promedio
        showMessage(promedio)
    End Sub

    Private Sub showMessage(promedio As Decimal)
        If promedio < 70 Then
            lblmssg.Text = "Reprobado, repetición de curso."
        ElseIf promedio >= 70 And promedio < 80 Then
            lblmssg.Text = "Necesitas estudiar más, es importante la investigación y práctica."
        ElseIf promedio >= 80 And promedio < 90 Then
            lblmssg.Text = "Eres un buen estudiante, obtuviste una calificación buena."
        ElseIf promedio >= 90 And promedio <= 100 Then
            lblmssg.Text = "Eres un excelente estudiante, sigue así por el orgullo de ser búfalo."
        Else
            lblmssg.Text = "Error..."
        End If
    End Sub
End Class
