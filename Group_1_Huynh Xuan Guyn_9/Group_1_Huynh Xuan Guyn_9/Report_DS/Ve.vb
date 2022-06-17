Public Class Ve
    Private Sub Ve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet3.Ve' table. You can move, or remove it, as needed.
        Me.VeTableAdapter.Fill(Me.DataSet3.Ve)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class