Imports System.IO
Public Class FConnection
     Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Sub FConnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       FConnPass.ShowDialog()
      '  MessageBox.Show(My.Application.Info.DirectoryPath)
       TextBox1.Text = ReadIni("Path", "Path1")
       TextBox2.Text = ReadIni("Path", "Path2")
       TextBox3.Text = ReadIni("Path", "Path3")
       TextBox4.Text = ReadIni("DataBase", "DataSource")
       TextBox5.Text = ReadIni("DataBase", "InitialCatalog")
       Label3.Text = My.Computer.Name & "\" & TextBox4.Text
    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Choose_dir(TextBox1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Choose_dir(TextBox2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Choose_dir(TextBox3)
    End Sub

    Private Sub Choose_dir(box_ As TextBox)
        FolderBrowserDialog1.Reset()
        If box_.Text.Length > 0 Then
            FolderBrowserDialog1.SelectedPath = box_.Text
        End If
        FolderBrowserDialog1.ShowNewFolderButton = True
        FolderBrowserDialog1.ShowDialog()
        box_.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WriteIni("Path", "Path1", TextBox1.Text)
        WriteIni("Path", "Path2", TextBox2.Text)
        WriteIni("Path", "Path3", TextBox3.Text)
        WriteIni("DataBase", "DataSource", TextBox4.Text)
        WriteIni("DataBase", "InitialCatalog", TextBox5.Text)
    End Sub
    
    Public Function ReadIni(ByVal Section As String, ByVal Param As String) As String
        Try
            Dim rc As String = Strings.StrDup(255, vbNullChar)
            Dim x As Integer
            x = GetPrivateProfileString(Section, Param, "", rc, 255, My.Application.Info.DirectoryPath & "\Setup.ini")
            If x <> 0 Then rc = Strings.Left(rc, x)
            ReadIni = rc
        Catch ex As Exception
            MsgBox("Reed ini...ERROR " & ex.Message)
            Return ""
        End Try
    End Function

    Public Sub WriteIni(ByVal Section As String, ByVal Obj As String, ByVal Param As String)
        Call WritePrivateProfileString(Section, Obj, Param, My.Application.Info.DirectoryPath & "\Setup.ini")
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Label3.Text = My.Computer.Name & "\" & TextBox4.Text
    End Sub
    
End Class