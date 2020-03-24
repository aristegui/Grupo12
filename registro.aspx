<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="registro.aspx.vb" Inherits="Lab2.registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: justify;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            REGISTRO DE USUARIO<br />
            <br />
            Seleccione su rol:&nbsp;
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="Debe seleccionar una de las dos opciones" ForeColor="Maroon"></asp:RequiredFieldValidator>
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Alunmno</asp:ListItem>
                <asp:ListItem>Profesor</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            Email<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox1" ErrorMessage="*No puede haber campos vacios" ForeColor="Maroon"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Email"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Introduzca un mail valido" ForeColor="#990000" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            Nombre<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*No puede haber campos vacios" ForeColor="Maroon"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Introduzca un nombre valido" ForeColor="#990000" ValidationExpression="^([A-Za-z  ñáéíóú])+$"></asp:RegularExpressionValidator>
            <br />
            Primer Apellido<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="*No puede haber campos vacios" ForeColor="Maroon"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Introduzca un apellido valido" ForeColor="#990000" ValidationExpression="^([A-Za-z  ñáéíóú])+$"></asp:RegularExpressionValidator>
            <br />
            Segundo Apellido
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="*No puede haber campos vacios" ForeColor="Maroon"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Introduzca un apellido valido" ForeColor="#990000" ValidationExpression="^([A-Za-z  ñáéíóú])+$"></asp:RegularExpressionValidator>
            <br />
            Password<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox6" ErrorMessage="*No puede haber campos vacios" ForeColor="Maroon"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="TextBox6" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            Repetir Password<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox7" ErrorMessage="*No puede haber campos vacios" ForeColor="Maroon"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="TextBox7" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox6" ControlToValidate="TextBox7" ErrorMessage="Las contraseñas no son iguales" ForeColor="#990000"></asp:CompareValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="REGISTRAR" OnClientClick="~/confirmar.aspx" PostBackUrl="~/confirmar.aspx" />
            <br />
        </div>
        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
