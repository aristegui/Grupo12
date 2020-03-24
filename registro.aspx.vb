Imports Lab2
Imports System.Data.SqlClient
Imports Lab2.accesodatosSQL


Public Class registro
    Inherits System.Web.UI.Page
    Dim NumConf As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim conexion As String
        conexion = conectar()
        Label1.Text = conexion
    End Sub

    Protected Sub Page_Unload(ByVal Sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarConexion()
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim email = TextBox1.Text
        Session("correo") = email
        Dim nombre = TextBox2.Text
        Dim apellido1 = TextBox3.Text
        Dim apellido2 = TextBox4.Text
        Dim pass = TextBox6.Text
        Dim tipo = RadioButtonList1.SelectedValue
        Randomize()
        Dim numConfir As New Integer
        numConfir = CInt(Int((999999 * Rnd()) + 100000))
        Dim codpass As New Integer
        codpass = CInt(Int((999999 * Rnd()) + 100000))
        Dim confirmado = 0
        Dim apellidos = apellido1 & apellido2

        Dim v As Boolean = (email = "" Or nombre = "" Or apellido1 = "" Or apellido2 = "" Or pass = "" Or RadioButtonList1.SelectedValue = "")
        If v Then
            MsgBox("Algunos campos estan vacios")
        Else
            accesodatosSQL.conectar()
            Dim esta As Boolean
            esta = accesodatosSQL.EstaRegistrado(email)
            If esta Then
                accesodatosSQL.cerrarConexion()
                MsgBox("El email ya esta registrado")
            Else
                accesodatosSQL.Registrar(nombre, apellidos, email, tipo, pass, numConfir, codpass, confirmado)

                Dim enviarEmail As New Class1
                Dim url As String
                Randomize()

                NumConf = CLng(Rnd() * 9000000) + 1000000

                url = "http://localhost:52104/confirmar.aspx?mbr=" & email & "&numconf=" & NumConf.ToString & ""


                enviarEmail.enviarEmail(email, url)
                accesodatosSQL.cerrarConexion()

            End If
        End If
    End Sub
End Class