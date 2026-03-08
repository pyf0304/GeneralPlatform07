<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmSetRelaOfViewAndPotence" Codebehind="wfmSetRelaOfViewAndPotence.aspx.cs" %>

<%@ Register TagPrefix="uc1" TagName="wucQxViewPotence" Src="wucQxViewPotence.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>表QxViewPotence的查询、修改、删除、添加记录</title>
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <font face="宋体">
            <table id="tabTitle" style="z-index: 101; left: 8px; position: absolute; top: 8px"
                cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
                <tr>
                    <td bgcolor="#ff6666">
                        <asp:Label ID="lblViewTile" runat="server" Font-Size="Small" Font-Names="宋体" ForeColor="White"
                            Font-Bold="True">QxViewPotence表的查询、修改、删除、添加</asp:Label>
                    </td>
                </tr>
            </table>
            <table id="Table1" style="z-index: 102; left: 8px; position: absolute; top: 32px"
                cellspacing="1" cellpadding="1" width="300" border="1">
                <tr>
                    <td>
                        <div id="divQxViewPotence" style="width: 768px; position: relative; height: 64px" runat="server">
                            <asp:Label ID="lblViewId_q" Style="z-index: 107; left: 344px; position: absolute;
                                top: 8px" runat="server" Font-Names="verdana" Font-Size="x-small" Height="16px"
                                Width="70px">
  界面编号</asp:Label>
                            <asp:DropDownList ID="ddlViewId_q" Style="z-index: 108; left: 408px; position: absolute;
                                top: 8px" runat="server" >
                            </asp:DropDownList>
                            <asp:Label ID="lblPrjId_q" Style="z-index: 110; left: 16px; position: absolute; top: 8px"
                                runat="server" Font-Names="verdana" Font-Size="x-small" Height="16px" Width="70px">
  项目编号</asp:Label>
                            <asp:DropDownList ID="ddlPrjId_q" Style="z-index: 111; left: 99px; position: absolute;
                                top: 3px" runat="server"  AutoPostBack="True" OnSelectedIndexChanged="ddlPrjId_q_SelectedIndexChanged"
                                Width="138px">
                            </asp:DropDownList>
                            <asp:Label ID="lblPotenceId_q" Style="z-index: 113; left: 16px; position: absolute;
                                top: 40px" runat="server" Font-Names="verdana" Font-Size="x-small" Height="16px"
                                Width="70px">
  权限ID</asp:Label>
                            <asp:DropDownList ID="ddlPotenceId_q" Style="z-index: 114; left: 80px; position: absolute;
                                top: 40px" runat="server"  Width="154px">
                            </asp:DropDownList>
                            <asp:Button ID="btnQuery" Style="z-index: 122; left: 680px; position: absolute; top: 32px"
                                runat="server" Font-Names="verdana" Font-Size="x-Small" Height="24px" Width="80px"
                                Text="查询" OnClick="btnQuery_Click"></asp:Button>
                        </div>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table id="tabQxViewPotenceDataGrid" style="font-size: x-small; width: 552px" cellspacing="0"
                            cellpadding="0" width="552" border="0" runat="server">
                            <tr>
                                <td>
                                    <asp:DataGrid ID="dgQxViewPotence" runat="server" Font-Names="verdana" Font-Size="X-Small"
                                        Width="776px" AllowSorting="True" AllowPaging="True" PageSize="7" AutoGenerateColumns="False"
                                        CellPadding="4" ForeColor="#333333" GridLines="None">
                                        <Columns>
                                            <asp:BoundColumn DataField="mId" SortExpression="mId" HeaderText="流水号"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="ViewName" SortExpression="ViewName" HeaderText="界面"></asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="PrjName" SortExpression="PrjName" HeaderText="项目">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="PotenceName" SortExpression="PotenceName" HeaderText="权限">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="Level" SortExpression="Level" HeaderText="Level">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn Visible="False" DataField="Memo" SortExpression="Memo" HeaderText="备注">
                                            </asp:BoundColumn>
                                            <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                                            <asp:TemplateColumn>
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                        </Columns>
                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center"></PagerStyle>
                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <EditItemStyle BackColor="#999999" />
                                        <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                        <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                                        <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    </asp:DataGrid></td>
                            </tr>
                            <tr>
                                <td style="width: 605px" bgcolor="silver">
                                    <table id="tabQxViewPotenceJumpPage" style="font-size: x-small; width: 568px; font-family: Verdana;
                                        height: 26px" cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                                        <tr>
                                            <td>
                                                <font face="宋体"><font style="background-color: #c0c0c0">共有记录:</font>
                                                    <asp:Label ID="lblQxViewPotenceRecCount" runat="server" ForeColor="#000066" Width="16px">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <font style="background-color: #c0c0c0">总页数:</font>
                                                    <asp:Label ID="lblQxViewPotenceAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <font style="background-color: #c0c0c0">当前页:
                                                        <asp:Label ID="lblQxViewPotenceCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                        <div style="display: inline; width: 16px; height: 13px">
                                                        </div>
                                                        <asp:Button ID="btnQxViewPotencePrevPage" runat="server" Font-Size="X-Small" 
                                                            Width="50px" Text="上一页" OnClick="btnQxViewPotencePrevPage_Click"></asp:Button>
                                                        <asp:Button ID="btnQxViewPotenceNextPage" runat="server" Font-Size="X-Small" 
                                                            Width="50px" Text="下一页" OnClick="btnQxViewPotenceNextPage_Click"></asp:Button>到第
                                                        <asp:TextBox ID="txtQxViewPotenceJump2Page" runat="server" Font-Size="X-Small" 
                                                            Width="35px"></asp:TextBox>页
                                                        <asp:Button ID="btnQxViewPotenceJumpPage" runat="server" Font-Size="X-Small" 
                                                            Width="35px" Text="确定" OnClick="btnQxViewPotenceJumpPage_Click"></asp:Button>
                                                        <asp:CompareValidator ID="QxViewPotenceCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                            Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtQxViewPotenceJump2Page"
                                                            ErrorMessage="错误！"></asp:CompareValidator></font></font></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table id="tabEditQxViewPotenceRegion" style="width: 373px; height: 200px" cellspacing="1"
                            cellpadding="1" width="373" border="1">
                            <tr>
                                <td>
                                    <div style="width: 360px; position: relative; height: 24px">
                                        <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 8px; position: absolute; top: 0px"
                                            runat="server" Font-Names="verdana" Font-Size="x-Small" Height="24px" Width="80px"
                                            Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                                        <asp:Label ID="lblMsg" Style="z-index: 105; left: 96px; position: absolute; top: 8px"
                                            runat="server" Font-Names="verdana" Font-Size="x-small" Height="16px" Width="208px"></asp:Label>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <uc1:wucQxViewPotence ID="wucQxViewPotence1" runat="server"></uc1:wucQxViewPotence>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
            <table id="Table2" style="z-index: 103; left: 848px; position: absolute; top: 104px"
                cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
                <tr>
                    <td>
                        <asp:Label ID="lblmId_q" runat="server" Font-Names="verdana" Font-Size="x-small"
                            Height="16px" Width="70px">
  流水号</asp:Label>
                        <asp:TextBox ID="txtmId_q" runat="server"  Width="70px"></asp:TextBox></td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblLevel_q" runat="server" Font-Names="verdana" Font-Size="x-small"
                            Height="16px" Width="70px">
  Level</asp:Label>
                        <asp:TextBox ID="txtLevel_q" runat="server"  Width="70px"></asp:TextBox></td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMemo_q" runat="server" Font-Names="verdana" Font-Size="x-small"
                            Height="16px" Width="70px">
  备注</asp:Label>
                        <asp:TextBox ID="txtMemo_q" runat="server"  Width="70px"></asp:TextBox></td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div style="width: 360px; position: relative; height: 24px">
                            <asp:Button ID="btnOKUpd2" Style="z-index: 106; left: 8px; position: absolute; top: 0px"
                                runat="server" Font-Names="verdana" Font-Size="x-Small" Width="80px" Height="24px"
                                Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                            <asp:Label ID="lblMsg2" Style="z-index: 105; left: 96px; position: absolute; top: 8px"
                                runat="server" Font-Names="verdana" Font-Size="x-small" Width="208px" Height="16px"></asp:Label>
                        </div>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
            </table>
        </font>
    </form>
</body>
</html>
