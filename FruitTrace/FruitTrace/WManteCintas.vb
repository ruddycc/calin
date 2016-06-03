Public Class WManteCintas
    Private Sub T_cintasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles T_cintasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.T_cintasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Fruit_traceDataSet)
    End Sub

    Private Sub WManteCintas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Fruit_traceDataSet.t_cintas' Puede moverla o quitarla según sea necesario.
        Me.T_cintasTableAdapter.Fill(Me.Fruit_traceDataSet.t_cintas)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ButtonExportarExcel.Click
        Dim ExporGridExcel As New C_Funciones
        ExporGridExcel.GridAExcel(T_cintasDataGridView)
    End Sub
End Class