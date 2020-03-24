Imports Lab2.accesodatosSQL
Public Class confirmar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        accesodatosSQL.conectar()
        Dim email As String
        Dim respuesta As String
        email = Session("correo")
        respuesta = accesodatosSQL.CambiarEstado(email)
        accesodatosSQL.cerrarConexion()
        MsgBox(respuesta)
    End Sub
End Class