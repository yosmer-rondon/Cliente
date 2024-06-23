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
            this.btnNuevaHabitacion = new System.Windows.Forms.Button();
            this.btnEditarHabitacion = new System.Windows.Forms.Button();
            this.btnDeshabilitarHabitacion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupDatosHabitacion = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textCostoHabitacion = new System.Windows.Forms.TextBox();
            this.textIDHabitacion = new System.Windows.Forms.TextBox();
            this.checkEstadoHabitacion = new System.Windows.Forms.CheckBox();
            this.btnAgregarHabitacion = new System.Windows.Forms.Button();
            this.btnModificarHabitacion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textCapacidadHabitacion = new System.Windows.Forms.TextBox();
            this.textHabitacion = new System.Windows.Forms.TextBox();
            this.textIDTipoHabitacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textPisoHabitacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.groupDatosHabitacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(58, 12);
            this.dgvHabitaciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.Size = new System.Drawing.Size(835, 161);
            this.dgvHabitaciones.TabIndex = 0;
            this.dgvHabitaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHabitaciones_CellClick);
            this.dgvHabitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnNuevaHabitacion
            // 
            this.btnNuevaHabitacion.BackColor = System.Drawing.Color.Black;
            this.btnNuevaHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaHabitacion.ForeColor = System.Drawing.Color.White;
            this.btnNuevaHabitacion.Location = new System.Drawing.Point(58, 195);
            this.btnNuevaHabitacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevaHabitacion.Name = "btnNuevaHabitacion";
            this.btnNuevaHabitacion.Size = new System.Drawing.Size(159, 42);
            this.btnNuevaHabitacion.TabIndex = 1;
            this.btnNuevaHabitacion.Text = "Nueva Habitacion";
            this.btnNuevaHabitacion.UseVisualStyleBackColor = false;
            this.btnNuevaHabitacion.Click += new System.EventHandler(this.btnNuevaHabitacion_Click);
            // 
            // btnEditarHabitacion
            // 
            this.btnEditarHabitacion.BackColor = System.Drawing.Color.Black;
            this.btnEditarHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarHabitacion.ForeColor = System.Drawing.Color.White;
            this.btnEditarHabitacion.Location = new System.Drawing.Point(289, 195);
            this.btnEditarHabitacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditarHabitacion.Name = "btnEditarHabitacion";
            this.btnEditarHabitacion.Size = new System.Drawing.Size(147, 42);
            this.btnEditarHabitacion.TabIndex = 2;
            this.btnEditarHabitacion.Text = "Editar Habitacion";
            this.btnEditarHabitacion.UseVisualStyleBackColor = false;
            this.btnEditarHabitacion.Click += new System.EventHandler(this.btnEditarHabitacion_Click);
            // 
            // btnDeshabilitarHabitacion
            // 
            this.btnDeshabilitarHabitacion.BackColor = System.Drawing.Color.Black;
            this.btnDeshabilitarHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitarHabitacion.ForeColor = System.Drawing.Color.White;
            this.btnDeshabilitarHabitacion.Location = new System.Drawing.Point(547, 195);
            this.btnDeshabilitarHabitacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeshabilitarHabitacion.Name = "btnDeshabilitarHabitacion";
            this.btnDeshabilitarHabitacion.Size = new System.Drawing.Size(191, 42);
            this.btnDeshabilitarHabitacion.TabIndex = 3;
            this.btnDeshabilitarHabitacion.Text = "Deshabilitar Habitacion";
            this.btnDeshabilitarHabitacion.UseVisualStyleBackColor = false;
            this.btnDeshabilitarHabitacion.Click += new System.EventHandler(this.btnDeshabilitarHabitacion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Black;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(791, 195);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 42);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupDatosHabitacion
            // 
            this.groupDatosHabitacion.Controls.Add(this.textPisoHabitacion);
            this.groupDatosHabitacion.Controls.Add(this.label6);
            this.groupDatosHabitacion.Controls.Add(this.textIDTipoHabitacion);
            this.groupDatosHabitacion.Controls.Add(this.textHabitacion);
            this.groupDatosHabitacion.Controls.Add(this.textCapacidadHabitacion);
            this.groupDatosHabitacion.Controls.Add(this.label5);
            this.groupDatosHabitacion.Controls.Add(this.label4);
            this.groupDatosHabitacion.Controls.Add(this.label3);
            this.groupDatosHabitacion.Controls.Add(this.label2);
            this.groupDatosHabitacion.Controls.Add(this.label1);
            this.groupDatosHabitacion.Controls.Add(this.textCostoHabitacion);
            this.groupDatosHabitacion.Controls.Add(this.textIDHabitacion);
            this.groupDatosHabitacion.Controls.Add(this.checkEstadoHabitacion);
            this.groupDatosHabitacion.Controls.Add(this.btnAgregarHabitacion);
            this.groupDatosHabitacion.Controls.Add(this.btnModificarHabitacion);
            this.groupDatosHabitacion.Controls.Add(this.btnCancelar);
            this.groupDatosHabitacion.Location = new System.Drawing.Point(58, 264);
            this.groupDatosHabitacion.Name = "groupDatosHabitacion";
            this.groupDatosHabitacion.Size = new System.Drawing.Size(835, 189);
            this.groupDatosHabitacion.TabIndex = 5;
            this.groupDatosHabitacion.TabStop = false;
            this.groupDatosHabitacion.Text = "Datos de Habitacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FloralWhite;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(331, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Costo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FloralWhite;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Capacidad Habitacion";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FloralWhite;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID Tipo Habitacion";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FloralWhite;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Piso Habitacion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID Habitacion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textCostoHabitacion
            // 
            this.textCostoHabitacion.Location = new System.Drawing.Point(401, 111);
            this.textCostoHabitacion.Name = "textCostoHabitacion";
            this.textCostoHabitacion.Size = new System.Drawing.Size(45, 20);
            this.textCostoHabitacion.TabIndex = 11;
            // 
            // textIDHabitacion
            // 
            this.textIDHabitacion.Location = new System.Drawing.Point(110, 31);
            this.textIDHabitacion.Name = "textIDHabitacion";
            this.textIDHabitacion.Size = new System.Drawing.Size(101, 20);
            this.textIDHabitacion.TabIndex = 8;
            // 
            // checkEstadoHabitacion
            // 
            this.checkEstadoHabitacion.AutoSize = true;
            this.checkEstadoHabitacion.Location = new System.Drawing.Point(334, 34);
            this.checkEstadoHabitacion.Name = "checkEstadoHabitacion";
            this.checkEstadoHabitacion.Size = new System.Drawing.Size(130, 17);
            this.checkEstadoHabitacion.TabIndex = 5;
            this.checkEstadoHabitacion.Text = "Estado Habitacion";
            this.checkEstadoHabitacion.UseVisualStyleBackColor = true;
            // 
            // btnAgregarHabitacion
            // 
            this.btnAgregarHabitacion.BackColor = System.Drawing.Color.Black;
            this.btnAgregarHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarHabitacion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarHabitacion.Location = new System.Drawing.Point(668, 19);
            this.btnAgregarHabitacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregarHabitacion.Name = "btnAgregarHabitacion";
            this.btnAgregarHabitacion.Size = new System.Drawing.Size(159, 42);
            this.btnAgregarHabitacion.TabIndex = 4;
            this.btnAgregarHabitacion.Text = "Agregar";
            this.btnAgregarHabitacion.UseVisualStyleBackColor = false;
            this.btnAgregarHabitacion.Click += new System.EventHandler(this.btnAgregarHabitacion_Click);
            // 
            // btnModificarHabitacion
            // 
            this.btnModificarHabitacion.BackColor = System.Drawing.Color.Black;
            this.btnModificarHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarHabitacion.ForeColor = System.Drawing.Color.White;
            this.btnModificarHabitacion.Location = new System.Drawing.Point(668, 73);
            this.btnModificarHabitacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificarHabitacion.Name = "btnModificarHabitacion";
            this.btnModificarHabitacion.Size = new System.Drawing.Size(159, 42);
            this.btnModificarHabitacion.TabIndex = 3;
            this.btnModificarHabitacion.Text = "Modificar";
            this.btnModificarHabitacion.UseVisualStyleBackColor = false;
            this.btnModificarHabitacion.Click += new System.EventHandler(this.btnModificarHabitacion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(668, 132);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(159, 42);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // textCapacidadHabitacion
            // 
            this.textCapacidadHabitacion.Location = new System.Drawing.Point(499, 73);
            this.textCapacidadHabitacion.Name = "textCapacidadHabitacion";
            this.textCapacidadHabitacion.Size = new System.Drawing.Size(61, 20);
            this.textCapacidadHabitacion.TabIndex = 17;
            // 
            // textHabitacion
            // 
            this.textHabitacion.Location = new System.Drawing.Point(96, 73);
            this.textHabitacion.Name = "textHabitacion";
            this.textHabitacion.Size = new System.Drawing.Size(81, 20);
            this.textHabitacion.TabIndex = 18;
            // 
            // textIDTipoHabitacion
            // 
            this.textIDTipoHabitacion.Location = new System.Drawing.Point(149, 115);
            this.textIDTipoHabitacion.Name = "textIDTipoHabitacion";
            this.textIDTipoHabitacion.Size = new System.Drawing.Size(72, 20);
            this.textIDTipoHabitacion.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FloralWhite;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Habitacion";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textPisoHabitacion
            // 
            this.textPisoHabitacion.Location = new System.Drawing.Point(149, 153);
            this.textPisoHabitacion.Name = "textPisoHabitacion";
            this.textPisoHabitacion.Size = new System.Drawing.Size(72, 20);
            this.textPisoHabitacion.TabIndex = 21;
            // 
            // manHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(950, 449);
            this.Controls.Add(this.groupDatosHabitacion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitarHabitacion);
            this.Controls.Add(this.btnEditarHabitacion);
            this.Controls.Add(this.btnNuevaHabitacion);
            this.Controls.Add(this.dgvHabitaciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "manHabitaciones";
            this.Text = "manHabitaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.groupDatosHabitacion.ResumeLayout(false);
            this.groupDatosHabitacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Button btnNuevaHabitacion;
        private System.Windows.Forms.Button btnEditarHabitacion;
        private System.Windows.Forms.Button btnDeshabilitarHabitacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupDatosHabitacion;
        private System.Windows.Forms.Button btnAgregarHabitacion;
        private System.Windows.Forms.Button btnModificarHabitacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textIDHabitacion;
        private System.Windows.Forms.CheckBox checkEstadoHabitacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCostoHabitacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIDTipoHabitacion;
        private System.Windows.Forms.TextBox textHabitacion;
        private System.Windows.Forms.TextBox textCapacidadHabitacion;
        private System.Windows.Forms.TextBox textPisoHabitacion;
        private System.Windows.Forms.Label label6;
    }
}