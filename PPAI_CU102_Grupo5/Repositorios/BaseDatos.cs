using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_CU102_Grupo5.Repositorios
{
    public class BaseDatos
    {
        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();


        //Abre la conexion con el servidor
        private void conectar()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.ConnectionString = "Data Source=DESKTOP-FDKI1R8\\SQLEXPRESS;Initial Catalog=museo;Integrated Security=True";
                Conexion.Open();
                Cmd.Connection = Conexion;
                Cmd.CommandType = System.Data.CommandType.Text;
             
            }
        }

        //Envia una consulta sql al servidor
        public DataTable consulta(string sql)
        {
            conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            try
            {
                tabla.Load(Cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                MessageBox.Show("Error con la Base de Datos" + "\n"
                                + "En el comando:" + "\n"
                                + sql + "\n"
                                + "El mensaje es:" + "\n"
                                + e.Message);
                Console.WriteLine(sql);
            }
            desconectar();
            return tabla;
        }


        public void desconectar()
        {
                Conexion.Close();
     
        }
    }
}
