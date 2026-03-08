<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmMultiUserGroupRelation" Codebehind="wfmMultiUserGroupRelation.aspx.cs"  Theme="TaiZeTheme" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>wfmMultiUserGroupRelation</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="lblTitle" Style="z-index: 110; left: 128px; position: absolute; top: 8px"
            runat="server" Font-Size="X-Large" Font-Names="黑体" Height="43px" Width="384px">为多个用户添加或删除组</asp:Label>
        <table id="Table1" style="z-index: 109; left: 8px; position: absolute; top: 56px"
            cellspacing="1" cellpadding="1" width="300" border="0">
            <tr>
                <td style="height: 37px">
                    <div style="width: 616px; position: relative; height: 32px">
                        <asp:Label ID="lblUserId_q" Style="z-index: 111; left: 8px; position: absolute; top: 8px"
                            runat="server">用户号:</asp:Label>
                        <asp:TextBox ID="txtUserId_q" Style="z-index: 111; left: 64px; position: absolute;
                            top: 8px" runat="server" Width="64px"></asp:TextBox>
                        <asp:Label ID="lblXM_q" Style="z-index: 111; left: 144px; position: absolute; top: 8px"
                            runat="server">姓名:</asp:Label>
                        <asp:TextBox ID="txtXM_q" Style="z-index: 111; left: 192px; position: absolute; top: 8px"
                            runat="server" Width="80px"></asp:TextBox>
                        <asp:Label ID="Label5" Style="z-index: 111; left: 288px; position: absolute; top: 8px"
                            runat="server">部门：</asp:Label>
                        <asp:DropDownList ID="DropDownList1" Style="z-index: 111; left: 336px; position: absolute;
                            top: 8px" runat="server">
                        </asp:DropDownList>
                        <asp:Button ID="btnQuery" Style="z-index: 111; left: 464px; position: absolute; top: 8px"
                            runat="server" Text="查询" OnClick="btnQuery_Click"></asp:Button>
                    </div>
                </td>
                <td style="height: 37px">
                </td>
                <td style="height: 37px">
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DataGrid ID="dgUserGroupRelation" runat="server" Font-Size="Smaller" Font-Names="宋体"
                        AllowPaging="True" PageSize="5" AutoGenerateColumns="False" BorderColor="#3366CC"
                        BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="4">
                        <FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
                        <SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
                        <ItemStyle ForeColor="#003399" BackColor="White"></ItemStyle>
                        <HeaderStyle Font-Bold="True" ForeColor="#CCCCFF" BackColor="#003399"></HeaderStyle>
                        <Columns>
                            <asp:TemplateColumn HeaderText="选择">
                                <ItemTemplate>
                                    <asp:CheckBox ID="Ckb1" runat="server"></asp:CheckBox>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="UserId" HeaderText="用户号"></asp:BoundColumn>
                            <asp:BoundColumn DataField="UserName" HeaderText="用户名"></asp:BoundColumn>
                            <asp:BoundColumn DataField="userstatemc" HeaderText="用户状态"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Memo" HeaderText="备注">
                                <HeaderStyle Width="300px"></HeaderStyle>
                            </asp:BoundColumn>
                        </Columns>
                        <PagerStyle HorizontalAlign="Left" ForeColor="#003399" BackColor="#99CCCC" Mode="NumericPages">
                        </PagerStyle>
                    </asp:DataGrid></td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <div style="width: 608px; position: relative; height: 132px">
                        <asp:Label ID="lblRecCount" Style="z-index: 101; left: 80px; position: absolute;
                            top: 8px" runat="server" Font-Size="Smaller" Font-Names="宋体" Height="12px" Width="110px">查询结果记录数：</asp:Label>
                        <asp:TextBox ID="txtRecCount" Style="z-index: 102; left: 184px; position: absolute;
                            top: 8px" runat="server" Font-Size="Smaller" Font-Names="宋体"  Width="56px"
                            ReadOnly="True"></asp:TextBox>
                        <asp:Button ID="btnOK" Style="z-index: 103; left: 256px; position: absolute; top: 8px"
                            runat="server" Text="确定添加" OnClick="btnOK_Click"></asp:Button>
                        <asp:Label ID="Label3" Style="z-index: 104; left: 344px; position: absolute; top: 8px"
                            runat="server">选择用户组：</asp:Label>
                        <asp:CheckBoxList ID="CheckBoxList1" Style="z-index: 105; left: 440px; position: absolute;
                            top: 0px" runat="server" RepeatColumns="1">
                        </asp:CheckBoxList>
                        <asp:CheckBox ID="CheckBox1" Style="z-index: 106; left: 8px; position: absolute;
                            top: 8px" runat="server" Text="全选" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged">
                        </asp:CheckBox>
                        <asp:Button ID="Button1" Style="z-index: 107; left: 256px; position: absolute; top: 40px"
                            runat="server" Text="确定删除" OnClick="Button1_Click"></asp:Button>
                        <asp:Button ID="Button2" Style="z-index: 108; left: 144px; position: absolute; top: 72px"
                            runat="server" Text="所有查询到的用户添加" OnClick="Button2_Click"></asp:Button>
                        <asp:Button ID="Button3" Style="z-index: 109; left: 144px; position: absolute; top: 104px"
                            runat="server" Text="所有查询到的用户删除" OnClick="Button3_Click"></asp:Button>
                    </div>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
