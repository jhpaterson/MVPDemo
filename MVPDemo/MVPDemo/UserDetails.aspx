<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserDetails.aspx.cs" Inherits="MVPDemo.UserDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Passive View
    </h2>
    <p><asp:DropDownList ID="UsersDropDownList" runat="server" 
            onselectedindexchanged="UsersDropDownList_SelectedIndexChanged"
            autopostback="true">
    </asp:DropDownList></p>
    <p>First name: <asp:Label ID="FirstNameLabel" runat="server" /></p>
    <p>Last name: <asp:Label ID="LastNameLabel" runat="server" /></p>
    <p>Username: <asp:Label ID="UsernameLabel" runat="server" /></p>
    <p>Date joined: <asp:Label ID="DateJoinedLabel" runat="server" /></p>
    <p><asp:Button ID="HomeButton" runat="server" Text="Home" 
            onclick="HomeButton_Click" /></p>

</asp:Content>
