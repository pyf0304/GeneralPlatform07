<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmPrjPotence_QUDI" CodeBehind="wfmPrjPotence_QUDI.aspx.cs" Theme="TaiZeTheme" %>

<%@ Register TagPrefix="uc1" TagName="wucPrjPotence" Src="wucPrjPotence.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>表PrjPotence的查询、修改、删除、添加记录</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            z-index: 110;
        }
        .auto-style3 {
            z-index: 111;
        }
        .auto-style4 {
            z-index: 114;
        }
        .auto-style5 {
            z-index: 105;
        }
    </style>
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="lblViewTitle" Style="z-index: 114; left: 8px; position: absolute; top: 8px"
            runat="server" CssClass="PageTitleH1">工程权限维护</asp:Label>
        <table id="tabLayout" style="z-index: 105; left: 4px; position: absolute; top: 32px"
            cellspacing="2" cellpadding="2" width="100%" border="0" runat="server">
            <tr>
                <td>
                    <table id="divPrjPotence" style="z-index: 119; width: 90%; " runat="server">
                        <tr>
                            <td>
                                <asp:Label ID="lblPrjId_q" Style="z-index: 104;"
                                    runat="server" Width="46px">项目</asp:Label></td>
                            <td>
                                <asp:DropDownList ID="ddlPrjId_q" runat="server" Width="100px" OnSelectedIndexChanged="ddlPrjId_q_SelectedIndexChanged" CssClass="auto-style5" >
                                </asp:DropDownList></td>
                            <td>
                                <asp:Label ID="lblFuncModuleName" runat="server" CssClass="NameLabel">模块</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlFuncModuleId_q" runat="server" CssClass="TextBox_Defa"></asp:DropDownList>
                            </td>

                            <td>
                                <asp:Label ID="lblPotenceTypeId_q" Style="z-index: 107;" runat="server" Width="70px">权限类型</asp:Label></td>
                            <td>
                                <asp:DropDownList ID="ddlPotenceTypeId_q" Style="z-index: 108;" runat="server" Width="144px">
                                </asp:DropDownList></td>
                            <td>
                                <asp:Label ID="lblPotenceId_q" runat="server" Width="59px" CssClass="auto-style1">权限ID</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtPotenceId_q" runat="server" Width="95px" CssClass="auto-style3"></asp:TextBox></td>
                            <td>
                                <asp:Label ID="lblPotenceName_q" Style="z-index: 113;" runat="server" Width="70px">权限名称</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtPotenceName_q" runat="server" Width="100px" CssClass="auto-style4"></asp:TextBox></td>
                             <td>
                                <asp:Label ID="lblSubjectTypeId_q0" Style="z-index: 116;" runat="server" Width="70px"
                                    CssClass="NameLabel">使用?</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlIsVisible" Style="z-index: 117;" runat="server" Width="70px"
                                    CssClass="TextBox_Defa">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Button ID="btnQuery"
                                    runat="server" Width="57px"
                                    Text="查询" OnClick="btnQuery_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button></td>
                            <td>
                                            <asp:Button ID="btnExportExcel4Dg" Style="z-index: 107;"
                                                runat="server" Width="80px" Text="导出Excel" OnClick="btnExportExcel4Dg_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                        </td>
                            <td>
                                            <asp:Button ID="btnSetExportExcel4User" OnClick="btnSetExportExcel4User_Click" Style="z-index: 107;"
                                                CssClass="btn btn-outline-info btn-sm" runat="server" Width="100px" Text="设置导出字段"></asp:Button></td>
                        </tr>

                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabPrjPotenceDataGrid" style="z-index: 225; width: 100%"
                        cellspacing="0" cellpadding="0" width="100%" border="0" runat="server">
                        <tr>
                            <td>
                                <table style="display: inline; width: 750px; position: relative; height: 32px">
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblPrjPotenceList" Style="z-index: 105;"
                                                runat="server" CssClass="RegionTitleH1" Width="294px">权限列表</asp:Label>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnAddNewRec4Dg" Style="z-index: 106;"
                                                runat="server" Width="80px" Text="添加记录" OnClick="btnAddNewRec4Dg_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnDelete4Dg" Style="z-index: 104;"
                                                runat="server" Width="80px" Text="删除记录" OnClick="btnDelete4Dg_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnUpdate4Dg" Style="z-index: 105;"
                                                runat="server" Width="80px" Text="修改记录" OnClick="btnUpdate4Dg_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                        </td>
                                        <td style="width: 64px">
                                            <asp:Label ID="lblSymbolForProgramme" runat="server" Width="40px">标志</asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="txtSymbolForProgramme" runat="server" Width="82px"></asp:TextBox></td>
                                        <td style="width: 68px">
                                            <asp:Label ID="lblSymbolName" runat="server" Width="57px">标志名</asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="txtSymbolName" runat="server" Width="109px"></asp:TextBox></td>

                                        <td>
                                            <asp:Button ID="btnBatchSetSymbol" Style="z-index: 105;"
                                                runat="server" Width="100px" Text="批量设置标志" OnClick="btnBatchSetSymbol_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                        </td>
                                        <td>
                                            &nbsp;</td>
                                        <td></td>
                                    </tr>




                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DataGrid ID="dgPrjPotence" Style="z-index: 117; left: 260px; top: 115px" runat="server"
                                    Width="100%" AutoGenerateColumns="False" AllowPaging="True"
                                    AllowSorting="True" CellPadding="3" BackColor="White" BorderWidth="1px"
                                    BorderStyle="None" BorderColor="#E7E7FF" GridLines="Horizontal" DataKeyField="PotenceId" PageSize="20">
                                    <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                    <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                    <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                    <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                    <Columns>
                                        <asp:TemplateColumn HeaderText="选择">
                                            <HeaderStyle Width="30px"></HeaderStyle>
                                            <HeaderTemplate>
                                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server">全选</asp:LinkButton>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn DataField="PotenceId" SortExpression="PotenceId" HeaderText="权限ID"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PotenceName" SortExpression="PotenceName" HeaderText="权限名称"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="MenuName" SortExpression="MenuName" HeaderText="页面菜单"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="SymbolNum" SortExpression="SymbolNum" HeaderText="标志数"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PotenceTypeName" SortExpression="PotenceTypeName" HeaderText="权限类型名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="UpMenuName" SortExpression="UpMenuName" HeaderText="上级菜单"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsLeafNode" SortExpression="IsLeafNode" HeaderText="叶子?"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="FuncModuleName_Sim" SortExpression="FuncModuleName_Sim" HeaderText="模块"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PrjName" SortExpression="PrjName" HeaderText="工程名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsVisible" SortExpression="IsVisible" HeaderText="显示？"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="UpdUserId" SortExpression="UpdUserId" HeaderText="修改用户Id"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="Memo" SortExpression="Memo" HeaderText="备注"></asp:BoundColumn>
                                        <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                                        <asp:TemplateColumn>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
                                </asp:DataGrid>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 605px" bgcolor="silver">
                                <table id="tabPrjPotenceJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                                    cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                                    <tr>
                                        <td>
                                            <font style="background-color: #c0c0c0">共有记录:</font>
                                            <asp:Label ID="lblPrjPotenceRecCount" runat="server" Width="36px" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 36px; height: 13px">
                                            </div>
                                            <font style="background-color: #c0c0c0">总页数:</font>
                                            <asp:Label ID="lblPrjPotenceAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 36px; height: 13px">
                                            </div>
                                            <font style="background-color: #c0c0c0">当前页:</font>
                                            <asp:Label ID="lblPrjPotenceCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 36px; height: 13px">
                                            </div>
                                            <asp:Button ID="btnPrjPotencePrevPage" runat="server"
                                                Width="60px" Text="上一页" OnClick="btnPrjPotencePrevPage_Click"></asp:Button>
                                            <asp:Button ID="btnPrjPotenceNextPage" runat="server"
                                                Width="60px" Text="下一页" OnClick="btnPrjPotenceNextPage_Click"></asp:Button>到第
                                                  <asp:TextBox ID="txtPrjPotenceJump2Page" runat="server"
                                                      Width="35px"></asp:TextBox>页
                                                    <asp:Button ID="btnPrjPotenceJumpPage" runat="server"
                                                        Width="50px" Text="确定" OnClick="btnPrjPotenceJumpPage_Click"></asp:Button>
                                            <asp:CompareValidator ID="PrjPotenceCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                ErrorMessage="错误！" ControlToValidate="txtPrjPotenceJump2Page" Type="Integer"
                                                Operator="DataTypeCheck"></asp:CompareValidator>
                                        </td>
                                    </tr>
                                </table>
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
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabEditPrjPotenceRegion" style="z-index: 235; width: 750px; height: 200px"
                        cellspacing="1" cellpadding="1" width="750" border="1" runat="server">
                        <tr>
                            <td>
                                <div style="width: 730px; position: relative; height: 32px">
                                    <asp:Label ID="lblEditPrjPotence" Style="z-index: 104; left: 8px; position: absolute; top: 4px"
                                        runat="server" CssClass="RegionTitleH1">权限编辑区域</asp:Label>
                                    <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 520px; position: absolute; top: 8px"
                                        runat="server" Width="80px"
                                        Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                                    <asp:Label ID="lblMsg" Style="z-index: 105; left: 288px; position: absolute; top: 8px"
                                        runat="server" Width="208px"
                                        CssClass="ErrMsg"></asp:Label>
                                    <asp:LinkButton ID="lbDispPrjPotenceList" Style="z-index: 107; left: 624px; position: absolute; top: 8px"
                                        runat="server" Width="100px"
                                        OnClick="lbDispPrjPotenceList_Click">显示权限列表</asp:LinkButton>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc1:wucPrjPotence ID="wucPrjPotence1" runat="server"></uc1:wucPrjPotence>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
        </table>
    </form>
</body>
</html>
