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
            txtIDCliente.Location = new Point(180, 32);
            txtIDCliente.Margin = new Padding(3, 4, 3, 4);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.ReadOnly = true;
            txtIDCliente.Size = new Size(73, 27);
            txtIDCliente.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(112, 139);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(141, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblDatosCliente
            // 
            lblDatosCliente.AutoSize = true;
            lblDatosCliente.ImageAlign = ContentAlignment.BottomLeft;
            lblDatosCliente.Location = new Point(41, 39);
            lblDatosCliente.Name = "lblDatosCliente";
            lblDatosCliente.Size = new Size(133, 20);
            lblDatosCliente.TabIndex = 2;
            lblDatosCliente.Text = "Pago del cliente n°";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(47, 192);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(87, 20);
            lblDocumento.TabIndex = 3;
            lblDocumento.Text = "Documento";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(47, 143);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(47, 93);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(112, 89);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(141, 27);
            txtApellido.TabIndex = 6;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(134, 188);
            txtDocumento.Margin = new Padding(3, 4, 3, 4);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.ReadOnly = true;
            txtDocumento.Size = new Size(119, 27);
            txtDocumento.TabIndex = 9;
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Location = new Point(295, 43);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(47, 20);
            lblFechaPago.TabIndex = 10;
            lblFechaPago.Text = "Fecha";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(295, 96);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(53, 20);
            lblMonto.TabIndex = 11;
            lblMonto.Text = "Monto";
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Location = new Point(295, 144);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(111, 20);
            lblFormaPago.TabIndex = 12;
            lblFormaPago.Text = "Forma de pago";
            // 
            // radioBtnEfectivo
            // 
            radioBtnEfectivo.AutoSize = true;
            radioBtnEfectivo.Location = new Point(411, 141);
            radioBtnEfectivo.Margin = new Padding(3, 4, 3, 4);
            radioBtnEfectivo.Name = "radioBtnEfectivo";
            radioBtnEfectivo.Size = new Size(83, 24);
            radioBtnEfectivo.TabIndex = 13;
            radioBtnEfectivo.TabStop = true;
            radioBtnEfectivo.Text = "Efectivo";
            radioBtnEfectivo.UseVisualStyleBackColor = true;
            // 
            // radioBtnTarjeta
            // 
            radioBtnTarjeta.AutoSize = true;
            radioBtnTarjeta.Location = new Point(411, 175);
            radioBtnTarjeta.Margin = new Padding(3, 4, 3, 4);
            radioBtnTarjeta.Name = "radioBtnTarjeta";
            radioBtnTarjeta.Size = new Size(74, 24);
            radioBtnTarjeta.TabIndex = 14;
            radioBtnTarjeta.TabStop = true;
            radioBtnTarjeta.Text = "Tarjeta";
            radioBtnTarjeta.UseVisualStyleBackColor = true;
            // 
            // txtFechaPago
            // 
            txtFechaPago.Location = new Point(347, 39);
            txtFechaPago.Margin = new Padding(3, 4, 3, 4);
            txtFechaPago.Name = "txtFechaPago";
            txtFechaPago.Size = new Size(106, 27);
            txtFechaPago.TabIndex = 15;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(347, 89);
            txtMonto.Margin = new Padding(3, 4, 3, 4);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(106, 27);
            txtMonto.TabIndex = 16;
            // 
            // btnConfirmarPago
            // 
            btnConfirmarPago.Location = new Point(368, 249);
            btnConfirmarPago.Margin = new Padding(3, 4, 3, 4);
            btnConfirmarPago.Name = "btnConfirmarPago";
            btnConfirmarPago.Size = new Size(120, 37);
            btnConfirmarPago.TabIndex = 17;
            btnConfirmarPago.Text = "Confirmar pago";
            btnConfirmarPago.UseVisualStyleBackColor = true;
            btnConfirmarPago.Click += btnConfirmarPago_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(47, 253);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 31);
            btnVolver.TabIndex = 18;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmPagar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 315);
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
            Margin = new Padding(3, 4, 3, 4);
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