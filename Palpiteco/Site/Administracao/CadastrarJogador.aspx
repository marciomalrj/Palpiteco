<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="CadastrarJogador.aspx.cs" Inherits="Palpiteco.Site.Administracao.CadastrarJogador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <span>Nome</span>
    <asp:TextBox ID="txtNome" runat="server" placeholder="Digite seu Nome..." ></asp:TextBox><br />
    <span>Email</span>
    <asp:TextBox ID="txtEmail" runat="server" placeholder="Digite seu Email..."></asp:TextBox><br />
    <span>Senha</span>
    <asp:TextBox ID="txtSenha" runat="server" placeholder="Digite sua Senha..." TextMode="Password"></asp:TextBox><br />
    <span>Foto</span>
    <asp:FileUpload ID="uploadFoto" runat="server"/>
</asp:Content>
