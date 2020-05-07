<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_KulAdi = New System.Windows.Forms.TextBox()
        Me.txt_Sifre = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_Giris = New System.Windows.Forms.Button()
        Me.lbl_UyeOl = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(209, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(170, 1)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(209, 174)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(170, 1)
        Me.Panel2.TabIndex = 2
        '
        'txt_KulAdi
        '
        Me.txt_KulAdi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_KulAdi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_KulAdi.Location = New System.Drawing.Point(239, 124)
        Me.txt_KulAdi.Name = "txt_KulAdi"
        Me.txt_KulAdi.Size = New System.Drawing.Size(135, 13)
        Me.txt_KulAdi.TabIndex = 3
        '
        'txt_Sifre
        '
        Me.txt_Sifre.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Sifre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Sifre.Location = New System.Drawing.Point(239, 160)
        Me.txt_Sifre.Name = "txt_Sifre"
        Me.txt_Sifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Sifre.Size = New System.Drawing.Size(135, 13)
        Me.txt_Sifre.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(209, 119)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(209, 155)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'btn_Giris
        '
        Me.btn_Giris.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Giris.Location = New System.Drawing.Point(209, 206)
        Me.btn_Giris.Name = "btn_Giris"
        Me.btn_Giris.Size = New System.Drawing.Size(170, 23)
        Me.btn_Giris.TabIndex = 7
        Me.btn_Giris.Text = "Giriş"
        Me.btn_Giris.UseVisualStyleBackColor = False
        '
        'lbl_UyeOl
        '
        Me.lbl_UyeOl.AutoSize = True
        Me.lbl_UyeOl.Location = New System.Drawing.Point(210, 236)
        Me.lbl_UyeOl.Name = "lbl_UyeOl"
        Me.lbl_UyeOl.Size = New System.Drawing.Size(45, 13)
        Me.lbl_UyeOl.TabIndex = 9
        Me.lbl_UyeOl.TabStop = True
        Me.lbl_UyeOl.Text = "Üye Ol"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(369, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 33)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "X"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(405, 308)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_UyeOl)
        Me.Controls.Add(Me.btn_Giris)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txt_Sifre)
        Me.Controls.Add(Me.txt_KulAdi)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Giriş Paneli"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_KulAdi As TextBox
    Friend WithEvents txt_Sifre As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_Giris As Button
    Friend WithEvents lbl_UyeOl As LinkLabel
    Friend WithEvents Label1 As Label
End Class
