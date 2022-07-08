Public Class FormReportTransaksi

    Private Sub FormReportTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tbl_transaksi' table. You can move, or remove it, as needed.
        Me.tbl_transaksiTableAdapter.Fill(Me.DataSet1.tbl_transaksi)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class