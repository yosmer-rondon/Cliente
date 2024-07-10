namespace Cliente
{
    partial class RealizaOrdenTrabajo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ordenculminada = new System.Windows.Forms.Button();
            this.habitacionesucias = new System.Windows.Forms.Button();
            this.Listar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.descrip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tipotrabajo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idtra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Numhabitacion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(297, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.Numhabitacion);
            this.panel1.Controls.Add(this.Ordenculminada);
            this.panel1.Controls.Add(this.habitacionesucias);
            this.panel1.Controls.Add(this.Listar);
            this.panel1.Controls.Add(this.agregar);
            this.panel1.Controls.Add(this.descrip);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.estado);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tipotrabajo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.idtra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 524);
            this.panel1.TabIndex = 1;
            // 
            // Ordenculminada
            // 
            this.Ordenculminada.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Ordenculminada.Location = new System.Drawing.Point(315, 484);
            this.Ordenculminada.Name = "Ordenculminada";
            this.Ordenculminada.Size = new System.Drawing.Size(137, 30);
            this.Ordenculminada.TabIndex = 15;
            this.Ordenculminada.Text = "Culminar";
            this.Ordenculminada.UseVisualStyleBackColor = false;
            this.Ordenculminada.Click += new System.EventHandler(this.Ordenculminada_Click);
            // 
            // habitacionesucias
            // 
            this.habitacionesucias.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.habitacionesucias.Location = new System.Drawing.Point(727, 322);
            this.habitacionesucias.Name = "habitacionesucias";
            this.habitacionesucias.Size = new System.Drawing.Size(136, 65);
            this.habitacionesucias.TabIndex = 14;
            this.habitacionesucias.Text = "Listar Habitaciones sucias";
            this.habitacionesucias.UseVisualStyleBackColor = false;
            // 
            // Listar
            // 
            this.Listar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Listar.Location = new System.Drawing.Point(154, 484);
            this.Listar.Name = "Listar";
            this.Listar.Size = new System.Drawing.Size(137, 30);
            this.Listar.TabIndex = 12;
            this.Listar.Text = "Listar";
            this.Listar.UseVisualStyleBackColor = false;
            this.Listar.Click += new System.EventHandler(this.Listar_Click);
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.agregar.Location = new System.Drawing.Point(11, 466);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(137, 48);
            this.agregar.TabIndex = 11;
            this.agregar.Text = "Agregar orden de trabajo";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // descrip
            // 
            this.descrip.Location = new System.Drawing.Point(16, 284);
            this.descrip.Multiline = true;
            this.descrip.Name = "descrip";
            this.descrip.Size = new System.Drawing.Size(234, 76);
            this.descrip.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Detalle de trabajo";
            // 
            // estado
            // 
            this.estado.Location = new System.Drawing.Point(16, 223);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(47, 24);
            this.estado.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Num Habitacion";
            // 
            // tipotrabajo
            // 
            this.tipotrabajo.FormattingEnabled = true;
            this.tipotrabajo.Location = new System.Drawing.Point(16, 98);
            this.tipotrabajo.Name = "tipotrabajo";
            this.tipotrabajo.Size = new System.Drawing.Size(121, 26);
            this.tipotrabajo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de trabajo";
            // 
            // idtra
            // 
            this.idtra.Location = new System.Drawing.Point(16, 37);
            this.idtra.Name = "idtra";
            this.idtra.Size = new System.Drawing.Size(100, 24);
            this.idtra.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID O.Trabajo";
            // 
            // Numhabitacion
            // 
            this.Numhabitacion.FormattingEnabled = true;
            this.Numhabitacion.Location = new System.Drawing.Point(14, 155);
            this.Numhabitacion.Name = "Numhabitacion";
            this.Numhabitacion.Size = new System.Drawing.Size(121, 26);
            this.Numhabitacion.TabIndex = 16;
            // 
            // RealizaOrdenTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 529);
            this.Controls.Add(this.panel1);
            this.Name = "RealizaOrdenTrabajo";
            this.Text = "RealizaOrdenTrabajo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idtra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tipotrabajo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Listar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.TextBox descrip;
        private System.Windows.Forms.Button habitacionesucias;
        private System.Windows.Forms.Button Ordenculminada;
        private System.Windows.Forms.ComboBox Numhabitacion;
    }
}