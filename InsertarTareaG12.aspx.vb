Imports System.Data.SqlClient
Imports Lab2.accesodatosSQL

Public Class InsertarTarea
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dstMbrs As New DataSet
        Dim tblMbrs As New DataTable
        Dim dapMbrs As SqlDataAdapter

        Try
            Label1.Visible = False
            conectar()
            dapMbrs = New SqlDataAdapter("select * from TareasGenericas", getConexion())
            Dim bldMbrs As New SqlCommandBuilder(dapMbrs)

            dapMbrs.Fill(dstMbrs, "TareasGenericas")

            tblMbrs = dstMbrs.Tables("TareasGenericas")
            Dim rowMbrs As DataRow = tblMbrs.NewRow()
            rowMbrs("Codigo") = TextBox1.Text
            rowMbrs("Descripcion") = TextBox2.Text
            rowMbrs("CodAsig") = DropDownList1.SelectedItem.Text
            rowMbrs("HEstimadas") = TextBox3.Text
            rowMbrs("TipoTarea") = DropDownList2.SelectedItem.Text
            rowMbrs("Explotacion") = 0
            tblMbrs.Rows.Add(rowMbrs)

            dapMbrs.Update(dstMbrs, "TareasGenericas")
            tblMbrs.AcceptChanges()

        Catch ex As Exception
            Label1.Text = ex.Message
            Label1.Visible = True
        End Try


    End Sub


End Class