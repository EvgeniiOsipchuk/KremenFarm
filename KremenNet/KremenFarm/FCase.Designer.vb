<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FCase))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.edt_diag = New System.Windows.Forms.TextBox()
        Me.btn_getdiag = New System.Windows.Forms.Button()
        Me.edt_diagname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.edt_diagtype = New System.Windows.Forms.TextBox()
        Me.rb_amb = New System.Windows.Forms.RadioButton()
        Me.rb_stac = New System.Windows.Forms.RadioButton()
        Me.rb_allstac = New System.Windows.Forms.RadioButton()
        Me.rb_netrud = New System.Windows.Forms.RadioButton()
        Me.rb_death = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_lech = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_lpu = New System.Windows.Forms.ComboBox()
        Me.cb_doctor = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.edt_sum = New System.Windows.Forms.TextBox()
        Me.lbl_sumfood = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cb_otdel = New System.Windows.Forms.ComboBox()
        Me.edt_sumfood = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.edt_numbol = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dt_bolstart = New System.Windows.Forms.DateTimePicker()
        Me.c_zakr = New System.Windows.Forms.CheckBox()
        Me.dt_bolend = New System.Windows.Forms.DateTimePicker()
        Me.gb_Vidacha = New System.Windows.Forms.GroupBox()
        Me.btn_delvidach = New System.Windows.Forms.Button()
        Me.btn_showvid = New System.Windows.Forms.Button()
        Me.lbl_msch = New System.Windows.Forms.Label()
        Me.lbl_ost = New System.Windows.Forms.Label()
        Me.lbl_vidano = New System.Windows.Forms.Label()
        Me.lbl_limit = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_printvidach = New System.Windows.Forms.Button()
        Me.btn_addVidach = New System.Windows.Forms.Button()
        Me.g_vidach = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_enter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.st_label = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_label_fakt = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gb_Vidacha.SuspendLayout()
        CType(Me.g_vidach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Код диагноза"
        '
        'edt_diag
        '
        Me.edt_diag.Location = New System.Drawing.Point(86, 8)
        Me.edt_diag.Name = "edt_diag"
        Me.edt_diag.Size = New System.Drawing.Size(56, 20)
        Me.edt_diag.TabIndex = 1
        '
        'btn_getdiag
        '
        Me.btn_getdiag.Location = New System.Drawing.Point(147, 6)
        Me.btn_getdiag.Name = "btn_getdiag"
        Me.btn_getdiag.Size = New System.Drawing.Size(32, 23)
        Me.btn_getdiag.TabIndex = 2
        Me.btn_getdiag.Text = "?"
        Me.btn_getdiag.UseVisualStyleBackColor = True
        '
        'edt_diagname
        '
        Me.edt_diagname.Enabled = False
        Me.edt_diagname.Location = New System.Drawing.Point(185, 8)
        Me.edt_diagname.Name = "edt_diagname"
        Me.edt_diagname.Size = New System.Drawing.Size(448, 20)
        Me.edt_diagname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Тип диагноза"
        '
        'edt_diagtype
        '
        Me.edt_diagtype.Enabled = False
        Me.edt_diagtype.Location = New System.Drawing.Point(86, 34)
        Me.edt_diagtype.Name = "edt_diagtype"
        Me.edt_diagtype.Size = New System.Drawing.Size(547, 20)
        Me.edt_diagtype.TabIndex = 5
        '
        'rb_amb
        '
        Me.rb_amb.AutoSize = True
        Me.rb_amb.Location = New System.Drawing.Point(10, 63)
        Me.rb_amb.Name = "rb_amb"
        Me.rb_amb.Size = New System.Drawing.Size(98, 17)
        Me.rb_amb.TabIndex = 6
        Me.rb_amb.TabStop = True
        Me.rb_amb.Text = "Амбулаторное"
        Me.rb_amb.UseVisualStyleBackColor = True
        '
        'rb_stac
        '
        Me.rb_stac.AutoSize = True
        Me.rb_stac.Location = New System.Drawing.Point(122, 63)
        Me.rb_stac.Name = "rb_stac"
        Me.rb_stac.Size = New System.Drawing.Size(126, 17)
        Me.rb_stac.TabIndex = 7
        Me.rb_stac.TabStop = True
        Me.rb_stac.Text = "Дневной стационар"
        Me.rb_stac.UseVisualStyleBackColor = True
        '
        'rb_allstac
        '
        Me.rb_allstac.AutoSize = True
        Me.rb_allstac.Location = New System.Drawing.Point(257, 63)
        Me.rb_allstac.Name = "rb_allstac"
        Me.rb_allstac.Size = New System.Drawing.Size(163, 17)
        Me.rb_allstac.TabIndex = 8
        Me.rb_allstac.TabStop = True
        Me.rb_allstac.Text = "Круглосуточный стационар"
        Me.rb_allstac.UseVisualStyleBackColor = True
        '
        'rb_netrud
        '
        Me.rb_netrud.AutoSize = True
        Me.rb_netrud.Location = New System.Drawing.Point(432, 63)
        Me.rb_netrud.Name = "rb_netrud"
        Me.rb_netrud.Size = New System.Drawing.Size(132, 17)
        Me.rb_netrud.TabIndex = 9
        Me.rb_netrud.TabStop = True
        Me.rb_netrud.Text = "Нетрудоспособность"
        Me.rb_netrud.UseVisualStyleBackColor = True
        '
        'rb_death
        '
        Me.rb_death.AutoSize = True
        Me.rb_death.Location = New System.Drawing.Point(570, 63)
        Me.rb_death.Name = "rb_death"
        Me.rb_death.Size = New System.Drawing.Size(63, 17)
        Me.rb_death.TabIndex = 10
        Me.rb_death.TabStop = True
        Me.rb_death.Text = "Смерть"
        Me.rb_death.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Лечение"
        '
        'cb_lech
        '
        Me.cb_lech.DisplayMember = "lechenie"
        Me.cb_lech.FormattingEnabled = True
        Me.cb_lech.Location = New System.Drawing.Point(63, 100)
        Me.cb_lech.Name = "cb_lech"
        Me.cb_lech.Size = New System.Drawing.Size(242, 21)
        Me.cb_lech.TabIndex = 12
        Me.cb_lech.ValueMember = "id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "ЛПУ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Врач"
        '
        'cb_lpu
        '
        Me.cb_lpu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cb_lpu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cb_lpu.DisplayMember = "lpu"
        Me.cb_lpu.FormattingEnabled = True
        Me.cb_lpu.Location = New System.Drawing.Point(63, 127)
        Me.cb_lpu.Name = "cb_lpu"
        Me.cb_lpu.Size = New System.Drawing.Size(242, 21)
        Me.cb_lpu.TabIndex = 15
        Me.cb_lpu.ValueMember = "id"
        '
        'cb_doctor
        '
        Me.cb_doctor.DisplayMember = "doctor"
        Me.cb_doctor.FormattingEnabled = True
        Me.cb_doctor.Location = New System.Drawing.Point(63, 153)
        Me.cb_doctor.Name = "cb_doctor"
        Me.cb_doctor.Size = New System.Drawing.Size(242, 21)
        Me.cb_doctor.TabIndex = 16
        Me.cb_doctor.ValueMember = "id"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(325, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Сумма"
        '
        'edt_sum
        '
        Me.edt_sum.Location = New System.Drawing.Point(432, 100)
        Me.edt_sum.Name = "edt_sum"
        Me.edt_sum.Size = New System.Drawing.Size(203, 20)
        Me.edt_sum.TabIndex = 18
        Me.edt_sum.Text = "0"
        '
        'lbl_sumfood
        '
        Me.lbl_sumfood.AutoSize = True
        Me.lbl_sumfood.Location = New System.Drawing.Point(325, 131)
        Me.lbl_sumfood.Name = "lbl_sumfood"
        Me.lbl_sumfood.Size = New System.Drawing.Size(100, 13)
        Me.lbl_sumfood.TabIndex = 19
        Me.lbl_sumfood.Text = "Сумма на питание"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(325, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Отделение"
        '
        'cb_otdel
        '
        Me.cb_otdel.DisplayMember = "otdel"
        Me.cb_otdel.FormattingEnabled = True
        Me.cb_otdel.Location = New System.Drawing.Point(393, 153)
        Me.cb_otdel.Name = "cb_otdel"
        Me.cb_otdel.Size = New System.Drawing.Size(242, 21)
        Me.cb_otdel.TabIndex = 21
        Me.cb_otdel.ValueMember = "id"
        '
        'edt_sumfood
        '
        Me.edt_sumfood.Location = New System.Drawing.Point(432, 127)
        Me.edt_sumfood.Name = "edt_sumfood"
        Me.edt_sumfood.Size = New System.Drawing.Size(203, 20)
        Me.edt_sumfood.TabIndex = 22
        Me.edt_sumfood.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Больничный"
        '
        'edt_numbol
        '
        Me.edt_numbol.Location = New System.Drawing.Point(81, 185)
        Me.edt_numbol.Name = "edt_numbol"
        Me.edt_numbol.Size = New System.Drawing.Size(125, 20)
        Me.edt_numbol.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(242, 189)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "с даты"
        '
        'dt_bolstart
        '
        Me.dt_bolstart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_bolstart.Location = New System.Drawing.Point(292, 186)
        Me.dt_bolstart.Name = "dt_bolstart"
        Me.dt_bolstart.Size = New System.Drawing.Size(95, 20)
        Me.dt_bolstart.TabIndex = 26
        '
        'c_zakr
        '
        Me.c_zakr.AutoSize = True
        Me.c_zakr.Location = New System.Drawing.Point(443, 187)
        Me.c_zakr.Name = "c_zakr"
        Me.c_zakr.Size = New System.Drawing.Size(64, 17)
        Me.c_zakr.TabIndex = 27
        Me.c_zakr.Text = "Закрыт"
        Me.c_zakr.UseVisualStyleBackColor = True
        '
        'dt_bolend
        '
        Me.dt_bolend.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_bolend.Location = New System.Drawing.Point(513, 185)
        Me.dt_bolend.Name = "dt_bolend"
        Me.dt_bolend.Size = New System.Drawing.Size(95, 20)
        Me.dt_bolend.TabIndex = 28
        '
        'gb_Vidacha
        '
        Me.gb_Vidacha.Controls.Add(Me.btn_delvidach)
        Me.gb_Vidacha.Controls.Add(Me.btn_showvid)
        Me.gb_Vidacha.Controls.Add(Me.lbl_msch)
        Me.gb_Vidacha.Controls.Add(Me.lbl_ost)
        Me.gb_Vidacha.Controls.Add(Me.lbl_vidano)
        Me.gb_Vidacha.Controls.Add(Me.lbl_limit)
        Me.gb_Vidacha.Controls.Add(Me.Label14)
        Me.gb_Vidacha.Controls.Add(Me.Label13)
        Me.gb_Vidacha.Controls.Add(Me.Label12)
        Me.gb_Vidacha.Controls.Add(Me.Label11)
        Me.gb_Vidacha.Controls.Add(Me.btn_printvidach)
        Me.gb_Vidacha.Controls.Add(Me.btn_addVidach)
        Me.gb_Vidacha.Controls.Add(Me.g_vidach)
        Me.gb_Vidacha.Location = New System.Drawing.Point(14, 215)
        Me.gb_Vidacha.Name = "gb_Vidacha"
        Me.gb_Vidacha.Size = New System.Drawing.Size(620, 201)
        Me.gb_Vidacha.TabIndex = 29
        Me.gb_Vidacha.TabStop = False
        Me.gb_Vidacha.Text = "Выдача медикаментов"
        '
        'btn_delvidach
        '
        Me.btn_delvidach.Enabled = False
        Me.btn_delvidach.Location = New System.Drawing.Point(259, 171)
        Me.btn_delvidach.Name = "btn_delvidach"
        Me.btn_delvidach.Size = New System.Drawing.Size(71, 23)
        Me.btn_delvidach.TabIndex = 29
        Me.btn_delvidach.Text = "Удалить"
        Me.btn_delvidach.UseVisualStyleBackColor = True
        '
        'btn_showvid
        '
        Me.btn_showvid.Enabled = False
        Me.btn_showvid.Location = New System.Drawing.Point(182, 171)
        Me.btn_showvid.Name = "btn_showvid"
        Me.btn_showvid.Size = New System.Drawing.Size(71, 23)
        Me.btn_showvid.TabIndex = 28
        Me.btn_showvid.Text = "Просмотр"
        Me.btn_showvid.UseVisualStyleBackColor = True
        '
        'lbl_msch
        '
        Me.lbl_msch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_msch.Location = New System.Drawing.Point(491, 83)
        Me.lbl_msch.Name = "lbl_msch"
        Me.lbl_msch.Size = New System.Drawing.Size(82, 14)
        Me.lbl_msch.TabIndex = 27
        Me.lbl_msch.Text = "0"
        Me.lbl_msch.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_ost
        '
        Me.lbl_ost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_ost.Location = New System.Drawing.Point(491, 60)
        Me.lbl_ost.Name = "lbl_ost"
        Me.lbl_ost.Size = New System.Drawing.Size(82, 14)
        Me.lbl_ost.TabIndex = 26
        Me.lbl_ost.Text = "0"
        Me.lbl_ost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_vidano
        '
        Me.lbl_vidano.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_vidano.Location = New System.Drawing.Point(491, 40)
        Me.lbl_vidano.Name = "lbl_vidano"
        Me.lbl_vidano.Size = New System.Drawing.Size(82, 14)
        Me.lbl_vidano.TabIndex = 25
        Me.lbl_vidano.Text = "0"
        Me.lbl_vidano.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_limit
        '
        Me.lbl_limit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_limit.Location = New System.Drawing.Point(491, 20)
        Me.lbl_limit.Name = "lbl_limit"
        Me.lbl_limit.Size = New System.Drawing.Size(82, 14)
        Me.lbl_limit.TabIndex = 24
        Me.lbl_limit.Text = "0"
        Me.lbl_limit.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(360, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "% МСЧ"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(360, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Остаток"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(360, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Выдано медикаментов"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(360, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Лимит"
        '
        'btn_printvidach
        '
        Me.btn_printvidach.Enabled = False
        Me.btn_printvidach.Location = New System.Drawing.Point(105, 171)
        Me.btn_printvidach.Name = "btn_printvidach"
        Me.btn_printvidach.Size = New System.Drawing.Size(71, 23)
        Me.btn_printvidach.TabIndex = 2
        Me.btn_printvidach.Text = "Печать"
        Me.btn_printvidach.UseVisualStyleBackColor = True
        '
        'btn_addVidach
        '
        Me.btn_addVidach.Enabled = False
        Me.btn_addVidach.Location = New System.Drawing.Point(9, 171)
        Me.btn_addVidach.Name = "btn_addVidach"
        Me.btn_addVidach.Size = New System.Drawing.Size(90, 23)
        Me.btn_addVidach.TabIndex = 1
        Me.btn_addVidach.Text = "Новая выдача"
        Me.btn_addVidach.UseVisualStyleBackColor = True
        '
        'g_vidach
        '
        Me.g_vidach.AllowUserToAddRows = False
        Me.g_vidach.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.g_vidach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.g_vidach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.g_vidach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.date_enter, Me.total_price})
        Me.g_vidach.Location = New System.Drawing.Point(9, 20)
        Me.g_vidach.Name = "g_vidach"
        Me.g_vidach.ReadOnly = True
        Me.g_vidach.RowHeadersVisible = False
        Me.g_vidach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.g_vidach.Size = New System.Drawing.Size(319, 143)
        Me.g_vidach.TabIndex = 0
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.id.DefaultCellStyle = DataGridViewCellStyle2
        Me.id.HeaderText = "№"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'date_enter
        '
        Me.date_enter.DataPropertyName = "date_enter"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.date_enter.DefaultCellStyle = DataGridViewCellStyle3
        Me.date_enter.HeaderText = "Дата"
        Me.date_enter.Name = "date_enter"
        Me.date_enter.ReadOnly = True
        Me.date_enter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'total_price
        '
        Me.total_price.DataPropertyName = "total_price"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.total_price.DefaultCellStyle = DataGridViewCellStyle4
        Me.total_price.HeaderText = "Сумма"
        Me.total_price.Name = "total_price"
        Me.total_price.ReadOnly = True
        Me.total_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(23, 422)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(113, 23)
        Me.Btn_Save.TabIndex = 30
        Me.Btn_Save.Text = "Сохранить"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Btn_Close
        '
        Me.Btn_Close.Location = New System.Drawing.Point(474, 425)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(113, 23)
        Me.Btn_Close.TabIndex = 31
        Me.Btn_Close.Text = "Выход"
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_label, Me.st_label_fakt})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 453)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(645, 22)
        Me.StatusStrip1.TabIndex = 32
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
        'FCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 475)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.gb_Vidacha)
        Me.Controls.Add(Me.dt_bolend)
        Me.Controls.Add(Me.c_zakr)
        Me.Controls.Add(Me.dt_bolstart)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.edt_numbol)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.edt_sumfood)
        Me.Controls.Add(Me.cb_otdel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_sumfood)
        Me.Controls.Add(Me.edt_sum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cb_doctor)
        Me.Controls.Add(Me.cb_lpu)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cb_lech)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rb_death)
        Me.Controls.Add(Me.rb_netrud)
        Me.Controls.Add(Me.rb_allstac)
        Me.Controls.Add(Me.rb_stac)
        Me.Controls.Add(Me.rb_amb)
        Me.Controls.Add(Me.edt_diagtype)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.edt_diagname)
        Me.Controls.Add(Me.btn_getdiag)
        Me.Controls.Add(Me.edt_diag)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FCase"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Страховой случай"
        Me.gb_Vidacha.ResumeLayout(False)
        Me.gb_Vidacha.PerformLayout()
        CType(Me.g_vidach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents edt_diag As System.Windows.Forms.TextBox
    Friend WithEvents btn_getdiag As System.Windows.Forms.Button
    Friend WithEvents edt_diagname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents edt_diagtype As System.Windows.Forms.TextBox
    Friend WithEvents rb_amb As System.Windows.Forms.RadioButton
    Friend WithEvents rb_stac As System.Windows.Forms.RadioButton
    Friend WithEvents rb_allstac As System.Windows.Forms.RadioButton
    Friend WithEvents rb_netrud As System.Windows.Forms.RadioButton
    Friend WithEvents rb_death As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cb_lech As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cb_lpu As System.Windows.Forms.ComboBox
    Friend WithEvents cb_doctor As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents edt_sum As System.Windows.Forms.TextBox
    Friend WithEvents lbl_sumfood As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cb_otdel As System.Windows.Forms.ComboBox
    Friend WithEvents edt_sumfood As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents edt_numbol As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dt_bolstart As System.Windows.Forms.DateTimePicker
    Friend WithEvents c_zakr As System.Windows.Forms.CheckBox
    Friend WithEvents dt_bolend As System.Windows.Forms.DateTimePicker
    Friend WithEvents gb_Vidacha As System.Windows.Forms.GroupBox
    Friend WithEvents g_vidach As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_msch As System.Windows.Forms.Label
    Friend WithEvents lbl_ost As System.Windows.Forms.Label
    Friend WithEvents lbl_vidano As System.Windows.Forms.Label
    Friend WithEvents lbl_limit As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_printvidach As System.Windows.Forms.Button
    Friend WithEvents btn_addVidach As System.Windows.Forms.Button
    Friend WithEvents Btn_Save As System.Windows.Forms.Button
    Friend WithEvents Btn_Close As System.Windows.Forms.Button
    Friend WithEvents btn_delvidach As System.Windows.Forms.Button
    Friend WithEvents btn_showvid As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents st_label As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_label_fakt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_enter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_price As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
