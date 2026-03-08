<%@ Register TagPrefix="uc1" TagName="wucQxPrjUserRelation" Src="../Account/wucQxPrjUserRelation.ascx" %>

<%@ Page Language="c#" AutoEventWireup="true"
    Inherits="GeneralPlatform.Webform.wfmQxPrjUserRelation4Synch_QUDI" CodeBehind="wfmPrjUserRelation4Synch_QUDI.aspx.cs"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/tr/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>工程用户关系维护</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
    <link href="../../css/General.css" rel="stylesheet" />

</head>

<body>
    <form id="form1" runat="server">
        <table id="tabLayout" style="z-index: 105; left: 0px; position: absolute; top: 0px"
            cellspacing="0" cellpadding="0" width="100%" border="0" runat="server">
            <tr>
                <td colspan="2" style="height: 34px">
                    <div style="position: relative; width: 648px; height: 28px; left: 0px; top: 0px;">
                        <asp:Label ID="lblViewTitle" runat="server" CssClass="PageTitleH1">工程用户关系维护
                        </asp:Label>
                        <asp:Label ID="lblMsg_List" runat="server" CssClass="ErrMsg" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                            Width="347px"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td rowspan="6" valign="top">
                    <asp:TreeView ID="tvProjects" runat="server" OnSelectedNodeChanged="tvProjects_SelectedNodeChanged">
                        <SelectedNodeStyle BackColor="#E0E0E0" />
                    </asp:TreeView>
                </td>
            </tr>
            <tr>
                <td valign="top">
                    <div id="tabQxPrjUserRelationGridView" style="width: 100%" runat="server">

                        <div id="divGridFunction">
                            <ul class="UlBanner">
                                <li>
                                    <asp:Label ID="lblQxPrjUserRelationList" runat="server" Style="z-index: 105; width:200px" CssClass="RegionTitleH1">工程用户关系列表</asp:Label>
                                </li>
                                
                                <li>
                                    <asp:Label ID="lblUserId_q" runat="server" Width="45px" CssClass="NameLabel">用户ID</asp:Label>
                                </li>
                                <li>
                                    <asp:TextBox ID="txtUserId_q" runat="server" Width="82px" CssClass="TextBox_Defa"></asp:TextBox>
                                </li>
                                                             
                                <li>
                                    <asp:Label ID="lblDepartmentId_q0" runat="server" CssClass="NameLabel" Style="z-index: 102;"
                                        Width="30px">部门</asp:Label>
                                </li>
                                <li>
                                    <asp:DropDownList ID="ddlDepartmentId_q1" runat="server" CssClass="TextBox_Defa"
                                        Style="z-index: 103;" Width="171px">
                                    </asp:DropDownList>
                                </li>
                                <li>
                                    <asp:Button ID="btnQuery" runat="server" Width="68px" Text="查询"
                                        CssClass="btn btn-outline-info btn-sm" OnClick="btnQuery_Click"></asp:Button>
                                </li>
                                <li>
                                    <asp:Button ID="btnAddUser4CurrPrj" runat="server" OnClick="btnAddUser4CurrRole_Click"
                                        Style="z-index: 106;" Text="添加用户" Width="92px" CssClass="btn btn-outline-info btn-sm" />
                                </li>
                                <li>
                                    <asp:Button ID="btnDelQxUser4CurrPrj" runat="server" OnClick="btnDelQxUser4CurrRole_Click"
                                        Style="z-index: 104;" Text="删除用户" Width="84px" CssClass="btn btn-outline-info btn-sm" />
                                </li>
                                <li>
                                    <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" Style="z-index: 107;"
                                        runat="server" Width="68px" CssClass="btn btn-outline-info btn-sm" Text="导出Excel"></asp:Button>
                                </li>
                                <li>
                                    <asp:Button ID="btnSetExportExcel4User" OnClick="btnSetExportExcel4User_Click" Style="z-index: 107;"
                                        CssClass="btn btn-outline-info btn-sm" runat="server" Width="100px" Text="设置导出字段"></asp:Button>
                                </li>



                            </ul>
                        </div>

                        <div style="height: 330px">
                            <asp:GridView ID="gvQxPrjUserRelation" Style="z-index: 111; position: relative;" runat="server"
                                Width="100%" AutoGenerateColumns="False" PageSize="10" AllowPaging="true" AllowSorting="true"
                                OnSorting="gvQxPrjUserRelation_Sorting" OnPageIndexChanging="gvQxPrjUserRelation_PageIndexChanging"
                                OnRowCreated="gvQxPrjUserRelation_RowCreated" OnRowCommand="gvQxPrjUserRelation_RowCommand"
                                OnRowDeleting="gvQxPrjUserRelation_RowDeleting" BackColor="White" BorderColor="#E7E7FF"
                                BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" DataKeyNames="mId"
                                CssClass="GridValue">
                                <Columns>
                                    <asp:TemplateField HeaderText="全选">
                                        <HeaderStyle Width="30px" />
                                        <HeaderTemplate>
                                            <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="DgSelAll">全选</asp:LinkButton>
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="mId" SortExpression="mId" HeaderText="流水号"></asp:BoundField>
                                    <asp:BoundField DataField="PrjName" SortExpression="PrjName" HeaderText="工程名"></asp:BoundField>
                                    <asp:BoundField DataField="UserId" SortExpression="UserId" HeaderText="用户ID"></asp:BoundField>
                                    <asp:BoundField DataField="UserName" SortExpression="UserName" HeaderText="用户名"></asp:BoundField>
                                    <asp:BoundField DataField="IdentityDesc" HeaderText="身份" SortExpression="IdentityDesc"></asp:BoundField>
                                    <asp:BoundField DataField="DepartmentName" SortExpression="DepartmentName" HeaderText="部门名"></asp:BoundField>
                                    <asp:BoundField DataField="UserStateName" SortExpression="UserStateName" HeaderText="用户状态名"></asp:BoundField>
                                    <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="备注"></asp:BoundField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lbDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
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
                                    <asp:Button ID="btnPrevPage" runat="server" CssClass="Button_DefaInPager" Text="上一页"
                                        Width="50px" CommandArgument="Prev" CommandName="Page" /><span style="font-family: Verdana">
                                        </span>
                                    <asp:Button ID="btnNextPage" runat="server" CssClass="Button_DefaInPager" Text="下一页"
                                        Width="50px" CommandArgument="Next" CommandName="Page" />
                                    到第
                                    <asp:TextBox ID="txtJump2Page" runat="server" CssClass="TextBox_DefaInPager" Width="35px"></asp:TextBox>页
                                    <asp:Button ID="btnJumpPage" runat="server" CssClass="Button_DefaInPager" OnClick="btnJumpPage_Click"
                                        Text="确定" Width="35px" CommandName="Page" />
                                    <span style="background-color: #c0c0c0">页记录数:</span>
                                    <asp:DropDownList ID="ddlPagerRecCount" runat="server" CssClass="DropDown_DefaInPager"
                                        Width="41px" AutoPostBack="True" OnSelectedIndexChanged="ddlPagerRecCount_QxPrjUserRelation_SelectedIndexChanged">
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
                        </div>
                    </div>
               
                    <div id="divUsers" style="margin-top:20px" runat="server">

                        <div>

                            <ul class="UlBanner">
                                <li>
                                    <asp:Label ID="lblUsersList" runat="server" CssClass="RegionTitleH1" Style="z-index: 107; width: 150px">被选用户列表</asp:Label>
                                </li>

                                <li>
                                    <asp:Label ID="Label1" runat="server" CssClass="NameLabel" Style="z-index: 100;"
                                        Width="45px">用户ID</asp:Label>
                                </li>
                                <li>
                                    <asp:TextBox ID="txtUserId_q2" runat="server" CssClass="TextBox_Defa" Style="z-index: 101;"
                                        Width="96px"></asp:TextBox>
                                </li>
                                <li>
                                    <asp:Label ID="lblDepartmentId_q" runat="server" CssClass="NameLabel" Style="z-index: 102;"
                                        Width="30px">部门</asp:Label>
                                </li>
                                <li>
                                    <asp:DropDownList ID="ddlDepartmentId_q2" runat="server" CssClass="TextBox_Defa"
                                        Style="z-index: 103;" Width="171px">
                                    </asp:DropDownList>
                                </li>

                                <li>
                                    <asp:Label ID="Label2" runat="server" CssClass="NameLabel" Style="z-index: 100;"
                                        Width="45px">用户名</asp:Label>
                                </li>
                                <li>
                                    <asp:TextBox ID="txtUserName_q2" runat="server" CssClass="TextBox_Defa" Style="z-index: 101;"
                                        Width="96px"></asp:TextBox>
                                </li>

                                <li>
                                    <asp:Button ID="btnQuery4Users" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="btnQuery4Users_Click"
                                        Style="z-index: 105;" Text="查询" Width="62px" />
                                </li>
                                <li>
                                    <asp:Button ID="btnAddNewRec4Gv" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="btnAddNewRec4Gv_Click"
                                        Style="z-index: 106;" Text="添加所选用户" Width="95px" />
                                </li>

                            </ul>

                        </div>

                        <div>

                            <asp:GridView ID="gvUsers" runat="server" AllowPaging="True" AllowSorting="True"
                                AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None"
                                BorderWidth="1px" CellPadding="3" CssClass="GridValue" DataKeyNames="UserId"
                                GridLines="Horizontal" OnPageIndexChanging="gvUsers_PageIndexChanging" OnRowCommand="gvUsers_RowCommand"
                                OnRowCreated="gvUsers_RowCreated" OnSorting="gvUsers_Sorting" Style="z-index: 117; position: relative"
                                Width="100%" OnSelectedIndexChanged="gvUsers_SelectedIndexChanged"
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
                                    <asp:BoundField DataField="IdentityDesc" HeaderText="身份" SortExpression="IdentityDesc"></asp:BoundField>
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

                        </div>

                    </div>

                </td>

            </tr>
        </table>
    </form>
</body>
</html>
