Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Text

Module Globals
    Public con As New SqlConnection
    Public gl_insurcase_id As Integer
    Public Kremen As KrDataSet = New KrDataSet
    Public cmd As KrDataSetTableAdapters.QueriesTableAdapter = New KrDataSetTableAdapters.QueriesTableAdapter()

    Enum type_case
        NEW_CASE = 1
        EDIT_CASE = 2
    End Enum

    Public mode As type_case

    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String, _
            ByVal lpKeyName As String, _
            ByVal lpDefault As String, _
            ByVal lpReturnedString As StringBuilder, _
            ByVal nSize As Integer, _
            ByVal lpFileName As String) As Integer

    Public Function ReadIniParam(ByVal Section As String,
                                  ByVal Key As String,
                                  ByVal fFileName As String,
                                  Optional ByVal DefaultValue As String = vbNullString) As String
        Dim res As Integer
        Dim sb As StringBuilder

        sb = New StringBuilder(500)
        res = GetPrivateProfileString(Section, Key, DefaultValue, sb, sb.Capacity, fFileName)
        If res > 0 Then
            ReadIniParam = sb.ToString()
        Else
            ReadIniParam = DefaultValue
        End If
    End Function

    Public Sub GetLpu()

        Dim da As New KrDataSetTableAdapters.dt_lpuTableAdapter
        da.Fill(Kremen.dt_lpu)
        da.Dispose()

        Dim drNewRow As DataRow = Kremen.dt_lpu.NewRow
        drNewRow.Item("id") = 0
        drNewRow("lpu") = ""
        Kremen.dt_lpu.Rows.InsertAt(drNewRow, 0)

    End Sub

    Public Sub GetApteki()

        Dim da As New KrDataSetTableAdapters.dt_AptekiTableAdapter

        da.Fill(Kremen.dt_Apteki)
        da.Dispose()

    End Sub
   
    Public Sub GetDoctors()

        Dim da As New KrDataSetTableAdapters.dt_doctorsTableAdapter
        da.Fill(Kremen.dt_doctors)
        da.Dispose()

        Dim drNewRow As DataRow = Kremen.dt_doctors.NewRow
        drNewRow("id") = 0
        drNewRow("doctor") = ""
        drNewRow("doctortype") = 0

        Kremen.dt_doctors.Rows.InsertAt(drNewRow, 0)


    End Sub


    Public Sub GetOtdel()
        Dim da As New KrDataSetTableAdapters.dt_otdelTableAdapter
        da.Fill(Kremen.dt_otdel)
        da.Dispose()


        Dim drNewRow As DataRow = Kremen.dt_otdel.NewRow
        drNewRow("id") = 0
        drNewRow("otdel") = ""
        Kremen.dt_otdel.Rows.InsertAt(drNewRow, 0)


    End Sub

   

    Public Sub GetDiag(ByVal id As String)
        Dim da As New KrDataSetTableAdapters.dt_diagTableAdapter
        da.Fill(Kremen.dt_diag, id)
        da.Dispose()


        If Not Kremen.dt_diag.Rows.Count > 0 Then
            Dim drNewRow As DataRow = Kremen.dt_diag.NewRow
            drNewRow.Item("id") = 0
            drNewRow.Item("kod") = id
            drNewRow.Item("diag") = ""
            drNewRow.Item("type_diag") = "Неопределенный диагноз"
            Kremen.dt_diag.Rows.InsertAt(drNewRow, 0)
        End If

    End Sub


    Public Sub GetMed(ByVal med_name As String)
        Dim da As New KrDataSetTableAdapters.dt_GetMedTableAdapter
        da.Fill(Kremen.dt_GetMed, med_name)
        da.Dispose()
    End Sub


    Public Sub GetAllVidachByInsurCase(ByVal insurcase_id As Integer)
        'SELECT id, date_enter, total_price FROM Vidacha WHERE (insurcase_id = ?) ORDER BY id
        Dim da As New KrDataSetTableAdapters.dt_AllVidachByInsurCaseTableAdapter
        da.Fill(Kremen.dt_AllVidachByInsurCase, insurcase_id)
        da.Dispose()
    End Sub


    Public Sub GetVidachaDetail(ByVal vidacha_id As Integer)
        Dim da As New KrDataSetTableAdapters.dt_VidachaDetailTableAdapter
        da.Fill(Kremen.dt_VidachaDetail, vidacha_id)
        da.Dispose()
    End Sub


    Public Sub GetInsurCaseEdit(ByVal insurcase_id As Integer)
        Dim da As New KrDataSetTableAdapters.dt_insurcaseTableAdapter

        da.Fill(Kremen.dt_insurcase, insurcase_id)
        da.Dispose()
    End Sub
    Public Function ColValueByCurRow(ByRef grid As DataGridView, ByVal column As String) As Object
        ColValueByCurRow = grid(column, grid.CurrentRow.Index).Value
    End Function
    Public Function Get_ost() As Decimal
        If Not Kremen.SP_Klients.Rows.Count > 0 Then
            Get_ost = 0
            Exit Function
        End If

        Dim ost As Decimal
        Dim id As Integer = 0
        Try
            id = Globals.ColValueByCurRow(FKlients.g_klients, "id")
        Catch
        End Try
        cmd.SP_GetOstatok(id, ost)
        Get_ost = Math.Round(ost, 2)
    End Function

    Public Sub GetMKB(ByVal diag As String)
        If Trim(diag) = "" Then Exit Sub

        Dim da As New KrDataSetTableAdapters.dt_mkbTableAdapter
        da.Fill(Kremen.dt_mkb, Trim(diag))
        da.Dispose()
    End Sub

    Public Sub RemoveCase(ByVal insurcase_id As Integer)
        cmd.SP_DelInsurCase(insurcase_id)
    End Sub
End Module
