<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmPrjModule_QUDI" Codebehind="wfmPrjModule_QUDI.aspx.cs"  %>

<%@ Register TagPrefix="uc1" TagName="wucPrjModule" Src="wucPrjModule.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>表PrjModule的查询、修改、删除、添加记录</title>
    <link href="../../css/taishweb2.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <table id="tabTitle" style="z-index: 101; left: 8px; position: absolute; top: 8px"
            cellspacing="1" cellpadding="1" width="100%" bgcolor="#ff6666" border="0">
            <tr>
                <td bgcolor="#ff6666">
                    <asp:Label ID="lblViewTile" runat="server" Font-Size="Small" Font-Names="宋体" ForeColor="White"
                        Font-Bold="True">工程模块维护</asp:Label>
                </td>
            </tr>
        </table>
        <table id="Table1" style="z-index: 102; left: 8px; position: absolute; top: 32px"
            cellspacing="1" cellpadding="1" width="300" border="1">
            <tr>
                <td>
                    <div id="divPrjModule" style="width: 670px; position: relative; height: 32px" runat="server">
                        <asp:Label ID="lblModuleId_q" Style="z-index: 104; left: 8px; position: absolute;
                            top: 8px" runat="server" Width="70px"   >
  模块号</asp:Label>
                        <asp:TextBox ID="txtModuleId_q" Style="z-index: 105; left: 64px; position: absolute;
                            top: 5px" runat="server" Width="70px" ></asp:TextBox>
                        <asp:Label ID="lblModuleName_q" Style="z-index: 107; left: 152px; position: absolute;
                            top: 8px" runat="server" Width="70px"   >
  模块名称</asp:Label>
                        <asp:TextBox ID="txtModuleName_q" Style="z-index: 108; left: 240px; position: absolute;
                            top: 5px" runat="server" Width="70px" ></asp:TextBox>
                        <asp:Label ID="lblPrjId_q" Style="z-index: 110; left: 320px; position: absolute;
                            top: 8px" runat="server" Width="70px"   >
  项目编号</asp:Label>
                        <asp:DropDownList ID="ddlPrjId_q" Style="z-index: 111; left: 400px; position: absolute;
                            top: 5px" runat="server" Width="200px" >
                        </asp:DropDownList>
                    </div>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabPrjModuleDataGrid" style="width: 552px" cellspacing="0"
                        cellpadding="0" width="552" border="0" runat="server">
                        <tr>
                            <td>
                                <asp:DataGrid ID="dgPrjModule" runat="server"  
                                    Width="664px" AllowSorting="True" AllowPaging="True" PageSize="7" AutoGenerateColumns="False"
                                    BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" BackColor="White"
                                    CellPadding="3" GridLines="Horizontal">
                                    <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                    <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                    <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                    <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                    <Columns>
                                        <asp:BoundColumn DataField="ModuleId" SortExpression="ModuleId" HeaderText="模块号"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ModuleName" SortExpression="ModuleName" HeaderText="模块名称">
                                        </asp:BoundColumn>
                                        <asp:BoundColumn DataField="PrjName" SortExpression=clsQxProjectsEN.con_QxPrjId HeaderText="项目"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="Memo" SortExpression="Memo" HeaderText="备注"></asp:BoundColumn>
                                        <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                                        <asp:TemplateColumn>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                                    </PagerStyle>
                                </asp:DataGrid></td>
                        </tr>
                        <tr>
                            <td style="width: 605px" bgcolor="silver">
                                <table id="tabPrjModuleJumpPage" style="width: 568px; font-family: Verdana;
                                    height: 26px" cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                                    <tr>
                                        <td>
                                            <font face="宋体"><font style="background-color: #c0c0c0">共有记录:</font>
                                                <asp:Label ID="lblPrjModuleRecCount" runat="server" ForeColor="#000066" Width="16px">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">总页数:</font>
                                                <asp:Label ID="lblPrjModuleAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                                <div style="display: inline; width: 16px; height: 13px">
                                                </div>
                                                <font style="background-color: #c0c0c0">当前页:
                                                    <asp:Label ID="lblPrjModuleCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                                    <div style="display: inline; width: 16px; height: 13px">
                                                    </div>
                                                    <asp:Button ID="btnPrjModulePrevPage" runat="server"  
                                                        Width="50px" Text="上一页" OnClick="btnPrjModulePrevPage_Click"></asp:Button>
                                                    <asp:Button ID="btnPrjModuleNextPage" runat="server"  
                                                        Width="50px" Text="下一页" OnClick="btnPrjModuleNextPage_Click"></asp:Button>到第
                                                    <asp:TextBox ID="txtPrjModuleJump2Page" runat="server"  
                                                        Width="35px"></asp:TextBox>页
                                                    <asp:Button ID="btnPrjModuleJumpPage" runat="server"  
                                                        Width="35px" Text="确定" OnClick="btnPrjModuleJumpPage_Click"></asp:Button>
                                                    <asp:CompareValidator ID="PrjModuleCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                        Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtPrjModuleJump2Page"
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
                    <table id="tabEditPrjModuleRegion" style="width: 616px; height: 200px" cellspacing="1"
                        cellpadding="1" width="616" border="1">
                        <tr>
                            <td>
                                <div style="width: 360px; position: relative; height: 24px">
                                    <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 8px; position: absolute; top: 0px"
                                        runat="server" Width="80px"   
                                        Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                                    <asp:Label ID="lblMsg" Style="z-index: 105; left: 96px; position: absolute; top: 8px"
                                        runat="server" Width="208px"   ></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc1:wucPrjModule ID="wucPrjModule1" runat="server"></uc1:wucPrjModule>
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
        <asp:Button ID="btnQuery" Style="z-index: 116; left: 616px; position: absolute; top: 40px"
            runat="server" Width="80px"   
            Text="查询" OnClick="btnQuery_Click"></asp:Button>
    </form>
</body>
</html>
