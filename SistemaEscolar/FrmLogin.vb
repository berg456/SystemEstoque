Imports System.Data.SqlClient

Public Class FrmLogin
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Dim confirma = MsgBox("Deseja Sair?", vbYesNo + vbExclamation, "Atenção")
        If confirma = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim usu As String = txtUsuario.Text
        Dim sen As String = txtSenha.Text

        If usu = "" Or sen = "" Then
            MsgBox("Preencha os Campos")
        Else
            Dim cmd As New SqlCommand("iniciarSessao", conexao)
            Try
                abrir()
                cmd.CommandType = 4
                With cmd.Parameters
                    .AddWithValue("@Nome", usu)
                    .AddWithValue("@Senha", sen)
                    .Add("@Msg", SqlDbType.VarChar, 100).Direction = 2
                    cmd.ExecuteNonQuery()
                End With

                usuario = txtUsuario.Text
                Dim msg As String = cmd.Parameters("@Msg").Value
                MsgBox(msg, vbInformation)

                If (msg = "Dados incorretos") Then
                    txtSenha.Clear()
                    txtUsuario.Clear()
                    txtUsuario.Focus()
                Else
                    Dim frm As New FrmPrincipal
                    Me.Hide()
                    frm.ShowDialog()
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            conexao.Close()
        End If
    End Sub

    Private Sub btnSenha_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSenha.MouseDown
        txtSenha.UseSystemPasswordChar = False

    End Sub

    Private Sub btnSenha_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSenha.MouseUp
        txtSenha.UseSystemPasswordChar = True
    End Sub
End Class
