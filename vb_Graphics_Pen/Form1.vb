Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim pens As New Pen(Color.Purple)
        pens.DashStyle = DashStyle.Dash 'pen will draw with a dashed line
        pens.EndCap = LineCap.ArrowAnchor 'the line will end in an arrow
        pens.StartCap = LineCap.Round 'The line draw will start rounded
        '*Notice* - the Start and End Caps will not show if you draw a closed shape
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim pen As New Pen(Color.Blue, 5) 'Use a blue pen with a width of 15
        Dim point1 As New Point(5, 15) 'starting point of the line
        Dim point2 As New Point(30, 100) 'ending point of the line
        e.Graphics.DrawLine(pen, point1, point2)

        e.Graphics.DrawRectangle(pen, 60, 90, 200, 300) 'draw an outline of the rectangle

        Dim pen2 As New Pen(Color.Orange, 5) 'Use an orange pen with width of 1
        Dim origRect As New Rectangle(90, 30, 50, 60) 'Define bounds of arc
        e.Graphics.DrawArc(pen2, origRect, 20, 180) 'Draw arc in the rectangle bounds

        Dim rect As New Rectangle(50, 50, 50, 50)
        e.Graphics.FillRectangle(Brushes.Green, rect) 'draws a rectangle that is filled with green


        rect = New Rectangle(100, 100, 150, 250)
        e.Graphics.FillPie(Brushes.Silver, rect, 0, 220) 'draws a half circle that is filled with silver


        Dim hBrush As New HatchBrush(HatchStyle.ZigZag, Color.SkyBlue, Color.Gray)
        'creates a HatchBrush Tool with a background color of blue, foreground color of gray, 
        'and will fill with a zigzag pattern
        Dim rectan As New Rectangle(300, 100, 400, 100)
        e.Graphics.FillRectangle(hBrush, rectan)

        Dim lBrush As New LinearGradientBrush(point1, point2, Color.MediumVioletRed, Color.PaleGreen)
        Dim rect1 As New Rectangle(350, 150, 400, 200)
        e.Graphics.FillRectangle(lBrush, rect1)

        Dim textBrush As New TextureBrush(New Bitmap("d:\car.jpg"))
        Dim rect2 As New Rectangle(400, 400, 150, 150)
        e.Graphics.FillPie(textBrush, rect2, 0, 360)
    End Sub

    Private Sub btnEnum_Click(sender As Object, e As EventArgs) Handles btnEnum.Click
        clearlist()

        'Dim chrt s   As Enum=New chart1.

        '  ChRT 종류를 읽어 오기
        For Each item As String In System.Enum.GetNames(GetType(SeriesChartType))
            lst.Items.Add(item.ToString())
        Next



    End Sub

    Private Sub clearlist()
        lst.Items.Clear()
    End Sub
End Class
