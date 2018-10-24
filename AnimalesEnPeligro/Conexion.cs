using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace AnimalesEnPeligro
{
    class Conexion
    {
        public static SqlConnection conn = new SqlConnection("Initial Catalog=examen; Data Source=localhost; Integrated Security=SSPI;");

        public DataSet ConsultaTab(string tabla, string campo)
        {
            DataSet datSet = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            String consulta = string.Format("Select * from {0} order by {1} ASC", tabla, campo);
            SqlCommand comando = new SqlCommand(consulta, conn);
            adaptador.SelectCommand = comando;
            conn.Open();
            adaptador.Fill(datSet, tabla);
            conn.Close();
            return datSet;

        }

        public int ABM(string instruccion)
        {
            int respuesta = -1;
            SqlCommand comando = new SqlCommand(instruccion, conn);
            conn.Open();
            respuesta = comando.ExecuteNonQuery();
            conn.Close();
            return respuesta;
        }




    }

}
