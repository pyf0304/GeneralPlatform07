<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmUserGroups_QUDI" Codebehind="wfmUserGroups_QUDI.aspx.cs" Theme="TaiZeTheme"  %>

<%@ Register TagPrefix="uc1" TagName="wucUserGroups" Src="wucUserGroups.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>表UserGroups的查询、修改、删除、添加记录</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <font face="宋体">
            <asp:Label ID="lblTitle" Style="z-index: 101; left: 8px; position: absolute; top: 8px"
                runat="server" Width="80px"   >用户组的维护</asp:Label>
            <asp:Label ID="lblGroupId_q" Style="z-index: 102; left: 8px; position: absolute;
                top: 40px" runat="server"   Width="72px"
                Height="15px">用户组编号</asp:Label>
            <asp:TextBox ID="txtGroupId_q" Style="z-index: 103; left: 80px; position: absolute;
                top: 32px" runat="server" Width="100px" ></asp:TextBox>
            <asp:Label ID="lblGroupName_q" Style="z-index: 104; left: 208px; position: absolute;
                top: 40px" runat="server"   Width="56px"
                Height="15px">用户组</asp:Label>
            <asp:TextBox ID="txtGroupName_q" Style="z-index: 105; left: 264px; position: absolute;
                top: 32px" runat="server" Width="100px" ></asp:TextBox>
            <asp:Label ID="lblPrjId_q" Style="z-index: 106; left: 400px; position: absolute;
                top: 40px" runat="server"   Width="56px"
                Height="15px">工程编号</asp:Label>
            <asp:DropDownList ID="ddlPrjId_q" Style="z-index: 107; left: 456px; position: absolute;
                top: 32px" runat="server" Width="100px" >
            </asp:DropDownList>
            <asp:Button ID="btnQuery" Style="z-index: 108; left: 600px; position: absolute; top: 32px"
                runat="server" Width="80px"  Text="查询" OnClick="btnQuery_Click"></asp:Button>
        </font>
        <table id="Table1" style="z-index: 115; left: 8px; width: 680px; position: absolute;
            top: 64px; height: 233px" cellspacing="0" cellpadding="0" width="680" border="0">
            <tr>
                <td style="width: 399px">
                    <asp:DataGrid ID="dgUserGroups" runat="server"  Font-Names="宋体"
                        Height="154px" Width="400px" AllowPaging="True" PageSize="5" AutoGenerateColumns="False"
                        BorderColor="#999999" BorderStyle="Solid" CellSpacing="2" BorderWidth="3px" BackColor="#CCCCCC"
                        CellPadding="4" ForeColor="Black">
                        <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#000099"></SelectedItemStyle>
                        <ItemStyle BackColor="White"></ItemStyle>
                        <HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
                        <FooterStyle BackColor="#CCCCCC"></FooterStyle>
                        <Columns>
                            <asp:BoundColumn DataField="GroupId" HeaderText="用户组编号">
                                <HeaderStyle Width="22%"></HeaderStyle>
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="GroupName" HeaderText="用户组">
                                <HeaderStyle Width="20%"></HeaderStyle>
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="ProjectsPrjName" HeaderText="工程编号">
                                <HeaderStyle Width="18%"></HeaderStyle>
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="Memo" HeaderText="备注"></asp:BoundColumn>
                            <asp:ButtonColumn Text="修改" CommandName="Update">
                                <HeaderStyle Width="10%"></HeaderStyle>
                            </asp:ButtonColumn>
                            <asp:TemplateColumn>
                                <HeaderStyle Width="10%"></HeaderStyle>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                        </Columns>
                        <PagerStyle HorizontalAlign="Left" ForeColor="Black" BackColor="#CCCCCC" Mode="NumericPages">
                        </PagerStyle>
                    </asp:DataGrid></td>
                <td>
                    <uc1:wucUserGroups ID="wucUserGroups1" runat="server"></uc1:wucUserGroups>
                </td>
            </tr>
            <tr>
                <td style="width: 399px">
                    <asp:Label ID="lblRecCount" runat="server"  
                        Height="12px" Width="110px">查询结果记录数：</asp:Label>
                    <asp:TextBox ID="txtRecCount" runat="server" Width="111px"  
                         ReadOnly="True"></asp:TextBox></td>
                <td>
                    <asp:Button ID="btnOKUpd" runat="server" Width="80px"  Text="添加" OnClick="btnOKUpd_Click">
                    </asp:Button>
                    <asp:Label ID="lblMsg" runat="server" Width="168px" Height="15px" 
                        ></asp:Label></td>
            </tr>
        </table>
    </form>
</body>
</html>
