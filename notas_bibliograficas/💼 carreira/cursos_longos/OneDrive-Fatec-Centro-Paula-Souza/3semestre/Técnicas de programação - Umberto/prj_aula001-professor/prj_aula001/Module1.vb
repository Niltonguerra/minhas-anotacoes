Module Module1
    Public diretorio, SQL As String 'Variável SQL Querys manipulação Dados
    Public audio As Object
    Public db As New ADODB.Connection 'Variável Banco
    Public rs As New ADODB.Recordset  'Variável Tabela
    'Referência do menu Projeto
    'Adicionar Referências Microsoft Activex DataObjects 6.1 Library

    Sub conectar_banco()
        Try
            'String de Conexão com SQL-Server
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=LAB5-01;Initial Catalog=cadastro;trusted_connection=yes;")
            audio.speak("Conexão Bem Sucedida!")
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            audio.speak("Erro ao Conectar")
            MsgBox("Erro ao Conectar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub gerar_audio()

        Try
            audio = CreateObject("SAPI.SPVOICE")
            audio.VOLUME = 100
            audio.RATE = -1
        Catch ex As Exception
            MsgBox("Erro ao carregar módulo de voz", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub
End Module
