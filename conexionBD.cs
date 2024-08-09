using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace repasoJuaniFinalVargui
{   
    internal class conexionBD
    {
        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        string cadena;

        public conexionBD(string connectionString)
        {
            conexion = new OleDbConnection(connectionString);
        }

        public void abrirConexion()
        {
            try
            {
                if(conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cerrar la conexión: " + ex.Message);

            }
        }
        
        public conexionBD()
        {
            cadena = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./HELADITO.mdb;";
        }
        public void mostrarGustos(ComboBox cbGustos)
        {
            try
            {
                string query = "SELECT nombre + ' - ' + tipo AS SaborTipo FROM Gustos";
                OleDbCommand comando = new OleDbCommand(query, conexion);
                using (OleDbDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbGustos.Items.Add(reader["SaborTipo"].ToString());
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error al cargar" + ex.Message);
            }
        }
    }
}
