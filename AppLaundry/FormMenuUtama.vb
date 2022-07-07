Public Class FormMenuUtama

    
    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LOGINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGINToolStripMenuItem.Click
        FormLogin.ShowDialog()
    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub
    Sub Terkunci()
        LOGOUTToolStripMenuItem.Visible = False
        MASTERToolStripMenuItem.Visible = False
        TRANSAKSIToolStripMenuItem.Visible = False
        LAPORANToolStripMenuItem.Visible = False
        UTILITYToolStripMenuItem.Visible = False
    End Sub

    Private Sub USERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USERToolStripMenuItem.Click
        FormMasterUser.ShowDialog()
    End Sub

    Private Sub PELANGGANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PELANGGANToolStripMenuItem.Click
        FormMasterPelanggan.ShowDialog()
    End Sub

    Private Sub PELANGGANToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PELANGGANToolStripMenuItem1.Click
        ReportPelanggan.ShowDialog()
    End Sub

    Private Sub USERToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles USERToolStripMenuItem1.Click
        ReportUser.ShowDialog()
    End Sub

    Private Sub TRANSAKSIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRANSAKSIToolStripMenuItem.Click
        FormTransaksi.ShowDialog()
    End Sub
End Class
