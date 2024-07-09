using CapaDatos;
using CapaEntidad;
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
    public partial class ManMetodoDePago : Form
    {
        public ManMetodoDePago()
        {
            InitializeComponent();
            listar();
        }
        public void listar()
        {
            dgvMetodoPago.DataSource = logMetodoPago.Instancia.Listarmetodopago();
        }
        private void LimpiarVariables()
        {
            nombre.Text = "";
            descripcion.Text = " ";
            estado.Text = " ";
        }

        private void ManMetodoPago_Load(object sender, EventArgs e)
        {
        
        }
        private void dgvMetodoPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago mep = new entMetodoPago();
                mep.nombre = nombre.Text.Trim();
                mep.descripcion = descripcion.Text.Trim();
                mep.estado = estado.Text.Trim();
                logMetodoPago.Instancia.Insertarmetodopago(mep);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago c = new entMetodoPago();
                c.IDMetodopago = int.Parse(txtId.Text.Trim());
                c.nombre = nombre.Text.Trim();
                c.descripcion = descripcion.Text.Trim();
                c.estado = estado.Text.Trim();
                logMetodoPago.Instancia.Editarmetodopago(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listar();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {


        }

        private void dgvMetodoPago_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMetodoPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMetodoPago.Rows[e.RowIndex]; //
            txtId.Text = filaActual.Cells[0].Value.ToString();
            nombre.Text = filaActual.Cells[1].Value.ToString();
            descripcion.Text = filaActual.Cells[2].Value.ToString();
            estado.Text = filaActual.Cells[3].Value.ToString();
        }
    }
}
