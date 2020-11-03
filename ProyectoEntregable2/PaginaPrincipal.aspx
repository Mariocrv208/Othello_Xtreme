<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaPrincipal.aspx.cs" Inherits="ProyectoEntregable2.PaginaPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Othello-PantallaPrincipal</title>
    <link rel="icon" href="img/I1.jpeg" />
    <style type="text/css">
        #nombre{
            background-color: purple;
        }
        body{
            background-image:url(Fondo.png);
            background-size:cover;
        }
        #end{
            background-color:crimson;
        }
    </style>
</head>
<body id="body">
    <form id="Login" runat="server">
      <center>
        <div id="nombre">
              <h3 style="height: 31px; width: 1399px">&nbsp; iGamesGT</h3>
          </div>
          </header>
          <br />
          <br />
          <br />
          <h1>Menu Principal</h1>
          <br />
          <br />
          CARGAR PARTIDA<br />
          <br />
          <asp:FileUpload ID="buscaArc" runat="server" />
          <br />
          <br />
          <br />
          <asp:Button ID="Button10" runat="server" BackColor="#CC0066" Height="63px" OnClick="Button10_Click" Text="Cargar archivo Seleccionado" Width="470px" />
          <br />
          <br />
          MAS OPCIONES<br />
          <br />
            <asp:Button ID="Button4" runat="server" Text="Partida individual" Width="470px" Height="63px" BackColor="#CC0066" OnClick="Button4_Click" />
            <br />
          <br />
          <asp:Panel ID="Panel2" runat="server" Height="405px" Visible="False">
              Ingrese el color de ficha para el jugador 1<br />
              <br />
              (negro o blanco)<br />
              <br />
              <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
              <br />
              <br />
              Tipo de partida<br />
              <asp:RadioButton ID="RadioButton5" runat="server" GroupName="Individual" Text="PartidaPersonalizada" />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:RadioButton ID="RadioButton6" runat="server" GroupName="Individual" Text="Partida Normal" />
              <br />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <br />
              <br />
              Modalidad Partida<br />
              <asp:RadioButton ID="RadioButton7" runat="server" GroupName="InversoI" Text="Modo Normal" />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:RadioButton ID="RadioButton8" runat="server" GroupName="InversoI" Text="Reto Inverso" />
              <br />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <br />
              <br />
              <asp:Button ID="Button20" runat="server" BackColor="#CC0066" Height="36px" Text="Continuar" Width="279px" OnClick="Button20_Click1" />
              <br />
              <br />
          </asp:Panel>
          <br />
            <br />
          Escoge una Opcion&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Othello Time!<br />
          <br />
            <asp:Button ID="Button5" runat="server" Text="Partida multijugador" Width="470px" Height="63px" BackColor="#CC0066" OnClick="Button5_Click" />
            <br />
          <br />
            <br />
          <asp:Panel ID="Panel1" runat="server" Height="492px" Visible="False">
              Ingrese el nombre del Jugador 2<br />
              <br />
              <asp:TextBox ID="TextBox1" runat="server" Width="246px"></asp:TextBox>
              <br />
              <br />
              Ingrese el color de ficha para el jugador 1<br />
              <br />
              (negro o blanco)<br />
              <br />
              <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
              <br />
              <br />
              Tipo de partida<br /> <br />
              <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Multijugador" Text="Partida Personalizada" />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Multijugador" Text="Partida Normal" />
              <br />
              <br />
              Modalidad Partida<br />
              <br />
              <asp:RadioButton ID="RadioButton3" runat="server" GroupName="Modalidad" Text="Modo Normal" />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:RadioButton ID="RadioButton4" runat="server" GroupName="Modalidad" Text="Reto Inverso" />
              <br />
              <br />
              <br />

              <asp:Button ID="Continuar" runat="server"  BackColor="#CC0066" Height="38px" OnClick="Button11_Click" Text="Continuar" Width="329px" />
          </asp:Panel>
          <br />

                <asp:Button ID="PartidaXtreme" class="btn-info" runat="server" BackColor="#CC0066" Height="63px" Text="Partida Xtreme" Width="470px" OnClick="PartidaXtreme_Click"></asp:Button>
          <br />
          <asp:Panel ID="Panel3" runat="server" Height="856px" Visible="False">
              Desea Cargar un partida?<br />
              <br />
              <asp:Button ID="Button21" runat="server" BackColor="#CC0066" Text="Si" OnClick="Button21_Click1" />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Button ID="Button22" runat="server" BackColor="#CC0066" Text="No" OnClick="Button22_Click" />
              <br />
              <br />
              <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
              <br />
              <br />
              <asp:TextBox ID="TextBox4" runat="server" Visible="False"></asp:TextBox>
              <br />
              <br />
              <asp:Label ID="Label2" runat="server" Text="Tipo Partida" Visible="False"></asp:Label>
              <br />
              <br />
              <asp:RadioButton ID="RadioButton9" runat="server" GroupName="TipoXtreme" Text="Partida Personalizada" Visible="False" />
              &nbsp;&nbsp;
              <asp:RadioButton ID="RadioButton10" runat="server" GroupName="TipoXtreme" Text="Partida Normal" Visible="False" />
              <br />
              <br />
              <asp:Label ID="Label3" runat="server" Text="Modalidad" Visible="False"></asp:Label>
              <br />
              <br />
              <asp:RadioButton ID="RadioButton11" runat="server" GroupName="ModalidadXtreme" Text="Reto Inverso" Visible="False" />
              &nbsp;&nbsp;
              <asp:RadioButton ID="RadioButton12" runat="server" GroupName="ModalidadXtreme" Text="Modo Normal" Visible="False" />
              <br />
              <br />
              <asp:Label ID="Label9" runat="server" Text="Dimensiones Tablero" Visible="False"></asp:Label>
              <br />
              <br />
&nbsp;
              <asp:Label ID="Label7" runat="server" Text="Filas" Visible="False"></asp:Label>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Label ID="Label8" runat="server" Text="Columnas" Visible="False"></asp:Label>
              <br />
              <br />
              <asp:DropDownList ID="DropDownList1" runat="server" Visible="False">
                  <asp:ListItem Value="6"></asp:ListItem>
                  <asp:ListItem Value="8"></asp:ListItem>
                  <asp:ListItem Value="10"></asp:ListItem>
                  <asp:ListItem Value="12"></asp:ListItem>
                  <asp:ListItem Value="14"></asp:ListItem>
                  <asp:ListItem Value="16"></asp:ListItem>
                  <asp:ListItem Value="18"></asp:ListItem>
                  <asp:ListItem Value="20"></asp:ListItem>
              </asp:DropDownList>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:DropDownList ID="DropDownList2" runat="server" Visible="False">
                  <asp:ListItem Value="6"></asp:ListItem>
                  <asp:ListItem Value="8"></asp:ListItem>
                  <asp:ListItem Value="10"></asp:ListItem>
                  <asp:ListItem Value="12"></asp:ListItem>
                  <asp:ListItem Value="14"></asp:ListItem>
                  <asp:ListItem Value="16"></asp:ListItem>
                  <asp:ListItem Value="18"></asp:ListItem>
                  <asp:ListItem Value="20"></asp:ListItem>
              </asp:DropDownList>
              <br />
              <br />
              <asp:Label ID="Label4" runat="server" Text="Seleccion de colores" Visible="False"></asp:Label>
              <br />
              <br />
              <asp:Label ID="Label5" runat="server" Text="Jugador1" Visible="False"></asp:Label>
              &nbsp;&nbsp;&nbsp;
              <asp:Label ID="Label6" runat="server" Text="Jugador2" Visible="False"></asp:Label>
              <br />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RadioButton ID="RadioButton13" runat="server" GroupName="Rojo" Text="Rojo" Visible="False" />
              &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
              <asp:RadioButton ID="RadioButton14" runat="server" GroupName="Rojo" Text="Rojo" Visible="False" />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <br />
              <asp:RadioButton ID="RadioButton15" runat="server" GroupName="Amarillo" Text="Amarillo" Visible="False" />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:RadioButton ID="RadioButton16" runat="server" GroupName="Amarillo" Text="Amarillo" Visible="False" />
              &nbsp;&nbsp;
              <br />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RadioButton ID="RadioButton17" runat="server" GroupName="Azul" Text="Azul" Visible="False" />
              &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;<asp:RadioButton ID="RadioButton18" runat="server" GroupName="Azul" Text="Azul" Visible="False" />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <br />
              &nbsp;&nbsp;
              <asp:RadioButton ID="RadioButton19" runat="server" GroupName="Anaranjado" Text="Anaranjado" Visible="False" />
&nbsp;
              <asp:RadioButton ID="RadioButton20" runat="server" GroupName="Anaranjado" Text="Anaranjado" Visible="False" />
              <br />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:RadioButton ID="RadioButton21" runat="server" GroupName="Verde" Text="Verde" Visible="False" />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:RadioButton ID="RadioButton22" runat="server" GroupName="Verde" Text="Verde" Visible="False" />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <br />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:RadioButton ID="RadioButton23" runat="server" GroupName="Violeta" Text="Violeta" Visible="False" />
              &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
              <asp:RadioButton ID="RadioButton24" runat="server" GroupName="Violeta" Text="Violeta" Visible="False" />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <br />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:RadioButton ID="RadioButton25" runat="server" GroupName="Blanco" Text="Blanco" Visible="False" />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:RadioButton ID="RadioButton26" runat="server" GroupName="Blanco" Text="Blanco" Visible="False" />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <br />
              <asp:RadioButton ID="RadioButton27" runat="server" GroupName="Negro" Text="Negro" Visible="False" />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:RadioButton ID="RadioButton28" runat="server" GroupName="Negro" Text="Negro" Visible="False" />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <br />
              &nbsp;<asp:RadioButton ID="RadioButton29" runat="server" GroupName="Celeste" Text="Celeste" Visible="False" />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:RadioButton ID="RadioButton30" runat="server" GroupName="Celeste" Text="Celeste" Visible="False" />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <br />
              <asp:RadioButton ID="RadioButton31" runat="server" GroupName="Gris" Text="Gris" Visible="False" />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
              <asp:RadioButton ID="RadioButton32" runat="server" GroupName="Gris" Text="Gris" Visible="False" />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <br />
              <br />
              <asp:Button ID="Button23" runat="server" BackColor="#CC0066" Text="Continuar" Visible="False" OnClick="Button23_Click" />
              <br />
              <br />
          </asp:Panel>
          <br />
          <br />
          <br />
          <br />
            <asp:Button ID="Button6" runat="server" Text="Torneo" Width="470px" Height="63px" BackColor="#CC0066" OnClick="Button6_Click" />
            <br />
          <br />
            <asp:Button ID="Button7" runat="server" Text="Reportes" Width="470px" Height="63px" BackColor="#CC0066" OnClick="Button7_Click" />
            <br />
          <br />
            <asp:Button ID="Button9" runat="server" Text="Salir" Width="470px" Height="63px" BackColor="#CC0066" OnClick="Button9_Click" />
            <br />
          <div>
              <div>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>


              <br />
              <br />
              <br />
              <br />
              <br />
          </div>
      </center>
          
    </form>
    <div id="end">
        <b/>
    <p>
        Universidad de San Carlos de Guatemala Mario Jose Rodriguez Vasquez - 201908338</p>
    </div>
</body>
</html>
