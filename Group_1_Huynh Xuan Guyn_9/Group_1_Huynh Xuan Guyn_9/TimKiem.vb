Public Class TimKiem
    Private Sub loaddata()
        TimKiemDataSet11.Clear()
        TimKiemDataSet11.EnforceConstraints = False
        OleDbDataAdapter1.Fill(TimKiemDataSet11)
    End Sub
    Private Sub TimKiem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Private Sub TimKiem(value As String, value1 As String, value2 As String)
        Try
            OleDbConnection1.Open()
            Dim sql As String = "SELECT tenKH,CMND,DiemKhoiHanh,DiemDen,HangBay,NgayDi,NgayVe,SoLuongNguoi,GiaVe
                                FROM     ChuyenBay INNER JOIN
                                          ThongTinDatVe ON ChuyenBay.MaCB = ThongTinDatVe.MaCB INNER JOIN
                                          KhachHang ON ThongTinDatVe.MaKH = KhachHang.MaKH INNER JOIN
                                          Ve ON ThongTinDatVe.MaVe = Ve.MaVe
                                 Where TenKH != '' "
            sql += String.Format("and TenKH like N'%{0}%' ", value)
            sql += String.Format("And ChuyenBay.DiemKhoiHanh like N'%{0}%' And ChuyenBay.DiemDen Like N'%{1}%' ", value1, value2)
            OleDbSelectCommand1.CommandText = sql
            OleDbSelectCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnTimNhanh_Click(sender As Object, e As EventArgs) Handles btnTimNhanh.Click
        TimKiem(txtTenKH.Text, cbxDiemKhoiHanh.Text, cbxDiemDen.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        cbxDiemKhoiHanh.Text = ""
        cbxDiemDen.Text = ""
        txtTenKH.Text = ""
        Try
            OleDbConnection1.Open()
            Dim sql As String = "SELECT *
                                FROM     ChuyenBay INNER JOIN
                                                  ThongTinDatVe ON ChuyenBay.MaCB = ThongTinDatVe.MaCB INNER JOIN
                                                  KhachHang ON ThongTinDatVe.MaKH = KhachHang.MaKH INNER JOIN
                                 Ve ON ThongTinDatVe.MaVe = Ve.MaVe"
            OleDbSelectCommand1.CommandText = sql
            OleDbSelectCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub chbxTenKH_CheckedChanged(sender As Object, e As EventArgs) Handles chbxTenKH.CheckedChanged
        If chbxTenKH.Checked = True Then
            cbxDiemKhoiHanh.Enabled = "false"
            cbxDiemDen.Enabled = "false"
        ElseIf chbxTenKH.Checked = False Then
            cbxDiemKhoiHanh.Enabled = "true"
            cbxDiemDen.Enabled = "true"
        End If
    End Sub
End Class