Module SummaPropis
    Public Function ProcM3_SummaProp(Ps1 As String) As String
        Dim Ps2Propis$, Ps3GRN$, Ps4GRNProp$
        Dim Pi1_C As Integer
        Dim Pb1 As Boolean

        Ps2Propis$ = ""
        Ps3GRN$ = ""
        Ps4GRNProp$ = ""
        ProcM3_SummaProp = ""

        Ps1 = Trim(Ps1)
        For Pi1_C = 1 To Len(Ps1)
            If Mid(Ps1, Pi1_C, 1) = "," Then Ps1 = Mid(Ps1, 1, Pi1_C - 1) & "." & Mid(Ps1, Pi1_C + 1, Len(Ps1) - Pi1_C)
        Next Pi1_C
        If Left(Right(Ps1, 3), 1) <> "." Then MsgBox("Неправильная сумма " & Ps1) : Ps2Propis = "***" : Exit Function
        Ps3GRN = Right("000000" & Left(Ps1, Len(Ps1) - 3), 6)
        For Pi1_C = 1 To Len(Ps3GRN)
            If Pi1_C = 6 Then
                If Mid(Ps3GRN, Pi1_C, 1) = "1" Then Ps4GRNProp = Ps4GRNProp & "одна "
                If Mid(Ps3GRN, Pi1_C, 1) = "2" Then Ps4GRNProp = Ps4GRNProp & "дві "
                If Mid(Ps3GRN, Pi1_C, 1) = "3" Then Ps4GRNProp = Ps4GRNProp & "три "
                If Mid(Ps3GRN, Pi1_C, 1) = "4" Then Ps4GRNProp = Ps4GRNProp & "чотири "
                If Mid(Ps3GRN, Pi1_C, 1) = "5" Then Ps4GRNProp = Ps4GRNProp & "п`ять "
                If Mid(Ps3GRN, Pi1_C, 1) = "6" Then Ps4GRNProp = Ps4GRNProp & "шість "
                If Mid(Ps3GRN, Pi1_C, 1) = "7" Then Ps4GRNProp = Ps4GRNProp & "сім "
                If Mid(Ps3GRN, Pi1_C, 1) = "8" Then Ps4GRNProp = Ps4GRNProp & "вісім "
                If Mid(Ps3GRN, Pi1_C, 1) = "9" Then Ps4GRNProp = Ps4GRNProp & "дев`ять "
            End If
            If Pi1_C = 5 Then
                If Mid(Ps3GRN, Pi1_C, 2) = "10" Then Ps4GRNProp = Ps4GRNProp & "десять " : GoTo Mp1
                If Mid(Ps3GRN, Pi1_C, 2) = "11" Then Ps4GRNProp = Ps4GRNProp & "одинадцять " : GoTo Mp1
                If Mid(Ps3GRN, Pi1_C, 2) = "12" Then Ps4GRNProp = Ps4GRNProp & "дванадцять " : GoTo Mp1
                If Mid(Ps3GRN, Pi1_C, 2) = "13" Then Ps4GRNProp = Ps4GRNProp & "тринадцять " : GoTo Mp1
                If Mid(Ps3GRN, Pi1_C, 2) = "14" Then Ps4GRNProp = Ps4GRNProp & "чотирнадцять " : GoTo Mp1
                If Mid(Ps3GRN, Pi1_C, 2) = "15" Then Ps4GRNProp = Ps4GRNProp & "п`ятнадцять " : GoTo Mp1
                If Mid(Ps3GRN, Pi1_C, 2) = "16" Then Ps4GRNProp = Ps4GRNProp & "шістнадцять " : GoTo Mp1
                If Mid(Ps3GRN, Pi1_C, 2) = "17" Then Ps4GRNProp = Ps4GRNProp & "сімнадцять " : GoTo Mp1
                If Mid(Ps3GRN, Pi1_C, 2) = "18" Then Ps4GRNProp = Ps4GRNProp & "вісімнадцять " : GoTo Mp1
                If Mid(Ps3GRN, Pi1_C, 2) = "19" Then Ps4GRNProp = Ps4GRNProp & "дев`ятнадцять " : GoTo Mp1

                If Mid(Ps3GRN, Pi1_C, 1) = "2" Then Ps4GRNProp = Ps4GRNProp & "двадцять "
                If Mid(Ps3GRN, Pi1_C, 1) = "3" Then Ps4GRNProp = Ps4GRNProp & "тридцять "
                If Mid(Ps3GRN, Pi1_C, 1) = "4" Then Ps4GRNProp = Ps4GRNProp & "сорок "
                If Mid(Ps3GRN, Pi1_C, 1) = "5" Then Ps4GRNProp = Ps4GRNProp & "п`ятдесят "
                If Mid(Ps3GRN, Pi1_C, 1) = "6" Then Ps4GRNProp = Ps4GRNProp & "шістдесят "
                If Mid(Ps3GRN, Pi1_C, 1) = "7" Then Ps4GRNProp = Ps4GRNProp & "сімдесят "
                If Mid(Ps3GRN, Pi1_C, 1) = "8" Then Ps4GRNProp = Ps4GRNProp & "вісімдесят "
                If Mid(Ps3GRN, Pi1_C, 1) = "9" Then Ps4GRNProp = Ps4GRNProp & "дев`яносто "
            End If
            If Pi1_C = 2 Then
                If Mid(Ps3GRN, Pi1_C, 2) = "10" Then Ps4GRNProp = Ps4GRNProp & "десять тисяч " : Pb1 = True
                If Mid(Ps3GRN, Pi1_C, 2) = "11" Then Ps4GRNProp = Ps4GRNProp & "одинадцять тисяч " : Pb1 = True
                If Mid(Ps3GRN, Pi1_C, 2) = "12" Then Ps4GRNProp = Ps4GRNProp & "дванадцять тисяч " : Pb1 = True
                If Mid(Ps3GRN, Pi1_C, 2) = "13" Then Ps4GRNProp = Ps4GRNProp & "тринадцять тисяч " : Pb1 = True
                If Mid(Ps3GRN, Pi1_C, 2) = "14" Then Ps4GRNProp = Ps4GRNProp & "чотирнадцять тисяч " : Pb1 = True
                If Mid(Ps3GRN, Pi1_C, 2) = "15" Then Ps4GRNProp = Ps4GRNProp & "п`ятнадцять тисяч " : Pb1 = True
                If Mid(Ps3GRN, Pi1_C, 2) = "16" Then Ps4GRNProp = Ps4GRNProp & "шістнадцять тисяч " : Pb1 = True
                If Mid(Ps3GRN, Pi1_C, 2) = "17" Then Ps4GRNProp = Ps4GRNProp & "сімнадцять тисяч " : Pb1 = True
                If Mid(Ps3GRN, Pi1_C, 2) = "18" Then Ps4GRNProp = Ps4GRNProp & "вісімнадцять тисяч " : Pb1 = True
                If Mid(Ps3GRN, Pi1_C, 2) = "19" Then Ps4GRNProp = Ps4GRNProp & "дев`ятнадцять тисяч " : Pb1 = True

                If Mid(Ps3GRN, Pi1_C, 1) = "2" Then Ps4GRNProp = Ps4GRNProp & "двадцять "
                If Mid(Ps3GRN, Pi1_C, 1) = "3" Then Ps4GRNProp = Ps4GRNProp & "тридцять "
                If Mid(Ps3GRN, Pi1_C, 1) = "4" Then Ps4GRNProp = Ps4GRNProp & "сорок "
                If Mid(Ps3GRN, Pi1_C, 1) = "5" Then Ps4GRNProp = Ps4GRNProp & "п`ятдесят "
                If Mid(Ps3GRN, Pi1_C, 1) = "6" Then Ps4GRNProp = Ps4GRNProp & "шісдесят "
                If Mid(Ps3GRN, Pi1_C, 1) = "7" Then Ps4GRNProp = Ps4GRNProp & "сімдесят "
                If Mid(Ps3GRN, Pi1_C, 1) = "8" Then Ps4GRNProp = Ps4GRNProp & "вісімдесят "
                If Mid(Ps3GRN, Pi1_C, 1) = "9" Then Ps4GRNProp = Ps4GRNProp & "дев`яносто "
            End If
            If Pi1_C = 1 Or Pi1_C = 4 Then
                If Mid(Ps3GRN, Pi1_C, 1) = "1" Then Ps4GRNProp = Ps4GRNProp & "сто "
                If Mid(Ps3GRN, Pi1_C, 1) = "2" Then Ps4GRNProp = Ps4GRNProp & "двісті "
                If Mid(Ps3GRN, Pi1_C, 1) = "3" Then Ps4GRNProp = Ps4GRNProp & "триста "
                If Mid(Ps3GRN, Pi1_C, 1) = "4" Then Ps4GRNProp = Ps4GRNProp & "чотириста "
                If Mid(Ps3GRN, Pi1_C, 1) = "5" Then Ps4GRNProp = Ps4GRNProp & "п`ятьсот "
                If Mid(Ps3GRN, Pi1_C, 1) = "6" Then Ps4GRNProp = Ps4GRNProp & "шістьсот "
                If Mid(Ps3GRN, Pi1_C, 1) = "7" Then Ps4GRNProp = Ps4GRNProp & "сімсот "
                If Mid(Ps3GRN, Pi1_C, 1) = "8" Then Ps4GRNProp = Ps4GRNProp & "вісімсот "
                If Mid(Ps3GRN, Pi1_C, 1) = "9" Then Ps4GRNProp = Ps4GRNProp & "дев`ятьсот "
            End If
            If Pi1_C = 3 And Pb1 = False Then
                If Mid(Ps3GRN, Pi1_C, 1) = "1" Then Ps4GRNProp = Ps4GRNProp & "одна тисяча "
                If Mid(Ps3GRN, Pi1_C, 1) = "2" Then Ps4GRNProp = Ps4GRNProp & "дві тисячі "
                If Mid(Ps3GRN, Pi1_C, 1) = "3" Then Ps4GRNProp = Ps4GRNProp & "три тисячі "
                If Mid(Ps3GRN, Pi1_C, 1) = "4" Then Ps4GRNProp = Ps4GRNProp & "чотири тисячі "
                If Mid(Ps3GRN, Pi1_C, 1) = "5" Then Ps4GRNProp = Ps4GRNProp & "п`ять тисяч "
                If Mid(Ps3GRN, Pi1_C, 1) = "6" Then Ps4GRNProp = Ps4GRNProp & "шість тисяч "
                If Mid(Ps3GRN, Pi1_C, 1) = "7" Then Ps4GRNProp = Ps4GRNProp & "сім тисяч "
                If Mid(Ps3GRN, Pi1_C, 1) = "8" Then Ps4GRNProp = Ps4GRNProp & "вісім тисяч "
                If Mid(Ps3GRN, Pi1_C, 1) = "9" Then Ps4GRNProp = Ps4GRNProp & "дев`ять тисяч "
            End If
        Next Pi1_C
        ProcM3_SummaProp = Ps2Propis$
Mp1:
        Ps4GRNProp = UCase(Left(Ps4GRNProp, 1)) & Mid(Ps4GRNProp, 2, Len(Ps4GRNProp) - 1)
        Ps2Propis = Ps4GRNProp & "грн. " & Right(Ps1, 2) & " коп."
        ProcM3_SummaProp = Ps2Propis$
    End Function

End Module
