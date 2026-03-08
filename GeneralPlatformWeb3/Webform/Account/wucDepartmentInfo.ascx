<%@ Control Language="C#" AutoEventWireup="true" Inherits="GeneralPlatform.Webform.wucDepartmentInfo" CodeBehind="wucDepartmentInfo.ascx.cs" %>
        <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link href="../../css/tz_base11.css" rel="stylesheet" />
<table id="tabwucDepartmentInfo" cellspacing="1" cellpadding="1" border="0" style="width: 664px">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDepartmentId" runat="server" CssClass="NameControl">部门Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDepartmentId" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblDepartmentName" runat="server" CssClass="NameControl">部门名</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDepartmentName" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDepartmentAbbrName" runat="server" CssClass="NameControl">名称缩写</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDepartmentAbbrName" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblOrderNum" runat="server" CssClass="NameControl" Width="60px">排序号</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtOrderNum" runat="server" CssClass="ValueControl"></asp:TextBox>
            <asp:CompareValidator ID="ComValid_OrderNum" runat="server" CssClass="ErrMsg" ErrorMessage="请输入整型数值!" ControlToValidate="txtOrderNum"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
            </asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUpDepartmentId" runat="server" CssClass="NameControl" Width="80px">所属部门号</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlUpDepartmentId" runat="server" CssClass="ValueControl"
                Width="145px">
            </asp:DropDownList>
        </td>
        <td>
            <asp:Label ID="lblDepartmentTypeId" runat="server" CssClass="NameControl" Width="90px">部门类型ID</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDepartmentTypeId" runat="server" CssClass="ValueControl"
                Width="146px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:CheckBox ID="chkInUse" runat="server" Text="是否使用"></asp:CheckBox>
        </td>
        <td class="ValueTD">&nbsp;</td>
        <td class="NameTD" colspan="2">&nbsp;</td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="NameControl">备注</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtMemo" runat="server" CssClass="ValueControl" Height="156px"
                TextMode="MultiLine" Width="500px"></asp:TextBox>
        </td>
    </tr>
</table>
