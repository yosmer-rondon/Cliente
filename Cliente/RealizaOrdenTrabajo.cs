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
using CapaLogica;

namespace Cliente
{
    public partial class RealizaOrdenTrabajo : Form
    {
        public RealizaOrdenTrabajo()
        {
            InitializeComponent();
            LlenarComboBoxdenumhabitacion();
            LlenarComboBoxdenombrestipo();
            listar();
            dataGridView1.Columns["nombretipo"].Visible = false;
            dataGridView1.Columns["numhabitacion"].Visible = false;
        }

        private void LlenarComboBoxdenumhabitacion()
        {
            try
            {
                List<entHabitacion> listarnumhab = logHabitacion.Instancia.obtenernumeroshabitacion();

                Numhabitacion.Items.Clear(); // Limpiar los ítems existentes

                foreach (var numha in listarnumhab)
                {
                    Numhabitacion.Items.Add(numha.numhabitacion.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los números de habitaciones: " + ex.Message);
            }
        }
        private void LlenarComboBoxdenombrestipo()
        {
            try
            {
                List<entTipoTrabajo> listartipos = logTipoTrabajo.Instancia.obtenernombrestipos();

                tipotrabajo.Items.Clear(); 

                foreach (var tipo in listartipos)
                {
                    tipotrabajo.Items.Add(tipo.nombre.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los números de habitaciones: " + ex.Message);
            }
        }
        public void listar()
        {
            dataGridView1.DataSource = logODtrabajo.Instancia.ListarOrdentrabajo();
        }
        private void LimpiarVariables()
        {
            idtra.Text = " ";
            descrip.Text = "";
            estado.Text = " ";
            tipotrabajo.Text = "";
            Numhabitacion.Text = "";
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            try
            {
                entODTrabajo c = new entODTrabajo();
                c.descripcion = descrip.Text.Trim() ;
                c.estado = estado.Text.Trim();
                c.nombretipo = tipotrabajo.Text.Trim();
                c.numhabitacion = int.Parse(Numhabitacion.Text.Trim());
                logODtrabajo.Instancia.Insertarordentrabajo(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listar();
        }

        private void Ordenculminada_Click(object sender, EventArgs e)
        {

        }

        private void Listar_Click(object sender, EventArgs e)
        {

        }
    }
}
