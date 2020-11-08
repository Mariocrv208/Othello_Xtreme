using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Xml.Linq;
using System.Xml;
using System.Data.SqlClient;

namespace ProyectoEntregable2
{
    public partial class PantallaXtreme : System.Web.UI.Page
    {
        conect conectar = new conect();
        static bool validacionColor1 = false;
        static bool paso = false;
        static bool validacionTerminar = false;
        static bool validacionColor2 = false;
        static bool personlisto = false;
        static string colorGlobal = "";
        static string ultimo1 = "";
        static string ultimo2 = "";
        static int filallevar = 0;
        static int columnallevar = 0;
        static int contadorJug1 = 0;
        static int contadorJug2 = 0;
        static int actualfila = 0;
        static bool cambiomaquina = false;
        static int filam = 0;
        static int columnam = 0;
        static int actualcolu = 0;
        static bool listo = false;
        ImageButton[,] boton;
        static int filaT = 0;
        static int columnaT = 0;
        public static string idUsuarioCargado = "";
        static int cronometro;
        static int cronometroMinutos;
        static int cronometro2;
        static int cronometroMinutos2;
        static string literal = "";
        bool validacion = false;
        static bool YaEntro = false;
        static bool valcr1 = false;
        static bool valcro2 = false;
        static bool YaSalio = false;
        protected void Page_Load(object sender, EventArgs e)
            {
            if (YaSalio == true)
            {
                validacionColor1 = false;
                paso = false;
                validacionTerminar = false;
                validacionColor2 = false;
                personlisto = false;
                colorGlobal = "";
                ultimo1 = "";
                ultimo2 = "";
                filallevar = 0;
                columnallevar = 0;
                contadorJug1 = 0;
                contadorJug2 = 0;
                actualfila = 0;
                actualcolu = 0;
                filaT = 0;
                columnaT = 0;
                idUsuarioCargado = "";
                cronometro = 0;
                cronometroMinutos = 0;
                cronometro2 = 0;
                cronometroMinutos2 = 0;
                literal = "";
                validacion = false;
                valcr1 = false;
                valcro2 = false;
                YaEntro = false;
                YaSalio = false;
            }
            if(YaEntro == true)
            {
                validacionColor1 = false;
                paso = false;
                validacionTerminar = false;
                validacionColor2 = false;
                personlisto = false;
                colorGlobal = "";
                ultimo1 = "";
                ultimo2 = "";
                filallevar = 0;
                columnallevar = 0;
                contadorJug1 = 0;
                contadorJug2 = 0;
                actualfila = 0;
                actualcolu = 0;
                filaT = 0;
                columnaT = 0;
                idUsuarioCargado = "";
                cronometro = 0;
                cronometroMinutos = 0;
                cronometro2 = 0;
                cronometroMinutos2 = 0;
                literal = "";
                validacion = false;
                valcr1 = false;
                valcro2 = false;
                YaEntro = false;
                YaSalio = true;
            }
            if (PaginaPrincipal.carruta == "")
            {
                Tablero();
            }
            if (PaginaPrincipal.carruta != "")
            {
                CargarArchivo();
                validarTiros();
                paso = true;
                personlisto = true;
                PaginaPrincipal.carruta = "";
            }
            TextBox3.Text = ProyectoEntregable2.Login.UsuarioLogeado;
            TextBox4.Text = PaginaPrincipal.nombre2;
            if (colorGlobal == "")
            {
                colorSiguiente();
            }
            /*Activar Timmers*/
            if(valcro2 == true)
            {
                TimerBlanco.Enabled = false;
                TimerNegro.Enabled = true;
            }
            if (valcr1 == true)
            {
                TimerBlanco.Enabled = true;
                TimerNegro.Enabled = false;
            }
            TextBox1.Text = contadorJug1.ToString();
            TextBox2.Text = contadorJug2.ToString();
            if (PaginaPrincipal.partidaPersonalizada == true && personlisto == false && PaginaPrincipal.validacionCarga == false)
            {
                AperPersonalizada();
            }
            if ((PaginaPrincipal.partidaPersonalizada == false) && personlisto == false && PaginaPrincipal.validacionCarga == false)
            {
                AperPersonalizada();
            }
            if (personlisto == true && paso == false)
            {
                validarTiros();
                paso = true;
            }
            
        }

        protected void timerTestBlanco_tick(object sen, EventArgs e)
        {
            Label2.Text = "Tiempo: " + cronometroMinutos + ":" + cronometro.ToString();
            if (cronometro == 60)
            {
                cronometro = 0;
                cronometroMinutos = cronometroMinutos + 1;
            }
            cronometro = cronometro + 1;
        }
        
        protected void timerTestNegro_tick(object sen, EventArgs e)
        {
            Label3.Text = "Tiempo: " + cronometroMinutos2 + ":" + cronometro2.ToString();
            if (cronometro2 == 60)
            {
                cronometro2 = 0;
                cronometroMinutos2 = cronometroMinutos2 + 1;
            }
            cronometro2 = cronometro2 + 1;
        }
        
        protected void Button376_Click(object sender, EventArgs e)
        {
            validacionColor1 = false;
            paso = false;
            validacionTerminar = false;
            validacionColor2 = false;
            personlisto = false;
            colorGlobal = "";
            ultimo1 = "";
            ultimo2 = "";
            filallevar = 0;
            columnallevar = 0;
            contadorJug1 = 0;
            contadorJug2 = 0;
            actualfila = 0;
            actualcolu = 0;
            filaT = 0;
            columnaT = 0;
            idUsuarioCargado = "";
            cronometro = 0;
            cronometroMinutos = 0;
            cronometro2 = 0;
            cronometroMinutos2 = 0;
            literal = "";
            validacion = false;
            valcr1 = false;
            valcro2 = false;
            YaEntro = true;
            Response.Redirect("PaginaPrincipal.aspx");
            return;
        }

        protected void Tablero()
        {
            if (PaginaPrincipal.validacionCarga == false)
            {
                filaT = Int32.Parse(PaginaPrincipal.filasT) + 2;
                columnaT = Int32.Parse(PaginaPrincipal.columnasT) + 2;
            }
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
                        boton[i, j].ID = "F" + i.ToString() +"C" + j.ToString();
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
                        orilla[i, j].ID = "F" + i.ToString() + "C" + j.ToString();
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
                        boton[i, j].ID = "F" + i.ToString() + "C" + j.ToString();
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
                                    valcro2 = true;
                                    valcr1 = false;
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
                                    valcro2 = true;
                                    valcr1 = false;
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
                                    valcro2 = false;
                                    valcr1 = true;
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
                                    valcro2 = false;
                                    valcr1 = true;
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
                    valcro2 = false;
                    valcr1 = true;
                }

            }

        }

        protected void ButtonGeneral_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton buscar = (ImageButton)sender;
            char[] delimiterChars = { 'F', 'C', ' ' };
            string posicionbuscar = "";
            string parsearID = buscar.ID;
            string[] verId = parsearID.Split(delimiterChars);
            string separarfila = verId[1].ToString();
            string separarcolumna = verId[2].ToString();
            filallevar = Int32.Parse(separarfila);
            columnallevar = Int32.Parse(separarcolumna);
            for (int i = 1; i < (filaT - 1); i++)
            {
                for (int j = 1; j < (columnaT - 1); j++)
                {
                    posicionbuscar = "F"+i.ToString()+"C" + j.ToString();
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
            if ((PaginaPrincipal.partidaPersonalizada == true) && personlisto == false)
            {
                AperPersonalizada();
            }
            if(personlisto == true)
            {
                voltearFicha();
            }
            contadores();
            if (PaginaPrincipal.maquina == false)
            {
                colorSiguiente();
                if (personlisto == true)
                {
                    validarTiros();
                    pasarTurno();
                }
            }
            if (PaginaPrincipal.maquina == true)
            {
                colorSiguiente();
                if (personlisto == true)
                {
                    validarTiros();
                    pasarTurno();
                }
                if (listo == false)
                {
                    Maquina();
                }
                if (listo == true)
                {
                    colorSiguiente();
                    if (personlisto == true)
                    {
                        validarTiros();
                        pasarTurno();
                    }
                }
            }
            TerminarPartida();
        }

        protected void voltearFicha()
        {
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
                        if (columnabuscar == (columnaT - 1))
                        {
                            break;
                        }
                        if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                        {
                            validacion3 = true;
                            break;
                        }
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
                    if (columnabuscar == (columnaT - 1))
                    {
                        break;
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
                        if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                        {
                            validacion3 = true;
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
                        if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                        {
                            validacion3 = true;
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
                        if (filabuscar == (filaT - 1))
                        {
                            break;
                        }
                        if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                        {
                            validacion3 = true;
                            break;
                        }
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
                    if (filabuscar == (filaT - 1))
                    {
                        break;
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
                        if (filabuscar == 0 || columnabuscar == (columnaT - 1))
                        {
                            break;
                        }
                        if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                        {
                            validacion3 = true;
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
                    if (filabuscar == 0 || columnabuscar == (columnaT - 1))
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
                        if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                        {
                            validacion3 = true;
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
                        if (columnabuscar == 0 || filabuscar == (filaT - 1))
                        {
                            break;
                        }
                        if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                        {
                            validacion3 = true;
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
                    if (columnabuscar == 0 || filabuscar == (filaT - 1))
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
                        if (filabuscar == (filaT - 1) || columnabuscar == (columnaT - 1))
                        {
                            break;
                        }
                        if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                        {
                            validacion3 = true;
                            break;
                        }
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
                    if (filabuscar == (filaT - 1) || columnabuscar == (columnaT - 1))
                    {
                        break;
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
                        if (columnabuscar == (columnaT - 1))
                        {
                            break;
                        }
                        if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                        {
                            validacion3 = true;
                            break;
                        }
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
                    if (columnabuscar == (columnaT - 1))
                    {
                        break;
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
                        if (columnabuscar == 0)
                        {
                            break;
                        }
                        if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                        {
                            validacion3 = true;
                            break;
                        }
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
                    for (int i = 0; i < PaginaPrincipal.colores1.Length; i++)
                    {
                        if (filabuscar == 0)
                        {
                            break;
                        }
                        if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                        {
                            validacion3 = true;
                            break;
                        }
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
                        if (filabuscar == (filaT - 1))
                        {
                            break;
                        }
                        if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                        {
                            validacion3 = true;
                            break;
                        }
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
                    if (filabuscar == (filaT - 1))
                    {
                        break;
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
                        if (columnabuscar == (columnaT - 1) || filabuscar == 0)
                        {
                            break;
                        }
                        if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                        {
                            validacion3 = true;
                            break;
                        }
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
                    if (columnabuscar == (columnaT - 1) || filabuscar == 0)
                    {
                        break;
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
                        if (filabuscar == 0 || columnabuscar == 0)
                        {
                            break;
                        }
                        if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                        {
                            validacion3 = true;
                            break;
                        }
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
                    for (int i = 0; i < PaginaPrincipal.colores1.Length; i++)
                    {
                        if (filabuscar == (filaT - 1) || columnabuscar == 0)
                        {
                            break;
                        }
                        if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                        {
                            validacion3 = true;
                            break;
                        }
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
                    if (filabuscar == (filaT - 1) || columnabuscar == 0)
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
                    for (int i = 0; i < PaginaPrincipal.colores1.Length; i++)
                    {
                        if (filabuscar == (filaT - 1) || columnabuscar == (columnaT -1))
                        {
                            break;
                        }
                        if (boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png")
                        {
                            validacion3 = true;
                            break;
                        }
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
                    if (filabuscar == (filaT - 1) || columnabuscar == (columnaT - 1))
                    {
                        break;
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
            contadorJug1 = 0;
            contadorJug2 = 0;
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
                    bool validacioncolor = false;
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
                                if (PaginaPrincipal.colores1 != null)
                                {
                                    for (int k = 0; k< PaginaPrincipal.colores1.Length; k++)
                                    {
                                        if (elementomandar ==  PaginaPrincipal.colores1[k])
                                        {
                                            validacioncolor = false;    
                                            break;
                                        }
                                        if (elementomandar == PaginaPrincipal.colores1[k])
                                        {
                                            validacioncolor = true;
                                        }
                                    }
                                    if (validacioncolor == true)
                                    {
                                        PaginaPrincipal.Colores1.Add(elementomandar);
                                    }
                                }
                                if (PaginaPrincipal.colores1 == null)
                                {
                                    PaginaPrincipal.Colores1.Add(elementomandar);
                                    PaginaPrincipal.colores1 = PaginaPrincipal.Colores1.ToArray();
                                }


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
                                if (PaginaPrincipal.colores2 != null)
                                {
                                    for (int k = 0; k < PaginaPrincipal.colores2.Length; k++)
                                    {
                                        if (elementomandar == PaginaPrincipal.colores2[k])
                                        {
                                            validacioncolor = false;
                                            break;
                                        }
                                        if (elementomandar == PaginaPrincipal.colores2[k])
                                        {
                                            validacioncolor = true;
                                        }
                                    }
                                    if (validacioncolor == true)
                                    {
                                        PaginaPrincipal.Colores2.Add(elementomandar);
                                    }
                                }
                                if (PaginaPrincipal.colores2 == null)
                                {
                                    PaginaPrincipal.Colores2.Add(elementomandar);
                                    PaginaPrincipal.colores2 = PaginaPrincipal.Colores2.ToArray();
                                }
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
                                if ((filman < 21 && filman > 0) || (colman < 21 && colman > 0))
                                {
                                    if (boton[filman, colman].ImageUrl == "fondotransparente.png")
                                    {
                                        boton[filman, colman].ImageUrl = colormandar;
                                    }
                                }
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
                                        valcro2 = false;
                                        valcr1 = true;
                                        ultimo1 = colorGlobal;
                                        validacionColor1 = true;
                                    }
                                }
                                for (int k = 0; k < PaginaPrincipal.colores2.Length; k++)
                                {
                                    if (colorGlobal == PaginaPrincipal.colores2[k])
                                    {
                                        TimerBlanco.Enabled = false;
                                        TimerNegro.Enabled = true;
                                        valcro2 = true;
                                        valcr1 = false;
                                        ultimo2 = colorGlobal;
                                        validacionColor2 = true;
                                    }
                                }
                            }
                        }
                    }
                    PaginaPrincipal.carruta = "";
                }
            }
        }

        protected void validarTiros()
        {
            int columnabuscar = 0;
            int filabuscar = 0;
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
            bool jug1 = false;
            bool jug2 = false;
            for (int i = 0; i < PaginaPrincipal.colores1.Length; i++)
            {
                if (colorGlobal == PaginaPrincipal.colores1[i])
                {
                    jug1 = true;
                }
            }
            for (int i = 0; i < PaginaPrincipal.colores2.Length; i++)
            {
                if (colorGlobal == PaginaPrincipal.colores2[i])
                {
                    jug2 = true;
                }
            }
            if (jug1 == true)
            {
                for (int i = 1; i < (filaT - 1); i++)
                {
                    for (int j = 1; j < (columnaT - 1); j++)
                    {
                        for (int k = 0; k < PaginaPrincipal.colores1.Length; k++)
                        {
                            if (boton[i, j].ImageUrl == (PaginaPrincipal.colores1[k] + ".png"))
                            {
                                columnallevar = j;
                                filallevar = i;
                                /*Derecha*/
                                columnabuscar = columnallevar + 1;
                                filabuscar = filallevar;
                                while (columnabuscar < (columnaT - 1))
                                {
                                    if (columnabuscar == (columnaT - 1))
                                    {
                                        break;
                                    }
                                    for (int n = 0; n < PaginaPrincipal.colores1.Length; n++)
                                    {
                                        if ((boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png") || (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores1[n]+".png"))
                                        {
                                            validacion1 = true;
                                            break;
                                        }
                                        for (int m = 0; m < PaginaPrincipal.colores2.Length; m++)
                                        {
                                            if (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores2[m] + ".png")
                                            {
                                                validacioncambiar = true;
                                                der = true;
                                                filaLimiteder = filabuscar;
                                                columnaLimiteder = columnabuscar;
                                            }
                                        }
                                    }
                                    if (validacion1 == true)
                                    {
                                        break;
                                    }
                                    columnabuscar = columnabuscar + 1;
                                }
                                /*izquierda*/
                                validacion1 = false;
                                validacion2 = false;
                                validacion3 = false;
                                columnallevar = j;
                                filallevar = i;
                                columnabuscar = columnallevar - 1;
                                filabuscar = filallevar;
                                while (columnabuscar > 0)
                                {
                                    if (columnabuscar == 0)
                                    {
                                        break;
                                    }
                                    for (int n = 0; n < PaginaPrincipal.colores1.Length; n++)
                                    {
                                        if ((boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png") || (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores1[n] + ".png"))
                                        {
                                            validacion1 = true;
                                            break;
                                        }
                                        for (int m = 0; m < PaginaPrincipal.colores2.Length; m++)
                                        {
                                            if (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores2[m] + ".png")
                                            {
                                                validacioncambiar = true;
                                                iz = true;
                                                filaLimiteiz = filabuscar;
                                                columnaLimiteiz = columnabuscar;
                                            }
                                        }
                                    }
                                    if (validacion1 == true)
                                    {
                                        break;
                                    }
                                    columnabuscar = columnabuscar - 1;
                                }
                                /*arriba*/
                                validacion1 = false;
                                validacion2 = false;
                                validacion3 = false;
                                columnallevar = j;
                                filallevar = i;
                                columnabuscar = columnallevar;
                                filabuscar = filallevar - 1;
                                while (filabuscar > 0)
                                {
                                    if (filabuscar == 0)
                                    {
                                        break;
                                    }
                                    for (int n = 0; n < PaginaPrincipal.colores1.Length; n++)
                                    {
                                        if ((boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png") || (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores1[n] + ".png"))
                                        {
                                            validacion1 = true;
                                            break;
                                        }
                                        for (int m = 0; m < PaginaPrincipal.colores2.Length; m++)
                                        {
                                            if (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores2[m] + ".png")
                                            {
                                                validacioncambiar = true;
                                                arr = true;
                                                filaLimitearr = filabuscar;
                                                columnaLimitearr = columnabuscar;
                                            }
                                        }
                                    }
                                    if (validacion1 == true)
                                    {
                                        break;
                                    }
                                    filabuscar = filabuscar - 1;
                                }
                                /*abajo*/
                                validacion1 = false;
                                validacion2 = false;
                                validacion3 = false;
                                columnallevar = j;
                                filallevar = i;
                                columnabuscar = columnallevar;
                                filabuscar = filallevar + 1;
                                while (filabuscar < (filaT - 1))
                                {
                                    if (filabuscar == (filaT - 1))
                                    {
                                        break;
                                    }
                                    for (int n = 0; n < PaginaPrincipal.colores1.Length; n++)
                                    {
                                        if ((boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png") || (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores1[n] + ".png"))
                                        {
                                            validacion1 = true;
                                            break;
                                        }
                                        for (int m = 0; m < PaginaPrincipal.colores2.Length; m++)
                                        {
                                            if (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores2[m] + ".png")
                                            {
                                                validacioncambiar = true;
                                                aba = true;
                                                filaLimiteaba = filabuscar;
                                                columnaLimiteaba = columnabuscar;
                                            }
                                        }
                                    }
                                    if (validacion1 == true)
                                    {
                                        break;
                                    }
                                    filabuscar = filabuscar + 1;
                                }
                                /*derechaArriba*/
                                validacion1 = false;
                                validacion2 = false;
                                validacion3 = false;
                                columnallevar = j;
                                filallevar = i;
                                columnabuscar = columnallevar + 1;
                                filabuscar = filallevar - 1;
                                while ((filabuscar > 0) && (columnabuscar < (columnaT - 1)))
                                {
                                    if (filabuscar == 0 || columnabuscar == (columnaT - 1))
                                    {
                                        break;
                                    }
                                    for (int n = 0; n < PaginaPrincipal.colores1.Length; n++)
                                    {
                                        if ((boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png") || (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores1[n] + ".png"))
                                        {
                                            validacion1 = true;
                                            break;
                                        }
                                        for (int m = 0; m < PaginaPrincipal.colores2.Length; m++)
                                        {
                                            if (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores2[m] + ".png")
                                            {
                                                validacioncambiar = true;
                                                derarr = true;
                                                filaLimitederarr = filabuscar;
                                                columnaLimitederarr = columnabuscar;
                                            }
                                        }
                                    }
                                    if (validacion1 == true)
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
                                columnallevar = j;
                                filallevar = i;
                                columnabuscar = columnallevar - 1;
                                filabuscar = filallevar - 1;
                                while ((filabuscar > 0) && (columnabuscar > 0))
                                {
                                    if (filabuscar == 0 || columnabuscar == 0)
                                    {
                                        break;
                                    }
                                    for (int n = 0; n < PaginaPrincipal.colores1.Length; n++)
                                    {
                                        if ((boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png") || (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores1[n] + ".png"))
                                        {
                                            validacion1 = true;
                                            break;
                                        }
                                        for (int m = 0; m < PaginaPrincipal.colores2.Length; m++)
                                        {
                                            if (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores2[m] + ".png")
                                            {
                                                validacioncambiar = true;
                                                izarr = true;
                                                filaLimiteizarr = filabuscar;
                                                columnaLimiteizarr = columnabuscar;
                                            }
                                        }
                                    }
                                    if (validacion1 == true)
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
                                columnallevar = j;
                                filallevar = i;
                                columnabuscar = columnallevar - 1;
                                filabuscar = filallevar + 1;
                                while ((filabuscar < (filaT - 1)) && (columnabuscar > 0))
                                {
                                    if (columnabuscar == 0 || filabuscar == (filaT - 1))
                                    {
                                        break;
                                    }
                                    for (int n = 0; n < PaginaPrincipal.colores1.Length; n++)
                                    {
                                        if ((boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png") || (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores1[n] + ".png"))
                                        {
                                            validacion1 = true;
                                            break;
                                        }
                                        for (int m = 0; m < PaginaPrincipal.colores2.Length; m++)
                                        {
                                            if (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores2[m] + ".png")
                                            {
                                                validacioncambiar = true;
                                                izaba = true;
                                                filaLimiteizaba = filabuscar;
                                                columnaLimiteiziaba = columnabuscar;
                                            }
                                        }
                                    }
                                    if (validacion1 == true)
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
                                columnallevar = j;
                                filallevar = i;
                                columnabuscar = columnallevar + 1;
                                filabuscar = filallevar + 1;
                                while ((filabuscar < (filaT - 1)) && (columnabuscar < (columnaT - 1)))
                                {
                                    if (filabuscar == (filaT - 1) || columnabuscar == (columnaT - 1))
                                    {
                                        break;
                                    }
                                    for (int n = 0; n < PaginaPrincipal.colores1.Length; n++)
                                    {
                                        if ((boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png") || (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores1[n] + ".png"))
                                        {
                                            validacion1 = true;
                                            break;
                                        }
                                        for (int m = 0; m < PaginaPrincipal.colores2.Length; m++)
                                        {
                                            if (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores2[m] + ".png")
                                            {
                                                validacioncambiar = true;
                                                deraba = true;
                                                filaLimitederaba = filabuscar;
                                                columnaLimitederaba = columnabuscar;
                                            }
                                        }
                                    }
                                    if (validacion1 == true)
                                    {
                                        break;
                                    }
                                    columnabuscar = columnabuscar + 1;
                                    filabuscar = filabuscar + 1;
                                }
                            }
                        }
                    }
                }
            }
            if (jug2 == true)
            {
                for (int i = 1; i < (filaT - 1); i++)
                {
                    for (int j = 1; j < (columnaT - 1); j++)
                    {
                        for (int k = 0; k < PaginaPrincipal.colores2.Length; k++)
                        {
                            if (boton[i, j].ImageUrl == (PaginaPrincipal.colores2[k] + ".png"))
                            {
                                columnallevar = j;
                                filallevar = i;
                                /*Derecha*/
                                columnabuscar = columnallevar + 1;
                                filabuscar = filallevar;
                                while (columnabuscar < (columnaT - 1))
                                {
                                    if (columnabuscar == (columnaT - 1))
                                    {
                                        break;
                                    }
                                    for (int n = 0; n < PaginaPrincipal.colores2.Length; n++)
                                    {
                                        if ((boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png") || (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[n]+".png")))
                                        {
                                            validacion1 = true;
                                            break;
                                        }
                                        for (int m = 0; m < PaginaPrincipal.colores1.Length; m++)
                                        {
                                            if (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores1[m] + ".png")
                                            {
                                                validacioncambiar = true;
                                                der = true;
                                                filaLimiteder = filabuscar;
                                                columnaLimiteder = columnabuscar;
                                            }
                                        }
                                    }
                                    if (validacion1 == true)
                                    {
                                        break;
                                    }
                                    columnabuscar = columnabuscar + 1;
                                }
                                /*izquierda*/
                                validacion1 = false;
                                validacion2 = false;
                                validacion3 = false;
                                columnallevar = j;
                                filallevar = i;
                                columnabuscar = columnallevar - 1;
                                filabuscar = filallevar;
                                while (columnabuscar > 0)
                                {
                                    if (columnabuscar == 0)
                                    {
                                        break;
                                    }
                                    for (int n = 0; n < PaginaPrincipal.colores2.Length; n++)
                                    {
                                        if ((boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png") || (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[n] + ".png")))
                                        {
                                            validacion1 = true;
                                            break;
                                        }
                                        for (int m = 0; m < PaginaPrincipal.colores1.Length; m++)
                                        {
                                            if (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores1[m] + ".png")
                                            {
                                                validacioncambiar = true;
                                                iz = true;
                                                filaLimiteiz = filabuscar;
                                                columnaLimiteiz = columnabuscar;
                                            }
                                        }
                                    }
                                    if (validacion1 == true)
                                    {
                                        break;
                                    }
                                    columnabuscar = columnabuscar - 1;
                                }
                                /*arriba*/
                                validacion1 = false;
                                validacion2 = false;
                                validacion3 = false;
                                columnallevar = j;
                                filallevar = i;
                                columnabuscar = columnallevar;
                                filabuscar = filallevar - 1;
                                while (filabuscar > 0)
                                {
                                    if (filabuscar == 0)
                                    {
                                        break;
                                    }
                                    for (int n = 0; n < PaginaPrincipal.colores2.Length; n++)
                                    {
                                        if ((boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png") || (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[n] + ".png")))
                                        {
                                            validacion1 = true;
                                            break;
                                        }
                                        for (int m = 0; m < PaginaPrincipal.colores1.Length; m++)
                                        {
                                            if (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores1[m] + ".png")
                                            {
                                                validacioncambiar = true;
                                                arr = true;
                                                filaLimitearr = filabuscar;
                                                columnaLimitearr = columnabuscar;
                                            }
                                        }
                                    }
                                    if (validacion1 == true)
                                    {
                                        break;
                                    }
                                    filabuscar = filabuscar - 1;
                                }
                                /*abajo*/
                                validacion1 = false;
                                validacion2 = false;
                                validacion3 = false;
                                columnallevar = j;
                                filallevar = i;
                                columnabuscar = columnallevar;
                                filabuscar = filallevar + 1;
                                while (filabuscar < (filaT - 1))
                                {
                                    if (filabuscar == (filaT - 1))
                                    {
                                        break;
                                    }
                                    for (int n = 0; n < PaginaPrincipal.colores2.Length; n++)
                                    {
                                        if ((boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png") || (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[n] + ".png")))
                                        {
                                            validacion1 = true;
                                            break;
                                        }
                                        for (int m = 0; m < PaginaPrincipal.colores1.Length; m++)
                                        {
                                            if (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores1[m] + ".png")
                                            {
                                                validacioncambiar = true;
                                                aba = true;
                                                filaLimiteaba = filabuscar;
                                                columnaLimiteaba = columnabuscar;
                                            }
                                        }
                                    }
                                    if (validacion1 == true)
                                    {
                                        break;
                                    }
                                    filabuscar = filabuscar + 1;
                                }
                                /*derechaArriba*/
                                validacion1 = false;
                                validacion2 = false;
                                validacion3 = false;
                                columnallevar = j;
                                filallevar = i;
                                columnabuscar = columnallevar + 1;
                                filabuscar = filallevar - 1;
                                while ((filabuscar > 0) && (columnabuscar < (columnaT - 1)))
                                {
                                    if (filabuscar == 0 || columnabuscar == (columnaT - 1))
                                    {
                                        break;
                                    }
                                    for (int n = 0; n < PaginaPrincipal.colores2.Length; n++)
                                    {
                                        if ((boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png") || (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[n] + ".png")))
                                        {
                                            validacion1 = true;
                                            break;
                                        }
                                        for (int m = 0; m < PaginaPrincipal.colores1.Length; m++)
                                        {
                                            if (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores1[m] + ".png")
                                            {
                                                validacioncambiar = true;
                                                derarr = true;
                                                filaLimitederarr = filabuscar;
                                                columnaLimitederarr = columnabuscar;
                                            }
                                        }
                                    }
                                    if (validacion1 == true)
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
                                columnallevar = j;
                                filallevar = i;
                                columnabuscar = columnallevar - 1;
                                filabuscar = filallevar - 1;
                                while ((filabuscar > 0) && (columnabuscar > 0))
                                {
                                    if (filabuscar == 0 || columnabuscar == 0)
                                    {
                                        break;
                                    }
                                    for (int n = 0; n < PaginaPrincipal.colores2.Length; n++)
                                    {
                                        if ((boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png") || (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[n] + ".png")))
                                        {
                                            validacion1 = true;
                                            break;
                                        }
                                        for (int m = 0; m < PaginaPrincipal.colores1.Length; m++)
                                        {
                                            if (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores1[m] + ".png")
                                            {
                                                validacioncambiar = true;
                                                izarr = true;
                                                filaLimiteizarr = filabuscar;
                                                columnaLimiteizarr = columnabuscar;
                                            }
                                        }
                                    }
                                    if (validacion1 == true)
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
                                columnallevar = j;
                                filallevar = i;
                                columnabuscar = columnallevar - 1;
                                filabuscar = filallevar + 1;
                                while ((filabuscar < (filaT - 1)) && (columnabuscar > 0))
                                {
                                    if (columnabuscar == 0 || filabuscar == (filaT - 1))
                                    {
                                        break;
                                    }
                                    for (int n = 0; n < PaginaPrincipal.colores2.Length; n++)
                                    {
                                        if ((boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png") || (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[n] + ".png")))
                                        {
                                            validacion1 = true;
                                            break;
                                        }
                                        for (int m = 0; m < PaginaPrincipal.colores1.Length; m++)
                                        {
                                            if (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores1[m] + ".png")
                                            {
                                                validacioncambiar = true;
                                                izaba = true;
                                                filaLimiteizaba = filabuscar;
                                                columnaLimiteiziaba = columnabuscar;
                                            }
                                        }
                                    }
                                    if (validacion1 == true)
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
                                columnallevar = j;
                                filallevar = i;
                                columnabuscar = columnallevar + 1;
                                filabuscar = filallevar + 1;
                                while ((filabuscar < (filaT - 1)) && (columnabuscar < (columnaT - 1)))
                                {
                                    if (filabuscar == (filaT - 1) || columnabuscar == (columnaT - 1))
                                    {
                                        break;
                                    }
                                    for (int n = 0; n < PaginaPrincipal.colores2.Length; n++)
                                    {
                                        if ((boton[filabuscar, columnabuscar].ImageUrl == "fondotransparente.png") || (boton[filabuscar, columnabuscar].ImageUrl == (PaginaPrincipal.colores2[n] + ".png")))
                                        {
                                            validacion1 = true;
                                            break;
                                        }
                                        for (int m = 0; m < PaginaPrincipal.colores1.Length; m++)
                                        {
                                            if (boton[filabuscar, columnabuscar].ImageUrl == PaginaPrincipal.colores1[m] + ".png")
                                            {
                                                validacioncambiar = true;
                                                deraba = true;
                                                filaLimitederaba = filabuscar;
                                                columnaLimitederaba = columnabuscar;
                                            }
                                        }
                                    }
                                    if (validacion1 == true)
                                    {
                                        break;
                                    }
                                    columnabuscar = columnabuscar + 1;
                                    filabuscar = filabuscar + 1;
                                }
                            }
                        }
                        
                    }
                }
            }
            if (validacioncambiar == true)
            {
                if ((columnaLimiteder + 1) == (columnaT - 1))
                {
                    der = false;
                }
                if ((columnaLimiteiz - 1) == 0)
                {
                    iz = false;
                }
                if ((filaLimiteaba + 1) == (filaT - 1))
                {
                    aba = false;
                }
                if ((filaLimitearr - 1) == 0)
                {
                    arr = false;
                }
                if ((columnaLimitederarr + 1) == (columnaT - 1) || (filaLimitederarr - 1) == 0)
                {
                    derarr = false;
                }
                if ((columnaLimitederaba + 1) == (columnaT - 1) || (filaLimitederaba + 1) == (filaT - 1))
                {
                    deraba = false;
                }
                if ((columnaLimiteizarr - 1) == 0 || (filaLimiteizarr - 1) == 0)
                {
                    izarr = false;
                }
                if ((columnaLimiteiziaba - 1) == 0 || (filaLimiteizaba + 1) == (filaT - 1))
                {
                    izaba = false;
                }
                if (der == true && boton[filaLimiteder, (columnaLimiteder + 1)].ImageUrl == "fondotransparente.png")
                {
                    /*derecha*/
                    if (jug1 == true)
                    {
                        boton[filaLimiteder, (columnaLimiteder + 1)].ImageUrl = "posiblejug1.png";
                    }
                    if (jug2 == true)
                    {
                        boton[filaLimiteder, (columnaLimiteder + 1)].ImageUrl = "posiblejug2.png";
                    }
                }
                if (iz == true && boton[filaLimiteiz, (columnaLimiteiz - 1)].ImageUrl == "fondotransparente.png")
                {
                    /*izquierda*/
                    if (jug1 == true)
                    {
                        boton[filaLimiteiz, (columnaLimiteiz - 1)].ImageUrl = "posiblejug1.png";
                    }
                    if (jug2 == true)
                    {
                        boton[filaLimiteiz, (columnaLimiteiz - 1)].ImageUrl = "posiblejug2.png";
                    }
                }
                if (arr == true && boton[(filaLimitearr - 1), (columnaLimitearr)].ImageUrl == "fondotransparente.png")
                {
                    /*arriba*/
                    if (jug1 == true)
                    {
                        boton[(filaLimitearr - 1), (columnaLimitearr)].ImageUrl = "posiblejug1.png";
                    }
                    if (jug2 == true)
                    {
                        boton[(filaLimitearr - 1), (columnaLimitearr)].ImageUrl = "posiblejug2.png";
                    }
                }
                if (aba == true && boton[(filaLimiteaba + 1), (columnaLimiteaba)].ImageUrl == "fondotransparente.png")
                {
                    /*abajo*/
                    if (jug1 == true)
                    {
                        boton[(filaLimiteaba + 1), (columnaLimiteaba)].ImageUrl = "posiblejug1.png";
                    }
                    if (jug2 == true)
                    {
                        boton[(filaLimiteaba + 1), (columnaLimiteaba)].ImageUrl = "posiblejug2.png";
                    }
                }
                if (derarr == true && boton[(filaLimitederarr - 1), (columnaLimitederarr + 1)].ImageUrl == "fondotransparente.png")
                {
                    /*arribaDerecha*/
                    if (jug1 == true)
                    {
                        boton[(filaLimitederarr - 1), (columnaLimitederarr + 1)].ImageUrl = "posiblejug1.png";
                    }
                    if (jug2 == true)
                    {
                        boton[(filaLimitederarr - 1), (columnaLimitederarr + 1)].ImageUrl = "posiblejug2.png";
                    }
                }
                if (izarr == true && boton[(filaLimiteizarr - 1), (columnaLimiteizarr - 1)].ImageUrl == "fondotransparente.png")
                {
                    /*arribaIzquierda*/
                    if (jug1 == true)
                    {
                        boton[(filaLimiteizarr - 1), (columnaLimiteizarr - 1)].ImageUrl = "posiblejug1.png";
                    }
                    if (jug2 == true)
                    {
                        boton[(filaLimiteizarr - 1), (columnaLimiteizarr - 1)].ImageUrl = "posiblejug2.png";
                    }
                }
                if (izaba == true && boton[(filaLimiteizaba + 1), (columnaLimiteiziaba - 1)].ImageUrl == "fondotransparente.png")
                {
                    /*abajoIzquierda*/
                    if (jug1 == true)
                    {
                        boton[(filaLimiteizaba + 1), (columnaLimiteiziaba - 1)].ImageUrl = "posiblejug1.png";
                    }
                    if (jug2 == true)
                    {
                        boton[(filaLimiteizaba + 1), (columnaLimiteiziaba - 1)].ImageUrl = "posiblejug2.png";
                    }
                }
                if (deraba == true && boton[(filaLimitederaba + 1), (columnaLimitederaba + 1)].ImageUrl == "fondotransparente.png")
                {
                    /*abajoDerecha*/
                    if (jug1 == true)
                    {
                        boton[(filaLimitederaba + 1), (columnaLimitederaba + 1)].ImageUrl = "posiblejug1.png";
                    }
                    if (jug2 == true)
                    {
                        boton[(filaLimitederaba + 1), (columnaLimitederaba + 1)].ImageUrl = "posiblejug2.png";
                    }
                }
            }
            if (jug1 == true)
            {
                for (int i = 1; i < (filaT - 1); i++)
                {
                    for (int j = 1; j < (columnaT - 1); j++)
                    {
                        if (boton[i, j].ImageUrl == "posiblejug1.png")
                        {
                            boton[i, j].Enabled = true;
                        }
                        if (boton[i, j].ImageUrl != "posiblejug1.png")
                        {
                            boton[i, j].Enabled = false;
                        }
                        if (boton[i, j].ImageUrl == "posiblejug2.png")
                        {
                            boton[i, j].ImageUrl = "fondotransparente.png";
                        }
                    }
                }   
            }
            if (jug2 == true)
            {
                for (int i = 1; i < (filaT - 1); i++)
                {
                    for (int j = 1; j < (columnaT - 1); j++)
                    {
                        if (boton[i, j].ImageUrl == "posiblejug2.png")
                        {
                            boton[i, j].Enabled = true;
                        }
                        if (boton[i, j].ImageUrl != "posiblejug2.png")
                        {
                            boton[i, j].Enabled = false;
                        }
                        if (boton[i, j].ImageUrl == "posiblejug1.png")
                        {
                            boton[i, j].ImageUrl = "fondotransparente.png";
                        }
                    }
                }
            }

        }

        protected void AperPersonalizada()
        {
            bool validar1 = false;
            bool validar2 = false;
            bool validar3 = false;
            bool validar4 = false;
            if (PaginaPrincipal.partidaPersonalizada == true)
            {
                for (int i = 1; i < (filaT - 1); i++)
                {
                    for (int j = 1; j < (columnaT - 1); j++)
                    {
                        boton[i, j].Enabled = false;
                    }
                }
                boton[((filaT / 2) - 1), ((columnaT / 2) - 1)].Enabled = true;
                boton[((filaT / 2) - 1), ((columnaT / 2))].Enabled = true;
                boton[((filaT / 2)), ((columnaT / 2))].Enabled = true;
                boton[((filaT / 2)), ((columnaT / 2) - 1)].Enabled = true;
                if (boton[((filaT / 2) - 1), ((columnaT / 2) - 1)].ImageUrl != "fondotransparente.png")
                {
                    boton[((filaT / 2) - 1), ((columnaT / 2) - 1)].Enabled = false;
                    validar1 = true;
                }
                if (boton[((filaT / 2) - 1), ((columnaT / 2))].ImageUrl != "fondotransparente.png")
                {
                    boton[((filaT / 2) - 1), ((columnaT / 2))].Enabled = false;
                    validar2 = true;
                }
                if (boton[((filaT / 2)), ((columnaT / 2))].ImageUrl != "fondotransparente.png")
                {
                    boton[((filaT / 2)), ((columnaT / 2))].Enabled = false;
                    validar3 = true;
                }
                if (boton[((filaT / 2)), ((columnaT / 2) - 1)].ImageUrl != "fondotransparente.png")
                {
                    boton[((filaT / 2)), ((columnaT / 2) - 1)].Enabled = false;
                    validar4 = true;
                }
                if(validar1 == true && validar2 == true && validar3 == true && validar4 == true)
                {
                    for (int i = 1; i < (filaT - 1); i++)
                    {
                        for (int j = 1; j < (columnaT - 1); j++)
                        {
                            boton[i, j].Enabled = true;
                        }
                    }
                    boton[((filaT / 2) - 1), ((columnaT / 2) - 1)].Enabled = false;
                    boton[((filaT / 2) - 1), ((columnaT / 2))].Enabled = false;
                    boton[((filaT / 2)), ((columnaT / 2))].Enabled = false;
                    boton[((filaT / 2)), ((columnaT / 2) - 1)].Enabled = false;
                    personlisto = true;
                }
            }
            if (PaginaPrincipal.partidaPersonalizada == false)
            {
                boton[((filaT / 2) - 1), ((columnaT / 2) - 1)].ImageUrl = PaginaPrincipal.colores1[0]+".png";
                if(PaginaPrincipal.colores1.Length != 1)
                {
                    boton[((filaT / 2)), ((columnaT / 2))].ImageUrl = PaginaPrincipal.colores1[1] + ".png";
                    ultimo1 = PaginaPrincipal.colores1[1];
                }
                if (PaginaPrincipal.colores1.Length == 1)
                {
                    boton[((filaT / 2)), ((columnaT / 2))].ImageUrl = PaginaPrincipal.colores1[0] + ".png";
                    ultimo1 = PaginaPrincipal.colores1[0];
                }
                validacionColor1 = true;
                boton[((filaT / 2) - 1), ((columnaT / 2))].ImageUrl = PaginaPrincipal.colores2[0] + ".png";
                if (PaginaPrincipal.colores2.Length != 1)
                {
                    boton[((filaT / 2)), ((columnaT / 2) - 1)].ImageUrl = PaginaPrincipal.colores2[1] + ".png";
                    ultimo2 = PaginaPrincipal.colores2[1];
                }
                if (PaginaPrincipal.colores2.Length == 1)
                {
                    boton[((filaT / 2)), ((columnaT / 2) - 1)].ImageUrl = PaginaPrincipal.colores2[0] + ".png";
                    ultimo2 = PaginaPrincipal.colores2[0];
                }
                validacionColor2 = false;
                personlisto = true;
            }
        }

        protected void pasarTurno()
        {
            bool validacionDentro = false;
            bool validacion = false;
            bool jug1 = false;
            bool jug2 = false;
            for (int i = 0; i < PaginaPrincipal.colores1.Length; i++)
            {
                if (colorGlobal == PaginaPrincipal.colores1[i])
                {
                    jug1 = true;
                }
            }
            for (int i = 0; i < PaginaPrincipal.colores2.Length; i++)
            {
                if (colorGlobal == PaginaPrincipal.colores2[i])
                {
                    jug2 = true;
                }
            }
            if (jug1 == true)
            {
                for (int i = 1; i < (filaT - 1); i++)
                {
                    for (int j = 1; j < (columnaT - 1); j++)
                    {
                        if (boton[i, j].ImageUrl == "posiblejug1.png")
                        {
                            validacion = true;
                        }
                    }
                }
            }
            if (jug2 == true)
            {
                for (int i = 1; i < (filaT - 1); i++)
                {
                    for (int j = 1; j < (columnaT - 1); j++)
                    {
                        if (boton[i, j].ImageUrl == "posiblejug2.png")
                        {
                            validacion = true;
                        }
                    }
                }
            }
            if (validacion == false && validacionDentro == false)
            {
                validacionDentro = true;
                colorSiguiente();
                validarTiros();
                pasarTurno();
                if (validacion == true)
                {
                    listo = true;
                    return;
                }
            }
            if (validacionDentro == true)
            {
                /*Terminar Partida*/
                validacionTerminar = true;
                TerminarPartida();
            }
        }

        protected void TerminarPartida()
        {
            bool validacionLleno = false;
            bool validacionSalir = false;
            bool validacionRegresar = false;
            string texto = "";
            string modalidad = "";
            if (PaginaPrincipal.ModalidadInversa == true)
            {
                modalidad = "Inversa";
            }
            if (PaginaPrincipal.ModalidadInversa == false)
            {
                modalidad = "Normal";
            }
            if (PaginaPrincipal.maquina == true)
            {
                texto = "Xtreme/Maquina";
            }
            if (PaginaPrincipal.maquina == false)
            {
                texto = "Xtreme/Multijugador";
            }
            if (PaginaPrincipal.ModalidadInversa == true)
            {
                /*Tablero Lleno*/
                for (int i = 0; i < (filaT - 1); i++)
                {
                    for (int j = 0; j < (columnaT - 1); j++)
                    {
                        if (boton[i, j].ImageUrl != "fondotransparente.png")
                        {
                            validacionLleno = true;
                        }
                        if (boton[i, j].ImageUrl == "fondotransparente.png")
                        {
                            validacionSalir = true;
                            break;
                        }
                    }
                    if (validacionSalir == true)
                    {
                        break;
                    }
                }
                if (validacionLleno == true)
                {
                    string cronometromandar = "";
                    if ((contadorJug1 > contadorJug2 && ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text && PaginaPrincipal.ModalidadInversa == true) || (contadorJug2 > contadorJug1 && ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text && PaginaPrincipal.ModalidadInversa == true))
                    {
                        if (PaginaPrincipal.ModalidadInversa == true)
                        {
                            if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text)
                            {
                                cronometromandar = cronometroMinutos.ToString() + ":" + cronometro.ToString();
                            }
                            if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text)
                            {
                                cronometromandar = cronometroMinutos2.ToString() + ":" + cronometro2.ToString();
                            }
                            int contadorVictorias = 1;
                            int contadorDerrotas = 1;
                            int contadorEmpates = 1;
                            validacionRegresar = true;
                            bool salida = true;
                            bool salida2 = false;
                            bool salida3 = false;
                            while (salida == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT victorias, nicknameJugador FROM PartidaXtreme WHERE victorias=@victorias AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@victorias", contadorVictorias);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorVictorias = contadorVictorias + 1;
                                }
                                else if (!validacion2.Read())
                                {
                                    salida = false;
                                }
                            }
                            while (salida2 == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT derrotas, nicknameJugador FROM PartidaXtreme WHERE derrotas=@derrotas AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@derrotas", contadorDerrotas);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorDerrotas = contadorDerrotas + 1;
                                }

                                else if (!validacion2.Read())
                                {
                                    salida2 = false;
                                }
                            }
                            while (salida3 == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT empates, nicknameJugador FROM PartidaXtreme WHERE empates=@empates AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@empates", contadorEmpates);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorEmpates = contadorEmpates + 1;
                                }
                                else if (!validacion2.Read())
                                {
                                    salida3 = false;
                                }

                            }
                            /*Envio Datos*/
                            string mandar = "INSERT INTO PartidaXtreme (fichas, nicknameJugador, empates, tiempo, tipoPartida, modalidad) VALUES (@fichas, @nicknameJugador, @empates, @tiempo, @tipoPartida, @modalidad)";
                            SqlCommand mandando = new SqlCommand(mandar, conectar.Leer());
                            mandando.Parameters.AddWithValue("@fichas", contadorJug1);
                            mandando.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                            mandando.Parameters.AddWithValue("@empates", contadorEmpates);
                            mandando.Parameters.AddWithValue("@tiempo", cronometromandar);
                            mandando.Parameters.AddWithValue("@tipoPartida", texto);
                            mandando.Parameters.AddWithValue("@modalidad", modalidad);
                            mandando.ExecuteNonQuery();

                        }
                    }
                    if ((contadorJug1 > contadorJug2 && ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text && PaginaPrincipal.ModalidadInversa == true) || (contadorJug2 > contadorJug1 && ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text && PaginaPrincipal.ModalidadInversa == true))
                    {
                        if (PaginaPrincipal.ModalidadInversa == true)
                        {
                            if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text)
                            {
                                cronometromandar = cronometroMinutos.ToString() + ":" + cronometro.ToString();
                            }
                            if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text)
                            {
                                cronometromandar = cronometroMinutos2.ToString() + ":" + cronometro2.ToString();
                            }
                            int contadorVictorias = 1;
                            int contadorDerrotas = 1;
                            int contadorEmpates = 1;
                            validacionRegresar = true;
                            bool salida = false;
                            bool salida2 = true;
                            bool salida3 = false;
                            while (salida == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT victorias, nicknameJugador FROM PartidaXtreme WHERE victorias=@victorias AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@victorias", contadorVictorias);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorVictorias = contadorVictorias + 1;
                                }
                                else if (!validacion2.Read())
                                {
                                    salida = false;
                                }
                            }
                            while (salida2 == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT derrotas, nicknameJugador FROM PartidaXtreme WHERE derrotas=@derrotas AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@derrotas", contadorDerrotas);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorDerrotas = contadorDerrotas + 1;
                                }

                                else if (!validacion2.Read())
                                {
                                    salida2 = false;
                                }
                            }
                            while (salida3 == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT empates, nicknameJugador FROM PartidaXtreme WHERE empates=@empates AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@empates", contadorEmpates);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorEmpates = contadorEmpates + 1;
                                }
                                else if (!validacion2.Read())
                                {
                                    salida3 = false;
                                }

                            }
                            /*Envio Datos*/
                            string mandar = "INSERT INTO PartidaXtreme (fichas, nicknameJugador, empates, tiempo, tipoPartida, modalidad) VALUES (@fichas, @nicknameJugador, @empates, @tiempo, @tipoPartida, @modalidad)";
                            SqlCommand mandando = new SqlCommand(mandar, conectar.Leer());
                            mandando.Parameters.AddWithValue("@fichas", contadorJug1);
                            mandando.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                            mandando.Parameters.AddWithValue("@empates", contadorEmpates);
                            mandando.Parameters.AddWithValue("@tiempo", cronometromandar);
                            mandando.Parameters.AddWithValue("@tipoPartida", texto);
                            mandando.Parameters.AddWithValue("@modalidad", modalidad);
                            mandando.ExecuteNonQuery();

                        }
                    }
                    if (contadorJug1 == contadorJug2)
                    {
                        if (PaginaPrincipal.ModalidadInversa == true)
                        {
                            modalidad = "Inversa";
                        }
                        if (PaginaPrincipal.ModalidadInversa == false)
                        {
                            modalidad = "Normal";
                        }
                        if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text)
                        {
                            cronometromandar = cronometroMinutos.ToString() + ":" + cronometro.ToString();
                        }
                        if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text)
                        {
                            cronometromandar = cronometroMinutos2.ToString() + ":" + cronometro2.ToString();
                        }
                        int contadorVictorias = 1;
                        int contadorDerrotas = 1;
                        int contadorEmpates = 1;
                        validacionRegresar = true;
                        bool salida = false;
                        bool salida2 = false;
                        bool salida3 = true;
                        while (salida == true)
                        {
                            /*validar datos antes de mandarlos*/
                            String traer2 = "SELECT victorias, nicknameJugador FROM PartidaXtreme WHERE victorias=@victorias AND nicknameJugador=@nicknameJugador";
                            SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                            traendo2.Parameters.AddWithValue("@victorias", contadorVictorias);
                            traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                            traendo2.ExecuteNonQuery();
                            SqlDataReader validacion2 = traendo2.ExecuteReader();
                            if (validacion2.Read())
                            {
                                contadorVictorias = contadorVictorias + 1;
                            }
                            else if (!validacion2.Read())
                            {
                                salida = false;
                            }
                        }
                        while (salida2 == true)
                        {
                            /*validar datos antes de mandarlos*/
                            String traer2 = "SELECT derrotas, nicknameJugador FROM PartidaXtreme WHERE derrotas=@derrotas AND nicknameJugador=@nicknameJugador";
                            SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                            traendo2.Parameters.AddWithValue("@derrotas", contadorDerrotas);
                            traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                            traendo2.ExecuteNonQuery();
                            SqlDataReader validacion2 = traendo2.ExecuteReader();
                            if (validacion2.Read())
                            {
                                contadorDerrotas = contadorDerrotas + 1;
                            }

                            else if (!validacion2.Read())
                            {
                                salida2 = false;
                            }
                        }
                        while (salida3 == true)
                        {
                            /*validar datos antes de mandarlos*/
                            String traer2 = "SELECT empates, nicknameJugador FROM PartidaXtreme WHERE empates=@empates AND nicknameJugador=@nicknameJugador";
                            SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                            traendo2.Parameters.AddWithValue("@empates", contadorEmpates);
                            traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                            traendo2.ExecuteNonQuery();
                            SqlDataReader validacion2 = traendo2.ExecuteReader();
                            if (validacion2.Read())
                            {
                                contadorEmpates = contadorEmpates + 1;
                            }
                            else if (!validacion2.Read())
                            {
                                salida3 = false;
                            }

                        }
                        /*Envio Datos*/
                        string mandar = "INSERT INTO PartidaXtreme (fichas, nicknameJugador, empates, tiempo, tipoPartida, modalidad) VALUES (@fichas, @nicknameJugador, @empates, @tiempo, @tipoPartida, @modalidad)";
                        SqlCommand mandando = new SqlCommand(mandar, conectar.Leer());
                        mandando.Parameters.AddWithValue("@fichas", contadorJug1);
                        mandando.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                        mandando.Parameters.AddWithValue("@empates", contadorEmpates);
                        mandando.Parameters.AddWithValue("@tiempo", cronometromandar);
                        mandando.Parameters.AddWithValue("@tipoPartida", texto);
                        mandando.Parameters.AddWithValue("@modalidad", modalidad);
                        mandando.ExecuteNonQuery();
                    }
                }
                /*Tablero No lleno*/
                if (validacionTerminar == true)
                {
                    string cronometromandar = "";
                    if ((contadorJug1 > contadorJug2 && ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text && PaginaPrincipal.ModalidadInversa == false) || (contadorJug2 > contadorJug1 && ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text && PaginaPrincipal.ModalidadInversa == false))
                    {
                        if (PaginaPrincipal.ModalidadInversa == false)
                        {
                            if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text)
                            {
                                cronometromandar = cronometroMinutos.ToString() + ":" + cronometro.ToString();
                            }
                            if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text)
                            {
                                cronometromandar = cronometroMinutos2.ToString() + ":" + cronometro2.ToString();
                            }
                            int contadorVictorias = 1;
                            int contadorDerrotas = 1;
                            int contadorEmpates = 1;
                            validacionRegresar = true;
                            bool salida = true;
                            bool salida2 = false;
                            bool salida3 = false;
                            while (salida == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT victorias, nicknameJugador FROM PartidaXtreme WHERE victorias=@victorias AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@victorias", contadorVictorias);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorVictorias = contadorVictorias + 1;
                                }
                                else if (!validacion2.Read())
                                {
                                    salida = false;
                                }
                            }
                            while (salida2 == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT derrotas, nicknameJugador FROM PartidaXtreme WHERE derrotas=@derrotas AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@derrotas", contadorDerrotas);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorDerrotas = contadorDerrotas + 1;
                                }

                                else if (!validacion2.Read())
                                {
                                    salida2 = false;
                                }
                            }
                            while (salida3 == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT empates, nicknameJugador FROM PartidaXtreme WHERE empates=@empates AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@empates", contadorEmpates);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorEmpates = contadorEmpates + 1;
                                }
                                else if (!validacion2.Read())
                                {
                                    salida3 = false;
                                }

                            }
                            /*Envio Datos*/
                            string mandar = "INSERT INTO PartidaXtreme (fichas, nicknameJugador, empates, tiempo, tipoPartida, modalidad) VALUES (@fichas, @nicknameJugador, @empates, @tiempo, @tipoPartida, @modalidad)";
                            SqlCommand mandando = new SqlCommand(mandar, conectar.Leer());
                            mandando.Parameters.AddWithValue("@fichas", contadorJug1);
                            mandando.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                            mandando.Parameters.AddWithValue("@empates", contadorEmpates);
                            mandando.Parameters.AddWithValue("@tiempo", cronometromandar);
                            mandando.Parameters.AddWithValue("@tipoPartida", texto);
                            mandando.Parameters.AddWithValue("@modalidad", modalidad);
                            mandando.ExecuteNonQuery();

                        }
                    }
                    if ((contadorJug1 < contadorJug2 && ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text && PaginaPrincipal.ModalidadInversa == false) || (contadorJug2 < contadorJug1 && ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text && PaginaPrincipal.ModalidadInversa == false))
                    {

                        if (PaginaPrincipal.ModalidadInversa == false)
                        {
                            if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text)
                            {
                                cronometromandar = cronometroMinutos.ToString() + ":" + cronometro.ToString();
                            }
                            if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text)
                            {
                                cronometromandar = cronometroMinutos2.ToString() + ":" + cronometro2.ToString();
                            }
                            int contadorVictorias = 1;
                            int contadorDerrotas = 1;
                            int contadorEmpates = 1;
                            validacionRegresar = true;
                            bool salida = false;
                            bool salida2 = true;
                            bool salida3 = false;
                            while (salida == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT victorias, nicknameJugador FROM PartidaXtreme WHERE victorias=@victorias AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@victorias", contadorVictorias);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorVictorias = contadorVictorias + 1;
                                }
                                else if (!validacion2.Read())
                                {
                                    salida = false;
                                }
                            }
                            while (salida2 == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT derrotas, nicknameJugador FROM PartidaXtreme WHERE derrotas=@derrotas AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@derrotas", contadorDerrotas);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorDerrotas = contadorDerrotas + 1;
                                }

                                else if (!validacion2.Read())
                                {
                                    salida2 = false;
                                }
                            }
                            while (salida3 == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT empates, nicknameJugador FROM PartidaXtreme WHERE empates=@empates AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@empates", contadorEmpates);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorEmpates = contadorEmpates + 1;
                                }
                                else if (!validacion2.Read())
                                {
                                    salida3 = false;
                                }

                            }
                            /*Envio Datos*/
                            string mandar = "INSERT INTO PartidaXtreme (fichas, nicknameJugador, empates, tiempo, tipoPartida, modalidad) VALUES (@fichas, @nicknameJugador, @empates, @tiempo, @tipoPartida, @modalidad)";
                            SqlCommand mandando = new SqlCommand(mandar, conectar.Leer());
                            mandando.Parameters.AddWithValue("@fichas", contadorJug1);
                            mandando.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                            mandando.Parameters.AddWithValue("@empates", contadorEmpates);
                            mandando.Parameters.AddWithValue("@tiempo", cronometromandar);
                            mandando.Parameters.AddWithValue("@tipoPartida", texto);
                            mandando.Parameters.AddWithValue("@modalidad", modalidad);
                            mandando.ExecuteNonQuery();

                        }
                    }
                    if (contadorJug1 == contadorJug2)
                    {
                        if (PaginaPrincipal.ModalidadInversa == true)
                        {
                            modalidad = "Inversa";
                        }
                        if (PaginaPrincipal.ModalidadInversa == false)
                        {
                            modalidad = "Normal";
                        }
                        if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text)
                        {
                            cronometromandar = cronometroMinutos.ToString() + ":" + cronometro.ToString();
                        }
                        if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text)
                        {
                            cronometromandar = cronometroMinutos2.ToString() + ":" + cronometro2.ToString();
                        }
                        int contadorVictorias = 1;
                        int contadorDerrotas = 1;
                        int contadorEmpates = 1;
                        validacionRegresar = true;
                        bool salida = false;
                        bool salida2 = false;
                        bool salida3 = true;
                        while (salida == true)
                        {
                            /*validar datos antes de mandarlos*/
                            String traer2 = "SELECT victorias, nicknameJugador FROM PartidaXtreme WHERE victorias=@victorias AND nicknameJugador=@nicknameJugador";
                            SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                            traendo2.Parameters.AddWithValue("@victorias", contadorVictorias);
                            traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                            traendo2.ExecuteNonQuery();
                            SqlDataReader validacion2 = traendo2.ExecuteReader();
                            if (validacion2.Read())
                            {
                                contadorVictorias = contadorVictorias + 1;
                            }
                            else if (!validacion2.Read())
                            {
                                salida = false;
                            }
                        }
                        while (salida2 == true)
                        {
                            /*validar datos antes de mandarlos*/
                            String traer2 = "SELECT derrotas, nicknameJugador FROM PartidaXtreme WHERE derrotas=@derrotas AND nicknameJugador=@nicknameJugador";
                            SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                            traendo2.Parameters.AddWithValue("@derrotas", contadorDerrotas);
                            traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                            traendo2.ExecuteNonQuery();
                            SqlDataReader validacion2 = traendo2.ExecuteReader();
                            if (validacion2.Read())
                            {
                                contadorDerrotas = contadorDerrotas + 1;
                            }

                            else if (!validacion2.Read())
                            {
                                salida2 = false;
                            }
                        }
                        while (salida3 == true)
                        {
                            /*validar datos antes de mandarlos*/
                            String traer2 = "SELECT empates, nicknameJugador FROM PartidaXtreme WHERE empates=@empates AND nicknameJugador=@nicknameJugador";
                            SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                            traendo2.Parameters.AddWithValue("@empates", contadorEmpates);
                            traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                            traendo2.ExecuteNonQuery();
                            SqlDataReader validacion2 = traendo2.ExecuteReader();
                            if (validacion2.Read())
                            {
                                contadorEmpates = contadorEmpates + 1;
                            }
                            else if (!validacion2.Read())
                            {
                                salida3 = false;
                            }

                        }
                        /*Envio Datos*/
                        string mandar = "INSERT INTO PartidaXtreme (fichas, nicknameJugador, empates, tiempo, tipoPartida, modalidad) VALUES (@fichas, @nicknameJugador, @empates, @tiempo, @tipoPartida, @modalidad)";
                        SqlCommand mandando = new SqlCommand(mandar, conectar.Leer());
                        mandando.Parameters.AddWithValue("@fichas", contadorJug1);
                        mandando.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                        mandando.Parameters.AddWithValue("@empates", contadorEmpates);
                        mandando.Parameters.AddWithValue("@tiempo", cronometromandar);
                        mandando.Parameters.AddWithValue("@tipoPartida", texto);
                        mandando.Parameters.AddWithValue("@modalidad", modalidad);
                        mandando.ExecuteNonQuery();
                    }
                }
            }
            if (PaginaPrincipal.ModalidadInversa == false)
            {
                /*Tablero Lleno*/
                for (int i = 0; i < (filaT - 1); i++)
                {
                    for (int j = 0; j < (columnaT - 1); j++)
                    {
                        if (boton[i, j].ImageUrl != "fondotransparente.png")
                        {
                            validacionLleno = true;
                        }
                        if (boton[i, j].ImageUrl == "fondotransparente.png")
                        {
                            validacionSalir = true;
                            break;
                        }
                    }
                    if (validacionSalir == true)
                    {
                        break;
                    }
                }
                if (validacionLleno == true)
                {
                    string cronometromandar = "";
                    if ((contadorJug1 > contadorJug2 && ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text && PaginaPrincipal.ModalidadInversa == false) || (contadorJug2 > contadorJug1 && ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text && PaginaPrincipal.ModalidadInversa == false))
                    {
                        if (PaginaPrincipal.ModalidadInversa == false)
                        {
                            if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text)
                            {
                                cronometromandar = cronometroMinutos.ToString() + ":" + cronometro.ToString();
                            }
                            if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text)
                            {
                                cronometromandar = cronometroMinutos2.ToString() + ":" + cronometro2.ToString();
                            }
                            int contadorVictorias = 1;
                            int contadorDerrotas = 1;
                            int contadorEmpates = 1;
                            validacionRegresar = true;
                            bool salida = true;
                            bool salida2 = false;
                            bool salida3 = false;
                            while (salida == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT victorias, nicknameJugador FROM PartidaXtreme WHERE victorias=@victorias AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@victorias", contadorVictorias);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorVictorias = contadorVictorias + 1;
                                }
                                else if (!validacion2.Read())
                                {
                                    salida = false;
                                }
                            }
                            while (salida2 == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT derrotas, nicknameJugador FROM PartidaXtreme WHERE derrotas=@derrotas AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@derrotas", contadorDerrotas);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorDerrotas = contadorDerrotas + 1;
                                }

                                else if (!validacion2.Read())
                                {
                                    salida2 = false;
                                }
                            }
                            while (salida3 == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT empates, nicknameJugador FROM PartidaXtreme WHERE empates=@empates AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@empates", contadorEmpates);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorEmpates = contadorEmpates + 1;
                                }
                                else if (!validacion2.Read())
                                {
                                    salida3 = false;
                                }

                            }
                            /*Envio Datos*/
                            string mandar = "INSERT INTO PartidaXtreme (fichas, nicknameJugador, empates, tiempo, tipoPartida, modalidad) VALUES (@fichas, @nicknameJugador, @empates, @tiempo, @tipoPartida, @modalidad)";
                            SqlCommand mandando = new SqlCommand(mandar, conectar.Leer());
                            mandando.Parameters.AddWithValue("@fichas", contadorJug1);
                            mandando.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                            mandando.Parameters.AddWithValue("@empates", contadorEmpates);
                            mandando.Parameters.AddWithValue("@tiempo", cronometromandar);
                            mandando.Parameters.AddWithValue("@tipoPartida", texto);
                            mandando.Parameters.AddWithValue("@modalidad", modalidad);
                            mandando.ExecuteNonQuery();

                        }
                    }
                    if ((contadorJug1 < contadorJug2 && ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text && PaginaPrincipal.ModalidadInversa == false) || (contadorJug2 < contadorJug1 && ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text && PaginaPrincipal.ModalidadInversa == false))
                    {

                        if (PaginaPrincipal.ModalidadInversa == false)
                        {
                            if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text)
                            {
                                cronometromandar = cronometroMinutos.ToString() + ":" + cronometro.ToString();
                            }
                            if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text)
                            {
                                cronometromandar = cronometroMinutos2.ToString() + ":" + cronometro2.ToString();
                            }
                            int contadorVictorias = 1;
                            int contadorDerrotas = 1;
                            int contadorEmpates = 1;
                            validacionRegresar = true;
                            bool salida = false;
                            bool salida2 = true;
                            bool salida3 = false;
                            while (salida == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT victorias, nicknameJugador FROM PartidaXtreme WHERE victorias=@victorias AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@victorias", contadorVictorias);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorVictorias = contadorVictorias + 1;
                                }
                                else if (!validacion2.Read())
                                {
                                    salida = false;
                                }
                            }
                            while (salida2 == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT derrotas, nicknameJugador FROM PartidaXtreme WHERE derrotas=@derrotas AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@derrotas", contadorDerrotas);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorDerrotas = contadorDerrotas + 1;
                                }

                                else if (!validacion2.Read())
                                {
                                    salida2 = false;
                                }
                            }
                            while (salida3 == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT empates, nicknameJugador FROM PartidaXtreme WHERE empates=@empates AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@empates", contadorEmpates);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorEmpates = contadorEmpates + 1;
                                }
                                else if (!validacion2.Read())
                                {
                                    salida3 = false;
                                }

                            }
                            /*Envio Datos*/
                            string mandar = "INSERT INTO PartidaXtreme (fichas, nicknameJugador, empates, tiempo, tipoPartida, modalidad) VALUES (@fichas, @nicknameJugador, @empates, @tiempo, @tipoPartida, @modalidad)";
                            SqlCommand mandando = new SqlCommand(mandar, conectar.Leer());
                            mandando.Parameters.AddWithValue("@fichas", contadorJug1);
                            mandando.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                            mandando.Parameters.AddWithValue("@empates", contadorEmpates);
                            mandando.Parameters.AddWithValue("@tiempo", cronometromandar);
                            mandando.Parameters.AddWithValue("@tipoPartida", texto);
                            mandando.Parameters.AddWithValue("@modalidad", modalidad);
                            mandando.ExecuteNonQuery();

                        }
                    }
                    if (contadorJug1 == contadorJug2)
                    {
                        if (PaginaPrincipal.ModalidadInversa == true)
                        {
                            modalidad = "Inversa";
                        }
                        if (PaginaPrincipal.ModalidadInversa == false)
                        {
                            modalidad = "Normal";
                        }
                        if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text)
                        {
                            cronometromandar = cronometroMinutos.ToString() + ":" + cronometro.ToString();
                        }
                        if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text)
                        {
                            cronometromandar = cronometroMinutos2.ToString() + ":" + cronometro2.ToString();
                        }
                        int contadorVictorias = 1;
                        int contadorDerrotas = 1;
                        int contadorEmpates = 1;
                        validacionRegresar = true;
                        bool salida = false;
                        bool salida2 = false;
                        bool salida3 = true;
                        while (salida == true)
                        {
                            /*validar datos antes de mandarlos*/
                            String traer2 = "SELECT victorias, nicknameJugador FROM PartidaXtreme WHERE victorias=@victorias AND nicknameJugador=@nicknameJugador";
                            SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                            traendo2.Parameters.AddWithValue("@victorias", contadorVictorias);
                            traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                            traendo2.ExecuteNonQuery();
                            SqlDataReader validacion2 = traendo2.ExecuteReader();
                            if (validacion2.Read())
                            {
                                contadorVictorias = contadorVictorias + 1;
                            }
                            else if (!validacion2.Read())
                            {
                                salida = false;
                            }
                        }
                        while (salida2 == true)
                        {
                            /*validar datos antes de mandarlos*/
                            String traer2 = "SELECT derrotas, nicknameJugador FROM PartidaXtreme WHERE derrotas=@derrotas AND nicknameJugador=@nicknameJugador";
                            SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                            traendo2.Parameters.AddWithValue("@derrotas", contadorDerrotas);
                            traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                            traendo2.ExecuteNonQuery();
                            SqlDataReader validacion2 = traendo2.ExecuteReader();
                            if (validacion2.Read())
                            {
                                contadorDerrotas = contadorDerrotas + 1;
                            }

                            else if (!validacion2.Read())
                            {
                                salida2 = false;
                            }
                        }
                        while (salida3 == true)
                        {
                            /*validar datos antes de mandarlos*/
                            String traer2 = "SELECT empates, nicknameJugador FROM PartidaXtreme WHERE empates=@empates AND nicknameJugador=@nicknameJugador";
                            SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                            traendo2.Parameters.AddWithValue("@empates", contadorEmpates);
                            traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                            traendo2.ExecuteNonQuery();
                            SqlDataReader validacion2 = traendo2.ExecuteReader();
                            if (validacion2.Read())
                            {
                                contadorEmpates = contadorEmpates + 1;
                            }
                            else if (!validacion2.Read())
                            {
                                salida3 = false;
                            }

                        }
                        /*Envio Datos*/
                        string mandar = "INSERT INTO PartidaXtreme (fichas, nicknameJugador, empates, tiempo, tipoPartida, modalidad) VALUES (@fichas, @nicknameJugador, @empates, @tiempo, @tipoPartida, @modalidad)";
                        SqlCommand mandando = new SqlCommand(mandar, conectar.Leer());
                        mandando.Parameters.AddWithValue("@fichas", contadorJug1);
                        mandando.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                        mandando.Parameters.AddWithValue("@empates", contadorEmpates);
                        mandando.Parameters.AddWithValue("@tiempo", cronometromandar);
                        mandando.Parameters.AddWithValue("@tipoPartida", texto);
                        mandando.Parameters.AddWithValue("@modalidad", modalidad);
                        mandando.ExecuteNonQuery();
                    }
                }
                /*Tablero No lleno*/
                if (validacionTerminar == true)
                {
                    string cronometromandar = "";
                    if ((contadorJug1 > contadorJug2 && ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text && PaginaPrincipal.ModalidadInversa == false) || (contadorJug2 > contadorJug1 && ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text && PaginaPrincipal.ModalidadInversa == false))
                    {
                        if (PaginaPrincipal.ModalidadInversa == false)
                        {
                            if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text)
                            {
                                cronometromandar = cronometroMinutos.ToString() + ":" + cronometro.ToString();
                            }
                            if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text)
                            {
                                cronometromandar = cronometroMinutos2.ToString() + ":" + cronometro2.ToString();
                            }
                            int contadorVictorias = 1;
                            int contadorDerrotas = 1;
                            int contadorEmpates = 1;
                            validacionRegresar = true;
                            bool salida = true;
                            bool salida2 = false;
                            bool salida3 = false;
                            while (salida == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT victorias, nicknameJugador FROM PartidaXtreme WHERE victorias=@victorias AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@victorias", contadorVictorias);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorVictorias = contadorVictorias + 1;
                                }
                                else if (!validacion2.Read())
                                {
                                    salida = false;
                                }
                            }
                            while (salida2 == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT derrotas, nicknameJugador FROM PartidaXtreme WHERE derrotas=@derrotas AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@derrotas", contadorDerrotas);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorDerrotas = contadorDerrotas + 1;
                                }

                                else if (!validacion2.Read())
                                {
                                    salida2 = false;
                                }
                            }
                            while (salida3 == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT empates, nicknameJugador FROM PartidaXtreme WHERE empates=@empates AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@empates", contadorEmpates);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorEmpates = contadorEmpates + 1;
                                }
                                else if (!validacion2.Read())
                                {
                                    salida3 = false;
                                }

                            }
                            /*Envio Datos*/
                            string mandar = "INSERT INTO PartidaXtreme (fichas, nicknameJugador, empates, tiempo, tipoPartida, modalidad) VALUES (@fichas, @nicknameJugador, @empates, @tiempo, @tipoPartida, @modalidad)";
                            SqlCommand mandando = new SqlCommand(mandar, conectar.Leer());
                            mandando.Parameters.AddWithValue("@fichas", contadorJug1);
                            mandando.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                            mandando.Parameters.AddWithValue("@empates", contadorEmpates);
                            mandando.Parameters.AddWithValue("@tiempo", cronometromandar);
                            mandando.Parameters.AddWithValue("@tipoPartida", texto);
                            mandando.Parameters.AddWithValue("@modalidad", modalidad);
                            mandando.ExecuteNonQuery();

                        }
                    }
                    if ((contadorJug1 < contadorJug2 && ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text && PaginaPrincipal.ModalidadInversa == false) || (contadorJug2 < contadorJug1 && ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text && PaginaPrincipal.ModalidadInversa == false))
                    {

                        if (PaginaPrincipal.ModalidadInversa == false)
                        {
                            if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text)
                            {
                                cronometromandar = cronometroMinutos.ToString() + ":" + cronometro.ToString();
                            }
                            if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text)
                            {
                                cronometromandar = cronometroMinutos2.ToString() + ":" + cronometro2.ToString();
                            }
                            int contadorVictorias = 1;
                            int contadorDerrotas = 1;
                            int contadorEmpates = 1;
                            validacionRegresar = true;
                            bool salida = false;
                            bool salida2 = true;
                            bool salida3 = false;
                            while (salida == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT victorias, nicknameJugador FROM PartidaXtreme WHERE victorias=@victorias AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@victorias", contadorVictorias);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorVictorias = contadorVictorias + 1;
                                }
                                else if (!validacion2.Read())
                                {
                                    salida = false;
                                }
                            }
                            while (salida2 == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT derrotas, nicknameJugador FROM PartidaXtreme WHERE derrotas=@derrotas AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@derrotas", contadorDerrotas);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorDerrotas = contadorDerrotas + 1;
                                }

                                else if (!validacion2.Read())
                                {
                                    salida2 = false;
                                }
                            }
                            while (salida3 == true)
                            {
                                /*validar datos antes de mandarlos*/
                                String traer2 = "SELECT empates, nicknameJugador FROM PartidaXtreme WHERE empates=@empates AND nicknameJugador=@nicknameJugador";
                                SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                                traendo2.Parameters.AddWithValue("@empates", contadorEmpates);
                                traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                                traendo2.ExecuteNonQuery();
                                SqlDataReader validacion2 = traendo2.ExecuteReader();
                                if (validacion2.Read())
                                {
                                    contadorEmpates = contadorEmpates + 1;
                                }
                                else if (!validacion2.Read())
                                {
                                    salida3 = false;
                                }

                            }
                            /*Envio Datos*/
                            string mandar = "INSERT INTO PartidaXtreme (fichas, nicknameJugador, empates, tiempo, tipoPartida, modalidad) VALUES (@fichas, @nicknameJugador, @empates, @tiempo, @tipoPartida, @modalidad)";
                            SqlCommand mandando = new SqlCommand(mandar, conectar.Leer());
                            mandando.Parameters.AddWithValue("@fichas", contadorJug1);
                            mandando.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                            mandando.Parameters.AddWithValue("@empates", contadorEmpates);
                            mandando.Parameters.AddWithValue("@tiempo", cronometromandar);
                            mandando.Parameters.AddWithValue("@tipoPartida", texto);
                            mandando.Parameters.AddWithValue("@modalidad", modalidad);
                            mandando.ExecuteNonQuery();

                        }
                    }
                    if (contadorJug1 == contadorJug2)
                    {
                        if (PaginaPrincipal.ModalidadInversa == true)
                        {
                            modalidad = "Inversa";
                        }
                        if (PaginaPrincipal.ModalidadInversa == false)
                        {
                            modalidad = "Normal";
                        }
                        if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox3.Text)
                        {
                            cronometromandar = cronometroMinutos.ToString() + ":" + cronometro.ToString();
                        }
                        if (ProyectoEntregable2.Login.UsuarioLogeado == TextBox4.Text)
                        {
                            cronometromandar = cronometroMinutos2.ToString() + ":" + cronometro2.ToString();
                        }
                        int contadorVictorias = 1;
                        int contadorDerrotas = 1;
                        int contadorEmpates = 1;
                        validacionRegresar = true;
                        bool salida = false;
                        bool salida2 = false;
                        bool salida3 = true;
                        while (salida == true)
                        {
                            /*validar datos antes de mandarlos*/
                            String traer2 = "SELECT victorias, nicknameJugador FROM PartidaXtreme WHERE victorias=@victorias AND nicknameJugador=@nicknameJugador";
                            SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                            traendo2.Parameters.AddWithValue("@victorias", contadorVictorias);
                            traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                            traendo2.ExecuteNonQuery();
                            SqlDataReader validacion2 = traendo2.ExecuteReader();
                            if (validacion2.Read())
                            {
                                contadorVictorias = contadorVictorias + 1;
                            }
                            else if (!validacion2.Read())
                            {
                                salida = false;
                            }
                        }
                        while (salida2 == true)
                        {
                            /*validar datos antes de mandarlos*/
                            String traer2 = "SELECT derrotas, nicknameJugador FROM PartidaXtreme WHERE derrotas=@derrotas AND nicknameJugador=@nicknameJugador";
                            SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                            traendo2.Parameters.AddWithValue("@derrotas", contadorDerrotas);
                            traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                            traendo2.ExecuteNonQuery();
                            SqlDataReader validacion2 = traendo2.ExecuteReader();
                            if (validacion2.Read())
                            {
                                contadorDerrotas = contadorDerrotas + 1;
                            }

                            else if (!validacion2.Read())
                            {
                                salida2 = false;
                            }
                        }
                        while (salida3 == true)
                        {
                            /*validar datos antes de mandarlos*/
                            String traer2 = "SELECT empates, nicknameJugador FROM PartidaXtreme WHERE empates=@empates AND nicknameJugador=@nicknameJugador";
                            SqlCommand traendo2 = new SqlCommand(traer2, conectar.Leer());
                            traendo2.Parameters.AddWithValue("@empates", contadorEmpates);
                            traendo2.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                            traendo2.ExecuteNonQuery();
                            SqlDataReader validacion2 = traendo2.ExecuteReader();
                            if (validacion2.Read())
                            {
                                contadorEmpates = contadorEmpates + 1;
                            }
                            else if (!validacion2.Read())
                            {
                                salida3 = false;
                            }

                        }
                        /*Envio Datos*/
                        string mandar = "INSERT INTO PartidaXtreme (fichas, nicknameJugador, empates, tiempo, tipoPartida, modalidad) VALUES (@fichas, @nicknameJugador, @empates, @tiempo, @tipoPartida, @modalidad)";
                        SqlCommand mandando = new SqlCommand(mandar, conectar.Leer());
                        mandando.Parameters.AddWithValue("@fichas", contadorJug1);
                        mandando.Parameters.AddWithValue("@nicknameJugador", ProyectoEntregable2.Login.UsuarioLogeado);
                        mandando.Parameters.AddWithValue("@empates", contadorEmpates);
                        mandando.Parameters.AddWithValue("@tiempo", cronometromandar);
                        mandando.Parameters.AddWithValue("@tipoPartida", texto);
                        mandando.Parameters.AddWithValue("@modalidad", modalidad);
                        mandando.ExecuteNonQuery();
                    }
                }
            }
            if (validacionRegresar == true)
            {
                validacionColor1 = false;
                paso = false;
                validacionTerminar = false;
                validacionColor2 = false;
                personlisto = false;
                colorGlobal = "";
                ultimo1 = "";
                ultimo2 = "";
                filallevar = 0;
                columnallevar = 0;
                contadorJug1 = 0;
                contadorJug2 = 0;
                actualfila = 0;
                actualcolu = 0;
                filaT = 0;
                columnaT = 0;
                idUsuarioCargado = "";
                cronometro = 0;
                cronometroMinutos = 0;
                cronometro2 = 0;
                cronometroMinutos2 = 0;
                literal = "";
                validacion = false;
                valcr1 = false;
                valcro2 = false;
                YaEntro = true;
                Response.Redirect("PaginaPrincipal.aspx");
                return;
            }
        }

        protected void Maquina()
        {
            bool jug1 = false;
            bool jug2 = false;
            for (int i = 0; i < PaginaPrincipal.colores1.Length; i++)
            {
                if (colorGlobal == PaginaPrincipal.colores1[i])
                {
                    jug1 = true;
                }
            }
            for (int i = 0; i < PaginaPrincipal.colores2.Length; i++)
            {
                if (colorGlobal == PaginaPrincipal.colores2[i])
                {
                    jug2 = true;
                }
            }
            if (jug1 == true)
            {
                for (int i = 1; i < (filaT - 1); i++)
                {
                    for (int j = 1; j < (columnaT - 1); j++)
                    {

                        if ((boton[i, j].ImageUrl == "posiblejug1.png"))
                        {
                            boton[i, j].ImageUrl = colorGlobal + ".png";
                            colorSiguiente();
                            if (personlisto == true)
                            {
                                validarTiros();
                                pasarTurno();
                            }
                        }
                    }
                }
            }
            if (jug2 == true)
            {
                for (int i = 1; i < (filaT - 1); i++)
                {
                    for (int j = 1; j < (columnaT - 1); j++)
                    {

                        if ((boton[i, j].ImageUrl == "posiblejug2.png"))
                        {
                            boton[i, j].ImageUrl = colorGlobal + ".png";
                            colorSiguiente();
                            if (personlisto == true)
                            {
                                validarTiros();
                                pasarTurno();
                            }
                        }
                    }
                }
            }
        }
    }
}