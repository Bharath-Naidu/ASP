<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_21_9_2018_RegistractionFoam.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <table class="nav-justified">
        <tr>
            <td>First Name</td>
            <td>
                <asp:TextBox ID="FIRSTNAME" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FIRSTNAME" ErrorMessage="Should not be empty" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Last Name</td>
            <td>
                <asp:TextBox ID="LASTNAME" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="LASTNAME" ErrorMessage="Should not be empty" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Mobile</td>
            <td>
                <asp:TextBox ID="MOBILE" runat="server" TextMode="Number"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="MOBILE" ErrorMessage="Should not be empty" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Date Of Birth</td>
            <td>
                <asp:TextBox ID="DATEOFBIRTH" runat="server" TextMode="Date"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DATEOFBIRTH" ErrorMessage="Should not be empty" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Age</td>
            <td>
                <asp:TextBox TextMode="Number" ID="AGE" runat="server" EnableTheming="True"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="AGE" ErrorMessage="Should not be empty" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Gender</td>
            <td>
                <asp:RadioButtonList ID="GENDER" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="GENDER" ErrorMessage="Should not be empty" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Country</td>
            <td>
                <asp:DropDownList ID="COUNTRY_LIST" runat="server">
                    <asp:ListItem>India</asp:ListItem>
                    <asp:ListItem>USA</asp:ListItem>
                    <asp:ListItem>UK</asp:ListItem>
                    <asp:ListItem>AUS</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="COUNTRY_LIST" ErrorMessage="Should not be empty"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="SUBMIT" runat="server" OnClick="Button1_Click" Text="Submit" />
                <br />
                <br />
                <br />
                <asp:Button ID="ALLSUBMISSIONS" runat="server" Text="All Submissions" OnClick="ALLSUBMISSIONS_Click" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <br />
                <br />
                <asp:GridView ID="GridView1" runat="server" Visible="False"></asp:GridView>
                <%--<asp:ListBox ID="ListBox1" runat="server" Visible="False"></asp:ListBox>--%>
                <br />
                <br />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>
