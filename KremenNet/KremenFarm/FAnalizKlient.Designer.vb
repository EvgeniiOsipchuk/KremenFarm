<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAnalizKlient
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FAnalizKlient))
        Me.g_analiz_klient = New System.Windows.Forms.DataGridView()
        Me.date_napr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_napr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_akt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_akt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_add_analiz_klient = New System.Windows.Forms.Button()
        Me.btn_del_analiz = New System.Windows.Forms.Button()
        Me.btn_print_analiz = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.lbl_klient = New System.Windows.Forms.Label()
        CType(Me.g_analiz_klient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'g_analiz_klient
        '
        Me.g_analiz_klient.AllowUserToAddRows = False
        Me.g_analiz_klient.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.g_analiz_klient.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.g_analiz_klient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.g_analiz_klient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.date_napr, Me.id, Me.nom_napr, Me.date_akt, Me.nom_akt, Me.total_price})
        Me.g_analiz_klient.Location = New System.Drawing.Point(5, 25)
        Me.g_analiz_klient.Name = "g_analiz_klient"
        Me.g_analiz_klient.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.g_analiz_klient.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.g_analiz_klient.RowHeadersVisible = False
        Me.g_analiz_klient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.g_analiz_klient.Size = New System.Drawing.Size(517, 233)
        Me.g_analiz_klient.TabIndex = 0
        '
        'date_napr
        '
        Me.date_napr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.date_napr.DataPropertyName = "date_napr"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.date_napr.DefaultCellStyle = DataGridViewCellStyle2
        Me.date_napr.HeaderText = "Дата направления"
        Me.date_napr.Name = "date_napr"
        Me.date_napr.ReadOnly = True
        Me.date_napr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.date_napr.Width = 97
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'nom_napr
        '
        Me.nom_napr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.nom_napr.DataPropertyName = "nom_napr"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.nom_napr.DefaultCellStyle = DataGridViewCellStyle3
        Me.nom_napr.HeaderText = "№ направления"
        Me.nom_napr.Name = "nom_napr"
        Me.nom_napr.ReadOnly = True
        Me.nom_napr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.nom_napr.Width = 84
        '
        'date_akt
        '
        Me.date_akt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.date_akt.DataPropertyName = "date_akt"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.date_akt.DefaultCellStyle = DataGridViewCellStyle4
        Me.date_akt.HeaderText = "Дата акта"
        Me.date_akt.Name = "date_akt"
        Me.date_akt.ReadOnly = True
        Me.date_akt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.date_akt.Width = 59
        '
        'nom_akt
        '
        Me.nom_akt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.nom_akt.DataPropertyName = "nom_akt"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.nom_akt.DefaultCellStyle = DataGridViewCellStyle5
        Me.nom_akt.HeaderText = "№ акта"
        Me.nom_akt.Name = "nom_akt"
        Me.nom_akt.ReadOnly = True
        Me.nom_akt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.nom_akt.Width = 45
        '
        'total_price
        '
        Me.total_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.total_price.DataPropertyName = "total_price"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.total_price.DefaultCellStyle = DataGridViewCellStyle6
        Me.total_price.HeaderText = "Сумма"
        Me.total_price.Name = "total_price"
        Me.total_price.ReadOnly = True
        Me.total_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_price.Width = 47
        '
        'btn_add_analiz_klient
        '
        Me.btn_add_analiz_klient.Location = New System.Drawing.Point(5, 271)
        Me.btn_add_analiz_klient.Name = "btn_add_analiz_klient"
        Me.btn_add_analiz_klient.Size = New System.Drawing.Size(75, 23)
        Me.btn_add_analiz_klient.TabIndex = 1
        Me.btn_add_analiz_klient.Text = "Новый"
        Me.btn_add_analiz_klient.UseVisualStyleBackColor = True
        '
        'btn_del_analiz
        '
        Me.btn_del_analiz.Location = New System.Drawing.Point(188, 271)
        Me.btn_del_analiz.Name = "btn_del_analiz"
        Me.btn_del_analiz.Size = New System.Drawing.Size(75, 23)
        Me.btn_del_analiz.TabIndex = 2
        Me.btn_del_analiz.Text = "Удалить"
        Me.btn_del_analiz.UseVisualStyleBackColor = True
        '
        'btn_print_analiz
        '
        Me.btn_print_analiz.Location = New System.Drawing.Point(95, 271)
        Me.btn_print_analiz.Name = "btn_print_analiz"
        Me.btn_print_analiz.Size = New System.Drawing.Size(75, 23)
        Me.btn_print_analiz.TabIndex = 3
        Me.btn_print_analiz.Text = "Печать"
        Me.btn_print_analiz.UseVisualStyleBackColor = True
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(445, 271)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 23)
        Me.btn_Close.TabIndex = 4
        Me.btn_Close.Text = "Выход"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'lbl_klient
        '
        Me.lbl_klient.AutoSize = True
        Me.lbl_klient.Location = New System.Drawing.Point(8, 6)
        Me.lbl_klient.Name = "lbl_klient"
        Me.lbl_klient.Size = New System.Drawing.Size(39, 13)
        Me.lbl_klient.TabIndex = 5
        Me.lbl_klient.Text = "Label1"
        '
        'FAnalizKlient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 306)
        Me.Controls.Add(Me.lbl_klient)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.btn_print_analiz)
        Me.Controls.Add(Me.btn_del_analiz)
        Me.Controls.Add(Me.btn_add_analiz_klient)
        Me.Controls.Add(Me.g_analiz_klient)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FAnalizKlient"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Анализы"
        CType(Me.g_analiz_klient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents g_analiz_klient As System.Windows.Forms.DataGridView
    Friend WithEvents btn_add_analiz_klient As System.Windows.Forms.Button
    Friend WithEvents btn_del_analiz As System.Windows.Forms.Button
    Friend WithEvents btn_print_analiz As System.Windows.Forms.Button
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents lbl_klient As System.Windows.Forms.Label
    Friend WithEvents date_napr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom_napr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_akt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom_akt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_price As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
