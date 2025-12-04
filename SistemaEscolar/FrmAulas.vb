Imports System.Data.SqlClient
Public Class FrmAulas
    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("BuscarAlunoMat", conexao)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@turma", cbTurmas.SelectedItem)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            fechar()
        Catch ex As Exception
            fechar()
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cbTurmas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTurmas.SelectedIndexChanged
        Dim capacidade As Integer
        Dim CMD As SqlCommand
        Try
            abrir()
            CMD = New SqlCommand("BuscarVagasAlunos", conexao)
            CMD.CommandType = 4
            CMD.Parameters.AddWithValue("@codaula", CInt(cbTurmas.SelectedItem))
            CMD.Parameters.Add("@vagas", SqlDbType.Int).Direction = 2
            capacidade = CMD.ExecuteScalar()
            txtCapacidade.Text = CStr(capacidade)
            Dim vagas As Integer = CMD.Parameters("@vagas").Value
            txtVagas.Text = vagas
            Listar()
            Dim j As Integer = DataGridView1.Rows.Count
            lbl_total.Text = CStr(j)
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        fechar()
    End Sub

    Private Sub BunifuLabel1_Click(sender As Object, e As EventArgs) Handles BunifuLabel1.Click
        Close()
    End Sub
End Class