using BussinessLayer;
using PresentatioLayer.Categorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentatioLayer.Personal
{
    public partial class Personal : System.Web.UI.Page
    {
        PersonalBussiness PersonalB = new PersonalBussiness();  
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                CargarPersonal();
            }
        }

        protected void CargarPersonal()
        {
            GvPersonal.DataSource = PersonalB.obtenerPersonal();
            GvPersonal.DataBind();
        }

        protected void GvPersonal_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GvPersonal.EditIndex = e.NewEditIndex;
            CargarPersonal();
        }

        protected void GvPersonal_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GvPersonal.DataKeys[e.RowIndex].Values[0]);
            GridViewRow crow = GvPersonal.Rows[e.RowIndex];

            TextBox txtName = crow.FindControl("TxtName") as TextBox;
            TextBox txtPhone = crow.FindControl("TxtPhone") as TextBox;
            TextBox txtRole = crow.FindControl("TxtRole") as TextBox;

            if(txtName != null && txtPhone != null && txtRole != null)
            {
                string nombre = txtName.Text;
                string telefono = txtPhone.Text;
                string role = txtRole.Text;

                if (PersonalB.actualizarPersonal(id, nombre, telefono, role))
                {
                    GvPersonal.EditIndex = -1;
                    CargarPersonal();
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }


        }

        protected void GvPersonal_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GvPersonal.EditIndex = -1;
            CargarPersonal();
        }

        protected void GvPersonal_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GvPersonal.DataKeys[e.RowIndex].Values[0]);
            if (PersonalB.eliminarPersonal(id))
            {
                CargarPersonal();
            }
            else
            {
                return;
            }
        }
    }
}