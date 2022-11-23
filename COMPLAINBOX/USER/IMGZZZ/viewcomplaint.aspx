<%@ Page Title="" Language="C#" MasterPageFile="~/USER/Viewcomplaint.Master" AutoEventWireup="true" CodeBehind="viewcomplaint.aspx.cs" Inherits="COMPLAINBOX.USER.IMGZZZ.viewcomplaint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="stylesheet" runat="server">
    <h1  style="background:white"> Query Reply</h1>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="pname" HeaderText="Product-Name" />
            <asp:BoundField DataField="queries" HeaderText="Your Querry" />
            <asp:BoundField DataField="reply" HeaderText="Admin Reply" />
        </Columns>
        </asp:GridView>
</asp:Content>
