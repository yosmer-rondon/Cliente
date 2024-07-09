using CapaDatos;
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
using CapaEntidadd;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cliente
{
    public partial class manHabitaciones : Form
    {

        public manHabitaciones()
        {
            InitializeComponent();
            listar();
        }

        public void listar()
        {
            dgvHabitaciones.DataSource = logHabitacion.Instancia.ListarHabitacion();
        }


        private void LimpiarControles()
        {

        }

        private void ListarTiposHabitacion()
        {

        }

        private void HabilitarControles(int estado)
        {

        }

        private void ListarHabitaciones()
        {
        }

        private void VincularControles(entHabitacion habitacion)
        {

        }

        private void manHabitaciones_Load(object sender, EventArgs e)
        {

        }

        private void dgvHabitaciones_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
          

           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void txtCosto_Validated(object sender, EventArgs e)
        {

        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnsPrincipal_EnabledChanged(object sender, EventArgs e)
        {

        }


        private void tipohabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LlenarComboBoxHabitaciones()
        {
            try
            {
                List<entTipoHabitacion> listaHabitacionesTipo = logTipoHabitacion.Instancia.nombrestipohabitacion();

                tipohabitacion.Items.Clear(); // Limpiar los ítems existentes

                foreach (var tipohabitaciones in listaHabitacionesTipo)
                {
                    tipohabitacion.Items.Add(tipohabitaciones.nombre.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los números de habitaciones: " + ex.Message);
            }
        }

        private void dgvHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

