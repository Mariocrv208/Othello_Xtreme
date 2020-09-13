using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoEntregable2
{
    public class UsuariosCargar
    {
        conect conectusu = new conect();

        public DataTable ComboUsuarios()
        {
            SqlDataAdapter adaptador = new SqlDataAdapter("Sp_CargarCombo", conectusu.Leer());
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable devolvertabla = new DataTable();
            adaptador.Fill(devolvertabla);
            return devolvertabla;
        }
    }
}