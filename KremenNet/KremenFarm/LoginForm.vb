Imports System.IO
Public Class LoginForm

    ' TODO: вставить код для настраиваемой проверки подлинности с использованием переданного имени пользователя и пароля 
    ' (См. http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' Пользовательский принципал можно затем подключить к принципалу потока следующим образом: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' где CustomPrincipal - реализация интерфейса IPrincipal, используемая для аутентификации. 
    ' Впоследствии My.User будет возвращать идентификационную информацию, заключенную в объекте CustomPrincipal,
    ' например, имя пользователя, отображаемое имя и т.д.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim sbb As SqlClient.SqlConnectionStringBuilder
        If Not File.Exists("Setup.ini") Then
            sbb = New SqlClient.SqlConnectionStringBuilder(My.Settings.KremenCnStr)
        Else
            sbb = New SqlClient.SqlConnectionStringBuilder("Data Source=" & My.Computer.Name _
                                                      & "\" & FConnection.ReadIni("DataBase", "DataSource") & ";Initial Catalog=" _ 
                                                      & FConnection.ReadIni("DataBase", "InitialCatalog") & ";User ID=" & Trim(LoginTextBox.Text))
        End If    
        sbb.IntegratedSecurity = False
        sbb.UserID = Trim(LoginTextBox.Text)
        sbb.Password = Trim(PassTextBox.Text)
        My.Settings("KremenCnStr") = sbb.ToString()
        My.Settings.LastUser = Trim(LoginTextBox.Text)
        
        Dim da As New KrDataSetTableAdapters.da_CheckConnection
        Try
            da.Fill(Kremen.CheckConnection)
            Me.Hide()
            FMain.Visible = True
        Catch ex As Exception
            MsgBox("Нет соединения! Проверьте имя и пароль пользователя!")
            LoginTextBox.Focus()
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        FMain.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginTextBox.Text = My.Settings.LastUser
        PassTextBox.Text = ""       
    End Sub

    Private Sub LoginForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FMain.Close()
    End Sub

    Private Sub LoginForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Trim(LoginTextBox.Text) <> "" Then
            PassTextBox.Focus()
        End If
    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        FConnection.ShowDialog()
    End Sub
End Class
