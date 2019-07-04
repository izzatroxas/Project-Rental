Imports MySql.Data.MySqlClient
Public Class Sql_com

    Public Shared Function Sql_dataset(sql_com As String) As DataSet
        Call Koneksi()
        Dim dase As New DataSet
        sql = sql_com
        da = New MySqlDataAdapter(sql, conn)
        da.Fill(dase)
        Return dase
    End Function

    Public Shared Function Sql_datatable(sql_com As String) As DataTable
        Call Koneksi()
        Dim datab As New DataTable
        sql = sql_com
        da = New MySqlDataAdapter(sql, conn)
        da.Fill(datab)
        Return datab
    End Function

End Class
