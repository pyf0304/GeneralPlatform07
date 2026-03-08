
<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucExportExcelSetB.ascx.cs" Inherits="GeneralPlatform.Webform.wucExportExcelSetB" %>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link rel="stylesheet" type="text/css" href="../../css/tz_base11.css"/>
<table id="tabwucExportExcelSet" cellspacing="1" cellpadding="1" width="600" border="0">
<tr>
<td class="NameTD">
<asp:Label id="lblid_ExportExcel4Users" runat="server" CssClass="NameControl">流水号</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtid_ExportExcel4Users" runat="server" CssClass="ValueControl" 
        Width="400px"></asp:TextBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblViewName" runat="server" CssClass="NameControl">界面名称</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtViewName" runat="server" CssClass="ValueControl" Width="400px"></asp:TextBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblTabName" runat="server" CssClass="NameControl">表名</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtTabName" runat="server" CssClass="ValueControl" Width="400px"></asp:TextBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblUserID" runat="server" CssClass="NameControl">用户ID</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtUserID" runat="server" CssClass="ValueControl" Width="400px"></asp:TextBox>
</td>
</tr>
<tr>
<td colspan="2">
<asp:CheckBox id="chkIsDefaultUser" runat="server" Text="是否缺省用户" CssClass="Check_Defa"></asp:CheckBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblExportFileName" runat="server" CssClass="NameControl">导出文件名</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtExportFileName" runat="server" CssClass="ValueControl" 
        Width="400px"></asp:TextBox>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblMemo" runat="server" CssClass="NameControl">备注</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtMemo" runat="server" CssClass="ValueControl" Height="63px" 
        TextMode="MultiLine" Width="400px"></asp:TextBox>
</td>
</tr>
</table>