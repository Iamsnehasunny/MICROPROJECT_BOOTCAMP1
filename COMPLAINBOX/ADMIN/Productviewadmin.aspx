 <%@ Page Title="" Language="C#" MasterPageFile="~/ADMIN/Productviewadmin.Master" AutoEventWireup="true" CodeBehind="Productviewadmin.aspx.cs" Inherits="COMPLAINBOX.ADMIN.Productviewadmin1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="stylesheet" runat="server">
     <h1>Product View</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Product_Id"  OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" >
        <Columns>
            <asp:BoundField HeaderText="PRODUCT NAME" DataField="ProductName" />
            <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
            <asp:CommandField EditText="Delete" HeaderText="Delete" ShowDeleteButton="True" />
        </Columns>
        
    </asp:GridView>
</asp:Content>
