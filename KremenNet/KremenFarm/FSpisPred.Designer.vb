<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSpisPred
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FSpisPred))
        Me.cb_pred = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_god_strax = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_print_all = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dt_end = New System.Windows.Forms.DateTimePicker()
        Me.dt_start = New System.Windows.Forms.DateTimePicker()
        Me.g_predpr = New System.Windows.Forms.DataGridView()
        Me.FIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dogovor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.summa_za = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.summa_tr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rb_strax = New System.Windows.Forms.RadioButton()
        Me.rb_all = New System.Windows.Forms.RadioButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.st_label = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_kol = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Btn_Uvol = New System.Windows.Forms.Button()
        Me.btn_Priem = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.gb_plat = New System.Windows.Forms.GroupBox()
        Me.btn_updDBF = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.edt_summa_tr = New System.Windows.Forms.TextBox()
        Me.edt_summa_za = New System.Windows.Forms.TextBox()
        Me.Btn_Plat = New System.Windows.Forms.Button()
        Me.btn_new_year = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.g_predpr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.gb_plat.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_pred
        '
        Me.cb_pred.DisplayMember = "predpr_name"
        Me.cb_pred.FormattingEnabled = True
        Me.cb_pred.Location = New System.Drawing.Point(6, 20)
        Me.cb_pred.Name = "cb_pred"
        Me.cb_pred.Size = New System.Drawing.Size(263, 21)
        Me.cb_pred.TabIndex = 0
        Me.cb_pred.ValueMember = "id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Предприятие"
        '
        'cb_god_strax
        '
        Me.cb_god_strax.DisplayMember = "god_strax"
        Me.cb_god_strax.FormattingEnabled = True
        Me.cb_god_strax.Location = New System.Drawing.Point(275, 20)
        Me.cb_god_strax.Name = "cb_god_strax"
        Me.cb_god_strax.Size = New System.Drawing.Size(88, 21)
        Me.cb_god_strax.TabIndex = 27
        Me.cb_god_strax.ValueMember = "god_strax"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(271, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Год страхования"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_print_all)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btn_print)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dt_end)
        Me.GroupBox1.Controls.Add(Me.dt_start)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(730, 44)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Печать"
        '
        'btn_print_all
        '
        Me.btn_print_all.Location = New System.Drawing.Point(578, 16)
        Me.btn_print_all.Name = "btn_print_all"
        Me.btn_print_all.Size = New System.Drawing.Size(146, 23)
        Me.btn_print_all.TabIndex = 30
        Me.btn_print_all.Text = "Формировать все"
        Me.btn_print_all.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "-"
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(339, 16)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(75, 23)
        Me.btn_print.TabIndex = 28
        Me.btn_print.Text = "Печать"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Страховой период"
        '
        'dt_end
        '
        Me.dt_end.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_end.Location = New System.Drawing.Point(227, 18)
        Me.dt_end.Name = "dt_end"
        Me.dt_end.Size = New System.Drawing.Size(96, 20)
        Me.dt_end.TabIndex = 16
        '
        'dt_start
        '
        Me.dt_start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_start.Location = New System.Drawing.Point(112, 18)
        Me.dt_start.Name = "dt_start"
        Me.dt_start.Size = New System.Drawing.Size(96, 20)
        Me.dt_start.TabIndex = 15
        '
        'g_predpr
        '
        Me.g_predpr.AllowUserToAddRows = False
        Me.g_predpr.AllowUserToDeleteRows = False
        Me.g_predpr.AllowUserToResizeRows = False
        Me.g_predpr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.g_predpr.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.g_predpr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.g_predpr.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FIO, Me.dogovor, Me.id, Me.inn, Me.tabnum, Me.comment, Me.summa_za, Me.summa_tr})
        Me.g_predpr.Location = New System.Drawing.Point(7, 94)
        Me.g_predpr.MultiSelect = False
        Me.g_predpr.Name = "g_predpr"
        Me.g_predpr.ReadOnly = True
        Me.g_predpr.RowHeadersVisible = False
        Me.g_predpr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.g_predpr.ShowEditingIcon = False
        Me.g_predpr.Size = New System.Drawing.Size(730, 281)
        Me.g_predpr.TabIndex = 29
        '
        'FIO
        '
        Me.FIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FIO.DataPropertyName = "fio"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.FIO.DefaultCellStyle = DataGridViewCellStyle2
        Me.FIO.HeaderText = "ФИО"
        Me.FIO.Name = "FIO"
        Me.FIO.ReadOnly = True
        Me.FIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dogovor
        '
        Me.dogovor.DataPropertyName = "dogovor"
        Me.dogovor.HeaderText = "dogovor"
        Me.dogovor.Name = "dogovor"
        Me.dogovor.ReadOnly = True
        Me.dogovor.Visible = False
        Me.dogovor.Width = 71
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        Me.id.Width = 40
        '
        'inn
        '
        Me.inn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.inn.DataPropertyName = "inn"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.inn.DefaultCellStyle = DataGridViewCellStyle3
        Me.inn.HeaderText = "ИНН"
        Me.inn.Name = "inn"
        Me.inn.ReadOnly = True
        Me.inn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.inn.Width = 37
        '
        'tabnum
        '
        Me.tabnum.DataPropertyName = "tabnum"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.tabnum.DefaultCellStyle = DataGridViewCellStyle4
        Me.tabnum.HeaderText = "Таб №"
        Me.tabnum.Name = "tabnum"
        Me.tabnum.ReadOnly = True
        Me.tabnum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.tabnum.Width = 46
        '
        'comment
        '
        Me.comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.comment.DataPropertyName = "comment"
        Me.comment.HeaderText = "Статус"
        Me.comment.Name = "comment"
        Me.comment.ReadOnly = True
        Me.comment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.comment.Width = 47
        '
        'summa_za
        '
        Me.summa_za.DataPropertyName = "summa_za"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.summa_za.DefaultCellStyle = DataGridViewCellStyle5
        Me.summa_za.HeaderText = "Сум Пр"
        Me.summa_za.Name = "summa_za"
        Me.summa_za.ReadOnly = True
        Me.summa_za.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.summa_za.Width = 50
        '
        'summa_tr
        '
        Me.summa_tr.DataPropertyName = "summa_tr"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.summa_tr.DefaultCellStyle = DataGridViewCellStyle6
        Me.summa_tr.HeaderText = "Сум Кл"
        Me.summa_tr.Name = "summa_tr"
        Me.summa_tr.ReadOnly = True
        Me.summa_tr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.summa_tr.Width = 49
        '
        'rb_strax
        '
        Me.rb_strax.AutoSize = True
        Me.rb_strax.Location = New System.Drawing.Point(369, 20)
        Me.rb_strax.Name = "rb_strax"
        Me.rb_strax.Size = New System.Drawing.Size(110, 17)
        Me.rb_strax.TabIndex = 30
        Me.rb_strax.TabStop = True
        Me.rb_strax.Text = "Застрахованные"
        Me.rb_strax.UseVisualStyleBackColor = True
        '
        'rb_all
        '
        Me.rb_all.AutoSize = True
        Me.rb_all.Location = New System.Drawing.Point(485, 20)
        Me.rb_all.Name = "rb_all"
        Me.rb_all.Size = New System.Drawing.Size(44, 17)
        Me.rb_all.TabIndex = 31
        Me.rb_all.TabStop = True
        Me.rb_all.Text = "Все"
        Me.rb_all.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_label, Me.st_kol})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 441)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 35
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'st_label
        '
        Me.st_label.Name = "st_label"
        Me.st_label.Size = New System.Drawing.Size(102, 17)
        Me.st_label.Text = "Найдено записей"
        '
        'st_kol
        '
        Me.st_kol.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.st_kol.ForeColor = System.Drawing.Color.Black
        Me.st_kol.Name = "st_kol"
        Me.st_kol.Size = New System.Drawing.Size(129, 17)
        Me.st_kol.Text = "ToolStripStatusLabel2"
        '
        'Btn_Uvol
        '
        Me.Btn_Uvol.Location = New System.Drawing.Point(11, 400)
        Me.Btn_Uvol.Name = "Btn_Uvol"
        Me.Btn_Uvol.Size = New System.Drawing.Size(66, 23)
        Me.Btn_Uvol.TabIndex = 36
        Me.Btn_Uvol.Text = "Уволить"
        Me.Btn_Uvol.UseVisualStyleBackColor = True
        '
        'btn_Priem
        '
        Me.btn_Priem.Location = New System.Drawing.Point(83, 400)
        Me.btn_Priem.Name = "btn_Priem"
        Me.btn_Priem.Size = New System.Drawing.Size(89, 23)
        Me.btn_Priem.TabIndex = 37
        Me.btn_Priem.Text = "Восстановить"
        Me.btn_Priem.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.Location = New System.Drawing.Point(178, 400)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(67, 23)
        Me.btn_New.TabIndex = 38
        Me.btn_New.Text = "Новый"
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'gb_plat
        '
        Me.gb_plat.Controls.Add(Me.btn_new_year)
        Me.gb_plat.Controls.Add(Me.btn_updDBF)
        Me.gb_plat.Controls.Add(Me.Label5)
        Me.gb_plat.Controls.Add(Me.Label4)
        Me.gb_plat.Controls.Add(Me.edt_summa_tr)
        Me.gb_plat.Controls.Add(Me.edt_summa_za)
        Me.gb_plat.Controls.Add(Me.Btn_Plat)
        Me.gb_plat.Location = New System.Drawing.Point(256, 383)
        Me.gb_plat.Name = "gb_plat"
        Me.gb_plat.Size = New System.Drawing.Size(514, 52)
        Me.gb_plat.TabIndex = 40
        Me.gb_plat.TabStop = False
        Me.gb_plat.Text = "Платеж"
        '
        'btn_updDBF
        '
        Me.btn_updDBF.Location = New System.Drawing.Point(380, 18)
        Me.btn_updDBF.Name = "btn_updDBF"
        Me.btn_updDBF.Size = New System.Drawing.Size(120, 23)
        Me.btn_updDBF.TabIndex = 46
        Me.btn_updDBF.Text = "Обновить из DBF"
        Me.btn_updDBF.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(102, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Сум Кл"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Сум Пр"
        '
        'edt_summa_tr
        '
        Me.edt_summa_tr.Location = New System.Drawing.Point(147, 20)
        Me.edt_summa_tr.Name = "edt_summa_tr"
        Me.edt_summa_tr.Size = New System.Drawing.Size(39, 20)
        Me.edt_summa_tr.TabIndex = 43
        '
        'edt_summa_za
        '
        Me.edt_summa_za.Location = New System.Drawing.Point(54, 21)
        Me.edt_summa_za.Name = "edt_summa_za"
        Me.edt_summa_za.Size = New System.Drawing.Size(39, 20)
        Me.edt_summa_za.TabIndex = 42
        '
        'Btn_Plat
        '
        Me.Btn_Plat.Location = New System.Drawing.Point(203, 19)
        Me.Btn_Plat.Name = "Btn_Plat"
        Me.Btn_Plat.Size = New System.Drawing.Size(78, 23)
        Me.Btn_Plat.TabIndex = 41
        Me.Btn_Plat.Text = "Начислить"
        Me.Btn_Plat.UseVisualStyleBackColor = True
        '
        'btn_new_year
        '
        Me.btn_new_year.Location = New System.Drawing.Point(292, 19)
        Me.btn_new_year.Name = "btn_new_year"
        Me.btn_new_year.Size = New System.Drawing.Size(78, 23)
        Me.btn_new_year.TabIndex = 47
        Me.btn_new_year.Text = "В новый год"
        Me.btn_new_year.UseVisualStyleBackColor = True
        '
        'FSpisPred
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 463)
        Me.Controls.Add(Me.gb_plat)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.btn_Priem)
        Me.Controls.Add(Me.Btn_Uvol)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.rb_all)
        Me.Controls.Add(Me.rb_strax)
        Me.Controls.Add(Me.g_predpr)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cb_god_strax)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_pred)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FSpisPred"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Предприятия"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.g_predpr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.gb_plat.ResumeLayout(False)
        Me.gb_plat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cb_pred As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb_god_strax As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dt_end As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_start As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents g_predpr As System.Windows.Forms.DataGridView
    Friend WithEvents rb_strax As System.Windows.Forms.RadioButton
    Friend WithEvents rb_all As System.Windows.Forms.RadioButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents st_label As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_kol As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Btn_Uvol As System.Windows.Forms.Button
    Friend WithEvents btn_Priem As System.Windows.Forms.Button
    Friend WithEvents btn_New As System.Windows.Forms.Button
    Friend WithEvents gb_plat As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Plat As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents edt_summa_tr As System.Windows.Forms.TextBox
    Friend WithEvents edt_summa_za As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dogovor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tabnum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents summa_za As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents summa_tr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_print_all As System.Windows.Forms.Button
    Friend WithEvents btn_updDBF As System.Windows.Forms.Button
    Friend WithEvents btn_new_year As System.Windows.Forms.Button
End Class
