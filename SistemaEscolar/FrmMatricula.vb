Imports System.Data.SqlClient
Public Class FrmMatricula
    Private Sub BunifuLabel1_Click(sender As Object, e As EventArgs) Handles BunifuLabel1.Click
        Close()

    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT * FROM matricula", conexao)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Dim x As Integer = DataGridView1.Rows.Count
            lbl_total.Text = CInt(x)
        Catch ex As Exception
            fechar()
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Limpar()
        txtCPF.Clear()
        txtValor.Text = "25"
        txtAno.Text = Now.Year
        txtCodigo.Text = ""


        cbTurmas.Text = "Selecione"
        DateTimePicker1.Value = Now
        txtCPF.Focus()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand

        If txtCpf.Text <> "" Then
            Try
                abrir()
                cmd = New SqlCommand("registrarMatricula", conexao)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@DATA", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@VALOR", txtValor.Text)
                cmd.Parameters.AddWithValue("@TURMA", cbTurmas.SelectedItem)
                cmd.Parameters.AddWithValue("@SERIE", txtSerie.Text)
                cmd.Parameters.AddWithValue("@COD_AULA", cbTurmas.SelectedItem)
                cmd.Parameters.AddWithValue("@CPF_ALUNO", txtCpf.Text)
                cmd.Parameters.AddWithValue("@NUM_ANO", txtAno.Text)
                cmd.Parameters.Add("@MENSAGEM", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim mensagem As String = cmd.Parameters("@MENSAGEM").Value.ToString
                MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Listar()
                Limpar()
                Me.Width = 580

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                fechar()
            End Try

        Else
            Dim mensagem As String = cmd.Parameters("@MENSAGEM").Value.ToString
            MessageBox.Show("Preencha todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub cbTurmas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTurmas.SelectedIndexChanged
        Dim cmd As New SqlCommand("BuscarVagas", conexao)
        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@codaula", cbTurmas.SelectedItem)
            cmd.Parameters.Add("@vagas", SqlDbType.Int).Direction = 2
            cmd.ExecuteNonQuery()
            Dim vagas As Integer = cmd.Parameters("@vagas").Value
            txtVagas.Text = CStr(vagas)
            txtSerie.Text = "A"
        Catch ex As Exception
        End Try
        fechar()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Limpar()
        btnSalvar.Enabled = True
        btnEditar.Enabled = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        btnEditar.Enabled = True
        DateTimePicker1.Enabled = True
        cbTurmas.Enabled = False
        txtValor.Enabled = True
        txtSerie.ReadOnly = False

        Dim dt As New DataTable
        Dim row As DataRow
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_matricula", conexao)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@CPF_ALUNO", txtCpf.Text)
            da.SelectCommand.Parameters.Add("@MENSAGEM", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output
            da.Fill(dt)

            If dt.Rows.Count = 1 Then
                row = dt.Rows(0)
                txtCodigo.Text = row(0).ToString
                DateTimePicker1.Value = row(1).ToString
                txtValor.Text = FormatNumber(row(2).ToString, 2)
                cbTurmas.SelectedItem = row(3).ToString
                txtSerie.Text = row(4).ToString
                txtAno.Text = row(7).ToString
                cbTurmas.SelectedValue = row(5).ToString
                Dim MENSAGEM As String = da.SelectCommand.Parameters("@MENSAGEM").Value.ToString
                MessageBox.Show(MENSAGEM, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                btnEditar.Enabled = True
                btnSalvar.Enabled = False
            Else
                MessageBox.Show("CPF não Registrado", "Aviso")
                Call Limpar()
                btnEditar.Enabled = False
                btnSalvar.Enabled = True

            End If
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        DateTimePicker1.Enabled = False
        cbTurmas.Enabled = True
        txtValor.Enabled = False
        txtSerie.ReadOnly = True

        Dim cmd As New SqlCommand
        If txtCpf.Text <> "" Then
            Try
                abrir()
                cmd = New SqlCommand("editar_matricula", conexao)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@DATA", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@VALOR", txtValor.Text)
                cmd.Parameters.AddWithValue("@TURMA", cbTurmas.SelectedItem)
                cmd.Parameters.AddWithValue("@SERIE", txtSerie.Text)
                cmd.Parameters.AddWithValue("@COD_AULA", cbTurmas.SelectedItem)
                cmd.Parameters.AddWithValue("@CPF_ALUNO", txtCpf.Text)
                cmd.Parameters.AddWithValue("@NUM_ANO", txtAno.Text)
                cmd.Parameters.Add("@MENSAGEM", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()
                Dim MENSAJE As String = cmd.Parameters("@MENSAGEM").Value.ToString
                MessageBox.Show(MENSAJE, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Listar()
                Limpar()
            Catch ex As Exception : MessageBox.Show(ex.Message)
                fechar()
            End Try
        Else
            MessageBox.Show("Preencha os Campos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtAno_Click(sender As Object, e As EventArgs) Handles txtAno.Click
        Dim form = New FrmAnoLetivo
        form.ShowDialog()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim form = New FrmAnoLetivo
        form.ShowDialog()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        'Dim form = New frmConsultarMatriculas
        'Form.ShowDialog()
    End Sub

    Private Sub FrmMatricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        btnEditar.Enabled = False
        txtValor.Text = "25"
        txtAno.Text = Now.Year
    End Sub
End Class