<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QxRoleMenusExcelImport.aspx.cs" Inherits="GeneralPlatform.DataExcelImport.QxRoleMenusExcelImport"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/tr/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" type="text/css" href="../CSS/KnowledgeBG.css" />
    <link rel="stylesheet" type="text/css" href="../../CSS/KnowledgeBG.css" />
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <table style="width: 100%">
                <tr>
                    <td>
                        <table id="TabfileUpload" style="border-right: #4d9ab0 1px solid; border-bottom: #4d9ab0 1px solid; border-top: #4d9ab0 1px solid; border-left: #4d9ab0 1px solid;">
                            <tr>
                                <td style="width: 200px; border-right: #4d9ab0 1px solid; border-bottom: #4d9ab0 1px solid; text-align: center;">
                                    <asp:Label ID="Label4" runat="server" Text="附件:"></asp:Label>
                                </td>
                                <td style="border-right: #4d9ab0 1px solid; border-bottom: #4d9ab0 1px solid; text-align: center;">
                                    <asp:FileUpload ID="FileUploadChoose" runat="server" Width="500px" unselectable="on" />
                                </td>
                                <td style="text-align: center;">&nbsp;&nbsp;<asp:Button ID="btnUpload" runat="server" Text="上传" OnClick="btnUpload_Click" />
                                    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="../DownLoad/2013级学生信息.xls">下载Excel样例</a>
                                </td>
                            </tr>
                        </table>

                    </td>
                </tr>


                <tr id="stuGV" runat="server">
                    <td>
                        <asp:GridView ID="gvStudent" runat="server" Style="z-index: 108;"
                            Width="100%"
                            AllowPaging="true"
                            BackColor="White"
                            BorderColor="#E7E7FF"
                            BorderStyle="None"
                            BorderWidth="1px"
                            CssClass="GridValue" OnPageIndexChanging="gvStudent_PageIndexChanging">
                        </asp:GridView>
                    </td>
                </tr>

                <tr>
                    <td style="border-right: #4d9ab0 1px solid; border-bottom: #4d9ab0 1px solid; border-top: #4d9ab0 1px solid; border-left: #4d9ab0 1px solid;">
                        <asp:Label ID="lblMessFalse" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: center;">
                        <asp:Button ID="btnImport" runat="server" Text="数据导入" OnClick="btnImport_Click" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                </tr>

                <tr id="gvStuInfo" runat="server">
                    <td>
                        <table id="tabLayout" style="width: 100%;" border="0" runat="server" class="msgtable">
                            <tr>
                                <td>

                                    <table style="width: 80%;" class="msgtable">
                                        <tr>

                                            <td>
                                                <asp:Label ID="lblStuID_q" Style="z-index: 104;"
                                                    runat="server" Width="90px" Height="20px" CssClass="NameLabel">学号</asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtStuID_q" Style="z-index: 105;"
                                                    runat="server" Width="200px" Height="20px" CssClass="TextBox_Defa">
                                                </asp:TextBox>
                                            </td>

                                            <td>
                                                <asp:Label ID="lblStuName_q" Style="z-index: 107;"
                                                    runat="server" Width="90px" Height="20px" CssClass="NameLabel">姓名</asp:Label>
                                            </td>
                                            <td>
                                                <asp:TextBox ID="txtStuName_q" Style="z-index: 108;"
                                                    runat="server" Width="200px" Height="20px" CssClass="TextBox_Defa">
                                                </asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>

                                            <td>
                                                <asp:Label ID="lblid_Major_q" Style="z-index: 110;"
                                                    runat="server" Width="90px" Height="20px" CssClass="NameLabel">专业</asp:Label>
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="ddlid_Major_q" Style="z-index: 111;"
                                                    runat="server" Width="200px" Height="22px" CssClass="TextBox_Defa">
                                                </asp:DropDownList>
                                            </td>

                                            <td>
                                                <asp:Label ID="lblid_Grade_q" Style="z-index: 113;"
                                                    runat="server" Width="90px" Height="20px" CssClass="NameLabel">年级</asp:Label>
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="ddlid_Grade_q" Style="z-index: 114;"
                                                    runat="server" Width="200px" Height="22px" CssClass="TextBox_Defa">
                                                </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="3">
                                                <asp:Label ID="lblMsg_List" runat="server" CssClass="ErrMsg" Style="z-index: 105; left: 54px;"
                                                    Width="347px"></asp:Label>
                                            </td>
                                            <td style="text-align: right">

                                                <asp:Button ID="btnQuery"
                                                    Style="z-index: 116;"
                                                    runat="server"
                                                    Width="80px" Height="24px"
                                                    Text="查询" CssClass="btn btn-outline-info btn-sm"
                                                    OnClick="btnQuery_Click"></asp:Button>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>

                                    <table id="tabQxRoleMenusGridView" style="width: 100%" class="msgtable"
                                        runat="server">
                                        <tr>
                                            <td>
                                                <asp:GridView ID="gvQxRoleMenus" Style="z-index: 117;" runat="server"
                                                    Width="100%" AutoGenerateColumns="False"
                                                    PageSize="10" AllowPaging="true"
                                                    AllowSorting="true"
                                                    OnSorting="gvQxRoleMenus_Sorting"
                                                    OnPageIndexChanging="gvQxRoleMenus_PageIndexChanging"
                                                    OnRowDeleting="gvQxRoleMenus_RowDeleting"
                                                    BackColor="White"
                                                    BorderColor="#E7E7FF"
                                                    BorderStyle="None"
                                                    BorderWidth="1px"
                                                    CellPadding="3"
                                                    GridLines="None"
                                                    Height="1px"
                                                    DataKeyNames="MenuId"
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
                                                        <asp:BoundField DataField="MenuId" SortExpression="MenuId" HeaderText="菜单Id"></asp:BoundField>
                                                        <asp:BoundField DataField="MenuName" SortExpression="MenuName" HeaderText="菜单名"></asp:BoundField>
                                                        <asp:BoundField DataField="UpMenuId" SortExpression="UpMenuId" HeaderText="上级菜单Id"></asp:BoundField>
                                                  
                                                        <%--   <asp:TemplateField>
                                                        <ItemTemplate>
                                                            <asp:LinkButton ID="lbUpdate" runat="Server" CommandName="Update" Text="修改"></asp:LinkButton>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>--%>
                                                        <asp:TemplateField>
                                                            <ItemTemplate>
                                                                <asp:LinkButton ID="lbDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                    </Columns>
                                                    <PagerTemplate>
                                                        <span>共有记录:</span>
                                                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066" Width="22px">0</asp:Label>
                                                        <span>
                                                            <div style="display: inline; width: 16px; height: 13px">
                                                            </div>
                                                        </span><span>总页数:</span>
                                                        <asp:Label ID="lblAllPages" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                                        <div style="display: inline; width: 16px; height: 13px">
                                                        </div>
                                                        <span>当前页:</span>
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
                                                        <span>页记录数:</span>
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

                        </table>

                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
