
Imports System.Data.SqlClient

Public Class FUpdDBF


    Private dt As New DataTable
    Private dogovor As Long
    Private predpr_id As Long

    Private inn As String
    Private fio As String
    Private ceh As String
    Private nazvan As String
    Private tabnum As String
    Private date_birth As DateTime
    Private paspser As String
    Private paspnom As Integer
    Private paspdat As DateTime
    Private kemvidan As String
    Private address As String
    Private telefon As String
    Private rab As String
    Private schet As String
    Private nasled As String
    Private nasladr As String
    Private naslrogd As DateTime
    Private comment As String
    Private date_dog_begin As DateTime
    Private date_dog_end As DateTime
    Private status As Integer
    Private god_strax As Integer




    Private Sub cb_god_strax_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FUpdDBF_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_openDBF_Click(sender As Object, e As EventArgs) Handles btn_openDBF.Click
        Dim ConnectionString As String

        If cb_pred.SelectedIndex = -1 Then
            MessageBox.Show("Выберите предприятие!")
            Exit Sub
        End If

        OpenDBF.FileName = ""
        OpenDBF.Filter = "dbf files (*.dbf)|*.dbf"
        OpenDBF.RestoreDirectory = True


        Dim res As Windows.Forms.DialogResult
        res = OpenDBF.ShowDialog()

        If res = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        If res = Windows.Forms.DialogResult.OK And Trim(OpenDBF.FileName) = "" Then
            MsgBox("Не выбран файл для загрузки")
            Exit Sub
        End If

        lbl_path.Text = OpenDBF.FileName

        Dim myFileInfo As System.IO.FileInfo = New System.IO.FileInfo(OpenDBF.FileName)
        Dim dir As String = myFileInfo.DirectoryName.Trim() & "\"
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & dir & ";Extended Properties=dBase IV"

        Dim dBaseConnection As New System.Data.OleDb.OleDbConnection(ConnectionString)

        btn_openDBF.Text = "Ждите..."
        btn_openDBF.Refresh()

        Try
            dBaseConnection.Open()

            Dim dBaseCommand As New System.Data.OleDb.OleDbCommand("SELECT * FROM " & myFileInfo.Name, dBaseConnection)
            Dim dBaseDataReader As System.Data.OleDb.OleDbDataReader = dBaseCommand.ExecuteReader(CommandBehavior.SequentialAccess)

            dt.Reset()
            dt.Load(dBaseDataReader)
            dBaseConnection.Close()

            btn_openDBF.Text = "Выбрать файл"

            'Этот костыль для того чтобы отсеивать пустые записи, которые последнее время начал пихать в свою базу РАКС
            'т.е. реально в списке 200 человек и еще 50 просто пустых записей
            Dim foundRows() As DataRow = dt.Select("Trim(fio) <> ''")

            st_kol.Text = foundRows.Length  'dt.Rows.Count

        Catch Ex As Exception
            btn_openDBF.Text = "Выбрать файл"
            lbl_path.Text = ""
            dt.Clear()
            dBaseConnection.Close()
            MsgBox("Не удалось открыть файл. Ошибка: " & Ex.Message)
        End Try
    End Sub


    Private Sub cb_pred_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_pred.SelectedIndexChanged
        dt.Clear()
        lbl_path.Text = ""
        If cb_pred.SelectedIndex = 0 Then
            predpr_id = 1 'ДМК
            dogovor = 8
        Else
            predpr_id = 8 'РАКС
            dogovor = 14
        End If
        Dim da As New KrDataSetTableAdapters.dt_god_strax_predprTableAdapter
        Dim dt1 As New KrDataSet.dt_god_strax_predprDataTable
        da.Fill(dt1, predpr_id)
        da.Dispose()
        spin_god_strax.Value = dt1.Rows(0)("god_strax")
        lbl_god_strax.Text = dt1.Rows(0)("god_strax")
    End Sub

    Private Sub btn_load_Click(sender As Object, e As EventArgs) Handles btn_load.Click
        Dim comm_uvol As String = "'УВОЛЕН'"
        Dim comm_rab As String = "''"
        Dim id As Long
        Dim proceed As Integer
        Dim dklients As New DataTable
        Dim foundRows() As DataRow
        If dt.Rows.Count = 0 Then
            MessageBox.Show("Файл импорта не выбран или пуст")
            Exit Sub
        End If
        Dim conn As New SqlConnection(My.Settings.KremenCnStr)
        Dim cmdUvol As New SqlCommand("update klients set comment = " & comm_uvol & " where predpr = " & predpr_id & " and god_strax = " & spin_god_strax.Value.ToString, conn)
        Dim cmdUpd As New SqlCommand("update klients set summa_za = summa_za + 20, summa_tr = summa_tr + 10, comment = " & comm_rab & " where id = @id", conn)
        cmdUpd.Parameters.Add("@id", SqlDbType.BigInt)
        Dim cmdKlients As New SqlCommand("select id, inn from klients where predpr = " & predpr_id & " and god_strax = " + spin_god_strax.Value.ToString, conn)
        conn.Open() 'Соединяемся с sql сервером
        dklients.Load(cmdKlients.ExecuteReader) 'Пихаем в datatable всех клиентов этого предприятия в выбранном страховом году из sql сервера
        cmdUvol.ExecuteNonQuery() 'Увольняем всех работников этого предприятия в выбранном страховом году
        With progress
            .Maximum = dt.Rows.Count
            .Minimum = 0
            .Value = 0
            .Visible = True
        End With
        proceed = 0
        For Each dr As DataRow In dt.Rows
            progress.Value += 1
            Me.Refresh()
            'Если это голимая пустая строка - просто пропускаем ее
            If Trim(dr("fio").ToString) = "" Then
                Continue For
            End If
            proceed += 1
            'У РАКСА у религиозников поле inn = 0, у ДМК заполнено серией и № паспорта
            'ищем в datatable содержащей инфу из sql сервера строку соответствующую строке из DBF 
            If dr("kod").ToString = "0" Then
                foundRows = dklients.Select("inn = '" & dr("paspser").ToString & dr("paspnom").ToString & "'")
            Else
                foundRows = dklients.Select("inn = '" & dr("kod").ToString & "'")
            End If
            If foundRows.Length <> 0 Then
                'Если нашли - обновляем сумму платежа и "восстанавливаем" его в работающие
                id = foundRows(0)("id")
                cmdUpd.Parameters("@id").Value = id
                cmdUpd.ExecuteNonQuery()
            Else
                'Если не нашли - добавляем его как вновь принятого
                inn = dr("kod").ToString
                fio = dr("fio").ToString
                ceh = dr("cex").ToString
                nazvan = dr("nazvan").ToString
                tabnum = dr("tabnom").ToString
                date_birth = IIf(IsDBNull(dr("rogden")), DateTime.Now, dr("rogden"))
                paspser = dr("paspser").ToString
                Try
                    paspnom = IIf(IsDBNull(dr("paspnom")), 0, dr("paspnom").ToString)
                Catch
                    paspnom = 0
                End Try
                kemvidan = dr("kemvidan").ToString
                paspdat = IIf(IsDBNull(dr("paspdat")), DateTime.Now, dr("paspdat").ToString)
                address = dr("adres").ToString
                nasled = dr("nasled").ToString
                nasladr = dr("nasladr").ToString
                naslrogd = IIf(IsDBNull(dr("naslrogd")), DateTime.Now, dr("naslrogd"))
                rab = ""
                comment = ""
                telefon = dr("telefon").ToString
                schet = dr("schet").ToString

                date_dog_begin = New Date(Now.Year, Now.Month, 8)
                date_dog_end = date_dog_begin.AddMonths(1)

                god_strax = spin_god_strax.Value

                cmd.SP_KlientsInsert(inn, fio, ceh, nazvan, tabnum, date_birth, paspser, paspnom, paspdat, kemvidan, address, telefon,
                                     dogovor, rab, schet, nasled, nasladr, naslrogd, comment, 0, 0, 0, 0, date_dog_begin, date_dog_end,
                                     predpr_id, My.User.Name, status, god_strax)
            End If
        Next
        MessageBox.Show("OK " & proceed)
    End Sub

    Private Sub FUpdDBF_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class