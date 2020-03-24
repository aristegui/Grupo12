Imports System.Xml
Imports System.Data.SqlClient
Imports Lab2.accesodatosSQL
Public Class ExportarTarea
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim DAProfe As SqlDataAdapter
        Dim DSProfe As New DataSet
        Dim DTProfe As DataTable
        Dim email As String
        Dim codAsig As String

        Dim arc As New XmlDocument

        codAsig = DropDownList1.SelectedValue

        email = Session("email")

        DAProfe = New SqlDataAdapter("select Codigo, Descripcion, Hestimadas, Explotacion, TipoTarea from TareasGenericas where CodAsig='" & codAsig & "'", getConexion())

        DSProfe = New DataSet("Tareas")

        DAProfe.Fill(DSProfe, "Tarea")

        DTProfe = DSProfe.Tables("Tarea")

        DTProfe.Columns(0).ColumnName = "Codigo"
        DTProfe.Columns(1).ColumnName = "Descripcion"
        DTProfe.Columns(2).ColumnName = "Hestimadas"
        DTProfe.Columns(3).ColumnName = "Explotacion"
        DTProfe.Columns(4).ColumnName = "TipoTarea"

        DSProfe.WriteXml(Server.MapPath("App_Data/" & codAsig & "export.xml"))
        Label1.Text = "XML de " & codAsig & " Exportado Correctamente"
        'ButtonETAtributo.Visible = True
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Profesor.aspx")
    End Sub
End Class