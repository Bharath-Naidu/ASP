<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="Default_Page.aspx.cs" Inherits="_20_9_2018_First_Application.Default_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Header" Runat="Server">
    <!DOCTYPE html>
<html>
<head>
    <link href="Styles.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <div id="header-tag">
    <h1>Welcome to my first app</h1>
    </div>
</body>
</html>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyOfPage" Runat="Server">
    <div id="intro">
        <img src="C:\Users\bharat.naidu\Pictures\People.jpg" width="50" height="50">
        <a href="Default_Page.aspx" id="startingtag">Supporting Our Networks</a>
        <br />
        <p>Our networks are strongest when we work together, learn from each other, and build our collective ability to complement – and improve – the country’s rapidly changing health care and services systems.</p>
        <p>ACL is committed to sharing best practices as well as research and development findings across the aging and disability networks; providing technical assistance; and informing the networks informed about policy developments.</p>
    </div>
    </asp:Content>

