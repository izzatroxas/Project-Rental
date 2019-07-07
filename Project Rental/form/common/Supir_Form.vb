Imports MySql.Data.MySqlClient
Imports Project_Rental.Sql_com
Public Class Supir

    Sub Clean()
        kode.Clear()
        nama.Clear()
        alamat.Clear()
        telf.Text = ""
        cari.Clear()
        kode.Select()
        Call Grid()
    End Sub

    Sub Baru()
        nama.Clear()
        alamat.Clear()
        telf.Text = ""
        cari.Clear()
        nama.Select()
    End Sub

    Sub Found()
        nama.Text = dr.Item("Nama_Supir")
        alamat.Text = dr.Item("Alamat_Supir")
        telf.Text = dr.Item("Telp_Supir")
        nama.Select()
    End Sub
    Sub Grid()
        sql = "SELECT * FROM tbl_supir"
        ds = Sql_dataset(sql)
        If ds.Tables.Count > 0 Then
            dgv.DataSource = ds.Tables(0)
            dgv.ReadOnly = True
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Call Koneksi()
        Call Clean()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Call Clean()
    End Sub

    Private Sub Cbtn_Click(sender As Object, e As EventArgs) Handles cbtn.Click
        Me.Close()
    End Sub

    Private Sub Telf_LostFocus(sender As Object, e As EventArgs) Handles telf.LostFocus
        telf.Text = UCase(telf.Text)
    End Sub

    Private Sub Sbtn_Click(sender As Object, e As EventArgs) Handles sbtn.Click
        Try
            sql = "SELECT * FROM tbl_supir WHERE Kode_Supir='" & kode.Text & "'"
            Dim ds As New DataSet
            ds = Sql_dataset(sql)
            ''cmd = New MySqlCommand(sql, conn)
            ''dr = cmd.ExecuteReader
            ''dr.Read()
            ''Try
            ''If Not dr.HasRows Then
            If ds.Tables(0).Rows.Count = 0 Then
                Dim save As String
                save = "INSERT INTO tbl_supir (Kode_Supir, Nama_Supir, Alamat_Supir, Telp_Supir) VALUES (@kode, @nama, @alamat, @telf)"
                cmd = New MySqlCommand(save, conn)
                cmd.Parameters.AddWithValue("@kode", kode.Text)
                cmd.Parameters.AddWithValue("@nama", nama.Text)
                cmd.Parameters.AddWithValue("@alamat", alamat.Text)
                cmd.Parameters.AddWithValue("@telf", telf.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Simpan Berhasil")
            Else
                Dim edit As String
                edit = "UPDATE tbl_supir SET Nama_Supir = @nama, Alamat_Supir = @alamat, Telp_Supir= @telf WHERE Kode_Supir = @kd"
                cmd = New MySqlCommand(edit, conn)
                cmd.Parameters.AddWithValue("@nama", nama.Text)
                cmd.Parameters.AddWithValue("@alamat", alamat.Text)
                cmd.Parameters.AddWithValue("@telf", telf.Text)
                cmd.Parameters.AddWithValue("@kd", kode.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Update Berhasil")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Call Clean()
        End Try
        dr.Close()
    End Sub

    Private Sub Dgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        On Error Resume Next
        kode.Text = dgv.Rows(e.RowIndex).Cells(0).Value
        nama.Text = dgv.Rows(e.RowIndex).Cells(1).Value
        alamat.Text = dgv.Rows(e.RowIndex).Cells(2).Value
        telf.Text = dgv.Rows(e.RowIndex).Cells(3).Value
    End Sub

    Private Sub Delbtn_Click(sender As Object, e As EventArgs) Handles delbtn.Click
        If kode.Text = "" Then
            MsgBox("Kode Supir Harus Di isi !")
            kode.Select()
        End If
        If MessageBox.Show("Yakin mau dihapus ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim del As String
            del = "DELETE FROM tbl_supir WHERE Kode_Supir='" & kode.Text & "'"
            cmd = New MySqlCommand(del, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus")
            Call Clean()
        Else
            Call Clean()
        End If
    End Sub

    Private Sub Kode_LostFocus(sender As Object, e As EventArgs) Handles kode.LostFocus
        sql = "SELECT * FROM tbl_supir WHERE Kode_Supir='" & kode.Text & "'"
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

    Private Sub Cari_TextChanged(sender As Object, e As EventArgs) Handles cari.TextChanged
        sql = "SELECT * FROM tbl_supir WHERE Nama_Supir like '%" & cari.Text & "% '"
        da = New MySqlDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds)
        dgv.DataSource = ds.Tables(0)
        ''Belum Fix untuk search
    End Sub
End Class