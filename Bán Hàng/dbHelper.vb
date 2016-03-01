Imports System.Data.SqlClient

Module dbHelper

    Public user As DataRow
    Public ds As New DataSet()
    Public ds2 As New DataSet()
    'kết nối
    Public ConnectionString As String = "workstation id=QLBanHang4.mssql.somee.com;packet size=4096;user id=minhntps03343_SQLLogin_1;pwd=v9fax9wo5l;data source=QLBanHang4.mssql.somee.com;persist security info=False;initial catalog=QLBanHang4"
    'câu lệnh thực thi
    Public Sub ExecuteNonQuery(sql As String)
        Dim Connection As New SqlConnection(ConnectionString)
        Dim command As New SqlCommand(sql, Connection)
        Connection.Open()
        command.ExecuteNonQuery()
        Connection.Close()
    End Sub
    Public Sub fill(sql As String, tenbang As String)
        Dim connection As New SqlConnection(ConnectionString)
        Dim dataAdapter As New SqlDataAdapter(sql, connection)
        If ds.Tables.Contains(tenbang) Then
            ds.Tables(tenbang).Clear()

        End If
        dataAdapter.Fill(ds, tenbang)
        connection.Close()
    End Sub

End Module
