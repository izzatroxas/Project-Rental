<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.kode = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.stat = New System.Windows.Forms.ComboBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.save = New System.Windows.Forms.Button()
        Me.del = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.tutup = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.search = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode User"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama User"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'kode
        '
        Me.kode.Location = New System.Drawing.Point(78, 16)
        Me.kode.Name = "kode"
        Me.kode.Size = New System.Drawing.Size(130, 20)
        Me.kode.TabIndex = 3
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(78, 46)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(344, 20)
        Me.nama.TabIndex = 4
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(78, 75)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(130, 20)
        Me.pass.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(214, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Status User"
        '
        'stat
        '
        Me.stat.FormattingEnabled = True
        Me.stat.Items.AddRange(New Object() {"Administrator", "User"})
        Me.stat.Location = New System.Drawing.Point(282, 75)
        Me.stat.Name = "stat"
        Me.stat.Size = New System.Drawing.Size(140, 21)
        Me.stat.TabIndex = 7
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(7, 157)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(451, 169)
        Me.dgv.TabIndex = 8
        '
        'save
        '
        Me.save.Image = CType(resources.GetObject("save.Image"), System.Drawing.Image)
        Me.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.save.Location = New System.Drawing.Point(196, 117)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(59, 26)
        Me.save.TabIndex = 9
        Me.save.Text = "Save"
        Me.save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.save.UseVisualStyleBackColor = True
        '
        'del
        '
        Me.del.Image = CType(resources.GetObject("del.Image"), System.Drawing.Image)
        Me.del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.del.Location = New System.Drawing.Point(261, 117)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(64, 25)
        Me.del.TabIndex = 10
        Me.del.Text = "Delete"
        Me.del.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.del.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Image = CType(resources.GetObject("back.Image"), System.Drawing.Image)
        Me.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.back.Location = New System.Drawing.Point(331, 117)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(57, 25)
        Me.back.TabIndex = 11
        Me.back.Text = "Back"
        Me.back.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.back.UseVisualStyleBackColor = True
        '
        'tutup
        '
        Me.tutup.Image = CType(resources.GetObject("tutup.Image"), System.Drawing.Image)
        Me.tutup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tutup.Location = New System.Drawing.Point(394, 117)
        Me.tutup.Name = "tutup"
        Me.tutup.Size = New System.Drawing.Size(59, 25)
        Me.tutup.TabIndex = 12
        Me.tutup.Text = "Close"
        Me.tutup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tutup.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.search)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 100)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(229, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Search"
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(276, 14)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(140, 20)
        Me.search.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(190, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 46)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(463, 327)
        Me.Controls.Add(Me.tutup)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.del)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.stat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.kode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "User"
        Me.Text = "User"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents kode As TextBox
    Friend WithEvents nama As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents stat As ComboBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents save As Button
    Friend WithEvents del As Button
    Friend WithEvents back As Button
    Friend WithEvents tutup As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents search As TextBox
End Class
