<%@ Register TagPrefix="uc1" TagName="wucExportExcel4UsersB" Src="wucExportExcel4UsersB.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmExportExcel4UsersB_QUDI.aspx.cs"
    Inherits="GeneralPlatform.Webform.wfmExportExcel4UsersB_QUDI"  Theme="TaiZeTheme" %>

<%@ Register Src="wucExportExcelSetB_Sim.ascx" TagName="wucExportExcelSetB_Sim" TagPrefix="uc2" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>导出Excel用户字段表维护</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <table id="tabLayout" style="z-index: 105; left: 0px; position: absolute; top: 0px"
        cellspacing="2" cellpadding="2" width="780px" border="0" runat="server">
        <tr>
            <td>
                <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                    <asp:Label ID="lblViewTitle" runat="server" CssClass="PageTitleH1" >导出Excel用户字段表维护
                    </asp:Label>
                    <asp:Label ID="lblMsg_List" runat="server" CssClass="ErrMsg"  Style="z-index: 105;
                        left: 54px; position: relative; top: 4px" Width="347px"></asp:Label>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <table>
                    <tr id="trPrepHidden" runat="server">
                        <td>
                            <asp:Label ID="lblid_ExportExcel4Users_q" Style="z-index: 104;" runat="server" Width="100px"
                                Height="20px" CssClass="NameLabel">导出Excel设置</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlid_ExportExcel4Users_q" Style="z-index: 105;" runat="server"
                                Width="100px" Height="22px" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="lblUserID_q" Style="z-index: 107;" runat="server" Width="90px" Height="20px"
                                CssClass="NameLabel">用户ID</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtUserID_q" Style="z-index: 108;" runat="server" Width="100px"
                                Height="22px" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="lblUserName_q" Style="z-index: 110;" runat="server" Width="90px" Height="20px"
                                CssClass="NameLabel">用户名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtUserName_q" Style="z-index: 111;" runat="server" Width="100px"
                                Height="22px" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblFieldName_q" Style="z-index: 113;" runat="server" Width="90px"
                                Height="20px" CssClass="NameLabel">字段名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFieldName_q" Style="z-index: 114;" runat="server" Width="100px"
                                Height="22px" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="lblFieldCnName_q" Style="z-index: 116;" runat="server" Width="90px"
                                Height="20px" CssClass="NameLabel">字段中文名称</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFieldCnName_q" Style="z-index: 117;" runat="server" Width="100px"
                                Height="22px" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                        <td>
                        </td>
                        <td>
                            <asp:Button ID="btnQuery" Style="z-index: 119;" runat="server" Width="80px" 
                                Text="查询" CssClass="btn btn-outline-info btn-sm" OnClick="btnQuery_Click"></asp:Button>
                                        <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" Style="z-index: 107;"
                                            runat="server" Width="80px" CssClass="btn btn-outline-info btn-sm" Text="导出Excel"></asp:Button>
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
                <table style="width: 760px;">
                    <tr>
                        <td>
                            <uc2:wucExportExcelSetB_Sim ID="wucExportExcelSetB_Sim1" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnOK4ExcelFileName" Style="z-index: 106;" runat="server" Width="120px"
                                Text="确定导出文件名" OnClick="btnOK4ExcelFileName_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table id="tabExportExcel4UsersGridView" style="width: 100%" runat="server">
                    <tr>
                        <td>
                            <table style="width: 100%; height: 32px" id="tabGridFunction">
                                <tr>
                                    <td>
                                        <asp:Label ID="lblExportExcel4UsersList" runat="server" Style="z-index: 105;" CssClass="RegionTitleH1"
                                            Width="196px">导出Excel用户字段表列表</asp:Label>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnSynchFieldWithTab" runat="server" Style="z-index: 106;" Width="131px"
                                            CssClass="btn btn-outline-info btn-sm" Text="与导出表同步字段" OnClick="btnSynchFieldWithTab_Click">
                                        </asp:Button>
                                    </td>
                                    <td>
                            <asp:Button ID="btnSynchFieldWithDefaultUser" runat="server" Style="z-index: 106;" Width="139px"
                                CssClass="btn btn-outline-info btn-sm" Text="与缺省用户同步字段" OnClick="btnSynchFieldWithDefaultUser_Click">
                            </asp:Button>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" Style="z-index: 105;"
                                            runat="server" Width="50px" CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnChangeExportStatus" OnClick="btnChangeExportStatus_Click" Style="z-index: 105;"
                                            runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="改变导出状态"></asp:Button>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnGoTop" runat="server"  Style="z-index: 109;" Text="移顶"
                                            Width="48px" CssClass="btn btn-outline-info btn-sm" OnClick="btnGoTop_Click" />
                                    </td>
                                    <td>
                                        <asp:Button ID="btnUpMove" runat="server"  OnClick="btnUpMove_Click"
                                            Style="z-index: 109;" CssClass="btn btn-outline-info btn-sm" Text="上移" Width="48px" />
                                    </td>
                                    <td>
                                        <asp:Button ID="btnDownMove" runat="server"  OnClick="btnDownMove_Click"
                                            Style="z-index: 110;" CssClass="btn btn-outline-info btn-sm" Text="下移" Width="48px" />
                                    </td>
                                    <td>
                                        <asp:Button ID="btnGoBottum" runat="server"  Style="z-index: 110; left: 664px;"
                                            Text="移底" Width="48px" OnClick="btnGoBottum_Click" />
                                    </td>
                                    <td>
                                        <asp:Button ID="btnReOrder" runat="server"  OnClick="btnReOrder_Click"
                                            Style="z-index: 111; left: 712px;" CssClass="btn btn-outline-info btn-sm" Text="重序" Width="40px" />
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:GridView ID="gvExportExcel4Users" Style="z-index: 120;" runat="server" Width="100%"
                                AutoGenerateColumns="False" PageSize="10" AllowPaging="true" AllowSorting="true"
                                OnSorting="gvExportExcel4Users_Sorting" OnPageIndexChanging="gvExportExcel4Users_PageIndexChanging"
                                OnRowCreated="gvExportExcel4Users_RowCreated" OnRowCommand="gvExportExcel4Users_RowCommand"
                                OnRowDeleting="gvExportExcel4Users_RowDeleting" OnRowUpdating="gvExportExcel4Users_RowUpdating"
                                BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px"
                                CellPadding="3" GridLines="Horizontal" Height="1px" DataKeyNames="mId" CssClass="GridValue">
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
                                    <asp:BoundField DataField="mId" Visible="false" SortExpression="mId" HeaderText="mId">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="id_ExportExcel4Users" SortExpression="id_ExportExcel4Users"
                                        HeaderText="字段设置流水号"></asp:BoundField>
                                    <asp:BoundField DataField="ViewName" SortExpression="ViewName" HeaderText="界面名称">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="TabName" SortExpression="TabName" HeaderText="表名"></asp:BoundField>
                                    <asp:BoundField DataField="IsDefaultUser" SortExpression="IsDefaultUser" HeaderText="缺省用户?">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="UserID" SortExpression="UserID" HeaderText="用户ID"></asp:BoundField>
                                    <asp:BoundField DataField="UserName" SortExpression="UserName" HeaderText="用户名">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="ExportFileName" SortExpression="ExportFileName" HeaderText="导出文件名">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="FieldName" SortExpression="FieldName" HeaderText="字段名">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="FieldCnName" SortExpression="FieldCnName" HeaderText="字段中文名称">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="IsExport" SortExpression="IsExport" HeaderText="是否导出">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="OrderNum" SortExpression="OrderNum" HeaderText="序号"></asp:BoundField>
                                    <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundField>
                                    <asp:BoundField DataField="UpdUserId" SortExpression="UpdUserId" HeaderText="修改用户Id">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="备注"></asp:BoundField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lbUpdate" runat="Server" CommandName="Update" Text="修改"></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <PagerTemplate>
                                    <span style="background-color: #c0c0c0">共有记录:</span>
                                    <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066"
                                        Width="22px">0</asp:Label>
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
        </tr>
        <tr>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <table id="tabEditExportExcel4UsersRegion" style="z-index: 120; width: 100%" cellspacing="1"
                    cellpadding="1" width="100%" border="1" runat="server">
                    <tr>
                        <td>
                            <asp:Label ID="lblEditExportExcel4Users" Style="z-index: 104;" runat="server" CssClass="RegionTitleH1">导出Excel用户字段表编辑区域</asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblMsg_Edit" Style="z-index: 105;" runat="server" Width="208px" 
                                CssClass="ErrMsg"></asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server" Width="80px" Text="添加"
                                OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnCancelExportExcel4UsersEdit" Style="z-index: 107;" runat="server"
                                Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelExportExcel4UsersEdit_Click">
                            </asp:Button>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4">
                            <uc1:wucExportExcel4UsersB ID="wucExportExcel4UsersB1" runat="server" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
