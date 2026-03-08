<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucCodeTypeB.ascx.cs" 
    Inherits="GeneralPlatform.Webform.wucCodeTypeB" %>
        <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link href="../../css/tz_base11.css" rel="stylesheet" />
<table id="tabwucCodeType" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCodeTypeId" runat="server" CssClass="NameControl">代码类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCodeTypeId" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCodeTypeName" runat="server" CssClass="NameControl">代码类型名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCodeTypeName" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="NameControl">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
