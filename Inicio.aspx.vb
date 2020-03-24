Imports Lab2.accesodatosSQL
Imports System.Data.SqlClient

Public Class Inicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim email As String
        Dim tipo As String
        Dim register As SqlDataReader
        Dim pass As String
        email = TextBox1.Text
        pass = TextBox2.Text

        accesodatosSQL.conectar()
        register = accesodatosSQL.Login(email, pass)
        If register.HasRows Then
            register.Read()
            tipo = register.Item("tipo")
            Session("email") = email
            register.Close()

            If tipo = "Profesor" Then
                Response.Redirect("Profesor.aspx")
            Else
                Response.Redirect("alumnos.aspx")

            End If

        Else
            MsgBox("El usuario no esta registrado")
        End If
        accesodatosSQL.cerrarConexion()
    End Sub
End Class