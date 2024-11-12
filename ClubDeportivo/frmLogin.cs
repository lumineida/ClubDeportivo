using ClubDeportivo.Datos;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System.Data;

namespace ClubDeportivo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable(); 
            Datos.Usuarios dato = new Datos.Usuarios();

            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);

            if (tablaLogin.Rows.Count > 0)
            {
                MessageBox.Show("Ingreso exitoso");

                frmPrincipal Principal = new frmPrincipal();
                Principal.usuario = Convert.ToString(txtUsuario.Text);
                Principal.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }

        }
    }
}
