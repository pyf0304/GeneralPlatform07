<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucUserMenuDetailB.ascx.cs" Inherits="GeneralPlatform.Webform.wucUserMenuDetailB" %>
<link rel="stylesheet" type="text/css" href="../../Webform/css/taishweb1.css" />
<table id="tabwucUserMenuDetail" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMenuId" runat="server" CssClass="NameControl">菜单Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlMenuId" runat="server" CssClass="ValueControl"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMenuName" runat="server" CssClass="NameControl">菜单名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMenuName" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsDisp" runat="server" Text="是否显示" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUpMenuId" runat="server" CssClass="NameControl">上级菜单Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlUpMenuId" runat="server" CssClass="ValueControl"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblLinkFile" runat="server" CssClass="NameControl">链接文件</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtLinkFile" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblImgFile" runat="server" CssClass="NameControl">图像文件</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtImgFile" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsCustomMenu" runat="server" Text="是否定制菜单" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUserId" runat="server" CssClass="NameControl">用户ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlUserId" runat="server" CssClass="ValueControl"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjId" runat="server" CssClass="NameControl">项目Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjId" runat="server" CssClass="ValueControl"></asp:DropDownList>
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
            <asp:Label ID="lblMemo" runat="server" CssClass="NameControl">备注</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
