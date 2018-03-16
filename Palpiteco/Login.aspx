<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Palpiteco.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="input-group col-lg-5 col-sm-6 col-xs-10 center-block" data-theme="a">
       
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
            <button type="submit" class="btn btn-success pull-left">Entrar</button>
        </div>
    </div>
</asp:Content>
