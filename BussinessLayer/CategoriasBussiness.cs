using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class CategoriasBussiness
    {
        CategoriasData CategoriasD = new CategoriasData();

        public DataTable obtenerCategorias()
        {
            return CategoriasD.obtenerCategorias();
        }

        public bool insertarCategoria(string nombre)
        {
            return CategoriasD.insertarCategoria(nombre);
        }

        public bool actualizarCategoria(int id, string nombre)
        {
            return CategoriasD.actualizarCategoria(id, nombre);
        }

        public bool eliminarCategoria(int id)
        {
            return CategoriasD.eliminarCategoria(id);
        }
    }

    
}
