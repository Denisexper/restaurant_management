using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentatioLayer.Categorias
{
    public partial class CrearCategoria : System.Web.UI.Page
    {
        CategoriasBussiness CategoriasB = new CategoriasBussiness();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCerrarCat_Click(object sender, EventArgs e)
        {
            Response.Redirect("Categorias.aspx");
        }

        protected void btnCrearCat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCrearCat.Text))
            {
                return;
            }
            string nombre = txtCrearCat.Text;

            CategoriasB.insertarCategoria(nombre);
            LimpiarCampos();

        }

        protected void LimpiarCampos()
        {
            txtCrearCat.Text = "";
        }
    }
}