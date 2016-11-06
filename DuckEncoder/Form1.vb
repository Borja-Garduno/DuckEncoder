Imports System.IO

Public Class frmMain

    Dim FilePathInput As String

    Dim directorioTemporal As String = "C:\Temp\DuckyEncoder\"

    Dim encoderPath As String = "encoder.jar"
    Dim languagePath As String = "es.properties"
    Dim scriptPath As String = "script.txt"

    Dim ficheroCargado As Boolean = False

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Directory.Exists(directorioTemporal) Then
            Directory.CreateDirectory(directorioTemporal)
        End If

        If File.Exists(directorioTemporal + scriptPath) Then
            File.Delete(directorioTemporal + scriptPath)
        End If

        ' ENCODER TEMPORAL
        Using MsiFile As New FileStream(directorioTemporal + encoderPath, FileMode.Create)
            MsiFile.Write(My.Resources.encoder, 0, My.Resources.encoder.Length)
        End Using

        ' IDIOMA TEMPORAL
        Using MsiFile As New FileStream(directorioTemporal + languagePath, FileMode.Create)
            MsiFile.Write(My.Resources.es, 0, My.Resources.es.Length)
        End Using

        If My.Settings.colorScript = 0 Then
            ConsolaToolStripMenuItem_Click(sender, e)
        Else
            NormalToolStripMenuItem_Click(sender, e)
        End If

    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        ' ELIMINAR FICHEROS TEMPORALES
        If File.Exists(directorioTemporal + encoderPath) = True Then
            File.Delete(directorioTemporal + encoderPath)
        End If

        If File.Exists(directorioTemporal + languagePath) = True Then
            File.Delete(directorioTemporal + languagePath)
        End If

        If File.Exists(directorioTemporal + scriptPath) Then
            File.Delete(directorioTemporal + scriptPath)
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
            If File.Exists(directorioTemporal + scriptPath) Then
                File.Delete(directorioTemporal + scriptPath)
            End If

            Dim sfd As New SaveFileDialog
            sfd.Title = "Guardar fichero compilado"
            sfd.FileName = "inject.bin"
            sfd.Filter = "|*.bin"
            Dim result = sfd.ShowDialog()

            If result = DialogResult.OK Then
                Dim sw As StreamWriter
                sw = My.Computer.FileSystem.OpenTextFileWriter(directorioTemporal + scriptPath, True)
                sw.WriteLine(txtScript.Text)
                sw.Close()
                FilePathInput = directorioTemporal + scriptPath

                If My.Settings.idiomaPath Is Nothing Then
                    languagePath = directorioTemporal + "es.properties"
                    MsgBox("Idioma por defecto español")
                Else

                    If My.Settings.idiomaModificado = 0 Then
                        languagePath = directorioTemporal + My.Settings.idiomaPath

                        Select Case My.Settings.idiomaIndex
                            Case 0
                                Using MsiFile As New FileStream(languagePath, FileMode.Create)
                                    MsiFile.Write(My.Resources.be, 0, My.Resources.be.Length)
                                End Using
                            Case 1
                                Using MsiFile As New FileStream(languagePath, FileMode.Create)
                                    MsiFile.Write(My.Resources.br, 0, My.Resources.br.Length)
                                End Using
                            Case 2
                                Using MsiFile As New FileStream(languagePath, FileMode.Create)
                                    MsiFile.Write(My.Resources.ca, 0, My.Resources.ca.Length)
                                End Using
                            Case 3
                                Using MsiFile As New FileStream(languagePath, FileMode.Create)
                                    MsiFile.Write(My.Resources.ch, 0, My.Resources.ch.Length)
                                End Using
                            Case 4
                                Using MsiFile As New FileStream(languagePath, FileMode.Create)
                                    MsiFile.Write(My.Resources.de, 0, My.Resources.de.Length)
                                End Using
                            Case 5
                                Using MsiFile As New FileStream(languagePath, FileMode.Create)
                                    MsiFile.Write(My.Resources.dk, 0, My.Resources.dk.Length)
                                End Using
                            Case 6
                                Using MsiFile As New FileStream(languagePath, FileMode.Create)
                                    MsiFile.Write(My.Resources.es, 0, My.Resources.es.Length)
                                End Using
                            Case 7
                                Using MsiFile As New FileStream(languagePath, FileMode.Create)
                                    MsiFile.Write(My.Resources.fi, 0, My.Resources.fi.Length)
                                End Using
                            Case 8
                                Using MsiFile As New FileStream(languagePath, FileMode.Create)
                                    MsiFile.Write(My.Resources.fr, 0, My.Resources.fr.Length)
                                End Using
                            Case 9
                                Using MsiFile As New FileStream(languagePath, FileMode.Create)
                                    MsiFile.Write(My.Resources.gb, 0, My.Resources.gb.Length)
                                End Using
                            Case 10
                                Using MsiFile As New FileStream(languagePath, FileMode.Create)
                                    MsiFile.Write(My.Resources.hr, 0, My.Resources.hr.Length)
                                End Using
                            Case 11
                                Using MsiFile As New FileStream(languagePath, FileMode.Create)
                                    MsiFile.Write(My.Resources.it, 0, My.Resources.it.Length)
                                End Using
                            Case 12
                                Using MsiFile As New FileStream(languagePath, FileMode.Create)
                                    MsiFile.Write(My.Resources.no, 0, My.Resources.no.Length)
                                End Using
                            Case 13
                                Using MsiFile As New FileStream(languagePath, FileMode.Create)
                                    MsiFile.Write(My.Resources.pt, 0, My.Resources.pt.Length)
                                End Using
                            Case 14
                                Using MsiFile As New FileStream(languagePath, FileMode.Create)
                                    MsiFile.Write(My.Resources.ru, 0, My.Resources.ru.Length)
                                End Using
                            Case 15
                                Using MsiFile As New FileStream(languagePath, FileMode.Create)
                                    MsiFile.Write(My.Resources.si, 0, My.Resources.si.Length)
                                End Using
                            Case 16
                                Using MsiFile As New FileStream(languagePath, FileMode.Create)
                                    MsiFile.Write(My.Resources.sv, 0, My.Resources.sv.Length)
                                End Using
                            Case 17
                                Using MsiFile As New FileStream(languagePath, FileMode.Create)
                                    MsiFile.Write(My.Resources.tr, 0, My.Resources.tr.Length)
                                End Using
                            Case 18
                                Using MsiFile As New FileStream(languagePath, FileMode.Create)
                                    MsiFile.Write(My.Resources.us, 0, My.Resources.us.Length)
                                End Using
                        End Select

                        MsgBox("Idioma por defecto: " + languagePath)
                    Else
                        languagePath = My.Settings.idiomaModificadoPath
                        MsgBox("Idioma modificado: " + languagePath)
                    End If

                End If

                ' Process.Start("java.exe", "-jar C:\Temp\encoder.jar -l C:\Temp\es.properties -i " + FilePathInput + " -o """ + sfd.FileName + """")
                Process.Start("java.exe", "-jar " + directorioTemporal + encoderPath + " -l " + languagePath + " -i " + FilePathInput + " -o """ + sfd.FileName + """")
            End If
        End If
    End Sub

    Private Sub ConsolaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsolaToolStripMenuItem.Click
        txtScript.BackColor = Color.Black
        txtScript.ForeColor = Color.Lime
        ConsolaToolStripMenuItem.Checked = True
        NormalToolStripMenuItem.Checked = False
        My.Settings.colorScript = 0
        My.Settings.Save()
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        txtScript.BackColor = Color.White
        txtScript.ForeColor = Color.Black
        ConsolaToolStripMenuItem.Checked = False
        NormalToolStripMenuItem.Checked = True
        My.Settings.colorScript = 1
        My.Settings.Save()
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
        frmAcercade.ShowDialog()
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

    Private Sub IdiomaEncoderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IdiomaEncoderToolStripMenuItem.Click
        frmIdioma.ShowDialog()
    End Sub

    Private Sub CastellanoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CastellanoToolStripMenuItem.Click

    End Sub

    Private Sub InglesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InglesToolStripMenuItem.Click

    End Sub
End Class
