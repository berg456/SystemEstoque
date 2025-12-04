Public Class FrmLogin
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Dim confirma = MsgBox("Deseja Sair?", vbYesNo + vbExclamation, "Atenção")
        If confirma = vbYes Then
            Me.Close()
        End If
    End Sub


End Class