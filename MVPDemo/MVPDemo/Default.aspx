<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="MVPDemo._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        MVP patterns demo
    </h2>
    <p>
         Go to <a href="/UserDetails.aspx" >User List</a> (Passive View)
    </p> 
    <p>
         Go to <a href="/UserDetailsSVC.aspx" >User List</a> (Supervising Controller)
    </p>
</asp:Content>
