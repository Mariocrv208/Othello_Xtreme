using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoEntregable2
{
    public partial class PaginaPrincipal : System.Web.UI.Page
    {
        conect conectar = new conect();
        public static string carruta = "";
        public static string nombre2 = "";
        public static string colorglobal = "";
        public static bool partidaPersonalizada = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reportes.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("PantallaJuego.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("Torneos.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            carruta = "C:\\Users\\mario\\OneDrive\\Documentos\\GitHub\\Proyecto1\\ProyectoEntregable2\\XMLArchivos\\" + buscaArc.FileName;
            Response.Redirect("PantallaJuego.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            colorglobal = TextBox2.Text;
            nombre2 = TextBox1.Text;
            if (RadioButton1.Checked == true)
            {
                partidaPersonalizada = true;
            }
            if (RadioButton2.Checked == true)
            {
                partidaPersonalizada = false;
            }
            Panel1.Visible = false;
            Response.Redirect("PantallaJuego.aspx");
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}