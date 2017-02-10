<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ManageProduct.aspx.cs" Inherits="Pages_Management_ManageProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    Name:</p>
<p>
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
</p>
<p>
    Size:</p>
<p>
    <asp:DropDownList ID="ddlType" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="ID">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TshirtDBConnectionString %>" SelectCommand="SELECT [ID], [Name] FROM [Size] ORDER BY [Name]"></asp:SqlDataSource>
</p>
<p>
    Price:</p>
<p>
    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
</p>
<p>
    Image:</p>
<p>
    <asp:DropDownList ID="ddlImage" runat="server" OnSelectedIndexChanged="ddlImage_SelectedIndexChanged">
    </asp:DropDownList>
</p>
<p>
    &nbsp;</p>
<p>
    Descriptipon:</p>
<p>
    <asp:TextBox ID="txtDescription" runat="server" Height="92px" TextMode="MultiLine" Width="372px"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click1" />
</p>
    <p>
    <asp:Label ID="lblResult" runat="server"></asp:Label>
</p>
</asp:Content>

