<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucQxUsers4Synch.ascx.cs" Inherits="GeneralPlatform.Webform.wucQxUsers4Synch" %>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<link href="../../Content/bootstrap-grid.css.map" rel="stylesheet" />
<table id="tabwucQxUsers4Synch" style="width: 600px; padding: 1px; border: 0px" class="table table-bordered table-hover">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblIpAddress" CssClass="col-form-label text-right" Width="90px" Text="IP地址" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtIpAddress" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUserId" CssClass="col-form-label text-right" Width="90px" Text="用户ID" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlUserId" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUserName" CssClass="col-form-label text-right" Width="90px" Text="用户名" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtUserName" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUserStateId" CssClass="col-form-label text-right" Width="90px" Text="用户状态Id" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlUserStateId" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblopenid" CssClass="col-form-label text-right" Width="90px" Text="微信openid" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtopenid" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblIdentityID" CssClass="col-form-label text-right" Width="90px" Text="身份编号" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtIdentityID" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblStuTeacherId" CssClass="col-form-label text-right" Width="90px" Text="学工号" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtStuTeacherId" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPassword" CssClass="col-form-label text-right" Width="90px" Text="口令" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPassword" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPhoneNumber" CssClass="col-form-label text-right" Width="90px" Text="电话号码" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPhoneNumber" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDepartmentId" CssClass="col-form-label text-right" Width="90px" Text="部门Id" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlDepartmentId" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblid_College" CssClass="col-form-label text-right" Width="90px" Text="学院流水号" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtid_College" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblEffectiveDate" CssClass="col-form-label text-right" Width="90px" Text="有效日期" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtEffectiveDate" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblEffitiveBeginDate" CssClass="col-form-label text-right" Width="90px" Text="有效开始日期" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtEffitiveBeginDate" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblEffitiveEndDate" CssClass="col-form-label text-right" Width="90px" Text="有效结束日期" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtEffitiveEndDate" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblEmail" CssClass="col-form-label text-right" Width="90px" Text="邮箱" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtEmail" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD"></td>
        <td class="ValueTD">
            <asp:CheckBox ID="chkIsArchive" name="chkIsArchive" CssClass="form-control" Width="200px" Text="是否存档" runat="server"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" CssClass="col-form-label text-right" Width="90px" Text="备注" runat="server" />
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" CssClass="form-control" Width="200px" runat="server" />
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
