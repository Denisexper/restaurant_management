using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class TablesBussiness
    {
        TablesData TablesD = new TablesData();

        public DataTable obtenerTables()
        {
            return TablesD.obtenerTables();
        }

        public bool insertarTable(string nombre)
        {
            return TablesD.insertarTable(nombre);
        }

        public bool actualizarTable(int id, string nombre)
        {
            return TablesD.actualizarTable(id, nombre);
        }

        public bool eliminarTable(int id)
        {
            return TablesD.eliminarTable(id);
        }
    }
}
