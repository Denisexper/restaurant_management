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

        protected void GvCategorias_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GvCategorias.EditIndex = e.NewEditIndex;
            cargarCategorias();
        }

        protected void GvCategorias_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GvCategorias.DataKeys[e.RowIndex].Value);
            GridViewRow crow = GvCategorias.Rows[e.RowIndex];

            TextBox txtName = crow.FindControl("TxtName") as TextBox;

            if(txtName != null)
            {
                string nombre = txtName.Text;

                if (categoriasB.actualizarCategoria(id, nombre))
                {
                    GvCategorias.EditIndex = -1;
                    cargarCategorias();
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

        protected void GvCategorias_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GvCategorias.EditIndex = -1;
            cargarCategorias();
        }

        protected void GvCategorias_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GvCategorias.DataKeys[e.RowIndex].Value);
            if (categoriasB.eliminarCategoria(id))
            {
                cargarCategorias();
            }
            else
            {
                return;
            }
        }
    }
}