
Public Class MDIParent1
    Private Sub ÇıkışToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub StokTakipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokTakipToolStripMenuItem.Click
        Form1.MdiParent = Me
        Form1.Show()
    End Sub

    Private Sub KullanıEklemeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KullanıEklemeToolStripMenuItem.Click
        Form2.MdiParent = Me
        Form2.Show()
    End Sub

    Private Sub StokEkleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokEkleToolStripMenuItem.Click
        Form3.MdiParent = Me
        Form3.Show()
    End Sub

    Private Sub ÇalışanlarıGösterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇalışanlarıGösterToolStripMenuItem.Click
        Form4.MdiParent = Me
        Form4.Show()
    End Sub
End Class
