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
        int contadornegro;
        int contadorblanco;
        static int contadorxml = 0;
        static string [][]  matriztablero;
        static string [] contenidotablero;
        static string[,] multielementos;
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
        static string identificadorD4 = "";
        static string identificadorE4 = "negro";
        static string identificadorF4 = "";
        static string identificadorG4 = "";
        static string identificadorH4 = "";
        static string identificadorA5 = "";
        static string identificadorB5 = "";
        static string identificadorC5 = "";
        static string identificadorD5 = "negro";
        static string identificadorE5 = "";
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
        static string columnaA1 = "A";
        static string filaA1 = "1";
        static string columnaB1 = "B";
        static string filaB1 = "1";
        static string columnaC1 = "C";
        static string filaC1 = "1";
        static string columnaD1 = "D";
        static string filaD1 = "1";
        static string columnaE1 = "E";
        static string filaE1 = "1";
        static string columnaF1 = "F";
        static string filaF1 = "1";
        static string columnaG1 = "G";
        static string filaG1 = "1";
        static string columnaH1 = "H";
        static string filaH1 = "1";
        static string columnaA2 = "A";
        static string filaA2 = "2";
        static string columnaB2 = "B";
        static string filaB2 = "2";
        static string columnaC2 = "C";
        static string filaC2 = "2";
        static string columnaD2 = "D";
        static string filaD2 = "2";
        static string columnaE2 = "E";
        static string filaE2 = "2";
        static string columnaF2 = "F";
        static string filaF2 = "2";
        static string columnaG2 = "G";
        static string filaG2 = "2";
        static string columnaH2 = "H";
        static string filaH2 = "2";
        static string columnaA3 = "A";
        static string filaA3 = "3";
        static string columnaB3 = "B";
        static string filaB3 = "3";
        static string columnaC3 = "C";
        static string filaC3 = "3";
        static string columnaD3 = "D";
        static string filaD3 = "3";
        static string columnaE3 = "E";
        static string filaE3 = "3";
        static string columnaF3 = "F";
        static string filaF3 = "3";
        static string columnaG3 = "G";
        static string filaG3 = "3";
        static string columnaH3 = "H";
        static string filaH3 = "3";
        static string columnaA4 = "A";
        static string filaA4 = "4";
        static string columnaB4 = "B";
        static string filaB4 = "4";
        static string columnaC4 = "C";
        static string filaC4 = "4";
        static string columnaD4 = "D";
        static string filaD4 = "4";
        static string columnaE4 = "E";
        static string filaE4 = "4";
        static string columnaF4 = "F";
        static string filaF4 = "4";
        static string columnaG4 = "G";
        static string filaG4 = "4";
        static string columnaH4 = "H";
        static string filaH4 = "4";
        static string columnaA5 = "A";
        static string filaA5 = "5";
        static string columnaB5 = "B";
        static string filaB5 = "5";
        static string columnaC5 = "C";
        static string filaC5 = "5";
        static string columnaD5 = "D";
        static string filaD5 = "5";
        static string columnaE5 = "E";
        static string filaE5 = "5";
        static string columnaF5 = "F";
        static string filaF5 = "5";
        static string columnaG5 = "G";
        static string filaG5 = "5";
        static string columnaH5 = "H";
        static string filaH5 = "5";
        static string columnaA6 = "A";
        static string filaA6 = "6";
        static string columnaB6 = "B";
        static string filaB6 = "6";
        static string columnaC6 = "C";
        static string filaC6 = "6";
        static string columnaD6 = "D";
        static string filaD6 = "6";
        static string columnaE6 = "E";
        static string filaE6 = "6";
        static string columnaF6 = "F";
        static string filaF6 = "6";
        static string columnaG6 = "G";
        static string filaG6 = "6";
        static string columnaH6 = "H";
        static string filaH6 = "6";
        static string columnaA7 = "A";
        static string filaA7 = "7";
        static string columnaB7 = "B";
        static string filaB7 = "7";
        static string columnaC7 = "C";
        static string filaC7 = "7";
        static string columnaD7 = "D";
        static string filaD7 = "7";
        static string columnaE7 = "E";
        static string filaE7 = "7";
        static string columnaF7 = "F";
        static string filaF7 = "7";
        static string columnaG7 = "G";
        static string filaG7 = "7";
        static string columnaH7 = "H";
        static string filaH7 = "7";
        static string columnaA8 = "A";
        static string filaA8 = "8";
        static string columnaB8 = "B";
        static string filaB8 = "8";
        static string columnaC8 = "C";
        static string filaC8 = "8";
        static string columnaD8 = "D";
        static string filaD8 = "8";
        static string columnaE8 = "E";
        static string filaE8 = "8";
        static string columnaF8 = "F";
        static string filaF8 = "8";
        static string columnaG8 = "G";
        static string filaG8 = "8";
        static string columnaH8 = "H";
        static string rutabase = "";
        static string filaH8 = "8";
        static string idArchivo = "0";
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
        public static string idUsuarioCargado = "";
        static bool validacion = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDocument leer = new XmlDocument();
            if (PaginaPrincipal.carruta != "")
            {
                if(validacion == false)
                {
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
                                    matriztablero[0][0] = contenidotablero.ToString();
                                }
                                else if (identificadorA1.Equals("blanco"))
                                {
                                    A1.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA1;
                                    matriztablero[0][0] = contenidotablero.ToString();
                                }
                                else
                                {
                                    A1.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA1;
                                    matriztablero[0][0] = contenidotablero.ToString();
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
                                    matriztablero[0][1] = contenidotablero.ToString();
                                }
                                else if (identificadorB1.Equals("blanco"))
                                {
                                    B1.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB1;
                                    matriztablero[0][1] = contenidotablero.ToString();
                                }
                                else
                                {
                                    B1.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB1;
                                    matriztablero[0][1] = contenidotablero.ToString();
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
                                    matriztablero[0][2] = contenidotablero.ToString();
                                }
                                else if (identificadorC1.Equals("blanco"))
                                {
                                    C1.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC1;
                                    matriztablero[0][2] = contenidotablero.ToString();
                                }
                                else
                                {
                                    C1.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC1;
                                    matriztablero[0][2] = contenidotablero.ToString();
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
                                    matriztablero[0][3] = contenidotablero.ToString();
                                }
                                else if (identificadorD1.Equals("blanco"))
                                {
                                    D1.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD1;
                                    matriztablero[0][3] = contenidotablero.ToString();
                                }
                                else
                                {
                                    D1.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD1;
                                    matriztablero[0][3] = contenidotablero.ToString();
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
                                    matriztablero[0][4] = contenidotablero.ToString();
                                }
                                else if (identificadorE1.Equals("blanco"))
                                {
                                    E1.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE1;
                                    matriztablero[0][4] = contenidotablero.ToString();
                                }
                                else
                                {
                                    E1.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE1;
                                    matriztablero[0][4] = contenidotablero.ToString();
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
                                    matriztablero[0][5] = contenidotablero.ToString();
                                }
                                else if (identificadorF1.Equals("blanco"))
                                {
                                    F1.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF1;
                                    matriztablero[0][5] = contenidotablero.ToString();
                                }
                                else
                                {
                                    F1.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF1;
                                    matriztablero[0][5] = contenidotablero.ToString();
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
                                    matriztablero[0][6] = contenidotablero.ToString();
                                }
                                else if (identificadorG1.Equals("blanco"))
                                {
                                    G1.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG1;
                                    matriztablero[0][6] = contenidotablero.ToString();
                                }
                                else
                                {
                                    G1.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG1;
                                    matriztablero[0][6] = contenidotablero.ToString();
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
                                    matriztablero[0][7] = contenidotablero.ToString();
                                }
                                else if (identificadorH1.Equals("blanco"))
                                {
                                    H1.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH1;
                                    matriztablero[0][7] = contenidotablero.ToString();
                                }
                                else
                                {
                                    H1.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila1;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH1;
                                    matriztablero[0][7] = contenidotablero.ToString();
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
                                    matriztablero[1][0] = contenidotablero.ToString();
                                }
                                else if (identificadorA2.Equals("blanco"))
                                {
                                    A2.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA2;
                                    matriztablero[1][0] = contenidotablero.ToString();
                                }
                                else
                                {
                                    A2.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA2;
                                    matriztablero[1][0] = contenidotablero.ToString();
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
                                    matriztablero[1][1] = contenidotablero.ToString();
                                }
                                else if (identificadorB2.Equals("blanco"))
                                {
                                    B2.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB2;
                                    matriztablero[1][1] = contenidotablero.ToString();
                                }
                                else
                                {
                                    B2.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB2;
                                    matriztablero[1][1] = contenidotablero.ToString();
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
                                    matriztablero[1][2] = contenidotablero.ToString();
                                }
                                else if (identificadorC2.Equals("blanco"))
                                {
                                    C2.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC2;
                                    matriztablero[1][2] = contenidotablero.ToString();
                                }
                                else
                                {
                                    C2.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC2;
                                    matriztablero[1][2] = contenidotablero.ToString();
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
                                    matriztablero[1][3] = contenidotablero.ToString();
                                }
                                else if (identificadorD2.Equals("blanco"))
                                {
                                    D2.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD2;
                                    matriztablero[1][3] = contenidotablero.ToString();
                                }
                                else
                                {
                                    D2.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD2;
                                    matriztablero[1][3] = contenidotablero.ToString();
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
                                    matriztablero[1][4] = contenidotablero.ToString();
                                }
                                else if (identificadorE2.Equals("blanco"))
                                {
                                    E2.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE2;
                                    matriztablero[1][4] = contenidotablero.ToString();
                                }
                                else
                                {
                                    E2.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE2;
                                    matriztablero[1][4] = contenidotablero.ToString();
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
                                    matriztablero[1][5] = contenidotablero.ToString();
                                }
                                else if (identificadorF2.Equals("blanco"))
                                {
                                    F2.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF2;
                                    matriztablero[1][5] = contenidotablero.ToString();
                                }
                                else
                                {
                                    F2.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF2;
                                    matriztablero[1][5] = contenidotablero.ToString();
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
                                    matriztablero[1][6] = contenidotablero.ToString();
                                }
                                else if (identificadorG2.Equals("blanco"))
                                {
                                    G2.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG2;
                                    matriztablero[1][6] = contenidotablero.ToString();
                                }
                                else
                                {
                                    G2.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG2;
                                    matriztablero[1][6] = contenidotablero.ToString();
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
                                    matriztablero[1][7] = contenidotablero.ToString();
                                }
                                else if (identificadorH2.Equals("blanco"))
                                {
                                    H2.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH2;
                                    matriztablero[1][7] = contenidotablero.ToString();
                                }
                                else
                                {
                                    H2.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila2;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH2;
                                    matriztablero[1][7] = contenidotablero.ToString();
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
                                    matriztablero[2][0] = contenidotablero.ToString();
                                }
                                else if (identificadorA3.Equals("blanco"))
                                {
                                    A3.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA3;
                                    matriztablero[2][0] = contenidotablero.ToString();
                                }
                                else
                                {
                                    A3.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA3;
                                    matriztablero[2][0] = contenidotablero.ToString();
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
                                    matriztablero[2][1] = contenidotablero.ToString();
                                }
                                else if (identificadorB3.Equals("blanco"))
                                {
                                    B3.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB3;
                                    matriztablero[2][1] = contenidotablero.ToString();
                                }
                                else
                                {
                                    B3.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB3;
                                    matriztablero[2][1] = contenidotablero.ToString();
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
                                    matriztablero[2][2] = contenidotablero.ToString();
                                }
                                else if (identificadorC3.Equals("blanco"))
                                {
                                    C3.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC3;
                                    matriztablero[2][2] = contenidotablero.ToString();
                                }
                                else
                                {
                                    C3.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC3;
                                    matriztablero[2][2] = contenidotablero.ToString();
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
                                    matriztablero[2][3] = contenidotablero.ToString();
                                }
                                else if (identificadorD3.Equals("blanco"))
                                {
                                    D3.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD3;
                                    matriztablero[2][3] = contenidotablero.ToString();
                                }
                                else
                                {
                                    D3.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD3;
                                    matriztablero[2][3] = contenidotablero.ToString();
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
                                    matriztablero[2][4] = contenidotablero.ToString();
                                }
                                else if (identificadorE3.Equals("blanco"))
                                {
                                    E3.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE3;
                                    matriztablero[2][4] = contenidotablero.ToString();
                                }
                                else
                                {
                                    E3.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE3;
                                    matriztablero[2][4] = contenidotablero.ToString();
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
                                    matriztablero[2][5] = contenidotablero.ToString();
                                }
                                else if (identificadorF3.Equals("blanco"))
                                {
                                    F3.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF3;
                                    matriztablero[2][5] = contenidotablero.ToString();
                                }
                                else
                                {
                                    F3.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF3;
                                    matriztablero[2][5] = contenidotablero.ToString();
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
                                    matriztablero[2][6] = contenidotablero.ToString();
                                }
                                else if (identificadorG3.Equals("blanco"))
                                {
                                    G3.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG3;
                                    matriztablero[2][6] = contenidotablero.ToString();
                                }
                                else
                                {
                                    G3.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG3;
                                    matriztablero[2][6] = contenidotablero.ToString();
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
                                    matriztablero[2][7] = contenidotablero.ToString();
                                }
                                else if (identificadorH3.Equals("blanco"))
                                {
                                    H3.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH3;
                                    matriztablero[2][7] = contenidotablero.ToString();
                                }
                                else
                                {
                                    H3.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila3;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH3;
                                    matriztablero[2][7] = contenidotablero.ToString();
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
                                    matriztablero[3][0] = contenidotablero.ToString();
                                }
                                else if (identificadorA4.Equals("blanco"))
                                {
                                    A4.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA4;
                                    matriztablero[3][0] = contenidotablero.ToString();
                                }
                                else
                                {
                                    A4.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA4;
                                    matriztablero[3][0] = contenidotablero.ToString();
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
                                    matriztablero[3][1] = contenidotablero.ToString();
                                }
                                else if (identificadorB4.Equals("blanco"))
                                {
                                    B4.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB4;
                                    matriztablero[3][1] = contenidotablero.ToString();
                                }
                                else
                                {
                                    B4.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB4;
                                    matriztablero[3][1] = contenidotablero.ToString();
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
                                    matriztablero[3][2] = contenidotablero.ToString();
                                }
                                else if (identificadorC4.Equals("blanco"))
                                {
                                    C4.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC4;
                                    matriztablero[3][2] = contenidotablero.ToString();
                                }
                                else
                                {
                                    C4.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC4;
                                    matriztablero[3][2] = contenidotablero.ToString();
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
                                    matriztablero[3][3] = contenidotablero.ToString();
                                }
                                else if (identificadorD4.Equals("blanco"))
                                {
                                    D4.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC4;
                                    matriztablero[3][3] = contenidotablero.ToString();
                                }
                                else
                                {
                                    D4.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC4;
                                    matriztablero[3][3] = contenidotablero.ToString();
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
                                    matriztablero[3][4] = contenidotablero.ToString();
                                }
                                else if (identificadorE4.Equals("blanco"))
                                {
                                    E4.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE4;
                                    matriztablero[3][4] = contenidotablero.ToString();
                                }
                                else
                                {
                                    E4.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE4;
                                    matriztablero[3][4] = contenidotablero.ToString();
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
                                    matriztablero[3][5] = contenidotablero.ToString();
                                }
                                else if (identificadorF4.Equals("blanco"))
                                {
                                    F4.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF4;
                                    matriztablero[3][5] = contenidotablero.ToString();
                                }
                                else
                                {
                                    F4.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF4;
                                    matriztablero[3][5] = contenidotablero.ToString();
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
                                    matriztablero[3][6] = contenidotablero.ToString();
                                }
                                else if (identificadorG4.Equals("blanco"))
                                {
                                    G4.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG4;
                                    matriztablero[3][6] = contenidotablero.ToString();
                                }
                                else
                                {
                                    G4.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG4;
                                    matriztablero[3][6] = contenidotablero.ToString();
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
                                    matriztablero[3][7] = contenidotablero.ToString();
                                }
                                else if (identificadorH4.Equals("blanco"))
                                {
                                    H4.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH4;
                                    matriztablero[3][7] = contenidotablero.ToString();
                                }
                                else
                                {
                                    H4.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila4;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH4;
                                    matriztablero[3][7] = contenidotablero.ToString();
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
                                    matriztablero[4][0] = contenidotablero.ToString();
                                }
                                else if (identificadorA5.Equals("blanco"))
                                {
                                    A5.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA5;
                                    matriztablero[4][0] = contenidotablero.ToString();
                                }
                                else
                                {
                                    A5.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA5;
                                    matriztablero[4][0] = contenidotablero.ToString();
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
                                    matriztablero[4][1] = contenidotablero.ToString();
                                }
                                else if (identificadorB5.Equals("blanco"))
                                {
                                    B5.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB5;
                                    matriztablero[4][1] = contenidotablero.ToString();
                                }
                                else
                                {
                                    B5.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB5;
                                    matriztablero[4][1] = contenidotablero.ToString();
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
                                    matriztablero[4][2] = contenidotablero.ToString();
                                }
                                else if (identificadorC5.Equals("blanco"))
                                {
                                    C5.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC5;
                                    matriztablero[4][2] = contenidotablero.ToString();
                                }
                                else
                                {
                                    C5.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC5;
                                    matriztablero[4][2] = contenidotablero.ToString();
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
                                    matriztablero[4][3] = contenidotablero.ToString();
                                }
                                else if (identificadorD5.Equals("blanco"))
                                {
                                    D5.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD5;
                                    matriztablero[4][3] = contenidotablero.ToString();
                                }
                                else
                                {
                                    D5.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD5;
                                    matriztablero[4][3] = contenidotablero.ToString();
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
                                    matriztablero[4][4] = contenidotablero.ToString();
                                }
                                else if (identificadorE5.Equals("blanco"))
                                {
                                    E5.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE5;
                                    matriztablero[4][4] = contenidotablero.ToString();
                                }
                                else
                                {
                                    E5.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE5;
                                    matriztablero[4][4] = contenidotablero.ToString();
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
                                    matriztablero[4][5] = contenidotablero.ToString();
                                }
                                else if (identificadorF5.Equals("blanco"))
                                {
                                    F5.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF5;
                                    matriztablero[4][5] = contenidotablero.ToString();
                                }
                                else
                                {
                                    F5.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF5;
                                    matriztablero[4][5] = contenidotablero.ToString();
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
                                    matriztablero[4][6] = contenidotablero.ToString();
                                }
                                else if (identificadorG5.Equals("blanco"))
                                {
                                    G5.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG5;
                                    matriztablero[4][6] = contenidotablero.ToString();
                                }
                                else
                                {
                                    G5.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG5;
                                    matriztablero[4][6] = contenidotablero.ToString();
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
                                    matriztablero[4][7] = contenidotablero.ToString();
                                }
                                else if (identificadorH5.Equals("blanco"))
                                {
                                    H5.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH5;
                                    matriztablero[4][7] = contenidotablero.ToString();
                                }
                                else
                                {
                                    H5.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila5;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH5;
                                    matriztablero[4][7] = contenidotablero.ToString();
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
                                    matriztablero[5][0] = contenidotablero.ToString();
                                }
                                else if (identificadorA6.Equals("blanco"))
                                {
                                    A6.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA6;
                                    matriztablero[5][0] = contenidotablero.ToString();
                                }
                                else
                                {
                                    A6.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA6;
                                    matriztablero[5][0] = contenidotablero.ToString();
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
                                    matriztablero[5][1] = contenidotablero.ToString();
                                }
                                else if (identificadorB6.Equals("blanco"))
                                {
                                    B6.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB6;
                                    matriztablero[5][1] = contenidotablero.ToString();
                                }
                                else
                                {
                                    B6.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB6;
                                    matriztablero[5][1] = contenidotablero.ToString();
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
                                    matriztablero[5][2] = contenidotablero.ToString();
                                }
                                else if (identificadorC6.Equals("blanco"))
                                {
                                    C6.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC6;
                                    matriztablero[5][2] = contenidotablero.ToString();
                                }
                                else
                                {
                                    C6.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC6;
                                    matriztablero[5][2] = contenidotablero.ToString();
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
                                    matriztablero[5][3] = contenidotablero.ToString();
                                }
                                else if (identificadorD6.Equals("blanco"))
                                {
                                    D6.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD6;
                                    matriztablero[5][3] = contenidotablero.ToString();
                                }
                                else
                                {
                                    D6.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD6;
                                    matriztablero[5][3] = contenidotablero.ToString();
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
                                    matriztablero[5][4] = contenidotablero.ToString();
                                }
                                else if (identificadorE6.Equals("blanco"))
                                {
                                    E6.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE6;
                                    matriztablero[5][4] = contenidotablero.ToString();
                                }
                                else
                                {
                                    E6.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE6;
                                    matriztablero[5][4] = contenidotablero.ToString();
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
                                    matriztablero[5][5] = contenidotablero.ToString();
                                }
                                else if (identificadorF6.Equals("blanco"))
                                {
                                    F6.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF6;
                                    matriztablero[5][5] = contenidotablero.ToString();
                                }
                                else
                                {
                                    F6.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF6;
                                    matriztablero[5][5] = contenidotablero.ToString();
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
                                    matriztablero[5][6] = contenidotablero.ToString();
                                }
                                else if (identificadorG6.Equals("blanco"))
                                {
                                    G6.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG6;
                                    matriztablero[5][6] = contenidotablero.ToString();
                                }
                                else
                                {
                                    G6.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG6;
                                    matriztablero[5][6] = contenidotablero.ToString();
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
                                    matriztablero[5][7] = contenidotablero.ToString();
                                }
                                else if (identificadorH6.Equals("blanco"))
                                {
                                    H6.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH6;
                                    matriztablero[5][7] = contenidotablero.ToString();
                                }
                                else
                                {
                                    H6.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila6;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH6;
                                    matriztablero[5][7] = contenidotablero.ToString();
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
                                    matriztablero[6][0] = contenidotablero.ToString();
                                }
                                else if (identificadorA7.Equals("blanco"))
                                {
                                    A7.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA7;
                                    matriztablero[6][0] = contenidotablero.ToString();
                                }
                                else
                                {
                                    A7.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA7;
                                    matriztablero[6][0] = contenidotablero.ToString();
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
                                    matriztablero[6][1] = contenidotablero.ToString();
                                }
                                else if (identificadorB7.Equals("blanco"))
                                {
                                    B7.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB7;
                                    matriztablero[6][1] = contenidotablero.ToString();
                                }
                                else
                                {
                                    B7.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB7;
                                    matriztablero[6][1] = contenidotablero.ToString();
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
                                    matriztablero[6][2] = contenidotablero.ToString();
                                }
                                else if (identificadorC7.Equals("blanco"))
                                {
                                    C7.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC7;
                                    matriztablero[6][2] = contenidotablero.ToString();
                                }
                                else
                                {
                                    C7.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC7;
                                    matriztablero[6][2] = contenidotablero.ToString();
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
                                    matriztablero[6][3] = contenidotablero.ToString();
                                }
                                else if (identificadorD7.Equals("blanco"))
                                {
                                    D7.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD7;
                                    matriztablero[6][3] = contenidotablero.ToString();
                                }
                                else
                                {
                                    D7.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD7;
                                    matriztablero[6][3] = contenidotablero.ToString();
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
                                    matriztablero[6][4] = contenidotablero.ToString();
                                }
                                else if (identificadorE7.Equals("blanco"))
                                {
                                    E7.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE7;
                                    matriztablero[6][4] = contenidotablero.ToString();
                                }
                                else
                                {
                                    E7.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE7;
                                    matriztablero[6][4] = contenidotablero.ToString();
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
                                    matriztablero[6][5] = contenidotablero.ToString();
                                }
                                else if (identificadorF7.Equals("blanco"))
                                {
                                    F7.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF7;
                                    matriztablero[6][5] = contenidotablero.ToString();
                                }
                                else
                                {
                                    F7.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF7;
                                    matriztablero[6][5] = contenidotablero.ToString();
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
                                    matriztablero[6][6] = contenidotablero.ToString();
                                }
                                else if (identificadorG7.Equals("blanco"))
                                {
                                    G7.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG7;
                                    matriztablero[6][6] = contenidotablero.ToString();
                                }
                                else
                                {
                                    G7.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG7;
                                    matriztablero[6][6] = contenidotablero.ToString();
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
                                    matriztablero[6][7] = contenidotablero.ToString();
                                }
                                else if (identificadorH7.Equals("blanco"))
                                {
                                    H7.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH7;
                                    matriztablero[6][7] = contenidotablero.ToString();
                                }
                                else
                                {
                                    H7.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila7;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH7;
                                    matriztablero[6][7] = contenidotablero.ToString();
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
                                    matriztablero[7][0] = contenidotablero.ToString();
                                }
                                else if (identificadorA8.Equals("blanco"))
                                {
                                    A8.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA8;
                                    matriztablero[7][0] = contenidotablero.ToString();
                                }
                                else
                                {
                                    A8.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaA;
                                    contenidotablero[2] = identificadorA8;
                                    matriztablero[7][0] = contenidotablero.ToString();
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
                                    matriztablero[7][1] = contenidotablero.ToString();
                                }
                                else if (identificadorB8.Equals("blanco"))
                                {
                                    B8.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB8;
                                    matriztablero[7][1] = contenidotablero.ToString();
                                }
                                else
                                {
                                    B8.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaB;
                                    contenidotablero[2] = identificadorB8;
                                    matriztablero[7][1] = contenidotablero.ToString();
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
                                    matriztablero[7][2] = contenidotablero.ToString();
                                }
                                else if (identificadorC8.Equals("blanco"))
                                {
                                    C8.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC8;
                                    matriztablero[7][2] = contenidotablero.ToString();
                                }
                                else
                                {
                                    C8.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaC;
                                    contenidotablero[2] = identificadorC8;
                                    matriztablero[7][2] = contenidotablero.ToString();
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
                                    matriztablero[7][3] = contenidotablero.ToString();
                                }
                                else if (identificadorD8.Equals("blanco"))
                                {
                                    D8.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD8;
                                    matriztablero[7][3] = contenidotablero.ToString();
                                }
                                else
                                {
                                    D8.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaD;
                                    contenidotablero[2] = identificadorD8;
                                    matriztablero[7][3] = contenidotablero.ToString();
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
                                    matriztablero[7][4] = contenidotablero.ToString();
                                }
                                else if (identificadorE8.Equals("blanco"))
                                {
                                    E8.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE8;
                                    matriztablero[7][4] = contenidotablero.ToString();
                                }
                                else
                                {
                                    E8.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaE;
                                    contenidotablero[2] = identificadorE8;
                                    matriztablero[7][4] = contenidotablero.ToString();
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
                                    matriztablero[7][5] = contenidotablero.ToString();
                                }
                                else if (identificadorF8.Equals("blanco"))
                                {
                                    F8.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF8;
                                    matriztablero[7][5] = contenidotablero.ToString();
                                }
                                else
                                {
                                    F8.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaF;
                                    contenidotablero[2] = identificadorF8;
                                    matriztablero[7][5] = contenidotablero.ToString();
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
                                    matriztablero[7][6] = contenidotablero.ToString();
                                }
                                else if (identificadorG8.Equals("blanco"))
                                {
                                    G8.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG8;
                                    matriztablero[7][6] = contenidotablero.ToString();
                                }
                                else
                                {
                                    G8.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaG;
                                    contenidotablero[2] = identificadorG8;
                                    matriztablero[7][6] = contenidotablero.ToString();
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
                                    matriztablero[7][7] = contenidotablero.ToString();
                                }
                                else if (identificadorH8.Equals("blanco"))
                                {
                                    H8.ImageUrl = "Blanca.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH8;
                                    matriztablero[7][7] = contenidotablero.ToString();
                                }
                                else
                                {
                                    H8.ImageUrl = "fondotransparente.png";
                                    contenidotablero[0] = fila8;
                                    contenidotablero[1] = columnaH;
                                    contenidotablero[2] = identificadorH8;
                                    matriztablero[7][7] = contenidotablero.ToString();
                                }
                            }
                        }




                        /*
                        if (xmlNode.Name.Equals("fichaA1"))
                        {
                            identificadorA1 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorA1.Equals("negro"))
                            {
                                A1.ImageUrl = "negra.png";

                            }
                            else if (identificadorA1.Equals("blanco"))
                            {
                                A1.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                A1.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaB1"))
                        {
                            identificadorB1 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorB1.Equals("negro"))
                            {
                                B1.ImageUrl = "negra.png";
                            }
                            else if (identificadorB1.Equals("blanco"))
                            {
                                B1.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                B1.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaC1"))
                        {
                            identificadorC1 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorC1.Equals("negro"))
                            {
                                C1.ImageUrl = "negra.png";
                            }
                            else if (identificadorC1.Equals("blanco"))
                            {
                                C1.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                C1.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaD1"))
                        {
                            identificadorD1 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorD1.Equals("negro"))
                            {
                                D1.ImageUrl = "negra.png";
                            }
                            else if (identificadorD1.Equals("blanco"))
                            {
                                D1.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                D1.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaE1"))
                        {
                            identificadorE1 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorE1.Equals("negro"))
                            {
                                E1.ImageUrl = "negra.png";
                            }
                            else if (identificadorE1.Equals("blanco"))
                            {
                                E1.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                E1.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaF1"))
                        {
                            identificadorF1 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorF1.Equals("negro"))
                            {
                                F1.ImageUrl = "negra.png";
                            }
                            else if (identificadorF1.Equals("blanco"))
                            {
                                F1.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                F1.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaG1"))
                        {
                            identificadorG1 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorG1.Equals("negro"))
                            {
                                G1.ImageUrl = "negra.png";
                            }
                            else if (identificadorG1.Equals("blanco"))
                            {
                                G1.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                G1.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaH1"))
                        {
                            identificadorH1 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorH1.Equals("negro"))
                            {
                                H1.ImageUrl = "negra.png";
                            }
                            else if (identificadorH1.Equals("blanco"))
                            {
                                H1.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                H1.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaA2"))
                        {
                            identificadorA2 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorA2.Equals("negro"))
                            {
                                A2.ImageUrl = "negra.png";
                            }
                            else if (identificadorA2.Equals("blanco"))
                            {
                                A2.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                A2.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaB2"))
                        {
                            identificadorB2 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorB2.Equals("negro"))
                            {
                                B2.ImageUrl = "negra.png";
                            }
                            else if (identificadorB2.Equals("blanco"))
                            {
                                B2.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                B2.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaC2"))
                        {
                            identificadorC2 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorC2.Equals("negro"))
                            {
                                C2.ImageUrl = "negra.png";
                            }
                            else if (identificadorC2.Equals("blanco"))
                            {
                                C2.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                C2.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaD2"))
                        {
                            identificadorD2 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorD2.Equals("negro"))
                            {
                                D2.ImageUrl = "negra.png";
                            }
                            else if (identificadorD2.Equals("blanco"))
                            {
                                D2.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                D2.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaE2"))
                        {
                            identificadorE2 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorE2.Equals("negro"))
                            {
                                E2.ImageUrl = "negra.png";
                            }
                            else if (identificadorE2.Equals("blanco"))
                            {
                                E2.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                E2.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaF2"))
                        {
                            identificadorF2 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorF2.Equals("negro"))
                            {
                                F2.ImageUrl = "negra.png";
                            }
                            else if (identificadorF2.Equals("blanco"))
                            {
                                F2.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                F2.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaG2"))
                        {
                            identificadorG2 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorG2.Equals("negro"))
                            {
                                G2.ImageUrl = "negra.png";
                            }
                            else if (identificadorG2.Equals("blanco"))
                            {
                                G2.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                G2.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaH2"))
                        {
                            identificadorH2 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorH2.Equals("negro"))
                            {
                                H2.ImageUrl = "negra.png";
                            }
                            else if (identificadorH2.Equals("blanco"))
                            {
                                H2.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                H2.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaA3"))
                        {
                            identificadorA3 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorA3.Equals("negro"))
                            {
                                A3.ImageUrl = "negra.png";
                            }
                            else if (identificadorA3.Equals("blanco"))
                            {
                                A3.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                A3.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaB3"))
                        {
                            identificadorB3 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorB3.Equals("negro"))
                            {
                                B3.ImageUrl = "negra.png";
                            }
                            else if (identificadorB3.Equals("blanco"))
                            {
                                B3.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                B3.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaC3"))
                        {
                            identificadorC3 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorC3.Equals("negro"))
                            {
                                C3.ImageUrl = "negra.png";
                            }
                            else if (identificadorC3.Equals("blanco"))
                            {
                                C3.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                C3.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaD3"))
                        {
                            identificadorD3 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorD3.Equals("negro"))
                            {
                                D3.ImageUrl = "negra.png";
                            }
                            else if (identificadorD3.Equals("blanco"))
                            {
                                D3.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                D3.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaE3"))
                        {
                            identificadorE3 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorE3.Equals("negro"))
                            {
                                E3.ImageUrl = "negra.png";
                            }
                            else if (identificadorE3.Equals("blanco"))
                            {
                                E3.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                E3.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaF3"))
                        {
                            identificadorF3 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorF3.Equals("negro"))
                            {
                                F3.ImageUrl = "negra.png";
                            }
                            else if (identificadorF3.Equals("blanco"))
                            {
                                F3.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                F3.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaG3"))
                        {
                            identificadorG3 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorG3.Equals("negro"))
                            {
                                G3.ImageUrl = "negra.png";
                            }
                            else if (identificadorG3.Equals("blanco"))
                            {
                                G3.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                G3.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaH3"))
                        {
                            identificadorH3 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorH3.Equals("negro"))
                            {
                                H3.ImageUrl = "negra.png";
                            }
                            else if (identificadorH3.Equals("blanco"))
                            {
                                H3.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                H3.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaA4"))
                        {
                            identificadorA4 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorA4.Equals("negro"))
                            {
                                A4.ImageUrl = "negra.png";
                            }
                            else if (identificadorA4.Equals("blanco"))
                            {
                                A4.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                A4.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaB4"))
                        {
                            identificadorB4 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorB4.Equals("negro"))
                            {
                                B4.ImageUrl = "negra.png";
                            }
                            else if (identificadorB4.Equals("blanco"))
                            {
                                B4.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                B4.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaC4"))
                        {
                            identificadorC4 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorC4.Equals("negro"))
                            {
                                C4.ImageUrl = "negra.png";
                            }
                            else if (identificadorC4.Equals("blanco"))
                            {
                                C4.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                C4.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaD4"))
                        {
                            identificadorD4 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorD4.Equals("negro"))
                            {
                                D4.ImageUrl = "negra.png";
                            }
                            else if (identificadorD4.Equals("blanco"))
                            {
                                D4.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                D4.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaE4"))
                        {
                            identificadorE4 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorE4.Equals("negro"))
                            {
                                E4.ImageUrl = "negra.png";
                            }
                            else if (identificadorE4.Equals("blanco"))
                            {
                                E4.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                E4.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaF4"))
                        {
                            identificadorF4 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorF4.Equals("negro"))
                            {
                                F4.ImageUrl = "negra.png";
                            }
                            else if (identificadorF4.Equals("blanco"))
                            {
                                F4.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                F4.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaG4"))
                        {
                            identificadorG4 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorG4.Equals("negro"))
                            {
                                G4.ImageUrl = "negra.png";
                            }
                            else if (identificadorG4.Equals("blanco"))
                            {
                                G4.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                G4.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaH4"))
                        {
                            identificadorH4 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorH4.Equals("negro"))
                            {
                                H4.ImageUrl = "negra.png";
                            }
                            else if (identificadorH4.Equals("blanco"))
                            {
                                H4.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                H4.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaA5"))
                        {
                            identificadorA5 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorA5.Equals("negro"))
                            {
                                A5.ImageUrl = "negra.png";
                            }
                            else if (identificadorA5.Equals("blanco"))
                            {
                                A5.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                A5.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaB5"))
                        {
                            identificadorB5 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorB5.Equals("negro"))
                            {
                                B5.ImageUrl = "negra.png";
                            }
                            else if (identificadorB5.Equals("blanco"))
                            {
                                B5.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                B5.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaC5"))
                        {
                            identificadorC5 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorC5.Equals("negro"))
                            {
                                C5.ImageUrl = "negra.png";
                            }
                            else if (identificadorC5.Equals("blanco"))
                            {
                                C5.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                C5.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaD5"))
                        {
                            identificadorD5 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorD5.Equals("negro"))
                            {
                                D5.ImageUrl = "negra.png";
                            }
                            else if (identificadorD5.Equals("blanco"))
                            {
                                D5.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                D5.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaE5"))
                        {
                            identificadorE5 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorE5.Equals("negro"))
                            {
                                E5.ImageUrl = "negra.png";
                            }
                            else if (identificadorE5.Equals("blanco"))
                            {
                                E5.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                E5.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaF5"))
                        {
                            identificadorF5 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorF5.Equals("negro"))
                            {
                                F5.ImageUrl = "negra.png";
                            }
                            else if (identificadorF5.Equals("blanco"))
                            {
                                F5.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                F5.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaG5"))
                        {
                            identificadorG5 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorG5.Equals("negro"))
                            {
                                G5.ImageUrl = "negra.png";
                            }
                            else if (identificadorG5.Equals("blanco"))
                            {
                                G5.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                G5.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaH5"))
                        {
                            identificadorH5 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorH5.Equals("negro"))
                            {
                                H5.ImageUrl = "negra.png";
                            }
                            else if (identificadorH5.Equals("blanco"))
                            {
                                H5.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                H5.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaA6"))
                        {
                            identificadorA6 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorA6.Equals("negro"))
                            {
                                A6.ImageUrl = "negra.png";
                            }
                            else if (identificadorA6.Equals("blanco"))
                            {
                                A6.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                A6.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaB6"))
                        {
                            identificadorB6 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorB6.Equals("negro"))
                            {
                                B6.ImageUrl = "negra.png";
                            }
                            else if (identificadorB6.Equals("blanco"))
                            {
                                B6.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                B6.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaC6"))
                        {
                            identificadorC6 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorC6.Equals("negro"))
                            {
                                C6.ImageUrl = "negra.png";
                            }
                            else if (identificadorC6.Equals("blanco"))
                            {
                                C6.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                C6.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaD6"))
                        {
                            identificadorD6 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorD6.Equals("negro"))
                            {
                                D6.ImageUrl = "negra.png";
                            }
                            else if (identificadorD6.Equals("blanco"))
                            {
                                D6.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                D6.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaE6"))
                        {
                            identificadorE6 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorE6.Equals("negro"))
                            {
                                E6.ImageUrl = "negra.png";
                            }
                            else if (identificadorE6.Equals("blanco"))
                            {
                                E6.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                E6.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaF6"))
                        {
                            identificadorF6 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorF6.Equals("negro"))
                            {
                                F6.ImageUrl = "negra.png";
                            }
                            else if (identificadorF6.Equals("blanco"))
                            {
                                F6.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                F6.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaG6"))
                        {
                            identificadorG6 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorG6.Equals("negro"))
                            {
                                G6.ImageUrl = "negra.png";
                            }
                            else if (identificadorG6.Equals("blanco"))
                            {
                                G6.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                G6.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaH6"))
                        {
                            identificadorH6 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorH6.Equals("negro"))
                            {
                                H6.ImageUrl = "negra.png";
                            }
                            else if (identificadorH6.Equals("blanco"))
                            {
                                H6.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                H6.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaA7"))
                        {
                            identificadorA7 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorA7.Equals("negro"))
                            {
                                A7.ImageUrl = "negra.png";
                            }
                            else if (identificadorA7.Equals("blanco"))
                            {
                                A7.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                A7.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaB7"))
                        {
                            identificadorB7 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorB7.Equals("negro"))
                            {
                                B7.ImageUrl = "negra.png";
                            }
                            else if (identificadorB7.Equals("blanco"))
                            {
                                B7.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                B7.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaC7"))
                        {
                            identificadorC7 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorC7.Equals("negro"))
                            {
                                C7.ImageUrl = "negra.png";
                            }
                            else if (identificadorC7.Equals("blanco"))
                            {
                                C7.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                C7.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaD7"))
                        {
                            identificadorD7 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorD7.Equals("negro"))
                            {
                                D7.ImageUrl = "negra.png";
                            }
                            else if (identificadorD7.Equals("blanco"))
                            {
                                D7.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                D7.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaE7"))
                        {
                            identificadorE7 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorE7.Equals("negro"))
                            {
                                E7.ImageUrl = "negra.png";
                            }
                            else if (identificadorE7.Equals("blanco"))
                            {
                                E7.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                E7.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaF7"))
                        {
                            identificadorF7 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorF7.Equals("negro"))
                            {
                                F7.ImageUrl = "negra.png";
                            }
                            else if (identificadorF7.Equals("blanco"))
                            {
                                F7.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                F7.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaG7"))
                        {
                            identificadorG7 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorG7.Equals("negro"))
                            {
                                G7.ImageUrl = "negra.png";
                            }
                            else if (identificadorG7.Equals("blanco"))
                            {
                                G7.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                G7.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaH7"))
                        {
                            identificadorH7 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorH7.Equals("negro"))
                            {
                                H7.ImageUrl = "negra.png";
                            }
                            else if (identificadorH7.Equals("blanco"))
                            {
                                H7.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                H7.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaA8"))
                        {
                            identificadorA8 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorA8.Equals("negro"))
                            {
                                A8.ImageUrl = "negra.png";
                            }
                            else if (identificadorA8.Equals("blanco"))
                            {
                                A8.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                A8.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaB8"))
                        {
                            identificadorB8 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorB8.Equals("negro"))
                            {
                                B8.ImageUrl = "negra.png";
                            }
                            else if (identificadorB8.Equals("blanco"))
                            {
                                B8.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                B8.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaC8"))
                        {
                            identificadorC8 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorC8.Equals("negro"))
                            {
                                C8.ImageUrl = "negra.png";
                            }
                            else if (identificadorC8.Equals("blanco"))
                            {
                                C8.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                C8.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaD8"))
                        {
                            identificadorD8 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorD8.Equals("negro"))
                            {
                                D8.ImageUrl = "negra.png";
                            }
                            else if (identificadorD8.Equals("blanco"))
                            {
                                D8.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                D8.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaE8"))
                        {
                            identificadorE8 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorE8.Equals("negro"))
                            {
                                E8.ImageUrl = "negra.png";
                            }
                            else if (identificadorE8.Equals("blanco"))
                            {
                                E8.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                E8.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaF8"))
                        {
                            identificadorF8 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorF8.Equals("negro"))
                            {
                                F8.ImageUrl = "negra.png";
                            }
                            else if (identificadorF8.Equals("blanco"))
                            {
                                F8.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                F8.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaG8"))
                        {
                            identificadorG8 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorG8.Equals("negro"))
                            {
                                G8.ImageUrl = "negra.png";
                            }
                            else if (identificadorG8.Equals("blanco"))
                            {
                                G8.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                G8.ImageUrl = "fondotransparente.png";
                            }

                        }
                        if (xmlNode.Name.Equals("fichaH8"))
                        {
                            identificadorH8 = xmlNode.FirstChild.InnerText.ToString();
                            if (identificadorH8.Equals("negro"))
                            {
                                H8.ImageUrl = "negra.png";
                            }
                            else if (identificadorH8.Equals("blanco"))
                            {
                                H8.ImageUrl = "Blanca.png";
                            }
                            else
                            {
                                H8.ImageUrl = "fondotransparente.png";
                            }

                        }*/
                    }
                validacion = true;
                }
                
            }
            EsquemaTablero();
            validacion = true;
        }

        protected void Button178_Click(object sender, ImageClickEventArgs e)
        {
            
            if (identificadorA1.Equals("negro"))
            {
                identificadorA1 = "blanco";
                contadorblanco++;
                A1.ImageUrl = "Blanca.png";
                
            }
            else
            {
                identificadorA1 = "negro";
                contadornegro++;
                A1.ImageUrl = "negra.png";
                A1.ImageUrl = "Blanca.png";
                
            }
            contenidotablero[0] = fila1;
            contenidotablero[1] = columnaA;
            contenidotablero[2] = identificadorA1;
            matriztablero[0][0] = contenidotablero.ToString();
        }

        protected void B1_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorB1.Equals("negro"))
            {
                identificadorB1 = "blanco";
                contadorblanco++;
                B1.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorB1 = "negro";
                contadornegro++;
                B1.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila1;
            contenidotablero[1] = columnaB;
            contenidotablero[2] = identificadorB1;
            matriztablero[0][1] = contenidotablero.ToString();
        }

        protected void C1_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorC1.Equals("negro"))
            {
                identificadorC1 = "blanco";
                contadorblanco++;
                C1.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorC1 = "negro";
                contadornegro++;
                C1.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila1;
            contenidotablero[1] = columnaC;
            contenidotablero[2] = identificadorC1;
            matriztablero[0][2] = contenidotablero.ToString();
        }

        protected void D1_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorD1.Equals("negro"))
            {
                identificadorD1 = "blanco";
                contadorblanco++;
                D1.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorD1 = "negro";
                contadornegro++;
                D1.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila1;
            contenidotablero[1] = columnaD;
            contenidotablero[2] = identificadorD1;
            matriztablero[0][3] = contenidotablero.ToString();
        }

        protected void E1_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorE1.Equals("negro"))
            {
                identificadorE1 = "blanco";
                contadorblanco++;
                E1.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorE1 = "negro";
                contadornegro++;
                E1.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila1;
            contenidotablero[1] = columnaE;
            contenidotablero[2] = identificadorE1;
            matriztablero[0][4] = contenidotablero.ToString();
        }

        protected void F1_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorF1.Equals("negro"))
            {
                identificadorF1 = "blanco";
                contadorblanco++;
                F1.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorF1 = "negro";
                contadornegro++;
                F1.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila1;
            contenidotablero[1] = columnaF;
            contenidotablero[2] = identificadorF1;
            matriztablero[0][5] = contenidotablero.ToString();
        }

        protected void G1_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorG1.Equals("negro"))
            {
                identificadorG1 = "blanco";
                contadorblanco++;
                G1.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorG1 = "negro";
                contadornegro++;
                G1.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila1;
            contenidotablero[1] = columnaG;
            contenidotablero[2] = identificadorG1;
            matriztablero[0][6] = contenidotablero.ToString();
        }

        protected void H1_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorH1.Equals("negro"))
            {
                identificadorH1 = "blanco";
                contadorblanco++;
                H1.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorH1 = "negro";
                contadornegro++;
                H1.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila1;
            contenidotablero[1] = columnaH;
            contenidotablero[2] = identificadorH1;
            matriztablero[0][7] = contenidotablero.ToString();
        }

        protected void A2_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorA2.Equals("negro"))
            {
                identificadorA2 = "blanco";
                contadorblanco++;
                A2.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorA2 = "negro";
                contadornegro++;
                A2.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila2;
            contenidotablero[1] = columnaA;
            contenidotablero[2] = identificadorA2;
            matriztablero[1][0] = contenidotablero.ToString();
        }

        protected void B2_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorB2.Equals("negro"))
            {
                identificadorB2 = "blanco";
                contadorblanco++;
                B2.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorB2 = "negro";
                contadornegro++;
                B2.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila2;
            contenidotablero[1] = columnaB;
            contenidotablero[2] = identificadorB2;
            matriztablero[1][1] = contenidotablero.ToString();
        }

        protected void C2_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorC2.Equals("negro"))
            {
                identificadorC2 = "blanco";
                contadorblanco++;
                C2.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorC2 = "negro";
                contadornegro++;
                C2.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila2;
            contenidotablero[1] = columnaC;
            contenidotablero[2] = identificadorC2;
            matriztablero[1][2] = contenidotablero.ToString();
        }

        protected void D2_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorD2.Equals("negro"))
            {
                identificadorD2 = "blanco";
                contadorblanco++;
                D2.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorD2 = "negro";
                contadornegro++;
                D2.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila2;
            contenidotablero[1] = columnaD;
            contenidotablero[2] = identificadorD2;
            matriztablero[1][3] = contenidotablero.ToString();

        }

        protected void E2_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorE2.Equals("negro"))
            {
                identificadorE2 = "blanco";
                contadorblanco++;
                E2.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorE2 = "negro";
                contadornegro++;
                E2.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila2;
            contenidotablero[1] = columnaE;
            contenidotablero[2] = identificadorE2;
            matriztablero[1][4] = contenidotablero.ToString();
        }

        protected void F2_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorF2.Equals("negro"))
            {
                identificadorF2 = "blanco";
                contadorblanco++;
                F2.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorF2 = "negro";
                contadornegro++;
                F2.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila2;
            contenidotablero[1] = columnaF;
            contenidotablero[2] = identificadorF2;
            matriztablero[1][5] = contenidotablero.ToString();
        }

        protected void G2_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorG2.Equals("negro"))
            {
                identificadorG2 = "blanco";
                contadorblanco++;
                G2.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorG2 = "negro";
                contadornegro++;
                G2.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila2;
            contenidotablero[1] = columnaG;
            contenidotablero[2] = identificadorG2;
            matriztablero[1][6] = contenidotablero.ToString();
        }

        protected void H2_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorH2.Equals("negro"))
            {
                identificadorH2 = "blanco";
                contadorblanco++;
                H2.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorH2 = "negro";
                contadornegro++;
                H2.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila2;
            contenidotablero[1] = columnaH;
            contenidotablero[2] = identificadorH2;
            matriztablero[1][7] = contenidotablero.ToString();
        }

        protected void A3_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorA3.Equals("negro"))
            {
                identificadorA3 = "blanco";
                contadorblanco++;
                A3.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorA3 = "negro";
                contadornegro++;
                A3.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila3;
            contenidotablero[1] = columnaA;
            contenidotablero[2] = identificadorA3;
            matriztablero[2][0] = contenidotablero.ToString();
        }

        protected void B3_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorB3.Equals("negro"))
            {
                identificadorB3 = "blanco";
                contadorblanco++;
                B3.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorB3 = "negro";
                contadornegro++;
                B3.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila3;
            contenidotablero[1] = columnaB;
            contenidotablero[2] = identificadorB3;
            matriztablero[2][1] = contenidotablero.ToString();
        }

        protected void C3_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorC3.Equals("negro"))
            {
                identificadorC3 = "blanco";
                contadorblanco++;
                C3.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorC3 = "negro";
                contadornegro++;
                C3.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila3;
            contenidotablero[1] = columnaC;
            contenidotablero[2] = identificadorC3;
            matriztablero[2][2] = contenidotablero.ToString();
        }

        protected void D3_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorD3.Equals("negro"))
            {
                identificadorD3 = "blanco";
                contadorblanco++;
                D3.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorD3 = "negro";
                contadornegro++;
                D3.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila3;
            contenidotablero[1] = columnaD;
            contenidotablero[2] = identificadorD3;
            matriztablero[2][3] = contenidotablero.ToString();
        }

        protected void E3_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorE3.Equals("negro"))
            {
                identificadorE3 = "blanco";
                contadorblanco++;
                E3.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorE3 = "negro";
                contadornegro++;
                E3.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila3;
            contenidotablero[1] = columnaE;
            contenidotablero[2] = identificadorE3;
            matriztablero[2][4] = contenidotablero.ToString();
        }

        protected void F3_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorF3.Equals("negro"))
            {
                identificadorF3 = "blanco";
                contadorblanco++;
                F3.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorF3 = "negro";
                contadornegro++;
                F3.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila3;
            contenidotablero[1] = columnaF;
            contenidotablero[2] = identificadorF3;
            matriztablero[2][5] = contenidotablero.ToString();
        }

        protected void G3_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorG3.Equals("negro"))
            {
                identificadorG3 = "blanco";
                contadorblanco++;
                G3.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorG3 = "negro";
                contadornegro++;
                G3.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila3;
            contenidotablero[1] = columnaG;
            contenidotablero[2] = identificadorG3;
            matriztablero[2][6] = contenidotablero.ToString();
        }

        protected void H3_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorH3.Equals("negro"))
            {
                identificadorH3 = "blanco";
                contadorblanco++;
                H3.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorH3 = "negro";
                contadornegro++;
                H3.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila3;
            contenidotablero[1] = columnaH;
            contenidotablero[2] = identificadorH3;
            matriztablero[2][7] = contenidotablero.ToString();
        }

        protected void A4_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorA4.Equals("negro"))
            {
                identificadorA4 = "blanco";
                contadorblanco++;
                A4.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorA4 = "negro";
                contadornegro++;
                A4.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila4;
            contenidotablero[1] = columnaA;
            contenidotablero[2] = identificadorA4;
            matriztablero[3][0] = contenidotablero.ToString();
        }

        protected void B4_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorB4.Equals("negro"))
            {
                identificadorB4 = "blanco";
                contadorblanco++;
                B4.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorB4 = "negro";
                contadornegro++;
                B4.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila4;
            contenidotablero[1] = columnaB;
            contenidotablero[2] = identificadorB4;
            matriztablero[3][1] = contenidotablero.ToString();
        }

        protected void C4_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorC4.Equals("negro"))
            {
                identificadorC4 = "blanco";
                contadorblanco++;
                C4.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorC4 = "negro";
                contadornegro++;
                C4.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila4;
            contenidotablero[1] = columnaC;
            contenidotablero[2] = identificadorC4;
            matriztablero[3][2] = contenidotablero.ToString();
        }

        protected void D4_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorD4.Equals("negro"))
            {
                identificadorD4 = "blanco";
                contadorblanco++;
                D4.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorD4 = "negro";
                contadornegro++;
                D4.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila4;
            contenidotablero[1] = columnaB;
            contenidotablero[2] = identificadorB4;
            matriztablero[3][3] = contenidotablero.ToString();
        }

        protected void E4_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorE4.Equals("negro"))
            {
                identificadorE4 = "blanco";
                contadorblanco++;
                E4.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorE4 = "negro";
                contadornegro++;
                E4.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila4;
            contenidotablero[1] = columnaE;
            contenidotablero[2] = identificadorE4;
            matriztablero[3][4] = contenidotablero.ToString();
        }

        protected void F4_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorF4.Equals("negro"))
            {
                identificadorF4 = "blanco";
                contadorblanco++;
                F4.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorF4 = "negro";
                contadornegro++;
                F4.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila4;
            contenidotablero[1] = columnaF;
            contenidotablero[2] = identificadorF4;
            matriztablero[3][5] = contenidotablero.ToString();
        }

        protected void G4_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorG4.Equals("negro"))
            {
                identificadorG4 = "blanco";
                contadorblanco++;
                G4.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorG4 = "negro";
                contadornegro++;
                G4.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila4;
            contenidotablero[1] = columnaG;
            contenidotablero[2] = identificadorG4;
            matriztablero[3][6] = contenidotablero.ToString();
        }

        protected void H4_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorH4.Equals("negro"))
            {
                identificadorH4 = "blanco";
                contadorblanco++;
                H4.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorH4 = "negro";
                contadornegro++;
                H4.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila4;
            contenidotablero[1] = columnaH;
            contenidotablero[2] = identificadorH4;
            matriztablero[3][7] = contenidotablero.ToString();
        }

        protected void A5_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorA5.Equals("negro"))
            {
                identificadorA5 = "blanco";
                contadorblanco++;
                A5.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorA5 = "negro";
                contadornegro++;
                A5.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila5;
            contenidotablero[1] = columnaA;
            contenidotablero[2] = identificadorA5;
            matriztablero[4][0] = contenidotablero.ToString();
        }

        protected void B5_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorB5.Equals("negro"))
            {
                identificadorB5 = "blanco";
                contadorblanco++;
                B5.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorB5 = "negro";
                contadornegro++;
                B5.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila5;
            contenidotablero[1] = columnaB;
            contenidotablero[2] = identificadorB5;
            matriztablero[4][1] = contenidotablero.ToString();
        }

        protected void C5_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorC5.Equals("negro"))
            {
                identificadorC5 = "blanco";
                contadorblanco++;
                C5.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorC5 = "negro";
                contadornegro++;
                C5.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila5;
            contenidotablero[1] = columnaC;
            contenidotablero[2] = identificadorC5;
            matriztablero[4][2] = contenidotablero.ToString();
        }

        protected void D5_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorD5.Equals("negro"))
            {
                identificadorD5 = "blanco";
                contadorblanco++;
                D5.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorD5 = "negro";
                contadornegro++;
                D5.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila5;
            contenidotablero[1] = columnaD;
            contenidotablero[2] = identificadorD5;
            matriztablero[4][3] = contenidotablero.ToString();
        }

        protected void E5_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorE5.Equals("negro"))
            {
                identificadorE5 = "blanco";
                contadorblanco++;
                E5.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorE5 = "negro";
                contadornegro++;
                E5.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila5;
            contenidotablero[1] = columnaE;
            contenidotablero[2] = identificadorE5;
            matriztablero[4][4] = contenidotablero.ToString();
        }

        protected void F5_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorF5.Equals("negro"))
            {
                identificadorF5 = "blanco";
                contadorblanco++;
                F5.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorF5 = "negro";
                contadornegro++;
                F5.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila5;
            contenidotablero[1] = columnaF;
            contenidotablero[2] = identificadorF5;
            matriztablero[4][5] = contenidotablero.ToString();
        }

        protected void G5_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorG5.Equals("negro"))
            {
                identificadorG5 = "blanco";
                contadorblanco++;
                G5.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorG5 = "negro";
                contadornegro++;
                G5.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila5;
            contenidotablero[1] = columnaG;
            contenidotablero[2] = identificadorG5;
            matriztablero[4][6] = contenidotablero.ToString();
        }

        protected void H5_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorH5.Equals("negro"))
            {
                identificadorH5 = "blanco";
                contadorblanco++;
                H5.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorH5 = "negro";
                contadornegro++;
                H5.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila5;
            contenidotablero[1] = columnaH;
            contenidotablero[2] = identificadorH5;
            matriztablero[4][7] = contenidotablero.ToString();
        }

        protected void A6_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorA6.Equals("negro"))
            {
                identificadorA6 = "blanco";
                contadorblanco++;
                A6.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorA6 = "negro";
                contadornegro++;
                A6.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila6;
            contenidotablero[1] = columnaA;
            contenidotablero[2] = identificadorA6;
            matriztablero[5][0] = contenidotablero.ToString();
        }

        protected void B6_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorB6.Equals("negro"))
            {
                identificadorB6 = "blanco";
                contadorblanco++;
                B6.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorB6 = "negro";
                contadornegro++;
                B6.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila6;
            contenidotablero[1] = columnaB;
            contenidotablero[2] = identificadorB6;
            matriztablero[5][1] = contenidotablero.ToString();
        }

        protected void C6_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorC6.Equals("negro"))
            {
                identificadorC6 = "blanco";
                contadorblanco++;
                C6.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorC6 = "negro";
                contadornegro++;
                C6.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila6;
            contenidotablero[1] = columnaC;
            contenidotablero[2] = identificadorC6;
            matriztablero[5][2] = contenidotablero.ToString();
        }

        protected void D6_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorD6.Equals("negro"))
            {
                identificadorD6 = "blanco";
                contadorblanco++;
                D6.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorD6 = "negro";
                contadornegro++;
                D6.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila6;
            contenidotablero[1] = columnaD;
            contenidotablero[2] = identificadorD6;
            matriztablero[5][3] = contenidotablero.ToString();
        }

        protected void E6_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorE6.Equals("negro"))
            {
                identificadorE6 = "blanco";
                contadorblanco++;
                E6.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorE6 = "negro";
                contadornegro++;
                E6.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila6;
            contenidotablero[1] = columnaE;
            contenidotablero[2] = identificadorE6;
            matriztablero[5][4] = contenidotablero.ToString();
        }

        protected void F6_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorF6.Equals("negro"))
            {
                identificadorF6 = "blanco";
                contadorblanco++;
                F6.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorF6 = "negro";
                contadornegro++;
                F6.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila6;
            contenidotablero[1] = columnaF;
            contenidotablero[2] = identificadorF6;
            matriztablero[5][5] = contenidotablero.ToString();
        }

        protected void G6_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorG6.Equals("negro"))
            {
                identificadorG6 = "blanco";
                contadorblanco++;
                G6.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorG6 = "negro";
                contadornegro++;
                G6.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila6;
            contenidotablero[1] = columnaG;
            contenidotablero[2] = identificadorG6;
            matriztablero[5][6] = contenidotablero.ToString();
        }

        protected void H6_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorH6.Equals("negro"))
            {
                identificadorH6 = "blanco";
                contadorblanco++;
                H6.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorH6 = "negro";
                contadornegro++;
                H6.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila6;
            contenidotablero[1] = columnaH;
            contenidotablero[2] = identificadorH6;
            matriztablero[5][7] = contenidotablero.ToString();
        }

        protected void A7_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorA7.Equals("negro"))
            {
                identificadorA7 = "blanco";
                contadorblanco++;
                A7.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorA7 = "negro";
                contadornegro++;
                A7.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila7;
            contenidotablero[1] = columnaA;
            contenidotablero[2] = identificadorA7;
            matriztablero[6][0] = contenidotablero.ToString();
        }

        protected void B7_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorB7.Equals("negro"))
            {
                identificadorB7 = "blanco";
                contadorblanco++;
                B7.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorB7 = "negro";
                contadornegro++;
                B7.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila7;
            contenidotablero[1] = columnaB;
            contenidotablero[2] = identificadorB7;
            matriztablero[6][1] = contenidotablero.ToString();
        }

        protected void C7_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorC7.Equals("negro"))
            {
                identificadorC7 = "blanco";
                contadorblanco++;
                C7.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorC7 = "negro";
                contadornegro++;
                C7.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila7;
            contenidotablero[1] = columnaC;
            contenidotablero[2] = identificadorC7;
            matriztablero[6][2] = contenidotablero.ToString();
        }

        protected void D7_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorD7.Equals("negro"))
            {
                identificadorD7 = "blanco";
                contadorblanco++;
                D7.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorD7 = "negro";
                contadornegro++;
                D7.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila7;
            contenidotablero[1] = columnaD;
            contenidotablero[2] = identificadorD7;
            matriztablero[6][3] = contenidotablero.ToString();
        }

        protected void E7_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorE7.Equals("negro"))
            {
                identificadorE7 = "blanco";
                contadorblanco++;
                E7.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorE7 = "negro";
                contadornegro++;
                E7.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila7;
            contenidotablero[1] = columnaE;
            contenidotablero[2] = identificadorE7;
            matriztablero[6][4] = contenidotablero.ToString();
        }

        protected void F7_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorF7.Equals("negro"))
            {
                identificadorF7 = "blanco";
                contadorblanco++;
                F7.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorF7 = "negro";
                contadornegro++;
                F7.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila7;
            contenidotablero[1] = columnaF;
            contenidotablero[2] = identificadorF7;
            matriztablero[6][5] = contenidotablero.ToString();
        }

        protected void G7_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorG7.Equals("negro"))
            {
                identificadorG7 = "blanco";
                contadorblanco++;
                G7.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorG7 = "negro";
                contadornegro++;
                G7.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila7;
            contenidotablero[1] = columnaG;
            contenidotablero[2] = identificadorG7;
            matriztablero[6][6] = contenidotablero.ToString();
        }

        protected void H7_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorH7.Equals("negro"))
            {
                identificadorH7 = "blanco";
                contadorblanco++;
                H7.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorH7 = "negro";
                contadornegro++;
                H7.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila7;
            contenidotablero[1] = columnaH;
            contenidotablero[2] = identificadorH7;
            matriztablero[6][7] = contenidotablero.ToString();
        }

        protected void A8_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorA8.Equals("negro"))
            {
                identificadorA8 = "blanco";
                contadorblanco++;
                A8.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorA8 = "negro";
                contadornegro++;
                A8.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila8;
            contenidotablero[1] = columnaA;
            contenidotablero[2] = identificadorA8;
            matriztablero[7][0] = contenidotablero.ToString();
        }

        protected void B8_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorB8.Equals("negro"))
            {
                identificadorB8 = "blanco";
                contadorblanco++;
                B8.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorB8 = "negro";
                contadornegro++;
                B8.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila8;
            contenidotablero[1] = columnaB;
            contenidotablero[2] = identificadorB8;
            matriztablero[7][1] = contenidotablero.ToString();
        }

        protected void C8_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorC8.Equals("negro"))
            {
                identificadorC8 = "blanco";
                contadorblanco++;
                C8.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorC8 = "negro";
                contadornegro++;
                C8.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila8;
            contenidotablero[1] = columnaC;
            contenidotablero[2] = identificadorC8;
            matriztablero[7][2] = contenidotablero.ToString();
        }

        protected void D8_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorD8.Equals("negro"))
            {
                identificadorD8 = "blanco";
                contadorblanco++;
                D8.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorD8 = "negro";
                contadornegro++;
                D8.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila8;
            contenidotablero[1] = columnaD;
            contenidotablero[2] = identificadorD8;
            matriztablero[7][3] = contenidotablero.ToString();
        }

        protected void E8_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorE8.Equals("negro"))
            {
                identificadorE8 = "blanco";
                contadorblanco++;
                E8.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorE8 = "negro";
                contadornegro++;
                E8.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila8;
            contenidotablero[1] = columnaE;
            contenidotablero[2] = identificadorE8;
            matriztablero[7][4] = contenidotablero.ToString();
        }

        protected void F8_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorF8.Equals("negro"))
            {
                identificadorF8 = "blanco";
                contadorblanco++;
                F8.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorF8 = "negro";
                contadornegro++;
                F8.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila8;
            contenidotablero[1] = columnaF;
            contenidotablero[2] = identificadorF8;
            matriztablero[7][5] = contenidotablero.ToString();
        }

        protected void G8_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorG8.Equals("negro"))
            {
                identificadorG8 = "blanco";
                contadorblanco++;
                G8.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorG8 = "negro";
                contadornegro++;
                G8.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila8;
            contenidotablero[1] = columnaG;
            contenidotablero[2] = identificadorG8;
            matriztablero[7][6] = contenidotablero.ToString();
        }

        protected void H8_Click(object sender, ImageClickEventArgs e)
        {
            if (identificadorH8.Equals("negro"))
            {
                identificadorH8 = "blanco";
                contadorblanco++;
                H8.ImageUrl = "Blanca.png";
            }
            else
            {
                identificadorH8 = "negro";
                contadornegro++;
                H8.ImageUrl = "negra.png";
            }
            contenidotablero[0] = fila8;
            contenidotablero[1] = columnaH;
            contenidotablero[2] = identificadorH8;
            matriztablero[7][7] = contenidotablero.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            XDocument crearXML = new XDocument(new XDeclaration("1.0", "utf-8", null));
            XElement raiz = new XElement("Tablero");
            crearXML.Add(raiz);

            /*Manejar con datos de matriz*/
            for (int i = 0; i<matriztablero.Length; i++)
            {
                for (int j = 0; j < matriztablero[i].Length; j++)
                {
                    for (int k = 0; k<contenidotablero.Length; k++)
                    {
                        string guardarcontenido = matriztablero[i][j].ToString();
                        string guardarseparaciones = guardarcontenido.Split().ToString();
                        if (guardarseparaciones[2].ToString() != (""))
                        {
                            XElement fichanueva = new XElement("ficha");
                            if (j == 0 && k == 0)
                            {
                                fichanueva.Add(new XElement("color", identificadorA1));
                                fichanueva.Add(new XElement("columna", columnaA));
                                fichanueva.Add(new XElement("fila", fila1));
                            }
                            if (j == 0 && k == 1)
                            {
                                fichanueva.Add(new XElement("color", identificadorB1));
                                fichanueva.Add(new XElement("columna", columnaB));
                                fichanueva.Add(new XElement("fila", fila1));
                            }
                            if (j == 0 && k == 2)
                            {
                                fichanueva.Add(new XElement("color", identificadorC1));
                                fichanueva.Add(new XElement("columna", columnaC));
                                fichanueva.Add(new XElement("fila", fila1));

                            }
                            if (j == 0 && k == 3)
                            {
                                fichanueva.Add(new XElement("color", identificadorD1));
                                fichanueva.Add(new XElement("columna", columnaD));
                                fichanueva.Add(new XElement("fila", fila1));

                            }
                            if (j == 0 && k == 4)
                            {
                                fichanueva.Add(new XElement("color", identificadorE1));
                                fichanueva.Add(new XElement("columna", columnaE));
                                fichanueva.Add(new XElement("fila", fila1));

                            }
                            if (j == 0 && k == 5)
                            {
                                fichanueva.Add(new XElement("color", identificadorF1));
                                fichanueva.Add(new XElement("columna", columnaF));
                                fichanueva.Add(new XElement("fila", fila1));

                            }
                            if (j == 0 && k == 6)
                            {
                                fichanueva.Add(new XElement("color", identificadorG1));
                                fichanueva.Add(new XElement("columna", columnaG));
                                fichanueva.Add(new XElement("fila", fila1));

                            }
                            if (j == 0 && k == 7)
                            {
                                fichanueva.Add(new XElement("color", identificadorH1));
                                fichanueva.Add(new XElement("columna", columnaH));
                                fichanueva.Add(new XElement("fila", fila1));

                            }
                            if (j == 1 && k == 0)
                            {
                                fichanueva.Add(new XElement("color", identificadorA2));
                                fichanueva.Add(new XElement("columna", columnaA));
                                fichanueva.Add(new XElement("fila", fila2));

                            }
                            if (j == 1 && k == 1)
                            {
                                fichanueva.Add(new XElement("color", identificadorB2));
                                fichanueva.Add(new XElement("columna", columnaB));
                                fichanueva.Add(new XElement("fila", fila2));

                            }
                            if (j == 1 && k == 2)
                            {
                                fichanueva.Add(new XElement("color", identificadorC2));
                                fichanueva.Add(new XElement("columna", columnaC));
                                fichanueva.Add(new XElement("fila", fila2));

                            }
                            if (j == 1 && k == 3)
                            {
                                fichanueva.Add(new XElement("color", identificadorD2));
                                fichanueva.Add(new XElement("columna", columnaD));
                                fichanueva.Add(new XElement("fila", fila2));

                            }
                            if (j == 1 && k == 4)
                            {
                                fichanueva.Add(new XElement("color", identificadorE2));
                                fichanueva.Add(new XElement("columna", columnaE));
                                fichanueva.Add(new XElement("fila", fila2));

                            }
                            if (j == 1 && k == 5)
                            {
                                fichanueva.Add(new XElement("color", identificadorF2));
                                fichanueva.Add(new XElement("columna", columnaF));
                                fichanueva.Add(new XElement("fila", fila2));

                            }
                            if (j == 1 && k == 6)
                            {
                                fichanueva.Add(new XElement("color", identificadorG2));
                                fichanueva.Add(new XElement("columna", columnaG));
                                fichanueva.Add(new XElement("fila", fila2));

                            }
                            if (j == 1 && k == 7)
                            {
                                fichanueva.Add(new XElement("color", identificadorH2));
                                fichanueva.Add(new XElement("columna", columnaH));
                                fichanueva.Add(new XElement("fila", fila2));

                            }
                            if (j == 2 && k == 0)
                            {
                                fichanueva.Add(new XElement("color", identificadorA3));
                                fichanueva.Add(new XElement("columna", columnaA));
                                fichanueva.Add(new XElement("fila", fila3));

                            }
                            if (j == 2 && k == 1)
                            {
                                fichanueva.Add(new XElement("color", identificadorB3));
                                fichanueva.Add(new XElement("columna", columnaB));
                                fichanueva.Add(new XElement("fila", fila3));

                            }
                            if (j == 2 && k == 2)
                            {
                                fichanueva.Add(new XElement("color", identificadorC3));
                                fichanueva.Add(new XElement("columna", columnaC));
                                fichanueva.Add(new XElement("fila", fila3));

                            }
                            if (j == 2 && k == 3)
                            {
                                fichanueva.Add(new XElement("color", identificadorD3));
                                fichanueva.Add(new XElement("columna", columnaD));
                                fichanueva.Add(new XElement("fila", fila3));

                            }
                            if (j == 2 && k == 4)
                            {
                                fichanueva.Add(new XElement("color", identificadorE3));
                                fichanueva.Add(new XElement("columna", columnaE));
                                fichanueva.Add(new XElement("fila", fila3));

                            }
                            if (j == 2 && k == 5)
                            {
                                fichanueva.Add(new XElement("color", identificadorF3));
                                fichanueva.Add(new XElement("columna", columnaF));
                                fichanueva.Add(new XElement("fila", fila3));

                            }
                            if (j == 2 && k == 6)
                            {
                                fichanueva.Add(new XElement("color", identificadorG3));
                                fichanueva.Add(new XElement("columna", columnaG));
                                fichanueva.Add(new XElement("fila", fila3));

                            }
                            if (j == 2 && k == 7)
                            {
                                fichanueva.Add(new XElement("color", identificadorH3));
                                fichanueva.Add(new XElement("columna", columnaH));
                                fichanueva.Add(new XElement("fila", fila3));

                            }
                            if (j == 3 && k == 0)
                            {
                                fichanueva.Add(new XElement("color", identificadorA4));
                                fichanueva.Add(new XElement("columna", columnaA));
                                fichanueva.Add(new XElement("fila", fila4));

                            }
                            if (j == 3 && k == 1)
                            {
                                fichanueva.Add(new XElement("color", identificadorB4));
                                fichanueva.Add(new XElement("columna", columnaB));
                                fichanueva.Add(new XElement("fila", fila4));

                            }
                            if (j == 3 && k == 2)
                            {
                                fichanueva.Add(new XElement("color", identificadorC4));
                                fichanueva.Add(new XElement("columna", columnaC));
                                fichanueva.Add(new XElement("fila", fila4));

                            }
                            if (j == 3 && k == 3)
                            {
                                fichanueva.Add(new XElement("color", identificadorD4));
                                fichanueva.Add(new XElement("columna", columnaD));
                                fichanueva.Add(new XElement("fila", fila4));

                            }
                            if (j == 3 && k == 4)
                            {
                                fichanueva.Add(new XElement("color", identificadorE4));
                                fichanueva.Add(new XElement("columna", columnaE));
                                fichanueva.Add(new XElement("fila", fila4));

                            }
                            if (j == 3 && k == 5)
                            {
                                fichanueva.Add(new XElement("color", identificadorF4));
                                fichanueva.Add(new XElement("columna", columnaF));
                                fichanueva.Add(new XElement("fila", fila4));

                            }
                            if (j == 3 && k == 6)
                            {
                                fichanueva.Add(new XElement("color", identificadorG4));
                                fichanueva.Add(new XElement("columna", columnaG));
                                fichanueva.Add(new XElement("fila", fila4));

                            }
                            if (j == 3 && k == 7)
                            {
                                fichanueva.Add(new XElement("color", identificadorH4));
                                fichanueva.Add(new XElement("columna", columnaH));
                                fichanueva.Add(new XElement("fila", fila4));

                            }
                            if (j == 4 && k == 0)
                            {
                                fichanueva.Add(new XElement("color", identificadorA5));
                                fichanueva.Add(new XElement("columna", columnaA));
                                fichanueva.Add(new XElement("fila", fila5));

                            }
                            if (j == 4 && k == 1)
                            {
                                fichanueva.Add(new XElement("color", identificadorB5));
                                fichanueva.Add(new XElement("columna", columnaB));
                                fichanueva.Add(new XElement("fila", fila5));

                            }
                            if (j == 4 && k == 2)
                            {
                                fichanueva.Add(new XElement("color", identificadorC5));
                                fichanueva.Add(new XElement("columna", columnaC));
                                fichanueva.Add(new XElement("fila", fila5));

                            }
                            if (j == 4 && k == 3)
                            {
                                fichanueva.Add(new XElement("color", identificadorD5));
                                fichanueva.Add(new XElement("columna", columnaD));
                                fichanueva.Add(new XElement("fila", fila5));

                            }
                            if (j == 4 && k == 4)
                            {
                                fichanueva.Add(new XElement("color", identificadorE5));
                                fichanueva.Add(new XElement("columna", columnaE));
                                fichanueva.Add(new XElement("fila", fila5));

                            }
                            if (j == 4 && k == 5)
                            {
                                fichanueva.Add(new XElement("color", identificadorF5));
                                fichanueva.Add(new XElement("columna", columnaF));
                                fichanueva.Add(new XElement("fila", fila5));

                            }
                            if (j == 4 && k == 6)
                            {
                                fichanueva.Add(new XElement("color", identificadorG5));
                                fichanueva.Add(new XElement("columna", columnaG));
                                fichanueva.Add(new XElement("fila", fila5));

                            }
                            if (j == 4 && k == 7)
                            {
                                fichanueva.Add(new XElement("color", identificadorH5));
                                fichanueva.Add(new XElement("columna", columnaH));
                                fichanueva.Add(new XElement("fila", fila5));

                            }
                            if (j == 5 && k == 0)
                            {
                                fichanueva.Add(new XElement("color", identificadorA6));
                                fichanueva.Add(new XElement("columna", columnaA));
                                fichanueva.Add(new XElement("fila", fila6));

                            }
                            if (j == 5 && k == 1)
                            {
                                fichanueva.Add(new XElement("color", identificadorB6));
                                fichanueva.Add(new XElement("columna", columnaB));
                                fichanueva.Add(new XElement("fila", fila6));

                            }
                            if (j == 5 && k == 2)
                            {
                                fichanueva.Add(new XElement("color", identificadorC6));
                                fichanueva.Add(new XElement("columna", columnaC));
                                fichanueva.Add(new XElement("fila", fila6));

                            }
                            if (j == 5 && k == 3)
                            {
                                fichanueva.Add(new XElement("color", identificadorD6));
                                fichanueva.Add(new XElement("columna", columnaD));
                                fichanueva.Add(new XElement("fila", fila6));

                            }
                            if (j == 5 && k == 4)
                            {
                                fichanueva.Add(new XElement("color", identificadorE6));
                                fichanueva.Add(new XElement("columna", columnaE));
                                fichanueva.Add(new XElement("fila", fila6));

                            }
                            if (j == 5 && k == 5)
                            {
                                fichanueva.Add(new XElement("color", identificadorF6));
                                fichanueva.Add(new XElement("columna", columnaF));
                                fichanueva.Add(new XElement("fila", fila6));

                            }
                            if (j == 5 && k == 6)
                            {
                                fichanueva.Add(new XElement("color", identificadorG6));
                                fichanueva.Add(new XElement("columna", columnaG));
                                fichanueva.Add(new XElement("fila", fila6));

                            }
                            if (j == 5 && k == 7)
                            {
                                fichanueva.Add(new XElement("color", identificadorH6));
                                fichanueva.Add(new XElement("columna", columnaH));
                                fichanueva.Add(new XElement("fila", fila6));

                            }
                            if (j == 6 && k == 0)
                            {
                                fichanueva.Add(new XElement("color", identificadorA7));
                                fichanueva.Add(new XElement("columna", columnaA));
                                fichanueva.Add(new XElement("fila", fila7));

                            }
                            if (j == 6 && k == 1)
                            {
                                fichanueva.Add(new XElement("color", identificadorB7));
                                fichanueva.Add(new XElement("columna", columnaB));
                                fichanueva.Add(new XElement("fila", fila7));

                            }
                            if (j == 6 && k == 2)
                            {
                                fichanueva.Add(new XElement("color", identificadorC7));
                                fichanueva.Add(new XElement("columna", columnaC));
                                fichanueva.Add(new XElement("fila", fila7));

                            }
                            if (j == 6 && k == 3)
                            {
                                fichanueva.Add(new XElement("color", identificadorD7));
                                fichanueva.Add(new XElement("columna", columnaD));
                                fichanueva.Add(new XElement("fila", fila7));

                            }
                            if (j == 6 && k == 4)
                            {
                                fichanueva.Add(new XElement("color", identificadorE7));
                                fichanueva.Add(new XElement("columna", columnaE));
                                fichanueva.Add(new XElement("fila", fila7));

                            }
                            if (j == 6 && k == 5)
                            {
                                fichanueva.Add(new XElement("color", identificadorF7));
                                fichanueva.Add(new XElement("columna", columnaF));
                                fichanueva.Add(new XElement("fila", fila7));

                            }
                            if (j == 6 && k == 6)
                            {
                                fichanueva.Add(new XElement("color", identificadorG7));
                                fichanueva.Add(new XElement("columna", columnaG));
                                fichanueva.Add(new XElement("fila", fila7));

                            }
                            if (j == 6 && k == 7)
                            {
                                fichanueva.Add(new XElement("color", identificadorH7));
                                fichanueva.Add(new XElement("columna", columnaH));
                                fichanueva.Add(new XElement("fila", fila7));

                            }
                            if (j == 7 && k == 0)
                            {
                                fichanueva.Add(new XElement("color", identificadorA8));
                                fichanueva.Add(new XElement("columna", columnaA));
                                fichanueva.Add(new XElement("fila", fila8));

                            }
                            if (j == 7 && k == 1)
                            {
                                fichanueva.Add(new XElement("color", identificadorB8));
                                fichanueva.Add(new XElement("columna", columnaB));
                                fichanueva.Add(new XElement("fila", fila8));

                            }
                            if (j == 7 && k == 2)
                            {
                                fichanueva.Add(new XElement("color", identificadorC8));
                                fichanueva.Add(new XElement("columna", columnaC));
                                fichanueva.Add(new XElement("fila", fila8));

                            }
                            if (j == 7 && k == 3)
                            {
                                fichanueva.Add(new XElement("color", identificadorD8));
                                fichanueva.Add(new XElement("columna", columnaD));
                                fichanueva.Add(new XElement("fila", fila8));

                            }
                            if (j == 7 && k == 4)
                            {
                                fichanueva.Add(new XElement("color", identificadorE8));
                                fichanueva.Add(new XElement("columna", columnaE));
                                fichanueva.Add(new XElement("fila", fila8));

                            }
                            if (j == 7 && k == 5)
                            {
                                fichanueva.Add(new XElement("color", identificadorF8));
                                fichanueva.Add(new XElement("columna", columnaF));
                                fichanueva.Add(new XElement("fila", fila8));

                            }
                            if (j == 7 && k == 6)
                            {
                                fichanueva.Add(new XElement("color", identificadorG8));
                                fichanueva.Add(new XElement("columna", columnaG));
                                fichanueva.Add(new XElement("fila", fila8));

                            }
                            if (j == 7 && k == 7)
                            {
                                fichanueva.Add(new XElement("color", identificadorH8));
                                fichanueva.Add(new XElement("columna", columnaH));
                                fichanueva.Add(new XElement("fila", fila8));

                            }
                            raiz.Add(fichanueva);
                        }
                    }
                }
            }




            /*
            XElement fichaA1 = new XElement("fichaA1");
            fichaA1.Add(new XElement("color", identificadorA1));
            fichaA1.Add(new XElement("columna", columnaA1));
            fichaA1.Add(new XElement("fila", filaA1));
            raiz.Add(fichaA1);
            XElement fichaB1 = new XElement("fichaB1");
            fichaB1.Add(new XElement("color", identificadorB1));
            fichaB1.Add(new XElement("columna", columnaB1));
            fichaB1.Add(new XElement("fila", filaB1));
            raiz.Add(fichaB1);
            XElement fichaC1 = new XElement("fichaC1");
            fichaC1.Add(new XElement("color", identificadorC1));
            fichaC1.Add(new XElement("columna", columnaC1));
            fichaC1.Add(new XElement("fila", filaC1));
            raiz.Add(fichaC1);
            XElement fichaD1 = new XElement("fichaD1");
            fichaD1.Add(new XElement("color", identificadorD1));
            fichaD1.Add(new XElement("columna", columnaD1));
            fichaD1.Add(new XElement("fila", filaD1));
            raiz.Add(fichaD1);
            XElement fichaE1 = new XElement("fichaE1");
            fichaE1.Add(new XElement("color", identificadorE1));
            fichaE1.Add(new XElement("columna", columnaE1));
            fichaE1.Add(new XElement("fila", filaE1));
            raiz.Add(fichaE1);
            XElement fichaF1 = new XElement("fichaF1");
            fichaF1.Add(new XElement("color", identificadorF1));
            fichaF1.Add(new XElement("columna", columnaF1));
            fichaF1.Add(new XElement("fila", filaF1));
            raiz.Add(fichaF1);
            XElement fichaG1 = new XElement("fichaG1");
            fichaG1.Add(new XElement("color", identificadorG1));
            fichaG1.Add(new XElement("columna", columnaG1));
            fichaG1.Add(new XElement("fila", filaG1));
            raiz.Add(fichaG1);
            XElement fichaH1 = new XElement("fichaH1");
            fichaH1.Add(new XElement("color", identificadorH1));
            fichaH1.Add(new XElement("columna", columnaH1));
            fichaH1.Add(new XElement("fila", filaH1));
            raiz.Add(fichaH1);
            XElement fichaA2 = new XElement("fichaA2");
            fichaA2.Add(new XElement("color", identificadorA2));
            fichaA2.Add(new XElement("columna", columnaA2));
            fichaA2.Add(new XElement("fila", filaA2));
            raiz.Add(fichaA2);
            XElement fichaB2 = new XElement("fichaB2");
            fichaB2.Add(new XElement("color", identificadorB2));
            fichaB2.Add(new XElement("columna", columnaB2));
            fichaB2.Add(new XElement("fila", filaB2));
            raiz.Add(fichaB2);
            XElement fichaC2 = new XElement("fichaC2");
            fichaC2.Add(new XElement("color", identificadorC2));
            fichaC2.Add(new XElement("columna", columnaC2));
            fichaC2.Add(new XElement("fila", filaC2));
            raiz.Add(fichaC2);
            XElement fichaD2 = new XElement("fichaD2");
            fichaD2.Add(new XElement("color", identificadorD2));
            fichaD2.Add(new XElement("columna", columnaD2));
            fichaD2.Add(new XElement("fila", filaD2));
            raiz.Add(fichaD2);
            XElement fichaE2 = new XElement("fichaE2");
            fichaE2.Add(new XElement("color", identificadorE2));
            fichaE2.Add(new XElement("columna", columnaE2));
            fichaE2.Add(new XElement("fila", filaE2));
            raiz.Add(fichaE2);
            XElement fichaF2 = new XElement("fichaF2");
            fichaF2.Add(new XElement("color", identificadorF2));
            fichaF2.Add(new XElement("columna", columnaF2));
            fichaF2.Add(new XElement("fila", filaF2));
            raiz.Add(fichaF2);
            XElement fichaG2 = new XElement("fichaG2");
            fichaG2.Add(new XElement("color", identificadorG2));
            fichaG2.Add(new XElement("columna", columnaG2));
            fichaG2.Add(new XElement("fila", filaG2));
            raiz.Add(fichaG2);
            XElement fichaH2 = new XElement("fichaH2");
            fichaH2.Add(new XElement("color", identificadorH2));
            fichaH2.Add(new XElement("columna", columnaH2));
            fichaH2.Add(new XElement("fila", filaH2));
            raiz.Add(fichaH2);
            XElement fichaA3 = new XElement("fichaA3");
            fichaA3.Add(new XElement("color", identificadorA3));
            fichaA3.Add(new XElement("columna", columnaA3));
            fichaA3.Add(new XElement("fila", filaA3));
            raiz.Add(fichaA3);
            XElement fichaB3 = new XElement("fichaB3");
            fichaB3.Add(new XElement("color", identificadorB3));
            fichaB3.Add(new XElement("columna", columnaB3));
            fichaB3.Add(new XElement("fila", filaB3));
            raiz.Add(fichaB3);
            XElement fichaC3 = new XElement("fichaC3");
            fichaC3.Add(new XElement("color", identificadorC3));
            fichaC3.Add(new XElement("columna", columnaC3));
            fichaC3.Add(new XElement("fila", filaC3));
            raiz.Add(fichaC3);
            XElement fichaD3 = new XElement("fichaD3");
            fichaD3.Add(new XElement("color", identificadorD3));
            fichaD3.Add(new XElement("columna", columnaD3));
            fichaD3.Add(new XElement("fila", filaD3));
            raiz.Add(fichaD3);
            XElement fichaE3 = new XElement("fichaE3");
            fichaE3.Add(new XElement("color", identificadorE3));
            fichaE3.Add(new XElement("columna", columnaE3));
            fichaE3.Add(new XElement("fila", filaE3));
            raiz.Add(fichaE3);
            XElement fichaF3 = new XElement("fichaF3");
            fichaF3.Add(new XElement("color", identificadorF3));
            fichaF3.Add(new XElement("columna", columnaF3));
            fichaF3.Add(new XElement("fila", filaF3));
            raiz.Add(fichaF3);
            XElement fichaG3 = new XElement("fichaG3");
            fichaG3.Add(new XElement("color", identificadorG3));
            fichaG3.Add(new XElement("columna", columnaG3));
            fichaG3.Add(new XElement("fila", filaG3));
            raiz.Add(fichaG3);
            XElement fichaH3 = new XElement("fichaH3");
            fichaH3.Add(new XElement("color", identificadorH3));
            fichaH3.Add(new XElement("columna", columnaH3));
            fichaH3.Add(new XElement("fila", filaH3));
            raiz.Add(fichaH3);
            XElement fichaA4 = new XElement("fichaA4");
            fichaA4.Add(new XElement("color", identificadorA4));
            fichaA4.Add(new XElement("columna", columnaA4));
            fichaA4.Add(new XElement("fila", filaA4));
            raiz.Add(fichaA4);
            XElement fichaB4 = new XElement("fichaB4");
            fichaB4.Add(new XElement("color", identificadorB4));
            fichaB4.Add(new XElement("columna", columnaB4));
            fichaB4.Add(new XElement("fila", filaB4));
            raiz.Add(fichaB4);
            XElement fichaC4 = new XElement("fichaC4");
            fichaC4.Add(new XElement("color", identificadorC4));
            fichaC4.Add(new XElement("columna", columnaC4));
            fichaC4.Add(new XElement("fila", filaC4));
            raiz.Add(fichaC4);
            XElement fichaD4 = new XElement("fichaD4");
            fichaD4.Add(new XElement("color", identificadorD4));
            fichaD4.Add(new XElement("columna", columnaD4));
            fichaD4.Add(new XElement("fila", filaD4));
            raiz.Add(fichaD4);
            XElement fichaE4 = new XElement("fichaE4");
            fichaE4.Add(new XElement("color", identificadorE4));
            fichaE4.Add(new XElement("columna", columnaE4));
            fichaE4.Add(new XElement("fila", filaE4));
            raiz.Add(fichaE4);
            XElement fichaF4 = new XElement("fichaF4");
            fichaF4.Add(new XElement("color", identificadorF4));
            fichaF4.Add(new XElement("columna", columnaF4));
            fichaF4.Add(new XElement("fila", filaF4));
            raiz.Add(fichaF4);
            XElement fichaG4 = new XElement("fichaG4");
            fichaG4.Add(new XElement("color", identificadorG4));
            fichaG4.Add(new XElement("columna", columnaG4));
            fichaG4.Add(new XElement("fila", filaG4));
            raiz.Add(fichaG4);
            XElement fichaH4 = new XElement("fichaH4");
            fichaH4.Add(new XElement("color", identificadorH4));
            fichaH4.Add(new XElement("columna", columnaH4));
            fichaH4.Add(new XElement("fila", filaH4));
            raiz.Add(fichaH4);
            XElement fichaA5 = new XElement("fichaA5");
            fichaA5.Add(new XElement("color", identificadorA5));
            fichaA5.Add(new XElement("columna", columnaA5));
            fichaA5.Add(new XElement("fila", filaA5));
            raiz.Add(fichaA5);
            XElement fichaB5 = new XElement("fichaB5");
            fichaB5.Add(new XElement("color", identificadorB5));
            fichaB5.Add(new XElement("columna", columnaB5));
            fichaB5.Add(new XElement("fila", filaB5));
            raiz.Add(fichaB5);
            XElement fichaC5 = new XElement("fichaC5");
            fichaC5.Add(new XElement("color", identificadorC5));
            fichaC5.Add(new XElement("columna", columnaC5));
            fichaC5.Add(new XElement("fila", filaC5));
            raiz.Add(fichaC5);
            XElement fichaD5 = new XElement("fichaD5");
            fichaD5.Add(new XElement("color", identificadorD5));
            fichaD5.Add(new XElement("columna", columnaD5));
            fichaD5.Add(new XElement("fila", filaD5));
            raiz.Add(fichaD5);
            XElement fichaE5 = new XElement("fichaE5");
            fichaE5.Add(new XElement("color", identificadorE5));
            fichaE5.Add(new XElement("columna", columnaE5));
            fichaE5.Add(new XElement("fila", filaE5));
            raiz.Add(fichaE5);
            XElement fichaF5 = new XElement("fichaF5");
            fichaF5.Add(new XElement("color", identificadorF5));
            fichaF5.Add(new XElement("columna", columnaF5));
            fichaF5.Add(new XElement("fila", filaF5));
            raiz.Add(fichaF5);
            XElement fichaG5 = new XElement("fichaG5");
            fichaG5.Add(new XElement("color", identificadorG5));
            fichaG5.Add(new XElement("columna", columnaG5));
            fichaG5.Add(new XElement("fila", filaG5));
            raiz.Add(fichaG5);
            XElement fichaH5 = new XElement("fichaH5");
            fichaH5.Add(new XElement("color", identificadorH5));
            fichaH5.Add(new XElement("columna", columnaH5));
            fichaH5.Add(new XElement("fila", filaH5));
            raiz.Add(fichaH5);
            XElement fichaA6 = new XElement("fichaA6");
            fichaA6.Add(new XElement("color", identificadorA6));
            fichaA6.Add(new XElement("columna", columnaA6));
            fichaA6.Add(new XElement("fila", filaA6));
            raiz.Add(fichaA6);
            XElement fichaB6 = new XElement("fichaB6");
            fichaB6.Add(new XElement("color", identificadorB6));
            fichaB6.Add(new XElement("columna", columnaB6));
            fichaB6.Add(new XElement("fila", filaB6));
            raiz.Add(fichaB6);
            XElement fichaC6 = new XElement("fichaC6");
            fichaC6.Add(new XElement("color", identificadorC6));
            fichaC6.Add(new XElement("columna", columnaC6));
            fichaC6.Add(new XElement("fila", filaC6));
            raiz.Add(fichaC6);
            XElement fichaD6 = new XElement("fichaD6");
            fichaD6.Add(new XElement("color", identificadorD6));
            fichaD6.Add(new XElement("columna", columnaD6));
            fichaD6.Add(new XElement("fila", filaD6));
            raiz.Add(fichaD6);
            XElement fichaE6 = new XElement("fichaE6");
            fichaE6.Add(new XElement("color", identificadorE6));
            fichaE6.Add(new XElement("columna", columnaE6));
            fichaE6.Add(new XElement("fila", filaE6));
            raiz.Add(fichaE6);
            XElement fichaF6 = new XElement("fichaF6");
            fichaF6.Add(new XElement("color", identificadorF6));
            fichaF6.Add(new XElement("columna", columnaF6));
            fichaF6.Add(new XElement("fila", filaF6));
            raiz.Add(fichaF6);
            XElement fichaG6 = new XElement("fichaG6");
            fichaG6.Add(new XElement("color", identificadorG6));
            fichaG6.Add(new XElement("columna", columnaG6));
            fichaG6.Add(new XElement("fila", filaG6));
            raiz.Add(fichaG6);
            XElement fichaH6 = new XElement("fichaH6");
            fichaH6.Add(new XElement("color", identificadorH6));
            fichaH6.Add(new XElement("columna", columnaH6));
            fichaH6.Add(new XElement("fila", filaH6));
            raiz.Add(fichaH6);
            XElement fichaA7 = new XElement("fichaA7");
            fichaA7.Add(new XElement("color", identificadorA7));
            fichaA7.Add(new XElement("columna", columnaA7));
            fichaA7.Add(new XElement("fila", filaA7));
            raiz.Add(fichaA7);
            XElement fichaB7 = new XElement("fichaB7");
            fichaB7.Add(new XElement("color", identificadorB7));
            fichaB7.Add(new XElement("columna", columnaB7));
            fichaB7.Add(new XElement("fila", filaB7));
            raiz.Add(fichaB7);
            XElement fichaC7 = new XElement("fichaC7");
            fichaC7.Add(new XElement("color", identificadorC7));
            fichaC7.Add(new XElement("columna", columnaC7));
            fichaC7.Add(new XElement("fila", filaC7));
            raiz.Add(fichaC7);
            XElement fichaD7 = new XElement("fichaD7");
            fichaD7.Add(new XElement("color", identificadorD7));
            fichaD7.Add(new XElement("columna", columnaD7));
            fichaD7.Add(new XElement("fila", filaD7));
            raiz.Add(fichaD7);
            XElement fichaE7 = new XElement("fichaE7");
            fichaE7.Add(new XElement("color", identificadorE7));
            fichaE7.Add(new XElement("columna", columnaE7));
            fichaE7.Add(new XElement("fila", filaE7));
            raiz.Add(fichaE7);
            XElement fichaF7 = new XElement("fichaF7");
            fichaF7.Add(new XElement("color", identificadorF7));
            fichaF7.Add(new XElement("columna", columnaF7));
            fichaF7.Add(new XElement("fila", filaF7));
            raiz.Add(fichaF7);
            XElement fichaG7 = new XElement("fichaG7");
            fichaG7.Add(new XElement("color", identificadorG7));
            fichaG7.Add(new XElement("columna", columnaG7));
            fichaG7.Add(new XElement("fila", filaG7));
            raiz.Add(fichaG7);
            XElement fichaH7 = new XElement("fichaH7");
            fichaH7.Add(new XElement("color", identificadorH7));
            fichaH7.Add(new XElement("columna", columnaH7));
            fichaH7.Add(new XElement("fila", filaH7));
            raiz.Add(fichaH7);
            XElement fichaA8 = new XElement("fichaA8");
            fichaA8.Add(new XElement("color", identificadorA8));
            fichaA8.Add(new XElement("columna", columnaA8));
            fichaA8.Add(new XElement("fila", filaA8));
            raiz.Add(fichaA8);
            XElement fichaB8 = new XElement("fichaB8");
            fichaB8.Add(new XElement("color", identificadorB8));
            fichaB8.Add(new XElement("columna", columnaB8));
            fichaB8.Add(new XElement("fila", filaB8));
            raiz.Add(fichaB8);
            XElement fichaC8 = new XElement("fichaC8");
            fichaC8.Add(new XElement("color", identificadorC8));
            fichaC8.Add(new XElement("columna", columnaC8));
            fichaC8.Add(new XElement("fila", filaC8));
            raiz.Add(fichaC8);
            XElement fichaD8 = new XElement("fichaD8");
            fichaD8.Add(new XElement("color", identificadorD8));
            fichaD8.Add(new XElement("columna", columnaD8));
            fichaD8.Add(new XElement("fila", filaD8));
            raiz.Add(fichaD8);
            XElement fichaE8 = new XElement("fichaE8");
            fichaE8.Add(new XElement("color", identificadorE8));
            fichaE8.Add(new XElement("columna", columnaE8));
            fichaE8.Add(new XElement("fila", filaE8));
            raiz.Add(fichaE8);
            XElement fichaF8 = new XElement("fichaF8");
            fichaF8.Add(new XElement("color", identificadorF8));
            fichaF8.Add(new XElement("columna", columnaF8));
            fichaF8.Add(new XElement("fila", filaF8));
            raiz.Add(fichaF8);
            XElement fichaG8 = new XElement("fichaG8");
            fichaG8.Add(new XElement("color", identificadorG8));
            fichaG8.Add(new XElement("columna", columnaG8));
            fichaG8.Add(new XElement("fila", filaG8));
            raiz.Add(fichaG8);
            XElement fichaH8 = new XElement("fichaH8");
            fichaH8.Add(new XElement("color", identificadorH8));
            fichaH8.Add(new XElement("columna", columnaH8));
            fichaH8.Add(new XElement("fila", filaH8));
            raiz.Add(fichaH8);*/
            /*Cargar Usuario*/
            String mandar = "SELECT IdUsuario FROM Usuario WHERE nickname=@nickname";
            SqlCommand mandando = new SqlCommand(mandar, conectar.Leer());
            mandando.Parameters.AddWithValue("@nickname", ProyectoEntregable2.Login.UsuarioLogeado);
            mandando.ExecuteNonQuery();
            SqlDataReader validacion = mandando.ExecuteReader();
            
            if (validacion.Read())
            {
                /*Cargando valor IdUsuario*/
                idUsuarioCargado = Convert.ToString(validacion["IdUsuario"]);
                /*Crear archivo xml en ruta*/
                crearXML.Save(@"C:\Users\mario\OneDrive\Documentos\GitHub\Proyecto1\ProyectoEntregable2\XMLArchivos\Archivo" + ProyectoEntregable2.Login.UsuarioLogeado + contadorxml.ToString() + ".xml");
                String crearArchivo = "INSERT INTO Archivo (ruta, IdUsuario) VALUES (@ruta, @IdUsuario)";
                SqlCommand creandoArchivo = new SqlCommand(crearArchivo, conectar.Leer());
                rutabase = "C:\\Users\\mario\\OneDrive\\Documentos\\GitHub\\Proyecto1\\ProyectoEntregable2\\XMLArchivos\\Archivo" + ProyectoEntregable2.Login.UsuarioLogeado + contadorxml.ToString() + ".xml";
                creandoArchivo.Parameters.AddWithValue("@ruta", rutabase);
                creandoArchivo.Parameters.AddWithValue("@IdUsuario", idUsuarioCargado);
                creandoArchivo.ExecuteNonQuery();
                contadorxml++;
                /*Validando archivo ya registrado
                String archivobuscarid = "SELECT IdArchivo, ruta FROM Archivo WHERE ruta=@ruta";
                SqlCommand archivobuscandoid = new SqlCommand(archivobuscarid, conectar.Leer());
                archivobuscandoid.Parameters.AddWithValue("@ruta", rutabase);
                archivobuscandoid.ExecuteNonQuery();
                SqlDataReader archivobuscaridahora = archivobuscandoid.ExecuteReader();
                if (archivobuscaridahora.Read())
                {
                    if (!idArchivo.Equals("0"))
                    {
                        idArchivo = Convert.ToString(archivobuscaridahora["IdArchivo"]);
                    }
                }*/
                /*Regresando a pagina principal*/
                Response.Redirect("PaginaPrincipal.aspx");
                    
            }
            else
            {
                /*Cargando valor IdUsuario*/
                idUsuarioCargado = Convert.ToString(validacion["IdUsuario"]);
                /*Crear archivo xml en ruta*/
                crearXML.Save(@"C:\Users\mario\OneDrive\Documentos\GitHub\Proyecto1\ProyectoEntregable2\XMLArchivos\Archivo" + ProyectoEntregable2.Login.UsuarioLogeado + contadorxml.ToString() + ".xml");
                String crearArchivo = "INSERT INTO Archivo (ruta, IdUsuario) VALUES (@ruta, @IdUsuario)";
                SqlCommand creandoArchivo = new SqlCommand(crearArchivo, conectar.Leer());
                rutabase = "C:\\Users\\mario\\OneDrive\\Documentos\\GitHub\\Proyecto1\\ProyectoEntregable2\\XMLArchivos\\Archivo" + ProyectoEntregable2.Login.UsuarioLogeado + contadorxml.ToString() + ".xml";
                creandoArchivo.Parameters.AddWithValue("@ruta", rutabase);
                creandoArchivo.Parameters.AddWithValue("@IdUsuario", idUsuarioCargado);
                creandoArchivo.ExecuteNonQuery();
                contadorxml++;
                Response.Redirect("PaginaPrincipal.aspx");
            }
            
        }

        protected void Button376_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaPrincipal.aspx");
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
                            contenidotablero = new string[] { fila1, columnaA, identificadorA1 };
                        }
                        if (j == 0 && k == 1)
                        {
                            contenidotablero[0] = fila1;
                            contenidotablero[1] = columnaB;
                            contenidotablero[2] = identificadorB1;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 0 && k == 2)
                        {
                            contenidotablero[0] = fila1;
                            contenidotablero[1] = columnaC;
                            contenidotablero[2] = identificadorC1;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 0 && k == 3)
                        {
                            contenidotablero[0] = fila1;
                            contenidotablero[1] = columnaD;
                            contenidotablero[2] = identificadorD1;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 0 && k == 4)
                        {
                            contenidotablero[0] = fila1;
                            contenidotablero[1] = columnaE;
                            contenidotablero[2] = identificadorE1;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 0 && k == 5)
                        {
                            contenidotablero[0] = fila1;
                            contenidotablero[1] = columnaF;
                            contenidotablero[2] = identificadorF1;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 0 && k == 6)
                        {
                            contenidotablero[0] = fila1;
                            contenidotablero[1] = columnaG;
                            contenidotablero[2] = identificadorG1;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 0 && k == 7)
                        {
                            contenidotablero[0] = fila1;
                            contenidotablero[1] = columnaH;
                            contenidotablero[2] = identificadorH1;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 1 && k == 0)
                        {
                            contenidotablero[0] = fila2;
                            contenidotablero[1] = columnaA;
                            contenidotablero[2] = identificadorA2;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 1 && k == 1)
                        {
                            contenidotablero[0] = fila2;
                            contenidotablero[1] = columnaB;
                            contenidotablero[2] = identificadorB2;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 1 && k == 2)
                        {
                            contenidotablero[0] = fila2;
                            contenidotablero[1] = columnaC;
                            contenidotablero[2] = identificadorC2;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 1 && k == 3)
                        {
                            contenidotablero[0] = fila2;
                            contenidotablero[1] = columnaD;
                            contenidotablero[2] = identificadorD2;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 1 && k == 4)
                        {
                            contenidotablero[0] = fila2;
                            contenidotablero[1] = columnaE;
                            contenidotablero[2] = identificadorE2;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 1 && k == 5)
                        {
                            contenidotablero[0] = fila2;
                            contenidotablero[1] = columnaF;
                            contenidotablero[2] = identificadorF2;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 1 && k == 6)
                        {
                            contenidotablero[0] = fila2;
                            contenidotablero[1] = columnaG;
                            contenidotablero[2] = identificadorG2;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 1 && k == 7)
                        {
                            contenidotablero[0] = fila2;
                            contenidotablero[1] = columnaH;
                            contenidotablero[2] = identificadorH2;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 2 && k == 0)
                        {
                            contenidotablero[0] = fila3;
                            contenidotablero[1] = columnaA;
                            contenidotablero[2] = identificadorA3;                                matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 2 && k == 1)
                        {
                            contenidotablero[0] = fila3;
                            contenidotablero[1] = columnaB;
                            contenidotablero[2] = identificadorB3;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 2 && k == 2)
                        {
                            contenidotablero[0] = fila3;
                            contenidotablero[1] = columnaC;
                            contenidotablero[2] = identificadorC3;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 2 && k == 3)
                        {
                            contenidotablero[0] = fila3;
                            contenidotablero[1] = columnaD;
                            contenidotablero[2] = identificadorD3;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 2 && k == 4)
                        {
                            contenidotablero[0] = fila3;
                            contenidotablero[1] = columnaE;
                            contenidotablero[2] = identificadorE3;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 2 && k == 5)
                        {
                            contenidotablero[0] = fila3;
                            contenidotablero[1] = columnaF;
                            contenidotablero[2] = identificadorF3;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 2 && k == 6)
                        {
                            contenidotablero[0] = fila3;
                            contenidotablero[1] = columnaG;
                            contenidotablero[2] = identificadorG3;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 2 && k == 7)
                        {
                            contenidotablero[0] = fila3;
                            contenidotablero[1] = columnaH;
                            contenidotablero[2] = identificadorH3;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 3 && k == 0)
                        {
                            contenidotablero[0] = fila4;
                            contenidotablero[1] = columnaA;
                            contenidotablero[2] = identificadorA4;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 3 && k == 1)
                        {
                            contenidotablero[0] = fila4;
                            contenidotablero[1] = columnaB;
                            contenidotablero[2] = identificadorB4;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 3 && k == 2)
                        {
                            contenidotablero[0] = fila4;
                            contenidotablero[1] = columnaC;
                            contenidotablero[2] = identificadorC4;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 3 && k == 3)
                        {
                            contenidotablero[0] = fila4;
                            contenidotablero[1] = columnaD;
                            contenidotablero[2] = identificadorD4;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 3 && k == 4)
                        {
                            contenidotablero[0] = fila4;
                            contenidotablero[1] = columnaE;
                            contenidotablero[2] = identificadorE4;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 3 && k == 5)
                        {
                            contenidotablero[0] = fila4;
                            contenidotablero[1] = columnaF;
                            contenidotablero[2] = identificadorF4;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 3 && k == 6)
                        {
                            contenidotablero[0] = fila4;
                            contenidotablero[1] = columnaG;
                            contenidotablero[2] = identificadorG4;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 3 && k == 7)
                        {
                            contenidotablero[0] = fila4;
                            contenidotablero[1] = columnaH;
                            contenidotablero[2] = identificadorH4;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 4 && k == 0)
                        {
                            contenidotablero[0] = fila5;
                            contenidotablero[1] = columnaA;
                            contenidotablero[2] = identificadorA5;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 4 && k == 1)
                        {
                            contenidotablero[0] = fila5;
                            contenidotablero[1] = columnaB;
                            contenidotablero[2] = identificadorB5;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 4 && k == 2)
                        {
                            contenidotablero[0] = fila5;
                            contenidotablero[1] = columnaC;
                            contenidotablero[2] = identificadorC5;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 4 && k == 3)
                        {
                            contenidotablero[0] = fila5;
                            contenidotablero[1] = columnaD;
                            contenidotablero[2] = identificadorD5;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 4 && k == 4)
                        {
                            contenidotablero[0] = fila5;
                            contenidotablero[1] = columnaE;
                            contenidotablero[2] = identificadorE5;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 4 && k == 5)
                        {
                            contenidotablero[0] = fila5;
                            contenidotablero[1] = columnaF;
                            contenidotablero[2] = identificadorF5;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 4 && k == 6)
                        {
                            contenidotablero[0] = fila5;
                            contenidotablero[1] = columnaG;
                            contenidotablero[2] = identificadorG5;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 4 && k == 7)
                        {
                            contenidotablero[0] = fila5;
                            contenidotablero[1] = columnaH;
                            contenidotablero[2] = identificadorH5;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 5 && k == 0)
                        {
                            contenidotablero[0] = fila6;
                            contenidotablero[1] = columnaA;
                            contenidotablero[2] = identificadorA6;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 5 && k == 1)
                        {
                            contenidotablero[0] = fila6;
                            contenidotablero[1] = columnaB;
                            contenidotablero[2] = identificadorB6;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 5 && k == 2)
                        {
                            contenidotablero[0] = fila6;
                            contenidotablero[1] = columnaC;
                            contenidotablero[2] = identificadorC6;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 5 && k == 3)
                        {
                            contenidotablero[0] = fila6;
                            contenidotablero[1] = columnaD;
                            contenidotablero[2] = identificadorD6;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 5 && k == 4)
                        {
                            contenidotablero[0] = fila6;
                            contenidotablero[1] = columnaE;
                            contenidotablero[2] = identificadorE6;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 5 && k == 5)
                        {
                            contenidotablero[0] = fila6;
                            contenidotablero[1] = columnaF;
                            contenidotablero[2] = identificadorF6;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 5 && k == 6)
                        {
                            contenidotablero[0] = fila6;
                            contenidotablero[1] = columnaG;
                            contenidotablero[2] = identificadorG6;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 5 && k == 7)
                        {
                            contenidotablero[0] = fila6;
                            contenidotablero[1] = columnaH;
                            contenidotablero[2] = identificadorH6;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 6 && k == 0)
                        {
                            contenidotablero[0] = fila7;
                            contenidotablero[1] = columnaA;
                            contenidotablero[2] = identificadorA7;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 6 && k == 1)
                        {
                            contenidotablero[0] = fila7;
                            contenidotablero[1] = columnaB;
                            contenidotablero[2] = identificadorB7;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 6 && k == 2)
                        {
                            contenidotablero[0] = fila7;
                            contenidotablero[1] = columnaC;
                            contenidotablero[2] = identificadorC7;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 6 && k == 3)
                        {
                            contenidotablero[0] = fila7;
                            contenidotablero[1] = columnaD;
                            contenidotablero[2] = identificadorD7;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 6 && k == 4)
                        {
                            contenidotablero[0] = fila7;
                            contenidotablero[1] = columnaE;
                            contenidotablero[2] = identificadorE7;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 6 && k == 5)
                        {
                            contenidotablero[0] = fila7;
                            contenidotablero[1] = columnaF;
                            contenidotablero[2] = identificadorF7;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 6 && k == 6)
                        {
                            contenidotablero[0] = fila7;
                            contenidotablero[1] = columnaG;
                            contenidotablero[2] = identificadorG7;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 6 && k == 7)
                        {
                            contenidotablero[0] = fila7;
                            contenidotablero[1] = columnaH;
                            contenidotablero[2] = identificadorH7;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 7 && k == 0)
                        {
                            contenidotablero[0] = fila8;
                            contenidotablero[1] = columnaA;
                            contenidotablero[2] = identificadorA8;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 7 && k == 1)
                        {
                            contenidotablero[0] = fila8;
                            contenidotablero[1] = columnaB;
                            contenidotablero[2] = identificadorB8;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 7 && k == 2)
                        {
                            contenidotablero[0] = fila8;
                            contenidotablero[1] = columnaC;
                            contenidotablero[2] = identificadorC8;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 7 && k == 3)
                        {
                            contenidotablero[0] = fila8;
                            contenidotablero[1] = columnaD;
                            contenidotablero[2] = identificadorD8;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 7 && k == 4)
                        {
                            contenidotablero[0] = fila8;
                            contenidotablero[1] = columnaE;
                            contenidotablero[2] = identificadorE8;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 7 && k == 5)
                        {
                            contenidotablero[0] = fila8;
                            contenidotablero[1] = columnaF;
                            contenidotablero[2] = identificadorF8;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 7 && k == 6)
                        {
                            contenidotablero[0] = fila8;
                            contenidotablero[1] = columnaG;
                            contenidotablero[2] = identificadorG8;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                        if (j == 7 && k == 7)
                        {
                            contenidotablero[0] = fila8;
                            contenidotablero[1] = columnaH;
                            contenidotablero[2] = identificadorH8;
                            matriztablero[j][k] = contenidotablero.ToString();
                        }
                    }
                }
            }
        }
    }
}

