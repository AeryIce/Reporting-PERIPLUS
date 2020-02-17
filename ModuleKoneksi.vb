Imports System.Data.SqlClient
Module ModuleKoneksi
    Public Conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Dr As SqlDataReader
    Public Ds As DataSet
    Public cmd As SqlCommand

    Sub Koneksi()
        Try
            Conn = New SqlConnection("Server=NUNU-PC\SQLEXPRESS;database= TJUAL;Trusted_Connection =yes")
            Conn.Open()
            FormHome.LabelDatabase.Text = "connected"
        Catch ex As Exception
            FormHome.LabelDatabase.Text = "Not Connected"

        End Try
    End Sub


End Module
