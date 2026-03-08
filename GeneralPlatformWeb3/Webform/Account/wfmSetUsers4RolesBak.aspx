<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmSetUsers4RolesBak" CodeBehind="wfmSetUsers4RolesBak.aspx.cs" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>为角色设置用户</title>

            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/General.css" rel="stylesheet" />
    <link href="../../css/tz_base11.css" rel="stylesheet" />

    <style type="text/css">
        .style1 {
            height: 24px;
            width: 619px;
        }
    </style>
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="lblViewTitle" Style="z-index: 114; left: 8px; position: absolute; top: 8px"
            runat="server" CssClass="PageTitleH1">用户管理->为角色设置用户</asp:Label>
        <table id="tabLayout" style="z-index: 105; left: 4px; position: absolute; top: 32px"
            cellspacing="2" cellpadding="2" width="300" border="0" runat="server">
            <tr>
                <td rowspan="4" style="width: 5px" valign="top">
                    <table id="Table1" border="0" cellpadding="0" cellspacing="0" class="content" style="width: 156px"
                        width="656">
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="项目名称" CssClass="RegionTitleH2"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 174px" valign="top">
                                <asp:DropDownList ID="ddlPrjId" runat="server" AutoPostBack="True" Width="136px"
                                    OnSelectedIndexChanged="ddlPrjId_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 200px" valign="top">
                                <asp:TreeView ID="tvRoles" runat="server" CssClass="content" ExpandDepth="3" OnSelectedNodeChanged="tvRoles_SelectedNodeChanged" Width="200px">
                                </asp:TreeView>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 174px; height: 41px" valign="top"></td>
                        </tr>
                    </table>
                </td>
                <td>
                    <asp:Label ID="lblMsg_List" runat="server" CssClass="ErrMsg" Style="z-index: 105;"
                        Width="347px"></asp:Label>
                </td>
                <td></td>
                <td rowspan="2" style="width: 5px" valign="top"></td>
            </tr>
            <tr>
                <td valign="top">
                    <table id="tabUsersDataGrid" style="z-index: 225" cellspacing="0" cellpadding="0"
                        border="0" runat="server">
                        <tr>
                            <td style="height: 32px">
                                <div style="width: 633px" cellpadding="0" cellspacing="0">
                                    <ul class="UlBanner">
                                        <li >
                                            <asp:Label ID="lblUserId_q" runat="server"
                                                Width="48px">用户ID</asp:Label>
                                        </li>
                                        <li>
                                            <asp:TextBox ID="txtUserId_q" runat="server" Width="74px"></asp:TextBox>
                                        </li>
                                        <li >
                                            <asp:Label ID="lblUserName_q" runat="server"
                                                Width="45px">用户名</asp:Label>
                                        </li>
                                        <li>
                                            <asp:TextBox ID="txtUserName_q" runat="server" Width="86px"></asp:TextBox>
                                        </li>
                                        <li >
                                            <asp:Label ID="lblDepartmentId_q" runat="server" CssClass="NameLabel"
                                                Style="z-index: 102;" Width="30px">
部门</asp:Label>
                                        </li>
                                        <li style="width: 3px">
                                            <asp:DropDownList ID="ddlDepartmentId_q" runat="server" CssClass="TextBox_Defa"
                                                Style="z-index: 103;" Width="171px">
                                            </asp:DropDownList>
                                        </li>
                                 
                                        <li  align="right">
                                            <asp:Button ID="btnQuery" runat="server"
                                                OnClick="btnQuery_Click" Text="查询" Width="69px" CssClass="btn btn-outline-info btn-sm" />
                                            </li>
                                        <li>
                                            <asp:Button ID="btnAddUser4CurrPrj" runat="server" OnClick="btnAddUser4CurrRole_Click"
                                                Style="z-index: 106;" Text="添加用户" Width="87px" CssClass="btn btn-outline-info btn-sm" />
                                        </li>
                                        <li></li>
                                        <li>
                                            <asp:Button ID="btnDelQxUser4CurrPrj" runat="server" OnClick="btnDelQxUser4CurrRole_Click"
                                                Style="z-index: 104;" Text="删除用户" Width="88px" CssClass="btn btn-outline-info btn-sm" />
                                        </li>

                                    </ul>

                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 32px;">
                                <table style="display: inline; width: 503px;">
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblUserRoleRelationList" Style="z-index: 100;" runat="server" CssClass="RegionTitleH1">所有用户角色关系列表</asp:Label></td>
                                        <td>
                                            <asp:Label ID="lblMsg" runat="server"
                                                Style="z-index: 103;" Width="208px"></asp:Label></td>
                                        <td></td>
                                    </tr>


                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 801px">
                                <asp:DataGrid ID="dgUserRoleRelation" Style="z-index: 117; left: 10px; top: 145px"
                                    runat="server" Width="656px" AutoGenerateColumns="False" AllowPaging="True"
                                    AllowSorting="True" BorderColor="#E7E7FF" BorderStyle="None"
                                    BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Horizontal" OnItemCommand="dgUsers_ItemCommand"
                                    OnItemCreated="dgUsers_ItemCreated" OnPageIndexChanged="dgUsers_PageIndexChanged"
                                    OnSortCommand="dgUsers_SortCommand" DataKeyField="mId">
                                    <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                    <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                    <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                    <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                    <Columns>
                                        <asp:TemplateColumn HeaderText="选择">
                                            <HeaderStyle Width="30px"></HeaderStyle>
                                            <HeaderTemplate>
                                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" CssClass="DgSelAll" runat="server">全选</asp:LinkButton>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn DataField="UserId" SortExpression="UserId" HeaderText="用户ID"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="UserName" SortExpression="UserName" HeaderText="用户名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="RoleName" HeaderText="角色" SortExpression="RoleName"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IdentityDesc" HeaderText="身份" SortExpression="IdentityDesc"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PrjName" HeaderText="工程" SortExpression="PrjName"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="DepartmentName" SortExpression="DepartmentName" HeaderText="部门"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="UserStateName" SortExpression="UserStateName" HeaderText="用户状态"
                                            Visible="False"></asp:BoundColumn>
                                        <asp:TemplateColumn>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
                                </asp:DataGrid>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 801px" bgcolor="silver">
                                <table id="tabUsersJumpPage" style="width: 627px; font-family: Verdana; height: 26px"
                                    cellspacing="0" cellpadding="0" border="1" runat="server">
                                    <tr>
                                        <td class="style1">
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
                                            <asp:DropDownList ID="ddlRecordNumPerPage" runat="server"
                                                OnSelectedIndexChanged="ddlRecordNumPerPage_SelectedIndexChanged"
                                                AutoPostBack="True">
                                                <asp:ListItem>5</asp:ListItem>
                                                <asp:ListItem>10</asp:ListItem>
                                                <asp:ListItem>20</asp:ListItem>
                                                <asp:ListItem>50</asp:ListItem>
                                                <asp:ListItem>100</asp:ListItem>
                                                <asp:ListItem>1000</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:CompareValidator ID="UsersCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                ErrorMessage="错误！" ControlToValidate="txtUsersJump2Page" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
                <td></td>
            </tr>
            <tr>
                <td></td>
            </tr>
            <tr>
                <td valign="top">
                    <table id="tabUsersGridView" runat="server" style="width: 552px">
                        <tr>
                            <td>
                                <div style="width: 100%;">
                                    <ul class="UlBanner">
                                        <li></li>
                                        <li align="right">
                                            <asp:Label ID="Label2" runat="server" CssClass="NameLabel" Style="z-index: 100;"
                                                Width="45px">用户ID</asp:Label>
                                        </li>
                                        <li>
                                            <asp:TextBox ID="txtUserId_q2" runat="server" CssClass="TextBox_Defa"
                                                Style="z-index: 101;" Width="96px"></asp:TextBox>
                                        </li>
                                        <li align="right">
                                            <asp:Label ID="Label5" runat="server" CssClass="NameLabel" Style="z-index: 100;"
                                                Width="45px">用户名</asp:Label>
                                        </li>
                                        <li>
                                            <asp:TextBox ID="txtUserName_q2" runat="server" CssClass="TextBox_Defa"
                                                Style="z-index: 101;" Width="96px"></asp:TextBox>
                                        </li>
                                        <li align="right">
                                            <asp:Label ID="Label3" runat="server" CssClass="NameLabel" Style="z-index: 102; right: 346px;"
                                                Width="30px">部门</asp:Label>
                                        </li>
                                        <li>
                                            <asp:DropDownList ID="ddlDepartmentId_q2" runat="server" CssClass="TextBox_Defa"
                                                Style="z-index: 103;" Width="171px">
                                            </asp:DropDownList>
                                        </li>




                                        <li align="right" colspan="2">
                                            <asp:Button ID="btnQuery4Users" runat="server" CssClass="btn btn-outline-info btn-sm"
                                                OnClick="btnQuery4Users_Click" Style="z-index: 105;" Text="查询" Width="62px" />
                                        </li>
                                        <li align="right">
                                            <asp:Button ID="btnAddNewRec4Gv" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="btnAddNewRec4Gv_Click"
                                                Style="z-index: 106;" Text="添加所选用户" Width="95px" />
                                        </li>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" CssClass="RegionTitleH1" Style="z-index: 107;">以下用户列表可供选择</asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:GridView ID="gvUsers" runat="server" AllowPaging="True" AllowSorting="True"
                                    AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None"
                                    BorderWidth="1px" CellPadding="3" CssClass="GridValue" DataKeyNames="UserId"
                                    GridLines="Horizontal" Height="1px" OnPageIndexChanging="gvUsers_PageIndexChanging"
                                    OnRowCommand="gvUsers_RowCommand" OnRowCreated="gvUsers_RowCreated" OnSorting="gvUsers_Sorting"
                                    Style="z-index: 117; position: relative" Width="663px" OnSelectedIndexChanged="gvUsers_SelectedIndexChanged"
                                    DataSourceID="">
                                    <Columns>
                                        <asp:TemplateField HeaderText="全选">
                                            <HeaderStyle Width="30px" />
                                            <HeaderTemplate>
                                                <asp:LinkButton ID="lbSelAll" runat="server" CommandName="lbSelAll" CssClass="DgSelAll">全选</asp:LinkButton>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="UserId" HeaderText="用户ID" SortExpression="UserId" />
                                        <asp:BoundField DataField="UserName" HeaderText="用户名" SortExpression="UserName" />
                                        <asp:BoundField DataField="IdentityDesc" HeaderText="身份" SortExpression="IdentityDesc" />
                                        <asp:BoundField DataField="DepartmentName" HeaderText="部门" SortExpression="DepartmentName" />
                                        <asp:BoundField DataField="UserStateName" HeaderText="用户状态" SortExpression="UserStateName" />
                                        <asp:BoundField DataField="Password" HeaderText="口令" SortExpression="Password" Visible="False" />
                                        <asp:BoundField DataField="Memo" HeaderText="备注" SortExpression="Memo" />
                                        <asp:ButtonField Text="添加用户" CommandName="AddUser" />
                                    </Columns>
                                    <PagerTemplate>
                                        <span style="background-color: #c0c0c0">共有记录:</span>
                                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066"
                                            Width="26px">0</asp:Label>
                                        <span style="background-color: #c0c0c0">
                                            <div style="display: inline; width: 16px; height: 13px">
                                            </div>
                                        </span><span style="background-color: #c0c0c0">总页数:</span>
                                        <asp:Label ID="lblAllPages" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <span style="background-color: #c0c0c0">当前页:</span>
                                        <asp:Label ID="lblCurrentPage" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <asp:Button ID="btnPrevPage" runat="server" CommandArgument="Prev" CommandName="Page"
                                            CssClass="Button_DefaInPager" Text="上一页" Width="50px" /><span style="font-family: Verdana">
                                            </span>
                                        <asp:Button ID="btnNextPage" runat="server" CommandArgument="Next" CommandName="Page"
                                            CssClass="Button_DefaInPager" Text="下一页" Width="50px" />
                                        到第
                                    <asp:TextBox ID="txtJump2Page" runat="server" CssClass="TextBox_DefaInPager" Width="35px"></asp:TextBox>页
                                    <asp:Button ID="btnJumpPage" runat="server" CommandName="Page" CssClass="Button_DefaInPager"
                                        OnClick="btnJumpPage_Click" Text="确定" Width="35px" />
                                        <span style="background-color: #c0c0c0">页记录数:</span>
                                        <asp:DropDownList ID="ddlPagerRecCount" runat="server" CssClass="DropDown_DefaInPager"
                                            Width="41px" AutoPostBack="True" OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged">
                                            <asp:ListItem>5</asp:ListItem>
                                            <asp:ListItem>10</asp:ListItem>
                                            <asp:ListItem>20</asp:ListItem>
                                            <asp:ListItem>30</asp:ListItem>
                                            <asp:ListItem>50</asp:ListItem>
                                            <asp:ListItem>100</asp:ListItem>
                                            <asp:ListItem>1000</asp:ListItem>
                                            <asp:ListItem></asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
                                            ErrorMessage="错误！" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                                    </PagerTemplate>
                                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                    <AlternatingRowStyle BackColor="#F7F7F7" />
                                </asp:GridView>
                            </td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td style="width: 5px"></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td style="width: 5px"></td>
            </tr>
        </table>
    </form>
</body>
</html>
