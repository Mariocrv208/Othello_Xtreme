using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoEntregable2
{
    public partial class PantallaXtreme : System.Web.UI.Page
    {
        conect conectar = new conect();
        static int contadorxml = 0;
        static string[][] matriztablero;
        static string[] contenidotablero;
        static string identificadorGlobal = "";
        static string nombreJug2 = "";
        static int contadornegro = 2;
        static int contadorblanco = 2;
        static string colorpaso = "";
        static int contadorGlobal = 0;
        static int contadorDerrotas = 1;
        static int contadorVictorias = 1;
        static int contadorEmpates = 1;
        static int contadormaquina = 1;
        static int contadorpaso = 0;
        public static string idUsuarioCargado = "";
        static bool validacion = false;
        static bool validacionazul = false;
        static bool priemraEntrada = false;
        static bool entradaPersonalizada = false;
        static bool validacionroja = false;
        static bool segundopermiso = false;
        static bool primerapermiso = false;
        static int cronometro;
        static int cronometroMinutos;
        static int cronometro2;
        static int cronometroMinutos2;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void timerTestBlanco_tick(object sen, EventArgs e)
        {
            litMsg.Text = "Tiempo: " + cronometroMinutos + ":" + cronometro.ToString();
            if (cronometro == 60)
            {
                cronometro = 0;
                cronometroMinutos = cronometroMinutos + 1;
            }
            cronometro = cronometro + 1;
        }

        protected void timerTestNegro_tick(object sen, EventArgs e)
        {
            litMsg2.Text = "Tiempo: " + cronometroMinutos2 + ":" + cronometro2.ToString();
            if (cronometro2 == 60)
            {
                cronometro2 = 0;
                cronometroMinutos2 = cronometroMinutos2 + 1;
            }
            cronometro2 = cronometro2 + 1;
        }

        protected void Button376_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaPrincipal.aspx");
        }
    }
}