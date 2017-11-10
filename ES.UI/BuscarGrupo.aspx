<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuscarGrupo.aspx.cs" Inherits="ES.UI.BuscarGrupo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
    <div class="alert alert-success" visible="false"  id="mensaje" runat="server">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
             <strong id="textoMensaje" runat="server"></strong>
        </div> 
     <div class="alert alert-danger" visible="false"  id="mensajeError" runat="server">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
             <strong id="textomensajeError" runat="server"></strong>
        </div>  
    <div class="alert alert-info" visible="false"  id="mensajeInfo" runat="server">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
             <strong id="textomensajeInfo" runat="server"></strong>
        </div>      
    <h2>Lista de Grupo</h2>
    <div class="table-responsive">
    <asp:GridView style="font-family: Verdana, Geneva, Tahoma, sans-serif;
    font-size:10px;" ID="gvDatos" AutoGenerateColumns = False 
        CssClass="table table-hover" runat="server">
    <Columns>
        <asp:BoundField DataField = "IdGrupo" HeaderText = "Id Grupo" />
        <asp:BoundField DataField = "Aula" HeaderText = "Aulas" />
           
    </Columns>
    </asp:GridView>
     </div>
</asp:Content>
