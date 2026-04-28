Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NúmerosAntecessoresESucessoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NúmerosAntecessoresESucessoresToolStripMenuItem.Click
        Try
            frm_maior.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro de execução", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub MaiorNúmeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaiorNúmeroToolStripMenuItem.Click
        Try
            frm_numero.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro de execução", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Try
            Process.Start("calc.exe") 'chama de formulario
        Catch ex As Exception
            MsgBox("Erro de execução", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub ExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelToolStripMenuItem.Click
        Try
            Process.Start("excel.exe") 'chama de formulario
        Catch ex As Exception
            MsgBox("Erro de execução", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub AréaDoQuadradoEPerimetroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AréaDoQuadradoEPerimetroToolStripMenuItem.Click
        Try
            frm_area.ShowDialog()
        Catch ex As Exception
            MsgBox("Erro de execução", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub
End Class
