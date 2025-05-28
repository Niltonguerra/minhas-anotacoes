Module Module1
    Public diretorio, SQL, aux_cpf, resp As String
    Public cont As Integer
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public clienteLogado, an_cod_venda As String

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=DESKTOP-37E9V6T;Initial Catalog=P1TDP;trusted_connection=yes")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub


    Sub carregar_dados_prod()
        Try
            SQL = "select * from tb_roupa order by nome_prod asc"
            rs = db.Execute(SQL)
            With contaadmin.dgv_dados_prod
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value,
                              rs.Fields(1).Value,
                              rs.Fields(3).Value,
                              rs.Fields(2).Value,
                              rs.Fields(5).Value,
                              Nothing, Nothing,
                              Image.FromFile(rs.Fields(4).Value.ToString()))
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados do produto", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_dados_prod_cliente()
        Try
            SQL = "select cod_prod, nome_prod, cor_prod, img_prod, preco from tb_roupa"
            rs = db.Execute(SQL)
            With contacliente.dgv_dados_prod_cliente
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value,
                              rs.Fields(1).Value,
                              rs.Fields(2).Value,
                              rs.Fields(4).Value,
                              Image.FromFile(rs.Fields(3).Value.ToString()))
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados do produto", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_dados_cliente()
        Try
            SQL = "select * from Cliente order by nome asc"
            rs = db.Execute(SQL)
            With contaadmin.dgv_dados_cliente
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(0).Value, Image.FromFile(rs.Fields(6).Value.ToString()), Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados do cliente", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_vendas_registradas()
        Try
            SQL = "Select cod_venda,nome_cliente,nome_prod,preco_prod,venda_quant,venda_desconto,venda_valortotal from tb_vendaregistro where cpf = '" & clienteLogado & "'"
            rs = db.Execute(SQL)
            With contacliente.dgv_vendasregistradas
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(
                        rs.Fields(0).Value, 'Codigo de Venda
                        rs.Fields(1).Value, 'Nome Cliente
                        rs.Fields(2).Value, 'Nome Produto
                        rs.Fields(3).Value, 'Preco Produto
                        rs.Fields(4).Value, 'Venda Quantidade
                        rs.Fields(5).Value, 'Venda Desconto
                        rs.Fields(6).Value) 'Valor Total
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar vendas registradas", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Sub carregar_vendas_registradas_adm()
        Try
        SQL = "Select cod_venda,nome_cliente,nome_prod,preco_prod,venda_quant,venda_desconto,venda_valortotal from tb_vendaregistro"
        rs = db.Execute(SQL)
            With contaadmin.dgv_vendasregistradas
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(
                        rs.Fields(0).Value, 'Codigo de Venda
                        rs.Fields(1).Value, 'Nome Cliente
                        rs.Fields(2).Value, 'Nome Produto
                        rs.Fields(3).Value, 'Preco Produto
                        rs.Fields(4).Value, 'Venda Quantidade
                        rs.Fields(5).Value, 'Venda Desconto
                        rs.Fields(6).Value) 'Valor Total
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
        MsgBox("Erro ao carregar vendas registradas", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

        End Try
    End Sub

    Sub autonumerico()
        Try
            SQL = "Select cod_venda from tb_vendaregistro order by cod_venda desc"
            rs = db.Execute(SQL)
            an_cod_venda = rs.Fields(0).Value + 1
        Catch ex As Exception

        End Try
    End Sub

    Sub Carregar_perfil_Cliente()

        With contacliente.Perfil

        End With

    End Sub

End Module
