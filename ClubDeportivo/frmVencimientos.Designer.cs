using System.Data;

namespace ClubDeportivo
{
    public partial class frmVencimientos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public DataGridView dataGridVencimientos;

        public void LoadData(DataTable data)
        {
            this.dataGridVencimientos = new System.Windows.Forms.DataGridView();
            this.Controls.Add(this.dataGridVencimientos);
            dataGridVencimientos.DataSource = data;
            dataGridVencimientos.Dock = DockStyle.Fill;
            dataGridVencimientos.Columns["Fecha de Vencimiento"].Width = 150;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // frmVencimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmVencimientos";
            Text = "Listado de vencimientos";
            Load += frmVencimientos_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}