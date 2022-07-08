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
            Call BukaKunci(Rd("LevelUser"))
        Else
            MsgBox("Id User atau Password salah !!!", MsgBoxStyle.Critical)
            txtkodeuser.Focus()
        End If
    End Sub
    Sub BukaKunci(LevelUser As String)
        FormMenuUtama.TRANSAKSIToolStripMenuItem.Visible = True
        FormMenuUtama.LOGINToolStripMenuItem.Visible = False
        FormMenuUtama.LOGOUTToolStripMenuItem.Visible = True
        FormMenuUtama.UTILITYToolStripMenuItem.Visible = True
        FormMenuUtama.MASTERToolStripMenuItem.Visible = True

        If (LevelUser = "ADMIN") Then
            FormMenuUtama.LAPORANToolStripMenuItem.Visible = True
        Else
            FormMenuUtama.USERToolStripMenuItem.Enabled = False
            FormMenuUtama.LAPORANToolStripMenuItem.Visible = False
        End If

    End Sub
End Class