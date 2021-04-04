Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		''Set view property
		ListView1.View = View.Details
		ListView1.GridLines = True
		ListView1.FullRowSelect = True

		'Add column header
		ListView1.Columns.Add("ProductName", 100)
		ListView1.Columns.Add("Price", 70)
		ListView1.Columns.Add("Quantity", 70)

		'Add items in the listview
		Dim arr(3) As String
		Dim itm As ListViewItem

		'Add first item
		arr(0) = "product_1"
		arr(1) = "100"
		arr(2) = "10"
		itm = New ListViewItem(arr)
		ListView1.Items.Add(itm)

		'Add second item
		arr(0) = "product_2"
		arr(1) = "200"
		arr(2) = "20"
		itm = New ListViewItem(arr)
		ListView1.Items.Add(itm)



	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim productName As String
		Dim price As String
		Dim quantity As String

		productName = ListView1.SelectedItems.Item(0).SubItems(0).Text
		price = ListView1.SelectedItems.Item(0).SubItems(1).Text
		quantity = ListView1.SelectedItems.Item(0).SubItems(2).Text

		MsgBox(productName & " , " & price & " , " & quantity)

		' color dialog box
		Dim dlg As New ColorDialog
		'dlg.ShowDialog()

		If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
			Dim str As String
			str = dlg.Color.Name
			MsgBox(str)

		End If
	End Sub

	Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
		If e.KeyCode = Keys.A Then
			MsgBox("Press Control key")

		End If
	End Sub
	Dim cLeft As Integer = 1
	Public Function AddNewTextBox() As System.Windows.Forms.TextBox
		Dim txt As New System.Windows.Forms.TextBox()
		Me.Controls.Add(txt)
		txt.Top = cLeft * 25
		txt.Left = 100
		txt.Text = "TextBox " & Me.cLeft.ToString
		cLeft = cLeft + 1
		Return txt
	End Function

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		TextBox6.Text = AddNewTextBox().Text

	End Sub
End Class
