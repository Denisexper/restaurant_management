<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearMesa.aspx.cs" Inherits="PresentatioLayer.Mesas.CrearMesa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f5f5f5;
            margin: 0;
            padding: 0;
        }

        .container {
            max-width: 400px;
            margin: 50px auto;
            background-color: white;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }

        h2 {
            text-align: center;
            color: #333;
        }

        label {
            display: block;
            margin-bottom: 8px;
            font-weight: bold;
            color: #333;
        }

        .form-control {
            width: 100%;
            padding: 10px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 5px;
            font-size: 14px;
        }

        .button-group {
            display: flex;
            justify-content: space-between;
        }

        .btn {
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            font-size: 14px;
            cursor: pointer;
            transition: background-color 0.3s;
        }

        .btn-save {
            background-color: #ff6584;
            color: white;
        }

            .btn-save:hover {
                background-color: #e64a6d;
            }

        .btn-close {
            background-color: #2d3e50;
            color: white;
        }

            .btn-close:hover {
                background-color: #1c2a39;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Crear Mesa</h2>
            <label for="txtCrearMes">Nombre</label>
            <asp:TextBox ID="txtCrearMes" runat="server" CssClass="form-control"></asp:TextBox>
            <div class="button-group">
                <asp:Button ID="btnCrearMes" runat="server" Text="Guardar" CssClass="btn btn-save" OnClick="btnCrearCat_Click" />
                <asp:Button ID="btnCerrarMes" runat="server" Text="Cerrar" CssClass="btn btn-close" OnClick="btnCerrarCat_Click" />
            </div>
        </div>
    </form>
</body>
</html>
