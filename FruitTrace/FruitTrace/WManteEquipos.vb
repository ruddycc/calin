Public Class WManteEquipos
    Private Sub WManteEquipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Fruit_traceDataSet.t_equipos' Puede moverla o quitarla según sea necesario.
        Me.T_equiposTableAdapter.Fill(Me.Fruit_traceDataSet.t_equipos)
    End Sub

    Private Sub T_equiposBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles T_equiposBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.T_equiposBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Fruit_traceDataSet)

    End Sub

    Private Sub ButtonExportarExcel_Click(sender As Object, e As EventArgs) Handles ButtonExportarExcel.Click
        Dim ExporGridExcel As New C_Funciones
        ExporGridExcel.GridAExcel(T_equiposDataGridView)
    End Sub
End Class