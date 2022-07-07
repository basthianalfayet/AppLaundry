Imports System.Data.Odbc
Public Class FormMasterPelanggan
    Sub KondisiAwal()
        txtidpelanggan.Text = ""
        txtnama.Text = ""
        txtalamat.Text = ""
        txttelepon.Text = ""
        txtketerangan.Text = ""
        Call MunculGrid()
        txtidpelanggan.MaxLength = 6
    End Sub

    Private Sub FormMasterPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
    Sub MunculGrid()
        Call Koneksi()
        Da = New OdbcDataAdapter("Select * from tbl_pelanggan", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_pelanggan")
        dgvpelanggan.DataSource = Ds.Tables("tbl_pelanggan")
        dgvpelanggan.Columns(0).Width = 100
        dgvpelanggan.Columns(1).Width = 150
        dgvpelanggan.Columns(2).Width = 150
        dgvpelanggan.Columns(3).Width = 150
        dgvpelanggan.Columns(4).Width = 150
        dgvpelanggan.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
    End Sub

    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        If btninput.Text = "Input" Then
            btninput.Text = "Simpan"
            Call Koneksi()
            Cmd = New OdbcCommand("select * from tbl_pelanggan where IdPelanggan in(select max(IdPelanggan) from tbl_pelanggan)", Conn)
            Dim UrutanKode As String
            Dim Hitung As Long
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                UrutanKode = "PLG" + "001"
            Else
                Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
                UrutanKode = "PLG" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
            End If
            txtidpelanggan.Text = UrutanKode
            txtnama.Focus()
        Else
            If btninput.Text = "Input" Then
                btninput.Text = "Simpan"
                btnedit.Enabled = False
                btnhapus.Enabled = False
                btntutup.Text = "Batal"
            Else
                Call Koneksi()
                Dim simpan As String = "Insert into tbl_pelanggan VALUES ('" & txtidpelanggan.Text & "','" & txtnama.Text & "','" & txtalamat.Text & "','" & txttelepon.Text & "','" & txtketerangan.Text & "')"
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
        Dim edit As String = "Update tbl_pelanggan set NamaPelanggan='" & txtnama.Text & "', AlamatPelanggan='" & txtalamat.Text & "', TelpPelanggan='" & txttelepon.Text & "', KetPelanggan='" & txtketerangan.Text & "' where IdPelanggan='" & txtidpelanggan.Text & "'"
        Cmd = New OdbcCommand(edit, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Edit Data Berhasil !", MsgBoxStyle.Information)
        Call KondisiAwal()
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Call Koneksi()
        Dim hapus As String = "Delete from tbl_pelanggan where IdPelanggan='" & txtidpelanggan.Text & "'"
        Cmd = New OdbcCommand(hapus, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Data berhasil di hapus", MsgBoxStyle.Information)
        Call KondisiAwal()
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tbl_pelanggan where NamaPelanggan Like '%" & txtnama.Text & "%'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call Koneksi()
            Da = New OdbcDataAdapter("Select * from tbl_pelanggan where NamaPelanggan Like '%" & txtcari.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "Ketemu Data")
            dgvpelanggan.DataSource = Ds.Tables("Ketemu Data")
            dgvpelanggan.ReadOnly = True
        End If
    End Sub

    Private Sub dgvpelanggan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpelanggan.CellClick
        Dim i As Integer
        i = dgvpelanggan.CurrentRow.Index

        On Error Resume Next
        txtidpelanggan.Text = dgvpelanggan.Item(0, i).Value
        txtnama.Text = dgvpelanggan.Item(1, i).Value
        txtalamat.Text = dgvpelanggan.Item(2, i).Value
        txttelepon.Text = dgvpelanggan.Item(3, i).Value
        txtketerangan.Text = dgvpelanggan.Item(4, i).Value
    End Sub

    Private Sub dgvpelanggan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpelanggan.CellContentClick

    End Sub
End Class