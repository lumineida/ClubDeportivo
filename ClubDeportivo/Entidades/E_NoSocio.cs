using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClubDeportivo.Entidades
{
    internal class E_NoSocio : E_Cliente
    {


        public frmPrincipal Principal = new frmPrincipal();
        DataGridView grid;
        public E_NoSocio() {

            grid = Principal.dataGridNoSocios;

        }

        public void CargaGrilla()
        {
            Debug.WriteLine("test grilla");

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();

                query = "select nombre, apellido, concat(tipo_doc, ' ', nro_doc), telefono, direccion from cliente where socio = 0;";


                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    Debug.WriteLine("haydatos");
                    while (reader.Read())
                    {
                        int renglon = grid.Rows.Add();
                        grid.Rows[renglon].Cells[0].Value = reader.GetString(0);
                        grid.Rows[renglon].Cells[1].Value = reader.GetString(1);
                        grid.Rows[renglon].Cells[2].Value = reader.GetString(2);
                        grid.Rows[renglon].Cells[3].Value = reader.GetString(3);
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY DATOS PARA LA CARGA DE LA GRILLA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }


    }
}
