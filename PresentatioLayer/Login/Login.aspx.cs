using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentatioLayer
{
    public partial class Login : System.Web.UI.Page
    {
        LoginBussiness loginBussiness = new LoginBussiness();
        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text;
            string userpassword = txtPassword.Text;

            string resultado = loginBussiness.IniciarSesion(username, userpassword);

            if (resultado == "Bienvenido")
            {
                Response.Redirect("../DashBoard/Dashboard.aspx");
            }
            else
            {
                lblAviso.Text = resultado;
            }
        }
    }
}