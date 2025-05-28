Public Class frm_area

    Dim lado, area, perimetro As Double  'dim cria uma variavel pessoal


    Private Sub Frm_area_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gerar_voz()
    End Sub

    Private Sub Btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Try
            lado = txt_lado.Text
            area = (lado ^ 2)
            perimetro = (lado * 4)

            lbl_area.Text = area
            lbl_perimetro.Text = perimetro
            audio.speak("Área do quadrado" & area & "" + vbNewLine &
                        "Perimetro" & perimetro & "")

        Catch ex As Exception
            MsgBox("Erro de execução", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        Try
            txt_lado.Clear()
            lbl_area.Text = ""
            lbl_perimetro.Text = ""
            txt_lado.Focus()
        Catch ex As Exception
            MsgBox("Erro de execução", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
End Class