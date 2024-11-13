namespace ClubDeportivo
{
    partial class Carnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carnet));
            lblTitulo = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblNroSocio = new Label();
            lblDocumento = new Label();
            btnImprimir = new Button();
            lblFecha = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(196, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(254, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "CLUB DEPORTIVO";
            lblTitulo.UseMnemonic = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(186, 179);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre: ";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(186, 224);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(73, 20);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido: ";
            // 
            // lblNroSocio
            // 
            lblNroSocio.AutoSize = true;
            lblNroSocio.Location = new Point(186, 97);
            lblNroSocio.Name = "lblNroSocio";
            lblNroSocio.Size = new Size(74, 20);
            lblNroSocio.TabIndex = 4;
            lblNroSocio.Text = "Socio Nº: ";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(186, 136);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(94, 20);
            lblDocumento.TabIndex = 6;
            lblDocumento.Text = "Documento: ";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(534, 302);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(94, 29);
            btnImprimir.TabIndex = 7;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(574, 97);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(54, 20);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha: ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Carnet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 366);
            Controls.Add(pictureBox1);
            Controls.Add(lblFecha);
            Controls.Add(btnImprimir);
            Controls.Add(lblDocumento);
            Controls.Add(lblNroSocio);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "Carnet";
            Text = "Carnet";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblNroSocio;
        private Label lblDocumento;
        private Button btnImprimir;
        private Label lblFecha;
        private PictureBox pictureBox1;
    }
}