<!DOCTYPE html>
<script runat="server">

    Protected Sub Page_Load(sender As Object, e As EventArgs)

    End Sub
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title>Dashboard</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet"/>
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
    </style>
</head>
<body>
    <form id="form1" runat="server">
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
        <div class="content">
            <h2>Dashboard</h2>
            <p>Welcome to the Restaurant Management System.</p>
        </div>
    </form>
</body>
</html>
