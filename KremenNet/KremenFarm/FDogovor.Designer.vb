<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FDogovor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FDogovor))
        Me.g_dogovor = New System.Windows.Forms.DataGridView()
        Me.num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_dog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.predpr_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.g_dogovor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'g_dogovor
        '
        Me.g_dogovor.AllowUserToAddRows = False
        Me.g_dogovor.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.g_dogovor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.g_dogovor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.g_dogovor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num, Me.date_dog, Me.predpr_name})
        Me.g_dogovor.Location = New System.Drawing.Point(4, 3)
        Me.g_dogovor.Name = "g_dogovor"
        Me.g_dogovor.ReadOnly = True
        Me.g_dogovor.RowHeadersVisible = False
        Me.g_dogovor.Size = New System.Drawing.Size(441, 227)
        Me.g_dogovor.TabIndex = 0
        '
        'num
        '
        Me.num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.num.DataPropertyName = "num"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.num.DefaultCellStyle = DataGridViewCellStyle2
        Me.num.HeaderText = "№ договора"
        Me.num.Name = "num"
        Me.num.ReadOnly = True
        Me.num.Width = 86
        '
        'date_dog
        '
        Me.date_dog.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.date_dog.DataPropertyName = "date_dog"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.date_dog.DefaultCellStyle = DataGridViewCellStyle3
        Me.date_dog.HeaderText = "Дата заключения"
        Me.date_dog.Name = "date_dog"
        Me.date_dog.ReadOnly = True
        Me.date_dog.Width = 112
        '
        'predpr_name
        '
        Me.predpr_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.predpr_name.DataPropertyName = "predpr_name"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.predpr_name.DefaultCellStyle = DataGridViewCellStyle4
        Me.predpr_name.HeaderText = "Предприятие"
        Me.predpr_name.Name = "predpr_name"
        Me.predpr_name.ReadOnly = True
        Me.predpr_name.Width = 99
        '
        'FDogovor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 235)
        Me.Controls.Add(Me.g_dogovor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FDogovor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Договора"
        CType(Me.g_dogovor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents g_dogovor As System.Windows.Forms.DataGridView
    Friend WithEvents num As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_dog As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents predpr_name As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
