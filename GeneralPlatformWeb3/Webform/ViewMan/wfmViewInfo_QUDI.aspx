<%@ Register TagPrefix="uc1" TagName="wucViewInfo" Src="wucViewInfo.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmViewInfo_QUDI" Codebehind="wfmViewInfo_QUDI.aspx.cs" Theme="TaiZeTheme"  %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>表ViewInfo的查询、修改、删除、添加记录</title>
                <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <table id="Table1" style="z-index: 105; left: 8px; width: 100%; position: absolute;
            top: 40px; height: 304px" cellspacing="1" cellpadding="1" border="0">
            <tr>
                <td>
                    <div style="width: 100%; position: relative; height: 64px">
                        <asp:Label ID="lblViewId_q" Style="z-index: 104; left: 8px; position: absolute; top: 8px"
                            runat="server"    Width="70px">
  界面编号</asp:Label>
                        <asp:TextBox ID="txtViewId_q" Style="z-index: 102; left: 72px; position: absolute;
                            top: 8px" runat="server"  Width="150px"></asp:TextBox>
                        <asp:Label ID="lblViewName_q" Style="z-index: 105; left: 240px; position: absolute;
                            top: 8px" runat="server"   
                            Width="70px">
  界面名称</asp:Label>
                        <asp:TextBox ID="txtViewName_q" Style="z-index: 108; left: 304px; position: absolute;
                            top: 8px" runat="server"  Width="150px"></asp:TextBox>
                        <asp:Label ID="lblViewCnName_q" Style="z-index: 106; left: 472px; position: absolute;
                            top: 8px" runat="server"   
                            Width="72px">  界面中文名</asp:Label>
                        <asp:TextBox ID="txtViewCnName_q" Style="z-index: 103; left: 544px; position: absolute;
                            top: 8px" runat="server"  Width="150px"></asp:TextBox>
                        <asp:Label ID="lblPrjId_q" Style="z-index: 107; left: 8px; position: absolute; top: 40px"
                            runat="server"    Width="70px">
  项目编号</asp:Label>
                        <asp:DropDownList ID="ddlPrjId_q" Style="z-index: 109; left: 72px; position: absolute;
                            top: 40px" runat="server" Width="152px" OnSelectedIndexChanged="ddlPrjId_q_SelectedIndexChanged">
                        </asp:DropDownList>
                        <asp:Button ID="btnQuery" Style="z-index: 101; left: 720px; position: absolute; top: 32px"
                            runat="server"    Width="80px"
                            Text="查询" OnClick="btnQuery_Click"></asp:Button>
                        <asp:DropDownList ID="ddlModuleId" Style="z-index: 110; left: 304px; position: absolute;
                            top: 40px" runat="server" Width="160px"  
                            CssClass="ValueControl">
                        </asp:DropDownList>
                        <asp:Label ID="lblModuleId" Style="z-index: 111; left: 248px; position: absolute;
                            top: 40px" runat="server"   CssClass="NameControl">模块</asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DataGrid ID="dgViewInfo" runat="server"  
                        Width="840px" AutoGenerateColumns="False" PageSize="7" AllowPaging="True" AllowSorting="True"
                        BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" BackColor="White"
                        CellPadding="3" GridLines="Horizontal">
                        <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                        <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                        <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                        <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                        <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                        <Columns>
                            <asp:BoundColumn DataField="ViewId" SortExpression="ViewId" HeaderText="界面编号"></asp:BoundColumn>
                            <asp:BoundColumn DataField="ViewName" SortExpression="ViewName" HeaderText="界面名称"></asp:BoundColumn>
                            <asp:BoundColumn DataField="ViewCnName" SortExpression="ViewCnName" HeaderText="界面中文名称">
                            </asp:BoundColumn>
                            <asp:BoundColumn Visible="False" DataField="FileName" SortExpression="FileName" HeaderText="文件名">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="FilePath" SortExpression="FilePath" HeaderText="文件路径"></asp:BoundColumn>
                            <asp:BoundColumn Visible="False" DataField="UpdUserID" SortExpression="UpdUserID" HeaderText="UpdUserID">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="PrjName" SortExpression="PrjName" HeaderText="项目"></asp:BoundColumn>
                            <asp:BoundColumn DataField="ModuleName" SortExpression="ModuleName" HeaderText="模块">
                            </asp:BoundColumn>
                            <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                            <asp:TemplateColumn>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                        </Columns>
                        <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                        </PagerStyle>
                    </asp:DataGrid>
                    <table id="tabViewInfoJumpPage" style="width: 100%; font-family: Verdana;
                        height: 26px" cellspacing="0" cellpadding="0" width="880" border="1" runat="server">
                        <tr>
                            <td style="background-color: silver">
                                <font face="宋体"><font style="background-color: #c0c0c0">共有记录:</font>
                                    <asp:Label ID="lblViewInfoRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <font style="background-color: #c0c0c0">总页数:</font>
                                    <asp:Label ID="lblViewInfoAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <font style="background-color: #c0c0c0">当前页:
                                        <asp:Label ID="lblViewInfoCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <asp:Button ID="btnViewInfoPrevPage" runat="server"  
                                            Width="50px" Text="上一页" OnClick="btnViewInfoPrevPage_Click"></asp:Button><asp:Button
                                                ID="btnViewInfoNextPage" runat="server"   Width="50px"
                                                Text="下一页" OnClick="btnViewInfoNextPage_Click"></asp:Button>到第
                                        <asp:TextBox ID="txtViewInfoJump2Page" runat="server"  
                                            Width="35px"></asp:TextBox>页
                                        <asp:Button ID="btnViewInfoJumpPage" runat="server"  
                                            Width="35px" Text="确定" OnClick="btnViewInfoJumpPage_Click"></asp:Button><asp:CompareValidator
                                                ID="ViewInfoCompareValidator1" runat="server" ForeColor="DarkOrange" ErrorMessage="错误！"
                                                ControlToValidate="txtViewInfoJump2Page" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator></font></font></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnOKUpd" runat="server"  
                         Width="80px" Text="添加" OnClick="btnOKUpd_Click"></asp:Button><asp:Label
                            ID="lblMsg" runat="server"   
                            Width="70px"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <uc1:wucViewInfo ID="wucViewInfo1" runat="server"></uc1:wucViewInfo>
                </td>
            </tr>
        </table>
        <table id="tabTitle" style="z-index: 149; left: 8px; width: 100%; position: absolute;
            top: 8px; height: 22px" cellspacing="1" cellpadding="1" width="800" bgcolor="#ff6666"
            border="0">
            <tr>
                <td bgcolor="#ff6666">
                    <asp:Label ID="lblViewTile" runat="server" Font-Names="宋体" Font-Size="Small" ForeColor="White"
                        Font-Bold="True">界面信息维护</asp:Label></td>
            </tr>
        </table>
    </form>
</body>
</html>
