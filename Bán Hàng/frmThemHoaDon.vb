Public Class frmthemHoadon

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = " select * from khachhang "
        fill(sql, "khachhang")
        'fillhoadon2(sql, "sanpham")
        cboMa_kh.DataSource = ds.Tables("khachhang")
        cboMa_kh.DisplayMember = " ten_kh"
        cboMa_kh.ValueMember = "ma_kh"

        Dim sql2 As String = "select * from sanpham"
        fill(sql2, "sanpham")
        cboSanpham.DataSource = ds.Tables("sanpham")
        cboSanpham.DisplayMember = "ten_sp"
        cboSanpham.ValueMember = "masanpham"

        Dim sql3 As String = " select * from sanpham"
        fill(sql3, "sanpham")
        cboMasanpham.DataSource = ds.Tables("sanpham")
        cboMasanpham.DisplayMember = "masanpham"
        cboMasanpham.ValueMember = "ten_sp"
        cboMasanpham.ValueMember = "maloai"

        Dim sql4 As String = "select * from loaisanpham"
        fill(sql4, "loaisanpham")
        cboMaloai.DataSource = ds.Tables("loaisanpham")
        cboMaloai.DisplayMember = "maloai"
        cboMaloai.ValueMember = "tenloai"

        Dim sql5 As String = "select * from loaisanpham"
        fill(sql5, "loaisanpham")
        cboloaisp.DataSource = ds.Tables("loaisanpham")
        cboloaisp.DisplayMember = "tenloai"
        cboloaisp.ValueMember = "maloai"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cboMa_kh.Text = "" Then
            MsgBox(" Bạn chưa nhập mã khách hàng ")
        ElseIf cboSanpham.Text = "" Then
            MsgBox(" Bạn chưa nhâp tên sản phẩm ")
        ElseIf cbosoluong.Text = "" Then
            MsgBox(" Bạn chưa nhập số lượng hàng ")
        ElseIf cboMaloai.Text = "" Then
            MsgBox(" Bạn chưa nhập mã loại sản phẩm")
        ElseIf txtTonggia.Text = "" Then
            MsgBox(" Bạn chưa nhập tổng giá")
        Else
            Dim sql As String = <sql>
                                insert into hoadon
                                values ('{0}','{1}','{2}')
                                
                            </sql>
            sql = String.Format(sql, txtNgay.Text, cboMa_kh.Text, txtTonggia.Text)
            Dim sql2 As String = <sql>
                                insert into chitiet_hoadon
                                values (@@IDENTITY,'{3}','{4}')
                                 </sql>
            sql2 = String.Format(sql, cboMasanpham.Text, cbosoluong.Text)


            MsgBox("Nhập hoá đơn thành công")

           

        End If

    End Sub

    Private Sub cboMaloai_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMaloai.SelectedIndexChanged

    End Sub

    Private Sub cbosoluong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosoluong.SelectedIndexChanged
        
    End Sub
End Class