<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.dgPersonel = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Yeni = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txt_Ara = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgPersonel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgPersonel
        '
        Me.dgPersonel.AllowUserToAddRows = False
        Me.dgPersonel.AllowUserToDeleteRows = False
        Me.dgPersonel.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPersonel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgPersonel.Location = New System.Drawing.Point(12, 72)
        Me.dgPersonel.Name = "dgPersonel"
        Me.dgPersonel.ReadOnly = True
        Me.dgPersonel.Size = New System.Drawing.Size(644, 281)
        Me.dgPersonel.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "User Id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Adı Soyadı"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Şifre"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tel"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Görevi"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Adres"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'btn_Yeni
        '
        Me.btn_Yeni.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Yeni.Location = New System.Drawing.Point(484, 33)
        Me.btn_Yeni.Name = "btn_Yeni"
        Me.btn_Yeni.Size = New System.Drawing.Size(109, 23)
        Me.btn_Yeni.TabIndex = 28
        Me.btn_Yeni.Text = "Yeni Personel"
        Me.btn_Yeni.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Location = New System.Drawing.Point(87, 55)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(446, 1)
        Me.Panel7.TabIndex = 27
        '
        'txt_Ara
        '
        Me.txt_Ara.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Ara.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Ara.Location = New System.Drawing.Point(93, 42)
        Me.txt_Ara.Name = "txt_Ara"
        Me.txt_Ara.Size = New System.Drawing.Size(334, 13)
        Me.txt_Ara.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Personel Adı:"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(662, 365)
        Me.Controls.Add(Me.btn_Yeni)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.txt_Ara)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgPersonel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Name = "Form4"
        Me.Text = "Çalışanlar Listesi"
        CType(Me.dgPersonel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgPersonel As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents btn_Yeni As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txt_Ara As TextBox
    Friend WithEvents Label1 As Label
End Class
