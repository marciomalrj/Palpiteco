<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Teste.aspx.cs" Inherits="Palpiteco.Teste" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

    <%--<label for="exampleInputEmail1">Email address</label>--%>
    <p><span>Email</span></p>
    <input type="email" runat="server" class="form-control" id="txtEmail" aria-describedby="Email" placeholder="Entre com seu Email" />
    <br />
    <br />


    <%--<label for="exampleInputPassword1"></label>--%>
    <p><span>Senha</span></p>
    <input type="password" runat="server" class="form-control" id="txtSenha" placeholder="Senha" />
    <br />

    <div class="pull-left">
        <input type="checkbox" class="form-check-input" id="chkLogado" />
        &nbsp;
        <label class="form-check-label" for="Check1">Permanecer Logado</label>
        <br />
        
    </div>
    <button type="submit" class="btn btn-success pull-left" data-theme="g">Entrar</button>
</asp:Content>
