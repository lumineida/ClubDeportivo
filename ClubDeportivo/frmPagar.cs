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
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarPago_Click(object sender, EventArgs e)
        {
        }

        private void frmPagarSocio_Load(object sender, EventArgs e)
        {

        }
    }
}
