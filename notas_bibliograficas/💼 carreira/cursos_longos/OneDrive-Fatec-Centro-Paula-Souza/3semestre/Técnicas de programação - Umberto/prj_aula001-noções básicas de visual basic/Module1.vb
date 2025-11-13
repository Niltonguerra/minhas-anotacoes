Module Module1
    Public audio As Object ' variavel publica
    Public diretorio As String
    Sub gerar_voz()
        Try
            audio = CreateObject("SAPI.SPVOICE")
            audio.volume = 20 'volume
            audio.rate = -1 'velocidade do audio, negativo mais lento. numero positivo, audio mais rápido
        Catch ex As Exception
            MsgBox("Erro de execução", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
End Module
