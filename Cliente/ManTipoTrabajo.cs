using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class ManTipoTrabajo : Form
    {
        public ManTipoTrabajo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManTipoTrabajo_Load(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
             string tipoTrabajo = comboBoxtipodetrabajo.SelectedItem.ToString();
             string descripcion = textBoxDescripcionTrabajo.Text;

            InsertarRegistro(nombre, tipoTrabajo, descripcion);

            ActualizarDataGridView();

        }
        private void InsertarRegistro(string nombre, string tipoTrabajo, string descripcion)
        {
            // Aquí deberías usar tu conexión a la base de datos
            string connectionString = "tu cadena de conexión";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO TuTabla (Nombre, TipoTrabajo, Descripcion) VALUES (@Nombre, @TipoTrabajo, @Descripcion)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@TipoTrabajo", tipoTrabajo);
                command.Parameters.AddWithValue("@Descripcion", descripcion);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el registro: " + ex.Message);
                }
            }
        }
        private void ActualizarDataGridView()
        {
            // Aquí puedes cargar nuevamente los datos desde la base de datos al dataGridView1
            // Por ejemplo, podrías usar un SqlDataAdapter o Entity Framework para esta tarea
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            string nombre = textBoxNombre.Text;
            string tipoTrabajo = comboBoxtipodetrabajo.SelectedItem.ToString();
            string descripcion = textBoxDescripcionTrabajo.Text;

            ActualizarRegistro(id, nombre, tipoTrabajo, descripcion);

            ActualizarDataGridView();

        }
        private void ActualizarRegistro(int id, string nombre, string tipoTrabajo, string descripcion)
        {
            // Aquí deberías usar tu conexión a la base de datos
            string connectionString = "tu cadena de conexión";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE TuTabla SET Nombre = @Nombre, TipoTrabajo = @TipoTrabajo, Descripcion = @Descripcion WHERE ID = @ID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@TipoTrabajo", tipoTrabajo);
                command.Parameters.AddWithValue("@Descripcion", descripcion);
                command.Parameters.AddWithValue("@ID", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                }
            }
        }

        private void buttonLista_Click(object sender, EventArgs e)
        {
            //carga los datos registrados 
            CargarDatos();
        }
        private void CargarDatos()
        {
            // Aquí deberías usar tu conexión a la base de datos
            string connectionString = "tu cadena de conexión";
            string query = "SELECT ID, Nombre, TipoTrabajo, Descripcion FROM TuTabla";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            EliminarRegistro(id);
            ActualizarDataGridView();
        }
        private void EliminarRegistro(int id)
        {
            // Aquí deberías usar tu conexión a la base de datos
            string connectionString = "tu cadena de conexión";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM TuTabla WHERE ID = @ID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
            }
        }


    }
}
