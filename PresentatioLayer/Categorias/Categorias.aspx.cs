using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentatioLayer.Categorias
{
    public partial class Categorias : System.Web.UI.Page
    {
        CategoriasBussiness categoriasB = new CategoriasBussiness();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                cargarCategorias();
            }
        }

        private void cargarCategorias()
        {
            GvCategorias.DataSource = categoriasB.obtenerCategorias();
            GvCategorias.DataBind();
        }
    }
}