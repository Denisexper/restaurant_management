using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class LoginBussiness
    {
        LoginData loginData = new LoginData();

        public string IniciarSesion(string username, string userpassword)
        {
            if (loginData.ValidarUsuario(username, userpassword))
            {
                return "Bienvenido";
            }
            else
            {
                return "Usuario o contraseña incorrectos";
            }
        }
    }
}
