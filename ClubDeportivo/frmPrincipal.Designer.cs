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
            tabsClientes = new TabControl();
            tabSocios = new TabPage();
            dtgvSocios = new DataGridView();
            tabNoSocios = new TabPage();
            dtgvNoSocios = new DataGridView();
            nombre2 = new DataGridViewTextBoxColumn();
            apellido2 = new DataGridViewTextBoxColumn();
            documento2 = new DataGridViewTextBoxColumn();
            telefono2 = new DataGridViewTextBoxColumn();
            direccion2 = new DataGridViewTextBoxColumn();
            botones2 = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            documento = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            botones = new DataGridViewTextBoxColumn();
            tabsClientes.SuspendLayout();
            tabSocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvSocios).BeginInit();
            tabNoSocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvNoSocios).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(16, 444);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 33);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnInscribir
            // 
            btnInscribir.Location = new Point(874, 12);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(133, 36);
            btnInscribir.TabIndex = 1;
            btnInscribir.Text = "NUEVO CLIENTE";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnPagoCuota
            // 
            btnPagoCuota.Location = new Point(654, 453);
            btnPagoCuota.Name = "btnPagoCuota";
            btnPagoCuota.Size = new Size(130, 33);
            btnPagoCuota.TabIndex = 2;
            btnPagoCuota.Text = "Pagos";
            btnPagoCuota.UseVisualStyleBackColor = true;
            // 
            // btnBajas
            // 
            btnBajas.Location = new Point(812, 453);
            btnBajas.Name = "btnBajas";
            btnBajas.Size = new Size(182, 33);
            btnBajas.TabIndex = 3;
            btnBajas.Text = "Listar Vencimientos";
            btnBajas.UseVisualStyleBackColor = true;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(12, 20);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(87, 20);
            lblIngreso.TabIndex = 4;
            lblIngreso.Text = "Bienvenido ";
            // 
            // tabsClientes
            // 
            tabsClientes.Controls.Add(tabSocios);
            tabsClientes.Controls.Add(tabNoSocios);
            tabsClientes.Location = new Point(12, 54);
            tabsClientes.Name = "tabsClientes";
            tabsClientes.SelectedIndex = 0;
            tabsClientes.Size = new Size(982, 372);
            tabsClientes.TabIndex = 5;
            tabsClientes.SelectedIndexChanged += tabNoSocios_Click;
            tabsClientes.TabIndexChanged += tabNoSocios_Click;
            // 
            // tabSocios
            // 
            tabSocios.Controls.Add(dtgvSocios);
            tabSocios.Location = new Point(4, 29);
            tabSocios.Name = "tabSocios";
            tabSocios.Padding = new Padding(3);
            tabSocios.Size = new Size(974, 339);
            tabSocios.TabIndex = 0;
            tabSocios.Text = "SOCIOS";
            tabSocios.UseVisualStyleBackColor = true;
            tabSocios.Click += tabSocios_Click;
            // 
            // dtgvSocios
            // 
            dtgvSocios.AllowUserToAddRows = false;
            dtgvSocios.AllowUserToDeleteRows = false;
            dtgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSocios.Columns.AddRange(new DataGridViewColumn[] { nombre, apellido, documento, telefono, direccion, botones });
            dtgvSocios.Dock = DockStyle.Fill;
            dtgvSocios.Location = new Point(3, 3);
            dtgvSocios.Name = "dtgvSocios";
            dtgvSocios.RowHeadersWidth = 51;
            dtgvSocios.RowTemplate.Height = 29;
            dtgvSocios.Size = new Size(968, 333);
            dtgvSocios.TabIndex = 0;
            // 
            // tabNoSocios
            // 
            tabNoSocios.Controls.Add(dtgvNoSocios);
            tabNoSocios.Location = new Point(4, 29);
            tabNoSocios.Name = "tabNoSocios";
            tabNoSocios.Padding = new Padding(3);
            tabNoSocios.Size = new Size(974, 339);
            tabNoSocios.TabIndex = 1;
            tabNoSocios.Text = "NO SOCIOS";
            tabNoSocios.UseVisualStyleBackColor = true;
            tabNoSocios.Click += tabNoSocios_Click;
            // 
            // dtgvNoSocios
            // 
            dtgvNoSocios.AllowUserToAddRows = false;
            dtgvNoSocios.AllowUserToDeleteRows = false;
            dtgvNoSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvNoSocios.Columns.AddRange(new DataGridViewColumn[] { nombre2, apellido2, documento2, telefono2, direccion2, botones2 });
            dtgvNoSocios.Dock = DockStyle.Fill;
            dtgvNoSocios.Location = new Point(3, 3);
            dtgvNoSocios.Name = "dtgvNoSocios";
            dtgvNoSocios.ReadOnly = true;
            dtgvNoSocios.RowHeadersWidth = 51;
            dtgvNoSocios.RowTemplate.Height = 29;
            dtgvNoSocios.Size = new Size(968, 333);
            dtgvNoSocios.TabIndex = 1;
            // 
            // nombre2
            // 
            nombre2.HeaderText = "Nombre";
            nombre2.MinimumWidth = 6;
            nombre2.Name = "nombre2";
            nombre2.ReadOnly = true;
            nombre2.Width = 125;
            // 
            // apellido2
            // 
            apellido2.HeaderText = "Apellido";
            apellido2.MinimumWidth = 6;
            apellido2.Name = "apellido2";
            apellido2.ReadOnly = true;
            apellido2.Width = 125;
            // 
            // documento2
            // 
            documento2.HeaderText = "Documento";
            documento2.MinimumWidth = 6;
            documento2.Name = "documento2";
            documento2.ReadOnly = true;
            documento2.Width = 125;
            // 
            // telefono2
            // 
            telefono2.HeaderText = "Telefono";
            telefono2.MinimumWidth = 6;
            telefono2.Name = "telefono2";
            telefono2.ReadOnly = true;
            telefono2.Width = 125;
            // 
            // direccion2
            // 
            direccion2.HeaderText = "Direccion";
            direccion2.MinimumWidth = 6;
            direccion2.Name = "direccion2";
            direccion2.ReadOnly = true;
            direccion2.Width = 125;
            // 
            // botones2
            // 
            botones2.HeaderText = "";
            botones2.MinimumWidth = 6;
            botones2.Name = "botones2";
            botones2.ReadOnly = true;
            botones2.Width = 125;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.Width = 125;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.MinimumWidth = 6;
            apellido.Name = "apellido";
            apellido.Width = 125;
            // 
            // documento
            // 
            documento.HeaderText = "Documento";
            documento.MinimumWidth = 6;
            documento.Name = "documento";
            documento.Width = 125;
            // 
            // telefono
            // 
            telefono.HeaderText = "Telefono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            telefono.Width = 125;
            // 
            // direccion
            // 
            direccion.HeaderText = "Direccion";
            direccion.MinimumWidth = 6;
            direccion.Name = "direccion";
            direccion.Width = 125;
            // 
            // botones
            // 
            botones.HeaderText = "opciones";
            botones.MinimumWidth = 6;
            botones.Name = "botones";
            botones.Width = 125;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 498);
            Controls.Add(tabsClientes);
            Controls.Add(lblIngreso);
            Controls.Add(btnBajas);
            Controls.Add(btnPagoCuota);
            Controls.Add(btnInscribir);
            Controls.Add(btnSalir);
            Name = "frmPrincipal";
            Text = "Menu Principal";
            Load += frmPrincipal_Load;
            tabsClientes.ResumeLayout(false);
            tabSocios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvSocios).EndInit();
            tabNoSocios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvNoSocios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnInscribir;
        private Button btnPagoCuota;
        private Button btnBajas;
        private Label lblIngreso;
        private TabControl tabsClientes;
        private TabPage tabSocios;
        private TabPage tabNoSocios;
        public DataGridView dtgvSocios;
        public DataGridView dtgvNoSocios;
        public DataGridViewTextBoxColumn nombre2;
        public DataGridViewTextBoxColumn apellido2;
        public DataGridViewTextBoxColumn documento2;
        public DataGridViewTextBoxColumn telefono2;
        public DataGridViewTextBoxColumn direccion2;
        public DataGridViewTextBoxColumn botones2;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn documento;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn botones;
    }
}