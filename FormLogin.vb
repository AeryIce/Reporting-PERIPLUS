Imports System.Data.SqlClient
Public Class FormLogin
    Dim Dr As SqlDataReader
    Dim Cmd As SqlCommand
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoginAdmin()

    End Sub
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Call LoginAdmin()
        Cmd = New SqlCommand("SELECT * FROM DataAdmin where Nama_Admin ='" & TextBoxUserName.Text & "' And Pass_Admin ='" & TextBoxPassword.Text & "' ", KoneksiLogin)
        Dr = Cmd.ExecuteReader
        Dr.Read()
        If Dr.HasRows Then
            FormHome.Show()
            Me.Visible = False
        Else
            MsgBox("Username dan Password Tidak sesuai")

        End If



    End Sub

    Private Sub TextBoxUserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUserName.KeyPress
        If e.KeyChar = Chr(13) Then TextBoxPassword.Focus()

    End Sub
End Class