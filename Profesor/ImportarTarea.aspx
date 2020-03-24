<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ImportarTarea.aspx.vb" Inherits="Lab2.ImportarTarea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            IMPORTAR TAREA DE PROFESOR</div>
        <p>
            Seleccionar la asignatura a importar:</p>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="codigoasig" DataValueField="codigoasig">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AmigosConnectionString %>" SelectCommand="SELECT Distinct codigoasig FROM ProfesoresGrupo inner join GruposClase on codigo = codigogrupo WHERE Email = 'blanco@ehu.es' "></asp:SqlDataSource>
        <p>
            <asp:Label ID="Label1" runat="server" visible="False" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="IMPORTAR (XMLD)" />
        </p>
        <asp:Xml ID="Xml1" runat="server"></asp:Xml>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
