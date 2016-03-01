Imports System.Configuration
Imports System.Data.SqlClient

Public Class frmAddMember

    'khaibao bien toan cuc de ket noi
    Private _ConnectionString As String = ConfigurationSettings.AppSettings("myconnectionstring")

    Dim connectionObject, connectionObject2 As New SqlClient.SqlConnection(_ConnectionString)
    Private Sub btnDangki_Click(sender As Object, e As EventArgs) Handles btnDangki.Click
        If txtMakh.Text = "" OrElse txtTendangnhap.Text = "" OrElse txtMatkhau.Text = "" OrElse txtTenkh.Text = "" Then
            MessageBox.Show(" vui lòng nhập đầy đủ", "nhập chưa đủ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        ElseIf txtMakh.Text.Length > 5 Then
            MessageBox.Show("yêu cầu mã khách hàng ít hơn 5 kí tự")
        Else
            Dim selectqry As String = String.Format("select * from mlogin  where ma_kh = @ma_kh")

            Dim selectcmd As New SqlClient.SqlCommand(selectqry, connectionObject)

            'create a sql object to save data into sql table

            selectcmd.Parameters.Add("ma_kh", SqlDbType.Char).Value = txtMakh.Text

            If connectionObject.State = ConnectionState.Closed Then
                connectionObject.Open()

                Dim reader As SqlClient.SqlDataReader = selectcmd.ExecuteReader


                If reader.Read = True Then
                    MsgBox("mã khách hàng đã tồn tại")

                Else

                    Dim inserQuery As String = " INSERT INTO khachhang values(@ma_kh,@ten_kh,@ngaysinh,@diachi,@ngaygianhap)"
                    Dim inserQuery2 As String = " INSERT INTO mlogin values(@ma_kh,@username, @password)"
                    Dim insertcmd As New SqlClient.SqlCommand(inserQuery, connectionObject2)
                    Dim insertcmd2 As New SqlClient.SqlCommand(inserQuery2, connectionObject2)

                    'data
                    insertcmd.Parameters.Add("ma_kh", SqlDbType.Char).Value = txtMakh.Text
                    insertcmd.Parameters.Add("ten_kh", SqlDbType.Char).Value = txtTenkh.Text
                    insertcmd.Parameters.Add("ngaysinh", SqlDbType.Char).Value = dtpNgaysinh.Text
                    insertcmd.Parameters.Add("diachi", SqlDbType.Char).Value = txtDiachi.Text
                    insertcmd.Parameters.Add("ngaygianhap", SqlDbType.Char).Value = dtpNgaygianhap.Text
                    insertcmd2.Parameters.Add("ma_kh", SqlDbType.Char).Value = txtMakh.Text
                    insertcmd2.Parameters.Add("username", SqlDbType.Char).Value = txtTendangnhap.Text
                    insertcmd2.Parameters.Add("password", SqlDbType.Char).Value = txtMatkhau.Text

                    If connectionObject2.State = ConnectionState.Closed Then connectionObject2.Open()

                    insertcmd.ExecuteNonQuery()
                    insertcmd2.ExecuteNonQuery()
                    MsgBox("thanh cong")
                    insertcmd.Dispose()
                    insertcmd2.Dispose()
                    connectionObject2.Close()


                End If
                selectcmd.Dispose()
                reader.Close()
                connectionObject.Close()
            End If
        End If

    End Sub

    Private Sub txtMakh_MouseMove(sender As Object, e As MouseEventArgs) Handles txtMakh.MouseMove
        Me.ToolTip1.SetToolTip(Me.txtMakh, "Nhập mã khách hàng bắt đầu bằng PS")
    End Sub

    Private Sub btnHuybo_Click(sender As Object, e As EventArgs) Handles btnHuybo.Click
        Me.Close()
    End Sub
End Class