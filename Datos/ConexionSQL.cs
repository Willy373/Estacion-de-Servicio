using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Datos
{
    public class ConexionSQL
    {
        static String conexionstring = "server = LAPTOP-2L5H5J2L\\SQLEXPRESS; database=EstaciondeServicio; INTEGRATED SECURITY = true ";
        SqlConnection conexion = new SqlConnection(conexionstring);

        public int Mes_referencia(String mestext)
        {
            if (mestext == "ENERO")
                return 1;
            if (mestext == "FEBRERO")
                return 2;
            if (mestext == "MARZO")
                return 3;
            if (mestext == "ABRIL")
                return 4;
            if (mestext == "MAYO")
                return 5;
            if (mestext == "JUNIO")
                return 6;
            if (mestext == "JULIO")
                return 7;
            if (mestext == "AGOSTO")
                return 8;
            if (mestext == "SEPTIEMBRE")
                return 9;
            if (mestext == "OCTUBRE")
                return 10;
            if (mestext == "NOVIEMBRE")
                return 11;
            if (mestext == "DICIEMBRE")
                return 12;
            return 0;
        }

        public int consultalogin(String usuario, String contraseña)
        {
            int count;
            conexion.Open();
            String Query = "Select Count(*) FROM EstaciondeServicio.dbo.usuario where nombre_usuario='" + usuario + "'and contrasena_usuario='" + contraseña + "'";
            SqlCommand cmd = new SqlCommand(Query, conexion);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.Close();
            return count;
        }
        public string combustible(String usuario)
        {
            string nombrecombus = "";
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
            string punto = "";
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
        public DataTable Arqueoeco(String usuario, String numero_puesto)
        {
            conexion.Open();
            string query = "SELECT h.id_historial as Nro, u.nombre_usuario, e.combustible_servicio, e.costo_combustible, h.cantidad_combustible, h.total_bolivianos, h.fecha_venta from EstaciondeServicio.dbo.historial_estacion h inner join EstaciondeServicio.dbo.usuario u on h.id_usuario = u.id_usuario inner join EstaciondeServicio.dbo.estacion e on h.id_estacion = e.id_estacion where u.nombre_usuario = '" + usuario + "'and e.id_estacion = '" + numero_puesto + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conexion.Close();
            return tabla;
        }

        public DataTable Venta_Forma_General()
        {
            conexion.Open();
            string query = "SELECT h.id_historial as Nro, u.nombre_usuario, e.combustible_servicio, e.costo_combustible, h.cantidad_combustible, h.total_bolivianos, h.fecha_venta from EstaciondeServicio.dbo.historial_estacion h inner join EstaciondeServicio.dbo.usuario u on h.id_usuario = u.id_usuario inner join EstaciondeServicio.dbo.estacion e on h.id_estacion = e.id_estacion";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conexion.Close();
            return tabla;
        }

        public DataTable Usuarios()
        {
            conexion.Open();
            string query = "SELECT u.id_usuario, u.nombre_usuario, u.contrasena_usuario, u.nombre_vendedor, u.apellido_vendedor, e.numero_servicio , e.combustible_servicio FROM EstaciondeServicio.dbo.usuario u inner join EstaciondeServicio.dbo.estacion e on u.id_estacion = e.id_estacion";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            conexion.Close();
            return tabla;
        }

        public int ActualizarUsuario(string usuario, string contraseña, string num_puesto)
        {
            int verificar = 0;
            conexion.Open();
            string query = "UPDATE EstaciondeServicio.dbo.usuario SET nombre_usuario='" + usuario + "', contrasena_usuario='" + contraseña + "', id_estacion='" + num_puesto + "' WHERE id_usuario=1";
            SqlCommand cmd = new SqlCommand(query, conexion);
            verificar = cmd.ExecuteNonQuery();
            conexion.Close();
            return verificar;
        }


        public DataTable VentaSeleccionada(String usuario, String mes)
        {
            conexion.Open();
            DataTable tabla = new DataTable();

            if (usuario == "TODOS" && mes == "TODOS")
            {
                string query = "SELECT h.id_historial as Nro, u.nombre_usuario, e.combustible_servicio, e.costo_combustible, h.cantidad_combustible, h.total_bolivianos, h.fecha_venta from EstaciondeServicio.dbo.historial_estacion h inner join EstaciondeServicio.dbo.usuario u on h.id_usuario = u.id_usuario inner join EstaciondeServicio.dbo.estacion e on h.id_estacion = e.id_estacion ";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(tabla);
                conexion.Close();
                return tabla;
            }
            if (usuario == "TODOS" && mes != "TODOS")
            {
                int mesNum = Mes_referencia(mes);
                string query = "SELECT h.id_historial as Nro, u.nombre_usuario, e.combustible_servicio, e.costo_combustible, h.cantidad_combustible, h.total_bolivianos, h.fecha_venta from EstaciondeServicio.dbo.historial_estacion h inner join EstaciondeServicio.dbo.usuario u on h.id_usuario = u.id_usuario inner join EstaciondeServicio.dbo.estacion e on h.id_estacion = e.id_estacion where MONTH(h.fecha_venta) = "+mesNum+"";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(tabla);
                conexion.Close();
                return tabla;
            }
            if (usuario != "TODOS" && mes == "TODOS")
            {
                string query = "SELECT h.id_historial as Nro, u.nombre_usuario, e.combustible_servicio, e.costo_combustible, h.cantidad_combustible, h.total_bolivianos, h.fecha_venta from EstaciondeServicio.dbo.historial_estacion h inner join EstaciondeServicio.dbo.usuario u on h.id_usuario = u.id_usuario inner join EstaciondeServicio.dbo.estacion e on h.id_estacion = e.id_estacion where u.nombre_usuario = '"+usuario+"'";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(tabla);
                conexion.Close();
                return tabla;

            }
            if (usuario != "TODOS" && mes != "TODOS")
            {
                int mesNum = Mes_referencia(mes);
                string query = "SELECT h.id_historial as Nro, u.nombre_usuario, e.combustible_servicio, e.costo_combustible, h.cantidad_combustible, h.total_bolivianos, h.fecha_venta from EstaciondeServicio.dbo.historial_estacion h inner join EstaciondeServicio.dbo.usuario u on h.id_usuario = u.id_usuario inner join EstaciondeServicio.dbo.estacion e on h.id_estacion = e.id_estacion where MONTH(h.fecha_venta) = "+mesNum+" and u.nombre_usuario = '"+usuario+"'";
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(tabla);
                conexion.Close();
                return tabla;

            }
            return tabla;
        }
    }
}
