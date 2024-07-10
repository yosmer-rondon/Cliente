using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaEntidadd;
using CapaLogica;

namespace Cliente
{
    public partial class RealizaOrdenReserva : Form
    {
        public RealizaOrdenReserva()
        {
            InitializeComponent();
            LlenarComboBoxdemetodos();
            RESERVA.Enabled = true;
            RESERVA.Visible = true;
            CLIENTE.Enabled = false;
            CLIENTE.Visible = false;
            HABITACIONES.Enabled = false;
            HABITACIONES.Visible = false;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            CLIENTE.DataSource = logCliente.Instancia.ListarCliente();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HABITACIONES.DataSource = logHabitacion.Instancia.habitaciondispobibles();
        }
    }
}
