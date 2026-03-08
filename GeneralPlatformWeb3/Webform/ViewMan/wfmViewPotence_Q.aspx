<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmQxViewPotence_Q" Codebehind="wfmQxViewPotence_Q.aspx.cs" Theme="TaiZeTheme"  %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>表QxViewPotence的查询修改记录</title>
                <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <font face="宋体">
            <asp:Label ID="lblViewTitle" Style="z-index: 114; left: 8px; position: absolute;
                top: 8px" runat="server"  CssClass="PageTitleH1">界面权限关系查询</asp:Label>
            <table id="tabLayout" style="z-index: 105; left: 4px; position: absolute; top: 32px"
                cellspacing="2" cellpadding="2" width="300" border="0" runat="server">
                <tr>
                    <td>
                        <div id="divQxViewPotence" style="z-index: 119; width: 750px; position: relative; height: 69px"
                            runat="server">
                            <asp:Label ID="lblPrjId_q" Style="z-index: 104; left: 10px; position: absolute; top: 15px"
                                runat="server" Width="32px"   >项目</asp:Label>
                            <asp:DropDownList ID="ddlPrjId_q" Style="z-index: 105; left: 48px; position: absolute;
                                top: 15px" runat="server" Width="192px"  OnSelectedIndexChanged="ddlPrjId_q_SelectedIndexChanged">
                            </asp:DropDownList>
                            <asp:Label ID="lblModuleId_q" Style="z-index: 107; left: 260px; position: absolute;
                                top: 15px" runat="server" Width="40px"   >模块</asp:Label>
                            <asp:DropDownList ID="ddlModuleId_q" Style="z-index: 108; left: 304px; position: absolute;
                                top: 15px" runat="server" Width="168px" >
                            </asp:DropDownList>
                            <asp:Label ID="lblViewId_q" Style="z-index: 110; left: 488px; position: absolute;
                                top: 15px" runat="server" Width="32px"   >界面</asp:Label>
                            <asp:DropDownList ID="ddlViewId_q" Style="z-index: 111; left: 528px; position: absolute;
                                top: 15px" runat="server" Width="176px" >
                            </asp:DropDownList>
                            <asp:Label ID="lblPotenceId_q" Style="z-index: 113; left: 10px; position: absolute;
                                top: 45px" runat="server" Width="32px"   >权限</asp:Label>
                            <asp:DropDownList ID="ddlPotenceId_q" Style="z-index: 114; left: 48px; position: absolute;
                                top: 45px" runat="server" Width="192px" >
                            </asp:DropDownList>
                            <asp:Label ID="lblLevel_q" Style="z-index: 116; left: 260px; position: absolute;
                                top: 45px" runat="server" Width="32px"   >等级</asp:Label>
                            <asp:TextBox ID="txtLevel_q" Style="z-index: 117; left: 304px; position: absolute;
                                top: 45px" runat="server" Width="168px" ></asp:TextBox>
                            <asp:Button ID="btnQuery" Style="z-index: 119; left: 488px; position: absolute; top: 45px"
                                runat="server" Width="72px"   
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
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <table id="tabQxViewPotenceDataGrid" style="z-index: 225; width: 552px"
                            cellspacing="0" cellpadding="0" width="552" border="0" runat="server">
                            <tr>
                                <td>
                                    <div style="display: inline; width: 750px; position: relative; height: 32px">
                                        <asp:Label ID="lblQxViewPotenceList" Style="z-index: 105; left: 8px; position: absolute;
                                            top: 4px" runat="server" CssClass="RegionTitleH1" >界面权限关系列表</asp:Label>
                                        <asp:Button ID="btnExportExcel4Dg" Style="z-index: 107; left: 475px; position: absolute;
                                            top: 4px" runat="server"  Width="80px" Text="导出Excel" OnClick="btnExportExcel4Dg_Click">
                                        </asp:Button>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DataGrid ID="dgQxViewPotence" Style="z-index: 120; left: 510px; top: 125px" runat="server"
                                        Width="800px" AutoGenerateColumns="False" AllowPaging="True" 
                                         AllowSorting="True" BorderColor="#E7E7FF" BorderStyle="None"
                                        BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Horizontal">
                                        <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                        <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                        <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                        <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                        <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                        <Columns>
                                            <asp:TemplateColumn HeaderText="选择">
                                                <HeaderStyle Width="30px"></HeaderStyle>
                                                <HeaderTemplate>
                                                    <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" 
                                                        >全选</asp:LinkButton>
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                                </ItemTemplate>
                                            </asp:TemplateColumn>
                                            <asp:BoundColumn Visible="False" DataField="mId" SortExpression="mId" HeaderText="流水号">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="ModuleName" SortExpression="ModuleName" HeaderText="模块名称">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="ViewId" SortExpression="ViewId" HeaderText="界面编号"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="ViewName" SortExpression="ViewName" HeaderText="界面名称"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="PotenceId" SortExpression="PotenceId" HeaderText="权限ID">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="PotenceName" SortExpression="PotenceName" HeaderText="权限名称">
                                            </asp:BoundColumn>
                                            <asp:BoundColumn DataField="Level" SortExpression="Level" HeaderText="等级"></asp:BoundColumn>
                                            <asp:BoundColumn DataField="PrjName" SortExpression="PrjName" HeaderText="工程名"></asp:BoundColumn>
                                        </Columns>
                                        <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                                        </PagerStyle>
                                    </asp:DataGrid>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 605px" bgcolor="silver">
                                    <table id="tabQxViewPotenceJumpPage" style="width: 568px; font-family: Verdana;
                                        height: 26px" cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                                        <tr>
                                            <td>
                                                <font face="宋体"><font style="background-color: #c0c0c0">共有记录:</font>
                                                    <asp:Label ID="lblQxViewPotenceRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
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
                                                        <asp:Button ID="btnQxViewPotencePrevPage" runat="server"  
                                                            Width="50px" Text="上一页" OnClick="btnQxViewPotencePrevPage_Click"></asp:Button>
                                                        <asp:Button ID="btnQxViewPotenceNextPage" runat="server"  
                                                            Width="50px" Text="下一页" OnClick="btnQxViewPotenceNextPage_Click"></asp:Button>
                                                        到第
                                                        <asp:TextBox ID="txtQxViewPotenceJump2Page" runat="server"  
                                                            Width="35px"></asp:TextBox>页
                                                        <asp:Button ID="btnQxViewPotenceJumpPage" runat="server"  
                                                            Width="35px" Text="确定" OnClick="btnQxViewPotenceJumpPage_Click"></asp:Button>
                                                        <asp:CompareValidator ID="QxViewPotenceCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                            ErrorMessage="错误！" ControlToValidate="txtQxViewPotenceJump2Page" Type="Integer"
                                                            Operator="DataTypeCheck"></asp:CompareValidator></font></font>
                                            </td>
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
