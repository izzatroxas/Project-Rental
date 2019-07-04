Imports MySql.Data.MySqlClient
Module connect
    Public conn As MySqlConnection
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public cmd As MySqlCommand
    Public sql As String
    Public dt As DataTable
    Dim str As String
    Dim aha As String
    Dim password = "Davinalfa123"

    Sub Koneksi()
        Try
            str = "Server=localhost;user id =root; database=project_rental;password=" & password & "; MultipleActiveResultSets=True;"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                If conn.State = ConnectionState.Open Then
                    'MessageBox.Show("Koneksi Berhasil")
                End If
            End If

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Function Check() As Boolean
        Try
            str = "Server=localhost;user id =root;password=" & password & "; database=project_rental;"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                Return True
            End If
            Return False

        Catch ex As Exception
            Return False
        End Try
    End Function

End Module
