<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FDoctorType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FDoctorType))
        Me.g_type = New System.Windows.Forms.DataGridView()
        Me.doctortype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.g_type, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'g_type
        '
        Me.g_type.AllowUserToAddRows = False
        Me.g_type.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.g_type.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.g_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.g_type.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.doctortype})
        Me.g_type.Location = New System.Drawing.Point(4, 3)
        Me.g_type.Name = "g_type"
        Me.g_type.ReadOnly = True
        Me.g_type.RowHeadersVisible = False
        Me.g_type.Size = New System.Drawing.Size(441, 227)
        Me.g_type.TabIndex = 0
        '
        'doctortype
        '
        Me.doctortype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.doctortype.DataPropertyName = "doctortype"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.doctortype.DefaultCellStyle = DataGridViewCellStyle2
        Me.doctortype.HeaderText = "Специальность"
        Me.doctortype.Name = "doctortype"
        Me.doctortype.ReadOnly = True
        '
        'FDoctorType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 235)
        Me.Controls.Add(Me.g_type)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FDoctorType"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Специальности врачей"
        CType(Me.g_type, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents g_type As System.Windows.Forms.DataGridView
    Friend WithEvents doctortype As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
