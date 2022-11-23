<%@ Page Title="" Language="C#" MasterPageFile="~/ADMIN/ViewQery.Master" AutoEventWireup="true" CodeBehind="ViewQery.aspx.cs" Inherits="COMPLAINBOX.ADMIN.ViewQery1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="stylesheet" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="qid">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Customer Name" />
            <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
            
            <asp:BoundField DataField="Query" HeaderText="Query" />
            <asp:BoundField DataField="Q_Status" HeaderText="Status" />
            <asp:BoundField DataField="Date" HeaderText="Date" />
            <asp:HyperLinkField DataNavigateUrlFields="Query_Id" DataNavigateUrlFormatString="reply.aspx?Qid={0}" HeaderText="Reply" Text="Go" />
            
        </Columns>
    </asp:GridView>
</asp:Content>
