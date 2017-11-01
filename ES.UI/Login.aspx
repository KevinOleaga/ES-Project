<%@ Page Title="Login" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ES.UI.Login1" %>

<asp:Content ID="Content" ContentPlaceHolderID="Content" runat="server">
    <div ID="divUser" runat="server">
        <asp:TextBox CssClass="form-control input-lg" ToolTip="Introduzca su usuario" placeholder="Usuario" ID="txtUser" runat="server" />
        <span class="glyphicon glyphicon-user"></span>
    </div>

    <div ID="divPassword" runat="server">
        <asp:TextBox CssClass="form-control input-lg" ToolTip="Introduzca su contraseña" placeholder="Contraseña" TextMode="Password" ID="txtPassword" runat="server" />
        <span class="glyphicon glyphicon-lock"></span>
    </div>

    <asp:Button OnClick="btnUser_Click" class="btn btn-block btn-primary" ID="btnUser" runat="server" Text="Continuar" />
    <asp:Button OnClick="btnPassword_Click" class="btn btn-block btn-primary" ID="btnPassword" runat="server" Text="Iniciar Sesión" />
    <asp:Button OnClick="btnReturn_Click" class="btn btn-block btn-primary" ID="btnReturn" runat="server" Text="Volver" />
    <asp:Button OnClick="btnRestore_Click" class="btn btn-block btn-primary" ID="btnRestore" runat="server" Text="Restaurar cuenta" />

    <section>
        <a runat="server" id="link" href="#">Olvidaste la contraseña ?</a>
    </section>
</asp:Content>