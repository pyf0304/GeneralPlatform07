<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmPotenceType_QUDI" CodeBehind="wfmPotenceType_QUDI.aspx.cs" Theme="TaiZeTheme" %>

<%@ Register TagPrefix="uc1" TagName="wucPotenceType" Src="wucPotenceType.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>表PotenceType的查询、修改、删除、添加记录</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            z-index: 110;
        }

        .auto-style2 {
            z-index: 107;
        }

        .auto-style3 {
            line-height: 24px;
            color: #3d80b3;
            cursor: pointer;
            z-index: 106;
            border: 1px solid #aed0ea;
            padding: 0px 10px;
            background: #e3f1fa url('../../css/images/button_submit.gif') repeat-x;
        }
    </style>
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="lblViewTitle" Style="z-index: 114; left: 8px; position: absolute; top: 8px"
            runat="server" CssClass="PageTitleH1">权限类型维护</asp:Label>
        <table id="tabLayout" style="z-index: 105; left: 4px; position: absolute; top: 32px"
            cellspacing="2" cellpadding="2" width="100%" border="0" runat="server">
            <tr>
                <td>
                    <table id="divPotenceType" style="z-index: 119;" runat="server">
                        <tr>
                            <td>
                                <asp:Label ID="lblPrjId_q" Style="z-index: 104;"
                                    runat="server" Width="35px">项目</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlPrjId_q" Style="z-index: 105;"
                                    runat="server" Width="176px">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="lblPotenceTypeId_q"
                                    runat="server" Width="85px" CssClass="auto-style2">权限类型Id</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtPotenceTypeId_q" Style="z-index: 108;"
                                    runat="server" Width="70px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label ID="lblPotenceTypeName_q"
                                    runat="server" Width="87px" CssClass="auto-style1">权限类型名</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtPotenceTypeName_q" Style="z-index: 111;"
                                    runat="server" Width="128px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label ID="lblFuncModuleName" runat="server" CssClass="NameLabel">模块</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlFuncModuleId_q" runat="server" CssClass="TextBox_Defa"></asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="lblSubjectTypeId_q0" Style="z-index: 116;" runat="server" Width="70px"
                                    CssClass="NameLabel">是否使用</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlIsVisible" Style="z-index: 117;" runat="server" Width="70px"
                                    CssClass="TextBox_Defa">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Button ID="btnQuery" Style="z-index: 113;"
                                    runat="server" Width="80px"
                                    Text="查询" OnClick="btnQuery_Click"></asp:Button>
                            </td>
                            <td>
                                <asp:Button ID="btnExportExcel4Dg" Style="z-index: 107;"
                                    runat="server" Width="80px" Text="导出Excel" OnClick="btnExportExcel4Dg_Click"></asp:Button>
                            </td>

                            <td>
                                <asp:Button ID="btnSetExportExcel4User" OnClick="btnSetExportExcel4User_Click" Style="z-index: 107;"
                                    CssClass="btn btn-outline-info btn-sm" runat="server" Width="100px" Text="设置导出字段"></asp:Button></td>

                            <td>&nbsp;</td>

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
                    <table id="tabPotenceTypeDataGrid" style="z-index: 225; width: 100%"
                        cellspacing="0" cellpadding="0" width="100%" border="0" runat="server">
                        <tr>
                            <td>
                                <table>
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblPotenceTypeList" Style="z-index: 105;"
                                                runat="server" CssClass="RegionTitleH1" Width="394px">权限类型列表</asp:Label>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnAddNewRec4Dg" Style="z-index: 106;"
                                                runat="server" Width="50px" Text="添加" OnClick="btnAddNewRec4Dg_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnDelete4Dg" Style="z-index: 104;"
                                                runat="server" Width="50px" Text="删除" OnClick="btnDelete4Dg_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnUpdate4Dg" Style="z-index: 105;"
                                                runat="server" Width="50px" Text="修改" OnClick="btnUpdate4Dg_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label1" runat="server" CssClass="NameLabel">模块</asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="ddlFuncModuleId" runat="server" CssClass="TextBox_Defa"></asp:DropDownList>
                                        </td>
                                         <td>
                                            <asp:Button ID="btnSetFuncModule" runat="server" CssClass="btn btn-outline-info btn-sm"
                                                OnClick="btnSetFuncModule_Click" Style="z-index: 106;"
                                                Text="设置模块" Width="97px" /></td>
                                        <td>
                                            <asp:Button ID="btnSetIsVisible" runat="server" CssClass="btn btn-outline-info btn-sm"
                                                OnClick="btnSetIsVisible_Click" Style="z-index: 106;"
                                                Text="设置成可用" Width="97px" /></td>
                                        <td>
                                            <asp:Button ID="btnSetNotIsVisible" runat="server" CssClass="auto-style3"
                                                Text="设置成不可用" Width="105px" OnClick="btnSetNotIsVisible_Click" />
                                        </td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:Label ID="lblMsg_List" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                </table>

                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DataGrid ID="dgPotenceType" Style="z-index: 114; left: 260px; top: 115px" runat="server"
                                    Width="100%" AutoGenerateColumns="False" AllowPaging="True"
                                    AllowSorting="True" BorderColor="#E7E7FF" BorderStyle="None"
                                    BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Horizontal" DataKeyField="PotenceTypeId">
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
                                        <asp:BoundColumn DataField="PotenceTypeId" SortExpression="PotenceTypeId" HeaderText="权限类型Id"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PotenceTypeName" SortExpression="PotenceTypeName" HeaderText="权限类型名"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsVisible" SortExpression="IsVisible" HeaderText="显示？"></asp:BoundColumn>

                                        <asp:BoundColumn DataField="FuncModuleName" SortExpression="FuncModuleName" HeaderText="模块"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PrjName" SortExpression="PrjName" HeaderText="工程名"></asp:BoundColumn>
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
                                <table id="tabPotenceTypeJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                                    cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                                    <tr>
                                        <td>
                                            <span style="background-color: #c0c0c0">共有记录:</span>
                                            <asp:Label ID="lblPotenceTypeRecCount" runat="server" Width="36px" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 36px; height: 13px">
                                            </div>
                                            <span style="background-color: #c0c0c0">总页数:</span>
                                            <asp:Label ID="lblPotenceTypeAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 36px; height: 13px">
                                            </div>
                                            <span style="background-color: #c0c0c0">当前页:</span>
                                            <asp:Label ID="lblPotenceTypeCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 16px; height: 13px">
                                            </div>
                                            <asp:Button ID="btnPotenceTypePrevPage" runat="server"
                                                Width="60px" Text="上一页" OnClick="btnPotenceTypePrevPage_Click"></asp:Button>
                                            <asp:Button ID="btnPotenceTypeNextPage" runat="server"
                                                Width="60px" Text="下一页" OnClick="btnPotenceTypeNextPage_Click"></asp:Button>到第
                                                          <asp:TextBox ID="txtPotenceTypeJump2Page" runat="server"
                                                              Width="35px"></asp:TextBox>页
                                                    <asp:Button ID="btnPotenceTypeJumpPage" runat="server"
                                                        Width="50px" Text="确定" OnClick="btnPotenceTypeJumpPage_Click"></asp:Button>
                                            <asp:CompareValidator ID="PotenceTypeCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                ErrorMessage="错误！" ControlToValidate="txtPotenceTypeJump2Page" Type="Integer"
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
                    <table id="tabEditPotenceTypeRegion" style="z-index: 229; width: 750px; height: 200px"
                        cellspacing="1" cellpadding="1" width="750" border="1" runat="server">
                        <tr>
                            <td>
                                <div style="width: 730px; position: relative; height: 32px">
                                    <asp:Label ID="lblEditPotenceType" Style="z-index: 104; left: 8px; position: absolute; top: 4px"
                                        runat="server" CssClass="RegionTitleH1">权限类型编辑区域</asp:Label>
                                    <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 520px; position: absolute; top: 8px"
                                        runat="server" Width="80px"
                                        Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                                    <asp:Label ID="lblMsg" Style="z-index: 105; left: 288px; position: absolute; top: 8px"
                                        runat="server" Width="208px"
                                        CssClass="ErrMsg"></asp:Label>
                                    <asp:LinkButton ID="lbDispPotenceTypeList" Style="z-index: 107; left: 624px; position: absolute; top: 8px"
                                        runat="server" Width="108px"
                                        OnClick="lbDispPotenceTypeList_Click">显示权限类型列表</asp:LinkButton>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc1:wucPotenceType ID="wucPotenceType1" runat="server"></uc1:wucPotenceType>
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
