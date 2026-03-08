<%@ Page Language="c#" AutoEventWireup="True" Inherits="GeneralPlatform.Webform.wfmSetRelaOfPotenceAndSymbol"
    CodeBehind="wfmSetRelaOfPotenceAndSymbol.aspx.cs" Theme="TaiZeTheme" %>

<%@ Register Src="../UserRolePotence/wucRelaOfPotenceAndSymbol.ascx" TagName="wucRelaOfPotenceAndSymbol"
    TagPrefix="uc1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>表RelaOfPotenceAndSymbol的查询、修改、删除、添加记录</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />

    <style type="text/css">
        .auto-style1 {
            z-index: 107;
        }

        .auto-style2 {
            z-index: 110;
        }

        .auto-style3 {
            z-index: 104;
        }
    </style>
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <table id="tabTitle" style="z-index: 101; left: 8px; position: absolute; top: 8px"
            cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
            <tr>
                <td bgcolor="#ff6666">
                    <asp:Label ID="lblViewTile" runat="server" Font-Size="Small" Font-Names="宋体" ForeColor="White"
                        Font-Bold="True">权限、标志关系维护</asp:Label>
                </td>
            </tr>
        </table>
        <table id="Table1" style="z-index: 102; left: 8px; position: absolute; top: 32px"
            cellspacing="1" cellpadding="1" width="100%" border="1">
            <tr>
                <td>
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="lblPrjId_q" Style="z-index: 116;" runat="server"
                                    Width="33px">项目</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlPrjId_q" Style="z-index: 117;" runat="server" AutoPostBack="True"
                                    OnSelectedIndexChanged="ddlPrjId_q_SelectedIndexChanged" Width="140px">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="lblPotenceId0" runat="server"
                                    Width="78px">权限类型</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlPotenceTypeId" runat="server"
                                    Width="143px" AutoPostBack="True" OnSelectedIndexChanged="ddlPotenceTypeId_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="lblPotenceId_q" runat="server"
                                    Width="46px" CssClass="auto-style3">权限</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlPotenceId_q" Style="z-index: 105;" runat="server"
                                    Width="206px">
                                </asp:DropDownList>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblSymbolForProgramme_q" runat="server"
                                    Width="80px" CssClass="auto-style1">编程标志</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtSymbolForProgramme_q" Style="z-index: 108;" runat="server" Width="118px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label ID="lblSymbolName_q" runat="server"
                                    Width="78px" CssClass="auto-style2">标志名称</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtSymbolName_q" Style="z-index: 111;" runat="server" Width="146px"></asp:TextBox>
                            </td>
                            <td>
                                 </td>
                            <td>
                                 </td>
                            <td>
                                <asp:Button ID="btnQuery" Style="z-index: 122;" runat="server"
                                    Width="80px" Text="查询" OnClick="btnQuery_Click"></asp:Button>
                            </td>
                            <td>
                                <asp:Button ID="btnExportExcel4Dg" Style="z-index: 107;" CssClass="btn btn-outline-info btn-sm" runat="server" Width="80px" Text="导出Excel" OnClick="btnExportExcel4Dg_Click"></asp:Button>
                                  </td>
                            <td>
                                <asp:Button ID="btnSetExportExcel4User" OnClick="btnSetExportExcel4User_Click" Style="z-index: 107;"  CssClass="btn btn-outline-info btn-sm" runat="server" Width="100px" Text="设置导出字段"></asp:Button></td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="10"></td>
                        </tr>
                        <tr>
                           
                            <td></td>
                            <td></td>
                             <td style="width: 64px">
                                            <asp:Label ID="lblSymbolForProgramme" runat="server" Width="40px">标志</asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="txtSymbolForProgramme" runat="server" Width="82px"></asp:TextBox></td>
                                        <td style="width: 68px">
                                            <asp:Label ID="lblSymbolName" runat="server" Width="57px">标志名</asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="txtSymbolName" runat="server" Width="109px"></asp:TextBox>
                                            <asp:Button ID="btnBatchSetSymbol" Style="z-index: 105;"
                                                runat="server" Width="100px" Text="批量设置标志" OnClick="btnBatchSetSymbol_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                        </td>

                                        <td colspan="4">
                                    <asp:Label ID="lblMsg_List" Style="z-index: 105; " runat="server" Width="208px"></asp:Label>
                                </td>
                                       
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabRelaOfPotenceAndSymbolDataGrid"
                        cellspacing="0" cellpadding="0" width="100%" border="0" runat="server">
                        <tr>
                            <td>
                                <asp:DataGrid ID="dgRelaOfPotenceAndSymbol" runat="server" Width="100%" AutoGenerateColumns="False"
                                    AllowPaging="True" AllowSorting="True"
                                    CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="20" DataKeyField="RelaMid">
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
                                        <asp:BoundColumn DataField="RelaMid" SortExpression="RelaMid" HeaderText="流水号"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PotenceTypeName" SortExpression="PotenceTypeName" HeaderText="权限类型"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PotenceName" SortExpression="PotenceName" HeaderText="权限"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="SymbolNum" SortExpression="SymbolNum" HeaderText="标志数"></asp:BoundColumn>

                                        <asp:BoundColumn DataField="SymbolForProgramme" SortExpression="SymbolForProgramme"
                                            HeaderText="编程标志"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="SymbolName" SortExpression="SymbolName" HeaderText="标志名称"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="Memo" SortExpression="Memo" HeaderText="备注"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="PrjName" SortExpression="PrjName" HeaderText="项目编号"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="UpdUserId" SortExpression="UpdUserId" HeaderText="修改用户Id"></asp:BoundColumn>
                                        <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                                        <asp:TemplateColumn>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                    </Columns>
                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Left" NextPageText="下一页"
                                        PrevPageText="上一页"></PagerStyle>
                                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <EditItemStyle BackColor="#999999" />
                                    <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                                    <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                </asp:DataGrid>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 605px" bgcolor="silver">
                                <table id="tabRelaOfPotenceAndSymbolJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                                    cellspacing="0" cellpadding="0" width="568"
                                    border="1" runat="server">
                                    <tr>
                                        <td>
                                            <font style="background-color: #c0c0c0">共有记录:</font>
                                            <asp:Label ID="lblRelaOfPotenceAndSymbolRecCount" runat="server" Width="36px" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 16px; height: 13px">
                                            </div>
                                            <font style="background-color: #c0c0c0">总页数:</font>
                                            <asp:Label ID="lblRelaOfPotenceAndSymbolAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 36px; height: 13px">
                                            </div>
                                            <font style="background-color: #c0c0c0">当前页:</font>
                                            <asp:Label ID="lblRelaOfPotenceAndSymbolCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 36px; height: 13px">
                                            </div>
                                            <asp:Button ID="btnRelaOfPotenceAndSymbolPrevPage" runat="server"
                                                Width="60px" Text="上一页" OnClick="btnRelaOfPotenceAndSymbolPrevPage_Click"></asp:Button>
                                            <asp:Button ID="btnRelaOfPotenceAndSymbolNextPage" runat="server"
                                                Width="60px" Text="下一页" OnClick="btnRelaOfPotenceAndSymbolNextPage_Click"></asp:Button>
                                            到第
                                                <asp:TextBox ID="txtRelaOfPotenceAndSymbolJump2Page" runat="server"
                                                    Width="35px"></asp:TextBox>页
                                                <asp:Button ID="btnRelaOfPotenceAndSymbolJumpPage" runat="server"
                                                    Width="35px" Text="确定" OnClick="btnRelaOfPotenceAndSymbolJumpPage_Click"></asp:Button>
                                            <asp:CompareValidator ID="RelaOfPotenceAndSymbolCompareValidator1" runat="server"
                                                ForeColor="DarkOrange" ErrorMessage="错误！" ControlToValidate="txtRelaOfPotenceAndSymbolJump2Page"
                                                Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabEditRelaOfPotenceAndSymbolRegion" style="width: 373px; height: 200px"
                        cellspacing="1" cellpadding="1" width="373" border="1">
                        <tr>
                            <td>
                                <div style="width: 586px; position: relative; height: 24px">
                                    <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 8px; position: absolute; top: 0px"
                                        runat="server" Width="80px"
                                        Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                                    <asp:Label ID="lblMsg" Style="z-index: 105; left: 96px; position: absolute; top: 8px"
                                        runat="server" Width="208px"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc1:wucRelaOfPotenceAndSymbol ID="wucRelaOfPotenceAndSymbol1" runat="server"></uc1:wucRelaOfPotenceAndSymbol>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <table id="Table2" style="z-index: 103; left: 888px; position: absolute; top: 128px"
            cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
            <tr>
                <td>
                    <asp:Label ID="lblRelaMid_q" runat="server"
                        Width="70px">流水号</asp:Label>
                    <asp:TextBox ID="txtRelaMid_q" runat="server" Width="70px"></asp:TextBox>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMemo_q" runat="server"
                        Width="70px">备注</asp:Label>
                    <asp:TextBox ID="txtMemo_q" runat="server" Width="70px"></asp:TextBox>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <div style="width: 360px; position: relative; height: 24px">
                        <asp:Button ID="btnOKUpd2" Style="z-index: 106; left: 8px; position: absolute; top: 0px"
                            runat="server" Width="80px"
                            Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                        <asp:Label ID="lblMsg2" Style="z-index: 105; left: 96px; position: absolute; top: 8px"
                            runat="server" Width="208px"></asp:Label>
                    </div>
                </td>
                <td></td>
                <td></td>
            </tr>
        </table>
    </form>
</body>
</html>
