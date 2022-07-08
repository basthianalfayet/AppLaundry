Imports System.Data.Odbc

Public Class FormMasterUser
    Sub KondisiAwal()
        txtiduser.Text = ""
        txtpassword.Text = ""
        txtnama.Text = ""
        txtcari.Text = ""
        ComboBox1.Text = ""
        ComboBox1.Items.Add("ADMIN")
        ComboBox1.Items.Add("USER")
        Call MunculGrid()
    End Sub

    Private Sub FormMasterUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
    Sub MunculGrid()
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * from tbl_user", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_user")
        DataGridView1.DataSource = Ds.Tables("tbl_user")
        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 100
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
    End Sub

    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        If btninput.Text = "Input" Then
            btninput.Text = "Simpan"
            Call Koneksi()
            Cmd = New OdbcCommand("select * from tbl_user where IdUser in(select max(IdUser) from tbl_user)", Conn)
            Dim UrutanKode As String
            Dim Hitung As Long
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                UrutanKode = "USR" + "001"
            Else
                Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
                UrutanKode = "USR" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
            End If
            txtiduser.Text = UrutanKode
            txtnama.Focus()
        Else
            If btninput.Text = "Input" Then
                btninput.Text = "Simpan"
                btnedit.Enabled = False
                btnhapus.Enabled = False
                btntutup.Text = "Batal"
            Else
                Call Koneksi()
                Dim simpan As String = "Insert into tbl_user VALUES ('" & txtiduser.Text & "','" & txtnama.Text & "','" & txtpassword.Text & "','" & ComboBox1.Text & "')"
                Cmd = New OdbcCommand(simpan, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input Data Berhasil !", MsgBoxStyle.Information)
                Call KondisiAwal()
                Call MunculGrid()
                btninput.Text = "Input"
            End If
        End If

     
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Call Koneksi()
        Dim edit As String = "Update tbl_user set NamaUser='" & txtnama.Text & "', PasswordUser='" & txtpassword.Text & "', LevelUser='" & ComboBox1.Text & "' where IdUser='" & txtiduser.Text & "'"
        Cmd = New OdbcCommand(edit, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Edit Data Berhasil !", MsgBoxStyle.Information)
        Call KondisiAwal()
    End Sub

    Private Sub txtiduser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtiduser.KeyPress
        'If e.KeyChar = Chr(13) Then
        '    Call Koneksi()
        '    Cmd = New OdbcCommand("Select * from tbl_user where IdUser='" & txtiduser.Text & "'", Conn)
        '    Rd = Cmd.ExecuteReader
        '    Rd.Read()
        '    If Not Rd.HasRows Then
        '        MsgBox("Id user tidak ada")
        '    Else
        '        txtiduser.Text = Rd.Item("IdUser")
        '        txtnama.Text = Rd.Item("NamaUser")
        '        txtpassword.Text = Rd.Item("PasswordUser")
        '        ComboBox1.Text = Rd.Item("LevelUser")
        '    End If
        'End If
    End Sub

   
    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Call Koneksi()
        Dim hapus As String = "Delete from tbl_user where IdUser='" & txtiduser.Text & "'"
        Cmd = New OdbcCommand(hapus, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Data berhasil di hapus", MsgBoxStyle.Information)
        Call KondisiAwal()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        On Error Resume Next
        txtiduser.Text = DataGridView1.Item(0, i).Value
        txtnama.Text = DataGridView1.Item(1, i).Value
        txtpassword.Text = DataGridView1.Item(2, i).Value
        ComboBox1.Text = DataGridView1.Item(3, i).Value
    End Sub

    
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tbl_user where NamaUser Like '%" & txtcari.Text & "%'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call Koneksi()
            Da = New OdbcDataAdapter("Select * from tbl_user where NamaUser Like '%" & txtcari.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "Ketemu Data")
            DataGridView1.DataSource = Ds.Tables("Ketemu Data")
            DataGridView1.ReadOnly = True
        End If
    End Sub

    Private Sub btntutup_Click(sender As Object, e As EventArgs) Handles btntutup.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged

    End Sub
End Class