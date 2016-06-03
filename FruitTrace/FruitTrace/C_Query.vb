Imports MySql.Data.MySqlClient

Public Class C_Query
    Public RS1 As MySqlDataReader
    Dim Conexion As New C_Conexion


    Public Sub Sql1(SqlTex As String)
        Dim RecordSet As New MySqlCommand
        Try
            Conexion.cnx.Open()
            RecordSet.CommandText = SqlTex
            RecordSet.Connection = Conexion.cnx
            RS1 = RecordSet.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
            Conexion.cnx.Close()
        End Try
    End Sub

End Class
