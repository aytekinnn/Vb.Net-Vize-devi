Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = dtGetir("select * from Kullanici")
        For i = 0 To dt.Rows.Count - 1
            dgPersonel.Rows.Add(dt.Rows(i)("UserId").ToString(),
            dt.Rows(i)("AdiSoyadi").ToString(),
            dt.Rows(i)("Sifre").ToString(),
            dt.Rows(i)("Tel").ToString(),
            dt.Rows(i)("Gorevi").ToString(),
            dt.Rows(i)("Adres").ToString())
        Next
    End Sub

    Private Sub btn_Yeni_Click(sender As Object, e As EventArgs) Handles btn_Yeni.Click
        Form2.Show()
    End Sub

    Private Sub txt_Ara_TextChanged(sender As Object, e As EventArgs) Handles txt_Ara.TextChanged
        Dim dt As DataTable = dtGetir("select * from Kullanici where AdiSoyadi like '" & txt_Ara.Text & "%'")
        dgPersonel.Rows.Clear()

        For i = 0 To dt.Rows.Count - 1
            dgPersonel.Rows.Add(dt.Rows(i)("UserId").ToString(),
            dt.Rows(i)("AdiSoyadi").ToString(),
            dt.Rows(i)("Sifre").ToString(),
            dt.Rows(i)("Tel").ToString(),
            dt.Rows(i)("Gorevi").ToString(),
            dt.Rows(i)("Adres").ToString())
        Next
    End Sub
End Class