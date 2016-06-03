<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WManteEstado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WManteEstado))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Fruit_traceDataSet = New FruitTrace.fruit_traceDataSet()
        Me.T_estadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_estadosTableAdapter = New FruitTrace.fruit_traceDataSetTableAdapters.t_estadosTableAdapter()
        Me.TableAdapterManager = New FruitTrace.fruit_traceDataSetTableAdapters.TableAdapterManager()
        Me.T_estadosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.T_estadosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.T_estadoDataGridView = New System.Windows.Forms.DataGridView()
        Me.IIDESTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDESCRIPCIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BACTIVODataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.Fruit_traceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_estadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_estadosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.T_estadosBindingNavigator.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.T_estadoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fruit_traceDataSet
        '
        Me.Fruit_traceDataSet.DataSetName = "fruit_traceDataSet"
        Me.Fruit_traceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T_estadosBindingSource
        '
        Me.T_estadosBindingSource.DataMember = "t_estados"
        Me.T_estadosBindingSource.DataSource = Me.Fruit_traceDataSet
        '
        'T_estadosTableAdapter
        '
        Me.T_estadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.t_anomaliaTableAdapter = Nothing
        Me.TableAdapterManager.t_areaTableAdapter = Nothing
        Me.TableAdapterManager.t_cintasTableAdapter = Nothing
        Me.TableAdapterManager.t_cosechaTableAdapter = Nothing
        Me.TableAdapterManager.t_embolseTableAdapter = Nothing
        Me.TableAdapterManager.t_entregaTableAdapter = Nothing
        Me.TableAdapterManager.t_equiposTableAdapter = Nothing
        Me.TableAdapterManager.t_estadosTableAdapter = Me.T_estadosTableAdapter
        Me.TableAdapterManager.t_evaluacionTableAdapter = Nothing
        Me.TableAdapterManager.t_inventarioTableAdapter = Nothing
        Me.TableAdapterManager.t_posicionTableAdapter = Nothing
        Me.TableAdapterManager.t_propiedaevaluaTableAdapter = Nothing
        Me.TableAdapterManager.t_rolesTableAdapter = Nothing
        Me.TableAdapterManager.t_usuariosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FruitTrace.fruit_traceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'T_estadosBindingNavigator
        '
        Me.T_estadosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.T_estadosBindingNavigator.AutoSize = False
        Me.T_estadosBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.T_estadosBindingNavigator.BindingSource = Me.T_estadosBindingSource
        Me.T_estadosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.T_estadosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.T_estadosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.T_estadosBindingNavigator.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_estadosBindingNavigator.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.T_estadosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.ToolStripSeparator4, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.ToolStripSeparator3, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator2, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator1, Me.T_estadosBindingNavigatorSaveItem, Me.ToolStripSeparator5, Me.ToolStripButton1})
        Me.T_estadosBindingNavigator.Location = New System.Drawing.Point(9, 275)
        Me.T_estadosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.T_estadosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.T_estadosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.T_estadosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.T_estadosBindingNavigator.Name = "T_estadosBindingNavigator"
        Me.T_estadosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.T_estadosBindingNavigator.Size = New System.Drawing.Size(446, 43)
        Me.T_estadosBindingNavigator.TabIndex = 0
        Me.T_estadosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 40)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 40)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 40)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 40)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 43)
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 40)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 43)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 25)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 43)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 40)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 43)
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 40)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 43)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 43)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 43)
        '
        'T_estadosBindingNavigatorSaveItem
        '
        Me.T_estadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.T_estadosBindingNavigatorSaveItem.Image = CType(resources.GetObject("T_estadosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.T_estadosBindingNavigatorSaveItem.Name = "T_estadosBindingNavigatorSaveItem"
        Me.T_estadosBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 40)
        Me.T_estadosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 43)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(34, 40)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(24, 0)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(430, 306)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(24, 12)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.RectangleShape1.CornerRadius = 6
        Me.RectangleShape1.FillColor = System.Drawing.Color.SlateGray
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(6, 7)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(447, 54)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(464, 327)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SlateGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(73, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Mantenimiento de Estados"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'T_estadoDataGridView
        '
        Me.T_estadoDataGridView.AllowUserToDeleteRows = False
        Me.T_estadoDataGridView.AutoGenerateColumns = False
        Me.T_estadoDataGridView.BackgroundColor = System.Drawing.Color.SkyBlue
        Me.T_estadoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.T_estadoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.T_estadoDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.T_estadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.T_estadoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IIDESTADODataGridViewTextBoxColumn, Me.SDESCRIPCIONDataGridViewTextBoxColumn, Me.BACTIVODataGridViewCheckBoxColumn})
        Me.T_estadoDataGridView.DataSource = Me.T_estadosBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.T_estadoDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.T_estadoDataGridView.EnableHeadersVisualStyles = False
        Me.T_estadoDataGridView.GridColor = System.Drawing.Color.SkyBlue
        Me.T_estadoDataGridView.Location = New System.Drawing.Point(8, 70)
        Me.T_estadoDataGridView.MultiSelect = False
        Me.T_estadoDataGridView.Name = "T_estadoDataGridView"
        Me.T_estadoDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.T_estadoDataGridView.RowHeadersVisible = False
        Me.T_estadoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.T_estadoDataGridView.Size = New System.Drawing.Size(446, 194)
        Me.T_estadoDataGridView.TabIndex = 9
        '
        'IIDESTADODataGridViewTextBoxColumn
        '
        Me.IIDESTADODataGridViewTextBoxColumn.DataPropertyName = "sID_ESTADO"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IIDESTADODataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.IIDESTADODataGridViewTextBoxColumn.DividerWidth = 2
        Me.IIDESTADODataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.IIDESTADODataGridViewTextBoxColumn.Name = "IIDESTADODataGridViewTextBoxColumn"
        '
        'SDESCRIPCIONDataGridViewTextBoxColumn
        '
        Me.SDESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "sDESCRIPCION"
        Me.SDESCRIPCIONDataGridViewTextBoxColumn.DividerWidth = 2
        Me.SDESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.SDESCRIPCIONDataGridViewTextBoxColumn.Name = "SDESCRIPCIONDataGridViewTextBoxColumn"
        Me.SDESCRIPCIONDataGridViewTextBoxColumn.Width = 225
        '
        'BACTIVODataGridViewCheckBoxColumn
        '
        Me.BACTIVODataGridViewCheckBoxColumn.DataPropertyName = "bACTIVO"
        Me.BACTIVODataGridViewCheckBoxColumn.DividerWidth = 2
        Me.BACTIVODataGridViewCheckBoxColumn.HeaderText = "Activo"
        Me.BACTIVODataGridViewCheckBoxColumn.Name = "BACTIVODataGridViewCheckBoxColumn"
        '
        'WManteEstado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(464, 327)
        Me.Controls.Add(Me.T_estadoDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.T_estadosBindingNavigator)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MaximizeBox = False
        Me.Name = "WManteEstado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Estados"
        CType(Me.Fruit_traceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_estadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_estadosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.T_estadosBindingNavigator.ResumeLayout(False)
        Me.T_estadosBindingNavigator.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.T_estadoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Fruit_traceDataSet As fruit_traceDataSet
    Friend WithEvents T_estadosBindingSource As BindingSource
    Friend WithEvents T_estadosTableAdapter As fruit_traceDataSetTableAdapters.t_estadosTableAdapter
    Friend WithEvents TableAdapterManager As fruit_traceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents T_estadosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents T_estadosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents T_estadoDataGridView As DataGridView
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents IIDESTADODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SDESCRIPCIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BACTIVODataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
