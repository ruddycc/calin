Imports MySql.Data.MySqlClient

Public Class C_Conexion

    Dim strconexion As String = "server=localhost;database=fruit_trace;user id=root;password=;port=3306;"
    Public cnx As MySqlConnection = New MySqlConnection(strconexion)

End Class

