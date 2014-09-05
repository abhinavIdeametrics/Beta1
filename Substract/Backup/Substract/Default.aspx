<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Substract._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:Label ID="frst" Text="First No" runat="server"></asp:Label>
    <asp:TextBox ID="tb1" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="sec" Text="Second No" runat="server"></asp:Label>
    <asp:TextBox ID="tb2" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="result" Text="Result here" runat="server" ></asp:Label>

    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />

</asp:Content>
