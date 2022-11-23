<%@ Page Title="" Language="C#" MasterPageFile="~/USER/Complaintregistration.Master" AutoEventWireup="true" CodeBehind="Complaintregistration.aspx.cs" Inherits="COMPLAINBOX.USER.Complaintregistration1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="stylesheet" runat="server">
   
<h3 align="center">Complaint Registartion</h3>   
    <table align="center">        
        <tr>            
            <td>Choose your product</td>            
            <td>   
                <asp:DropDownList ID="ddlproduct" runat="server"></asp:DropDownList>                

            </td>                      

        </tr>        
        <tr>            
            <td>Enter you complaint</td>            
            <td>                
                <asp:TextBox ID="txtcomplaint" runat="server"></asp:TextBox>

            </td>        

        </tr>                
        <tr>            
            <td>                
                <asp:Button ID="btnreg" runat="server" Text="Register" OnClick="btnreg_Click"/>

            </td>        

        </tr>    

    </table>


</asp:Content>
