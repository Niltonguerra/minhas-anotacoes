Public Class frm_cadastro
    Private Sub Frm_cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gerar_audio()
        conectar_banco()
        carregar_dados()
        carregar_tipo()

    End Sub

    Private Sub Img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
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

    Private Sub Btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            SQL = "select * from tb_cadastro_prof where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then 'Se o CPF existir na tabela
                SQL = "update tb_cadastro_prof set nome='" & txt_nome.Text & "', " &
                    "data_nasc='" & txt_data_nasc.Value.Date & "', " &
                    "fone='" & txt_fone.Text & "', email='" & txt_email.Text & "', " &
                    "dir_foto='" & diretorio & "' where cpf='" & txt_cpf.Text & "'"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                SQL = "insert into tb_cadastro_prof values ('" & txt_cpf.Text & "', " &
                    "'" & txt_nome.Text & "', '" & txt_data_nasc.Value.Date & "', " &
                    "'" & txt_fone.Text & "', '" & txt_email.Text & "', '" & diretorio & "')"
                rs = db.Execute(UCase(SQL))
                MsgBox("Dados gravados com sucessso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            End If
            txt_cpf.Clear()
            txt_nome.Clear()
            txt_data_nasc.Value = Now
            txt_fone.Clear()
            txt_email.Clear()
            img_foto.Load(Application.StartupPath & "\Fotos\nova_foto.png")
            txt_cpf.Focus()
            carregar_dados()
        Catch ex As Exception
            MsgBox("Erro ao Gravar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            SQL = "select * from tb_cadastro_prof where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = True Then 'Se não CPF existir na tabela
                txt_nome.Focus()
            Else
                txt_nome.Text = rs.Fields(1).Value
                txt_data_nasc.Value = rs.Fields(2).Value
                txt_fone.Text = rs.Fields(3).Value
                txt_email.Text = rs.Fields(4).Value
                img_foto.Load(rs.Fields(5).Value)
            End If
        Catch ex As Exception
            MsgBox("Erro ao Consultar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        txt_cpf.Clear()
        txt_nome.Clear()
        txt_data_nasc.Value = Date.Today
        txt_fone.Clear()
        txt_email.Clear()
        img_foto.Load(Application.StartupPath & "\Fotos\nova_foto.png")
        txt_cpf.Focus()
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            SQL = "select * from tb_cadastro_prof where " & cmb_tipo.Text & " like '" & txt_busca.Text & "%'"
            rs = db.Execute(SQL)
            With dgv_dados
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing)
                    rs.MoveNext()
                    cont = cont + 1
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub Dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(3).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    SQL = "select * from tb_cadastro_prof where cpf='" & aux_cpf & "'"
                    rs = db.Execute(SQL)
                    If rs.EOF = False Then
                        TabControl1.SelectTab(0)
                        txt_cpf.Text = rs.Fields(0).Value
                        txt_nome.Text = rs.Fields(1).Value
                        txt_data_nasc.Value = rs.Fields(2).Value
                        txt_fone.Text = rs.Fields(3).Value
                        txt_email.Text = rs.Fields(4).Value
                        img_foto.Load(rs.Fields(5).Value)
                    End If
                ElseIf .CurrentRow.Cells(4).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    resp = MsgBox("Deseja realmente excluir" + vbNewLine &
                                 "o CPF:" & aux_cpf & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                    If resp = MsgBoxResult.Yes Then
                        SQL = "delete from tb_cadastro_prof where cpf='" & aux_cpf & "'"
                        rs = db.Execute(SQL)
                        carregar_dados()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


End Class