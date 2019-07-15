<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pinjam
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pinjam))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.KK = New System.Windows.Forms.ComboBox()
        Me.jp = New System.Windows.Forms.ComboBox()
        Me.kode_mob = New System.Windows.Forms.ComboBox()
        Me.kode_sup = New System.Windows.Forms.ComboBox()
        Me.rencana = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_kode_mob = New System.Windows.Forms.Label()
        Me.lbl_kode_supir = New System.Windows.Forms.Label()
        Me.durasi = New System.Windows.Forms.ComboBox()
        Me.jam_ber = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.stts_pem = New System.Windows.Forms.ComboBox()
        Me.uang_muka = New System.Windows.Forms.TextBox()
        Me.ktp = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.hp = New System.Windows.Forms.TextBox()
        Me.cbtn = New System.Windows.Forms.Button()
        Me.bbtn = New System.Windows.Forms.Button()
        Me.delbtn = New System.Windows.Forms.Button()
        Me.sbtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tgl_ber = New System.Windows.Forms.DateTimePicker()
        Me.tgl_pin = New System.Windows.Forms.DateTimePicker()
        Me.lbl_ss_pemb = New System.Windows.Forms.Label()
        Me.lbl_tot_biaya = New System.Windows.Forms.Label()
        Me.kode = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.dgv3 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(14, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Pinjam"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(14, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 21)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Tanggal Pinjam"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(14, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 21)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Kartu Keluarga"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(14, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 21)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Jenis Pinjam"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(14, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 21)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Kode Mobil"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(14, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 21)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Kode Supir"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(14, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 21)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Rencana Lama Pinjam"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(14, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 21)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Tgl - Jam Berangkat"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KK
        '
        Me.KK.FormattingEnabled = True
        Me.KK.Location = New System.Drawing.Point(142, 65)
        Me.KK.Name = "KK"
        Me.KK.Size = New System.Drawing.Size(121, 21)
        Me.KK.TabIndex = 25
        '
        'jp
        '
        Me.jp.FormattingEnabled = True
        Me.jp.Items.AddRange(New Object() {"Sama Supir", "Tanpa Supir"})
        Me.jp.Location = New System.Drawing.Point(142, 96)
        Me.jp.Name = "jp"
        Me.jp.Size = New System.Drawing.Size(121, 21)
        Me.jp.TabIndex = 26
        '
        'kode_mob
        '
        Me.kode_mob.FormattingEnabled = True
        Me.kode_mob.Location = New System.Drawing.Point(142, 117)
        Me.kode_mob.Name = "kode_mob"
        Me.kode_mob.Size = New System.Drawing.Size(121, 21)
        Me.kode_mob.TabIndex = 27
        '
        'kode_sup
        '
        Me.kode_sup.FormattingEnabled = True
        Me.kode_sup.Location = New System.Drawing.Point(142, 138)
        Me.kode_sup.Name = "kode_sup"
        Me.kode_sup.Size = New System.Drawing.Size(121, 21)
        Me.kode_sup.TabIndex = 28
        '
        'rencana
        '
        Me.rencana.FormattingEnabled = True
        Me.rencana.Location = New System.Drawing.Point(142, 159)
        Me.rencana.Name = "rencana"
        Me.rencana.Size = New System.Drawing.Size(121, 21)
        Me.rencana.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(269, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 21)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "No KTP Customer"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(269, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 21)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Nama Customer"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(269, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 21)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Alamat"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(269, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 21)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "No Handphone"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_kode_mob
        '
        Me.lbl_kode_mob.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_kode_mob.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_kode_mob.Location = New System.Drawing.Point(269, 117)
        Me.lbl_kode_mob.Name = "lbl_kode_mob"
        Me.lbl_kode_mob.Size = New System.Drawing.Size(121, 21)
        Me.lbl_kode_mob.TabIndex = 36
        Me.lbl_kode_mob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_kode_supir
        '
        Me.lbl_kode_supir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_kode_supir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_kode_supir.Location = New System.Drawing.Point(269, 138)
        Me.lbl_kode_supir.Name = "lbl_kode_supir"
        Me.lbl_kode_supir.Size = New System.Drawing.Size(121, 21)
        Me.lbl_kode_supir.TabIndex = 37
        Me.lbl_kode_supir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'durasi
        '
        Me.durasi.FormattingEnabled = True
        Me.durasi.Items.AddRange(New Object() {"Jam", "Hari"})
        Me.durasi.Location = New System.Drawing.Point(269, 159)
        Me.durasi.Name = "durasi"
        Me.durasi.Size = New System.Drawing.Size(121, 21)
        Me.durasi.TabIndex = 38
        '
        'jam_ber
        '
        Me.jam_ber.Location = New System.Drawing.Point(269, 179)
        Me.jam_ber.Name = "jam_ber"
        Me.jam_ber.Size = New System.Drawing.Size(121, 20)
        Me.jam_ber.TabIndex = 39
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(396, 117)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(121, 21)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Total Biaya"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(396, 138)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(121, 21)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Uang Muka"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(396, 159)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(121, 21)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Sisa Pembayaran"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(396, 181)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(121, 21)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Status Peminjaman"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'stts_pem
        '
        Me.stts_pem.FormattingEnabled = True
        Me.stts_pem.Items.AddRange(New Object() {"Booking", "Jalan"})
        Me.stts_pem.Location = New System.Drawing.Point(523, 180)
        Me.stts_pem.Name = "stts_pem"
        Me.stts_pem.Size = New System.Drawing.Size(121, 21)
        Me.stts_pem.TabIndex = 46
        '
        'uang_muka
        '
        Me.uang_muka.Location = New System.Drawing.Point(523, 138)
        Me.uang_muka.Name = "uang_muka"
        Me.uang_muka.Size = New System.Drawing.Size(121, 20)
        Me.uang_muka.TabIndex = 47
        '
        'ktp
        '
        Me.ktp.Location = New System.Drawing.Point(396, 23)
        Me.ktp.Name = "ktp"
        Me.ktp.Size = New System.Drawing.Size(248, 20)
        Me.ktp.TabIndex = 48
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(396, 44)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(248, 20)
        Me.nama.TabIndex = 49
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(396, 65)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(248, 20)
        Me.alamat.TabIndex = 50
        '
        'hp
        '
        Me.hp.Location = New System.Drawing.Point(396, 86)
        Me.hp.Name = "hp"
        Me.hp.Size = New System.Drawing.Size(248, 20)
        Me.hp.TabIndex = 51
        '
        'cbtn
        '
        Me.cbtn.Image = CType(resources.GetObject("cbtn.Image"), System.Drawing.Image)
        Me.cbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cbtn.Location = New System.Drawing.Point(581, 228)
        Me.cbtn.Name = "cbtn"
        Me.cbtn.Size = New System.Drawing.Size(59, 25)
        Me.cbtn.TabIndex = 55
        Me.cbtn.Text = "Close"
        Me.cbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbtn.UseVisualStyleBackColor = True
        '
        'bbtn
        '
        Me.bbtn.Image = CType(resources.GetObject("bbtn.Image"), System.Drawing.Image)
        Me.bbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bbtn.Location = New System.Drawing.Point(518, 228)
        Me.bbtn.Name = "bbtn"
        Me.bbtn.Size = New System.Drawing.Size(57, 25)
        Me.bbtn.TabIndex = 54
        Me.bbtn.Text = "Back"
        Me.bbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bbtn.UseVisualStyleBackColor = True
        '
        'delbtn
        '
        Me.delbtn.Image = CType(resources.GetObject("delbtn.Image"), System.Drawing.Image)
        Me.delbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.delbtn.Location = New System.Drawing.Point(448, 228)
        Me.delbtn.Name = "delbtn"
        Me.delbtn.Size = New System.Drawing.Size(64, 25)
        Me.delbtn.TabIndex = 53
        Me.delbtn.Text = "Delete"
        Me.delbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.delbtn.UseVisualStyleBackColor = True
        '
        'sbtn
        '
        Me.sbtn.Image = CType(resources.GetObject("sbtn.Image"), System.Drawing.Image)
        Me.sbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sbtn.Location = New System.Drawing.Point(383, 228)
        Me.sbtn.Name = "sbtn"
        Me.sbtn.Size = New System.Drawing.Size(59, 26)
        Me.sbtn.TabIndex = 52
        Me.sbtn.Text = "Save"
        Me.sbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.sbtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(377, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 46)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tgl_ber)
        Me.GroupBox1.Controls.Add(Me.tgl_pin)
        Me.GroupBox1.Controls.Add(Me.lbl_ss_pemb)
        Me.GroupBox1.Controls.Add(Me.lbl_tot_biaya)
        Me.GroupBox1.Controls.Add(Me.kode)
        Me.GroupBox1.Location = New System.Drawing.Point(-8, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(676, 270)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        '
        'tgl_ber
        '
        Me.tgl_ber.Location = New System.Drawing.Point(150, 177)
        Me.tgl_ber.Name = "tgl_ber"
        Me.tgl_ber.Size = New System.Drawing.Size(121, 20)
        Me.tgl_ber.TabIndex = 61
        '
        'tgl_pin
        '
        Me.tgl_pin.Location = New System.Drawing.Point(150, 40)
        Me.tgl_pin.Name = "tgl_pin"
        Me.tgl_pin.Size = New System.Drawing.Size(121, 20)
        Me.tgl_pin.TabIndex = 60
        '
        'lbl_ss_pemb
        '
        Me.lbl_ss_pemb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ss_pemb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_ss_pemb.Location = New System.Drawing.Point(531, 158)
        Me.lbl_ss_pemb.Name = "lbl_ss_pemb"
        Me.lbl_ss_pemb.Size = New System.Drawing.Size(121, 21)
        Me.lbl_ss_pemb.TabIndex = 59
        Me.lbl_ss_pemb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_tot_biaya
        '
        Me.lbl_tot_biaya.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_tot_biaya.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_tot_biaya.Location = New System.Drawing.Point(531, 113)
        Me.lbl_tot_biaya.Name = "lbl_tot_biaya"
        Me.lbl_tot_biaya.Size = New System.Drawing.Size(121, 21)
        Me.lbl_tot_biaya.TabIndex = 59
        Me.lbl_tot_biaya.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'kode
        '
        Me.kode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.kode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.kode.Location = New System.Drawing.Point(150, 19)
        Me.kode.Name = "kode"
        Me.kode.Size = New System.Drawing.Size(121, 21)
        Me.kode.TabIndex = 59
        Me.kode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(8, 379)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(648, 262)
        Me.dgv.TabIndex = 58
        '
        'dgv2
        '
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Location = New System.Drawing.Point(11, 279)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.Size = New System.Drawing.Size(657, 77)
        Me.dgv2.TabIndex = 59
        '
        'dgv3
        '
        Me.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv3.Location = New System.Drawing.Point(661, 379)
        Me.dgv3.Name = "dgv3"
        Me.dgv3.Size = New System.Drawing.Size(647, 262)
        Me.dgv3.TabIndex = 60
        '
        'Pinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(1313, 653)
        Me.Controls.Add(Me.dgv3)
        Me.Controls.Add(Me.dgv2)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.cbtn)
        Me.Controls.Add(Me.bbtn)
        Me.Controls.Add(Me.delbtn)
        Me.Controls.Add(Me.sbtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.hp)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.ktp)
        Me.Controls.Add(Me.uang_muka)
        Me.Controls.Add(Me.stts_pem)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.jam_ber)
        Me.Controls.Add(Me.durasi)
        Me.Controls.Add(Me.lbl_kode_supir)
        Me.Controls.Add(Me.lbl_kode_mob)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.rencana)
        Me.Controls.Add(Me.kode_sup)
        Me.Controls.Add(Me.kode_mob)
        Me.Controls.Add(Me.jp)
        Me.Controls.Add(Me.KK)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pinjam"
        Me.Text = "Pinjam"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents KK As ComboBox
    Friend WithEvents jp As ComboBox
    Friend WithEvents kode_mob As ComboBox
    Friend WithEvents kode_sup As ComboBox
    Friend WithEvents rencana As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_kode_mob As Label
    Friend WithEvents lbl_kode_supir As Label
    Friend WithEvents durasi As ComboBox
    Friend WithEvents jam_ber As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents stts_pem As ComboBox
    Friend WithEvents uang_muka As TextBox
    Friend WithEvents ktp As TextBox
    Friend WithEvents nama As TextBox
    Friend WithEvents alamat As TextBox
    Friend WithEvents hp As TextBox
    Friend WithEvents cbtn As Button
    Friend WithEvents bbtn As Button
    Friend WithEvents delbtn As Button
    Friend WithEvents sbtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents lbl_ss_pemb As Label
    Friend WithEvents lbl_tot_biaya As Label
    Friend WithEvents kode As Label
    Friend WithEvents tgl_ber As DateTimePicker
    Friend WithEvents tgl_pin As DateTimePicker
    Friend WithEvents dgv2 As DataGridView
    Friend WithEvents dgv3 As DataGridView
End Class
