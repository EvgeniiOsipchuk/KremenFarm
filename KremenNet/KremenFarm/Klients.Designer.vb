<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FKlients
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FKlients))
        Me.Pnl_buttons = New System.Windows.Forms.Panel()
        Me.gbMain = New System.Windows.Forms.GroupBox()
        Me.Btn_UvolKlient = New System.Windows.Forms.Button()
        Me.Btn_UpdKlient = New System.Windows.Forms.Button()
        Me.btn_AddKlient = New System.Windows.Forms.Button()
        Me.gb_add = New System.Windows.Forms.GroupBox()
        Me.Btn_Spis = New System.Windows.Forms.Button()
        Me.btn_Analiz = New System.Windows.Forms.Button()
        Me.btn_Strax = New System.Windows.Forms.Button()
        Me.btn_find = New System.Windows.Forms.Button()
        Me.edt_find = New System.Windows.Forms.TextBox()
        Me.cb_find = New System.Windows.Forms.ComboBox()
        Me.Pnl_bottom = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.st_label = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_label_fakt = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_Adress = New System.Windows.Forms.Label()
        Me.lbl_Ceh = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_find = New System.Windows.Forms.Label()
        Me.g_klients = New System.Windows.Forms.DataGridView()
        Me.inn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.naslrogd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nasladr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nasled = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.schet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kemvidan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nazvan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dogovor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_birth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ceh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paspser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paspnom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nachislen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vidano = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.limit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.god_strax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_dog_begin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rab = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pnl_buttons.SuspendLayout()
        Me.gbMain.SuspendLayout()
        Me.gb_add.SuspendLayout()
        Me.Pnl_bottom.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.g_klients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pnl_buttons
        '
        Me.Pnl_buttons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_buttons.Controls.Add(Me.gbMain)
        Me.Pnl_buttons.Controls.Add(Me.gb_add)
        Me.Pnl_buttons.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_buttons.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_buttons.Name = "Pnl_buttons"
        Me.Pnl_buttons.Size = New System.Drawing.Size(821, 44)
        Me.Pnl_buttons.TabIndex = 5
        '
        'gbMain
        '
        Me.gbMain.Controls.Add(Me.Btn_UvolKlient)
        Me.gbMain.Controls.Add(Me.Btn_UpdKlient)
        Me.gbMain.Controls.Add(Me.btn_AddKlient)
        Me.gbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbMain.Location = New System.Drawing.Point(542, 0)
        Me.gbMain.Name = "gbMain"
        Me.gbMain.Size = New System.Drawing.Size(277, 42)
        Me.gbMain.TabIndex = 14
        Me.gbMain.TabStop = False
        '
        'Btn_UvolKlient
        '
        Me.Btn_UvolKlient.Location = New System.Drawing.Point(192, 13)
        Me.Btn_UvolKlient.Name = "Btn_UvolKlient"
        Me.Btn_UvolKlient.Size = New System.Drawing.Size(77, 22)
        Me.Btn_UvolKlient.TabIndex = 15
        Me.Btn_UvolKlient.Text = "Уволить"
        Me.Btn_UvolKlient.UseVisualStyleBackColor = True
        '
        'Btn_UpdKlient
        '
        Me.Btn_UpdKlient.Location = New System.Drawing.Point(89, 13)
        Me.Btn_UpdKlient.Name = "Btn_UpdKlient"
        Me.Btn_UpdKlient.Size = New System.Drawing.Size(97, 22)
        Me.Btn_UpdKlient.TabIndex = 14
        Me.Btn_UpdKlient.Text = "Редактировать"
        Me.Btn_UpdKlient.UseVisualStyleBackColor = True
        '
        'btn_AddKlient
        '
        Me.btn_AddKlient.Location = New System.Drawing.Point(6, 13)
        Me.btn_AddKlient.Name = "btn_AddKlient"
        Me.btn_AddKlient.Size = New System.Drawing.Size(77, 22)
        Me.btn_AddKlient.TabIndex = 13
        Me.btn_AddKlient.Text = "Новый"
        Me.btn_AddKlient.UseVisualStyleBackColor = True
        '
        'gb_add
        '
        Me.gb_add.Controls.Add(Me.Btn_Spis)
        Me.gb_add.Controls.Add(Me.btn_Analiz)
        Me.gb_add.Controls.Add(Me.btn_Strax)
        Me.gb_add.Controls.Add(Me.btn_find)
        Me.gb_add.Controls.Add(Me.edt_find)
        Me.gb_add.Controls.Add(Me.cb_find)
        Me.gb_add.Dock = System.Windows.Forms.DockStyle.Left
        Me.gb_add.Location = New System.Drawing.Point(0, 0)
        Me.gb_add.Name = "gb_add"
        Me.gb_add.Size = New System.Drawing.Size(542, 42)
        Me.gb_add.TabIndex = 13
        Me.gb_add.TabStop = False
        '
        'Btn_Spis
        '
        Me.Btn_Spis.Location = New System.Drawing.Point(463, 13)
        Me.Btn_Spis.Name = "Btn_Spis"
        Me.Btn_Spis.Size = New System.Drawing.Size(73, 22)
        Me.Btn_Spis.TabIndex = 11
        Me.Btn_Spis.Text = "Списки"
        Me.Btn_Spis.UseVisualStyleBackColor = True
        '
        'btn_Analiz
        '
        Me.btn_Analiz.Location = New System.Drawing.Point(380, 13)
        Me.btn_Analiz.Name = "btn_Analiz"
        Me.btn_Analiz.Size = New System.Drawing.Size(77, 22)
        Me.btn_Analiz.TabIndex = 9
        Me.btn_Analiz.Text = "Анализы"
        Me.btn_Analiz.UseVisualStyleBackColor = True
        '
        'btn_Strax
        '
        Me.btn_Strax.Location = New System.Drawing.Point(297, 13)
        Me.btn_Strax.Name = "btn_Strax"
        Me.btn_Strax.Size = New System.Drawing.Size(77, 22)
        Me.btn_Strax.TabIndex = 7
        Me.btn_Strax.Text = "Страховки"
        Me.btn_Strax.UseVisualStyleBackColor = True
        '
        'btn_find
        '
        Me.btn_find.Location = New System.Drawing.Point(225, 13)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(66, 22)
        Me.btn_find.TabIndex = 6
        Me.btn_find.Text = "Искать"
        Me.btn_find.UseVisualStyleBackColor = True
        '
        'edt_find
        '
        Me.edt_find.Location = New System.Drawing.Point(83, 14)
        Me.edt_find.Name = "edt_find"
        Me.edt_find.Size = New System.Drawing.Size(134, 20)
        Me.edt_find.TabIndex = 0
        '
        'cb_find
        '
        Me.cb_find.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_find.FormattingEnabled = True
        Me.cb_find.Items.AddRange(New Object() {"ФИО ", "Таб. №  "})
        Me.cb_find.Location = New System.Drawing.Point(8, 13)
        Me.cb_find.Name = "cb_find"
        Me.cb_find.Size = New System.Drawing.Size(69, 21)
        Me.cb_find.TabIndex = 2
        '
        'Pnl_bottom
        '
        Me.Pnl_bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_bottom.Controls.Add(Me.StatusStrip1)
        Me.Pnl_bottom.Controls.Add(Me.Label1)
        Me.Pnl_bottom.Controls.Add(Me.lbl_id)
        Me.Pnl_bottom.Controls.Add(Me.lbl_Adress)
        Me.Pnl_bottom.Controls.Add(Me.lbl_Ceh)
        Me.Pnl_bottom.Controls.Add(Me.Label3)
        Me.Pnl_bottom.Controls.Add(Me.Label2)
        Me.Pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pnl_bottom.Location = New System.Drawing.Point(0, 424)
        Me.Pnl_bottom.Name = "Pnl_bottom"
        Me.Pnl_bottom.Size = New System.Drawing.Size(821, 69)
        Me.Pnl_bottom.TabIndex = 6
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_label, Me.st_label_fakt})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 45)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(819, 22)
        Me.StatusStrip1.TabIndex = 34
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'st_label
        '
        Me.st_label.Name = "st_label"
        Me.st_label.Size = New System.Drawing.Size(216, 17)
        Me.st_label.Text = "Фактический остаток средств клиента"
        '
        'st_label_fakt
        '
        Me.st_label_fakt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.st_label_fakt.ForeColor = System.Drawing.Color.Red
        Me.st_label_fakt.Name = "st_label_fakt"
        Me.st_label_fakt.Size = New System.Drawing.Size(129, 17)
        Me.st_label_fakt.Text = "ToolStripStatusLabel2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Системный номер клиента"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_id.ForeColor = System.Drawing.Color.Black
        Me.lbl_id.Location = New System.Drawing.Point(155, 74)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(28, 13)
        Me.lbl_id.TabIndex = 5
        Me.lbl_id.Text = "hhh"
        Me.lbl_id.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lbl_Adress
        '
        Me.lbl_Adress.AutoSize = True
        Me.lbl_Adress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_Adress.Location = New System.Drawing.Point(48, 25)
        Me.lbl_Adress.Name = "lbl_Adress"
        Me.lbl_Adress.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Adress.TabIndex = 4
        Me.lbl_Adress.Text = "Адрес"
        '
        'lbl_Ceh
        '
        Me.lbl_Ceh.AutoSize = True
        Me.lbl_Ceh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_Ceh.Location = New System.Drawing.Point(47, 6)
        Me.lbl_Ceh.Name = "lbl_Ceh"
        Me.lbl_Ceh.Size = New System.Drawing.Size(50, 13)
        Me.lbl_Ceh.TabIndex = 3
        Me.lbl_Ceh.Text = "№ цеха"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Адрес"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "№ цеха"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_find)
        Me.Panel1.Controls.Add(Me.g_klients)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(821, 380)
        Me.Panel1.TabIndex = 7
        '
        'lbl_find
        '
        Me.lbl_find.AutoSize = True
        Me.lbl_find.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_find.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_find.ForeColor = System.Drawing.Color.Brown
        Me.lbl_find.Location = New System.Drawing.Point(205, 162)
        Me.lbl_find.Name = "lbl_find"
        Me.lbl_find.Size = New System.Drawing.Size(412, 55)
        Me.lbl_find.TabIndex = 2
        Me.lbl_find.Text = "Нет информации"
        Me.lbl_find.Visible = False
        '
        'g_klients
        '
        Me.g_klients.AllowUserToAddRows = False
        Me.g_klients.AllowUserToDeleteRows = False
        Me.g_klients.AllowUserToResizeRows = False
        Me.g_klients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.g_klients.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.g_klients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.g_klients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.inn, Me.naslrogd, Me.nasladr, Me.nasled, Me.schet, Me.address, Me.kemvidan, Me.nazvan, Me.dogovor, Me.date_birth, Me.ceh, Me.paspser, Me.tabnum, Me.paspnom, Me.id, Me.FIO, Me.nachislen, Me.vidano, Me.limit, Me.god_strax, Me.date_dog_begin, Me.comment, Me.rab})
        Me.g_klients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_klients.Location = New System.Drawing.Point(0, 0)
        Me.g_klients.MultiSelect = False
        Me.g_klients.Name = "g_klients"
        Me.g_klients.ReadOnly = True
        Me.g_klients.RowHeadersVisible = False
        Me.g_klients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.g_klients.ShowEditingIcon = False
        Me.g_klients.Size = New System.Drawing.Size(821, 380)
        Me.g_klients.TabIndex = 1
        '
        'inn
        '
        Me.inn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.inn.DataPropertyName = "inn"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.inn.DefaultCellStyle = DataGridViewCellStyle2
        Me.inn.HeaderText = "ИНН"
        Me.inn.Name = "inn"
        Me.inn.ReadOnly = True
        Me.inn.Width = 56
        '
        'naslrogd
        '
        Me.naslrogd.DataPropertyName = "naslrogd"
        Me.naslrogd.HeaderText = "naslrogd"
        Me.naslrogd.Name = "naslrogd"
        Me.naslrogd.ReadOnly = True
        Me.naslrogd.Visible = False
        Me.naslrogd.Width = 72
        '
        'nasladr
        '
        Me.nasladr.DataPropertyName = "nasladr"
        Me.nasladr.HeaderText = "nasladr"
        Me.nasladr.Name = "nasladr"
        Me.nasladr.ReadOnly = True
        Me.nasladr.Visible = False
        Me.nasladr.Width = 66
        '
        'nasled
        '
        Me.nasled.DataPropertyName = "nasled"
        Me.nasled.HeaderText = "nasled"
        Me.nasled.Name = "nasled"
        Me.nasled.ReadOnly = True
        Me.nasled.Visible = False
        Me.nasled.Width = 63
        '
        'schet
        '
        Me.schet.DataPropertyName = "schet"
        Me.schet.HeaderText = "schet"
        Me.schet.Name = "schet"
        Me.schet.ReadOnly = True
        Me.schet.Visible = False
        Me.schet.Width = 58
        '
        'address
        '
        Me.address.DataPropertyName = "address"
        Me.address.HeaderText = "address"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        Me.address.Visible = False
        Me.address.Width = 69
        '
        'kemvidan
        '
        Me.kemvidan.DataPropertyName = "kemvidan"
        Me.kemvidan.HeaderText = "kemvidan"
        Me.kemvidan.Name = "kemvidan"
        Me.kemvidan.ReadOnly = True
        Me.kemvidan.Visible = False
        Me.kemvidan.Width = 78
        '
        'nazvan
        '
        Me.nazvan.DataPropertyName = "nazvan"
        Me.nazvan.HeaderText = "nazvan"
        Me.nazvan.Name = "nazvan"
        Me.nazvan.ReadOnly = True
        Me.nazvan.Visible = False
        Me.nazvan.Width = 67
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
        'date_birth
        '
        Me.date_birth.DataPropertyName = "date_birth"
        Me.date_birth.HeaderText = "date_birth"
        Me.date_birth.Name = "date_birth"
        Me.date_birth.ReadOnly = True
        Me.date_birth.Visible = False
        Me.date_birth.Width = 79
        '
        'ceh
        '
        Me.ceh.DataPropertyName = "ceh"
        Me.ceh.HeaderText = "ceh"
        Me.ceh.Name = "ceh"
        Me.ceh.ReadOnly = True
        Me.ceh.Visible = False
        Me.ceh.Width = 50
        '
        'paspser
        '
        Me.paspser.DataPropertyName = "paspser"
        Me.paspser.HeaderText = "paspser"
        Me.paspser.Name = "paspser"
        Me.paspser.ReadOnly = True
        Me.paspser.Visible = False
        Me.paspser.Width = 69
        '
        'tabnum
        '
        Me.tabnum.DataPropertyName = "tabnum"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.tabnum.DefaultCellStyle = DataGridViewCellStyle3
        Me.tabnum.HeaderText = "Таб №"
        Me.tabnum.Name = "tabnum"
        Me.tabnum.ReadOnly = True
        Me.tabnum.Width = 51
        '
        'paspnom
        '
        Me.paspnom.DataPropertyName = "paspnom"
        Me.paspnom.HeaderText = "paspnom"
        Me.paspnom.Name = "paspnom"
        Me.paspnom.ReadOnly = True
        Me.paspnom.Visible = False
        Me.paspnom.Width = 75
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
        'FIO
        '
        Me.FIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FIO.DataPropertyName = "fio"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.FIO.DefaultCellStyle = DataGridViewCellStyle4
        Me.FIO.HeaderText = "ФИО"
        Me.FIO.Name = "FIO"
        Me.FIO.ReadOnly = True
        '
        'nachislen
        '
        Me.nachislen.DataPropertyName = "nachislen"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.nachislen.DefaultCellStyle = DataGridViewCellStyle5
        Me.nachislen.HeaderText = "Начисленно от завода"
        Me.nachislen.Name = "nachislen"
        Me.nachislen.ReadOnly = True
        Me.nachislen.Width = 101
        '
        'vidano
        '
        Me.vidano.DataPropertyName = "vidano"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.vidano.DefaultCellStyle = DataGridViewCellStyle6
        Me.vidano.HeaderText = "Выдано"
        Me.vidano.Name = "vidano"
        Me.vidano.ReadOnly = True
        Me.vidano.Width = 71
        '
        'limit
        '
        Me.limit.DataPropertyName = "limit"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.limit.DefaultCellStyle = DataGridViewCellStyle7
        Me.limit.HeaderText = "Остаток"
        Me.limit.Name = "limit"
        Me.limit.ReadOnly = True
        Me.limit.Width = 74
        '
        'god_strax
        '
        Me.god_strax.DataPropertyName = "god_strax"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.god_strax.DefaultCellStyle = DataGridViewCellStyle8
        Me.god_strax.HeaderText = "Год"
        Me.god_strax.Name = "god_strax"
        Me.god_strax.ReadOnly = True
        Me.god_strax.Width = 50
        '
        'date_dog_begin
        '
        Me.date_dog_begin.DataPropertyName = "date_dog_begin"
        Me.date_dog_begin.HeaderText = "date_dog_begin"
        Me.date_dog_begin.Name = "date_dog_begin"
        Me.date_dog_begin.ReadOnly = True
        Me.date_dog_begin.Visible = False
        Me.date_dog_begin.Width = 109
        '
        'comment
        '
        Me.comment.DataPropertyName = "comment"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.comment.DefaultCellStyle = DataGridViewCellStyle9
        Me.comment.HeaderText = "Статус"
        Me.comment.Name = "comment"
        Me.comment.ReadOnly = True
        Me.comment.Width = 66
        '
        'rab
        '
        Me.rab.DataPropertyName = "rab"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.rab.DefaultCellStyle = DataGridViewCellStyle10
        Me.rab.HeaderText = "Предпр"
        Me.rab.Name = "rab"
        Me.rab.ReadOnly = True
        Me.rab.Width = 70
        '
        'FKlients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 493)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Pnl_bottom)
        Me.Controls.Add(Me.Pnl_buttons)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FKlients"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Клиенты"
        Me.Pnl_buttons.ResumeLayout(False)
        Me.gbMain.ResumeLayout(False)
        Me.gb_add.ResumeLayout(False)
        Me.gb_add.PerformLayout()
        Me.Pnl_bottom.ResumeLayout(False)
        Me.Pnl_bottom.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.g_klients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pnl_buttons As System.Windows.Forms.Panel
    Friend WithEvents Pnl_bottom As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gb_add As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Spis As System.Windows.Forms.Button
    Friend WithEvents btn_Analiz As System.Windows.Forms.Button
    Friend WithEvents btn_Strax As System.Windows.Forms.Button
    Friend WithEvents btn_find As System.Windows.Forms.Button
    Friend WithEvents edt_find As System.Windows.Forms.TextBox
    Friend WithEvents cb_find As System.Windows.Forms.ComboBox
    Friend WithEvents gbMain As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_UvolKlient As System.Windows.Forms.Button
    Friend WithEvents Btn_UpdKlient As System.Windows.Forms.Button
    Friend WithEvents btn_AddKlient As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents g_klients As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_Adress As System.Windows.Forms.Label
    Friend WithEvents lbl_Ceh As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents st_label As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_label_fakt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_find As System.Windows.Forms.Label
    Friend WithEvents inn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents naslrogd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nasladr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nasled As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents schet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kemvidan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nazvan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dogovor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_birth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ceh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents paspser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tabnum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents paspnom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nachislen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vidano As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents limit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents god_strax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_dog_begin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rab As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
