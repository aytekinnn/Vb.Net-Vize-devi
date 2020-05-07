<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_tel = New System.Windows.Forms.TextBox()
        Me.txt_AdiSoyadi = New System.Windows.Forms.TextBox()
        Me.lbl_EkleyenKisi = New System.Windows.Forms.Label()
        Me.lbl_StokAdedi = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_gorevi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_adresi = New System.Windows.Forms.TextBox()
        Me.lbl_Aciklama = New System.Windows.Forms.Label()
        Me.btn_kaydet = New System.Windows.Forms.Button()
        Me.btn_kapat = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_sifre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Personel Ekleme"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(162, 204)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(158, 1)
        Me.Panel5.TabIndex = 32
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(120, 145)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 1)
        Me.Panel4.TabIndex = 33
        '
        'txt_tel
        '
        Me.txt_tel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_tel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_tel.Location = New System.Drawing.Point(200, 190)
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(110, 13)
        Me.txt_tel.TabIndex = 31
        '
        'txt_AdiSoyadi
        '
        Me.txt_AdiSoyadi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_AdiSoyadi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_AdiSoyadi.Location = New System.Drawing.Point(204, 131)
        Me.txt_AdiSoyadi.Name = "txt_AdiSoyadi"
        Me.txt_AdiSoyadi.Size = New System.Drawing.Size(110, 13)
        Me.txt_AdiSoyadi.TabIndex = 30
        '
        'lbl_EkleyenKisi
        '
        Me.lbl_EkleyenKisi.AutoSize = True
        Me.lbl_EkleyenKisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_EkleyenKisi.Location = New System.Drawing.Point(167, 189)
        Me.lbl_EkleyenKisi.Name = "lbl_EkleyenKisi"
        Me.lbl_EkleyenKisi.Size = New System.Drawing.Size(31, 18)
        Me.lbl_EkleyenKisi.TabIndex = 29
        Me.lbl_EkleyenKisi.Text = "Tel"
        '
        'lbl_StokAdedi
        '
        Me.lbl_StokAdedi.AutoSize = True
        Me.lbl_StokAdedi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_StokAdedi.Location = New System.Drawing.Point(116, 128)
        Me.lbl_StokAdedi.Name = "lbl_StokAdedi"
        Me.lbl_StokAdedi.Size = New System.Drawing.Size(87, 18)
        Me.lbl_StokAdedi.TabIndex = 28
        Me.lbl_StokAdedi.Text = "Adı Soyadı"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(143, 234)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(177, 1)
        Me.Panel1.TabIndex = 39
        '
        'txt_gorevi
        '
        Me.txt_gorevi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_gorevi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_gorevi.Location = New System.Drawing.Point(199, 220)
        Me.txt_gorevi.Name = "txt_gorevi"
        Me.txt_gorevi.Size = New System.Drawing.Size(110, 13)
        Me.txt_gorevi.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(140, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 18)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Görevi"
        '
        'txt_adresi
        '
        Me.txt_adresi.Location = New System.Drawing.Point(188, 273)
        Me.txt_adresi.Multiline = True
        Me.txt_adresi.Name = "txt_adresi"
        Me.txt_adresi.Size = New System.Drawing.Size(215, 90)
        Me.txt_adresi.TabIndex = 41
        '
        'lbl_Aciklama
        '
        Me.lbl_Aciklama.AutoSize = True
        Me.lbl_Aciklama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_Aciklama.Location = New System.Drawing.Point(131, 271)
        Me.lbl_Aciklama.Name = "lbl_Aciklama"
        Me.lbl_Aciklama.Size = New System.Drawing.Size(56, 20)
        Me.lbl_Aciklama.TabIndex = 40
        Me.lbl_Aciklama.Text = "Adres"
        '
        'btn_kaydet
        '
        Me.btn_kaydet.Location = New System.Drawing.Point(188, 369)
        Me.btn_kaydet.Name = "btn_kaydet"
        Me.btn_kaydet.Size = New System.Drawing.Size(93, 32)
        Me.btn_kaydet.TabIndex = 42
        Me.btn_kaydet.Text = "Kaydet"
        Me.btn_kaydet.UseVisualStyleBackColor = True
        '
        'btn_kapat
        '
        Me.btn_kapat.Location = New System.Drawing.Point(310, 369)
        Me.btn_kapat.Name = "btn_kapat"
        Me.btn_kapat.Size = New System.Drawing.Size(93, 32)
        Me.btn_kapat.TabIndex = 43
        Me.btn_kapat.Text = "Kapat"
        Me.btn_kapat.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(162, 174)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(158, 1)
        Me.Panel2.TabIndex = 46
        '
        'txt_sifre
        '
        Me.txt_sifre.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sifre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_sifre.Location = New System.Drawing.Point(200, 160)
        Me.txt_sifre.Name = "txt_sifre"
        Me.txt_sifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_sifre.Size = New System.Drawing.Size(110, 13)
        Me.txt_sifre.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(158, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 18)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Şifre"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(523, 432)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txt_sifre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_kapat)
        Me.Controls.Add(Me.btn_kaydet)
        Me.Controls.Add(Me.txt_adresi)
        Me.Controls.Add(Me.lbl_Aciklama)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_gorevi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txt_tel)
        Me.Controls.Add(Me.txt_AdiSoyadi)
        Me.Controls.Add(Me.lbl_EkleyenKisi)
        Me.Controls.Add(Me.lbl_StokAdedi)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kullanıcı Ekleme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_tel As TextBox
    Friend WithEvents txt_AdiSoyadi As TextBox
    Friend WithEvents lbl_EkleyenKisi As Label
    Friend WithEvents lbl_StokAdedi As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_gorevi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_adresi As TextBox
    Friend WithEvents lbl_Aciklama As Label
    Friend WithEvents btn_kaydet As Button
    Friend WithEvents btn_kapat As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_sifre As TextBox
    Friend WithEvents Label2 As Label
End Class
