<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PantallaJuego.aspx.cs" Inherits="ProyectoEntregable2.PantallaJuego" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Othello-Juego</title>
    <link rel="icon" href="img/I1.jpeg" />
    <style type="text/css">
        #nombre{
            background-color: purple;
        }
        body{
            background-image:url(Fondo.png);
            background-size:cover;
        }
        thead{
            background-color:purple;
        }
        #end{
            background-color:crimson;
        }
        .auto-style1 {
            width: 89%;
            height: 764px;
        }
        .auto-style2 {
            width: 854px;
            height: 868px;
        }
        #tablero{
            background-color:black;
        }
        #izquierdoarriba{
            border-top-left-radius: 30px 30px;
        }
        #derechaarriba{
            border-top-right-radius: 30px 30px;
        }
        #Izquierdoabajo{
            border-bottom-left-radius: 30px 30px;
        }
        #derechaAbajo{
            border-bottom-right-radius: 30px 30px;
        }
    </style>
</head>
<body id="body">
    <form id="Login" runat="server">
      <center>
        <div id="nombre">
              <h3 style="height: 31px; width: 1399px">&nbsp; iGamesGT</h3>
          </div>
          <br />
          <h1>Menu Principal</h1>
&nbsp;<br />
                        <div id="tablero" class="auto-style2">
                        <table class="auto-style1">
                            <tr>
                                <td>
            <asp:Button ID="izquierdoarriba" Text="Othello" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:Button ID="Button168" Text="A" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:Button ID="Button330" Text="B" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:Button ID="Button331" Text="C" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:Button ID="Button332" Text="D" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:Button ID="Button333" Text="E" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:Button ID="Button334" Text="F" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:Button ID="Button335" Text="G" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:Button ID="Button336" Text="H" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:Button ID="derechaarriba" Text="Othello" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                            </tr>
                            <tr>
                                <td>
            <asp:Button ID="Button368" Text="1" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:ImageButton ID="A1" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="Button178_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="B1" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="B1_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="C1" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="C1_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="D1" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="D1_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="E1" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="E1_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="F1" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="F1_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="G1" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="G1_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="H1" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="H1_Click" />
                                </td>
                                <td>
            <asp:Button ID="Button338" Text="1" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                            </tr>
                            <tr>
                                <td>
            <asp:Button ID="Button369" Text="2" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:ImageButton ID="A2" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="A2_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="B2" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="B2_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="C2" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="C2_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="D2" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="D2_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="E2" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="E2_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="F2" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="F2_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="G2" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="G2_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="H2" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="H2_Click" />
                                </td>
                                <td>
            <asp:Button ID="Button339" Text="2" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                            </tr>
                            <tr>
                                <td>
            <asp:Button ID="Button370" Text="3" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:ImageButton ID="A3" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="A3_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="B3" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="B3_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="C3" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="C3_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="D3" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="D3_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="E3" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="E3_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="F3" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="F3_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="G3" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="G3_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="H3" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="H3_Click" />
                                </td>
                                <td>
            <asp:Button ID="Button340" Text="3" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                            </tr>
                            <tr>
                                <td>
            <asp:Button ID="Button371" Text="4" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:ImageButton ID="A4" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="A4_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="B4" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="B4_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="C4" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="C4_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="D4" runat="server" Width="80px" Height="80px" BackColor="#66FF99" Text="." ImageUrl="Blanca.png" OnClick="D4_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="E4" runat="server" Width="80px" Height="80px" BackColor="#66FF99" Text="." ImageUrl="negra.png" OnClick="E4_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="F4" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="F4_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="G4" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="G4_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="H4" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="H4_Click" />
                                </td>
                                <td>
            <asp:Button ID="Button341" Text="4" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                            </tr>
                            <tr>
                                <td>
            <asp:Button ID="Button372" Text="5" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:ImageButton ID="A5" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="A5_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="B5" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="B5_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="C5" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="C5_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="D5" runat="server" Width="80px" Height="80px" BackColor="#66FF99" Text="." ImageUrl="negra.png" OnClick="D5_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="E5" runat="server" Width="80px" Height="80px" BackColor="#66FF99" Text="." ImageUrl="Blanca.png" OnClick="E5_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="F5" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="F5_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="G5" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="G5_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="H5" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="H5_Click" />
                                </td>
                                <td>
            <asp:Button ID="Button342" Text="5" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                            </tr>
                            <tr>
                                <td>
            <asp:Button ID="Button373" Text="6" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:ImageButton ID="A6" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="A6_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="B6" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="B6_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="C6" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="C6_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="D6" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="D6_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="E6" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="E6_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="F6" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="F6_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="G6" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="G6_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="H6" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="H6_Click" />
                                </td>
                                <td>
            <asp:Button ID="Button362" Text="6" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                            </tr>
                            <tr>
                                <td>
            <asp:Button ID="Button374" Text="7" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:ImageButton ID="A7" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="A7_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="B7" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="B7_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="C7" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="C7_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="D7" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="D7_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="E7" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="E7_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="F7" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="F7_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="G7" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="G7_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="H7" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="H7_Click" />
                                </td>
                                <td>
            <asp:Button ID="Button363" Text="7" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                            </tr>
                            <tr>
                                <td>
            <asp:Button ID="Button375" Text="8" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:ImageButton ID="A8" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="A8_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="B8" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="B8_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="C8" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="C8_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="D8" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="D8_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="E8" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="E8_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="F8" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="F8_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="G8" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="G8_Click" />
                                </td>
                                <td>
            <asp:ImageButton ID="H8" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" OnClick="H8_Click" />
                                </td>
                                <td>
            <asp:Button ID="Button364" Text="8" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                            </tr>
                            <tr>
                                <td>
            <asp:Button ID="Izquierdoabajo" Text="Othello" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:Button ID="Button353" Text="A" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:Button ID="Button354" Text="B" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:Button ID="Button355" Text="C" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:Button ID="Button356" Text="D" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:Button ID="Button357" Text="E" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:Button ID="Button358" Text="F" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:Button ID="Button359" Text="G" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:Button ID="Button360" Text="H" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                                <td>
            <asp:Button ID="derechaAbajo" Text="Othello" runat="server"  Width="80px" Height="80px" BackColor="#946230" />
                                </td>
                            </tr>
                        </table>
          </div>
          <br />
          <br />
          <br />
            Datos<br />
          <br />
            <br />
          Negro&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" BackColor="#FFCCCC"></asp:TextBox>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Blanco&nbsp;
          <asp:TextBox ID="TextBox2" runat="server" BackColor="#FFCCCC"></asp:TextBox>
          <br />
          <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nickname&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox3" runat="server" BackColor="#FFCCCC"></asp:TextBox>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Nickname&nbsp;
          <asp:TextBox ID="TextBox4" runat="server" BackColor="#FFCCCC"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <br />
          <br />
            Victorias&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox5" runat="server" BackColor="#FFCCCC"></asp:TextBox>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Victorias&nbsp;
          <asp:TextBox ID="TextBox6" runat="server" BackColor="#FFCCCC"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <br />
            <br />
          Derrotas&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox7" runat="server" BackColor="#FFCCCC"></asp:TextBox>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Derrotas&nbsp;
          <asp:TextBox ID="TextBox8" runat="server" BackColor="#FFCCCC"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
          <br />
          <br />
            <br />
          <br />
            <asp:Button ID="Button3" runat="server" Height="65px" Text="Guardar Partida" Width="234px" BackColor="#CC0066" OnClick="Button3_Click" />
          <br />
          <br />
          <asp:Button ID="Button376" runat="server" BackColor="#CC0066" Height="72px" OnClick="Button376_Click" Text="Regresar a menu" Width="236px" />
          <div>
              <br />
              <br />
          </div>
      </center>
    
        
    </form>
    <div id="end">
        <b/>
    <p>
        Universidad de San Carlos de Guatemala</p>
    <p>
        Mario Jose Rodriguez Vasquez - 201908338</p>
    </div>
</body>
</html>
