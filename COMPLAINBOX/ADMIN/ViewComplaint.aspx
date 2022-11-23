<%@ Page Title="" Language="C#" MasterPageFile="~/ADMIN/ViewComplaint.Master" AutoEventWireup="true" CodeBehind="ViewComplaint.aspx.cs" Inherits="COMPLAINBOX.ADMIN.ViewComplaint1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="stylesheet" runat="server">
    <h1>View Complaint</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  OnRowDeleting="GridView1_RowDeleting" DataKeyNames="Cm_Id" >
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="User Name" />
             <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
            <asp:BoundField DataField="Complaints" HeaderText="Complaint" />
            
            <asp:BoundField DataField="C_Status" HeaderText="Status" />
            <asp:BoundField DataField="Date" HeaderText="Date" />
            <asp:CommandField DeleteText="Confirm"  HeaderText="Confirm" ShowEditButton="True" EditText="" />
        </Columns>
        
    </asp:GridView>
</asp:Content>
