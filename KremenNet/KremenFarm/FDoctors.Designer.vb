<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FDoctors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FDoctors))
        Me.g_doctors = New System.Windows.Forms.DataGridView()
        Me.doc_fio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.doctortype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_add_doctor = New System.Windows.Forms.Button()
        CType(Me.g_doctors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'g_doctors
        '
        Me.g_doctors.AllowUserToAddRows = False
        Me.g_doctors.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.g_doctors.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.g_doctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.g_doctors.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.doc_fio, Me.doctortype})
        Me.g_doctors.Location = New System.Drawing.Point(4, 3)
        Me.g_doctors.Name = "g_doctors"
        Me.g_doctors.ReadOnly = True
        Me.g_doctors.RowHeadersVisible = False
        Me.g_doctors.Size = New System.Drawing.Size(483, 227)
        Me.g_doctors.TabIndex = 0
        '
        'doc_fio
        '
        Me.doc_fio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.doc_fio.DataPropertyName = "doc_fio"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.doc_fio.DefaultCellStyle = DataGridViewCellStyle2
        Me.doc_fio.HeaderText = "Фамилия"
        Me.doc_fio.Name = "doc_fio"
        Me.doc_fio.ReadOnly = True
        '
        'doctortype
        '
        Me.doctortype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.doctortype.DataPropertyName = "doctortype"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.doctortype.DefaultCellStyle = DataGridViewCellStyle3
        Me.doctortype.HeaderText = "Специальность"
        Me.doctortype.Name = "doctortype"
        Me.doctortype.ReadOnly = True
        Me.doctortype.Width = 110
        '
        'btn_add_doctor
        '
        Me.btn_add_doctor.Location = New System.Drawing.Point(4, 236)
        Me.btn_add_doctor.Name = "btn_add_doctor"
        Me.btn_add_doctor.Size = New System.Drawing.Size(75, 23)
        Me.btn_add_doctor.TabIndex = 1
        Me.btn_add_doctor.Text = "Добавить"
        Me.btn_add_doctor.UseVisualStyleBackColor = True
        '
        'FDoctors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 265)
        Me.Controls.Add(Me.btn_add_doctor)
        Me.Controls.Add(Me.g_doctors)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FDoctors"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Врачи"
        CType(Me.g_doctors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents g_doctors As System.Windows.Forms.DataGridView
    Friend WithEvents btn_add_doctor As System.Windows.Forms.Button
    Friend WithEvents doc_fio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents doctortype As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
