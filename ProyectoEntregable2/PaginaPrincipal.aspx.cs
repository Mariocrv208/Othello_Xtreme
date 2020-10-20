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
        public static bool ModalidadInversa = false;
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
            Panel2.Visible = true;
            
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
            if (RadioButton3.Checked == true)
            {
                ModalidadInversa = false;
            }
            if (RadioButton4.Checked == true)
            {
                ModalidadInversa = true;
            }
            Panel1.Visible = false;
            Response.Redirect("PantallaJuego.aspx");
        }
        
        protected void Button20_Click1(object sender, EventArgs e)
        {
            colorglobal = TextBox3.Text;
            nombre2 = "Maquina";
            if (RadioButton5.Checked == true)
            {
                partidaPersonalizada = true;
            }
            if (RadioButton6.Checked == true)
            {
                partidaPersonalizada = false;
            }
            if (RadioButton7.Checked == true)
            {
                ModalidadInversa = false;
            }
            if (RadioButton8.Checked == true)
            {
                ModalidadInversa = true;
            }
            Panel2.Visible = false;
            Response.Redirect("PantallaJuego2.aspx");
        }
    }
}