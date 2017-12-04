<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMKB
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMKB))
        Me.pnl_top = New System.Windows.Forms.Panel()
        Me.btn_find = New System.Windows.Forms.Button()
        Me.edt_diag = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.g_mkb = New System.Windows.Forms.DataGridView()
        Me.kod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type_diag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_top.SuspendLayout()
        CType(Me.g_mkb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_top
        '
        Me.pnl_top.Controls.Add(Me.btn_find)
        Me.pnl_top.Controls.Add(Me.edt_diag)
        Me.pnl_top.Controls.Add(Me.Label1)
        Me.pnl_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_top.Location = New System.Drawing.Point(0, 0)
        Me.pnl_top.Name = "pnl_top"
        Me.pnl_top.Size = New System.Drawing.Size(585, 34)
        Me.pnl_top.TabIndex = 0
        '
        'btn_find
        '
        Me.btn_find.Location = New System.Drawing.Point(356, 5)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(75, 23)
        Me.btn_find.TabIndex = 2
        Me.btn_find.Text = "Поиск"
        Me.btn_find.UseVisualStyleBackColor = True
        '
        'edt_diag
        '
        Me.edt_diag.Location = New System.Drawing.Point(64, 7)
        Me.edt_diag.Name = "edt_diag"
        Me.edt_diag.Size = New System.Drawing.Size(284, 20)
        Me.edt_diag.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Диагноз"
        '
        'g_mkb
        '
        Me.g_mkb.AllowUserToAddRows = False
        Me.g_mkb.AllowUserToDeleteRows = False
        Me.g_mkb.AllowUserToResizeRows = False
        Me.g_mkb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.g_mkb.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kod, Me.type_diag, Me.diag})
        Me.g_mkb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_mkb.Location = New System.Drawing.Point(0, 34)
        Me.g_mkb.Name = "g_mkb"
        Me.g_mkb.RowHeadersVisible = False
        Me.g_mkb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.g_mkb.Size = New System.Drawing.Size(585, 401)
        Me.g_mkb.TabIndex = 1
        '
        'kod
        '
        Me.kod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.kod.DataPropertyName = "kod"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.kod.DefaultCellStyle = DataGridViewCellStyle1
        Me.kod.HeaderText = "Код"
        Me.kod.Name = "kod"
        Me.kod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.kod.Width = 32
        '
        'type_diag
        '
        Me.type_diag.DataPropertyName = "type_diag"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.type_diag.DefaultCellStyle = DataGridViewCellStyle2
        Me.type_diag.HeaderText = "Тип диагноза"
        Me.type_diag.Name = "type_diag"
        Me.type_diag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.type_diag.Width = 120
        '
        'diag
        '
        Me.diag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.diag.DataPropertyName = "diag"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.diag.DefaultCellStyle = DataGridViewCellStyle3
        Me.diag.HeaderText = "Диагноз"
        Me.diag.Name = "diag"
        Me.diag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'FMKB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 435)
        Me.Controls.Add(Me.g_mkb)
        Me.Controls.Add(Me.pnl_top)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FMKB"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "МКБ-10"
        Me.pnl_top.ResumeLayout(False)
        Me.pnl_top.PerformLayout()
        CType(Me.g_mkb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_top As System.Windows.Forms.Panel
    Friend WithEvents edt_diag As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents g_mkb As System.Windows.Forms.DataGridView
    Friend WithEvents btn_find As System.Windows.Forms.Button
    Friend WithEvents kod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type_diag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents diag As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
