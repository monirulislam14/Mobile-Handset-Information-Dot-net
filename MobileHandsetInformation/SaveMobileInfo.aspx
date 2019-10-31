<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SaveMobileInfo.aspx.cs" Inherits="MobileHandsetInformation.SaveMobileInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 63%;" class="nav-justified">
        <tr>
            <td class="text-right" style="width: 148px"><strong>Save</strong></td>
            <td style="width: 110px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-right" style="width: 148px">&nbsp;</td>
            <td style="width: 110px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 148px; height: 20px"></td>
            <td style="width: 110px; height: 20px">Model Name</td>
            <td style="height: 20px">
                <asp:TextBox ID="modelNameTextBox" runat="server" Width="172px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 148px; height: 19px"></td>
            <td style="width: 110px; height: 19px">IMEI</td>
            <td style="height: 19px">
                <asp:TextBox ID="imeiTextBox" runat="server" Width="172px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 148px">&nbsp;</td>
            <td style="width: 110px">Price</td>
            <td>
                <asp:TextBox ID="priceTextBox" runat="server" Width="172px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 148px">&nbsp;</td>
            <td style="width: 110px">&nbsp;</td>
            <td class="text-center">
                <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 148px">&nbsp;</td>
            <td colspan="2">
                <asp:Label ID="messageLabel" runat="server" ></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
