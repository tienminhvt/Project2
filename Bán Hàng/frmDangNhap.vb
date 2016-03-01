Imports System.Configuration
Imports System.Data.SqlClient
Public Class frmDangNhap
    ' khai bao bien toan cuc de ket noi vs CSDL
    Private _ConnectionString As String = ConfigurationSettings.AppSettings("MyconnectionString")
    Private conn As SqlConnection
    Private da As SqlDataAdapter

    'dinh nghia ham lay du lieu do vao table
    Private Function getDataTable(sqlQuery As String) As DataTable
        Dim dTable As New DataTable
        'khoi tao bien conn
        conn = New SqlConnection(_ConnectionString)

        'khoi tao bien da
        da = New SqlDataAdapter(sqlQuery, conn)

        Try
            conn.Open()
            da.Fill(dTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error") 'thongbao
        Finally
            conn.Close() 'close 
        End Try

        Return dTable

    End Function

    ' dinh nghia ham kiem tra 
    Private Function CheckLogin(user As String, pass As String) As Boolean
        Dim sqlQuery As String = String.Format("select * from  dbo.mlogin where username = '{0}' and password = '{1}'", user, pass)
        Dim dTable As DataTable = getDataTable(sqlQuery)
        Return dTable.Rows.Count > 0
    End Function

    'kiem tra user,pass rong
    Private Function Empty() As Boolean
        Return String.IsNullOrEmpty(Me.txtLogin.Text) OrElse String.IsNullOrEmpty(Me.txtPass.Text)
    End Function
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click, btnLogin.Enter, MyBase.Enter
        If Empty() Then
            MessageBox.Show("bạn chưa nhập tên đăng nhập hoặc mật khẩu ")
        Else
            If CheckLogin(Me.txtLogin.Text.ToLower, Me.txtPass.Text.ToLower) Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                MessageBox.Show("đăng nhập thành công")

                Me.Close()
            Else 'truong hop sai user or pass
                MessageBox.Show(" sai tên đăng nhập hoặc mật khẩu")
            End If
        End If
    End Sub


    Private Sub txtLogin_Click(sender As Object, e As EventArgs) Handles txtLogin.Click
        txtLogin.Clear()
        txtPass.Text = "tienminh"
    End Sub

    Private Sub txtPass_TextClick(sender As Object, e As EventArgs) Handles txtPass.Click
        txtPass.Clear()
        txtLogin.Text = "tienminh"
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        frmAddMember.Show()


    End Sub

    Private Sub frmDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLogin.Focus()
    End Sub
End Class
