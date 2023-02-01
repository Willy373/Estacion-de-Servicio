using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class LogicaSQL
    {
        ConexionSQL conDatos = new ConexionSQL();

        public int consultaLogin(String usuario, String contraseña)
        {
            return conDatos.consultalogin(usuario, contraseña);

        }

        public String consultaCombustible(String usuario)
        {
            return conDatos.combustible(usuario);
        }

        public string consultaNumeroPunto(string usuario)
        {
            return conDatos.numero_punto(usuario);
        }

        public string consultaCombusDisponible(string usuario)
        {
            return conDatos.combustible_disponible(usuario);
        }
        public string consultaCombusLimite(string usuario)
        {
            return conDatos.combustible_limite(usuario);
        }
    }
}
