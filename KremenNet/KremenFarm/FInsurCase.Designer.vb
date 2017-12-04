<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FInsurCase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FInsurCase))
        Me.pnl_top = New System.Windows.Forms.Panel()
        Me.lbl_fio = New System.Windows.Forms.Label()
        Me.pnl_button = New System.Windows.Forms.Panel()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_NewCase = New System.Windows.Forms.Button()
        Me.btn_DelCase = New System.Windows.Forms.Button()
        Me.btn_UpdCase = New System.Windows.Forms.Button()
        Me.pnl_cases = New System.Windows.Forms.Panel()
        Me.g_cases = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_start = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bol_end = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lechenie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type_diag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnl_top.SuspendLayout()
        Me.pnl_button.SuspendLayout()
        Me.pnl_cases.SuspendLayout()
        CType(Me.g_cases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_top
        '
        Me.pnl_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_top.Controls.Add(Me.lbl_fio)
        Me.pnl_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_top.Location = New System.Drawing.Point(0, 0)
        Me.pnl_top.Name = "pnl_top"
        Me.pnl_top.Size = New System.Drawing.Size(673, 36)
        Me.pnl_top.TabIndex = 0
        '
        'lbl_fio
        '
        Me.lbl_fio.AutoSize = True
        Me.lbl_fio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_fio.Location = New System.Drawing.Point(11, 11)
        Me.lbl_fio.Name = "lbl_fio"
        Me.lbl_fio.Size = New System.Drawing.Size(45, 13)
        Me.lbl_fio.TabIndex = 0
        Me.lbl_fio.Text = "Label1"
        '
        'pnl_button
        '
        Me.pnl_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_button.Controls.Add(Me.btn_Exit)
        Me.pnl_button.Controls.Add(Me.btn_NewCase)
        Me.pnl_button.Controls.Add(Me.btn_DelCase)
        Me.pnl_button.Controls.Add(Me.btn_UpdCase)
        Me.pnl_button.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_button.Location = New System.Drawing.Point(0, 382)
        Me.pnl_button.Name = "pnl_button"
        Me.pnl_button.Size = New System.Drawing.Size(673, 44)
        Me.pnl_button.TabIndex = 1
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(342, 10)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(104, 23)
        Me.btn_Exit.TabIndex = 3
        Me.btn_Exit.Text = "Выход"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'btn_NewCase
        '
        Me.btn_NewCase.Location = New System.Drawing.Point(122, 10)
        Me.btn_NewCase.Name = "btn_NewCase"
        Me.btn_NewCase.Size = New System.Drawing.Size(104, 23)
        Me.btn_NewCase.TabIndex = 2
        Me.btn_NewCase.Text = "Новый"
        Me.btn_NewCase.UseVisualStyleBackColor = True
        '
        'btn_DelCase
        '
        Me.btn_DelCase.Location = New System.Drawing.Point(232, 10)
        Me.btn_DelCase.Name = "btn_DelCase"
        Me.btn_DelCase.Size = New System.Drawing.Size(104, 23)
        Me.btn_DelCase.TabIndex = 1
        Me.btn_DelCase.Text = "Удалить"
        Me.btn_DelCase.UseVisualStyleBackColor = True
        '
        'btn_UpdCase
        '
        Me.btn_UpdCase.Location = New System.Drawing.Point(12, 10)
        Me.btn_UpdCase.Name = "btn_UpdCase"
        Me.btn_UpdCase.Size = New System.Drawing.Size(104, 23)
        Me.btn_UpdCase.TabIndex = 0
        Me.btn_UpdCase.Text = "Редактировать"
        Me.btn_UpdCase.UseVisualStyleBackColor = True
        '
        'pnl_cases
        '
        Me.pnl_cases.Controls.Add(Me.g_cases)
        Me.pnl_cases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_cases.Location = New System.Drawing.Point(0, 36)
        Me.pnl_cases.Name = "pnl_cases"
        Me.pnl_cases.Size = New System.Drawing.Size(673, 346)
        Me.pnl_cases.TabIndex = 2
        '
        'g_cases
        '
        Me.g_cases.AllowUserToAddRows = False
        Me.g_cases.AllowUserToDeleteRows = False
        Me.g_cases.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.g_cases.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.g_cases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.g_cases.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.bol_start, Me.bol_end, Me.lechenie, Me.type_diag})
        Me.g_cases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_cases.Location = New System.Drawing.Point(0, 0)
        Me.g_cases.MultiSelect = False
        Me.g_cases.Name = "g_cases"
        Me.g_cases.ReadOnly = True
        Me.g_cases.RowHeadersVisible = False
        Me.g_cases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.g_cases.Size = New System.Drawing.Size(673, 346)
        Me.g_cases.TabIndex = 0
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.id.DataPropertyName = "id"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.id.DefaultCellStyle = DataGridViewCellStyle2
        Me.id.HeaderText = "№"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.id.Width = 24
        '
        'bol_start
        '
        Me.bol_start.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.bol_start.DataPropertyName = "bol_start"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.bol_start.DefaultCellStyle = DataGridViewCellStyle3
        Me.bol_start.HeaderText = "С даты"
        Me.bol_start.Name = "bol_start"
        Me.bol_start.ReadOnly = True
        Me.bol_start.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.bol_start.Width = 48
        '
        'bol_end
        '
        Me.bol_end.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.bol_end.DataPropertyName = "bol_end"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.bol_end.DefaultCellStyle = DataGridViewCellStyle4
        Me.bol_end.HeaderText = "По дату"
        Me.bol_end.Name = "bol_end"
        Me.bol_end.ReadOnly = True
        Me.bol_end.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.bol_end.Width = 52
        '
        'lechenie
        '
        Me.lechenie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.lechenie.DataPropertyName = "lechenie"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.lechenie.DefaultCellStyle = DataGridViewCellStyle5
        Me.lechenie.HeaderText = "Лечение"
        Me.lechenie.Name = "lechenie"
        Me.lechenie.ReadOnly = True
        Me.lechenie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.lechenie.Width = 56
        '
        'type_diag
        '
        Me.type_diag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.type_diag.DataPropertyName = "type_diag"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.type_diag.DefaultCellStyle = DataGridViewCellStyle6
        Me.type_diag.HeaderText = "Тип диагноза"
        Me.type_diag.Name = "type_diag"
        Me.type_diag.ReadOnly = True
        Me.type_diag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'FInsurCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 426)
        Me.Controls.Add(Me.pnl_cases)
        Me.Controls.Add(Me.pnl_button)
        Me.Controls.Add(Me.pnl_top)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FInsurCase"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Страховые случаи"
        Me.pnl_top.ResumeLayout(False)
        Me.pnl_top.PerformLayout()
        Me.pnl_button.ResumeLayout(False)
        Me.pnl_cases.ResumeLayout(False)
        CType(Me.g_cases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl_top As System.Windows.Forms.Panel
    Friend WithEvents pnl_button As System.Windows.Forms.Panel
    Friend WithEvents pnl_cases As System.Windows.Forms.Panel
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
    Friend WithEvents btn_NewCase As System.Windows.Forms.Button
    Friend WithEvents btn_DelCase As System.Windows.Forms.Button
    Friend WithEvents btn_UpdCase As System.Windows.Forms.Button
    Friend WithEvents lbl_fio As System.Windows.Forms.Label
    Friend WithEvents g_cases As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_start As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bol_end As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lechenie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type_diag As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
