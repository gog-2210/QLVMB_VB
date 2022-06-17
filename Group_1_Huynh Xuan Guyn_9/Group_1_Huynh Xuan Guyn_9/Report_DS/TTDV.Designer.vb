<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TTDV
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ThongTinDatVeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Group_1_Huynh_Xuan_Guyn_9.DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ThongTinDatVeTableAdapter = New Group_1_Huynh_Xuan_Guyn_9.DataSet1TableAdapters.ThongTinDatVeTableAdapter()
        CType(Me.ThongTinDatVeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ThongTinDatVeBindingSource
        '
        Me.ThongTinDatVeBindingSource.DataMember = "ThongTinDatVe"
        Me.ThongTinDatVeBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ThongTinDatVeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Group_1_Huynh_Xuan_Guyn_9.rpt_TTDV.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1033, 407)
        Me.ReportViewer1.TabIndex = 0
        '
        'ThongTinDatVeTableAdapter
        '
        Me.ThongTinDatVeTableAdapter.ClearBeforeFill = True
        '
        'TTDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 407)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "TTDV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Huynh Xuan Guyn_9_Goup1"
        CType(Me.ThongTinDatVeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ThongTinDatVeBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ThongTinDatVeTableAdapter As DataSet1TableAdapters.ThongTinDatVeTableAdapter
End Class
