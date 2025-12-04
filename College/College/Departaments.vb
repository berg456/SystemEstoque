Imports System.Data.SqlClient
Public Class Departaments
    Dim Con = New SqlConnection("Data Source=INTERNET-PC;Initial Catalog=college;Integrated Security=True")
    Private Sub Display()
        Con.Open()
        Dim query = "select * from departmentsTBl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DepartmentDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If DepartmentNameTb.Text = "" Or DesTb.Text = "" Or DurationTb.Text = "" Then
            MsgBox("Missing Information")

        Else
            Try
                Con.Open()
                Dim query = "insert into departmentsTBl values('" & DepartmentNameTb.Text & "','" & DesTb.Text & "'," & DurationTb.Text & ")"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Department Saved")
                Con.Close()
                Display()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub Departaments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub
    Private Sub Reset()
        DepartmentNameTb.Text = ""
        DurationTb.Text = ""
        DesTb.Text = ""
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If key = 0 Then
            MsgBox("Select the Department")

        Else
            Try
                Con.Open()
                Dim query = "delete from DepartmentsTBl where dep_id=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Department Deleted")
                Con.Close()
                Display()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Dim key = 0
    Private Sub DepartmentDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DepartmentDGV.CellMouseClick
        Dim row As DataGridViewRow = DepartmentDGV.Rows(e.RowIndex)
        DepartmentNameTb.Text = row.Cells(1).Value.ToString
        DesTb.Text = row.Cells(2).Value.ToString
        DurationTb.Text = row.Cells(3).Value.ToString
        If DepartmentNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If DepartmentNameTb.Text = "" Or DesTb.Text = "" Or DurationTb.Text = "" Then
            MsgBox("Missing Information")

        Else
            Try
                Con.Open()
                Dim query = "update DepartmentsTBl set dep_name='" & DepartmentNameTb.Text & "',dep_descrition='" & DesTb.Text & "',dep_dur=" & DurationTb.Text & " where dep_id=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Department Updated")
                Con.Close()
                Display()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class