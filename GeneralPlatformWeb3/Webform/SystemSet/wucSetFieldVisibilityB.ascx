
<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucSetFieldVisibilityB.ascx.cs" Inherits="GeneralPlatform.Webform.wucSetFieldVisibilityB" %>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link href="../../css/tz_base11.css" rel="stylesheet" type="text/css" />
<table id="tabwucSetFieldVisibility" cellspacing="1" cellpadding="1" width="600" border="0">
<tr>
<td class="NameTD">
<asp:Label id="lblid_School" runat="server" CssClass="NameControl">学校</asp:Label>
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlid_School" Width="400px" runat="server" CssClass="ValueControl"></asp:DropDownList>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblViewName" runat="server" CssClass="NameControl">界面名称</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtViewName" Width="400px" runat="server" CssClass="ValueControl"></asp:TextBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblFieldName" runat="server" CssClass="NameControl">字段名</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtFieldName" Width="400px" runat="server" CssClass="ValueControl"></asp:TextBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblCtrlType" runat="server" CssClass="NameControl">控件类型</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtCtrlType" Width="400px" runat="server" CssClass="ValueControl"></asp:TextBox>
</td>
</tr>
<tr>
<td colspan="2">
<asp:CheckBox id="chkIsVisible" runat="server" Text="是否显示" CssClass="Check_Defa"></asp:CheckBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblMemo" runat="server" CssClass="NameControl">备注</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtMemo" Width="400px" runat="server" CssClass="ValueControl"></asp:TextBox>
</td>
</tr>
</table>