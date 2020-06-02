using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Presentacion;
using Presentacion.Visual;

namespace QFacture
{
    public partial class CapturarF : Form
    {
        Datos conexion = new Datos();
        public CapturarF()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == string.Empty || txtApellidos.Text == string.Empty || txtDireccion.Text == string.Empty || txtCiudad.Text == string.Empty || txtEmail.Text == string.Empty || txtTelefono.Text == string.Empty || txtOcupacion.Text == string.Empty)
                {
                    MessageBox.Show("Introduzca Todos Los Datos");
                }
                else
                {
                    conexion.abrir();
                    string query = string.Format("INSERT INTO Clientes (\"Nombre\", \"Apellido\", \"Direccion\", \"Ciudad\", \"Email\", \"Telefono\", \"Ocupacion\")" +
                         "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');", txtNombre.Text, txtApellidos.Text, txtDireccion.Text, txtCiudad.Text, txtEmail.Text, txtTelefono.Text, txtOcupacion.Text);

                    SqlCommand comando = new SqlCommand(query, conexion.Conexion);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Datos No Validos", "Datos");
            }
        }
    }
}
