﻿Imports System.IO

Public Class frmIdioma

    Dim idiomaPath As String

    Private Sub frmIdioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If cbIdioma.Items.Count < 1 Then
            cbIdioma.Items.Add("BELGIUM") '         be - 0
            cbIdioma.Items.Add("BRAZIL") '          br - 1
            cbIdioma.Items.Add("CANADA") '          ca - 2
            cbIdioma.Items.Add("SWITZERLAND") '     ch - 3
            cbIdioma.Items.Add("GERMANY") '         de - 4
            cbIdioma.Items.Add("DENMARK") '         dk - 5
            cbIdioma.Items.Add("SPAIN") '           es - 6
            cbIdioma.Items.Add("FINLAND") '         fi - 7
            cbIdioma.Items.Add("FRANCE") '          fr - 8
            cbIdioma.Items.Add("UNITED KINGDOM") '  gb - 9
            cbIdioma.Items.Add("CROATIA") '         hr - 10
            cbIdioma.Items.Add("ITALY") '           it - 11
            cbIdioma.Items.Add("NORWAY") '          no - 12
            cbIdioma.Items.Add("PORTUGAL") '        pt - 13
            cbIdioma.Items.Add("RUSSIA") '          ru - 14
            cbIdioma.Items.Add("SLOVENIA") '        si - 15
            cbIdioma.Items.Add("EL SALVADOR") '     sv - 16
            cbIdioma.Items.Add("TURKEY") '          tr - 17
            cbIdioma.Items.Add("UNITED STATES") '   us - 18
        End If

        cbIdioma.SelectedIndex = My.Settings.idiomaIndex

        If My.Settings.idiomaModificado = 0 Then
            TabControl1.SelectedTab = TabPage1
        Else
            TabControl1.SelectedTab = TabPage2
            txtIdiomaModificado.Text = My.Settings.idiomaModificadoPath
        End If

    End Sub

    Private Sub cbIdioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIdioma.SelectedIndexChanged

        Select Case cbIdioma.SelectedIndex
            Case 0
                idiomaPath = "be.properties"
            Case 1
                idiomaPath = "br.properties"
            Case 2
                idiomaPath = "ca.properties"
            Case 3
                idiomaPath = "ch.properties"
            Case 4
                idiomaPath = "de.properties"
            Case 5
                idiomaPath = "dk.properties"
            Case 6
                idiomaPath = "es.properties"
            Case 7
                idiomaPath = "fi.properties"
            Case 8
                idiomaPath = "fr.properties"
            Case 9
                idiomaPath = "gb.properties"
            Case 10
                idiomaPath = "hr.properties"
            Case 11
                idiomaPath = "it.properties"
            Case 12
                idiomaPath = "no.properties"
            Case 13
                idiomaPath = "pt.properties"
            Case 14
                idiomaPath = "ru.properties"
            Case 15
                idiomaPath = "si.properties"
            Case 16
                idiomaPath = "sv.properties"
            Case 17
                idiomaPath = "tr.properties"
            Case 18
                idiomaPath = "us.properties"
            Case Else
                MsgBox("Error")
        End Select

        My.Settings.idiomaPath = idiomaPath
        My.Settings.idiomaIndex = cbIdioma.SelectedIndex
        My.Settings.Save()

    End Sub

    Private Sub btnExplorar_Click(sender As Object, e As EventArgs) Handles btnExplorar.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "|*.properties"
        ofd.Title = "Cargar Recurso"
        ofd.ShowDialog()

        Try
            txtIdiomaModificado.Text = ofd.FileName

            Dim newPath As String = "C:\Temp\DuckyEncoder\resources\" + Path.GetFileName(ofd.FileName)
            File.Copy(ofd.FileName, newPath, 1)

            My.Settings.idiomaModificadoPath = newPath
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAceptarIdioma_Click(sender As Object, e As EventArgs) Handles btnAceptarIdioma.Click
        If TabControl1.SelectedTab Is TabPage1 Then
            My.Settings.idiomaModificado = 0
        ElseIf TabControl1.SelectedTab Is TabPage2 Then
            My.Settings.idiomaModificado = 1
        End If

        Close()
    End Sub
End Class