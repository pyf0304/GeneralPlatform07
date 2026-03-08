
<%@ Control Language = "C#" AutoEventWireup = "True" CodeBehind = "wucQxUsersB.ascx.cs" Inherits = "GeneralPlatform.Webform.wucQxUsersB" %>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link rel = "stylesheet" type = "text/css" href = "../../css/tz_base11.css"/>
<table id = "tabwucQxUsers" style = "width:600px; padding:1px;" border = "0">
<tr>
<td class = "NameTD">
<asp:Label id = "lblUserId" runat = "server" CssClass = "NameControl">用户ID</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtUserId" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblUserName" runat = "server" CssClass = "NameControl">用户名</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtUserName" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblDepartmentId" runat = "server" CssClass = "NameControl">部门Id</asp:Label>
</td>
<td class = "ValueTD">
<asp:DropDownList id = "ddlDepartmentId" runat = "server" CssClass = "ValueControl"></asp:DropDownList>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblUserStateId" runat = "server" CssClass = "NameControl">用户状态Id</asp:Label>
</td>
<td class = "ValueTD">
<asp:DropDownList id = "ddlUserStateId" runat = "server" CssClass = "ValueControl"></asp:DropDownList>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblEffectiveDate" runat = "server" CssClass = "NameControl">有效日期</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtEffectiveDate" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblPassword" runat = "server" CssClass = "NameControl">口令</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtPassword" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblid_College" runat = "server" CssClass = "NameControl">学院流水号</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtid_College" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblEffitiveBeginDate" runat = "server" CssClass = "NameControl">有效开始日期</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtEffitiveBeginDate" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblEffitiveEndDate" runat = "server" CssClass = "NameControl">有效结束日期</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtEffitiveEndDate" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblStuTeacherId" runat = "server" CssClass = "NameControl">学工号</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtStuTeacherId" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblIdentityID" runat = "server" CssClass = "NameControl">身份编号</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtIdentityID" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td>
<asp:CheckBox id = "chkIsArchive" runat = "server" Text = "是否存档" CssClass = "Check_Defa"></asp:CheckBox>
</td>
<td>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblopenid" runat = "server" CssClass = "NameControl">微信openid</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtopenid" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblEmail" runat = "server" CssClass = "NameControl">邮箱</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtEmail" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblPhoneNumber" runat = "server" CssClass = "NameControl">电话号码</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtPhoneNumber" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td>
<asp:CheckBox id = "chkIsSynch" runat = "server" Text = "是否同步" CssClass = "Check_Defa"></asp:CheckBox>
</td>
<td>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblSynchDate" runat = "server" CssClass = "NameControl">同步日期</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtSynchDate" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblUpdDate" runat = "server" CssClass = "NameControl">修改日期</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtUpdDate" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblUpdUser" runat = "server" CssClass = "NameControl">修改用户</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtUpdUser" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
<tr>
<td class = "NameTD">
<asp:Label id = "lblMemo" runat = "server" CssClass = "NameControl">备注</asp:Label>
</td>
<td class = "ValueTD">
<asp:TextBox id = "txtMemo" runat = "server" CssClass = "ValueControl"></asp:TextBox>
</td>
<td>
</td>
<td></td>
</tr>
</table>