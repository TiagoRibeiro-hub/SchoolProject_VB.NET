<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/index.Master" CodeBehind="welcome.aspx.vb" Inherits="AppWeb.welcome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .auto-style1 {
            height: 515px;
            position: fixed;
            left: 32%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style1">
         <asp:Image ID="ImageWelcome" runat="server" Height="515px" ImageUrl="~/Imagens/home.jpg" />
    </div>
</asp:Content>
