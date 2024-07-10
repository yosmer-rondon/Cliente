namespace Cliente
{
    partial class RealizaOrdenReserva
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HABITACIONES = new System.Windows.Forms.DataGridView();
            this.CLIENTE = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numhabitacion = new System.Windows.Forms.ComboBox();
            this.metodopago = new System.Windows.Forms.ComboBox();
            this.fechasalida = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.estado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.costo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fechaentrada = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ID_reserva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RESERVA = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ID_cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HABITACIONES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RESERVA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.HABITACIONES);
            this.groupBox1.Controls.Add(this.CLIENTE);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numhabitacion);
            this.groupBox1.Controls.Add(this.metodopago);
            this.groupBox1.Controls.Add(this.fechasalida);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.estado);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.costo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.fechaentrada);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ID_reserva);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RESERVA);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ID_cliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 558);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RESERVA";
            // 
            // HABITACIONES
            // 
            this.HABITACIONES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HABITACIONES.Location = new System.Drawing.Point(422, 280);
            this.HABITACIONES.Name = "HABITACIONES";
            this.HABITACIONES.Size = new System.Drawing.Size(441, 116);
            this.HABITACIONES.TabIndex = 34;
            this.HABITACIONES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HABITACIONES_CellContentClick);
            // 
            // CLIENTE
            // 
            this.CLIENTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CLIENTE.Location = new System.Drawing.Point(422, 151);
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.Size = new System.Drawing.Size(441, 116);
            this.CLIENTE.TabIndex = 33;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(322, 492);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 55);
            this.button3.TabIndex = 32;
            this.button3.Text = "Habitaciones disponibles";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 40);
            this.button1.TabIndex = 31;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numhabitacion
            // 
            this.numhabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numhabitacion.FormattingEnabled = true;
            this.numhabitacion.Location = new System.Drawing.Point(17, 175);
            this.numhabitacion.Name = "numhabitacion";
            this.numhabitacion.Size = new System.Drawing.Size(154, 33);
            this.numhabitacion.TabIndex = 30;
            // 
            // metodopago
            // 
            this.metodopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.metodopago.FormattingEnabled = true;
            this.metodopago.Location = new System.Drawing.Point(19, 429);
            this.metodopago.Name = "metodopago";
            this.metodopago.Size = new System.Drawing.Size(198, 33);
            this.metodopago.TabIndex = 29;
            // 
            // fechasalida
            // 
            this.fechasalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechasalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.fechasalida.Location = new System.Drawing.Point(19, 356);
            this.fechasalida.Name = "fechasalida";
            this.fechasalida.Size = new System.Drawing.Size(200, 29);
            this.fechasalida.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 24);
            this.label10.TabIndex = 27;
            this.label10.Text = "fecha de salida";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Honeydew;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(452, 485);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 67);
            this.button5.TabIndex = 26;
            this.button5.Text = "Agregar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // estado
            // 
            this.estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.Location = new System.Drawing.Point(19, 499);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(162, 29);
            this.estado.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Estado";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Honeydew;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(560, 485);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(102, 67);
            this.button8.TabIndex = 3;
            this.button8.Text = "Anular Reserva";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Metodo de pago";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Honeydew;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(668, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "Buscar Reserva";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // costo
            // 
            this.costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costo.Location = new System.Drawing.Point(17, 235);
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(119, 29);
            this.costo.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Costo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "fecha de entrada";
            // 
            // fechaentrada
            // 
            this.fechaentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaentrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.fechaentrada.Location = new System.Drawing.Point(19, 294);
            this.fechaentrada.Name = "fechaentrada";
            this.fechaentrada.Size = new System.Drawing.Size(200, 29);
            this.fechaentrada.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 31);
            this.label5.TabIndex = 11;
            // 
            // ID_reserva
            // 
            this.ID_reserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_reserva.Location = new System.Drawing.Point(17, 61);
            this.ID_reserva.Name = "ID_reserva";
            this.ID_reserva.Size = new System.Drawing.Size(119, 29);
            this.ID_reserva.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID Reserva";
            // 
            // RESERVA
            // 
            this.RESERVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RESERVA.Location = new System.Drawing.Point(422, 19);
            this.RESERVA.Name = "RESERVA";
            this.RESERVA.Size = new System.Drawing.Size(441, 126);
            this.RESERVA.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Honeydew;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(776, 485);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 67);
            this.button4.TabIndex = 6;
            this.button4.Text = "Agregar cliente";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Num habitancion";
            // 
            // ID_cliente
            // 
            this.ID_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_cliente.Location = new System.Drawing.Point(17, 116);
            this.ID_cliente.Name = "ID_cliente";
            this.ID_cliente.Size = new System.Drawing.Size(193, 29);
            this.ID_cliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID cliente";
            // 
            // RealizaOrdenReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 557);
            this.Controls.Add(this.groupBox1);
            this.Name = "RealizaOrdenReserva";
            this.Text = "reservas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HABITACIONES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RESERVA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView RESERVA;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID_reserva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker fechaentrada;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox costo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker fechasalida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox numhabitacion;
        private System.Windows.Forms.ComboBox metodopago;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView CLIENTE;
        private System.Windows.Forms.DataGridView HABITACIONES;
    }
}