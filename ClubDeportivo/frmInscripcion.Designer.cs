namespace ClubDeportivo
{
    partial class frmInscripcion
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
            label1 = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            radioBtnSocio = new RadioButton();
            radioBtnNoSocio = new RadioButton();
            btnGuardar = new Button();
            gBoxSocio = new GroupBox();
            btnLimpiar = new Button();
            btnVolver = new Button();
            label2 = new Label();
            txtFichaMedica = new TextBox();
            gBoxSocio.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 0;
            label1.Text = "NUEVA INSCRIPCION";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(33, 54);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(115, 51);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(145, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(115, 89);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(145, 23);
            txtApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(33, 92);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(115, 127);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(145, 23);
            txtDni.TabIndex = 6;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(33, 130);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 5;
            lblDni.Text = "DNI:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(115, 163);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(145, 23);
            txtTelefono.TabIndex = 8;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(32, 166);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Telefono:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(115, 200);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(145, 23);
            txtDireccion.TabIndex = 10;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(32, 203);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 9;
            lblDireccion.Text = "Dirección:";
            // 
            // radioBtnSocio
            // 
            radioBtnSocio.AutoSize = true;
            radioBtnSocio.Checked = true;
            radioBtnSocio.Location = new Point(26, 27);
            radioBtnSocio.Margin = new Padding(3, 2, 3, 2);
            radioBtnSocio.Name = "radioBtnSocio";
            radioBtnSocio.Size = new Size(34, 19);
            radioBtnSocio.TabIndex = 13;
            radioBtnSocio.TabStop = true;
            radioBtnSocio.Text = "Si";
            radioBtnSocio.UseVisualStyleBackColor = true;
            // 
            // radioBtnNoSocio
            // 
            radioBtnNoSocio.AutoSize = true;
            radioBtnNoSocio.Location = new Point(88, 27);
            radioBtnNoSocio.Margin = new Padding(3, 2, 3, 2);
            radioBtnNoSocio.Name = "radioBtnNoSocio";
            radioBtnNoSocio.Size = new Size(41, 19);
            radioBtnNoSocio.TabIndex = 14;
            radioBtnNoSocio.TabStop = true;
            radioBtnNoSocio.Text = "No";
            radioBtnNoSocio.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(402, 303);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // gBoxSocio
            // 
            gBoxSocio.Controls.Add(radioBtnSocio);
            gBoxSocio.Controls.Add(radioBtnNoSocio);
            gBoxSocio.Location = new Point(314, 54);
            gBoxSocio.Margin = new Padding(3, 2, 3, 2);
            gBoxSocio.Name = "gBoxSocio";
            gBoxSocio.Padding = new Padding(3, 2, 3, 2);
            gBoxSocio.Size = new Size(150, 64);
            gBoxSocio.TabIndex = 16;
            gBoxSocio.TabStop = false;
            gBoxSocio.Text = "Socio";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(310, 303);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(82, 22);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(34, 303);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 17;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 240);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 11;
            label2.Text = "Ficha Médica:";
            // 
            // txtFichaMedica
            // 
            txtFichaMedica.Location = new Point(115, 237);
            txtFichaMedica.Name = "txtFichaMedica";
            txtFichaMedica.Size = new Size(145, 23);
            txtFichaMedica.TabIndex = 12;
            txtFichaMedica.TextChanged += txtFichaMedica_TextChanged;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 338);
            Controls.Add(txtFichaMedica);
            Controls.Add(label2);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(gBoxSocio);
            Controls.Add(btnGuardar);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmInscripcion";
            Text = "Inscripcion";
            gBoxSocio.ResumeLayout(false);
            gBoxSocio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtDni;
        private Label lblDni;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private RadioButton radioBtnSocio;
        private RadioButton radioBtnNoSocio;
        private Button btnGuardar;
        private GroupBox gBoxSocio;
        private Button btnLimpiar;
        private Button btnVolver;
        private Label label2;
        private TextBox txtFichaMedica;
    }
}