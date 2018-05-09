Public Class Form1


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Admin" And TextBox2.Text = "123" Then
            Me.Hide()
            Form2.Show()
        Else : MsgBox("Incorrect Username and Password combination", MessageBoxIcon.Error)
        End If
    End Sub
End Class
