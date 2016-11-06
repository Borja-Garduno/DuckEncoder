Imports System.Globalization
Imports System.Threading

Public Class frmAcercade
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub email_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles email.LinkClicked
        Process.Start(String.Format("mailto:{0}", "borja.garduno@hotmail.com"))
    End Sub

    Private Sub frmAcercade_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class