<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="cambiarpassword.aspx.vb" Inherits="Lab2.cambiarpassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            RECUPERACIÓN O CAMBIO DE CONTRASEÑA<br />
            <br />
            Introduzca el email:<br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Email" Height="42px" Width="548px"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="El email no es correcto" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">El email no es correcto</asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="ENVIAR" />
            <br />
            <br />
            *Se enviara un enlace al email para poder cambiar la contraseña<br />
            <br />
        </div>
    </form>
</body>
</html>
