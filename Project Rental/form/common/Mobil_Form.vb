Imports MySql.Data.MySqlClient
Imports Project_Rental.Sql_com
Public Class Mobil

    Sub Clean()
        kode.Clear()
        nama.Clear()
        tmpj.Text = ""
        tmph.Clear()
        tspj.Clear()
        tsph.Clear()
        cari.Clear()
        kode.Select()
        Call Grid()
    End Sub

    Sub Baru()
        nama.Clear()
        tmpj.Text = ""
        tmph.Clear()
        tspj.Clear()
        tsph.Clear()
        cari.Clear()
        nama.Select()
    End Sub

    Sub Found()
        nama.Text = dr.Item("Nama_Mobil")
        tmpj.Text = dr.Item("Tarif_Per_Jam")
        tmph.Text = dr.Item("Tarif_Per_Hari")
        tspj.Text = dr.Item("Tarif_Supir_Per_Jam")
        tsph.Text = dr.Item("Tarif_Supir_Per_Hari")
        nama.Select()
    End Sub

    Sub Grid()
        sql = "SELECT * FROM tbl_mobil"
        ds = Sql_dataset(sql)
        If ds.Tables.Count > 0 Then
            dgv.DataSource = ds.Tables(0)
            dgv.ReadOnly = True
        End If
    End Sub
    Private Sub Mobil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Call Koneksi()
        Call Clean()
    End Sub

    Private Sub Bbtn_Click(sender As Object, e As EventArgs) Handles bbtn.Click
        Call Clean()
    End Sub

    Private Sub Cbtn_Click(sender As Object, e As EventArgs) Handles cbtn.Click
        Me.Close()
    End Sub

    Private Sub Sbtn_Click(sender As Object, e As EventArgs) Handles sbtn.Click
        Try
            sql = "SELECT * FROM tbl_mobil WHERE Kode_Mobil='" & kode.Text & "'"
            Dim ds As New DataSet
            ds = Sql_dataset(sql)
            ''cmd = New MySqlCommand(sql, conn)
            ''dr = cmd.ExecuteReader
            ''dr.Read()
            ''Try
            ''If Not dr.HasRows Then
            If ds.Tables(0).Rows.Count = 0 Then
                Dim save As String
                save = "INSERT INTO tbl_mobil (Kode_Mobil, Nama_Mobil, Tarif_Per_Jam, Tarif_Per_Hari, Tarif_Supir_Per_Jam, Tarif_Supir_Per_Hari) VALUES (@kode, @nama, @taperja, @taperha, @tasuperja, @tasuperha)"
                cmd = New MySqlCommand(save, conn)
                cmd.Parameters.AddWithValue("@kode", kode.Text)
                cmd.Parameters.AddWithValue("@nama", nama.Text)
                cmd.Parameters.AddWithValue("@taperja", tmpj.Text)
                cmd.Parameters.AddWithValue("@taperha", tmph.Text)
                cmd.Parameters.AddWithValue("@tasuperja", tspj.Text)
                cmd.Parameters.AddWithValue("@tasuperha", tsph.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Simpan Berhasil")
            Else
                Dim edit As String
                edit = "UPDATE tbl_mobil SET Nama_Mobil = @nama, Tarif_Per_Jam = @taperja, Tarif_Per_Hari = @taperha, Tarif_Supir_Per_Jam = @tasuperja, Tarif_Supir_Per_Hari = @tasuperha WHERE Kode_Mobil = @kd"
                cmd = New MySqlCommand(edit, conn)
                cmd.Parameters.AddWithValue("@nama", nama.Text)
                cmd.Parameters.AddWithValue("@taperja", tmpj.Text)
                cmd.Parameters.AddWithValue("@taperha", tmph.Text)
                cmd.Parameters.AddWithValue("@tasuperja", tspj.Text)
                cmd.Parameters.AddWithValue("@tasuperha", tsph.Text)
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

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        On Error Resume Next
        kode.Text = dgv.Rows(e.RowIndex).Cells(0).Value
        nama.Text = dgv.Rows(e.RowIndex).Cells(1).Value
        tmpj.Text = dgv.Rows(e.RowIndex).Cells(2).Value
        tmph.Text = dgv.Rows(e.RowIndex).Cells(3).Value
        tspj.Text = dgv.Rows(e.RowIndex).Cells(4).Value
        tsph.Text = dgv.Rows(e.RowIndex).Cells(5).Value
    End Sub

    Private Sub Delbtn_Click(sender As Object, e As EventArgs) Handles delbtn.Click
        If kode.Text = "" Then
            MsgBox("Kode Supir Harus Di isi !")
            kode.Select()
        End If
        If MessageBox.Show("Yakin mau dihapus ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim del As String
            del = "DELETE FROM tbl_mobil WHERE Kode_Mobil='" & kode.Text & "'"
            cmd = New MySqlCommand(del, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus")
            Call Clean()
        Else
            Call Clean()
        End If
    End Sub

    Private Sub Kode_LostFocus(sender As Object, e As EventArgs) Handles kode.LostFocus
        sql = "SELECT * FROM tbl_mobil WHERE Kode_Mobil='" & kode.Text & "'"
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
End Class