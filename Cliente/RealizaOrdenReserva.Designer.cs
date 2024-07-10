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
            this.HABITACIONES = new System.Windows.Forms.DataGridView();
            this.CLIENTE = new System.Windows.Forms.DataGridView();
            this.habitaciondisponible = new System.Windows.Forms.Button();
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
            this.buscarreserva = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listarclientes = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.HABITACIONES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RESERVA)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HABITACIONES
            // 
            this.HABITACIONES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HABITACIONES.Location = new System.Drawing.Point(479, 268);
            this.HABITACIONES.Name = "HABITACIONES";
            this.HABITACIONES.Size = new System.Drawing.Size(441, 116);
            this.HABITACIONES.TabIndex = 34;
            this.HABITACIONES.CellBorderStyleChanged += new System.EventHandler(this.HABITACIONES_CellBorderStyleChanged);
            this.HABITACIONES.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HABITACIONES_CellClick);
            this.HABITACIONES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HABITACIONES_CellContentClick);
            // 
            // CLIENTE
            // 
            this.CLIENTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CLIENTE.Location = new System.Drawing.Point(479, 149);
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.Size = new System.Drawing.Size(441, 116);
            this.CLIENTE.TabIndex = 33;
            this.CLIENTE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CLIENTE_CellClick);
            // 
            // habitaciondisponible
            // 
            this.habitaciondisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitaciondisponible.Location = new System.Drawing.Point(755, 403);
            this.habitaciondisponible.Name = "habitaciondisponible";
            this.habitaciondisponible.Size = new System.Drawing.Size(124, 46);
            this.habitaciondisponible.TabIndex = 32;
            this.habitaciondisponible.Text = "Habitaciones disponibles";
            this.habitaciondisponible.UseVisualStyleBackColor = true;
            this.habitaciondisponible.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 27);
            this.button1.TabIndex = 31;
            this.button1.Text = "Buscar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numhabitacion
            // 
            this.numhabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numhabitacion.FormattingEnabled = true;
            this.numhabitacion.Location = new System.Drawing.Point(11, 149);
            this.numhabitacion.Name = "numhabitacion";
            this.numhabitacion.Size = new System.Drawing.Size(154, 26);
            this.numhabitacion.TabIndex = 30;
            // 
            // metodopago
            // 
            this.metodopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metodopago.FormattingEnabled = true;
            this.metodopago.Location = new System.Drawing.Point(13, 403);
            this.metodopago.Name = "metodopago";
            this.metodopago.Size = new System.Drawing.Size(198, 26);
            this.metodopago.TabIndex = 29;
            // 
            // fechasalida
            // 
            this.fechasalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechasalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.fechasalida.Location = new System.Drawing.Point(13, 330);
            this.fechasalida.Name = "fechasalida";
            this.fechasalida.Size = new System.Drawing.Size(200, 24);
            this.fechasalida.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 18);
            this.label10.TabIndex = 27;
            this.label10.Text = "fecha de salida";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Honeydew;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(269, 649);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 67);
            this.button5.TabIndex = 26;
            this.button5.Text = "Agregar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // estado
            // 
            this.estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.Location = new System.Drawing.Point(13, 466);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(162, 24);
            this.estado.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Estado";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Honeydew;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(150, 649);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(102, 67);
            this.button8.TabIndex = 3;
            this.button8.Text = "Anular Reserva";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Metodo de pago";
            // 
            // buscarreserva
            // 
            this.buscarreserva.BackColor = System.Drawing.Color.Honeydew;
            this.buscarreserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarreserva.Location = new System.Drawing.Point(236, 35);
            this.buscarreserva.Name = "buscarreserva";
            this.buscarreserva.Size = new System.Drawing.Size(144, 29);
            this.buscarreserva.TabIndex = 2;
            this.buscarreserva.Text = "Buscar Reserva";
            this.buscarreserva.UseVisualStyleBackColor = false;
            // 
            // costo
            // 
            this.costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costo.Location = new System.Drawing.Point(11, 209);
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(119, 29);
            this.costo.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Costo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "fecha de entrada";
            // 
            // fechaentrada
            // 
            this.fechaentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaentrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.fechaentrada.Location = new System.Drawing.Point(13, 268);
            this.fechaentrada.Name = "fechaentrada";
            this.fechaentrada.Size = new System.Drawing.Size(200, 24);
            this.fechaentrada.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1038, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 11;
            // 
            // ID_reserva
            // 
            this.ID_reserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_reserva.Location = new System.Drawing.Point(11, 35);
            this.ID_reserva.Name = "ID_reserva";
            this.ID_reserva.Size = new System.Drawing.Size(119, 24);
            this.ID_reserva.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID Reserva";
            // 
            // RESERVA
            // 
            this.RESERVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RESERVA.Location = new System.Drawing.Point(479, 20);
            this.RESERVA.Name = "RESERVA";
            this.RESERVA.Size = new System.Drawing.Size(441, 126);
            this.RESERVA.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Honeydew;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(388, 649);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Num habitancion";
            // 
            // ID_cliente
            // 
            this.ID_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_cliente.Location = new System.Drawing.Point(11, 90);
            this.ID_cliente.Name = "ID_cliente";
            this.ID_cliente.Size = new System.Drawing.Size(193, 24);
            this.ID_cliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID cliente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Descripcion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.listarclientes);
            this.panel1.Controls.Add(this.ID_reserva);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.CLIENTE);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.RESERVA);
            this.panel1.Controls.Add(this.HABITACIONES);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.buscarreserva);
            this.panel1.Controls.Add(this.costo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.habitaciondisponible);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.fechaentrada);
            this.panel1.Controls.Add(this.ID_cliente);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numhabitacion);
            this.panel1.Controls.Add(this.estado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.metodopago);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.fechasalida);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 729);
            this.panel1.TabIndex = 35;
            // 
            // listarclientes
            // 
            this.listarclientes.Location = new System.Drawing.Point(595, 403);
            this.listarclientes.Name = "listarclientes";
            this.listarclientes.Size = new System.Drawing.Size(129, 46);
            this.listarclientes.TabIndex = 35;
            this.listarclientes.Text = "Listar clientes";
            this.listarclientes.UseVisualStyleBackColor = true;
            this.listarclientes.Click += new System.EventHandler(this.listarclientes_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Honeydew;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(16, 649);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 67);
            this.button3.TabIndex = 36;
            this.button3.Text = "Activar Buscar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Descripcion";
            // 
            // Descripcion
            // 
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(13, 528);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(162, 24);
            this.Descripcion.TabIndex = 38;
            // 
            // RealizaOrdenReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 728);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Name = "RealizaOrdenReserva";
            this.Text = "reservas";
            ((System.ComponentModel.ISupportInitialize)(this.HABITACIONES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLIENTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RESERVA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView RESERVA;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID_reserva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buscarreserva;
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
        private System.Windows.Forms.Button habitaciondisponible;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView CLIENTE;
        private System.Windows.Forms.DataGridView HABITACIONES;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button listarclientes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.Label label3;
    }
}