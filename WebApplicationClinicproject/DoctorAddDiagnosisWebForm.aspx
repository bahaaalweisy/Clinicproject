<%@ Page Title="" Language="C#" MasterPageFile="~/DoctorMasterPage.Master" AutoEventWireup="true" CodeBehind="DoctorAddDiagnosisWebForm.aspx.cs" Inherits="WebApplicationClinicproject.DoctorAddDiagnosisWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 119px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" Text="Patient"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownListPatient" runat="server" Height="20px" Width="150px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBoxDescription" runat="server" Height="92px" TextMode="MultiLine" Width="318px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label3" runat="server" Text="Cost"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBoxCost" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="ButtonSave" runat="server" OnClick="ButtonSave_Click" Text="Save" />
            </td>
        </tr>
    </table>
</asp:Content>
