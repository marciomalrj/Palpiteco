<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="p.aspx.cs" Inherits="Palpiteco.Site.Administracao.p" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <%-- <script src="../../js/jquery.js"></script>
    <script src="../../js/jquery.mobile-1.4.0-rc.1.js"></script>--%>

    <asp:TextBox ID="TextBox1" runat="server" data-theme="c"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" />
</asp:Content>
