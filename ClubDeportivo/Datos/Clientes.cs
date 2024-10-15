using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    internal class Clientes
    {

        public string Nuevo_Cliente(E_Cliente cliente)
        {
            string? salida;
            salida = " ";

            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("NuevoCliente", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = cliente.Nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = cliente.Apellido;
                comando.Parameters.Add("TipoDoc", MySqlDbType.VarChar).Value = cliente.TipoDoc;
                comando.Parameters.Add("NroDoc", MySqlDbType.VarChar).Value = cliente.NroDoc;
                comando.Parameters.Add("Tel", MySqlDbType.VarChar).Value = cliente.Telefono;
                comando.Parameters.Add("Dir", MySqlDbType.VarChar).Value = cliente.Direccion;
                comando.Parameters.Add("Soc", MySqlDbType.Bit).Value = cliente.Socio;
                comando.Parameters.Add("FichaMed", MySqlDbType.Bit).Value = cliente.FichaMedica;

                MySqlParameter ParCodigo = new MySqlParameter();

                ParCodigo.ParameterName = "rta";

                //ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();

                salida = Convert.ToString(ParCodigo.Value);
            }

            catch (Exception ex)
            {
                salida = ex.Message;
            }

            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }

            return salida;

        }

    }
}
