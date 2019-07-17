Imports MySql.Data.MySqlClient
Public Class Sql_com

    Public Shared Function Sql_dataset(sql_com As String) As DataSet
        Call Koneksi()
        Dim ds As New DataSet
        sql = sql_com
        da = New MySqlDataAdapter(sql, conn)
        da.Fill(ds)
        Return ds
    End Function

    Public Shared Function Sql_datatable(sql_com As String) As DataTable
        Call Koneksi()
        Dim dt As New DataTable
        sql = sql_com
        da = New MySqlDataAdapter(sql, conn)
        da.Fill(dt)
        Return dt
    End Function

End Class
