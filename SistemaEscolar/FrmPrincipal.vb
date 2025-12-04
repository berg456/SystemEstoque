Public Class FrmPrincipal
    Private Sub label4_Click(sender As Object, e As EventArgs) Handles label4.Click

    End Sub

    Private Sub BunifuLabel1_Click(sender As Object, e As EventArgs) Handles BunifuLabel1.Click
        Dim confirma = MsgBox("Deseja Sair?", vbYesNo + vbExclamation, "Atenção")
        If confirma = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_alunos_Click(sender As Object, e As EventArgs) Handles btn_alunos.Click
        Dim form = New FrmAlunos
        form.ShowDialog()
    End Sub

    Private Sub btn_professores_Click(sender As Object, e As EventArgs) Handles btn_professores.Click
        Dim form = New FrmProfessores
        form.ShowDialog()
    End Sub

    Private Sub btn_cursos_Click(sender As Object, e As EventArgs) Handles btn_cursos.Click
        Dim form = New FrmMaterias
        form.ShowDialog()
    End Sub

    Private Sub btn_matricula_Click(sender As Object, e As EventArgs) Handles btn_matricula.Click
        Dim form = New FrmMatricula
        form.ShowDialog()
    End Sub
End Class