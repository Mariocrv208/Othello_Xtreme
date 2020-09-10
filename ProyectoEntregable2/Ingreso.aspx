<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ingreso.aspx.cs" Inherits="ProyectoEntregable2.Ingreso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Othello-Registro</title>
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
          <br />
          <h1><b>REGISTRO</b></h1>
          <br /><br />
          <div>
              Nombre:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
              <asp:TextBox ID="txtUsuario" runat="server" Width="317px" BackColor="#FFCCCC"></asp:TextBox>
              <br /><br />
        </div>
          <div>
              Apellido:&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp; <asp:TextBox ID="txtContrasenia" runat="server" Width="315px" BackColor="#FFCCCC"></asp:TextBox>
              <br />
              <br />
          <div>
              Nickname:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; <asp:TextBox ID="txtUsuario0" runat="server" Width="317px" BackColor="#FFCCCC"></asp:TextBox>
              <br />
              <br />
        </div>
          <div>
              Contraseña:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="txtContrasenia0" runat="server" Width="317px" BackColor="#FFCCCC"></asp:TextBox>
              <br />
              <br />
          </div>
          <div>
              Fecha de nacimiento:&nbsp;
              <asp:TextBox ID="txtUsuario1" runat="server" Width="317px" BackColor="#FFCCCC"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <br />
              <br />
        </div>
          <div>
              Pais:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="txtContrasenia1" runat="server" Width="315px" BackColor="#FFCCCC"></asp:TextBox>
              <br />
              <br />
          </div>
          <div>
              Correo electronico:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
              <asp:TextBox ID="txtUsuario2" runat="server" Width="317px" BackColor="#FFCCCC"></asp:TextBox>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <br />
              <br />
              <br />
        </div>
              <br />
          </div>
          <div>
            <asp:Button ID="Button1" runat="server" Text="Continuar" Width="458px" Height="99px" BackColor="#CC0066" />
              <br />
              <br />
            <br /><br />
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
