<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgStok = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_Id = New System.Windows.Forms.Label()
        Me.lbl_StokAdi = New System.Windows.Forms.Label()
        Me.lbl_StokModeli = New System.Windows.Forms.Label()
        Me.lbl_StokAdedi = New System.Windows.Forms.Label()
        Me.lbl_EkleyenKisi = New System.Windows.Forms.Label()
        Me.lbl_Tarih = New System.Windows.Forms.Label()
        Me.lbl_Aciklama = New System.Windows.Forms.Label()
        Me.txt_StokId = New System.Windows.Forms.TextBox()
        Me.txt_StokAdi = New System.Windows.Forms.TextBox()
        Me.txt_StokModeli = New System.Windows.Forms.TextBox()
        Me.txt_StokAdedi = New System.Windows.Forms.TextBox()
        Me.txt_EkleyenKisi = New System.Windows.Forms.TextBox()
        Me.txt_Aciklama = New System.Windows.Forms.TextBox()
        Me.dtp_Tarih = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btn_Kaydet = New System.Windows.Forms.Button()
        Me.btn_Cikis = New System.Windows.Forms.Button()
        Me.btn_Temizle = New System.Windows.Forms.Button()
        Me.btn_Yeni = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txt_Ara = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txt_EklenenMiktar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txt_CikanMiktar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txt_UserId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgStok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgStok
        '
        Me.dgStok.AllowUserToAddRows = False
        Me.dgStok.AllowUserToDeleteRows = False
        Me.dgStok.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStok.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgStok.Location = New System.Drawing.Point(342, 92)
        Me.dgStok.Name = "dgStok"
        Me.dgStok.ReadOnly = True
        Me.dgStok.Size = New System.Drawing.Size(747, 361)
        Me.dgStok.TabIndex = 0
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
        'lbl_Id
        '
        Me.lbl_Id.AutoSize = True
        Me.lbl_Id.Location = New System.Drawing.Point(67, 46)
        Me.lbl_Id.Name = "lbl_Id"
        Me.lbl_Id.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Id.TabIndex = 1
        Me.lbl_Id.Text = "Stok Id"
        '
        'lbl_StokAdi
        '
        Me.lbl_StokAdi.AutoSize = True
        Me.lbl_StokAdi.Location = New System.Drawing.Point(60, 80)
        Me.lbl_StokAdi.Name = "lbl_StokAdi"
        Me.lbl_StokAdi.Size = New System.Drawing.Size(55, 13)
        Me.lbl_StokAdi.TabIndex = 2
        Me.lbl_StokAdi.Text = "Stok Adı"
        '
        'lbl_StokModeli
        '
        Me.lbl_StokModeli.AutoSize = True
        Me.lbl_StokModeli.Location = New System.Drawing.Point(40, 117)
        Me.lbl_StokModeli.Name = "lbl_StokModeli"
        Me.lbl_StokModeli.Size = New System.Drawing.Size(74, 13)
        Me.lbl_StokModeli.TabIndex = 3
        Me.lbl_StokModeli.Text = "Stok Modeli"
        '
        'lbl_StokAdedi
        '
        Me.lbl_StokAdedi.AutoSize = True
        Me.lbl_StokAdedi.Location = New System.Drawing.Point(46, 144)
        Me.lbl_StokAdedi.Name = "lbl_StokAdedi"
        Me.lbl_StokAdedi.Size = New System.Drawing.Size(69, 13)
        Me.lbl_StokAdedi.TabIndex = 4
        Me.lbl_StokAdedi.Text = "Stok Adedi"
        '
        'lbl_EkleyenKisi
        '
        Me.lbl_EkleyenKisi.AutoSize = True
        Me.lbl_EkleyenKisi.Location = New System.Drawing.Point(8, 172)
        Me.lbl_EkleyenKisi.Name = "lbl_EkleyenKisi"
        Me.lbl_EkleyenKisi.Size = New System.Drawing.Size(106, 13)
        Me.lbl_EkleyenKisi.TabIndex = 5
        Me.lbl_EkleyenKisi.Text = "Stok Ekleyen Kişi"
        '
        'lbl_Tarih
        '
        Me.lbl_Tarih.AutoSize = True
        Me.lbl_Tarih.Location = New System.Drawing.Point(13, 315)
        Me.lbl_Tarih.Name = "lbl_Tarih"
        Me.lbl_Tarih.Size = New System.Drawing.Size(98, 13)
        Me.lbl_Tarih.TabIndex = 6
        Me.lbl_Tarih.Text = "Stok Giriş Tarihi"
        '
        'lbl_Aciklama
        '
        Me.lbl_Aciklama.AutoSize = True
        Me.lbl_Aciklama.Location = New System.Drawing.Point(53, 363)
        Me.lbl_Aciklama.Name = "lbl_Aciklama"
        Me.lbl_Aciklama.Size = New System.Drawing.Size(58, 13)
        Me.lbl_Aciklama.TabIndex = 7
        Me.lbl_Aciklama.Text = "Açıklama"
        '
        'txt_StokId
        '
        Me.txt_StokId.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_StokId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_StokId.Enabled = False
        Me.txt_StokId.Location = New System.Drawing.Point(119, 44)
        Me.txt_StokId.Name = "txt_StokId"
        Me.txt_StokId.Size = New System.Drawing.Size(136, 13)
        Me.txt_StokId.TabIndex = 8
        '
        'txt_StokAdi
        '
        Me.txt_StokAdi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_StokAdi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_StokAdi.Enabled = False
        Me.txt_StokAdi.Location = New System.Drawing.Point(118, 78)
        Me.txt_StokAdi.Name = "txt_StokAdi"
        Me.txt_StokAdi.Size = New System.Drawing.Size(137, 13)
        Me.txt_StokAdi.TabIndex = 9
        '
        'txt_StokModeli
        '
        Me.txt_StokModeli.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_StokModeli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_StokModeli.Location = New System.Drawing.Point(118, 116)
        Me.txt_StokModeli.Name = "txt_StokModeli"
        Me.txt_StokModeli.Size = New System.Drawing.Size(45, 13)
        Me.txt_StokModeli.TabIndex = 10
        '
        'txt_StokAdedi
        '
        Me.txt_StokAdedi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_StokAdedi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_StokAdedi.Enabled = False
        Me.txt_StokAdedi.Location = New System.Drawing.Point(118, 142)
        Me.txt_StokAdedi.Name = "txt_StokAdedi"
        Me.txt_StokAdedi.Size = New System.Drawing.Size(110, 13)
        Me.txt_StokAdedi.TabIndex = 11
        '
        'txt_EkleyenKisi
        '
        Me.txt_EkleyenKisi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_EkleyenKisi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_EkleyenKisi.Enabled = False
        Me.txt_EkleyenKisi.Location = New System.Drawing.Point(121, 172)
        Me.txt_EkleyenKisi.Name = "txt_EkleyenKisi"
        Me.txt_EkleyenKisi.Size = New System.Drawing.Size(110, 13)
        Me.txt_EkleyenKisi.TabIndex = 12
        '
        'txt_Aciklama
        '
        Me.txt_Aciklama.Enabled = False
        Me.txt_Aciklama.Location = New System.Drawing.Point(109, 364)
        Me.txt_Aciklama.Multiline = True
        Me.txt_Aciklama.Name = "txt_Aciklama"
        Me.txt_Aciklama.Size = New System.Drawing.Size(215, 90)
        Me.txt_Aciklama.TabIndex = 13
        '
        'dtp_Tarih
        '
        Me.dtp_Tarih.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtp_Tarih.Enabled = False
        Me.dtp_Tarih.Location = New System.Drawing.Point(109, 312)
        Me.dtp_Tarih.Name = "dtp_Tarih"
        Me.dtp_Tarih.Size = New System.Drawing.Size(200, 20)
        Me.dtp_Tarih.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(66, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 1)
        Me.Panel1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(66, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 1)
        Me.Panel2.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(41, 130)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(225, 1)
        Me.Panel3.TabIndex = 16
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(49, 156)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 1)
        Me.Panel4.TabIndex = 16
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(16, 186)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(250, 1)
        Me.Panel5.TabIndex = 16
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Location = New System.Drawing.Point(45, 331)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 1)
        Me.Panel6.TabIndex = 16
        '
        'btn_Kaydet
        '
        Me.btn_Kaydet.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Kaydet.Location = New System.Drawing.Point(108, 465)
        Me.btn_Kaydet.Name = "btn_Kaydet"
        Me.btn_Kaydet.Size = New System.Drawing.Size(97, 36)
        Me.btn_Kaydet.TabIndex = 17
        Me.btn_Kaydet.Text = "KAYDET"
        Me.btn_Kaydet.UseVisualStyleBackColor = False
        '
        'btn_Cikis
        '
        Me.btn_Cikis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Cikis.Location = New System.Drawing.Point(227, 464)
        Me.btn_Cikis.Name = "btn_Cikis"
        Me.btn_Cikis.Size = New System.Drawing.Size(97, 36)
        Me.btn_Cikis.TabIndex = 18
        Me.btn_Cikis.Text = "KAPAT"
        Me.btn_Cikis.UseVisualStyleBackColor = False
        '
        'btn_Temizle
        '
        Me.btn_Temizle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Temizle.Location = New System.Drawing.Point(192, 108)
        Me.btn_Temizle.Name = "btn_Temizle"
        Me.btn_Temizle.Size = New System.Drawing.Size(74, 23)
        Me.btn_Temizle.TabIndex = 20
        Me.btn_Temizle.Text = "Temizle"
        Me.btn_Temizle.UseVisualStyleBackColor = False
        '
        'btn_Yeni
        '
        Me.btn_Yeni.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Yeni.Location = New System.Drawing.Point(806, 49)
        Me.btn_Yeni.Name = "btn_Yeni"
        Me.btn_Yeni.Size = New System.Drawing.Size(109, 23)
        Me.btn_Yeni.TabIndex = 24
        Me.btn_Yeni.Text = "Yeni Stok"
        Me.btn_Yeni.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Location = New System.Drawing.Point(409, 71)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(446, 1)
        Me.Panel7.TabIndex = 23
        '
        'txt_Ara
        '
        Me.txt_Ara.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Ara.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Ara.Location = New System.Drawing.Point(415, 58)
        Me.txt_Ara.Name = "txt_Ara"
        Me.txt_Ara.Size = New System.Drawing.Size(334, 13)
        Me.txt_Ara.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(340, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Stok Arama"
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Location = New System.Drawing.Point(16, 225)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(250, 1)
        Me.Panel8.TabIndex = 27
        '
        'txt_EklenenMiktar
        '
        Me.txt_EklenenMiktar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_EklenenMiktar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_EklenenMiktar.Location = New System.Drawing.Point(121, 211)
        Me.txt_EklenenMiktar.Name = "txt_EklenenMiktar"
        Me.txt_EklenenMiktar.Size = New System.Drawing.Size(110, 13)
        Me.txt_EklenenMiktar.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Eklenen Miktar"
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Location = New System.Drawing.Point(16, 259)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(250, 1)
        Me.Panel9.TabIndex = 30
        '
        'txt_CikanMiktar
        '
        Me.txt_CikanMiktar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_CikanMiktar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_CikanMiktar.Location = New System.Drawing.Point(121, 245)
        Me.txt_CikanMiktar.Name = "txt_CikanMiktar"
        Me.txt_CikanMiktar.Size = New System.Drawing.Size(110, 13)
        Me.txt_CikanMiktar.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Çıkan Miktar"
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Location = New System.Drawing.Point(16, 292)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(250, 1)
        Me.Panel10.TabIndex = 33
        '
        'txt_UserId
        '
        Me.txt_UserId.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_UserId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_UserId.Location = New System.Drawing.Point(121, 278)
        Me.txt_UserId.Name = "txt_UserId"
        Me.txt_UserId.Size = New System.Drawing.Size(110, 13)
        Me.txt_UserId.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Stok Düzenleyen"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1101, 503)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.txt_UserId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.txt_CikanMiktar)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_EklenenMiktar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_Yeni)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.txt_Ara)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Temizle)
        Me.Controls.Add(Me.btn_Cikis)
        Me.Controls.Add(Me.btn_Kaydet)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtp_Tarih)
        Me.Controls.Add(Me.txt_Aciklama)
        Me.Controls.Add(Me.txt_EkleyenKisi)
        Me.Controls.Add(Me.txt_StokAdedi)
        Me.Controls.Add(Me.txt_StokModeli)
        Me.Controls.Add(Me.txt_StokAdi)
        Me.Controls.Add(Me.txt_StokId)
        Me.Controls.Add(Me.lbl_Aciklama)
        Me.Controls.Add(Me.lbl_Tarih)
        Me.Controls.Add(Me.lbl_EkleyenKisi)
        Me.Controls.Add(Me.lbl_StokAdedi)
        Me.Controls.Add(Me.lbl_StokModeli)
        Me.Controls.Add(Me.lbl_StokAdi)
        Me.Controls.Add(Me.lbl_Id)
        Me.Controls.Add(Me.dgStok)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "Form1"
        Me.Text = "Stok Takip "
        CType(Me.dgStok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgStok As DataGridView
    Friend WithEvents lbl_Id As Label
    Friend WithEvents lbl_StokAdi As Label
    Friend WithEvents lbl_StokModeli As Label
    Friend WithEvents lbl_StokAdedi As Label
    Friend WithEvents lbl_EkleyenKisi As Label
    Friend WithEvents lbl_Tarih As Label
    Friend WithEvents lbl_Aciklama As Label
    Friend WithEvents txt_StokId As TextBox
    Friend WithEvents txt_StokAdi As TextBox
    Friend WithEvents txt_StokModeli As TextBox
    Friend WithEvents txt_StokAdedi As TextBox
    Friend WithEvents txt_EkleyenKisi As TextBox
    Friend WithEvents txt_Aciklama As TextBox
    Friend WithEvents dtp_Tarih As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btn_Kaydet As Button
    Friend WithEvents btn_Cikis As Button
    Friend WithEvents btn_Temizle As Button
    Friend WithEvents btn_Yeni As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txt_Ara As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txt_EklenenMiktar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txt_CikanMiktar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txt_UserId As TextBox
    Friend WithEvents Label4 As Label
End Class
