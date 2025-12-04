Imports System.Data.SqlClient
Public Class Students
    Dim Con = New SqlConnection("Data Source=INTERNET-PC;Initial Catalog=college;Integrated Security=True")
    Private Sub FillDepartment()
        Con.Open()
        Dim query = "select * from departmentsTBl"
        Dim cmd As New SqlCommand(query, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim TBl As New DataTable()
        adapter.Fill(TBl)
        std_departCb.DataSource = TBl
        std_departCb.DisplayMember = "dep_name"
        std_departCb.ValueMember = "dep_name"
        Con.Close()
    End Sub

    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDepatment()
    End Sub

    Private Sub FillDepatment()
        Throw New NotImplementedException()
    End Sub
End Class