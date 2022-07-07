Imports System.Data.Odbc

Public Class FormTransaksi

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet11.tbl_jenis' table. You can move, or remove it, as needed.
        Me.Tbl_jenisTableAdapter.Fill(Me.DataSet11.tbl_jenis)
        'TODO: This line of code loads data into the 'DataSet1.tbl_pelanggan' table. You can move, or remove it, as needed.
        Me.Tbl_pelangganTableAdapter.Fill(Me.DataSet1.tbl_pelanggan)

    End Sub

    Private Function IsiJenis()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tbl_jenis", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            'Dim odbcReader As OdbcDataReader

            'Call Koneksi()
            'Da = New OdbcDataAdapter("select * from tbl_pelanggan where namapelanggan like '%" & txtcari.text & "%'", Conn)
            'Ds = New DataSet
            'Da.Fill(Ds, "ketemu data")
            'dgvpelanggan.DataSource = Ds.Tables("ketemu data")
            'dgvpelanggan.ReadOnly = True
        End If
    End Function

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

    Private Sub cmbjenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbjenis.SelectedIndexChanged
        txtjumlah.Text = cmbjenis.SelectedValue
    End Sub
End Class