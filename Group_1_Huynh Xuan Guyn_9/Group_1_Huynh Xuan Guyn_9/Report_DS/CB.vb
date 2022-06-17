Public Class CB
    Private Sub CB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet4.ChuyenBay' table. You can move, or remove it, as needed.
        Me.ChuyenBayTableAdapter.Fill(Me.DataSet4.ChuyenBay)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class