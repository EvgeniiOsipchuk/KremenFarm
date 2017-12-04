Imports System.Data.SqlClient

Public Class FKlients

    Private Sub find_kient()
        If Trim(edt_find.Text) = "" Then
            Exit Sub
        End If
        Dim da_klients As New KrDataSetTableAdapters.SP_KlientsTableAdapter
        Dim f As Integer
        If cb_find.SelectedIndex = 1 Then
            f = 1
        Else
            f = 0
        End If
        btn_find.Text = "Ждите..."
        btn_find.Refresh()

        g_klients.AutoGenerateColumns = False
        da_klients.Fill(Kremen.SP_Klients, f, (Trim(edt_find.Text) & "%"))
        da_klients.Dispose()
        btn_find.Text = "Поиск"
        If Not Kremen.SP_Klients.Rows.Count > 0 Then
            lbl_find.Visible = True
        Else
            lbl_find.Visible = False
        End If
    End Sub

    Private Sub ShowCases()
        If Not Kremen.SP_Klients.Rows.Count > 0 Then
            Exit Sub
        End If
        Me.SuspendLayout()
        Dim sel_idx As Integer = g_klients.CurrentRow.Index
        FInsurCase.ShowDialog()
        find_kient()
        g_klients.Rows(sel_idx).Selected = True
        g_klients.CurrentCell = g_klients.Rows(sel_idx).Cells(0)
        st_label_fakt.Text = Globals.Get_ost
        Me.ResumeLayout()
    End Sub

    Private Sub btn_find_Click(sender As Object, e As EventArgs) Handles btn_find.Click
        find_kient()
    End Sub

    Private Sub FKlients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g_klients.AutoGenerateColumns = False
        g_klients.DataSource = Kremen.SP_Klients
        lbl_Adress.DataBindings.Add("text", Kremen.SP_Klients, "address")
        lbl_Ceh.DataBindings.Add("text", Kremen.SP_Klients, "ceh")
        lbl_id.DataBindings.Add("text", Kremen.SP_Klients, "id")
        cb_find.SelectedIndex = 1
        st_label_fakt.Text = "0"
    End Sub

    Private Sub FKlients_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        edt_find.Focus()
    End Sub


    Private Sub Btn_UvolKlient_Click(sender As Object, e As EventArgs) Handles Btn_UvolKlient.Click
        If Not Kremen.SP_Klients.Rows.Count > 0 Then
            Exit Sub
        End If
        cmd.UvolKlient("УВОЛЕН", Globals.ColValueByCurRow(g_klients, "id"))
        find_kient()
    End Sub

    Private Sub btn_Strax_Click(sender As Object, e As EventArgs) Handles btn_Strax.Click
        ShowCases()
    End Sub

    Private Sub edt_find_KeyPress(sender As Object, e As KeyPressEventArgs) Handles edt_find.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            find_kient()
        End If
    End Sub

    Private Sub g_klients_DoubleClick(sender As Object, e As EventArgs) Handles g_klients.DoubleClick
        ShowCases()
    End Sub

    Private Sub btn_Analiz_Click(sender As Object, e As EventArgs) Handles btn_Analiz.Click
        'MsgBox(SummaPropis.ProcM3_SummaProp("12356,56"))
        If Not Kremen.SP_Klients.Rows.Count > 0 Then
            Exit Sub
        End If
        FAnalizKlient.ShowDialog()
    End Sub

    Private Sub g_klients_SelectionChanged(sender As Object, e As EventArgs) Handles g_klients.SelectionChanged
        st_label_fakt.Text = Globals.Get_ost
    End Sub

    Private Sub FKlients_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Kremen.SP_Klients.Clear()
        Me.Dispose()
    End Sub

    Private Sub btn_AddKlient_Click(sender As Object, e As EventArgs) Handles btn_AddKlient.Click
        FKlientKard.Mode = FKlientKard.e_mode.NEW_KLIENT
        FKlientKard.ShowDialog()
    End Sub

    Private Sub Btn_UpdKlient_Click(sender As Object, e As EventArgs) Handles Btn_UpdKlient.Click
        If Not Kremen.SP_Klients.Rows.Count > 0 Then
            Exit Sub
        End If
        Me.SuspendLayout()
        Dim sel_idx As Integer = g_klients.CurrentRow.Index

        FKlientKard.Mode = FKlientKard.e_mode.UPDATE_KLIENT
        FKlientKard.ShowDialog()
        find_kient()
        g_klients.Rows(sel_idx).Selected = True
        g_klients.CurrentCell = g_klients.Rows(sel_idx).Cells(0)
        Me.ResumeLayout()
    End Sub

    Private Sub Btn_Spis_Click(sender As Object, e As EventArgs) Handles Btn_Spis.Click
        FSpisPred.ShowDialog()
    End Sub


End Class
