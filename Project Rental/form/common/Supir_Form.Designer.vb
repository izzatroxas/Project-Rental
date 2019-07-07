<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supir))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.telf = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.sbtn = New System.Windows.Forms.Button()
        Me.delbtn = New System.Windows.Forms.Button()
        Me.cbtn = New System.Windows.Forms.Button()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cari = New System.Windows.Forms.TextBox()
        Me.kode = New System.Windows.Forms.TextBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Supir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Supir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(90, 47)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(341, 20)
        Me.nama.TabIndex = 4
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(90, 74)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(133, 20)
        Me.alamat.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(229, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Telf / HP"
        '
        'telf
        '
        Me.telf.Location = New System.Drawing.Point(275, 66)
        Me.telf.Name = "telf"
        Me.telf.Size = New System.Drawing.Size(144, 20)
        Me.telf.TabIndex = 7
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(5, 154)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(454, 167)
        Me.dgv.TabIndex = 8
        '
        'sbtn
        '
        Me.sbtn.Image = CType(resources.GetObject("sbtn.Image"), System.Drawing.Image)
        Me.sbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sbtn.Location = New System.Drawing.Point(197, 117)
        Me.sbtn.Name = "sbtn"
        Me.sbtn.Size = New System.Drawing.Size(59, 26)
        Me.sbtn.TabIndex = 10
        Me.sbtn.Text = "Save"
        Me.sbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.sbtn.UseVisualStyleBackColor = True
        '
        'delbtn
        '
        Me.delbtn.Image = CType(resources.GetObject("delbtn.Image"), System.Drawing.Image)
        Me.delbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.delbtn.Location = New System.Drawing.Point(262, 118)
        Me.delbtn.Name = "delbtn"
        Me.delbtn.Size = New System.Drawing.Size(64, 25)
        Me.delbtn.TabIndex = 11
        Me.delbtn.Text = "Delete"
        Me.delbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.delbtn.UseVisualStyleBackColor = True
        '
        'cbtn
        '
        Me.cbtn.Image = CType(resources.GetObject("cbtn.Image"), System.Drawing.Image)
        Me.cbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cbtn.Location = New System.Drawing.Point(395, 118)
        Me.cbtn.Name = "cbtn"
        Me.cbtn.Size = New System.Drawing.Size(59, 25)
        Me.cbtn.TabIndex = 14
        Me.cbtn.Text = "Close"
        Me.cbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbtn.UseVisualStyleBackColor = True
        '
        'backbtn
        '
        Me.backbtn.Image = CType(resources.GetObject("backbtn.Image"), System.Drawing.Image)
        Me.backbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.backbtn.Location = New System.Drawing.Point(332, 118)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(57, 25)
        Me.backbtn.TabIndex = 13
        Me.backbtn.Text = "Back"
        Me.backbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.backbtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(192, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 46)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cari)
        Me.GroupBox1.Controls.Add(Me.kode)
        Me.GroupBox1.Controls.Add(Me.telf)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 95)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(219, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Search"
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(275, 11)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(144, 20)
        Me.cari.TabIndex = 25
        '
        'kode
        '
        Me.kode.Location = New System.Drawing.Point(79, 11)
        Me.kode.Name = "kode"
        Me.kode.Size = New System.Drawing.Size(133, 20)
        Me.kode.TabIndex = 24
        '
        'Supir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(463, 321)
        Me.Controls.Add(Me.cbtn)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.delbtn)
        Me.Controls.Add(Me.sbtn)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Supir"
        Me.Text = "Supir"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nama As TextBox
    Friend WithEvents alamat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents telf As TextBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents sbtn As Button
    Friend WithEvents delbtn As Button
    Friend WithEvents cbtn As Button
    Friend WithEvents backbtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents kode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cari As TextBox
End Class
