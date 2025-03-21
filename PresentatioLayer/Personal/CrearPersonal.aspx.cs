using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentatioLayer.Personal
{
    public partial class CrearPersonal : System.Web.UI.Page
    {
        PersonalBussiness PersonalB = new PersonalBussiness();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtRol.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                return;
            }

            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string rol = txtRol.Text;

            PersonalB.insertarPersonal(nombre, telefono, rol);
            LimpiarCampos();

        }

        protected void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtRol.Text = "";
            txtTelefono.Text = "";
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Personal.aspx");
        }
    }
}