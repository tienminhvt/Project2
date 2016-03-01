<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoaDon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHoaDon))
        Me.txtNgay = New System.Windows.Forms.DateTimePicker()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvHoadon = New System.Windows.Forms.DataGridView()
        Me.ma_hd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nganh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboMa_kh = New System.Windows.Forms.ComboBox()
        Me.txtSoluong = New System.Windows.Forms.TextBox()
        Me.lblMahd = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.bs2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtSanpham = New System.Windows.Forms.ComboBox()
        Me.cboMaloai = New System.Windows.Forms.ComboBox()
        Me.lblGia = New System.Windows.Forms.TextBox()
        CType(Me.dgvHoadon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNgay
        '
        Me.txtNgay.CustomFormat = ""
        Me.txtNgay.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtNgay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtNgay.Location = New System.Drawing.Point(174, 60)
        Me.txtNgay.Name = "txtNgay"
        Me.txtNgay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNgay.Size = New System.Drawing.Size(146, 20)
        Me.txtNgay.TabIndex = 30
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = Global.Bán_Hàng.My.Resources.Resources._1453799851_trash
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDelete.Location = New System.Drawing.Point(334, 133)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(52, 44)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dgvHoadon
        '
        Me.dgvHoadon.AllowUserToAddRows = False
        Me.dgvHoadon.AllowUserToDeleteRows = False
        Me.dgvHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHoadon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ma_hd, Me.nganh, Me.Column2, Me.Column1, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvHoadon.Location = New System.Drawing.Point(7, 183)
        Me.dgvHoadon.Name = "dgvHoadon"
        Me.dgvHoadon.ReadOnly = True
        Me.dgvHoadon.Size = New System.Drawing.Size(713, 215)
        Me.dgvHoadon.TabIndex = 25
        '
        'ma_hd
        '
        Me.ma_hd.DataPropertyName = "mahoadon"
        Me.ma_hd.HeaderText = "Mã hoá đơn"
        Me.ma_hd.Name = "ma_hd"
        Me.ma_hd.ReadOnly = True
        '
        'nganh
        '
        Me.nganh.DataPropertyName = "ngay"
        Me.nganh.HeaderText = "ngày"
        Me.nganh.Name = "nganh"
        Me.nganh.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "ma_kh"
        Me.Column2.HeaderText = "Mã khách hàng"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ten_sp"
        Me.Column1.HeaderText = "Tên sản phẩm"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "maloai"
        Me.Column3.HeaderText = "mã loại"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "soluong"
        Me.Column4.HeaderText = "Số lượng"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "tong_gia"
        Me.Column5.HeaderText = "Tổng giá"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'cboMa_kh
        '
        Me.cboMa_kh.Enabled = False
        Me.cboMa_kh.FormattingEnabled = True
        Me.cboMa_kh.Location = New System.Drawing.Point(174, 90)
        Me.cboMa_kh.Name = "cboMa_kh"
        Me.cboMa_kh.Size = New System.Drawing.Size(146, 21)
        Me.cboMa_kh.TabIndex = 24
        '
        'txtSoluong
        '
        Me.txtSoluong.Enabled = False
        Me.txtSoluong.Location = New System.Drawing.Point(456, 98)
        Me.txtSoluong.Name = "txtSoluong"
        Me.txtSoluong.Size = New System.Drawing.Size(121, 20)
        Me.txtSoluong.TabIndex = 22
        '
        'lblMahd
        '
        Me.lblMahd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMahd.Location = New System.Drawing.Point(174, 22)
        Me.lblMahd.Name = "lblMahd"
        Me.lblMahd.Size = New System.Drawing.Size(146, 23)
        Me.lblMahd.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(364, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Số lượng"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(487, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "tổng giá"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Mã khách hàng"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(364, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Mã loại"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Ngày"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(364, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Sản phẩm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Mã hoá đơn"
        '
        'btnBack
        '
        Me.btnBack.BackgroundImage = Global.Bán_Hàng.My.Resources.Resources.MB__back
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBack.Location = New System.Drawing.Point(174, 133)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(51, 44)
        Me.btnBack.TabIndex = 31
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.BackgroundImage = Global.Bán_Hàng.My.Resources.Resources._1453799894_document_blank
        Me.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNew.Location = New System.Drawing.Point(252, 133)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(52, 44)
        Me.btnNew.TabIndex = 26
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'txtSanpham
        '
        Me.txtSanpham.Enabled = False
        Me.txtSanpham.FormattingEnabled = True
        Me.txtSanpham.Location = New System.Drawing.Point(456, 20)
        Me.txtSanpham.Name = "txtSanpham"
        Me.txtSanpham.Size = New System.Drawing.Size(121, 21)
        Me.txtSanpham.TabIndex = 32
        '
        'cboMaloai
        '
        Me.cboMaloai.Enabled = False
        Me.cboMaloai.FormattingEnabled = True
        Me.cboMaloai.Location = New System.Drawing.Point(456, 57)
        Me.cboMaloai.Name = "cboMaloai"
        Me.cboMaloai.Size = New System.Drawing.Size(121, 21)
        Me.cboMaloai.TabIndex = 33
        '
        'lblGia
        '
        Me.lblGia.Location = New System.Drawing.Point(560, 151)
        Me.lblGia.Name = "lblGia"
        Me.lblGia.Size = New System.Drawing.Size(144, 20)
        Me.lblGia.TabIndex = 34
        '
        'frmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 408)
        Me.Controls.Add(Me.lblGia)
        Me.Controls.Add(Me.cboMaloai)
        Me.Controls.Add(Me.txtSanpham)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtNgay)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.dgvHoadon)
        Me.Controls.Add(Me.cboMa_kh)
        Me.Controls.Add(Me.txtSoluong)
        Me.Controls.Add(Me.lblMahd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHoaDon"
        Me.Text = "Hoá Đơn"
        CType(Me.dgvHoadon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtNgay As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents dgvHoadon As System.Windows.Forms.DataGridView
    Friend WithEvents ma_hd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nganh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboMa_kh As System.Windows.Forms.ComboBox
    Friend WithEvents txtSoluong As System.Windows.Forms.TextBox
    Friend WithEvents lblMahd As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bs2 As System.Windows.Forms.BindingSource
    Friend WithEvents txtSanpham As System.Windows.Forms.ComboBox
    Friend WithEvents cboMaloai As System.Windows.Forms.ComboBox
    Friend WithEvents lblGia As System.Windows.Forms.TextBox
End Class
