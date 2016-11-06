<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIdioma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIdioma))
        Me.btnAceptarIdioma = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbIdioma = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdiomaModificado = New System.Windows.Forms.TextBox()
        Me.btnExplorar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptarIdioma
        '
        Me.btnAceptarIdioma.Location = New System.Drawing.Point(321, 92)
        Me.btnAceptarIdioma.Name = "btnAceptarIdioma"
        Me.btnAceptarIdioma.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarIdioma.TabIndex = 0
        Me.btnAceptarIdioma.Text = "Aceptar"
        Me.btnAceptarIdioma.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Idioma Recurso"
        '
        'cbIdioma
        '
        Me.cbIdioma.FormattingEnabled = True
        Me.cbIdioma.Location = New System.Drawing.Point(92, 6)
        Me.cbIdioma.Name = "cbIdioma"
        Me.cbIdioma.Size = New System.Drawing.Size(278, 21)
        Me.cbIdioma.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(384, 74)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cbIdioma)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(376, 48)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Recursos por defecto"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnExplorar)
        Me.TabPage2.Controls.Add(Me.txtIdiomaModificado)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(376, 48)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Añadir recurso modificado"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Idioma Recurso"
        '
        'txtIdiomaModificado
        '
        Me.txtIdiomaModificado.Location = New System.Drawing.Point(92, 6)
        Me.txtIdiomaModificado.Name = "txtIdiomaModificado"
        Me.txtIdiomaModificado.Size = New System.Drawing.Size(200, 20)
        Me.txtIdiomaModificado.TabIndex = 1
        '
        'btnExplorar
        '
        Me.btnExplorar.Location = New System.Drawing.Point(298, 4)
        Me.btnExplorar.Name = "btnExplorar"
        Me.btnExplorar.Size = New System.Drawing.Size(75, 23)
        Me.btnExplorar.TabIndex = 2
        Me.btnExplorar.Text = "Explorar"
        Me.btnExplorar.UseVisualStyleBackColor = True
        '
        'frmIdioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 126)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnAceptarIdioma)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmIdioma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Idioma"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAceptarIdioma As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbIdioma As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnExplorar As Button
    Friend WithEvents txtIdiomaModificado As TextBox
    Friend WithEvents Label2 As Label
End Class
