<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSanPham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSanPham))
        Me.txtTensp = New System.Windows.Forms.TextBox()
        Me.txtGia = New System.Windows.Forms.TextBox()
        Me.txtTacgia = New System.Windows.Forms.TextBox()
        Me.txtNoisx = New System.Windows.Forms.TextBox()
        Me.txtMasp = New System.Windows.Forms.TextBox()
        Me.cboMaloai = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvSource = New System.Windows.Forms.DataGridView()
        Me.masanpham = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tenloai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tensp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noisx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tacgia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ptbHinh = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHinh = New System.Windows.Forms.TextBox()
        Me.ofdHinh = New System.Windows.Forms.OpenFileDialog()
        Me.cboTenLoai = New System.Windows.Forms.ComboBox()
        CType(Me.dgvSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbHinh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTensp
        '
        Me.txtTensp.Location = New System.Drawing.Point(531, 31)
        Me.txtTensp.Name = "txtTensp"
        Me.txtTensp.Size = New System.Drawing.Size(121, 20)
        Me.txtTensp.TabIndex = 16
        '
        'txtGia
        '
        Me.txtGia.Location = New System.Drawing.Point(531, 136)
        Me.txtGia.Name = "txtGia"
        Me.txtGia.Size = New System.Drawing.Size(121, 20)
        Me.txtGia.TabIndex = 15
        '
        'txtTacgia
        '
        Me.txtTacgia.Location = New System.Drawing.Point(531, 101)
        Me.txtTacgia.Name = "txtTacgia"
        Me.txtTacgia.Size = New System.Drawing.Size(121, 20)
        Me.txtTacgia.TabIndex = 17
        '
        'txtNoisx
        '
        Me.txtNoisx.Location = New System.Drawing.Point(531, 66)
        Me.txtNoisx.Name = "txtNoisx"
        Me.txtNoisx.Size = New System.Drawing.Size(121, 20)
        Me.txtNoisx.TabIndex = 14
        '
        'txtMasp
        '
        Me.txtMasp.Location = New System.Drawing.Point(216, 31)
        Me.txtMasp.Name = "txtMasp"
        Me.txtMasp.Size = New System.Drawing.Size(121, 20)
        Me.txtMasp.TabIndex = 13
        '
        'cboMaloai
        '
        Me.cboMaloai.FormattingEnabled = True
        Me.cboMaloai.Items.AddRange(New Object() {"CT", "IT", "KH", "LS", "TT"})
        Me.cboMaloai.Location = New System.Drawing.Point(217, 63)
        Me.cboMaloai.Name = "cboMaloai"
        Me.cboMaloai.Size = New System.Drawing.Size(120, 21)
        Me.cboMaloai.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(445, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Giá :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(445, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tác Giả :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(445, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nơi SX :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(445, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tên SP :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(147, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Mã Loại :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Mã SP :"
        '
        'dgvSource
        '
        Me.dgvSource.AutoGenerateColumns = False
        Me.dgvSource.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvSource.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSource.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvSource.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSource.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.masanpham, Me.tenloai, Me.tensp, Me.noisx, Me.tacgia, Me.gia})
        Me.dgvSource.DataSource = Me.bs
        Me.dgvSource.Location = New System.Drawing.Point(13, 235)
        Me.dgvSource.Name = "dgvSource"
        Me.dgvSource.Size = New System.Drawing.Size(645, 202)
        Me.dgvSource.TabIndex = 5
        '
        'masanpham
        '
        Me.masanpham.DataPropertyName = "masanpham"
        Me.masanpham.HeaderText = "Mã sản phẩm"
        Me.masanpham.Name = "masanpham"
        Me.masanpham.Width = 96
        '
        'tenloai
        '
        Me.tenloai.DataPropertyName = "tenloai"
        Me.tenloai.HeaderText = "Tên loại"
        Me.tenloai.Name = "tenloai"
        Me.tenloai.Width = 70
        '
        'tensp
        '
        Me.tensp.DataPropertyName = "ten_sp"
        Me.tensp.HeaderText = "Tên sản phẩm"
        Me.tensp.Name = "tensp"
        '
        'noisx
        '
        Me.noisx.DataPropertyName = "noi_sx"
        Me.noisx.HeaderText = "Nơi sản xuất"
        Me.noisx.Name = "noisx"
        Me.noisx.Width = 91
        '
        'tacgia
        '
        Me.tacgia.DataPropertyName = "tacgia"
        Me.tacgia.HeaderText = "Tác giả"
        Me.tacgia.Name = "tacgia"
        Me.tacgia.Width = 68
        '
        'gia
        '
        Me.gia.DataPropertyName = "gia"
        Me.gia.HeaderText = "Giá"
        Me.gia.Name = "gia"
        Me.gia.Width = 48
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancel.Location = New System.Drawing.Point(497, 185)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(52, 44)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.BackgroundImage = CType(resources.GetObject("btnNew.BackgroundImage"), System.Drawing.Image)
        Me.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNew.Location = New System.Drawing.Point(408, 185)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(52, 44)
        Me.btnNew.TabIndex = 21
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDelete.Location = New System.Drawing.Point(317, 185)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(52, 44)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEdit.Location = New System.Drawing.Point(227, 185)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(52, 44)
        Me.btnEdit.TabIndex = 19
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdd.Location = New System.Drawing.Point(136, 185)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(52, 44)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(147, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Tên loại :"
        '
        'ptbHinh
        '
        Me.ptbHinh.Location = New System.Drawing.Point(12, 31)
        Me.ptbHinh.Name = "ptbHinh"
        Me.ptbHinh.Size = New System.Drawing.Size(115, 143)
        Me.ptbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbHinh.TabIndex = 26
        Me.ptbHinh.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(148, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Hình :"
        '
        'txtHinh
        '
        Me.txtHinh.Location = New System.Drawing.Point(216, 133)
        Me.txtHinh.Name = "txtHinh"
        Me.txtHinh.Size = New System.Drawing.Size(121, 20)
        Me.txtHinh.TabIndex = 28
        '
        'ofdHinh
        '
        Me.ofdHinh.FileName = "ofdHinh"
        '
        'cboTenLoai
        '
        Me.cboTenLoai.FormattingEnabled = True
        Me.cboTenLoai.Location = New System.Drawing.Point(216, 98)
        Me.cboTenLoai.Name = "cboTenLoai"
        Me.cboTenLoai.Size = New System.Drawing.Size(121, 21)
        Me.cboTenLoai.TabIndex = 29
        '
        'frmSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 447)
        Me.Controls.Add(Me.cboTenLoai)
        Me.Controls.Add(Me.txtHinh)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ptbHinh)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtTensp)
        Me.Controls.Add(Me.txtGia)
        Me.Controls.Add(Me.txtTacgia)
        Me.Controls.Add(Me.txtNoisx)
        Me.Controls.Add(Me.txtMasp)
        Me.Controls.Add(Me.cboMaloai)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvSource)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSanPham"
        Me.Text = "Sản Phẩm"
        CType(Me.dgvSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbHinh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtTensp As System.Windows.Forms.TextBox
    Friend WithEvents txtGia As System.Windows.Forms.TextBox
    Friend WithEvents txtTacgia As System.Windows.Forms.TextBox
    Friend WithEvents txtNoisx As System.Windows.Forms.TextBox
    Friend WithEvents txtMasp As System.Windows.Forms.TextBox
    Friend WithEvents cboMaloai As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvSource As System.Windows.Forms.DataGridView
    Friend WithEvents bs As System.Windows.Forms.BindingSource
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ptbHinh As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtHinh As System.Windows.Forms.TextBox
    Friend WithEvents ofdHinh As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cboTenLoai As System.Windows.Forms.ComboBox
    Friend WithEvents masanpham As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tenloai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tensp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents noisx As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tacgia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gia As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
