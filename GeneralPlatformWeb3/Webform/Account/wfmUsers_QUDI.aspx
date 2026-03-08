<%@ Register TagPrefix="uc1" TagName="wucUsers" Src="wucUsers.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" Inherits="GeneralPlatform.Webform.wfmUsers_QUDI" Codebehind="wfmUsers_QUDI.aspx.cs"  Theme="TaiZeTheme" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>表Users的查询、修改、删除、添加记录</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="lblViewTitle" Style="z-index: 114; left: 8px; position: absolute;
            top: 8px" runat="server"  CssClass="PageTitleH1">用户信息维护</asp:Label>
        <table id="tabLayout" style="z-index: 105; left: 4px; position: absolute; top: 32px"
            cellspacing="2" cellpadding="2" width="300" border="0" runat="server">
            <tr>
                <td>
                    <div id="divUsers" style="z-index: 119; width: 769px; position: relative; height: 57px"
                        runat="server">
                        <asp:Label ID="lblUserId_q" Style="z-index: 100; left: 10px; position: absolute;
                            top: 5px" runat="server" Width="48px"   >用户ID</asp:Label>
                        <asp:TextBox ID="txtUserId_q" Style="z-index: 101; left: 64px; position: absolute;
                            top: 5px" runat="server" Width="160px" ></asp:TextBox>
                        <asp:Label ID="lblUserName_q" Style="z-index: 102; left: 248px; position: absolute;
                            top: 5px" runat="server" Width="50px"   >用户名</asp:Label>
                        <asp:TextBox ID="txtUserName_q" Style="z-index: 103; left: 312px; position: absolute;
                            top: 5px" runat="server" Width="176px" ></asp:TextBox>
                        <asp:Label ID="lblDepartmentId_q" Style="z-index: 104; left: 10px; position: absolute;
                            top: 35px" runat="server" Width="50px"   >部门</asp:Label>
                        <asp:DropDownList ID="ddlDepartmentId_q" Style="z-index: 106; left: 64px; position: absolute;
                            top: 35px" runat="server" Width="168px" >
                        </asp:DropDownList>
                        <asp:Label ID="lblUserStateId_q" Style="z-index: 107; left: 248px; position: absolute;
                            top: 35px" runat="server" Width="56px"   >用户状态</asp:Label>
                        <asp:DropDownList ID="ddlUserStateId_q" Style="z-index: 108; left: 312px; position: absolute;
                            top: 35px" runat="server" Width="176px" >
                        </asp:DropDownList>
                        <asp:Button ID="btnQuery" Style="z-index: 109; left: 496px; position: absolute; top: 32px"
                            runat="server" Width="80px"   
                            Text="查询" OnClick="btnQuery_Click"></asp:Button>
                        <asp:DropDownList ID="ddlPrjId_q" Style="z-index: 110; left: 560px; position: absolute;
                            top: 8px" runat="server"  Width="208px">
                        </asp:DropDownList>
                        <asp:Label ID="lblPrjId_q" Style="z-index: 111; left: 496px; position: absolute;
                            top: 8px" runat="server" Height="15px"  
                            Width="56px">相关工程</asp:Label>
                    </div>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabUsersDataGrid" style="z-index: 225; width: 552px"
                        cellspacing="0" cellpadding="0" width="552" border="0" runat="server">
                        <tr>
                            <td>
                                <div style="display: inline; width: 750px; position: relative; height: 32px">
                                    <asp:Label ID="lblUsersList" Style="z-index: 105; left: 8px; position: absolute;
                                        top: 4px" runat="server" CssClass="RegionTitleH1" >用户信息列表</asp:Label>
                                    <asp:Button ID="btnAddNewRec4Dg" Style="z-index: 106; left: 390px; position: absolute;
                                        top: 4px" runat="server" Width="80px"  Text="添加记录" OnClick="btnAddNewRec4Dg_Click">
                                    </asp:Button>
                                    <asp:Button ID="btnDelete4Dg" Style="z-index: 104; left: 475px; position: absolute;
                                        top: 4px" runat="server"  Width="80px" Text="删除记录" OnClick="btnDelete4Dg_Click">
                                    </asp:Button>
                                    <asp:Button ID="btnUpdate4Dg" Style="z-index: 105; left: 560px; position: absolute;
                                        top: 4px" runat="server"  Width="80px" Text="修改记录" OnClick="btnUpdate4Dg_Click">
                                    </asp:Button>
                                    <asp:Button ID="btnExportExcel4Dg" Style="z-index: 107; left: 645px; position: absolute;
                                        top: 4px" runat="server"  Width="80px" Text="导出Excel" OnClick="btnExportExcel4Dg_Click">
                                    </asp:Button>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DataGrid ID="dgUsers" Style="z-index: 117; left: 10px; top: 145px" runat="server"
                                    Width="800px" AutoGenerateColumns="False" AllowPaging="True" 
                                     AllowSorting="True" BorderColor="#E7E7FF" BorderStyle="None"
                                    BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Horizontal">
                                    <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                    <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                    <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                    <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                    <Columns>
                                        <asp:TemplateColumn HeaderText="选择">
                                            <HeaderStyle Width="30px"></HeaderStyle>
                                            <HeaderTemplate>
                                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" 
                                                    >全选</asp:LinkButton>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn DataField="UserId" SortExpression="UserId" HeaderText="用户ID"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="UserName" SortExpression="UserName" HeaderText="用户名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="DepartmentName" SortExpression="DepartmentName" HeaderText="部门名">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="UserStateName" SortExpression="UserStateName" HeaderText="用户状态名">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="Password" SortExpression="Password" HeaderText="口令"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="openid" SortExpression="openid" HeaderText="微信openid"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="Memo" SortExpression="Memo" HeaderText="备注"></asp:BoundColumn>
                                        <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                                        <asp:TemplateColumn>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                                    </PagerStyle>
                                </asp:DataGrid>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 605px" bgcolor="silver">
                                <table id="tabUsersJumpPage" style="width: 568px; font-family: Verdana;
                                    height: 26px" cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                                    <tr>
                                        <td>
                                            <font face="宋体"><font style="background-color: #c0c0c0">共有记录:</font>
                                                <asp:Label ID="lblUsersRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">总页数:</font>
                                                <asp:Label ID="lblUsersAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">当前页:
                                                    <asp:Label ID="lblUsersCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <asp:Button ID="btnUsersPrevPage" runat="server"  
                                                        Width="50px" Text="上一页" OnClick="btnUsersPrevPage_Click"></asp:Button>
                                                    <asp:Button ID="btnUsersNextPage" runat="server"  
                                                        Width="50px" Text="下一页" OnClick="btnUsersNextPage_Click"></asp:Button>
                                                    到第
                                                    <asp:TextBox ID="txtUsersJump2Page" runat="server"  
                                                        Width="35px"></asp:TextBox>页
                                                    <asp:Button ID="btnUsersJumpPage" runat="server"  
                                                        Width="35px" Text="确定" OnClick="btnUsersJumpPage_Click"></asp:Button>
                                                    <asp:CompareValidator ID="UsersCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                        ErrorMessage="错误！" ControlToValidate="txtUsersJump2Page" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator></font></font>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabEditUsersRegion" style="z-index: 235; width: 750px; height: 200px"
                        cellspacing="1" cellpadding="1" width="750" border="1" runat="server">
                        <tr>
                            <td>
                                <div style="width: 730px; position: relative; height: 32px">
                                    <asp:Label ID="lblEditUsers" Style="z-index: 104; left: 8px; position: absolute;
                                        top: 4px" runat="server" CssClass="RegionTitleH1" >用户信息编辑区域</asp:Label>
                                    <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 520px; position: absolute; top: 8px"
                                        runat="server" Width="80px"   
                                        Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                                    <asp:Label ID="lblMsg" Style="z-index: 105; left: 288px; position: absolute; top: 8px"
                                        runat="server" Width="208px"   
                                        CssClass="ErrMsg"></asp:Label>
                                    <asp:LinkButton ID="lbDispUsersList" Style="z-index: 107; left: 624px; position: absolute;
                                        top: 8px" runat="server" Width="100px"  
                                        OnClick="lbDispUsersList_Click">显示用户信息列表</asp:LinkButton>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc1:wucUsers ID="wucUsers1" runat="server"></uc1:wucUsers>
                            </td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
