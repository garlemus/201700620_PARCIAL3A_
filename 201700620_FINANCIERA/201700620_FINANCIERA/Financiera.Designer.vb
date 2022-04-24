<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_dias = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_viajeros = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_biotopo = New System.Windows.Forms.RadioButton()
        Me.RadioButton_mirador = New System.Windows.Forms.RadioButton()
        Me.RadioButton_laguna = New System.Windows.Forms.RadioButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AceptarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AceptarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasReservacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadViajeros = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoViaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_buscar = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_id
        '
        Me.TextBox_id.Location = New System.Drawing.Point(141, 49)
        Me.TextBox_id.Name = "TextBox_id"
        Me.TextBox_id.Size = New System.Drawing.Size(114, 20)
        Me.TextBox_id.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Identificador Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Días de Reservacíon:"
        '
        'TextBox_dias
        '
        Me.TextBox_dias.Location = New System.Drawing.Point(141, 87)
        Me.TextBox_dias.Name = "TextBox_dias"
        Me.TextBox_dias.Size = New System.Drawing.Size(114, 20)
        Me.TextBox_dias.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad Viajeros:"
        '
        'TextBox_viajeros
        '
        Me.TextBox_viajeros.Location = New System.Drawing.Point(141, 125)
        Me.TextBox_viajeros.Name = "TextBox_viajeros"
        Me.TextBox_viajeros.Size = New System.Drawing.Size(114, 20)
        Me.TextBox_viajeros.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_biotopo)
        Me.GroupBox1.Controls.Add(Me.RadioButton_mirador)
        Me.GroupBox1.Controls.Add(Me.RadioButton_laguna)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 170)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Viaje:"
        '
        'RadioButton_biotopo
        '
        Me.RadioButton_biotopo.AutoSize = True
        Me.RadioButton_biotopo.Location = New System.Drawing.Point(20, 79)
        Me.RadioButton_biotopo.Name = "RadioButton_biotopo"
        Me.RadioButton_biotopo.Size = New System.Drawing.Size(189, 17)
        Me.RadioButton_biotopo.TabIndex = 2
        Me.RadioButton_biotopo.TabStop = True
        Me.RadioButton_biotopo.Text = "Biotopo del Quetzal (Baja Verapaz)"
        Me.RadioButton_biotopo.UseVisualStyleBackColor = True
        '
        'RadioButton_mirador
        '
        Me.RadioButton_mirador.AutoSize = True
        Me.RadioButton_mirador.Location = New System.Drawing.Point(20, 55)
        Me.RadioButton_mirador.Name = "RadioButton_mirador"
        Me.RadioButton_mirador.Size = New System.Drawing.Size(97, 17)
        Me.RadioButton_mirador.TabIndex = 1
        Me.RadioButton_mirador.TabStop = True
        Me.RadioButton_mirador.Text = "Mirador (Petén)"
        Me.RadioButton_mirador.UseVisualStyleBackColor = True
        '
        'RadioButton_laguna
        '
        Me.RadioButton_laguna.AutoSize = True
        Me.RadioButton_laguna.Location = New System.Drawing.Point(20, 32)
        Me.RadioButton_laguna.Name = "RadioButton_laguna"
        Me.RadioButton_laguna.Size = New System.Drawing.Size(178, 17)
        Me.RadioButton_laguna.TabIndex = 0
        Me.RadioButton_laguna.TabStop = True
        Me.RadioButton_laguna.Text = "Laguna Brava (Huehuetenango)"
        Me.RadioButton_laguna.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(116, 26)
        '
        'AceptarToolStripMenuItem
        '
        Me.AceptarToolStripMenuItem.Name = "AceptarToolStripMenuItem"
        Me.AceptarToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.AceptarToolStripMenuItem.Text = "Aceptar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AceptarToolStripMenuItem1, Me.MostrarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.EliminarToolStripMenuItem1, Me.LimpiarVectoresToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(922, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AceptarToolStripMenuItem1
        '
        Me.AceptarToolStripMenuItem1.Name = "AceptarToolStripMenuItem1"
        Me.AceptarToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.AceptarToolStripMenuItem1.Text = "Guardar"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.EliminarToolStripMenuItem.Text = "Buscar"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(62, 20)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCliente, Me.DiasReservacion, Me.CantidadViajeros, Me.TipoViaje, Me.total})
        Me.DataGridView1.Location = New System.Drawing.Point(281, 87)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(614, 251)
        Me.DataGridView1.TabIndex = 8
        '
        'IdCliente
        '
        Me.IdCliente.HeaderText = "Id Cliente"
        Me.IdCliente.Name = "IdCliente"
        Me.IdCliente.ReadOnly = True
        '
        'DiasReservacion
        '
        Me.DiasReservacion.HeaderText = "Días"
        Me.DiasReservacion.Name = "DiasReservacion"
        Me.DiasReservacion.ReadOnly = True
        '
        'CantidadViajeros
        '
        Me.CantidadViajeros.HeaderText = "Viajeros"
        Me.CantidadViajeros.Name = "CantidadViajeros"
        Me.CantidadViajeros.ReadOnly = True
        '
        'TipoViaje
        '
        Me.TipoViaje.HeaderText = "Tipo Viaje"
        Me.TipoViaje.Name = "TipoViaje"
        Me.TipoViaje.ReadOnly = True
        Me.TipoViaje.Width = 175
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(608, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Buscar por Id:"
        '
        'TextBox_buscar
        '
        Me.TextBox_buscar.Location = New System.Drawing.Point(687, 48)
        Me.TextBox_buscar.Name = "TextBox_buscar"
        Me.TextBox_buscar.Size = New System.Drawing.Size(207, 20)
        Me.TextBox_buscar.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 374)
        Me.Controls.Add(Me.TextBox_buscar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_viajeros)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_dias)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_id)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "201700620_FINANCIERA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_dias As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_viajeros As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton_biotopo As RadioButton
    Friend WithEvents RadioButton_mirador As RadioButton
    Friend WithEvents RadioButton_laguna As RadioButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AceptarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AceptarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdCliente As DataGridViewTextBoxColumn
    Friend WithEvents DiasReservacion As DataGridViewTextBoxColumn
    Friend WithEvents CantidadViajeros As DataGridViewTextBoxColumn
    Friend WithEvents TipoViaje As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_buscar As TextBox
End Class
