Imports System.Data.SqlClient
Public Class FrmProfessores
    Private Sub FrmProfessores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 548
        DateTimePicker1.Value = "01/01/2000"
        Listar()
        BuscarMaterias()
    End Sub

    Sub BuscarMaterias()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("SELECT * FROM MATERIA", conexao)
            DA.Fill(DT)
            cbMateria.DisplayMember = "materia"
            cbMateria.ValueMember = "id_materia"
            cbMateria.DataSource = DT
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        fechar()
    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT * FROM professor", conexao)
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
        txtBuscarCpf.Clear()
        txtNome.Clear()
        txtCpf.Clear()
        txtSobrenome.Clear()
        txtEndereco.Clear()
        txtEmail.Clear()
        txtTelefone.Clear()
        cbMateria.Text = "Selecionar"
        txtIdade.Clear()
        rbMasculino.Checked = True
        DateTimePicker1.Value = "01/01/2000"
        txtCpf.Focus()
    End Sub

    Private Sub btn_inserir_Click(sender As Object, e As EventArgs) Handles btn_inserir.Click
        Me.Width = 966
        If rbCpf.Checked Then
            txtCpf.Text = txtBuscarCpf.Text
            txtBuscarCpf.Text = ""
            txtNome.Text = ""
            txtNome.Focus()
        Else
            txtNome.Text = txtBuscarCpf.Text
            txtBuscarCpf.Text = ""
            txtCpf.Text = ""
            txtCpf.Focus()
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand
        codAl = txtCpf.Text
        If txtCpf.Text <> "" And txtNome.Text <> "" Then
            Try
                abrir()
                cmd = New SqlCommand("registrarProfessor", conexao)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CPF", txtCpf.Text)
                cmd.Parameters.AddWithValue("@NOME", txtNome.Text)
                cmd.Parameters.AddWithValue("@SOBRENOME", txtSobrenome.Text)
                cmd.Parameters.AddWithValue("@IDADE", txtIdade.Text)
                cmd.Parameters.AddWithValue("@SEXO", If(rbMasculino.Checked = True, "M", "F"))
                cmd.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text)
                cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@ID_MATERIA", cbMateria.SelectedIndex)
                cmd.Parameters.Add("@MENSAGEM", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim mensagem As String = cmd.Parameters("@MENSAGEM").Value.ToString
                MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Listar()
                Limpar()
                Me.Width = 548

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                fechar()
            End Try

        Else
            Dim mensagem As String = cmd.Parameters("@MENSAGEM").Value.ToString
            MessageBox.Show("Preencha todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim dataNasc As Date
        Dim idade As Integer

        dataNasc = DateTimePicker1.Value
        idade = Now.Year - dataNasc.Year

        If dataNasc >= "01/01/2010" Then
            MsgBox("Idade não permitida para matricula")
            txtIdade.Clear()
            DateTimePicker1.Value = "01/01/2000"
        Else
            txtIdade.Text = CStr(idade)
        End If
    End Sub

    Private Sub txtBuscarNome_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarNome.TextChanged
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("BuscarNomeProfessor", conexao)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@Nome", txtBuscarNome.Text)
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

    Private Sub rbCpf_CheckedChanged(sender As Object, e As EventArgs) Handles rbCpf.CheckedChanged
        lblBuscar.Text = "CPF"
        txtBuscarCpf.Visible = True
        txtBuscarCpf.Clear()
        txtBuscarCpf.Focus()
        txtBuscarNome.Visible = False
        Listar()
    End Sub

    Private Sub rbNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbNome.CheckedChanged
        lblBuscar.Text = "Nome"
        txtBuscarNome.Visible = True
        txtBuscarNome.Clear()
        txtBuscarNome.Focus()
        txtBuscarCpf.Visible = False
        Listar()
    End Sub

    Private Sub txtBuscarCpf_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCpf.TextChanged
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()

            da = New SqlDataAdapter("BuscarCPFProfessor", conexao)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@CPF", txtBuscarCpf.Text)
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        lbl_info.Text = "Dê um duplo clique sobre o nome para editar!"
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Me.Width = 966
        txtCpf.Enabled = False
        txtCpf.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtTelefone.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtNome.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtSobrenome.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtIdade.Text = DataGridView1.CurrentRow.Cells(4).Value
        Dim sexo As Char = DataGridView1.CurrentRow.Cells(5).Value
        If sexo = "M" Then
            rbMasculino.Checked = True
        Else
            rbFemenino.Checked = True
        End If
        txtEndereco.Text = DataGridView1.CurrentRow.Cells(6).Value

        txtEmail.Text = DataGridView1.CurrentRow.Cells(7).Value
        DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(8).Value
        'cbMateria.Text = DataGridView1.CurrentRow.Cells(9).Value

        btnEditar.Enabled = True
        btnSalvar.Enabled = False
    End Sub

    Private Sub btnFecharCad_Click(sender As Object, e As EventArgs) Handles btnFecharCad.Click
        Me.Width = 548
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cmd As SqlCommand
        codAl = txtCpf.Text
        If txtCpf.Text <> "" And txtNome.Text <> "" Then
            Try
                abrir()
                cmd = New SqlCommand("EditarProfessor", conexao)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CPF", txtCpf.Text)
                cmd.Parameters.AddWithValue("@NOME", txtNome.Text)
                cmd.Parameters.AddWithValue("@SOBRENOME", txtSobrenome.Text)
                cmd.Parameters.AddWithValue("@IDADE", txtIdade.Text)
                cmd.Parameters.AddWithValue("@SEXO", If(rbMasculino.Checked = True, "M", "F"))
                cmd.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text)
                cmd.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text)
                cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text)
                cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@ID_MATERIA", cbMateria.SelectedIndex)
                cmd.Parameters.Add("@MENSAGEM", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim mensagem As String = cmd.Parameters("@MENSAGEM").Value.ToString
                MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Listar()
                Limpar()
                Me.Width = 548
                txtCpf.Enabled = True
                btnSalvar.Enabled = True
                btnEditar.Enabled = False

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                fechar()
            End Try

        Else
            Dim mensagem As String = cmd.Parameters("@MENSAGEM").Value.ToString
            MessageBox.Show("Preencha todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub BunifuLabel2_Click(sender As Object, e As EventArgs) Handles BunifuLabel2.Click
        Close()

    End Sub
End Class