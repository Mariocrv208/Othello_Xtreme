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
            <asp:ImageButton ID="Button178" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button386" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button387" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button388" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button389" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button390" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button391" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button392" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
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
            <asp:ImageButton ID="Button393" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button394" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button395" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button396" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button397" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button398" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button399" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button400" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
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
            <asp:ImageButton ID="Button401" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button402" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button403" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button404" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button405" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button406" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button407" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button408" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
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
            <asp:ImageButton ID="Button409" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button410" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button411" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button294" runat="server" Width="80px" Height="80px" BackColor="#66FF99" Text="." ImageUrl="Blanca.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button293" runat="server" Width="80px" Height="80px" BackColor="#66FF99" Text="." ImageUrl="negra.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button412" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button413" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button414" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
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
            <asp:ImageButton ID="Button415" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button416" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button417" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button301" runat="server" Width="80px" Height="80px" BackColor="#66FF99" Text="." ImageUrl="negra.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button302" runat="server" Width="80px" Height="80px" BackColor="#66FF99" Text="." ImageUrl="Blanca.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button418" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button419" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button420" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
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
            <asp:ImageButton ID="Button421" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button422" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button423" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button424" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button425" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button426" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button427" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button428" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
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
            <asp:ImageButton ID="Button429" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button430" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button431" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button432" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button433" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button434" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button435" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button436" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
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
            <asp:ImageButton ID="Button437" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button438" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button439" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button440" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button441" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button442" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button443" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
                                </td>
                                <td>
            <asp:ImageButton ID="Button444" runat="server" Width="80px" Height="80px"  BackColor="#66FF99" ImageUrl="fondotransparente.png" />
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
            <asp:Button ID="Button3" runat="server" Height="65px" Text="Guardar Partida" Width="234px" BackColor="#CC0066" />
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
