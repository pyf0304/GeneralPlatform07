<%@ Register TagPrefix="uc1" TagName="wucUserDownLoadDetailLogB" Src="wucUserDownLoadDetailLogB.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmUserDownLoadDetailLogB_QUDI.aspx.cs"
    Inherits="GeneralPlatform.Webform.wfmUserDownLoadDetailLogB_QUDI"  Theme="TaiZeTheme" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/tr/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>用户下载日志细节维护的维护</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link rel="stylesheet" type="text/css" href="../../Styles/Images/style.css" />
    <link href="../../css/tz_base11.css" rel="stylesheet" />
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table id="tabLayout" cellspacing="2" cellpadding="2" width="100%" border="0" runat="server">
        <tr>
            <td class="navigation">
                <b><span id="title" runat="server" style="font-size: 13px; font-weight: bold;">用户下载日志细节维护</span></b>
            </td>
        </tr>
        <tr id="trSelect" runat="server">
            <td>
                <table border="0" cellspacing="0" cellpadding="0" class="msgtable" width="80%">
                    <tr>
                        <td>
                            <asp:Label ID="lblPrjId_q" Style="z-index: 107;" runat="server" Width="50px" CssClass="NameLabel">项目编号</asp:Label>
                        </td>
                        <td class="style1">
                            <asp:DropDownList ID="ddlPrjId_q" Style="z-index: 108;" runat="server" Width="200px"
                                CssClass="TextBox_Defa" Enabled="false">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="lblPrjSiteName_q" Style="z-index: 104;" runat="server" Width="62px"
                                CssClass="NameLabel">工程站点名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtPrjSiteName_q" Style="z-index: 105;" runat="server" Width="200px"
                                CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblUserId_q" Style="z-index: 110;" runat="server" Width="50px" CssClass="NameLabel">用户ID</asp:Label>
                        </td>
                        <td class="style1">
                            <asp:DropDownList ID="ddlUserId_q" Style="z-index: 111;" runat="server" Width="200px"
                                CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Label ID="lblFileName_q" Style="z-index: 113;" runat="server" Width="50px" CssClass="NameLabel">文件名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFileName_q" Style="z-index: 114;" runat="server" Width="200px"
                                CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:Label ID="lblMsg_List" runat="server" CssClass="ErrMsg"></asp:Label>
                        </td>
                        <td align="right">
                            <asp:Button ID="btnQuery" Style="z-index: 116;" runat="server" Width="80px" 
                                Text="查询" CssClass="btn btn-outline-info btn-sm" OnClick="btnQuery_Click"></asp:Button>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                <table id="tabUserDownLoadDetailLogGridView" style="width: 100%" runat="server">
                    <tr>
                        <td>
                            <table style="width: 100%; height: 32px" id="tabGridFunction">
                                <tr>
                                    <td style="width: 100%;">
                                        <asp:Label ID="lblUserDownLoadDetailLogList" runat="server" Style="z-index: 105;"
                                            CssClass="RegionTitleH1" Width="250px">用户下载日志细节列表</asp:Label>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" Style="z-index: 106;"
                                            Width="80px" CssClass="btn btn-outline-info btn-sm" Text="添加记录"></asp:Button>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click" Style="z-index: 104;"
                                            runat="server" Width="80px" CssClass="btn btn-outline-info btn-sm" Text="删除记录"></asp:Button>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" Style="z-index: 105;"
                                            runat="server" Width="80px" CssClass="btn btn-outline-info btn-sm" Text="修改记录" Visible="false"></asp:Button>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" Style="z-index: 107;"
                                            runat="server" Width="80px" CssClass="btn btn-outline-info btn-sm" Text="导出Excel"></asp:Button>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:GridView ID="gvUserDownLoadDetailLog" Style="z-index: 117;" runat="server" Width="100%"
                                AutoGenerateColumns="False" PageSize="10" AllowPaging="true" AllowSorting="true"
                                OnSorting="gvUserDownLoadDetailLog_Sorting" OnPageIndexChanging="gvUserDownLoadDetailLog_PageIndexChanging"
                                OnRowCreated="gvUserDownLoadDetailLog_RowCreated" OnRowCommand="gvUserDownLoadDetailLog_RowCommand"
                                OnRowDeleting="gvUserDownLoadDetailLog_RowDeleting" OnRowUpdating="gvUserDownLoadDetailLog_RowUpdating"
                                BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px"
                                CellPadding="3" GridLines="None" Height="1px" DataKeyNames="mId" CssClass="GridValue">
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
                                    <asp:BoundField DataField="PrjSiteName" SortExpression="PrjSiteName" HeaderText="工程站点名">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="QxPrjId" SortExpression="QxPrjId" HeaderText="项目编号"></asp:BoundField>
                                    <asp:BoundField DataField="PrjName" SortExpression="PrjName" HeaderText="工程名"></asp:BoundField>
                                    <asp:BoundField DataField="UserId" SortExpression="UserId" HeaderText="用户ID"></asp:BoundField>
                                    <asp:BoundField DataField="FileName" SortExpression="FileName" HeaderText="文件名">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="DownLownDate" SortExpression="DownLownDate" HeaderText="下载日期">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="IsSuccess" SortExpression="IsSuccess" HeaderText="是否成功">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="LogInfo" SortExpression="LogInfo" HeaderText="日志信息"></asp:BoundField>
                                    <asp:BoundField DataField="Version" SortExpression="Version" HeaderText="版本"></asp:BoundField>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lbUpdate" runat="Server" CommandName="Update" Text="详细"></asp:LinkButton>
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
                                <FooterStyle CssClass="FooterStyle" />
                                <RowStyle CssClass="RowStyle" />
                                <EmptyDataRowStyle CssClass="EmptyDataRowStyle" />
                                <PagerStyle CssClass="PagerStyle" />
                                <SelectedRowStyle CssClass="SelectedRowStyle" />
                                <HeaderStyle CssClass="HeaderStyle" />
                                <EditRowStyle CssClass="EditRowStyle" />
                                <AlternatingRowStyle CssClass="AlternatingRowStyle" />
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr id="tabEditUserDownLoadDetailLogRegion" runat="server">
            <td style="width: 100%;">
                <uc1:wucUserDownLoadDetailLogB ID="wucUserDownLoadDetailLogB1" runat="server" />
                <div style="text-align: center;">
                    <asp:Button ID="btnOKUpd" runat="server" Width="80px" Text="添加" OnClick="btnOKUpd_Click"
                        CssClass="btn btn-outline-info btn-sm"></asp:Button>
                    &nbsp;
                    <input name="重置" type="reset" class="submit" value="重置" />
                    &nbsp;
                    <asp:Button ID="btnCancelUserDownLoadDetailLogEdit" Style="z-index: 107;" runat="server"
                        CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelUserDownLoadDetailLogEdit_Click">
                    </asp:Button>
                </div>
                <div style="margin-top: 10px; text-align: center;">
                    <asp:Label ID="lblMsg_Edit" runat="server"  CssClass="ErrMsg"></asp:Label>
                </div>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
