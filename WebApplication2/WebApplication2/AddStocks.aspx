<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddStocks.aspx.cs" Inherits="WebApplication2.AddStocks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

         <asp:Label ID="lblCode" runat="server" Text="Code"></asp:Label>
          <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>

           <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
           <asp:TextBox ID="txtName" runat="server"></asp:TextBox>

           <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
           <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>

           <asp:Button ID="btnAdd" runat="server" Text="Add Stock" OnClick="btnAdd_Click" />

          <asp:Button ID="btnClear" runat="server" Text="Clear" />

      

        


</asp:Content>
