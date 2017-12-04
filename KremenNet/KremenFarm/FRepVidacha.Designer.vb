<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRepVidacha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRepVidacha))
        Me.cb_pred = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt_start = New System.Windows.Forms.DateTimePicker()
        Me.dt_end = New System.Windows.Forms.DateTimePicker()
        Me.gb_lechenie = New System.Windows.Forms.GroupBox()
        Me.rb_amb_lech = New System.Windows.Forms.RadioButton()
        Me.rb_all_lech = New System.Windows.Forms.RadioButton()
        Me.gb_bol = New System.Windows.Forms.GroupBox()
        Me.rb_bol_close = New System.Windows.Forms.RadioButton()
        Me.rb_bol_open = New System.Windows.Forms.RadioButton()
        Me.rb_All_bol = New System.Windows.Forms.RadioButton()
        Me.gb_med = New System.Windows.Forms.GroupBox()
        Me.cb_Apteka = New System.Windows.Forms.ComboBox()
        Me.rb_med_no = New System.Windows.Forms.RadioButton()
        Me.rb_med_yes = New System.Windows.Forms.RadioButton()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.g_RepVidach = New System.Windows.Forms.DataGridView()
        Me.fio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_start = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_sum = New System.Windows.Forms.Label()
        Me.lbl_kol = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.st_info = New System.Windows.Forms.ToolStripStatusLabel()
        Me.progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.gb_lechenie.SuspendLayout()
        Me.gb_bol.SuspendLayout()
        Me.gb_med.SuspendLayout()
        CType(Me.g_RepVidach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_pred
        '
        Me.cb_pred.FormattingEnabled = True
        Me.cb_pred.Location = New System.Drawing.Point(4, 19)
        Me.cb_pred.Name = "cb_pred"
        Me.cb_pred.Size = New System.Drawing.Size(212, 21)
        Me.cb_pred.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Выберите предприятие"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "с"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(107, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "по"
        '
        'dt_start
        '
        Me.dt_start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_start.Location = New System.Drawing.Point(16, 44)
        Me.dt_start.Name = "dt_start"
        Me.dt_start.Size = New System.Drawing.Size(89, 20)
        Me.dt_start.TabIndex = 4
        '
        'dt_end
        '
        Me.dt_end.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_end.Location = New System.Drawing.Point(128, 44)
        Me.dt_end.Name = "dt_end"
        Me.dt_end.Size = New System.Drawing.Size(89, 20)
        Me.dt_end.TabIndex = 5
        '
        'gb_lechenie
        '
        Me.gb_lechenie.Controls.Add(Me.rb_amb_lech)
        Me.gb_lechenie.Controls.Add(Me.rb_all_lech)
        Me.gb_lechenie.Location = New System.Drawing.Point(223, 6)
        Me.gb_lechenie.Name = "gb_lechenie"
        Me.gb_lechenie.Size = New System.Drawing.Size(113, 87)
        Me.gb_lechenie.TabIndex = 6
        Me.gb_lechenie.TabStop = False
        Me.gb_lechenie.Text = "Лечение"
        '
        'rb_amb_lech
        '
        Me.rb_amb_lech.AutoSize = True
        Me.rb_amb_lech.Location = New System.Drawing.Point(11, 54)
        Me.rb_amb_lech.Name = "rb_amb_lech"
        Me.rb_amb_lech.Size = New System.Drawing.Size(100, 17)
        Me.rb_amb_lech.TabIndex = 1
        Me.rb_amb_lech.TabStop = True
        Me.rb_amb_lech.Text = "Амбулаторные"
        Me.rb_amb_lech.UseVisualStyleBackColor = True
        '
        'rb_all_lech
        '
        Me.rb_all_lech.AutoSize = True
        Me.rb_all_lech.Location = New System.Drawing.Point(11, 26)
        Me.rb_all_lech.Name = "rb_all_lech"
        Me.rb_all_lech.Size = New System.Drawing.Size(44, 17)
        Me.rb_all_lech.TabIndex = 0
        Me.rb_all_lech.TabStop = True
        Me.rb_all_lech.Text = "Все"
        Me.rb_all_lech.UseVisualStyleBackColor = True
        '
        'gb_bol
        '
        Me.gb_bol.Controls.Add(Me.rb_bol_close)
        Me.gb_bol.Controls.Add(Me.rb_bol_open)
        Me.gb_bol.Controls.Add(Me.rb_All_bol)
        Me.gb_bol.Location = New System.Drawing.Point(342, 5)
        Me.gb_bol.Name = "gb_bol"
        Me.gb_bol.Size = New System.Drawing.Size(88, 88)
        Me.gb_bol.TabIndex = 7
        Me.gb_bol.TabStop = False
        Me.gb_bol.Text = "Больничные"
        '
        'rb_bol_close
        '
        Me.rb_bol_close.AutoSize = True
        Me.rb_bol_close.Location = New System.Drawing.Point(8, 65)
        Me.rb_bol_close.Name = "rb_bol_close"
        Me.rb_bol_close.Size = New System.Drawing.Size(77, 17)
        Me.rb_bol_close.TabIndex = 3
        Me.rb_bol_close.TabStop = True
        Me.rb_bol_close.Text = "Закрытые"
        Me.rb_bol_close.UseVisualStyleBackColor = True
        '
        'rb_bol_open
        '
        Me.rb_bol_open.AutoSize = True
        Me.rb_bol_open.Location = New System.Drawing.Point(8, 42)
        Me.rb_bol_open.Name = "rb_bol_open"
        Me.rb_bol_open.Size = New System.Drawing.Size(77, 17)
        Me.rb_bol_open.TabIndex = 2
        Me.rb_bol_open.TabStop = True
        Me.rb_bol_open.Text = "Открытые"
        Me.rb_bol_open.UseVisualStyleBackColor = True
        '
        'rb_All_bol
        '
        Me.rb_All_bol.AutoSize = True
        Me.rb_All_bol.Location = New System.Drawing.Point(8, 19)
        Me.rb_All_bol.Name = "rb_All_bol"
        Me.rb_All_bol.Size = New System.Drawing.Size(44, 17)
        Me.rb_All_bol.TabIndex = 1
        Me.rb_All_bol.TabStop = True
        Me.rb_All_bol.Text = "Все"
        Me.rb_All_bol.UseVisualStyleBackColor = True
        '
        'gb_med
        '
        Me.gb_med.Controls.Add(Me.cb_Apteka)
        Me.gb_med.Controls.Add(Me.rb_med_no)
        Me.gb_med.Controls.Add(Me.rb_med_yes)
        Me.gb_med.Location = New System.Drawing.Point(433, 4)
        Me.gb_med.Name = "gb_med"
        Me.gb_med.Size = New System.Drawing.Size(119, 89)
        Me.gb_med.TabIndex = 8
        Me.gb_med.TabStop = False
        Me.gb_med.Text = "Медикаменты"
        '
        'cb_Apteka
        '
        Me.cb_Apteka.DisplayMember = "apteka_name"
        Me.cb_Apteka.FormattingEnabled = True
        Me.cb_Apteka.Location = New System.Drawing.Point(9, 41)
        Me.cb_Apteka.Name = "cb_Apteka"
        Me.cb_Apteka.Size = New System.Drawing.Size(102, 21)
        Me.cb_Apteka.TabIndex = 4
        Me.cb_Apteka.ValueMember = "id"
        '
        'rb_med_no
        '
        Me.rb_med_no.AutoSize = True
        Me.rb_med_no.Location = New System.Drawing.Point(11, 66)
        Me.rb_med_no.Name = "rb_med_no"
        Me.rb_med_no.Size = New System.Drawing.Size(84, 17)
        Me.rb_med_no.TabIndex = 3
        Me.rb_med_no.TabStop = True
        Me.rb_med_no.Text = "Без выдачи"
        Me.rb_med_no.UseVisualStyleBackColor = True
        '
        'rb_med_yes
        '
        Me.rb_med_yes.AutoSize = True
        Me.rb_med_yes.Location = New System.Drawing.Point(11, 20)
        Me.rb_med_yes.Name = "rb_med_yes"
        Me.rb_med_yes.Size = New System.Drawing.Size(78, 17)
        Me.rb_med_yes.TabIndex = 2
        Me.rb_med_yes.TabStop = True
        Me.rb_med_yes.Text = "С выдачей"
        Me.rb_med_yes.UseVisualStyleBackColor = True
        '
        'btn_select
        '
        Me.btn_select.Location = New System.Drawing.Point(9, 71)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(75, 23)
        Me.btn_select.TabIndex = 9
        Me.btn_select.Text = "Выбрать"
        Me.btn_select.UseVisualStyleBackColor = True
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(90, 71)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(75, 23)
        Me.btn_print.TabIndex = 10
        Me.btn_print.Text = "Печать"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'g_RepVidach
        '
        Me.g_RepVidach.AllowUserToAddRows = False
        Me.g_RepVidach.AllowUserToDeleteRows = False
        Me.g_RepVidach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.g_RepVidach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fio, Me.num, Me.bol_num, Me.bol_start, Me.total_price})
        Me.g_RepVidach.Location = New System.Drawing.Point(8, 102)
        Me.g_RepVidach.Name = "g_RepVidach"
        Me.g_RepVidach.ReadOnly = True
        Me.g_RepVidach.RowHeadersVisible = False
        Me.g_RepVidach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.g_RepVidach.Size = New System.Drawing.Size(682, 358)
        Me.g_RepVidach.TabIndex = 11
        '
        'fio
        '
        Me.fio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.fio.DataPropertyName = "fio"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.fio.DefaultCellStyle = DataGridViewCellStyle1
        Me.fio.HeaderText = "ФИО"
        Me.fio.Name = "fio"
        Me.fio.ReadOnly = True
        Me.fio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'num
        '
        Me.num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.num.DataPropertyName = "num"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.num.DefaultCellStyle = DataGridViewCellStyle2
        Me.num.HeaderText = "Договор"
        Me.num.Name = "num"
        Me.num.ReadOnly = True
        Me.num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.num.Width = 57
        '
        'bol_num
        '
        Me.bol_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.bol_num.DataPropertyName = "bol_num"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.bol_num.DefaultCellStyle = DataGridViewCellStyle3
        Me.bol_num.HeaderText = "Больничный"
        Me.bol_num.Name = "bol_num"
        Me.bol_num.ReadOnly = True
        Me.bol_num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.bol_num.Width = 75
        '
        'bol_start
        '
        Me.bol_start.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.bol_start.DataPropertyName = "bol_start"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.bol_start.DefaultCellStyle = DataGridViewCellStyle4
        Me.bol_start.HeaderText = "Начало страхового"
        Me.bol_start.Name = "bol_start"
        Me.bol_start.ReadOnly = True
        Me.bol_start.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.bol_start.Width = 99
        '
        'total_price
        '
        Me.total_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.total_price.DataPropertyName = "total_price"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.total_price.DefaultCellStyle = DataGridViewCellStyle5
        Me.total_price.HeaderText = "Сумма"
        Me.total_price.Name = "total_price"
        Me.total_price.ReadOnly = True
        Me.total_price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total_price.Width = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(557, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "ИТОГО"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(558, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Сумма"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(557, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Количество"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_sum
        '
        Me.lbl_sum.AutoSize = True
        Me.lbl_sum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_sum.Location = New System.Drawing.Point(604, 36)
        Me.lbl_sum.Name = "lbl_sum"
        Me.lbl_sum.Size = New System.Drawing.Size(14, 13)
        Me.lbl_sum.TabIndex = 15
        Me.lbl_sum.Text = "0"
        Me.lbl_sum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_kol
        '
        Me.lbl_kol.AutoSize = True
        Me.lbl_kol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_kol.Location = New System.Drawing.Point(634, 60)
        Me.lbl_kol.Name = "lbl_kol"
        Me.lbl_kol.Size = New System.Drawing.Size(14, 13)
        Me.lbl_kol.TabIndex = 16
        Me.lbl_kol.Text = "0"
        Me.lbl_kol.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_info, Me.progress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 463)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(699, 22)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'st_info
        '
        Me.st_info.Name = "st_info"
        Me.st_info.Size = New System.Drawing.Size(137, 17)
        Me.st_info.Text = "Формируется документ"
        '
        'progress
        '
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(200, 16)
        Me.progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'FRepVidacha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 485)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lbl_kol)
        Me.Controls.Add(Me.lbl_sum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.g_RepVidach)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_select)
        Me.Controls.Add(Me.gb_med)
        Me.Controls.Add(Me.gb_bol)
        Me.Controls.Add(Me.gb_lechenie)
        Me.Controls.Add(Me.dt_end)
        Me.Controls.Add(Me.dt_start)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_pred)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FRepVidacha"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Выдачи за период"
        Me.gb_lechenie.ResumeLayout(False)
        Me.gb_lechenie.PerformLayout()
        Me.gb_bol.ResumeLayout(False)
        Me.gb_bol.PerformLayout()
        Me.gb_med.ResumeLayout(False)
        Me.gb_med.PerformLayout()
        CType(Me.g_RepVidach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cb_pred As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt_start As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_end As System.Windows.Forms.DateTimePicker
    Friend WithEvents gb_lechenie As System.Windows.Forms.GroupBox
    Friend WithEvents rb_amb_lech As System.Windows.Forms.RadioButton
    Friend WithEvents rb_all_lech As System.Windows.Forms.RadioButton
    Friend WithEvents gb_bol As System.Windows.Forms.GroupBox
    Friend WithEvents gb_med As System.Windows.Forms.GroupBox
    Friend WithEvents rb_bol_close As System.Windows.Forms.RadioButton
    Friend WithEvents rb_bol_open As System.Windows.Forms.RadioButton
    Friend WithEvents rb_All_bol As System.Windows.Forms.RadioButton
    Friend WithEvents rb_med_no As System.Windows.Forms.RadioButton
    Friend WithEvents rb_med_yes As System.Windows.Forms.RadioButton
    Friend WithEvents btn_select As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents g_RepVidach As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_sum As System.Windows.Forms.Label
    Friend WithEvents lbl_kol As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents progress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents st_info As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cb_Apteka As System.Windows.Forms.ComboBox
    Friend WithEvents fio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_start As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total_price As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
