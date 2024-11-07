using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        internal string? usuario;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "BIENVENIDO USUARIO: " + usuario;

            tabSocios_Click(sender, e);


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            frmInscripcion inscripcion = new frmInscripcion();
            inscripcion.Show();
            this.Hide();

        }


        private void tabSocios_Click(object sender, EventArgs e)
        {
            E_Socio socios = new E_Socio();
            socios.CargaDatos();
            if (socios.listado.Count > 0)
            {
                cargarDatosGrilla(socios.listado, "Socios");
            }

        }

        private void tabNoSocios_Click(object sender, EventArgs e)
        {
            E_NoSocio noSocios = new E_NoSocio();
            noSocios.CargaDatos();
            if (noSocios.listado.Count > 0)
            {
                cargarDatosGrilla(noSocios.listado, "NoSocios");
            }
        }

        private void cargarDatosGrilla(List<E_Cliente> listado, string tipo)
        {
            DataGridView grid = tipo == "Socios" ? dtgvSocios : dtgvNoSocios;

            foreach (E_Cliente cliente in listado)
            {
                Debug.WriteLine(cliente.Nombre);
                int renglon = grid.Rows.Add();
                grid.Rows[renglon].Cells[0].Value = cliente.Id;
                grid.Rows[renglon].Cells[1].Value = cliente.Nombre;
                grid.Rows[renglon].Cells[2].Value = cliente.Apellido;
                grid.Rows[renglon].Cells[3].Value = cliente.Documento;
                grid.Rows[renglon].Cells[4].Value = cliente.Telefono;
                grid.Rows[renglon].Cells[5].Value = cliente.Direccion;
            }
        }

        private void dtgvSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvSocios.Columns[e.ColumnIndex].Name == "pagar" && e.RowIndex >= 0)
            {
                var rowData = dtgvSocios.Rows[e.RowIndex].Cells[0].Value;
                MessageBox.Show($"Cambiar esto para que abra el form de Pagar para el socio con ID: {rowData}");
            }
            else if (dtgvSocios.Columns[e.ColumnIndex].Name == "Carnet" && e.RowIndex >= 0)
            {
                var rowData = dtgvSocios.Rows[e.RowIndex].Cells[0].Value;
                MessageBox.Show($"Cambiar esto para que abra el form de Carnet para el socio con ID: {rowData}");
            }

        }

        private void dtgvNoSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvNoSocios.Columns[e.ColumnIndex].Name == "actividad" && e.RowIndex >= 0)
            {
                var rowData = dtgvNoSocios.Rows[e.RowIndex].Cells[0].Value;
                MessageBox.Show($"Cambiar esto para que abra el form de incripcion y pago de actividad para el no-socio con ID: {rowData}");
            }

        }
    }
}
