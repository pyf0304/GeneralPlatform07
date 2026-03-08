<%@ Register TagPrefix="uc1" TagName="wucRelaOfPotenceAndSymbolB" Src="wucRelaOfPotenceAndSymbolB.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmRelaOfPotenceAndSymbolB_QUDI.aspx.cs" 
    Inherits="GeneralPlatform.Webform.wfmRelaOfPotenceAndSymbolB_QUDI" Theme="TaiZeTheme"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/tr/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>设置权限与编程标志关系的维护</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <table id="tabLayout" style="z-index: 105; left: 0px; position: absolute; top: 0px" cellspacing="2"
            cellpadding="2" width="100%" border="0" runat="server">
            <tr>
                <td>

                    <table id="tabTitle" style="z-index: 102; " cellspacing="1"
                        cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
                        <tr>
                            <td bgcolor="#ff6666">
                                <asp:Label ID="lblViewTile" runat="server" Font-Size="Small" Font-Names="宋体" ForeColor="White" Font-Bold="True">设置权限与编程标志关系</asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>

                    <table>
                        <tr>

                            <td>
                                <asp:Label ID="lblPrjId_q" Style="z-index: 104;"
                                    runat="server" Width="90px" Height="20px" CssClass="NameLabel">项目Id</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlPrjId_q" Style="z-index: 105;"
                                    runat="server" Width="100px" Height="22px" CssClass="TextBox_Defa">
                                </asp:DropDownList>
                            </td>

                            <td>
                                <asp:Label ID="lblPotenceTypeId_q" Style="z-index: 107;"
                                    runat="server" Width="90px" Height="20px" CssClass="NameLabel">权限类型Id</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlPotenceTypeId_q" Style="z-index: 108;"
                                    runat="server" Width="100px" Height="22px" CssClass="TextBox_Defa">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>

                            <td>
                                <asp:Label ID="lblPotenceId_q" Style="z-index: 110;"
                                    runat="server" Width="90px" Height="20px" CssClass="NameLabel">权限ID</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlPotenceId_q" Style="z-index: 111;"
                                    runat="server" Width="100px" Height="22px" CssClass="TextBox_Defa">
                                </asp:DropDownList>
                            </td>

                            <td>
                                <asp:Label ID="lblSymbolForProgramme_q" Style="z-index: 113;"
                                    runat="server" Width="90px" Height="20px" CssClass="NameLabel">编程标志</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtSymbolForProgramme_q" Style="z-index: 114;"
                                    runat="server" Width="100px" Height="22px" CssClass="TextBox_Defa">
                                </asp:TextBox>
                            </td>
                        </tr>
                        <tr>

                            <td>
                                <asp:Label ID="lblSymbolName_q" Style="z-index: 116;"
                                    runat="server" Width="90px" Height="20px" CssClass="NameLabel">标志名称</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtSymbolName_q" Style="z-index: 117;"
                                    runat="server" Width="100px" Height="22px" CssClass="TextBox_Defa">
                                </asp:TextBox>
                            </td>
                            <td>

                                <asp:Button ID="btnQuery"
                                    Style="z-index: 119;"
                                    runat="server"
                                    Width="80px" Height="24px"
                                    Text="查询" CssClass="btn btn-outline-info btn-sm"
                                    OnClick="btnQuery_Click"></asp:Button>
                            </td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMsg_List" Style="z-index: 113;"
                        runat="server" Width="630px" Height="20px" CssClass="NameLabel"></asp:Label>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>

                    <table id="tabRelaOfPotenceAndSymbolGridView" style="width: 100%"
                        runat="server">
                        <tr>
                            <td>
                                <table style="width: 100%; height: 32px" id="tabGridFunction">
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblRelaOfPotenceAndSymbolList" runat="server" Style="z-index: 105;"
                                                CssClass="RegionTitleH1" Width="250px">权限编程标志关系表列表</asp:Label>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" Style="z-index: 106;"
                                                Width="80px" CssClass="btn btn-outline-info btn-sm" Text="添加记录"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click" Style="z-index: 104;" runat="server"
                                                Width="80px" CssClass="btn btn-outline-info btn-sm" Text="删除记录"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" Style="z-index: 105;" runat="server"
                                                Width="80px" CssClass="btn btn-outline-info btn-sm" Text="修改记录"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" Style="z-index: 107;"
                                                runat="server" Width="80px" CssClass="btn btn-outline-info btn-sm" Text="导出Excel"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnSetExportExcel4User" OnClick="btnSetExportExcel4User_Click" Style="z-index: 107;"
                                                runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="设置导出字段"></asp:Button>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:GridView ID="gvRelaOfPotenceAndSymbol" Style="z-index: 120;" runat="server"
                                    Width="100%" AutoGenerateColumns="False"
                                    PageSize="20" AllowPaging="true"
                                    AllowSorting="true"
                                    OnSorting="gvRelaOfPotenceAndSymbol_Sorting"
                                    OnPageIndexChanging="gvRelaOfPotenceAndSymbol_PageIndexChanging"
                                    OnRowCreated="gvRelaOfPotenceAndSymbol_RowCreated"
                                    OnRowCommand="gvRelaOfPotenceAndSymbol_RowCommand"
                                    OnRowDeleting="gvRelaOfPotenceAndSymbol_RowDeleting"
                                    OnRowUpdating="gvRelaOfPotenceAndSymbol_RowUpdating"
                                    BackColor="White"
                                    BorderColor="#E7E7FF"
                                    BorderStyle="None"
                                    BorderWidth="1px"
                                    CellPadding="3"
                                    GridLines="Horizontal"
                                    Height="1px"
                                    DataKeyNames="RelaMid"
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
                                        <asp:BoundField DataField="RelaMid" SortExpression="RelaMid" HeaderText="流水号"></asp:BoundField>
                                        <asp:BoundField DataField="QxPrjId" SortExpression="QxPrjId" HeaderText="项目Id"></asp:BoundField>
                                        <asp:BoundField DataField="PrjName" SortExpression="PrjName" HeaderText="工程名"></asp:BoundField>
                                        <asp:BoundField DataField="PotenceTypeId" SortExpression="PotenceTypeId" HeaderText="权限类型Id"></asp:BoundField>
                                        <asp:BoundField DataField="PotenceTypeName" SortExpression="PotenceTypeName" HeaderText="权限类型名"></asp:BoundField>
                                        <asp:BoundField DataField="PotenceId" SortExpression="PotenceId" HeaderText="权限ID"></asp:BoundField>
                                        <asp:BoundField DataField="PotenceName" SortExpression="PotenceName" HeaderText="权限名称"></asp:BoundField>
                                        <asp:BoundField DataField="SymbolName" SortExpression="SymbolName" HeaderText="标志名称"></asp:BoundField>
                                        <asp:BoundField DataField="SymbolForProgramme" SortExpression="SymbolForProgramme" HeaderText="编程标志"></asp:BoundField>
                                        <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundField>
                                        <asp:BoundField DataField="UpdUserId" SortExpression="UpdUserId" HeaderText="修改用户Id"></asp:BoundField>
                                        <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="备注"></asp:BoundField>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbUpdate" runat="Server" CommandName="Update" Text="修改"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <PagerTemplate>
                                        <span style="background-color: #c0c0c0">共有记录:</span>
                                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066" Width="22px">0</asp:Label>
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
                                            Width="55px" AutoPostBack="True" OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged">
                                            <asp:ListItem>5</asp:ListItem>
                                            <asp:ListItem>10</asp:ListItem>
                                            <asp:ListItem>20</asp:ListItem>
                                            <asp:ListItem>30</asp:ListItem>
                                            <asp:ListItem>50</asp:ListItem>
                                            <asp:ListItem>100</asp:ListItem>
                                            <asp:ListItem>1000</asp:ListItem>
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
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabEditRelaOfPotenceAndSymbolRegion" style="z-index: 120; width: 100%"
                        cellspacing="1" cellpadding="1" width="100%" border="1" runat="server">
                        <tr>
                            <td>
                                <asp:Label ID="lblEditRelaOfPotenceAndSymbol" Style="z-index: 104;" runat="server"
                                    CssClass="RegionTitleH1">权限编程标志关系表编辑区域</asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblMsg_Edit" Style="z-index: 105;" runat="server"
                                    Width="208px"  CssClass="ErrMsg"></asp:Label>
                            </td>
                            <td>
                                <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                    Width="80px" Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                            </td>
                            <td>
                                <asp:Button ID="btnCancelRelaOfPotenceAndSymbolEdit" Style="z-index: 107;"
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelRelaOfPotenceAndSymbolEdit_Click"></asp:Button>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <uc1:wucRelaOfPotenceAndSymbolB id="wucRelaOfPotenceAndSymbolB1" runat="server" />
                            </td>
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
