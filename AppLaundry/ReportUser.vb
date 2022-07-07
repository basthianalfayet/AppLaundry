Public Class ReportUser

    Private Sub ReportUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.tbl_user' table. You can move, or remove it, as needed.
        Me.tbl_userTableAdapter.Fill(Me.DataSet1.tbl_user)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class