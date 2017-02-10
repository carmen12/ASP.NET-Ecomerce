<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Pages_Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td rowspan="4">
                <asp:Image ID="imgProduct" runat="server" CssClass="detailsImage"/>
            </td>
            <td>
                <h2>
                    <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
                    <hr/>
                </h2>
            </td>
        </tr>
        <tr>       
            <td>
                <asp:Label ID="lblDescription" runat="server" Text="Label" CssClass="detailsDescription"></asp:Label>
            </td>
        </tr>
        <tr>       
            <td></td>
            <td>
                <asp:Label ID="lblPrice" runat="server" Text="Label" CssClass="detailsPrice"></asp:Label><br />
                Quantity:
                <asp:DropDownList ID="ddlAmount" runat="server"></asp:DropDownList>
                <br />
                <asp:Button ID="Button1" runat="server" CssClass="button" OnClick="Button1_Click" Text="Add to Cart" />
                <br />
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Product Number :
                <asp:Label ID="lblItemNr" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbl" runat="server" Text="Available" CssClass="productPrice"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

