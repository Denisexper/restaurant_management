<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PresentatioLayer.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title>Iniciar Sesión</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background-color: #f8f9fa;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }
        .login-container {
            background-color: #ffffff;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
            width: 100%;
            max-width: 400px;
        }
        .login-header {
            background-color: #2c3e50;
            color: #ecf0f1;
            padding: 10px;
            text-align: center;
            border-radius: 10px 10px 0 0;
        }
        .form-label {
            color: #2c3e50;
        }
        .form-control {
            border-radius: 5px;
        }
        .btn-primary {
            background-color: #2c3e50;
            border-color: #2c3e50;
        }
        .btn-primary:hover {
            background-color: #34495e;
            border-color: #34495e;
        }
        .alert {
            color: red;
            font-size: 12px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <div class="login-header">
                <asp:Label ID="lblTitulo" runat="server" Text="Iniciar Sesión" CssClass="h4"></asp:Label>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblUsuario" runat="server" Text="Usuario" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblPassword" runat="server" Text="Contraseña" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
            </div>
            <div class="d-grid gap-2">
                <asp:Button ID="btnIniciar" runat="server" Text="Iniciar sesión" CssClass="btn btn-primary btn-block" OnClick="btnIniciar_Click" />
            </div>
            <div class="mt-3 text-center">
                <asp:Label ID="lblAviso" runat="server" CssClass="alert"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
