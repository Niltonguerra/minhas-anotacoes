Public Class frm_cadastro
    Private Sub Frm_cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gerar_audio()
        conectar_banco()

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
            SQL = "select * from tb_cadastro where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then ' verifica se o cpf existe na tabela do sql server
                MsgBox("Erro" & txt_cpf.Text & "" + vbNewLine & "já cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
            Else
                SQL = "insert into tb_cadastro values ('" & txt_cpf.Text & "', '" & txt_nome.Text & "', '" & txt_data_nasc.Text & "', '" & txt_fone.Text & "', '" & txt_email.Text & "', " &
                        "'" & diretorio & "')"

                rs = db.Execute(UCase(SQL))
                MsgBox("dados cadastrados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                txt_cpf.Clear()
                txt_nome.Clear()
                txt_data_nasc.Value = Now
                txt_fone.Clear()
                txt_email.Clear()
                img_foto.Load(Application.StartupPath * "Fotos\nova_foto.png")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            SQL = "select * from tb_cadastro where cpf='" & txt_cpf.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = True Then 'se não tem CPF existemna tabela
                txt_nome.Focus()
            Else
                txt_nome.Text = rs.Fields(1).Value
                txt_data_nasc.Value = rs.Fields(2).Value
                txt_fone.Text = rs.Fields(3).Value
                txt_email.Text = rs.Fields(4).Value
                img_foto.Load(rs.Fields(5).Value)

            End If

        Catch ex As Exception
            MsgBox("erro ao consultar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick

        Try
            SQL = "select * from tb_cadastro where cpf'" & txt_cpf.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = True Then ' se não existir na tabela
                txt_nome.Focus()
            Else
                txt_nome.Text = rs.Fields(1).Value
                txt_data_nasc.Value = rs.Fields(2).Value
                txt_fone.Text = rs.Fields(3).Value
                txt_email.Text = rs.Fields(4).Value
                img_foto.Load(rs.Fields(5).Value)
            End If
        Catch ex As Exception
            MsgBox("erro ao consultar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
End Class