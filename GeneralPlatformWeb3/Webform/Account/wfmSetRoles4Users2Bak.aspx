<%@ Register TagPrefix="uc1" TagName="wucUsers" Src="wucUsers.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmSetRoles4Users2Bak" Codebehind="wfmSetRoles4Users2Bak.aspx.cs" Theme="TaiZeTheme"  %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>为用户设置角色</title>    
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="lblViewTitle" Style="z-index: 114; left: 8px; position: absolute;
            top: 8px" runat="server"  CssClass="PageTitleH1">用户管理->为用户设置角色</asp:Label>
        <table id="tabLayout" style="z-index: 105; left: 4px; position: absolute; top: 32px"
            cellspacing="2" cellpadding="2" width="300" border="0" runat="server">
            <tr>
                <td rowspan="4" style="width: 5px" valign="top">
                    <asp:TreeView ID="tvDepartments" runat="server" OnSelectedNodeChanged="tvDepartments_SelectedNodeChanged">
                        <SelectedNodeStyle BackColor="#8080FF" />
                    </asp:TreeView>
                </td>
                <td>
                </td>
                <td>
                </td>
                <td rowspan="2" style="width: 5px" valign="top">
                    <table id="Table1" border="0" cellpadding="0" cellspacing="0" class="content" style="width: 156px"
                        width="656">
                        <tr>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 174px" valign="top">
                                <asp:DropDownList ID="ddlPrjId" runat="server" AutoPostBack="True" Width="136px"
                                    OnSelectedIndexChanged="ddlPrjId_SelectedIndexChanged">
                                </asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td style="width: 174px" valign="top">
                                <asp:TreeView ID="tvRoles" runat="server" CssClass="content">
                                </asp:TreeView>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 174px; height: 41px" valign="top">
                                <asp:Button ID="btAddRoles" runat="server"   OnClick="btAddRoles_Click"
                                    Text="更新角色" Width="64px" />&nbsp;
                                <asp:Label ID="lblShow" runat="server"  Width="96px"></asp:Label></td>
                        </tr>
                    </table>
                    <asp:Button ID="btnSetRole4AllSelectedUser" runat="server"  
                        Text="为所选用户更新角色" Width="156px" OnClick="btnSetRole4AllSelectedUser_Click" /></td>
            </tr>
            <tr>
                <td valign="top">
                    <table id="tabUsersDataGrid" style="z-index: 225" cellspacing="0" cellpadding="0"
                        border="0" runat="server">
                        <tr>
                            <td style="height: 32px">
                                
                                <table style="width: 493px" cellpadding="0" cellspacing="0">
                                    <tr>
                                        <td>
                                    <asp:Label ID="lblUserId_q" runat="server"  
                                         Width="48px">用户ID</asp:Label></td>
                                        <td>
                                            <asp:TextBox
                                            ID="txtUserId_q" runat="server"  Width="74px"></asp:TextBox></td>
                                        <td>
                                    <asp:Label ID="lblUserName_q" runat="server"  
                                        
                                        Width="45px">用户名</asp:Label></td>
                                        <td>
                                    <asp:TextBox ID="txtUserName_q" runat="server"  Width="86px"></asp:TextBox></td>
                                        <td>
                                            <asp:Label ID="lblUserStateId_q" runat="server"
                                               Width="35px">身份</asp:Label></td>
                                        <td>
                                        <asp:DropDownList ID="ddlIdentityId_q" runat="server"  Width="61px">
                                        </asp:DropDownList>
                                        </td>
                                        <td>
                                    <asp:Button ID="btnQuery" runat="server"  
                                         OnClick="btnQuery_Click" Text="查询" Width="69px" /></td>
                                        <td style="width: 3px">
                                    <asp:DropDownList ID="ddlRecordNumPerPage" runat="server">
                                        <asp:ListItem>5</asp:ListItem>
                                        <asp:ListItem>10</asp:ListItem>
                                        <asp:ListItem>20</asp:ListItem>
                                        <asp:ListItem>50</asp:ListItem>
                                        <asp:ListItem>100</asp:ListItem>
                                        <asp:ListItem>1000</asp:ListItem>
                                    </asp:DropDownList></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 32px;">
                                <table style="display: inline; width: 503px;">
                                    <tr>
                                        <td>   <asp:Label ID="lblUsersList" Style="z-index: 100; " runat="server" CssClass="RegionTitleH1" >用户信息列表</asp:Label></td>
                                        <td><asp:Button ID="btShowRoles" runat="server"   OnClick="btShowRoles_Click"
                                        Style="z-index: 101; " Text="显示角色" Width="64px" /></td>
                                        <td><asp:Label ID="lblMsg" runat="server"   Style="z-index: 103; " Width="208px"></asp:Label></td>
                                        
                                    </tr>
                   
                                    
                                    
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 801px">
                                <asp:DataGrid ID="dgUsers" Style="z-index: 117; left: 10px; top: 145px" runat="server"
                                    Width="519px" AutoGenerateColumns="False" AllowPaging="True" 
                                     AllowSorting="True" BorderColor="#E7E7FF" BorderStyle="None"
                                    BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Horizontal" OnItemCommand="dgUsers_ItemCommand"
                                    OnItemCreated="dgUsers_ItemCreated" OnPageIndexChanged="dgUsers_PageIndexChanged"
                                    OnSortCommand="dgUsers_SortCommand">
                                    <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                    <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                    <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                    <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                    <Columns>
                                        <asp:TemplateColumn HeaderText="选择">
                                            <HeaderStyle Width="30px"></HeaderStyle>
                                            <HeaderTemplate>
                                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" CssClass="DgSelAll" runat="server"
                                                     >全选</asp:LinkButton>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn DataField="UserId" SortExpression="UserId" HeaderText="用户ID"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="UserName" SortExpression="UserName" HeaderText="用户名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="RoleName" HeaderText="角色" SortExpression="RoleName"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PrjName" HeaderText="工程" SortExpression="PrjName"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IdentityDesc" HeaderText="身份" SortExpression="IdentityDesc"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="DepartmentName" SortExpression="DepartmentName" HeaderText="部门">                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="UserStateName" SortExpression="UserStateName" HeaderText="用户状态" Visible="False"></asp:BoundColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                                    </PagerStyle>
                                </asp:DataGrid>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 801px" bgcolor="silver">
                                <table id="tabUsersJumpPage" style="width: 527px; font-family: Verdana;
                                    height: 26px" cellspacing="0" cellpadding="0" border="1" runat="server">
                                    <tr>
                                        <td style="height: 24px">
                                            <font style="background-color: #c0c0c0">共有记录:</font>
                                            <asp:Label ID="lblUsersRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 9px; height: 13px">
                                            </div>
                                            <font style="background-color: #c0c0c0">总页数:</font>
                                            <asp:Label ID="lblUsersAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 8px; height: 13px">
                                            </div>
                                            <font style="background-color: #c0c0c0">当前页:</font>
                                            <asp:Label ID="lblUsersCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 7px; height: 13px">
                                            </div>
                                            <asp:Button ID="btnUsersPrevPage" runat="server"  
                                                Width="50px" Text="上一页" OnClick="btnUsersPrevPage_Click"></asp:Button>
                                            <asp:Button ID="btnUsersNextPage" runat="server"  
                                                Width="50px" Text="下一页" OnClick="btnUsersNextPage_Click"></asp:Button>
                                            到第
                                            <asp:TextBox ID="txtUsersJump2Page" runat="server"  
                                                Width="21px"></asp:TextBox>页
                                            <asp:Button ID="btnUsersJumpPage" runat="server"  
                                                Width="35px" Text="确定" OnClick="btnUsersJumpPage_Click"></asp:Button>
                                            <asp:CompareValidator ID="UsersCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                ErrorMessage="错误！" ControlToValidate="txtUsersJump2Page" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td style="width: 5px">
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td style="width: 5px">
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
