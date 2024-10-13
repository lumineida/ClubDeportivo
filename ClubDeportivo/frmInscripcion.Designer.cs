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
            btnCancelar = new Button();
            gBoxSocio = new GroupBox();
            gBoxSocio.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(77, 38);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 0;
            label1.Text = "NUEVA INSCRIPCION";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(83, 102);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(174, 102);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(174, 158);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(175, 27);
            txtApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(83, 158);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(174, 215);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(175, 27);
            txtDni.TabIndex = 6;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(83, 215);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 5;
            lblDni.Text = "DNI";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(174, 269);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(175, 27);
            txtTelefono.TabIndex = 8;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(83, 269);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Telefono";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(174, 328);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(175, 27);
            txtDireccion.TabIndex = 10;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(83, 328);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 9;
            lblDireccion.Text = "Direccion";
            // 
            // radioBtnSocio
            // 
            radioBtnSocio.AutoSize = true;
            radioBtnSocio.Checked = true;
            radioBtnSocio.Location = new Point(30, 36);
            radioBtnSocio.Name = "radioBtnSocio";
            radioBtnSocio.Size = new Size(42, 24);
            radioBtnSocio.TabIndex = 12;
            radioBtnSocio.TabStop = true;
            radioBtnSocio.Text = "Si";
            radioBtnSocio.UseVisualStyleBackColor = true;
            // 
            // radioBtnNoSocio
            // 
            radioBtnNoSocio.AutoSize = true;
            radioBtnNoSocio.Location = new Point(100, 36);
            radioBtnNoSocio.Name = "radioBtnNoSocio";
            radioBtnNoSocio.Size = new Size(50, 24);
            radioBtnNoSocio.TabIndex = 13;
            radioBtnNoSocio.TabStop = true;
            radioBtnNoSocio.Text = "No";
            radioBtnNoSocio.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(590, 331);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(456, 331);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // gBoxSocio
            // 
            gBoxSocio.Controls.Add(radioBtnSocio);
            gBoxSocio.Controls.Add(radioBtnNoSocio);
            gBoxSocio.Location = new Point(512, 93);
            gBoxSocio.Name = "gBoxSocio";
            gBoxSocio.Size = new Size(172, 85);
            gBoxSocio.TabIndex = 16;
            gBoxSocio.TabStop = false;
            gBoxSocio.Text = "Socio";
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gBoxSocio);
            Controls.Add(btnCancelar);
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
        private Button btnCancelar;
        private GroupBox gBoxSocio;
    }
}