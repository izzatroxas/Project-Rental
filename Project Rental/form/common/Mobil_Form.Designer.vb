<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mobil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mobil))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.kode = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.tmpj = New System.Windows.Forms.TextBox()
        Me.tmph = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tspj = New System.Windows.Forms.TextBox()
        Me.tsph = New System.Windows.Forms.TextBox()
        Me.cbtn = New System.Windows.Forms.Button()
        Me.bbtn = New System.Windows.Forms.Button()
        Me.delbtn = New System.Windows.Forms.Button()
        Me.sbtn = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cari = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Mobil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Mobil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tarif Mobil Per Jam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tarif Mobil Per Hari"
        '
        'kode
        '
        Me.kode.Location = New System.Drawing.Point(115, 16)
        Me.kode.Name = "kode"
        Me.kode.Size = New System.Drawing.Size(114, 20)
        Me.kode.TabIndex = 4
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(115, 42)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(336, 20)
        Me.nama.TabIndex = 5
        '
        'tmpj
        '
        Me.tmpj.Location = New System.Drawing.Point(115, 69)
        Me.tmpj.Name = "tmpj"
        Me.tmpj.Size = New System.Drawing.Size(114, 20)
        Me.tmpj.TabIndex = 6
        '
        'tmph
        '
        Me.tmph.Location = New System.Drawing.Point(115, 95)
        Me.tmph.Name = "tmph"
        Me.tmph.Size = New System.Drawing.Size(114, 20)
        Me.tmph.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(235, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tarif Supir Per Jam"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(235, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tarif Supir Per Hari"
        '
        'tspj
        '
        Me.tspj.Location = New System.Drawing.Point(337, 68)
        Me.tspj.Name = "tspj"
        Me.tspj.Size = New System.Drawing.Size(114, 20)
        Me.tspj.TabIndex = 10
        '
        'tsph
        '
        Me.tsph.Location = New System.Drawing.Point(337, 94)
        Me.tsph.Name = "tsph"
        Me.tsph.Size = New System.Drawing.Size(114, 20)
        Me.tsph.TabIndex = 11
        '
        'cbtn
        '
        Me.cbtn.Image = CType(resources.GetObject("cbtn.Image"), System.Drawing.Image)
        Me.cbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cbtn.Location = New System.Drawing.Point(395, 135)
        Me.cbtn.Name = "cbtn"
        Me.cbtn.Size = New System.Drawing.Size(59, 25)
        Me.cbtn.TabIndex = 18
        Me.cbtn.Text = "Close"
        Me.cbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbtn.UseVisualStyleBackColor = True
        '
        'bbtn
        '
        Me.bbtn.Image = CType(resources.GetObject("bbtn.Image"), System.Drawing.Image)
        Me.bbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bbtn.Location = New System.Drawing.Point(332, 135)
        Me.bbtn.Name = "bbtn"
        Me.bbtn.Size = New System.Drawing.Size(57, 25)
        Me.bbtn.TabIndex = 17
        Me.bbtn.Text = "Back"
        Me.bbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bbtn.UseVisualStyleBackColor = True
        '
        'delbtn
        '
        Me.delbtn.Image = CType(resources.GetObject("delbtn.Image"), System.Drawing.Image)
        Me.delbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.delbtn.Location = New System.Drawing.Point(262, 135)
        Me.delbtn.Name = "delbtn"
        Me.delbtn.Size = New System.Drawing.Size(64, 25)
        Me.delbtn.TabIndex = 16
        Me.delbtn.Text = "Delete"
        Me.delbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.delbtn.UseVisualStyleBackColor = True
        '
        'sbtn
        '
        Me.sbtn.Image = CType(resources.GetObject("sbtn.Image"), System.Drawing.Image)
        Me.sbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sbtn.Location = New System.Drawing.Point(197, 134)
        Me.sbtn.Name = "sbtn"
        Me.sbtn.Size = New System.Drawing.Size(59, 26)
        Me.sbtn.TabIndex = 15
        Me.sbtn.Text = "Save"
        Me.sbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.sbtn.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(7, 173)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(452, 157)
        Me.dgv.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cari)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 120)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(229, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Search"
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(276, 16)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(169, 20)
        Me.cari.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(192, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 46)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'Mobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(463, 329)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.cbtn)
        Me.Controls.Add(Me.bbtn)
        Me.Controls.Add(Me.delbtn)
        Me.Controls.Add(Me.sbtn)
        Me.Controls.Add(Me.tsph)
        Me.Controls.Add(Me.tspj)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tmph)
        Me.Controls.Add(Me.tmpj)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.kode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Mobil"
        Me.Text = "Mobil"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents kode As TextBox
    Friend WithEvents nama As TextBox
    Friend WithEvents tmpj As TextBox
    Friend WithEvents tmph As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tspj As TextBox
    Friend WithEvents tsph As TextBox
    Friend WithEvents cbtn As Button
    Friend WithEvents bbtn As Button
    Friend WithEvents delbtn As Button
    Friend WithEvents sbtn As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cari As TextBox
End Class
