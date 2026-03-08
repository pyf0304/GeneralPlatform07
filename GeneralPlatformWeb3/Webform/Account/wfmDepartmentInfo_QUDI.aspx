<%@ Register TagPrefix="uc1" TagName="wucDepartmentInfo" Src="wucDepartmentInfo.ascx" %>

<%@ Page Language="c#" AutoEventWireup="true"
    Inherits="GeneralPlatform.Webform.wfmDepartmentInfo_QUDI" CodeBehind="wfmDepartmentInfo_QUDI.aspx.cs" Theme="TaiZeTheme" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/tr/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>QxDepartmentInfo的维护</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
        <table id="tabLayout" style="z-index: 105; left: 0px; top: 0px"
            cellspacing="2" cellpadding="2" width="100%" border="0" runat="server">
            <tr>
                <td>
                    <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                        <asp:Label ID="lblViewTitle" runat="server" CssClass="PageTitleH1">部门维护
                        </asp:Label>
                        <asp:Label ID="lblMsg_List" runat="server" CssClass="ErrMsg" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                            Width="347px"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="lblDepartmentId_q" Style="z-index: 104;" runat="server" Width="70px"
                                    CssClass="NameLabel">部门Id</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtDepartmentId_q" Style="z-index: 105;" runat="server" Width="130px"
                                    CssClass="TextBox_Defa"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label ID="lblDepartmentName_q" Style="z-index: 107;" runat="server" Width="70px"
                                    CssClass="NameLabel">部门名</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtDepartmentName_q" Style="z-index: 108;" runat="server" Width="109px"
                                    CssClass="TextBox_Defa"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label ID="lblDepartmentTypeId_q" Style="z-index: 113;" runat="server" Width="70px"
                                    CssClass="NameLabel">部门类型</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlDepartmentTypeId_q" Style="z-index: 114;" runat="server"
                                    Width="114px" CssClass="TextBox_Defa">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="lblSubjectTypeId_q" Style="z-index: 116;" runat="server" Width="70px"
                                    CssClass="NameLabel">学科类型ID</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlSubjectTypeId_q" Style="z-index: 117;" runat="server" Width="70px"
                                    CssClass="TextBox_Defa">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblUpDepartmentId_q" Style="z-index: 110;" runat="server" Width="70px"
                                    CssClass="NameLabel">所属部门</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlUpDepartmentId_q" Style="z-index: 111;" runat="server" Width="138px"
                                    CssClass="TextBox_Defa">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="lblSubjectTypeId_q0" Style="z-index: 116;" runat="server" Width="70px"
                                    CssClass="NameLabel">是否使用</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlInUse" Style="z-index: 117;" runat="server" Width="70px"
                                    CssClass="TextBox_Defa">
                                </asp:DropDownList>
                            </td>
                            <td></td>
                            <td></td>
                            <td>
                                <asp:Button ID="btnQuery" Style="z-index: 119;" runat="server" Width="80px"
                                    Text="查询" CssClass="btn btn-outline-info btn-sm" OnClick="btnQuery_Click"></asp:Button>
                            </td>
                            <td>
                                <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" Style="z-index: 107; left: 679px; top: 4px"
                                    runat="server" Width="90px" CssClass="btn btn-outline-info btn-sm"
                                    Text="导出Excel"></asp:Button>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabDepartmentInfoGridView" style="width: 100%" runat="server">
                        <tr>
                            <td>
                                <table style="width: 781px; position: relative; height: 32px; left: 0px; top: 0px;"
                                    id="divGridFunction">
                                    <tr>
                                        <td>

                                            <asp:Label ID="lblDepartmentInfoList" runat="server" Style="z-index: 105; left: 0px; position: relative; top: 0px"
                                                CssClass="RegionTitleH1" Width="150px">部门信息列表</asp:Label>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" Style="z-index: 106; left: 420px; top: 2px"
                                                Width="48px" CssClass="btn btn-outline-info btn-sm"
                                                Text="添加"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click" Style="z-index: 104; left: 471px; top: 3px"
                                                runat="server" Width="50px" CssClass="btn btn-outline-info btn-sm"
                                                Text="删除"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" Style="z-index: 105; left: 517px; top: 4px"
                                                runat="server" Width="50px" CssClass="btn btn-outline-info btn-sm"
                                                Text="修改"></asp:Button>
                                        </td>



                                        <td>
                                            <asp:Button ID="btnSetInUse" runat="server" CssClass="btn btn-outline-info btn-sm"
                                                OnClick="btnSetInUse_Click" Style="z-index: 106;"
                                                Text="设置成可用" Width="97px" /></td>
                                        <td>
                                            <asp:Button ID="btnSetNotInUse" runat="server" CssClass="btn btn-outline-info btn-sm"
                                                Style="z-index: 106;"
                                                Text="设置成不可用" Width="97px" OnClick="btnSetNotInUse_Click" />
                                        </td>
                                        <td>
                                            <asp:Button ID="btnGoTop" runat="server" Style="z-index: 109;"
                                                Text="移顶" Width="50px" CssClass="btn btn-outline-info btn-sm" OnClick="btnGoTop_Click" />
                                        </td>
                                        <td>
                                            <asp:Button ID="btnUpMove" runat="server" Style="z-index: 103; left: 559px; top: 4px"
                                                Text="上移" Width="50px" OnClick="btnUpMove_Click" CssClass="btn btn-outline-info btn-sm" />
                                        </td>
                                        <td>
                                            <asp:Button ID="btnDownMove" runat="server" Style="z-index: 104; left: 599px; top: 4px"
                                                Text="下移" Width="50px" OnClick="btnDownMove_Click" CssClass="btn btn-outline-info btn-sm" />
                                        </td>
                                        <td>
                                            <asp:Button ID="btnGoBottum" runat="server" CssClass="btn btn-outline-info btn-sm" Style="z-index: 110; left: 664px;"
                                                Text="移底" Width="50px" OnClick="btnGoBottum_Click" />
                                        </td>
                                        <td>
                                            <asp:Button ID="btnReOrder" runat="server" Style="z-index: 105; left: 638px; top: 4px"
                                                Text="重序" Width="50px" OnClick="btnReOrder_Click" CssClass="btn btn-outline-info btn-sm" />
                                        </td>
                                        <td>
                                            <asp:Button ID="btnDataSynToLocalDataBase" runat="server" OnClick="btnDataSynToLocalDataBase_Click"
                                                Style="z-index: 106; left: 227px; top: 3px" Text="同步部门到本地数据库"
                                                Width="176px" CssClass="btn btn-outline-info btn-sm" />

                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:GridView ID="gvDepartmentInfo" Style="z-index: 120; position: relative;" runat="server"
                                    Width="100%" AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True"
                                    OnSorting="gvDepartmentInfo_Sorting" OnPageIndexChanging="gvDepartmentInfo_PageIndexChanging"
                                    OnRowCreated="gvDepartmentInfo_RowCreated" OnRowCommand="gvDepartmentInfo_RowCommand"
                                    OnRowDeleting="gvDepartmentInfo_RowDeleting" OnRowUpdating="gvDepartmentInfo_RowUpdating"
                                    BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px"
                                    CellPadding="3" GridLines="Horizontal" Height="1px" DataKeyNames="DepartmentId"
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
                                        <asp:BoundField DataField="OrderNum" SortExpression="OrderNum" HeaderText="排序号"></asp:BoundField>
                                        <asp:BoundField DataField="DepartmentId" SortExpression="DepartmentId" HeaderText="部门Id"></asp:BoundField>
                                        <asp:BoundField DataField="DepartmentName" SortExpression="DepartmentName" HeaderText="部门名"></asp:BoundField>
                                        <asp:BoundField DataField="UpDepartmentName" SortExpression="UpDepartmentName" HeaderText="上级部门"></asp:BoundField>
                                        <asp:BoundField DataField="DepartmentAbbrName" SortExpression="DepartmentAbbrName"
                                            HeaderText="名称缩写"></asp:BoundField>
                                        <asp:BoundField DataField="DepartmentTypeName" SortExpression="DepartmentTypeName"
                                            HeaderText="部门类型名"></asp:BoundField>
                                        <asp:BoundField DataField="InUse" SortExpression="InUse" HeaderText="使用?"></asp:BoundField>
                                        <asp:BoundField DataField="UserNum" SortExpression="UserNum" HeaderText="用户数"></asp:BoundField>


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
                                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066"
                                            Width="16px">0</asp:Label>
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
            <tr>
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabEditDepartmentInfoRegion" style="z-index: 120; width: 750px" cellspacing="1"
                        cellpadding="1" width="750" border="1" runat="server">
                        <tr>
                            <td>
                                <div style="width: 730px; position: relative; height: 32px">
                                    <asp:Label ID="lblEditDepartmentInfo" Style="z-index: 104; left: 0px; position: relative; top: 4px"
                                        runat="server" CssClass="RegionTitleH1">部门信息编辑区域</asp:Label>
                                    <asp:Label ID="lblMsg_Edit" Style="z-index: 105; left: 54px; position: relative; top: 8px"
                                        runat="server" Width="208px" CssClass="ErrMsg"></asp:Label>
                                    <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 68px; position: relative; top: 4px"
                                        runat="server" Width="80px" Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                    <asp:Button ID="btnCancelDepartmentInfoEdit" Style="z-index: 107; left: 90px; position: relative; top: 4px"
                                        runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelDepartmentInfoEdit_Click"></asp:Button>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc1:wucDepartmentInfo ID="wucDepartmentInfo1" runat="server"></uc1:wucDepartmentInfo>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
