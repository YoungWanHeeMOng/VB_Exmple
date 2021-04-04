Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports System.IO

Public Class Form1
    '엑셀 사용을 위한 변수.....
    Dim ExcelApp As Excel.Application = Nothing
    Dim wb As Excel.Workbook = Nothing
    Dim ws As Excel.Worksheet = Nothing

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '원본 파일이 없다면...
        If Not File.Exists("D:\Test.xls") Then
            Return
        End If
        '파일이 있다면 삭제하고...
        If File.Exists("d:\Testw.xls") Then
            File.Delete("d:\Testw.xls")
        End If
        Try
            ExcelApp = New Excel.Application()
            'wb = ExcelApp.Workbooks.Add("Test") >= 엑셀 파일 만들 때 새로운 워크북 추가 
            '엑셀 파일 오픈...
            wb = ExcelApp.Workbooks.Open("D:\Test.xls")
            ws = CType(wb.Worksheets("Sheet1"), Excel.Worksheet)

            '시트 -> 셀에 데이터 삽입 부분
            ws.Cells(1, 1) = "1"
            ws.Cells(1, 2) = "12"
            ws.Cells(1, 3) = "123"
            ws.Cells(1, 4) = "1234"

            '폼 화면에 디스플레이...
            TextBox1.Text += "A1: 1" + System.Environment.NewLine
            TextBox1.Text += "A2: 12" + System.Environment.NewLine
            TextBox1.Text += "A3: 123" + System.Environment.NewLine
            TextBox1.Text += "A4: 1234" + System.Environment.NewLine
            TextBox1.Text += "===========================" + System.Environment.NewLine
            TextBox1.Text += "Excel File Write..." + System.Environment.NewLine
            TextBox1.Text += "===========================" + System.Environment.NewLine

            '파일 닫기... 
            '다른이름으로 저장하기...
            wb.SaveAs("d:\Testw.xls")
            wb.Saved = True
            wb.Close(False, Excel.XlFileFormat.xlWorkbookNormal)
            ExcelApp.Quit()
        Catch ex As Exception
            '객체 메모리 해제...
            ReleaseObject(ws)
            ReleaseObject(wb)
            ReleaseObject(ExcelApp)
            GC.Collect()
        Finally
            '객체 메모리 해제...
            ReleaseObject(ws)
            ReleaseObject(wb)
            ReleaseObject(ExcelApp)
            GC.Collect()
        End Try


    End Sub


    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            If Not obj Is Nothing Then
                Runtime.InteropServices.Marshal.ReleaseComObject(obj)
                obj = Nothing
            End If
        Catch
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '엑셀 파일 존재 하지 않는다면.....
        If Not File.Exists("d:\test.xls") Then
            Return
        End If

        Try
            ExcelApp = New Excel.Application()
            '엑셀 파일 오픈
            wb = ExcelApp.Workbooks.Open("d:\test.xls")
            ws = CType(wb.Worksheets("sheet1"), Excel.Worksheet)

            '시트 -> 셀 값 얻어 오기....
            Dim rg As Excel.Range = CType(ws.Cells(1, 1), Excel.Range)
            Dim rg2 As Excel.Range = CType(ws.Cells(1, 2), Excel.Range)
            Dim rg3 As Excel.Range = CType(ws.Cells(1, 3), Excel.Range)
            Dim rg4 As Excel.Range = CType(ws.Cells(1, 4), Excel.Range)

            TextBox1.Text += "A1:" + rg.Value2.ToString() + System.Environment.NewLine
            TextBox1.Text += "A2:" + rg2.Value2.ToString() + System.Environment.NewLine
            TextBox1.Text += "A3:" + rg3.Value2.ToString() + System.Environment.NewLine
            TextBox1.Text += "A4:" + rg4.Value2.ToString() + System.Environment.NewLine

            TextBox1.Text += "===========================" + System.Environment.NewLine
            TextBox1.Text += "Excel File Write..." + System.Environment.NewLine
            TextBox1.Text += "===========================" + System.Environment.NewLine

            '파일 닫기.....
            wb.Close(False, Excel.XlFileFormat.xlWorkbookNormal)
            ExcelApp.Quit()

        Catch ex As Exception
            '객체 메모리 해제...
            ReleaseObject(ws)
            ReleaseObject(wb)
            ReleaseObject(ExcelApp)

        Finally
            '객체 메모리 해제...
            ReleaseObject(ws)
            ReleaseObject(wb)
            ReleaseObject(ExcelApp)
        End Try


    End Sub
End Class
