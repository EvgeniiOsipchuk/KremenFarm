<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FUpdDBF
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenDBF = New System.Windows.Forms.OpenFileDialog()
        Me.spin_god_strax = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_god_strax = New System.Windows.Forms.Label()
        Me.btn_openDBF = New System.Windows.Forms.Button()
        Me.btn_load = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_kol = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_info = New System.Windows.Forms.ToolStripStatusLabel()
        Me.progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.cb_pred = New System.Windows.Forms.ComboBox()
        Me.lbl_path = New System.Windows.Forms.Label()
        CType(Me.spin_god_strax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Импортировать список"
        '
        'OpenDBF
        '
        Me.OpenDBF.FileName = "OpenFileDialog1"
        '
        'spin_god_strax
        '
        Me.spin_god_strax.Location = New System.Drawing.Point(110, 32)
        Me.spin_god_strax.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.spin_god_strax.Minimum = New Decimal(New Integer() {2005, 0, 0, 0})
        Me.spin_god_strax.Name = "spin_god_strax"
        Me.spin_god_strax.Size = New System.Drawing.Size(73, 20)
        Me.spin_god_strax.TabIndex = 31
        Me.spin_god_strax.Value = New Decimal(New Integer() {2005, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Год страхования"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Текущий год страхования"
        '
        'lbl_god_strax
        '
        Me.lbl_god_strax.AutoSize = True
        Me.lbl_god_strax.Location = New System.Drawing.Point(348, 35)
        Me.lbl_god_strax.Name = "lbl_god_strax"
        Me.lbl_god_strax.Size = New System.Drawing.Size(19, 13)
        Me.lbl_god_strax.TabIndex = 34
        Me.lbl_god_strax.Text = "__"
        '
        'btn_openDBF
        '
        Me.btn_openDBF.Location = New System.Drawing.Point(15, 66)
        Me.btn_openDBF.Name = "btn_openDBF"
        Me.btn_openDBF.Size = New System.Drawing.Size(123, 23)
        Me.btn_openDBF.TabIndex = 35
        Me.btn_openDBF.Text = "Выбрать файл"
        Me.btn_openDBF.UseVisualStyleBackColor = True
        '
        'btn_load
        '
        Me.btn_load.Location = New System.Drawing.Point(15, 95)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(123, 23)
        Me.btn_load.TabIndex = 36
        Me.btn_load.Text = "Загрузить"
        Me.btn_load.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.st_kol, Me.st_info, Me.progress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 155)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(424, 24)
        Me.StatusStrip1.TabIndex = 37
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(120, 19)
        Me.ToolStripStatusLabel2.Text = "Количество человек"
        '
        'st_kol
        '
        Me.st_kol.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.st_kol.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.st_kol.Name = "st_kol"
        Me.st_kol.Size = New System.Drawing.Size(18, 19)
        Me.st_kol.Text = "0"
        '
        'st_info
        '
        Me.st_info.Name = "st_info"
        Me.st_info.Size = New System.Drawing.Size(55, 19)
        Me.st_info.Text = "Загрузка"
        '
        'progress
        '
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(90, 18)
        Me.progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'cb_pred
        '
        Me.cb_pred.FormattingEnabled = True
        Me.cb_pred.Items.AddRange(New Object() {"ДМК", "РАКС"})
        Me.cb_pred.Location = New System.Drawing.Point(144, 6)
        Me.cb_pred.Name = "cb_pred"
        Me.cb_pred.Size = New System.Drawing.Size(121, 21)
        Me.cb_pred.TabIndex = 38
        '
        'lbl_path
        '
        Me.lbl_path.AutoSize = True
        Me.lbl_path.Location = New System.Drawing.Point(144, 71)
        Me.lbl_path.Name = "lbl_path"
        Me.lbl_path.Size = New System.Drawing.Size(19, 13)
        Me.lbl_path.TabIndex = 39
        Me.lbl_path.Text = "__"
        '
        'FUpdDBF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 179)
        Me.Controls.Add(Me.lbl_path)
        Me.Controls.Add(Me.cb_pred)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btn_load)
        Me.Controls.Add(Me.btn_openDBF)
        Me.Controls.Add(Me.lbl_god_strax)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.spin_god_strax)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FUpdDBF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "загрузка списков из DBF"
        CType(Me.spin_god_strax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenDBF As System.Windows.Forms.OpenFileDialog
    Friend WithEvents spin_god_strax As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_god_strax As System.Windows.Forms.Label
    Friend WithEvents btn_openDBF As System.Windows.Forms.Button
    Friend WithEvents btn_load As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_kol As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_info As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents progress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents cb_pred As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_path As System.Windows.Forms.Label
End Class
