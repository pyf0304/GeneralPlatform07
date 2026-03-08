<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmSetMenu4Users" Codebehind="wfmSetMenu4Users.aspx.cs" Theme="TaiZeTheme"  %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>wfmSetMenu4Users</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="lblUserId_q" Style="z-index: 111; left: 40px; position: absolute;
            top: 32px" runat="server" Width="56px" Height="15px"  >用户编号</asp:Label>
        <table id="Table1" style="z-index: 112; left: 40px; width: 300px; position: absolute;
            top: 112px; height: 16px" cellspacing="0" cellpadding="0" width="300" border="0">
            <tr>
                <td valign="top">
                    <asp:DataGrid ID="dgUsers" runat="server" Width="512px" Height="154px" Font-Names="宋体"
                         AutoGenerateColumns="False" PageSize="5" AllowPaging="True">
                        <Columns>
                            <asp:TemplateColumn>
                                <ItemTemplate>
                                    <asp:CheckBox ID="cb1" runat="server"></asp:CheckBox>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="UserId" HeaderText="用户编号"></asp:BoundColumn>
                            <asp:BoundColumn DataField="XM" HeaderText="姓名"></asp:BoundColumn>
                            <asp:BoundColumn DataField="DepartmentName" HeaderText="所属部门"></asp:BoundColumn>
                            <asp:BoundColumn DataField="RoleName" HeaderText="角色"></asp:BoundColumn>
                            <asp:BoundColumn DataField="PrjName" HeaderText="所属工程"></asp:BoundColumn>
                            <asp:BoundColumn DataField="IsUseRoleMenu" HeaderText="使用角色菜单"></asp:BoundColumn>
                            <asp:BoundColumn Visible="False" DataField="mId" HeaderText="mId"></asp:BoundColumn>
                        </Columns>
                        <PagerStyle Mode="NumericPages"></PagerStyle>
                    </asp:DataGrid></td>
            </tr>
            <tr>
                <td valign="top">
                    <asp:CheckBox ID="cbChooseAll" runat="server"  
                        Text="全选" AutoPostBack="True" OnCheckedChanged="cbChooseAll_CheckedChanged"></asp:CheckBox>
                    <asp:CheckBox ID="cdUseRoleMenu" runat="server"  
                        Text="是否使用角色菜单"></asp:CheckBox>
                    <asp:Button ID="btnMakeSure" runat="server"  
                         Width="56px" Text="确认提交" OnClick="btnMakeSure_Click"></asp:Button></td>
            </tr>
        </table>
        <asp:TextBox ID="txtUserId_q" Style="z-index: 101; left: 104px; position: absolute;
            top: 24px" runat="server" Width="100px" ></asp:TextBox>
        <asp:Label ID="lblXM_q" Style="z-index: 102; left: 40px; position: absolute; top: 64px"
            runat="server" Width="32px" Height="15px"  >姓名</asp:Label>
        <asp:TextBox ID="txtXM_q" Style="z-index: 103; left: 104px; position: absolute; top: 56px"
            runat="server" Width="100px" ></asp:TextBox>
        <asp:Label ID="lblBMH_q" Style="z-index: 104; left: 224px; position: absolute; top: 32px"
            runat="server" Width="56px" Height="15px"  >所属部门</asp:Label>
        <asp:DropDownList ID="ddlBMH_q" Style="z-index: 105; left: 288px; position: absolute;
            top: 24px" runat="server" Width="100px" >
        </asp:DropDownList>
        <asp:Label ID="lblRoleId_q" Style="z-index: 106; left: 416px; position: absolute;
            top: 32px" runat="server" Width="32px" Height="15px"  >角色</asp:Label>
        <asp:DropDownList ID="ddlRoleId_q" Style="z-index: 107; left: 456px; position: absolute;
            top: 24px" runat="server" Width="100px" >
        </asp:DropDownList>
        <asp:Button ID="btnQuery" Style="z-index: 108; left: 472px; position: absolute; top: 56px"
            runat="server" Width="80px"  Text="查询" OnClick="btnQuery_Click"></asp:Button>
        <asp:Label ID="lblRecCount" Style="z-index: 109; left: 224px; position: absolute;
            top: 64px" runat="server" Width="110px" Height="12px"  >查询结果记录数：</asp:Label>
        <asp:TextBox ID="txtRecCount" Style="z-index: 110; left: 336px; position: absolute;
            top: 56px" runat="server" Width="48px"   
            ReadOnly="True"></asp:TextBox>
    </form>
</body>
</html>
