<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PresentatioLayer.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitulo" runat="server" Text="Iniciar Sesión"></asp:Label>
        </div>
        <p>
            <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lbl" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnIniciar" runat="server" Text="Iniciar sesión" OnClick="btnIniciar_Click" />
        <p>
            <asp:Label ID="lblAviso" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
