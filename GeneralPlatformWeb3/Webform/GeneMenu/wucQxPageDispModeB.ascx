<%@ Control Language="C#" AutoEventWireup="true"
    Inherits="GeneralPlatform.Webform.wucQxPageDispModeB" Codebehind="wucQxPageDispModeB.ascx.cs" %>
        <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link href="../../css/tz_base11.css" rel="stylesheet" />
<table id="tabwucQxPageDispMode" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPageDispModeId" runat="server" CssClass="NameControl">页面显示方式Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPageDispModeId" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPageDispModeName" runat="server" CssClass="NameControl">页面显示方式名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPageDispModeName" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="NameControl">备注</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
</table>
