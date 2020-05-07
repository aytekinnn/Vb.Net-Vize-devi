<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StokTakipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KullanıEklemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇalışanlarıGösterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StokTakipToolStripMenuItem, Me.ÇalışanlarıGösterToolStripMenuItem, Me.KullanıEklemeToolStripMenuItem, Me.StokEkleToolStripMenuItem, Me.ÇıkışToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StokTakipToolStripMenuItem
        '
        Me.StokTakipToolStripMenuItem.Name = "StokTakipToolStripMenuItem"
        Me.StokTakipToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.StokTakipToolStripMenuItem.Text = "Stok Takip"
        '
        'KullanıEklemeToolStripMenuItem
        '
        Me.KullanıEklemeToolStripMenuItem.Name = "KullanıEklemeToolStripMenuItem"
        Me.KullanıEklemeToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.KullanıEklemeToolStripMenuItem.Text = "Çalışan Ekleme"
        '
        'StokEkleToolStripMenuItem
        '
        Me.StokEkleToolStripMenuItem.Name = "StokEkleToolStripMenuItem"
        Me.StokEkleToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.StokEkleToolStripMenuItem.Text = "Stok Ekle"
        '
        'ÇıkışToolStripMenuItem
        '
        Me.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem"
        Me.ÇıkışToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ÇıkışToolStripMenuItem.Text = "Çıkış"
        '
        'ÇalışanlarıGösterToolStripMenuItem
        '
        Me.ÇalışanlarıGösterToolStripMenuItem.Name = "ÇalışanlarıGösterToolStripMenuItem"
        Me.ÇalışanlarıGösterToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.ÇalışanlarıGösterToolStripMenuItem.Text = "Çalışanları Göster"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDIParent1"
        Me.Text = "MDIParent1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StokTakipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StokEkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÇıkışToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KullanıEklemeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÇalışanlarıGösterToolStripMenuItem As ToolStripMenuItem
End Class
