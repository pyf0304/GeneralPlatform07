
<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucRelaOfPotenceAndSymbolB.ascx.cs" Inherits="GeneralPlatform.Webform.wucRelaOfPotenceAndSymbolB" %>
        <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link href="../../css/tz_base11.css" rel="stylesheet" />
<table id="tabwucRelaOfPotenceAndSymbol" cellspacing="1" cellpadding="1" width="600" border="0">
<tr>
<td class="NameTD">
<asp:Label id="lblPotenceId" runat="server" CssClass="NameControl">权限ID</asp:Label>
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlPotenceId" runat="server" CssClass="ValueControl"></asp:DropDownList>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblSymbolForProgramme" runat="server" CssClass="NameControl">编程标志</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtSymbolForProgramme" runat="server" CssClass="ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblSymbolName" runat="server" CssClass="NameControl">标志名称</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtSymbolName" runat="server" CssClass="ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblUpdDate" runat="server" CssClass="NameControl">修改日期</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtUpdDate" runat="server" CssClass="ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblUpdUserId" runat="server" CssClass="NameControl">修改用户Id</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtUpdUserId" runat="server" CssClass="ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblPrjId" runat="server" CssClass="NameControl">项目Id</asp:Label>
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