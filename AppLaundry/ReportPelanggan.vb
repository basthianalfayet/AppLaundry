Public Class ReportPelanggan

    Private Sub Formreportpelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tbl_pelanggan' table. You can move, or remove it, as needed.
        Me.tbl_pelangganTableAdapter.Fill(Me.DataSet1.tbl_pelanggan)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class