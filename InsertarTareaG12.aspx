<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InsertarTareaG12.aspx.vb" Inherits="Lab2.InsertarTarea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Código<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Descripción<br />
            <asp:TextBox ID="TextBox2" runat="server" Height="170px" Width="862px"></asp:TextBox>
            <br />
            Asignatura<br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="codigo" DataValueField="codigo">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AmigosConnectionString %>" SelectCommand="SELECT [codigo] FROM [Asignaturas]"></asp:SqlDataSource>
            <br />
            Horas Estimadas<br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            Tipo tarea<br />
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>Laboratorio</asp:ListItem>
                <asp:ListItem>Examen</asp:ListItem>
                <asp:ListItem>Proyecto</asp:ListItem>
                <asp:ListItem>Ejercicio</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:AmigosConnectionString %>" SelectCommand="SELECT [CodAsig], [TipoTarea] FROM [TareasGenericas] WHERE ([CodAsig] = @CodAsig)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="CodAsig" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Añadir Tarea" />
        </div>
        <div style="margin-left: 920px">
            <asp:HyperLink ID="HyperLink1" runat="server">Ver tareas</asp:HyperLink>
        </div>
    </form>
</body>
</html>
