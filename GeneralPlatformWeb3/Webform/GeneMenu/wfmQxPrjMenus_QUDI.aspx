<%@ Register TagPrefix="uc1" TagName="wucQxPrjMenus" Src="wucQxPrjMenus.ascx" %>

<%@ Page Language="c#" AutoEventWireup="true" Inherits="GeneralPlatform.Webform.wfmQxPrjMenus_QUDI"
    CodeBehind="wfmQxPrjMenus_QUDI.aspx.cs" Theme="TaiZeTheme" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/tr/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>系统菜单维护</title>
        <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
        <table id="tabLayout" style="z-index: 105; left: 0px; position: absolute; top: 0px"
            cellspacing="2" cellpadding="2" width="100%" border="0" runat="server">
            <tr>
                <td>
                    <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                        <asp:Label ID="lblViewTitle" runat="server" CssClass="PageTitleH1">系统菜单维护
                        </asp:Label>
                        <asp:Label ID="lblMsg_List" runat="server" CssClass="ErrMsg" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                            Width="347px"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <table style="width: 1013px">
                        <tr>
                            <td align="right">
                                <asp:Label ID="lblPrjId_q" Style="z-index: 107;" runat="server" Width="70px"
                                    CssClass="NameLabel">项目编号</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlPrjId_q" Style="z-index: 108;" runat="server" Width="136px"
                                    AutoPostBack="True" CssClass="TextBox_Defa" OnSelectedIndexChanged="ddlPrjId_q_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                            <td align="right">
                                <asp:Label ID="Label3" runat="server" Width="42px" CssClass="Label_Defa">菜单集</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlPrjMenuSet_q" Style="z-index: 102;" runat="server" OnSelectedIndexChanged="ddlMenuSetId_SelectedIndexChanged" Width="200px" AutoPostBack="True">
                                </asp:DropDownList>
                            </td>
                             <td>
                             <asp:Label ID="Label5" Style="z-index: 104;"
                                runat="server" CssClass="NameLabel">应用类型</asp:Label>
                        </td>
                            <td class="ValueTD">
                            <asp:DropDownList ID="ddlApplicationTypeId_q" runat="server" CssClass="ValueControl"></asp:DropDownList>
                        </td>
                            <td align="right">&nbsp;</td>
                            <td>
                                <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" Style="z-index: 107;"
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="导出Excel"></asp:Button>
                            </td>
                            <td>
                                <asp:Button ID="btnSetExportExcel4User" OnClick="btnSetExportExcel4User_Click" Style="z-index: 107;"
                                    CssClass="btn btn-outline-info btn-sm" runat="server" Width="120px" Text="设置导出字段"></asp:Button>
                            </td>
                               <td>&nbsp;</td>
                               <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label ID="lblMenuName_q" Style="z-index: 104;" runat="server" Width="49px"
                                    CssClass="NameLabel">菜单名</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtMenuName_q" Style="z-index: 105;" runat="server" Width="147px"
                                    CssClass="TextBox_Defa"></asp:TextBox>
                            </td>
                            <td align="right">
                                <asp:Label ID="Label1" Style="z-index: 107;" runat="server" Width="70px"
                                    CssClass="NameLabel">上级菜单名</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlUpMenuId" Style="z-index: 108;" runat="server" Width="200px"
                                    CssClass="TextBox_Defa">
                                </asp:DropDownList>
                            </td>
                            <td align="right">
                                <asp:Label ID="Label2" runat="server" Width="60px">是否在用</asp:Label></td>
                            <td>
                                <asp:DropDownList ID="ddlInUse" runat="server" Width="50px">
                                </asp:DropDownList></td>
                             <td align="right">
                                <asp:Label ID="Label7" runat="server" Width="60px">叶子?</asp:Label></td>
                            <td>
                                <asp:DropDownList ID="ddlIsLeafNode" runat="server" Width="50px">
                                </asp:DropDownList></td>
                            <td align="right">&nbsp;</td>
                            <td>
                                <asp:Button ID="btnQuery" Style="z-index: 115;" runat="server" Width="78px"
                                    Text="查询" CssClass="btn btn-outline-info btn-sm" OnClick="btnQuery_Click"></asp:Button>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabQxPrjMenusGridView" style="width: 100%" runat="server">
                        <tr>
                            <td>
                                <table style="width: 100%; height: 32px" id="tabGridFunction">
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblQxPrjMenusList" runat="server" Height="18px" Style="z-index: 105;"
                                                CssClass="RegionTitleH1" Width="267px">工程菜单列表</asp:Label>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" Style="z-index: 106;"
                                                Width="60px" CssClass="btn btn-outline-info btn-sm" Text="添加"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnCloneNewRec4Gv" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="btnCloneNewRec4Gv_Click" Style="z-index: 106;" Text="克隆" Width="44px" />
                                        </td>
                                        <td>
                                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click" Style="z-index: 104;"
                                                runat="server" Width="60px" CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" Style="z-index: 105;"
                                                runat="server" Width="60px" CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnSetInUse" OnClick="btnSetInUse_Click" Style="z-index: 105;"
                                                runat="server" Width="80px" CssClass="btn btn-outline-info btn-sm" Text="设置在用"></asp:Button>
                                        </td>
                                         <td>
                                            <asp:Button ID="btnAutoGetTabName" OnClick="btnAutoGetTabName_Click" Style="z-index: 105;"
                                                runat="server" Width="99px" CssClass="btn btn-outline-info btn-sm" Text="自动获取表名"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Label ID="Label6" runat="server" CssClass="NameLabel">应用</asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="ddlApplicationTypeId" runat="server" CssClass="TextBox_Defa"></asp:DropDownList>
                                        </td>
                                         <td>
                                            <asp:Button ID="btnApplicationType" runat="server" CssClass="btn btn-outline-info btn-sm"
                                                OnClick="btnApplicationType_Click" Style="z-index: 106;"
                                                Text="设置应用" Width="80px" /></td>

                                        <td>
                                            <asp:Label ID="Label4" runat="server" Width="42px" CssClass="Label_Defa">菜单集</asp:Label>
                                        </td>
                                        <td>
                                            <asp:DropDownList ID="ddlPrjMenuSet" Style="z-index: 102;" runat="server" Width="200px">
                                            </asp:DropDownList>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnSetPrjMenuSet" runat="server" OnClick="btnSetPrjMenuSet_Click" Style="z-index: 106;"
                                                Width="100px" CssClass="btn btn-outline-info btn-sm" Text="设置菜单集"></asp:Button>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:GridView ID="gvQxPrjMenus" Style="z-index: 116;" runat="server" Width="100%" AutoGenerateColumns="False"
                                    AllowPaging="True" AllowSorting="True" OnSorting="gvQxPrjMenus_Sorting" OnPageIndexChanging="gvQxPrjMenus_PageIndexChanging"
                                    OnRowCreated="gvQxPrjMenus_RowCreated" OnRowCommand="gvQxPrjMenus_RowCommand" OnRowDeleting="gvQxPrjMenus_RowDeleting"
                                    OnRowUpdating="gvQxPrjMenus_RowUpdating" BackColor="White" BorderColor="#E7E7FF"
                                    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="1px"
                                    DataKeyNames="MenuId" CssClass="GridValue">
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
                                        <asp:BoundField DataField="MenuId" SortExpression="MenuId" HeaderText="菜单Id"></asp:BoundField>
                                        <asp:BoundField DataField="MenuName" SortExpression="MenuName" HeaderText="菜单名"></asp:BoundField>
                                        <asp:BoundField DataField="RoleNum" SortExpression="RoleNum" HeaderText="角色数"></asp:BoundField>
                                        <asp:BoundField DataField="UpMenuId" SortExpression="UpMenuId" HeaderText="上级菜单Id"
                                            Visible="False"></asp:BoundField>
                                        <asp:BoundField DataField="PageDispModeName" HeaderText="显示方式" SortExpression="PageDispModeName" />
                                        <asp:BoundField DataField="LinkFile" SortExpression="LinkFile" HeaderText="链接文件">
                                            <ItemStyle Width="150px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="qsParameters" SortExpression="qsParameters" HeaderText="qs参数">
                                            <ItemStyle Width="100px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="TabName" SortExpression="TabName" HeaderText="相关表名"></asp:BoundField>
                                        <asp:BoundField DataField="ImgFile" SortExpression="ImgFile" HeaderText="图像文件"></asp:BoundField>
                                        <asp:BoundField DataField="RoleId" SortExpression="RoleId" HeaderText="角色Id" Visible="False"></asp:BoundField>
                                        <asp:BoundField DataField="RoleName" SortExpression="RoleName" HeaderText="角色名称"
                                            Visible="False"></asp:BoundField>
                                        <asp:BoundField DataField="QxPrjId" SortExpression="QxPrjId" HeaderText="项目编号" Visible="False"></asp:BoundField>
                                        <asp:BoundField DataField="IsLeafNode" SortExpression="IsLeafNode" HeaderText="是否叶子"></asp:BoundField>
                                        <asp:BoundField DataField="InUse" SortExpression="InUse" HeaderText="是否在用"></asp:BoundField>
                                        <asp:BoundField DataField="MenuSetName" SortExpression="MenuSetName" HeaderText="菜单集"></asp:BoundField>
                                        <asp:BoundField DataField="UpMenuName" SortExpression="UpMenuName" HeaderText="上级菜单名"></asp:BoundField>
                                        <asp:BoundField DataField="OrderNum" SortExpression="OrderNum" HeaderText="排序号"></asp:BoundField>
                                        <asp:BoundField DataField="ApplicationTypeName" SortExpression="ApplicationTypeName" HeaderText="应用"></asp:BoundField>
                                        <asp:BoundField DataField="PrjName" SortExpression="PrjName" HeaderText="工程名"></asp:BoundField>
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
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabEditQxPrjMenusRegion" style="z-index: 116; width: 750px" cellspacing="1"
                        cellpadding="1" width="750" border="1" runat="server">
                        <tr>
                            <td>
                                <asp:Label ID="lblEditQxPrjMenus" Style="z-index: 104;" runat="server" CssClass="RegionTitleH1"
                                    Height="18px">工程菜单编辑区域</asp:Label>
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
                                <asp:Button ID="btnCancelQxPrjMenusEdit" Style="z-index: 107;" runat="server" Width="100px"
                                    CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelQxPrjMenusEdit_Click"></asp:Button>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <uc1:wucQxPrjMenus ID="wucQxPrjMenus1" runat="server" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
