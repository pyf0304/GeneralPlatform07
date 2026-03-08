
<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucExportExcel4UsersB.ascx.cs" Inherits="GeneralPlatform.Webform.wucExportExcel4UsersB" %>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link rel="stylesheet" type="text/css" href="../../css/tz_base11.css"/>
<table id="tabwucExportExcel4Users" cellspacing="1" cellpadding="1" width="600" border="0">
<tr>
<td class="NameTD">
<asp:Label id="lblid_ExportExcel4Users" runat="server" CssClass="NameControl">流水号</asp:Label>
</td>
<td class="ValueTD">
<asp:DropDownList id="ddlid_ExportExcel4Users" runat="server" 
        CssClass="ValueControl" Width="400px"></asp:DropDownList>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblFieldName" runat="server" CssClass="NameControl">字段名</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtFieldName" runat="server" CssClass="ValueControl" Width="400px"></asp:TextBox>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblFieldCnName" runat="server" CssClass="NameControl">中文名称</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtFieldCnName" runat="server" CssClass="ValueControl" 
        Width="400px"></asp:TextBox>
</td>
<td>
</td>
</tr>
<tr>
<td colspan="2">
<asp:CheckBox id="chkIsExport" runat="server" Text="是否导出" CssClass="Check_Defa"></asp:CheckBox>
</td>
<td>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblOrderNum" runat="server" CssClass="NameControl">序号</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtOrderNum" runat="server" CssClass="ValueControl" Width="400px"></asp:TextBox>
</td>
<td>
<asp:CompareValidator id="ComValid_OrderNum" runat="server" CssClass="ErrMsg" ErrorMessage="请输入整型数值!" ControlToValidate="txtOrderNum" 
Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
</asp:CompareValidator>
</td>
</tr>
<tr>
<td class="NameTD">
<asp:Label id="lblMemo" runat="server" CssClass="NameControl">备注</asp:Label>
</td>
<td class="ValueTD">
<asp:TextBox id="txtMemo" runat="server" CssClass="ValueControl" Width="400px" 
        Height="54px" TextMode="MultiLine"></asp:TextBox>
</td>
<td>
</td>
</tr>
</table>