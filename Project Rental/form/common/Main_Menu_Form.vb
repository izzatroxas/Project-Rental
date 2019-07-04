Imports Project_Rental.Sql_com
Imports Project_Rental.Login
Public Class Main_Menu
    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        time.Enabled = True
        idu.Text = Login.id
        nid.Text = ""
        Call Getname()
    End Sub

    Sub Getname()
        Dim rn As New DataTable
        Dim cok = Login.id
        sql = "SELECT * FROM tbl_user WHERE Kode_User ='" & cok & "';"
        rn = Sql_datatable(sql)
        If rn.Rows.Count > 0 Then
            nid.Text = rn.Rows(0).Item(1)
        Else
            Application.Exit()
        End If
    End Sub
    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click

    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        User.Show()
    End Sub

    Private Sub SupirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupirToolStripMenuItem.Click
        Supir.Show()
    End Sub

    Private Sub MobilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MobilToolStripMenuItem.Click
        Mobil.Show()
    End Sub

    Private Sub PinjamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PinjamToolStripMenuItem.Click
        Pinjam.Show()
    End Sub

    Private Sub KembaliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KembaliToolStripMenuItem.Click
        Kembali.Show()
    End Sub

    Private Sub BiayaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BiayaToolStripMenuItem.Click
        Biaya.Show()
    End Sub

    Private Sub PinjamToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PinjamToolStripMenuItem1.Click
        Laporan_Peminjaman.Show()
    End Sub

    Private Sub KembaliToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KembaliToolStripMenuItem1.Click
        Laporan_Pengembalian.Show()
    End Sub

    Private Sub LabaRugiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LabaRugiToolStripMenuItem.Click
        Laba_Rugi.Show()
    End Sub

    Private Sub LogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub TutupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TutupToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        User.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Supir.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Mobil.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Pinjam.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Kembali.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Biaya.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Laporan_Peminjaman.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Laporan_Pengembalian.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Laba_Rugi.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Close()
    End Sub

    Private Sub Time_Tick(sender As Object, e As EventArgs) Handles time.Tick
        clock.Text = Date.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub
End Class