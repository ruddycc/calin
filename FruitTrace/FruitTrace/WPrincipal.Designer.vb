<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WPrincipipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WPrincipipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProduccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntregaChipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CintasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PosicionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LectorRFIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProduccionToolStripMenuItem, Me.MantenimientoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(890, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProduccionToolStripMenuItem
        '
        Me.ProduccionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntregaChipToolStripMenuItem})
        Me.ProduccionToolStripMenuItem.Name = "ProduccionToolStripMenuItem"
        Me.ProduccionToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.ProduccionToolStripMenuItem.Text = "&Produccion"
        '
        'EntregaChipToolStripMenuItem
        '
        Me.EntregaChipToolStripMenuItem.Name = "EntregaChipToolStripMenuItem"
        Me.EntregaChipToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.EntregaChipToolStripMenuItem.Text = "Entrega Chip"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AreaToolStripMenuItem, Me.CintasToolStripMenuItem, Me.EquiposToolStripMenuItem, Me.EstadosToolStripMenuItem, Me.PosicionesToolStripMenuItem, Me.RolesToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.LectorRFIDToolStripMenuItem, Me.CalinToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "&Mantenimiento"
        '
        'AreaToolStripMenuItem
        '
        Me.AreaToolStripMenuItem.Name = "AreaToolStripMenuItem"
        Me.AreaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AreaToolStripMenuItem.Text = "Areas"
        '
        'CintasToolStripMenuItem
        '
        Me.CintasToolStripMenuItem.Name = "CintasToolStripMenuItem"
        Me.CintasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CintasToolStripMenuItem.Text = "Cintas"
        '
        'EquiposToolStripMenuItem
        '
        Me.EquiposToolStripMenuItem.Name = "EquiposToolStripMenuItem"
        Me.EquiposToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EquiposToolStripMenuItem.Text = "Equipos"
        '
        'EstadosToolStripMenuItem
        '
        Me.EstadosToolStripMenuItem.Name = "EstadosToolStripMenuItem"
        Me.EstadosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EstadosToolStripMenuItem.Text = "Estados"
        '
        'PosicionesToolStripMenuItem
        '
        Me.PosicionesToolStripMenuItem.Name = "PosicionesToolStripMenuItem"
        Me.PosicionesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PosicionesToolStripMenuItem.Text = "Posiciones"
        '
        'RolesToolStripMenuItem
        '
        Me.RolesToolStripMenuItem.Name = "RolesToolStripMenuItem"
        Me.RolesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RolesToolStripMenuItem.Text = "Roles"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'LectorRFIDToolStripMenuItem
        '
        Me.LectorRFIDToolStripMenuItem.Name = "LectorRFIDToolStripMenuItem"
        Me.LectorRFIDToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LectorRFIDToolStripMenuItem.Text = "Lector RFID"
        '
        'CalinToolStripMenuItem
        '
        Me.CalinToolStripMenuItem.Name = "CalinToolStripMenuItem"
        Me.CalinToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CalinToolStripMenuItem.Text = "Calin"
        '
        'WPrincipipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(890, 460)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "WPrincipipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FruitTrace v.01"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AreaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CintasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EquiposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PosicionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RolesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduccionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LectorRFIDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntregaChipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalinToolStripMenuItem As ToolStripMenuItem
End Class
