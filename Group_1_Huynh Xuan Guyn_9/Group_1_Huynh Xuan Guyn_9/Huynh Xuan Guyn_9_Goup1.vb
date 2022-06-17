Public Class Form1
    Private Sub loaddata()
        QlvmbDataset1.Clear()
        QLVMBDataset.Clear()
        OleDbDataAdapterTTDV.Fill(QlvmbDataset1)
        OleDbDataAdapterKH.Fill(QlvmbDataset1)
        OleDbDataAdapterCB.Fill(QLVMBDataset)
        OleDbDataAdapterVe.Fill(QlvmbDataset1)
    End Sub
    Private Sub Huynh_Xuan_Guyn_9_Goup1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub btnThemTTDV_Click(sender As Object, e As EventArgs) Handles btnThemTTDV.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO [ThongTinDatVe] ([MaVe], [MaCB], [MaKH], [SoLuongNguoi], [NgayDat])
                                   VALUES ('" & cbxHangBay.Text & "','" & cbxMaCB.Text & "','" & cbxTenKH.Text & "'," & txtSoLuongNguoi.Text & ",'" & cbxNgayDat.Text & "')"
            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSuaTTDV_Click(sender As Object, e As EventArgs) Handles btnSuaTTDV.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE [ThongTinDatVe] 
                                    SET [MaVe] = '" + cbxHangBay.Text + "', [MaCB] = '" + cbxMaCB.Text + "', 
                                    [MaKH] = '" + cbxTenKH.Text + "', [SoLuongNguoi] = '" + txtSoLuongNguoi.Text + "', [NgayDat] = '" + cbxNgayDat.Text + "' WHERE [MaTTDV] = '" + txtMaTTDV.Text + "'"
            OleDbUpdateCommand1.CommandText = sql
            OleDbUpdateCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnHuyTTDV_Click(sender As Object, e As EventArgs) Handles btnHuyTTDV.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "DELETE FROM [ThongTinDatVe] WHERE [MaTTDV] = '" + txtMaTTDV.Text + "'"
            OleDbDeleteCommand1.CommandText = sql
            OleDbDeleteCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnThemKH_Click(sender As Object, e As EventArgs) Handles btnThemKH.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO [KhachHang] ([MaKH], [CMND], [tenKH], [SDT]) 
                    VALUES ('" & txtMaKH.Text & "', '" & txtCMND.Text & "',N'" & txtTenKH.Text & "','" & txtSDT.Text & "')"
            OleDbInsertCommand2.CommandText = sql
            OleDbInsertCommand2.ExecuteNonQuery()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSuaKH_Click(sender As Object, e As EventArgs) Handles btnSuaKH.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE [KhachHang]
                                 SET   [CMND] ='" + txtCMND.Text + "' , [tenKH] = N'" + txtTenKH.Text + "', [SDT] = '" + txtSDT.Text + "'
                                WHERE  [MaKH] = '" + txtMaKH.Text + "'"
            OleDbUpdateCommand2.CommandText = sql
            OleDbUpdateCommand2.ExecuteNonQuery()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnXoaKH_Click(sender As Object, e As EventArgs) Handles btnXoaKH.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "DELETE FROM [KhachHang] WHERE [MaKH] = '" + txtMaKH.Text + "'"
            OleDbDeleteCommand2.CommandText = sql
            OleDbDeleteCommand2.ExecuteNonQuery()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnThemCB_Click(sender As Object, e As EventArgs) Handles btnThemCB.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO [ChuyenBay] ([MaCB], [DiemKhoiHanh], [DiemDen], [ThoiGianBay], [NgayDi], [NgayVe]) 
                            VALUES ('" & txtMaCB.Text & "',N'" & cbxDiemKhoiHanh.Text & "',N'" & cbxDiemDen.Text & "',N'" & txtThoiGianBay.Text & "','" & cbxNgayDi.Text & "','" & cbxNgayVe.Text & "')"
            OleDbInsertCommand3.CommandText = sql
            OleDbInsertCommand3.ExecuteNonQuery()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSuaCB_Click(sender As Object, e As EventArgs) Handles btnSuaCB.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE [ChuyenBay] 
            SET  [DiemKhoiHanh] =N'" + cbxDiemKhoiHanh.Text + "', [DiemDen] =N'" + cbxDiemDen.Text + "', [ThoiGianBay] =N'" + txtThoiGianBay.Text + "', [NgayDi] ='" + cbxNgayDi.Text + "', [NgayVe] ='" + cbxNgayVe.Text + "' WHERE [MaCB] ='" + txtMaCB.Text + "'"
            OleDbUpdateCommand3.CommandText = sql
            OleDbUpdateCommand3.ExecuteNonQuery()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnXoaCB_Click(sender As Object, e As EventArgs) Handles btnXoaCB.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "DELETE FROM [ChuyenBay] WHERE [MaCB] ='" + txtMaCB.Text + "'"
            OleDbDeleteCommand3.CommandText = sql
            OleDbDeleteCommand3.ExecuteNonQuery()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnThemVe_Click(sender As Object, e As EventArgs) Handles btnThemVe.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO [Ve] ([MaVe], [HangBay], [GiaVe], [TinhTrangVe]) VALUES ('" & txtMaVe.Text & "',N'" & txtHangBay.Text & "','" & txtGiaVe.Text & "',N'" & txtTinhTrangVe.Text & "')"
            OleDbInsertCommand4.CommandText = sql
            OleDbInsertCommand4.ExecuteNonQuery()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSuaVe_Click(sender As Object, e As EventArgs) Handles btnSuaVe.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE [Ve] 
                    SET [HangBay] =N'" + txtHangBay.Text + "', [GiaVe] ='" + txtGiaVe.Text + "', [TinhTrangVe] =N'" + txtTinhTrangVe.Text + "' WHERE [MaVe] ='" + txtMaVe.Text + "'"
            OleDbUpdateCommand4.CommandText = sql
            OleDbUpdateCommand4.ExecuteNonQuery()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnXoaVe_Click(sender As Object, e As EventArgs) Handles btnXoaVe.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "DELETE FROM [Ve] WHERE [MaVe] ='" + txtMaVe.Text + "'"
            OleDbDeleteCommand4.CommandText = sql
            OleDbDeleteCommand4.ExecuteNonQuery()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnTinKiemNC_Click(sender As Object, e As EventArgs) Handles btnTimKiemNC.Click
        TimKiem.Show()
    End Sub

    Private Sub btnInTTDV_Click(sender As Object, e As EventArgs) Handles btnInTTDV.Click
        TTDV.Show()
    End Sub

    Private Sub btnBaoCaoKH_Click(sender As Object, e As EventArgs) Handles btnBaoCaoKH.Click
        KH.Show()
    End Sub

    Private Sub btnBaoCaoCB_Click(sender As Object, e As EventArgs) Handles btnBaoCaoCB.Click
        CB.Show()
    End Sub

    Private Sub btnBaoCaoVe_Click(sender As Object, e As EventArgs) Handles btnBaoCaoVe.Click
        Ve.Show()
    End Sub
End Class
