using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public DataTable consultaArqueoEconomico(string usuario, string num_puesto)
        {
            return conDatos.Arqueoeco(usuario, num_puesto);
        }

        public DataTable consultaVenta_Forma_Gral()
        {
            return conDatos.Venta_Forma_General();
        }

        public DataTable consultaUsuarios()
        {
            return conDatos.Usuarios();
        }

        public int consultaActualizarUsuarios(string usuario, string contraseña, string num_puesto)
        {
            return conDatos.ActualizarUsuario(usuario, contraseña, num_puesto);
        }

        public DataTable consultaVentaEspecifica(string usuario, string mes)
        {
            return conDatos.VentaSeleccionada(usuario, mes);
        }

        public DataTable consultaClientes()
        {
            return conDatos.Clientes();
        }

        public DataTable consultaBuscarCliente(string placa)
        {
            return conDatos.BuscarCliente(placa);
        }

        public string consultaValorCombustible(string usuario)
        {
            return conDatos.ValorCombustible(usuario);
        }

        public string consultaMaxGasolina()
        {
            return conDatos.MaxGasolina();
        }

        public string consultaMaxDiesel()
        {
            return conDatos.MaxDiesel();
        }

        public string consultaIdUsuario(string usuario)
        {
            return conDatos.idUsuario(usuario);
        }

        public string consultaIdCliente(string placa)
        {
            return conDatos.idCliente(placa);
        }

        public int consultaActCombustible(double combus, int num_serv)
        {
            return conDatos.ActualizarCombustible(combus, num_serv);
        }

        public int consultaInsertarHistorial(int id_usuario, int id_cliente, int id_estacion, double Cantidad_combustible, double total_bs)
        {
            return conDatos.InsertarHistorial(id_usuario, id_cliente, id_estacion, Cantidad_combustible, total_bs);
        }

        public int consultaLLenarCombustible(double limiteCombustible, int estacion)
        {
            return conDatos.LlenarCombustible(limiteCombustible, estacion);
        }




    }
}
