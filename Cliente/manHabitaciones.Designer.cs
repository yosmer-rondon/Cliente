namespace Cliente
{
    partial class manHabitaciones
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
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupHabitacion = new System.Windows.Forms.GroupBox();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.nudPiso = new System.Windows.Forms.NumericUpDown();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.textIDHabitacion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numHabitacion = new System.Windows.Forms.TextBox();
            this.TipoHabitacion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.groupHabitacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPiso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.AllowUserToAddRows = false;
            this.dgvHabitaciones.AllowUserToDeleteRows = false;
            this.dgvHabitaciones.AllowUserToResizeColumns = false;
            this.dgvHabitaciones.AllowUserToResizeRows = false;
            this.dgvHabitaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHabitaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(58, 12);
            this.dgvHabitaciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvHabitaciones.MultiSelect = false;
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.ReadOnly = true;
            this.dgvHabitaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHabitaciones.Size = new System.Drawing.Size(835, 161);
            this.dgvHabitaciones.TabIndex = 0;
            this.dgvHabitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHabitaciones_CellContentClick);
            this.dgvHabitaciones.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHabitaciones_CellEnter);
            // 
            // btnNueva
            // 
            this.btnNueva.BackColor = System.Drawing.Color.Orange;
            this.btnNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueva.ForeColor = System.Drawing.Color.Black;
            this.btnNueva.Location = new System.Drawing.Point(58, 195);
            this.btnNueva.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(159, 42);
            this.btnNueva.TabIndex = 1;
            this.btnNueva.Text = "Nueva Habitación";
            this.btnNueva.UseVisualStyleBackColor = false;
            this.btnNueva.EnabledChanged += new System.EventHandler(this.btnsPrincipal_EnabledChanged);
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Orange;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(289, 195);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(147, 42);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar Habitación";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.EnabledChanged += new System.EventHandler(this.btnsPrincipal_EnabledChanged);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.Color.Orange;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.ForeColor = System.Drawing.Color.Black;
            this.btnDeshabilitar.Location = new System.Drawing.Point(547, 195);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(191, 42);
            this.btnDeshabilitar.TabIndex = 3;
            this.btnDeshabilitar.Text = "Deshabilitar Habitación";
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            this.btnDeshabilitar.EnabledChanged += new System.EventHandler(this.btnsPrincipal_EnabledChanged);
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Orange;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(791, 195);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 42);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.EnabledChanged += new System.EventHandler(this.btnsPrincipal_EnabledChanged);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupHabitacion
            // 
            this.groupHabitacion.Controls.Add(this.TipoHabitacion);
            this.groupHabitacion.Controls.Add(this.numHabitacion);
            this.groupHabitacion.Controls.Add(this.label2);
            this.groupHabitacion.Controls.Add(this.Estado);
            this.groupHabitacion.Controls.Add(this.label1);
            this.groupHabitacion.Controls.Add(this.nudCapacidad);
            this.groupHabitacion.Controls.Add(this.nudPiso);
            this.groupHabitacion.Controls.Add(this.lblCosto);
            this.groupHabitacion.Controls.Add(this.lblCapacidad);
            this.groupHabitacion.Controls.Add(this.lblTipo);
            this.groupHabitacion.Controls.Add(this.lblPiso);
            this.groupHabitacion.Controls.Add(this.lblID);
            this.groupHabitacion.Controls.Add(this.txtCosto);
            this.groupHabitacion.Controls.Add(this.textIDHabitacion);
            this.groupHabitacion.Controls.Add(this.btnAgregar);
            this.groupHabitacion.Controls.Add(this.btnModificar);
            this.groupHabitacion.Controls.Add(this.btnCancelar);
            this.groupHabitacion.Location = new System.Drawing.Point(58, 264);
            this.groupHabitacion.Name = "groupHabitacion";
            this.groupHabitacion.Size = new System.Drawing.Size(835, 192);
            this.groupHabitacion.TabIndex = 5;
            this.groupHabitacion.TabStop = false;
            this.groupHabitacion.Text = "Datos de Habitacion";
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Enabled = false;
            this.nudCapacidad.Location = new System.Drawing.Point(499, 74);
            this.nudCapacidad.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(39, 20);
            this.nudCapacidad.TabIndex = 18;
            this.nudCapacidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCapacidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPiso
            // 
            this.nudPiso.Enabled = false;
            this.nudPiso.Location = new System.Drawing.Point(126, 73);
            this.nudPiso.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPiso.Name = "nudPiso";
            this.nudPiso.Size = new System.Drawing.Size(39, 20);
            this.nudPiso.TabIndex = 17;
            this.nudPiso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.BackColor = System.Drawing.Color.FloralWhite;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(331, 112);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(47, 16);
            this.lblCosto.TabIndex = 16;
            this.lblCosto.Text = "Costo";
            this.lblCosto.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.BackColor = System.Drawing.Color.FloralWhite;
            this.lblCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.Location = new System.Drawing.Point(331, 75);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(162, 16);
            this.lblCapacidad.TabIndex = 15;
            this.lblCapacidad.Text = "Capacidad Habitación";
            this.lblCapacidad.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.FloralWhite;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(6, 117);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(118, 16);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = "Tipo Habitación";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.BackColor = System.Drawing.Color.FloralWhite;
            this.lblPiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiso.Location = new System.Drawing.Point(3, 75);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(117, 16);
            this.lblPiso.TabIndex = 13;
            this.lblPiso.Text = "Piso Habitación";
            this.lblPiso.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.FloralWhite;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(3, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(101, 16);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID Habitación";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtCosto
            // 
            this.txtCosto.Enabled = false;
            this.txtCosto.Location = new System.Drawing.Point(401, 111);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(92, 20);
            this.txtCosto.TabIndex = 11;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            this.txtCosto.Validated += new System.EventHandler(this.txtCosto_Validated);
            // 
            // textIDHabitacion
            // 
            this.textIDHabitacion.Enabled = false;
            this.textIDHabitacion.Location = new System.Drawing.Point(110, 31);
            this.textIDHabitacion.Name = "textIDHabitacion";
            this.textIDHabitacion.Size = new System.Drawing.Size(101, 20);
            this.textIDHabitacion.TabIndex = 8;
            this.textIDHabitacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Orange;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(668, 19);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(159, 42);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.EnabledChanged += new System.EventHandler(this.btnsPrincipal_EnabledChanged);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Orange;
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(668, 73);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(159, 42);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.EnabledChanged += new System.EventHandler(this.btnsPrincipal_EnabledChanged);
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Orange;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(668, 132);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(159, 42);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.EnabledChanged += new System.EventHandler(this.btnsPrincipal_EnabledChanged);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Estado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Estado
            // 
            this.Estado.Enabled = false;
            this.Estado.Location = new System.Drawing.Point(417, 31);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(101, 20);
            this.Estado.TabIndex = 20;
            this.Estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FloralWhite;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Numero Habitacion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // numHabitacion
            // 
            this.numHabitacion.Enabled = false;
            this.numHabitacion.Location = new System.Drawing.Point(150, 158);
            this.numHabitacion.Name = "numHabitacion";
            this.numHabitacion.Size = new System.Drawing.Size(101, 20);
            this.numHabitacion.TabIndex = 22;
            this.numHabitacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TipoHabitacion
            // 
            this.TipoHabitacion.FormattingEnabled = true;
            this.TipoHabitacion.Location = new System.Drawing.Point(140, 116);
            this.TipoHabitacion.Name = "TipoHabitacion";
            this.TipoHabitacion.Size = new System.Drawing.Size(121, 21);
            this.TipoHabitacion.TabIndex = 23;
            // 
            // manHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(950, 468);
            this.Controls.Add(this.groupHabitacion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.dgvHabitaciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "manHabitaciones";
            this.Text = "manHabitaciones";
            this.Load += new System.EventHandler(this.manHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.groupHabitacion.ResumeLayout(false);
            this.groupHabitacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPiso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupHabitacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textIDHabitacion;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.NumericUpDown nudPiso;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.TextBox Estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numHabitacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoHabitacion;
    }
}