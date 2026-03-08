<%@ Control Language="C#" AutoEventWireup="true"
    Inherits="GeneralPlatform.Webform.wucQxPrjMenuSet" Codebehind="wucQxPrjMenuSet.ascx.cs" %>
        <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link href="../../css/tz_base11.css" rel="stylesheet" />
<table id="tabwucQxPrjMenuSet" cellspacing="1" cellpadding="1" border="0" style="width: 528px">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMenuSetId" runat="server" CssClass="NameControl">菜单集合Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMenuSetId" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMenuSetName" runat="server" CssClass="NameControl">菜单集合名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMenuSetName" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjId" runat="server" CssClass="NameControl">项目</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjId" runat="server" CssClass="ValueControl" Width="146px">
            </asp:DropDownList>
        </td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="Label1" runat="server" CssClass="NameControl">是否默认</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlIsDefault" runat="server" CssClass="ValueControl" Width="146px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="NameControl">备注</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" CssClass="ValueControl" Height="116px" Width="434px"></asp:TextBox>
        </td>
    </tr>
</table>
