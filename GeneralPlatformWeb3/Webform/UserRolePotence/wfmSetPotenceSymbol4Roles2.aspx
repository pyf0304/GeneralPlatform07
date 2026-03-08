<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmSetPotenceSymbol4Roles2" Codebehind="wfmSetPotenceSymbol4Roles2.aspx.cs"  Theme="TaiZeTheme" %>

<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>


<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>为角色设置用户</title>
                <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
    <link href="../../tzTreeViewWuc/cssTreeView.css" rel="stylesheet" />
    <style type="text/css">
        .style1
        {
            height: 24px;
            width: 619px;
        }
    </style>
</head>
<body>
    <form id="Form1" method="post" runat="server">
    <asp:Label ID="lblViewTitle" Style="z-index: 114; left: 8px; position: absolute;
        top: 8px" runat="server"  CssClass="PageTitleH1">用户管理->为角色设置用户</asp:Label>
    <table id="tabLayout" style="border-color: #C0C0C0; z-index: 105; left: 4px; position: absolute;
        top: 32px" cellspacing="2" cellpadding="2" width="300" border="2" runat="server">
        <tr>
            <td rowspan="4" style="width: 5px" valign="top">
                <table id="Table1" border="0" cellpadding="0" cellspacing="0" class="content" style="width: 156px"
                    width="656">
                    <tr>
                        <td style="background-color: #C0C0C0">
                            <asp:Label ID="Label8" runat="server" Text="角色树" CssClass="RegionTitleH1"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="项目名称" CssClass="RegionTitleH1"></asp:Label>
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
                        <td style="width: 174px" valign="top">
                           <%-- <asp:TreeView ID="tvRoles" runat="server" CssClass="content" ExpandDepth="3" OnSelectedNodeChanged="tvRoles_SelectedNodeChanged"
                                Width="119px">
                            </asp:TreeView>--%>
                            <uc1:wucTreeView runat="server" ID="wucTreeView1"  OnafterSelect_Tz="wucTreeView1_afterSelect_Tz"  />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td valign="top">
                <table id="tabUsersDataGrid" style="border-color: #C0C0C0; z-index: 225" cellspacing="1"
                    cellpadding="1" border="0" runat="server">
                    <tr>
                        <td style="background-color: #C0C0C0">
                                        <asp:Label ID="lblUserGroupPotenceList0" Style="z-index: 100;" 
                                runat="server" CssClass="RegionTitleH1"
                                            >当前角色所有用户列表</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="background-color: #000080; line-height: 2px;">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td style="height: 32px">
                            <table style="width: 633px" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="lblPotenceTypeId_q" runat="server" CssClass="NameLabel" 
                                            Style="z-index: 102;" Width="67px">
权限类型</asp:Label>
                                    </td>
                                    <td style="width: 3px">
                                        <asp:DropDownList ID="ddlPotenceTypeId_q" runat="server" CssClass="TextBox_Defa"
                                             Style="z-index: 103;" Width="171px" AutoPostBack="True" OnSelectedIndexChanged="ddlPotenceTypeId_q_SelectedIndexChanged">
                                        </asp:DropDownList>
                                    </td>
                                    <td align="right">
                                        <asp:Label ID="lblUserName_q" runat="server"  
                                             Width="45px">权限名</asp:Label>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlPotenceId_q" runat="server"  Width="80px">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td colspan="2">
                                        &nbsp;
                                    </td>
                                    <td colspan="5" align="right">
                                        <asp:Button ID="btnQuery" runat="server"  
                                             OnClick="btnQuery_Click" Text="查询" Width="69px" />
                                        <asp:Button ID="btnAddPotence4CurrRole" runat="server"  OnClick="btnAddUser4CurrRole_Click"
                                            Style="z-index: 106;" Text="添加权限" Width="68px" />
                                        <asp:Button ID="btnDelPotence4CurrRole" runat="server"  OnClick="btnDelQxUser4CurrRole_Click"
                                            Style="z-index: 104;" Text="删除权限" Width="67px" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 32px;">
                            <table>
                                <tr>
                                    <td width="250">
                                        <asp:Label ID="lblUserGroupPotenceList" Style="z-index: 100;" runat="server" CssClass="RegionTitleH1"
                                            >所有用户角色关系列表</asp:Label>
                                    </td>
                                    <td>
                                        <asp:Label ID="lblMsg_List" runat="server" CssClass="ErrMsg"  Style="z-index: 105;"
                                            Width="347px"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 801px">
                            <asp:DataGrid ID="dgUserGroupPotence" Style="z-index: 117; left: 10px; top: 145px"
                                runat="server" Width="656px" AutoGenerateColumns="False" AllowPaging="True" 
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
                                    <asp:BoundColumn DataField="RoleId" SortExpression="RoleId" HeaderText="角色ID"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="RoleName" HeaderText="角色" SortExpression="RoleName">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="PrjName" HeaderText="工程" SortExpression="PrjName"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="PotenceName" SortExpression="PotenceName" HeaderText="权限">
                                    </asp:BoundColumn>
                                    <asp:BoundColumn DataField="SymbolForProgramme" SortExpression="SymbolForProgramme"
                                        HeaderText="编程序号" Visible="True"></asp:BoundColumn>
                                    <asp:BoundColumn DataField="SymbolName" SortExpression="SymbolName" HeaderText="等级名称"
                                        Visible="True"></asp:BoundColumn>
                                    <asp:TemplateColumn>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lbDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateColumn>
                                </Columns>
                                <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                                </PagerStyle>
                            </asp:DataGrid>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 801px" bgcolor="silver">
                            <table id="tabUsersJumpPage" style="width: 627px; font-family: Verdana;
                                height: 26px" cellspacing="0" cellpadding="0" border="1" runat="server">
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
                                        <asp:DropDownList ID="ddlRecordNumPerPage" runat="server" OnSelectedIndexChanged="ddlRecordNumPerPage_SelectedIndexChanged"
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
        </tr>
        <tr>
            <td>
            </td>
        </tr>
        <tr>
            <td valign="top">
                <table id="tabUsersGridView" runat="server" style="width: 552px" border="0" 
                    cellpadding="1" cellspacing="1">
                    <tr>
                        <td style="background-color: #C0C0C0">
                                        <asp:Label ID="lblUserGroupPotenceList1" Style="z-index: 100;" 
                                runat="server" CssClass="RegionTitleH1"
                                             Width="130px">待选用户列表</asp:Label>
                                        <asp:Label ID="lblUserGroupPotenceList2" Style="z-index: 100;" 
                                runat="server" CssClass="RegionTitleH3"
                                            >供添加到当前所选角色</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="line-height: 2px; background-color: #000080">
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <table style="width: 100%;">
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="Label6" runat="server" CssClass="NameLabel"  Style="z-index: 102;"
                                            Width="67px">
权限类型</asp:Label>
                                    </td>
                                    <td style="width: 3px">
                                        <asp:DropDownList ID="ddlPotenceTypeId_q2" runat="server" CssClass="TextBox_Defa"
                                             Style="z-index: 103;" Width="171px" AutoPostBack="True" OnSelectedIndexChanged="ddlPotenceTypeId_q2_SelectedIndexChanged">
                                        </asp:DropDownList>
                                    </td>
                                    <td align="right">
                                        <asp:Label ID="Label7" runat="server"   
                                            Width="45px">权限名</asp:Label>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlPotenceId_q2" runat="server"  Width="80px">
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                    </td>
                                    <td align="right">
                                        &nbsp;
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td align="right">
                                        &nbsp;
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td align="right" colspan="2">
                                        <asp:Button ID="btnQuery4Users" runat="server" CssClass="btn btn-outline-info btn-sm" 
                                            OnClick="btnQuery4Users_Click" Style="z-index: 105;" Text="查询" Width="62px" />
                                        <asp:Button ID="btnAddNewRec4Gv" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="btnAddNewRec4Gv_Click"
                                            Style="z-index: 106;" Text="添加所选权限" Width="95px" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" CssClass="RegionTitleH1"  Style="z-index: 107;">以下用户列表可供选择</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:GridView ID="gvRelaOfPotenceAndSymbol" runat="server" AllowPaging="True" AllowSorting="True"
                                AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None"
                                BorderWidth="1px" CellPadding="3" CssClass="GridValue" DataKeyNames="RelaMid"
                                GridLines="Horizontal" Height="1px" OnPageIndexChanging="gvRelaOfPotenceAndSymbol_PageIndexChanging"
                                OnRowCommand="gvRelaOfPotenceAndSymbol_RowCommand" OnRowCreated="gvRelaOfPotenceAndSymbol_RowCreated"
                                OnSorting="gvRelaOfPotenceAndSymbol_Sorting" Style="z-index: 117; position: relative"
                                Width="663px" OnSelectedIndexChanged="gvRelaOfPotenceAndSymbol_SelectedIndexChanged"
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
                                    <asp:BoundField DataField="PotenceId" HeaderText="权限ID" SortExpression="PotenceId" />
                                    <asp:BoundField DataField="PotenceName" HeaderText="权限名" SortExpression="PotenceName" />
                                    <asp:BoundField DataField="SymbolForProgramme" SortExpression="SymbolForProgramme"
                                        HeaderText="编程序号" Visible="True"></asp:BoundField>
                                    <asp:BoundField DataField="SymbolName" SortExpression="SymbolName" HeaderText="等级名称"
                                        Visible="True"></asp:BoundField>
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
        </tr>
    </table>
    </form>
</body>
</html>
