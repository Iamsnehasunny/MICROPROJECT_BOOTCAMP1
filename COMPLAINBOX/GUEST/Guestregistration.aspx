<%@ Page Title="" Language="C#" MasterPageFile="~/GUEST/Guestregistration.Master" AutoEventWireup="true" CodeBehind="Guestregistration.aspx.cs" Inherits="COMPLAINBOX.GUEST.Guestregistration1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
       
        .p1{
            padding :100px;

        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="stylesheet" runat="server">
    <center>
    <table class="p1" border="1">
        <tr>
            <td align="center" colspan="2"><h1>REGISTRATION FORM</h1></td>
        </tr>
        <tr>
            <td>Name :</td>
            <td><asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Address :</td>
            <td><asp:TextBox ID="txtaddress" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Email :</td>
            <td><asp:TextBox ID="txtmail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Phone :</td>
            <td><asp:TextBox ID="txtphn" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>USER NAME :</td>
            <td><asp:TextBox ID="txtusername" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>PASSWORD :</td>
            <td><asp:TextBox ID="txtpswrd" textmode="Password" runat="server"></asp:TextBox></td>
        </tr>
        
        <tr>
            <td><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" style="height: 26px" /></td>
            
        </tr>
            
    </table>
        </center>
</asp:Content>
