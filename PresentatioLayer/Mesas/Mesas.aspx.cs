using BussinessLayer;
using PresentatioLayer.Categorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentatioLayer.Mesas
{
    public partial class Mesas : System.Web.UI.Page
    {
        TablesBussiness MesasB = new TablesBussiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarMesas();
            }
        }

        protected void CargarMesas()
        {
            GvMesas.DataSource = MesasB.obtenerTables();
            GvMesas.DataBind();
        }
    }
}