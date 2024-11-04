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

            Debug.WriteLine("test principal");
            //tabSocios_Click(sender, e);
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

        private void tabSelected(object sender, EventArgs e)
        {
            MessageBox.Show(e.ToString());

        }



        private void tabSocios_Click(object sender, EventArgs e)
        {
            E_Socio socios = new E_Socio();
        }

        private void tabNoSocios_Click(object sender, EventArgs e)
        {
            E_NoSocio noSocios = new E_NoSocio();
            noSocios.CargaGrilla();
        }
    }
}
