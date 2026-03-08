<%@ Register TagPrefix="uc1" TagName="wucProjects" Src="wucProjects.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmProjects_QUDI" CodeBehind="wfmProjects_QUDI.aspx.cs"  Theme="TaiZeTheme" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>表QxProjects的查询、修改、删除、添加记录</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <table id="Table1" style="z-index: 114; left: 856px; position: absolute; top: 64px"
            cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
            <tr>
                <td>
                    <div style="width: 433px; position: relative; height: 238px">
                        <asp:Label ID="lblPrjDomain_q" Style="z-index: 110; left: 32px; position: absolute; top: 48px"
                            runat="server"   Width="80px"
                            Height="15px">PrjDomain</asp:Label>
                        <asp:TextBox ID="txtPrjDomain_q" Style="z-index: 104; left: 128px; position: absolute; top: 48px"
                            runat="server" Width="100px"></asp:TextBox>
                        <asp:Label ID="lblPrjMainDataBase_q" Style="z-index: 108; left: 32px; position: absolute; top: 80px"
                            runat="server"   Width="80px"
                            Height="15px">PrjMainDataBase</asp:Label>
                        <asp:TextBox ID="txtPrjMainDataBase_q" Style="z-index: 106; left: 128px; position: absolute; top: 80px"
                            runat="server" Width="100px"></asp:TextBox>
                        <asp:Label ID="lblIpAddress_q" Style="z-index: 109; left: 32px; position: absolute; top: 104px"
                            runat="server"   Width="80px"
                            Height="15px">IpAddress</asp:Label>
                        <asp:TextBox ID="txtIpAddress_q" Style="z-index: 114; left: 128px; position: absolute; top: 104px"
                            runat="server" Width="100px"></asp:TextBox>
                        <asp:Label ID="lblDataBaseUserId_q" Style="z-index: 101; left: 32px; position: absolute; top: 136px"
                            runat="server"   Width="80px"
                            Height="15px">DataBaseUserId</asp:Label>
                        <asp:TextBox ID="txtDataBaseUserId_q" Style="z-index: 103; left: 128px; position: absolute; top: 136px"
                            runat="server" Width="100px"></asp:TextBox>
                        <asp:Label ID="lblDataBasePwd_q" Style="z-index: 105; left: 32px; position: absolute; top: 160px"
                            runat="server"   Width="80px"
                            Height="15px">DataBasePwd</asp:Label>
                        <asp:TextBox ID="txtDataBasePwd_q" Style="z-index: 107; left: 128px; position: absolute; top: 160px"
                            runat="server" Width="100px"></asp:TextBox>
                        <asp:Label ID="lblUserID_q" Style="z-index: 111; left: 32px; position: absolute; top: 192px"
                            runat="server"   Width="80px"
                            Height="15px">UserID</asp:Label>
                        <asp:TextBox ID="txtUserID_q" Style="z-index: 112; left: 128px; position: absolute; top: 192px"
                            runat="server" Width="100px"></asp:TextBox>
                        <asp:Label ID="lblUpdTime_q" Style="z-index: 113; left: 32px; position: absolute; top: 216px"
                            runat="server"   Width="80px"
                            Height="15px">UpdTime</asp:Label>
                        <asp:TextBox ID="txtUpdTime_q" Style="z-index: 100; left: 128px; position: absolute; top: 216px"
                            runat="server" Width="100px"></asp:TextBox>
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
        <table id="Table2" style="z-index: 115; left: 8px; width: 736px; position: absolute; top: 48px"
            cellspacing="1" cellpadding="1" width="736" border="0">
            <tr>
                <td>
                    <div style="width: 776px; position: relative; height: 40px">
                        <asp:Label ID="lblPrjId_q" Style="z-index: 116; left: 8px; position: absolute; top: 16px"
                            runat="server"   Width="56px" Height="15px">项目编号</asp:Label>
                        <asp:TextBox ID="txtPrjId_q" Style="z-index: 116; left: 72px; position: absolute; top: 16px"
                            runat="server" Width="100px"></asp:TextBox>
                        <asp:Label ID="lblPrjName_q" Style="z-index: 116; left: 192px; position: absolute; top: 16px"
                            runat="server"   Width="56px"
                            Height="15px">项目名称</asp:Label>
                        <asp:TextBox ID="txtPrjName_q" Style="z-index: 116; left: 264px; position: absolute; top: 16px"
                            runat="server" Width="128px"></asp:TextBox>
                        <asp:Label ID="lblMemo_q" Style="z-index: 116; left: 408px; position: absolute; top: 16px"
                            runat="server"   Width="72px" Height="15px">超链接地址</asp:Label>
                        <asp:TextBox ID="txtMemo_q" Style="z-index: 116; left: 496px; position: absolute; top: 16px"
                            runat="server" Width="176px"></asp:TextBox>
                        <asp:Button ID="btnQuery" Style="z-index: 116; left: 688px; position: absolute; top: 16px"
                            runat="server" Width="80px" Text="查询" OnClick="btnQuery_Click"></asp:Button>
                    </div>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <div style="width: 712px; position: relative; height: 24px">
                        <asp:Label ID="Label1" Style="z-index: 115; left: 0px; position: absolute; top: 0px"
                            runat="server" Width="152px" CssClass="RegionTitleH1">工程列表</asp:Label>
                    </div>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <asp:DataGrid ID="dgProjects" runat="server" Width="784px" Height="154px" AutoGenerateColumns="False"
                        AllowPaging="True" Font-Names="宋体"  BorderColor="#E7E7FF"
                        BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Horizontal">
                        <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                        <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                        <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                        <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                        <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                        <Columns>
                            <asp:BoundColumn DataField="QxPrjId" HeaderText="项目编号"></asp:BoundColumn>
                            <asp:BoundColumn DataField="PrjName" HeaderText="项目名称"></asp:BoundColumn>
                            <asp:BoundColumn DataField="IsDefaultPrj" HeaderText="默认工程?" SortExpression="IsDefaultPrj"></asp:BoundColumn>
                            
                            <asp:BoundColumn Visible="False" DataField="UpdUser" HeaderText="UpdUser"></asp:BoundColumn>
                            <asp:BoundColumn Visible="False" DataField="UpdDate" HeaderText="UpdDate"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Memo" HeaderText="超链接地址"></asp:BoundColumn>
                            <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                            <asp:TemplateColumn>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                        </Columns>
                        <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
                    </asp:DataGrid>
                    <asp:Label ID="lblRecCount" runat="server" Width="110px" Height="12px" 
                        >查询结果记录数：</asp:Label>
                    <asp:TextBox ID="txtRecCount" runat="server" Width="111px" 
                         ReadOnly="True"></asp:TextBox></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnOKUpd" runat="server" Width="80px" Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                    <asp:Label ID="lblMsg" runat="server" Width="215px" Height="15px"></asp:Label></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabLayout" style="width: 373px; height: 15px" cellspacing="1" cellpadding="1"
                        width="373" border="0" runat="server">
                        <tr>
                            <td>
                                <uc1:wucProjects ID="wucProjects1" runat="server"></uc1:wucProjects>
                            </td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
        </table>
        <asp:Label ID="lblTitle" Style="z-index: 115; left: 16px; position: absolute; top: 16px"
            runat="server" Width="152px" CssClass="PageTitleH1">工程信息维护</asp:Label>
    </form>
</body>
</html>
