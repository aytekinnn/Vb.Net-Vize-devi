Public Class frmKullaniciGirisi
    Private Sub lblCikis_Click(sender As Object, e As EventArgs) Handles lblCikis.Click
        Me.Close()
    End Sub

    Private Sub linklblSifremiUnuttum_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklblSifremiUnuttum.LinkClicked
        frmSifremiUnuttum.ShowDialog()
    End Sub

    Private Sub lblUyeOl_Click(sender As Object, e As EventArgs) Handles lblUyeOl.Click
        frmYeniKullanici.ShowDialog()
    End Sub
    Dim k As New Kullanici

    Sub Temizle()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
    End Sub
    Private Sub btnGiris_Click(sender As Object, e As EventArgs) Handles btnGiris.Click
        k.KullaniciGirisi(txtKullaniciAdi.Text, txtKullaniciSifre.Text)
    End Sub
End Class
