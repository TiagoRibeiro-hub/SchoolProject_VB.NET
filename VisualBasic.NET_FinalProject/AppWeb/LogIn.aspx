<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/index.Master" CodeBehind="LogIn.aspx.vb" Inherits="AppWeb.LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .caixaLogIn {
            border-style: solid;
            border-width: 2px;
            width: 300px;
            height: 270px;
            position: absolute;
            left: 605px;
            top: 238px;
            text-align: center;
            border-radius: 10px;
        }

        .labelUserName {
            width: 250px;
            height: 25px;
            left: 25px;
            top: 25px;
            position: relative;
            text-align: left;
        }

        .tbUserName {
            width: 250px;
            height: 25px;
            left: 25px;
            top: 42px;
            position: relative;
            text-align: left;
        }

        .labelPassword  {
            width: 250px;
            height: 25px;
            left: 25px;
            top: 63px;
            position: relative;
            text-align: left;
        }

        .tbPassword{
            width: 250px;
            height: 25px;
            left: 25px;
            top: 84px;
            position: relative;
            text-align: left;
        }

        .btnLogInDiv {
            width: 250px;
            height: 25px;
            left: 25px;
            top: 105px;
            position: relative;
        }

        .LinkRegisterDiv {
            width: 300px;
            height: 25px;
            position: relative;
            left: 1px;
            top: 118px;
        }
        .LinkRegister{
            color:rgb(8 40 209);
            text-decoration: none;
        }
        .LinkRegister:hover{
            font-weight: bold;
            text-decoration: underline;
            color: rgb(8 138 209);
        }
        .btnLogIn{
            background-color: white;
            border-color: black;
            border-radius: 3px;
        }
        .btnLogIn:hover{
            color: white;
            font-weight: bold;
            background-color:rgb(8 40 209);
        }

        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="caixaLogIn" id="caixaLogin">
        <div class="labelUserName">
            <asp:Label ID="LabelUserName" runat="server" Text="User Name"></asp:Label>
        </div>
        <div class="tbUserName">
            <asp:TextBox ID="TextBoxUserName" runat="server" Width="250px"></asp:TextBox>
        </div>
        <div class="labelPassword">
            <asp:Label ID="LabelPassword" runat="server" Text="Password"></asp:Label>
        </div>
        <div class="tbPassword">
            <asp:TextBox ID="TextBoxPassword" runat="server" Width="250px" TextMode="Password"></asp:TextBox>
        </div>
        <div class="btnLogInDiv">
            <asp:Button ID="ButtonLogIn" runat="server" CssClass="btnLogIn" Text="Log In" />
        </div>
        <div class="LinkRegisterDiv">
            <asp:LinkButton ID="LinkButtonRegister" runat="server" CssClass="LinkRegister">Register</asp:LinkButton>
        </div>
    </div>
</asp:Content>
