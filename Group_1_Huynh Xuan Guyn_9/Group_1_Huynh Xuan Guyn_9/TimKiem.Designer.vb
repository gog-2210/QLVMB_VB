<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimKiem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TimKiem))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TenKHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMNDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiemKhoiHanhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiemDenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HangBayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayDiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayVeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongNguoiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GiaVeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChuyenBayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimKiemDataSet11 = New Group_1_Huynh_Xuan_Guyn_9.TimKiemDataSet1()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.cbxDiemKhoiHanh = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxDiemDen = New System.Windows.Forms.ComboBox()
        Me.btnTimNhanh = New System.Windows.Forms.Button()
        Me.btnLamMoi = New System.Windows.Forms.Button()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.chbxTenKH = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChuyenBayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimKiemDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TenKHDataGridViewTextBoxColumn, Me.CMNDDataGridViewTextBoxColumn, Me.DiemKhoiHanhDataGridViewTextBoxColumn, Me.DiemDenDataGridViewTextBoxColumn, Me.HangBayDataGridViewTextBoxColumn, Me.NgayDiDataGridViewTextBoxColumn, Me.NgayVeDataGridViewTextBoxColumn, Me.SoLuongNguoiDataGridViewTextBoxColumn, Me.GiaVeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ChuyenBayBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 283)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1157, 297)
        Me.DataGridView1.TabIndex = 0
        '
        'TenKHDataGridViewTextBoxColumn
        '
        Me.TenKHDataGridViewTextBoxColumn.DataPropertyName = "tenKH"
        Me.TenKHDataGridViewTextBoxColumn.HeaderText = "tenKH"
        Me.TenKHDataGridViewTextBoxColumn.Name = "TenKHDataGridViewTextBoxColumn"
        '
        'CMNDDataGridViewTextBoxColumn
        '
        Me.CMNDDataGridViewTextBoxColumn.DataPropertyName = "CMND"
        Me.CMNDDataGridViewTextBoxColumn.HeaderText = "CMND"
        Me.CMNDDataGridViewTextBoxColumn.Name = "CMNDDataGridViewTextBoxColumn"
        '
        'DiemKhoiHanhDataGridViewTextBoxColumn
        '
        Me.DiemKhoiHanhDataGridViewTextBoxColumn.DataPropertyName = "DiemKhoiHanh"
        Me.DiemKhoiHanhDataGridViewTextBoxColumn.HeaderText = "DiemKhoiHanh"
        Me.DiemKhoiHanhDataGridViewTextBoxColumn.Name = "DiemKhoiHanhDataGridViewTextBoxColumn"
        '
        'DiemDenDataGridViewTextBoxColumn
        '
        Me.DiemDenDataGridViewTextBoxColumn.DataPropertyName = "DiemDen"
        Me.DiemDenDataGridViewTextBoxColumn.HeaderText = "DiemDen"
        Me.DiemDenDataGridViewTextBoxColumn.Name = "DiemDenDataGridViewTextBoxColumn"
        '
        'HangBayDataGridViewTextBoxColumn
        '
        Me.HangBayDataGridViewTextBoxColumn.DataPropertyName = "HangBay"
        Me.HangBayDataGridViewTextBoxColumn.HeaderText = "HangBay"
        Me.HangBayDataGridViewTextBoxColumn.Name = "HangBayDataGridViewTextBoxColumn"
        '
        'NgayDiDataGridViewTextBoxColumn
        '
        Me.NgayDiDataGridViewTextBoxColumn.DataPropertyName = "NgayDi"
        Me.NgayDiDataGridViewTextBoxColumn.HeaderText = "NgayDi"
        Me.NgayDiDataGridViewTextBoxColumn.Name = "NgayDiDataGridViewTextBoxColumn"
        '
        'NgayVeDataGridViewTextBoxColumn
        '
        Me.NgayVeDataGridViewTextBoxColumn.DataPropertyName = "NgayVe"
        Me.NgayVeDataGridViewTextBoxColumn.HeaderText = "NgayVe"
        Me.NgayVeDataGridViewTextBoxColumn.Name = "NgayVeDataGridViewTextBoxColumn"
        '
        'SoLuongNguoiDataGridViewTextBoxColumn
        '
        Me.SoLuongNguoiDataGridViewTextBoxColumn.DataPropertyName = "SoLuongNguoi"
        Me.SoLuongNguoiDataGridViewTextBoxColumn.HeaderText = "Nguoi"
        Me.SoLuongNguoiDataGridViewTextBoxColumn.Name = "SoLuongNguoiDataGridViewTextBoxColumn"
        Me.SoLuongNguoiDataGridViewTextBoxColumn.Width = 70
        '
        'GiaVeDataGridViewTextBoxColumn
        '
        Me.GiaVeDataGridViewTextBoxColumn.DataPropertyName = "GiaVe"
        Me.GiaVeDataGridViewTextBoxColumn.HeaderText = "GiaVe"
        Me.GiaVeDataGridViewTextBoxColumn.Name = "GiaVeDataGridViewTextBoxColumn"
        '
        'ChuyenBayBindingSource
        '
        Me.ChuyenBayBindingSource.DataMember = "ChuyenBay"
        Me.ChuyenBayBindingSource.DataSource = Me.TimKiemDataSet11
        '
        'TimKiemDataSet11
        '
        Me.TimKiemDataSet11.DataSetName = "TimKiemDataSet1"
        Me.TimKiemDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = resources.GetString("OleDbSelectCommand1.CommandText")
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=LAPTOP-E2K5JO10\GUYNIT;Persist Security Info=True;" &
    "User ID=sa;Password=guynhuynh123;Initial Catalog=QLVMB"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ChuyenBay", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaCB", "MaCB"), New System.Data.Common.DataColumnMapping("DiemKhoiHanh", "DiemKhoiHanh"), New System.Data.Common.DataColumnMapping("DiemDen", "DiemDen"), New System.Data.Common.DataColumnMapping("ThoiGianBay", "ThoiGianBay"), New System.Data.Common.DataColumnMapping("NgayDi", "NgayDi"), New System.Data.Common.DataColumnMapping("NgayVe", "NgayVe"), New System.Data.Common.DataColumnMapping("MaTTDV", "MaTTDV"), New System.Data.Common.DataColumnMapping("MaVe", "MaVe"), New System.Data.Common.DataColumnMapping("MaCB1", "MaCB1"), New System.Data.Common.DataColumnMapping("MaKH", "MaKH"), New System.Data.Common.DataColumnMapping("SoLuongNguoi", "SoLuongNguoi"), New System.Data.Common.DataColumnMapping("NgayDat", "NgayDat"), New System.Data.Common.DataColumnMapping("MaKH1", "MaKH1"), New System.Data.Common.DataColumnMapping("CMND", "CMND"), New System.Data.Common.DataColumnMapping("tenKH", "tenKH"), New System.Data.Common.DataColumnMapping("SDT", "SDT"), New System.Data.Common.DataColumnMapping("MaVe1", "MaVe1"), New System.Data.Common.DataColumnMapping("HangBay", "HangBay"), New System.Data.Common.DataColumnMapping("GiaVe", "GiaVe"), New System.Data.Common.DataColumnMapping("TinhTrangVe", "TinhTrangVe")})})
        '
        'cbxDiemKhoiHanh
        '
        Me.cbxDiemKhoiHanh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDiemKhoiHanh.FormattingEnabled = True
        Me.cbxDiemKhoiHanh.Items.AddRange(New Object() {"An Giang", "Kon Tum", "Bà Rịa – Vũng Tàu", "Lai Châu", "Bắc Giang", "Lâm Đồng", "Bắc Kạn", "Lạng Sơn", "Bạc Liêu", "Lào Cai", "Bắc Ninh", "Long An", "Bến Tre", "Nam Định", "Bình Định", "Nghệ An", "Bình Dương", "Ninh Bình", "Bình Phước", "Ninh Thuận", "Bình Thuận", "Phú Thọ", "Cà Mau", "Phú Yên", "Cần Thơ", "Quảng Bình", "Cao Bằng", "Quảng Nam", "Đà Nẵng", "Quảng Ngãi", "Đắk Lắk", "Quảng Ninh", "Đắk Nông", "Quảng Trị", "Điện Biên", "Sóc Trăng", "Đồng Nai", "Sơn La", "Đồng Tháp", "Tây Ninh", "Gia Lai", "Thái Bình", "Hà Giang", "Thái Nguyên", "Hà Nam", "Thanh Hóa", "Hà Nội", "Thừa Thiên Huế", "Hà Tĩnh", "Tiền Giang", "Hải Dương", "TP Hồ Chí Minh", "Hải Phòng", "Trà Vinh", "Hậu Giang", "Tuyên Quang", "Hòa Bình", "Vĩnh Long", "Hưng Yên", "Vĩnh Phúc", "Khánh Hòa", "Yên Bái", "Kiên Giang"})
        Me.cbxDiemKhoiHanh.Location = New System.Drawing.Point(543, 105)
        Me.cbxDiemKhoiHanh.Name = "cbxDiemKhoiHanh"
        Me.cbxDiemKhoiHanh.Size = New System.Drawing.Size(187, 33)
        Me.cbxDiemKhoiHanh.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(565, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Điểm khởi hành"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(809, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Điểm đến"
        '
        'cbxDiemDen
        '
        Me.cbxDiemDen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDiemDen.FormattingEnabled = True
        Me.cbxDiemDen.Items.AddRange(New Object() {"An Giang", "Kon Tum", "Bà Rịa – Vũng Tàu", "Lai Châu", "Bắc Giang", "Lâm Đồng", "Bắc Kạn", "Lạng Sơn", "Bạc Liêu", "Lào Cai", "Bắc Ninh", "Long An", "Bến Tre", "Nam Định", "Bình Định", "Nghệ An", "Bình Dương", "Ninh Bình", "Bình Phước", "Ninh Thuận", "Bình Thuận", "Phú Thọ", "Cà Mau", "Phú Yên", "Cần Thơ", "Quảng Bình", "Cao Bằng", "Quảng Nam", "Đà Nẵng", "Quảng Ngãi", "Đắk Lắk", "Quảng Ninh", "Đắk Nông", "Quảng Trị", "Điện Biên", "Sóc Trăng", "Đồng Nai", "Sơn La", "Đồng Tháp", "Tây Ninh", "Gia Lai", "Thái Bình", "Hà Giang", "Thái Nguyên", "Hà Nam", "Thanh Hóa", "Hà Nội", "Thừa Thiên Huế", "Hà Tĩnh", "Tiền Giang", "Hải Dương", "TP Hồ Chí Minh", "Hải Phòng", "Trà Vinh", "Hậu Giang", "Tuyên Quang", "Hòa Bình", "Vĩnh Long", "Hưng Yên", "Vĩnh Phúc", "Khánh Hòa", "Yên Bái", "Kiên Giang"})
        Me.cbxDiemDen.Location = New System.Drawing.Point(760, 107)
        Me.cbxDiemDen.Name = "cbxDiemDen"
        Me.cbxDiemDen.Size = New System.Drawing.Size(187, 33)
        Me.cbxDiemDen.TabIndex = 5
        '
        'btnTimNhanh
        '
        Me.btnTimNhanh.BackColor = System.Drawing.Color.Gold
        Me.btnTimNhanh.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimNhanh.ForeColor = System.Drawing.Color.Red
        Me.btnTimNhanh.Image = CType(resources.GetObject("btnTimNhanh.Image"), System.Drawing.Image)
        Me.btnTimNhanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTimNhanh.Location = New System.Drawing.Point(292, 196)
        Me.btnTimNhanh.Name = "btnTimNhanh"
        Me.btnTimNhanh.Padding = New System.Windows.Forms.Padding(20, 0, 30, 0)
        Me.btnTimNhanh.Size = New System.Drawing.Size(257, 53)
        Me.btnTimNhanh.TabIndex = 7
        Me.btnTimNhanh.Text = "Tìm nhanh"
        Me.btnTimNhanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTimNhanh.UseVisualStyleBackColor = False
        '
        'btnLamMoi
        '
        Me.btnLamMoi.Image = CType(resources.GetObject("btnLamMoi.Image"), System.Drawing.Image)
        Me.btnLamMoi.Location = New System.Drawing.Point(693, 196)
        Me.btnLamMoi.Name = "btnLamMoi"
        Me.btnLamMoi.Size = New System.Drawing.Size(75, 53)
        Me.btnLamMoi.TabIndex = 9
        Me.btnLamMoi.UseVisualStyleBackColor = True
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(174, 105)
        Me.txtTenKH.Multiline = True
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(246, 35)
        Me.txtTenKH.TabIndex = 12
        '
        'btnThoat
        '
        Me.btnThoat.BackColor = System.Drawing.Color.LightCoral
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(785, 196)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(98, 53)
        Me.btnThoat.TabIndex = 13
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = False
        '
        'chbxTenKH
        '
        Me.chbxTenKH.AutoSize = True
        Me.chbxTenKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxTenKH.Location = New System.Drawing.Point(193, 69)
        Me.chbxTenKH.Name = "chbxTenKH"
        Me.chbxTenKH.Size = New System.Drawing.Size(197, 29)
        Me.chbxTenKH.TabIndex = 14
        Me.chbxTenKH.Text = "Tên Khách Hàng"
        Me.chbxTenKH.UseVisualStyleBackColor = True
        '
        'TimKiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1181, 604)
        Me.Controls.Add(Me.chbxTenKH)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.btnLamMoi)
        Me.Controls.Add(Me.btnTimNhanh)
        Me.Controls.Add(Me.cbxDiemDen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxDiemKhoiHanh)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "TimKiem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HuynhXuanGuyn_9_Group1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChuyenBayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimKiemDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents TimKiemDataSet11 As TimKiemDataSet1
    Friend WithEvents ChuyenBayBindingSource As BindingSource
    Friend WithEvents cbxDiemKhoiHanh As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxDiemDen As ComboBox
    Friend WithEvents btnTimNhanh As Button
    Friend WithEvents TenKHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CMNDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiemKhoiHanhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiemDenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HangBayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgayDiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgayVeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongNguoiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GiaVeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnLamMoi As Button
    Friend WithEvents txtTenKH As TextBox
    Friend WithEvents btnThoat As Button
    Friend WithEvents chbxTenKH As CheckBox
End Class
