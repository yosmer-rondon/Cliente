using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaEntidadd;
using CapaLogica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Cliente
{
    public partial class RealizaOrdenReserva : Form
    {
        public RealizaOrdenReserva()
        {
            InitializeComponent();
            LlenarComboBoxdemetodos();
            LlenarComboBoxdenumhabitacion();
            listar();
            ID_reserva.Enabled = false;
            buscarreserva.Enabled = false;
            RESERVA.Enabled = true;
            RESERVA.Visible = true;
            CLIENTE.Enabled = false;
            CLIENTE.Visible = false;
            HABITACIONES.Enabled = false;
            HABITACIONES.Visible = false;
        }
        public void listar()
        {
            RESERVA.DataSource = logODReserva.Instancia.ListarOrdenreserva();
            RESERVA.Columns["nombre_metpago"].Visible = false;
            RESERVA.Columns["num_habitacion"].Visible = false;
            RESERVA.Enabled = true;
            RESERVA.Visible = true;
        }
        private void LlenarComboBoxdemetodos()
        {
            try
            {
                List<entMetodoPago> listarmetodos = logMetodoPago.Instancia.obtenernombresmetodos();

                metodopago.Items.Clear(); // Limpiar los ítems existentes

                foreach (var metopago in listarmetodos)
                {
                    metodopago.Items.Add(metopago.nombre.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los números de habitaciones: " + ex.Message);
            }
        }
        private void LlenarComboBoxdenumhabitacion()
        {
            try
            {
                List<entHabitacion> listarnumhab = logHabitacion.Instancia.obtenernumeroshabitacion();

                numhabitacion.Items.Clear(); // Limpiar los ítems existentes

                foreach (var numha in listarnumhab)
                {
                    numhabitacion.Items.Add(numha.numhabitacion.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los números de habitaciones: " + ex.Message);
            }
        }
        private void LimpiarVariables()
        {
            ID_reserva.Text = " ";
            ID_cliente.Text = "";
            costo.Text = " ";
            estado.Text = " ";
            Descripcion.Text = " ";
            metodopago.Text = "";
            numhabitacion.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mancliente manc = new Mancliente();
            manc.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                entODReserva c = new entODReserva();
                c.fecha_entrada = fechaentrada.Value;
                c.fecha_salida = fechasalida.Value;
                c.estado = estado.Text.Trim();
                c.descripcion= Descripcion.Text.Trim();
                c.costo = double.Parse(costo.Text.Trim());
                c.idCliente = int.Parse(ID_cliente.Text.Trim());
                c.nombre_metpago = metodopago.Text.Trim();
                c.num_habitacion = int.Parse(numhabitacion.Text.Trim());
                logODReserva.Instancia.Insertarordenreserva(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listar();
            RESERVA.Enabled = true;
            RESERVA.Visible = true;
            CLIENTE.Enabled = false;
            CLIENTE.Visible = false;
            HABITACIONES.Enabled = false;
            HABITACIONES.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RESERVA.Enabled = false;
            RESERVA.Visible = false;
            CLIENTE.Enabled = true;
            CLIENTE.Visible = true;
            HABITACIONES.Enabled = false;
            HABITACIONES.Visible = false;
            try
            {
                int idcliente = int.Parse(ID_cliente.Text.Trim());
                List<entCliente> cliente = logCliente.Instancia.buscarclienteporid(idcliente);

                CLIENTE.DataSource = cliente;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void HABITACIONES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void listarclientes_Click(object sender, EventArgs e)
        {
            RESERVA.Enabled = false;
            RESERVA.Visible = false;
            CLIENTE.Enabled = true;
            CLIENTE.Visible = true;
            HABITACIONES.Enabled = false;
            HABITACIONES.Visible = false;
            CLIENTE.DataSource = logCliente.Instancia.ListarCliente();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RESERVA.Enabled = false;
            RESERVA.Visible = false;
            CLIENTE.Enabled = false;
            CLIENTE.Visible = false;
            HABITACIONES.Enabled = true;
            HABITACIONES.Visible = true;
            HABITACIONES.DataSource = logHabitacion.Instancia.habitaciondispobibles();
        }

        private void CLIENTE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = CLIENTE.Rows[e.RowIndex];
            ID_cliente.Text = filaActual.Cells[0].Value.ToString();
        }

        private void HABITACIONES_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void HABITACIONES_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = HABITACIONES.Rows[e.RowIndex];
            numhabitacion.Text = filaActual.Cells[1].Value.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ID_reserva.Enabled = true;
            buscarreserva.Enabled = true;
        }

        private void RESERVA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = RESERVA.Rows[e.RowIndex];
            ID_reserva.Text = filaActual.Cells[0].Value.ToString();
            ID_cliente.Text = filaActual.Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                int idReserva = int.Parse(ID_reserva.Text.Trim());
                logODReserva.Instancia.CulminarReserva(idReserva);

                MessageBox.Show("Reserva culminada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al culminar la reserva: " + ex.Message);
            }
            listar();
        }

        private void CLIENTE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void costo_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
