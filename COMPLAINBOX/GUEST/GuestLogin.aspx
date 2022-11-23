<%@ Page Title="" Language="C#" MasterPageFile="~/GUEST/Guestlogin.Master" AutoEventWireup="true" CodeBehind="GuestLogin.aspx.cs" Inherits="COMPLAINBOX.GUEST.GuestLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 27px;
        }
        .p1{
            padding :100px;

        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="stylesheet" runat="server">
    <center>
    <table class="p1" border="1">
        <tr>
            <td align="center" colspan="2"><h1>LOGIN</h1></td>
        </tr>
        <tr>
            <td class="auto-style1">USER NAME :</td>
            <td class="auto-style1"><asp:TextBox ID="txtusername" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>PASSWORD :</td>
            <td><asp:TextBox ID="txtpswrd" runat="server"></asp:TextBox></td>
        </tr>
        
        <tr>
            <td><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SignIn" style="height: 26px" /></td>
            
        </tr>
        </table>
        </center>
</asp:Content>
