Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = dtGetir("select * from Stoktakip")
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

    Private Sub btn_Temizle_Click(sender As Object, e As EventArgs) Handles btn_Temizle.Click
        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.text = ""
            End If
        Next
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

    Private Sub btn_Kaydet_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_Kaydet_Click_1(sender As Object, e As EventArgs) Handles btn_Kaydet.Click

        sqlCalistir("insert into Hareketler (stokId,eklenenMiktar,cikanMiktar,stokDuzenleyenKisi) 
        values ('" & txt_StokId.Text & "','" & txt_EklenenMiktar.Text & "','" & txt_CikanMiktar.Text & "','" & txt_UserId.Text & "')")
        MsgBox("Kayıt Kaydedildi", MsgBoxStyle.Information, "İşlem Tamam")
    End Sub

    Private Sub btn_Gozat_Click(sender As Object, e As EventArgs)

    End Sub
End Class
