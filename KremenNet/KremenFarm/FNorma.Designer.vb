<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FNorma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FNorma))
        Me.OpenNorma = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btn_openNorma = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btn_importNorma = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_sum = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_kol = New System.Windows.Forms.ToolStripStatusLabel()
        Me.st_info = New System.Windows.Forms.ToolStripStatusLabel()
        Me.progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.Btn_close = New System.Windows.Forms.Button()
        Me.cb_Apteka = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenNorma
        '
        Me.OpenNorma.FileName = "OpenFileDialog1"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'btn_openNorma
        '
        Me.btn_openNorma.Location = New System.Drawing.Point(12, 9)
        Me.btn_openNorma.Name = "btn_openNorma"
        Me.btn_openNorma.Size = New System.Drawing.Size(181, 23)
        Me.btn_openNorma.TabIndex = 1
        Me.btn_openNorma.Text = "Открыть файл накладной"
        Me.btn_openNorma.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(574, 170)
        Me.DataGridView1.TabIndex = 2
        '
        'Btn_importNorma
        '
        Me.Btn_importNorma.Location = New System.Drawing.Point(63, 231)
        Me.Btn_importNorma.Name = "Btn_importNorma"
        Me.Btn_importNorma.Size = New System.Drawing.Size(119, 23)
        Me.Btn_importNorma.TabIndex = 3
        Me.Btn_importNorma.Text = "Ввести накладную"
        Me.Btn_importNorma.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.st_sum, Me.ToolStripStatusLabel2, Me.st_kol, Me.st_info, Me.progress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 270)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(598, 24)
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(124, 19)
        Me.ToolStripStatusLabel1.Text = "Сумма по накладной"
        '
        'st_sum
        '
        Me.st_sum.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.st_sum.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.st_sum.Name = "st_sum"
        Me.st_sum.Size = New System.Drawing.Size(18, 19)
        Me.st_sum.Text = "0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(102, 19)
        Me.ToolStripStatusLabel2.Text = "Строк накладной"
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
        'Btn_close
        '
        Me.Btn_close.Location = New System.Drawing.Point(402, 231)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(119, 23)
        Me.Btn_close.TabIndex = 19
        Me.Btn_close.Text = "Выход"
        Me.Btn_close.UseVisualStyleBackColor = True
        '
        'cb_Apteka
        '
        Me.cb_Apteka.DisplayMember = "apteka_name"
        Me.cb_Apteka.FormattingEnabled = True
        Me.cb_Apteka.Location = New System.Drawing.Point(223, 11)
        Me.cb_Apteka.Name = "cb_Apteka"
        Me.cb_Apteka.Size = New System.Drawing.Size(121, 21)
        Me.cb_Apteka.TabIndex = 20
        Me.cb_Apteka.ValueMember = "id"
        '
        'FNorma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 294)
        Me.Controls.Add(Me.cb_Apteka)
        Me.Controls.Add(Me.Btn_close)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Btn_importNorma)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_openNorma)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FNorma"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Загрузить накладную аптеки"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenNorma As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btn_openNorma As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_importNorma As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents st_info As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents progress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_sum As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents st_kol As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents cb_Apteka As System.Windows.Forms.ComboBox
End Class
