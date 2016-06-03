Public Class WManteEstado
    Private Sub T_estadosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles T_estadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.T_estadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Fruit_traceDataSet)

    End Sub

    Private Sub WManteEstado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Fruit_traceDataSet.t_estados' Puede moverla o quitarla según sea necesario.
        Me.T_estadosTableAdapter.Fill(Me.Fruit_traceDataSet.t_estados)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim ExporGridExcel As New C_Funciones
        ExporGridExcel.GridAExcel(T_estadoDataGridView)
    End Sub
End Class