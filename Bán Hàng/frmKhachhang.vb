Imports System.Data.SqlClient

Public Class frmKhachHang
    Private Sub fillkhachhang()
        Dim sql As String =
            <sql>
            select * from khachhang
            </sql>
        fill(sql, "khachhang")
        khachhang.DataSource = ds.Tables("khachhang")
        dgvDAta.DataSource = khachhang
        khachhang.ResetBindings(False)

    End Sub
   
    Private Sub fillkhachhang2()
        Dim sql As String = "select * from khachhang"
        fill(sql, "khachhang")
        cboTenkh.DataSource = ds.Tables("khachhang")
        cboTenkh.DisplayMember = "ten_kh"
        cboTenkh.ValueMember = "ma_kh"
    End Sub

    Private Sub filltimkiem()
        Dim sql As String = <sql>select * from khachhang where ten_kh LIKE N'%{0}%'</sql>
        sql = String.Format(sql, cboTenkh.Text)
        fill(sql, "khachhang")
        cboTenkh.DataSource = ds.Tables("khachhang")
        cboTenkh.DisplayMember = "ten_kh"
        cboTenkh.ValueMember = "ma_kh"
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDAta.AutoGenerateColumns = False
        fillkhachhang()
        filltimkiem()
        fillkhachhang2()

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        filltimkiem()
    End Sub


    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        fillkhachhang()
        fillkhachhang2()
    End Sub

End Class