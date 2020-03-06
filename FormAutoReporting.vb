Imports System.Data.SqlClient
Imports System.Data
Imports excel = Microsoft.Office.Interop.Excel

Public Class FormAutoReporting

    Private Sub FormAutoReporting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Dim Conn As SqlConnection
        Dim connectionString As String
        Dim Sql As String
        Dim i, J As Integer

        Dim Xlapp As excel.Application
        Dim XlWorkBook As excel.Workbook
        Dim XlWorkSheet1 As excel.Worksheet
        Dim MissValue As Object = System.Reflection.Missing.Value

        Xlapp = New excel.ApplicationClass
        XlWorkBook = Xlapp.Workbooks.Add(MissValue)
        XlWorkSheet1 = XlWorkBook.Sheets("Sheet1")

        XlWorkSheet1.Name = "Query1"



        connectionString = "Data Source = NUNU-PC\SQLEXPRESS;Initial Catalog=Tjual;Integrated Security=True"
        Conn = New SqlConnection(connectionString)
        Conn.Open()
        Sql = "select a.bara, b.[desc], a.tgl, a.jam,a.struk, a.qty, a.netto as SebelumPB1, round(a.Netto*1.1,-2) as SetelahPB1, b.gol + ' ' + b.nmgol as kategori
            from tjual..tjual_pp334 a 
            left join tjual..master_cafe_java b on a.bara=b.bara 
            where a.gol like '14%' and 
             a.tgl='20200102'
            group by a.bara,b.[desc],a.tgl,a.jam,a.struk,a.qty,b.gol,b.nmgol,a.netto
            order by a.tgl, a.jam"


        Dim DaCmd1 As New SqlDataAdapter(Sql, Conn)
        Ds = New DataSet
        DaCmd1.Fill(Ds)
        Conn.Close()


        For i = 0 To Ds.Tables(0).Rows.Count - 1
            For J = 0 To Ds.Tables(0).Columns.Count - 1
                XlWorkSheet1.Cells(i + 1, J + 1) =
                    Ds.Tables(0).Rows(i).Item(J)
            Next
        Next
 



        XlWorkSheet1.SaveAs("D:\Aga\Sql To Excel.xlsx")
        XlWorkBook.Close()
        Xlapp.Quit()

        ReleaseObject(Xlapp)
        ReleaseObject(XlWorkBook)
        ReleaseObject(XlWorkSheet1)

        Conn.Close()

        MsgBox("Done, Find At D:/Aga/Sql To Excel")
        Me.Close()
        FormLogin.Close()


    End Sub



    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing

        Catch ex As Exception
            obj = Nothing

        Finally
            GC.Collect()

        End Try


    End Sub




End Class