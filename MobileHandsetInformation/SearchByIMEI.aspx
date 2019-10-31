<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchByIMEI.aspx.cs" Inherits="MobileHandsetInformation.SearchByIMEI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <table style="width: 100%;">
        <tr>
            <td colspan="2"><strong>Search BY IMEI</strong></td>
            <td colspan="3"><strong></strong></td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
            <td colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 100px; text-align: right;">IMEI</td>
          
           
            <td style="width: 112px">
                <asp:TextBox ID="imeiTextBox" runat="server" Width="142px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 100px">&nbsp;</td>
            <td style="width: 152px">&nbsp;</td>
            <td colspan="3">&nbsp;</td>
        </tr>
    </table>
    
    <asp:GridView ID="showMobileGrideView" runat="server" AutoGenerateColumns="False" AllowSorting="True" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
        <Columns>
            <asp:TemplateField HeaderText="#SL">
                <ItemTemplate>
                    <%#Eval(expression:"MobileId") %>
                </ItemTemplate>
                </asp:TemplateField>
             <asp:TemplateField HeaderText="Model Name">
                <ItemTemplate>
                    <%#Eval(expression:"MobileModelName") %>
                </ItemTemplate>
                </asp:TemplateField>
             <asp:TemplateField HeaderText="IMEI">
                <ItemTemplate>
                    <%#Eval(expression:"MobileIMEI") %>
                </ItemTemplate>
                </asp:TemplateField>
             <asp:TemplateField HeaderText="Price">
                <ItemTemplate>
                    <%#Eval(expression:"MobilePrice") %>
                </ItemTemplate>
                </asp:TemplateField>
                </Columns>
          <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
      
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="White" ForeColor="#003399" />

                </asp:GridView>
</asp:Content>
