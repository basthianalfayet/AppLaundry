Imports System.Data.Odbc

Public Class FormTransaksi
    Dim TotalItem As Integer = 0
    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet11.tbl_jenis' table. You can move, or remove it, as needed.
        Me.Tbl_jenisTableAdapter.Fill(Me.DataSet11.tbl_jenis)
        'TODO: This line of code loads data into the 'DataSet1.tbl_pelanggan' table. You can move, or remove it, as needed.
        Me.Tbl_pelangganTableAdapter.Fill(Me.DataSet1.tbl_pelanggan)

    End Sub

    'Private Function IsiJenis()
    'Call Koneksi()
    'Cmd = New OdbcCommand("Select * from tbl_jenis", Conn)
    'Rd = Cmd.ExecuteReader
    'Rd.Read()
    'If Rd.HasRows Then
    'Dim odbcReader As OdbcDataReader

    'Call Koneksi()
    'Da = New OdbcDataAdapter("select * from tbl_pelanggan where namapelanggan like '%" & txtcari.text & "%'", Conn)
    'Ds = New DataSet
    'Da.Fill(Ds, "ketemu data")
    'dgvpelanggan.DataSource = Ds.Tables("ketemu data")
    'dgvpelanggan.ReadOnly = True
    'End If
    'End Function

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



    Private Sub btntambahitem_Click(sender As Object, e As EventArgs) Handles btntambahitem.Click
        Dim count As Integer = panelitem.Controls.OfType(Of ComboBox).ToList.Count
        If (count > 7) Then
            MsgBox("Item Sudah Maksimal!", MsgBoxStyle.Information)
            Return
        End If

        Dim cmbJenis As ComboBox = New ComboBox
        cmbJenis.Location = New System.Drawing.Point(10, (25 * count))
        cmbJenis.Size = New System.Drawing.Size(80, 20)
        cmbJenis.Name = "cmbJenis_" & (count + 1)

        Call Koneksi()
        Da = New OdbcDataAdapter("Select * from tbl_jenis", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_jenis")
        cmbJenis.DataSource = Ds.Tables("tbl_jenis")
        cmbJenis.DisplayMember = "NamaJenis"
        cmbJenis.ValueMember = "Harga"
        AddHandler cmbJenis.SelectedValueChanged, AddressOf Me.cmbJenis_SelectedValueChanged
        panelitem.Controls.Add(cmbJenis)

        Dim txtHarga As TextBox = New TextBox
        txtHarga.Location = New System.Drawing.Point(100, (25 * count))
        txtHarga.Size = New System.Drawing.Size(80, 20)
        txtHarga.Name = "txtHarga_" & (count + 1)
        txtHarga.ReadOnly = True
        panelitem.Controls.Add(txtHarga)

        Dim txtJumlah As TextBox = New TextBox
        txtJumlah.Location = New System.Drawing.Point(190, (25 * count))
        txtJumlah.Size = New System.Drawing.Size(80, 20)
        txtJumlah.Name = "txtJumlah_" & (count + 1)
        AddHandler txtJumlah.TextChanged, AddressOf Me.txtjumlah_TextChanged
        panelitem.Controls.Add(txtJumlah)

        Dim txtTotalHarga As TextBox = New TextBox
        txtTotalHarga.Location = New System.Drawing.Point(280, (25 * count))
        txtTotalHarga.Size = New System.Drawing.Size(80, 20)
        txtTotalHarga.Name = "txtTotalHarga_" & (count + 1)
        txtTotalHarga.ReadOnly = True
        panelitem.Controls.Add(txtTotalHarga)

        Dim btnHapus As Button = New Button
        btnHapus.Location = New System.Drawing.Point(370, (25 * count))
        btnHapus.Size = New System.Drawing.Size(20, 20)
        btnHapus.Name = "btnHapus_" & (count + 1)
        btnHapus.Text = "X"
        btnHapus.BackColor = Color.Red
        AddHandler btnHapus.Click, AddressOf Me.btnDelete_Click
        panelitem.Controls.Add(btnHapus)


    End Sub
    Private Sub txtjumlah_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim txt As TextBox = CType(sender, TextBox)
        Dim index As Integer = Integer.Parse(txt.Name.Split("_")(1))
        Dim txttotalharga As TextBox = panelitem.Controls.Find(("txttotalharga_" & index), True)(0)
        Dim txtharga As TextBox = panelitem.Controls.Find(("txtharga_" & index), True)(0)

        If (txt.Text <> "" And txtharga.Text <> "") Then
            txttotalharga.Text = txt.Text * txtharga.Text
            TotalItem += txt.Text
        Else
            txt.Text = "1"
        End If

        Dim totalHarga As Integer = 0
        For Each cmbJenis As ComboBox In panelitem.Controls.OfType(Of ComboBox)()
            Dim controlIndex As Integer = Integer.Parse(cmbJenis.Name.Split("_")(1))
            Dim txttotalhargaloop As TextBox = CType(panelitem.Controls.Find(("txttotalharga_" & controlIndex), True)(0), TextBox)

            If (txttotalhargaloop.Text <> "") Then
                totalHarga += txttotalhargaloop.Text
            End If
        Next

        txttotal.Text = totalHarga

    End Sub
    Private Sub cmbJenis_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim cmb As ComboBox = CType(sender, ComboBox)
        Dim index As Integer = Integer.Parse(cmb.Name.Split("_")(1))
        Dim txtharga As TextBox = panelitem.Controls.Find(("txtharga_" & index), True)(0)


        txtharga.Text = cmb.SelectedValue
    End Sub
    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Dim index As Integer = Integer.Parse(button.Name.Split("_")(1))

        panelitem.Controls.Remove(panelitem.Controls.Find(("cmbJenis_" & index), True)(0))
        panelitem.Controls.Remove(panelitem.Controls.Find(("txtharga_" & index), True)(0))
        panelitem.Controls.Remove(panelitem.Controls.Find(("txtjumlah_" & index), True)(0))
        panelitem.Controls.Remove(panelitem.Controls.Find(("txttotalharga_" & index), True)(0))

        panelitem.Controls.Remove(button)

        For Each btnHapus As Button In panelitem.Controls.OfType(Of Button)()
            Dim controlIndex As Integer = Integer.Parse(btnHapus.Name.Split("_")(1))
            If (controlIndex > index) Then
                Dim cmbJenis As ComboBox = CType(panelitem.Controls.Find(("cmbJenis_" & controlIndex), True)(0), ComboBox)
                Dim txtHarga As TextBox = CType(panelitem.Controls.Find(("txtHarga_" & controlIndex), True)(0), TextBox)
                Dim txtjumlah As TextBox = CType(panelitem.Controls.Find(("txtjumlah_" & controlIndex), True)(0), TextBox)
                Dim txttotalharga As TextBox = CType(panelitem.Controls.Find(("txttotalharga_" & controlIndex), True)(0), TextBox)

                btnHapus.Top = (btnHapus.Top - 25)
                cmbJenis.Top = (cmbJenis.Top - 25)
                txtHarga.Top = (txtHarga.Top - 25)
                txtjumlah.Top = (txtjumlah.Top - 25)
                txttotalharga.Top = (txttotalharga.Top - 25)
            End If
        Next
    End Sub

    Private Sub txttunai_TextChanged(sender As Object, e As EventArgs) Handles txttunai.TextChanged
        If (txttotal.Text <> "" And txttunai.Text <> "") Then
            txtkembalian.Text = txttunai.Text - txttotal.Text
        End If
    End Sub

    
    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If (txtidpelanggan.Text = "" And txttunai.Text = "") Then
            MsgBox("Harap Pilih Pelanggan Dan Item Terlebih Dahulu!", vbCritical)
            Return
        End If
        Call Koneksi()
        Cmd = New OdbcCommand("select * from tbl_transaksi where IdTransaksi in(select max(IdTransaksi) from tbl_transaksi)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "TRS" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            UrutanKode = "TRS" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If

        Dim simpan As String = "Insert into tbl_transaksi(IdTransaksi,IdPelanggan,TotalItem,TotalHarga,Tunai,Kembalian) VALUES ('" & UrutanKode & "','" & txtidpelanggan.Text & "','" & TotalItem & "','" & txttotal.Text & "','" & txttunai.Text & "','" & txtkembalian.Text & "')"
        Cmd = New OdbcCommand(simpan, Conn)
        Cmd.ExecuteNonQuery()

        For Each cmbJenis As ComboBox In panelitem.Controls.OfType(Of ComboBox)()
            Dim controlIndex As Integer = Integer.Parse(cmbJenis.Name.Split("_")(1))
            Dim txtjumlah As TextBox = CType(panelitem.Controls.Find(("txtJumlah_" & controlIndex), True)(0), TextBox)

            Dim simpanitem As String = "Insert into tbl_transaksi_item(IdTransaksi,NamaJenis,Harga,Jumlah) VALUES ('" & UrutanKode & "','" & cmbJenis.Text & "','" & cmbJenis.SelectedValue & "','" & txtjumlah.Text & "')"
            Cmd = New OdbcCommand(simpanitem, Conn)
            Cmd.ExecuteNonQuery()
        Next

        MsgBox("Input Data Berhasil !", MsgBoxStyle.Information)
    End Sub
End Class