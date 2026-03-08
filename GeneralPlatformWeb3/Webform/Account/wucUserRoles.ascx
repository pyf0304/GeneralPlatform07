<%@ Control Language="c#" AutoEventWireup="True" Inherits="GeneralPlatform.Webform.wucUserRoles" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" CodeBehind="wucUserRoles.ascx.cs" %>
        <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link href="../../css/tz_base11.css" rel="stylesheet" />
<meta name="vs_snapToGrid" content="false">
<meta name="vs_showGrid" content="true">
<table id="tabwucUserRoles" cellspacing="1" cellpadding="1" width="512" border="0" style="width: 512px; height: 80px">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblRoleId" runat="server" CssClass="NameControl">角色Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtRoleId" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblRoleName" runat="server" CssClass="NameControl">角色名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtRoleName" runat="server" CssClass="ValueControl"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjId" runat="server" CssClass="NameControl">项目</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjId" runat="server" Width="158px"
                CssClass="ValueControl" AutoPostBack="True" OnSelectedIndexChanged="ddlPrjId_SelectedIndexChanged">
            </asp:DropDownList></td>
       <td>
            <asp:Label ID="Label1" runat="server" CssClass="NameControl">角色序号</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtRoleIndex" runat="server" CssClass="ValueControl"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="NameControl">备注</asp:Label></td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtMemo" runat="server" CssClass="ValueControl"
                Width="416px" Height="80px" TextMode="MultiLine"></asp:TextBox></td>
    </tr>
</table>
