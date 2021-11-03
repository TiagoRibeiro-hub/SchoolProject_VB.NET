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
        .btnLuz{
            background-color: white;
            border-color: black;
            border-radius: 3px;
        }
        .btnLuz:hover{
            font-weight: bold;
            border-radius: 8px;
        }
        .imgPlanta{
             position: absolute;
            top: 155px;
            left: 730px;
            z-index: 1;
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

        .agendamentoDiv {
            width: 1175px;
            height: 22px;
            position: absolute;
            top: 767px;
            left: 161px;
            z-index: 1;
            background-color: aqua;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
    <div class="agendamentoDiv">

    </div>
</asp:Content>
