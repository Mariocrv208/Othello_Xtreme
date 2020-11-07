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
        public static bool botonSi = false;
        public static string filasT = "";
        public static string columnasT = "";
        public static bool rojo = false;
        public static bool amarillo = false;
        public static bool maquina = false;
        public static bool azul = false;
        public static bool anaranjado = false;
        public static bool verde = false;
        public static bool violeta = false;
        public static bool blanco = false;
        public static bool negro = false;
        public static bool celeste = false;
        public static bool gris = false;
        public static string[] colores1;
        public static string[] colores2;
        public static bool validacionCarga = false;
        public static List<string> Colores1 = new List<string>();
        public static List<string> Colores2 = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            Colores1.Clear();
            Colores2.Clear();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Perfil.aspx");
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
            if (colorglobal == "negro")
            {
                Colores1.Add("negro");
                colores1 = Colores1.ToArray();
                Colores2.Add("blanco");
                colores2 = Colores2.ToArray();
            }
            if (colorglobal == "blanco")
            {
                Colores1.Add("blanco");
                colores1 = Colores1.ToArray();
                Colores2.Add("negro");
                colores2 = Colores2.ToArray();
            }
            Panel1.Visible = false;
            Response.Redirect("PantallaJuego.aspx");
        }
        
        protected void Button20_Click1(object sender, EventArgs e)
        {
            colorglobal = TextBox3.Text;
            nombre2 = "Maquina";
            maquina = true;
            if (colorglobal == "negro")
            {
                Colores1.Add("negro");
                colores1 = Colores1.ToArray();
                Colores2.Add("blanco");
                colores2 = Colores2.ToArray();
            }
            if (colorglobal == "blanco")
            {
                Colores1.Add("blanco");
                colores1 = Colores1.ToArray();
                Colores2.Add("negro");
                colores2 = Colores2.ToArray();
            }
            Panel2.Visible = false;
            Response.Redirect("PantallaJuego2.aspx");
        }

        protected void BottonXtreme_Click(object sender, EventArgs e)
        {

        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            
        }
       
        protected void PartidaXtreme_Click(object sender, EventArgs e)
        {
            Panel3.Visible = true;
        }

        protected void Button21_Click1(object sender, EventArgs e)
        {
            TextBox4.Visible = true;
            Label1.Visible = true;
            Label1.Text = "Ingrese El nombre del archivo";
            validacionCarga = true;
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Label5.Visible = false;
            Label6.Visible = false;
            Button23.Visible = true;
            RadioButton9.Visible = false;
            RadioButton10.Visible = false;
            RadioButton11.Visible = false;
            RadioButton12.Visible = false;
            RadioButton9.Visible = false;
            RadioButton10.Visible = false;
            RadioButton11.Visible = false;
            RadioButton12.Visible = false;
            RadioButton13.Visible = false;
            RadioButton14.Visible = false;
            RadioButton15.Visible = false;
            RadioButton16.Visible = false;
            RadioButton17.Visible = false;
            RadioButton18.Visible = false;
            RadioButton19.Visible = false;
            RadioButton20.Visible = false;
            RadioButton21.Visible = false;
            RadioButton22.Visible = false;
            RadioButton23.Visible = false;
            RadioButton24.Visible = false;
            RadioButton25.Visible = false;
            RadioButton26.Visible = false;
            RadioButton28.Visible = false;
            RadioButton29.Visible = false;
            RadioButton30.Visible = false;
            RadioButton31.Visible = false;
            RadioButton32.Visible = false;
            botonSi = true;
        }

        protected void Button22_Click(object sender, EventArgs e)
        {
            validacionCarga = false;
            TextBox4.Visible = true;
            DropDownList1.Visible = true;
            DropDownList2.Visible = true;
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Label5.Visible = true;
            Label6.Visible = true;
            Label7.Visible = true;
            Label8.Visible = true;
            Label9.Visible = true;
            RadioButton9.Visible = true;
            RadioButton10.Visible = true;
            RadioButton11.Visible = true;
            RadioButton12.Visible = true;
            RadioButton13.Visible = true;
            RadioButton14.Visible = true;
            RadioButton15.Visible = true;
            RadioButton16.Visible = true;
            RadioButton17.Visible = true;
            RadioButton18.Visible = true;
            RadioButton19.Visible = true;
            RadioButton20.Visible = true;
            RadioButton21.Visible = true;
            RadioButton22.Visible = true;
            RadioButton23.Visible = true;
            RadioButton24.Visible = true;
            RadioButton25.Visible = true;
            RadioButton26.Visible = true;
            RadioButton27.Visible = true;
            RadioButton28.Visible = true;
            RadioButton29.Visible = true;
            RadioButton30.Visible = true;
            RadioButton31.Visible = true;
            RadioButton32.Visible = true;
            Button23.Visible = true;
            Label1.Text = "Ingrese el nombre del jugador 2";
            botonSi = false;
        }

        protected void Button23_Click(object sender, EventArgs e)
        {
            if(botonSi == true)
            {
                carruta = TextBox4.Text;
                Response.Redirect("PantallaXtreme.aspx");
            }
            if (botonSi == false)
            {
                nombre2 = TextBox4.Text;
                if (RadioButton9.Checked == true)
                {
                    partidaPersonalizada = true;
                }
                if (RadioButton10.Checked == true)
                {
                    partidaPersonalizada = false;
                }
                if (RadioButton11.Checked == true)
                {
                    ModalidadInversa = true;
                }
                if (RadioButton12.Checked == true)
                {
                    ModalidadInversa = false;
                }
                if (RadioButton12.Checked == true)
                {
                    ModalidadInversa = false;
                }
                if (RadioButton13.Checked == true)
                {
                    rojo = false;
                    Colores1.Add("rojo");
                    colores1 = Colores1.ToArray();
                }
                if (RadioButton14.Checked == true)
                {
                    rojo = true;
                    Colores2.Add("rojo");
                    colores2 = Colores2.ToArray();
                }
                if (RadioButton15.Checked == true)
                {
                    amarillo = false;
                    Colores1.Add("amarillo");
                    colores1 = Colores1.ToArray();
                }
                if (RadioButton16.Checked == true)
                {
                    amarillo = true;
                    Colores2.Add("amarillo");
                    colores2 = Colores2.ToArray();
                }
                if (RadioButton17.Checked == true)
                {
                    azul = false;
                    Colores1.Add("azul");
                    colores1 = Colores1.ToArray();
                }
                if (RadioButton18.Checked == true)
                {
                    azul = true;
                    Colores2.Add("azul");
                    colores2 = Colores2.ToArray();
                }
                if (RadioButton19.Checked == true)
                {
                    anaranjado = false;
                    Colores1.Add("anaranjado");
                    colores1 = Colores1.ToArray();
                }
                if (RadioButton20.Checked == true)
                {
                    anaranjado = true;
                    Colores2.Add("anaranjado");
                    colores2 = Colores2.ToArray();
                }
                if (RadioButton21.Checked == true)
                {
                    verde = false;
                    Colores1.Add("verde");
                    colores1 = Colores1.ToArray();
                }
                if (RadioButton22.Checked == true)
                {
                    verde = true;
                    Colores2.Add("verde");
                    colores2 = Colores2.ToArray();
                }
                if (RadioButton23.Checked == true)
                {
                    violeta = false;
                    Colores1.Add("violeta");
                    colores1 = Colores1.ToArray();
                }
                if (RadioButton24.Checked == true)
                {
                    violeta = true;
                    Colores2.Add("violeta");
                    colores2 = Colores2.ToArray();
                }
                if (RadioButton25.Checked == true)
                {
                    blanco = false;
                    Colores1.Add("blanco");
                    colores1 = Colores1.ToArray();
                }
                if (RadioButton26.Checked == true)
                {
                    blanco = true;
                    Colores2.Add("blanco");
                    colores2 = Colores2.ToArray();
                }
                if (RadioButton27.Checked == true)
                {
                    negro = false;
                    Colores1.Add("negro");
                    colores1 = Colores1.ToArray();
                }
                if (RadioButton28.Checked == true)
                {
                    negro = true;
                    Colores2.Add("negro");
                    colores2 = Colores2.ToArray();
                }
                if (RadioButton29.Checked == true)
                {
                    celeste = false;
                    Colores1.Add("celeste");
                    colores1 = Colores1.ToArray();
                }
                if (RadioButton30.Checked == true)
                {
                    celeste = false;
                    Colores2.Add("celeste");
                    colores2 = Colores2.ToArray();
                }
                if (RadioButton31.Checked == true)
                {
                    gris = false;
                    Colores1.Add("gris");
                    colores1 = Colores1.ToArray();
                }
                if (RadioButton32.Checked == true)
                {
                    gris = false;
                    Colores2.Add("gris");
                    colores2 = Colores2.ToArray();
                }
                if (RadioButton33.Checked == true)
                {
                    maquina = false;
                }
                if (RadioButton34.Checked == true)
                {
                    maquina = true;
                }
                filasT = DropDownList1.Text;
                columnasT = DropDownList2.Text;
                Response.Redirect("PantallaXtreme.aspx");
            }
        }
        
    }
}