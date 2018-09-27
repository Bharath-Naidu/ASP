<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ProductItem.aspx.cs" Inherits="_22_9_2018_Authencation2._0.ProductItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <br /><br /><br /><br />
    <asp:Image ID="Image1" runat="server" Height="150px" Width="150px"/>
    <br />
    Name of Product&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;
   <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    Brand&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp; 
    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    <br />
    Price of the Product&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <br />
    Description about product :&nbsp; <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <br />


    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
</asp:Content>