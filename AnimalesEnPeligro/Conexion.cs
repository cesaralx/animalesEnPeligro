﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MetroFramework;


namespace AnimalesEnPeligro
{
    class Conexion
    {
        public static SqlConnection conn = new SqlConnection("Initial Catalog=examen; Data Source=CESARAL-MOBL2\\SQLEXPRESS; Integrated Security=SSPI;");

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

        public int ABM(string instruccion, byte[] imagen = null)
        {
            int respuesta = -1;
            SqlCommand comando = new SqlCommand(instruccion, conn);
            conn.Open();
            if (imagen != null){
                comando.Parameters.Add("@File", SqlDbType.VarBinary, imagen.Length).Value = imagen;
            }
            else
            {
                comando.Parameters.Add("@File", SqlDbType.VarBinary, -1).Value = DBNull.Value;

            }
            respuesta = comando.ExecuteNonQuery();
            conn.Close();
            return respuesta;
        }

        public DataSet Busca(string consu, string tabla)
        {
            DataSet ConjuntoDatos = new DataSet();
            SqlCommand comando = new SqlCommand(consu, conn);
            SqlDataAdapter adaptador = new SqlDataAdapter
            {
                SelectCommand = comando
            };
            conn.Open();
            adaptador.Fill(ConjuntoDatos, tabla);
            conn.Close();
            return ConjuntoDatos;
        }



    }

}
