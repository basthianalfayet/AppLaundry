Imports System.Data.Odbc
Public Class FormLogin
    Sub KondisiAwal()
        txtkodeuser.Text = ""
        txtpassword.Text = ""
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tbl_user where IdUser='" & txtkodeuser.Text & "' and PasswordUser='" & txtpassword.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Me.Close()
            Call BukaKunci()
        Else
            MsgBox("Id User atau Password salah !!!", MsgBoxStyle.Critical)
            txtkodeuser.Focus()
        End If
    End Sub
    Sub BukaKunci()
        FormMenuUtama.LOGINToolStripMenuItem.Visible = False
        FormMenuUtama.LOGOUTToolStripMenuItem.Visible = True
        FormMenuUtama.MASTERToolStripMenuItem.Visible = True
        FormMenuUtama.TRANSAKSIToolStripMenuItem.Visible = True
        FormMenuUtama.UTILITYToolStripMenuItem.Visible = True
        FormMenuUtama.LAPORANToolStripMenuItem.Visible = True
    End Sub
End Class