Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j, n As Integer
        j = 1
        n = TextBox1.Text
        For i = 1 To n Step 1
            j = j * i
        Next
        Label2.Text = "Factorial:  " & j
    End Sub
End Class
