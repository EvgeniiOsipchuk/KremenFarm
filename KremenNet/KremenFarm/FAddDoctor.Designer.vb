<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAddDoctor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FAddDoctor))
        Me.btn_add_doctor = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.edt_last_name = New System.Windows.Forms.TextBox()
        Me.edt_first_name = New System.Windows.Forms.TextBox()
        Me.edt_sekond_name = New System.Windows.Forms.TextBox()
        Me.cb_doctortype = New System.Windows.Forms.ComboBox()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_add_doctor
        '
        Me.btn_add_doctor.Location = New System.Drawing.Point(82, 138)
        Me.btn_add_doctor.Name = "btn_add_doctor"
        Me.btn_add_doctor.Size = New System.Drawing.Size(75, 23)
        Me.btn_add_doctor.TabIndex = 1
        Me.btn_add_doctor.Text = "Добавить"
        Me.btn_add_doctor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Фамилия"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Имя"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Отчество"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Специальность"
        '
        'edt_last_name
        '
        Me.edt_last_name.Location = New System.Drawing.Point(104, 10)
        Me.edt_last_name.Name = "edt_last_name"
        Me.edt_last_name.Size = New System.Drawing.Size(261, 20)
        Me.edt_last_name.TabIndex = 6
        '
        'edt_first_name
        '
        Me.edt_first_name.Location = New System.Drawing.Point(104, 37)
        Me.edt_first_name.Name = "edt_first_name"
        Me.edt_first_name.Size = New System.Drawing.Size(261, 20)
        Me.edt_first_name.TabIndex = 7
        '
        'edt_sekond_name
        '
        Me.edt_sekond_name.Location = New System.Drawing.Point(104, 66)
        Me.edt_sekond_name.Name = "edt_sekond_name"
        Me.edt_sekond_name.Size = New System.Drawing.Size(261, 20)
        Me.edt_sekond_name.TabIndex = 8
        '
        'cb_doctortype
        '
        Me.cb_doctortype.DisplayMember = "doctortype"
        Me.cb_doctortype.FormattingEnabled = True
        Me.cb_doctortype.Location = New System.Drawing.Point(104, 96)
        Me.cb_doctortype.Name = "cb_doctortype"
        Me.cb_doctortype.Size = New System.Drawing.Size(261, 21)
        Me.cb_doctortype.TabIndex = 9
        Me.cb_doctortype.ValueMember = "id"
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(217, 138)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 23)
        Me.btn_Close.TabIndex = 10
        Me.btn_Close.Text = "Выход"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'FAddDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 173)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.cb_doctortype)
        Me.Controls.Add(Me.edt_sekond_name)
        Me.Controls.Add(Me.edt_first_name)
        Me.Controls.Add(Me.edt_last_name)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_add_doctor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FAddDoctor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Добавить врача"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_add_doctor As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents edt_last_name As System.Windows.Forms.TextBox
    Friend WithEvents edt_first_name As System.Windows.Forms.TextBox
    Friend WithEvents edt_sekond_name As System.Windows.Forms.TextBox
    Friend WithEvents cb_doctortype As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Close As System.Windows.Forms.Button
End Class
