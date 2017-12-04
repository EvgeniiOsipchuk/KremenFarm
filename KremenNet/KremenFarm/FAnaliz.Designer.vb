<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAnaliz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FAnaliz))
        Me.g_diag = New System.Windows.Forms.DataGridView()
        Me.cb = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.analiz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb_bol = New System.Windows.Forms.ComboBox()
        Me.dt_napr = New System.Windows.Forms.DateTimePicker()
        Me.dt_akt = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.edt_num_napr = New System.Windows.Forms.TextBox()
        Me.edn_num_akt = New System.Windows.Forms.TextBox()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_count = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_Add_analiz = New System.Windows.Forms.Button()
        CType(Me.g_diag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'g_diag
        '
        Me.g_diag.AllowUserToAddRows = False
        Me.g_diag.AllowUserToDeleteRows = False
        Me.g_diag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.g_diag.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cb, Me.id, Me.analiz, Me.price})
        Me.g_diag.Location = New System.Drawing.Point(11, 85)
        Me.g_diag.Name = "g_diag"
        Me.g_diag.ReadOnly = True
        Me.g_diag.RowHeadersVisible = False
        Me.g_diag.Size = New System.Drawing.Size(424, 321)
        Me.g_diag.TabIndex = 0
        '
        'cb
        '
        Me.cb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cb.DataPropertyName = "cb"
        Me.cb.HeaderText = ""
        Me.cb.Name = "cb"
        Me.cb.ReadOnly = True
        Me.cb.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cb.Width = 5
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.id.Visible = False
        '
        'analiz
        '
        Me.analiz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.analiz.DataPropertyName = "analiz"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.analiz.DefaultCellStyle = DataGridViewCellStyle1
        Me.analiz.HeaderText = "Анализ"
        Me.analiz.Name = "analiz"
        Me.analiz.ReadOnly = True
        Me.analiz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'price
        '
        Me.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.price.DataPropertyName = "price"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.price.DefaultCellStyle = DataGridViewCellStyle2
        Me.price.HeaderText = "Цена"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        Me.price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.price.Width = 39
        '
        'cb_bol
        '
        Me.cb_bol.FormattingEnabled = True
        Me.cb_bol.Location = New System.Drawing.Point(115, 57)
        Me.cb_bol.Name = "cb_bol"
        Me.cb_bol.Size = New System.Drawing.Size(127, 21)
        Me.cb_bol.TabIndex = 2
        '
        'dt_napr
        '
        Me.dt_napr.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_napr.Location = New System.Drawing.Point(115, 8)
        Me.dt_napr.Name = "dt_napr"
        Me.dt_napr.Size = New System.Drawing.Size(127, 20)
        Me.dt_napr.TabIndex = 3
        '
        'dt_akt
        '
        Me.dt_akt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_akt.Location = New System.Drawing.Point(116, 33)
        Me.dt_akt.Name = "dt_akt"
        Me.dt_akt.Size = New System.Drawing.Size(126, 20)
        Me.dt_akt.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Дата направления"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Дата акта"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ЛПУ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(249, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "номер"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(249, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "номер"
        '
        'edt_num_napr
        '
        Me.edt_num_napr.Location = New System.Drawing.Point(294, 9)
        Me.edt_num_napr.Name = "edt_num_napr"
        Me.edt_num_napr.Size = New System.Drawing.Size(100, 20)
        Me.edt_num_napr.TabIndex = 10
        '
        'edn_num_akt
        '
        Me.edn_num_akt.Location = New System.Drawing.Point(294, 32)
        Me.edn_num_akt.Name = "edn_num_akt"
        Me.edn_num_akt.Size = New System.Drawing.Size(100, 20)
        Me.edn_num_akt.TabIndex = 11
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(180, 432)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.btn_Save.TabIndex = 12
        Me.btn_Save.Text = "Сохранить"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(360, 432)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 23)
        Me.btn_Close.TabIndex = 13
        Me.btn_Close.Text = "Выход"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'lbl_price
        '
        Me.lbl_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(345, 405)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(90, 18)
        Me.lbl_price.TabIndex = 14
        Me.lbl_price.Text = "Label6"
        Me.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_count
        '
        Me.lbl_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_count.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_count.Location = New System.Drawing.Point(88, 405)
        Me.lbl_count.Name = "lbl_count"
        Me.lbl_count.Size = New System.Drawing.Size(44, 18)
        Me.lbl_count.TabIndex = 15
        Me.lbl_count.Text = "Label6"
        Me.lbl_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 405)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 18)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Выбрано"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.Location = New System.Drawing.Point(131, 405)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(214, 18)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "На сумму"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Add_analiz
        '
        Me.btn_Add_analiz.Location = New System.Drawing.Point(11, 432)
        Me.btn_Add_analiz.Name = "btn_Add_analiz"
        Me.btn_Add_analiz.Size = New System.Drawing.Size(99, 23)
        Me.btn_Add_analiz.TabIndex = 18
        Me.btn_Add_analiz.Text = "Новый анализ"
        Me.btn_Add_analiz.UseVisualStyleBackColor = True
        '
        'FAnaliz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 465)
        Me.Controls.Add(Me.btn_Add_analiz)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_count)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.edn_num_akt)
        Me.Controls.Add(Me.edt_num_napr)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dt_akt)
        Me.Controls.Add(Me.dt_napr)
        Me.Controls.Add(Me.cb_bol)
        Me.Controls.Add(Me.g_diag)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FAnaliz"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Новый анализ"
        CType(Me.g_diag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents g_diag As System.Windows.Forms.DataGridView
    Friend WithEvents cb_bol As System.Windows.Forms.ComboBox
    Friend WithEvents dt_napr As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_akt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents edt_num_napr As System.Windows.Forms.TextBox
    Friend WithEvents edn_num_akt As System.Windows.Forms.TextBox
    Friend WithEvents btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents lbl_price As System.Windows.Forms.Label
    Friend WithEvents lbl_count As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_Add_analiz As System.Windows.Forms.Button
    Friend WithEvents cb As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents analiz As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
