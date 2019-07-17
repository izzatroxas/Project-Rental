Imports MySql.Data.MySqlClient
Imports Project_Rental.Sql_com
Public Class Pinjam

    Sub Idpin()
        Call Koneksi()
        sql = "SELECT Kode_Pinjam FROM tbl_pinjam ORDER BY Kode_Pinjam DESC"
        cmd = New MySqlCommand(sql, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        ''Dim ds As New DataSet
        ''ds = Sql_dataset(sql)
        If Not dr.HasRows Then
            ''If ds.Tables(0).Rows.Count = 0 Then
            kode.Text = "A0001"
        Else
            kode.Text = "A" + Format(Microsoft.VisualBasic.Right(dr.Item("Kode_Pinjam"), 4) + 1, "0000")
        End If
        dr.Close()
    End Sub

    Sub Clean()
        tgl_pin.Value = Today ''belum bisa di format ke text ganti ke Value FIX
        tgl_ber.Value = Today ''belum bisa di format ke text gabtu ke Value FIX
        ktp.Clear()
        nama.Clear()
        alamat.Clear()
        hp.Clear()
        uang_muka.Clear()
        lbl_tot_biaya.Text = ""
        lbl_kode_mob.Text = ""
        lbl_kode_supir.Text = ""
        lbl_ss_pemb.Text = ""
        jp.Text = ""
        KK.Text = ""
        kode_mob.Text = ""
        kode_sup.Text = ""
        rencana.Text = ""
        durasi.Text = ""
        stts_pem.Text = ""
        dgv2.Columns.Clear()
    End Sub

    Sub Found()
        Call Koneksi()
        kode.Text = dr("Kode_Pinjam")
        tgl_pin.Value = dr("Tanggal_Pinjam")
        KK.Text = dr("Kartu_Keluarga")
        ktp.Text = dr("KTP")
        nama.Text = dr("Nama_Customer")
        alamat.Text = dr("Alamat")
        hp.Text = dr("Telp_HP")
        jp.Text = dr("Jenis_Pinjam")
        tgl_ber.Value = dr("Tanggal_Berangkat")
        jam_ber.Text = dr("Jam_Berangkat")
        lbl_kode_mob.Text = dr("Kode_Mobil")
        lbl_kode_supir.Text = dr("Kode_Supir")
        rencana.Text = dr("Rencana_Lama_Pinjam")
        durasi.Text = dr("Durasi")
        lbl_tot_biaya.Text = dr("Total_Biaya")
        uang_muka.Text = dr("Uang_Muka")
        lbl_ss_pemb.Text = dr("Sisa")
        stts_pem.Text = dr("Status_Pinjam")

        'TABLE SUPIR
        sql = "SELECT * FROM tbl_supir WHERE Kode_Supir='" & lbl_kode_supir.Text & "'"
        cmd = New MySqlCommand(sql, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        ''Dim ds As New DataSet
        ''ds = Sql_dataset(sql)
        ''If ds.Tables(0).Rows.Count = 0 Then
        If dr.HasRows Then
            kode_sup = dr("Nama_Supir")
        End If
        dr.Close()

        'TABLE MOBIL
        sql = "SELECT * FROM tbl_mobil WHERE Kode_Mobil='" & lbl_kode_mob.Text & "'"
        cmd = New MySqlCommand(sql, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            ''Dim da As New DataSet
            ''da = Sql_dataset(sql)
            ''If da.Tables(0).Rows.Count = 0 Then
            kode_mob = dr("Nama_Mobil")
        End If
        dr.Close()

    End Sub

    'Sub Show()
    '   kode.Text = dr("Kode_Pinjam")
    '  sql = "SELECT * FROM tbl_pinjam WHERE Kode_Pinjam='" & kode.Text & "'"
    ' cmd = New MySqlCommand(sql, conn)
    'dr = cmd.ExecuteReader
    'dr.Read()
    'If dr.HasRows Then
    '       ktp.Text = dr("KTP")
    '      nama.Text = dr("Nama_Customer")
    '     alamat.Text = dr("Alamat")
    '    hp.Text = dr("Telp_HP")
    '   jp.Text = dr("Jenis_Pinjam")
    '  tgl_ber.Value = dr("Tanggal_Berangkat")
    ' jam_ber.Text = dr("Jam_Berangkat")
    ' lbl_kode_mob.Text = dr("Kode_Mobil")
    ' lbl_kode_supir.Text = dr("Kode_Supir")
    '  rencana.Text = dr("Rencana_Lama_Pinjam")
    '  durasi.Text = dr("Durasi")
    '  lbl_tot_biaya.Text = FormatNumber(dr("Total_Biaya"), 0)
    '  uang_muka.Text = FormatNumber(dr("Uang_Muka"), 0)
    '  lbl_ss_pemb.Text = FormatNumber(dr("Sisa"), 0)
    '  stts_pem.Text = dr("Status_Pinjam")
    'End If
    'End Sub

    Sub Searchkodepinjam()
        Call Koneksi()
        sql = "SELECT * FROM tbl_pinjam WHERE Kode_Pinjam='" & kode.Text & "'"
        ''Dim ds As New DataSet
        ''ds = Sql_dataset(sql)
        dr = cmd.ExecuteReader
        dr.Read()
    End Sub

    Sub Grid()
        sql = "SELECT Kode_Pinjam, Tanggal_Pinjam, Nama_Customer, Kode_Mobil, Total_Biaya, Uang_Muka FROM tbl_pinjam"
        ds = Sql_dataset(sql)
        ''If ds.Tables.Count > 0 Then
        dgv.DataSource = ds.Tables(0)
        dgv.ReadOnly = True
        '---Format Angka 000 Belum Fix
        dgv.Columns(4).ValueType = GetType(Decimal)
        dgv.Columns(5).ValueType = GetType(Decimal)
        dgv.Columns(6).ValueType = GetType(Decimal)
        '---Format Alignt Center Testing
        dgv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        ''End If
    End Sub

    Sub Smobil()
        Call Koneksi()
        sql = "SELECT * FROM tbl_mobil WHERE Status_Mobil='Ada'"
        cmd = New MySqlCommand(sql, conn)
        dr = cmd.ExecuteReader
        ''Dim ds As New DataSet
        ''ds = Sql_dataset(sql)
        kode_mob.Items.Clear()
        Do While dr.Read
            kode_mob.Items.Add(dr.Item(1))
        Loop
        dr.Close()
    End Sub

    Sub Ssupir()
        Call Koneksi()
        sql = "SELECT * FROM tbl_supir WHERE Status_Supir='Ada'"
        ''Dim ds As New DataSet
        ''ds = Sql_dataset(sql)
        cmd = New MySqlCommand(sql, conn)
        dr = cmd.ExecuteReader
        kode_sup.Items.Clear()
        Do While dr.Read
            kode_sup.Items.Add(dr.Item(1))
        Loop
        dr.Close()
    End Sub

    Sub SLP()
        ''Call Koneksi()
        For lama As Integer = 1 To 30
            rencana.Items.Add(lama)
        Next
    End Sub

    Sub MSP()
        ''Call Koneksi()
        ''Dim tm As String = "HH:MM"
        ''Dim dt As DateTime
        ''dt = Convert.ToString(tm)
        sql = "SELECT tbl_mobil.Kode_Mobil, Nama_Mobil, Status_Mobil, tbl_pinjam.Tanggal_Berangkat, Jam_Berangkat, Status_Pinjam FROM tbl_mobil LEFT JOIN tbl_pinjam ON tbl_mobil.Kode_Mobil = tbl_pinjam.Kode_Mobil"
        ds = Sql_dataset(sql)
        ''If ds.Tables.Count > 0 Then
        dgv3.DataSource = ds.Tables(0)
        dgv3.ReadOnly = True
        dgv3.Columns(4).DefaultCellStyle.Format = "HH:MM"
    End Sub
    Private Sub Pinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Call Koneksi()
        Call Idpin()
        Call Smobil()
        Call Ssupir()
        Call SLP()
        Call Grid()
        Call MSP()
        dr.Close()
    End Sub

    Private Sub Kode_mob_GotFocus(sender As Object, e As EventArgs) Handles kode_mob.GotFocus
        uang_muka.Clear()
        lbl_ss_pemb.Text = ""
        Dim edit_mob As String
        edit_mob = "UPDATE tbl_mobil SET Status_Mobil='Ada' WHERE Kode_Mobil ='" * lbl_kode_mob.Text & "'"
        cmd = New MySqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Kode_mob_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kode_mob.SelectedIndexChanged
        Call Koneksi()
        sql = "SELECT * FROM tbl_mobil WHERE Nama_Mobil='" & kode_mob.Text & "'"
        cmd = New MySqlCommand(sql, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            ''Dim ds As New DataSet
            ''ds = Sql_dataset(sql)
            ''If ds.Tables(0).Rows.Count > 0 Then
            lbl_kode_mob.Text = dr.Item(0)
        End If
        dr.Close()

        On Error Resume Next

        If durasi.Text = "Jam" And kode_sup.Text = "" Then
            lbl_tot_biaya.Text = Val(rencana.Text) * dgv2.Rows(0).Cells(2).Value
        ElseIf durasi.Text = "Jam" And kode_sup.Text <> "" Then
            lbl_tot_biaya.Text = (Val(rencana.Text) * dgv2.Rows(0).Cells(2).Value) + (Val(rencana.Text) * dgv2.Rows(0).Cells(4).Value)
        ElseIf durasi.Text = "Hari" And kode_sup.Text = "" Then
            lbl_tot_biaya.Text = Val(rencana.Text) * dgv2.Rows(0).Cells(3).Value
        ElseIf durasi.Text = "Hari" And kode_sup.Text <> "" Then
            lbl_tot_biaya.Text = (Val(rencana.Text) * dgv2.Rows(0).Cells(3).Value) + (Val(rencana.Text) * dgv2.Rows(0).Cells(5).Value)
        End If
        'dr.Close()
    End Sub

    Private Sub Kode_sup_GotFocus(sender As Object, e As EventArgs) Handles kode_sup.GotFocus
        uang_muka.Clear()
        lbl_ss_pemb.Text = ""
        Dim edit_sup As String
        edit_sup = "UPDATE tbl_supir SET Status_Supir='Ada' WHERE Kode_Supir" * lbl_kode_supir.Text & "'"
        cmd = New MySqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Kode_sup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kode_sup.SelectedIndexChanged
        Call Koneksi()
        sql = "SELECT * FROM tbl_supir WHERE Nama_Supir='" & kode_sup.Text & "'"
        cmd = New MySqlCommand(sql, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            ''Dim ds As New DataSet
            ''ds = Sql_dataset(sql)
            ''If ds.Tables(0).Rows.Count > 0 Then
            lbl_kode_supir.Text = dr.Item(0)
        End If
        dr.Close()

        'On Error Resume Next
        If durasi.Text = "Jam" And kode_sup.Text = "" Then
            lbl_tot_biaya.Text = Val(rencana.Text) * dgv2.Rows(0).Cells(2).Value
        ElseIf durasi.Text = "Jam" And kode_sup.Text <> "" Then
            lbl_tot_biaya.Text = (Val(rencana.Text) * dgv2.Rows(0).Cells(2).Value) + (Val(rencana.Text) * dgv2.Rows(0).Cells(4).Value)
        ElseIf durasi.Text = "Hari" And kode_sup.Text = "" Then
            lbl_tot_biaya.Text = Val(rencana.Text) * dgv2.Rows(0).Cells(3).Value
        ElseIf durasi.Text = "Hari" And kode_sup.Text <> "" Then
            lbl_tot_biaya.Text = (Val(rencana.Text) * dgv2.Rows(0).Cells(3).Value) + (Val(rencana.Text) * dgv2.Rows(0).Cells(5).Value)
        End If
        'dr.Close()
    End Sub

    Private Sub Jp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles jp.SelectedIndexChanged
        If jp.Text = "Sama Supir" Then
            kode_sup.Enabled = True
        Else kode_sup.Enabled = False
            kode_sup.Text = ""
        End If
        uang_muka.Clear()
        lbl_ss_pemb.Text = ""
    End Sub

    Private Sub Durasi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles durasi.SelectedIndexChanged
        'On Error Resume Next
        If durasi.Text = "Jam" And kode_sup.Text = "" Then
            lbl_tot_biaya.Text = Val(rencana.Text) * dgv2.Rows(0).Cells(2).Value
        ElseIf durasi.Text = "Jam" And kode_sup.Text <> "" Then
            lbl_tot_biaya.Text = (Val(rencana.Text) * dgv2.Rows(0).Cells(2).Value) + (Val(rencana.Text) * dgv2.Rows(0).Cells(4).Value)
        ElseIf durasi.Text = "Hari" And kode_sup.Text = "" Then
            lbl_tot_biaya.Text = Val(rencana.Text) * dgv2.Rows(0).Cells(3).Value
        ElseIf durasi.Text = "Hari" And kode_sup.Text <> "" Then
            lbl_tot_biaya.Text = (Val(rencana.Text) * dgv2.Rows(0).Cells(3).Value) + (Val(rencana.Text) * dgv2.Rows(0).Cells(5).Value)
        End If
    End Sub

    Private Sub Rencana_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rencana.SelectedIndexChanged
        durasi.Text = ""
        lbl_tot_biaya.Text = ""
    End Sub

    Private Sub Uang_muka_KeyDown(sender As Object, e As KeyEventArgs) Handles uang_muka.KeyDown
        If Val(uang_muka.Text) >= Val(lbl_tot_biaya.Text) Then
            lbl_ss_pemb.Text = 0
        Else
            lbl_ss_pemb.Text = Val(lbl_tot_biaya.Text) - Val(uang_muka.Text)
            lbl_ss_pemb.Text = FormatNumber(lbl_ss_pemb.Text, 0)
        End If
    End Sub

    Private Sub Bbtn_Click(sender As Object, e As EventArgs) Handles bbtn.Click
        Call Clean()
    End Sub

    Private Sub Cbtn_Click(sender As Object, e As EventArgs) Handles cbtn.Click
        Me.Close()
    End Sub

    Sub FoundKTP()
        Call Koneksi()
        nama.Text = dr.Item("Nama_Customer")
        alamat.Text = dr.Item("Alamat")
        hp.Text = dr.Item("Telp_Hp")
    End Sub

    Private Sub Ktp_KeyDown(sender As Object, e As KeyEventArgs) Handles ktp.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Koneksi()
            sql = "SELECT * FROM tbl_pinjam WHERE KTP='" & ktp.Text & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                ''Dim ds As New DataSet
                ''ds = Sql_dataset(sql)
                ''If ds.Tables(0).Rows.Count = 0 Then
                Call FoundKTP()
            End If
            dr.Close()
        End If
    End Sub

    Private Sub Stts_pem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles stts_pem.SelectedIndexChanged
        If stts_pem.Text = "Booking" Then
            Call Koneksi()
            sql = "SELECT * FROM tbl_pinjam WHERE Tanggal_Pinjam='" & tgl_pin.Value & "' AND Kode_Mobil='" & lbl_kode_mob.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                ''Dim ds As New DataSet
                '' ds = Sql_dataset(sql)
                ''If ds.Tables(0).Rows.Count > 0 Then
                MsgBox("Booking Tidak Tersedia")
            End If
            dr.Close()
        End If
    End Sub

    Private Sub Sbtn_Click(sender As Object, e As EventArgs) Handles sbtn.Click
        Try
            Call Koneksi()
            sql = "SELECT * FROM tbl_pinjam WHERE Kode_Pinjam='" & kode.Text & "'"
            ''Dim ds As New DataSet
            ''ds = Sql_dataset(sql)
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            'Try
            If Not dr.HasRows Then
                ''If ds.Tables(0).Rows.Count = 0 Then
                Dim save As String
                ''"SELECT Kode_Pinjam, Tanggal_Pinjam, Nama_Customer, Kode_Mobil, Total_Biaya, Uang_Muka FROM tbl_pinjam"
                save = "INSERT INTO tbl_pinjam (Kode_Pinjam, Tanggal_Pinjam, Nama_Customer, Kode_Mobil, Total_Biaya, Uang_Muka) VALUES (@kode, @tp, @nc, @km, @tb, @um)"
                cmd = New MySqlCommand(save, conn)
                cmd.Parameters.AddWithValue("@kode", kode.Text)
                cmd.Parameters.AddWithValue("@tp", tgl_pin.Text)
                cmd.Parameters.AddWithValue("@nc", nama.Text)
                cmd.Parameters.AddWithValue("@km", kode_mob.Text)
                cmd.Parameters.AddWithValue("@tb", lbl_tot_biaya.Text)
                cmd.Parameters.AddWithValue("@um", uang_muka.Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Simpan Berhasil")
            Else
                Dim edit As String
                edit = "UPDATE tbl_supir SET Nama_Customer = @nama, Tanggal_Pinjam = @tp, Kode_Mobil= @km. Total_Biaya= @tb, Uang_Muka=@um WHERE Kode_Pinjam = @kd"
                cmd = New MySqlCommand(edit, conn)
                cmd.Parameters.AddWithValue("@nama", nama.Text)
                cmd.Parameters.AddWithValue("@tp", tgl_pin.Value)
                cmd.Parameters.AddWithValue("@km", kode_mob.Text)
                cmd.Parameters.AddWithValue("@tb", lbl_tot_biaya.Text)
                cmd.Parameters.AddWithValue("@um", uang_muka.Text)
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
        Call Koneksi()
        kode.Text = dgv.Rows(e.RowIndex).Cells(0).Value
        Call Searchkodepinjam()
        If dr.HasRows Then
            Call Found()
        End If

        If stts_pem.Text = "Booking" Then
            stts_pem.Enabled = True
        Else
            stts_pem.Enabled = False
        End If
        dr.Close()
    End Sub

    Private Sub Lbl_kode_mob_TextChanged(sender As Object, e As EventArgs) Handles lbl_kode_mob.TextChanged
        ''Call Koneksi()
        dr.Close()
        sql = "SELECT * FROM tbl_mobil WHERE Kode_Mobil='" & lbl_kode_mob.Text & "'"
        cmd = New MySqlCommand(sql, conn)
        ds = Sql_dataset(sql)
        ''ds.Tables.Count > 0 Then
        ''da = New MySqlDataAdapter(sql, conn)
        ''ds = New DataSet
        ''da.Fill(ds)
        dgv2.DataSource = ds.Tables(0)
        dgv2.ReadOnly = True
        ''Get Type
        dgv2.Columns(2).ValueType = GetType(Decimal)
        dgv2.Columns(3).ValueType = GetType(Decimal)
        dgv2.Columns(4).ValueType = GetType(Decimal)
        dgv2.Columns(5).ValueType = GetType(Decimal)
    End Sub

    Private Sub Lbl_tot_biaya_TextChanged(sender As Object, e As EventArgs) Handles lbl_tot_biaya.TextChanged
        On Error Resume Next
        ''lbl_tot_biaya.Text = FormatNumber(lbl_tot_biaya.Text, 0)
        lbl_tot_biaya.TabIndex = FormatNumber(lbl_tot_biaya.Text, 0)
    End Sub

    Private Sub Uang_muka_TextChanged(sender As Object, e As EventArgs) Handles uang_muka.TextChanged
        On Error Resume Next
        uang_muka.Text = FormatNumber(uang_muka.Text, 0)
        uang_muka.SelectionStart = Len(uang_muka.Text)
    End Sub

    Private Sub Lbl_ss_pemb_TextChanged(sender As Object, e As EventArgs) Handles lbl_ss_pemb.TextChanged
        On Error Resume Next
        lbl_ss_pemb.Text = FormatNumber(lbl_ss_pemb.Text, 0)
    End Sub

End Class