<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Profesor.aspx.vb" Inherits="Lab2.Profesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:LinkButton ID="LinkButton1" runat="server">Asignaturas</asp:LinkButton>
        <p>
        <asp:LinkButton ID="LinkButton2" runat="server">Tareas</asp:LinkButton>
        </p>
        <asp:LinkButton ID="LinkButton3" runat="server">Grupos</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton4" runat="server">Importar Tarea</asp:LinkButton>
        <p>
        <asp:LinkButton ID="LinkButton5" runat="server">Exportar Tarea</asp:LinkButton>
        </p>
        <p>
        <asp:LinkButton ID="LinkButton6" runat="server">Importar Tarea (DataSet)</asp:LinkButton>
        </p>
    </form>
</body>
</html>
