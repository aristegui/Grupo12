﻿Public Class alumnos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Response.Redirect("TareasAlumno.aspx")
    End Sub

    Protected Sub LinkButton2_Click(sender As Object, e As EventArgs) Handles LinkButton2.Click


    End Sub

    Protected Sub LinkButton3_Click(sender As Object, e As EventArgs) Handles LinkButton3.Click
        Response.Redirect("")

    End Sub
End Class