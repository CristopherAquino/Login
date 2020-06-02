using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Visual
{
    public class Datos
    {
        string BD = @"Data Source=DESKTOP-261MICJ\SQLEXPRESS;Initial Catalog=MyCompany;Integrated Security=True";
        public SqlConnection Conexion = new SqlConnection();


        public Datos()
        {
            Conexion.ConnectionString = BD;
        }

        public void abrir()
        {
            try
            {
                Conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Conexion a la base de datos");
            }
        }

        public void cerrar()
        {
            Conexion.Close();
        }
    }
}