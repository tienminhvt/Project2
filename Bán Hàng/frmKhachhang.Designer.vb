<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKhachHang))
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTenkh = New System.Windows.Forms.ComboBox()
        Me.khachhang = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvDAta = New System.Windows.Forms.DataGridView()
        Me.ma_kh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ten_kh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ngaysinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diachi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ngaygianhap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.khachhang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDAta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(311, 70)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(105, 23)
        Me.btnShowAll.TabIndex = 7
        Me.btnShowAll.Text = "Hiển thị tất cả"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(77, 70)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(104, 23)
        Me.btnFind.TabIndex = 8
        Me.btnFind.Text = "Tìm kiếm"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tên khách hàng :"
        '
        'cboTenkh
        '
        Me.cboTenkh.FormattingEnabled = True
        Me.cboTenkh.Location = New System.Drawing.Point(122, 19)
        Me.cboTenkh.Name = "cboTenkh"
        Me.cboTenkh.Size = New System.Drawing.Size(121, 21)
        Me.cboTenkh.TabIndex = 4
        '
        'dgvDAta
        '
        Me.dgvDAta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDAta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ma_kh, Me.ten_kh, Me.ngaysinh, Me.diachi, Me.ngaygianhap})
        Me.dgvDAta.Location = New System.Drawing.Point(12, 110)
        Me.dgvDAta.Name = "dgvDAta"
        Me.dgvDAta.Size = New System.Drawing.Size(534, 281)
        Me.dgvDAta.TabIndex = 9
        '
        'ma_kh
        '
        Me.ma_kh.DataPropertyName = "ma_kh"
        Me.ma_kh.HeaderText = "Mã KH"
        Me.ma_kh.Name = "ma_kh"
        '
        'ten_kh
        '
        Me.ten_kh.DataPropertyName = "ten_kh"
        Me.ten_kh.HeaderText = "Tên KH"
        Me.ten_kh.Name = "ten_kh"
        '
        'ngaysinh
        '
        Me.ngaysinh.DataPropertyName = "ngaysinh"
        Me.ngaysinh.HeaderText = "Ngày Sinh"
        Me.ngaysinh.Name = "ngaysinh"
        '
        'diachi
        '
        Me.diachi.DataPropertyName = "diachi"
        Me.diachi.HeaderText = "Địa Chỉ"
        Me.diachi.Name = "diachi"
        '
        'ngaygianhap
        '
        Me.ngaygianhap.DataPropertyName = "ngaygianhap"
        Me.ngaygianhap.HeaderText = "Ngày Gia Nhập"
        Me.ngaygianhap.Name = "ngaygianhap"
        '
        'frmKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 403)
        Me.Controls.Add(Me.dgvDAta)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboTenkh)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmKhachHang"
        Me.Text = "Khách Hàng"
        CType(Me.khachhang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDAta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShowAll As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTenkh As System.Windows.Forms.ComboBox
    Friend WithEvents khachhang As System.Windows.Forms.BindingSource
    Friend WithEvents dgvDAta As System.Windows.Forms.DataGridView
    Friend WithEvents ma_kh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ten_kh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ngaysinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents diachi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ngaygianhap As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
