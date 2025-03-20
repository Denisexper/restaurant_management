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

        protected void GvMesas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GvMesas.EditIndex = e.NewEditIndex;
            CargarMesas();
        }

        protected void GvMesas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GvMesas.DataKeys[e.RowIndex].Value);
            GridViewRow crow = GvMesas.Rows[e.RowIndex];

            TextBox txtName = crow.FindControl("TxtName") as TextBox;

            if (txtName != null)
            {
                string nombre = txtName.Text;

                if (MesasB.actualizarTable(id, nombre))
                {
                    GvMesas.EditIndex = -1;
                    CargarMesas();
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

        protected void GvMesas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GvMesas.EditIndex = -1;
            CargarMesas();
        }

        protected void GvMesas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GvMesas.DataKeys[e.RowIndex].Value);
            if(MesasB.eliminarTable(id))
            {
                CargarMesas();
            }
            else
            {
                return;
            }   
        }
    }
}