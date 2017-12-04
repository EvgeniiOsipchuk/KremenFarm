<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMedikament
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMedikament))
        Me.pnl_top = New System.Windows.Forms.Panel()
        Me.btn_show_med = New System.Windows.Forms.Button()
        Me.g_med = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.medname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolvo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proizvod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_kol = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnl_top.SuspendLayout()
        CType(Me.g_med, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_top
        '
        Me.pnl_top.Controls.Add(Me.btn_show_med)
        Me.pnl_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_top.Location = New System.Drawing.Point(0, 0)
        Me.pnl_top.Name = "pnl_top"
        Me.pnl_top.Size = New System.Drawing.Size(591, 31)
        Me.pnl_top.TabIndex = 0
        '
        'btn_show_med
        '
        Me.btn_show_med.Location = New System.Drawing.Point(3, 3)
        Me.btn_show_med.Name = "btn_show_med"
        Me.btn_show_med.Size = New System.Drawing.Size(75, 23)
        Me.btn_show_med.TabIndex = 2
        Me.btn_show_med.Text = "Показать"
        Me.btn_show_med.UseVisualStyleBackColor = True
        '
        'g_med
        '
        Me.g_med.AllowUserToAddRows = False
        Me.g_med.AllowUserToDeleteRows = False
        Me.g_med.AllowUserToOrderColumns = True
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
        Me.g_med.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.kod, Me.medname, Me.kolvo, Me.proizvod})
        Me.g_med.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_med.Location = New System.Drawing.Point(0, 31)
        Me.g_med.MultiSelect = False
        Me.g_med.Name = "g_med"
        Me.g_med.ReadOnly = True
        Me.g_med.RowHeadersVisible = False
        Me.g_med.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.g_med.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.g_med.Size = New System.Drawing.Size(591, 377)
        Me.g_med.TabIndex = 4
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'kod
        '
        Me.kod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.kod.DataPropertyName = "kod"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.kod.DefaultCellStyle = DataGridViewCellStyle2
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.medname.DefaultCellStyle = DataGridViewCellStyle3
        Me.medname.HeaderText = "Наименование"
        Me.medname.Name = "medname"
        Me.medname.ReadOnly = True
        Me.medname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'kolvo
        '
        Me.kolvo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.kolvo.DataPropertyName = "kolvo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.kolvo.DefaultCellStyle = DataGridViewCellStyle4
        Me.kolvo.HeaderText = "Уп"
        Me.kolvo.Name = "kolvo"
        Me.kolvo.ReadOnly = True
        Me.kolvo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.kolvo.Width = 27
        '
        'proizvod
        '
        Me.proizvod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.proizvod.DataPropertyName = "proizvod"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.proizvod.DefaultCellStyle = DataGridViewCellStyle5
        Me.proizvod.HeaderText = "Производитель"
        Me.proizvod.Name = "proizvod"
        Me.proizvod.ReadOnly = True
        Me.proizvod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.proizvod.Width = 92
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.st_kol})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 384)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(591, 24)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(102, 19)
        Me.ToolStripStatusLabel2.Text = "Найдено записей"
        '
        'st_kol
        '
        Me.st_kol.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.st_kol.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.st_kol.Name = "st_kol"
        Me.st_kol.Size = New System.Drawing.Size(18, 19)
        Me.st_kol.Text = "0"
        '
        'FMedikament
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 408)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.g_med)
        Me.Controls.Add(Me.pnl_top)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FMedikament"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Медикаменты"
        Me.pnl_top.ResumeLayout(False)
        CType(Me.g_med, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl_top As System.Windows.Forms.Panel
    Friend WithEvents g_med As System.Windows.Forms.DataGridView
    Friend WithEvents btn_show_med As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents medname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kolvo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents proizvod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_kol As System.Windows.Forms.ToolStripStatusLabel
End Class
