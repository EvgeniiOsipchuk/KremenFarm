<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMedOst
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.st_info = New System.Windows.Forms.ToolStripStatusLabel()
        Me.progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.btn_ost = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.cb_Apteka = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_info, Me.progress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 113)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(299, 22)
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'st_info
        '
        Me.st_info.Name = "st_info"
        Me.st_info.Size = New System.Drawing.Size(137, 17)
        Me.st_info.Text = "Формируется документ"
        '
        'progress
        '
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(100, 16)
        Me.progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'btn_ost
        '
        Me.btn_ost.Location = New System.Drawing.Point(12, 65)
        Me.btn_ost.Name = "btn_ost"
        Me.btn_ost.Size = New System.Drawing.Size(113, 23)
        Me.btn_ost.TabIndex = 19
        Me.btn_ost.Text = "Сформировать"
        Me.btn_ost.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Сформировать остатки медикаментов?"
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(154, 65)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(113, 23)
        Me.btn_close.TabIndex = 21
        Me.btn_close.Text = "Закрыть"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'cb_Apteka
        '
        Me.cb_Apteka.DisplayMember = "apteka_name"
        Me.cb_Apteka.FormattingEnabled = True
        Me.cb_Apteka.Location = New System.Drawing.Point(87, 29)
        Me.cb_Apteka.Name = "cb_Apteka"
        Me.cb_Apteka.Size = New System.Drawing.Size(121, 21)
        Me.cb_Apteka.TabIndex = 22
        Me.cb_Apteka.ValueMember = "id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Аптека"
        '
        'FMedOst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 135)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cb_Apteka)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_ost)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FMedOst"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Остатки медикаметов"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents st_info As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents progress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents btn_ost As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents cb_Apteka As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
