<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/index.Master" CodeBehind="Plant.aspx.vb" Inherits="AppWeb.Plant" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .CaixaTable {
            border-style: double;
            border-width: 3px;
            width: 30%;
            height: 373px;
            position: absolute;
            top: 190px;
            left: 75px;
            z-index: 1;
        }

        .labelLuz {
            border-style: double;
            border-width: 3px;
            text-align: center;
            height: 50px;
        }

        .btnLuzDiv {
            border-style: double;
            border-width: 3px;
            text-align: center;
            width: 84px;
            height: 50px;
        }

        .btnLuz {
            background-color: white;
            border-color: black;
            border-radius: 3px;
        }

            .btnLuz:hover {
                font-weight: bold;
                border-radius: 8px;
            }

        .LuzQuarto1On {
            position: absolute;
            top: 285px;
            left: 808px;
            z-index: 2;
            height: 45px;
            width: 45px;
        }

        .LuzQuarto1Off {
            position: absolute;
            top: 286px;
            left: 863px;
            z-index: 2;
            height: 45px;
            width: 45px;
        }

        .LuzCasaDeBanho1On {
            position: absolute;
            left: 962px;
            top: 215px;
            z-index: 2;
            width: 45px;
            height: 45px;
        }

        .LuzCasaDeBanho1Off {
            position: absolute;
            top: 216px;
            left: 1011px;
            z-index: 2;
            width: 45px;
            height: 45px;
        }

        .LuzQuarto2On {
            position: absolute;
            top: 267px;
            left: 1116px;
            z-index: 1;
            width: 45px;
            height: 45px;
        }

        .LuzQuarto2Off {
            position: absolute;
            top: 267px;
            left: 1181px;
            width: 45px;
            height: 45px;
            z-index: 2;
        }

        .LuzCozinhaOn {
            position: absolute;
            top: 271px;
            left: 1296px;
            z-index: 3;
            width: 45px;
            height: 45px;
        }

        .LuzCozinhaOff {
            position: absolute;
            top: 271px;
            left: 1361px;
            z-index: 2;
            width: 45px;
            height: 45px;
        }

        .LuzQuarto3On {
            position: absolute;
            top: 528px;
            left: 818px;
            z-index: 2;
            width: 45px;
            height: 45px;
        }

        .LuzQuarto3Off {
            position: absolute;
            top: 527px;
            left: 879px;
            z-index: 1;
            width: 45px;
            height: 45px;
        }

        .LuzCasaDeBanho2On {
            position: absolute;
            top: 613px;
            left: 983px;
            z-index: 2;
            width: 45px;
            height: 45px;
        }

        .LuzCasaDeBanho2Off {
            position: absolute;
            top: 614px;
            left: 1035px;
            z-index: 2;
            width: 45px;
            height: 45px;
        }

        .LuzCorredorOn {
            position: absolute;
            top: 453px;
            left: 1054px;
            z-index: 2;
            width: 45px;
            height: 45px;
        }

        .LuzCorredorOff {
            position: absolute;
            top: 452px;
            left: 1118px;
            z-index: 2;
            width: 45px;
            height: 45px;
        }

        .LuzSalaOn {
            position: absolute;
            top: 567px;
            left: 1236px;
            z-index: 2;
            width: 45px;
            height: 45px;
        }

        .LuzSalaOff {
            position: absolute;
            top: 567px;
            left: 1303px;
            z-index: 2;
            width: 45px;
            height: 45px;
        }

        .imgPlanta {
            position: absolute;
            top: 154px;
            left: 730px;
            z-index: 1;
        }

        .agendamentoDiv {
            width: 1175px;
            height: 1000px;
            position: absolute;
            top: 767px;
            left: 160px;
            z-index: 1;
        }

        .lbAgenda {
            position: absolute;
            top: 25px;
            left: 525px;
            z-index: 1;
            width: 155px;
        }

        .LbEscolherHoras {
            position: absolute;
            top: 100px;
            left: 385px;
            z-index: 1;
            height: 22px;
            width: 123px;
        }

        .DdListHH {
            position: absolute;
            top: 140px;
            left: 545px;
            z-index: 1;
            width: 60px;
            height: 25px;
        }

        .lbHH {
            position: absolute;
            top: 140px;
            left: 630px;
            z-index: 1;
        }

        .DdLMM {
            position: absolute;
            top: 180px;
            left: 545px;
            z-index: 1;
            width: 60px;
            height: 25px;
        }

        .lbMM {
            position: absolute;
            top: 180px;
            left: 630px;
            z-index: 1;
        }

        .DdLSS {
            position: absolute;
            top: 220px;
            left: 545px;
            z-index: 1;
            width: 60px;
            height: 25px;
        }

        .lbSS {
            position: absolute;
            top: 220px;
            left: 630px;
            z-index: 1;
        }


        .lbLuzesSalaAgen {
            position: absolute;
            top: 100px;
            left: 770px;
            z-index: 1;
            height: 25px;
        }

        .cbONluzesSalaAgen {
            position: absolute;
            top: 100px;
            left: 1000px;
            z-index: 1;
        }

        .cbOFFluzesSalaAgen {
            position: absolute;
            top: 100px;
            left: 1050px;
            z-index: 1;
        }

        .lbLuzesCorredorAgen {
            position: absolute;
            top: 140px;
            left: 770px;
            z-index: 1;
            height: 25px;
        }

        .cbONluzesCorredorAgen {
            position: absolute;
            top: 140px;
            left: 1000px;
            z-index: 1;
        }

        .cbOFFluzesCorredorAgen {
            position: absolute;
            top: 140px;
            left: 1050px;
            z-index: 1;
        }

        .lbLuzesCozinhaAgen {
            position: absolute;
            top: 180px;
            left: 770px;
            z-index: 1;
            height: 25px;
        }

        .cbONluzesCozinhaAgen {
            position: absolute;
            top: 180px;
            left: 1000px;
            z-index: 1;
        }

        .cbOFFluzesCozinhaAgen {
            position: absolute;
            top: 180px;
            left: 1050px;
            z-index: 1;
        }

        .lbLuzesQuarto1Agen {
            position: absolute;
            top: 220px;
            left: 770px;
            z-index: 1;
            height: 25px;
        }

        .cbONluzesQuarto1Agen {
            position: absolute;
            top: 220px;
            left: 1000px;
            z-index: 1;
        }

        .cbOFFluzesQuarto1Agen {
            position: absolute;
            top: 220px;
            left: 1050px;
            z-index: 1;
        }

        .lbLuzesQuarto2Agen {
            position: absolute;
            top: 260px;
            left: 770px;
            z-index: 1;
            height: 25px;
        }

        .cbONluzesQuarto2Agen {
            position: absolute;
            top: 260px;
            left: 1000px;
            z-index: 1;
        }

        .cbOFFluzesQuarto2Agen {
            position: absolute;
            top: 260px;
            left: 1050px;
            z-index: 1;
        }

        .lbLuzesQuarto3Agen {
            position: absolute;
            top: 300px;
            left: 770px;
            z-index: 1;
            height: 25px;
        }

        .cbONluzesQuarto3Agen {
            position: absolute;
            top: 300px;
            left: 1000px;
            z-index: 1;
        }

        .cbOFFluzesQuarto3Agen {
            position: absolute;
            top: 300px;
            left: 1050px;
            z-index: 1;
        }

        .lbLuzesCasaDeBanho1Agen {
            position: absolute;
            top: 340px;
            left: 770px;
            z-index: 1;
            height: 25px;
        }

        .cbONluzesCasaDeBanho1Agen {
            position: absolute;
            top: 340px;
            left: 1000px;
            z-index: 1;
        }

        .cbOFFluzesCasaDeBanho1Agen {
            position: absolute;
            top: 340px;
            left: 1050px;
            z-index: 1;
        }

        .lbLuzesCasaDeBanho2Agen {
            position: absolute;
            top: 380px;
            left: 770px;
            z-index: 1;
            height: 25px;
        }

        .cbONluzesCasaDeBanho2Agen {
            position: absolute;
            top: 380px;
            left: 1000px;
            z-index: 1;
        }

        .cbOFFluzesCasaDeBanho2Agen {
            position: absolute;
            top: 380px;
            left: 1050px;
            z-index: 1;
        }


        .lbEscolherData {
            position: absolute;
            top: 100px;
            left: 50px;
            z-index: 1;
        }

        .lbAno {
            position: absolute;
            top: 140px;
            left: 190px;
            z-index: 1;
            height: 26px;
        }

        .lbAnoRes {
            position: absolute;
            top: 140px;
            left: 270px;
            z-index: 1;
            height: 26px;
        }

        .lbMes {
            position: absolute;
            top: 180px;
            left: 190px;
            z-index: 1;
            height: 26px;
        }

        .lbMesRes {
            position: absolute;
            top: 180px;
            left: 270px;
            z-index: 1;
            height: 26px;
        }

        .lbDia {
            position: absolute;
            top: 220px;
            left: 190px;
            z-index: 1;
            height: 26px;
        }

        .ddDia {
            position: absolute;
            top: 220px;
            left: 270px;
            z-index: 1;
            height: 25px;
            width: 60px;
        }

        .btnFazerAgendamento {
            position: absolute;
            top: 450px;
            left: 880px;
            z-index: 1;
            background-color: white;
            border-color: black;
            border-radius: 5px;
        }

            .btnFazerAgendamento:hover {
                color: white;
                font-weight: bold;
                background-color: rgb(8 40 209);
                border-radius: 10px;
            }

        .gridUsersReg {
            Height: 150px;
            Width: 655px;
            left: 0px;
            position: absolute;
            top: 270px;
            left: 50px;
            z-index: 1;
        }

        .panelAutorizacao {
            width: 1175px;
            height: 200px;
            position: absolute;
            top: 520px;
            left: 0px;
            z-index: 1;
        }

        .TabelaAutori {
            width: 100%;
            height: 55px;
            position: relative;
            top: 20px;
            left: 0px;
            z-index: 1;
        }

        .tbColunaAutori {
            width: 137px;
        }

        .PlaceHolderTableAutori {
            width: 404px;
            height: 22px;
            position: absolute;
            top: 170px;
            left: 315px;
            z-index: 1;
        }

        .ddlUsersAutori {
            position: absolute;
            top: 90px;
            left: 0px;
            height: 25px;
            z-index: 1;
        }

        .btnRefresh {
            z-index: 1;
            position: absolute;
            top: 90px;
            left: 100px;
            width: 150px;
            height: 25px;
            background-color: white;
            border-color: black;
            border-radius: 5px;
        }

            .btnRefresh:hover {
                color: white;
                font-weight: bold;
                background-color: rgb(8 40 209);
                border-radius: 10px;
            }

        .btnGravarPermissoes {
            position: absolute;
            top: 90px;
            right: 0px;
            height: 25px;
            z-index: 1;
            background-color: white;
            border-color: black;
            border-radius: 5px;
        }

            .btnGravarPermissoes:hover {
                color: white;
                font-weight: bold;
                background-color: rgb(8 40 209);
                border-radius: 10px;
            }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    
    <asp:Timer ID="TimerRefresh" runat="server" Interval="310000">
    </asp:Timer>
    
    <asp:UpdateProgress ID="UpdateProgress1" runat="server">
        <ProgressTemplate>
            Loading..........
        </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table class="CaixaTable">
                <tr>
                    <td class="btnLuzDiv">
                        <asp:Button ID="ButtonLuzSala" runat="server" CssClass="btnLuz" Text="On" />
                    </td>
                    <td class="labelLuz">
                        <asp:Label ID="LabelLuzSala" runat="server" Text="Luz da Sala Apagada"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="btnLuzDiv">
                        <asp:Button ID="ButtonLuzCozinha" runat="server" CssClass="btnLuz" Text="On" />
                    </td>
                    <td class="labelLuz">
                        <asp:Label ID="LabelLuzCozinha" runat="server" Text="Luz da Cozinha Apagada"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="btnLuzDiv">
                        <asp:Button ID="ButtonLuzCorredor" runat="server" CssClass="btnLuz" Text="On" />
                    </td>
                    <td class="labelLuz">
                        <asp:Label ID="LabelLuzCorredor" runat="server" Text="Luz do Corredor Apagada"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="btnLuzDiv">
                        <asp:Button ID="ButtonLuzQuarto1" runat="server" CssClass="btnLuz" Text="On" />
                    </td>
                    <td class="labelLuz">
                        <asp:Label ID="LabelLuzQuarto1" runat="server" Text="Luz do Quarto 1 Apagada"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="btnLuzDiv">
                        <asp:Button ID="ButtonLuzQuarto2" runat="server" CssClass="btnLuz" Text="On" />
                    </td>
                    <td class="labelLuz">
                        <asp:Label ID="LabelLuzQuarto2" runat="server" Text="Luz do Quarto 2 Apagada"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="btnLuzDiv">
                        <asp:Button ID="ButtonLuzQuarto3" runat="server" CssClass="btnLuz" Text="On" />
                    </td>
                    <td class="labelLuz">
                        <asp:Label ID="LabelLuzQuarto3" runat="server" Text="Luz do Quarto 3 Apagada"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="btnLuzDiv">
                        <asp:Button ID="ButtonLuzCasaDeBanho1" runat="server" CssClass="btnLuz" Text="On" />
                    </td>
                    <td class="labelLuz">
                        <asp:Label ID="LabelLuzCasaDeBanho1" runat="server" Text="Luz da Casa de Banho 1 Apagada"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="btnLuzDiv">
                        <asp:Button ID="ButtonLuzCasaDeBanho2" runat="server" CssClass="btnLuz" Text="On" />
                    </td>
                    <td class="labelLuz">
                        <asp:Label ID="LabelLuzCasaDeBanho2" runat="server" Text="Luz da Casa de Banho 2 Apagada"></asp:Label>
                    </td>
                </tr>
            </table>
            <asp:ImageButton ID="ImageButtonLuzCasaDeBanho1On" runat="server" CssClass="LuzCasaDeBanho1On" ImageUrl="~/Imagens/lampada_on.png" Visible="False" />
            <asp:ImageButton ID="ImageButtonLuzCasaDeBanho1Off" runat="server" CssClass="LuzCasaDeBanho1Off" ImageUrl="~/Imagens/lampada_off.jpg" />
            <asp:ImageButton ID="ImageButtonLuzQuarto1On" runat="server" CssClass="LuzQuarto1On" ImageUrl="~/Imagens/lampada_on.png" Visible="False" />
            <asp:ImageButton ID="ImageButtonLuzQuarto1Off" runat="server" CssClass="LuzQuarto1Off" ImageUrl="~/Imagens/lampada_off.jpg" />
            <asp:Image ID="ImagePlanta" runat="server" CssClass="imgPlanta" ImageUrl="~/Imagens/planta-de-casa-com-3-quartos-5.jpg" />
            <asp:ImageButton ID="ImageButtonLuzQuarto2On" runat="server" CssClass="LuzQuarto2On" ImageUrl="~/Imagens/lampada_on.png" Visible="False" />
            <asp:ImageButton ID="ImageButtonLuzQuarto2Off" runat="server" CssClass="LuzQuarto2Off" ImageUrl="~/Imagens/lampada_off.jpg" />
            <asp:ImageButton ID="ImageButtonLuzCozinhaOn" runat="server" CssClass="LuzCozinhaOn" ImageUrl="~/Imagens/lampada_on.png" Visible="False" />
            <asp:ImageButton ID="ImageButtonLuzCozinhaOff" runat="server" CssClass="LuzCozinhaOff" ImageUrl="~/Imagens/lampada_off.jpg" />
            <asp:ImageButton ID="ImageButtonLuzQuarto3On" runat="server" CssClass="LuzQuarto3On" ImageUrl="~/Imagens/lampada_on.png" Visible="False" />
            <asp:ImageButton ID="ImageButtonLuzQuarto3Off" runat="server" CssClass="LuzQuarto3Off" ImageUrl="~/Imagens/lampada_off.jpg" />
            <asp:ImageButton ID="ImageButtonCasaDeBanho2On" runat="server" CssClass="LuzCasaDeBanho2On" ImageUrl="~/Imagens/lampada_on.png" Visible="False" />
            <asp:ImageButton ID="ImageButtonLuzCasaDeBanho2Off" runat="server" CssClass="LuzCasaDeBanho2Off" ImageUrl="~/Imagens/lampada_off.jpg" />
            <asp:ImageButton ID="ImageButtonLuzCorredorOn" runat="server" CssClass="LuzCorredorOn" ImageUrl="~/Imagens/lampada_on.png" Visible="False" />
            <asp:ImageButton ID="ImageButtonLuzCorredorOff" runat="server" CssClass="LuzCorredorOff" ImageUrl="~/Imagens/lampada_off.jpg" />
            <asp:ImageButton ID="ImageButtonLuzSalaOn" runat="server" CssClass="LuzSalaOn" ImageUrl="~/Imagens/lampada_on.png" Visible="False" />
            <asp:ImageButton ID="ImageButtonLuzSalaOff" runat="server" CssClass="LuzSalaOff" ImageUrl="~/Imagens/lampada_off.jpg" />
        </ContentTemplate>
    </asp:UpdatePanel>

    <div class="agendamentoDiv">

        <asp:Label ID="LabelAgendamento" runat="server" CssClass="lbAgenda" ForeColor="Black" Text="AGENDAMENTO"></asp:Label>
        <asp:Label ID="LabelEscolherHoras" runat="server" CssClass="LbEscolherHoras" Text="Escolha a hora:"></asp:Label>

        <asp:DropDownList ID="DropDownListHH" runat="server" CssClass="DdListHH">
            <asp:ListItem Value="1"></asp:ListItem>
            <asp:ListItem Value="2"></asp:ListItem>
            <asp:ListItem Value="3"></asp:ListItem>
            <asp:ListItem Value="4"></asp:ListItem>
            <asp:ListItem Value="5"></asp:ListItem>
            <asp:ListItem Value="6"></asp:ListItem>
            <asp:ListItem Value="7"></asp:ListItem>
            <asp:ListItem Value="8"></asp:ListItem>
            <asp:ListItem Value="9"></asp:ListItem>
            <asp:ListItem Value="10"></asp:ListItem>
            <asp:ListItem Value="11"></asp:ListItem>
            <asp:ListItem Value="12"></asp:ListItem>
            <asp:ListItem>13</asp:ListItem>
            <asp:ListItem Value="14"></asp:ListItem>
            <asp:ListItem Value="15"></asp:ListItem>
            <asp:ListItem>16</asp:ListItem>
            <asp:ListItem Value="17"></asp:ListItem>
            <asp:ListItem>18</asp:ListItem>
            <asp:ListItem>19</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>21</asp:ListItem>
            <asp:ListItem>22</asp:ListItem>
            <asp:ListItem>23</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownListMM" runat="server" CssClass="DdLMM">
            <asp:ListItem Value="0"></asp:ListItem>
            <asp:ListItem Value="05">05</asp:ListItem>
            <asp:ListItem Value="10"></asp:ListItem>
            <asp:ListItem Value="15"></asp:ListItem>
            <asp:ListItem Value="20"></asp:ListItem>
            <asp:ListItem Value="25"></asp:ListItem>
            <asp:ListItem Value="30"></asp:ListItem>
            <asp:ListItem Value="35"></asp:ListItem>
            <asp:ListItem Value="40"></asp:ListItem>
            <asp:ListItem Value="45"></asp:ListItem>
            <asp:ListItem Value="50"></asp:ListItem>
            <asp:ListItem Value="55"></asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownListSS" runat="server" CssClass="DdLSS">
            <asp:ListItem Value="00">00</asp:ListItem>
            <asp:ListItem Value="30"></asp:ListItem>
        </asp:DropDownList>

        <asp:Label ID="LabelHH" runat="server" CssClass="lbHH" Text="HH"></asp:Label>
        <asp:Label ID="LabelMM" runat="server" CssClass="lbMM" Text="MM"></asp:Label>
        <asp:Label ID="LabelSS" runat="server" CssClass="lbSS" Text="SS"></asp:Label>

        <asp:Label ID="LabelLuzesSalaAgend" runat="server" CssClass="lbLuzesSalaAgen" Text="Luzes Sala ................................."></asp:Label>
        <asp:CheckBox ID="CheckBoxSalaOn" runat="server" CssClass="cbONluzesSalaAgen" Text="ON" />
        <asp:CheckBox ID="CheckBoxSalaOff" runat="server" CssClass="cbOFFluzesSalaAgen" Text="OFF" />

        <asp:Label ID="LabelLuzesCorredorAgen" runat="server" CssClass="lbLuzesCorredorAgen" Text="Luzes Corredor .........................."></asp:Label>
        <asp:CheckBox ID="CheckBoxCorredorON" runat="server" CssClass="cbONluzesCorredorAgen" Text="ON" />
        <asp:CheckBox ID="CheckBoxCorredorOFF" runat="server" CssClass="cbOFFluzesCorredorAgen" Text="OFF" />

        <asp:Label ID="LabelLuzesCozinhaAgen" runat="server" CssClass="lbLuzesCozinhaAgen" Text="Luzes Cozinha ............................"></asp:Label>
        <asp:CheckBox ID="CheckBoxluzesCozinhaAgenON" runat="server" CssClass="cbONluzesCozinhaAgen" Text="ON" />
        <asp:CheckBox ID="CheckBoxluzesCozinhaAgenOFF" runat="server" CssClass="cbOFFluzesCozinhaAgen" Text="OFF" />

        <asp:Label ID="LabelLuzesQuarto1Agen" runat="server" CssClass="lbLuzesQuarto1Agen" Text="Luzes Quarto 1 ..........................."></asp:Label>
        <asp:CheckBox ID="CheckBoxluzesQuarto1AgenON" runat="server" CssClass="cbONluzesQuarto1Agen" Text="ON" />
        <asp:CheckBox ID="CheckBoxluzesQuarto1AgenOFF" runat="server" CssClass="cbOFFluzesQuarto1Agen" Text="OFF" />

        <asp:Label ID="LabelLuzesQuarto2Agen" runat="server" CssClass="lbLuzesQuarto2Agen" Text="Luzes Quarto 2 ..........................."></asp:Label>
        <asp:CheckBox ID="CheckBoxluzesQuarto2AgenON" runat="server" CssClass="cbONluzesQuarto2Agen" Text="ON" />
        <asp:CheckBox ID="CheckBoxluzesQuarto2AgenOFF" runat="server" CssClass="cbOFFluzesQuarto2Agen" Text="OFF" />

        <asp:Label ID="LabelLuzesQuarto3Agen" runat="server" CssClass="lbLuzesQuarto3Agen" Text="Luzes Quarto 3 ..........................."></asp:Label>
        <asp:CheckBox ID="CheckBoxluzesQuarto3AgenON" runat="server" CssClass="cbONluzesQuarto3Agen" Text="ON" />
        <asp:CheckBox ID="CheckBoxluzesQuarto3AgenOFF" runat="server" CssClass="cbOFFluzesQuarto3Agen" Text="OFF" />

        <asp:Label ID="LabelLuzesCasaDeBanho1Agen" runat="server" CssClass="lbLuzesCasaDeBanho1Agen" Text="Luzes Casa De Banho 1 .............."></asp:Label>
        <asp:CheckBox ID="CheckBoxLuzesCasaDeBanho1AgendON" runat="server" CssClass="cbONluzesCasaDeBanho1Agen" Text="ON" />
        <asp:CheckBox ID="CheckBoxLuzesCasaDeBanho1AgendOFF" runat="server" CssClass="cbOFFluzesCasaDeBanho1Agen" Text="OFF" />

        <asp:Label ID="LabelLuzesCasaDeBanho2Agen" runat="server" CssClass="lbLuzesCasaDeBanho2Agen" Text="Luzes Casa De Banho 2 .............."></asp:Label>
        <asp:CheckBox ID="CheckBoxLuzesCasaDeBanho2AgendON" runat="server" CssClass="cbONluzesCasaDeBanho2Agen" Text="ON" />
        <asp:CheckBox ID="CheckBoxLuzesCasaDeBanho2AgendOFF" runat="server" CssClass="cbOFFluzesCasaDeBanho2Agen" Text="OFF" />

        <asp:Label ID="LabelEscolherData" runat="server" CssClass="lbEscolherData" Text="Escolha a data:"></asp:Label>

        <asp:Label ID="LabelAno" runat="server" CssClass="lbAno" Text="ANO"></asp:Label>
        <asp:Label ID="LabelAnoRes" runat="server" CssClass="lbAnoRes" Text="ANORES"></asp:Label>

        <asp:Label ID="LabelMes" runat="server" CssClass="lbMes" Text="MÊS"></asp:Label>
        <asp:Label ID="LabelMesRes" runat="server" CssClass="lbMesRes" Text="MESRES"></asp:Label>

        <asp:Label ID="LabelDia" runat="server" CssClass="lbDia" Text="DIA"></asp:Label>
        <asp:DropDownList ID="DropDownListDias" runat="server" CssClass="ddDia"></asp:DropDownList>
        <asp:Button ID="ButtonFazerAgendamento" runat="server" CssClass="btnFazerAgendamento" Text="Fazer Agendamento" />


        <asp:GridView ID="GridViewAgendIndividual" runat="server" CssClass="gridUsersReg" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>

        <asp:Panel ID="PanelAutorizacaoAdmin" runat="server" CssClass="panelAutorizacao" Visible="False">


            <table id="tableAutorizacao" class="TabelaAutori">
                <tr>
                    <td>
                        <asp:Label ID="LabelUserAutorizacao" runat="server" Text="Utilizador"></asp:Label>
                    </td>
                    <td class="tbColunaAutori">
                        <asp:Label ID="LabelSalaAutor" runat="server" Text="Sala"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelCorredorAutor" runat="server" Text="Corredor"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelCozinhaAutor" runat="server" Text="Cozinha"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelQuarto1Autor" runat="server" Text="Quarto1"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelQuarto2Autor" runat="server" Text="Quarto2"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelQuarto3Autor" runat="server" Text="Quarto3"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelCasaDeBanho1Autor" runat="server" Text="Casa De Banho1"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelCasaDeBanhoAutor" runat="server" Text="Casa De Banho2"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="LabelAdminAutor" runat="server" Text="Admin"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>

                        <asp:Label ID="LabelUsersEscolhidos" runat="server" Text="Escolha user"></asp:Label>

                    </td>
                    <td class="tbColunaAutori">
                        <asp:CheckBox ID="CheckBoxSalaAutori" runat="server" Text="Autorizar" />
                    </td>
                    <td>
                        <asp:CheckBox ID="CheckBoxCorredorAutori" runat="server" Text="Autorizar" />
                    </td>
                    <td>
                        <asp:CheckBox ID="CheckBoxCozinhaAutori" runat="server" Text="Autorizar" />
                    </td>
                    <td>
                        <asp:CheckBox ID="CheckBoxQuarto1Autori" runat="server" Text="Autorizar" />
                    </td>
                    <td>
                        <asp:CheckBox ID="CheckBoxQuarto2Autori" runat="server" Text="Autorizar" />
                    </td>
                    <td>
                        <asp:CheckBox ID="CheckBoxQuarto3Autori" runat="server" Text="Autorizar" />
                    </td>
                    <td>
                        <asp:CheckBox ID="CheckBoxCasaDeBanho1Autori" runat="server" Text="Autorizar" />
                    </td>
                    <td>
                        <asp:CheckBox ID="CheckBoxCasaDeBanho2Autori" runat="server" Text="Autorizar" />
                    </td>
                    <td>
                        <asp:CheckBox ID="CheckBoxAdminAutori" runat="server" Text="Autorizar" />
                    </td>
                </tr>
            </table>

            <asp:DropDownList ID="DropDownListUsersAutori" runat="server" CssClass="ddlUsersAutori"></asp:DropDownList>
            <asp:Button ID="ButtonRefreshAutori" runat="server" CssClass="btnRefresh" Text="Escolher User" />
            <asp:Button ID="ButtonGravarAutori" runat="server" CssClass="btnGravarPermissoes" Text="Gravar Permissoes" />

            <div class="PlaceHolderTableAutori">
                <asp:PlaceHolder ID="PlaceHolderTableAutorizaçoes" runat="server" Visible="False"></asp:PlaceHolder>
            </div>

        </asp:Panel>

    </div>


</asp:Content>
