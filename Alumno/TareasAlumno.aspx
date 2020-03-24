<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TareasAlumno.aspx.vb" Inherits="Lab2.TareasAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
    <div>
    
        Alumnos Gestión de tareas genéricas<br />
        <br />
        Seleccionar Asignatura:<br />
        <asp:DropDownList ID="DropDownAsigAlum" runat="server" DataSourceID="SqlDataSource1" DataTextField="codigoasig" DataValueField="codigoasig" AutoPostBack="True">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AmigosConnectionString %>" SelectCommand="ObtenerAsignaturaAlumnoG11" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:SessionParameter Name="Email" SessionField="email" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <asp:Button ID="ButtonVerTareas" runat="server" Text="Ver Tareas" />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridViewTareasAlumno" runat="server">
            <Columns>
                <asp:CommandField SelectText="Instanciar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Estadistica.aspx">Estadistica horas reales por asignatura</asp:HyperLink>
        <br />
    
    </div>
    </form>
</body>
</html>