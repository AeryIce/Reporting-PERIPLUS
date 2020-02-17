Imports System.Data.SqlClient
Module ModuleLogin
	Public KoneksiLogin As SqlConnection



	Sub LoginAdmin()
		Try
			KoneksiLogin = New SqlConnection("Data source=NUNU-PC\SQLEXPRESS;Initial Catalog = Admin;Integrated security = True")
			KoneksiLogin.Open()
			FormLogin.LabelStatusDB.Text = "Connected"

		Catch ex As Exception
			FormLogin.LabelStatusDB.Text = "Not Connected"

		End Try


	End Sub

End Module
