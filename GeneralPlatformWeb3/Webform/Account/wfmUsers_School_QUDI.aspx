<%@ Register TagPrefix="uc1" TagName="wucUsers" Src="wucUsers_School.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" 
    Inherits="GeneralPlatform.Webform.wfmUsers_School_QUDI" Codebehind="wfmUsers_School_QUDI.aspx.cs" Theme="TaiZeTheme" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>用户信息维护</title>
   
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />

    <style type="text/css">
        .style1
        {
            width: 582px;
        }
    </style>
</head>
<body>
    <form id="Form1" method="post" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                <table >
                    <tr>
                        <td>
                            <asp:Label ID="lblViewTitle" runat="server" Height="22px" CssClass="PageTitleH1"
                                Width="204px">用户管理->用户信息维护</asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblUserId_q" runat="server"  
                                Width="48px" CssClass="NameLabel">用户ID</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtUserId_q" runat="server" Width="80px" ></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="lblUserName_q" runat="server"  
                                Width="45px" CssClass="NameLabel">用户名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtUserName_q" runat="server" Width="80px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="lblUserStateId_q" runat="server"  
                                Width="62px" CssClass="NameLabel">用户身份</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIdentityId" runat="server" Width="80px" Height="18px">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="lblPrjId_q" runat="server"  
                                Width="31px" CssClass="NameLabel">工程</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlPrjId_q" runat="server" Width="80px" >
                            </asp:DropDownList>
                        </td>
                         <td>
                            <asp:Label ID="Label1" runat="server"  
                                Width="52px" CssClass="NameLabel">用户状态</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlUserStateId" runat="server" Width="80px" >
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Button ID="btnQuery" runat="server"  
                                 OnClick="btnQuery_Click" Text="查询" Width="48px" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table id="tabLayout" cellspacing="2" cellpadding="2" width="100%" border="0" runat="server">
                    <tr>
                        <td rowspan="3" style="width: 1px" valign="top">
                            <asp:TreeView ID="tvDepartments" runat="server" CssClass="LinkButton_Defa" OnSelectedNodeChanged="tvDepartments_SelectedNodeChanged">
                                <SelectedNodeStyle BackColor="#E0E0E0" />
                            </asp:TreeView>
                        </td>
                        <td valign="top">
                            <table id="tabUsersDataGrid" style="z-index: 225; width: 100%"
                                cellspacing="0" cellpadding="0" width="100%" border="0" runat="server">
                                <tr>
                                    <td style="width: 100%">
                                        <table style="width: 100%;">
                                            <tr>
                                               
                                                <td>
                                                    <asp:Label ID="lblUsersList" Style="z-index: 105;" runat="server" CssClass="RegionTitleH1"
                                                         Width="242px">用户信息列表</asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Button ID="btnDataSynToLocalDataBase" Style="z-index: 106;" runat="server" Width="176px"
                                                         Text="同步用户到本地数据库" OnClick="btnDataSynToLocalDataBase_Click"></asp:Button>
                                                </td>
                                                <td>
                                                </td>
                                                <td>
                                                    <asp:Button ID="btnAddNewRec4Dg" Style="z-index: 106;" runat="server" Width="80px"
                                                         Text="添加记录" OnClick="btnAddNewRec4Dg_Click"></asp:Button>
                                                </td>
                                                <td>
                                                    <asp:Button ID="btnDelete4Dg" Style="z-index: 104;" runat="server" 
                                                        Width="80px" Text="删除记录" OnClick="btnDelete4Dg_Click"></asp:Button>
                                                </td>
                                                <td>
                                                    <asp:Button ID="btnUpdate4Dg" Style="z-index: 105;" runat="server" 
                                                        Width="80px" Text="修改记录" OnClick="btnUpdate4Dg_Click"></asp:Button>
                                                </td>
                                                <td>
                                                    <asp:Button ID="btnSynCard_State" Style="z-index: 105;" runat="server" 
                                                        Width="80px" Text="同步卡状态" OnClick="btnSynCard_State_Click"></asp:Button>
                                                </td>
                                                <td>
                                                    <asp:Button ID="btnExportExcel4Dg" Style="z-index: 107;" runat="server" 
                                                        Width="80px" Text="导出Excel" OnClick="btnExportExcel4Dg_Click"></asp:Button>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 100%">
                                        <asp:DataGrid ID="dgUsers" Style="z-index: 117; left: 10px; top: 145px" runat="server"
                                            Width="100%" AutoGenerateColumns="False" AllowPaging="True" 
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
                                                <asp:BoundColumn DataField="UserName" SortExpression="UserName" HeaderText="用户名">
                                                </asp:BoundColumn>
                                                <asp:BoundColumn DataField="IdentityDesc" SortExpression="IdentityDesc" HeaderText="用户身份">
                                                </asp:BoundColumn>
                                                <asp:BoundColumn DataField="DepartmentName" SortExpression="DepartmentName" HeaderText="部门">
                                                </asp:BoundColumn>
                                                <asp:BoundColumn DataField="UserStateName" SortExpression="UserStateName" HeaderText="用户状态">
                                                </asp:BoundColumn>
                                                  <asp:BoundColumn DataField="EffectiveDate" SortExpression="EffectiveDate" HeaderText="有效期">
                                                </asp:BoundColumn>
                                                <asp:BoundColumn DataField="Card_State" SortExpression="Card_State" HeaderText="卡状态">
                                                </asp:BoundColumn>
                                                <asp:BoundColumn DataField="Memo" SortExpression="Memo" HeaderText="备注"></asp:BoundColumn>
                                            </Columns>
                                            <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                                            </PagerStyle>
                                        </asp:DataGrid>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 100%" bgcolor="silver">
                                        <table id="tabUsersJumpPage" style="width: 100%; font-family: Verdana;
                                            height: 26px" cellspacing="0" cellpadding="0" border="1" runat="server">
                                            <tr>
                                                <td>
                                                    <font style="background-color: #c0c0c0">共有记录:</font>
                                                    <asp:Label ID="lblUsersRecCount" runat="server" Width="36px" ForeColor="#000066">0</asp:Label>
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
                                                        <asp:Button ID="btnUsersPrevPage" runat="server"  Width="50px"
                                                            Text="上一页" OnClick="btnUsersPrevPage_Click"></asp:Button>
                                                        <asp:Button ID="btnUsersNextPage" runat="server"  Width="50px"
                                                            Text="下一页" OnClick="btnUsersNextPage_Click"></asp:Button>
                                                        到第
                                                        <asp:TextBox ID="txtUsersJump2Page" runat="server"  Width="35px"></asp:TextBox>页
                                                        <asp:Button ID="btnUsersJumpPage" runat="server"  Width="35px"
                                                            Text="确定" OnClick="btnUsersJumpPage_Click"></asp:Button>
                                                        <span style="background-color: #c0c0c0">页记录数:</span>
                                                        <asp:DropDownList ID="ddlPagerRecCount" runat="server" CssClass="DropDown_DefaInPager"
                                                            Width="61px" AutoPostBack="True" OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged">
                                                            <asp:ListItem>5</asp:ListItem>
                                                            <asp:ListItem>10</asp:ListItem>
                                                            <asp:ListItem>20</asp:ListItem>
                                                            <asp:ListItem>30</asp:ListItem>
                                                            <asp:ListItem>50</asp:ListItem>
                                                            <asp:ListItem>100</asp:ListItem>
                                                            <asp:ListItem>1000</asp:ListItem>
                                                            <asp:ListItem></asp:ListItem>
                                                        </asp:DropDownList>
                                                        <asp:CompareValidator ID="UsersCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                            ErrorMessage="错误！" ControlToValidate="txtUsersJump2Page" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator></font>
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
                            <table id="tabEditUsersRegion" style="z-index: 235; width: 650px; height: 200px"
                                cellspacing="1" cellpadding="1" width="750" border="1" runat="server">
                                <tr>
                                    <td>
                                        <div style="width: 691px; position: relative; height: 32px">
                                            <asp:Label ID="lblEditUsers" Style="z-index: 104; left: 8px; position: absolute;
                                                top: 4px" runat="server" CssClass="RegionTitleH1" >用户信息编辑区域</asp:Label>
                                            <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 465px; position: absolute; top: 8px"
                                                runat="server" Width="80px"   
                                                Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                                            <asp:Label ID="lblMsg" Style="z-index: 105; left: 205px; position: absolute; top: 8px"
                                                runat="server" Width="208px"   
                                                CssClass="ErrMsg"></asp:Label>
                                            <asp:LinkButton ID="lbDispUsersList" Style="z-index: 107; left: 557px; position: absolute;
                                                top: 8px" runat="server" Width="131px"  
                                                OnClick="lbDispUsersList_Click">显示用户信息列表</asp:LinkButton>
                                        </div>
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top">
                                        <uc1:wucUsers ID="wucUsers_School1" runat="server"></uc1:wucUsers>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
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
        
    </table>
<asp:HiddenField ID="hidUserId" runat="server" />
    </form>
</body>
</html>
