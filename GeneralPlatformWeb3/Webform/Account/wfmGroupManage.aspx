<%@ Page Language="c#" AutoEventWireup="True" Inherits="GeneralPlatform.Webform.wfmGroupManage" Codebehind="wfmGroupManage.aspx.cs" Theme="TaiZeTheme"  %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>wfmGroupManage</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="lblTitle" Style="z-index: 110; left: 176px; position: absolute; top: 8px"
            runat="server" Width="384px" Height="43px" Font-Names="黑体" Font-Size="X-Large">请选择要管理的用户组</asp:Label>
        <table id="Table1" style="z-index: 109; left: 8px; position: absolute; top: 56px"
            cellspacing="1" cellpadding="1" width="300" border="0">
            <tr>
                <td style="height: 37px">
                    <div style="width: 616px; position: relative; height: 32px">
                        <asp:Label ID="Label5" Style="z-index: 101; left: 32px; position: absolute; top: 8px"
                            runat="server">工程：</asp:Label>
                        <asp:DropDownList ID="DropDownList1" Style="z-index: 102; left: 80px; position: absolute;
                            top: 8px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList>
                        <asp:Button ID="btnQuery" Style="z-index: 103; left: 464px; position: absolute; top: 8px"
                            runat="server" Text="查询" OnClick="btnQuery_Click"></asp:Button>
                        <asp:Label ID="Label1" Style="z-index: 104; left: 232px; position: absolute; top: 8px"
                            runat="server">用户组：</asp:Label>
                        <asp:DropDownList ID="DropDownList2" Style="z-index: 105; left: 296px; position: absolute;
                            top: 8px" runat="server">
                        </asp:DropDownList>
                    </div>
                </td>
                <td style="height: 37px">
                </td>
                <td style="height: 37px">
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DataGrid ID="dgUserGroupRelation" runat="server" Font-Names="宋体" Font-Size="Smaller"
                        CellPadding="4" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#3366CC"
                        AutoGenerateColumns="False" PageSize="5" AllowPaging="True">
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
                            <asp:BoundColumn DataField="groupid" HeaderText="组号"></asp:BoundColumn>
                            <asp:BoundColumn DataField="groupmc" HeaderText="组名"></asp:BoundColumn>
                            <asp:BoundColumn DataField="userstatemc" HeaderText="用户状态"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Memo" HeaderText="备注">
                                <HeaderStyle Width="200px"></HeaderStyle>
                            </asp:BoundColumn>
                            <asp:TemplateColumn>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbnDelete" runat="server" Text="删除" CausesValidation="false"
                                        CommandName="Delete">删除</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
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
                    <div style="width: 608px; position: relative; height: 214px">
                        <asp:Label ID="lblRecCount" Style="z-index: 101; left: 384px; position: absolute;
                            top: 8px" runat="server" Width="110px" Height="12px" Font-Names="宋体" Font-Size="Smaller">查询结果记录数：</asp:Label>
                        <asp:TextBox ID="txtRecCount" Style="z-index: 102; left: 480px; position: absolute;
                            top: 8px" runat="server" Width="56px"  Font-Names="宋体" Font-Size="Smaller"
                            ReadOnly="True"></asp:TextBox>
                        <asp:Button ID="btnOK" Style="z-index: 103; left: 80px; position: absolute; top: 40px"
                            runat="server" Text="确定添加" OnClick="btnOK_Click"></asp:Button>
                        <asp:CheckBox ID="CheckBox1" Style="z-index: 104; left: 8px; position: absolute;
                            top: 8px" runat="server" Text="全选" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged">
                        </asp:CheckBox>
                        <asp:Button ID="Button1" Style="z-index: 105; left: 80px; position: absolute; top: 8px"
                            runat="server" Text="确定删除" OnClick="Button1_Click"></asp:Button>
                        <asp:Button ID="Button3" Style="z-index: 106; left: 176px; position: absolute; top: 8px"
                            runat="server" Text="删除所有查询到的用户" OnClick="Button3_Click"></asp:Button>
                        <div style="display: inline; z-index: 107; left: 88px; width: 320px; position: absolute;
                            top: 80px; height: 16px">
                            按住"Ctrl"或"Shift"可以成批添加！！</div>
                        <asp:ListBox ID="ListBox1" Style="z-index: 108; left: 8px; position: absolute; top: 40px"
                            runat="server" Height="174px" Width="64px" SelectionMode="Multiple"></asp:ListBox>
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
