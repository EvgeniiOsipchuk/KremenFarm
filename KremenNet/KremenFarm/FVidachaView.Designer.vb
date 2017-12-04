<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FVidachaView
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FVidachaView))
        Me.g_vidach = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apteka = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolvo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.upak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.g_vidach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'g_vidach
        '
        Me.g_vidach.AllowUserToAddRows = False
        Me.g_vidach.AllowUserToDeleteRows = False
        Me.g_vidach.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.g_vidach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.g_vidach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.g_vidach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.apteka, Me.kod, Me.medname, Me.kolvo, Me.price, Me.upak})
        Me.g_vidach.Location = New System.Drawing.Point(8, 12)
        Me.g_vidach.MultiSelect = False
        Me.g_vidach.Name = "g_vidach"
        Me.g_vidach.ReadOnly = True
        Me.g_vidach.RowHeadersVisible = False
        Me.g_vidach.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.g_vidach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.g_vidach.Size = New System.Drawing.Size(560, 360)
        Me.g_vidach.TabIndex = 4
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.id.Visible = False
        '
        'apteka
        '
        Me.apteka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.apteka.DataPropertyName = "apteka_name"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.apteka.DefaultCellStyle = DataGridViewCellStyle2
        Me.apteka.HeaderText = "Аптека"
        Me.apteka.Name = "apteka"
        Me.apteka.ReadOnly = True
        Me.apteka.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.apteka.Width = 49
        '
        'kod
        '
        Me.kod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.kod.DataPropertyName = "kod"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.kod.DefaultCellStyle = DataGridViewCellStyle3
        Me.kod.HeaderText = "Код"
        Me.kod.Name = "kod"
        Me.kod.ReadOnly = True
        Me.kod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.kod.Width = 32
        '
        'medname
        '
        Me.medname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.medname.DataPropertyName = "medname"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.medname.DefaultCellStyle = DataGridViewCellStyle4
        Me.medname.HeaderText = "Наименование"
        Me.medname.Name = "medname"
        Me.medname.ReadOnly = True
        Me.medname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'kolvo
        '
        Me.kolvo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.kolvo.DataPropertyName = "kolvo"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.kolvo.DefaultCellStyle = DataGridViewCellStyle5
        Me.kolvo.HeaderText = "Кол-во"
        Me.kolvo.Name = "kolvo"
        Me.kolvo.ReadOnly = True
        Me.kolvo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.kolvo.Width = 47
        '
        'price
        '
        Me.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.price.DataPropertyName = "price"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.price.DefaultCellStyle = DataGridViewCellStyle6
        Me.price.HeaderText = "Цена"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        Me.price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price.Width = 39
        '
        'upak
        '
        Me.upak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.upak.DataPropertyName = "upak"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.upak.DefaultCellStyle = DataGridViewCellStyle7
        Me.upak.HeaderText = "Уп"
        Me.upak.Name = "upak"
        Me.upak.ReadOnly = True
        Me.upak.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.upak.Width = 27
        '
        'FVidachaView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 384)
        Me.Controls.Add(Me.g_vidach)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FVidachaView"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Просмотр выдачи"
        CType(Me.g_vidach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents g_vidach As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apteka As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents medname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kolvo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents upak As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
