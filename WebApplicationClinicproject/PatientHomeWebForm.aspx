<%@ Page Title="" Language="C#" MasterPageFile="~/PatientMasterPage.Master" AutoEventWireup="true" CodeBehind="PatientHomeWebForm.aspx.cs" Inherits="WebApplicationClinicproject.PatientHomeWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 158px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style2">
            <asp:Label runat="server" Text="Email"></asp:Label>
        </td>
        <td>
            <asp:Label ID="LabelEmail" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label2" runat="server" Text="Welcome"></asp:Label>
        </td>
        <td>
            <asp:Label ID="LabelName" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
