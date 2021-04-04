
Imports System.Management
Public Class Form1
    Dim strQry As String = "Select Name, ProcessID,  ExecutablePath,WorkingSetSize From Win32_Process"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '리스트뷰 아이템 초기화
        lv.Items.Clear()
        'dg.Rows.Clear()
        lst.Items.Clear()
        'dg.RowCount = 30
        Dim oWMI As ManagementObjectSearcher = New ManagementObjectSearcher(New SelectQuery(strQry))
        For Each oItem As ManagementObject In oWMI.Get()
            Try
                Dim lvi As ListViewItem = New ListViewItem()
                Dim str(4) As String
                lvi.Text = oItem.GetPropertyValue("Name").ToString()
                str(0) = oItem.GetPropertyValue("Name").ToString()
                'lvi.SubItems.Add(oItem.GetPropertyValue("ProcessID").ToString())
                lvi.Text += (" , " + (oItem.GetPropertyValue("ProcessID").ToString()))
                str(1) = ((oItem.GetPropertyValue("ProcessID").ToString()))
                'lvi.SubItems.Add(String.Format("{0:00}", CType(Integer.Parse(oItem.GetPropertyValue("WorkingSetSize").ToString()) / 1024, Double)) + " KB")
                lvi.Text += (" , " + (String.Format("{0:00}", CType(Integer.Parse(oItem.GetPropertyValue("WorkingSetSize").ToString()) / 1024, Double)) + " KB"))
                str(2) = ((String.Format("{0:00}", CType(Integer.Parse(oItem.GetPropertyValue("WorkingSetSize").ToString()) / 1024, Double)) + " KB"))
                'lvi.SubItems.Add(oItem.GetPropertyValue("ExecutablePath").ToString())
                'lvi.Text += (" , " + (oItem.GetPropertyValue("ExecutablePath").ToString()))
                'lv.Items.Add(lvi)
                'dg.Rows.Add(lvi)


                dg.Rows.Add(str)
                lb.Text = lvi.ToString()
                'lst.Items.Add(lvi.ToString())

                Debug.WriteLine(str(2).ToString())
            Catch ex As Exception
            End Try
        Next

    End Sub
End Class
