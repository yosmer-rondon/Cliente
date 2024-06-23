namespace Cliente
{
    partial class Limpieza_de_habitaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkEstadoHabitacion = new System.Windows.Forms.CheckBox();
            this.chkDisponibilidad = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEstadoOrden = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoTrabajo = new System.Windows.Forms.ComboBox();
            this.comboBoxPersonal = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtIDHabitacion = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de trabajo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 834);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(-4, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 85);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LIMPIEZA_DE_HABITACION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "personal";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID de la Habitacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "nombre del empleado";
            // 
            // chkEstadoHabitacion
            // 
            this.chkEstadoHabitacion.AutoSize = true;
            this.chkEstadoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstadoHabitacion.Location = new System.Drawing.Point(171, 512);
            this.chkEstadoHabitacion.Name = "chkEstadoHabitacion";
            this.chkEstadoHabitacion.Size = new System.Drawing.Size(208, 24);
            this.chkEstadoHabitacion.TabIndex = 10;
            this.chkEstadoHabitacion.Text = "Estado de Habitacion";
            this.chkEstadoHabitacion.UseVisualStyleBackColor = true;
            // 
            // chkDisponibilidad
            // 
            this.chkDisponibilidad.AutoSize = true;
            this.chkDisponibilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDisponibilidad.Location = new System.Drawing.Point(171, 473);
            this.chkDisponibilidad.Name = "chkDisponibilidad";
            this.chkDisponibilidad.Size = new System.Drawing.Size(260, 24);
            this.chkDisponibilidad.TabIndex = 11;
            this.chkDisponibilidad.Text = "Disponibilidad de habitacion";
            this.chkDisponibilidad.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(474, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(892, 439);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Estado de orden";
            // 
            // comboBoxEstadoOrden
            // 
            this.comboBoxEstadoOrden.FormattingEnabled = true;
            this.comboBoxEstadoOrden.Location = new System.Drawing.Point(171, 580);
            this.comboBoxEstadoOrden.Name = "comboBoxEstadoOrden";
            this.comboBoxEstadoOrden.Size = new System.Drawing.Size(154, 28);
            this.comboBoxEstadoOrden.TabIndex = 14;
            // 
            // comboBoxTipoTrabajo
            // 
            this.comboBoxTipoTrabajo.FormattingEnabled = true;
            this.comboBoxTipoTrabajo.Location = new System.Drawing.Point(171, 176);
            this.comboBoxTipoTrabajo.Name = "comboBoxTipoTrabajo";
            this.comboBoxTipoTrabajo.Size = new System.Drawing.Size(157, 28);
            this.comboBoxTipoTrabajo.TabIndex = 15;
            // 
            // comboBoxPersonal
            // 
            this.comboBoxPersonal.FormattingEnabled = true;
            this.comboBoxPersonal.Location = new System.Drawing.Point(171, 260);
            this.comboBoxPersonal.Name = "comboBoxPersonal";
            this.comboBoxPersonal.Size = new System.Drawing.Size(145, 28);
            this.comboBoxPersonal.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(474, 605);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 50);
            this.button1.TabIndex = 17;
            this.button1.Text = "agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(663, 605);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 50);
            this.button2.TabIndex = 18;
            this.button2.Text = "actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtIDHabitacion
            // 
            this.txtIDHabitacion.Location = new System.Drawing.Point(166, 352);
            this.txtIDHabitacion.Name = "txtIDHabitacion";
            this.txtIDHabitacion.Size = new System.Drawing.Size(180, 26);
            this.txtIDHabitacion.TabIndex = 19;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(171, 428);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(214, 26);
            this.txtNombreEmpleado.TabIndex = 20;
            // 
            // Limpieza_de_habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 831);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.txtIDHabitacion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxPersonal);
            this.Controls.Add(this.comboBoxTipoTrabajo);
            this.Controls.Add(this.comboBoxEstadoOrden);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chkDisponibilidad);
            this.Controls.Add(this.chkEstadoHabitacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Limpieza_de_habitaciones";
            this.Text = "Limpieza_de_habitaciones";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkEstadoHabitacion;
        private System.Windows.Forms.CheckBox chkDisponibilidad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEstadoOrden;
        private System.Windows.Forms.ComboBox comboBoxTipoTrabajo;
        private System.Windows.Forms.ComboBox comboBoxPersonal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIDHabitacion;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
    }
}