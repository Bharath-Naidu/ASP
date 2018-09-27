<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="_22_9_2018_Authentication2_0.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

  
  
    
    <br />
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
    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        
   <%-- <asp:Image ID="Image1" runat="server" style="width: 113px; height: 87px"/><br />
    <asp:HyperLink ID="HyperLink1" runat="server" Text="Name"/><br />
    <asp:label runat="server" ID="label1">Price</asp:label> --%>
            
    </asp:PlaceHolder>
    
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    
</asp:Content>
