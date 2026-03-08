<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucExportExcelSetB_Sim.ascx.cs"
    Inherits="GeneralPlatform.Webform.wucExportExcelSetB_Sim" %>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link href="../../css/tz_base11.css" rel="stylesheet" type="text/css" />
<table id="tabwucExportExcelSet" cellspacing="1" cellpadding="1" border="0" style="width: 619px">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblViewName" runat="server" Width="70px" CssClass="NameControl">界面名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:Label ID="txtViewName" runat="server" CssClass="ValueControl"></asp:Label>
        </td>
        <td class="NameTD">
            <asp:Label ID="lblTabName" runat="server" CssClass="NameControl">表名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:Label ID="txtTabName" runat="server" CssClass="ValueControl"></asp:Label>
        </td>
        <td class="NameTD">
            <asp:Label ID="lblUserID" runat="server" CssClass="NameControl">用户ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:Label ID="txtUserID" runat="server" CssClass="ValueControl"></asp:Label>
        </td>
        <td class="ValueTD">
            <asp:Label ID="lblIsDefaultUser" runat="server" CssClass="ValueControl"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblExportFileName" runat="server" CssClass="NameControl">导出文件名</asp:Label>
        </td>
        <td class="ValueTD" colspan="5">
            <asp:TextBox ID="txtExportFileName" runat="server" CssClass="ValueControl" Width="400px"></asp:TextBox>
        </td>
        <td class="ValueTD">
            &nbsp;</td>
    </tr>
</table>
