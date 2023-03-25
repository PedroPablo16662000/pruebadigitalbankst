<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="Capa1PresentacionWeb.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="name" runat="server"></asp:TextBox><br />
    <asp:Label ID="label2" runat="server" Text="Fecha Nacimiento"></asp:Label>
    <input type="date" id="fnac" runat="server"></input><br />
    <asp:Label ID="Label3" runat="server" Text="Sexo"></asp:Label>
    <asp:DropDownList ID="sex" runat="server">
        <asp:ListItem Value="F" Text="Femenino"></asp:ListItem>
        <asp:ListItem Value="M" Text="Masculino"></asp:ListItem>
    </asp:DropDownList><br />
    <asp:Button ID="btnSave" runat="server" Text="Guardar" OnClick="btnSave_Click" />
</asp:Content>
