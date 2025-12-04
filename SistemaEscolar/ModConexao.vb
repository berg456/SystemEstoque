Imports System.Data.SqlClient
Module ModConexao
    Public conexao As New SqlConnection("Data Source=DESKTOP-OJPN3JR;Initial Catalog=sistema;Integrated Security=True;Encrypt=False")

    Sub abrir()
        If conexao.State = 0 Then
            conexao.Open()
        End If
    End Sub

    Sub fechar()
        If conexao.State = 1 Then
            conexao.Close()
        End If
    End Sub

    Public usuario As String
    Public codAl As String

End Module
