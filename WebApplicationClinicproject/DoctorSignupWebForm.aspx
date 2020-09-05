<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DoctorSignupWebForm.aspx.cs" Inherits="WebApplicationClinicproject.DoctorSignupWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 297px;
    }
        .auto-style3 {
            width: 297px;
            height: 25px;
        }
        .auto-style4 {
            height: 25px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label2" runat="server" Text="FullName"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBoxFullName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style3"></td>
        <td class="auto-style4"></td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label3" runat="server" Text="Mobile"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBoxMobile" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label5" runat="server" Text="Specilization"></asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="DropDownListSpecilization" runat="server" Height="25px" Width="168px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>
            <asp:Button ID="ButtonSignup" runat="server" Text="Sign Up" OnClick="ButtonSignup_Click" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
