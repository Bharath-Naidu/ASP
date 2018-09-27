<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageAllProducts.aspx.cs" Inherits="_22_9_2018_Authencation2_0.ManageAllProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:PlaceHolder ID="PlaceHolder2" runat="server">
    <div>
           <span>Enter Barcode: </span>
           <asp:TextBox runat="server" ID="txtSearch" />
           <asp:Button runat="server" ID="btnSearchBar" Style="background-color: #c9302c;" CssClass="btn btn-danger" Text="Search"  OnClick="btnSearchBar_Click" />
       </div>
      </asp:PlaceHolder>
    

    <asp:PlaceHolder ID="PlaceHolderManage" runat="server"></asp:PlaceHolder>


    


    <br />
    <asp:Button ID="New" runat="server" OnClick="New_Click" Text="ADD MORE" PostBackUrl="~/InsertNewProduct.aspx" />


    


</asp:Content>
