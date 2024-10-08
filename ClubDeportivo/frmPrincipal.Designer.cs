namespace ClubDeportivo
{
    partial class frmPrincipal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalir = new Button();
            btnInscribir = new Button();
            btnPagoCuota = new Button();
            btnBajas = new Button();
            lblIngreso = new Label();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(682, 38);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnInscribir
            // 
            btnInscribir.Location = new Point(103, 190);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(122, 89);
            btnInscribir.TabIndex = 1;
            btnInscribir.Text = "Inscripciones";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnPagoCuota
            // 
            btnPagoCuota.Location = new Point(323, 192);
            btnPagoCuota.Name = "btnPagoCuota";
            btnPagoCuota.Size = new Size(122, 89);
            btnPagoCuota.TabIndex = 2;
            btnPagoCuota.Text = "Pagos";
            btnPagoCuota.UseVisualStyleBackColor = true;
            // 
            // btnBajas
            // 
            btnBajas.Location = new Point(546, 194);
            btnBajas.Name = "btnBajas";
            btnBajas.Size = new Size(122, 87);
            btnBajas.TabIndex = 3;
            btnBajas.Text = "Vencimientos";
            btnBajas.UseVisualStyleBackColor = true;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(82, 41);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(87, 20);
            lblIngreso.TabIndex = 4;
            lblIngreso.Text = "Bienvenido ";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIngreso);
            Controls.Add(btnBajas);
            Controls.Add(btnPagoCuota);
            Controls.Add(btnInscribir);
            Controls.Add(btnSalir);
            Name = "frmPrincipal";
            Text = "Menu Principal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnInscribir;
        private Button btnPagoCuota;
        private Button btnBajas;
        private Label lblIngreso;
    }
}