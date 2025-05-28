Module Module1
    Public diretorio, SQL, aux_cpf, resp As String
    Public cont As Integer
    Public audio As Object
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset


    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SAMSUNGEXPERT\\SQLEXPRESS;Data Source=SAMSUNGEXPERT\nilto;Initial Catalog=P1TDP;trusted_connection=yes;")
            audio.speak("Conexão Bem Sucedida!")
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub









End Module
