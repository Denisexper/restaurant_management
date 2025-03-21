using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class PersonalBussiness
    {
        PersonalData PersonalD = new PersonalData();

        public DataTable obtenerPersonal()
        {
            return PersonalD.obtenerPersonal();
        }

        public bool insertarPersonal(string nombre, string telefono, string role)
        {
            return PersonalD.insertarPersonal(nombre, telefono, role);
        }

        public bool actualizarPersonal(int id, string nombre, string telefono, string role)
        {
            return PersonalD.actualizarPersonal(id, nombre, telefono, role);
        }

        public bool eliminarPersonal(int id)
        {
            return PersonalD.eliminarPersonal(id);
        }
    }
}
