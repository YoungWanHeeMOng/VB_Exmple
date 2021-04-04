<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lv = New System.Windows.Forms.ListView()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.lb = New System.Windows.Forms.Label()
        Me.lst = New System.Windows.Forms.ListBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(312, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "현재 실행 중인 프로세스 조회...."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lv
        '
        Me.lv.HideSelection = False
        Me.lv.Location = New System.Drawing.Point(3, 31)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(975, 413)
        Me.lv.TabIndex = 1
        Me.lv.UseCompatibleStateImageBehavior = False
        Me.lv.Visible = False
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dg.Location = New System.Drawing.Point(3, 31)
        Me.dg.Name = "dg"
        Me.dg.RowTemplate.Height = 23
        Me.dg.Size = New System.Drawing.Size(975, 413)
        Me.dg.TabIndex = 2
        '
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.Location = New System.Drawing.Point(341, 4)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(42, 12)
        Me.lb.TabIndex = 3
        Me.lb.Text = "Label1"
        '
        'lst
        '
        Me.lst.FormattingEnabled = True
        Me.lst.ItemHeight = 12
        Me.lst.Location = New System.Drawing.Point(3, 380)
        Me.lst.Name = "lst"
        Me.lst.Size = New System.Drawing.Size(975, 64)
        Me.lst.TabIndex = 4
        Me.lst.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Column4"
        Me.Column4.Name = "Column4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 450)
        Me.Controls.Add(Me.lst)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lv As ListView
    Friend WithEvents dg As DataGridView
    Friend WithEvents lb As Label
    Friend WithEvents lst As ListBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
