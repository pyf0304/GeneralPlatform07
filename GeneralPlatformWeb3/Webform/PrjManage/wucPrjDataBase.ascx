<%@ Control Language="C#" AutoEventWireup="true" Inherits="GeneralPlatform.Webform.wucPrjDataBase" CodeBehind="wucPrjDataBase.ascx.cs" %>
        <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link href="../../css/tz_base11.css" rel="stylesheet" />
<table id="tabwucPrjDataBase" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjDataBaseId" runat="server" CssClass="NameControl">项目数据库Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPrjDataBaseId" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjDataBaseName" runat="server" CssClass="NameControl">项目数据库名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPrjDataBaseName" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDataBaseName" runat="server" CssClass="NameControl">数据库名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDataBaseName" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDatabaseOwner" runat="server" CssClass="NameControl">数据库拥有者</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDatabaseOwner" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDataBaseTypeId" runat="server" CssClass="NameControl">数据库类型ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlDataBaseTypeId" runat="server" CssClass="ValueControl"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDataBasePwd" runat="server" CssClass="NameControl">数据库用户口令</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDataBasePwd" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDataBaseUserId" runat="server" CssClass="NameControl">数据库用户Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDataBaseUserId" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblIpAddress" runat="server" CssClass="NameControl">IP地址</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtIpAddress" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSID" runat="server" CssClass="NameControl">SID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSID" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTableSpace" runat="server" CssClass="NameControl">表空间</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTableSpace" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUserId" runat="server" CssClass="NameControl">用户ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtUserId" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUpdDate" runat="server" CssClass="NameControl">UpdDate</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtUpdDate" runat="server" CssClass="ValueControl"></asp:TextBox>
        </td>
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
