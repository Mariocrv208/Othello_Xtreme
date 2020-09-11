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
        .auto-style1 {
            margin-left: 200px;
        }
        .auto-style2 {
            margin-left: 80px;
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
          <div class="auto-style1">
              Nombres:&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
              <asp:TextBox ID="txtnombres" runat="server" Width="317px" BackColor="#FFCCCC"></asp:TextBox>
              &nbsp;
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" BackColor="#FF5050" ControlToValidate="txtnombres" ErrorMessage="Debes ingresar tu nombre"></asp:RequiredFieldValidator>
              <br /><br />
        </div>
          <div class="auto-style1">
              Apellidos:&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp; <asp:TextBox ID="txtapellidos" runat="server" Width="315px" BackColor="#FFCCCC"></asp:TextBox>
              &nbsp;
              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" BackColor="#FF6666" ControlToValidate="txtapellidos" ErrorMessage="Debes ingresar tu apellido"></asp:RequiredFieldValidator>
              <br />
              <br />
          <div>
              Nickname:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; <asp:TextBox ID="txtnickname" runat="server" Width="317px" BackColor="#FFCCCC"></asp:TextBox>
              &nbsp;
              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" BackColor="#FF6666" ControlToValidate="txtnickname" ErrorMessage="Debes ingresar tu nickname"></asp:RequiredFieldValidator>
              <br />
              <br />
        </div>
          <div>
              Contraseña:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="txtcontra" runat="server" Width="317px" BackColor="#FFCCCC"></asp:TextBox>
              &nbsp;
              <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" BackColor="#FF6666" ControlToValidate="txtcontra" ErrorMessage="Debes ingresar tu contraseña"></asp:RequiredFieldValidator>
              <br />
              <br />
          </div>
          <div class="auto-style2">
              Fecha de nacimiento:&nbsp; &nbsp;
              <asp:TextBox ID="txtfecha" runat="server" Width="317px" BackColor="#FFCCCC"></asp:TextBox>
&nbsp;
              <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" BackColor="#FF6666" ControlToValidate="txtfecha" ErrorMessage="Debes ingresar tu fecha de nacimiento"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <br />
              <br />
        </div>
          <div>
              Pais:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
              <asp:DropDownList ID="DropDownPais" runat="server" AutoPostBack="True" BackColor="#FF99CC" Height="23px" Width="319px">
                  <asp:ListItem>Seleccione un pais</asp:ListItem>
                  <asp:ListItem>AFG</asp:ListItem>
                  <asp:ListItem>ALA</asp:ListItem>
                  <asp:ListItem>ALB</asp:ListItem>
                  <asp:ListItem>ALB</asp:ListItem>
                  <asp:ListItem>ASM</asp:ListItem>
                  <asp:ListItem>AND</asp:ListItem>
                  <asp:ListItem>AGO</asp:ListItem>
                  <asp:ListItem>AIA</asp:ListItem>
                  <asp:ListItem>ATA</asp:ListItem>
                  <asp:ListItem>ATG</asp:ListItem>
                  <asp:ListItem>ARG</asp:ListItem>
                  <asp:ListItem>ARM</asp:ListItem>
                  <asp:ListItem>ABW</asp:ListItem>
                  <asp:ListItem>AUS</asp:ListItem>
                  <asp:ListItem>AUT</asp:ListItem>
                  <asp:ListItem>AZE</asp:ListItem>
                  <asp:ListItem>BHS</asp:ListItem>
                  <asp:ListItem>BHR</asp:ListItem>
                  <asp:ListItem>BGD</asp:ListItem>
                  <asp:ListItem>BRB</asp:ListItem>
                  <asp:ListItem>BRL</asp:ListItem>
                  <asp:ListItem>BEL</asp:ListItem>
                  <asp:ListItem>BLZ</asp:ListItem>
                  <asp:ListItem>BEN</asp:ListItem>
                  <asp:ListItem>BMU</asp:ListItem>
                  <asp:ListItem>BTN</asp:ListItem>
                  <asp:ListItem>BOL</asp:ListItem>
                  <asp:ListItem>BES</asp:ListItem>
                  <asp:ListItem>BIH</asp:ListItem>
                  <asp:ListItem>BWA</asp:ListItem>
                  <asp:ListItem>BVT</asp:ListItem>
                  <asp:ListItem>BRA</asp:ListItem>
                  <asp:ListItem>IOT</asp:ListItem>
                  <asp:ListItem>VGB</asp:ListItem>
                  <asp:ListItem>BRN</asp:ListItem>
                  <asp:ListItem>BGR</asp:ListItem>
                  <asp:ListItem>BFA</asp:ListItem>
                  <asp:ListItem>BDI</asp:ListItem>
                  <asp:ListItem>KHM</asp:ListItem>
                  <asp:ListItem>CMR</asp:ListItem>
                  <asp:ListItem Value="CAN"></asp:ListItem>
                  <asp:ListItem>CPV</asp:ListItem>
                  <asp:ListItem>CYM</asp:ListItem>
                  <asp:ListItem>CAF</asp:ListItem>
                  <asp:ListItem>TCD</asp:ListItem>
                  <asp:ListItem>CHL</asp:ListItem>
                  <asp:ListItem>CHN</asp:ListItem>
                  <asp:ListItem>CXR</asp:ListItem>
                  <asp:ListItem>CCK</asp:ListItem>
                  <asp:ListItem>COL</asp:ListItem>
                  <asp:ListItem>COM</asp:ListItem>
                  <asp:ListItem>COK</asp:ListItem>
                  <asp:ListItem>CRI</asp:ListItem>
                  <asp:ListItem>HRV</asp:ListItem>
                  <asp:ListItem>CUB</asp:ListItem>
                  <asp:ListItem>CUW</asp:ListItem>
                  <asp:ListItem>CYP</asp:ListItem>
                  <asp:ListItem>CZE</asp:ListItem>
                  <asp:ListItem>COD</asp:ListItem>
                  <asp:ListItem>DNK</asp:ListItem>
                  <asp:ListItem>DJI</asp:ListItem>
                  <asp:ListItem>DMA</asp:ListItem>
                  <asp:ListItem>DOM</asp:ListItem>
                  <asp:ListItem>TLS</asp:ListItem>
                  <asp:ListItem>ECU</asp:ListItem>
                  <asp:ListItem>EGY</asp:ListItem>
                  <asp:ListItem>SLV</asp:ListItem>
                  <asp:ListItem>GNQ</asp:ListItem>
                  <asp:ListItem>ERI</asp:ListItem>
                  <asp:ListItem>EST</asp:ListItem>
                  <asp:ListItem>ETH</asp:ListItem>
                  <asp:ListItem>FLK</asp:ListItem>
                  <asp:ListItem>FRO</asp:ListItem>
                  <asp:ListItem>FJI</asp:ListItem>
                  <asp:ListItem>FIN</asp:ListItem>
                  <asp:ListItem Value="FRA"></asp:ListItem>
                  <asp:ListItem>GUF</asp:ListItem>
                  <asp:ListItem>PYF</asp:ListItem>
                  <asp:ListItem>ATF</asp:ListItem>
                  <asp:ListItem>GAB</asp:ListItem>
                  <asp:ListItem>GMB</asp:ListItem>
                  <asp:ListItem>GEO</asp:ListItem>
                  <asp:ListItem>DEU</asp:ListItem>
                  <asp:ListItem>GHA</asp:ListItem>
                  <asp:ListItem>GIB</asp:ListItem>
                  <asp:ListItem>GRC</asp:ListItem>
                  <asp:ListItem>GRL</asp:ListItem>
                  <asp:ListItem>GRD</asp:ListItem>
                  <asp:ListItem>GLP</asp:ListItem>
                  <asp:ListItem>GUM</asp:ListItem>
                  <asp:ListItem>GTM</asp:ListItem>
                  <asp:ListItem>GGY</asp:ListItem>
                  <asp:ListItem>GIN</asp:ListItem>
                  <asp:ListItem>GNB</asp:ListItem>
                  <asp:ListItem>GUY</asp:ListItem>
                  <asp:ListItem>HTI</asp:ListItem>
                  <asp:ListItem>HMD</asp:ListItem>
                  <asp:ListItem>HND</asp:ListItem>
                  <asp:ListItem>HKG</asp:ListItem>
                  <asp:ListItem>HUN</asp:ListItem>
                  <asp:ListItem>ISL</asp:ListItem>
                  <asp:ListItem>IND</asp:ListItem>
                  <asp:ListItem>IDN</asp:ListItem>
                  <asp:ListItem>IRN</asp:ListItem>
                  <asp:ListItem>IRQ</asp:ListItem>
                  <asp:ListItem>IRL</asp:ListItem>
                  <asp:ListItem>IMN</asp:ListItem>
                  <asp:ListItem>ISR</asp:ListItem>
                  <asp:ListItem>ITA</asp:ListItem>
                  <asp:ListItem>CIV</asp:ListItem>
                  <asp:ListItem>JAM</asp:ListItem>
                  <asp:ListItem>JPN</asp:ListItem>
                  <asp:ListItem>JEY</asp:ListItem>
                  <asp:ListItem>JOR</asp:ListItem>
                  <asp:ListItem>KAZ</asp:ListItem>
                  <asp:ListItem>KEN</asp:ListItem>
                  <asp:ListItem>KIR</asp:ListItem>
                  <asp:ListItem>XKX</asp:ListItem>
                  <asp:ListItem>KWT</asp:ListItem>
                  <asp:ListItem>KGZ</asp:ListItem>
                  <asp:ListItem>LAO</asp:ListItem>
                  <asp:ListItem>LVA</asp:ListItem>
                  <asp:ListItem>LBN</asp:ListItem>
                  <asp:ListItem>LBY</asp:ListItem>
                  <asp:ListItem>LIE</asp:ListItem>
                  <asp:ListItem>LTU</asp:ListItem>
                  <asp:ListItem>LUX</asp:ListItem>
                  <asp:ListItem>MAC</asp:ListItem>
                  <asp:ListItem>MKD</asp:ListItem>
                  <asp:ListItem>MDG</asp:ListItem>
                  <asp:ListItem>MWI</asp:ListItem>
                  <asp:ListItem>MYS</asp:ListItem>
                  <asp:ListItem>MDV</asp:ListItem>
                  <asp:ListItem>MLI</asp:ListItem>
                  <asp:ListItem>MLT</asp:ListItem>
                  <asp:ListItem>MHL</asp:ListItem>
                  <asp:ListItem Value="MTQ"></asp:ListItem>
                  <asp:ListItem>MRT</asp:ListItem>
                  <asp:ListItem>MUS</asp:ListItem>
                  <asp:ListItem>MYT</asp:ListItem>
                  <asp:ListItem>MEX</asp:ListItem>
                  <asp:ListItem>FSM</asp:ListItem>
                  <asp:ListItem>MDA</asp:ListItem>
                  <asp:ListItem>MCO</asp:ListItem>
                  <asp:ListItem>MNG</asp:ListItem>
                  <asp:ListItem>MNE</asp:ListItem>
                  <asp:ListItem>MSR</asp:ListItem>
                  <asp:ListItem>MAR</asp:ListItem>
                  <asp:ListItem>MOZ</asp:ListItem>
                  <asp:ListItem>MMR</asp:ListItem>
                  <asp:ListItem>NAM</asp:ListItem>
                  <asp:ListItem>NRU</asp:ListItem>
                  <asp:ListItem>NLD</asp:ListItem>
                  <asp:ListItem>NLD</asp:ListItem>
                  <asp:ListItem>ANT</asp:ListItem>
                  <asp:ListItem>NCL</asp:ListItem>
                  <asp:ListItem>NZL</asp:ListItem>
                  <asp:ListItem>NIC</asp:ListItem>
                  <asp:ListItem>NER</asp:ListItem>
                  <asp:ListItem>NGA</asp:ListItem>
                  <asp:ListItem>NIU</asp:ListItem>
                  <asp:ListItem>NFK</asp:ListItem>
                  <asp:ListItem>PRK</asp:ListItem>
                  <asp:ListItem>MNP</asp:ListItem>
                  <asp:ListItem>NOR</asp:ListItem>
                  <asp:ListItem>OMN</asp:ListItem>
                  <asp:ListItem>PAK</asp:ListItem>
                  <asp:ListItem>PLW</asp:ListItem>
                  <asp:ListItem>PSE</asp:ListItem>
                  <asp:ListItem>PAN</asp:ListItem>
                  <asp:ListItem>PNG</asp:ListItem>
                  <asp:ListItem>PER</asp:ListItem>
                  <asp:ListItem>PHL</asp:ListItem>
                  <asp:ListItem>PCN</asp:ListItem>
                  <asp:ListItem>POL</asp:ListItem>
                  <asp:ListItem>PRT</asp:ListItem>
                  <asp:ListItem>PRI</asp:ListItem>
                  <asp:ListItem>QAT</asp:ListItem>
                  <asp:ListItem>COG</asp:ListItem>
                  <asp:ListItem>REU</asp:ListItem>
                  <asp:ListItem>ROU</asp:ListItem>
                  <asp:ListItem>RUS</asp:ListItem>
                  <asp:ListItem>RWA</asp:ListItem>
                  <asp:ListItem>BLM</asp:ListItem>
                  <asp:ListItem>SHN</asp:ListItem>
                  <asp:ListItem>KNA</asp:ListItem>
                  <asp:ListItem>LCA</asp:ListItem>
                  <asp:ListItem>MAF</asp:ListItem>
                  <asp:ListItem>SPM</asp:ListItem>
                  <asp:ListItem>VCT</asp:ListItem>
                  <asp:ListItem>WSM</asp:ListItem>
                  <asp:ListItem>SMR</asp:ListItem>
                  <asp:ListItem>STP</asp:ListItem>
                  <asp:ListItem>SAU</asp:ListItem>
                  <asp:ListItem>SEN</asp:ListItem>
                  <asp:ListItem>SRB</asp:ListItem>
                  <asp:ListItem>SCG</asp:ListItem>
                  <asp:ListItem>SYC</asp:ListItem>
                  <asp:ListItem>SLE</asp:ListItem>
                  <asp:ListItem>SXM</asp:ListItem>
                  <asp:ListItem>SVK</asp:ListItem>
                  <asp:ListItem>SVN</asp:ListItem>
                  <asp:ListItem>SLB</asp:ListItem>
                  <asp:ListItem>SOM</asp:ListItem>
                  <asp:ListItem>ZAF</asp:ListItem>
                  <asp:ListItem>SGS</asp:ListItem>
                  <asp:ListItem>KOR</asp:ListItem>
                  <asp:ListItem>SSD</asp:ListItem>
                  <asp:ListItem>ESP</asp:ListItem>
                  <asp:ListItem>LKA</asp:ListItem>
                  <asp:ListItem>SDN</asp:ListItem>
                  <asp:ListItem>SUR</asp:ListItem>
                  <asp:ListItem>SJM</asp:ListItem>
                  <asp:ListItem>SWZ</asp:ListItem>
                  <asp:ListItem>SWE</asp:ListItem>
                  <asp:ListItem>CHE</asp:ListItem>
                  <asp:ListItem>SYR</asp:ListItem>
                  <asp:ListItem>TWN</asp:ListItem>
                  <asp:ListItem>TJK</asp:ListItem>
                  <asp:ListItem>TZA</asp:ListItem>
                  <asp:ListItem>THA</asp:ListItem>
                  <asp:ListItem>TGO</asp:ListItem>
                  <asp:ListItem>TKL</asp:ListItem>
                  <asp:ListItem>TON</asp:ListItem>
                  <asp:ListItem>TTO</asp:ListItem>
                  <asp:ListItem>TUN</asp:ListItem>
                  <asp:ListItem>TUR</asp:ListItem>
                  <asp:ListItem>TKM</asp:ListItem>
                  <asp:ListItem>TCA</asp:ListItem>
                  <asp:ListItem>TUV</asp:ListItem>
                  <asp:ListItem>VIR</asp:ListItem>
                  <asp:ListItem>UGA</asp:ListItem>
                  <asp:ListItem>UKR</asp:ListItem>
                  <asp:ListItem>ARE</asp:ListItem>
                  <asp:ListItem>GBR</asp:ListItem>
                  <asp:ListItem>USA</asp:ListItem>
                  <asp:ListItem>UMI</asp:ListItem>
                  <asp:ListItem>URY</asp:ListItem>
                  <asp:ListItem>UZB</asp:ListItem>
                  <asp:ListItem>VUT</asp:ListItem>
                  <asp:ListItem>VAT</asp:ListItem>
                  <asp:ListItem>VEN</asp:ListItem>
                  <asp:ListItem>VNM</asp:ListItem>
                  <asp:ListItem>WLF</asp:ListItem>
                  <asp:ListItem>ESH</asp:ListItem>
                  <asp:ListItem>YEM</asp:ListItem>
                  <asp:ListItem>ZMB</asp:ListItem>
                  <asp:ListItem>ZWE</asp:ListItem>
              </asp:DropDownList>
&nbsp;
              <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" BackColor="#FF6666" ControlToValidate="DropDownPais" ErrorMessage="Debes ingresar tu Pais"></asp:RequiredFieldValidator>
              <br />
              <br />
          </div>
          <div class="auto-style2">
              Correo electronico &nbsp;&nbsp;
              <asp:TextBox ID="txtcorreo" runat="server" Width="317px" BackColor="#FFCCCC"></asp:TextBox>
              &nbsp;
              <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" BackColor="#FF6666" ControlToValidate="txtcorreo" ErrorMessage="Debes ingresar tu Correo electronico"></asp:RequiredFieldValidator>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <br />
              <br />
              <br />
        </div>
              <br />
          </div>
          <div>
            <asp:Button ID="Button1" runat="server" Text="Continuar" Width="458px" Height="99px" BackColor="#CC0066" OnClick="Button1_Click" />
              <br />
              <br />
            <br /><br />
        </div>
      </center>
    
        
    </form>
    <div id="end">
        <b/>
    <p>
        Universidad de San Carlos de Guatemalaa       Mario Jose Rodriguez Vasquez - 201908338</p>
    </div>
</body>
</html>
