<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmUserGroupPotence_Q" Codebehind="wfmUserGroupPotence_Q.aspx.cs" Theme="TaiZeTheme"  %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>表QxUserGroupPotence的查询修改记录</title>
                <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="lblViewTitle" Style="z-index: 114; left: 8px; position: absolute;
            top: 8px" runat="server"  CssClass="PageTitleH1">用户权限关系查询</asp:Label>
        <table id="tabLayout" style="z-index: 105; left: 4px; position: absolute; top: 32px"
            cellspacing="2" cellpadding="2" width="300" border="0" runat="server">
            <tr>
                <td>
                    <div id="divUserGroupPotence" style="z-index: 119; width: 864px; position: relative;
                        height: 72px" runat="server">
                        <asp:Label ID="lblPrjId_q" Style="z-index: 104; left: 10px; position: absolute; top: 15px"
                            runat="server" Width="56px"   >项目编号</asp:Label>
                        <asp:DropDownList ID="ddlPrjId_q" Style="z-index: 105; left: 85px; position: absolute;
                            top: 15px" runat="server" Width="192px"  OnSelectedIndexChanged="ddlPrjId_q_SelectedIndexChanged">
                        </asp:DropDownList>
                        <asp:Label ID="lblRoleId_q" Style="z-index: 107; left: 312px; position: absolute;
                            top: 15px" runat="server" Width="32px"   >角色</asp:Label>
                        <asp:DropDownList ID="ddlRoleId_q" Style="z-index: 108; left: 360px; position: absolute;
                            top: 15px" runat="server" Width="144px" >
                        </asp:DropDownList>
                        <asp:Label ID="lblPotenceId_q" Style="z-index: 110; left: 10px; position: absolute;
                            top: 45px" runat="server" Width="32px"   >权限</asp:Label>
                        <asp:DropDownList ID="ddlPotenceId_q" Style="z-index: 111; left: 85px; position: absolute;
                            top: 45px" runat="server" Width="192px" >
                        </asp:DropDownList>
                        <asp:Label ID="lblUserID_q" Style="z-index: 113; left: 312px; position: absolute;
                            top: 45px" runat="server" Width="32px"   >用户</asp:Label>
                        <asp:TextBox ID="txtUserID_q" Style="z-index: 114; left: 360px; position: absolute;
                            top: 45px" runat="server" Width="136px" ></asp:TextBox>
                        <asp:Button ID="btnQuery" Style="z-index: 119; left: 536px; position: absolute; top: 48px"
                            runat="server" Width="80px"   
                            Text="查询" OnClick="btnQuery_Click"></asp:Button>
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
                    <table id="tabUserGroupPotenceDataGrid" style="z-index: 225;
                        width: 552px" cellspacing="0" cellpadding="0" width="552" border="0" runat="server">
                        <tr>
                            <td>
                                <div style=" width: 750px; position: relative; height: 32px">
                                    <asp:Label ID="lblUserGroupPotenceList" Style="z-index: 105; left: 8px; position: absolute;
                                        top: 4px" runat="server" Width="200px" CssClass="RegionTitleH1" >用户权限关系列表</asp:Label>
                                    <asp:Button ID="btnExportExcel4Dg" Style="z-index: 107; left: 475px; position: absolute;
                                        top: 4px" runat="server"  Width="80px" Text="导出Excel" OnClick="btnExportExcel4Dg_Click">
                                    </asp:Button>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DataGrid ID="dgUserGroupPotence" Style="z-index: 120; left: 260px; top: 155px"
                                    runat="server" Width="1100px" AutoGenerateColumns="False" AllowPaging="True"
                                      AllowSorting="True" BorderColor="#E7E7FF"
                                    BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Horizontal">
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
                                        <asp:BoundColumn Visible="False" DataField="mId" SortExpression="mId" HeaderText="流水号">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="PrjName" SortExpression="PrjName" HeaderText="工程名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="RoleId" SortExpression="RoleId" HeaderText="角色Id"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="RoleName" SortExpression="RoleName" HeaderText="角色名称"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PotenceTypeName" SortExpression="PotenceTypeName" HeaderText="权限类型名">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="PotenceId" SortExpression="PotenceId" HeaderText="权限ID">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="PotenceName" SortExpression="PotenceName" HeaderText="权限名称">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="UserID" SortExpression="UserID" HeaderText="用户ID"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="GroupId" SortExpression="GroupId" HeaderText="组Id"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="GroupName" SortExpression="GroupName" HeaderText="组名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="UserName" SortExpression="UserName" HeaderText="用户名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="RelaMid" SortExpression="RelaMid" HeaderText="流水号"></asp:BoundColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                                    </PagerStyle>
                                </asp:DataGrid>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 605px" bgcolor="silver">
                                <table id="tabUserGroupPotenceJumpPage" style="width: 568px;
                                    font-family: Verdana; height: 26px" cellspacing="0" cellpadding="0" width="568"
                                    border="1" runat="server">
                                    <tr>
                                        <td>
                                            <font face="宋体"><font style="background-color: #c0c0c0">共有记录:</font>
                                                <asp:Label ID="lblUserGroupPotenceRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">总页数:</font>
                                                <asp:Label ID="lblUserGroupPotenceAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">当前页:
                                                    <asp:Label ID="lblUserGroupPotenceCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <asp:Button ID="btnUserGroupPotencePrevPage" runat="server"  
                                                        Width="50px" Text="上一页" OnClick="btnUserGroupPotencePrevPage_Click"></asp:Button>
                                                    <asp:Button ID="btnUserGroupPotenceNextPage" runat="server"  
                                                        Width="50px" Text="下一页" OnClick="btnUserGroupPotenceNextPage_Click"></asp:Button>
                                                    到第
                                                    <asp:TextBox ID="txtUserGroupPotenceJump2Page" runat="server" 
                                                         Width="35px"></asp:TextBox>页
                                                    <asp:Button ID="btnUserGroupPotenceJumpPage" runat="server"  
                                                        Width="35px" Text="确定" OnClick="btnUserGroupPotenceJumpPage_Click"></asp:Button>
                                                    <asp:CompareValidator ID="UserGroupPotenceCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                        ErrorMessage="错误！" ControlToValidate="txtUserGroupPotenceJump2Page" Type="Integer"
                                                        Operator="DataTypeCheck"></asp:CompareValidator></font></font>
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
        </table>
    </form>
</body>
</html>
