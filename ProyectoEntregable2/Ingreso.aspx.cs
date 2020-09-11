using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoEntregable2
{
    public partial class Ingreso : System.Web.UI.Page
    {
        conect conectar = new conect();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            String mandar = "INSERT INTO Usuario (nombres, apellidos, nickname, contrasenia, fechaNacimiento, pais, correo) VALUES (@nombres, @apellidos, @nickname, @contrasenia, @fechaNacimiento, @pais, @correo)";
            SqlCommand mandando = new SqlCommand(mandar, conectar.Leer());
            mandando.Parameters.AddWithValue("@nombres", txtnombres.Text);
            mandando.Parameters.AddWithValue("@apellidos", txtapellidos.Text);
            mandando.Parameters.AddWithValue("@nickname", txtnickname.Text);
            mandando.Parameters.AddWithValue("@contrasenia", txtcontra.Text);
            mandando.Parameters.AddWithValue("@fechaNacimiento", txtfecha.Text);
            mandando.Parameters.AddWithValue("@pais", DropDownPais.Text);
            mandando.Parameters.AddWithValue("@correo", txtcorreo.Text);
            mandando.ExecuteNonQuery();
            Response.Redirect("Login.aspx");
        }
    }
}