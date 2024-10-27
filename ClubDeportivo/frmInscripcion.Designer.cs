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
            txtNroDoc = new TextBox();
            lblNroDoc = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            radioBtnSocio = new RadioButton();
            radioBtnNoSocio = new RadioButton();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            gBoxSocio = new GroupBox();
            lblTipoDoc = new Label();
            cboTipoDoc = new ComboBox();
            btnVolver = new Button();
            chkFichaMedica = new CheckBox();
            gBoxSocio.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(67, 28);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Nueva inscripción";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(73, 76);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(152, 76);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(211, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(152, 118);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(211, 23);
            txtApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(73, 118);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtNroDoc
            // 
            txtNroDoc.Location = new Point(267, 160);
            txtNroDoc.Margin = new Padding(3, 2, 3, 2);
            txtNroDoc.Name = "txtNroDoc";
            txtNroDoc.Size = new Size(96, 23);
            txtNroDoc.TabIndex = 6;
            // 
            // lblNroDoc
            // 
            lblNroDoc.AutoSize = true;
            lblNroDoc.Location = new Point(231, 163);
            lblNroDoc.Name = "lblNroDoc";
            lblNroDoc.Size = new Size(30, 15);
            lblNroDoc.TabIndex = 5;
            lblNroDoc.Text = "Nro.";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(152, 205);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(211, 23);
            txtTelefono.TabIndex = 8;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(73, 205);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Telefono";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(152, 249);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(211, 23);
            txtDireccion.TabIndex = 10;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(73, 249);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 9;
            lblDireccion.Text = "Direccion";
            // 
            // radioBtnSocio
            // 
            radioBtnSocio.AutoSize = true;
            radioBtnSocio.Checked = true;
            radioBtnSocio.Location = new Point(26, 27);
            radioBtnSocio.Margin = new Padding(3, 2, 3, 2);
            radioBtnSocio.Name = "radioBtnSocio";
            radioBtnSocio.Size = new Size(34, 19);
            radioBtnSocio.TabIndex = 12;
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
            radioBtnNoSocio.TabIndex = 13;
            radioBtnNoSocio.TabStop = true;
            radioBtnNoSocio.Text = "No";
            radioBtnNoSocio.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(529, 317);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(412, 317);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(82, 22);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // gBoxSocio
            // 
            gBoxSocio.Controls.Add(radioBtnSocio);
            gBoxSocio.Controls.Add(radioBtnNoSocio);
            gBoxSocio.Location = new Point(448, 69);
            gBoxSocio.Margin = new Padding(3, 2, 3, 2);
            gBoxSocio.Name = "gBoxSocio";
            gBoxSocio.Padding = new Padding(3, 2, 3, 2);
            gBoxSocio.Size = new Size(150, 64);
            gBoxSocio.TabIndex = 16;
            gBoxSocio.TabStop = false;
            gBoxSocio.Text = "Socio";
            // 
            // lblTipoDoc
            // 
            lblTipoDoc.AutoSize = true;
            lblTipoDoc.Location = new Point(73, 163);
            lblTipoDoc.Name = "lblTipoDoc";
            lblTipoDoc.Size = new Size(30, 15);
            lblTipoDoc.TabIndex = 17;
            lblTipoDoc.Text = "Tipo";
            // 
            // cboTipoDoc
            // 
            cboTipoDoc.FormattingEnabled = true;
            cboTipoDoc.Location = new Point(123, 160);
            cboTipoDoc.Name = "cboTipoDoc";
            cboTipoDoc.Size = new Size(85, 23);
            cboTipoDoc.TabIndex = 18;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(73, 317);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(82, 22);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // chkFichaMedica
            // 
            chkFichaMedica.AutoSize = true;
            chkFichaMedica.Location = new Point(474, 164);
            chkFichaMedica.Name = "chkFichaMedica";
            chkFichaMedica.Size = new Size(96, 19);
            chkFichaMedica.TabIndex = 20;
            chkFichaMedica.Text = "Ficha médica";
            chkFichaMedica.TextAlign = ContentAlignment.MiddleRight;
            chkFichaMedica.UseVisualStyleBackColor = true;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 394);
            Controls.Add(chkFichaMedica);
            Controls.Add(btnVolver);
            Controls.Add(cboTipoDoc);
            Controls.Add(lblTipoDoc);
            Controls.Add(gBoxSocio);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtNroDoc);
            Controls.Add(lblNroDoc);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmInscripcion";
            Text = "Inscripcion";
            Load += frmInscripcion_Load;
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
        private TextBox txtNroDoc;
        private Label lblNroDoc;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private RadioButton radioBtnSocio;
        private RadioButton radioBtnNoSocio;
        private Button btnGuardar;
        private Button btnLimpiar;
        private GroupBox gBoxSocio;
        private Label lblTipoDoc;
        private ComboBox cboTipoDoc;
        private Button btnVolver;
        private CheckBox chkFichaMedica;
    }
}