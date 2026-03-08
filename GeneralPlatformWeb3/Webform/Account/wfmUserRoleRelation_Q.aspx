<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmUserRoleRelation_Q" Codebehind="wfmUserRoleRelation_Q.aspx.cs"  Theme="TaiZeTheme" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>表UserRoleRelation的查询修改记录</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="lblViewTitle" Style="z-index: 114; left: 8px; position: absolute;
            top: 8px" runat="server"  CssClass="PageTitleH1">用户角色关系查询</asp:Label>
        <table id="tabLayout" style="z-index: 105; left: 4px; position: absolute; top: 32px"
            cellspacing="2" cellpadding="2" width="300" border="0" runat="server">
            <tr>
                <td>
                    <div id="divQxUserRoleRelation" style="z-index: 119; width: 750px; position: relative;
                        height: 62px" runat="server">
                        <asp:Label ID="lblUserId_q" Style="z-index: 104; left: 200px; position: absolute;
                            top: 40px" runat="server" Width="32px"   >用户</asp:Label>
                        <asp:TextBox ID="txtUserId_q" Style="z-index: 105; left: 248px; position: absolute;
                            top: 40px" runat="server" Width="120px" ></asp:TextBox>
                        <asp:Label ID="lblRoleId_q" Style="z-index: 107; left: 200px; position: absolute;
                            top: 8px" runat="server" Width="32px"   >角色</asp:Label>
                        <asp:DropDownList ID="ddlRoleId_q" Style="z-index: 108; left: 248px; position: absolute;
                            top: 8px" runat="server" Width="120px" >
                        </asp:DropDownList>
                        <asp:Label ID="lblDepartmentId_q" Style="z-index: 110; left: 16px; position: absolute;
                            top: 40px" runat="server" Width="32px"   >部门</asp:Label>
                        <asp:DropDownList ID="ddlDepartmentId_q" Style="z-index: 111; left: 56px; position: absolute;
                            top: 40px" runat="server" Width="112px" >
                        </asp:DropDownList>
                        <asp:Label ID="lblUserStateId_q" Style="z-index: 113; left: 392px; position: absolute;
                            top: 8px" runat="server" Width="56px"   >用户状态</asp:Label>
                        <asp:DropDownList ID="ddlUserStateId_q" Style="z-index: 114; left: 456px; position: absolute;
                            top: 8px" runat="server" Width="112px" >
                        </asp:DropDownList>
                        <asp:Label ID="lblPrjId_q" Style="z-index: 116; left: 16px; position: absolute; top: 8px"
                            runat="server" Width="32px"   >项目</asp:Label>
                        <asp:DropDownList ID="ddlPrjId_q" Style="z-index: 117; left: 56px; position: absolute;
                            top: 8px" runat="server" Width="112px"  AutoPostBack="True" OnSelectedIndexChanged="ddlPrjId_q_SelectedIndexChanged">
                        </asp:DropDownList>
                        <asp:Button ID="btnQuery" Style="z-index: 119; left: 392px; position: absolute; top: 32px"
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
                    <table id="tabUserRoleRelationDataGrid" style="z-index: 225;
                        width: 552px" cellspacing="0" cellpadding="0" width="552" border="0" runat="server">
                        <tr>
                            <td>
                                <table style="display: inline; width: 750px; ">
                                    <tr>
                                        <td>      <asp:Label ID="lblUserRoleRelationList" Style="z-index: 105;" runat="server" CssClass="RegionTitleH1" >用户角色关系列表</asp:Label></td>
                                       <td><asp:Button ID="btnExportExcel4Dg" Style="z-index: 107; " runat="server"  Width="80px" Text="导出Excel" OnClick="btnExportExcel4Dg_Click">
                                    </asp:Button></td>
                                       
                                    </tr>
                              
                                    
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DataGrid ID="dgUserRoleRelation" Style="z-index: 120; left: 510px; top: 125px"
                                    runat="server" Width="800px" AutoGenerateColumns="False" AllowPaging="True" 
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
                                        <asp:BoundColumn Visible="False" DataField="mId" SortExpression="mId" HeaderText="流水号">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="UserId" SortExpression="UserId" HeaderText="用户ID"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="UserName" SortExpression="UserName" HeaderText="用户名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="RoleName" SortExpression="RoleName" HeaderText="角色名称"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IdentityDesc" HeaderText="身份" SortExpression="IdentityDesc"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="DepartmentName" SortExpression="DepartmentName" HeaderText="部门名">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="UserStateName" SortExpression="UserStateName" HeaderText="用户状态名">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="PrjName" SortExpression="PrjName" HeaderText="工程名"></asp:BoundColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                                    </PagerStyle>
                                </asp:DataGrid>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 605px" bgcolor="silver">
                                <table id="tabUserRoleRelationJumpPage" style="width: 568px;
                                    font-family: Verdana; height: 26px" cellspacing="0" cellpadding="0" width="568"
                                    border="1" runat="server">
                                    <tr>
                                        <td>
                                            <font face="宋体"><font style="background-color: #c0c0c0">共有记录:</font>
                                                <asp:Label ID="lblUserRoleRelationRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">总页数:</font>
                                                <asp:Label ID="lblUserRoleRelationAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">当前页:
                                                    <asp:Label ID="lblUserRoleRelationCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <asp:Button ID="btnUserRoleRelationPrevPage" runat="server"  
                                                        Width="50px" Text="上一页" OnClick="btnUserRoleRelationPrevPage_Click"></asp:Button>
                                                    <asp:Button ID="btnUserRoleRelationNextPage" runat="server"  
                                                        Width="50px" Text="下一页" OnClick="btnUserRoleRelationNextPage_Click"></asp:Button>
                                                    到第
                                                    <asp:TextBox ID="txtUserRoleRelationJump2Page" runat="server" 
                                                         Width="35px"></asp:TextBox>页
                                                    <asp:Button ID="btnUserRoleRelationJumpPage" runat="server"  
                                                        Width="35px" Text="确定" OnClick="btnUserRoleRelationJumpPage_Click"></asp:Button>
                                                    <asp:CompareValidator ID="UserRoleRelationCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                        ErrorMessage="错误！" ControlToValidate="txtUserRoleRelationJump2Page" Type="Integer"
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
