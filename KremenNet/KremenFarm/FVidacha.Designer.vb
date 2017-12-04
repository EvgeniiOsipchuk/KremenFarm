<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FVidacha
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FVidacha))
        Me.gb_find = New System.Windows.Forms.GroupBox()
        Me.btn_AddMed = New System.Windows.Forms.Button()
        Me.g_med = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apteka_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolvo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.upak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnt_MenuMed = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mi_add = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mi_delit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_separate = New System.Windows.Forms.Button()
        Me.edt_medfind = New System.Windows.Forms.TextBox()
        Me.gb_select = New System.Windows.Forms.GroupBox()
        Me.lbl_itogo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_RemoveMed = New System.Windows.Forms.Button()
        Me.g_select = New System.Windows.Forms.DataGridView()
        Me.selid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sel_apteka_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.auto_inc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selkod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selmedname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selkolvo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selupak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cnt_MenuSelect = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mi_Remove = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.st_info_lim = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_limit = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_total_price = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_food_price = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_vidach = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gb_find.SuspendLayout()
        CType(Me.g_med, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cnt_MenuMed.SuspendLayout()
        Me.gb_select.SuspendLayout()
        CType(Me.g_select, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cnt_MenuSelect.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_find
        '
        Me.gb_find.Controls.Add(Me.btn_AddMed)
        Me.gb_find.Controls.Add(Me.g_med)
        Me.gb_find.Controls.Add(Me.btn_separate)
        Me.gb_find.Controls.Add(Me.edt_medfind)
        Me.gb_find.Location = New System.Drawing.Point(6, 5)
        Me.gb_find.Name = "gb_find"
        Me.gb_find.Size = New System.Drawing.Size(581, 224)
        Me.gb_find.TabIndex = 0
        Me.gb_find.TabStop = False
        Me.gb_find.Text = "Выбор продукта"
        '
        'btn_AddMed
        '
        Me.btn_AddMed.Location = New System.Drawing.Point(176, 15)
        Me.btn_AddMed.Name = "btn_AddMed"
        Me.btn_AddMed.Size = New System.Drawing.Size(75, 23)
        Me.btn_AddMed.TabIndex = 4
        Me.btn_AddMed.Text = "Добавить"
        Me.btn_AddMed.UseVisualStyleBackColor = True
        '
        'g_med
        '
        Me.g_med.AllowUserToAddRows = False
        Me.g_med.AllowUserToDeleteRows = False
        Me.g_med.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.g_med.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.g_med.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.g_med.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.apteka_name, Me.kod, Me.medname, Me.kolvo, Me.price, Me.upak})
        Me.g_med.ContextMenuStrip = Me.cnt_MenuMed
        Me.g_med.Location = New System.Drawing.Point(11, 43)
        Me.g_med.MultiSelect = False
        Me.g_med.Name = "g_med"
        Me.g_med.ReadOnly = True
        Me.g_med.RowHeadersVisible = False
        Me.g_med.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.g_med.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.g_med.Size = New System.Drawing.Size(560, 177)
        Me.g_med.TabIndex = 3
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
        'apteka_name
        '
        Me.apteka_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.apteka_name.DataPropertyName = "apteka_name"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.apteka_name.DefaultCellStyle = DataGridViewCellStyle2
        Me.apteka_name.HeaderText = "Аптека"
        Me.apteka_name.Name = "apteka_name"
        Me.apteka_name.ReadOnly = True
        Me.apteka_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.apteka_name.Width = 49
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
        'cnt_MenuMed
        '
        Me.cnt_MenuMed.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mi_add, Me.ToolStripMenuItem1, Me.mi_delit})
        Me.cnt_MenuMed.Name = "cnt_MenuMed"
        Me.cnt_MenuMed.Size = New System.Drawing.Size(127, 54)
        '
        'mi_add
        '
        Me.mi_add.Name = "mi_add"
        Me.mi_add.Size = New System.Drawing.Size(126, 22)
        Me.mi_add.Text = "Добавить"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(123, 6)
        '
        'mi_delit
        '
        Me.mi_delit.Name = "mi_delit"
        Me.mi_delit.Size = New System.Drawing.Size(126, 22)
        Me.mi_delit.Text = "Делить"
        '
        'btn_separate
        '
        Me.btn_separate.Location = New System.Drawing.Point(257, 15)
        Me.btn_separate.Name = "btn_separate"
        Me.btn_separate.Size = New System.Drawing.Size(75, 23)
        Me.btn_separate.TabIndex = 1
        Me.btn_separate.Text = "Делить"
        Me.btn_separate.UseVisualStyleBackColor = True
        '
        'edt_medfind
        '
        Me.edt_medfind.Location = New System.Drawing.Point(11, 18)
        Me.edt_medfind.Name = "edt_medfind"
        Me.edt_medfind.Size = New System.Drawing.Size(153, 20)
        Me.edt_medfind.TabIndex = 0
        '
        'gb_select
        '
        Me.gb_select.Controls.Add(Me.lbl_itogo)
        Me.gb_select.Controls.Add(Me.Label1)
        Me.gb_select.Controls.Add(Me.btn_RemoveMed)
        Me.gb_select.Controls.Add(Me.g_select)
        Me.gb_select.Controls.Add(Me.btn_close)
        Me.gb_select.Controls.Add(Me.btn_save)
        Me.gb_select.Location = New System.Drawing.Point(6, 226)
        Me.gb_select.Name = "gb_select"
        Me.gb_select.Size = New System.Drawing.Size(581, 255)
        Me.gb_select.TabIndex = 1
        Me.gb_select.TabStop = False
        Me.gb_select.Text = "Выбранные медикаменты"
        '
        'lbl_itogo
        '
        Me.lbl_itogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_itogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_itogo.Location = New System.Drawing.Point(484, 195)
        Me.lbl_itogo.Name = "lbl_itogo"
        Me.lbl_itogo.Size = New System.Drawing.Size(88, 23)
        Me.lbl_itogo.TabIndex = 10
        Me.lbl_itogo.Text = "0"
        Me.lbl_itogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(473, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Итого:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_RemoveMed
        '
        Me.btn_RemoveMed.Location = New System.Drawing.Point(12, 225)
        Me.btn_RemoveMed.Name = "btn_RemoveMed"
        Me.btn_RemoveMed.Size = New System.Drawing.Size(75, 23)
        Me.btn_RemoveMed.TabIndex = 7
        Me.btn_RemoveMed.Text = "Удалить"
        Me.btn_RemoveMed.UseVisualStyleBackColor = True
        '
        'g_select
        '
        Me.g_select.AllowUserToAddRows = False
        Me.g_select.AllowUserToDeleteRows = False
        Me.g_select.AllowUserToResizeRows = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.g_select.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.g_select.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.g_select.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.selid, Me.sel_apteka_name, Me.auto_inc, Me.selkod, Me.selmedname, Me.selkolvo, Me.selprice, Me.selupak})
        Me.g_select.ContextMenuStrip = Me.cnt_MenuSelect
        Me.g_select.Location = New System.Drawing.Point(12, 19)
        Me.g_select.MultiSelect = False
        Me.g_select.Name = "g_select"
        Me.g_select.ReadOnly = True
        Me.g_select.RowHeadersVisible = False
        Me.g_select.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.g_select.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.g_select.Size = New System.Drawing.Size(560, 177)
        Me.g_select.TabIndex = 4
        '
        'selid
        '
        Me.selid.DataPropertyName = "id"
        Me.selid.HeaderText = "id"
        Me.selid.Name = "selid"
        Me.selid.ReadOnly = True
        Me.selid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.selid.Visible = False
        '
        'sel_apteka_name
        '
        Me.sel_apteka_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.sel_apteka_name.DataPropertyName = "apteka_name"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.sel_apteka_name.DefaultCellStyle = DataGridViewCellStyle9
        Me.sel_apteka_name.HeaderText = "Аптека"
        Me.sel_apteka_name.Name = "sel_apteka_name"
        Me.sel_apteka_name.ReadOnly = True
        Me.sel_apteka_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.sel_apteka_name.Width = 49
        '
        'auto_inc
        '
        Me.auto_inc.DataPropertyName = "auto_inc"
        Me.auto_inc.HeaderText = "auto_inc"
        Me.auto_inc.Name = "auto_inc"
        Me.auto_inc.ReadOnly = True
        Me.auto_inc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.auto_inc.Visible = False
        '
        'selkod
        '
        Me.selkod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.selkod.DataPropertyName = "kod"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.selkod.DefaultCellStyle = DataGridViewCellStyle10
        Me.selkod.HeaderText = "Код"
        Me.selkod.Name = "selkod"
        Me.selkod.ReadOnly = True
        Me.selkod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.selkod.Width = 32
        '
        'selmedname
        '
        Me.selmedname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.selmedname.DataPropertyName = "medname"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.selmedname.DefaultCellStyle = DataGridViewCellStyle11
        Me.selmedname.HeaderText = "Наименование"
        Me.selmedname.Name = "selmedname"
        Me.selmedname.ReadOnly = True
        Me.selmedname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'selkolvo
        '
        Me.selkolvo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.selkolvo.DataPropertyName = "kolvo"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.selkolvo.DefaultCellStyle = DataGridViewCellStyle12
        Me.selkolvo.HeaderText = "Кол-во"
        Me.selkolvo.Name = "selkolvo"
        Me.selkolvo.ReadOnly = True
        Me.selkolvo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.selkolvo.Width = 47
        '
        'selprice
        '
        Me.selprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.selprice.DataPropertyName = "price"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.selprice.DefaultCellStyle = DataGridViewCellStyle13
        Me.selprice.HeaderText = "Цена"
        Me.selprice.Name = "selprice"
        Me.selprice.ReadOnly = True
        Me.selprice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.selprice.Width = 39
        '
        'selupak
        '
        Me.selupak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.selupak.DataPropertyName = "upak"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.selupak.DefaultCellStyle = DataGridViewCellStyle14
        Me.selupak.HeaderText = "Уп"
        Me.selupak.Name = "selupak"
        Me.selupak.ReadOnly = True
        Me.selupak.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.selupak.Width = 27
        '
        'cnt_MenuSelect
        '
        Me.cnt_MenuSelect.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mi_Remove, Me.ToolStripSeparator1})
        Me.cnt_MenuSelect.Name = "cnt_MenuMed"
        Me.cnt_MenuSelect.Size = New System.Drawing.Size(119, 32)
        '
        'mi_Remove
        '
        Me.mi_Remove.Name = "mi_Remove"
        Me.mi_Remove.Size = New System.Drawing.Size(118, 22)
        Me.mi_Remove.Text = "Удалить"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(115, 6)
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(492, 225)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 2
        Me.btn_close.Text = "Выход"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(104, 225)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 0
        Me.btn_save.Text = "Сохранить"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_info_lim, Me.st_limit, Me.ToolStripStatusLabel1, Me.st_total_price, Me.ToolStripStatusLabel2, Me.st_food_price, Me.ToolStripStatusLabel3, Me.st_vidach})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 483)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.ShowItemToolTips = True
        Me.StatusStrip1.Size = New System.Drawing.Size(593, 24)
        Me.StatusStrip1.TabIndex = 33
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'st_info_lim
        '
        Me.st_info_lim.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.st_info_lim.Name = "st_info_lim"
        Me.st_info_lim.Size = New System.Drawing.Size(88, 19)
        Me.st_info_lim.Text = "Лимит случая"
        '
        'st_limit
        '
        Me.st_limit.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.st_limit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.st_limit.Name = "st_limit"
        Me.st_limit.Size = New System.Drawing.Size(18, 19)
        Me.st_limit.Text = "0"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(54, 19)
        Me.ToolStripStatusLabel1.Text = "Выплата"
        '
        'st_total_price
        '
        Me.st_total_price.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.st_total_price.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.st_total_price.Name = "st_total_price"
        Me.st_total_price.Size = New System.Drawing.Size(18, 19)
        Me.st_total_price.Text = "0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(54, 19)
        Me.ToolStripStatusLabel2.Text = "Питание"
        '
        'st_food_price
        '
        Me.st_food_price.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.st_food_price.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.st_food_price.Name = "st_food_price"
        Me.st_food_price.Size = New System.Drawing.Size(18, 19)
        Me.st_food_price.Text = "0"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(132, 19)
        Me.ToolStripStatusLabel3.Text = "Выдано медикаментов"
        '
        'st_vidach
        '
        Me.st_vidach.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.st_vidach.Name = "st_vidach"
        Me.st_vidach.Size = New System.Drawing.Size(14, 19)
        Me.st_vidach.Text = "0"
        '
        'FVidacha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 507)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gb_select)
        Me.Controls.Add(Me.gb_find)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FVidacha"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Выдача медикаментов"
        Me.gb_find.ResumeLayout(False)
        Me.gb_find.PerformLayout()
        CType(Me.g_med, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cnt_MenuMed.ResumeLayout(False)
        Me.gb_select.ResumeLayout(False)
        CType(Me.g_select, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cnt_MenuSelect.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb_find As System.Windows.Forms.GroupBox
    Friend WithEvents gb_select As System.Windows.Forms.GroupBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_separate As System.Windows.Forms.Button
    Friend WithEvents edt_medfind As System.Windows.Forms.TextBox
    Friend WithEvents g_med As System.Windows.Forms.DataGridView
    Friend WithEvents g_select As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents st_info_lim As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_limit As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cnt_MenuMed As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mi_add As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mi_delit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cnt_MenuSelect As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mi_Remove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_total_price As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_food_price As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_vidach As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btn_AddMed As System.Windows.Forms.Button
    Friend WithEvents btn_RemoveMed As System.Windows.Forms.Button
    Friend WithEvents lbl_itogo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apteka_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents medname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kolvo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents upak As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents selid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sel_apteka_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents auto_inc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents selkod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents selmedname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents selkolvo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents selprice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents selupak As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
