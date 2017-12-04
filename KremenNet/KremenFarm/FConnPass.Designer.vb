<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FConnPass
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
        Me.TxtBx_ConnPass = New System.Windows.Forms.TextBox()
        Me.Btn_connPass = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'TxtBx_ConnPass
        '
        Me.TxtBx_ConnPass.Location = New System.Drawing.Point(12, 12)
        Me.TxtBx_ConnPass.Name = "TxtBx_ConnPass"
        Me.TxtBx_ConnPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtBx_ConnPass.Size = New System.Drawing.Size(125, 20)
        Me.TxtBx_ConnPass.TabIndex = 0
        Me.TxtBx_ConnPass.UseSystemPasswordChar = true
        '
        'Btn_connPass
        '
        Me.Btn_connPass.Location = New System.Drawing.Point(143, 10)
        Me.Btn_connPass.Name = "Btn_connPass"
        Me.Btn_connPass.Size = New System.Drawing.Size(75, 23)
        Me.Btn_connPass.TabIndex = 1
        Me.Btn_connPass.Text = "Check!"
        Me.Btn_connPass.UseVisualStyleBackColor = true
        '
        'FConnPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 43)
        Me.Controls.Add(Me.Btn_connPass)
        Me.Controls.Add(Me.TxtBx_ConnPass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FConnPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FConnPass"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents TxtBx_ConnPass As TextBox
    Friend WithEvents Btn_connPass As Button
End Class
