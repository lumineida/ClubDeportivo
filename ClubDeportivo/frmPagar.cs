using ClubDeportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmPagar : Form
    {

        public frmPagar(string id, string apellido, string nombre, string documento)
        {
            InitializeComponent();
            txtIDCliente.Text = id;
            txtApellido.Text = apellido;
            txtNombre.Text = nombre;
            txtDocumento.Text = documento;
            txtFechaPago.Text = DateTime.Now.ToString("dd-MM-yyyy");
            txtFechaPago.ReadOnly = true;
            txtMonto.Focus();
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            if (txtIDCliente.Text == "" || txtApellido.Text == "" || txtNombre.Text == "" || txtDocumento.Text == "" || txtMonto.Text == "" || (!radioBtnEfectivo.Checked && radioBtnTarjeta.Checked))
            {
                MessageBox.Show("Por favor complete todos los campos");
            }
            else
            {
                try
                {
                    string idSocio = txtIDCliente.Text;
                    string monto = txtMonto.Text;
                    string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                    string fechaVencimiento = DateTime.Now.AddMonths(1).ToString("yyyy-MM-dd");
                    string formaPago = radioBtnEfectivo.Checked ? "efectivo" : "tarjeta";

                    string query = "INSERT INTO cuota (idSocio, monto, fechaPago, fechaVencimiento, formaPago) VALUES ('" + idSocio + "', '" + monto + "', '" + fecha + "', '" + fechaVencimiento + "', '" + formaPago + "')";
                    MySqlConnection conexion = Conexion.getInstancia().CrearConexion();
                    conexion.Open();
                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Pago realizado con éxito");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar el pago: " + ex.Message);
                }
            }
        }

        private void frmPagarSocio_Load(object sender, EventArgs e)
        {

        }
    }
}
