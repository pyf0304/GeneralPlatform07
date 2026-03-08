<%@ Page Language="c#" AutoEventWireup="false"
    Inherits="GeneralPlatform.Webform.wfmSetQxViewPotenceLevel" CodeBehind="wfmSetQxViewPotenceLevel.aspx.cs" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>表ViewInfo的查询修改记录</title>
    <link href="../../Webform/css/taishweb1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="Form1" method="post" runat="server">

        <table id="tabTitle" style="z-index: 101; left: 8px; position: absolute; top: 8px"
            cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
            <tr>
                <td bgcolor="#ff6666">
                    <asp:Label ID="lblViewTile" runat="server" Font-Size="Small" Font-Names="宋体" ForeColor="White"
                        Font-Bold="True">设置界面与权限等级的关系</asp:Label>
                </td>
            </tr>
        </table>
        <table id="Table2" style="z-index: 102; left: 8px; width: 848px; position: absolute; top: 32px; height: 484px"
            cellspacing="1" cellpadding="1" width="848" border="1">
            <tr>
                <td valign="top">
                    <table id="Table1" style="width: 600px; word-break: break-all" cellspacing="1" cellpadding="1"
                        width="600" border="0">
                        <tr>
                            <td style="width: 695px" colspan="3">
                                <asp:Label ID="lblPrjId_q" runat="server" Font-Names="verdana" Font-Size="x-small"
                                    Height="16px" Width="70px">项目编号</asp:Label>
                                <asp:DropDownList ID="ddlPrjId_q" runat="server" AutoPostBack="True">
                                </asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td style="width: 695px" colspan="3">
                                <hr style="width: 98.81%; height: 1px" width="98.81%" size="1">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 695px" colspan="3">
                                <div style="width: 99.82%; position: relative; height: 64px">
                                    <asp:Label ID="lblViewId_q" Style="z-index: 157; left: 16px; position: absolute; top: 8px"
                                        runat="server" Font-Names="verdana" Font-Size="x-small" Height="16px"
                                        Width="70px">界面编号</asp:Label>
                                    <asp:TextBox ID="txtViewId_q" Style="z-index: 157; left: 72px; position: absolute; top: 0px"
                                        runat="server" Width="150px"></asp:TextBox>
                                    <asp:Label ID="lblViewName_q" Style="z-index: 157; left: 16px; position: absolute; top: 32px"
                                        runat="server" Font-Names="verdana" Font-Size="x-small" Height="16px"
                                        Width="70px">界面名称</asp:Label>
                                    <asp:TextBox ID="txtViewName_q" Style="z-index: 157; left: 72px; position: absolute; top: 32px"
                                        runat="server" Width="150px"></asp:TextBox>
                                    <asp:Label ID="lblViewCnName_q" Style="z-index: 157; left: 232px; position: absolute; top: 8px"
                                        runat="server" Font-Names="verdana" Font-Size="x-small" Height="16px"
                                        Width="88px">界面中文名称</asp:Label>
                                    <asp:TextBox ID="txtViewCnName_q" Style="z-index: 157; left: 312px; position: absolute; top: 8px"
                                        runat="server" Width="150px"></asp:TextBox>
                                    <asp:Button ID="btnQuery" Style="z-index: 156; left: 496px; position: absolute; top: 32px"
                                        runat="server" Font-Names="verdana" Font-Size="x-Small" Height="24px" Width="80px"
                                        Text="查询"></asp:Button>
                                    <asp:Label ID="lblFilePath_q" Style="z-index: 105; left: 232px; position: absolute; top: 32px"
                                        runat="server" Font-Names="verdana" Font-Size="x-small" Height="16px"
                                        Width="70px">文件路径</asp:Label>
                                    <asp:TextBox ID="txtFilePath_q" Style="z-index: 104; left: 312px; position: absolute; top: 32px"
                                        runat="server" Width="150px"></asp:TextBox>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 8px" colspan="3">
                                <asp:DataGrid ID="dgViewInfo" runat="server" Font-Names="verdana" Font-Size="X-Small"
                                    Width="100%" CellSpacing="1" CellPadding="1" BackColor="White" BorderWidth="1px"
                                    BorderStyle="None" BorderColor="#3366CC" PageSize="5" AutoGenerateColumns="False"
                                    AllowPaging="True" AllowSorting="True">
                                    <FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
                                    <SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
                                    <ItemStyle ForeColor="#003399" BackColor="White"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#CCCCFF" BackColor="#003399"></HeaderStyle>
                                    <Columns>
                                        <asp:BoundColumn DataField="ViewId" SortExpression="ViewId" HeaderText="界面编号">
                                            <HeaderStyle Width="15%"></HeaderStyle>
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="ViewName" SortExpression="ViewName" HeaderText="界面名称">
                                            <HeaderStyle Width="15%"></HeaderStyle>
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="ViewCnName" SortExpression="ViewCnName" HeaderText="中文名称"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="FileName" SortExpression="FileName" HeaderText="文件名">
                                            <HeaderStyle Width="15%"></HeaderStyle>
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="FilePath" SortExpression="FilePath" HeaderText="文件路径">
                                            <HeaderStyle Width="15%"></HeaderStyle>
                                        </asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="DefaMenuName" SortExpression="DefaMenuName"
                                            HeaderText="DefaMenuName"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="ViewTypeCode" SortExpression="ViewTypeCode"
                                            HeaderText="ViewTypeCode"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="DataBaseName" SortExpression="DataBaseName"
                                            HeaderText="DataBaseName"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="UpdUserID" SortExpression="UpdUserID" HeaderText="UpdUserID"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PrjName" SortExpression="PrjName" HeaderText="项目名称">
                                            <HeaderStyle Width="20%"></HeaderStyle>
                                        </asp:BoundColumn>
                                        <asp:ButtonColumn Text="选择" CommandName="Select"></asp:ButtonColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Left" ForeColor="#003399" BackColor="#99CCCC" Mode="NumericPages"></PagerStyle>
                                </asp:DataGrid></td>
                        </tr>
                        <tr>
                            <td style="background-color: silver" colspan="3">
                                <table id="tabViewInfoJumpPage" style="font-size: x-small; font-family: Verdana; height: 26px"
                                    cellspacing="0" cellpadding="0" width="100%" border="1" runat="server">
                                    <tr>
                                        <td>
                                            <font style="background-color: #c0c0c0">共有记录:</font>
                                            <asp:Label ID="lblViewInfoRecCount" runat="server" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 16px; height: 13px">
                                            </div>
                                            <font style="background-color: #c0c0c0">总页数:</font>
                                            <asp:Label ID="lblViewInfoAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 16px; height: 13px">
                                            </div>
                                            <font style="background-color: #c0c0c0">当前页:</font>
                                            <asp:Label ID="lblViewInfoCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 16px; height: 13px">
                                            </div>
                                            <asp:Button ID="btnViewInfoPrevPage" runat="server" Font-Size="X-Small"
                                                Width="50px" Text="上一页"></asp:Button>
                                            <asp:Button ID="btnViewInfoNextPage" runat="server" Font-Size="X-Small"
                                                Width="50px" Text="下一页"></asp:Button>到第
                                                        <asp:TextBox ID="txtViewInfoJump2Page" runat="server" Font-Size="X-Small"
                                                            Width="35px"></asp:TextBox>页
                                                        <asp:Button ID="btnViewInfoJumpPage" runat="server" Font-Size="X-Small"
                                                            Width="35px" Text="确定"></asp:Button>
                                            <asp:CompareValidator ID="ViewInfoCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                ErrorMessage="错误！" ControlToValidate="txtViewInfoJump2Page" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3"></td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:Label ID="Label2" runat="server" Font-Bold="True">请选择一个权限等级：</asp:Label></td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal">
                                </asp:CheckBoxList></td>
                        </tr>
                    </table>
                </td>
                <td>
                    <table id="Table4" style="width: 219px; height: 448px" cellspacing="1" cellpadding="1"
                        width="219" border="0">
                        <tr>
                            <td style="height: 15px">
                                <asp:Button ID="Button1" runat="server" Text="显示权限"></asp:Button>
                                <asp:Button ID="Button2" runat="server" Text="设定权限"></asp:Button></td>
                        </tr>
                        <tr>
                            <td style="height: 1px">
                                <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="height: 446px" valign="top">
                                <asp:TreeView ID="TreeView1" runat="server" Height="500px" Width="300px">
                                </asp:TreeView>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <table id="Table3" style="z-index: 103; left: 928px; position: absolute; top: 152px"
            cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
            <tr>
                <td>
                    <div id="divViewInfo" style="width: 272px; position: relative; height: 534px" runat="server">
                        <asp:Label ID="lblFileName_q" Style="z-index: 113; left: 100px; position: absolute; top: 99px"
                            runat="server" Font-Names="verdana" Font-Size="x-small" Height="16px"
                            Width="70px">文件名</asp:Label>
                        <asp:TextBox ID="txtFileName_q" Style="z-index: 114; left: 175px; position: absolute; top: 99px"
                            runat="server" Width="70px"></asp:TextBox>
                        &nbsp;&nbsp;
                            <asp:Label ID="lblViewTypeCode_q" Style="z-index: 122; left: 100px; position: absolute; top: 183px"
                                runat="server" Font-Names="verdana" Font-Size="x-small" Height="16px"
                                Width="70px">ViewTypeCode</asp:Label>
                        <asp:TextBox ID="txtViewTypeCode_q" Style="z-index: 123; left: 175px; position: absolute; top: 183px"
                            runat="server" Width="70px"></asp:TextBox>
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                            <asp:Label ID="lblUserID_q" Style="z-index: 144; left: 100px; position: absolute; top: 407px"
                                runat="server" Font-Names="verdana" Font-Size="x-small" Height="16px"
                                Width="70px">UserID</asp:Label>
                        <asp:TextBox ID="txtUserID_q" Style="z-index: 145; left: 175px; position: absolute; top: 407px"
                            runat="server" Width="70px"></asp:TextBox>
                        <asp:Label ID="lblViewFunction_q" Style="z-index: 150; left: 100px; position: absolute; top: 463px"
                            runat="server" Font-Names="verdana" Font-Size="x-small" Height="16px"
                            Width="70px">ViewFunction</asp:Label>
                        <asp:TextBox ID="txtViewFunction_q" Style="z-index: 151; left: 175px; position: absolute; top: 463px"
                            runat="server" Width="70px"></asp:TextBox>
                        <asp:Label ID="lblViewDetail_q" Style="z-index: 153; left: 100px; position: absolute; top: 491px"
                            runat="server" Font-Names="verdana" Font-Size="x-small" Height="16px"
                            Width="70px">ViewDetail</asp:Label>
                        <asp:TextBox ID="txtViewDetail_q" Style="z-index: 154; left: 175px; position: absolute; top: 491px"
                            runat="server" Width="70px"></asp:TextBox>
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
                <td></td>
                <td></td>
                <td></td>
            </tr>
        </table>
    </form>
</body>
</html>
