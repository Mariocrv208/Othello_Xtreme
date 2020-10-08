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
          Escoge una Opcion&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Othello Time!<br />
            <asp:Button ID="Button5" runat="server" Text="Partida multijugador" Width="470px" Height="63px" BackColor="#CC0066" OnClick="Button5_Click" />
            <br />
          <asp:Panel ID="Panel1" runat="server" Height="296px" Visible="False">
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
              <asp:Button ID="Continuar" runat="server" BackColor="#CC0066" Height="38px" OnClick="Button11_Click" Text="Continuar" Width="329px" />
          </asp:Panel>
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
