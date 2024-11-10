namespace ClubDeportivo
{
    partial class frmPagar
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
            txtIDCliente = new TextBox();
            txtNombre = new TextBox();
            lblDatosCliente = new Label();
            lblDocumento = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            lblFechaPago = new Label();
            lblMonto = new Label();
            lblFormaPago = new Label();
            radioBtnEfectivo = new RadioButton();
            radioBtnTarjeta = new RadioButton();
            txtFechaPago = new TextBox();
            txtMonto = new TextBox();
            btnConfirmarPago = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(139, 26);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.ReadOnly = true;
            txtIDCliente.Size = new Size(34, 23);
            txtIDCliente.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(98, 104);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(124, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblDatosCliente
            // 
            lblDatosCliente.AutoSize = true;
            lblDatosCliente.ImageAlign = ContentAlignment.BottomLeft;
            lblDatosCliente.Location = new Point(36, 29);
            lblDatosCliente.Name = "lblDatosCliente";
            lblDatosCliente.Size = new Size(106, 15);
            lblDatosCliente.TabIndex = 2;
            lblDatosCliente.Text = "Pago del cliente n°";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(41, 144);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 3;
            lblDocumento.Text = "Documento";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(41, 107);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(41, 70);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(98, 67);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(124, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(117, 141);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.ReadOnly = true;
            txtDocumento.Size = new Size(105, 23);
            txtDocumento.TabIndex = 9;
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Location = new Point(258, 32);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(38, 15);
            lblFechaPago.TabIndex = 10;
            lblFechaPago.Text = "Fecha";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(258, 72);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 11;
            lblMonto.Text = "Monto";
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Location = new Point(258, 108);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(87, 15);
            lblFormaPago.TabIndex = 12;
            lblFormaPago.Text = "Forma de pago";
            // 
            // radioBtnEfectivo
            // 
            radioBtnEfectivo.AutoSize = true;
            radioBtnEfectivo.Location = new Point(360, 106);
            radioBtnEfectivo.Name = "radioBtnEfectivo";
            radioBtnEfectivo.Size = new Size(67, 19);
            radioBtnEfectivo.TabIndex = 13;
            radioBtnEfectivo.TabStop = true;
            radioBtnEfectivo.Text = "Efectivo";
            radioBtnEfectivo.UseVisualStyleBackColor = true;
            // 
            // radioBtnTarjeta
            // 
            radioBtnTarjeta.AutoSize = true;
            radioBtnTarjeta.Location = new Point(360, 131);
            radioBtnTarjeta.Name = "radioBtnTarjeta";
            radioBtnTarjeta.Size = new Size(59, 19);
            radioBtnTarjeta.TabIndex = 14;
            radioBtnTarjeta.TabStop = true;
            radioBtnTarjeta.Text = "Tarjeta";
            radioBtnTarjeta.UseVisualStyleBackColor = true;
            // 
            // txtFechaPago
            // 
            txtFechaPago.Location = new Point(304, 29);
            txtFechaPago.Name = "txtFechaPago";
            txtFechaPago.Size = new Size(93, 23);
            txtFechaPago.TabIndex = 15;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(304, 67);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(93, 23);
            txtMonto.TabIndex = 16;
            // 
            // btnConfirmarPago
            // 
            btnConfirmarPago.Location = new Point(322, 187);
            btnConfirmarPago.Name = "btnConfirmarPago";
            btnConfirmarPago.Size = new Size(105, 28);
            btnConfirmarPago.TabIndex = 17;
            btnConfirmarPago.Text = "Confirmar pago";
            btnConfirmarPago.UseVisualStyleBackColor = true;
            btnConfirmarPago.Click += btnConfirmarPago_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(41, 190);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 18;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmPagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 236);
            Controls.Add(btnVolver);
            Controls.Add(btnConfirmarPago);
            Controls.Add(txtMonto);
            Controls.Add(txtFechaPago);
            Controls.Add(radioBtnTarjeta);
            Controls.Add(radioBtnEfectivo);
            Controls.Add(lblFormaPago);
            Controls.Add(lblMonto);
            Controls.Add(lblFechaPago);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblDocumento);
            Controls.Add(lblDatosCliente);
            Controls.Add(txtNombre);
            Controls.Add(txtIDCliente);
            Name = "frmPagar";
            Text = "Realizar pago";
            Load += frmPagarSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIDCliente;
        private TextBox txtNombre;
        private Label lblDatosCliente;
        private Label lblDocumento;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private Label lblFechaPago;
        private Label lblMonto;
        private Label lblFormaPago;
        private RadioButton radioBtnEfectivo;
        private RadioButton radioBtnTarjeta;
        private TextBox txtFechaPago;
        private TextBox txtMonto;
        private Button btnConfirmarPago;
        private Button btnVolver;
    }
}