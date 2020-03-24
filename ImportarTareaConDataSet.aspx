<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ImportarTareaConDataSet.aspx.vb" Inherits="Lab2.ImportarTareaConDataSet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>PROFESOR
        <br />
        IMPORTAR TAREAS GENÉRICAS<br />
        <br />
        </strong>Seleccionar Asignatura a Importar:<br />
        <strong>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="codigoasig" DataValueField="codigoasig">
        </asp:DropDownList>
        <br />
        <asp:Xml ID="Xml1" runat="server"></asp:Xml>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Importar (XMLD)" />
        <br />
        <br />
        </strong>
        <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Profesor.aspx">Menu Profesor</asp:HyperLink>
        </div>
    </form>
</body>
</html>
