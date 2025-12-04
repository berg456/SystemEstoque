Imports System.Data.SqlClient
Imports Guna.UI2.WinForms.Suite

Public Class FrmAnoLetivo
    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT * FROM ano_escolar", conexao)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Dim x As Integer = DataGridView1.Rows.Count
            lbl_total.Text = CInt(x)
        Catch ex As Exception
            fechar()
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FrmAnoLetivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        txtAno.Text = Date.Now.Year
    End Sub

    Private Sub Limpar()
        txtAno.Text = Date.Now.Year
        DateTimePicker2.Value = Now
        DateTimePicker1.Value = Now
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand

        If txtAno.Text <> "" Then
            Try
                abrir()
                cmd = New SqlCommand("registrarAno", conexao)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Ano", txtAno.Text)
                cmd.Parameters.AddWithValue("@DataInicial", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@DataFinal", DateTimePicker2.Value)

                cmd.Parameters.Add("@MENSAGEM", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim mensagem As String = cmd.Parameters("@MENSAGEM").Value.ToString
                MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Listar()
                Limpar()


            Catch ex As Exception
                MessageBox.Show(ex.Message)
                fechar()
            End Try

        Else
            Dim mensagem As String = cmd.Parameters("@MENSAGEM").Value.ToString
            MessageBox.Show("Preencha o campo matéria", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub BunifuLabel1_Click(sender As Object, e As EventArgs) Handles BunifuLabel1.Click
        Close()

    End Sub
End Class