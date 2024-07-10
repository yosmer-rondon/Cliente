namespace Cliente
{
    partial class Mantipohabitacion
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
            this.groupBoxDatosTipoHabitacion = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.NombreTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDTipoHabitacion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.checkBoxEstadoTipo = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDeshabilitarTipo = new System.Windows.Forms.Button();
            this.btnEditarTipo = new System.Windows.Forms.Button();
            this.btnNuevoTipo = new System.Windows.Forms.Button();
            this.dgvTipoHabitacion = new System.Windows.Forms.DataGridView();
            this.groupBoxDatosTipoHabitacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoHabitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDatosTipoHabitacion
            // 
            this.groupBoxDatosTipoHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBoxDatosTipoHabitacion.Controls.Add(this.label2);
            this.groupBoxDatosTipoHabitacion.Controls.Add(this.textEstado);
            this.groupBoxDatosTipoHabitacion.Controls.Add(this.label4);
            this.groupBoxDatosTipoHabitacion.Controls.Add(this.Descripcion);
            this.groupBoxDatosTipoHabitacion.Controls.Add(this.NombreTipo);
            this.groupBoxDatosTipoHabitacion.Controls.Add(this.label3);
            this.groupBoxDatosTipoHabitacion.Controls.Add(this.label1);
            this.groupBoxDatosTipoHabitacion.Controls.Add(this.IDTipoHabitacion);
            this.groupBoxDatosTipoHabitacion.Controls.Add(this.btnAgregar);
            this.groupBoxDatosTipoHabitacion.Controls.Add(this.btnModificar);
            this.groupBoxDatosTipoHabitacion.Controls.Add(this.btnCancelar);
            this.groupBoxDatosTipoHabitacion.Location = new System.Drawing.Point(4, 196);
            this.groupBoxDatosTipoHabitacion.Name = "groupBoxDatosTipoHabitacion";
            this.groupBoxDatosTipoHabitacion.Size = new System.Drawing.Size(488, 198);
            this.groupBoxDatosTipoHabitacion.TabIndex = 11;
            this.groupBoxDatosTipoHabitacion.TabStop = false;
            this.groupBoxDatosTipoHabitacion.Text = "Datos de Tipo Habitacion";
            this.groupBoxDatosTipoHabitacion.Enter += new System.EventHandler(this.groupBoxDatosTipoHabitacion_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Descripcion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textEstado
            // 
            this.textEstado.Location = new System.Drawing.Point(71, 167);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(78, 20);
            this.textEstado.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PowderBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Estado";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(99, 86);
            this.Descripcion.Multiline = true;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(152, 39);
            this.Descripcion.TabIndex = 19;
            // 
            // NombreTipo
            // 
            this.NombreTipo.Location = new System.Drawing.Point(71, 60);
            this.NombreTipo.Name = "NombreTipo";
            this.NombreTipo.Size = new System.Drawing.Size(180, 20);
            this.NombreTipo.TabIndex = 17;
            this.NombreTipo.TextChanged += new System.EventHandler(this.textNombreTipo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PowderBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID Tipo Habitacion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // IDTipoHabitacion
            // 
            this.IDTipoHabitacion.Location = new System.Drawing.Point(150, 28);
            this.IDTipoHabitacion.Name = "IDTipoHabitacion";
            this.IDTipoHabitacion.Size = new System.Drawing.Size(101, 20);
            this.IDTipoHabitacion.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(307, 19);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(159, 42);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Black;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(307, 73);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(159, 42);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(307, 132);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(159, 42);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // checkBoxEstadoTipo
            // 
            this.checkBoxEstadoTipo.AutoSize = true;
            this.checkBoxEstadoTipo.Location = new System.Drawing.Point(223, 377);
            this.checkBoxEstadoTipo.Name = "checkBoxEstadoTipo";
            this.checkBoxEstadoTipo.Size = new System.Drawing.Size(137, 17);
            this.checkBoxEstadoTipo.TabIndex = 5;
            this.checkBoxEstadoTipo.Text = "Estado Tipo Habitacion";
            this.checkBoxEstadoTipo.UseVisualStyleBackColor = true;
            this.checkBoxEstadoTipo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(499, 352);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(217, 42);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDeshabilitarTipo
            // 
            this.btnDeshabilitarTipo.BackColor = System.Drawing.Color.Black;
            this.btnDeshabilitarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitarTipo.ForeColor = System.Drawing.Color.White;
            this.btnDeshabilitarTipo.Location = new System.Drawing.Point(499, 303);
            this.btnDeshabilitarTipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeshabilitarTipo.Name = "btnDeshabilitarTipo";
            this.btnDeshabilitarTipo.Size = new System.Drawing.Size(217, 42);
            this.btnDeshabilitarTipo.TabIndex = 9;
            this.btnDeshabilitarTipo.Text = "Deshabilitar Tipo Habitacion";
            this.btnDeshabilitarTipo.UseVisualStyleBackColor = false;
            this.btnDeshabilitarTipo.Click += new System.EventHandler(this.btnDeshabilitarTipo_Click);
            // 
            // btnEditarTipo
            // 
            this.btnEditarTipo.BackColor = System.Drawing.Color.Black;
            this.btnEditarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTipo.ForeColor = System.Drawing.Color.White;
            this.btnEditarTipo.Location = new System.Drawing.Point(499, 250);
            this.btnEditarTipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditarTipo.Name = "btnEditarTipo";
            this.btnEditarTipo.Size = new System.Drawing.Size(217, 42);
            this.btnEditarTipo.TabIndex = 8;
            this.btnEditarTipo.Text = "Editar Tipo Habitacion";
            this.btnEditarTipo.UseVisualStyleBackColor = false;
            this.btnEditarTipo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNuevoTipo
            // 
            this.btnNuevoTipo.BackColor = System.Drawing.Color.Black;
            this.btnNuevoTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoTipo.ForeColor = System.Drawing.Color.White;
            this.btnNuevoTipo.Location = new System.Drawing.Point(499, 202);
            this.btnNuevoTipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevoTipo.Name = "btnNuevoTipo";
            this.btnNuevoTipo.Size = new System.Drawing.Size(217, 42);
            this.btnNuevoTipo.TabIndex = 7;
            this.btnNuevoTipo.Text = "Nuevo Tipo Habitacion";
            this.btnNuevoTipo.UseVisualStyleBackColor = false;
            this.btnNuevoTipo.Click += new System.EventHandler(this.btnNuevoTipo_Click);
            // 
            // dgvTipoHabitacion
            // 
            this.dgvTipoHabitacion.BackgroundColor = System.Drawing.Color.White;
            this.dgvTipoHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoHabitacion.Location = new System.Drawing.Point(13, 24);
            this.dgvTipoHabitacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvTipoHabitacion.Name = "dgvTipoHabitacion";
            this.dgvTipoHabitacion.Size = new System.Drawing.Size(703, 161);
            this.dgvTipoHabitacion.TabIndex = 6;
            this.dgvTipoHabitacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoHabitacion_CellClick);
            this.dgvTipoHabitacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Mantipohabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(722, 395);
            this.Controls.Add(this.groupBoxDatosTipoHabitacion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitarTipo);
            this.Controls.Add(this.btnEditarTipo);
            this.Controls.Add(this.btnNuevoTipo);
            this.Controls.Add(this.dgvTipoHabitacion);
            this.Controls.Add(this.checkBoxEstadoTipo);
            this.Name = "Mantipohabitacion";
            this.Text = "Mantipohabitacion";
            this.groupBoxDatosTipoHabitacion.ResumeLayout(false);
            this.groupBoxDatosTipoHabitacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoHabitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatosTipoHabitacion;
        private System.Windows.Forms.TextBox NombreTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDTipoHabitacion;
        private System.Windows.Forms.CheckBox checkBoxEstadoTipo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDeshabilitarTipo;
        private System.Windows.Forms.Button btnEditarTipo;
        private System.Windows.Forms.Button btnNuevoTipo;
        private System.Windows.Forms.DataGridView dgvTipoHabitacion;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}