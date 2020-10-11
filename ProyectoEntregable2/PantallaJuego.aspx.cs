using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Xml;

namespace ProyectoEntregable2
{
    
    public partial class PantallaJuego : System.Web.UI.Page
    {
        conect conectar = new conect();
        static int contadorxml = 0;
        static string [][]  matriztablero;
        static string [] contenidotablero;
        static string identificadorGlobal = "";
        static string nombreJug2 = "";
        static int contadornegro = 2;
        static int contadorblanco = 2;
        static string identificadorA1 = "";
        static string identificadorB1 = "";
        static string identificadorC1 = "";
        static string identificadorD1 = "";
        static string identificadorE1 = "";
        static string identificadorF1 = "";
        static string identificadorG1 = "";
        static string identificadorH1 = "";
        static string identificadorA2 = "";
        static string identificadorB2 = "";
        static string identificadorC2 = "";
        static string identificadorD2 = "";
        static string identificadorE2 = "";
        static string identificadorF2 = "";
        static string identificadorG2 = "";
        static string identificadorH2 = "";
        static string identificadorA3 = "";
        static string identificadorB3 = "";
        static string identificadorC3 = "";
        static string identificadorD3 = "";
        static string identificadorE3 = "";
        static string identificadorF3 = "";
        static string identificadorG3 = "";
        static string identificadorH3 = "";
        static string identificadorA4 = "";
        static string identificadorB4 = "";
        static string identificadorC4 = "";
        static string identificadorD4 = "blanco";
        static string identificadorE4 = "negro";
        static string identificadorF4 = "";
        static string identificadorG4 = "";
        static string identificadorH4 = "";
        static string identificadorA5 = "";
        static string identificadorB5 = "";
        static string identificadorC5 = "";
        static string identificadorD5 = "negro";
        static string identificadorE5 = "blanco";
        static string identificadorF5 = "";
        static string identificadorG5 = "";
        static string identificadorH5 = "";
        static string identificadorA6 = "";
        static string identificadorB6 = "";
        static string identificadorC6 = "";
        static string identificadorD6 = "";
        static string identificadorE6 = "";
        static string identificadorF6 = "";
        static string identificadorG6 = "";
        static string identificadorH6 = "";
        static string identificadorA7 = "";
        static string identificadorB7 = "";
        static string identificadorC7 = "";
        static string identificadorD7 = "";
        static string identificadorE7 = "";
        static string identificadorF7 = "";
        static string identificadorG7 = "";
        static string identificadorH7 = "";
        static string identificadorA8 = "";
        static string identificadorB8 = "";
        static string identificadorC8 = "";
        static string identificadorD8 = "";
        static string identificadorE8 = "";
        static string identificadorF8 = "";
        static string identificadorG8 = "";
        static string identificadorH8 = "";
        static string fila1 = "1";
        static string fila2 = "2";
        static string fila3 = "3";
        static string fila4 = "4";
        static string fila5 = "5";
        static string fila6 = "6";
        static string fila7 = "7";
        static string fila8 = "8";
        static string columnaA = "A";
        static string columnaB = "B";
        static string columnaC = "C";
        static string columnaD = "D";
        static string columnaE = "E";
        static string columnaF = "F";
        static string columnaG = "G";
        static string columnaH = "H";
        static int contadorGlobal = 0;
        static int contadorvictorianegro = 0;
        static int contadorvictoriablanco = 0;
        static int contadorderrotanegro = 0;
        static int contadorderrotablanco = 0;
        static bool validarA1 = false;
        static bool validarB1 = false;
        static bool validarC1 = false;
        static bool validarD1 = false;
        static bool validarE1 = false;
        static bool validarF1 = false;
        static bool validarG1 = false;
        static bool validarH1 = false;
        static bool validarA2 = false;
        static bool validarB2 = false;
        static bool validarC2 = false;
        static bool validarD2 = false;
        static bool validarE2 = false;
        static bool validarF2 = false;
        static bool validarG2 = false;
        static bool validarH2 = false;
        static bool validarA3 = false;
        static bool validarB3 = false;
        static bool validarC3 = false;
        static bool validarD3 = false;
        static bool validarE3 = false;
        static bool validarF3 = false;
        static bool validarG3 = false;
        static bool validarH3 = false;
        static bool validarA4 = false;
        static bool validarB4 = false;
        static bool validarC4 = false;
        static bool validarD4 = false;
        static bool validarE4 = false;
        static bool validarF4 = false;
        static bool validarG4 = false;
        static bool validarH4 = false;
        static bool validarA5 = false;
        static bool validarB5 = false;
        static bool validarC5 = false;
        static bool validarD5 = false;
        static bool validarE5 = false;
        static bool validarF5 = false;
        static bool validarG5 = false;
        static bool validarH5 = false;
        static bool validarA6 = false;
        static bool validarB6 = false;
        static bool validarC6 = false;
        static bool validarD6 = false;
        static bool validarE6 = false;
        static bool validarF6 = false;
        static bool validarG6 = false;
        static bool validarH6 = false;
        static bool validarA7 = false;
        static bool validarB7 = false;
        static bool validarC7 = false;
        static bool validarD7 = false;
        static bool validarE7 = false;
        static bool validarF7 = false;
        static bool validarG7 = false;
        static bool validarH7 = false;
        static bool validarA8 = false;
        static bool validarB8 = false;
        static bool validarC8 = false;
        static bool validarD8 = false;
        static bool validarE8 = false;
        static bool validarF8 = false;
        static bool validarG8 = false;
        static bool validarH8 = false;
        public static string idUsuarioCargado = "";
        static bool validacion = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (identificadorGlobal == "")
            {
                identificadorGlobal = PaginaPrincipal.colorglobal;
            }
            nombreJug2 = PaginaPrincipal.nombre2;
            TextBox4.Text = nombreJug2;
            TextBox3.Text = ProyectoEntregable2.Login.UsuarioLogeado;
            XmlDocument leer = new XmlDocument();
            if (PaginaPrincipal.carruta != "")
            {
                if(validacion == false)
                {
                    EsquemaTablero();
                    leer.Load(PaginaPrincipal.carruta);
                    foreach (XmlNode xmlNode in leer.DocumentElement.ChildNodes[0].ParentNode)
                    {
                        if (xmlNode.Name.Equals("ficha"))
                        {
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "A" && xmlNode.ChildNodes[2].InnerText.ToString() == "1")
                            {
                                identificadorA1 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorA1.Equals("negro"))
                                {
                                    A1.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA1;
                                    matriztablero[0][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorA1.Equals("blanco"))
                                {
                                    A1.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA1;
                                    matriztablero[0][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    A1.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA1;
                                    matriztablero[0][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "B" && xmlNode.ChildNodes[2].InnerText.ToString() == "1")
                            {
                                identificadorB1 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorB1.Equals("negro"))
                                {
                                    B1.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB1;
                                    matriztablero[0][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorB1.Equals("blanco"))
                                {
                                    B1.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB1;
                                    matriztablero[0][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    B1.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB1;
                                    matriztablero[0][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "C" && xmlNode.ChildNodes[2].InnerText.ToString() == "1")
                            {
                                identificadorC1 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorC1.Equals("negro"))
                                {
                                    C1.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC1;
                                    matriztablero[0][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorC1.Equals("blanco"))
                                {
                                    C1.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC1;
                                    matriztablero[0][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    C1.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC1;
                                    matriztablero[0][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "D" && xmlNode.ChildNodes[2].InnerText.ToString() == "1")
                            {
                                identificadorD1 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorD1.Equals("negro"))
                                {
                                    D1.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD1;
                                    matriztablero[0][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorD1.Equals("blanco"))
                                {
                                    D1.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD1;
                                    matriztablero[0][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    D1.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD1;
                                    matriztablero[0][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "E" && xmlNode.ChildNodes[2].InnerText.ToString() == "1")
                            {
                                identificadorE1 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorE1.Equals("negro"))
                                {
                                    E1.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE1;
                                    matriztablero[0][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorE1.Equals("blanco"))
                                {
                                    E1.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE1;
                                    matriztablero[0][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    E1.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE1;
                                    matriztablero[0][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "F" && xmlNode.ChildNodes[2].InnerText.ToString() == "1")
                            {
                                identificadorF1 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorF1.Equals("negro"))
                                {
                                    F1.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF1;
                                    matriztablero[0][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorF1.Equals("blanco"))
                                {
                                    F1.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF1;
                                    matriztablero[0][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    F1.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF1;
                                    matriztablero[0][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "G" && xmlNode.ChildNodes[2].InnerText.ToString() == "1")
                            {
                                identificadorG1 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorG1.Equals("negro"))
                                {
                                    G1.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG1;
                                    matriztablero[0][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorG1.Equals("blanco"))
                                {
                                    G1.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG1;
                                    matriztablero[0][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    G1.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG1;
                                    matriztablero[0][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "H" && xmlNode.ChildNodes[2].InnerText.ToString() == "1")
                            {
                                identificadorH1 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorH1.Equals("negro"))
                                {
                                    H1.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH1;
                                    matriztablero[0][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorH1.Equals("blanco"))
                                {
                                    H1.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH1;
                                    matriztablero[0][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    H1.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH1;
                                    matriztablero[0][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "A" && xmlNode.ChildNodes[2].InnerText.ToString() == "2")
                            {
                                identificadorA2 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorA2.Equals("negro"))
                                {
                                    A2.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA2;
                                    matriztablero[1][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorA2.Equals("blanco"))
                                {
                                    A2.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA2;
                                    matriztablero[1][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    A2.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA2;
                                    matriztablero[1][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "B" && xmlNode.ChildNodes[2].InnerText.ToString() == "2")
                            {
                                identificadorB2 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorB2.Equals("negro"))
                                {
                                    B2.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB2;
                                    matriztablero[1][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorB2.Equals("blanco"))
                                {
                                    B2.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB2;
                                    matriztablero[1][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    B2.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB2;
                                    matriztablero[1][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "C" && xmlNode.ChildNodes[2].InnerText.ToString() == "2")
                            {
                                identificadorC2 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorC2.Equals("negro"))
                                {
                                    C2.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC2;
                                    matriztablero[1][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorC2.Equals("blanco"))
                                {
                                    C2.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC2;
                                    matriztablero[1][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    C2.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC2;
                                    matriztablero[1][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "D" && xmlNode.ChildNodes[2].InnerText.ToString() == "2")
                            {
                                identificadorD2 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorD2.Equals("negro"))
                                {
                                    D2.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD2;
                                    matriztablero[1][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorD2.Equals("blanco"))
                                {
                                    D2.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD2;
                                    matriztablero[1][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    D2.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD2;
                                    matriztablero[1][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "E" && xmlNode.ChildNodes[2].InnerText.ToString() == "2")
                            {
                                identificadorE2 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorE2.Equals("negro"))
                                {
                                    E2.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE2;
                                    matriztablero[1][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorE2.Equals("blanco"))
                                {
                                    E2.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE2;
                                    matriztablero[1][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    E2.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE2;
                                    matriztablero[1][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "F" && xmlNode.ChildNodes[2].InnerText.ToString() == "2")
                            {
                                identificadorF2 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorF2.Equals("negro"))
                                {
                                    F2.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF2;
                                    matriztablero[1][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorF2.Equals("blanco"))
                                {
                                    F2.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF2;
                                    matriztablero[1][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    F2.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF2;
                                    matriztablero[1][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "G" && xmlNode.ChildNodes[2].InnerText.ToString() == "2")
                            {
                                identificadorG2 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorG2.Equals("negro"))
                                {
                                    G2.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG2;
                                    matriztablero[1][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorG2.Equals("blanco"))
                                {
                                    G2.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG2;
                                    matriztablero[1][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    G2.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG2;
                                    matriztablero[1][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "H" && xmlNode.ChildNodes[2].InnerText.ToString() == "2")
                            {
                                identificadorH2 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorH2.Equals("negro"))
                                {
                                    H2.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH2;
                                    matriztablero[1][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorH2.Equals("blanco"))
                                {
                                    H2.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH2;
                                    matriztablero[1][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    H2.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH2;
                                    matriztablero[1][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "A" && xmlNode.ChildNodes[2].InnerText.ToString() == "3")
                            {
                                identificadorA3 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorA3.Equals("negro"))
                                {
                                    A3.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA3;
                                    matriztablero[2][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorA3.Equals("blanco"))
                                {
                                    A3.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA3;
                                    matriztablero[2][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    A3.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA3;
                                    matriztablero[2][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "B" && xmlNode.ChildNodes[2].InnerText.ToString() == "3")
                            {
                                identificadorB3 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorB3.Equals("negro"))
                                {
                                    B3.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB3;
                                    matriztablero[2][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorB3.Equals("blanco"))
                                {
                                    B3.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB3;
                                    matriztablero[2][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    B3.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB3;
                                    matriztablero[2][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "C" && xmlNode.ChildNodes[2].InnerText.ToString() == "3")
                            {
                                identificadorC3 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorC3.Equals("negro"))
                                {
                                    C3.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC3;
                                    matriztablero[2][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorC3.Equals("blanco"))
                                {
                                    C3.ImageUrl = "Blanca.png";
                                    contenidotablero[0] =  fila3;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC3;
                                    matriztablero[2][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    C3.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC3;
                                    matriztablero[2][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "D" && xmlNode.ChildNodes[2].InnerText.ToString() == "3")
                            {
                                identificadorD3 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorD3.Equals("negro"))
                                {
                                    D3.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD3;
                                    matriztablero[2][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorD3.Equals("blanco"))
                                {
                                    D3.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD3;
                                    matriztablero[2][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    D3.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD3;
                                    matriztablero[2][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "E" && xmlNode.ChildNodes[2].InnerText.ToString() == "3")
                            {
                                identificadorE3 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorE3.Equals("negro"))
                                {
                                    E3.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE3;
                                    matriztablero[2][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorE3.Equals("blanco"))
                                {
                                    E3.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE3;
                                    matriztablero[2][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    E3.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE3;
                                    matriztablero[2][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "F" && xmlNode.ChildNodes[2].InnerText.ToString() == "3")
                            {
                                identificadorF3 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorF3.Equals("negro"))
                                {
                                    F3.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF3;
                                    matriztablero[2][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorF3.Equals("blanco"))
                                {
                                    F3.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF3;
                                    matriztablero[2][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    F3.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF3;
                                    matriztablero[2][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "G" && xmlNode.ChildNodes[2].InnerText.ToString() == "3")
                            {
                                identificadorG3 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorG3.Equals("negro"))
                                {
                                    G3.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG3;
                                    matriztablero[2][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorG3.Equals("blanco"))
                                {
                                    G3.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG3;
                                    matriztablero[2][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    G3.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG3;
                                    matriztablero[2][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "H" && xmlNode.ChildNodes[2].InnerText.ToString() == "3")
                            {
                                identificadorH3 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorH3.Equals("negro"))
                                {
                                    H3.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH3;
                                    matriztablero[2][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorH3.Equals("blanco"))
                                {
                                    H3.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH3;
                                    matriztablero[2][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    H3.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH3;
                                    matriztablero[2][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "A" && xmlNode.ChildNodes[2].InnerText.ToString() == "4")
                            {
                                identificadorA4 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorA4.Equals("negro"))
                                {
                                    A4.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA4;
                                    matriztablero[3][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorA4.Equals("blanco"))
                                {
                                    A4.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA4;
                                    matriztablero[3][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    A4.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA4;
                                    matriztablero[3][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "B" && xmlNode.ChildNodes[2].InnerText.ToString() == "4")
                            {
                                identificadorB4 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorB4.Equals("negro"))
                                {
                                    B4.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB4;
                                    matriztablero[3][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorB4.Equals("blanco"))
                                {
                                    B4.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB4;
                                    matriztablero[3][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    B4.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB4;
                                    matriztablero[3][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "C" && xmlNode.ChildNodes[2].InnerText.ToString() == "4")
                            {
                                identificadorC4 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorC4.Equals("negro"))
                                {
                                    C4.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC4;
                                    matriztablero[3][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorC4.Equals("blanco"))
                                {
                                    C4.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC4;
                                    matriztablero[3][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    C4.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC4;
                                    matriztablero[3][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "D" && xmlNode.ChildNodes[2].InnerText.ToString() == "4")
                            {
                                identificadorD4 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorD4.Equals("negro"))
                                {
                                    D4.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC4;
                                    matriztablero[3][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorD4.Equals("blanco"))
                                {
                                    D4.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC4;
                                    matriztablero[3][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    D4.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC4;
                                    matriztablero[3][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "E" && xmlNode.ChildNodes[2].InnerText.ToString() == "4")
                            {
                                identificadorE4 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorE4.Equals("negro"))
                                {
                                    E4.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE4;
                                    matriztablero[3][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorE4.Equals("blanco"))
                                {
                                    E4.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE4;
                                    matriztablero[3][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    E4.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE4;
                                    matriztablero[3][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "F" && xmlNode.ChildNodes[2].InnerText.ToString() == "4")
                            {
                                identificadorF4 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorF4.Equals("negro"))
                                {
                                    F4.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF4;
                                    matriztablero[3][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorF4.Equals("blanco"))
                                {
                                    F4.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF4;
                                    matriztablero[3][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    F4.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF4;
                                    matriztablero[3][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "G" && xmlNode.ChildNodes[2].InnerText.ToString() == "4")
                            {
                                identificadorG4 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorG4.Equals("negro"))
                                {
                                    G4.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG4;
                                    matriztablero[3][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorG4.Equals("blanco"))
                                {
                                    G4.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG4;
                                    matriztablero[3][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    G4.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG4;
                                    matriztablero[3][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "H" && xmlNode.ChildNodes[2].InnerText.ToString() == "4")
                            {
                                identificadorH4 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorH4.Equals("negro"))
                                {
                                    H4.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH4;
                                    matriztablero[3][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorH4.Equals("blanco"))
                                {
                                    H4.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH4;
                                    matriztablero[3][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    H4.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH4;
                                    matriztablero[3][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "A" && xmlNode.ChildNodes[2].InnerText.ToString() == "5")
                            {
                                identificadorA5 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorA5.Equals("negro"))
                                {
                                    A5.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA5;
                                    matriztablero[4][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorA5.Equals("blanco"))
                                {
                                    A5.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA5;
                                    matriztablero[4][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    A5.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA5;
                                    matriztablero[4][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "B" && xmlNode.ChildNodes[2].InnerText.ToString() == "5")
                            {
                                identificadorB5 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorB5.Equals("negro"))
                                {
                                    B5.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB5;
                                    matriztablero[4][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorB5.Equals("blanco"))
                                {
                                    B5.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB5;
                                    matriztablero[4][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    B5.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB5;
                                    matriztablero[4][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "C" && xmlNode.ChildNodes[2].InnerText.ToString() == "5")
                            {
                                identificadorC5 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorC5.Equals("negro"))
                                {
                                    C5.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC5;
                                    matriztablero[4][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorC5.Equals("blanco"))
                                {
                                    C5.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC5;
                                    matriztablero[4][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    C5.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC5;
                                    matriztablero[4][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "D" && xmlNode.ChildNodes[2].InnerText.ToString() == "5")
                            {
                                identificadorD5 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorD5.Equals("negro"))
                                {
                                    D5.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD5;
                                    matriztablero[4][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorD5.Equals("blanco"))
                                {
                                    D5.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD5;
                                    matriztablero[4][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    D5.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD5;
                                    matriztablero[4][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "E" && xmlNode.ChildNodes[2].InnerText.ToString() == "5")
                            {
                                identificadorE5 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorE5.Equals("negro"))
                                {
                                    E5.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE5;
                                    matriztablero[4][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorE5.Equals("blanco"))
                                {
                                    E5.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE5;
                                    matriztablero[4][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    E5.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE5;
                                    matriztablero[4][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "F" && xmlNode.ChildNodes[2].InnerText.ToString() == "5")
                            {
                                identificadorF5 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorF5.Equals("negro"))
                                {
                                    F5.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF5;
                                    matriztablero[4][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorF5.Equals("blanco"))
                                {
                                    F5.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF5;
                                    matriztablero[4][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    F5.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF5;
                                    matriztablero[4][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "G" && xmlNode.ChildNodes[2].InnerText.ToString() == "5")
                            {
                                identificadorG5 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorG5.Equals("negro"))
                                {
                                    G5.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG5;
                                    matriztablero[4][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorG5.Equals("blanco"))
                                {
                                    G5.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG5;
                                    matriztablero[4][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    G5.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG5;
                                    matriztablero[4][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "H" && xmlNode.ChildNodes[2].InnerText.ToString() == "5")
                            {
                                identificadorH5 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorH5.Equals("negro"))
                                {
                                    H5.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH5;
                                    matriztablero[4][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorH5.Equals("blanco"))
                                {
                                    H5.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH5;
                                    matriztablero[4][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    H5.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH5;
                                    matriztablero[4][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "A" && xmlNode.ChildNodes[2].InnerText.ToString() == "6")
                            {
                                identificadorA6 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorA6.Equals("negro"))
                                {
                                    A6.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA6;
                                    matriztablero[5][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorA6.Equals("blanco"))
                                {
                                    A6.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA6;
                                    matriztablero[5][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    A6.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA6;
                                    matriztablero[5][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "B" && xmlNode.ChildNodes[2].InnerText.ToString() == "6")
                            {
                                identificadorB6 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorB6.Equals("negro"))
                                {
                                    B6.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB6;
                                    matriztablero[5][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorB6.Equals("blanco"))
                                {
                                    B6.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB6;
                                    matriztablero[5][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    B6.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB6;
                                    matriztablero[5][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "C" && xmlNode.ChildNodes[2].InnerText.ToString() == "6")
                            {
                                identificadorC6 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorC6.Equals("negro"))
                                {
                                    C6.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC6;
                                    matriztablero[5][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorC6.Equals("blanco"))
                                {
                                    C6.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC6;
                                    matriztablero[5][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    C6.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC6;
                                    matriztablero[5][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "D" && xmlNode.ChildNodes[2].InnerText.ToString() == "6")
                            {
                                identificadorD6 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorD6.Equals("negro"))
                                {
                                    D6.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD6;
                                    matriztablero[5][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorD6.Equals("blanco"))
                                {
                                    D6.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD6;
                                    matriztablero[5][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    D6.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD6;
                                    matriztablero[5][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "E" && xmlNode.ChildNodes[2].InnerText.ToString() == "6")
                            {
                                identificadorE6 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorE6.Equals("negro"))
                                {
                                    E6.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE6;
                                    matriztablero[5][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorE6.Equals("blanco"))
                                {
                                    E6.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE6;
                                    matriztablero[5][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    E6.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE6;
                                    matriztablero[5][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "F" && xmlNode.ChildNodes[2].InnerText.ToString() == "6")
                            {
                                identificadorF6 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorF6.Equals("negro"))
                                {
                                    F6.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF6;
                                    matriztablero[5][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorF6.Equals("blanco"))
                                {
                                    F6.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF6;
                                    matriztablero[5][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    F6.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF6;
                                    matriztablero[5][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "G" && xmlNode.ChildNodes[2].InnerText.ToString() == "6")
                            {
                                identificadorG6 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorG6.Equals("negro"))
                                {
                                    G6.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG6;
                                    matriztablero[5][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorG6.Equals("blanco"))
                                {
                                    G6.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG6;
                                    matriztablero[5][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    G6.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG6;
                                    matriztablero[5][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "H" && xmlNode.ChildNodes[2].InnerText.ToString() == "6")
                            {
                                identificadorH6 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorH6.Equals("negro"))
                                {
                                    H6.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH6;
                                    matriztablero[5][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorH6.Equals("blanco"))
                                {
                                    H6.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH6;
                                    matriztablero[5][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    H6.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH6;
                                    matriztablero[5][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "A" && xmlNode.ChildNodes[2].InnerText.ToString() == "7")
                            {
                                identificadorA7 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorA7.Equals("negro"))
                                {
                                    A7.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA7;
                                    matriztablero[6][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorA7.Equals("blanco"))
                                {
                                    A7.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA7;
                                    matriztablero[6][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    A7.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA7;
                                    matriztablero[6][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "B" && xmlNode.ChildNodes[2].InnerText.ToString() == "7")
                            {
                                identificadorB7 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorB7.Equals("negro"))
                                {
                                    B7.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB7;
                                    matriztablero[6][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorB7.Equals("blanco"))
                                {
                                    B7.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB7;
                                    matriztablero[6][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    B7.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB7;
                                    matriztablero[6][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "C" && xmlNode.ChildNodes[2].InnerText.ToString() == "7")
                            {
                                identificadorC7 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorC7.Equals("negro"))
                                {
                                    C7.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC7;
                                    matriztablero[6][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorC7.Equals("blanco"))
                                {
                                    C7.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC7;
                                    matriztablero[6][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    C7.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC7;
                                    matriztablero[6][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "D" && xmlNode.ChildNodes[2].InnerText.ToString() == "7")
                            {
                                identificadorD7 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorD7.Equals("negro"))
                                {
                                    D7.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD7;
                                    matriztablero[6][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorD7.Equals("blanco"))
                                {
                                    D7.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD7;
                                    matriztablero[6][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    D7.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD7;
                                    matriztablero[6][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "E" && xmlNode.ChildNodes[2].InnerText.ToString() == "7")
                            {
                                identificadorE7 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorE7.Equals("negro"))
                                {
                                    E7.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE7;
                                    matriztablero[6][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorE7.Equals("blanco"))
                                {
                                    E7.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE7;
                                    matriztablero[6][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    E7.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE7;
                                    matriztablero[6][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "F" && xmlNode.ChildNodes[2].InnerText.ToString() == "7")
                            {
                                identificadorF7 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorF7.Equals("negro"))
                                {
                                    F7.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF7;
                                    matriztablero[6][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorF7.Equals("blanco"))
                                {
                                    F7.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF7;
                                    matriztablero[6][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    F7.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF7;
                                    matriztablero[6][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "G" && xmlNode.ChildNodes[2].InnerText.ToString() == "7")
                            {
                                identificadorG7 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorG7.Equals("negro"))
                                {
                                    G7.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG7;
                                    matriztablero[6][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorG7.Equals("blanco"))
                                {
                                    G7.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG7;
                                    matriztablero[6][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    G7.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG7;
                                    matriztablero[6][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "H" && xmlNode.ChildNodes[2].InnerText.ToString() == "7")
                            {
                                identificadorH7 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorH7.Equals("negro"))
                                {
                                    H7.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH7;
                                    matriztablero[6][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorH7.Equals("blanco"))
                                {
                                    H7.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH7;
                                    matriztablero[6][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    H7.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH7;
                                    matriztablero[6][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "A" && xmlNode.ChildNodes[2].InnerText.ToString() == "8")
                            {
                                identificadorA8 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorA8.Equals("negro"))
                                {
                                    A8.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA8;
                                    matriztablero[7][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorA8.Equals("blanco"))
                                {
                                    A8.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA8;
                                    matriztablero[7][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    A8.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA8;
                                    matriztablero[7][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "B" && xmlNode.ChildNodes[2].InnerText.ToString() == "8")
                            {
                                identificadorB8 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorB8.Equals("negro"))
                                {
                                    B8.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB8;
                                    matriztablero[7][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorB8.Equals("blanco"))
                                {
                                    B8.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB8;
                                    matriztablero[7][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    B8.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB8;
                                    matriztablero[7][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "C" && xmlNode.ChildNodes[2].InnerText.ToString() == "8")
                            {
                                identificadorC8 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorC8.Equals("negro"))
                                {
                                    C8.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC8;
                                    matriztablero[7][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorC8.Equals("blanco"))
                                {
                                    C8.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC8;
                                    matriztablero[7][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    C8.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC8;
                                    matriztablero[7][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "D" && xmlNode.ChildNodes[2].InnerText.ToString() == "8")
                            {
                                identificadorD8 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorD8.Equals("negro"))
                                {
                                    D8.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD8;
                                    matriztablero[7][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorD8.Equals("blanco"))
                                {
                                    D8.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD8;
                                    matriztablero[7][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    D8.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD8;
                                    matriztablero[7][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "E" && xmlNode.ChildNodes[2].InnerText.ToString() == "8")
                            {
                                identificadorE8 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorE8.Equals("negro"))
                                {
                                    E8.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE8;
                                    matriztablero[7][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorE8.Equals("blanco"))
                                {
                                    E8.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE8;
                                    matriztablero[7][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    E8.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE8;
                                    matriztablero[7][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "F" && xmlNode.ChildNodes[2].InnerText.ToString() == "8")
                            {
                                identificadorF8 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorF8.Equals("negro"))
                                {
                                    F8.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF8;
                                    matriztablero[7][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorF8.Equals("blanco"))
                                {
                                    F8.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF8;
                                    matriztablero[7][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    F8.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF8;
                                    matriztablero[7][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "G" && xmlNode.ChildNodes[2].InnerText.ToString() == "8")
                            {
                                identificadorG8 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorG8.Equals("negro"))
                                {
                                    G8.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG8;
                                    matriztablero[7][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorG8.Equals("blanco"))
                                {
                                    G8.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG8;
                                    matriztablero[7][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    G8.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG8;
                                    matriztablero[7][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                            if (xmlNode.ChildNodes[1].InnerText.ToString() == "H" && xmlNode.ChildNodes[2].InnerText.ToString() == "8")
                            {
                                identificadorH8 = xmlNode.FirstChild.InnerText.ToString();
                                if (identificadorH8.Equals("negro"))
                                {
                                    H8.ImageUrl = "negra.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH8;
                                    matriztablero[7][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else if (identificadorH8.Equals("blanco"))
                                {
                                    H8.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH8;
                                    matriztablero[7][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                                else
                                {
                                    H8.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH8;
                                    matriztablero[7][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                                }
                            }
                        }
                    }
                    identificadorGlobal = "negro";
                    PaginaPrincipal.carruta = "";
                }
            }
            if (identificadorGlobal == "negro" && PaginaPrincipal.colorglobal == "negro")
            {
                Label1.Text = "negro";
            }
            if (identificadorGlobal == "blanco" && PaginaPrincipal.colorglobal == "blanco")
            {
                Label1.Text = "blanco";
            }
            if (identificadorGlobal == "negro" && PaginaPrincipal.colorglobal == "")
            {
                Label1.Text = "blanco";
            }
            if (identificadorGlobal == "blanco" && PaginaPrincipal.colorglobal == "")
            {
                Label1.Text = "negro";
            }
            if (PaginaPrincipal.carruta != "")
            {
                PaginaPrincipal.carruta = "";
            }
            TextBox5.Text = contadorvictorianegro.ToString();
            TextBox6.Text = contadorvictoriablanco.ToString();
            TextBox7.Text = contadorderrotanegro.ToString();
            TextBox8.Text = contadorderrotablanco.ToString();
            EsquemaTablero();
            validarMovimiento();
            PaginaPrincipal.colorglobal = "";
            cerrarPartida();
        }

        protected void validarMovimiento()
        {
            int columna = 0;
            int fila = 0;
            int columnabuscar = 0;
            int filabuscar = 0;
            string guardfila;
            string guardcolu;
            string guardestado;
            string guardfiladerecha;
            string guardcoluderecha;
            string guardestadoderecha;
            string guardfilaizquierda;
            string guardcoluizquierda;
            string guardestadoizquierda;
            string guardfilaarriba;
            string guardcoluarriba;
            string guardestadoarriba;
            string guardfilaabajo;
            string guardcoluabajo;
            string guardestadoabajo;
            string[] guardarseparaciones;
            string[] guardarseparacionesderecha;
            string[] guardarseparacionesizquierda;
            string[] guardarseparacionesarriba;
            string[] guardarseparacionesabajo;
            string guardarcontenidoizquierda;
            string guardarcontenidoderecha;
            string guardarcontenidoabajo;
            string guardarcontenidoarriba;
            string guardarcontenido;
            for (fila = 0; fila < matriztablero.Length; fila++)
            {
                for (columna = 0; columna < matriztablero[fila].Length; columna++)
                {
                    guardarcontenido = matriztablero[fila][columna].ToString();
                    guardarseparaciones = guardarcontenido.Split(',');
                    guardfila = guardarseparaciones[0];
                    guardcolu = guardarseparaciones[1];
                    guardestado = guardarseparaciones[2];
                    if (identificadorGlobal == "negro" && PaginaPrincipal.colorglobal == "")
                    {
                        if (guardestado == "blanco")
                        {
                            columnabuscar = columna;
                            filabuscar = fila;
                            while (columnabuscar < 8)
                            {
                                columnabuscar++;
                                if (columnabuscar == 8)
                                {
                                    break;
                                }
                                guardarcontenidoderecha = matriztablero[fila][columnabuscar].ToString();
                                guardarseparacionesderecha = guardarcontenidoderecha.Split(',');
                                guardfiladerecha = guardarseparacionesderecha[0];
                                guardcoluderecha = guardarseparacionesderecha[1];
                                guardestadoderecha = guardarseparacionesderecha[2];
                                guardarcontenidoizquierda = matriztablero[fila][columnabuscar - 1].ToString();
                                guardarseparacionesizquierda = guardarcontenidoizquierda.Split(',');
                                guardfilaizquierda = guardarseparacionesizquierda[0];
                                guardcoluizquierda = guardarseparacionesizquierda[1];
                                guardestadoizquierda = guardarseparacionesizquierda[2];
                                if (guardestadoderecha == "" && guardestadoizquierda == "negro")
                                {
                                    if (fila == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (columnabuscar >= 0)
                            {
                                columnabuscar = columnabuscar - 1;
                                if (columnabuscar < 0)
                                {
                                    break;
                                }
                                guardarcontenidoizquierda = matriztablero[fila][columnabuscar].ToString();
                                guardarseparacionesizquierda = guardarcontenidoizquierda.Split(',');
                                guardfilaizquierda = guardarseparacionesizquierda[0];
                                guardcoluizquierda = guardarseparacionesizquierda[1];
                                guardestadoizquierda = guardarseparacionesizquierda[2];
                                guardarcontenidoderecha = matriztablero[fila][columnabuscar + 1].ToString();
                                guardarseparacionesderecha = guardarcontenidoderecha.Split(',');
                                guardfiladerecha = guardarseparacionesderecha[0];
                                guardcoluderecha = guardarseparacionesderecha[1];
                                guardestadoderecha = guardarseparacionesderecha[2];
                                if (guardestadoizquierda == "" && guardestadoderecha == "negro")
                                {
                                    if (fila == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar < 8)
                            {
                                filabuscar++;
                                if (filabuscar == 8)
                                {
                                    break;
                                }
                                guardarcontenidoabajo = matriztablero[filabuscar][columna].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                guardarcontenidoarriba = matriztablero[filabuscar - 1][columna].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                if (guardestadoabajo == "" && guardestadoarriba == "negro")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columna == 0)
                                        {
                                            A1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H1.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columna == 0)
                                        {
                                            A2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H2.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columna == 0)
                                        {
                                            A3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H3.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columna == 0)
                                        {
                                            A4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H4.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columna == 0)
                                        {
                                            A5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H5.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columna == 0)
                                        {
                                            A6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H6.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columna == 0)
                                        {
                                            A7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H7.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columna == 0)
                                        {
                                            A8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H8.ImageUrl = "Posible.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar >= 0)
                            {
                                filabuscar = filabuscar - 1;
                                if (filabuscar < 0)
                                {
                                    break;
                                }
                                guardarcontenidoarriba = matriztablero[filabuscar][columna].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                guardarcontenidoabajo = matriztablero[filabuscar + 1][columna].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                if (guardestadoarriba == "" && guardestadoabajo == "negro")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columna == 0)
                                        {
                                            A1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H1.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columna == 0)
                                        {
                                            A2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H2.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columna == 0)
                                        {
                                            A3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H3.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columna == 0)
                                        {
                                            A4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H4.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columna == 0)
                                        {
                                            A5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H5.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columna == 0)
                                        {
                                            A6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H6.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columna == 0)
                                        {
                                            A7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H7.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columna == 0)
                                        {
                                            A8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H8.ImageUrl = "Posible.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar < 8 || columnabuscar >= 0)
                            {
                                filabuscar++;
                                columnabuscar = columnabuscar - 1;
                                if (filabuscar == 8)
                                {
                                    break;
                                }
                                if (columnabuscar < 0)
                                {
                                    break;
                                }
                                guardarcontenidoarriba = matriztablero[filabuscar][columnabuscar].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                guardarcontenidoabajo = matriztablero[filabuscar - 1][columnabuscar + 1].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                if (guardestadoarriba == "" && guardestadoabajo == "negro")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar < 8 || columnabuscar < 8)
                            {
                                filabuscar++;
                                columnabuscar++;
                                if (filabuscar == 8)
                                {
                                    break;
                                }
                                if (columnabuscar == 8)
                                {
                                    break;
                                }
                                guardarcontenidoarriba = matriztablero[filabuscar][columnabuscar].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                guardarcontenidoabajo = matriztablero[filabuscar - 1][columnabuscar - 1].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                if (guardestadoarriba == "" && guardestadoabajo == "negro")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar >= 0 || columnabuscar < 8)
                            {
                                filabuscar = filabuscar - 1;
                                columnabuscar++;
                                if (filabuscar < 0)
                                {
                                    break;
                                }
                                if (columnabuscar == 8)
                                {
                                    break;
                                }
                                guardarcontenidoarriba = matriztablero[filabuscar][columnabuscar].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                guardarcontenidoabajo = matriztablero[filabuscar + 1][columnabuscar - 1].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                if (guardestadoarriba == "" && guardestadoabajo == "negro")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar >= 0 || columnabuscar >= 0)
                            {
                                filabuscar = filabuscar - 1;
                                columnabuscar = columnabuscar - 1;
                                if (filabuscar < 0)
                                {
                                    break;
                                }
                                if (columnabuscar < 0)
                                {
                                    break;
                                }
                                guardarcontenidoarriba = matriztablero[filabuscar][columnabuscar].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                guardarcontenidoabajo = matriztablero[filabuscar + 1][columnabuscar + 1].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                if (guardestadoarriba == "" && guardestadoabajo == "negro")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;
                        }
                    } 

                    if (identificadorGlobal == "blanco" && PaginaPrincipal.colorglobal == "")
                    {
                        if (guardestado == "negro")
                        {
                            columnabuscar = columna;
                            filabuscar = fila;
                            while (columnabuscar < 8)
                            {
                                columnabuscar++;
                                if (columnabuscar == 8)
                                {
                                    break;
                                }
                                guardarcontenidoderecha = matriztablero[fila][columnabuscar].ToString();
                                guardarseparacionesderecha = guardarcontenidoderecha.Split(',');
                                guardfiladerecha = guardarseparacionesderecha[0];
                                guardcoluderecha = guardarseparacionesderecha[1];
                                guardestadoderecha = guardarseparacionesderecha[2];
                                guardarcontenidoizquierda = matriztablero[fila][columnabuscar - 1].ToString();
                                guardarseparacionesizquierda = guardarcontenidoizquierda.Split(',');
                                guardfilaizquierda = guardarseparacionesizquierda[0];
                                guardcoluizquierda = guardarseparacionesizquierda[1];
                                guardestadoizquierda = guardarseparacionesizquierda[2];
                                if (guardestadoderecha == "" && guardestadoizquierda == "blanco")
                                {
                                    if (fila == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible2.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (columnabuscar >= 0)
                            {
                                columnabuscar = columnabuscar - 1;
                                if (columnabuscar < 0)
                                {
                                    break;
                                }
                                guardarcontenidoizquierda = matriztablero[fila][columnabuscar].ToString();
                                guardarseparacionesizquierda = guardarcontenidoizquierda.Split(',');
                                guardfilaizquierda = guardarseparacionesizquierda[0];
                                guardcoluizquierda = guardarseparacionesizquierda[1];
                                guardestadoizquierda = guardarseparacionesizquierda[2];
                                guardarcontenidoderecha = matriztablero[fila][columnabuscar + 1].ToString();
                                guardarseparacionesderecha = guardarcontenidoderecha.Split(',');
                                guardfiladerecha = guardarseparacionesderecha[0];
                                guardcoluderecha = guardarseparacionesderecha[1];
                                guardestadoderecha = guardarseparacionesderecha[2];
                                if (guardestadoizquierda == "" && guardestadoderecha == "blanco")
                                {
                                    if (fila == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible2.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar < 8)
                            {
                                filabuscar++;
                                if (filabuscar == 8)
                                {
                                    break;
                                }
                                guardarcontenidoabajo = matriztablero[filabuscar][columna].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                guardarcontenidoarriba = matriztablero[filabuscar - 1][columna].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                if (guardestadoabajo == "" && guardestadoarriba == "blanco")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columna == 0)
                                        {
                                            A1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H1.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columna == 0)
                                        {
                                            A2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H2.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columna == 0)
                                        {
                                            A3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H3.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columna == 0)
                                        {
                                            A4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H4.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columna == 0)
                                        {
                                            A5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H5.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columna == 0)
                                        {
                                            A6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H6.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columna == 0)
                                        {
                                            A7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H7.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columna == 0)
                                        {
                                            A8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H8.ImageUrl = "Posible2 .png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar >= 0)
                            {
                                filabuscar = filabuscar - 1;
                                if (filabuscar < 0)
                                {
                                    break;
                                }
                                guardarcontenidoarriba = matriztablero[filabuscar][columna].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                guardarcontenidoabajo = matriztablero[filabuscar + 1][columna].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                if (guardestadoarriba == "" && guardestadoabajo == "blanco")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columna == 0)
                                        {
                                            A1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H1.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columna == 0)
                                        {
                                            A2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H2.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columna == 0)
                                        {
                                            A3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H3.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columna == 0)
                                        {
                                            A4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H4.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columna == 0)
                                        {
                                            A5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H5.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columna == 0)
                                        {
                                            A6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H6.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columna == 0)
                                        {
                                            A7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H7.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columna == 0)
                                        {
                                            A8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H8.ImageUrl = "Posible2.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar < 8 || columnabuscar >= 0)
                            {
                                filabuscar++;
                                columnabuscar = columnabuscar - 1;
                                if (filabuscar == 8)
                                {
                                    break;
                                }
                                if (columnabuscar < 0)
                                {
                                    break;
                                }
                                guardarcontenidoarriba = matriztablero[filabuscar][columnabuscar].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                guardarcontenidoabajo = matriztablero[filabuscar - 1][columnabuscar + 1].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                if (guardestadoarriba == "" && guardestadoabajo == "blanco")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible2.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar < 8 || columnabuscar < 8)
                            {
                                filabuscar++;
                                columnabuscar++;
                                if (filabuscar == 8)
                                {
                                    break;
                                }
                                if (columnabuscar == 8)
                                {
                                    break;
                                }
                                guardarcontenidoarriba = matriztablero[filabuscar][columnabuscar].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                guardarcontenidoabajo = matriztablero[filabuscar - 1][columnabuscar - 1].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                if (guardestadoarriba == "" && guardestadoabajo == "blanco")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible2.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar >= 0 || columnabuscar < 8)
                            {
                                filabuscar = filabuscar - 1;
                                columnabuscar++;
                                if (filabuscar < 0)
                                {
                                    break;
                                }
                                if (columnabuscar == 8)
                                {
                                    break;
                                }
                                guardarcontenidoarriba = matriztablero[filabuscar][columnabuscar].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                guardarcontenidoabajo = matriztablero[filabuscar + 1][columnabuscar - 1].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                if (guardestadoarriba == "" && guardestadoabajo == "blanco")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible2.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar >= 0 || columnabuscar >= 0)
                            {
                                filabuscar = filabuscar - 1;
                                columnabuscar = columnabuscar - 1;
                                if (filabuscar < 0)
                                {
                                    break;
                                }
                                if (columnabuscar < 0)
                                {
                                    break;
                                }
                                guardarcontenidoarriba = matriztablero[filabuscar][columnabuscar].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                guardarcontenidoabajo = matriztablero[filabuscar + 1][columnabuscar + 1].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                if (guardestadoarriba == "" && guardestadoabajo == "blanco")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible2.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;
                        }
                    }
                    if(identificadorGlobal == "negro" && PaginaPrincipal.colorglobal == "negro")
                    {
                        if (guardestado == "negro")
                        {
                            columnabuscar = columna;
                            filabuscar = fila;
                            while (columnabuscar < 8)
                            {
                                columnabuscar++;
                                if (columnabuscar == 8)
                                {
                                    break;
                                }
                                guardarcontenidoderecha = matriztablero[fila][columnabuscar].ToString();
                                guardarseparacionesderecha = guardarcontenidoderecha.Split(',');
                                guardfiladerecha = guardarseparacionesderecha[0];
                                guardcoluderecha = guardarseparacionesderecha[1];
                                guardestadoderecha = guardarseparacionesderecha[2];
                                guardarcontenidoizquierda = matriztablero[fila][columnabuscar - 1].ToString();
                                guardarseparacionesizquierda = guardarcontenidoizquierda.Split(',');
                                guardfilaizquierda = guardarseparacionesizquierda[0];
                                guardcoluizquierda = guardarseparacionesizquierda[1];
                                guardestadoizquierda = guardarseparacionesizquierda[2];
                                if (guardestadoderecha == "" && guardestadoizquierda == "blanco")
                                {
                                    if (fila == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible2.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (columnabuscar >= 0)
                            {
                                columnabuscar = columnabuscar - 1;
                                if (columnabuscar < 0)
                                {
                                    break;
                                }
                                guardarcontenidoizquierda = matriztablero[fila][columnabuscar].ToString();
                                guardarseparacionesizquierda = guardarcontenidoizquierda.Split(',');
                                guardfilaizquierda = guardarseparacionesizquierda[0];
                                guardcoluizquierda = guardarseparacionesizquierda[1];
                                guardestadoizquierda = guardarseparacionesizquierda[2];
                                guardarcontenidoderecha = matriztablero[fila][columnabuscar + 1].ToString();
                                guardarseparacionesderecha = guardarcontenidoderecha.Split(',');
                                guardfiladerecha = guardarseparacionesderecha[0];
                                guardcoluderecha = guardarseparacionesderecha[1];
                                guardestadoderecha = guardarseparacionesderecha[2];
                                if (guardestadoizquierda == "" && guardestadoderecha == "blanco")
                                {
                                    if (fila == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (fila == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible2.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar < 8)
                            {
                                filabuscar++;
                                if (filabuscar == 8)
                                {
                                    break;
                                }
                                guardarcontenidoabajo = matriztablero[filabuscar][columna].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                guardarcontenidoarriba = matriztablero[filabuscar - 1][columna].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                if (guardestadoabajo == "" && guardestadoarriba == "blanco")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columna == 0)
                                        {
                                            A1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H1.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columna == 0)
                                        {
                                            A2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H2.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columna == 0)
                                        {
                                            A3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H3.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columna == 0)
                                        {
                                            A4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H4.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columna == 0)
                                        {
                                            A5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H5.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columna == 0)
                                        {
                                            A6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H6.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columna == 0)
                                        {
                                            A7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H7.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columna == 0)
                                        {
                                            A8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H8.ImageUrl = "Posible2 .png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar >= 0)
                            {
                                filabuscar = filabuscar - 1;
                                if (filabuscar < 0)
                                {
                                    break;
                                }
                                guardarcontenidoarriba = matriztablero[filabuscar][columna].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                guardarcontenidoabajo = matriztablero[filabuscar + 1][columna].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                if (guardestadoarriba == "" && guardestadoabajo == "blanco")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columna == 0)
                                        {
                                            A1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G1.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H1.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columna == 0)
                                        {
                                            A2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G2.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H2.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columna == 0)
                                        {
                                            A3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G3.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H3.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columna == 0)
                                        {
                                            A4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G4.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H4.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columna == 0)
                                        {
                                            A5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G5.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H5.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columna == 0)
                                        {
                                            A6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G6.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H6.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columna == 0)
                                        {
                                            A7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G7.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H7.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columna == 0)
                                        {
                                            A8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G8.ImageUrl = "Posible2.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H8.ImageUrl = "Posible2.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar < 8 || columnabuscar >= 0)
                            {
                                filabuscar++;
                                columnabuscar = columnabuscar - 1;
                                if (filabuscar == 8)
                                {
                                    break;
                                }
                                if (columnabuscar < 0)
                                {
                                    break;
                                }
                                guardarcontenidoarriba = matriztablero[filabuscar][columnabuscar].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                guardarcontenidoabajo = matriztablero[filabuscar - 1][columnabuscar + 1].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                if (guardestadoarriba == "" && guardestadoabajo == "blanco")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible2.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar < 8 || columnabuscar < 8)
                            {
                                filabuscar++;
                                columnabuscar++;
                                if (filabuscar == 8)
                                {
                                    break;
                                }
                                if (columnabuscar == 8)
                                {
                                    break;
                                }
                                guardarcontenidoarriba = matriztablero[filabuscar][columnabuscar].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                guardarcontenidoabajo = matriztablero[filabuscar - 1][columnabuscar - 1].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                if (guardestadoarriba == "" && guardestadoabajo == "blanco")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible2.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar >= 0 || columnabuscar < 8)
                            {
                                filabuscar = filabuscar - 1;
                                columnabuscar++;
                                if (filabuscar < 0)
                                {
                                    break;
                                }
                                if (columnabuscar == 8)
                                {
                                    break;
                                }
                                guardarcontenidoarriba = matriztablero[filabuscar][columnabuscar].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                guardarcontenidoabajo = matriztablero[filabuscar + 1][columnabuscar - 1].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                if (guardestadoarriba == "" && guardestadoabajo == "blanco")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible2.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar >= 0 || columnabuscar >= 0)
                            {
                                filabuscar = filabuscar - 1;
                                columnabuscar = columnabuscar - 1;
                                if (filabuscar < 0)
                                {
                                    break;
                                }
                                if (columnabuscar < 0)
                                {
                                    break;
                                }
                                guardarcontenidoarriba = matriztablero[filabuscar][columnabuscar].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                guardarcontenidoabajo = matriztablero[filabuscar + 1][columnabuscar + 1].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                if (guardestadoarriba == "" && guardestadoabajo == "blanco")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible2.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible2.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible2.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;
                        }
                    }
                    if (identificadorGlobal == "blanco" && PaginaPrincipal.colorglobal == "blanco")
                    {
                        if (guardestado == "blanco")
                        {
                            columnabuscar = columna;
                            filabuscar = fila;
                            while (columnabuscar < 8)
                            {
                                columnabuscar++;
                                if (columnabuscar == 8)
                                {
                                    break;
                                }
                                guardarcontenidoderecha = matriztablero[fila][columnabuscar].ToString();
                                guardarseparacionesderecha = guardarcontenidoderecha.Split(',');
                                guardfiladerecha = guardarseparacionesderecha[0];
                                guardcoluderecha = guardarseparacionesderecha[1];
                                guardestadoderecha = guardarseparacionesderecha[2];
                                guardarcontenidoizquierda = matriztablero[fila][columnabuscar - 1].ToString();
                                guardarseparacionesizquierda = guardarcontenidoizquierda.Split(',');
                                guardfilaizquierda = guardarseparacionesizquierda[0];
                                guardcoluizquierda = guardarseparacionesizquierda[1];
                                guardestadoizquierda = guardarseparacionesizquierda[2];
                                if (guardestadoderecha == "" && guardestadoizquierda == "negro")
                                {
                                    if (fila == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (columnabuscar >= 0)
                            {
                                columnabuscar = columnabuscar - 1;
                                if (columnabuscar < 0)
                                {
                                    break;
                                }
                                guardarcontenidoizquierda = matriztablero[fila][columnabuscar].ToString();
                                guardarseparacionesizquierda = guardarcontenidoizquierda.Split(',');
                                guardfilaizquierda = guardarseparacionesizquierda[0];
                                guardcoluizquierda = guardarseparacionesizquierda[1];
                                guardestadoizquierda = guardarseparacionesizquierda[2];
                                guardarcontenidoderecha = matriztablero[fila][columnabuscar + 1].ToString();
                                guardarseparacionesderecha = guardarcontenidoderecha.Split(',');
                                guardfiladerecha = guardarseparacionesderecha[0];
                                guardcoluderecha = guardarseparacionesderecha[1];
                                guardestadoderecha = guardarseparacionesderecha[2];
                                if (guardestadoizquierda == "" && guardestadoderecha == "negro")
                                {
                                    if (fila == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (fila == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar < 8)
                            {
                                filabuscar++;
                                if (filabuscar == 8)
                                {
                                    break;
                                }
                                guardarcontenidoabajo = matriztablero[filabuscar][columna].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                guardarcontenidoarriba = matriztablero[filabuscar - 1][columna].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                if (guardestadoabajo == "" && guardestadoarriba == "negro")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columna == 0)
                                        {
                                            A1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H1.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columna == 0)
                                        {
                                            A2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H2.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columna == 0)
                                        {
                                            A3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H3.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columna == 0)
                                        {
                                            A4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H4.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columna == 0)
                                        {
                                            A5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H5.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columna == 0)
                                        {
                                            A6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H6.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columna == 0)
                                        {
                                            A7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H7.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columna == 0)
                                        {
                                            A8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H8.ImageUrl = "Posible.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar >= 0)
                            {
                                filabuscar = filabuscar - 1;
                                if (filabuscar < 0)
                                {
                                    break;
                                }
                                guardarcontenidoarriba = matriztablero[filabuscar][columna].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                guardarcontenidoabajo = matriztablero[filabuscar + 1][columna].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                if (guardestadoarriba == "" && guardestadoabajo == "negro")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columna == 0)
                                        {
                                            A1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G1.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H1.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columna == 0)
                                        {
                                            A2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G2.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H2.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columna == 0)
                                        {
                                            A3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G3.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H3.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columna == 0)
                                        {
                                            A4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G4.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H4.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columna == 0)
                                        {
                                            A5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G5.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H5.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columna == 0)
                                        {
                                            A6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G6.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H6.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columna == 0)
                                        {
                                            A7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G7.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H7.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columna == 0)
                                        {
                                            A8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 1)
                                        {
                                            B8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 2)
                                        {
                                            C8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 3)
                                        {
                                            D8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 4)
                                        {
                                            E8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 5)
                                        {
                                            F8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 6)
                                        {
                                            G8.ImageUrl = "Posible.png";
                                        }
                                        if (columna == 7)
                                        {
                                            H8.ImageUrl = "Posible.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar < 8 || columnabuscar >= 0)
                            {
                                filabuscar++;
                                columnabuscar = columnabuscar - 1;
                                if (filabuscar == 8)
                                {
                                    break;
                                }
                                if (columnabuscar < 0)
                                {
                                    break;
                                }
                                guardarcontenidoarriba = matriztablero[filabuscar][columnabuscar].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                guardarcontenidoabajo = matriztablero[filabuscar - 1][columnabuscar + 1].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                if (guardestadoarriba == "" && guardestadoabajo == "negro")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar < 8 || columnabuscar < 8)
                            {
                                filabuscar++;
                                columnabuscar++;
                                if (filabuscar == 8)
                                {
                                    break;
                                }
                                if (columnabuscar == 8)
                                {
                                    break;
                                }
                                guardarcontenidoarriba = matriztablero[filabuscar][columnabuscar].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                guardarcontenidoabajo = matriztablero[filabuscar - 1][columnabuscar - 1].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                if (guardestadoarriba == "" && guardestadoabajo == "negro")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar >= 0 || columnabuscar < 8)
                            {
                                filabuscar = filabuscar - 1;
                                columnabuscar++;
                                if (filabuscar < 0)
                                {
                                    break;
                                }
                                if (columnabuscar == 8)
                                {
                                    break;
                                }
                                guardarcontenidoarriba = matriztablero[filabuscar][columnabuscar].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                guardarcontenidoabajo = matriztablero[filabuscar + 1][columnabuscar - 1].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                if (guardestadoarriba == "" && guardestadoabajo == "negro")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;

                            while (filabuscar >= 0 || columnabuscar >= 0)
                            {
                                filabuscar = filabuscar - 1;
                                columnabuscar = columnabuscar - 1;
                                if (filabuscar < 0)
                                {
                                    break;
                                }
                                if (columnabuscar < 0)
                                {
                                    break;
                                }
                                guardarcontenidoarriba = matriztablero[filabuscar][columnabuscar].ToString();
                                guardarseparacionesarriba = guardarcontenidoarriba.Split(',');
                                guardfilaarriba = guardarseparacionesarriba[0];
                                guardcoluarriba = guardarseparacionesarriba[1];
                                guardestadoarriba = guardarseparacionesarriba[2];
                                guardarcontenidoabajo = matriztablero[filabuscar + 1][columnabuscar + 1].ToString();
                                guardarseparacionesabajo = guardarcontenidoabajo.Split(',');
                                guardfilaabajo = guardarseparacionesabajo[0];
                                guardcoluabajo = guardarseparacionesabajo[1];
                                guardestadoabajo = guardarseparacionesabajo[2];
                                if (guardestadoarriba == "" && guardestadoabajo == "negro")
                                {
                                    if (filabuscar == 0)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G1.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H1.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 1)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G2.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H2.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 2)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G3.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H3.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 3)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G4.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H4.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 4)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G5.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H5.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 5)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G6.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H6.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 6)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G7.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H7.ImageUrl = "Posible.png";
                                        }
                                    }
                                    if (filabuscar == 7)
                                    {
                                        if (columnabuscar == 0)
                                        {
                                            A8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 1)
                                        {
                                            B8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 2)
                                        {
                                            C8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 3)
                                        {
                                            D8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 4)
                                        {
                                            E8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 5)
                                        {
                                            F8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 6)
                                        {
                                            G8.ImageUrl = "Posible.png";
                                        }
                                        if (columnabuscar == 7)
                                        {
                                            H8.ImageUrl = "Posible.png";
                                        }
                                    }
                                }
                            }
                            columnabuscar = columna;
                            filabuscar = fila;
                        }
                    }
                }
            }
        }

        protected void cerrarPartida()
        {
            string guardarcontenido;
            string[] guardarseparaciones;
            string guardfila = "";
            string guardcolu = "";
            string guardestado = "";
            contadorGlobal = contadorblanco + contadornegro;
            if (contadorGlobal == 63)
            {
                for (int i = 0; i < matriztablero.Length; i++)
                {
                    for (int j = 0; j < matriztablero[i].Length; j++)
                    {
                        guardarcontenido = matriztablero[i][j].ToString();
                        guardarseparaciones = guardarcontenido.Split(',');
                        guardfila = guardarseparaciones[0];
                        guardcolu = guardarseparaciones[1];
                        guardestado = guardarseparaciones[2];
                        if (guardestado == "")
                        {
                            if (i == 0)
                            {
                                if (j == 0)
                                {
                                    if (A1.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 1)
                                {
                                    if (B1.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 2)
                                {
                                    if (C1.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 3)
                                {
                                    if (D1.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 4)
                                {
                                    if (E1.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 5)
                                {
                                    if (F1.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 6)
                                {
                                    if (G1.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 7)
                                {
                                    if (H1.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                            }
                            if (i == 1)
                            {
                                if (j == 0)
                                {
                                    if (A2.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 1)
                                {
                                    if (B2.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 2)
                                {
                                    if (C2.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 3)
                                {
                                    if (D2.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 4)
                                {
                                    if (E2.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 5)
                                {
                                    if (F2.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 6)
                                {
                                    if (G2.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 7)
                                {
                                    if (H2.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                            }
                            if (i == 2)
                            {
                                if (j == 0)
                                {
                                    if (A3.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 1)
                                {
                                    if (B3.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 2)
                                {
                                    if (C3.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 3)
                                {
                                    if (D3.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 4)
                                {
                                    if (E3.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 5)
                                {
                                    if (F3.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 6)
                                {
                                    if (G3.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 7)
                                {
                                    if (H3.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                            }
                            if (i == 3)
                            {
                                if (j == 0)
                                {
                                    if (A4.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 1)
                                {
                                    if (B4.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 2)
                                {
                                    if (C4.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 3)
                                {
                                    if (D4.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 4)
                                {
                                    if (E4.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 5)
                                {
                                    if (F4.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 6)
                                {
                                    if (G4.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 7)
                                {
                                    if (H4.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                            }
                            if (i == 4)
                            {
                                if (j == 0)
                                {
                                    if (A5.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 1)
                                {
                                    if (B5.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 2)
                                {
                                    if (C5.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 3)
                                {
                                    if (D5.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 4)
                                {
                                    if (E5.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 5)
                                {
                                    if (F5.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 6)
                                {
                                    if (G5.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 7)
                                {
                                    if (H5.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                            }
                            if (i == 5)
                            {
                                if (j == 0)
                                {
                                    if (A6.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 1)
                                {
                                    if (B6.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 2)
                                {
                                    if (C6.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 3)
                                {
                                    if (D6.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 4)
                                {
                                    if (E6.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 5)
                                {
                                    if (F6.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 6)
                                {
                                    if (G6.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 7)
                                {
                                    if (H6.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                            }
                            if (i == 0)
                            {
                                if (j == 0)
                                {
                                    if (A7.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 1)
                                {
                                    if (B7.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 2)
                                {
                                    if (C7.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 3)
                                {
                                    if (D7.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 4)
                                {
                                    if (E7.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 5)
                                {
                                    if (F7.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 6)
                                {
                                    if (G7.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 7)
                                {
                                    if (H7.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                            }
                            if (i == 7)
                            {
                                if (j == 0)
                                {
                                    if (A8.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 1)
                                {
                                    if (B8.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        contadornegro = contadornegro + 1;
                                    }
                                }
                                if (j == 2)
                                {
                                    if (C8.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 3)
                                {
                                    if (D8.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 4)
                                {
                                    if (E8.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 5)
                                {
                                    if (F8.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 6)
                                {
                                    if (G8.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                                if (j == 7)
                                {
                                    if (H8.ImageUrl == "fondotransparente.png")
                                    {
                                        if (contadorblanco > contadornegro)
                                        {
                                            contadorblanco = contadorblanco + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadornegro > contadorblanco)
                                        {
                                            contadornegro = contadornegro + 1;
                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                        if (contadorblanco == contadornegro)
                                        {

                                            Response.Redirect("PaginaPrincipal.aspx");
                                        }
                                    }
                                }
                            }

                        }
                    }
                }
                if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text)
                {
                    bool salida = false;
                    bool salida2 = false;
                    while (salida == true)
                    {
                        /*validar datos antes de mandarlos*/
                        String traer1 = "SELECT derrotasNegro FROM PartidaMultijugador WHERE derrotasNegro=@derrotasNegro";
                        SqlCommand traendo1 = new SqlCommand(traer1, conectar.Leer());
                        traendo1.Parameters.AddWithValue("@derrotasNegro", contadorderrotanegro.ToString());
                        traendo1.ExecuteNonQuery();
                        SqlDataReader validacion1 = traendo1.ExecuteReader();
                        if (validacion1.Read())
                        {
                            contadorderrotanegro = contadorderrotanegro + 1;
                        }
                        else if (!validacion1.Read())
                        {
                            salida = true;
                        }
                    }
                    while (salida2 == false)
                    {
                        /*validar datos antes de mandarlos*/
                        String traer2 = "SELECT victoriasNegro FROM PartidaMultijugador WHERE victoriasNegro=@victoriasNegro";
                        SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                        traendo2.Parameters.AddWithValue("@victoriasNegro", contadorvictorianegro.ToString());
                        traendo2.ExecuteNonQuery();
                        SqlDataReader validacion2 = traendo2.ExecuteReader();
                        if (validacion2.Read())
                        {
                            contadorvictorianegro = contadorvictorianegro + 1;
                        }
                        else if (!validacion2.Read())
                        {
                            salida2 = true;
                        }
                    }
                }
                if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text)
                {
                    bool salida = false;
                    bool salida2 = false;
                    while (salida == false)
                    {
                        /*validar datos antes de mandarlos*/
                        String traer2 = "SELECT derrotasBlanco FROM PartidaMultijugador WHERE derrotasBlanco=@derrotasBlanco";
                        SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                        traendo2.Parameters.AddWithValue("@derrotasBlanco", contadorderrotablanco.ToString());
                        traendo2.ExecuteNonQuery();
                        SqlDataReader validacion2 = traendo2.ExecuteReader();
                        if (validacion2.Read())
                        {
                            contadorderrotablanco = contadorderrotablanco + 1;
                        }
                        else if (!validacion2.Read())
                        {
                            salida = true;
                        }
                    }
                    while (salida2 == false)
                    {
                        /*validar datos antes de mandarlos*/
                        String traer2 = "SELECT victoriasBlanco FROM PartidaMultijugador WHERE victoriasBlanco=@victoriasBlanco";
                        SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                        traendo2.Parameters.AddWithValue("@victoriasBlanco", contadorvictoriablanco.ToString());
                        traendo2.ExecuteNonQuery();
                        SqlDataReader validacion2 = traendo2.ExecuteReader();
                        if (validacion2.Read())
                        {
                            contadorvictoriablanco = contadorvictoriablanco + 1;
                        }
                        else if (!validacion2.Read())
                        {
                            salida2 = true;
                        }
                    }
                }
                /*If para validar si el dato de victoria viene vacio*/
                String mandar = "INSERT INTO PartidaMultijugador (movimientoNegro, movimientoBlanco, nicknameNegro, nicknameBlanco, derrotasNegro, derrotasBlanco, victoriasNegro, victoriasBlanco, tipoPartida) VALUES (@movimientoNegro, @movimientoBlanco, @nicknameNegro, @nicknameBlanco, @derrotasNegro, @derrotasBlanco, @victoriasNegro,  @victoriasBlanco, @tipoPartida)";
                SqlCommand mandando = new SqlCommand(mandar, conectar.Leer());
                mandando.Parameters.AddWithValue("@movimientoNegro", contadornegro.ToString());
                mandando.Parameters.AddWithValue("@movimientoBlanco", contadorblanco.ToString());
                mandando.Parameters.AddWithValue("@nicknameNegro", TextBox3.Text);
                mandando.Parameters.AddWithValue("@nicknameBlanco", TextBox4.Text);
                mandando.Parameters.AddWithValue("@derrotasNegro", contadorderrotanegro.ToString());
                mandando.Parameters.AddWithValue("@derrotasBlanco", contadorderrotablanco.ToString());
                mandando.Parameters.AddWithValue("@victoriasNegro", contadorvictorianegro.ToString());
                mandando.Parameters.AddWithValue("@victoriasBlanco", contadorvictoriablanco.ToString());
                mandando.Parameters.AddWithValue("@tipoPartida", "Multijugador");
                mandando.ExecuteNonQuery();
                Response.Redirect("PaginaPrincipal.aspx");
            }
            if (contadorGlobal == 64)
            {
                if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text)
                {
                    bool salida = false;
                    bool salida2 = false;
                    while (salida == true)
                    {
                        /*validar datos antes de mandarlos*/
                        String traer1 = "SELECT derrotasNegro FROM PartidaMultijugador WHERE derrotasNegro=@derrotasNegro";
                        SqlCommand traendo1 = new SqlCommand(traer1, conectar.Leer());
                        traendo1.Parameters.AddWithValue("@derrotasNegro", contadorderrotanegro.ToString());
                        traendo1.ExecuteNonQuery();
                        SqlDataReader validacion1 = traendo1.ExecuteReader();
                        if (validacion1.Read())
                        {
                            contadorderrotanegro = contadorderrotanegro + 1;
                        }
                        else if (!validacion1.Read())
                        {
                            salida = true;
                        }
                    }
                    while (salida2 == false)
                    {
                        /*validar datos antes de mandarlos*/
                        String traer2 = "SELECT victoriasNegro FROM PartidaMultijugador WHERE victoriasNegro=@victoriasNegro";
                        SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                        traendo2.Parameters.AddWithValue("@victoriasNegro", contadorvictorianegro.ToString());
                        traendo2.ExecuteNonQuery();
                        SqlDataReader validacion2 = traendo2.ExecuteReader();
                        if (validacion2.Read())
                        {
                            contadorvictorianegro = contadorvictorianegro + 1;
                        }
                        else if (!validacion2.Read())
                        {
                            salida2 = true;
                        }
                    }
                }
                if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text)
                {
                    bool salida = false;
                    bool salida2 = false;
                    while (salida == false)
                    {
                        /*validar datos antes de mandarlos*/
                        String traer2 = "SELECT derrotasBlanco FROM PartidaMultijugador WHERE derrotasBlanco=@derrotasBlanco";
                        SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                        traendo2.Parameters.AddWithValue("@derrotasBlanco", contadorderrotablanco.ToString());
                        traendo2.ExecuteNonQuery();
                        SqlDataReader validacion2 = traendo2.ExecuteReader();
                        if (validacion2.Read())
                        {
                            contadorderrotablanco = contadorderrotablanco + 1;
                        }
                        else if (!validacion2.Read())
                        {
                            salida = true;
                        }
                    }
                    while (salida2 == false)
                    {
                        /*validar datos antes de mandarlos*/
                        String traer2 = "SELECT victoriasBlanco FROM PartidaMultijugador WHERE victoriasBlanco=@victoriasBlanco";
                        SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                        traendo2.Parameters.AddWithValue("@victoriasBlanco", contadorvictoriablanco.ToString());
                        traendo2.ExecuteNonQuery();
                        SqlDataReader validacion2 = traendo2.ExecuteReader();
                        if (validacion2.Read())
                        {
                            contadorvictoriablanco = contadorvictoriablanco + 1;
                        }
                        else if (!validacion2.Read())
                        {
                            salida2 = true;
                        }
                    }
                }
                /*If para validar si el dato de victoria viene vacio*/
                String mandar = "INSERT INTO PartidaMultijugador (movimientoNegro, movimientoBlanco, nicknameNegro, nicknameBlanco, derrotasNegro, derrotasBlanco, victoriasNegro, victoriasBlanco, tipoPartida) VALUES (@movimientoNegro, @movimientoBlanco, @nicknameNegro, @nicknameBlanco, @derrotasNegro, @derrotasBlanco, @victoriasNegro,  @victoriasBlanco, @tipoPartida)";
                SqlCommand mandando = new SqlCommand(mandar, conectar.Leer());
                mandando.Parameters.AddWithValue("@movimientoNegro", contadornegro.ToString());
                mandando.Parameters.AddWithValue("@movimientoBlanco", contadorblanco.ToString());
                mandando.Parameters.AddWithValue("@nicknameNegro", TextBox3.Text);
                mandando.Parameters.AddWithValue("@nicknameBlanco", TextBox4.Text);
                mandando.Parameters.AddWithValue("@derrotasNegro", contadorderrotanegro.ToString());
                mandando.Parameters.AddWithValue("@derrotasBlanco", contadorderrotablanco.ToString());
                mandando.Parameters.AddWithValue("@victoriasNegro", contadorvictorianegro.ToString());
                mandando.Parameters.AddWithValue("@victoriasBlanco", contadorvictoriablanco.ToString());
                mandando.Parameters.AddWithValue("@tipoPartida", "Multijugador");
                mandando.ExecuteNonQuery();
                Response.Redirect("PaginaPrincipal.aspx");
            }
        }

        protected void CambioFicha()
        {

        }

        protected void Button178_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorA1 = "negro";
                identificadorGlobal = "blanco";
                A1.ImageUrl = "negra.png";
                A1.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorA1 = "blanco";
                identificadorGlobal = "negro";
                A1.ImageUrl = "Blanca.png";
                A1.Enabled = false;
            }
            validarA1 = true;
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila1;
            contenidotablero[1] = columnaA;
            contenidotablero[2] = identificadorA1;
            matriztablero[0][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void B1_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorB1 = "negro";
                identificadorGlobal = "blanco";
                B1.ImageUrl = "negra.png";
                B1.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorB1 = "blanco";
                identificadorGlobal = "negro";
                B1.ImageUrl = "Blanca.png";
                B1.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila1;
            contenidotablero[1] = columnaB;
            contenidotablero[2] = identificadorB1;
            matriztablero[0][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void C1_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorC1 = "negro";
                identificadorGlobal = "blanco";
                C1.ImageUrl = "negra.png";
                C1.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorC1 = "blanco";
                identificadorGlobal = "negro";
                C1.ImageUrl = "Blanca.png";
                C1.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila1;
            contenidotablero[1] = columnaC;
            contenidotablero[2] = identificadorC1;
            matriztablero[0][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void D1_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorD1 = "negro";
                identificadorGlobal = "blanco";
                D1.ImageUrl = "negra.png";
                D1.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorD1 = "blanco";
                identificadorGlobal = "negro";
                D1.ImageUrl = "Blanca.png";
                D1.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila1;
            contenidotablero[1] = columnaD;
            contenidotablero[2] = identificadorD1;
            matriztablero[0][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void E1_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorE1 = "negro";
                identificadorGlobal = "blanco";
                E1.ImageUrl = "negra.png";
                E1.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorE1 = "blanco";
                identificadorGlobal = "negro";
                E1.ImageUrl = "Blanca.png";
                E1.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila1;
            contenidotablero[1] = columnaE;
            contenidotablero[2] = identificadorE1;
            matriztablero[0][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void F1_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorF1 = "negro";
                identificadorGlobal = "blanco";
                F1.ImageUrl = "negra.png";
                F1.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorF1 = "blanco";
                identificadorGlobal = "negro";
                F1.ImageUrl = "Blanca.png";
                F1.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila1;
            contenidotablero[1] = columnaF;
            contenidotablero[2] = identificadorF1;
            matriztablero[0][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void G1_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorG1 = "negro";
                identificadorGlobal = "blanco";
                G1.ImageUrl = "negra.png";
                G1.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorG1 = "blanco";
                identificadorGlobal = "negro";
                G1.ImageUrl = "Blanca.png";
                G1.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila1;
            contenidotablero[1] = columnaG;
            contenidotablero[2] = identificadorG1;
            matriztablero[0][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void H1_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorH1 = "negro";
                identificadorGlobal = "blanco";
                H1.ImageUrl = "negra.png";
                H1.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorH1 = "blanco";
                identificadorGlobal = "negro";
                H1.ImageUrl = "Blanca.png";
                H1.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila1;
            contenidotablero[1] = columnaH;
            contenidotablero[2] = identificadorH1;
            matriztablero[0][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void A2_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorA2 = "negro";
                identificadorGlobal = "blanco";
                A2.ImageUrl = "negra.png";
                A2.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorA2 = "blanco";
                identificadorGlobal = "negro";
                A2.ImageUrl = "Blanca.png";
                A2.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila2;
            contenidotablero[1] = columnaA;
            contenidotablero[2] = identificadorA2;
            matriztablero[1][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void B2_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorB2 = "negro";
                identificadorGlobal = "blanco";
                B2.ImageUrl = "negra.png";
                B2.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorB2 = "blanco";
                identificadorGlobal = "negro";
                B2.ImageUrl = "Blanca.png";
                B2.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila2;
            contenidotablero[1] = columnaB;
            contenidotablero[2] = identificadorB2;
            matriztablero[1][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void C2_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorC2 = "negro";
                identificadorGlobal = "blanco";
                C2.ImageUrl = "negra.png";
                C2.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorC2 = "blanco";
                identificadorGlobal = "negro";
                C2.ImageUrl = "Blanca.png";
                C2.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila2;
            contenidotablero[1] = columnaC;
            contenidotablero[2] = identificadorC2;
            matriztablero[1][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void D2_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorD2 = "negro";
                identificadorGlobal = "blanco";
                D2.ImageUrl = "negra.png";
                D2.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorD2 = "blanco";
                identificadorGlobal = "negro";
                D2.ImageUrl = "Blanca.png";
                D2.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila2;
            contenidotablero[1] = columnaD;
            contenidotablero[2] = identificadorD2;
            matriztablero[1][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void E2_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorE2 = "negro";
                identificadorGlobal = "blanco";
                E2.ImageUrl = "negra.png";
                E2.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorE2 = "blanco";
                identificadorGlobal = "negro";
                E2.ImageUrl = "Blanca.png";
                E2.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila2;
            contenidotablero[1] = columnaE;
            contenidotablero[2] = identificadorE2;
            matriztablero[1][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void F2_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorF2 = "negro";
                identificadorGlobal = "blanco";
                F2.ImageUrl = "negra.png";
                F2.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorF2 = "blanco";
                identificadorGlobal = "negro";
                F2.ImageUrl = "Blanca.png";
                F2.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila2;
            contenidotablero[1] = columnaF;
            contenidotablero[2] = identificadorF2;
            matriztablero[1][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void G2_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorG2 = "negro";
                identificadorGlobal = "blanco";
                G2.ImageUrl = "negra.png";
                G2.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorG2 = "blanco";
                identificadorGlobal = "negro";
                G2.ImageUrl = "Blanca.png";
                G2.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila2;
            contenidotablero[1] = columnaG;
            contenidotablero[2] = identificadorG2;
            matriztablero[1][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void H2_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorH2 = "negro";
                identificadorGlobal = "blanco";
                H2.ImageUrl = "negra.png";
                H2.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorH2 = "blanco";
                identificadorGlobal = "negro";
                H2.ImageUrl = "Blanca.png";
                H2.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila2;
            contenidotablero[1] = columnaH;
            contenidotablero[2] = identificadorH2;
            matriztablero[1][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void A3_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorA3 = "negro";
                identificadorGlobal = "blanco";
                A3.ImageUrl = "negra.png";
                A3.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorA3 = "blanco";
                identificadorGlobal = "negro";
                A3.ImageUrl = "Blanca.png";
                A3.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila3;
            contenidotablero[1] = columnaA;
            contenidotablero[2] = identificadorA3;
            matriztablero[2][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void B3_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorB3 = "negro";
                identificadorGlobal = "blanco";
                B3.ImageUrl = "negra.png";
                B3.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorB3 = "blanco";
                identificadorGlobal = "negro";
                B3.ImageUrl = "Blanca.png";
                B3.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila3;
            contenidotablero[1] = columnaB;
            contenidotablero[2] = identificadorB3;
            matriztablero[2][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void C3_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorC3 = "negro";
                identificadorGlobal = "blanco";
                C3.ImageUrl = "negra.png";
                C3.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorC3 = "blanco";
                identificadorGlobal = "negro";
                C3.ImageUrl = "Blanca.png";
                C3.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila3;
            contenidotablero[1] = columnaC;
            contenidotablero[2] = identificadorC3;
            matriztablero[2][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void D3_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorD3 = "negro";
                identificadorGlobal = "blanco";
                D3.ImageUrl = "negra.png";
                D3.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorD3 = "blanco";
                identificadorGlobal = "negro";
                D3.ImageUrl = "Blanca.png";
                D3.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila3;
            contenidotablero[1] = columnaD;
            contenidotablero[2] = identificadorD3;
            matriztablero[2][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void E3_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorE3 = "negro";
                identificadorGlobal = "blanco";
                E3.ImageUrl = "negra.png";
                E3.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorE3 = "blanco";
                identificadorGlobal = "negro";
                E3.ImageUrl = "Blanca.png";
                E3.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila3;
            contenidotablero[1] = columnaE;
            contenidotablero[2] = identificadorE3;
            matriztablero[2][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void F3_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorF3 = "negro";
                identificadorGlobal = "blanco";
                F3.ImageUrl = "negra.png";
                F3.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorF3 = "blanco";
                identificadorGlobal = "negro";
                F3.ImageUrl = "Blanca.png";
                F3.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila3;
            contenidotablero[1] = columnaF;
            contenidotablero[2] = identificadorF3;
            matriztablero[2][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void G3_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorG3 = "negro";
                identificadorGlobal = "blanco";
                G3.ImageUrl = "negra.png";
                G3.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorG3 = "blanco";
                identificadorGlobal = "negro";
                G3.ImageUrl = "Blanca.png";
                G3.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila3;
            contenidotablero[1] = columnaG;
            contenidotablero[2] = identificadorG3;
            matriztablero[2][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void H3_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorH3 = "negro";
                identificadorGlobal = "blanco";
                H3.ImageUrl = "negra.png";
                H3.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorH3 = "blanco";
                identificadorGlobal = "negro";
                H3.ImageUrl = "Blanca.png";
                H3.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila3;
            contenidotablero[1] = columnaH;
            contenidotablero[2] = identificadorH3;
            matriztablero[2][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void A4_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorA4 = "negro";
                identificadorGlobal = "blanco";
                A4.ImageUrl = "negra.png";
                A4.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorA4 = "blanco";
                identificadorGlobal = "negro";
                A4.ImageUrl = "Blanca.png";
                A4.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila4;
            contenidotablero[1] = columnaA;
            contenidotablero[2] = identificadorA4;
            matriztablero[3][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void B4_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorB4 = "negro";
                identificadorGlobal = "blanco";
                B4.ImageUrl = "negra.png";
                B4.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorB4 = "blanco";
                identificadorGlobal = "negro";
                B4.ImageUrl = "Blanca.png";
                B4.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila4;
            contenidotablero[1] = columnaB;
            contenidotablero[2] = identificadorB4;
            matriztablero[3][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void C4_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorC4 = "negro";
                identificadorGlobal = "blanco";
                C4.ImageUrl = "negra.png";
                C4.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorC4 = "blanco";
                identificadorGlobal = "negro";
                C4.ImageUrl = "Blanca.png";
                C4.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila4;
            contenidotablero[1] = columnaC;
            contenidotablero[2] = identificadorC4;
            matriztablero[3][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void D4_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorD4 = "negro";
                identificadorGlobal = "blanco";
                D4.ImageUrl = "negra.png";
                D4.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorD4 = "blanco";
                identificadorGlobal = "negro";
                D4.ImageUrl = "Blanca.png";
                D4.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila4;
            contenidotablero[1] = columnaB;
            contenidotablero[2] = identificadorB4;
            matriztablero[3][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void E4_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorE4 = "negro";
                identificadorGlobal = "blanco";
                E4.ImageUrl = "negra.png";
                E4.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorE4 = "blanco";
                identificadorGlobal = "negro";
                E4.ImageUrl = "Blanca.png";
                E4.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila4;
            contenidotablero[1] = columnaE;
            contenidotablero[2] = identificadorE4;
            matriztablero[3][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void F4_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorF4 = "negro";
                identificadorGlobal = "blanco";
                F4.ImageUrl = "negra.png";
                F4.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorF4 = "blanco";
                identificadorGlobal = "negro";
                F4.ImageUrl = "Blanca.png";
                F4.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila4;
            contenidotablero[1] = columnaF;
            contenidotablero[2] = identificadorF4;
            matriztablero[3][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void G4_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorG4 = "negro";
                identificadorGlobal = "blanco";
                G4.ImageUrl = "negra.png";
                G4.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorG4 = "blanco";
                identificadorGlobal = "negro";
                G4.ImageUrl = "Blanca.png";
                G4.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila4;
            contenidotablero[1] = columnaG;
            contenidotablero[2] = identificadorG4;
            matriztablero[3][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void H4_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorH4 = "negro";
                identificadorGlobal = "blanco";
                H4.ImageUrl = "negra.png";
                H4.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorH4 = "blanco";
                identificadorGlobal = "negro";
                H4.ImageUrl = "Blanca.png";
                H4.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila4;
            contenidotablero[1] = columnaH;
            contenidotablero[2] = identificadorH4;
            matriztablero[3][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void A5_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorA5 = "negro";
                identificadorGlobal = "blanco";
                A5.ImageUrl = "negra.png";
                A5.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorA5 = "blanco";
                identificadorGlobal = "negro";
                A5.ImageUrl = "Blanca.png";
                A5.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila5;
            contenidotablero[1] = columnaA;
            contenidotablero[2] = identificadorA5;
            matriztablero[4][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void B5_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorB5 = "negro";
                identificadorGlobal = "blanco";
                B5.ImageUrl = "negra.png";
                B5.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorB5 = "blanco";
                identificadorGlobal = "negro";
                B5.ImageUrl = "Blanca.png";
                B5.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila5;
            contenidotablero[1] = columnaB;
            contenidotablero[2] = identificadorB5;
            matriztablero[4][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void C5_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorC5 = "negro";
                identificadorGlobal = "blanco";
                C5.ImageUrl = "negra.png";
                C5.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorC5 = "blanco";
                identificadorGlobal = "negro";
                C5.ImageUrl = "Blanca.png";
                C5.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila5;
            contenidotablero[1] = columnaC;
            contenidotablero[2] = identificadorC5;
            matriztablero[4][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void D5_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorD5 = "negro";
                identificadorGlobal = "blanco";
                D5.ImageUrl = "negra.png";
                D5.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorD5 = "blanco";
                identificadorGlobal = "negro";
                D5.ImageUrl = "Blanca.png";
                D5.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila5;
            contenidotablero[1] = columnaD;
            contenidotablero[2] = identificadorD5;
            matriztablero[4][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void E5_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorE5 = "negro";
                identificadorGlobal = "blanco";
                E5.ImageUrl = "negra.png";
                E5.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorE5 = "blanco";
                identificadorGlobal = "negro";
                E5.ImageUrl = "Blanca.png";
                E5.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila5;
            contenidotablero[1] = columnaE;
            contenidotablero[2] = identificadorE5;
            matriztablero[4][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void F5_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorF5 = "negro";
                identificadorGlobal = "blanco";
                F5.ImageUrl = "negra.png";
                F5.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorF5 = "blanco";
                identificadorGlobal = "negro";
                F5.ImageUrl = "Blanca.png";
                F5.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila5;
            contenidotablero[1] = columnaF;
            contenidotablero[2] = identificadorF5;
            matriztablero[4][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void G5_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorG5 = "negro";
                identificadorGlobal = "blanco";
                G5.ImageUrl = "negra.png";
                G5.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorG5 = "blanco";
                identificadorGlobal = "negro";
                G5.ImageUrl = "Blanca.png";
                G5.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila5;
            contenidotablero[1] = columnaG;
            contenidotablero[2] = identificadorG5;
            matriztablero[4][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void H5_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorH5 = "negro";
                identificadorGlobal = "blanco";
                H5.ImageUrl = "negra.png";
                H5.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorH5 = "blanco";
                identificadorGlobal = "negro";
                H5.ImageUrl = "Blanca.png";
                H5.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila5;
            contenidotablero[1] = columnaH;
            contenidotablero[2] = identificadorH5;
            matriztablero[4][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void A6_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorA6 = "negro";
                identificadorGlobal = "blanco";
                A6.ImageUrl = "negra.png";
                A6.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorA6 = "blanco";
                identificadorGlobal = "negro";
                A6.ImageUrl = "Blanca.png";
                A6.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila6;
            contenidotablero[1] = columnaA;
            contenidotablero[2] = identificadorA6;
            matriztablero[5][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void B6_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorB6 = "negro";
                identificadorGlobal = "blanco";
                B6.ImageUrl = "negra.png";
                B6.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorB6 = "blanco";
                identificadorGlobal = "negro";
                B6.ImageUrl = "Blanca.png";
                B6.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila6;
            contenidotablero[1] = columnaB;
            contenidotablero[2] = identificadorB6;
            matriztablero[5][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void C6_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorC6 = "negro";
                identificadorGlobal = "blanco";
                C6.ImageUrl = "negra.png";
                C6.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorC6 = "blanco";
                identificadorGlobal = "negro";
                C6.ImageUrl = "Blanca.png";
                C6.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila6;
            contenidotablero[1] = columnaC;
            contenidotablero[2] = identificadorC6;
            matriztablero[5][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void D6_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorD6 = "negro";
                identificadorGlobal = "blanco";
                D6.ImageUrl = "negra.png";
                D6.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorD6 = "blanco";
                identificadorGlobal = "negro";
                D6.ImageUrl = "Blanca.png";
                D6.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila6;
            contenidotablero[1] = columnaD;
            contenidotablero[2] = identificadorD6;
            matriztablero[5][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void E6_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorE6 = "negro";
                identificadorGlobal = "blanco";
                E6.ImageUrl = "negra.png";
                E6.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorE6 = "blanco";
                identificadorGlobal = "negro";
                E6.ImageUrl = "Blanca.png";
                E6.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila6;
            contenidotablero[1] = columnaE;
            contenidotablero[2] = identificadorE6;
            matriztablero[5][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2]; ;
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void F6_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorF6 = "negro";
                identificadorGlobal = "blanco";
                F6.ImageUrl = "negra.png";
                F6.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorF6 = "blanco";
                identificadorGlobal = "negro";
                F6.ImageUrl = "Blanca.png";
                F6.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila6;
            contenidotablero[1] = columnaF;
            contenidotablero[2] = identificadorF6;
            matriztablero[5][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void G6_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorG6 = "negro";
                identificadorGlobal = "blanco";
                G6.ImageUrl = "negra.png";
                G6.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorG6 = "blanco";
                identificadorGlobal = "negro";
                G6.ImageUrl = "Blanca.png";
                G6.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila6;
            contenidotablero[1] = columnaG;
            contenidotablero[2] = identificadorG6;
            matriztablero[5][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void H6_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorH6 = "negro";
                identificadorGlobal = "blanco";
                H6.ImageUrl = "negra.png";
                H6.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorH6 = "blanco";
                identificadorGlobal = "negro";
                H6.ImageUrl = "Blanca.png";
                H6.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila6;
            contenidotablero[1] = columnaH;
            contenidotablero[2] = identificadorH6;
            matriztablero[5][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void A7_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorA7 = "negro";
                identificadorGlobal = "blanco";
                A7.ImageUrl = "negra.png";
                A7.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorA7 = "blanco";
                identificadorGlobal = "negro";
                A7.ImageUrl = "Blanca.png";
                A7.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila7;
            contenidotablero[1] = columnaA;
            contenidotablero[2] = identificadorA7;
            matriztablero[6][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void B7_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorB7 = "negro";
                identificadorGlobal = "blanco";
                B7.ImageUrl = "negra.png";
                B7.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorB7 = "blanco";
                identificadorGlobal = "negro";
                B7.ImageUrl = "Blanca.png";
                B7.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila7;
            contenidotablero[1] = columnaB;
            contenidotablero[2] = identificadorB7;
            matriztablero[6][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void C7_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorC7 = "negro";
                identificadorGlobal = "blanco";
                C7.ImageUrl = "negra.png";
                C7.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorC7 = "blanco";
                identificadorGlobal = "negro";
                C7.ImageUrl = "Blanca.png";
                C7.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila7;
            contenidotablero[1] = columnaC;
            contenidotablero[2] = identificadorC7;
            matriztablero[6][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void D7_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorD7 = "negro";
                identificadorGlobal = "blanco";
                D7.ImageUrl = "negra.png";
                D7.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorD7 = "blanco";
                identificadorGlobal = "negro";
                D7.ImageUrl = "Blanca.png";
                D7.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila7;
            contenidotablero[1] = columnaD;
            contenidotablero[2] = identificadorD7;
            matriztablero[6][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void E7_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorE7 = "negro";
                identificadorGlobal = "blanco";
                E7.ImageUrl = "negra.png";
                E7.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorE7 = "blanco";
                identificadorGlobal = "negro";
                E7.ImageUrl = "Blanca.png";
                E7.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila7;
            contenidotablero[1] = columnaE;
            contenidotablero[2] = identificadorE7;
            matriztablero[6][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void F7_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorF7 = "negro";
                identificadorGlobal = "blanco";
                F7.ImageUrl = "negra.png";
                F7.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorF7 = "blanco";
                identificadorGlobal = "negro";
                F7.ImageUrl = "Blanca.png";
                F7.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila7;
            contenidotablero[1] = columnaF;
            contenidotablero[2] = identificadorF7;
            matriztablero[6][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void G7_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorG7 = "negro";
                identificadorGlobal = "blanco";
                G7.ImageUrl = "negra.png";
                G7.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorG7 = "blanco";
                identificadorGlobal = "negro";
                G7.ImageUrl = "Blanca.png";
                G7.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila7;
            contenidotablero[1] = columnaG;
            contenidotablero[2] = identificadorG7;
            matriztablero[6][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void H7_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorH7 = "negro";
                identificadorGlobal = "blanco";
                H7.ImageUrl = "negra.png";
                H7.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorH7 = "blanco";
                identificadorGlobal = "negro";
                H7.ImageUrl = "Blanca.png";
                H7.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila7;
            contenidotablero[1] = columnaH;
            contenidotablero[2] = identificadorH7;
            matriztablero[6][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void A8_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorA8 = "negro";
                identificadorGlobal = "blanco";
                A8.ImageUrl = "negra.png";
                A8.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorA8 = "blanco";
                identificadorGlobal = "negro";
                A8.ImageUrl = "Blanca.png";
                A8.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila8;
            contenidotablero[1] = columnaA;
            contenidotablero[2] = identificadorA8;
            matriztablero[7][0] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void B8_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorB8 = "negro";
                identificadorGlobal = "blanco";
                B8.ImageUrl = "negra.png";
                B8.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorB8 = "blanco";
                identificadorGlobal = "negro";
                B8.ImageUrl = "Blanca.png";
                B8.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila8;
            contenidotablero[1] = columnaB;
            contenidotablero[2] = identificadorB8;
            matriztablero[7][1] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void C8_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorC8 = "negro";
                identificadorGlobal = "blanco";
                C8.ImageUrl = "negra.png";
                C8.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorC8 = "blanco";
                identificadorGlobal = "negro";
                C8.ImageUrl = "Blanca.png";
                C8.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila8;
            contenidotablero[1] = columnaC;
            contenidotablero[2] = identificadorC8;
            matriztablero[7][2] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void D8_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorD8 = "negro";
                identificadorGlobal = "blanco";
                D8.ImageUrl = "negra.png";
                D8.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorD8 = "blanco";
                identificadorGlobal = "negro";
                D8.ImageUrl = "Blanca.png";
                D8.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila8;
            contenidotablero[1] = columnaD;
            contenidotablero[2] = identificadorD8;
            matriztablero[7][3] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void E8_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorE8 = "negro";
                identificadorGlobal = "blanco";
                E8.ImageUrl = "negra.png";
                E8.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorE8 = "blanco";
                identificadorGlobal = "negro";
                E8.ImageUrl = "Blanca.png";
                E8.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila8;
            contenidotablero[1] = columnaE;
            contenidotablero[2] = identificadorE8;
            matriztablero[7][4] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void F8_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorF8 = "negro";
                identificadorGlobal = "blanco";
                F8.ImageUrl = "negra.png";
                F8.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorF8 = "blanco";
                identificadorGlobal = "negro";
                F8.ImageUrl = "Blanca.png";
                F8.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila8;
            contenidotablero[1] = columnaF;
            contenidotablero[2] = identificadorF8;
            matriztablero[7][5] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void G8_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorG8 = "negro";
                identificadorGlobal = "blanco";
                G8.ImageUrl = "negra.png";
                G8.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorG8 = "blanco";
                identificadorGlobal = "negro";
                G8.ImageUrl = "Blanca.png";
                G8.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila8;
            contenidotablero[1] = columnaG;
            contenidotablero[2] = identificadorG8;
            matriztablero[7][6] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void H8_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorGlobal.Equals("negro"))
            {
                contadornegro++;
                identificadorH8 = "negro";
                identificadorGlobal = "blanco";
                H8.ImageUrl = "negra.png";
                H8.Enabled = false;
            }
            else if (identificadorGlobal.Equals("blanco"))
            {
                contadorblanco++;
                identificadorH8 = "blanco";
                identificadorGlobal = "negro";
                H8.ImageUrl = "Blanca.png";
                H8.Enabled = false;
            }
            TextBox1.Text = contadornegro.ToString();
            TextBox2.Text = contadorblanco.ToString();
            contenidotablero[0] = fila8;
            contenidotablero[1] = columnaH;
            contenidotablero[2] = identificadorH8;
            matriztablero[7][7] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
            EsquemaTablero();
            validarMovimiento();
            cerrarPartida();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string [] guardarseparaciones;
            XDocument crearXML = new XDocument(new XDeclaration("1.0", "utf-8", null));
            XElement raiz = new XElement("Tablero");
            crearXML.Add(raiz);

            /*Manejar con datos de matriz*/
            for (int i = 0; i<matriztablero.Length; i++)
            {
                for (int j = 0; j < matriztablero[i].Length; j++)
                {
                    string guardarcontenido = matriztablero[i][j].ToString();
                    guardarseparaciones = guardarcontenido.Split(',');
                    if (guardarseparaciones[2].ToString() != "")
                    {
                        XElement fichanueva = new XElement("ficha");
                        if (i == 0 && j == 0)
                        {
                            fichanueva.Add(new XElement("color", identificadorA1));
                            fichanueva.Add(new XElement("columna", columnaA));
                            fichanueva.Add(new XElement("fila", fila1));
                        }
                        if (i == 0 && j == 1)
                        {
                            fichanueva.Add(new XElement("color", identificadorB1));
                            fichanueva.Add(new XElement("columna", columnaB));
                            fichanueva.Add(new XElement("fila", fila1));
                        }
                        if (i == 0 && j == 2)
                        {
                            fichanueva.Add(new XElement("color", identificadorC1));
                            fichanueva.Add(new XElement("columna", columnaC));
                            fichanueva.Add(new XElement("fila", fila1));

                        }
                        if (i == 0 && j == 3)
                        {
                            fichanueva.Add(new XElement("color", identificadorD1));
                            fichanueva.Add(new XElement("columna", columnaD));
                            fichanueva.Add(new XElement("fila", fila1));

                        }
                        if (i == 0 && j == 4)
                        {
                            fichanueva.Add(new XElement("color", identificadorE1));
                            fichanueva.Add(new XElement("columna", columnaE));
                            fichanueva.Add(new XElement("fila", fila1));

                        }
                        if (i == 0 && j == 5)
                        {
                            fichanueva.Add(new XElement("color", identificadorF1));
                            fichanueva.Add(new XElement("columna", columnaF));
                            fichanueva.Add(new XElement("fila", fila1));

                        }
                        if (i == 0 && j == 6)
                        {
                            fichanueva.Add(new XElement("color", identificadorG1));
                            fichanueva.Add(new XElement("columna", columnaG));
                            fichanueva.Add(new XElement("fila", fila1));

                        }
                        if (i == 0 && j == 7)
                        {
                            fichanueva.Add(new XElement("color", identificadorH1));
                            fichanueva.Add(new XElement("columna", columnaH));
                            fichanueva.Add(new XElement("fila", fila1));

                        }
                        if (i == 1 && j == 0)
                        {
                            fichanueva.Add(new XElement("color", identificadorA2));
                            fichanueva.Add(new XElement("columna", columnaA));
                            fichanueva.Add(new XElement("fila", fila2));

                        }
                        if (i == 1 && j == 1)
                        {
                            fichanueva.Add(new XElement("color", identificadorB2));
                            fichanueva.Add(new XElement("columna", columnaB));
                            fichanueva.Add(new XElement("fila", fila2));

                        }
                        if (i == 1 && j == 2)
                        {
                            fichanueva.Add(new XElement("color", identificadorC2));
                            fichanueva.Add(new XElement("columna", columnaC));
                            fichanueva.Add(new XElement("fila", fila2));

                        }
                        if (i == 1 && j == 3)
                        {
                            fichanueva.Add(new XElement("color", identificadorD2));
                            fichanueva.Add(new XElement("columna", columnaD));
                            fichanueva.Add(new XElement("fila", fila2));

                        }
                        if (i == 1 && j == 4)
                        {
                            fichanueva.Add(new XElement("color", identificadorE2));
                            fichanueva.Add(new XElement("columna", columnaE));
                            fichanueva.Add(new XElement("fila", fila2));

                        }
                        if (i == 1 && j == 5)
                        {
                            fichanueva.Add(new XElement("color", identificadorF2));
                            fichanueva.Add(new XElement("columna", columnaF));
                            fichanueva.Add(new XElement("fila", fila2));

                        }
                        if (i == 1 && j == 6)
                        {
                            fichanueva.Add(new XElement("color", identificadorG2));
                            fichanueva.Add(new XElement("columna", columnaG));
                            fichanueva.Add(new XElement("fila", fila2));

                        }
                        if (i == 1 && j == 7)
                        {
                            fichanueva.Add(new XElement("color", identificadorH2));
                            fichanueva.Add(new XElement("columna", columnaH));
                            fichanueva.Add(new XElement("fila", fila2));

                        }
                        if (i == 2 && j == 0)
                        {
                            fichanueva.Add(new XElement("color", identificadorA3));
                            fichanueva.Add(new XElement("columna", columnaA));
                            fichanueva.Add(new XElement("fila", fila3));

                        }
                        if (i == 2 && j == 1)
                        {
                            fichanueva.Add(new XElement("color", identificadorB3));
                            fichanueva.Add(new XElement("columna", columnaB));
                            fichanueva.Add(new XElement("fila", fila3));

                        }
                        if (i == 2 && j == 2)
                        {
                            fichanueva.Add(new XElement("color", identificadorC3));
                            fichanueva.Add(new XElement("columna", columnaC));
                            fichanueva.Add(new XElement("fila", fila3));

                        }
                        if (i == 2 && j == 3)
                        {
                            fichanueva.Add(new XElement("color", identificadorD3));
                            fichanueva.Add(new XElement("columna", columnaD));
                            fichanueva.Add(new XElement("fila", fila3));

                        }
                        if (i == 2 && j == 4)
                        {
                            fichanueva.Add(new XElement("color", identificadorE3));
                            fichanueva.Add(new XElement("columna", columnaE));
                            fichanueva.Add(new XElement("fila", fila3));

                        }
                        if (i == 2 && j == 5)
                        {
                            fichanueva.Add(new XElement("color", identificadorF3));
                            fichanueva.Add(new XElement("columna", columnaF));
                            fichanueva.Add(new XElement("fila", fila3));

                        }
                        if (i == 2 && j == 6)
                        {
                            fichanueva.Add(new XElement("color", identificadorG3));
                            fichanueva.Add(new XElement("columna", columnaG));
                            fichanueva.Add(new XElement("fila", fila3));

                        }
                        if (i == 2 && j == 7)
                        {
                            fichanueva.Add(new XElement("color", identificadorH3));
                            fichanueva.Add(new XElement("columna", columnaH));
                            fichanueva.Add(new XElement("fila", fila3));

                        }
                        if (i == 3 && j == 0)
                        {
                            fichanueva.Add(new XElement("color", identificadorA4));
                            fichanueva.Add(new XElement("columna", columnaA));
                            fichanueva.Add(new XElement("fila", fila4));

                        }
                        if (i == 3 && j == 1)
                        {
                            fichanueva.Add(new XElement("color", identificadorB4));
                            fichanueva.Add(new XElement("columna", columnaB));
                            fichanueva.Add(new XElement("fila", fila4));

                        }
                        if (i == 3 && j == 2)
                        {
                            fichanueva.Add(new XElement("color", identificadorC4));
                            fichanueva.Add(new XElement("columna", columnaC));
                            fichanueva.Add(new XElement("fila", fila4));

                        }
                        if (i == 3 && j == 3)
                        {
                            fichanueva.Add(new XElement("color", identificadorD4));
                            fichanueva.Add(new XElement("columna", columnaD));
                            fichanueva.Add(new XElement("fila", fila4));

                        }
                        if (i == 3 && j == 4)
                        {
                            fichanueva.Add(new XElement("color", identificadorE4));
                            fichanueva.Add(new XElement("columna", columnaE));
                            fichanueva.Add(new XElement("fila", fila4));

                        }
                        if (i == 3 && j == 5)
                        {
                            fichanueva.Add(new XElement("color", identificadorF4));
                            fichanueva.Add(new XElement("columna", columnaF));
                            fichanueva.Add(new XElement("fila", fila4));

                        }
                        if (i == 3 && j == 6)
                        {
                            fichanueva.Add(new XElement("color", identificadorG4));
                            fichanueva.Add(new XElement("columna", columnaG));
                            fichanueva.Add(new XElement("fila", fila4));

                        }
                        if (i == 3 && j == 7)
                        {
                            fichanueva.Add(new XElement("color", identificadorH4));
                            fichanueva.Add(new XElement("columna", columnaH));
                            fichanueva.Add(new XElement("fila", fila4));

                        }
                        if (i == 4 && j == 0)
                        {
                            fichanueva.Add(new XElement("color", identificadorA5));
                            fichanueva.Add(new XElement("columna", columnaA));
                            fichanueva.Add(new XElement("fila", fila5));

                        }
                        if (i == 4 && j == 1)
                        {
                            fichanueva.Add(new XElement("color", identificadorB5));
                            fichanueva.Add(new XElement("columna", columnaB));
                            fichanueva.Add(new XElement("fila", fila5));

                        }
                        if (i == 4 && j == 2)
                        {
                            fichanueva.Add(new XElement("color", identificadorC5));
                            fichanueva.Add(new XElement("columna", columnaC));
                            fichanueva.Add(new XElement("fila", fila5));

                        }
                        if (i == 4 && j == 3)
                        {
                            fichanueva.Add(new XElement("color", identificadorD5));
                            fichanueva.Add(new XElement("columna", columnaD));
                            fichanueva.Add(new XElement("fila", fila5));

                        }
                        if (i == 4 && j == 4)
                        {
                            fichanueva.Add(new XElement("color", identificadorE5));
                            fichanueva.Add(new XElement("columna", columnaE));
                            fichanueva.Add(new XElement("fila", fila5));

                        }
                        if (i == 4 && j == 5)
                        {
                            fichanueva.Add(new XElement("color", identificadorF5));
                            fichanueva.Add(new XElement("columna", columnaF));
                            fichanueva.Add(new XElement("fila", fila5));

                        }
                        if (i == 4 && j == 6)
                        {
                            fichanueva.Add(new XElement("color", identificadorG5));
                            fichanueva.Add(new XElement("columna", columnaG));
                            fichanueva.Add(new XElement("fila", fila5));

                        }
                        if (i == 4 && j == 7)
                        {
                            fichanueva.Add(new XElement("color", identificadorH5));
                            fichanueva.Add(new XElement("columna", columnaH));
                            fichanueva.Add(new XElement("fila", fila5));

                        }
                        if (i == 5 && j == 0)
                        {
                            fichanueva.Add(new XElement("color", identificadorA6));
                            fichanueva.Add(new XElement("columna", columnaA));
                            fichanueva.Add(new XElement("fila", fila6));

                        }
                        if (i == 5 && j == 1)
                        {
                            fichanueva.Add(new XElement("color", identificadorB6));
                            fichanueva.Add(new XElement("columna", columnaB));
                            fichanueva.Add(new XElement("fila", fila6));

                        }
                        if (i == 5 && j == 2)
                        {
                            fichanueva.Add(new XElement("color", identificadorC6));
                            fichanueva.Add(new XElement("columna", columnaC));
                            fichanueva.Add(new XElement("fila", fila6));

                        }
                        if (i == 5 && j == 3)
                        {
                            fichanueva.Add(new XElement("color", identificadorD6));
                            fichanueva.Add(new XElement("columna", columnaD));
                            fichanueva.Add(new XElement("fila", fila6));

                        }
                        if (i == 5 && j == 4)
                        {
                            fichanueva.Add(new XElement("color", identificadorE6));
                            fichanueva.Add(new XElement("columna", columnaE));
                            fichanueva.Add(new XElement("fila", fila6));

                        }
                        if (i == 5 && j == 5)
                        {
                            fichanueva.Add(new XElement("color", identificadorF6));
                            fichanueva.Add(new XElement("columna", columnaF));
                            fichanueva.Add(new XElement("fila", fila6));

                        }
                        if (i == 5 && j == 6)
                        {
                            fichanueva.Add(new XElement("color", identificadorG6));
                            fichanueva.Add(new XElement("columna", columnaG));
                            fichanueva.Add(new XElement("fila", fila6));

                        }
                        if (i == 5 && j == 7)
                        {
                            fichanueva.Add(new XElement("color", identificadorH6));
                            fichanueva.Add(new XElement("columna", columnaH));
                            fichanueva.Add(new XElement("fila", fila6));

                        }
                        if (i == 6 && j == 0)
                        {
                            fichanueva.Add(new XElement("color", identificadorA7));
                            fichanueva.Add(new XElement("columna", columnaA));
                            fichanueva.Add(new XElement("fila", fila7));

                        }
                        if (i == 6 && j == 1)
                        {
                            fichanueva.Add(new XElement("color", identificadorB7));
                            fichanueva.Add(new XElement("columna", columnaB));
                            fichanueva.Add(new XElement("fila", fila7));

                        }
                        if (i == 6 && j == 2)
                        {
                            fichanueva.Add(new XElement("color", identificadorC7));
                            fichanueva.Add(new XElement("columna", columnaC));
                            fichanueva.Add(new XElement("fila", fila7));

                        }
                        if (i == 6 && j == 3)
                        {
                            fichanueva.Add(new XElement("color", identificadorD7));
                            fichanueva.Add(new XElement("columna", columnaD));
                            fichanueva.Add(new XElement("fila", fila7));

                        }
                        if (i == 6 && j == 4)
                        {
                            fichanueva.Add(new XElement("color", identificadorE7));
                            fichanueva.Add(new XElement("columna", columnaE));
                            fichanueva.Add(new XElement("fila", fila7));

                        }
                        if (i == 6 && j == 5)
                        {
                            fichanueva.Add(new XElement("color", identificadorF7));
                            fichanueva.Add(new XElement("columna", columnaF));
                            fichanueva.Add(new XElement("fila", fila7));

                        }
                        if (i == 6 && j == 6)
                        {
                            fichanueva.Add(new XElement("color", identificadorG7));
                            fichanueva.Add(new XElement("columna", columnaG));
                            fichanueva.Add(new XElement("fila", fila7));

                        }
                        if (i == 6 && j == 7)
                        {
                            fichanueva.Add(new XElement("color", identificadorH7));
                            fichanueva.Add(new XElement("columna", columnaH));
                            fichanueva.Add(new XElement("fila", fila7));

                        }
                        if (i == 7 && j == 0)
                        {
                            fichanueva.Add(new XElement("color", identificadorA8));
                            fichanueva.Add(new XElement("columna", columnaA));
                            fichanueva.Add(new XElement("fila", fila8));

                        }
                        if (i == 7 && j == 1)
                        {
                            fichanueva.Add(new XElement("color", identificadorB8));
                            fichanueva.Add(new XElement("columna", columnaB));
                            fichanueva.Add(new XElement("fila", fila8));

                        }
                        if (i == 7 && j == 2)
                        {
                            fichanueva.Add(new XElement("color", identificadorC8));
                            fichanueva.Add(new XElement("columna", columnaC));
                            fichanueva.Add(new XElement("fila", fila8));

                        }
                        if (i == 7 && j == 3)
                        {
                            fichanueva.Add(new XElement("color", identificadorD8));
                            fichanueva.Add(new XElement("columna", columnaD));
                            fichanueva.Add(new XElement("fila", fila8));

                        }
                        if (i == 7 && j == 4)
                        {
                            fichanueva.Add(new XElement("color", identificadorE8));
                            fichanueva.Add(new XElement("columna", columnaE));
                            fichanueva.Add(new XElement("fila", fila8));

                        }
                        if (i == 7 && j == 5)
                        {
                            fichanueva.Add(new XElement("color", identificadorF8));
                            fichanueva.Add(new XElement("columna", columnaF));
                            fichanueva.Add(new XElement("fila", fila8));

                        }
                        if (i == 7 && j == 6)
                        {
                            fichanueva.Add(new XElement("color", identificadorG8));
                            fichanueva.Add(new XElement("columna", columnaG));
                            fichanueva.Add(new XElement("fila", fila8));

                        }
                        if (i == 7 && j == 7)
                        {
                            fichanueva.Add(new XElement("color", identificadorH8));
                            fichanueva.Add(new XElement("columna", columnaH));
                            fichanueva.Add(new XElement("fila", fila8));

                        }
                        raiz.Add(fichanueva);
                    }
                }
            }
            crearXML.Save(@"C:\Users\mario\OneDrive\Documentos\GitHub\Proyecto1\ProyectoEntregable2\XMLArchivos\Archivo" + ProyectoEntregable2.Login.UsuarioLogeado + contadorxml.ToString() + ".xml");
            Response.Redirect("PaginaPrincipal.aspx");

        }

        protected void Button376_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaPrincipal.aspx");
            identificadorA1 = "";
            identificadorB1 = "";
            identificadorC1 = "";
            identificadorD1 = "";
            identificadorE1 = "";
            identificadorF1 = "";
            identificadorG1 = "";
            identificadorH1 = "";
            identificadorA2 = "";
            identificadorB2 = "";
            identificadorC2 = "";
            identificadorD2 = "";
            identificadorE2 = "";
            identificadorF2 = "";
            identificadorG2 = "";
            identificadorH2 = "";
            identificadorA3 = "";
            identificadorB3 = "";
            identificadorC3 = "";
            identificadorD3 = "";
            identificadorE3 = "";
            identificadorF3 = "";
            identificadorG3 = "";
            identificadorH3 = "";
            identificadorA4 = "";
            identificadorB4 = "";
            identificadorC4 = "";
            identificadorD4 = "blanco";
            identificadorE4 = "negro";
            identificadorF4 = "";
            identificadorG4 = "";
            identificadorH4 = "";
            identificadorA5 = "";
            identificadorB5 = "";
            identificadorC5 = "";
            identificadorD5 = "negro";
            identificadorE5 = "blanco";
            identificadorF5 = "";
            identificadorG5 = "";
            identificadorH5 = "";
            identificadorA6 = "";
            identificadorB6 = "";
            identificadorC6 = "";
            identificadorD6 = "";
            identificadorE6 = "";
            identificadorF6 = "";
            identificadorG6 = "";
            identificadorH6 = "";
            identificadorA7 = "";
            identificadorB7 = "";
            identificadorC7 = "";
            identificadorD7 = "";
            identificadorE7 = "";
            identificadorF7 = "";
            identificadorG7 = "";
            identificadorH7 = "";
            identificadorA8 = "";
            identificadorB8 = "";
            identificadorC8 = "";
            identificadorD8 = "";
            identificadorE8 = "";
            identificadorF8 = "";
            identificadorG8 = "";
            identificadorH8 = "";
        }


        protected static void EsquemaTablero()
        {
            /*Cargando valores de tablero (Posicion x, posicion y, estado)*/
            matriztablero = new string[8][];
            for (int i = 0; i < matriztablero.Length; i++)
            {
                matriztablero[i] = new string[8];
            }
                contenidotablero = new string[3];

            for (int j = 0; j < matriztablero.Length; j++)
            {
                for (int k = 0; k < matriztablero[j].Length; k++)
                {
                    if (matriztablero[j][k] == null)
                    {
                        if (j == 0 && k == 0)
                        {
                            contenidotablero[0] = fila1;
                            contenidotablero[1] = columnaA;
                            contenidotablero[2] = identificadorA1;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];

                        }
                        if (j == 0 && k == 1)
                        {
                            contenidotablero[0] = fila1;
                            contenidotablero[1] = columnaB;
                            contenidotablero[2] = identificadorB1;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 0 && k == 2)
                        {
                            contenidotablero[0] = fila1;
                            contenidotablero[1] = columnaC;
                            contenidotablero[2] = identificadorC1;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 0 && k == 3)
                        {
                            contenidotablero[0] = fila1;
                            contenidotablero[1] = columnaD;
                            contenidotablero[2] = identificadorD1;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 0 && k == 4)
                        {
                            contenidotablero[0] = fila1;
                            contenidotablero[1] = columnaE;
                            contenidotablero[2] = identificadorE1;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 0 && k == 5)
                        {
                            contenidotablero[0] = fila1;
                            contenidotablero[1] = columnaF;
                            contenidotablero[2] = identificadorF1;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 0 && k == 6)
                        {
                            contenidotablero[0] = fila1;
                            contenidotablero[1] = columnaG;
                            contenidotablero[2] = identificadorG1;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 0 && k == 7)
                        {
                            contenidotablero[0] = fila1;
                            contenidotablero[1] = columnaH;
                            contenidotablero[2] = identificadorH1;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 1 && k == 0)
                        {
                            contenidotablero[0] = fila2;
                            contenidotablero[1] = columnaA;
                            contenidotablero[2] = identificadorA2;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 1 && k == 1)
                        {
                            contenidotablero[0] = fila2;
                            contenidotablero[1] = columnaB;
                            contenidotablero[2] = identificadorB2;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 1 && k == 2)
                        {
                            contenidotablero[0] = fila2;
                            contenidotablero[1] = columnaC;
                            contenidotablero[2] = identificadorC2;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 1 && k == 3)
                        {
                            contenidotablero[0] = fila2;
                            contenidotablero[1] = columnaD;
                            contenidotablero[2] = identificadorD2;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 1 && k == 4)
                        {
                            contenidotablero[0] = fila2;
                            contenidotablero[1] = columnaE;
                            contenidotablero[2] = identificadorE2;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 1 && k == 5)
                        {
                            contenidotablero[0] = fila2;
                            contenidotablero[1] = columnaF;
                            contenidotablero[2] = identificadorF2;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 1 && k == 6)
                        {
                            contenidotablero[0] = fila2;
                            contenidotablero[1] = columnaG;
                            contenidotablero[2] = identificadorG2;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 1 && k == 7)
                        {
                            contenidotablero[0] = fila2;
                            contenidotablero[1] = columnaH;
                            contenidotablero[2] = identificadorH2;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 2 && k == 0)
                        {
                            contenidotablero[0] = fila3;
                            contenidotablero[1] = columnaA;
                            contenidotablero[2] = identificadorA3;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 2 && k == 1)
                        {
                            contenidotablero[0] = fila3;
                            contenidotablero[1] = columnaB;
                            contenidotablero[2] = identificadorB3;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 2 && k == 2)
                        {
                            contenidotablero[0] = fila3;
                            contenidotablero[1] = columnaC;
                            contenidotablero[2] = identificadorC3;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 2 && k == 3)
                        {
                            contenidotablero[0] = fila3;
                            contenidotablero[1] = columnaD;
                            contenidotablero[2] = identificadorD3;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 2 && k == 4)
                        {
                            contenidotablero[0] = fila3;
                            contenidotablero[1] = columnaE;
                            contenidotablero[2] = identificadorE3;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 2 && k == 5)
                        {
                            contenidotablero[0] = fila3;
                            contenidotablero[1] = columnaF;
                            contenidotablero[2] = identificadorF3;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 2 && k == 6)
                        {
                            contenidotablero[0] = fila3;
                            contenidotablero[1] = columnaG;
                            contenidotablero[2] = identificadorG3;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 2 && k == 7)
                        {
                            contenidotablero[0] = fila3;
                            contenidotablero[1] = columnaH;
                            contenidotablero[2] = identificadorH3;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 3 && k == 0)
                        {
                            contenidotablero[0] = fila4;
                            contenidotablero[1] = columnaA;
                            contenidotablero[2] = identificadorA4;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 3 && k == 1)
                        {
                            contenidotablero[0] = fila4;
                            contenidotablero[1] = columnaB;
                            contenidotablero[2] = identificadorB4;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 3 && k == 2)
                        {
                            contenidotablero[0] = fila4;
                            contenidotablero[1] = columnaC;
                            contenidotablero[2] = identificadorC4;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 3 && k == 3)
                        {
                            contenidotablero[0] = fila4;
                            contenidotablero[1] = columnaD;
                            contenidotablero[2] = identificadorD4;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 3 && k == 4)
                        {
                            contenidotablero[0] = fila4;
                            contenidotablero[1] = columnaE;
                            contenidotablero[2] = identificadorE4;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 3 && k == 5)
                        {
                            contenidotablero[0] = fila4;
                            contenidotablero[1] = columnaF;
                            contenidotablero[2] = identificadorF4;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 3 && k == 6)
                        {
                            contenidotablero[0] = fila4;
                            contenidotablero[1] = columnaG;
                            contenidotablero[2] = identificadorG4;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 3 && k == 7)
                        {
                            contenidotablero[0] = fila4;
                            contenidotablero[1] = columnaH;
                            contenidotablero[2] = identificadorH4;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 4 && k == 0)
                        {
                            contenidotablero[0] = fila5;
                            contenidotablero[1] = columnaA;
                            contenidotablero[2] = identificadorA5;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 4 && k == 1)
                        {
                            contenidotablero[0] = fila5;
                            contenidotablero[1] = columnaB;
                            contenidotablero[2] = identificadorB5;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 4 && k == 2)
                        {
                            contenidotablero[0] = fila5;
                            contenidotablero[1] = columnaC;
                            contenidotablero[2] = identificadorC5;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 4 && k == 3)
                        {
                            contenidotablero[0] = fila5;
                            contenidotablero[1] = columnaD;
                            contenidotablero[2] = identificadorD5;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 4 && k == 4)
                        {
                            contenidotablero[0] = fila5;
                            contenidotablero[1] = columnaE;
                            contenidotablero[2] = identificadorE5;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 4 && k == 5)
                        {
                            contenidotablero[0] = fila5;
                            contenidotablero[1] = columnaF;
                            contenidotablero[2] = identificadorF5;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 4 && k == 6)
                        {
                            contenidotablero[0] = fila5;
                            contenidotablero[1] = columnaG;
                            contenidotablero[2] = identificadorG5;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 4 && k == 7)
                        {
                            contenidotablero[0] = fila5;
                            contenidotablero[1] = columnaH;
                            contenidotablero[2] = identificadorH5;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 5 && k == 0)
                        {
                            contenidotablero[0] = fila6;
                            contenidotablero[1] = columnaA;
                            contenidotablero[2] = identificadorA6;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 5 && k == 1)
                        {
                            contenidotablero[0] = fila6;
                            contenidotablero[1] = columnaB;
                            contenidotablero[2] = identificadorB6;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 5 && k == 2)
                        {
                            contenidotablero[0] = fila6;
                            contenidotablero[1] = columnaC;
                            contenidotablero[2] = identificadorC6;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 5 && k == 3)
                        {
                            contenidotablero[0] = fila6;
                            contenidotablero[1] = columnaD;
                            contenidotablero[2] = identificadorD6;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 5 && k == 4)
                        {
                            contenidotablero[0] = fila6;
                            contenidotablero[1] = columnaE;
                            contenidotablero[2] = identificadorE6;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 5 && k == 5)
                        {
                            contenidotablero[0] = fila6;
                            contenidotablero[1] = columnaF;
                            contenidotablero[2] = identificadorF6;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 5 && k == 6)
                        {
                            contenidotablero[0] = fila6;
                            contenidotablero[1] = columnaG;
                            contenidotablero[2] = identificadorG6;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 5 && k == 7)
                        {
                            contenidotablero[0] = fila6;
                            contenidotablero[1] = columnaH;
                            contenidotablero[2] = identificadorH6;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 6 && k == 0)
                        {
                            contenidotablero[0] = fila7;
                            contenidotablero[1] = columnaA;
                            contenidotablero[2] = identificadorA7;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 6 && k == 1)
                        {
                            contenidotablero[0] = fila7;
                            contenidotablero[1] = columnaB;
                            contenidotablero[2] = identificadorB7;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 6 && k == 2)
                        {
                            contenidotablero[0] = fila7;
                            contenidotablero[1] = columnaC;
                            contenidotablero[2] = identificadorC7;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 6 && k == 3)
                        {
                            contenidotablero[0] = fila7;
                            contenidotablero[1] = columnaD;
                            contenidotablero[2] = identificadorD7;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 6 && k == 4)
                        {
                            contenidotablero[0] = fila7;
                            contenidotablero[1] = columnaE;
                            contenidotablero[2] = identificadorE7;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 6 && k == 5)
                        {
                            contenidotablero[0] = fila7;
                            contenidotablero[1] = columnaF;
                            contenidotablero[2] = identificadorF7;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 6 && k == 6)
                        {
                            contenidotablero[0] = fila7;
                            contenidotablero[1] = columnaG;
                            contenidotablero[2] = identificadorG7;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 6 && k == 7)
                        {
                            contenidotablero[0] = fila7;
                            contenidotablero[1] = columnaH;
                            contenidotablero[2] = identificadorH7;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 7 && k == 0)
                        {
                            contenidotablero[0] = fila8;
                            contenidotablero[1] = columnaA;
                            contenidotablero[2] = identificadorA8;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 7 && k == 1)
                        {
                            contenidotablero[0] = fila8;
                            contenidotablero[1] = columnaB;
                            contenidotablero[2] = identificadorB8;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 7 && k == 2)
                        {
                            contenidotablero[0] = fila8;
                            contenidotablero[1] = columnaC;
                            contenidotablero[2] = identificadorC8;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 7 && k == 3)
                        {
                            contenidotablero[0] = fila8;
                            contenidotablero[1] = columnaD;
                            contenidotablero[2] = identificadorD8;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 7 && k == 4)
                        {
                            contenidotablero[0] = fila8;
                            contenidotablero[1] = columnaE;
                            contenidotablero[2] = identificadorE8;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 7 && k == 5)
                        {
                            contenidotablero[0] = fila8;
                            contenidotablero[1] = columnaF;
                            contenidotablero[2] = identificadorF8;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 7 && k == 6)
                        {
                            contenidotablero[0] = fila8;
                            contenidotablero[1] = columnaG;
                            contenidotablero[2] = identificadorG8;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                        if (j == 7 && k == 7)
                        {
                            contenidotablero[0] = fila8;
                            contenidotablero[1] = columnaH;
                            contenidotablero[2] = identificadorH8;
                            matriztablero[j][k] = contenidotablero[0] + "," + contenidotablero[1] + "," + contenidotablero[2];
                        }
                    }
                }
            }
        }
    }
}

