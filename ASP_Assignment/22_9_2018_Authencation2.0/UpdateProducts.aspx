<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateProducts.aspx.cs" Inherits="_22_9_2018_Authencation2._0.UpdateProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <br />
    <asp:Label ID="Titile" runat="server" Font-Size="X-Large" Text="Product Details"></asp:Label>
    <br />
    <br />
    <table class="nav-justified">
        <tr>
            <td style="width: 195px">Product Pic</td>
            <td>
                <asp:Image ID="Image2" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 195px">Product Name</td>
            <td>
                <asp:TextBox ID="Name" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 195px">Brand</td>
            <td>
                <asp:DropDownList ID="Brands" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 195px">Product Price</td>
            <td>
                <asp:TextBox ID="price" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 195px">Description about product</td>
            <td>
                <asp:TextBox ID="dec" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 195px">
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" PostBackUrl="~/ManageAllProducts.aspx" Text="Go Back" />
            </td>
            <td>
                <br />
                <br />
                <asp:Button ID="Confirm" runat="server" OnClick="Button1_Click1" Text="Continue to Update" />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                <br />
            </td>
        </tr>
    </table>
    <br />
    <br />
    
    <br />
</asp:Content>
