Public Class WPrincipipal
    Private Sub AreaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AreaToolStripMenuItem.Click
        WManteAreas.MdiParent = Me
        WManteAreas.Show()
    End Sub

    Private Sub WPrincipipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CintasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CintasToolStripMenuItem.Click
        WManteCintas.MdiParent = Me
        WManteCintas.Show()
    End Sub

    Private Sub EquiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquiposToolStripMenuItem.Click
        WManteEquipos.MdiParent = Me
        WManteEquipos.Show()
    End Sub

    Private Sub EstadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadosToolStripMenuItem.Click
        WManteEstado.MdiParent = Me
        WManteEstado.Show()
    End Sub

    Private Sub LectorRFIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LectorRFIDToolStripMenuItem.Click
        WManteLectorRFID.MdiParent = Me
        WManteLectorRFID.Show()
    End Sub

    Private Sub EntregaChipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntregaChipToolStripMenuItem.Click
        WEntregaBodega.MdiParent = Me
        WEntregaBodega.Show()
    End Sub
End Class
