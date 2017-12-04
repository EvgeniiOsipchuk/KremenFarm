<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMain))
        Me.menu_main = New System.Windows.Forms.MenuStrip()
        Me.КлиентыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mi_Medikament = New System.Windows.Forms.ToolStripMenuItem()
        Me.mi_ImportNakl = New System.Windows.Forms.ToolStripMenuItem()
        Me.КлиентыToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsKlients = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОтчетыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mi_RepVidacha = New System.Windows.Forms.ToolStripMenuItem()
        Me.mi_repvostok = New System.Windows.Forms.ToolStripMenuItem()
        Me.mi_svodrep = New System.Windows.Forms.ToolStripMenuItem()
        Me.mi_MedOst = New System.Windows.Forms.ToolStripMenuItem()
        Me.mi_RepAnaliz = New System.Windows.Forms.ToolStripMenuItem()
        Me.mi_OpenNorma = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДоговораToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mi_Dogovor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mi_DogovorAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправочникиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mi_doctors = New System.Windows.Forms.ToolStripMenuItem()
        Me.mi_MKB = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mi_doctortype = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЛимитыОтветственностиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mi_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.НастройкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СоединениеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_main.SuspendLayout
        Me.SuspendLayout
        '
        'menu_main
        '
        Me.menu_main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КлиентыToolStripMenuItem, Me.КлиентыToolStripMenuItem1, Me.ОтчетыToolStripMenuItem, Me.ДоговораToolStripMenuItem, Me.СправочникиToolStripMenuItem, Me.НастройкиToolStripMenuItem, Me.mi_Exit})
        Me.menu_main.Location = New System.Drawing.Point(0, 0)
        Me.menu_main.Name = "menu_main"
        Me.menu_main.Size = New System.Drawing.Size(574, 24)
        Me.menu_main.TabIndex = 1
        Me.menu_main.Text = "MenuStrip2"
        '
        'КлиентыToolStripMenuItem
        '
        Me.КлиентыToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mi_Medikament, Me.mi_ImportNakl})
        Me.КлиентыToolStripMenuItem.Name = "КлиентыToolStripMenuItem"
        Me.КлиентыToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.КлиентыToolStripMenuItem.Text = "Аптека"
        '
        'mi_Medikament
        '
        Me.mi_Medikament.Name = "mi_Medikament"
        Me.mi_Medikament.Size = New System.Drawing.Size(206, 22)
        Me.mi_Medikament.Text = "Медикаменты"
        '
        'mi_ImportNakl
        '
        Me.mi_ImportNakl.Name = "mi_ImportNakl"
        Me.mi_ImportNakl.Size = New System.Drawing.Size(206, 22)
        Me.mi_ImportNakl.Text = "Ввод накладной из файла"
        '
        'КлиентыToolStripMenuItem1
        '
        Me.КлиентыToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsKlients})
        Me.КлиентыToolStripMenuItem1.Name = "КлиентыToolStripMenuItem1"
        Me.КлиентыToolStripMenuItem1.Size = New System.Drawing.Size(64, 20)
        Me.КлиентыToolStripMenuItem1.Text = "Клиенты"
        '
        'tsKlients
        '
        Me.tsKlients.Name = "tsKlients"
        Me.tsKlients.Size = New System.Drawing.Size(219, 22)
        Me.tsKlients.Text = "Просмотр и редактирование"
        '
        'ОтчетыToolStripMenuItem
        '
        Me.ОтчетыToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mi_RepVidacha, Me.mi_MedOst, Me.mi_RepAnaliz, Me.mi_OpenNorma})
        Me.ОтчетыToolStripMenuItem.Name = "ОтчетыToolStripMenuItem"
        Me.ОтчетыToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ОтчетыToolStripMenuItem.Text = "Отчеты"
        '
        'mi_RepVidacha
        '
        Me.mi_RepVidacha.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mi_repvostok, Me.mi_svodrep})
        Me.mi_RepVidacha.Name = "mi_RepVidacha"
        Me.mi_RepVidacha.Size = New System.Drawing.Size(228, 22)
        Me.mi_RepVidacha.Text = "Выдачи за период"
        '
        'mi_repvostok
        '
        Me.mi_repvostok.Name = "mi_repvostok"
        Me.mi_repvostok.Size = New System.Drawing.Size(317, 22)
        Me.mi_repvostok.Text = "Пофамильно для Востока"
        '
        'mi_svodrep
        '
        Me.mi_svodrep.Name = "mi_svodrep"
        Me.mi_svodrep.Size = New System.Drawing.Size(317, 22)
        Me.mi_svodrep.Text = "Сводная накладная по выданым медикаментам"
        '
        'mi_MedOst
        '
        Me.mi_MedOst.Name = "mi_MedOst"
        Me.mi_MedOst.Size = New System.Drawing.Size(228, 22)
        Me.mi_MedOst.Text = "Остатки медикаментов"
        '
        'mi_RepAnaliz
        '
        Me.mi_RepAnaliz.Name = "mi_RepAnaliz"
        Me.mi_RepAnaliz.Size = New System.Drawing.Size(228, 22)
        Me.mi_RepAnaliz.Text = "Анализы"
        '
        'mi_OpenNorma
        '
        Me.mi_OpenNorma.Name = "mi_OpenNorma"
        Me.mi_OpenNorma.Size = New System.Drawing.Size(228, 22)
        Me.mi_OpenNorma.Text = "Открытые случаи с выдачами"
        '
        'ДоговораToolStripMenuItem
        '
        Me.ДоговораToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mi_Dogovor, Me.mi_DogovorAdd})
        Me.ДоговораToolStripMenuItem.Name = "ДоговораToolStripMenuItem"
        Me.ДоговораToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ДоговораToolStripMenuItem.Text = "Договора"
        '
        'mi_Dogovor
        '
        Me.mi_Dogovor.Name = "mi_Dogovor"
        Me.mi_Dogovor.Size = New System.Drawing.Size(225, 22)
        Me.mi_Dogovor.Text = "Договора страхования"
        '
        'mi_DogovorAdd
        '
        Me.mi_DogovorAdd.Name = "mi_DogovorAdd"
        Me.mi_DogovorAdd.Size = New System.Drawing.Size(225, 22)
        Me.mi_DogovorAdd.Text = "Дополнительные соглашения"
        '
        'СправочникиToolStripMenuItem
        '
        Me.СправочникиToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mi_doctors, Me.mi_MKB, Me.ToolStripMenuItem2, Me.mi_doctortype, Me.ЛимитыОтветственностиToolStripMenuItem})
        Me.СправочникиToolStripMenuItem.Name = "СправочникиToolStripMenuItem"
        Me.СправочникиToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.СправочникиToolStripMenuItem.Text = "Справочники"
        '
        'mi_doctors
        '
        Me.mi_doctors.Name = "mi_doctors"
        Me.mi_doctors.Size = New System.Drawing.Size(204, 22)
        Me.mi_doctors.Text = "Врачи"
        '
        'mi_MKB
        '
        Me.mi_MKB.Name = "mi_MKB"
        Me.mi_MKB.Size = New System.Drawing.Size(204, 22)
        Me.mi_MKB.Text = "МКБ-10"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(201, 6)
        '
        'mi_doctortype
        '
        Me.mi_doctortype.Name = "mi_doctortype"
        Me.mi_doctortype.Size = New System.Drawing.Size(204, 22)
        Me.mi_doctortype.Text = "Специальности врача"
        '
        'ЛимитыОтветственностиToolStripMenuItem
        '
        Me.ЛимитыОтветственностиToolStripMenuItem.Name = "ЛимитыОтветственностиToolStripMenuItem"
        Me.ЛимитыОтветственностиToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ЛимитыОтветственностиToolStripMenuItem.Text = "Лимиты ответственности"
        '
        'mi_Exit
        '
        Me.mi_Exit.Name = "mi_Exit"
        Me.mi_Exit.Size = New System.Drawing.Size(52, 20)
        Me.mi_Exit.Text = "Выход"
        '
        'НастройкиToolStripMenuItem
        '
        Me.НастройкиToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СоединениеToolStripMenuItem})
        Me.НастройкиToolStripMenuItem.Name = "НастройкиToolStripMenuItem"
        Me.НастройкиToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.НастройкиToolStripMenuItem.Text = "Настройки"
        '
        'СоединениеToolStripMenuItem
        '
        Me.СоединениеToolStripMenuItem.Name = "СоединениеToolStripMenuItem"
        Me.СоединениеToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.СоединениеToolStripMenuItem.Text = "Соединение"
        '
        'FMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 62)
        Me.Controls.Add(Me.menu_main)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "FMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KremenFarm"
        Me.menu_main.ResumeLayout(false)
        Me.menu_main.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents menu_main As System.Windows.Forms.MenuStrip
    Friend WithEvents КлиентыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mi_Medikament As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mi_ImportNakl As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents КлиентыToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsKlients As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОтчетыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mi_RepVidacha As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mi_MedOst As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mi_RepAnaliz As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ДоговораToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mi_Dogovor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mi_DogovorAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СправочникиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mi_doctors As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mi_MKB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mi_doctortype As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ЛимитыОтветственностиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mi_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mi_OpenNorma As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mi_repvostok As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mi_svodrep As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents НастройкиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СоединениеToolStripMenuItem As ToolStripMenuItem
End Class
