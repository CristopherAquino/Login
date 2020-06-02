using Presentacion.Visual;
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

namespace Presentacion
{
    public partial class Admin : Form
    {
        public static string id;
        Datos conexion = new Datos();
        public Admin()
        {
            InitializeComponent();
        }

        //Mostrar tabla clientes
        private void InstanciaSingleton(object Formhijo)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void Admin_Data(object sender, EventArgs e)
        {
            FormClientes frm = FormClientes.ObtenerInstancia();
            InstanciaSingleton(frm);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            //aqui
            this.clientesTableAdapter.Fill(this.myCompanyDataSet.Clientes);
            try
            {
                conexion.abrir();
                this.clientesTableAdapter.Fill(this.myCompanyDataSet.Clientes);
                conexion.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombre.Text = dataGridView1.CurrentRow.Cells["nombreDataGridViewTextBoxColumn"].Value.ToString();
                txtApellidos.Text = dataGridView1.CurrentRow.Cells["apellidoDataGridViewTextBoxColumn"].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells["direccionDataGridViewTextBoxColumn"].Value.ToString();
                txtCiudad.Text = dataGridView1.CurrentRow.Cells["ciudadDataGridViewTextBoxColumn"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["emailDataGridViewTextBoxColumn"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["telefonoDataGridViewTextBoxColumn"].Value.ToString();
                txtOcupacion.Text = dataGridView1.CurrentRow.Cells["ocupacionDataGridViewTextBoxColumn"].Value.ToString();
                id = dataGridView1.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show("Selección" + x.ToString(), "Error");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir();
                SqlCommand sql = new SqlCommand("UPDATE Clientes SET Nombre = @Nombre, Apellido = @Apellido, Direccion = @Direccion, " +
                    "Ciudad = @Ciudad, Email = @Email, Telefono = @Telefono, Ocupacion = @Ocupacion  WHERE ID = @ID", conexion.Conexion);
                sql.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                sql.Parameters.AddWithValue("@Apellido", txtApellidos.Text);
                sql.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                sql.Parameters.AddWithValue("@Ciudad", txtCiudad.Text);
                sql.Parameters.AddWithValue("@Email", txtEmail.Text);
                sql.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                sql.Parameters.AddWithValue("@Ocupacion", txtOcupacion.Text);
                sql.Parameters.AddWithValue("@ID", id);
                sql.ExecuteNonQuery();
                MessageBox.Show("Datos Modificados");
                conexion.cerrar();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir();
                SqlCommand sql = new SqlCommand("DELETE FROM Clientes WHERE ID = @ID", conexion.Conexion);
                sql.Parameters.AddWithValue("@ID", id);
                sql.ExecuteNonQuery();
                MessageBox.Show("Datos Borrados");
                conexion.cerrar();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message);
            }
}
    }
}
