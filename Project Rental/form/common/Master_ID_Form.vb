Imports MySql.Data.MySqlClient
Imports Project_Rental.Sql_com

Public Class User

    'Well buat Ngerbersihin Textbox sama buat Manggil Table dan Combo box nya
    Sub Clean()
        kode.Clear()
        nama.Clear()
        stat.Text = ""
        pass.Clear()
        search.Clear()
        kode.Select()
        Call Grid()
        Call Showstat()
    End Sub

    'Bener Bener Bersih, tapi mending pakai yang Clean soalnya sekalian Call Table dan Combo Box
    Sub Baru()
        nama.Clear()
        stat.Text = ""
        pass.Clear()
        search.Clear()
        nama.Select()
    End Sub

    'ini sub buat nyari nama, pass, dan Status tinggal call call aja
    Sub Found()
        nama.Text = dr.Item("Nama_User")
        pass.Text = dr.Item("Pwd_User")
        stat.Text = dr.Item("Status_User")
        nama.Select()
    End Sub

    '
    ' Banyak banget koding Test-an, abaikan saja
    '

    ' Sub Grid()
    '    'Call Koneksi()
    '   sql = "SELECT * FROM tbl_user"
    '   da = New MySqlDataAdapter(sql, conn)
    '   ds = New DataSet
    '   da.Fill(ds, "tbl_user")
    '   dgv.DataSource = ds.Tables("tbl_user")
    ' End Sub

    'Sub untuk show Grid / Table dari database, tinggal di Call di Main Form User
    Sub Grid()
        sql = "SELECT * FROM tbl_user"
        ds = Sql_dataset(sql)
        If ds.Tables.Count > 0 Then
            dgv.DataSource = ds.Tables(0)
            dgv.ReadOnly = True
        End If
    End Sub

    'buat Show Status "Administrator" dan "User" nya
    Sub Showstat()
        sql = "SELECT DISTINCT Status_User FROM tbl_user"
        cmd = New MySqlCommand(sql, conn)
        dr = cmd.ExecuteReader
        stat.Items.Clear()
        Do While dr.Read
            stat.Items.Add(dr.Item("Status_User"))
        Loop
        dr.Close()
    End Sub

    'Main Form nya User
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Call Koneksi()
        Call Clean()
        dr.Close()
    End Sub

    'ini sih biar ga bisa di ketik Combo Box nya
    Private Sub Stat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stat.KeyPress
        If ((e.KeyChar >= "0" And e.KeyChar <= "9") And e.KeyChar <> vbBack) Then e.Handled = True
    End Sub

    'Buat Refresh atau Back Button
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles back.Click
        Call Clean()
    End Sub

    'Close Button
    Private Sub Tutup_Click(sender As Object, e As EventArgs) Handles tutup.Click
        Me.Close()
    End Sub

    'Show Stat nya buat di Lost Focus in
    Private Sub Stat_LostFocus(sender As Object, e As EventArgs) Handles stat.LostFocus
        stat.Text = UCase(stat.Text)
    End Sub

    'Buat Save dan Update Database
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles save.Click
        Try
            sql = "SELECT * FROM tbl_user where Kode_User='" & kode.Text & "'"
            Dim ds As New DataSet
            ds = Sql_dataset(sql)
            ''cmd = New MySqlCommand(sql, conn)
            ''dr = cmd.ExecuteReader()
            ''dr.Read()
            If ds.Tables(0).Rows.Count Then
                Dim simpan As String
                simpan = "INSERT INTO tbl_user (Kode_User, Nama_User, Pwd_User, Status_User) VALUES (@kode, @user, @password, @status)"
                cmd = New MySqlCommand(simpan, conn)
                cmd.Parameters.AddWithValue("@kode", kode.Text)
                cmd.Parameters.AddWithValue("@user", nama.Text)
                cmd.Parameters.AddWithValue("@password", pass.Text)
                cmd.Parameters.AddWithValue("@status", stat.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Simpan Berhasil")
            Else
                Dim edit As String
                edit = "UPDATE tbl_user SET Nama_User = @nama, Status_User = @stat, Pwd_User = @pwd WHERE Kode_User = @kd"
                cmd = New MySqlCommand(edit, conn)
                cmd.Parameters.AddWithValue("@nama", nama.Text)
                cmd.Parameters.AddWithValue("@stat", stat.Text)
                cmd.Parameters.AddWithValue("@pwd", pass.Text)
                cmd.Parameters.AddWithValue("@kd", kode.Text)

                'Dim param As New Dictionary(Of String, Object) From {
                '   {"@nama", nama.Text},
                ' {"@stat", stat.Text},
                '{"@pwd", pass.Text},
                '{"@kd", kode.Text}
                '}

                cmd.ExecuteNonQuery()
                MessageBox.Show("Update Berhasil")
                'edit = "UPDATE tbl_user SET 
                'Nama_User ='" & nama.Text & "',
                'Status_User ='" & stat.Text & "',
                'Pwd_User ='" & pass.Text & "' WHERE 
                'Kode_User =" & kode.Text & "'"
                'cmd = New MySqlCommand(edit, conn)
                'cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Call Clean()
        End Try
        dr.Close()
    End Sub

    'Data Grid View nya
    Private Sub Dgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        On Error Resume Next
        kode.Text = dgv.Rows(e.RowIndex).Cells(0).Value
        nama.Text = dgv.Rows(e.RowIndex).Cells(1).Value
        pass.Text = dgv.Rows(e.RowIndex).Cells(2).Value
        stat.Text = dgv.Rows(e.RowIndex).Cells(3).Value
    End Sub

    'DELETE Button
    Private Sub Del_Click(sender As Object, e As EventArgs) Handles del.Click
        If kode.Text = "" Then
            MsgBox("Kode User Harus Di isi !")
            kode.Select()
        End If
        If MessageBox.Show("Yakin mau dihapus ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim del As String
            del = "DELETE FROM tbl_user WHERE Kode_User='" & kode.Text & "'"
            cmd = New MySqlCommand(del, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus")
            Call Clean()
        Else
            Call Clean()
        End If
    End Sub

    'Buat Fokus di Textbox Kode User
    Private Sub Kode_LostFocus(sender As Object, e As EventArgs) Handles kode.LostFocus
        sql = "SELECT * FROM tbl_user WHERE Kode_User='" & kode.Text & "'"
        cmd = New MySqlCommand(sql, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            Call Baru()
            dr.Close()
        Else
            Call Found()
            dr.Close()
        End If
        dr.Close()
    End Sub

    'Buat Mencari
    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        sql = "SELECT * FROM tbl_user WHERE Nama_User like '%" & search.Text & "% '"
        da = New MySqlDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds)
        dgv.DataSource = ds.Tables(0)
    End Sub
End Class