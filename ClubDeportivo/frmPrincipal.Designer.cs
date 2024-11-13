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
            btnListarVencimientos = new Button();
            lblIngreso = new Label();
            tabsClientes = new TabControl();
            tabSocios = new TabPage();
            dtgvSocios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            documento = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            pagar = new DataGridViewButtonColumn();
            Carnet = new DataGridViewButtonColumn();
            tabNoSocios = new TabPage();
            dtgvNoSocios = new DataGridView();
            IdNS = new DataGridViewTextBoxColumn();
            nombre2 = new DataGridViewTextBoxColumn();
            apellido2 = new DataGridViewTextBoxColumn();
            documento2 = new DataGridViewTextBoxColumn();
            telefono2 = new DataGridViewTextBoxColumn();
            direccion2 = new DataGridViewTextBoxColumn();
            actividad = new DataGridViewButtonColumn();
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
            // btnListarVencimientos
            // 
            btnListarVencimientos.Location = new Point(812, 453);
            btnListarVencimientos.Name = "btnListarVencimientos";
            btnListarVencimientos.Size = new Size(182, 33);
            btnListarVencimientos.TabIndex = 3;
            btnListarVencimientos.Text = "Listar Vencimientos";
            btnListarVencimientos.UseVisualStyleBackColor = true;
            btnListarVencimientos.Click += btnListarVencimientos_Click;
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
            dtgvSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSocios.Columns.AddRange(new DataGridViewColumn[] { Id, nombre, apellido, documento, telefono, direccion, pagar, Carnet });
            dtgvSocios.Dock = DockStyle.Fill;
            dtgvSocios.Location = new Point(3, 3);
            dtgvSocios.Name = "dtgvSocios";
            dtgvSocios.RowHeadersWidth = 51;
            dtgvSocios.RowTemplate.Height = 29;
            dtgvSocios.Size = new Size(968, 333);
            dtgvSocios.TabIndex = 0;
            dtgvSocios.CellContentClick += dtgvSocios_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.MinimumWidth = 6;
            apellido.Name = "apellido";
            // 
            // documento
            // 
            documento.HeaderText = "Documento";
            documento.MinimumWidth = 6;
            documento.Name = "documento";
            // 
            // telefono
            // 
            telefono.HeaderText = "Telefono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            // 
            // direccion
            // 
            direccion.HeaderText = "Direccion";
            direccion.MinimumWidth = 6;
            direccion.Name = "direccion";
            // 
            // pagar
            // 
            pagar.HeaderText = "";
            pagar.MinimumWidth = 6;
            pagar.Name = "pagar";
            pagar.Resizable = DataGridViewTriState.True;
            pagar.SortMode = DataGridViewColumnSortMode.Automatic;
            pagar.Text = "Pagar";
            pagar.UseColumnTextForButtonValue = true;
            // 
            // Carnet
            // 
            Carnet.HeaderText = "";
            Carnet.MinimumWidth = 6;
            Carnet.Name = "Carnet";
            Carnet.Resizable = DataGridViewTriState.True;
            Carnet.SortMode = DataGridViewColumnSortMode.Automatic;
            Carnet.Text = "Carnet";
            Carnet.UseColumnTextForButtonValue = true;
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
            dtgvNoSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvNoSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvNoSocios.Columns.AddRange(new DataGridViewColumn[] { IdNS, nombre2, apellido2, documento2, telefono2, direccion2, actividad });
            dtgvNoSocios.Dock = DockStyle.Fill;
            dtgvNoSocios.Location = new Point(3, 3);
            dtgvNoSocios.Name = "dtgvNoSocios";
            dtgvNoSocios.ReadOnly = true;
            dtgvNoSocios.RowHeadersWidth = 51;
            dtgvNoSocios.RowTemplate.Height = 29;
            dtgvNoSocios.Size = new Size(968, 333);
            dtgvNoSocios.TabIndex = 1;
            dtgvNoSocios.CellContentClick += dtgvNoSocios_CellContentClick;
            // 
            // IdNS
            // 
            IdNS.HeaderText = "ID";
            IdNS.MinimumWidth = 6;
            IdNS.Name = "IdNS";
            IdNS.ReadOnly = true;
            // 
            // nombre2
            // 
            nombre2.HeaderText = "Nombre";
            nombre2.MinimumWidth = 6;
            nombre2.Name = "nombre2";
            nombre2.ReadOnly = true;
            // 
            // apellido2
            // 
            apellido2.HeaderText = "Apellido";
            apellido2.MinimumWidth = 6;
            apellido2.Name = "apellido2";
            apellido2.ReadOnly = true;
            // 
            // documento2
            // 
            documento2.HeaderText = "Documento";
            documento2.MinimumWidth = 6;
            documento2.Name = "documento2";
            documento2.ReadOnly = true;
            // 
            // telefono2
            // 
            telefono2.HeaderText = "Telefono";
            telefono2.MinimumWidth = 6;
            telefono2.Name = "telefono2";
            telefono2.ReadOnly = true;
            // 
            // direccion2
            // 
            direccion2.HeaderText = "Direccion";
            direccion2.MinimumWidth = 6;
            direccion2.Name = "direccion2";
            direccion2.ReadOnly = true;
            // 
            // actividad
            // 
            actividad.HeaderText = "";
            actividad.MinimumWidth = 6;
            actividad.Name = "actividad";
            actividad.ReadOnly = true;
            actividad.Resizable = DataGridViewTriState.True;
            actividad.SortMode = DataGridViewColumnSortMode.Automatic;
            actividad.Text = "Inscribir a actividad";
            actividad.UseColumnTextForButtonValue = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 498);
            Controls.Add(tabsClientes);
            Controls.Add(lblIngreso);
            Controls.Add(btnListarVencimientos);
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
        private Button btnListarVencimientos;
        private Label lblIngreso;
        private TabControl tabsClientes;
        private TabPage tabSocios;
        private TabPage tabNoSocios;
        public DataGridView dtgvSocios;
        public DataGridView dtgvNoSocios;
        private DataGridViewTextBoxColumn IdNS;
        private DataGridViewTextBoxColumn nombre2;
        private DataGridViewTextBoxColumn apellido2;
        private DataGridViewTextBoxColumn documento2;
        private DataGridViewTextBoxColumn telefono2;
        private DataGridViewTextBoxColumn direccion2;
        private DataGridViewButtonColumn actividad;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn documento;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewButtonColumn pagar;
        private DataGridViewButtonColumn Carnet;
    }
}