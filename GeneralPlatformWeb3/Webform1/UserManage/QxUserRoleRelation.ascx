<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="QxUserRoleRelation.ascx.cs" Inherits="GeneralPlatform.Webform.QxUserRoleRelation" %>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabEdit" style="width: 70%" class="table table-bordered table-hover table td table-sm">
    <tr id="trRoleId">
        <td class="text-right">
            <asp:Label ID="lblUserId" name="lblUserId" CssClass="col-form-label text-right" Width="90px" Text="用户ID" runat="server" />
        </td>
        <td class="text-left">
            <asp:DropDownList ID="ddlUserId" name="ddlUserId" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td class="text-right">
            <asp:Label ID="lblRoleId" name="lblRoleId" CssClass="col-form-label text-right" Width="90px" Text="角色Id" runat="server" />
        </td>
        <td class="text-left">
            <asp:DropDownList ID="ddlRoleId" name="ddlRoleId" CssClass="form-control" Width="200px" runat="server" />
        </td>
    </tr>
    <tr id="trMemo">
        <td class="text-right">
            <asp:Label ID="lblQxPrjId" name="lblQxPrjId" CssClass="col-form-label text-right" Width="90px" Text="项目Id" runat="server" />
        </td>
        <td class="text-left">
            <asp:DropDownList ID="ddlQxPrjId" name="ddlQxPrjId" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td class="text-right">
            <asp:Label ID="lblMemo" name="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="备注" runat="server" />
        </td>
        <td class="text-left">
            <asp:TextBox ID="txtMemo" name="txtMemo" CssClass="form-control" Width="200px" runat="server" />
        </td>
    </tr>
</table>
