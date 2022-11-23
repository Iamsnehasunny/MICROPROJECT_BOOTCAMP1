<%@ Page Title="" Language="C#" MasterPageFile="~/USER/Qeryreg.Master" AutoEventWireup="true" CodeBehind="Qeryreg.aspx.cs" Inherits="COMPLAINBOX.USER.Qeryreg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="stylesheet" runat="server">
    <h3 align="center">Qery Registartion</h3>   
    <table align="center">        
        <tr>            
            <td>Choose your product</td>            
            <td>   
                <asp:DropDownList ID="ddlproduct" runat="server"></asp:DropDownList>                

            </td>                      

        </tr>        
        <tr>            
            <td>Enter your query</td>            
            <td>                
                <asp:TextBox ID="txtqery" runat="server"></asp:TextBox>

            </td>        

        </tr>                
        <tr>            
            <td>                
                <asp:Button ID="btnreg" runat="server" Text="Register" OnClick="btnreg_Click"/>

            </td>        

        </tr>    

    </table>
</asp:Content>
