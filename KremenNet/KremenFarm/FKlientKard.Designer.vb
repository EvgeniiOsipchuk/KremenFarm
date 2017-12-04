<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FKlientKard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FKlientKard))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.edt_inn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.edt_fio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt_datrog = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.edt_tabnum = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.edt_ceh = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.edt_cehname = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.edt_kemvidan = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dt_paspdate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.edt_pasp_num = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.edt_paspser = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.edt_adr = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.edt_schet = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cb_dogovor = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dt_dogdate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dt_naslgord = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.edt_nasladr = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.edt_naslfio = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cb_god_strax = New System.Windows.Forms.ComboBox()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.btn_CLose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ид. Номер"
        '
        'edt_inn
        '
        Me.edt_inn.Location = New System.Drawing.Point(74, 9)
        Me.edt_inn.Name = "edt_inn"
        Me.edt_inn.Size = New System.Drawing.Size(90, 20)
        Me.edt_inn.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ФИО"
        '
        'edt_fio
        '
        Me.edt_fio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.edt_fio.Location = New System.Drawing.Point(210, 9)
        Me.edt_fio.Name = "edt_fio"
        Me.edt_fio.Size = New System.Drawing.Size(318, 20)
        Me.edt_fio.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Дата рождения"
        '
        'dt_datrog
        '
        Me.dt_datrog.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_datrog.Location = New System.Drawing.Point(98, 34)
        Me.dt_datrog.Name = "dt_datrog"
        Me.dt_datrog.Size = New System.Drawing.Size(103, 20)
        Me.dt_datrog.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Табельный №"
        '
        'edt_tabnum
        '
        Me.edt_tabnum.Location = New System.Drawing.Point(92, 60)
        Me.edt_tabnum.Name = "edt_tabnum"
        Me.edt_tabnum.Size = New System.Drawing.Size(70, 20)
        Me.edt_tabnum.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(168, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Код цеха"
        '
        'edt_ceh
        '
        Me.edt_ceh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.edt_ceh.Location = New System.Drawing.Point(226, 60)
        Me.edt_ceh.Name = "edt_ceh"
        Me.edt_ceh.Size = New System.Drawing.Size(56, 20)
        Me.edt_ceh.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(288, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Название цеха"
        '
        'edt_cehname
        '
        Me.edt_cehname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.edt_cehname.Location = New System.Drawing.Point(377, 60)
        Me.edt_cehname.Name = "edt_cehname"
        Me.edt_cehname.Size = New System.Drawing.Size(152, 20)
        Me.edt_cehname.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.edt_kemvidan)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.dt_paspdate)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.edt_pasp_num)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.edt_paspser)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(517, 49)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Паспортные данные"
        '
        'edt_kemvidan
        '
        Me.edt_kemvidan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.edt_kemvidan.Location = New System.Drawing.Point(355, 18)
        Me.edt_kemvidan.Name = "edt_kemvidan"
        Me.edt_kemvidan.Size = New System.Drawing.Size(152, 20)
        Me.edt_kemvidan.TabIndex = 16
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(309, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 13)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Выдан"
        '
        'dt_paspdate
        '
        Me.dt_paspdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_paspdate.Location = New System.Drawing.Point(207, 19)
        Me.dt_paspdate.Name = "dt_paspdate"
        Me.dt_paspdate.Size = New System.Drawing.Size(96, 20)
        Me.dt_paspdate.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(172, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Дата "
        '
        'edt_pasp_num
        '
        Me.edt_pasp_num.Location = New System.Drawing.Point(110, 19)
        Me.edt_pasp_num.Name = "edt_pasp_num"
        Me.edt_pasp_num.Size = New System.Drawing.Size(56, 20)
        Me.edt_pasp_num.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(90, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "№"
        '
        'edt_paspser
        '
        Me.edt_paspser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.edt_paspser.Location = New System.Drawing.Point(46, 19)
        Me.edt_paspser.Name = "edt_paspser"
        Me.edt_paspser.Size = New System.Drawing.Size(37, 20)
        Me.edt_paspser.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Серия"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Адрес"
        '
        'edt_adr
        '
        Me.edt_adr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.edt_adr.Location = New System.Drawing.Point(61, 140)
        Me.edt_adr.Name = "edt_adr"
        Me.edt_adr.Size = New System.Drawing.Size(468, 20)
        Me.edt_adr.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Счет"
        '
        'edt_schet
        '
        Me.edt_schet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.edt_schet.Location = New System.Drawing.Point(61, 164)
        Me.edt_schet.Name = "edt_schet"
        Me.edt_schet.Size = New System.Drawing.Size(468, 20)
        Me.edt_schet.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Договор"
        '
        'cb_dogovor
        '
        Me.cb_dogovor.DisplayMember = "dog"
        Me.cb_dogovor.FormattingEnabled = True
        Me.cb_dogovor.Location = New System.Drawing.Point(61, 188)
        Me.cb_dogovor.Name = "cb_dogovor"
        Me.cb_dogovor.Size = New System.Drawing.Size(353, 21)
        Me.cb_dogovor.TabIndex = 18
        Me.cb_dogovor.ValueMember = "id"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(417, 190)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "с"
        '
        'dt_dogdate
        '
        Me.dt_dogdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_dogdate.Location = New System.Drawing.Point(433, 188)
        Me.dt_dogdate.Name = "dt_dogdate"
        Me.dt_dogdate.Size = New System.Drawing.Size(95, 20)
        Me.dt_dogdate.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dt_naslgord)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.edt_nasladr)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.edt_naslfio)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(517, 93)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Наследник"
        '
        'dt_naslgord
        '
        Me.dt_naslgord.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_naslgord.Location = New System.Drawing.Point(96, 67)
        Me.dt_naslgord.Name = "dt_naslgord"
        Me.dt_naslgord.Size = New System.Drawing.Size(103, 20)
        Me.dt_naslgord.TabIndex = 18
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 13)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Дата рождения"
        '
        'edt_nasladr
        '
        Me.edt_nasladr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.edt_nasladr.Location = New System.Drawing.Point(45, 43)
        Me.edt_nasladr.Name = "edt_nasladr"
        Me.edt_nasladr.Size = New System.Drawing.Size(466, 20)
        Me.edt_nasladr.TabIndex = 16
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 46)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 13)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Адрес"
        '
        'edt_naslfio
        '
        Me.edt_naslfio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.edt_naslfio.Location = New System.Drawing.Point(43, 19)
        Me.edt_naslfio.Name = "edt_naslfio"
        Me.edt_naslfio.Size = New System.Drawing.Size(468, 20)
        Me.edt_naslfio.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "ФИО"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 217)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Год страхования"
        '
        'cb_god_strax
        '
        Me.cb_god_strax.DisplayMember = "god_strax"
        Me.cb_god_strax.FormattingEnabled = True
        Me.cb_god_strax.Location = New System.Drawing.Point(100, 213)
        Me.cb_god_strax.Name = "cb_god_strax"
        Me.cb_god_strax.Size = New System.Drawing.Size(103, 21)
        Me.cb_god_strax.TabIndex = 25
        Me.cb_god_strax.ValueMember = "god_strax"
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(42, 344)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Save.TabIndex = 26
        Me.Btn_Save.Text = "Сохранить"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'btn_CLose
        '
        Me.btn_CLose.Location = New System.Drawing.Point(420, 344)
        Me.btn_CLose.Name = "btn_CLose"
        Me.btn_CLose.Size = New System.Drawing.Size(75, 23)
        Me.btn_CLose.TabIndex = 27
        Me.btn_CLose.Text = "Выход"
        Me.btn_CLose.UseVisualStyleBackColor = True
        '
        'FKlientKard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 376)
        Me.Controls.Add(Me.btn_CLose)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.cb_god_strax)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dt_dogdate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cb_dogovor)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.edt_schet)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.edt_adr)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.edt_cehname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.edt_ceh)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.edt_tabnum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dt_datrog)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.edt_fio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.edt_inn)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FKlientKard"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FKlientKard"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents edt_inn As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents edt_fio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt_datrog As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents edt_tabnum As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents edt_ceh As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents edt_cehname As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dt_paspdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents edt_pasp_num As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents edt_paspser As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents edt_adr As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents edt_schet As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cb_dogovor As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dt_dogdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dt_naslgord As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents edt_nasladr As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents edt_naslfio As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cb_god_strax As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_Save As System.Windows.Forms.Button
    Friend WithEvents btn_CLose As System.Windows.Forms.Button
    Friend WithEvents edt_kemvidan As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
End Class
