Public Class KH
    Private Sub KH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.KhachHang' table. You can move, or remove it, as needed.
        Me.KhachHangTableAdapter.Fill(Me.DataSet2.KhachHang)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class