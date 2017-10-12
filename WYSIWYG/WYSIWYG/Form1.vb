Public Class Form1
    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        changeStyleText(CheckedListBox1.SelectedIndex)

    End Sub
    Private Sub changeStyleText(index As Integer)
        If index = 0 Then
            input.Font = New Font(input.Font, FontStyle.Bold)
        ElseIf index = 1 Then
            input.Font = New Font(input.Font, FontStyle.Italic)
        ElseIf index = 2 Then
            input.Font = New Font(input.Font, FontStyle.Underline)
        End If

    End Sub
    Private Sub changeColor(control, color)
        control.ForeColor = color
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        changeColor(input, Color.Yellow)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        changeColor(input, Color.Red)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        changeColor(input, Color.Blue)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        changeColor(input, Color.Green)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        changeColor(input, Color.Purple)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        changeColor(input, Color.Orange)
    End Sub

    Private Sub changeColorBackground(control, color)
        control.BackColor = color
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        changeColorBackground(input, Color.Yellow)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        changeColorBackground(input, Color.Red)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        changeColorBackground(input, Color.Blue)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        changeColorBackground(input, Color.Green)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        changeColorBackground(input, Color.Purple)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        changeColorBackground(input, Color.Orange)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckedListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox2.SelectedIndexChanged
        Dim index As Integer = CheckedListBox2.SelectedIndex
        If index = 0 Then
            input.Text = input.Text.ToLower()
        ElseIf index = 1 Then
            input.Text = input.Text.ToUpper()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim size As Integer = Val(ComboBox1.SelectedItem)
        input.Font = New Font(Me.Font.FontFamily, size, FontStyle.Regular)
    End Sub
End Class
