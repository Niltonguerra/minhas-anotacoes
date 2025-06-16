Public Class contacliente
    Dim ProdutoPreco, VendaSubTotal, VendaValorTotal As Double
    Dim VendaQuant, VendaDesconto As Integer
    Dim cod_venda, nomeCliente As String
    Private Sub logincliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dados_prod_cliente()
        carregar_vendas_registradas()

    End Sub


    Private Sub txt_codigoaux_TextChanged(sender As Object, e As EventArgs) Handles txt_produtocodigo.TextChanged
        Try
            txt_produtonome_aux.Clear()
            txt_produtopreco.Clear()
            txt_quantidade_aux.Clear()
            txt_subtotal.Clear()
            txt_desconto.Clear()
            txt_valorfinal.Clear()

            SQL = "select nome_prod,preco from tb_roupa where cod_prod='" & txt_produtocodigo.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then
                txt_produtonome_aux.Text = rs.Fields(0).Value
                txt_produtopreco.Text = rs.Fields(1).Value
            End If
        Catch ex As Exception
            MsgBox("PRODUTO NÃO ENCONTRADO", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_quantidade_aux_TextChanged(sender As Object, e As EventArgs) Handles txt_quantidade_aux.TextChanged
        Try
            ProdutoPreco = txt_produtopreco.Text
            VendaQuant = txt_quantidade_aux.Text
            VendaSubTotal = ProdutoPreco * VendaQuant


            txt_subtotal.Text = VendaSubTotal

            If txt_desconto.Text = "" Then
                txt_valorfinal.Text = VendaSubTotal
            Else
                VendaDesconto = txt_desconto.Text
                VendaValorTotal = VendaSubTotal - (VendaSubTotal * VendaDesconto / 100)
                txt_valorfinal.Text = VendaValorTotal
            End If

        Catch ex As Exception
            MsgBox("Erro ao Calcular", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ERRO")
        End Try
    End Sub

    Private Sub txt_desconto_TextChanged(sender As Object, e As EventArgs) Handles txt_desconto.TextChanged
        If txt_desconto.Text = "" Then
            txt_valorfinal.Text = VendaSubTotal
        Else
            VendaDesconto = txt_desconto.Text
            VendaValorTotal = VendaSubTotal - (VendaSubTotal * VendaDesconto / 100)
            txt_valorfinal.Text = VendaValorTotal
        End If
    End Sub

    Private Sub btn_RegistrarVenda_Click(sender As Object, e As EventArgs) Handles btn_RegistrarVenda.Click
        autonumerico()
        cod_venda = an_cod_venda

        SQL = "Select nome from Cliente where cpf = '" & clienteLogado & "'"
        rs = db.Execute(SQL)
        nomeCliente = rs.Fields(0).Value

        SQL = "insert into tb_vendaregistro(cod_venda,cpf, nome_cliente,cod_prod, nome_prod, preco_prod,venda_quant,venda_desconto,venda_valortotal) values (
        '" & an_cod_venda & "',
        '" & clienteLogado & "',
        '" & nomeCliente & "',
        '" & txt_produtocodigo.Text & "',
        '" & txt_produtonome_aux.Text & "',
        '" & txt_produtopreco.Text & "',
        '" & txt_quantidade_aux.Text & "',
        '" & txt_desconto.Text & "',
        '" & txt_valorfinal.Text & "')"
        rs = db.Execute(UCase(SQL))

        MsgBox("Dados gravados com sucessso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")

        txt_valorfinal.Clear()
        txt_desconto.Clear()
        txt_subtotal.Clear()
        txt_produtopreco.Clear()
        txt_quantidade_aux.Clear()
        txt_produtonome_aux.Clear()
        txt_produtocodigo.Clear()
        txt_produtocodigo.Focus()

        carregar_vendas_registradas()

    End Sub

End Class