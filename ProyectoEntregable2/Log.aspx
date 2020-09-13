<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoEntregable2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <meta charset="utf-8" />
    <title>Othello-Login</title>
    <link rel="icon" href="img/I1.jpeg" />
    <style type="text/css">
        #Text1 {
            width: 299px;
        }
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
          <br />
          <br />
          <br />
          <br />
          <br />
          <br />
          <br />
          <br />
          <h1><b>LOGIN</b></h1>
          <br /><br />
          <div>
              <b>usuario:<b/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:TextBox ID="txtUsuario" runat="server" Width="317px" BackColor="#FFCCCC"></asp:TextBox>
              <br /><br />
        </div>
          <div>
            <b style="font-size: medium">contraseña:<b/>&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtContrasenia" runat="server" Width="317px" BackColor="#FFCCCC"></asp:TextBox>
            <br /><br /><br />
          </div>
          <div>
            <asp:Button ID="ContLogin" runat="server" Text="Continuar" Width="140px" BackColor="#CC0066" OnClick="ContLogin_Click" />
            <br /><br />
        </div>
        <div>
            <asp:Button ID="Button2" runat="server" Text="Registrar" Width="140px" BackColor="#CC0066" OnClick="Button2_Click" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />

        </div>
      </center>
    
        
    </form>
    </b></b></b></b>
    <div id="end">
        <b/>
    <p>
        Universidad de San Carlos de Guatemala</p>
    <p>
        Mario Jose Rodriguez Vasquez - 201908338</p>
    </div>
</body>
</html>
