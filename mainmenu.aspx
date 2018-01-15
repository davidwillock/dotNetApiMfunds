<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="mainmenu.aspx.cs" Inherits="mainmenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
   
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/import.aspx">Import Utility</asp:HyperLink>
   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

     <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/login.aspx">Logout</asp:HyperLink>
    </asp:Content>

