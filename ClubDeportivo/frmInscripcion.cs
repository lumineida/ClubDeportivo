using ClubDeportivo.Entidades;
using Mysqlx.Expr;
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
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";

            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDni.Text == "" || txtTelefono.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;
                E_Cliente cliente = new E_Cliente();
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Dni = txtDni.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Socio = radioBtnSocio.Checked;

                Datos.Clientes clientes = new Datos.Clientes();

                respuesta = clientes.Nuevo_Cliente(cliente);

                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo > 0)
                    {
                        MessageBox.Show("El cliente ya se encuentra registrado", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("El cliente se registró satisfactoriamente.", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        txtDni.Text = "";
                        txtTelefono.Text = "";
                        txtDireccion.Text = "";
                    }
                }
            }

        }




    }
}
