Imports System.Data.SqlClient
Imports Lab2.accesodatosSQL


Public Class InstanciarTarea
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Usuario As String
        Dim CodTarea As String

        'Variables DataSource
        Dim DATareas As SqlDataAdapter
        Dim DSTareas As New DataSet
        Dim DTTareas As DataTable

        Usuario = Session("email")
        CodTarea = Request.QueryString("codigo")

        TextBox1.Text = Usuario
        TextBox2.Text = CodTarea

        DATareas = New SqlDataAdapter("select * from EstudiantesTareas where Email='" & Usuario & "'", getConexion())

        DATareas.Fill(DSTareas, "TareasEspecificasAlumno")

        DTTareas = DSTareas.Tables("TareasEspecificasAlumno")

        GridViewTareasAsignatura.DataSource = DTTareas
        GridViewTareasAsignatura.DataBind()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim HEstimadas As Integer
        Dim HReales As Integer
        Dim Usuario As String
        Dim CodTarea As String

        'Variables DataSource
        Dim DATareas As SqlDataAdapter
        Dim DSTareas As New DataSet
        Dim DTTareas As DataTable
        Dim DRTareas As DataRow

        Usuario = Session("email")
        CodTarea = TextBox2.Text
        HEstimadas = TextBox3.Text
        HReales = TextBox4.Text

        DATareas = New SqlDataAdapter("select Email, CodTarea, HEstimadas, HReales from EstudiantesTareas where Email='" & Usuario & "'", getConexion())
        Dim Builder As SqlCommandBuilder = New SqlCommandBuilder(DATareas)

        DATareas.InsertCommand = Builder.GetInsertCommand

        DATareas.Fill(DSTareas, "TareasEspecificasAlumno")

        DTTareas = DSTareas.Tables("TareasEspecificasAlumno")

        DRTareas = DTTareas.NewRow()

        DRTareas("Email") = Usuario
        DRTareas("CodTarea") = CodTarea
        DRTareas("HEstimadas") = HEstimadas
        DRTareas("HReales") = HReales

        DTTareas.Rows.Add(DRTareas)

        Try
            DATareas.Update(DSTareas, "TareasEspecificasAlumno")
            DTTareas.AcceptChanges()

            GridViewTareasAsignatura.DataSource = DTTareas
            GridViewTareasAsignatura.DataBind()


        Catch ex As Exception
            MsgBox("Error al insertar")
        End Try
    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Response.Redirect("TareasAlumnos.aspx")

    End Sub
End Class