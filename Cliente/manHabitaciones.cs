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
using System.Net;

namespace Cliente
{
    public partial class manHabitaciones : Form
    {

        public manHabitaciones()
        {
            InitializeComponent();
            groupHabitacion.Enabled = false;
            LlenarComboBoxHabitaciones();
            

        }

        public void listar()
        {
            dgvHabitaciones.DataSource = logHabitacion.Instancia.ListarHabitacion();
            dgvHabitaciones.Columns["nombre"].Visible = false;
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
            btnBuscar.Visible = false;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupHabitacion.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
            btnBuscar.Visible = false;

        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entHabitacion c = new entHabitacion();

                c.id = int.Parse(textIDHabitacion.Text.Trim());
                logHabitacion.Instancia.DeshabilitarHabitacion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entHabitacion c = new entHabitacion();
                c.numhabitacion = int.Parse(numHabitacion.Text.Trim());
                c.piso = int.Parse(nudPiso.Text.Trim());
                c.capacidad = int.Parse(nudCapacidad.Text.Trim());
                c.costo = double.Parse(txtCosto.Text.Trim());
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

        private void dgvHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgvHabitaciones.Rows[e.RowIndex];
                textIDHabitacion.Text = filaActual.Cells[0].Value.ToString();
                numHabitacion.Text = filaActual.Cells[1].Value.ToString();
                nudPiso.Text = filaActual.Cells[2].Value.ToString();
                nudCapacidad.Text = filaActual.Cells[3].Value.ToString();
                txtCosto.Text = filaActual.Cells[4].Value.ToString();
                Estado.Text = filaActual.Cells[5].Value.ToString();
                int id = int.Parse(filaActual.Cells[7].Value.ToString());

                // Obtener el nombre del tipo de empleado
                List<entTipoHabitacion> tipoHabitacionList = logTipoHabitacion.Instancia.bucarnombreconidtipohabitacion(id);
                if (tipoHabitacionList.Count > 0)
                {
                    string nombreTipoHabitacion = tipoHabitacionList[0].nombre;

                    // Limpiar y seleccionar el nombre del tipo de empleado en el ComboBox
                    TipoHabitacion.SelectedIndex = -1; // Deseleccionar cualquier ítem seleccionado previamente
                    for (int i = 0; i < TipoHabitacion.Items.Count; i++)
                    {
                        if (TipoHabitacion.Items[i].ToString() == nombreTipoHabitacion)
                        {
                            TipoHabitacion.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                entHabitacion c = new entHabitacion();
                c.id = int.Parse(textIDHabitacion.Text.Trim());
                c.numhabitacion = int.Parse(numHabitacion.Text.Trim());
                c.piso = int.Parse(nudPiso.Text.Trim());
                c.capacidad = int.Parse(nudCapacidad.Text.Trim());
                c.costo = double.Parse(txtCosto.Text.Trim());
                c.estado = Estado.Text.Trim();
                c.nombre = TipoHabitacion.Text.Trim();
                logHabitacion.Instancia.EditarHabitacion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupHabitacion.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textIDHabitacion.Text.Trim());
                List<entHabitacion> Habitaciones = logHabitacion.Instancia.BuscarHabitacionPorId(id);

                dgvHabitaciones.DataSource = Habitaciones;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupHabitacion.Enabled = true;
            btnModificar.Visible = false;
            btnAgregar.Visible = false;
            btnBuscar.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listar();
        }
    }

}

