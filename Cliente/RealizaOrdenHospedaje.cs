using CapaEntidadd;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class RealizaOrdenHospedaje : Form
    {
        public RealizaOrdenHospedaje()
        {
            InitializeComponent();
            listar();
            LlenarComboBoxdemetodos();
            LlenarComboBoxdenumhabitacion();
        }

        public void listar()
        {
            dataGridView1.DataSource = logHospedaje.Instancia.ListarHospedaje();
            dataGridView1.Columns["nombre_metpago"].Visible = false;
            dataGridView1.Columns["num_habitacion"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RealizaOrdenReserva res = new RealizaOrdenReserva();
            res.Show();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                entHospedaje c = new entHospedaje();
                c.fecha_entrada = fechaentrada.Value;
                c.fecha_salida = fechasalida.Value;
                c.estado = Estado.Text.Trim();
                c.costo = double.Parse(costo.Text.Trim());
                c.id_cliente = int.Parse(IDCliente.Text.Trim());
                c.nombre_metpago = metodopago.Text.Trim();
                c.num_habitacion = int.Parse(habitacion.Text.Trim());
                logHospedaje.Instancia.InsertarHospedaje(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listar();
        }

    

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LlenarComboBoxdenumhabitacion()
        {
            try
            {
                List<entHabitacion> listarnumhab = logHabitacion.Instancia.obtenernumeroshabitacion();

                habitacion.Items.Clear(); // Limpiar los ítems existentes

                foreach (var numha in listarnumhab)
                {
                    habitacion.Items.Add(numha.numhabitacion.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los números de habitaciones: " + ex.Message);
            }
        }

        private void LimpiarVariables()
        {
            IDHospedaje.Text = " ";
            IDCliente.Text = "";
            costo.Text = " ";
            habitacion.Text = " ";
            costo.Text = " ";
            metodopago.Text = "";
            Estado.Text = "";
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            Mancliente manc = new Mancliente();
            manc.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }
    }
}
