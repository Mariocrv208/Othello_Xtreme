using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoEntregable2
{
    public partial class Login : System.Web.UI.Page
    {
        conect conectar = new conect();
        public static string UsuarioLogeado = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ContLogin_Click(object sender, EventArgs e)
        {
            String mandar = "SELECT nickname, contrasenia FROM Usuario WHERE nickname=@nickname AND contrasenia=@contrasenia";
            SqlCommand mandando = new SqlCommand(mandar, conectar.Leer());
            mandando.Parameters.AddWithValue("@nickname", txtUsuario.Text);
            mandando.Parameters.AddWithValue("@contrasenia", txtContrasenia.Text);
            mandando.ExecuteNonQuery();
            SqlDataReader validacion = mandando.ExecuteReader();
            if (validacion.Read())
            {
                UsuarioLogeado = txtUsuario.Text;
                Response.Redirect("PaginaPrincipal.aspx");
            }

            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ingreso.aspx");
        }


    }
}