﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRepVostok
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
        Me.gb_period = New System.Windows.Forms.GroupBox()
        Me.dt_end = New System.Windows.Forms.DateTimePicker()
        Me.dt_start = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_form = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.st_info = New System.Windows.Forms.ToolStripStatusLabel()
        Me.progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.gb_period.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_period
        '
        Me.gb_period.Controls.Add(Me.dt_end)
        Me.gb_period.Controls.Add(Me.dt_start)
        Me.gb_period.Controls.Add(Me.Label3)
        Me.gb_period.Controls.Add(Me.Label2)
        Me.gb_period.Location = New System.Drawing.Point(7, 9)
        Me.gb_period.Name = "gb_period"
        Me.gb_period.Size = New System.Drawing.Size(263, 51)
        Me.gb_period.TabIndex = 0
        Me.gb_period.TabStop = False
        Me.gb_period.Text = "Период"
        '
        'dt_end
        '
        Me.dt_end.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_end.Location = New System.Drawing.Point(149, 19)
        Me.dt_end.Name = "dt_end"
        Me.dt_end.Size = New System.Drawing.Size(89, 20)
        Me.dt_end.TabIndex = 9
        '
        'dt_start
        '
        Me.dt_start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_start.Location = New System.Drawing.Point(37, 19)
        Me.dt_start.Name = "dt_start"
        Me.dt_start.Size = New System.Drawing.Size(89, 20)
        Me.dt_start.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(128, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "по"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "с"
        '
        'btn_form
        '
        Me.btn_form.Location = New System.Drawing.Point(34, 88)
        Me.btn_form.Name = "btn_form"
        Me.btn_form.Size = New System.Drawing.Size(93, 23)
        Me.btn_form.TabIndex = 18
        Me.btn_form.Text = "Сформировать"
        Me.btn_form.UseVisualStyleBackColor = True
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(156, 88)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(93, 23)
        Me.btn_Close.TabIndex = 19
        Me.btn_Close.Text = "Выход"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.st_info, Me.progress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 136)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(291, 22)
        Me.StatusStrip1.TabIndex = 20
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
        'FRepVostok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 158)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.btn_form)
        Me.Controls.Add(Me.gb_period)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FRepVostok"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Пофамильно для Востока"
        Me.gb_period.ResumeLayout(False)
        Me.gb_period.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb_period As System.Windows.Forms.GroupBox
    Friend WithEvents dt_end As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_start As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_form As System.Windows.Forms.Button
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents st_info As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents progress As System.Windows.Forms.ToolStripProgressBar
End Class
