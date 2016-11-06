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
        Me.AjustesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomaAplicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CastellanoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InglesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomaEncoderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeDuckyEncoderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblScriptName = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
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
        resources.ApplyResources(Me.txtScript, "txtScript")
        Me.txtScript.BackColor = System.Drawing.Color.Black
        Me.txtScript.ForeColor = System.Drawing.Color.Lime
        Me.txtScript.Name = "txtScript"
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AjustesToolStripMenuItem, Me.VerToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        resources.ApplyResources(Me.ArchivoToolStripMenuItem, "ArchivoToolStripMenuItem")
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoScriptToolStripMenuItem, Me.CargarToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.EncodeToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        '
        'NuevoScriptToolStripMenuItem
        '
        resources.ApplyResources(Me.NuevoScriptToolStripMenuItem, "NuevoScriptToolStripMenuItem")
        Me.NuevoScriptToolStripMenuItem.Name = "NuevoScriptToolStripMenuItem"
        '
        'CargarToolStripMenuItem
        '
        resources.ApplyResources(Me.CargarToolStripMenuItem, "CargarToolStripMenuItem")
        Me.CargarToolStripMenuItem.Name = "CargarToolStripMenuItem"
        '
        'GuardarToolStripMenuItem
        '
        resources.ApplyResources(Me.GuardarToolStripMenuItem, "GuardarToolStripMenuItem")
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        '
        'EncodeToolStripMenuItem
        '
        resources.ApplyResources(Me.EncodeToolStripMenuItem, "EncodeToolStripMenuItem")
        Me.EncodeToolStripMenuItem.Name = "EncodeToolStripMenuItem"
        '
        'ToolStripSeparator1
        '
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        '
        'SalirToolStripMenuItem
        '
        resources.ApplyResources(Me.SalirToolStripMenuItem, "SalirToolStripMenuItem")
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        '
        'AjustesToolStripMenuItem
        '
        resources.ApplyResources(Me.AjustesToolStripMenuItem, "AjustesToolStripMenuItem")
        Me.AjustesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdiomaAplicaciónToolStripMenuItem, Me.IdiomaEncoderToolStripMenuItem})
        Me.AjustesToolStripMenuItem.Name = "AjustesToolStripMenuItem"
        '
        'IdiomaAplicaciónToolStripMenuItem
        '
        resources.ApplyResources(Me.IdiomaAplicaciónToolStripMenuItem, "IdiomaAplicaciónToolStripMenuItem")
        Me.IdiomaAplicaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CastellanoToolStripMenuItem, Me.InglesToolStripMenuItem})
        Me.IdiomaAplicaciónToolStripMenuItem.Name = "IdiomaAplicaciónToolStripMenuItem"
        '
        'CastellanoToolStripMenuItem
        '
        resources.ApplyResources(Me.CastellanoToolStripMenuItem, "CastellanoToolStripMenuItem")
        Me.CastellanoToolStripMenuItem.Name = "CastellanoToolStripMenuItem"
        '
        'InglesToolStripMenuItem
        '
        resources.ApplyResources(Me.InglesToolStripMenuItem, "InglesToolStripMenuItem")
        Me.InglesToolStripMenuItem.Name = "InglesToolStripMenuItem"
        '
        'IdiomaEncoderToolStripMenuItem
        '
        resources.ApplyResources(Me.IdiomaEncoderToolStripMenuItem, "IdiomaEncoderToolStripMenuItem")
        Me.IdiomaEncoderToolStripMenuItem.Name = "IdiomaEncoderToolStripMenuItem"
        '
        'VerToolStripMenuItem
        '
        resources.ApplyResources(Me.VerToolStripMenuItem, "VerToolStripMenuItem")
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalToolStripMenuItem, Me.ConsolaToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        '
        'NormalToolStripMenuItem
        '
        resources.ApplyResources(Me.NormalToolStripMenuItem, "NormalToolStripMenuItem")
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        '
        'ConsolaToolStripMenuItem
        '
        resources.ApplyResources(Me.ConsolaToolStripMenuItem, "ConsolaToolStripMenuItem")
        Me.ConsolaToolStripMenuItem.Checked = True
        Me.ConsolaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ConsolaToolStripMenuItem.Name = "ConsolaToolStripMenuItem"
        '
        'AcercaDeToolStripMenuItem
        '
        resources.ApplyResources(Me.AcercaDeToolStripMenuItem, "AcercaDeToolStripMenuItem")
        Me.AcercaDeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeDuckyEncoderToolStripMenuItem})
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        '
        'AcercaDeDuckyEncoderToolStripMenuItem
        '
        resources.ApplyResources(Me.AcercaDeDuckyEncoderToolStripMenuItem, "AcercaDeDuckyEncoderToolStripMenuItem")
        Me.AcercaDeDuckyEncoderToolStripMenuItem.Name = "AcercaDeDuckyEncoderToolStripMenuItem"
        '
        'lblScriptName
        '
        resources.ApplyResources(Me.lblScriptName, "lblScriptName")
        Me.lblScriptName.Name = "lblScriptName"
        '
        'ToolStrip1
        '
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.AbrirToolStripButton, Me.GuardarToolStripButton, Me.EncodeToolStripButton})
        Me.ToolStrip1.Name = "ToolStrip1"
        '
        'NuevoToolStripButton
        '
        resources.ApplyResources(Me.NuevoToolStripButton, "NuevoToolStripButton")
        Me.NuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NuevoToolStripButton.Name = "NuevoToolStripButton"
        '
        'AbrirToolStripButton
        '
        resources.ApplyResources(Me.AbrirToolStripButton, "AbrirToolStripButton")
        Me.AbrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AbrirToolStripButton.Name = "AbrirToolStripButton"
        '
        'GuardarToolStripButton
        '
        resources.ApplyResources(Me.GuardarToolStripButton, "GuardarToolStripButton")
        Me.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuardarToolStripButton.Name = "GuardarToolStripButton"
        '
        'EncodeToolStripButton
        '
        resources.ApplyResources(Me.EncodeToolStripButton, "EncodeToolStripButton")
        Me.EncodeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EncodeToolStripButton.Image = Global.DuckEncoder.My.Resources.Resources.ducky2
        Me.EncodeToolStripButton.Name = "EncodeToolStripButton"
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblScriptName)
        Me.Controls.Add(Me.txtScript)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
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
