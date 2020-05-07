<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txt_Ara = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Temizle = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_EkleyenKisi = New System.Windows.Forms.TextBox()
        Me.txt_StokAdedi = New System.Windows.Forms.TextBox()
        Me.txt_StokModeli = New System.Windows.Forms.TextBox()
        Me.txt_StokAdi = New System.Windows.Forms.TextBox()
        Me.txt_StokId = New System.Windows.Forms.TextBox()
        Me.lbl_EkleyenKisi = New System.Windows.Forms.Label()
        Me.lbl_StokAdedi = New System.Windows.Forms.Label()
        Me.lbl_StokModeli = New System.Windows.Forms.Label()
        Me.lbl_StokAdi = New System.Windows.Forms.Label()
        Me.lbl_Id = New System.Windows.Forms.Label()
        Me.dgStok = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Cikis = New System.Windows.Forms.Button()
        Me.btn_Ekle = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dtp_Tarih = New System.Windows.Forms.DateTimePicker()
        Me.txt_Aciklama = New System.Windows.Forms.TextBox()
        Me.lbl_Aciklama = New System.Windows.Forms.Label()
        Me.lbl_Tarih = New System.Windows.Forms.Label()
        Me.btn_Guncelle = New System.Windows.Forms.Button()
        Me.btn_Sil = New System.Windows.Forms.Button()
        CType(Me.dgStok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Location = New System.Drawing.Point(406, 68)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(446, 1)
        Me.Panel7.TabIndex = 43
        '
        'txt_Ara
        '
        Me.txt_Ara.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Ara.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Ara.Location = New System.Drawing.Point(412, 55)
        Me.txt_Ara.Name = "txt_Ara"
        Me.txt_Ara.Size = New System.Drawing.Size(334, 13)
        Me.txt_Ara.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(337, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Stok Arama"
        '
        'btn_Temizle
        '
        Me.btn_Temizle.Location = New System.Drawing.Point(227, 146)
        Me.btn_Temizle.Name = "btn_Temizle"
        Me.btn_Temizle.Size = New System.Drawing.Size(74, 23)
        Me.btn_Temizle.TabIndex = 40
        Me.btn_Temizle.Text = "Temizle"
        Me.btn_Temizle.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(49, 265)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(250, 1)
        Me.Panel5.TabIndex = 39
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(84, 214)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(217, 1)
        Me.Panel4.TabIndex = 38
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(77, 168)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(225, 1)
        Me.Panel3.TabIndex = 37
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(101, 117)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 1)
        Me.Panel2.TabIndex = 36
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(101, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 1)
        Me.Panel1.TabIndex = 35
        '
        'txt_EkleyenKisi
        '
        Me.txt_EkleyenKisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_EkleyenKisi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_EkleyenKisi.Location = New System.Drawing.Point(154, 251)
        Me.txt_EkleyenKisi.Name = "txt_EkleyenKisi"
        Me.txt_EkleyenKisi.Size = New System.Drawing.Size(110, 13)
        Me.txt_EkleyenKisi.TabIndex = 34
        '
        'txt_StokAdedi
        '
        Me.txt_StokAdedi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_StokAdedi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_StokAdedi.Location = New System.Drawing.Point(153, 200)
        Me.txt_StokAdedi.Name = "txt_StokAdedi"
        Me.txt_StokAdedi.Size = New System.Drawing.Size(110, 13)
        Me.txt_StokAdedi.TabIndex = 33
        '
        'txt_StokModeli
        '
        Me.txt_StokModeli.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_StokModeli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_StokModeli.Location = New System.Drawing.Point(154, 154)
        Me.txt_StokModeli.Name = "txt_StokModeli"
        Me.txt_StokModeli.Size = New System.Drawing.Size(45, 13)
        Me.txt_StokModeli.TabIndex = 32
        '
        'txt_StokAdi
        '
        Me.txt_StokAdi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_StokAdi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_StokAdi.Location = New System.Drawing.Point(153, 103)
        Me.txt_StokAdi.Name = "txt_StokAdi"
        Me.txt_StokAdi.Size = New System.Drawing.Size(137, 13)
        Me.txt_StokAdi.TabIndex = 31
        '
        'txt_StokId
        '
        Me.txt_StokId.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_StokId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_StokId.Enabled = False
        Me.txt_StokId.Location = New System.Drawing.Point(154, 56)
        Me.txt_StokId.Name = "txt_StokId"
        Me.txt_StokId.Size = New System.Drawing.Size(136, 13)
        Me.txt_StokId.TabIndex = 30
        '
        'lbl_EkleyenKisi
        '
        Me.lbl_EkleyenKisi.AutoSize = True
        Me.lbl_EkleyenKisi.Location = New System.Drawing.Point(41, 251)
        Me.lbl_EkleyenKisi.Name = "lbl_EkleyenKisi"
        Me.lbl_EkleyenKisi.Size = New System.Drawing.Size(106, 13)
        Me.lbl_EkleyenKisi.TabIndex = 29
        Me.lbl_EkleyenKisi.Text = "Stok Ekleyen Kişi"
        '
        'lbl_StokAdedi
        '
        Me.lbl_StokAdedi.AutoSize = True
        Me.lbl_StokAdedi.Location = New System.Drawing.Point(81, 202)
        Me.lbl_StokAdedi.Name = "lbl_StokAdedi"
        Me.lbl_StokAdedi.Size = New System.Drawing.Size(69, 13)
        Me.lbl_StokAdedi.TabIndex = 28
        Me.lbl_StokAdedi.Text = "Stok Adedi"
        '
        'lbl_StokModeli
        '
        Me.lbl_StokModeli.AutoSize = True
        Me.lbl_StokModeli.Location = New System.Drawing.Point(76, 155)
        Me.lbl_StokModeli.Name = "lbl_StokModeli"
        Me.lbl_StokModeli.Size = New System.Drawing.Size(74, 13)
        Me.lbl_StokModeli.TabIndex = 27
        Me.lbl_StokModeli.Text = "Stok Modeli"
        '
        'lbl_StokAdi
        '
        Me.lbl_StokAdi.AutoSize = True
        Me.lbl_StokAdi.Location = New System.Drawing.Point(95, 105)
        Me.lbl_StokAdi.Name = "lbl_StokAdi"
        Me.lbl_StokAdi.Size = New System.Drawing.Size(55, 13)
        Me.lbl_StokAdi.TabIndex = 26
        Me.lbl_StokAdi.Text = "Stok Adı"
        '
        'lbl_Id
        '
        Me.lbl_Id.AutoSize = True
        Me.lbl_Id.Location = New System.Drawing.Point(102, 58)
        Me.lbl_Id.Name = "lbl_Id"
        Me.lbl_Id.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Id.TabIndex = 25
        Me.lbl_Id.Text = "Stok Id"
        '
        'dgStok
        '
        Me.dgStok.AllowUserToAddRows = False
        Me.dgStok.AllowUserToDeleteRows = False
        Me.dgStok.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStok.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgStok.Location = New System.Drawing.Point(326, 80)
        Me.dgStok.Name = "dgStok"
        Me.dgStok.ReadOnly = True
        Me.dgStok.Size = New System.Drawing.Size(817, 368)
        Me.dgStok.TabIndex = 24
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Stok Adı"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Stok Modeli"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Stok Adedi"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Stok Ekleyen Kişi"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Stok Giriş Tarihi"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Açıklama"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'btn_Cikis
        '
        Me.btn_Cikis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Cikis.Location = New System.Drawing.Point(124, 467)
        Me.btn_Cikis.Name = "btn_Cikis"
        Me.btn_Cikis.Size = New System.Drawing.Size(125, 36)
        Me.btn_Cikis.TabIndex = 50
        Me.btn_Cikis.Text = "KAPAT"
        Me.btn_Cikis.UseVisualStyleBackColor = False
        '
        'btn_Ekle
        '
        Me.btn_Ekle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Ekle.Location = New System.Drawing.Point(423, 461)
        Me.btn_Ekle.Name = "btn_Ekle"
        Me.btn_Ekle.Size = New System.Drawing.Size(118, 49)
        Me.btn_Ekle.TabIndex = 49
        Me.btn_Ekle.Text = "EKLE"
        Me.btn_Ekle.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Location = New System.Drawing.Point(39, 316)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 1)
        Me.Panel6.TabIndex = 48
        '
        'dtp_Tarih
        '
        Me.dtp_Tarih.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp_Tarih.Location = New System.Drawing.Point(103, 297)
        Me.dtp_Tarih.Name = "dtp_Tarih"
        Me.dtp_Tarih.Size = New System.Drawing.Size(200, 20)
        Me.dtp_Tarih.TabIndex = 47
        '
        'txt_Aciklama
        '
        Me.txt_Aciklama.Location = New System.Drawing.Point(88, 358)
        Me.txt_Aciklama.Multiline = True
        Me.txt_Aciklama.Name = "txt_Aciklama"
        Me.txt_Aciklama.Size = New System.Drawing.Size(215, 90)
        Me.txt_Aciklama.TabIndex = 46
        '
        'lbl_Aciklama
        '
        Me.lbl_Aciklama.AutoSize = True
        Me.lbl_Aciklama.Location = New System.Drawing.Point(32, 357)
        Me.lbl_Aciklama.Name = "lbl_Aciklama"
        Me.lbl_Aciklama.Size = New System.Drawing.Size(58, 13)
        Me.lbl_Aciklama.TabIndex = 45
        Me.lbl_Aciklama.Text = "Açıklama"
        '
        'lbl_Tarih
        '
        Me.lbl_Tarih.AutoSize = True
        Me.lbl_Tarih.Location = New System.Drawing.Point(7, 300)
        Me.lbl_Tarih.Name = "lbl_Tarih"
        Me.lbl_Tarih.Size = New System.Drawing.Size(98, 13)
        Me.lbl_Tarih.TabIndex = 44
        Me.lbl_Tarih.Text = "Stok Giriş Tarihi"
        '
        'btn_Guncelle
        '
        Me.btn_Guncelle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Guncelle.Location = New System.Drawing.Point(673, 461)
        Me.btn_Guncelle.Name = "btn_Guncelle"
        Me.btn_Guncelle.Size = New System.Drawing.Size(118, 49)
        Me.btn_Guncelle.TabIndex = 51
        Me.btn_Guncelle.Text = "GÜNCELLE"
        Me.btn_Guncelle.UseVisualStyleBackColor = False
        '
        'btn_Sil
        '
        Me.btn_Sil.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Sil.Location = New System.Drawing.Point(913, 461)
        Me.btn_Sil.Name = "btn_Sil"
        Me.btn_Sil.Size = New System.Drawing.Size(118, 49)
        Me.btn_Sil.TabIndex = 52
        Me.btn_Sil.Text = "SİL"
        Me.btn_Sil.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1169, 530)
        Me.Controls.Add(Me.btn_Sil)
        Me.Controls.Add(Me.btn_Guncelle)
        Me.Controls.Add(Me.btn_Cikis)
        Me.Controls.Add(Me.btn_Ekle)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.dtp_Tarih)
        Me.Controls.Add(Me.txt_Aciklama)
        Me.Controls.Add(Me.lbl_Aciklama)
        Me.Controls.Add(Me.lbl_Tarih)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.txt_Ara)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Temizle)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_EkleyenKisi)
        Me.Controls.Add(Me.txt_StokAdedi)
        Me.Controls.Add(Me.txt_StokModeli)
        Me.Controls.Add(Me.txt_StokAdi)
        Me.Controls.Add(Me.txt_StokId)
        Me.Controls.Add(Me.lbl_EkleyenKisi)
        Me.Controls.Add(Me.lbl_StokAdedi)
        Me.Controls.Add(Me.lbl_StokModeli)
        Me.Controls.Add(Me.lbl_StokAdi)
        Me.Controls.Add(Me.lbl_Id)
        Me.Controls.Add(Me.dgStok)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok İşlemleri"
        CType(Me.dgStok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel7 As Panel
    Friend WithEvents txt_Ara As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Temizle As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_EkleyenKisi As TextBox
    Friend WithEvents txt_StokAdedi As TextBox
    Friend WithEvents txt_StokModeli As TextBox
    Friend WithEvents txt_StokAdi As TextBox
    Friend WithEvents txt_StokId As TextBox
    Friend WithEvents lbl_EkleyenKisi As Label
    Friend WithEvents lbl_StokAdedi As Label
    Friend WithEvents lbl_StokModeli As Label
    Friend WithEvents lbl_StokAdi As Label
    Friend WithEvents lbl_Id As Label
    Friend WithEvents dgStok As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents btn_Cikis As Button
    Friend WithEvents btn_Ekle As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dtp_Tarih As DateTimePicker
    Friend WithEvents txt_Aciklama As TextBox
    Friend WithEvents lbl_Aciklama As Label
    Friend WithEvents lbl_Tarih As Label
    Friend WithEvents btn_Guncelle As Button
    Friend WithEvents btn_Sil As Button
End Class
