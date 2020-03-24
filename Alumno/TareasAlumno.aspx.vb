Imports Lab2.accesodatosSQL
Imports System.Data.SqlClient
Public Class TareasAlumno

    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'If Page.IsPostBack = False Then

        'Dim DAAlumno As SqlDataAdapter
        'Dim DSAlumno As New DataSet
        'Dim DTAlumno As DataTable
        'Dim email As String

        'email = Session("email")
        '
        'DAAlumno = New SqlDataAdapter("select GruposClase.codigoasig from GruposClase, EstudiantesGrupo where EstudiantesGrupo.Grupo=GruposClase.codigo and EstudiantesGrupo.email='" & email & "'", getConexion())
        '
        'DAAlumno.Fill(DSAlumno, "Asignaturas")
        '
        'DropDownAsigAlum.DataSource = DSAlumno.Tables("Asignaturas")
        'DropDownAsigAlum.DataTextField = "codigoasig"
        'DropDownAsigAlum.DataBind()

        'End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonVerTareas.Click


        Dim DATarea As SqlDataAdapter
        Dim DSTarea As New DataSet
        Dim DTTarea As DataTable
        Dim email As String
        Dim SelectedTask As String

        SelectedTask = DropDownAsigAlum.SelectedItem.Text
        email = Session("email")

        DATarea = New SqlDataAdapter("Select TareasGenericas.Codigo, TareasGenericas.Descripcion, TareasGenericas.HEstimadas, TareasGenericas.TipoTarea from TareasGenericas where TareasGenericas.codAsig='" & SelectedTask & "'", getConexion())

        DATarea.Fill(DSTarea, "TareasAlumno")

        DTTarea = DSTarea.Tables("TareasAlumno")

        GridViewTareasAlumno.DataSource = DTTarea
        GridViewTareasAlumno.DataBind()

    End Sub

    Protected Sub GridViewTareasAlumno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridViewTareasAlumno.SelectedIndexChanged

        Dim codTarea As String

        codTarea = GridViewTareasAlumno.SelectedRow.Cells(1).Text

        Response.Redirect("InstanciarTarea.aspx?codigo=" & codTarea & "")


    End Sub
End Class