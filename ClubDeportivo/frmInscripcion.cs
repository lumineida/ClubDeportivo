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


        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            cboTipoDoc.Items.Add("Seleccionar");
            cboTipoDoc.Items.Add("DNI");
            cboTipoDoc.Items.Add("Pasaporte");
            cboTipoDoc.Items.Add("Extranjero");
            cboTipoDoc.SelectedIndex = 0;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox(this);
        }

        private void LimpiarTextBox(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty; // Limpia el contenido del TextBox
                }

                else if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false; // Desmarca el CheckBox
                }

                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = 0; // Selecciona el primer item del ComboBox
                }

                else if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false; // Desmarca el RadioButton
                }

            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || cboTipoDoc.Text == "Seleccionar" || txtNroDoc.Text == "" || txtTelefono.Text == "" || txtDireccion.Text == "" || !chkFichaMedica.Checked)
            {
                MessageBox.Show("Debe completar datos requeridos (*) ", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string? respuesta;
                E_Cliente cliente = new E_Cliente();
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.TipoDoc = cboTipoDoc.Text;
                cliente.NroDoc = txtNroDoc.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Socio = radioBtnSocio.Checked;
                cliente.FichaMedica = chkFichaMedica.Checked;

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
                        LimpiarTextBox(this);
                    }
                }
            }

        }



    }
}
