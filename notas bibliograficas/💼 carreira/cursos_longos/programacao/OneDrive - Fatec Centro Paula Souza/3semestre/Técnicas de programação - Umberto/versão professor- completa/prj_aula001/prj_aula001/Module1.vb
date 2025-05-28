Module Module1
    Public diretorio, SQL, aux_cpf, resp As String 'Variável SQL Querys manipulação Dados
    Public cont As Integer
    Public audio As Object
    Public db As New ADODB.Connection 'Variável Banco
    Public rs As New ADODB.Recordset  'Variável Tabela
    'Referência do menu Projeto
    'Adicionar Referências Microsoft Activex Data Objects 6.1 Library

    Sub conectar_banco()
        Try
            'String de Conexão com SQL-Server
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=SAMSUNGEXPERT\\SQLEXPRESS;Initial Catalog=P1TDP;trusted_connection=yes;")
            MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception

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

    Sub carregar_dados()
        Try
            SQL = "select * from tb_cadastro_prof order by nome asc"
            rs = db.Execute(SQL)
            With frm_cadastro.dgv_dados
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipo()
        Try
            With frm_cadastro.cmb_tipo.Items
                .Add("CPF")
                .Add("NOME")
            End With
            frm_cadastro.cmb_tipo.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao carregar dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

End Module
