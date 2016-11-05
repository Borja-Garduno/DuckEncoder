<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtScript = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeDuckyEncoderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblScriptName = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.AjustesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomaAplicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CastellanoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InglesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomaEncoderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AbrirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EncodeToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtScript
        '
        Me.txtScript.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtScript.BackColor = System.Drawing.Color.Black
        Me.txtScript.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScript.ForeColor = System.Drawing.Color.Lime
        Me.txtScript.Location = New System.Drawing.Point(0, 65)
        Me.txtScript.Multiline = True
        Me.txtScript.Name = "txtScript"
        Me.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtScript.Size = New System.Drawing.Size(869, 419)
        Me.txtScript.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AjustesToolStripMenuItem, Me.VerToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(869, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoScriptToolStripMenuItem, Me.CargarToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.EncodeToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoScriptToolStripMenuItem
        '
        Me.NuevoScriptToolStripMenuItem.Name = "NuevoScriptToolStripMenuItem"
        Me.NuevoScriptToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevoScriptToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.NuevoScriptToolStripMenuItem.Text = "Nuevo"
        '
        'CargarToolStripMenuItem
        '
        Me.CargarToolStripMenuItem.Name = "CargarToolStripMenuItem"
        Me.CargarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.CargarToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.CargarToolStripMenuItem.Text = "Abrir"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'EncodeToolStripMenuItem
        '
        Me.EncodeToolStripMenuItem.Name = "EncodeToolStripMenuItem"
        Me.EncodeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EncodeToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.EncodeToolStripMenuItem.Text = "Encode"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(153, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalToolStripMenuItem, Me.ConsolaToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.VerToolStripMenuItem.Text = "Ventana"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.NormalToolStripMenuItem.Text = "Normal"
        '
        'ConsolaToolStripMenuItem
        '
        Me.ConsolaToolStripMenuItem.Checked = True
        Me.ConsolaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ConsolaToolStripMenuItem.Name = "ConsolaToolStripMenuItem"
        Me.ConsolaToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ConsolaToolStripMenuItem.Text = "Consola"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeDuckyEncoderToolStripMenuItem})
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeDuckyEncoderToolStripMenuItem
        '
        Me.AcercaDeDuckyEncoderToolStripMenuItem.Name = "AcercaDeDuckyEncoderToolStripMenuItem"
        Me.AcercaDeDuckyEncoderToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AcercaDeDuckyEncoderToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.AcercaDeDuckyEncoderToolStripMenuItem.Text = "Acerca de Ducky Encoder"
        '
        'lblScriptName
        '
        Me.lblScriptName.AutoSize = True
        Me.lblScriptName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScriptName.Location = New System.Drawing.Point(2, 49)
        Me.lblScriptName.Name = "lblScriptName"
        Me.lblScriptName.Size = New System.Drawing.Size(79, 13)
        Me.lblScriptName.TabIndex = 8
        Me.lblScriptName.Text = "Nuevo script"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.AbrirToolStripButton, Me.GuardarToolStripButton, Me.EncodeToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(869, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'AjustesToolStripMenuItem
        '
        Me.AjustesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdiomaAplicaciónToolStripMenuItem, Me.IdiomaEncoderToolStripMenuItem})
        Me.AjustesToolStripMenuItem.Name = "AjustesToolStripMenuItem"
        Me.AjustesToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.AjustesToolStripMenuItem.Text = "Ajustes"
        '
        'IdiomaAplicaciónToolStripMenuItem
        '
        Me.IdiomaAplicaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CastellanoToolStripMenuItem, Me.InglesToolStripMenuItem})
        Me.IdiomaAplicaciónToolStripMenuItem.Name = "IdiomaAplicaciónToolStripMenuItem"
        Me.IdiomaAplicaciónToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.IdiomaAplicaciónToolStripMenuItem.Text = "Idioma aplicación"
        '
        'CastellanoToolStripMenuItem
        '
        Me.CastellanoToolStripMenuItem.Name = "CastellanoToolStripMenuItem"
        Me.CastellanoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CastellanoToolStripMenuItem.Text = "Castellano"
        '
        'InglesToolStripMenuItem
        '
        Me.InglesToolStripMenuItem.Name = "InglesToolStripMenuItem"
        Me.InglesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InglesToolStripMenuItem.Text = "Ingles"
        '
        'IdiomaEncoderToolStripMenuItem
        '
        Me.IdiomaEncoderToolStripMenuItem.Name = "IdiomaEncoderToolStripMenuItem"
        Me.IdiomaEncoderToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.IdiomaEncoderToolStripMenuItem.Text = "Idioma encoder"
        '
        'NuevoToolStripButton
        '
        Me.NuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NuevoToolStripButton.Image = CType(resources.GetObject("NuevoToolStripButton.Image"), System.Drawing.Image)
        Me.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoToolStripButton.Name = "NuevoToolStripButton"
        Me.NuevoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NuevoToolStripButton.Text = "&Nuevo"
        '
        'AbrirToolStripButton
        '
        Me.AbrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AbrirToolStripButton.Image = CType(resources.GetObject("AbrirToolStripButton.Image"), System.Drawing.Image)
        Me.AbrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AbrirToolStripButton.Name = "AbrirToolStripButton"
        Me.AbrirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AbrirToolStripButton.Text = "&Abrir"
        '
        'GuardarToolStripButton
        '
        Me.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), System.Drawing.Image)
        Me.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripButton.Name = "GuardarToolStripButton"
        Me.GuardarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.GuardarToolStripButton.Text = "&Guardar"
        '
        'EncodeToolStripButton
        '
        Me.EncodeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EncodeToolStripButton.Image = Global.DuckEncoder.My.Resources.Resources.ducky2
        Me.EncodeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EncodeToolStripButton.Name = "EncodeToolStripButton"
        Me.EncodeToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.EncodeToolStripButton.Text = "&Encode"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 484)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblScriptName)
        Me.Controls.Add(Me.txtScript)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ducky Encoder"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtScript As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeDuckyEncoderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsolaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lblScriptName As Label
    Friend WithEvents NuevoScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NuevoToolStripButton As ToolStripButton
    Friend WithEvents AbrirToolStripButton As ToolStripButton
    Friend WithEvents GuardarToolStripButton As ToolStripButton
    Friend WithEvents EncodeToolStripButton As ToolStripButton
    Friend WithEvents EncodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjustesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdiomaAplicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CastellanoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InglesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdiomaEncoderToolStripMenuItem As ToolStripMenuItem
End Class
