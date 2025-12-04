Imports System.Data.SqlClient
Public Class FrmMaterias

    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT * FROM materia", conexao)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Dim x As Integer = DataGridView1.Rows.Count
            lbl_total.Text = CInt(x)
        Catch ex As Exception
            fechar()
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FrmMaterias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand

        If txtMateria.Text <> "" Then
            Try
                abrir()
                cmd = New SqlCommand("registrarMateria", conexao)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Nome", txtMateria.Text)

                cmd.Parameters.Add("@MENSAGEM", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim mensagem As String = cmd.Parameters("@MENSAGEM").Value.ToString
                MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Listar()
                txtMateria.Clear()


            Catch ex As Exception
                MessageBox.Show(ex.Message)
                fechar()
            End Try

        Else
            Dim mensagem As String = cmd.Parameters("@MENSAGEM").Value.ToString
            MessageBox.Show("Preencha o campo matéria", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If

    End Sub

    Private Sub txtMateria_TextChanged(sender As Object, e As EventArgs) Handles txtMateria.TextChanged
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("BuscarMateria", conexao)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@Nome", txtMateria.Text)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Dim x As Integer
            x = DataGridView1.Rows.Count
            lbl_total.Text = CStr(x)


        Catch ex As Exception
            MsgBox(ex.Message)
            Close()
        End Try
    End Sub

    Private Sub BunifuLabel1_Click(sender As Object, e As EventArgs) Handles BunifuLabel1.Click
        Close()

    End Sub
End Class