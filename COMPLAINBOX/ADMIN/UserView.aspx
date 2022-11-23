<%@ Page Title="" Language="C#" MasterPageFile="~/ADMIN/UserView.Master" AutoEventWireup="true" CodeBehind="UserView.aspx.cs" Inherits="COMPLAINBOX.ADMIN.UserView1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="stylesheet" runat="server">
    <h1>USERS</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Login_Id" OnRowDeleting="GridView1_RowDeleting">
        <Columns>
            <asp:BoundField HeaderText="Name" DataField="Name"  />
            <asp:BoundField HeaderText="Address" DataField="Address" />
            <asp:BoundField HeaderText="Email" DataField="Email" />
            <asp:BoundField DataField="Phone" HeaderText="Phone" />
            <asp:BoundField DataField="Status" HeaderText="Status" />
            <asp:CommandField DeleteText="Update Status" EditText="Update Status" HeaderText="Update Status" ShowDeleteButton="True" />
            
            

        </Columns>

    </asp:GridView>
</asp:Content>
