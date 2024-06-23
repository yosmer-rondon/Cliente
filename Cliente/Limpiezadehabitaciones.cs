using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//string connectionString = "Server=NombreDelServidor;Database=base_de_prueba;User Id=tu_usuario;Password=tu_contraseña;";


namespace Cliente
{


    public partial class Limpieza_de_habitaciones : Form
    {
        public Limpieza_de_habitaciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection()) //poner el connectionString
            {
                con.Open();
                string query = "INSERT INTO Habitaciones (TipoTrabajo, Personal, IDHabitacion, NombreEmpleado, Disponibilidad, EstadoHabitacion, EstadoOrden) VALUES (@TipoTrabajo, @Personal, @IDHabitacion, @NombreEmpleado, @Disponibilidad, @EstadoHabitacion, @EstadoOrden)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TipoTrabajo", comboBoxTipoTrabajo.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Personal", comboBoxPersonal.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@IDHabitacion", int.Parse(txtIDHabitacion.Text));
                    cmd.Parameters.AddWithValue("@NombreEmpleado", txtNombreEmpleado.Text);
                    cmd.Parameters.AddWithValue("@Disponibilidad", chkDisponibilidad.Checked);
                    cmd.Parameters.AddWithValue("@EstadoHabitacion", chkEstadoHabitacion.Checked);
                    cmd.Parameters.AddWithValue("@EstadoOrden", comboBoxEstadoOrden.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())//por el connectionString en los parentecis
            {
                con.Open();
                string query = "UPDATE Habitaciones SET TipoTrabajo = @TipoTrabajo, Personal = @Personal, NombreEmpleado = @NombreEmpleado, Disponibilidad = @Disponibilidad, EstadoHabitacion = @EstadoHabitacion, EstadoOrden = @EstadoOrden WHERE IDHabitacion = @IDHabitacion";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TipoTrabajo", comboBoxTipoTrabajo.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Personal", comboBoxPersonal.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@IDHabitacion", int.Parse(txtIDHabitacion.Text));
                    cmd.Parameters.AddWithValue("@NombreEmpleado", txtNombreEmpleado.Text);
                    cmd.Parameters.AddWithValue("@Disponibilidad", chkDisponibilidad.Checked);
                    cmd.Parameters.AddWithValue("@EstadoHabitacion", chkEstadoHabitacion.Checked);
                    cmd.Parameters.AddWithValue("@EstadoOrden", comboBoxEstadoOrden.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
