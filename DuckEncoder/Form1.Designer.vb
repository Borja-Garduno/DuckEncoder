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
        Me.txtOutput = New System.Windows.Forms.RichTextBox()
        Me.panel = New System.Windows.Forms.SplitContainer()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.Panel1.SuspendLayout()
        Me.panel.Panel2.SuspendLayout()
        Me.panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtScript
        '
        Me.txtScript.BackColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.txtScript, "txtScript")
        Me.txtScript.ForeColor = System.Drawing.Color.Lime
        Me.txtScript.Name = "txtScript"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AjustesToolStripMenuItem, Me.VerToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoScriptToolStripMenuItem, Me.CargarToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.EncodeToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        resources.ApplyResources(Me.ArchivoToolStripMenuItem, "ArchivoToolStripMenuItem")
        '
        'NuevoScriptToolStripMenuItem
        '
        Me.NuevoScriptToolStripMenuItem.Name = "NuevoScriptToolStripMenuItem"
        resources.ApplyResources(Me.NuevoScriptToolStripMenuItem, "NuevoScriptToolStripMenuItem")
        '
        'CargarToolStripMenuItem
        '
        Me.CargarToolStripMenuItem.Name = "CargarToolStripMenuItem"
        resources.ApplyResources(Me.CargarToolStripMenuItem, "CargarToolStripMenuItem")
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        resources.ApplyResources(Me.GuardarToolStripMenuItem, "GuardarToolStripMenuItem")
        '
        'EncodeToolStripMenuItem
        '
        Me.EncodeToolStripMenuItem.Name = "EncodeToolStripMenuItem"
        resources.ApplyResources(Me.EncodeToolStripMenuItem, "EncodeToolStripMenuItem")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        resources.ApplyResources(Me.SalirToolStripMenuItem, "SalirToolStripMenuItem")
        '
        'AjustesToolStripMenuItem
        '
        Me.AjustesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdiomaAplicaciónToolStripMenuItem, Me.IdiomaEncoderToolStripMenuItem})
        Me.AjustesToolStripMenuItem.Name = "AjustesToolStripMenuItem"
        resources.ApplyResources(Me.AjustesToolStripMenuItem, "AjustesToolStripMenuItem")
        '
        'IdiomaAplicaciónToolStripMenuItem
        '
        Me.IdiomaAplicaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CastellanoToolStripMenuItem, Me.InglesToolStripMenuItem})
        Me.IdiomaAplicaciónToolStripMenuItem.Name = "IdiomaAplicaciónToolStripMenuItem"
        resources.ApplyResources(Me.IdiomaAplicaciónToolStripMenuItem, "IdiomaAplicaciónToolStripMenuItem")
        '
        'CastellanoToolStripMenuItem
        '
        Me.CastellanoToolStripMenuItem.Checked = True
        Me.CastellanoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CastellanoToolStripMenuItem.Name = "CastellanoToolStripMenuItem"
        resources.ApplyResources(Me.CastellanoToolStripMenuItem, "CastellanoToolStripMenuItem")
        '
        'InglesToolStripMenuItem
        '
        Me.InglesToolStripMenuItem.Name = "InglesToolStripMenuItem"
        resources.ApplyResources(Me.InglesToolStripMenuItem, "InglesToolStripMenuItem")
        '
        'IdiomaEncoderToolStripMenuItem
        '
        Me.IdiomaEncoderToolStripMenuItem.Name = "IdiomaEncoderToolStripMenuItem"
        resources.ApplyResources(Me.IdiomaEncoderToolStripMenuItem, "IdiomaEncoderToolStripMenuItem")
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalToolStripMenuItem, Me.ConsolaToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        resources.ApplyResources(Me.VerToolStripMenuItem, "VerToolStripMenuItem")
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        resources.ApplyResources(Me.NormalToolStripMenuItem, "NormalToolStripMenuItem")
        '
        'ConsolaToolStripMenuItem
        '
        Me.ConsolaToolStripMenuItem.Checked = True
        Me.ConsolaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ConsolaToolStripMenuItem.Name = "ConsolaToolStripMenuItem"
        resources.ApplyResources(Me.ConsolaToolStripMenuItem, "ConsolaToolStripMenuItem")
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeDuckyEncoderToolStripMenuItem})
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        resources.ApplyResources(Me.AcercaDeToolStripMenuItem, "AcercaDeToolStripMenuItem")
        '
        'AcercaDeDuckyEncoderToolStripMenuItem
        '
        Me.AcercaDeDuckyEncoderToolStripMenuItem.Name = "AcercaDeDuckyEncoderToolStripMenuItem"
        resources.ApplyResources(Me.AcercaDeDuckyEncoderToolStripMenuItem, "AcercaDeDuckyEncoderToolStripMenuItem")
        '
        'lblScriptName
        '
        resources.ApplyResources(Me.lblScriptName, "lblScriptName")
        Me.lblScriptName.Name = "lblScriptName"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripButton, Me.AbrirToolStripButton, Me.GuardarToolStripButton, Me.EncodeToolStripButton})
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.Name = "ToolStrip1"
        '
        'NuevoToolStripButton
        '
        Me.NuevoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.NuevoToolStripButton, "NuevoToolStripButton")
        Me.NuevoToolStripButton.Name = "NuevoToolStripButton"
        '
        'AbrirToolStripButton
        '
        Me.AbrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.AbrirToolStripButton, "AbrirToolStripButton")
        Me.AbrirToolStripButton.Name = "AbrirToolStripButton"
        '
        'GuardarToolStripButton
        '
        Me.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.GuardarToolStripButton, "GuardarToolStripButton")
        Me.GuardarToolStripButton.Name = "GuardarToolStripButton"
        '
        'EncodeToolStripButton
        '
        Me.EncodeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EncodeToolStripButton.Image = Global.DuckyEncoder.My.Resources.Resources.ducky2
        resources.ApplyResources(Me.EncodeToolStripButton, "EncodeToolStripButton")
        Me.EncodeToolStripButton.Name = "EncodeToolStripButton"
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.txtOutput, "txtOutput")
        Me.txtOutput.ForeColor = System.Drawing.Color.Lime
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        '
        'panel
        '
        resources.ApplyResources(Me.panel, "panel")
        Me.panel.Name = "panel"
        '
        'panel.Panel1
        '
        Me.panel.Panel1.Controls.Add(Me.txtScript)
        '
        'panel.Panel2
        '
        Me.panel.Panel2.Controls.Add(Me.txtOutput)
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblScriptName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.panel.Panel1.ResumeLayout(False)
        Me.panel.Panel1.PerformLayout()
        Me.panel.Panel2.ResumeLayout(False)
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
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
    Friend WithEvents txtOutput As RichTextBox
    Friend WithEvents panel As SplitContainer
End Class
