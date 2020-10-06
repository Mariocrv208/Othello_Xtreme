using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoEntregable2
{
    public class pruebaconeccion
    {
        public SqlConnection conectando()
        {
            SqlConnection prueba = new SqlConnection(ConfigurationManager.ConnectionStrings["baseD"].ConnectionString);
            if(prueba.State == System.Data.ConnectionState.Open)
            {
                prueba.Close();
            }
            else
            {
                prueba.Open();
            }
            return prueba;
        }


    }
}