Public Class FNorma

    Private dt As New DataTable
    Private sumObject As Object
    Private price_nakl As Decimal = 0
    Dim dc As New DataColumn("nakl_price")
    Dim dp As New DataColumn("total_price")

    Private Sub btn_openNorma_Click(sender As Object, e As EventArgs) Handles btn_openNorma.Click
        Dim ConnectionString As String

        OpenNorma.FileName = ""
        OpenNorma.Filter = "dbf files (*.dbf)|*.dbf"
        OpenNorma.RestoreDirectory = True


        Dim res As Windows.Forms.DialogResult
        res = OpenNorma.ShowDialog()

        If res = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        If res = Windows.Forms.DialogResult.OK And Trim(OpenNorma.FileName) = "" Then
            MsgBox("Не выбран файл для загрузки")
            Exit Sub
        End If

        Dim myFileInfo As System.IO.FileInfo = New System.IO.FileInfo(OpenNorma.FileName)
        Dim dir As String = myFileInfo.DirectoryName.Trim() & "\"
        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & dir & ";Extended Properties=dBase IV"
        Dim dBaseConnection As New System.Data.OleDb.OleDbConnection(ConnectionString)

        btn_openNorma.Text = "Ждите..."
        btn_openNorma.Refresh()

        Try
            dBaseConnection.Open()

            Dim dBaseCommand As New System.Data.OleDb.OleDbCommand("SELECT * FROM " & myFileInfo.Name, dBaseConnection)
            Dim dBaseDataReader As System.Data.OleDb.OleDbDataReader = dBaseCommand.ExecuteReader(CommandBehavior.SequentialAccess)

            dt.Clear()
            dt.Load(dBaseDataReader)
            dBaseConnection.Close()

            If dt.Columns.Contains(dp.ColumnName) Then
                dt.Columns.Remove(dp)
            End If
            If dt.Columns.Contains(dc.ColumnName) Then
                dt.Columns.Remove(dc)
            End If

            dt.Columns.Add(dc)
            dt.Columns.Add(dp)
            
            Try
                sumObject = Math.Round(dt.Compute("Sum(nakl_price)", ""), 2)
                price_nakl = sumObject
            Catch
                sumObject = Nothing
                price_nakl = 0
            End Try
            btn_openNorma.Text = "Открыть файл накладной"
            st_sum.Text = Format(price_nakl, "# ##0.00")
            st_kol.Text = dt.Rows.Count
        Catch Ex As Exception
            btn_openNorma.Text = "Открыть файл накладной"
            dt.Clear()
            dBaseConnection.Close()
            MsgBox("Не удалось открыть файл. Ошибка: " & Ex.Message)
        End Try
    End Sub

    Private Sub FNorma_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        dt.Clear()
        Me.Dispose()
    End Sub

    
    Private Sub Btn_importNorma_Click(sender As Object, e As EventArgs) Handles Btn_importNorma.Click

        If Not dt.Rows.Count > 0 Then
            MsgBox("Файл накладной пустой")
            Exit Sub
        End If

        Dim da As New KrDataSetTableAdapters.dt_CheckNaklTableAdapter
        Dim md_term As Date

        Btn_importNorma.Text = "Ждите..."
        Btn_importNorma.Refresh()

        da.Fill(Kremen.dt_CheckNakl, dt.Rows(0).Item("n_doc").ToString, cb_Apteka.SelectedValue)
        da.Dispose()
        If Kremen.dt_CheckNakl(0).kolvo <> 0 Then
            Btn_importNorma.Text = "Ввести накладную"
            MsgBox("Накладная № " & dt.Rows(0).Item("n_doc").ToString & " аптеки " & cb_Apteka.Text & " уже загружена!")
            Exit Sub
        End If
        st_info.Visible = True

        With progress
            .Maximum = dt.Rows.Count
            .Minimum = 0
            .Value = 0
            .Visible = True
        End With

        For Each dr As DataRow In dt.Rows
            If IsDBNull(dr.Item("md_term")) Then
                md_term = Now
            Else
                md_term = dr.Item("md_term")
            End If
            progress.Value += 1
            cmd.AptekaFromFile(dr.Item("Goods_kod").ToString,
                               dr.Item("Goods_name").ToString,
                               CType(dr.Item("Cnt_w"), Integer),
                               CType(dr.Item("gds_pr_u"), Decimal),
                               dr.Item("Prod_name").ToString,
                               md_term,
                               dr.Item("series").ToString,
                               CType(dr.Item("Gds_nds_u"), Decimal),
                               CType(dr.Item("Gds_pr_u"), Decimal),
                               dr.Item("n_doc").ToString, "Уп.",
                               CType(dr.Item("Cnt_w"), Integer),
                               Now,
                               cb_Apteka.SelectedValue) '

        Next
        st_info.Visible = False
        progress.Visible = False
        Btn_importNorma.Text = "Ввести накладную"
        MsgBox("Накладная загружена")
    End Sub

    Private Sub FNorma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        st_info.Visible = False
        progress.Visible = False
        DataGridView1.DataSource = dt.DefaultView
       
        With dp 'total_price
            .Expression = "gds_pr_u"
            .DataType = System.Type.GetType("System.Decimal")
        End With

        With dc 'price_nakl
            .Expression = "prt_pr_u"
            .DataType = System.Type.GetType("System.Decimal")
        End With
        Globals.GetApteki()
        Kremen.dt_Apteki.DefaultView.Sort = "id DESC"
        cb_Apteka.DataSource = Kremen.dt_Apteki


    End Sub

    Private Sub Btn_close_Click(sender As Object, e As EventArgs) Handles Btn_close.Click
        Me.Close()
    End Sub
End Class