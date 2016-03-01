<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddMember
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddMember))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpNgaygianhap = New System.Windows.Forms.DateTimePicker()
        Me.dtpNgaysinh = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMakh = New System.Windows.Forms.TextBox()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.txtTenkh = New System.Windows.Forms.TextBox()
        Me.btnHuybo = New System.Windows.Forms.Button()
        Me.btnDangki = New System.Windows.Forms.Button()
        Me.txtMatkhau = New System.Windows.Forms.TextBox()
        Me.txtTendangnhap = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpNgaygianhap)
        Me.GroupBox1.Controls.Add(Me.dtpNgaysinh)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtMakh)
        Me.GroupBox1.Controls.Add(Me.txtDiachi)
        Me.GroupBox1.Controls.Add(Me.txtTenkh)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 175)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin"
        '
        'dtpNgaygianhap
        '
        Me.dtpNgaygianhap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgaygianhap.Location = New System.Drawing.Point(122, 143)
        Me.dtpNgaygianhap.Name = "dtpNgaygianhap"
        Me.dtpNgaygianhap.Size = New System.Drawing.Size(111, 20)
        Me.dtpNgaygianhap.TabIndex = 2
        '
        'dtpNgaysinh
        '
        Me.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgaysinh.Location = New System.Drawing.Point(122, 84)
        Me.dtpNgaysinh.Name = "dtpNgaysinh"
        Me.dtpNgaysinh.Size = New System.Drawing.Size(111, 20)
        Me.dtpNgaysinh.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã khách hàng :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên khách hàng :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ngày sinh :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Địa chỉ :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ngày gia nhập :"
        '
        'txtMakh
        '
        Me.txtMakh.Location = New System.Drawing.Point(122, 25)
        Me.txtMakh.Name = "txtMakh"
        Me.txtMakh.Size = New System.Drawing.Size(111, 20)
        Me.txtMakh.TabIndex = 1
        '
        'txtDiachi
        '
        Me.txtDiachi.Location = New System.Drawing.Point(122, 115)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(111, 20)
        Me.txtDiachi.TabIndex = 1
        '
        'txtTenkh
        '
        Me.txtTenkh.Location = New System.Drawing.Point(122, 54)
        Me.txtTenkh.Name = "txtTenkh"
        Me.txtTenkh.Size = New System.Drawing.Size(111, 20)
        Me.txtTenkh.TabIndex = 1
        '
        'btnHuybo
        '
        Me.btnHuybo.Location = New System.Drawing.Point(159, 295)
        Me.btnHuybo.Name = "btnHuybo"
        Me.btnHuybo.Size = New System.Drawing.Size(75, 23)
        Me.btnHuybo.TabIndex = 8
        Me.btnHuybo.Text = "Huỷ bỏ"
        Me.btnHuybo.UseVisualStyleBackColor = True
        '
        'btnDangki
        '
        Me.btnDangki.Location = New System.Drawing.Point(28, 295)
        Me.btnDangki.Name = "btnDangki"
        Me.btnDangki.Size = New System.Drawing.Size(75, 23)
        Me.btnDangki.TabIndex = 9
        Me.btnDangki.Text = "Đăng kí"
        Me.btnDangki.UseVisualStyleBackColor = True
        '
        'txtMatkhau
        '
        Me.txtMatkhau.Location = New System.Drawing.Point(138, 248)
        Me.txtMatkhau.Name = "txtMatkhau"
        Me.txtMatkhau.Size = New System.Drawing.Size(111, 20)
        Me.txtMatkhau.TabIndex = 6
        '
        'txtTendangnhap
        '
        Me.txtTendangnhap.Location = New System.Drawing.Point(138, 220)
        Me.txtTendangnhap.Name = "txtTendangnhap"
        Me.txtTendangnhap.Size = New System.Drawing.Size(111, 20)
        Me.txtTendangnhap.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Mật khẩu"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tên đăng nhập :"
        '
        'frmAddMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 344)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHuybo)
        Me.Controls.Add(Me.btnDangki)
        Me.Controls.Add(Me.txtMatkhau)
        Me.Controls.Add(Me.txtTendangnhap)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddMember"
        Me.Text = "Đăng kí"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpNgaygianhap As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpNgaysinh As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMakh As System.Windows.Forms.TextBox
    Friend WithEvents txtDiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtTenkh As System.Windows.Forms.TextBox
    Friend WithEvents btnHuybo As System.Windows.Forms.Button
    Friend WithEvents btnDangki As System.Windows.Forms.Button
    Friend WithEvents txtMatkhau As System.Windows.Forms.TextBox
    Friend WithEvents txtTendangnhap As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
