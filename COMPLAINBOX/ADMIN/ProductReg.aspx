<%@ Page Title="" Language="C#" MasterPageFile="~/ADMIN/ProductReg.Master" AutoEventWireup="true" CodeBehind="ProductReg.aspx.cs" Inherits="COMPLAINBOX.ADMIN.ProductReg1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="stylesheet" runat="server">
    <link rel="stylesheet" type="text/css" href="page_specific.css" />
    <table border="1">
        <tr>
            <td align="center" colspan="2"><h1>REGISTRATION FORM</h1></td>
        </tr>
    <tr>
            <td>Product Name :</td>
            <td><asp:TextBox ID="txtprname" runat="server"></asp:TextBox></td>
        </tr>
        
        <tr>
            <td><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" style="height: 26px" /></td>
            
        </tr>
        </table>


    <br />
   
</asp:Content>
