Public Class Form1
    Private Sub ÁreaDoQuadradoEPerímetroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁreaDoQuadradoEPerímetroToolStripMenuItem.Click
        Try
            frm_area.ShowDialog() 'Chamada de Formulário
        Catch ex As Exception
            MsgBox("Erro de execução!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub NúmerosAntecessorESucessorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NúmerosAntecessorESucessorToolStripMenuItem.Click
        Try
            frm_numeros.ShowDialog() 'Chamada de Formulário
        Catch ex As Exception
            MsgBox("Erro de execução!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub MaiorNúmeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaiorNúmeroToolStripMenuItem.Click
        Try
            frm_maior.ShowDialog() 'Chamada de Formulário
        Catch ex As Exception
            MsgBox("Erro de execução!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Try
            Process.Start("calc.exe") 'Chamada de Formulário
        Catch ex As Exception
            MsgBox("Erro de execução!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub ExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelToolStripMenuItem.Click
        Try
            Process.Start("excel.exe") 'Chamada de Formulário
        Catch ex As Exception
            MsgBox("Erro de execução!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Class
