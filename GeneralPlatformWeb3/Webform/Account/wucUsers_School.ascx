<%@ Control Language="c#" AutoEventWireup="True" Inherits="GeneralPlatform.Webform.wucUsers_School"
    TargetSchema="http://schemas.microsoft.com/intellisense/ie5" Codebehind="wucUsers_School.ascx.cs" %>
        <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link href="../../css/tz_base11.css" rel="stylesheet" />
<table id="tabwucUsers" cellspacing="1" cellpadding="1" width="544" border="0" style="width: 544px;
    height: 173px">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUserId" runat="server"  
                CssClass="NameControl" Width="48px">用户ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtUserId" runat="server"  
                CssClass="ValueControl" Width="200px"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="lblStuIdTeacherId" runat="server"  
                CssClass="NameControl">学工号</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtStuIdTeacherId" runat="server"  
                CssClass="ValueControl" Width="184px"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDepartmentId" runat="server"  
                CssClass="NameControl">部门</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlDepartmentId" runat="server"  
                CssClass="ValueControl" Width="200px">
            </asp:DropDownList>
        </td>
        <td>
            <asp:Label ID="lblUserStateId" runat="server"  
                CssClass="NameControl" Width="57px">用户状态</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlUserStateId" runat="server"  
                CssClass="ValueControl" Width="184px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td class="NameTD" style="height: 25px">
            <asp:Label ID="lblIsLeaved" runat="server"  
                CssClass="NameControl">口令</asp:Label>
        </td>
        <td class="ValueTD" style="height: 25px">
    
        </td>
        <td style="height: 25px" colspan="2">
            <asp:CheckBox ID="chkIsLeaved" runat="server" Text="是否作为默认工程用户" CssClass="Check_Defa" Checked="True" /></td>
    </tr>
    <tr>
        <td class="NameTD" style="height: 25px">
            <asp:Label ID="lblDepartmentId0" runat="server"  
                CssClass="NameControl">用户身份</asp:Label>
        </td>
        <td class="ValueTD" style="height: 25px">
            <asp:DropDownList ID="ddlIdentityId" runat="server"  
                CssClass="ValueControl" Width="200px">
            </asp:DropDownList>
        </td>
          <td>
            <asp:Label ID="Label1" runat="server"  
                CssClass="NameControl">卡号</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtCardNo" runat="server"  
                CssClass="ValueControl" Width="184px"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server"   CssClass="NameControl">备注</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <font face="宋体">
                <asp:TextBox ID="txtMemo" runat="server"  
                    CssClass="ValueControl" Width="472px" Height="88px" TextMode="MultiLine"></asp:TextBox></font>
        </td>
    </tr>
</table>
