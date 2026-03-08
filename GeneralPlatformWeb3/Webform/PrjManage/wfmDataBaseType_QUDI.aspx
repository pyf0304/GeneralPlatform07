<%@ Register TagPrefix="uc1" TagName="wucDataBaseType" Src="wucDataBaseType.ascx" %>

<%@ Page Language="c#" AutoEventWireup="true" Inherits="GeneralPlatform.Webform.wfmDataBaseType_QUDI" CodeBehind="wfmDataBaseType_QUDI.aspx.cs"  Theme="TaiZeTheme" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/tr/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>DataBaseType的维护</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <table id="tabLayout" style="z-index: 105; left: 0px; position: absolute; top: 0px" cellspacing="2"
            cellpadding="2" width="300" border="0" runat="server">
            <tr>
                <td>

                    <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                        <asp:Label ID="lblViewTitle" runat="server" CssClass="PageTitleH1">DataBaseType表的维护
                        </asp:Label>
                        <asp:Label ID="lblMsg_List" runat="server" CssClass="ErrMsg" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                            Width="347px"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>

                    <div id="divDataBaseType" style="position: relative; width: 600px; height: 100px">

                        <asp:Label ID="lblDataBaseTypeId_q" Style="z-index: 104; left: 10px; position: absolute; top: 5px"
                            runat="server" Width="70px" CssClass="NameLabel">数据库类型ID</asp:Label>
                        <asp:TextBox ID="txtDataBaseTypeId_q" Style="z-index: 105; left: 85px; position: absolute; top: 5px"
                            runat="server" Width="70px" CssClass="TextBox_Defa">
                        </asp:TextBox>

                        <asp:Label ID="lblDataBaseTypeName_q" Style="z-index: 107; left: 260px; position: absolute; top: 5px"
                            runat="server" Width="70px" CssClass="NameLabel">数据库类型名</asp:Label>
                        <asp:TextBox ID="txtDataBaseTypeName_q" Style="z-index: 108; left: 335px; position: absolute; top: 5px"
                            runat="server" Width="70px" CssClass="TextBox_Defa">
                        </asp:TextBox>

                        <asp:Label ID="lblMemo_q" Style="z-index: 110; left: 10px; position: absolute; top: 35px"
                            runat="server" Width="70px" CssClass="NameLabel">备注</asp:Label>
                        <asp:TextBox ID="txtMemo_q" Style="z-index: 111; left: 85px; position: absolute; top: 35px"
                            runat="server" Width="70px" CssClass="TextBox_Defa">
                        </asp:TextBox>

                        <asp:Button ID="btnQuery"
                            Style="z-index: 113; left: 260px; position: relative; top: 35px"
                            runat="server"
                            Width="80px"
                            Text="查询" CssClass="btn btn-outline-info btn-sm"
                            OnClick="btnQuery_Click"></asp:Button>
                    </div>
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

                    <table id="tabDataBaseTypeGridView" style="width: 552px"
                        runat="server">
                        <tr>
                            <td>
                                <div style="width: 750px; position: relative; height: 32px" id="divGridFunction">
                                    <asp:Label ID="lblDataBaseTypeList" runat="server" Style="z-index: 105; left: 0px; position: relative; top: 0px"
                                        CssClass="RegionTitleH1">数据库类型列表</asp:Label>
                                    <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" Style="z-index: 106; left: 390px; position: absolute; top: 4px"
                                        Width="80px" CssClass="btn btn-outline-info btn-sm" Text="添加记录"></asp:Button>
                                    <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click" Style="z-index: 104; left: 475px; position: absolute; top: 4px" runat="server"
                                        Width="80px" CssClass="btn btn-outline-info btn-sm" Text="删除记录"></asp:Button>
                                    <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" Style="z-index: 105; left: 560px; position: absolute; top: 4px" runat="server"
                                        Width="80px" CssClass="btn btn-outline-info btn-sm" Text="修改记录"></asp:Button>
                                    <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" Style="z-index: 107; left: 645px; position: absolute; top: 4px"
                                        runat="server" Width="80px" CssClass="btn btn-outline-info btn-sm" Text="导出Excel"></asp:Button>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:GridView ID="gvDataBaseType" Style="z-index: 114; position: relative;" runat="server"
                                    Width="800px" AutoGenerateColumns="False"
                                    PageSize="10" AllowPaging="true"
                                    AllowSorting="true"
                                    OnSorting="gvDataBaseType_Sorting"
                                    OnPageIndexChanging="gvDataBaseType_PageIndexChanging"
                                    OnRowCreated="gvDataBaseType_RowCreated"
                                    OnRowCommand="gvDataBaseType_RowCommand"
                                    OnRowDeleting="gvDataBaseType_RowDeleting"
                                    OnRowUpdating="gvDataBaseType_RowUpdating"
                                    BackColor="White"
                                    BorderColor="#E7E7FF"
                                    BorderStyle="None"
                                    BorderWidth="1px"
                                    CellPadding="3"
                                    GridLines="Horizontal"
                                    Height="1px"
                                    DataKeyNames="DataBaseTypeId"
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
                                        <asp:BoundField DataField="DataBaseTypeId" SortExpression="DataBaseTypeId" HeaderText="数据库类型ID"></asp:BoundField>
                                        <asp:BoundField DataField="DataBaseTypeName" SortExpression="DataBaseTypeName" HeaderText="数据库类型名"></asp:BoundField>
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
                                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066" Width="16px">0</asp:Label>
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
                    <table id="tabEditDataBaseTypeRegion" style="z-index: 114; width: 750px"
                        cellspacing="1" cellpadding="1" width="750" border="1" runat="server">
                        <tr>
                            <td>
                                <div style="width: 730px; position: relative; height: 32px">
                                    <asp:Label ID="lblEditDataBaseType" Style="z-index: 104; left: 0px; position: relative; top: 4px" runat="server"
                                        CssClass="RegionTitleH1">数据库类型编辑区域</asp:Label>
                                    <asp:Label ID="lblMsg_Edit" Style="z-index: 105; left: 54px; position: relative; top: 8px" runat="server"
                                        Width="208px" CssClass="ErrMsg"></asp:Label>
                                    <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 68px; position: relative; top: 4px" runat="server"
                                        Width="80px" Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                    <asp:Button ID="btnCancelDataBaseTypeEdit" Style="z-index: 107; left: 90px; position: relative; top: 4px"
                                        runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelDataBaseTypeEdit_Click"></asp:Button>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc1:wucDataBaseType ID="wucDataBaseType1" runat="server"></uc1:wucDataBaseType>
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
