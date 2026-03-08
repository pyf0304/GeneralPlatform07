<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmUserGroupRelation_QD" Codebehind="wfmSingleUserGroupRelation.aspx.cs"  Theme="TaiZeTheme" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>表UserGroupRelation的直接在DATAGRID中删除</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="lblTitle" Style="z-index: 101; left: 128px; position: absolute; top: 0px"
            runat="server" Font-Size="X-Large" Font-Names="黑体" Height="43px" Width="384px">为用户设定一个或多个组</asp:Label>
        <table id="Table1" style="z-index: 109; left: 8px; position: absolute; top: 56px"
            cellspacing="1" cellpadding="1" width="300" border="0">
            <tr>
                <td style="height: 38px">
                    <div style="width: 616px; position: relative; height: 32px">
                        <asp:Label ID="lblUserId_q" Style="z-index: 111; left: 8px; position: absolute; top: 8px"
                            runat="server">用户号:</asp:Label>
                        <asp:TextBox ID="txtUserId_q" Style="z-index: 111; left: 72px; position: absolute;
                            top: 8px" runat="server" Width="72px" ></asp:TextBox>
                        <asp:Label ID="lblXM_q" Style="z-index: 111; left: 160px; position: absolute; top: 8px"
                            runat="server">姓名:</asp:Label>
                        <asp:TextBox ID="txtXM_q" Style="z-index: 111; left: 208px; position: absolute; top: 8px"
                            runat="server" Width="88px"></asp:TextBox>
                        <asp:Label ID="Label5" Style="z-index: 111; left: 312px; position: absolute; top: 8px"
                            runat="server">部门：</asp:Label>
                        <asp:DropDownList ID="DropDownList1" Style="z-index: 111; left: 360px; position: absolute;
                            top: 8px" runat="server">
                        </asp:DropDownList>
                        <asp:Button ID="btnQuery" Style="z-index: 111; left: 480px; position: absolute; top: 8px"
                            runat="server" Text="查询" OnClick="btnQuery_Click"></asp:Button>
                    </div>
                </td>
                <td style="height: 38px">
                </td>
                <td style="height: 38px">
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DataGrid ID="dgUserGroupRelation" runat="server" Font-Names="宋体" Font-Size="Smaller"
                        CellPadding="4" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#3366CC"
                        AutoGenerateColumns="False" PageSize="5" AllowPaging="True" OnSelectedIndexChanged="dgUserGroupRelation_SelectedIndexChanged">
                        <FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
                        <SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
                        <ItemStyle ForeColor="#003399" BackColor="White"></ItemStyle>
                        <HeaderStyle Font-Bold="True" ForeColor="#CCCCFF" BackColor="#003399"></HeaderStyle>
                        <Columns>
                            <asp:BoundColumn DataField="UserId" HeaderText="用户号"></asp:BoundColumn>
                            <asp:BoundColumn DataField="UserName" HeaderText="用户名"></asp:BoundColumn>
                            <asp:BoundColumn DataField="userstatemc" HeaderText="用户状态"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Memo" HeaderText="备注">
                                <HeaderStyle Width="300px"></HeaderStyle>
                            </asp:BoundColumn>
                            <asp:ButtonColumn Text="修改组" CommandName="Select"></asp:ButtonColumn>
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
                    <div style="width: 608px; position: relative; height: 40px">
                        <asp:Label ID="lblRecCount" Style="z-index: 116; left: 8px; position: absolute; top: 8px"
                            runat="server" Width="110px" Height="12px" Font-Names="宋体" Font-Size="Smaller">查询结果记录数：</asp:Label>
                        <asp:TextBox ID="txtRecCount" Style="z-index: 116; left: 112px; position: absolute;
                            top: 8px" runat="server" Width="48px"  Font-Names="宋体" Font-Size="Smaller"
                            ReadOnly="True"></asp:TextBox>
                        <asp:Button ID="btnDelete" Style="z-index: 116; left: 200px; position: absolute;
                            top: 8px" runat="server" Text="确定修改" OnClick="btnDelete_Click"></asp:Button>
                        <asp:Label ID="Label3" Style="z-index: 116; left: 296px; position: absolute; top: 8px"
                            runat="server">选择用户组：</asp:Label>
                        <asp:CheckBoxList ID="CheckBoxList1" Style="z-index: 116; left: 392px; position: absolute;
                            top: 0px" runat="server" RepeatColumns="1">
                        </asp:CheckBoxList>
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
