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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            btnSalir = new Button();
            btnInscribir = new Button();
            btnPagoCuota = new Button();
            btnBajas = new Button();
            lblIngreso = new Label();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(606, 297);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(82, 30);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnInscribir
            // 
            btnInscribir.Image = (Image)resources.GetObject("btnInscribir.Image");
            btnInscribir.ImageAlign = ContentAlignment.MiddleLeft;
            btnInscribir.Location = new Point(108, 142);
            btnInscribir.Margin = new Padding(3, 2, 3, 2);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.RightToLeft = RightToLeft.No;
            btnInscribir.Size = new Size(120, 67);
            btnInscribir.TabIndex = 1;
            btnInscribir.Text = "Inscripciones";
            btnInscribir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnPagoCuota
            // 
            btnPagoCuota.Image = (Image)resources.GetObject("btnPagoCuota.Image");
            btnPagoCuota.ImageAlign = ContentAlignment.MiddleRight;
            btnPagoCuota.Location = new Point(288, 142);
            btnPagoCuota.Margin = new Padding(3, 2, 3, 2);
            btnPagoCuota.Name = "btnPagoCuota";
            btnPagoCuota.Size = new Size(120, 67);
            btnPagoCuota.TabIndex = 2;
            btnPagoCuota.Text = "Pagos";
            btnPagoCuota.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPagoCuota.UseVisualStyleBackColor = true;
            // 
            // btnBajas
            // 
            btnBajas.Image = (Image)resources.GetObject("btnBajas.Image");
            btnBajas.ImageAlign = ContentAlignment.MiddleRight;
            btnBajas.Location = new Point(460, 144);
            btnBajas.Margin = new Padding(3, 2, 3, 2);
            btnBajas.Name = "btnBajas";
            btnBajas.Size = new Size(120, 67);
            btnBajas.TabIndex = 3;
            btnBajas.Text = "Vencimientos";
            btnBajas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBajas.UseVisualStyleBackColor = true;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(49, 47);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(130, 15);
            lblIngreso.TabIndex = 4;
            lblIngreso.Text = "Bienvenido Usuario xxx";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lblIngreso);
            Controls.Add(btnBajas);
            Controls.Add(btnPagoCuota);
            Controls.Add(btnInscribir);
            Controls.Add(btnSalir);
            Margin = new Padding(3, 2, 3, 2);
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