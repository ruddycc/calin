<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WEntregaBodega
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.listBox3 = New System.Windows.Forms.ListBox()
        Me.button11 = New System.Windows.Forms.Button()
        Me.button10 = New System.Windows.Forms.Button()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listBox3
        '
        Me.listBox3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.listBox3.FormattingEnabled = True
        Me.listBox3.Location = New System.Drawing.Point(480, 25)
        Me.listBox3.Name = "listBox3"
        Me.listBox3.ScrollAlwaysVisible = True
        Me.listBox3.Size = New System.Drawing.Size(208, 277)
        Me.listBox3.TabIndex = 45
        '
        'button11
        '
        Me.button11.Location = New System.Drawing.Point(598, 334)
        Me.button11.Name = "button11"
        Me.button11.Size = New System.Drawing.Size(90, 25)
        Me.button11.TabIndex = 47
        Me.button11.Text = "Limpiar"
        Me.button11.UseVisualStyleBackColor = True
        '
        'button10
        '
        Me.button10.Location = New System.Drawing.Point(480, 334)
        Me.button10.Name = "button10"
        Me.button10.Size = New System.Drawing.Size(90, 25)
        Me.button10.TabIndex = 48
        Me.button10.Text = "Captura"
        Me.button10.UseVisualStyleBackColor = True
        '
        'timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(477, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(477, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Total IDs = 0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(367, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 25)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Cargar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WEntregaBodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 371)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.button10)
        Me.Controls.Add(Me.button11)
        Me.Controls.Add(Me.listBox3)
        Me.Name = "WEntregaBodega"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents listBox3 As ListBox
    Private WithEvents button11 As Button
    Private WithEvents button10 As Button
    Private WithEvents timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents Button1 As Button
End Class
