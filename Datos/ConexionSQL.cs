using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace Datos
{
    public class ConexionSQL
    {
        static String conexionstring = "server = LAPTOP-2L5H5J2L\\SQLEXPRESS; database=EstaciondeServicio; INTEGRATED SECURITY = true ";
        SqlConnection conexion = new SqlConnection(conexionstring);

        public int consultalogin (String usuario, String contraseña)
        {
            int count;
            conexion.Open();
            String Query = "Select Count(*) FROM EstaciondeServicio.dbo.usuario where nombre_usuario='"+usuario+ "'and contrasena_usuario='"+contraseña+"'";
            SqlCommand cmd = new SqlCommand(Query, conexion);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.Close();
            return count;
        }
        public string combustible(String usuario)
        {
            string nombrecombus ="";
            conexion.Open();
            String Query = "SELECT e.combustible_servicio FROM EstaciondeServicio.dbo.usuario u inner join EstaciondeServicio.dbo.estacion e on u.id_estacion=e.id_estacion where nombre_usuario = '" + usuario + "'";
            SqlCommand cmd = new SqlCommand(Query, conexion);
            SqlDataReader reader = null;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    nombrecombus = reader.GetValue(0).ToString();
                }
            }
            conexion.Close();
            return nombrecombus;
        }

        public string numero_punto(string usuario)
        {
            string punto ="";
            conexion.Open();
            String Query = "SELECT e.numero_servicio FROM EstaciondeServicio.dbo.usuario u inner join EstaciondeServicio.dbo.estacion e on u.id_estacion=e.id_estacion where nombre_usuario = '" + usuario + "'";
            SqlCommand cmd = new SqlCommand(Query, conexion);
            SqlDataReader reader = null;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    punto = reader.GetValue(0).ToString();
                }
            }
            conexion.Close();
            return punto;
        }

        public string combustible_disponible(string usuario)
        {
            string punto = "";
            conexion.Open();
            String Query = "SELECT e.combustible_disponible FROM EstaciondeServicio.dbo.usuario u inner join EstaciondeServicio.dbo.estacion e on u.id_estacion=e.id_estacion where nombre_usuario = '" + usuario + "'";
            SqlCommand cmd = new SqlCommand(Query, conexion);
            SqlDataReader reader = null;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    punto = reader.GetValue(0).ToString();
                }
            }
            conexion.Close();
            return punto;
        }

        public string combustible_limite(string usuario)
        {
            string punto = "";
            conexion.Open();
            String Query = "SELECT e.capacidad_servicio FROM EstaciondeServicio.dbo.usuario u inner join EstaciondeServicio.dbo.estacion e on u.id_estacion=e.id_estacion where nombre_usuario = '" + usuario + "'";
            SqlCommand cmd = new SqlCommand(Query, conexion);
            SqlDataReader reader = null;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    punto = reader.GetValue(0).ToString();
                }
            }
            conexion.Close();
            return punto;
        }
    }
}
