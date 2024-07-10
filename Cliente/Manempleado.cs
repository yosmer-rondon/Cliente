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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cliente
{
    public partial class Manempleado : Form
    {
        public Manempleado()
        {
            InitializeComponent();
            LlenarComboBoxdetipos();
            listar();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado c = new entEmpleado();
                c.nombre = nombre.Text.Trim();
                c.apellidos = apellidos.Text.Trim();
                c.direccion = direccion.Text.Trim();
                c.Telefono = int.Parse(telefono.Text.Trim());
                c.correo = correo.Text.Trim();
                c.dni = int.Parse(dni.Text.Trim());
                c.estado = estado.Text.Trim();
                c.nombre_tipo = nombretipo.Text.Trim();

                LogEmpleado.Instancia.InsertarEmpleado(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listar();
        
        }
        private void LimpiarVariables()
        {
            ID_empleado.Text = "";
            nombre.Text = "";
            apellidos.Text = "";
            direccion.Text = " ";
            telefono.Text = " ";
            correo.Text = " ";
            dni.Text = " ";
            estado.Text = "";
            telefono.Text = " ";
            nombretipo.Text = "";
            
        }
        public void listar()
        {
            dgvEmpleado.DataSource = LogEmpleado.Instancia.ListarEmpleado();
            dgvEmpleado.Columns["nombre_tipo"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Manempleado_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int idEmpleado = int.Parse(ID_empleado.Text.Trim());
                List<entEmpleado> empleados = LogEmpleado.Instancia.BuscarEmpleadoPorId(idEmpleado);

                dgvEmpleado.DataSource = empleados;
            

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow filaActual = dgvEmpleado.Rows[e.RowIndex];
                ID_empleado.Text = filaActual.Cells[0].Value.ToString();
                nombre.Text = filaActual.Cells[1].Value.ToString();
                apellidos.Text = filaActual.Cells[2].Value.ToString();
                direccion.Text = filaActual.Cells[3].Value.ToString();
                telefono.Text = filaActual.Cells[4].Value.ToString();
                correo.Text = filaActual.Cells[5].Value.ToString();
                dni.Text = filaActual.Cells[6].Value.ToString();
                estado.Text = filaActual.Cells[7].Value.ToString();
                int idTipoEmpleado = int.Parse(filaActual.Cells[8].Value.ToString());

                // Obtener el nombre del tipo de empleado
                List<entTipoEmpleado> tipoEmpleadoList = logTipoEmpleado.Instancia.bucarnombresconidtipo(idTipoEmpleado);
                if (tipoEmpleadoList.Count > 0)
                {
                    string nombreTipoEmpleado = tipoEmpleadoList[0].nombre;

                    // Limpiar y seleccionar el nombre del tipo de empleado en el ComboBox
                    nombretipo.SelectedIndex = -1; // Deseleccionar cualquier ítem seleccionado previamente
                    for (int i = 0; i < nombretipo.Items.Count; i++)
                    {
                        if (nombretipo.Items[i].ToString() == nombreTipoEmpleado)
                        {
                            nombretipo.SelectedIndex = i;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado c = new entEmpleado();
                c.Idempleado = int.Parse(ID_empleado.Text.Trim());
                c.nombre = nombre.Text.Trim();
                c.apellidos = apellidos.Text.Trim();
                c.direccion = direccion.Text.Trim();
                c.Telefono = int.Parse(telefono.Text.Trim());
                c.correo = correo.Text.Trim();
                c.dni = int.Parse(dni.Text.Trim());
                c.estado = estado.Text.Trim();
                c.nombre_tipo = nombretipo.Text.Trim();
                LogEmpleado.Instancia.EditarEmpleado(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listar();

        }
        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LlenarComboBoxdetipos()
        {
            try
            {
                List<entTipoEmpleado> listartipos = logTipoEmpleado.Instancia.listarnombrestipos();

                nombretipo.Items.Clear(); // Limpiar los ítems existentes

                foreach (var tipoEmpleado in listartipos)
                {
                    nombretipo.Items.Add(tipoEmpleado.nombre.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los números de habitaciones: " + ex.Message);
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado c = new entEmpleado();

                c.Idempleado = int.Parse(ID_empleado.Text.Trim());
                LogEmpleado.Instancia.Deshabilitarempleado(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listar();
        }
    }
}
