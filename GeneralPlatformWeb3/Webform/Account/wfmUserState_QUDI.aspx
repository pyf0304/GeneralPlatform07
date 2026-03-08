<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmUserState_QUDI" Codebehind="wfmUserState_QUDI.aspx.cs"  Theme="TaiZeTheme" %>

<%@ Register TagPrefix="uc1" TagName="wucUserState" Src="wucUserState.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>表QxUserState的查询、修改、删除、添加记录</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="lblTitle" Style="z-index: 101; left: 8px; position: absolute; top: 8px"
            runat="server" Width="88px"   >用户状态维护</asp:Label>
        <asp:Label ID="lblUserStateId_q" Style="z-index: 102; left: 16px; position: absolute;
            top: 48px" runat="server"   Width="80px"
            Height="15px">用户状态编号</asp:Label>
        <asp:TextBox ID="txtUserStateId_q" Style="z-index: 103; left: 120px; position: absolute;
            top: 40px" runat="server" Width="100px" ></asp:TextBox>
        <asp:Label ID="lblUserState_q" Style="z-index: 104; left: 248px; position: absolute;
            top: 48px" runat="server"   Width="56px"
            Height="15px">用户状态</asp:Label>
        <asp:TextBox ID="txtUserState_q" Style="z-index: 105; left: 312px; position: absolute;
            top: 40px" runat="server" Width="100px" ></asp:TextBox>
        <asp:Button ID="btnQuery" Style="z-index: 106; left: 528px; position: absolute; top: 40px"
            runat="server" Width="80px"  Text="查询" OnClick="btnQuery_Click"></asp:Button>
        <table id="Table1" style="z-index: 107; left: 16px; width: 696px; position: absolute;
            top: 72px; height: 254px" cellspacing="0" cellpadding="0" width="696" border="0">
            <tr>
                <td style="width: 365px; height: 2px" valign="top">
                    <asp:DataGrid ID="dgUserState" runat="server" Width="472px" Height="154px" AutoGenerateColumns="False"
                        PageSize="5" AllowPaging="True" Font-Names="宋体"  BorderColor="#E7E7FF"
                        BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Horizontal">
                        <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                        <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                        <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                        <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                        <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                        <Columns>
                            <asp:BoundColumn DataField="UserStateId" HeaderText="用户状态编号">
                                <HeaderStyle Width="25%"></HeaderStyle>
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="UserStateName" HeaderText="用户状态"></asp:BoundColumn>
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
                        <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                        </PagerStyle>
                    </asp:DataGrid></td>
                <td style="height: 2px" valign="top">
                    <uc1:wucUserState ID="wucUserState1" runat="server"></uc1:wucUserState>
                </td>
            </tr>
            <tr>
                <td style="width: 365px" valign="top">
                    <asp:Label ID="lblRecCount" runat="server" Width="110px" Height="12px" 
                        >查询结果记录数：</asp:Label>
                    <asp:TextBox ID="txtRecCount" runat="server" Width="111px"  
                         ReadOnly="True"></asp:TextBox></td>
                <td valign="top">
                    <asp:Button ID="btnOKUpd" runat="server"  Width="80px" Text="添加" OnClick="btnOKUpd_Click">
                    </asp:Button>
                    <asp:Label ID="lblMsg" runat="server" Height="15px" Width="113px" 
                        ></asp:Label></td>
            </tr>
        </table>
    </form>
</body>
</html>
