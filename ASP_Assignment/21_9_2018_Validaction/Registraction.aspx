<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registraction.aspx.cs" Inherits="_21_9_2018_Validaction.Registraction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">First Name</td>
                <td>
                    <asp:TextBox ID="FName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" BackColor="White" ControlToValidate="FName" ErrorMessage="Please  enter First Name" ForeColor="#FF3300" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Second Name</td>
                <td>
                    <asp:TextBox ID="SName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Mobile Number</td>
                <td>
                    <asp:TextBox ID="Mnum" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Age</td>
                <td>
                    <asp:TextBox ID="Age_box" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Age_box" ErrorMessage="RangeValidator"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Date of Birth</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Gender</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem Selected="True">Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="height: 2px">Country</td>
                <td style="height: 2px">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>India</asp:ListItem>
                        <asp:ListItem>USA</asp:ListItem>
                        <asp:ListItem>UK</asp:ListItem>
                        <asp:ListItem>AUS</asp:ListItem>
                        <asp:ListItem>France</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td>
                    <br />
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="Show All Registrations" OnClick="Button2_Click" />
                        
                </td>
            </tr>
        </table>
        <asp:ListBox ID="ListBox1" runat="server" >
            
        </asp:ListBox>
    


</asp:Content>