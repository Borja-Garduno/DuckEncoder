Imports System.Globalization
Imports System.IO
Imports System.Threading

Public Class frmMain

    Dim FilePathInput As String

    Dim directorioTemporal As String = Path.GetTempPath() & "DuckyEncoder\"
    Dim directorioResources As String = "resources\"
    Dim directorioResourcesMod As String = "mod\"

    Dim encoderPath As String = "encoder.jar"
    Dim languagePath As String = "es.properties"
    Dim scriptPath As String = "script.txt"

    Dim ficheroCargado As Boolean = False

    Dim ofd As New OpenFileDialog

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' COMPROBAR SI EL DIRECTORIO TEMP\DUCKYENCODER EXISTE
        If Not Directory.Exists(directorioTemporal) Then
            Directory.CreateDirectory(directorioTemporal)
        End If

        ' COMPROBAR SI EL DIRECTORIO DUCKYENCODER\RESOURCES EXISTE
        If Not Directory.Exists(directorioTemporal + directorioResources) Then
            Directory.CreateDirectory(directorioTemporal + directorioResources)
        End If

        ' COMPROBAR SI EL DIRECTORIO DUCKYENCODER\RESOURCES\MOD EXISTE
        If Not Directory.Exists(directorioTemporal + directorioResources + directorioResourcesMod) Then
            Directory.CreateDirectory(directorioTemporal + directorioResources + directorioResourcesMod)
        End If

        ' COMPROBAR SI EXISTE EL FICHERO ENCODER.JAR
        If Not File.Exists(directorioTemporal + encoderPath) = True Then
            ' ENCODER TEMPORAL
            Using MsiFile As New FileStream(directorioTemporal + encoderPath, FileMode.Create)
                MsiFile.Write(My.Resources.encoder, 0, My.Resources.encoder.Length)
            End Using
        End If

        ' IDIOMA TEMPORAL
        'Using MsiFile As New FileStream(directorioTemporal + languagePath, FileMode.Create)
        '    MsiFile.Write(My.Resources.es, 0, My.Resources.es.Length)
        'End Using

        ' CARGAMOS LA CONFIGURACION DE LA PANTALLA
        If My.Settings.colorScript = 0 Then
            colorScriptConsola(sender, e)
        Else
            colorScriptNormal(sender, e)
        End If

        ' CARGAMOS EL IDIOMA
        If My.Settings.idiomaApp = 0 Then
            'Console.WriteLine("Iniciamos la aplicacion en Castellano")

            Try
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("ES")
                InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages(0)
                Controls.Clear() 'removes all the controls on the form
                InitializeComponent() 'load all the controls again
                CastellanoToolStripMenuItem.Checked = True
                InglesToolStripMenuItem.Checked = False
            Catch ex As Exception
                MsgBox("Error idioma castellano", MsgBoxStyle.Critical)
            End Try
        ElseIf My.Settings.idiomaApp = 1 Then
            'Console.WriteLine("Iniciamos la aplicacion en Ingles")

            Try
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("EN")
                Controls.Clear() 'removes all the controls on the form
                InitializeComponent() 'load all the controls again
                InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages(1)
                InglesToolStripMenuItem.Checked = True
                CastellanoToolStripMenuItem.Checked = False
            Catch ex As Exception
                MsgBox("Error english language", MsgBoxStyle.Critical)
            End Try
        End If

        ' COLOR TEXTBOX OUTPUT
        txtOutput.BackColor = Color.Black
        txtOutput.ForeColor = Color.Lime
    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        '' ELIMINAR ENCODER
        'If File.Exists(directorioTemporal + encoderPath) = True Then
        '    File.Delete(directorioTemporal + encoderPath)
        'End If

        '' ELIMINAR CARPETA RESOURCES + FICHEROS IDIOMAS
        'If Directory.Exists(directorioTemporal + directorioResources) Then
        '    Directory.Delete(directorioTemporal + directorioResources, True)
        'End If

        'If File.Exists(directorioTemporal + languagePath) = True Then
        '    File.Delete(directorioTemporal + languagePath)
        'End If

        '' ELIMINAR SCRIPT.TXT TEMPORAL
        'If File.Exists(directorioTemporal + scriptPath) Then
        '    File.Delete(directorioTemporal + scriptPath)
        'End If
    End Sub

    Sub nuevo()
        txtScript.Clear()
        lblScriptName.Text = "Nuevo script"
        ficheroCargado = False
    End Sub

    Sub cargar()
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
                    languagePath = directorioTemporal + directorioResources + "es.properties"
                Else

                    If My.Settings.idiomaModificado = 0 Then
                        languagePath = directorioTemporal + directorioResources + My.Settings.idiomaPath

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
                    Else
                        languagePath = My.Settings.idiomaModificadoPath
                    End If

                End If

                'MsgBox(directorioTemporal + encoderPath)
                'MsgBox(languagePath)
                'MsgBox(FilePathInput)
                'MsgBox(sfd.FileName)

                Try
                    'Process.Start("java.exe", "-jar " + directorioTemporal + encoderPath + " -l " + languagePath + " -i " + FilePathInput + " -o """ + sfd.FileName + """")

                    Dim JavaProc As New Process()
                    Dim JavaProcInfo As New ProcessStartInfo("Java", "-jar """ & directorioTemporal + encoderPath & """ -i """ & FilePathInput & """ -o """ & sfd.FileName & """ -l """ & languagePath & """")

                    With JavaProcInfo
                        .UseShellExecute = False
                        .CreateNoWindow = True
                        .RedirectStandardOutput = True
                    End With

                    With JavaProc
                        .StartInfo = JavaProcInfo
                        .Start()
                        .WaitForExit()
                    End With

                    Dim sOutput As String
                    Using sReader As System.IO.StreamReader = JavaProc.StandardOutput
                        sOutput = sReader.ReadToEnd()
                    End Using

                    Dim scanData As String = txtOutput.Text
                    txtOutput.Text = "****************" + Format(TimeOfDay, "HH:mm:ss") + "*****************" + vbNewLine + sOutput
                    txtOutput.AppendText(vbNewLine + scanData)

                    MsgBox("Fichero compilado correctamente.", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("Error encoder", MsgBoxStyle.Critical)
                End Try

            End If
        End If
    End Sub

    Sub idiomaAppCastellano(sender As Object, e As EventArgs)
        Try
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("ES")
            Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            'frmMain_Load(e, e) 'Load everything in your form load event again
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages(0)
            My.Settings.idiomaApp = 0
            My.Settings.Save()
            CastellanoToolStripMenuItem.Checked = True
            InglesToolStripMenuItem.Checked = False
        Catch ex As Exception
            MsgBox("Error idioma castellano", MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub idiomaAppIngles(sender As Object, e As EventArgs)
        Try
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("EN")
            Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            'frmMain_Load(e, e) 'Load everything in your form load event again
            InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages(1)
            My.Settings.idiomaApp = 1
            My.Settings.Save()
            InglesToolStripMenuItem.Checked = True
            CastellanoToolStripMenuItem.Checked = False
        Catch ex As Exception
            MsgBox("Error english language", MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub colorScriptConsola(sender As Object, e As EventArgs)
        txtScript.BackColor = Color.Black
        txtScript.ForeColor = Color.Lime
        ConsolaToolStripMenuItem.Checked = True
        NormalToolStripMenuItem.Checked = False
        My.Settings.colorScript = 0
        My.Settings.Save()
    End Sub

    Sub colorScriptNormal(sender As Object, e As EventArgs)
        txtScript.BackColor = Color.White
        txtScript.ForeColor = Color.Black
        ConsolaToolStripMenuItem.Checked = False
        NormalToolStripMenuItem.Checked = True
        My.Settings.colorScript = 1
        My.Settings.Save()
    End Sub

    Private Sub ConsolaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsolaToolStripMenuItem.Click
        colorScriptConsola(sender, e)
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        colorScriptNormal(sender, e)
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
        idiomaAppCastellano(sender, e)
    End Sub

    Private Sub InglesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InglesToolStripMenuItem.Click
        idiomaAppIngles(sender, e)
    End Sub

End Class
