<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FVidachaDelit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FVidachaDelit))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_medname = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.edt_delit = New System.Windows.Forms.TextBox()
        Me.btn_prover = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_ostorig = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_newtovar = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.btn_delit = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Лекарственное средство"
        '
        'lbl_medname
        '
        Me.lbl_medname.AutoSize = True
        Me.lbl_medname.Location = New System.Drawing.Point(149, 10)
        Me.lbl_medname.Name = "lbl_medname"
        Me.lbl_medname.Size = New System.Drawing.Size(39, 13)
        Me.lbl_medname.TabIndex = 1
        Me.lbl_medname.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "На сколько частей делить"
        '
        'edt_delit
        '
        Me.edt_delit.Location = New System.Drawing.Point(157, 35)
        Me.edt_delit.Name = "edt_delit"
        Me.edt_delit.Size = New System.Drawing.Size(100, 20)
        Me.edt_delit.TabIndex = 3
        '
        'btn_prover
        '
        Me.btn_prover.Location = New System.Drawing.Point(18, 65)
        Me.btn_prover.Name = "btn_prover"
        Me.btn_prover.Size = New System.Drawing.Size(75, 23)
        Me.btn_prover.TabIndex = 4
        Me.btn_prover.Text = "Проверить"
        Me.btn_prover.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Осталось оригинального товара"
        '
        'lbl_ostorig
        '
        Me.lbl_ostorig.AutoSize = True
        Me.lbl_ostorig.Location = New System.Drawing.Point(189, 100)
        Me.lbl_ostorig.Name = "lbl_ostorig"
        Me.lbl_ostorig.Size = New System.Drawing.Size(39, 13)
        Me.lbl_ostorig.TabIndex = 6
        Me.lbl_ostorig.Text = "Label2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Новый товар"
        '
        'lbl_newtovar
        '
        Me.lbl_newtovar.AutoSize = True
        Me.lbl_newtovar.Location = New System.Drawing.Point(90, 122)
        Me.lbl_newtovar.Name = "lbl_newtovar"
        Me.lbl_newtovar.Size = New System.Drawing.Size(39, 13)
        Me.lbl_newtovar.TabIndex = 8
        Me.lbl_newtovar.Text = "Label2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(153, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "по цене"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(218, 122)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(39, 13)
        Me.lbl_price.TabIndex = 10
        Me.lbl_price.Text = "Label2"
        '
        'btn_delit
        '
        Me.btn_delit.Location = New System.Drawing.Point(108, 158)
        Me.btn_delit.Name = "btn_delit"
        Me.btn_delit.Size = New System.Drawing.Size(75, 23)
        Me.btn_delit.TabIndex = 11
        Me.btn_delit.Text = "Делить"
        Me.btn_delit.UseVisualStyleBackColor = True
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(245, 157)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(75, 23)
        Me.btn_Close.TabIndex = 12
        Me.btn_Close.Text = "Выход"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'FVidachaDelit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 197)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.btn_delit)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_newtovar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_ostorig)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_prover)
        Me.Controls.Add(Me.edt_delit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_medname)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FVidachaDelit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Деление лекарственного средства"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_medname As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents edt_delit As System.Windows.Forms.TextBox
    Friend WithEvents btn_prover As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_ostorig As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_newtovar As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_price As System.Windows.Forms.Label
    Friend WithEvents btn_delit As System.Windows.Forms.Button
    Friend WithEvents btn_Close As System.Windows.Forms.Button
End Class
