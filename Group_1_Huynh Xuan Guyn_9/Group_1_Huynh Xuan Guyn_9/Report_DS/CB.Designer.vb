<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CB
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ChuyenBayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet4 = New Group_1_Huynh_Xuan_Guyn_9.DataSet4()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ChuyenBayTableAdapter = New Group_1_Huynh_Xuan_Guyn_9.DataSet4TableAdapters.ChuyenBayTableAdapter()
        CType(Me.ChuyenBayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChuyenBayBindingSource
        '
        Me.ChuyenBayBindingSource.DataMember = "ChuyenBay"
        Me.ChuyenBayBindingSource.DataSource = Me.DataSet4
        '
        'DataSet4
        '
        Me.DataSet4.DataSetName = "DataSet4"
        Me.DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ChuyenBayBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Group_1_Huynh_Xuan_Guyn_9.rpt_CB.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1037, 373)
        Me.ReportViewer1.TabIndex = 0
        '
        'ChuyenBayTableAdapter
        '
        Me.ChuyenBayTableAdapter.ClearBeforeFill = True
        '
        'CB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 373)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "CB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Huynh Xuan Guyn_9_Goup1"
        CType(Me.ChuyenBayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ChuyenBayBindingSource As BindingSource
    Friend WithEvents DataSet4 As DataSet4
    Friend WithEvents ChuyenBayTableAdapter As DataSet4TableAdapters.ChuyenBayTableAdapter
End Class
