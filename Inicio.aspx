<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Inicio.aspx.vb" Inherits="Lab2.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center" dir="cambiarpassword.aspx">
            <br />
            <br />
            INICIAR SESION<br />
            <br />
            Email<br />
            <asp:TextBox ID="TextBox1" runat="server" Height="38px" Width="492px" TextMode="Email"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Campo requerido" ForeColor="#990000"></asp:RequiredFieldValidator>
            <br />
            Password<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" Height="34px" Width="420px" TextMode="Password"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*Campo requerido" ForeColor="#990000"></asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="Button1" runat="server" Text="INICIAR" />
            <br />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/registro.aspx" style="font-weight: 700">Registrar</asp:HyperLink>
            <br />
            <br />
            <strong>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/cambiarpassword.aspx">Recuperar o Cambiar la contraseña</asp:HyperLink>
            </strong><br />
            <br />
        </div>
    </form>
</body>
</html>
