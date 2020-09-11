using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoEntregable2
{
    public class conect
    {
        public SqlConnection Leer()
        {
            SqlConnection sqlconctando = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            if (sqlconctando.State == ConnectionState.Open)
            {
                sqlconctando.Close();
            }
            else
            {
                sqlconctando.Open();
            }
            return sqlconctando;
        }
    }
}