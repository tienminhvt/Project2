<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmthemHoadon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmthemHoadon))
        Me.cbosoluong = New System.Windows.Forms.ComboBox()
        Me.cboloaisp = New System.Windows.Forms.ComboBox()
        Me.cboMasanpham = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTonggia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboSanpham = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNgay = New System.Windows.Forms.DateTimePicker()
        Me.cboMa_kh = New System.Windows.Forms.ComboBox()
        Me.cboMaloai = New System.Windows.Forms.ComboBox()
        Me.lblMahd = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbosoluong
        '
        Me.cbosoluong.FormattingEnabled = True
        Me.cbosoluong.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60", "70", "80", "90", "100"})
        Me.cbosoluong.Location = New System.Drawing.Point(403, 163)
        Me.cbosoluong.Name = "cbosoluong"
        Me.cbosoluong.Size = New System.Drawing.Size(121, 21)
        Me.cbosoluong.TabIndex = 50
        '
        'cboloaisp
        '
        Me.cboloaisp.FormattingEnabled = True
        Me.cboloaisp.Location = New System.Drawing.Point(403, 127)
        Me.cboloaisp.Name = "cboloaisp"
        Me.cboloaisp.Size = New System.Drawing.Size(121, 21)
        Me.cboloaisp.TabIndex = 49
        '
        'cboMasanpham
        '
        Me.cboMasanpham.FormattingEnabled = True
        Me.cboMasanpham.Location = New System.Drawing.Point(403, 27)
        Me.cboMasanpham.Name = "cboMasanpham"
        Me.cboMasanpham.Size = New System.Drawing.Size(121, 21)
        Me.cboMasanpham.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(311, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Mã sản phẩm :"
        '
        'txtTonggia
        '
        Me.txtTonggia.Location = New System.Drawing.Point(403, 198)
        Me.txtTonggia.Name = "txtTonggia"
        Me.txtTonggia.Size = New System.Drawing.Size(121, 20)
        Me.txtTonggia.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(311, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Tổng giá :"
        '
        'cboSanpham
        '
        Me.cboSanpham.FormattingEnabled = True
        Me.cboSanpham.Location = New System.Drawing.Point(403, 62)
        Me.cboSanpham.Name = "cboSanpham"
        Me.cboSanpham.Size = New System.Drawing.Size(121, 21)
        Me.cboSanpham.TabIndex = 44
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(366, 251)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Huỷ bỏ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(153, 251)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Thêm "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtNgay
        '
        Me.txtNgay.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtNgay.Location = New System.Drawing.Point(121, 65)
        Me.txtNgay.Name = "txtNgay"
        Me.txtNgay.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNgay.Size = New System.Drawing.Size(146, 20)
        Me.txtNgay.TabIndex = 41
        '
        'cboMa_kh
        '
        Me.cboMa_kh.FormattingEnabled = True
        Me.cboMa_kh.Location = New System.Drawing.Point(121, 95)
        Me.cboMa_kh.Name = "cboMa_kh"
        Me.cboMa_kh.Size = New System.Drawing.Size(146, 21)
        Me.cboMa_kh.TabIndex = 40
        '
        'cboMaloai
        '
        Me.cboMaloai.FormattingEnabled = True
        Me.cboMaloai.Location = New System.Drawing.Point(403, 95)
        Me.cboMaloai.Name = "cboMaloai"
        Me.cboMaloai.Size = New System.Drawing.Size(121, 21)
        Me.cboMaloai.TabIndex = 39
        '
        'lblMahd
        '
        Me.lblMahd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMahd.Location = New System.Drawing.Point(121, 27)
        Me.lblMahd.Name = "lblMahd"
        Me.lblMahd.Size = New System.Drawing.Size(146, 23)
        Me.lblMahd.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(311, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Số lượng :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Mã khách hàng"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(311, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Loại sản phẩm :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(311, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Mã loại :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Ngày"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(311, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Sản phẩm : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Mã hoá đơn"
        '
        'frmthemHoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 297)
        Me.Controls.Add(Me.cbosoluong)
        Me.Controls.Add(Me.cboloaisp)
        Me.Controls.Add(Me.cboMasanpham)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTonggia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboSanpham)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtNgay)
        Me.Controls.Add(Me.cboMa_kh)
        Me.Controls.Add(Me.cboMaloai)
        Me.Controls.Add(Me.lblMahd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmthemHoadon"
        Me.Text = "Thêm Hoá Đơn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbosoluong As System.Windows.Forms.ComboBox
    Friend WithEvents cboloaisp As System.Windows.Forms.ComboBox
    Friend WithEvents cboMasanpham As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTonggia As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboSanpham As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtNgay As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboMa_kh As System.Windows.Forms.ComboBox
    Friend WithEvents cboMaloai As System.Windows.Forms.ComboBox
    Friend WithEvents lblMahd As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
