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
using CapaEntidad;

namespace Cliente
{
    public partial class manHabitaciones : Form
    {
        private logHabitacion logHabitacion = null;
        private List<entHabitacion> listaHabitaciones = null;

        public manHabitaciones()
        {
            InitializeComponent();
        }

        private void LimpiarControles()
        {
            dgvHabitaciones.ClearSelection();
            txtID.Clear();
            nudPiso.Value = 0;
            cboTipo.SelectedIndex = -1;
            chkEstado.Checked = false;
            nudCapacidad.Value = 1;
            txtCosto.Text = "0.00";
        }

        private void ListarTiposHabitacion()
        {
            cboTipo.DataSource = logTipoHabitacion.Instancia.ListarTipoHabitacion();
            cboTipo.SelectedIndex = -1;
        }

        /// <summary>
        /// Método para Habilitar Controles
        /// </summary>
        /// <param name="estado">
        /// -1: Inicial
        /// 0: Nuevo
        /// 1: Editar
        /// 2: 
        /// </param>
        private void HabilitarControles(int estado)
        {
            switch(estado)
            {
                case -1:
                    LimpiarControles();

                    dgvHabitaciones.Enabled = true;
                    btnNueva.Enabled = true;
                    btnEditar.Enabled = true;
                    btnDeshabilitar.Enabled = true;
                    btnModificar.Enabled = true;

                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnCancelar.Enabled = false;
                    txtID.Enabled = false;
                    nudPiso.Enabled = false;
                    cboTipo.Enabled = false;
                    chkEstado.Enabled = false;
                    nudCapacidad.Enabled = false;
                    txtCosto.Enabled = false;
                    break;
                case 0:
                    LimpiarControles();

                    dgvHabitaciones.Enabled = false;
                    btnNueva.Enabled = false;
                    btnEditar.Enabled = false;
                    btnDeshabilitar.Enabled = false;
                    btnModificar.Enabled = false;
                    txtID.Enabled = false;

                    btnCancelar.Enabled = true;
                    btnAgregar.Enabled = true;
                    nudPiso.Enabled = true;
                    cboTipo.Enabled = true;
                    chkEstado.Enabled = true;
                    nudCapacidad.Enabled = true;
                    txtCosto.Enabled = true;
                    break;
                case 1:
                    dgvHabitaciones.Enabled = false;
                    btnNueva.Enabled = false;
                    btnEditar.Enabled = false;
                    btnDeshabilitar.Enabled = false;
                    btnAgregar.Enabled = false;
                    txtID.Enabled = false;

                    btnCancelar.Enabled = true;
                    btnModificar.Enabled = true;
                    nudPiso.Enabled = true;
                    cboTipo.Enabled = true;
                    chkEstado.Enabled = true;
                    nudCapacidad.Enabled = true;
                    txtCosto.Enabled = true;
                    break;
            }
        }

        private void ListarHabitaciones()
        {
            listaHabitaciones = logHabitacion.ListarHabitacion();
            dgvHabitaciones.DataSource = listaHabitaciones;
        }

        private void VincularControles(entHabitacion habitacion)
        {
            txtID.Text = habitacion.ID.ToString();
            nudPiso.Value = habitacion.Piso;
            cboTipo.SelectedValue = habitacion.IDTipo;
            chkEstado.Checked = habitacion.Estado;
            nudCapacidad.Value = habitacion.Capacidad;
            txtCosto.Text = habitacion.Costo.ToString("N2");
        }

        private void manHabitaciones_Load(object sender, EventArgs e)
        {
            cboTipo.ValueMember = "IDTipoHabitacion";
            cboTipo.DisplayMember = "Nombre";
            ListarTiposHabitacion();

            logHabitacion = new logHabitacion();

            ListarHabitaciones();
        }

        private void dgvHabitaciones_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                VincularControles(listaHabitaciones[e.RowIndex]);
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            HabilitarControles(0);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvHabitaciones.DataSource == null || dgvHabitaciones.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Debe de Seleccionar el Registro a Editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HabilitarControles(1);
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (dgvHabitaciones.DataSource == null || dgvHabitaciones.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Debe de Seleccionar el Registro a Deshabilitar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            entHabitacion habitacionSeleccionada = listaHabitaciones[dgvHabitaciones.SelectedCells[0].RowIndex];

            if (habitacionSeleccionada.Estado == false)
            {
                MessageBox.Show("El Registro a Deshabilitar ya se encuentra Deshabilitado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool modificacion = logHabitacion.DeshabilitarHabitacion(habitacionSeleccionada.ID);

            if (modificacion)
            {
                MessageBox.Show("Se deshabilitó la Habitación correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HabilitarControles(-1);
                ListarHabitaciones();
            }
            else
                MessageBox.Show("Hubo un Error en la deshabilitación, intentar nuevamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboTipo.SelectedItem == null)
            {
                MessageBox.Show("Debe de seleccionar un Tipo de Habitación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTipo.Focus();
                return;
            }

            txtCosto_Validated(null, EventArgs.Empty);

            if (string.IsNullOrWhiteSpace(txtCosto.Text) || txtCosto.Text.Equals("0.00"))
            {
                MessageBox.Show("Debe de ingresar un Precio para la Habitación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCosto.Focus();
                return;
            }

            bool insercion = logHabitacion.InsertarHabitacion(new entHabitacion
            {
                Piso = (int)nudPiso.Value,
                IDTipo = Convert.ToInt32(cboTipo.SelectedValue.ToString()),
                Capacidad = (int)nudCapacidad.Value,
                Costo = decimal.Parse(txtCosto.Text),
                Estado = chkEstado.Checked
            });

            if (insercion)
            {
                MessageBox.Show("Se insertó la Habitación correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HabilitarControles(-1);
                ListarHabitaciones();
            }
            else
                MessageBox.Show("Hubo un Error en la inserción, intentar nuevamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cboTipo.SelectedItem == null)
            {
                MessageBox.Show("Debe de seleccionar un Tipo de Habitación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTipo.Focus();
                return;
            }

            txtCosto_Validated(null, EventArgs.Empty);

            if (string.IsNullOrWhiteSpace(txtCosto.Text) || txtCosto.Text.Equals("0.00"))
            {
                MessageBox.Show("Debe de ingresar un Precio para la Habitación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCosto.Focus();
                return;
            }

            bool edicion = logHabitacion.EditarHabitacion(new entHabitacion
            {
                ID = Convert.ToInt32(txtID.Text.Trim()),
                Piso = (int)nudPiso.Value,
                IDTipo = Convert.ToInt32(cboTipo.SelectedValue.ToString()),
                Capacidad = (int)nudCapacidad.Value,
                Costo = decimal.Parse(txtCosto.Text),
                Estado = chkEstado.Checked
            });

            if (edicion)
            {
                MessageBox.Show("Se editó la Habitación correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HabilitarControles(-1);
                ListarHabitaciones();
            }
            else
                MessageBox.Show("Hubo un Error en la edición, intentar nuevamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControles(-1);
            dgvHabitaciones.Focus();
        }

        private void txtCosto_Validated(object sender, EventArgs e)
        {
            decimal valor = decimal.Zero;
            decimal.TryParse(txtCosto.Text.Trim(), out valor);
            txtCosto.Text = valor.ToString("N2");
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar))
                { e.Handled = true; }
        }

        private void btnsPrincipal_EnabledChanged(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn == null)
                return;

            btn.ForeColor = btn.Enabled ? Color.Black : Color.White;
        }
    }
}
