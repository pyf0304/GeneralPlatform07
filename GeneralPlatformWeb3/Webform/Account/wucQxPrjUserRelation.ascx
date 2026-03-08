<%@ Control Language="C#" AutoEventWireup="true"
    Inherits="GeneralPlatform.Webform.wucQxPrjUserRelation" Codebehind="wucQxPrjUserRelation.ascx.cs" %>
        <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link href="../../css/tz_base11.css" rel="stylesheet" />
<table id="tabwucQxPrjUserRelation" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjId" runat="server" CssClass="NameControl">项目编号</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjId" runat="server" CssClass="ValueControl" Width="157px">
            </asp:DropDownList>
        </td>
        <td>
            <asp:Label ID="lblUserId" runat="server" CssClass="NameControl">用户ID</asp:Label>
        </td>
        <td style="width: 242px">
            <asp:TextBox ID="txtUserId" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="NameControl">备注</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtMemo" runat="server" CssClass="ValueControl" Width="450px"></asp:TextBox>
        </td>
    </tr>
</table>
