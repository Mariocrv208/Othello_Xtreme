using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Xml.Linq;
using System.Xml;

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
        static int filallevar = 0;
        static int columnallevar = 0;
        static int contadorJug1 = 0;
        static int contadorJug2 = 0;
        static int actualfila = 0;
        static int actualcolu = 0;
        static ImageButton buscar;
        ImageButton[,] boton;
        static int filaT = 0;
        static int columnaT = 0;
        public static string idUsuarioCargado = "";
        static int cronometro;
        static int cronometroMinutos;
        static int cronometro2;
        static int cronometroMinutos2;
        static string literal = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PaginaPrincipal.carruta == "")
            {
                Tablero();
            }
            if (PaginaPrincipal.carruta != "")
            {
                CargarArchivo();
                PaginaPrincipal.carruta = "";
            }
            TextBox3.Text = ProyectoEntregable2.Login.UsuarioLogeado;
            TextBox4.Text = PaginaPrincipal.nombre2;
            if (colorGlobal == "")
            {
                colorSiguiente();
            }
            TextBox1.Text = contadorJug1.ToString();
            TextBox2.Text = contadorJug2.ToString();
            
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
            if (PaginaPrincipal.validacionCarga == false)
            {
                filaT = Int32.Parse(PaginaPrincipal.filasT) + 2;
                columnaT = Int32.Parse(PaginaPrincipal.columnasT) + 2;
            }
            filaT = actualfila;
            columnaT = actualcolu;
            if (PaginaPrincipal.validacionCarga == true)
            {
                filaT = actualfila + 2;
                columnaT = actualcolu + 2;
            }
            boton = new ImageButton[filaT, columnaT];
            Button[,] orilla = new Button[filaT, columnaT];
            for (int i = 0; i < filaT; i++)
            {
                TableRow row = new TableRow();
                for (int j = 0; j < columnaT; j++)
                {
                    if ((i == 0 && j == 0) || (i == (filaT - 1) && j == 0) || (i == 0 && j == (columnaT - 1)) || (i == (filaT - 1) && j == (columnaT - 1)))
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
                    if ((i == 0 && j != 0 && j != (columnaT - 1)) || (i != 0 && j == 0 && i != (filaT - 1)) || (i != 0 && j == (columnaT - 1) && i != (filaT - 1)) || (i == (filaT - 1) && j != 0 && j != (columnaT - 1)))
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
                        if (i == 0)
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
                        boton[i, j].ID = i.ToString() + j.ToString();
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
                                    Label1.Text = "Jugador 2" + "," + colorGlobal;
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
                if (PaginaPrincipal.colores1[0] != "")
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
            if (PaginaPrincipal.validacionCarga == false)
            {
                filaT = Int32.Parse(PaginaPrincipal.filasT) + 2;
                columnaT = Int32.Parse(PaginaPrincipal.columnasT) + 2;
            }
            filaT = actualfila;
            columnaT = actualcolu;
            if (PaginaPrincipal.validacionCarga == true)
            {
                filaT = actualfila + 2;
                columnaT = actualcolu + 2;
            }
            buscar = (ImageButton)sender;
            string posicionbuscar = "";
            string parsearID = buscar.ID;
            string separarfila = parsearID[0].ToString();
            string separarcolumna = parsearID[1].ToString();
            filallevar = Int32.Parse(separarfila);
            columnallevar = Int32.Parse(separarcolumna);
            for (int i = 1; i < (filaT - 1); i++)
            {
                for (int j = 1; j < (columnaT - 1); j++)
                {
                    posicionbuscar = i.ToString() + j.ToString();
                    if (buscar.ID == posicionbuscar)
                    {
                        if (colorGlobal == "rojo")
                        {
                            buscar.ImageUrl = "rojo.png";
                        }
                        if (colorGlobal == "amarillo")
                        {
                            buscar.ImageUrl = "amarillo.png";
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
            voltearFicha();
            contadores();
            colorSiguiente();
        }

        protected void voltearFicha()
        {
            if (PaginaPrincipal.validacionCarga == false)
            {
                filaT = Int32.Parse(PaginaPrincipal.filasT) + 2;
                columnaT = Int32.Parse(PaginaPrincipal.columnasT) + 2;
            }
            filaT = actualfila;
            columnaT = actualcolu;
            if (PaginaPrincipal.validacionCarga == true)
            {
                filaT = actualfila + 2;
                columnaT = actualcolu + 2;
            }
            int columnabuscar = 0;
            int filabuscar = 0;
            columnabuscar = columnallevar;
            filabuscar = filallevar;
            int filaLimiteder = 0;
            int columnaLimiteder = 0;
            int filaLimiteiz = 0;
            int columnaLimiteiz = 0;
            int filaLimitearr = 0;
            int columnaLimitearr = 0;
            int filaLimiteaba = 0;
            int columnaLimiteaba = 0;
            int filaLimitederarr = 0;
            int columnaLimitederarr = 0;
            int filaLimitederaba = 0;
            int columnaLimitederaba = 0;
            int filaLimiteizarr = 0;
            int columnaLimiteizarr = 0;
            int filaLimiteizaba = 0;
            int columnaLimiteiziaba = 0;
            bool der = false;
            bool iz = false;
            bool arr = false;
            bool aba = false;
            bool derarr = false;
            bool deraba = false;
            bool izarr = false;
            bool izaba = false;
            bool validacion1 = false;
            bool validacion2 = false;
            bool validacion3 = false;
            bool colorjug1 = false;
            bool colorjug2 = false;
            bool validacioncambiar = false;
            for (int i = 0; i < PaginaPrincipal.colores1.Length; i++)
            {
                if (colorGlobal == PaginaPrincipal.colores1[i])
                {
                    colorjug1 = true;
                }
            }
            for (int i = 0; i < PaginaPrincipal.colores2.Length; i++)
            {
                if (colorGlobal == PaginaPrincipal.colores2[i])
                {
                    colorjug2 = true;
                }
            }

            if (colorjug1 == true)
            {
                /*Derecha*/
                columnabuscar = columnallevar + 1;
                filabuscar = filallevar;
                while (columnabuscar < (columnaT - 1))
                {
                    for (int i = 0; i < PaginaPrincipal.colores2.Length; i++)
                    {
                        if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[i] + ".png"))
                        {
                            while (columnabuscar < (columnaT - 1))
                            {
                                for (int j = 0; j < PaginaPrincipal.colores1.Length; j++)
                                {
                                    if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores1[j] + ".png"))
                                    {
                                        filaLimiteder = filabuscar;
                                        columnaLimiteder = columnabuscar;
                                        der = true;
                                        validacioncambiar = true;
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                    if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                                    {
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                }
                                if (validacion1 == true)
                                {
                                    break;
                                }
                                columnabuscar = columnabuscar + 1;
                            }
                            if (validacion2 == true)
                            {
                                break;
                            }
                        }
                    }
                    if (validacion3 == true)
                    {
                        break;
                    }
                    columnabuscar = columnabuscar + 1;
                }
                /*izquierda*/
                validacion1 = false;
                validacion2 = false;
                validacion3 = false;
                columnabuscar = columnallevar - 1;
                filabuscar = filallevar;
                while (columnabuscar > 0)
                {
                    for (int i = 0; i < PaginaPrincipal.colores2.Length; i++)
                    {
                        if (columnabuscar == 0)
                        {
                            break;
                        }
                        if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[i] + ".png"))
                        {
                            while (columnabuscar > 0)
                            {
                                for (int j = 0; j < PaginaPrincipal.colores1.Length; j++)
                                {
                                    if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores1[j] + ".png"))
                                    {
                                        filaLimiteiz = filabuscar;
                                        columnaLimiteiz = columnabuscar;
                                        iz = true;
                                        validacioncambiar = true;
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                    if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                                    {
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                }
                                if (validacion1 == true)
                                {
                                    break;
                                }
                                columnabuscar = columnabuscar - 1;
                            }
                            if (validacion2 == true)
                            {
                                break;
                            }
                        }
                    }
                    if (columnabuscar == 0)
                    {
                        break;
                    }
                    if (validacion3 == true)
                    {
                        break;
                    }
                    columnabuscar = columnabuscar - 1;
                }
                /*arriba*/
                validacion1 = false;
                validacion2 = false;
                validacion3 = false;
                columnabuscar = columnallevar;
                filabuscar = filallevar - 1;
                while (filabuscar > 0)
                {
                    for (int i = 0; i < PaginaPrincipal.colores2.Length; i++)
                    {
                        if (filabuscar == 0)
                        {
                            break;
                        }
                        if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[i] + ".png"))
                        {
                            while (filabuscar > 0)
                            {
                                for (int j = 0; j < PaginaPrincipal.colores1.Length; j++)
                                {
                                    if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores1[j] + ".png"))
                                    {
                                        filaLimitearr = filabuscar;
                                        columnaLimitearr = columnabuscar;
                                        arr = true;
                                        validacioncambiar = true;
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                    if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                                    {
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                }
                                if (validacion1 == true)
                                {
                                    break;
                                }
                                filabuscar = filabuscar - 1;
                            }
                            if (validacion2 == true)
                            {
                                break;
                            }
                        }
                    }
                    if (filabuscar == 0)
                    {
                        break;
                    }
                    if (validacion3 == true)
                    {
                        break;
                    }
                    filabuscar = filabuscar - 1;
                }
                /*arriba*/
                validacion1 = false;
                validacion2 = false;
                validacion3 = false;
                columnabuscar = columnallevar;
                filabuscar = filallevar + 1;
                while (filabuscar < (filaT - 1))
                {
                    for (int i = 0; i < PaginaPrincipal.colores2.Length; i++)
                    {
                        if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[i] + ".png"))
                        {
                            while (filabuscar < (filaT - 1))
                            {
                                for (int j = 0; j < PaginaPrincipal.colores1.Length; j++)
                                {
                                    if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores1[j] + ".png"))
                                    {
                                        filaLimiteaba = filabuscar;
                                        columnaLimiteaba = columnabuscar;
                                        aba = true;
                                        validacioncambiar = true;
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                    if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                                    {
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                }
                                if (validacion1 == true)
                                {
                                    break;
                                }
                                filabuscar = filabuscar + 1;
                            }
                            if (validacion2 == true)
                            {
                                break;
                            }
                        }
                    }
                    if (validacion3 == true)
                    {
                        break;
                    }
                    filabuscar = filabuscar + 1;
                }
                /*derechaArriba*/
                validacion1 = false;
                validacion2 = false;
                validacion3 = false;
                columnabuscar = columnallevar + 1;
                filabuscar = filallevar - 1;
                while ((filabuscar > 0) && (columnabuscar < (columnaT - 1)))
                {
                    for (int i = 0; i < PaginaPrincipal.colores2.Length; i++)
                    {
                        if (filabuscar == 0)
                        {
                            break;
                        }
                        if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[i] + ".png"))
                        {
                            while ((filabuscar > 0) && (columnabuscar < (columnaT - 1)))
                            {
                                for (int j = 0; j < PaginaPrincipal.colores1.Length; j++)
                                {
                                    if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores1[j] + ".png"))
                                    {
                                        filaLimitederarr = filabuscar;
                                        columnaLimitederarr = columnabuscar;
                                        derarr = true;
                                        validacioncambiar = true;
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                    if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                                    {
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                }
                                if (validacion1 == true)
                                {
                                    break;
                                }
                                columnabuscar = columnabuscar + 1;
                                filabuscar = filabuscar - 1;
                            }
                            if (validacion2 == true)
                            {
                                break;
                            }
                        }
                    }
                    if (filabuscar == 0)
                    {
                        break;
                    }
                    if (validacion3 == true)
                    {
                        break;
                    }
                    columnabuscar = columnabuscar + 1;
                    filabuscar = filabuscar - 1;
                }
                /*izquierdaArriba*/
                validacion1 = false;
                validacion2 = false;
                validacion3 = false;
                columnabuscar = columnallevar - 1;
                filabuscar = filallevar - 1;
                while ((filabuscar > 0) && (columnabuscar > 0))
                {
                    for (int i = 0; i < PaginaPrincipal.colores2.Length; i++)
                    {
                        if (filabuscar == 0 || columnabuscar == 0)
                        {
                            break;
                        }
                        if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[i] + ".png"))
                        {
                            while ((filabuscar > 0) && (columnabuscar > 0))
                            {
                                for (int j = 0; j < PaginaPrincipal.colores1.Length; j++)
                                {
                                    if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores1[j] + ".png"))
                                    {
                                        filaLimiteizarr = filabuscar;
                                        columnaLimiteizarr = columnabuscar;
                                        izarr = true;
                                        validacioncambiar = true;
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                    if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                                    {
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                }
                                if (validacion1 == true)
                                {
                                    break;
                                }
                                columnabuscar = columnabuscar - 1;
                                filabuscar = filabuscar - 1;
                            }
                            if (validacion2 == true)
                            {
                                break;
                            }
                        }
                    }
                    if (filabuscar == 0 || columnabuscar == 0)
                    {
                        break;
                    }
                    if (validacion3 == true)
                    {
                        break;
                    }
                    columnabuscar = columnabuscar - 1;
                    filabuscar = filabuscar - 1;
                }
                /*izquierdaAbajo*/
                validacion1 = false;
                validacion2 = false;
                validacion3 = false;
                columnabuscar = columnallevar - 1;
                filabuscar = filallevar + 1;
                while ((filabuscar < (filaT - 1)) && (columnabuscar > 0))
                {
                    for (int i = 0; i < PaginaPrincipal.colores2.Length; i++)
                    {
                        if (columnabuscar == 0)
                        {
                            break;
                        }
                        if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[i] + ".png"))
                        {
                            while ((filabuscar < (filaT - 1)) && (columnabuscar > 0))
                            {
                                for (int j = 0; j < PaginaPrincipal.colores1.Length; j++)
                                {
                                    if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores1[j] + ".png"))
                                    {
                                        filaLimiteizaba = filabuscar;
                                        columnaLimiteiziaba = columnabuscar;
                                        izaba = true;
                                        validacioncambiar = true;
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                    if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                                    {
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                }
                                if (validacion1 == true)
                                {
                                    break;
                                }
                                columnabuscar = columnabuscar - 1;
                                filabuscar = filabuscar + 1;
                            }
                            if (validacion2 == true)
                            {
                                break;
                            }
                        }

                    }
                    if (columnabuscar == 0)
                    {
                        break;
                    }
                    if (validacion3 == true)
                    {
                        break;
                    }
                    columnabuscar = columnabuscar - 1;
                    filabuscar = filabuscar + 1;
                }
                /*derechaAbajo*/
                validacion1 = false;
                validacion2 = false;
                validacion3 = false;
                columnabuscar = columnallevar + 1;
                filabuscar = filallevar + 1;
                while ((filabuscar < (filaT - 1)) && (columnabuscar < (columnaT - 1)))
                {
                    for (int i = 0; i < PaginaPrincipal.colores2.Length; i++)
                    {
                        if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[i] + ".png"))
                        {
                            while ((filabuscar < (filaT - 1)) && (columnabuscar < (columnaT - 1)))
                            {
                                for (int j = 0; j < PaginaPrincipal.colores1.Length; j++)
                                {
                                    if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores1[j] + ".png"))
                                    {
                                        filaLimitederaba = filabuscar;
                                        columnaLimitederaba = columnabuscar;
                                        deraba = true;
                                        validacioncambiar = true;
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                    if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                                    {
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                }
                                if (validacion1 == true)
                                {
                                    break;
                                }
                                columnabuscar = columnabuscar + 1;
                                filabuscar = filabuscar + 1;
                            }
                            if (validacion2 == true)
                            {
                                break;
                            }
                        }
                    }
                    if (validacion3 == true)
                    {
                        break;
                    }
                    columnabuscar = columnabuscar + 1;
                    filabuscar = filabuscar + 1;
                }
            }
            if (colorjug2 == true)
            {
                /*derecha*/
                columnabuscar = columnallevar + 1;
                filabuscar = filallevar;
                while (columnabuscar < (columnaT - 1))
                {
                    for (int i = 0; i < PaginaPrincipal.colores1.Length; i++)
                    {
                        if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores1[i] + ".png"))
                        {
                            while (columnabuscar < (columnaT - 1))
                            {
                                for (int j = 0; j < PaginaPrincipal.colores2.Length; j++)
                                {
                                    if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[j] + ".png"))
                                    {
                                        filaLimiteder = filabuscar;
                                        columnaLimiteder = columnabuscar;
                                        der = true;
                                        validacioncambiar = true;
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                    if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                                    {
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                }
                                if (validacion1 == true)
                                {
                                    break;
                                }
                                columnabuscar = columnabuscar + 1;
                            }
                            if (validacion2 == true)
                            {
                                break;
                            }
                        }
                    }
                    if (validacion3 == true)
                    {
                        break;
                    }
                    columnabuscar = columnabuscar + 1;
                }
                /*izquierda*/
                validacion1 = false;
                validacion2 = false;
                validacion3 = false;
                columnabuscar = columnallevar - 1;
                filabuscar = filallevar;
                while (columnabuscar > 0)
                {
                    for (int i = 0; i < PaginaPrincipal.colores1.Length; i++)
                    {
                        if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores1[i] + ".png"))
                        {
                            while (columnabuscar > 0)
                            {
                                for (int j = 0; j < PaginaPrincipal.colores2.Length; j++)
                                {
                                    if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[j] + ".png"))
                                    {
                                        filaLimiteiz = filabuscar;
                                        columnaLimiteiz = columnabuscar;
                                        iz = true;
                                        validacioncambiar = true;
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                    if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                                    {
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                }
                                if (validacion1 == true)
                                {
                                    break;
                                }
                                columnabuscar = columnabuscar - 1;
                            }
                            if (validacion2 == true)
                            {
                                break;
                            }
                        }
                    }
                    if (validacion3 == true)
                    {
                        break;
                    }
                    columnabuscar = columnabuscar - 1;
                }
                /*arriba*/
                validacion1 = false;
                validacion2 = false;
                validacion3 = false;
                columnabuscar = columnallevar;
                filabuscar = filallevar - 1;
                while (filabuscar > 0)
                {
                    for (int i = 0; i < PaginaPrincipal.colores1.Length; i++)
                    {
                        if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores1[i] + ".png"))
                        {
                            while (filabuscar > 0)
                            {
                                for (int j = 0; j < PaginaPrincipal.colores2.Length; j++)
                                {
                                    if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[j] + ".png"))
                                    {
                                        filaLimitearr = filabuscar;
                                        columnaLimitearr = columnabuscar;
                                        arr = true;
                                        validacioncambiar = true;
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                    if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                                    {
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                }
                                if (validacion1 == true)
                                {
                                    break;
                                }
                                filabuscar = filabuscar - 1;
                            }
                            if (validacion2 == true)
                            {
                                break;
                            }
                        }
                    }
                    if (validacion3 == true)
                    {
                        break;
                    }
                    filabuscar = filabuscar - 1;
                }
                /*abajo*/
                validacion1 = false;
                validacion2 = false;
                validacion3 = false;
                columnabuscar = columnallevar;
                filabuscar = filallevar + 1;
                while (filabuscar < (filaT - 1))
                {
                    for (int i = 0; i < PaginaPrincipal.colores1.Length; i++)
                    {
                        if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores1[i] + ".png"))
                        {
                            while (filabuscar < (filaT - 1))
                            {
                                for (int j = 0; j < PaginaPrincipal.colores2.Length; j++)
                                {
                                    if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[j] + ".png"))
                                    {
                                        filaLimiteaba = filabuscar;
                                        columnaLimiteaba = columnabuscar;
                                        aba = true;
                                        validacioncambiar = true;
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                    if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                                    {
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                }
                                if (validacion1 == true)
                                {
                                    break;
                                }
                                filabuscar = filabuscar + 1;
                            }
                            if (validacion2 == true)
                            {
                                break;
                            }
                        }
                    }
                    if (validacion3 == true)
                    {
                        break;
                    }
                    filabuscar = filabuscar + 1;
                }
                /*derechaArriba*/
                validacion1 = false;
                validacion2 = false;
                validacion3 = false;
                columnabuscar = columnallevar + 1;
                filabuscar = filallevar - 1;
                while ((filabuscar > 0) && (columnabuscar < (columnaT - 1)))
                {
                    for (int i = 0; i < PaginaPrincipal.colores1.Length; i++)
                    {
                        if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores1[i] + ".png"))
                        {
                            while ((filabuscar > 0) && (columnabuscar < (columnaT - 1)))
                            {
                                for (int j = 0; j < PaginaPrincipal.colores2.Length; j++)
                                {
                                    if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[j] + ".png"))
                                    {
                                        filaLimitederarr = filabuscar;
                                        columnaLimitederarr = columnabuscar;
                                        derarr = true;
                                        validacioncambiar = true;
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                    if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                                    {
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                }
                                columnabuscar = columnabuscar + 1;
                                filabuscar = filabuscar - 1;
                                if (validacion1 == true)
                                {
                                    break;
                                }
                            }
                            if (validacion2 == true)
                            {
                                break;
                            }
                        }
                    }
                    columnabuscar = columnabuscar + 1;
                    filabuscar = filabuscar - 1;
                    if (validacion3 == true)
                    {
                        break;
                    }
                }
                /*izquierdaArriba*/
                validacion1 = false;
                validacion2 = false;
                validacion3 = false;
                columnabuscar = columnallevar - 1;
                filabuscar = filallevar - 1;
                while ((filabuscar > 0) && (columnabuscar > 0))
                {
                    for (int i = 0; i < PaginaPrincipal.colores1.Length; i++)
                    {
                        if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores1[i] + ".png"))
                        {
                            while ((filabuscar > 0) && (columnabuscar > 0))
                            {
                                for (int j = 0; j < PaginaPrincipal.colores2.Length; j++)
                                {
                                    if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[j] + ".png"))
                                    {
                                        filaLimiteizarr = filabuscar;
                                        columnaLimiteizarr = columnabuscar;
                                        izarr = true;
                                        validacioncambiar = true;
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                    if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                                    {
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                }
                                if (validacion1 == true)
                                {
                                    break;
                                }
                                columnabuscar = columnabuscar - 1;
                                filabuscar = filabuscar - 1;
                            }
                            if (validacion2 == true)
                            {
                                break;
                            }
                        }
                    }
                    if (validacion3 == true)
                    {
                        break;
                    }
                    columnabuscar = columnabuscar - 1;
                    filabuscar = filabuscar - 1;
                }
                /*izquierdaAbajo*/
                validacion1 = false;
                validacion2 = false;
                validacion3 = false;
                columnabuscar = columnallevar - 1;
                filabuscar = filallevar + 1;
                while ((filabuscar < (filaT - 1)) && (columnabuscar > 0))
                {
                    for (int i = 0; i < PaginaPrincipal.colores1.Length; i++)
                    {
                        if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores1[i] + ".png"))
                        {
                            while ((filabuscar < (filaT - 1)) && (columnabuscar > 0))
                            {
                                for (int j = 0; j < PaginaPrincipal.colores2.Length; j++)
                                {
                                    if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[j] + ".png"))
                                    {
                                        filaLimiteizaba = filabuscar;
                                        columnaLimiteiziaba = columnabuscar;
                                        izaba = true;
                                        validacioncambiar = true;
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                    if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                                    {
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                }
                                if (validacion1 == true)
                                {
                                    break;
                                }
                                columnabuscar = columnabuscar - 1;
                                filabuscar = filabuscar + 1;
                            }
                            if (validacion2 == true)
                            {
                                break;
                            }
                        }
                    }
                    if (validacion3 == true)
                    {
                        break;
                    }
                    columnabuscar = columnabuscar - 1;
                    filabuscar = filabuscar + 1;
                }
                /*derechaAbajo*/
                validacion1 = false;
                validacion2 = false;
                validacion3 = false;
                columnabuscar = columnallevar + 1;
                filabuscar = filallevar + 1;
                while ((filabuscar < (filaT - 1)) && (columnabuscar < (columnaT - 1)))
                {
                    for (int i = 0; i < PaginaPrincipal.colores1.Length; i++)
                    {
                        if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores1[i] + ".png"))
                        {
                            while ((filabuscar < (filaT - 1)) && (columnabuscar < (columnaT - 1)))
                            {
                                for (int j = 0; j < PaginaPrincipal.colores2.Length; j++)
                                {
                                    if (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[j] + ".png"))
                                    {
                                        filaLimitederaba = filabuscar;
                                        columnaLimitederaba = columnabuscar;
                                        deraba = true;
                                        validacioncambiar = true;
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                    if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                                    {
                                        validacion3 = true;
                                        validacion2 = true;
                                        validacion1 = true;
                                        break;
                                    }
                                }
                                if (validacion1 == true)
                                {
                                    break;
                                }
                                columnabuscar = columnabuscar + 1;
                                filabuscar = filabuscar + 1;
                            }
                            if (validacion2 == true)
                            {
                                break;
                            }
                        }
                    }
                    if (validacion3 == true)
                    {
                        break;
                    }
                    columnabuscar = columnabuscar + 1;
                    filabuscar = filabuscar + 1;
                }
            }
            if (validacioncambiar == true)
            {
                if (der == true)
                {
                    /*derecha*/
                    columnabuscar = columnallevar + 1;
                    filabuscar = filallevar;
                    while (columnabuscar < columnaLimiteder)
                    {
                        if (colorGlobal == "rojo")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "rojo.png";
                        }
                        if (colorGlobal == "amarillo")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "amarillo.png";
                        }
                        if (colorGlobal == "azul")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "azul.png";
                        }
                        if (colorGlobal == "anaranjado")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "anaranjado.png";
                        }
                        if (colorGlobal == "verde")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "verde.png";
                        }
                        if (colorGlobal == "violeta")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "violeta.png";
                        }
                        if (colorGlobal == "blanco")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "blanco.png";
                        }
                        if (colorGlobal == "negro")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "negro.png";
                        }
                        if (colorGlobal == "celeste")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "celeste.png";
                        }
                        if (colorGlobal == "gris")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "gris.png";
                        }
                        boton[filabuscar, columnabuscar].Enabled = false;
                        columnabuscar = columnabuscar + 1;
                    }
                }
                if (iz == true)
                {
                    /*izquierda*/
                    columnabuscar = columnallevar - 1;
                    filabuscar = filallevar;
                    while (columnabuscar > columnaLimiteiz)
                    {
                        if (colorGlobal == "rojo")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "rojo.png";
                        }
                        if (colorGlobal == "amarillo")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "amarillo.png";
                        }
                        if (colorGlobal == "azul")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "azul.png";
                        }
                        if (colorGlobal == "anaranjado")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "anaranjado.png";
                        }
                        if (colorGlobal == "verde")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "verde.png";
                        }
                        if (colorGlobal == "violeta")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "violeta.png";
                        }
                        if (colorGlobal == "blanco")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "blanco.png";
                        }
                        if (colorGlobal == "negro")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "negro.png";
                        }
                        if (colorGlobal == "celeste")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "celeste.png";
                        }
                        if (colorGlobal == "gris")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "gris.png";
                        }
                        boton[filabuscar, columnabuscar].Enabled = false;
                        columnabuscar = columnabuscar - 1;
                    }
                }
                if (arr == true)
                {
                    /*arriba*/
                    columnabuscar = columnallevar;
                    filabuscar = filallevar - 1;
                    while (filabuscar > filaLimitearr)
                    {
                        if (colorGlobal == "rojo")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "rojo.png";
                        }
                        if (colorGlobal == "amarillo")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "amarillo.png";
                        }
                        if (colorGlobal == "azul")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "azul.png";
                        }
                        if (colorGlobal == "anaranjado")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "anaranjado.png";
                        }
                        if (colorGlobal == "verde")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "verde.png";
                        }
                        if (colorGlobal == "violeta")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "violeta.png";
                        }
                        if (colorGlobal == "blanco")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "blanco.png";
                        }
                        if (colorGlobal == "negro")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "negro.png";
                        }
                        if (colorGlobal == "celeste")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "celeste.png";
                        }
                        if (colorGlobal == "gris")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "gris.png";
                        }
                        boton[filabuscar, columnabuscar].Enabled = false;
                        filabuscar = filabuscar - 1;
                    }
                }
                if (aba == true)
                {
                    /*abajo*/
                    columnabuscar = columnallevar;
                    filabuscar = filallevar + 1;
                    while (filabuscar < filaLimiteaba)
                    {
                        if (colorGlobal == "rojo")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "rojo.png";
                        }
                        if (colorGlobal == "amarillo")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "amarillo.png";
                        }
                        if (colorGlobal == "azul")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "azul.png";
                        }
                        if (colorGlobal == "anaranjado")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "anaranjado.png";
                        }
                        if (colorGlobal == "verde")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "verde.png";
                        }
                        if (colorGlobal == "violeta")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "violeta.png";
                        }
                        if (colorGlobal == "blanco")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "blanco.png";
                        }
                        if (colorGlobal == "negro")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "negro.png";
                        }
                        if (colorGlobal == "celeste")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "celeste.png";
                        }
                        if (colorGlobal == "gris")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "gris.png";
                        }
                        boton[filabuscar, columnabuscar].Enabled = false;
                        filabuscar = filabuscar + 1;
                    }
                }
                if (derarr == true)
                {
                    /*arribaDerecha*/
                    filabuscar = filallevar - 1;
                    columnabuscar = columnallevar + 1;
                    while ((filabuscar > filaLimitederarr) && (columnabuscar < columnaLimitederarr))
                    {
                        if (colorGlobal == "rojo")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "rojo.png";
                        }
                        if (colorGlobal == "amarillo")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "amarillo.png";
                        }
                        if (colorGlobal == "azul")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "azul.png";
                        }
                        if (colorGlobal == "anaranjado")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "anaranjado.png";
                        }
                        if (colorGlobal == "verde")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "verde.png";
                        }
                        if (colorGlobal == "violeta")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "violeta.png";
                        }
                        if (colorGlobal == "blanco")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "blanco.png";
                        }
                        if (colorGlobal == "negro")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "negro.png";
                        }
                        if (colorGlobal == "celeste")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "celeste.png";
                        }
                        if (colorGlobal == "gris")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "gris.png";
                        }
                        boton[filabuscar, columnabuscar].Enabled = false;
                        filabuscar = filabuscar - 1;
                        columnabuscar = columnabuscar + 1;
                    }
                }
                if (izarr == true)
                {
                    /*arribaIzquierda*/
                    filabuscar = filallevar - 1;
                    columnabuscar = columnallevar - 1;
                    while ((filabuscar > filaLimiteizarr) && (columnabuscar > columnaLimiteizarr))
                    {
                        if (colorGlobal == "rojo")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "rojo.png";
                        }
                        if (colorGlobal == "amarillo")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "amarillo.png";
                        }
                        if (colorGlobal == "azul")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "azul.png";
                        }
                        if (colorGlobal == "anaranjado")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "anaranjado.png";
                        }
                        if (colorGlobal == "verde")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "verde.png";
                        }
                        if (colorGlobal == "violeta")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "violeta.png";
                        }
                        if (colorGlobal == "blanco")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "blanco.png";
                        }
                        if (colorGlobal == "negro")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "negro.png";
                        }
                        if (colorGlobal == "celeste")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "celeste.png";
                        }
                        if (colorGlobal == "gris")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "gris.png";
                        }
                        boton[filabuscar, columnabuscar].Enabled = false;
                        filabuscar = filabuscar - 1;
                        columnabuscar = columnabuscar - 1;
                    }
                }
                if (izaba == true)
                {
                    /*abajoIzquierda*/
                    filabuscar = filallevar + 1;
                    columnabuscar = columnallevar - 1;
                    while ((filabuscar < filaLimiteizaba) && (columnabuscar > columnaLimiteiziaba))
                    {
                        if (colorGlobal == "rojo")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "rojo.png";
                        }
                        if (colorGlobal == "amarillo")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "amarillo.png";
                        }
                        if (colorGlobal == "azul")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "azul.png";
                        }
                        if (colorGlobal == "anaranjado")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "anaranjado.png";
                        }
                        if (colorGlobal == "verde")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "verde.png";
                        }
                        if (colorGlobal == "violeta")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "violeta.png";
                        }
                        if (colorGlobal == "blanco")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "blanco.png";
                        }
                        if (colorGlobal == "negro")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "negro.png";
                        }
                        if (colorGlobal == "celeste")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "celeste.png";
                        }
                        if (colorGlobal == "gris")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "gris.png";
                        }
                        boton[filabuscar, columnabuscar].Enabled = false;
                        filabuscar = filabuscar + 1;
                        columnabuscar = columnabuscar - 1;
                    }
                }
                if (deraba == true)
                {
                    /*abajoDerecha*/
                    filabuscar = filallevar + 1;
                    columnabuscar = columnallevar + 1;
                    while ((filabuscar < filaLimitederaba) && (columnabuscar < columnaLimitederaba))
                    {
                        if (colorGlobal == "rojo")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "rojo.png";
                        }
                        if (colorGlobal == "amarillo")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "amarillo.png";
                        }
                        if (colorGlobal == "azul")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "azul.png";
                        }
                        if (colorGlobal == "anaranjado")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "anaranjado.png";
                        }
                        if (colorGlobal == "verde")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "verde.png";
                        }
                        if (colorGlobal == "violeta")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "violeta.png";
                        }
                        if (colorGlobal == "blanco")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "blanco.png";
                        }
                        if (colorGlobal == "negro")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "negro.png";
                        }
                        if (colorGlobal == "celeste")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "celeste.png";
                        }
                        if (colorGlobal == "gris")
                        {
                            boton[filabuscar, columnabuscar].ImageUrl = "gris.png";
                        }
                        boton[filabuscar, columnabuscar].Enabled = false;
                        filabuscar = filabuscar + 1;
                        columnabuscar = columnabuscar + 1;
                    }
                }
            }
        }

        protected void contadores()
        {
            if (PaginaPrincipal.validacionCarga == false)
            {
                filaT = Int32.Parse(PaginaPrincipal.filasT) + 2;
                columnaT = Int32.Parse(PaginaPrincipal.columnasT) + 2;
            }
            filaT = actualfila;
            columnaT = actualcolu;
            if (PaginaPrincipal.validacionCarga == true)
            {
                filaT = actualfila + 2;
                columnaT = actualcolu + 2;
            }
            for (int i = 1; i < (filaT - 1); i++)
            {
                for (int j = 1; j < (columnaT - 1); j++)
                {
                    for (int k = 0; k < PaginaPrincipal.colores1.Length; k++)
                    {
                        if (boton[i, j].ImageUrl == (PaginaPrincipal.colores1[k] + ".png"))
                        {
                            contadorJug1 = contadorJug1 + 1;
                        }
                    }
                    for (int k = 0; k < PaginaPrincipal.colores2.Length; k++)
                    {
                        if (boton[i, j].ImageUrl == (PaginaPrincipal.colores2[k] + ".png"))
                        {
                            contadorJug2 = contadorJug2 + 1;
                        }
                    }
                }
            }
        }

        protected void CargarArchivo()
        {
            string rutaAbrir = "C:\\Users\\mario\\OneDrive\\Documentos\\GitHub\\Proyecto1\\ProyectoEntregable2\\XMLArchivos\\" + PaginaPrincipal.carruta +".xml";
            if (PaginaPrincipal.carruta != "")
            {
                XmlDocument leer = new XmlDocument();
                leer.Load(rutaAbrir);
                foreach (XmlNode xmlNode in leer.DocumentElement.ChildNodes[0].ParentNode)
                {
                    if (xmlNode.Name.Equals("filas"))
                    {
                        actualfila = Int32.Parse(xmlNode.ChildNodes[0].InnerText);
                    }
                    if (xmlNode.Name.Equals("columnas"))
                    {
                        actualcolu = Int32.Parse(xmlNode.ChildNodes[0].InnerText);
                    }
                    if (xmlNode.Name.Equals("Jugador1"))
                    {
                        string elementomandar = "";
                        foreach (XmlNode xmlNodeItem in xmlNode.ChildNodes)
                        {
                            if (xmlNodeItem.Name == "color")
                            {
                                elementomandar = xmlNodeItem.InnerText;
                                PaginaPrincipal.Colores1.Add(elementomandar);
                            }
                        }
                        PaginaPrincipal.colores1 = PaginaPrincipal.Colores1.ToArray();
                    }
                    if (xmlNode.Name.Equals("Jugador2"))
                    {
                        
                        string elementomandar = "";
                        foreach (XmlNode xmlNodeItem in xmlNode.ChildNodes)
                        {
                            if (xmlNodeItem.Name == "color")
                            {
                                elementomandar = xmlNodeItem.InnerText;
                                PaginaPrincipal.Colores2.Add(elementomandar);
                            }
                        }
                        PaginaPrincipal.colores2 = PaginaPrincipal.Colores2.ToArray();
                    }
                    if (xmlNode.Name.Equals("Modalidad"))
                    {
                        if (xmlNode.InnerText == "Normal")
                        {
                            PaginaPrincipal.ModalidadInversa = false;
                        }
                        if (xmlNode.InnerText == "Inversa")
                        {
                            PaginaPrincipal.ModalidadInversa = true;
                        }
                    }
                    if (xmlNode.Name.Equals("tablero"))
                    {
                        Tablero();
                        int colman = 0;
                        int filman = 0;
                        string colormandar = "";
                        string columnamandar = "";
                        string filamandar = "";
                        foreach (XmlNode xmlNodeItem in xmlNode.ChildNodes)
                        {
                            if (xmlNodeItem.Name == "ficha")
                            {
                                colormandar = xmlNodeItem.ChildNodes[0].InnerText + ".png";
                                columnamandar = xmlNodeItem.ChildNodes[1].InnerText;
                                filamandar = xmlNodeItem.ChildNodes[2].InnerText;
                                if(columnamandar == "A")
                                {
                                    colman = 1;
                                }
                                if (columnamandar == "B")
                                {
                                    colman = 2;
                                }
                                if (columnamandar == "C")
                                {
                                    colman = 3;
                                }
                                if (columnamandar == "D")
                                {
                                    colman = 4;
                                }
                                if (columnamandar == "E")
                                {
                                    colman = 5;
                                }
                                if (columnamandar == "F")
                                {
                                    colman = 6;
                                }
                                if (columnamandar == "G")
                                {
                                    colman = 7;
                                }
                                if (columnamandar == "H")
                                {
                                    colman = 8;
                                }
                                if (columnamandar == "I")
                                {
                                    colman = 9;
                                }
                                if (columnamandar == "J")
                                {
                                    colman = 10;
                                }
                                if (columnamandar == "K")
                                {
                                    colman = 11;
                                }
                                if (columnamandar == "L")
                                {
                                    colman = 12;
                                }
                                if (columnamandar == "M")
                                {
                                    colman = 13;
                                }
                                if (columnamandar == "N")
                                {
                                    colman = 14;
                                }
                                if (columnamandar == "O")
                                {
                                    colman = 15;
                                }
                                if (columnamandar == "P")
                                {
                                    colman = 16;
                                }
                                if (columnamandar == "Q")
                                {
                                    colman = 17;
                                }
                                if (columnamandar == "R")
                                {
                                    colman = 18;
                                }
                                if (columnamandar == "S")
                                {
                                    colman = 19;
                                }
                                if (columnamandar == "T")
                                {
                                    colman = 20;
                                }
                                filman = Int32.Parse(filamandar);
                                string guardarId = boton[filman, colman].ID;
                                boton[filman, colman].ImageUrl = colormandar;
                            }
                            if (xmlNodeItem.Name == "siguienteTiro")
                            {
                                colorGlobal = xmlNodeItem.FirstChild.InnerText;
                                for (int k = 0; k < PaginaPrincipal.colores1.Length; k++)
                                {
                                    if (colorGlobal == PaginaPrincipal.colores1[k])
                                    {
                                        TimerBlanco.Enabled = true;
                                        TimerNegro.Enabled = false;
                                    }
                                }
                                for (int k = 0; k < PaginaPrincipal.colores2.Length; k++)
                                {
                                    if (colorGlobal == PaginaPrincipal.colores2[k])
                                    {
                                        TimerBlanco.Enabled = false;
                                        TimerNegro.Enabled = true;
                                    }
                                }
                            }
                        }
                    }
                    PaginaPrincipal.carruta = "";
                }
            }
        }

        protected void AperPersonalizada()
        {

        }
    }
}