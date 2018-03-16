<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="CadastrarPerfil.aspx.cs" Inherits="Palpiteco.Site.Administracao.CadastrarPerfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" data-icon="check" CssClass="ui-btn-icon-left" OnClick="btnCadastrar_Click" />


</asp:Content>
