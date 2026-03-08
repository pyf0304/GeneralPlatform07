<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucQxFuncModuleB.ascx.cs" Inherits="GeneralPlatform.Webform.wucQxFuncModuleB" %>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link rel="stylesheet" type="text/css" href="../../css/tz_base11.css" />
<table id="tabwucQxFuncModule" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncModuleId" runat="server" CssClass="NameControl">模块Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFuncModuleId" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncModuleName" runat="server" CssClass="NameControl">模块名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFuncModuleName" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncModuleName_Sim" runat="server" CssClass="NameControl">模块名_Sim</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFuncModuleName_Sim" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncModuleEnName" runat="server" CssClass="NameControl">模块英文名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFuncModuleEnName" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblOrderNum" runat="server" CssClass="NameControl">排序号</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtOrderNum" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_OrderNum" runat="server" CssClass="ErrMsg" ErrorMessage="请输入整型数值!" ControlToValidate="txtOrderNum"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblQxPrjId" runat="server" CssClass="NameControl">项目Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlQxPrjId" runat="server" CssClass="ValueControl"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkInUse" runat="server" Text="是否在用" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
  
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="NameControl">备注</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
