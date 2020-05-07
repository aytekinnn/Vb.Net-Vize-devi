Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_kapat_Click(sender As Object, e As EventArgs) Handles btn_kapat.Click
        Me.Close()
    End Sub

    Private Sub btn_kaydet_Click(sender As Object, e As EventArgs) Handles btn_kaydet.Click
        If txt_AdiSoyadi.Text = "" Or txt_adresi.Text = "" Or txt_gorevi.Text = "" Or txt_sifre.Text = "" Or txt_tel.Text = "" Then
            MsgBox("Lütfen Tüm Alanları Doldururunuz",
            MsgBoxStyle.Critical, "Hata")

        End If

        sqlCalistir("insert into Kullanici (AdiSoyadi,Sifre,Tel,Gorevi,Adres) 
        values ('" & txt_AdiSoyadi.Text & "','" & txt_sifre.Text & "','" & txt_tel.Text & "','" & txt_gorevi.Text & "','" & txt_adresi.Text & "')")
        MsgBox("Kayıt Kaydedildi", MsgBoxStyle.Information, "İşlem Tamam")
        txt_AdiSoyadi.Clear()
        txt_adresi.Clear()
        txt_gorevi.Clear()
        txt_sifre.Clear()
        txt_tel.Clear()
        Hide()
        Form5.Show()
    End Sub
End Class