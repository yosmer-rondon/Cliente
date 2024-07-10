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
using CapaEntidadd;
using CapaLogica;

namespace Cliente
{
    public partial class RealizaOrdenReserva : Form
    {
        public RealizaOrdenReserva()
        {
            InitializeComponent();
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
        {/*
            try
            {
                int idEmpleado = int.Parse(ID_empleado.Text.Trim());
                List<entEmpleado> empleados = LogEmpleado.Instancia.BuscarEmpleadoPorId(idEmpleado);

                dgvEmpleado.DataSource = empleados;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }*/
        }

        private void HABITACIONES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
