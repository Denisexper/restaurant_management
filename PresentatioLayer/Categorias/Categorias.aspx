<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Inherits="PresentatioLayer.Categorias.Categorias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <title></title>
    <style>
        body {
            background-color: #f8f9fa;
        }

        .sidebar {
            height: 100vh;
            width: 250px;
            position: fixed;
            background-color: #2c3e50;
            padding-top: 20px;
        }

            .sidebar a {
                padding: 15px;
                text-decoration: none;
                font-size: 18px;
                color: #ecf0f1;
                display: block;
                transition: 0.3s;
            }

                .sidebar a:hover {
                    background-color: #34495e;
                }

        .content {
            margin-left: 260px;
            padding: 20px;
        }

        .title-section {
            display: flex;
            align-items: center;
            justify-content: space-between;
            margin-bottom: 20px;
        }

            .title-section h3 {
                font-size: 24px;
                margin: 0;
            }

        .add-button {
            background-color: #e74c3c;
            color: white;
            border: none;
            border-radius: 50%;
            font-size: 24px;
            width: 50px;
            height: 50px;
            display: flex;
            align-items: center;
            justify-content: center;
            cursor: pointer;
        }

            .add-button:hover {
                background-color: #c0392b;
            }

        .search-container {
            display: flex;
            align-items: center;
            margin-bottom: 20px;
        }

            .search-container input {
                border-radius: 5px;
                padding: 10px;
                border: 1px solid #ced4da;
                margin-left: 10px;
                width: 100%;
                max-width: 500px;
                font-size: 16px;
            }

            .search-container i {
                color: #bdc3c7;
                font-size: 20px;
            }

        .grid-container {
            width: 100%;
            overflow-x: auto;
        }

        .grid {
            width: 100%;
            border-collapse: collapse;
            background-color: white;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

            .grid th, .grid td {
                padding: 15px;
                text-align: left;
                border-bottom: 1px solid #ddd;
                font-size: 16px;
            }

            .grid th {
                background-color: #3498db;
                color: white;
                font-weight: bold;
            }

            .grid tr:hover {
                background-color: #f1f1f1;
            }

            .grid a {
                color: #3498db;
                text-decoration: none;
                margin-right: 10px;
            }

                .grid a:hover {
                    text-decoration: underline;
                }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Menú de navegación (idéntico al de Configuracion.aspx) -->
            <div class="sidebar">
                <h4 class="text-center text-light">Restaurant Management</h4>
                <a href="../Home/Home.aspx">🏠 Principal</a>
                <a href="../Categorias/Categorias.aspx">📂 Categorias</a>
                <a href="../Productos/Productos.aspx">📦 Productos</a>
                <a href="../Mesas/Mesas.aspx">🍽️ Mesas</a>
                <a href="../Personal/Personal.aspx">👥 Personal</a>
                <a href="../Cobro/Cobro.aspx">💳 Cobro</a>
                <a href="../Cocina/Cocina.aspx">👨‍🍳 Cocina</a>
                <a href="../Configuracion/Configuracion.aspx">⚙️ Configuracion</a>
            </div>

            <!-- Contenido principal -->
            <div class="content">
                <div class="title-section">
                    <h2>Lista de Categorias</h2>
                    <button type="button" class="add-button" onclick="window.location.href='CrearCategoria.aspx'">+</button>
                </div>

                <div class="search-container">
                    <i class="bi bi-search"></i>
                    <input type="text" placeholder="Buscar Categoria" />
                </div>

                <div class="grid-container">
                    <asp:GridView ID="GvCategorias"
                        runat="server"
                        AutoGenerateColumns="False"
                        DataKeyNames="idCategorie"
                        CssClass="grid"
                        OnRowCancelingEdit="GvCategorias_RowCancelingEdit"
                        OnRowDeleting="GvCategorias_RowDeleting"
                        OnRowEditing="GvCategorias_RowEditing"
                        OnRowUpdating="GvCategorias_RowUpdating">
                        <Columns>
                            <asp:BoundField DataField="idCategorie" HeaderText="ID" SortExpression="idCategorie" />

                            
                            <asp:TemplateField HeaderText="Nombre" SortExpression="nameCategorie">
                                <ItemTemplate>
                                    <%# Eval("nameCategorie") %>
                                    
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="TxtName" runat="server" Text='<%# Bind("nameCategorie") %>' />
                                </EditItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Acción">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LnkEdit" runat="server" Text="Actualizar" CommandName="Edit" />
                                    <asp:LinkButton ID="LnkDelete" runat="server" Text="Eliminar" CommandName="Delete" />
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:LinkButton ID="LnkUpdate" runat="server" Text="Actualizar" CommandName="Update" />
                                    <asp:LinkButton ID="LnkCancel" runat="server" Text="Cancelar" CommandName="Cancel" />
                                </EditItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>

                </div>
            </div>
        </div>
    </form>
</body>
</html>
