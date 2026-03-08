
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucQxUserRoleRelationB.ascx.cs" Inherits = "GeneralPlatform.Webform.wucQxUserRoleRelationB" %>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link rel = "stylesheet" type = "text/css" href = "../../css/tz_base11.css"/>
<table id = "tabwucQxUserRoleRelation" style = "width:600px; padding:1px;" border = "0">
<tr>
<td class = "NameTD">
<asp:Label id = "lblUserId" runat = "server" CssClass = "NameControl">用户ID</asp:Label>
</td>
<td class = "ValueTD">
<asp:DropDownList id = "ddlUserId" runat = "server" CssClass = "ValueControl"></asp:DropDownList>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblRoleId" runat = "server" CssClass = "NameControl">角色Id</asp:Label>
</td>
<td class = "ValueTD">
<asp:DropDownList id = "ddlRoleId" runat = "server" CssClass = "ValueControl"></asp:DropDownList>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblQxPrjId" runat = "server" CssClass = "NameControl">项目Id</asp:Label>
</td>
<td class = "ValueTD">
<asp:DropDownList id = "ddlQxPrjId" runat = "server" CssClass = "ValueControl"></asp:DropDownList>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblUpdDate" runat = "server" CssClass = "NameControl">修改日期</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtUpdDate" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblUpdUserId" runat = "server" CssClass = "NameControl">修改用户Id</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtUpdUserId" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblMemo" runat = "server" CssClass = "NameControl">备注</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtMemo" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
</table>