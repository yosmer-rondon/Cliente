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
using CapaEntidad;

namespace Cliente
{
    public partial class manHabitaciones : Form
    {

        public manHabitaciones()
        {
            InitializeComponent();
            listar();
            groupHabitacion.Enabled = false;
            textIDHabitacion.Enabled = false;

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
            groupHabitacion.Enabled = true;

            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;

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
            //insertar
            try
            {
                entHabitacion c = new entHabitacion();
                c.numhabitacion = int.Parse(numHabitacion.Text.Trim());
                c.piso = int.Parse(nudPiso.Text.Trim());
                c.capacidad = int.Parse(nudCapacidad.Text.Trim());
                c.costo = int.Parse(txtCosto.Text.Trim());
                c.estado = Estado.Text.Trim();
                c.nombre = TipoHabitacion.Text.Trim();
                logHabitacion.Instancia.InsertarHabitacion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupHabitacion.Enabled = false;
            listar();

        }

        private void LimpiarVariables()
        {
            numHabitacion.Text = "";
            nudPiso.Text = " ";
            nudCapacidad.Text = "";
            txtCosto.Text = "";
            Estado.Text = "";
            TipoHabitacion.Text = "";
            //cbkEstadoCliente.Checked = false;

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

                TipoHabitacion.Items.Clear(); // Limpiar los ítems existentes

                foreach (var tipohabitaciones in listaHabitacionesTipo)
                {
                    TipoHabitacion.Items.Add(tipohabitaciones.nombre.ToString());
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

