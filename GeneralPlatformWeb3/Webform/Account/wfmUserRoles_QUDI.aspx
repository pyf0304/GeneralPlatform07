<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmUserRoles_QUDI" Codebehind="wfmUserRoles_QUDI.aspx.cs"  Theme="TaiZeTheme" %>

<%@ Register TagPrefix="uc1" TagName="wucUserRoles" Src="wucUserRoles.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>表UserRoles的查询、修改、删除、添加记录</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="lblViewTitle" Style="z-index: 114; left: 8px; position: absolute;
            top: 8px" runat="server"  CssClass="PageTitleH1">角色维护</asp:Label>

             <asp:Label ID="lblMsg_List" Style="z-index: 114; left: 200px; position: absolute;
            top: 8px" runat="server"  CssClass="PageTitleH1"></asp:Label>

        <table id="tabLayout" style="z-index: 105; left: 4px; position: absolute; top: 32px"
            cellspacing="2" cellpadding="2" width="100%" border="0" runat="server">
            <tr>
                <td>
                    <div id="divUserRoles" style="z-index: 119; width: 879px; position: relative; height: 25px; top: 0px; left: 0px;"
                        runat="server">
                        <asp:Label ID="lblRoleId_q" Style="z-index: 104;" runat="server" Width="48px"   >角色Id</asp:Label>
                        <asp:TextBox ID="txtRoleId_q" Style="z-index: 105; " runat="server" Width="87px" ></asp:TextBox>
                        <asp:Label ID="lblRoleName_q" Style="z-index: 107; " runat="server" Width="70px"   >角色名称</asp:Label>
                        <asp:TextBox ID="txtRoleName_q" Style="z-index: 108; " runat="server" Width="120px" ></asp:TextBox>
                        <asp:Label ID="lblPrjId_q" Style="z-index: 110; " runat="server" Width="64px"   >项目编号</asp:Label>
                        <asp:DropDownList ID="ddlPrjId_q" Style="z-index: 111;" runat="server" Width="192px" >
                        </asp:DropDownList>
                        <asp:Button ID="btnQuery" Style="z-index: 113; "
                            runat="server" Width="80px"   
                            Text="查询" OnClick="btnQuery_Click"></asp:Button>
                                    <asp:Button ID="btnExportExcel4Dg" Style="z-index: 105; " runat="server"  Width="80px" Text="导出Excel" OnClick="btnExportExcel4Dg_Click">
                                    </asp:Button>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabUserRolesDataGrid" style="z-index: 225; width: 100%"
                        cellspacing="0" cellpadding="0" width="100%" border="0" runat="server">
                        <tr>
                            <td>
                                <div style="display: inline; width: 931px; position: relative; height: 24px; top: 0px; left: 0px;">
                                    <asp:Label ID="lblUserRolesList" Style="z-index: 101;" runat="server" 
                                        CssClass="RegionTitleH1"  Width="156px">角色列表</asp:Label>
                                    <asp:Button ID="btnAddNewRec4Dg" Style="z-index: 104; " runat="server" Width="80px"  Text="添加角色" OnClick="btnAddNewRec4Dg_Click">
                                    </asp:Button>
                                    <asp:Button ID="btnDelete4Dg" Style="z-index: 100; " runat="server"  Width="80px" Text="删除角色" OnClick="btnDelete4Dg_Click">
                                    </asp:Button>
                                    <asp:Button ID="btnUpdate4Dg" Style="z-index: 103;" runat="server"  Width="80px" Text="修改角色" OnClick="btnUpdate4Dg_Click">
                                    </asp:Button>
                                    <asp:Button ID="btnEditUserForRole" Style="z-index: 106;" runat="server"  Width="88px" Text="维护角色用户" OnClick="btnEditUserForRole_Click">
                                    </asp:Button>
                                    <asp:Button ID="btnDataSynToLocalDataBase" runat="server"  OnClick="btnDataSynToLocalDataBase_Click"
                                        Style="z-index: 106; " Text="同步角色到本地数据库"
                                        Width="176px" />
                                  
                                    <asp:Button ID="btnSetInUse" runat="server" CssClass="btn btn-outline-info btn-sm" 
                                         OnClick="btnSetInUse_Click" Style="z-index: 106;" 
                                        Text="设置成可用" Width="97px" />
                                    
                                    <asp:Button ID="btnSetNotInUse" runat="server" CssClass="btn btn-outline-info btn-sm" 
                                         Style="z-index: 106;" 
                                        Text="设置成不可用" Width="97px" onclick="btnSetNotInUse_Click" />
                                    
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DataGrid ID="dgUserRoles" Style="z-index: 114; left: 260px; top: 115px" runat="server"
                                    Width="100%" AutoGenerateColumns="False" AllowPaging="True" 
                                     AllowSorting="True" GridLines="Horizontal" CellPadding="3"
                                    BackColor="White" BorderWidth="1px" BorderStyle="None" 
                                    BorderColor="#E7E7FF" DataKeyField="RoleId">
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
                                        <asp:BoundColumn DataField="RoleId" SortExpression="RoleId" HeaderText="角色Id"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="RoleName" SortExpression="RoleName" HeaderText="角色名称"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="RoleIndex" SortExpression="RoleIndex" HeaderText="角色序号"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PrjName" SortExpression="PrjName" HeaderText="工程名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsInUse" HeaderText="是否在使用" 
                                            SortExpression="IsInUse"></asp:BoundColumn>
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
                                <table id="tabUserRolesJumpPage" style="width: 568px; font-family: Verdana;
                                    height: 26px" cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                                    <tr>
                                        <td>
                                            <font face="宋体"><font style="background-color: #c0c0c0">共有记录:</font>
                                                <asp:Label ID="lblUserRolesRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">总页数:</font>
                                                <asp:Label ID="lblUserRolesAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">当前页:
                                                    <asp:Label ID="lblUserRolesCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <asp:Button ID="btnUserRolesPrevPage" runat="server"  
                                                        Width="50px" Text="上一页" OnClick="btnUserRolesPrevPage_Click"></asp:Button>
                                                    <asp:Button ID="btnUserRolesNextPage" runat="server"  
                                                        Width="50px" Text="下一页" OnClick="btnUserRolesNextPage_Click"></asp:Button>
                                                    到第
                                                    <asp:TextBox ID="txtUserRolesJump2Page" runat="server"  
                                                        Width="35px"></asp:TextBox>页
                                                    <asp:Button ID="btnUserRolesJumpPage" runat="server"  
                                                        Width="35px" Text="确定" OnClick="btnUserRolesJumpPage_Click"></asp:Button>
                                                    <asp:CompareValidator ID="UserRolesCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                        ErrorMessage="错误！" ControlToValidate="txtUserRolesJump2Page" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator></font></font>
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
                <td>
                    <table id="tabEditUserRolesRegion" style="z-index: 229; width: 750px; height: 85px"
                        cellspacing="1" cellpadding="1" width="750" border="1" runat="server">
                        <tr>
                            <td>
                                <div style="width: 730px; position: relative; height: 24px">
                                    <asp:Label ID="lblEditUserRoles" Style="z-index: 104; left: 8px; position: absolute;
                                        top: 4px" runat="server" CssClass="RegionTitleH1" >角色编辑区域</asp:Label>
                                    <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 520px; position: absolute; top: 0px"
                                        runat="server" Width="80px"   
                                        Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                                    <asp:Label ID="lblMsg" Style="z-index: 105; left: 288px; position: absolute; top: 4px"
                                        runat="server" Width="208px"   
                                        CssClass="ErrMsg"></asp:Label>
                                    <asp:LinkButton ID="lbDispUserRolesList" Style="z-index: 107; left: 624px; position: absolute;
                                        top: 5px" runat="server" Width="100px"  
                                        OnClick="lbDispUserRolesList_Click">显示角色列表</asp:LinkButton>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc1:wucUserRoles ID="wucUserRoles1" runat="server"></uc1:wucUserRoles>
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
       
    </form>
</body>
</html>
