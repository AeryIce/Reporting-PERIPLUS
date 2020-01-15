Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient
Public Class FormHome


    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
    End Sub

    Private Sub ButtonRekap_Click(sender As Object, e As EventArgs) Handles ButtonRekap.Click
        If ComboBoxKodeCafe.Text = "PP334" Then
            Call Koneksi()
            Da = New SqlDataAdapter("select a.bara, b.[desc], a.tgl, a.jam,a.struk, a.qty, a.netto as SebelumPB1, round(a.Netto*1.1,-2) as SetelahPB1, b.gol + ' ' + b.nmgol as kategori 
            from tjual..tjual_pp334 a 
            left join tjual..master_cafe_java b on a.bara=b.bara 
            where a.gol like '14%' and 
             a.tgl='" & DateTimePicker1.Text & "'
            order by a.tgl, a.jam", Conn)
            Ds = New DataSet
            Da.Fill(Ds)
            DGVRekapQuery1.DataSource = Ds.Tables(0)

            Call Koneksi()
            Da = New SqlDataAdapter("select a.bara,b.[desc],a.tgl,sum(qty) as qty,sum(netto) as SebelumPB1,round(sum(netto*1.1),-2) as SetelahPB1
            from tjual..tjual_pp334 a
            left join tjual..master_cafe_java b on a.bara=b.bara
            where tgl='" & DateTimePicker1.Text & "'
            and a.gol like '14%'
            group by a.bara, b.[desc], a.tgl
            order by a.tgl,b.[desc]", Conn)
            Ds = New DataSet
            Da.Fill(Ds)
            DGVRekapQuery2.DataSource = Ds.Tables(0)
            TextBoxNamaCafe.Text = "Cafe Java"

        Else
            Call Koneksi()
            Da = New SqlDataAdapter("select a.bara, b.[desc], a.tgl, a.jam, a.qty, a.netto, a.bruto, b.gol + ' ' + b.nmgol as kategori 
            from tjual..tjual_pp333 a 
            left join tjual..master_cafe_themerchant b on a.bara=b.bara 
            where a.gol in ('1464','1463') --like '14%' and a.gol <> '1467' 
            and a.tgl='" & DateTimePicker1.Text & "'
            order by a.tgl, a.jam", Conn)
            Ds = New DataSet
            Da.Fill(Ds)
            DGVRekapQuery1.DataSource = Ds.Tables(0)

            Call Koneksi()
            Da = New SqlDataAdapter("select a.bara,b.[desc],a.tgl,sum(qty) as qty,sum(netto) as netto,sum(bruto) as bruto
            from tjual..tjual_pp333 a
            left join tjual..master_cafe_themerchant b on a.bara=b.bara
            where tgl='" & DateTimePicker1.Text & "'
            and a.gol in ('1464','1463') --like '14%' and a.gol <> '1467' and a.gol <> '1468'
            group by a.bara, b.[desc], a.tgl
            order by a.tgl,b.[desc]", Conn)
            Ds = New DataSet
            Da.Fill(Ds)
            DGVRekapQuery2.DataSource = Ds.Tables(0)
            TextBoxNamaCafe.Text = "The Merchant"

        End If



    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub ButtonConvert_Click(sender As Object, e As EventArgs) Handles ButtonConvert.Click
        Call Koneksi()
        Try
            Dim ExcelApp As Microsoft.Office.Interop.Excel.Application
            Dim ExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim ExcelWorkSheetQuery1, ExcelWorkSheetQuery2 As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim a As Integer
            Dim b As Integer

            ExcelApp = New Microsoft.Office.Interop.Excel.Application
            ExcelWorkBook = ExcelApp.Workbooks.Add(misValue)
            ExcelWorkSheetQuery2 = ExcelWorkBook.Sheets("sheet1")

            For a = 0 To DGVRekapQuery2.RowCount - 2
                For b = 0 To DGVRekapQuery2.ColumnCount - 1
                    For c As Integer = 1 To DGVRekapQuery2.Columns.Count
                        ExcelWorkSheetQuery2.Cells(1, c) = DGVRekapQuery2.Columns(c - 1).HeaderText
                        ExcelWorkSheetQuery2.Cells(a + 2, b + 1) = DGVRekapQuery2(b, a).Value.ToString()
                    Next
                Next
            Next


            ExcelWorkSheetQuery1 = CType(ExcelWorkBook.Worksheets.Add(), Excel.Worksheet)

            For a = 0 To DGVRekapQuery1.RowCount - 2
                For b = 0 To DGVRekapQuery1.ColumnCount - 1
                    For c As Integer = 1 To DGVRekapQuery1.Columns.Count
                        ExcelWorkSheetQuery1.Cells(1, c) = DGVRekapQuery1.Columns(c - 1).HeaderText
                        ExcelWorkSheetQuery1.Cells(a + 2, b + 1) = DGVRekapQuery1(b, a).Value.ToString()
                    Next
                Next
            Next

            ExcelWorkSheetQuery1.Name = "Q1"
            ExcelWorkSheetQuery2.Name = "Q2"

            ExcelWorkSheetQuery2.SaveAs("D:\Report Cafe\Reporting\" & ComboBoxKodeCafe.Text & "\" & TextBoxNamaCafe.Text & " " & DateTimePicker1.Text & ".xlsx")

            ExcelWorkBook.Close()
            ExcelApp.Quit()

            releaseObject(ExcelApp)
            releaseObject(ExcelWorkBook)
            releaseObject(ExcelWorkSheetQuery1)

            MsgBox("Hasil export tersimpan di D:\Report Cafe\Reporting\" & ComboBoxKodeCafe.Text & "\" & TextBoxNamaCafe.Text & " " & DateTimePicker1.Text & ".xlsx", MsgBoxStyle.Information)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
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