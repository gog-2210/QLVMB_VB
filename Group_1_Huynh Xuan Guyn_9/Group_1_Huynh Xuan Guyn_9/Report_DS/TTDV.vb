Public Class TTDV
    Private Sub TTDV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.ThongTinDatVe' table. You can move, or remove it, as needed.
        Me.ThongTinDatVeTableAdapter.Fill(Me.DataSet1.ThongTinDatVe)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class