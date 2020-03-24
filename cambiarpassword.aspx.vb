Public Class cambiarpassword
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim enviarEmail As New Class1
        Dim email As String
        Dim enviado As Boolean
        email = TextBox1.Text.ToString
        enviado = enviarEmail.enviarPassNuevo(email)
        If (enviado = True) Then
            MsgBox("Se ha enviado el email correctamente", vbOK)
            Response.Redirect("confirmarPassword.aspx")
        Else
            MsgBox("Ha surgido un error en el envio del email.", vbOK)
        End If
    End Sub
End Class