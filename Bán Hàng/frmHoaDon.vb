Public Class frmHoaDon
    Private Sub fillhoadon()
        Dim sql As String =
            <sql>
    select hoadon.mahoadon ,hoadon .ngay, khachhang .ma_kh,
		sanpham.ten_sp , loaisanpham .maloai , soluong , tong_gia 
  from 
		sanpham 
		inner join loaisanpham  on loaisanpham .maloai = sanpham .maloai 
		inner join chitiet_hoadon on sanpham .masanpham = chitiet_hoadon .masanpham
		inner join hoadon on chitiet_hoadon .mahoadon = hoadon .mahoadon 
		inner join khachhang on khachhang.ma_kh = hoadon .ma_kh 
        inner join mlogin on khachhang.ma_kh = mlogin .ma_kh  
            </sql>
        fill(sql, "hoadon")
        bs2.DataSource = ds.Tables("hoadon")
        dgvHoadon.DataSource = bs2
        bs2.ResetBindings(False)
    End Sub

    Private Sub fillXoa()
        Dim sql As String =
           <sql>
                delete from chitiet_hoadon
                where mahoadon = '{0}'
                delete from hoadon
                where mahoadon = '{1}'
            </sql>
        sql = String.Format(sql, lblMahd.Text, lblMahd.Text)
        ExecuteNonQuery(sql)
        fillhoadon()
        MsgBox(" Đã xoá thành công ")

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillhoadon()
        Dim sql As String = <sql>
                                select * from khachhang
                            </sql>
        fill(sql, "khachhang")
        cboMa_kh.DataSource = ds.Tables("khachhang")
        cboMa_kh.DisplayMember = "ma_kh"
        cboMa_kh.ValueMember = "ten_kh"

        Dim sql2 As String = <sql>
                                 select * from sanpham
                             </sql>
        fill(sql2, "sanpham")
        cboMaloai.DataSource = ds.Tables("sanpham")
        cboMaloai.DisplayMember = "maloai"
        cboMaloai.ValueMember = "ten_sp"

        Dim sql3 As String = <sql>
                                 select * from sanpham
                             </sql>
        fill(sql3, "sanpham")
        txtSanpham.DataSource = ds.Tables("sanpham")
        txtSanpham.DisplayMember = "ten_sp"
        txtSanpham.ValueMember = "maloai"
    End Sub

   

    Private Sub dgvHoadon_SelectionChanged(sender As Object, e As EventArgs) Handles dgvHoadon.SelectionChanged
        Try
            Dim rowview As DataRowView = bs2.Current
            Dim row As DataRow = rowview.Row
            lblMahd.Text = row("mahoadon")
            txtNgay.Text = row("ngay")
            cboMa_kh.Text = row("ma_kh")
            txtSanpham.Text = row("ten_sp")
            cboMaloai.Text = row("maloai")
            txtSoluong.Text = row("soluong")
            lblGia.Text = row("tong_gia")
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click


        txtSanpham.Text = ""
        txtSoluong.Clear()
        lblMahd.Text = ""
        lblGia.Text = ""
        cboMa_kh.Text = ""
        cboMaloai.Text = ""

    End Sub

   

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        fillXoa()
    End Sub


End Class