Public Class WMante

    'LLENADO DEL GRID AL CARGAR FORMULARIO
    Private Sub WManteCintas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LlenadoGrid()
        TextBox.Enabled = False
        ComboBox.Enabled = False
    End Sub

    'PONE EN BALCON EL TEXBOX Y COMBOBOX
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox.Enabled = True
        ComboBox.Enabled = True
        TextBox.Text = ""
        ComboBox.Text = ""
    End Sub

    'AGREGA LOS DATOS A LA BASE DE DATOS, PONE EN BLANCO EL TEXBOX Y COMBOBOX Y CARGA DE NUEVO EL GRID
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox.Text <> "" And ComboBox.Text <> "" Then
            Dim Query As New C_Query
            Dim Conexion As New C_Conexion
            Dim Activo As New Integer

            If ComboBox.Text = "Si" Then
                Activo = 1
                Query.Sql1("Insert into t_cintas (sCOLOR,bACTIVO) values ('" & TextBox.Text & "','" & Activo & "') ")
                Conexion.cnx.Close()
                Me.LlenadoGrid()
                TextBox.Text = ""
                ComboBox.Text = ""
                TextBox.Enabled = False
                ComboBox.Enabled = False
            Else
                Activo = 0
                Query.Sql1("Inser intot t_cintas (sCOLOR,bACTIVO) values ('" & TextBox.Text & "','" & Activo & "') ")
                Conexion.cnx.Close()
                Me.LlenadoGrid()
                TextBox.Text = ""
                ComboBox.Text = ""
                TextBox.Enabled = False
                ComboBox.Enabled = False
            End If
        Else
            MessageBox.Show("        Error: DEBE DE DIGITAR EL COLOR Y LA OPCION DE ACTIVADO", "ERROR DATOS EN BLACO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    'EDITAR HABILITA EL TEXBOX Y EL COMBOBOX PARA PODER ACTUALIZAR
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox.Text <> "" And ComboBox.Text <> "" Then
            TextBox.Enabled = True
            ComboBox.Enabled = True
        Else
            MessageBox.Show("Error: CAMPOS EN BLANCO, DEBE SELECCIONAR UN DATO PARA EDITAR", "ERROR DATOS EN BLACO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    'ACTUALIZA LOS DATOS DE LA BASE DE DATOS
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox.Text <> "" And ComboBox.Text <> "" Then
            Dim Query As New C_Query
            Dim Conexion As New C_Conexion
            Dim Activo As New Integer
            Dim Idx As Integer

            Idx = DataGrid.CurrentRow.Index

            If ComboBox.Text = "Si" Then
                Activo = 1
                Query.Sql1("Update t_cintas set sCOLOR = '" & TextBox.Text & "', bACTIVO= '" & Activo & "' where iID_CINTA='" & DataGrid.Item(0, Idx).Value & "' ")
                Conexion.cnx.Close()
                Me.LlenadoGrid()
                TextBox.Text = ""
                ComboBox.Text = ""
                TextBox.Enabled = False
                ComboBox.Enabled = False
            Else
                Activo = 0
                Query.Sql1("Update t_cintas set sCOLOR = '" & TextBox.Text & "', bACTIVO= '" & Activo & "' where iID_CINTA='" & DataGrid.Item(0, Idx).Value & "' ")
                Conexion.cnx.Close()
                Me.LlenadoGrid()
                TextBox.Text = ""
                ComboBox.Text = ""
                TextBox.Enabled = False
                ComboBox.Enabled = False
            End If
        Else
            MessageBox.Show("Error: CAMPOS EN BLANCO, EL COLOR Y LA OPCION DE ACTIVADO", "ERROR DATOS EN BLACO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    'ELIMINA LOS DATOS DE LA BASE DE DATOS SELECCIONADOS EN EL GRID
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox.Text <> "" And ComboBox.Text <> "" Then
            Dim Query As New C_Query
            Dim Conexion As New C_Conexion
            Dim Activo As New Integer
            Dim Idx As Integer

            Idx = DataGrid.CurrentRow.Index

            Query.Sql1("Delete from t_cintas where iID_CINTA='" & DataGrid.Item(0, Idx).Value & "' ")
            Conexion.cnx.Close()
            Me.LlenadoGrid()
            TextBox.Text = ""
            ComboBox.Text = ""
            TextBox.Enabled = False
            ComboBox.Enabled = False
        Else
            MessageBox.Show("Error: CAMPOS EN BLANCO, EL COLOR Y LA OPCION DE ACTIVADO", "ERROR DATOS EN BLACO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

    End Sub

    'CIERRA LA VENTANA
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    'METODO PARA LLENAR EL GRID
    Public Sub LlenadoGrid()
        Dim Query As New C_Query
        Dim Conexion As New C_Conexion
        Dim Codigo As String
        Dim Color As String
        Dim Activo As String

        DataGrid.Rows.Clear()
        Query.Sql1("Select iID_CINTA,sCOLOR,bACTIVO From t_cintas")
        Try
            While Query.RS1.Read
                Codigo = Query.RS1(0)
                Color = Query.RS1(1)
                Activo = Query.RS1(2)
                If Activo = True Then
                    Activo = "Si"
                Else
                    Activo = "No"
                End If
                DataGrid.Rows.Add(Codigo, Color, Activo)
            End While
            DataGrid.Refresh()
            Conexion.cnx.Close()
        Catch ex As Exception
            MessageBox.Show("        Error: AL LLENAR FILAS DEL GRID", "ERROR EN GRID        ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub

    'METODO PARA CARGA LOS DATOS DE LA LINEA DEL GRID EN EL TEXBOX Y COMBOBOX
    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick
        Dim Idx As Integer

        Idx = DataGrid.CurrentRow.Index
        TextBox.Text = DataGrid.Item(1, Idx).Value
        ComboBox.Text = DataGrid.Item(2, Idx).Value

    End Sub

    Private Sub T_cintasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub
End Class