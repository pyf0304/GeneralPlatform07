<%@ Control Language="c#" AutoEventWireup="True" Inherits="GeneralPlatform.Webform.wucPotenceType" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" CodeBehind="wucPotenceType.ascx.cs" %>
        <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link href="../../css/tz_base11.css" rel="stylesheet" />
<meta name="vs_snapToGrid" content="false">
<meta name="vs_showGrid" content="true">
<table id="tabwucPotenceType" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPotenceTypeId" runat="server" CssClass="NameControl" Width="80px">权限类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPotenceTypeId" runat="server" CssClass="ValueControl" Width="435px"></asp:TextBox>
        </td>
          <td></td>
        <td></td>
          </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPotenceTypeName" runat="server"
                CssClass="NameControl" Width="80px">权限类型名</asp:Label></td>
        <td>
            <asp:TextBox ID="txtPotenceTypeName" runat="server"
                CssClass="ValueControl" Width="437px"></asp:TextBox></td>
          <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjId" runat="server" CssClass="NameControl">项目</asp:Label></td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjId" runat="server" CssClass="ValueControl" Width="154px"></asp:DropDownList></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncModuleName" runat="server" CssClass="NameControl">模块</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlFuncModuleId" runat="server" CssClass="ValueControl"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="NameControl">备注</asp:Label></td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtMemo" runat="server" CssClass="ValueControl" Width="442px"></asp:TextBox></td>
    </tr>
</table>
