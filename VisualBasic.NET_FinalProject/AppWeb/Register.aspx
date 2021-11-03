<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/index.Master" CodeBehind="Register.aspx.vb" Inherits="AppWeb.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .CaixaRegister {
            border-style: solid;
            border-width: 2px;
            width: 300px;
            height: 350px;
            position: absolute;
            left: 605px;
            top: 238px;
            text-align: center;
            border-radius: 10px;
        }

        .lbUserNameDiv {
            width: 275px;
            height: 25px;
            position: relative;
            top: 21px;
            text-align: left;
            left: 25px;
        }

        .tbUserNameDiv {
            width: 275px;
            height: 25px;
            position: relative;
            top: 42px;
            left: 25px;
            text-align: left;
        }

        .lbPasswordDiv {
            width: 275px;
            height: 25px;
            position: relative;
            top: 63px;
            text-align: left;
            left: 25px;
        }

        .tbPasswordDiv {
            width: 275px;
            height: 25px;
            position: relative;
            top: 84px;
            left: 25px;
            text-align: left;
        }

        .lbRepeatPasswordDiv {
            position: relative;
            left: 26px;
            top: 105px;
            text-align: left;
            width: 275px;
        }

        .tbRepeatPasswordDiv {
            position: relative;
            left: 26px;
            top: 126px;
            width: 275px;
            text-align: left;
        }

        .btnRegAltDiv {
            position: relative;
            left: 1px;
            top: 147px;
        }

        .btnRegAlt {
            margin-top:5px;
            background-color: white;
            border-color: black;
            border-radius: 3px;
        }

        .btnRegAlt:hover {
             color: white;
             font-weight: bold;
             background-color: rgb(8 40 209);
        }


    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="CaixaRegister">
        <div class="lbUserNameDiv">
            <asp:Label ID="LabelUserName" runat="server" Text="User Name"></asp:Label>
        </div>
        <div class="tbUserNameDiv">
            <asp:TextBox ID="TextBoxUserName" runat="server" Width="250px"></asp:TextBox>
        </div>
        <div class="lbPasswordDiv">
            <asp:Label ID="LabelPassword" runat="server" Text="Password"></asp:Label>
        </div>
        <div class="tbPasswordDiv">
            <asp:TextBox ID="TextBoxPassword" runat="server" Width="250px" TextMode="Password"></asp:TextBox>
        </div>
        <div class="lbRepeatPasswordDiv">
            <asp:Label ID="LabelRepeatPassword" runat="server" Text="Repeat Password"></asp:Label>
        </div>
        <div class="tbRepeatPasswordDiv">
            <asp:TextBox ID="TextBoxRepeatPassword" runat="server" Width="250px" TextMode="Password"></asp:TextBox>
        </div>
        <div class="btnRegAltDiv">

            <asp:Button ID="ButtonRegister" runat="server" CssClass="btnRegAlt" Text="Register" Visible="False" />
            <asp:Button ID="ButtonAlterar" runat="server" CssClass="btnRegAlt" Text="Change" Visible="False" />

            <asp:CheckBox ID="CheckBoxAdmin" runat="server" Text="Admin" CssClass="cbAdmin" />

        </div>
            
    </div>
   
</asp:Content>
