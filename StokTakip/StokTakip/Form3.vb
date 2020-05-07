Public Class Form3


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = dtGetir("select * from StokTakip")
        For i = 0 To dt.Rows.Count - 1
            dgStok.Rows.Add(dt.Rows(i)("Id").ToString(),
            dt.Rows(i)("stokAdi").ToString(),
            dt.Rows(i)("stokModeli").ToString(),
            dt.Rows(i)("stokAdedi").ToString(),
            dt.Rows(i)("stokEkleyenKisi").ToString(),
            dt.Rows(i)("tarih").ToString(),
            dt.Rows(i)("Aciklama").ToString())
        Next
    End Sub

    Private Sub txt_Ara_TextChanged(sender As Object, e As EventArgs) Handles txt_Ara.TextChanged
        Dim dt As DataTable = dtGetir("select * from StokTakip where Id like '" & txt_Ara.Text & "%'")
        dgStok.Rows.Clear()

        For i = 0 To dt.Rows.Count - 1
            dgStok.Rows.Add(dt.Rows(i)("Id").ToString(),
            dt.Rows(i)("stokAdi").ToString(),
            dt.Rows(i)("stokModeli").ToString(),
            dt.Rows(i)("stokAdedi").ToString(),
            dt.Rows(i)("stokEkleyenKisi").ToString(),
            dt.Rows(i)("tarih").ToString(),
            dt.Rows(i)("Aciklama").ToString())
        Next
    End Sub

    Private Sub btn_Cikis_Click(sender As Object, e As EventArgs) Handles btn_Cikis.Click
        Me.Close()
    End Sub

    Private Sub btn_Sil_Click(sender As Object, e As EventArgs) Handles btn_Sil.Click
        sqlCalistir("delete from StokTakip where Id=" & txt_StokId.Text)
        MsgBox("Kayıt Silindi", MsgBoxStyle.Information, "İşlem Tamam")
        txt_Aciklama.Clear()
        txt_Ara.Clear()
        txt_EkleyenKisi.Clear()
        txt_StokAdedi.Clear()
        txt_StokAdi.Clear()
        txt_StokId.Clear()
        txt_StokModeli.Clear()
    End Sub

    Private Sub dgStok_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgStok.CellClick
        txt_StokId.Text = dgStok.CurrentRow.Cells(0).Value.ToString()
        txt_StokAdi.Text = dgStok.CurrentRow.Cells(1).Value.ToString()
        txt_StokModeli.Text = dgStok.CurrentRow.Cells(2).Value.ToString()
        txt_StokAdedi.Text = dgStok.CurrentRow.Cells(3).Value.ToString()
        txt_EkleyenKisi.Text = dgStok.CurrentRow.Cells(4).Value.ToString()
        dtp_Tarih.Value = dgStok.CurrentRow.Cells(5).Value.ToString()
        txt_Aciklama.Text = dgStok.CurrentRow.Cells(6).Value.ToString()
    End Sub
    Private Sub btn_Ekle_Click(sender As Object, e As EventArgs) Handles btn_Ekle.Click
        sqlCalistir("insert into StokTakip (stokAdi,stokModeli,stokAdedi,stokEkleyenKisi,tarih,Aciklama) 
        values ('" & txt_StokAdi.Text & "','" & txt_StokModeli.Text & "','" & txt_StokAdedi.Text & "','" & txt_EkleyenKisi.Text & "','" & dtp_Tarih.Value & "','" & txt_Aciklama.Text & "')")
        MsgBox("Kayıt Kaydedildi", MsgBoxStyle.Information, "İşlem Tamam")


    End Sub

    Private Sub btn_Guncelle_Click(sender As Object, e As EventArgs) Handles btn_Guncelle.Click
        sqlCalistir("update StokTakip set Id=@Id, stokAdi=@stokAdi, stokModeli=@stokModeli, stokAdedi=@stokAdedi, stokEkleyenKisi=@stokEkleyenKisi, tarih=@tarih, Aciklama=@Aciklama, 
        values ('" & txt_StokId.Text & "','" & txt_StokAdi.Text & "','" & txt_StokModeli.Text & "','" & txt_StokAdedi.Text & "','" & txt_EkleyenKisi.Text & "','" & dtp_Tarih.Value & "','" & txt_Aciklama.Text & "')")
        MsgBox("Güncelleme Başarılı", MsgBoxStyle.Information, "Başarılı")

    End Sub
End Class