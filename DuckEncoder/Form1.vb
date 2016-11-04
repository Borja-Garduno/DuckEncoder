Imports System.IO

Public Class frmMain

    Dim FilePathInput As String

    Dim encoderPath As String = "C:\Temp\encoder.jar"
    Dim languagePath As String = "C:\Temp\es.properties"
    Dim scriptPath As String = "C:\Temp\script.txt"

    Dim ficheroCargado As Boolean = False

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Directory.Exists("C:\Temp") Then
            Directory.CreateDirectory("C:\Temp")
        End If

        If File.Exists(scriptPath) Then
            File.Delete(scriptPath)
        End If

        ' ENCODER TEMPORAL
        Using MsiFile As New FileStream(encoderPath, FileMode.Create)
            MsiFile.Write(My.Resources.encoder, 0, My.Resources.encoder.Length)
        End Using

        ' IDIOMA TEMPORAL
        Using MsiFile As New FileStream(languagePath, FileMode.Create)
            MsiFile.Write(My.Resources.es, 0, My.Resources.es.Length)
        End Using

    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        ' ELIMINAR FICHEROS TEMPORALES
        If File.Exists(encoderPath) = True Then
            File.Delete(encoderPath)
        End If

        If File.Exists(languagePath) = True Then
            File.Delete(languagePath)
        End If

        If File.Exists(scriptPath) Then
            File.Delete(scriptPath)
        End If
    End Sub

    Sub nuevo()
        txtScript.Clear()
        lblScriptName.Text = "Nuevo script"
        ficheroCargado = False
    End Sub

    Sub cargar()
        Dim ofd As New OpenFileDialog
        ofd.Filter = "|*.txt"
        ofd.Title = "Cargar fichero"
        ofd.ShowDialog()
        FilePathInput = ofd.FileName

        Try
            Using sr As New StreamReader(ofd.FileName)
                txtScript.Text = sr.ReadToEnd
            End Using

            ficheroCargado = True
            lblScriptName.Text = Path.GetFileName(ofd.FileName)
        Catch ex As Exception

        End Try
    End Sub

    Sub guardar()
        If ficheroCargado = True Then
            My.Computer.FileSystem.WriteAllText(FilePathInput, txtScript.Text, False)
            MsgBox("Fichero guardado correctamente", MsgBoxStyle.Information, "Guardar")
        Else
            Dim sfd As New SaveFileDialog
            sfd.Title = "Guardar fichero"
            sfd.Filter = "|*.txt"
            sfd.FileName = "script.txt"
            If sfd.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(sfd.FileName, txtScript.Text, False)
                lblScriptName.Text = Path.GetFileName(sfd.FileName)
            End If
        End If
    End Sub

    Sub encode()
        If txtScript.Text = String.Empty Then
            MsgBox("Script no encontrado", MsgBoxStyle.Critical, "Ducky Encoder")
        Else
            If File.Exists(scriptPath) Then
                File.Delete(scriptPath)
            End If

            Dim sfd As New SaveFileDialog
            sfd.Title = "Guardar fichero compilado"
            sfd.FileName = "inject.bin"
            sfd.Filter = "|*.bin"
            Dim result = sfd.ShowDialog()

            If result = DialogResult.OK Then
                Dim sw As StreamWriter
                sw = My.Computer.FileSystem.OpenTextFileWriter(scriptPath, True)
                sw.WriteLine(txtScript.Text)
                sw.Close()
                FilePathInput = scriptPath

                ' Process.Start("java.exe", "-jar C:\Temp\encoder.jar -l C:\Temp\es.properties -i " + FilePathInput + " -o """ + sfd.FileName + """")
                Process.Start("java.exe", "-jar " + encoderPath + " -l " + languagePath + " -i " + FilePathInput + " -o """ + sfd.FileName + """")
            End If
        End If
    End Sub

    Private Sub ConsolaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsolaToolStripMenuItem.Click
        txtScript.BackColor = Color.Black
        txtScript.ForeColor = Color.Lime
        ConsolaToolStripMenuItem.Checked = True
        NormalToolStripMenuItem.Checked = False
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        txtScript.BackColor = Color.White
        txtScript.ForeColor = Color.Black
        ConsolaToolStripMenuItem.Checked = False
        NormalToolStripMenuItem.Checked = True
    End Sub

    Private Sub NuevoScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoScriptToolStripMenuItem.Click
        nuevo()
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        cargar()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        guardar()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AcercaDeDuckyEncoderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeDuckyEncoderToolStripMenuItem.Click
        Acercade.ShowDialog()
    End Sub

    Private Sub NuevoToolStripButton_Click(sender As Object, e As EventArgs) Handles NuevoToolStripButton.Click
        nuevo()
    End Sub

    Private Sub AbrirToolStripButton_Click(sender As Object, e As EventArgs) Handles AbrirToolStripButton.Click
        cargar()
    End Sub

    Private Sub GuardarToolStripButton_Click(sender As Object, e As EventArgs) Handles GuardarToolStripButton.Click
        guardar()
    End Sub

    Private Sub EncodeToolStripButton_Click(sender As Object, e As EventArgs) Handles EncodeToolStripButton.Click
        encode()
    End Sub

    Private Sub EncodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncodeToolStripMenuItem.Click
        encode()
    End Sub
End Class
