Imports System.Data.SqlClient
Imports System.IO
Public Class frmSanPham

    Private Sub fillthemsach()
        Dim sql As String =
            <sql>
                select * from sanpham inner join loaisanpham on sanpham.maloai = loaisanpham.maloai
            </sql>
        fill(sql, "sanpham")
        bs.DataSource = ds.Tables("sanpham")
        dgvSource.DataSource = bs
        bs.ResetBindings(False)
    End Sub


    Private Sub frmThemSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillthemsach()
        Dim sql4 As String = "select * from loaisanpham"
        fill(sql4, "loaisanpham")
        cboMaloai.DataSource = ds.Tables("loaisanpham")
        cboMaloai.DisplayMember = "maloai"
        cboMaloai.ValueMember = "tenloai"

        Dim sql5 As String = "select * from loaisanpham"
        fill(sql5, "loaisanpham")
        cboTenLoai.DataSource = ds.Tables("loaisanpham")
        cboTenLoai.DisplayMember = "tenloai"
        cboTenLoai.ValueMember = "maloai"
    End Sub
   


    Private Sub dgvSource_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSource.SelectionChanged
        Try
            Dim rowview As DataRowView = bs.Current
            Dim row As DataRow = rowview.Row
            txtMasp.Text = row("masanpham")
            cboMaloai.Text = row("maloai")
            txtTensp.Text = row("ten_sp")
            txtNoisx.Text = row("noi_sx")
            txtTacgia.Text = row("tacgia")
            txtGia.Text = row("gia")
            txtHinh.Text = row("hinh")
            cboTenLoai.Text = row("tenloai")
            ptbHinh.ImageLocation = "hinh2/" & row("Hinh")

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim sql As String =
                <sql>
                insert into sanpham(masanpham,maloai,ten_sp,noi_sx,tacgia,gia,hinh)
                values('{0}','{1}',N'{2}',N'{3}',N'{4}','{5}','{6}')
            </sql>
            sql = String.Format(sql, txtMasp.Text, cboMaloai.Text, txtTensp.Text, txtNoisx.Text, txtTacgia.Text, txtGia.Text, txtHinh.Text)
            ExecuteNonQuery(sql)

            fillthemsach()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim sql As String =
            <sql>
                update sanpham
                set maloai = '{0}' , ten_sp = N'{1}', noi_sx = N'{2}' , tacgia = N'{3}', gia = N'{4}',hinh = N'{5}'
                where (masanpham = '{6}')
            </sql>
        sql = String.Format(sql, cboMaloai.Text, txtTensp.Text, txtNoisx.Text, txtTacgia.Text, txtGia.Text, txtHinh.Text, txtMasp.Text)
        ExecuteNonQuery(sql)
        fillthemsach()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim sql As String =
            <sql>
                delete from sanpham
                where masanpham ='{0}'
            </sql>
        sql = String.Format(sql, txtMasp.Text)
        ExecuteNonQuery(sql)
        fillthemsach()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtMasp.Clear()
        txtGia.Clear()
        txtNoisx.Clear()
        txtTacgia.Clear()
        txtTensp.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmPanel.Show()
        Me.Hide()
    End Sub

    Private Sub ptbHinh_Click(sender As Object, e As EventArgs) Handles ptbHinh.Click
        Try
            If ofdHinh.ShowDialog() = Windows.Forms.DialogResult.OK Then
                File.Copy(ofdHinh.FileName, "Hinh2/" & ofdHinh.SafeFileName, True)
                txtHinh.Text = ofdHinh.SafeFileName
                ptbHinh.ImageLocation = "Hinh2/" & ofdHinh.SafeFileName
            End If
        Catch ex As Exception
        End Try
    End Sub


    
End Class