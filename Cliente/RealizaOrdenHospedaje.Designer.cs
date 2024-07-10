namespace Cliente
{
    partial class RealizaOrdenHospedaje
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
            this.groupHospedaje = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.habitacion = new System.Windows.Forms.ComboBox();
            this.Estado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.metodopago = new System.Windows.Forms.ComboBox();
            this.fechasalida = new System.Windows.Forms.DateTimePicker();
            this.fechaentrada = new System.Windows.Forms.DateTimePicker();
            this.IDCliente = new System.Windows.Forms.TextBox();
            this.costo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.IDHospedaje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.groupHospedaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupHospedaje
            // 
            this.groupHospedaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupHospedaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupHospedaje.Controls.Add(this.button2);
            this.groupHospedaje.Controls.Add(this.habitacion);
            this.groupHospedaje.Controls.Add(this.Estado);
            this.groupHospedaje.Controls.Add(this.label8);
            this.groupHospedaje.Controls.Add(this.btnNuevo);
            this.groupHospedaje.Controls.Add(this.metodopago);
            this.groupHospedaje.Controls.Add(this.fechasalida);
            this.groupHospedaje.Controls.Add(this.fechaentrada);
            this.groupHospedaje.Controls.Add(this.IDCliente);
            this.groupHospedaje.Controls.Add(this.costo);
            this.groupHospedaje.Controls.Add(this.label7);
            this.groupHospedaje.Controls.Add(this.label6);
            this.groupHospedaje.Controls.Add(this.label5);
            this.groupHospedaje.Controls.Add(this.label4);
            this.groupHospedaje.Controls.Add(this.label3);
            this.groupHospedaje.Controls.Add(this.label1);
            this.groupHospedaje.Controls.Add(this.btnAgregar);
            this.groupHospedaje.Controls.Add(this.btnListar);
            this.groupHospedaje.Controls.Add(this.IDHospedaje);
            this.groupHospedaje.Controls.Add(this.label2);
            this.groupHospedaje.Controls.Add(this.dataGridView1);
            this.groupHospedaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupHospedaje.ForeColor = System.Drawing.Color.Black;
            this.groupHospedaje.Location = new System.Drawing.Point(1, 4);
            this.groupHospedaje.Name = "groupHospedaje";
            this.groupHospedaje.Size = new System.Drawing.Size(905, 572);
            this.groupHospedaje.TabIndex = 1;
            this.groupHospedaje.TabStop = false;
            this.groupHospedaje.Text = "HOSPEDAJE";
            this.groupHospedaje.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Peru;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 55);
            this.button2.TabIndex = 54;
            this.button2.Text = "Agregar Cliente";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // habitacion
            // 
            this.habitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitacion.FormattingEnabled = true;
            this.habitacion.Location = new System.Drawing.Point(178, 374);
            this.habitacion.Name = "habitacion";
            this.habitacion.Size = new System.Drawing.Size(121, 26);
            this.habitacion.TabIndex = 52;
            // 
            // Estado
            // 
            this.Estado.BackColor = System.Drawing.Color.PapayaWhip;
            this.Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.Location = new System.Drawing.Point(381, 438);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(135, 24);
            this.Estado.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Peru;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(378, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 18);
            this.label8.TabIndex = 50;
            this.label8.Text = "Estado";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Peru;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(152, 511);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(124, 55);
            this.btnNuevo.TabIndex = 49;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // metodopago
            // 
            this.metodopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metodopago.FormattingEnabled = true;
            this.metodopago.Location = new System.Drawing.Point(178, 438);
            this.metodopago.Name = "metodopago";
            this.metodopago.Size = new System.Drawing.Size(121, 26);
            this.metodopago.TabIndex = 47;
            this.metodopago.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // fechasalida
            // 
            this.fechasalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechasalida.Location = new System.Drawing.Point(560, 438);
            this.fechasalida.Name = "fechasalida";
            this.fechasalida.Size = new System.Drawing.Size(200, 24);
            this.fechasalida.TabIndex = 46;
            // 
            // fechaentrada
            // 
            this.fechaentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaentrada.Location = new System.Drawing.Point(560, 363);
            this.fechaentrada.Name = "fechaentrada";
            this.fechaentrada.Size = new System.Drawing.Size(200, 24);
            this.fechaentrada.TabIndex = 45;
            // 
            // IDCliente
            // 
            this.IDCliente.BackColor = System.Drawing.Color.PapayaWhip;
            this.IDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDCliente.Location = new System.Drawing.Point(11, 440);
            this.IDCliente.Name = "IDCliente";
            this.IDCliente.Size = new System.Drawing.Size(129, 24);
            this.IDCliente.TabIndex = 44;
            // 
            // costo
            // 
            this.costo.BackColor = System.Drawing.Color.PapayaWhip;
            this.costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costo.Location = new System.Drawing.Point(381, 374);
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(129, 24);
            this.costo.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Peru;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(561, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 18);
            this.label7.TabIndex = 40;
            this.label7.Text = "Fecha de salida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Peru;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(565, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Fecha de entrada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Peru;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "Mentodo de pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Peru;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Peru;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Habitacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "ID Cliente";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Peru;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(286, 511);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 55);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Peru;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(431, 511);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(124, 55);
            this.btnListar.TabIndex = 18;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // IDHospedaje
            // 
            this.IDHospedaje.BackColor = System.Drawing.Color.PapayaWhip;
            this.IDHospedaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDHospedaje.Location = new System.Drawing.Point(11, 376);
            this.IDHospedaje.Name = "IDHospedaje";
            this.IDHospedaje.Size = new System.Drawing.Size(129, 24);
            this.IDHospedaje.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Peru;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "ID_Hospedaje";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(852, 273);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // RealizaOrdenHospedaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 575);
            this.Controls.Add(this.groupHospedaje);
            this.Name = "RealizaOrdenHospedaje";
            this.Text = "Hospedaje";
            this.groupHospedaje.ResumeLayout(false);
            this.groupHospedaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupHospedaje;
        private System.Windows.Forms.TextBox IDHospedaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox metodopago;
        private System.Windows.Forms.DateTimePicker fechasalida;
        private System.Windows.Forms.DateTimePicker fechaentrada;
        private System.Windows.Forms.TextBox IDCliente;
        private System.Windows.Forms.TextBox costo;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox Estado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox habitacion;
        private System.Windows.Forms.Button button2;
    }
}