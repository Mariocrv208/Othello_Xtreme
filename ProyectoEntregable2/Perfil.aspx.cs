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
    public partial class Reportes : System.Web.UI.Page
    {
        conect conectar = new conect();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaPrincipal.aspx");
        }

        protected void CargarDatos()
        {
            string IdUsuario = "";
            string nombres = "";
            string apellidos = "";
            string fechaNacimiento = "";
            string pais  = "";
            string correo = "";
            int Victorias = 0;
            int Derrotas = 0;
            int Empates = 0;
            int Participaciones = 0;
            int Ganados = 0;
            int Puntos = 0;
            /*validar datos antes de mandarlos*/
            String traer2 = "SELECT * FROM Usuario WHERE nickname=@nickname";
            SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
            traendo2.Parameters.AddWithValue("@nickname", ProyectoEntregable2.Login.UsuarioLogeado);
            SqlDataReader validacion2 = traendo2.ExecuteReader();
            if (validacion2.Read())
            {
                nombres = validacion2["nombres"].ToString();
                apellidos = validacion2["apellidos"].ToString();
                fechaNacimiento = validacion2["fechaNacimiento"].ToString();
                pais = validacion2["pais"].ToString();
                correo = validacion2["correo"].ToString();
            }
            int contadorVictoriasXtreme = 0;
            int contadorDerrotasXtreme = 0;
            int contadorEmpatesXtreme = 0;
            int contadorVictoriasMultijugador = 0;
            int contadorDerrotasMultijugador = 0;
            int contadorEmpatesMultijugador = 0;
            int contadorVictoriasIndividual = 0;
            int contadorDerrotasIndividual = 0;
            int contadorEmpatesIndividual = 0;
            bool salida = true;
            bool salida2 = true;
            bool salida3 = true;
            /*XTREME*/
            while (salida == true)
            {
                /*validar datos antes de mandarlos XTREME*/
                String traer6 = "SELECT victorias, nicknameJugador FROM PartidaXtreme WHERE victorias=@victorias AND nicknameJugador=@nicknameJugador";
                SqlCommand traendo6 = new SqlCommand(traer6, conectar.Leer());
                traendo6.Parameters.AddWithValue("@victorias", contadorVictoriasXtreme);
                traendo6.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                traendo6.ExecuteNonQuery();
                SqlDataReader validacion6 = traendo6.ExecuteReader();
                if (validacion6.Read())
                {
                    contadorVictoriasXtreme = contadorVictoriasXtreme + 1;
                }
                else if (!validacion6.Read())
                {
                    salida = false;
                }
            }
            while (salida2 == true)
            {
                /*validar datos antes de mandarlos*/
                String traer7 = "SELECT derrotas, nicknameJugador FROM PartidaXtreme WHERE derrotas=@derrotas AND nicknameJugador=@nicknameJugador";
                SqlCommand traendo7 = new SqlCommand(traer7, conectar.Leer());
                traendo7.Parameters.AddWithValue("@derrotas", contadorDerrotasXtreme);
                traendo7.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                traendo7.ExecuteNonQuery();
                SqlDataReader validacion7 = traendo7.ExecuteReader();
                if (validacion7.Read())
                {
                    contadorDerrotasXtreme = contadorDerrotasXtreme + 1;
                }

                else if (!validacion7.Read())
                {
                    salida2 = false;
                }
            }
            while (salida3 == true)
            {
                /*validar datos antes de mandarlos*/
                String traer8 = "SELECT empates, nicknameJugador FROM PartidaXtreme WHERE empates=@empates AND nicknameJugador=@nicknameJugador";
                SqlCommand traendo8 = new SqlCommand(traer8, conectar.Leer());
                traendo8.Parameters.AddWithValue("@empates", contadorEmpatesXtreme);
                traendo8.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                traendo8.ExecuteNonQuery();
                SqlDataReader validacion8 = traendo8.ExecuteReader();
                if (validacion8.Read())
                {
                    contadorEmpatesXtreme = contadorEmpatesXtreme + 1;
                }
                else if (!validacion8.Read())
                {
                    salida3 = false;
                }

            }
            salida = true;
            salida2 = true;
            salida3 = true;
            /*MULTIJUGADOR*/
            while (salida == true)
            {
                /*validar datos antes de mandarlos XTREME*/
                String traer6 = "SELECT victorias, nicknameJugador FROM PartidaMultijugador WHERE victorias=@victorias AND nicknameJugador=@nicknameJugador";
                SqlCommand traendo6 = new SqlCommand(traer6, conectar.Leer());
                traendo6.Parameters.AddWithValue("@victorias", contadorVictoriasMultijugador);
                traendo6.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                traendo6.ExecuteNonQuery();
                SqlDataReader validacion6 = traendo6.ExecuteReader();
                if (validacion6.Read())
                {
                    contadorVictoriasMultijugador = contadorVictoriasMultijugador + 1;
                }
                else if (!validacion6.Read())
                {
                    salida = false;
                }
            }
            while (salida2 == true)
            {
                /*validar datos antes de mandarlos*/
                String traer7 = "SELECT derrotas, nicknameJugador FROM PartidaMultijugador WHERE derrotas=@derrotas AND nicknameJugador=@nicknameJugador";
                SqlCommand traendo7 = new SqlCommand(traer7, conectar.Leer());
                traendo7.Parameters.AddWithValue("@derrotas", contadorDerrotasMultijugador);
                traendo7.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                traendo7.ExecuteNonQuery();
                SqlDataReader validacion7 = traendo7.ExecuteReader();
                if (validacion7.Read())
                {
                    contadorDerrotasMultijugador = contadorDerrotasMultijugador + 1;
                }

                else if (!validacion7.Read())
                {
                    salida2 = false;
                }
            }
            while (salida3 == true)
            {
                /*validar datos antes de mandarlos*/
                String traer8 = "SELECT empates, nicknameJugador FROM PartidaMultijugador WHERE empates=@empates AND nicknameJugador=@nicknameJugador";
                SqlCommand traendo8 = new SqlCommand(traer8, conectar.Leer());
                traendo8.Parameters.AddWithValue("@empates", contadorEmpatesMultijugador);
                traendo8.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                traendo8.ExecuteNonQuery();
                SqlDataReader validacion8 = traendo8.ExecuteReader();
                if (validacion8.Read())
                {
                    contadorEmpatesMultijugador = contadorEmpatesMultijugador + 1;
                }
                else if (!validacion8.Read())
                {
                    salida3 = false;
                }

            }
            salida = true;
            salida2 = true;
            salida3 = true;
            /*Individual*/
            while (salida == true)
            {
                /*validar datos antes de mandarlos XTREME*/
                String traer6 = "SELECT victorias, nicknameJugador FROM PartidaIndividual WHERE victorias=@victorias AND nicknameJugador=@nicknameJugador";
                SqlCommand traendo6 = new SqlCommand(traer6, conectar.Leer());
                traendo6.Parameters.AddWithValue("@victorias", contadorVictoriasIndividual);
                traendo6.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                traendo6.ExecuteNonQuery();
                SqlDataReader validacion6 = traendo6.ExecuteReader();
                if (validacion6.Read())
                {
                    contadorVictoriasIndividual = contadorVictoriasIndividual + 1;
                }
                else if (!validacion6.Read())
                {
                    salida = false;
                }
            }
            while (salida2 == true)
            {
                /*validar datos antes de mandarlos*/
                String traer7 = "SELECT derrotas, nicknameJugador FROM PartidaIndividual WHERE derrotas=@derrotas AND nicknameJugador=@nicknameJugador";
                SqlCommand traendo7 = new SqlCommand(traer7, conectar.Leer());
                traendo7.Parameters.AddWithValue("@derrotas", contadorDerrotasIndividual);
                traendo7.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                traendo7.ExecuteNonQuery();
                SqlDataReader validacion7 = traendo7.ExecuteReader();
                if (validacion7.Read())
                {
                    contadorDerrotasIndividual = contadorDerrotasIndividual + 1;
                }

                else if (!validacion7.Read())
                {
                    salida2 = false;
                }
            }
            while (salida3 == true)
            {
                /*validar datos antes de mandarlos*/
                String traer8 = "SELECT empates, nicknameJugador FROM PartidaIndividual WHERE empates=@empates AND nicknameJugador=@nicknameJugador";
                SqlCommand traendo8 = new SqlCommand(traer8, conectar.Leer());
                traendo8.Parameters.AddWithValue("@empates", contadorEmpatesIndividual);
                traendo8.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                traendo8.ExecuteNonQuery();
                SqlDataReader validacion8 = traendo8.ExecuteReader();
                if (validacion8.Read())
                {
                    contadorEmpatesIndividual = contadorEmpatesIndividual + 1;
                }
                else if (!validacion8.Read())
                {
                    salida3 = false;
                }

            }
            if (contadorDerrotasMultijugador != 0)
            {
                contadorDerrotasMultijugador = contadorDerrotasMultijugador - 1;
            }
            if (contadorVictoriasMultijugador != 0)
            {
                contadorVictoriasMultijugador = contadorVictoriasMultijugador - 1;
            }
            if (contadorEmpatesMultijugador != 0)
            {
                contadorEmpatesMultijugador = contadorEmpatesMultijugador - 1;
            }
            if (contadorDerrotasIndividual != 0)
            {
                contadorDerrotasIndividual = contadorDerrotasIndividual - 1;
            }
            if (contadorEmpatesIndividual  != 0)
            {
                contadorEmpatesIndividual = contadorEmpatesIndividual - 1;
            }
            if (contadorVictoriasIndividual != 0)
            {
                contadorVictoriasIndividual = contadorVictoriasIndividual - 1;
            }
            if (contadorVictoriasXtreme != 0)
            {
                contadorVictoriasXtreme = contadorVictoriasXtreme - 1;
            }
            if (contadorDerrotasXtreme != 0)
            {
                contadorDerrotasXtreme = contadorDerrotasXtreme - 1;
            }
            if (contadorEmpatesXtreme != 0)
            {
                contadorEmpatesXtreme = contadorEmpatesXtreme - 1;
            }
            Victorias = contadorVictoriasMultijugador + contadorVictoriasIndividual + contadorVictoriasXtreme;
            Derrotas = contadorDerrotasMultijugador + contadorDerrotasIndividual + contadorDerrotasXtreme;
            Empates = contadorEmpatesMultijugador + contadorEmpatesIndividual + contadorEmpatesXtreme;

            TextBox1.Text = nombres;
            TextBox2.Text = apellidos;
            TextBox3.Text = ProyectoEntregable2.Login.UsuarioLogeado;
            TextBox4.Text = fechaNacimiento;
            TextBox5.Text = pais;
            TextBox6.Text = correo;
            TextBox8.Text = Victorias.ToString();
            TextBox9.Text = Derrotas.ToString();
            TextBox10.Text = Empates.ToString();
            

        }
    }
}