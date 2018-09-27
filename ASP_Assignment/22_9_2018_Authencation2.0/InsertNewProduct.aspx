<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertNewProduct.aspx.cs" Inherits="_22_9_2018_Authencation2._0.InsertNewProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <table class="nav-justified" aria-atomic="False" border="1">
        <tr>
            <td style="width: 193px">Product Image</td>
            <td class="modal-lg" style="width: 396px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 193px">Product Name</td>
            <td class="modal-lg" style="width: 396px">
                <asp:TextBox ID="Name" runat="server"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 193px">Product Price</td>
            <td class="modal-lg" style="width: 396px">
                <asp:TextBox ID="Price" runat="server" TextMode="Number"></asp:TextBox>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 193px">Product Brand</td>
            <td class="modal-lg" dir="ltr" style="width: 396px">
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    
                </asp:DropDownList>
                <br />
            </td>
        </tr>
        <tr>
            <td style="width: 193px">Description about Product </td>
            <td class="modal-lg" style="width: 396px">
                <asp:TextBox ID="Dec" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 193px">&nbsp;</td>
            <td class="modal-lg" style="width: 396px">
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert Data" />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
            </td>
        </tr>
    </table>
    <p>
        <asp:Button ID="Button2" runat="server" PostBackUrl="~/ManageAllProducts.aspx" Text="Go Back" />
    </p>
    <p>
    </p>
</asp:Content>
