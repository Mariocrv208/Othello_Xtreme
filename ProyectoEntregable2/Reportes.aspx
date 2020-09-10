<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Torneos.aspx.cs" Inherits="ProyectoEntregable2.Torneos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Othello-Torneos</title>
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
<body data-="body">
    <form id="Login" runat="server">
      <center>
        <br />
          <div id="nombre">
              <h3 style="height: 31px; width: 1399px">&nbsp; iGamesGT</h3>
          </div>
          <br />
          <h1>Torneos</h1>
            <br />
          <asp:Button ID="Button5" runat="server" Height="200px" Text="Crear Torneo" Width="450px" BackColor="#CC0066" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="Button6" runat="server" Height="200px" Text="Unirse a un torneo" Width="450px" BackColor="#CC0066" />
          <br />
          <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
          <div id="CrearT">
              <br />
              <asp:Panel ID="Panel2" runat="server" Height="400px" Width="450px">
                  <br />
                  <br />
                  Cantidad de participantes<br />
                  <br />
                  <br />
                  <asp:DropDownList ID="DropDownList1" runat="server" Height="27px" Width="307px" BackColor="#FFCCCC">
                  </asp:DropDownList>
                  <br />
                  <br />
                  <br />
                  <asp:Button ID="Button7" runat="server" Height="121px" Text="Crear Torneo" Width="281px" BackColor="#CC0066" />
              </asp:Panel>
              <br />
          </div>
          <div id="UnirT">
              <br />
              <asp:Panel ID="Panel3" runat="server" Height="400px" Width="450px">
                  <br />
                  <br />
                  Ingresar codigo de torneo<br />
                  <br />
                  <br />
                  <asp:TextBox ID="TextBox1" runat="server" Width="275px" BackColor="#FFCCCC"></asp:TextBox>
                  <br />
                  <br />
                  <br />
                  <asp:Button ID="Button8" runat="server" Height="121px" Text="Unirse a Torneo" Width="281px" BackColor="#CC0066" />
              </asp:Panel>
          </div>
          &nbsp;&nbsp;<br />
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<div>
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
        Universidad de San Carlos de Guatemala</p>
    <p>
        Mario Jose Rodriguez Vasquez - 201908338</p>
    </div>
</body>
</html>