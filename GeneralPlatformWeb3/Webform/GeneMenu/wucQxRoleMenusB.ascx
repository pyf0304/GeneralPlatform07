<%@ Control Language="C#" AutoEventWireup="true"
    Inherits="GeneralPlatform.Webform.wucQxRoleMenusB" Codebehind="wucQxRoleMenusB.ascx.cs" %>
        <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link href="../../css/tz_base11.css" rel="stylesheet" />
<table id="tabwucQxRoleMenus" cellspacing="1" cellpadding="1" border="0" 
    style="width: 521px">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjId" runat="server" CssClass="NameControl">项目编号</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjId" runat="server" CssClass="ValueControl" 
                AutoPostBack="True" onselectedindexchanged="ddlPrjId_SelectedIndexChanged" 
                Width="200px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblRoleId" runat="server" CssClass="NameControl">角色Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlRoleId" runat="server" CssClass="ValueControl" 
                Width="200px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMenuId" runat="server" CssClass="NameControl">菜单Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlMenuId" runat="server" CssClass="ValueControl" 
                Width="200px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="NameControl">备注</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" CssClass="ValueControl" Height="149px" 
                TextMode="MultiLine" Width="400px"></asp:TextBox>
        </td>
    </tr>
</table>
