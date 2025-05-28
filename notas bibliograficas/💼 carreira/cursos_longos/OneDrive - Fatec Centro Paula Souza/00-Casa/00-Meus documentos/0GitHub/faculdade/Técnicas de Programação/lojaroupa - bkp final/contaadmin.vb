Imports System.Windows.Forms.VisualStyles
Public Class contaadmin
    Dim ProdutoPreco, VendaSubTotal, VendaValorTotal As Double
    Dim VendaQuant, VendaDesconto As Integer
    Private Sub contaadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conectar_banco()
        carregar_dados_prod()
        carregar_dados_cliente()
        carregar_vendas_registradas_adm()

    End Sub
    Private Sub WordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordToolStripMenuItem.Click
        Try
            Process.Start("WinWord.exe") 'Chamada de Formulário
        Catch ex As Exception
            MsgBox("Erro de execução!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub ChormeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChormeToolStripMenuItem.Click
        Try
            Process.Start("chrome.exe") 'Chamada de Formulário
        Catch ex As Exception
            MsgBox("Erro de execução!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\Fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub


    Private Sub dgv_dados_cliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_cliente.CellContentClick
        Try
            With dgv_dados_cliente
                If .CurrentRow.Cells(4).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine & "o CPF:" & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        SQL = "delete from Cliente where cpf='" & aux_cpf & "'"
                        rs = db.Execute(SQL)
                        carregar_dados_cliente()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub dgv_dados_prod_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_prod.CellContentClick
        Try
            With dgv_dados_prod
                If .CurrentRow.Cells(7).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(0).Value
                    SQL = "select * from tb_roupa where cod_prod='" & aux_cpf & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        Tab.SelectTab(0)
                        txt_codigo.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(1).Value
                        txt_cor.Text = rs.Fields(2).Value
                        txt_quantidade.Text = rs.Fields(3).Value
                        txt_preco.Text = rs.Fields(5).Value
                        img_foto.Load(rs.Fields(4).Value)
                    End If
                ElseIf .CurrentRow.Cells(6).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(0).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine & "o produto com o código:" & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        SQL = "delete from tb_roupa where cod_prod like'" & aux_cpf & "'"
                        rs = db.Execute(SQL)
                        carregar_dados_prod()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_cadastrar_cliente_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_cliente.Click
        Try
            SQL = "select * from Cliente where cpf ='" & txt_cpf.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then
                MsgBox("Cliente Já Registrado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
            Else
                SQL = "insert into Cliente(nome,cpf,telefone,Email,dt_aniver,senha,foto) values ('" & txt_clientenome.Text & "',
            '" & txt_cpf.Text & "','" & txt_fone.Text & "','" & txt_email.Text & "', '" & txt_dtNasc.Value.Date & "', '1234','" & diretorio & "')"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados gravados com sucessso!" & vbNewLine & "Senha Padrão: 1234", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txt_clientenome.Clear()
                txt_cpf.Clear()
                txt_fone.Clear()
                txt_email.Clear()
                txt_dtNasc.Value = Now
                img_foto.Load(Application.StartupPath & "\Fotos\nova_foto.png")
                txt_nome.Focus()

            End If
        Catch ex As Exception
            MsgBox("Erro ao Cadastrar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
    Private Sub btn_cadastrar_roupa_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_roupa.Click
        Try
            SQL = "select * from tb_roupa where cod_prod ='" & txt_codigo.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then
                SQL = "update tb_roupa set nome_prod='" & txt_nome.Text & "', " &
                    "cor_prod='" & txt_cor.Text & "', quant_prod='" & txt_quantidade.Text & "', " &
                    "preco='" & txt_preco.Text & "', " &
                    "img_prod='" & diretorio & "' where cod_prod='" & txt_codigo.Text & "'"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")

            Else
                SQL = "insert into tb_roupa(cod_prod,nome_prod,cor_prod,quant_prod,img_prod,preco) values ('" & txt_codigo.Text & "',
            '" & txt_nome.Text & "','" & txt_cor.Text & "','" & txt_quantidade.Text & "','" & diretorio & "','" & txt_preco.Text & "')"
                rs = db.Execute(UCase(SQL))
                MsgBox("Registro inserido com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Concluir")
                txt_codigo.Clear()
                txt_nome.Clear()
                txt_cor.Clear()
                txt_quantidade.Clear()
                txt_preco.Clear()
                img_foto.Load(Application.StartupPath & "\images\grande.png")
                txt_codigo.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao cadastrar!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

        carregar_dados_prod()
    End Sub

    Private Sub Img_foto_cliente_Click(sender As Object, e As EventArgs) Handles img_foto_cliente.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\Fotos"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub


    Private Sub dgv_venda_cliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            With dgv_dados_cliente
                If .CurrentRow.Cells(1).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(0).Value
                    SQL = "select * from tb_roupa where cod_prod='" & aux_cpf & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        Tab.SelectTab(0)
                        txt_codigo.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(1).Value
                        txt_cor.Text = rs.Fields(2).Value
                        txt_quantidade.Text = rs.Fields(3).Value
                        txt_preco.Text = rs.Fields(5).Value
                        img_foto.Load(rs.Fields(4).Value)
                    End If
                ElseIf .CurrentRow.Cells(6).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(0).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                 "o produto com o código:" & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        SQL = "delete from tb_roupa where cod_prod like'" & aux_cpf & "'"
                        rs = db.Execute(SQL)
                        carregar_dados_prod()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_cpf_aux_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf_aux.LostFocus
        Try
            SQL = "select nome from Cliente where cpf ='" & txt_cpf_aux.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then
                txt_nome_aux.Text = rs.Fields(0).Value
            End If
        Catch ex As Exception
            MsgBox("CPF NÃO ENCONTRADO", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_RegistrarVenda_Click(sender As Object, e As EventArgs) Handles btn_RegistrarVenda.Click
        autonumerico()


        SQL = "insert into tb_vendaregistro(cod_venda,cpf, nome_cliente,cod_prod, nome_prod, preco_prod,venda_quant,venda_desconto,venda_valortotal) values (
        '" & an_cod_venda & "','" & txt_cpf_aux.Text & "', '" & txt_nome_aux.Text & "','" & txt_codigoaux.Text & "','" & txt_produtonome_aux.Text & "','" & txt_produtopreco.Text & "',
        '" & txt_quantidade_aux.Text & "', '" & txt_desconto.Text & "','" & txt_valorfinal.Text & "')"
        rs = db.Execute(UCase(SQL))
        MsgBox("Dados gravados com sucessso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        txt_valorfinal.Clear()
        txt_desconto.Clear()
        txt_subtotal.Clear()
        txt_produtopreco.Clear()
        txt_quantidade_aux.Clear()
        txt_produtonome_aux.Clear()
        txt_codigoaux.Clear()
        txt_codigoaux.Focus()

        carregar_vendas_registradas_adm()
    End Sub

    Private Sub txt_codigoaux_TextChanged(sender As Object, e As EventArgs) Handles txt_codigoaux.TextChanged
        Try
            txt_produtonome_aux.Clear()
            txt_produtopreco.Clear()
            txt_quantidade_aux.Clear()
            txt_subtotal.Clear()
            txt_desconto.Clear()
            txt_valorfinal.Clear()

            SQL = "select nome_prod,preco from tb_roupa where cod_prod='" & txt_codigoaux.Text & "'"
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
End Class