﻿Public Class Acercade
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub email_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles email.LinkClicked
        Process.Start(String.Format("mailto:{0}", "borja.garduno@hotmail.com"))
    End Sub
End Class