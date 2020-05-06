Imports System.Data.SqlClient
Imports System.Deployment.Application

Public Class Kullanici
    ReadOnly baglanti As New SqlConnection("Data Source=C:\Users\aytek\Desktop\Vize Ödevi VB.NET\VizeOdevi\VizeOdevi\bin\Debug\Stok_Takip.mdb;Persist Security Info=True")


    Private _kullaniciAdi As String
    Private _sifre As String


    Public Property KullaniciAdi() As String
        Get
            Return _kullaniciAdi
        End Get
        Set(value As String)
            _kullaniciAdi = value
        End Set
    End Property

    Public Property Sifre() As String
        Get
            Return _sifre
        End Get
        Set(value As String)
            _sifre = value
        End Set
    End Property

    Sub KullaniciGirisi(Kadi As String, Password As String)
        KullaniciAdi = Kadi
        Sifre = Password
        If KullaniciAdi = "" Or Sifre = "" Then
            MessageBox.Show("Kullanıcı Adı ve/veya Şire Boş Geçilemez", "Uyarı-1")
        Else
            If baglanti.State = ConnectionState.Closed Then
                baglanti.Open()
            End If
            Dim komut As New SqlCommand("select *from Kullanici where kullaniciAdi='" & KullaniciAdi & "'", baglanti)
            Dim reader As SqlDataReader = komut.ExecuteReader
            If reader.Read Then
                If reader(1) = Sifre Then
                    MessageBox.Show("İşlem Başarılı", "Giriş")
                    frmKullaniciGirisi.Temizle()
                Else
                    MessageBox.Show("Şifrenizi Kontrol Ediniz.!!!", "Uyarı-2")
                End If
            Else
                MessageBox.Show("Bilgilerinizi Kontrol Ediniz.!!!", "Uyarı-3")
            End If
            baglanti.Close()
        End If
    End Sub

End Class

