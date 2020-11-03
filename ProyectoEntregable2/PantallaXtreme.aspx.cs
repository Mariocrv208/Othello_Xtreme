using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace ProyectoEntregable2
{
    public partial class PantallaXtreme : System.Web.UI.Page
    {
        conect conectar = new conect();
        static bool validacionColor1 = false;
        static bool validacionColor2 = false;
        static string colorGlobal = "";
        static string ultimo1 = "";
        static string ultimo2 = "";
        static bool validacionUsado = false;
        static int contadorxml = 0;
        static int filaT = 0;
        static int columnaT = 0;
        static string[][] matriztablero;
        static string[] contenidotablero;
        static string identificadorGlobal = "";
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
        static string literal = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Tablero();
            if (colorGlobal == "")
            {
                colorSiguiente();
            }
            TextBox4.Text = PaginaPrincipal.nombre2;
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

        protected void Tablero()
        {
            filaT = Int32.Parse(PaginaPrincipal.filasT) + 2;
            columnaT = Int32.Parse(PaginaPrincipal.columnasT) + 2;
            ImageButton[,] boton = new ImageButton[filaT, columnaT];
            Button[,] orilla = new Button[filaT, columnaT];
            for (int i = 0; i < filaT; i++)
            {
                TableRow row = new TableRow();
                for (int j = 0; j < columnaT; j++)
                {
                    if((i == 0 && j == 0) || (i == (filaT - 1) && j == 0) || (i == 0 && j == (columnaT - 1)) || (i == (filaT - 1) && j == (columnaT - 1)))
                    {
                        TableCell cell1 = new TableCell();
                        boton[i, j] = new ImageButton();
                        boton[i, j].Width = 40;
                        boton[i, j].Height = 40;
                        boton[i, j].BackColor = Color.SandyBrown;
                        boton[i, j].Enabled = false;
                        boton[i, j].ImageUrl = "fondotransparente.png";
                        cell1.Controls.Add(boton[i, j]);
                        row.Cells.Add(cell1);
                    }
                    if ((i==0 && j!=0 && j!= (columnaT - 1)) || (i!=0 && j==0 && i!= (filaT - 1)) || (i!=0 && j== (columnaT - 1) && i!= (filaT - 1)) || (i == (filaT - 1) && j != 0 && j != (columnaT - 1)))
                    {
                        TableCell cell1 = new TableCell();
                        orilla[i, j] = new Button();
                        orilla[i, j].Width = 40;
                        orilla[i, j].Height = 40;
                        orilla[i, j].BackColor = Color.SandyBrown;
                        orilla[i, j].Enabled = false;
                        if (j == 1)
                        {
                            literal = "A";
                        }
                        if (j == 2)
                        {
                            literal = "B";
                        }
                        if (j == 3)
                        {
                            literal = "C";
                        }
                        if (j == 4)
                        {
                            literal = "D";
                        }
                        if (j == 5)
                        {
                            literal = "E";
                        }
                        if (j == 6)
                        {
                            literal = "F";
                        }
                        if (j == 7)
                        {
                            literal = "G";
                        }
                        if (j == 8)
                        {
                            literal = "H";
                        }
                        if (j == 9)
                        {
                            literal = "I";
                        }
                        if (j == 10)
                        {
                            literal = "J";
                        }
                        if (j == 11)
                        {
                            literal = "K";
                        }
                        if (j == 12)
                        {
                            literal = "L";
                        }
                        if (j == 13)
                        {
                            literal = "M";
                        }
                        if (j == 14)
                        {
                            literal = "N";
                        }
                        if (j == 15)
                        {
                            literal = "O";
                        }
                        if (j == 16)
                        {
                            literal = "P";
                        }
                        if (j == 17)
                        {
                            literal = "Q";

                        }
                        if (j == 18)
                        {
                            literal = "R";
                        }
                        if (j == 19)
                        {
                            literal = "S";
                        }
                        if (j == 20)
                        {
                            literal = "T";
                        }
                        if(i == 0)
                        {
                            orilla[i, j].Text = literal;
                        }
                        if (j == 0)
                        {
                            orilla[i, j].Text = i.ToString();
                        }
                        if (i == (filaT - 1))
                        {
                            orilla[i, j].Text = literal;
                        }
                        if (j == (columnaT - 1))
                        {
                            orilla[i, j].Text = i.ToString();
                        }
                        cell1.Controls.Add(orilla[i, j]);
                        row.Cells.Add(cell1);
                    }
                    if (i != 0 && j != 0 && i < (filaT - 1) && j < (columnaT - 1))
                    {
                        TableCell cell1 = new TableCell();
                        boton[i, j] = new ImageButton();
                        boton[i, j].Width = 40;
                        boton[i, j].Height = 40;
                        boton[i, j].ID = i.ToString()+j.ToString();
                        boton[i, j].BackColor = Color.LightGreen;
                        boton[i, j].ImageUrl = "fondotransparente.png";
                        boton[i, j].Click += this.ButtonGeneral_Click;
                        cell1.Controls.Add(boton[i, j]);
                        row.Cells.Add(cell1);
                    }
                    
                }
                Table1.Rows.Add(row);
            }
            Table1.BackColor = Color.Black;
            
        }

        protected void colorSiguiente()
        {
            if (validacionColor1 == true)
            {
                validacionColor1 = false;
                for (int i = 0; i < PaginaPrincipal.colores1.Length; i++)
                {
                    if (colorGlobal == PaginaPrincipal.colores1[i])
                    {
                        ultimo1 = PaginaPrincipal.colores1[i];
                        for (int j = 0; j < PaginaPrincipal.colores2.Length; j++)
                        {
                            if (ultimo2 == "")
                            {
                                ultimo2 = PaginaPrincipal.colores2[(PaginaPrincipal.colores2.Length - 1)];
                            }
                            if (j == 0)
                            {
                                if (ultimo2 == PaginaPrincipal.colores2[(PaginaPrincipal.colores2.Length - 1)])
                                {
                                    colorGlobal = PaginaPrincipal.colores2[j];
                                    ultimo2 = PaginaPrincipal.colores2[j];
                                    validacionColor2 = true;
                                    Label1.Text = "Jugador 2"+","+colorGlobal;
                                    TimerBlanco.Enabled = false;
                                    TimerNegro.Enabled = true;
                                    return;
                                }
                            }
                            if (j != 0)
                            {
                                if (ultimo2 == PaginaPrincipal.colores2[j - 1])
                                {
                                    colorGlobal = PaginaPrincipal.colores2[j];
                                    ultimo2 = PaginaPrincipal.colores2[j];
                                    validacionColor2 = true;
                                    Label1.Text = "Jugador 2" + "," + colorGlobal;
                                    TimerBlanco.Enabled = false;
                                    TimerNegro.Enabled = true;
                                    return;
                                }
                            }
                        }
                    }
                }
                
            }

            if (validacionColor2 == true)
            {
                validacionColor2 = false;
                for (int i = 0; i < PaginaPrincipal.colores2.Length; i++)
                {
                    if (colorGlobal == PaginaPrincipal.colores2[i])
                    {
                        ultimo2 = PaginaPrincipal.colores2[i];
                        for (int j = 0; j < PaginaPrincipal.colores1.Length; j++)
                        {
                            if (j == 0)
                            {
                                if (ultimo1 == PaginaPrincipal.colores1[(PaginaPrincipal.colores1.Length - 1)])
                                {
                                    colorGlobal = PaginaPrincipal.colores1[j];
                                    ultimo1 = PaginaPrincipal.colores1[j];
                                    validacionColor1 = true;
                                    Label1.Text = "Jugador 1" + "," + colorGlobal;
                                    TimerBlanco.Enabled = true;
                                    TimerNegro.Enabled = false;
                                    return;
                                }
                            }
                            if (j != 0)
                            {
                                if (ultimo1 == PaginaPrincipal.colores1[j - 1])
                                {
                                    colorGlobal = PaginaPrincipal.colores1[j];
                                    ultimo1 = PaginaPrincipal.colores1[j];
                                    validacionColor1 = true;
                                    Label1.Text = "Jugador 1" + "," + colorGlobal;
                                    TimerBlanco.Enabled = true;
                                    TimerNegro.Enabled = false;
                                    return;
                                }
                            }
                        }
                    }
                }
                
            }

            if (validacionColor1 == false && validacionColor2 == false)
            {
                if(PaginaPrincipal.colores1[0] != "")
                {
                    colorGlobal = PaginaPrincipal.colores1[0];
                    ultimo1 = PaginaPrincipal.colores1[0];
                    validacionColor1 = true;
                    Label1.Text = "Jugador 1" + "," + colorGlobal;
                    TimerBlanco.Enabled = true;
                    TimerNegro.Enabled = false;
                }
                
            }
            
        }
            
        protected void ButtonGeneral_Click(object sender, ImageClickEventArgs e)
        {
            filaT = Int32.Parse(PaginaPrincipal.filasT) + 2;
            columnaT = Int32.Parse(PaginaPrincipal.columnasT) + 2;
            ImageButton buscar = (ImageButton)sender;
            string posicionbuscar = "";
            for (int i = 1; i<(filaT-1); i++)
            {
                for (int j = 1; j < (columnaT - 1); j++)
                {
                    posicionbuscar = i.ToString()+j.ToString();
                    if(buscar.ID == posicionbuscar)
                    {
                        if (colorGlobal == "rojo")
                        {
                            buscar.ImageUrl = "rojo.png";
                        }
                        if (colorGlobal == "amarillo")
                        {
                            buscar.ImageUrl = "amarilla.png";
                        }
                        if (colorGlobal == "azul")
                        {
                            buscar.ImageUrl = "azul.png";
                        }
                        if (colorGlobal == "anaranjado")
                        {
                            buscar.ImageUrl = "anaranjado.png";
                        }
                        if (colorGlobal == "verde")
                        {
                            buscar.ImageUrl = "verde.png";
                        }
                        if (colorGlobal == "violeta")
                        {
                            buscar.ImageUrl = "violeta.png";
                        }
                        if (colorGlobal == "blanco")
                        {
                            buscar.ImageUrl = "blanco.png";
                        }
                        if (colorGlobal == "negro")
                        {
                            buscar.ImageUrl = "negro.png";
                        }
                        if (colorGlobal == "celeste")
                        {
                            buscar.ImageUrl = "celeste.png";
                        }
                        if (colorGlobal == "gris")
                        {
                            buscar.ImageUrl = "gris.png";
                        }
                        buscar.Enabled = false;
                    }
                    
                }
            }
            colorSiguiente();
        }

    }
}