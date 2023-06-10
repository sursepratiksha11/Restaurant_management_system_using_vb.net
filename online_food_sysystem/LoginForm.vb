Imports System.Text.RegularExpressions
Public Class LoginForm
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub btnlock_Click(sender As Object, e As EventArgs) Handles btnlock.Click
        Application.Exit()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        If TextBox1.Text = "spratiksha" And TextBox2.Text = "pratiksha11@" Then
            MsgBox("Successfully Login")
            Me.Hide()
            HomeForm1.Show()

        ElseIf TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Please Enter Your Name")

        ElseIf TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "Please Enter Your Password")

        Else
            MsgBox("Login fail")

        End If


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
