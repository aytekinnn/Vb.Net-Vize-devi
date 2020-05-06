<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKullaniciGirisi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKullaniciGirisi))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtKullaniciAdi = New System.Windows.Forms.TextBox()
        Me.txtKullaniciSifre = New System.Windows.Forms.TextBox()
        Me.btnGiris = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.linklblSifremiUnuttum = New System.Windows.Forms.LinkLabel()
        Me.lblUyeOl = New System.Windows.Forms.Label()
        Me.lblCikis = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(26, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(163, 62)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(163, 105)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(164, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(140, 1)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(164, 87)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(140, 1)
        Me.Panel2.TabIndex = 4
        '
        'txtKullaniciAdi
        '
        Me.txtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKullaniciAdi.Location = New System.Drawing.Point(189, 72)
        Me.txtKullaniciAdi.Name = "txtKullaniciAdi"
        Me.txtKullaniciAdi.Size = New System.Drawing.Size(100, 13)
        Me.txtKullaniciAdi.TabIndex = 5
        '
        'txtKullaniciSifre
        '
        Me.txtKullaniciSifre.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKullaniciSifre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKullaniciSifre.Location = New System.Drawing.Point(189, 115)
        Me.txtKullaniciSifre.Name = "txtKullaniciSifre"
        Me.txtKullaniciSifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtKullaniciSifre.Size = New System.Drawing.Size(100, 13)
        Me.txtKullaniciSifre.TabIndex = 6
        '
        'btnGiris
        '
        Me.btnGiris.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGiris.Location = New System.Drawing.Point(163, 151)
        Me.btnGiris.Name = "btnGiris"
        Me.btnGiris.Size = New System.Drawing.Size(141, 27)
        Me.btnGiris.TabIndex = 7
        Me.btnGiris.Text = "Giriş"
        Me.btnGiris.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(168, 187)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(80, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Beni Hatırla"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'linklblSifremiUnuttum
        '
        Me.linklblSifremiUnuttum.AutoSize = True
        Me.linklblSifremiUnuttum.Location = New System.Drawing.Point(160, 213)
        Me.linklblSifremiUnuttum.Name = "linklblSifremiUnuttum"
        Me.linklblSifremiUnuttum.Size = New System.Drawing.Size(81, 13)
        Me.linklblSifremiUnuttum.TabIndex = 9
        Me.linklblSifremiUnuttum.TabStop = True
        Me.linklblSifremiUnuttum.Text = "Şifremi Unuttum"
        '
        'lblUyeOl
        '
        Me.lblUyeOl.AutoSize = True
        Me.lblUyeOl.Location = New System.Drawing.Point(265, 213)
        Me.lblUyeOl.Name = "lblUyeOl"
        Me.lblUyeOl.Size = New System.Drawing.Size(39, 13)
        Me.lblUyeOl.TabIndex = 10
        Me.lblUyeOl.Text = "Üye Ol"
        '
        'lblCikis
        '
        Me.lblCikis.AutoSize = True
        Me.lblCikis.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCikis.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblCikis.ForeColor = System.Drawing.Color.Red
        Me.lblCikis.Location = New System.Drawing.Point(352, 2)
        Me.lblCikis.Name = "lblCikis"
        Me.lblCikis.Size = New System.Drawing.Size(24, 24)
        Me.lblCikis.TabIndex = 11
        Me.lblCikis.Text = "X"
        '
        'frmKullaniciGirisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(378, 281)
        Me.Controls.Add(Me.lblCikis)
        Me.Controls.Add(Me.lblUyeOl)
        Me.Controls.Add(Me.linklblSifremiUnuttum)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnGiris)
        Me.Controls.Add(Me.txtKullaniciSifre)
        Me.Controls.Add(Me.txtKullaniciAdi)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmKullaniciGirisi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kullanıcı Girişi"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtKullaniciAdi As TextBox
    Friend WithEvents txtKullaniciSifre As TextBox
    Friend WithEvents btnGiris As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents linklblSifremiUnuttum As LinkLabel
    Friend WithEvents lblUyeOl As Label
    Friend WithEvents lblCikis As Label
End Class
