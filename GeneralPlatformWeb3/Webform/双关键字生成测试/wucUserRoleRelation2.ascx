<%@ Control Language="C#" AutoEventWireup="true" Inherits="GeneralPlatform.Webform.wucUserRoleRelation2" Codebehind="wucUserRoleRelation2.ascx.cs" %>
<link rel="stylesheet" type="text/css" href="../../Webform/css/taishweb1.css"/>
<table id="tabwucUserRoleRelation2" cellspacing="1" cellpadding="1" width="600" border="0">
<tr>
<td class="NameTD">
<asp:Label id="lblUserId" runat="server" CssClass="NameControl">用户ID</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtUserId" runat="server" CssClass="ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblRoleId" runat="server" CssClass="NameControl">角色Id</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtRoleId" runat="server" CssClass="ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblPrjId" runat="server" CssClass="NameControl">项目编号</asp:Label>
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlPrjId" runat="server" CssClass="ValueControl"></asp:DropDownList>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblMemo" runat="server" CssClass="NameControl">备注</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtMemo" runat="server" CssClass="ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
</table>