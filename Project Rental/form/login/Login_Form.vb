Imports MySql.Data.MySqlClient
Public Class Login
    Public id As String
    Dim hitung As Integer
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Call Masuk()
    End Sub

    Sub Masuk()
        Call koneksi()
        Dim user As String
        Dim pass As String
        Dim rt As New DataTable
        user = Tnama.Text
        pass = Tpassword.Text
        If user = "" And pass = "" Then
            MsgBox("Username dan Password Kosong")

        ElseIf user = "" Then
            MsgBox("Isi Username!")
        ElseIf pass = "" Then
            MsgBox("Isi Password!")
        Else
            'Select t1.Kode_User,t2.Type FROM tbl_user t1 INNER JOIN tbl_user_detail t2 On t1.Kode_User = t2.Kode_
            'user WHERE t1.Nama_User='" & user & "' && t1.Pwd_User ='" & pass & "';"
            sql = "Select t1.Kode_User,t2.Status_User FROM tbl_user t1 INNER JOIN tbl_user_detail t2 On t1.Kode_User = t2.Kode_User WHERE t1.Nama_User='" & user & "' && t1.Pwd_User ='" & pass & "';"
            'sql = "SELECT * FROM tbl_user WHERE Nama_User='" & user & "' Pwd_User='" & pass & "'"
            da = New MySqlDataAdapter(sql, conn)
            da.Fill(rt)
            If rt.Rows.Count > 0 Then
                id = rt.Rows(0).Item(0)
                Dim tu As String = rt.Rows(0).Item(1)
                If tu = "ADMINISTRATOR" Or tu = "USER" Then
                    MsgBox("Login Berhasil : " + id)
                    Dim mm = New Main_Menu
                    mm.Show()
                    Me.Hide()
                Else
                    MsgBox("Tidak ada Otoritas")
                    Tnama.Text = ""
                    Tpassword.Text = ""
                End If

            Else
                MsgBox("Username atau Password salah")
                Tnama.Text = ""
                Tpassword.Text = ""
                hitung = hitung + 1
                If hitung = 3 Then
                    MsgBox("Login sudah 3x Salah!")
                    End
                End If
            End If

        End If

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        End
    End Sub
    Private Sub Tnama_KeyDown(sender As Object, e As KeyEventArgs) Handles Tnama.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tpassword.Select()
        End If
    End Sub

    Private Sub Tpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles Tpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            OK.Select()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Check() = True Then
            Label3.Text = String.Format("Beta {0} Version", My.Application.Info.Version.ToString)
            MessageBox.Show("Terkoneksi ke Server")
        Else
            Application.Exit()
        End If
    End Sub
End Class
