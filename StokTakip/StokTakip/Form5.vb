Public Class Form5
    Private Sub lbl_UyeOl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_UyeOl.LinkClicked
        Form2.Show()
    End Sub



    Private Sub btn_Giris_Click(sender As Object, e As EventArgs) Handles btn_Giris.Click
        If txt_KulAdi.Text = "Aytekin" And txt_Sifre.Text = "123" Then
            Hide()
            MDIParent1.Show()
        Else
            MsgBox("Yönetici Adı veya Parola Geçersiz!", MsgBoxStyle.Critical, "Hata")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub
End Class