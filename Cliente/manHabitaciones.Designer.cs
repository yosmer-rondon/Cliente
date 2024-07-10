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
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoHabitacion = new System.Windows.Forms.ComboBox();
            this.textIDHabitacion = new System.Windows.Forms.TextBox();
            this.nudPiso = new System.Windows.Forms.NumericUpDown();
            this.numHabitacion = new System.Windows.Forms.TextBox();
            this.Estado = new System.Windows.Forms.TextBox();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.groupHabitacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
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
            this.dgvHabitaciones.Location = new System.Drawing.Point(23, 12);
            this.dgvHabitaciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvHabitaciones.MultiSelect = false;
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.ReadOnly = true;
            this.dgvHabitaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHabitaciones.Size = new System.Drawing.Size(948, 161);
            this.dgvHabitaciones.TabIndex = 0;
            this.dgvHabitaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHabitaciones_CellClick);
            this.dgvHabitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHabitaciones_CellContentClick);
            this.dgvHabitaciones.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHabitaciones_CellEnter);
            // 
            // btnNueva
            // 
            this.btnNueva.BackColor = System.Drawing.Color.Orange;
            this.btnNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueva.ForeColor = System.Drawing.Color.Black;
            this.btnNueva.Location = new System.Drawing.Point(13, 195);
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
            this.btnEditar.Location = new System.Drawing.Point(184, 195);
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
            this.btnDeshabilitar.Location = new System.Drawing.Point(349, 195);
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
            this.btnSalir.Location = new System.Drawing.Point(858, 195);
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
            this.groupHabitacion.Controls.Add(this.btnBuscar);
            this.groupHabitacion.Controls.Add(this.button1);
            this.groupHabitacion.Controls.Add(this.btnModificar);
            this.groupHabitacion.Controls.Add(this.btnAgregar);
            this.groupHabitacion.Controls.Add(this.txtCosto);
            this.groupHabitacion.Controls.Add(this.nudCapacidad);
            this.groupHabitacion.Controls.Add(this.Estado);
            this.groupHabitacion.Controls.Add(this.numHabitacion);
            this.groupHabitacion.Controls.Add(this.nudPiso);
            this.groupHabitacion.Controls.Add(this.textIDHabitacion);
            this.groupHabitacion.Controls.Add(this.TipoHabitacion);
            this.groupHabitacion.Controls.Add(this.label2);
            this.groupHabitacion.Controls.Add(this.label1);
            this.groupHabitacion.Controls.Add(this.lblCosto);
            this.groupHabitacion.Controls.Add(this.lblCapacidad);
            this.groupHabitacion.Controls.Add(this.lblTipo);
            this.groupHabitacion.Controls.Add(this.lblPiso);
            this.groupHabitacion.Controls.Add(this.lblID);
            this.groupHabitacion.Location = new System.Drawing.Point(58, 264);
            this.groupHabitacion.Name = "groupHabitacion";
            this.groupHabitacion.Size = new System.Drawing.Size(902, 235);
            this.groupHabitacion.TabIndex = 5;
            this.groupHabitacion.TabStop = false;
            this.groupHabitacion.Text = "Datos de Habitacion";
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
            // TipoHabitacion
            // 
            this.TipoHabitacion.FormattingEnabled = true;
            this.TipoHabitacion.Location = new System.Drawing.Point(140, 116);
            this.TipoHabitacion.Name = "TipoHabitacion";
            this.TipoHabitacion.Size = new System.Drawing.Size(121, 21);
            this.TipoHabitacion.TabIndex = 23;
            // 
            // textIDHabitacion
            // 
            this.textIDHabitacion.Location = new System.Drawing.Point(110, 28);
            this.textIDHabitacion.Name = "textIDHabitacion";
            this.textIDHabitacion.Size = new System.Drawing.Size(100, 20);
            this.textIDHabitacion.TabIndex = 24;
            // 
            // nudPiso
            // 
            this.nudPiso.Location = new System.Drawing.Point(126, 71);
            this.nudPiso.Name = "nudPiso";
            this.nudPiso.Size = new System.Drawing.Size(33, 20);
            this.nudPiso.TabIndex = 25;
            // 
            // numHabitacion
            // 
            this.numHabitacion.Location = new System.Drawing.Point(152, 154);
            this.numHabitacion.Name = "numHabitacion";
            this.numHabitacion.Size = new System.Drawing.Size(100, 20);
            this.numHabitacion.TabIndex = 26;
            // 
            // Estado
            // 
            this.Estado.Location = new System.Drawing.Point(401, 34);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(100, 20);
            this.Estado.TabIndex = 27;
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Location = new System.Drawing.Point(499, 71);
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(33, 20);
            this.nudCapacidad.TabIndex = 28;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(393, 108);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 29;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Orange;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(718, 12);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(159, 42);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Orange;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(718, 71);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(159, 42);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(718, 132);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 42);
            this.button1.TabIndex = 30;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Orange;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(718, 187);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(159, 42);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(557, 195);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 42);
            this.button2.TabIndex = 32;
            this.button2.Text = "Realizar Búsqueda";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(733, 195);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 42);
            this.button3.TabIndex = 33;
            this.button3.Text = "Listar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // manHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(984, 499);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudPiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupHabitacion;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoHabitacion;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.TextBox Estado;
        private System.Windows.Forms.TextBox numHabitacion;
        private System.Windows.Forms.NumericUpDown nudPiso;
        private System.Windows.Forms.TextBox textIDHabitacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}