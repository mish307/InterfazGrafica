using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace InterfazGrafica
{
    public partial class Form1 : Form
    {
        ConexionBD bd = new ConexionBD();

        public Form1()
        {
            InitializeComponent();
            RefrescarTabla();

            // Vincular eventos
            btnGuardar.Click += BtnGuardar_Click;
            btnEliminar.Click += BtnEliminar_Click;
        }

        private void RefrescarTabla()
        {
            dgvDatos.DataSource = bd.ObtenerDatos("SELECT * FROM Usuarios");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text)) return;

            string query = "INSERT INTO Usuarios (Nombre, Detalle) VALUES (@nom, @det)";
            using (SqlConnection con = bd.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nom", txtNombre.Text);
                cmd.Parameters.AddWithValue("@det", txtDetalle.Text);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            txtNombre.Clear();
            txtDetalle.Clear();
            RefrescarTabla();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvDatos.CurrentRow.Cells["ID"].Value);
                string query = "DELETE FROM Usuarios WHERE ID = @id";
                using (SqlConnection con = bd.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                RefrescarTabla();
            }
        }
    }
}