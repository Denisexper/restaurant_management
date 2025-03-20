using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentatioLayer.Mesas
{
    public partial class CrearMesa : System.Web.UI.Page
    {
        TablesBussiness MesasB = new TablesBussiness(); 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrearCat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCrearMes.Text))
            {
                return;
            }
            string nombre = txtCrearMes.Text;

            MesasB.insertarTable(nombre);
            LimpiarCampos();

        }

        protected void LimpiarCampos()
        {
            txtCrearMes.Text = "";
        }

        protected void btnCerrarCat_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mesas.aspx");
        }
    }
}