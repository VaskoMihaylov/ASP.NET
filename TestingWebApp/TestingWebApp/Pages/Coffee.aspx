    <%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Coffee.aspx.cs" Inherits="TestingWebApp.Pages.Coffee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Select a type<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="sds_type" DataTextField="type" DataValueField="type" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:SqlDataSource ID="sds_type" runat="server" ConnectionString="<%$ ConnectionStrings:CoffeeDBConnectionString %>" SelectCommand="SELECT [type] FROM [coffee] ORDER BY [type]"></asp:SqlDataSource>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
</asp:Content>
