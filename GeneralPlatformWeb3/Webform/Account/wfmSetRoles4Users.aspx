<%@ Register TagPrefix="uc1" TagName="wucUsers" Src="wucUsers.ascx" %>

<%@ Page Language="c#" AutoEventWireup="false"
    Inherits="GeneralPlatform.Webform.wfmUsers_Q" CodeBehind="wfmSetRoles4Users.aspx.cs"  Theme="TaiZeTheme" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>表Users的查询修改记录</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="lblTitle" Style="z-index: 101; left: 8px; position: absolute; top: 8px"
            runat="server" Width="112px"   >用户角色关系维护</asp:Label>
        <asp:Label ID="lblUserId_q" Style="z-index: 102; left: 8px; position: absolute; top: 32px"
            runat="server"   Width="56px" Height="15px">用户编号</asp:Label>
        <asp:TextBox ID="txtUserId_q" Style="z-index: 103; left: 72px; position: absolute; top: 32px"
            runat="server" Width="100px"></asp:TextBox>
        <asp:Label ID="lblUserName_q" Style="z-index: 104; left: 8px; position: absolute; top: 56px"
            runat="server"   Width="56px"
            Height="15px">用户姓名</asp:Label>
        <asp:TextBox ID="txtUserName_q" Style="z-index: 105; left: 72px; position: absolute; top: 56px"
            runat="server" Width="100px"></asp:TextBox>
        <asp:Label ID="lblDepartmentId_q" Style="z-index: 106; left: 176px; position: absolute; top: 32px"
            runat="server"   Width="56px"
            Height="15px">所属部门</asp:Label>
        <asp:DropDownList ID="ddlDepartmentId_q" Style="z-index: 107; left: 240px; position: absolute; top: 32px"
            runat="server" Width="100px">
        </asp:DropDownList>
        <asp:Label ID="lblUserStateId_q" Style="z-index: 108; left: 176px; position: absolute; top: 56px"
            runat="server"   Width="56px"
            Height="15px">用户状态</asp:Label>
        <asp:DropDownList ID="ddlUserStateId_q" Style="z-index: 109; left: 240px; position: absolute; top: 56px"
            runat="server" Width="100px">
        </asp:DropDownList>
        <asp:Button ID="btnQuery" Style="z-index: 110; left: 376px; position: absolute; top: 56px"
            runat="server" Width="80px" Text="查询"></asp:Button>
        <table id="Table1" style="z-index: 111; left: 8px; width: 656px; position: absolute; top: 96px"
            cellspacing="0" cellpadding="0" width="656" border="0">
            <tr>
                <td valign="top">
                    <asp:Label ID="lblRecCount" runat="server" Width="110px" Height="12px" 
                        >查询结果记录数：</asp:Label>
                    <asp:TextBox ID="txtRecCount" runat="server" Width="111px" 
                         ReadOnly="True"></asp:TextBox></td>
                <td valign="top">
                    <asp:DropDownList ID="ddlPrjId" runat="server" Width="136px" AutoPostBack="True"
                        OnSelectedIndexChanged="ddlPrjId_SelectedIndexChanged">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td valign="top">
                    <asp:DataGrid ID="dgUsers" runat="server" Width="463px" AutoGenerateColumns="False"
                        PageSize="5" AllowPaging="True" Font-Names="宋体"  BorderColor="#E7E7FF"
                        BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Horizontal">
                        <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                        <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                        <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                        <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                        <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                        <Columns>
                            <asp:TemplateColumn>
                                <HeaderStyle Width="6%"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:CheckBox ID="cb1" runat="server"></asp:CheckBox>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="UserId" HeaderText="用户编号">
                                <HeaderStyle Width="20%"></HeaderStyle>
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="UserName" HeaderText="用户姓名">
                                <HeaderStyle Width="20%"></HeaderStyle>
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="DepartmentName" HeaderText="所属部门">
                                <HeaderStyle Width="30%"></HeaderStyle>
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="UserStateName" HeaderText="用户状态">
                                <HeaderStyle Width="15%"></HeaderStyle>
                            </asp:BoundColumn>
                            <asp:BoundColumn Visible="False" DataField="Password" HeaderText="密码"></asp:BoundColumn>
                            <asp:BoundColumn Visible="False" DataField="Memo" HeaderText="备注"></asp:BoundColumn>
                        </Columns>
                        <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
                    </asp:DataGrid></td>
                <td valign="top">
                    <asp:TreeView ID="tvRoles" runat="server" ExpandLevel="2">
                    </asp:TreeView>
                </td>
            </tr>
            <tr>
                <td valign="top">
                    <asp:CheckBox ID="cbChooseAll" runat="server"  
                        Width="48px" Text="选全" AutoPostBack="True"></asp:CheckBox>
                    <asp:Button ID="btShowRoles" runat="server"  
                        Width="64px" Text="显示角色"></asp:Button></td>
                <td valign="top">
                    <asp:Button ID="btAddRoles" runat="server"  
                        Width="64px" Text="更新角色"></asp:Button>
                    <asp:Label ID="lblShow" runat="server"   Width="96px"></asp:Label></td>
            </tr>
        </table>
    </form>
</body>
</html>
