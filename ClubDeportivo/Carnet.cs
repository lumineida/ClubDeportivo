using ClubDeportivo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class Carnet : Form
    {
        public int? id;
        public string? documento;
        public string? nombre;
        public string? apellido;
        public string? vencimiento;

        public Carnet(int id, string nombre, string apellido, string documento)
        {
            InitializeComponent();

                lblNroSocio.Text = "Socio Nº: " + id;
                lblNombre.Text = "Nombre: " + nombre;
                lblApellido.Text = "Apellido: " + apellido;
                lblDocumento.Text = "Documento: " + documento;
                lblFecha.Text = DateTime.UtcNow.ToShortDateString();

        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();
            btnImprimir.Visible = true;

            MessageBox.Show("Se ha impreso el carnet", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics?.DrawImage(img, p);
        }
    }
}
