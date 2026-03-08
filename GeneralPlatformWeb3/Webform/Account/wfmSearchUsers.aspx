<%@ Page Language="c#" AutoEventWireup="True" Inherits="GeneralPlatform.Webform.wfmSearchUsers" Codebehind="wfmSearchUsers.aspx.cs"  Theme="TaiZeTheme" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>account</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:DropDownList ID="Dropdownlist1" Style="z-index: 120; left: 368px; position: absolute;
            top: 96px" runat="server"   Width="100px"
            >
        </asp:DropDownList>
        <asp:TextBox ID="txtName_q" Style="z-index: 122; left: 216px; position: absolute;
            top: 96px" runat="server"   Width="100px"
            ></asp:TextBox>
        <asp:DropDownList ID="ddlDepartments_q" Style="z-index: 119; left: 368px; position: absolute;
            top: 96px" runat="server"   Width="100px"
            AutoPostBack="True" >
        </asp:DropDownList>
        <asp:DropDownList ID="ddlUserState_q" Style="z-index: 116; left: 520px; position: absolute;
            top: 96px" runat="server"  Width="100px"  >
        </asp:DropDownList>
        <div style="display: inline; z-index: 101; left: 32px; width: 40px;
            font-family: Verdana; position: absolute; top: 96px; height: 11px">
            帐号:</div>
        <asp:TextBox ID="txtUserId_q" Style="z-index: 102; left: 64px; position: absolute;
            top: 96px" runat="server"  Width="100px"  ></asp:TextBox>
        <asp:Button ID="btnQry" Style="z-index: 103; left: 640px; position: absolute; top: 96px"
            runat="server" Height="25px" Width="80px" Text="查询"  
            OnClick="btnQry_Click"></asp:Button>
        <img style="z-index: 110; left: 8px; position: absolute; top: 24px" src="../../pic/bar1.JPG">
        <div style="display: inline; z-index: 111; left: 8px; width: 304px;
            font-family: Verdana; position: absolute; top: 8px; height: 8px">
            <font face="宋体">当前位置：&nbsp;帐号管理 &gt;&gt;&nbsp; <strong>帐号查询</strong></font></div>
        <img style="z-index: 112; left: 24px; position: absolute; top: 88px" src="../../pic/oragnebar.gif">
        <div style="display: inline; font-weight: bold; font-size: x-large; z-index: 113;
            left: 248px; width: 336px; position: absolute; top: 56px; height: 38px">
            请输入您要查询的帐号</div>
        <div style="display: inline; z-index: 115; left: 488px; width: 40px;
            font-family: Verdana; position: absolute; top: 96px; height: 11px">
            状态:</div>
        <div id="DIV1" style="z-index: 117; left: 792px; width: 157px; position: absolute;
            top: 56px; height: 160px" runat="server">
            <asp:DropDownList ID="ddlRole_q" Style="z-index: 125; left: 40px; position: absolute;
                top: 8px" runat="server"  Width="100px"  >
            </asp:DropDownList>
            <div style="display: inline; z-index: 125; left: 8px; width: 40px;
                font-family: Verdana; position: absolute; top: 8px; height: 11px">
                角色:</div>
            <asp:Label ID="Label1" Style="z-index: 127; left: 8px; position: absolute; top: 40px"
                runat="server" Height="10px" Width="32px"  >角色</asp:Label>
            <asp:DropDownList ID="ddlRole" Style="z-index: 127; left: 48px; position: absolute;
                top: 40px" runat="server"  Width="100px" AutoPostBack="True" 
                >
            </asp:DropDownList>
            <asp:DropDownList ID="ddlXy" Style="z-index: 130; left: 32px; position: absolute;
                top: 80px" runat="server"  Width="100px"  >
            </asp:DropDownList>
            <asp:TextBox ID="txtMemo" Style="z-index: 133; left: 40px; position: absolute; top: 112px"
                runat="server"   Width="100px" 
                TextMode="Password"></asp:TextBox>
            <asp:Label ID="lblSpec" Style="z-index: 133; left: 8px; position: absolute; top: 112px"
                runat="server" Height="11px" Width="32px"  >备注</asp:Label>
        </div>
        <div style="display: inline; z-index: 118; left: 336px; width: 40px;
            font-family: Verdana; position: absolute; top: 96px; height: 11px">
            部门:</div>
        <div style="display: inline; z-index: 121; left: 184px; width: 40px;
            font-family: Verdana; position: absolute; top: 96px; height: 11px">
            姓名:</div>
        <table id="Table1" style="z-index: 127; left: 24px; position: absolute; top: 120px"
            cellspacing="1" cellpadding="1" width="300" border="0">
            <tr>
                <td>
                    <asp:DataGrid ID="dgUsers" runat="server"  
                        CellSpacing="1" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#CCCCCC"
                        Width="584px" AutoGenerateColumns="False" AllowPaging="True" CellPadding="1"
                        OnSelectedIndexChanged="DataGrid1_SelectedIndexChanged">
                        <FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
                        <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
                        <ItemStyle ForeColor="#000066"></ItemStyle>
                        <HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
                        <Columns>
                            <asp:BoundColumn DataField="UserId" ReadOnly="True" HeaderText="帐号"></asp:BoundColumn>
                            <asp:BoundColumn DataField="UserName" HeaderText="姓名"></asp:BoundColumn>
                            <asp:BoundColumn Visible="False" DataField="DepartmentId" HeaderText="部门号"></asp:BoundColumn>
                            <asp:BoundColumn DataField="DepartmentName" HeaderText="部门"></asp:BoundColumn>
                            <asp:BoundColumn Visible="False" DataField="UserStateId" HeaderText="UserStateId"></asp:BoundColumn>
                            <asp:BoundColumn DataField="UserStateName" HeaderText="状态"></asp:BoundColumn>
                            <asp:BoundColumn DataField="Memo" HeaderText="备注"></asp:BoundColumn>
                            <asp:ButtonColumn Text="修改" CommandName="Select"></asp:ButtonColumn>
                            <asp:TemplateColumn>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbnDelete" runat="server" Text="删除" CausesValidation="false"
                                        CommandName="Del">删除</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                        </Columns>
                        <PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages">
                        </PagerStyle>
                    </asp:DataGrid></td>
                <td>
                    <div id="DIV2" style="width: 141px; position: relative; height: 193px" runat="server">
                        <asp:TextBox ID="txtName" Style="z-index: 129; left: 40px; position: absolute; top: 40px"
                            runat="server"   Width="100px" ></asp:TextBox>
                        <asp:Label ID="Label2" Style="z-index: 129; left: 0px; position: absolute; top: 40px"
                            runat="server"   Width="32px" >姓名</asp:Label>
                        <asp:DropDownList ID="ddlDepartments" Style="z-index: 129; left: 40px; position: absolute;
                            top: 72px" runat="server"   Width="100px"
                            >
                        </asp:DropDownList>
                        <div style="display: inline; z-index: 129; left: 0px; width: 40px;
                            font-family: Verdana; position: absolute; top: 72px; height: 11px">
                            部门:</div>
                        <asp:DropDownList ID="ddlUserState" Style="z-index: 129; left: 40px; position: absolute;
                            top: 104px" runat="server"  Width="100px"  >
                        </asp:DropDownList>
                        <asp:TextBox ID="txtPwd" Style="z-index: 129; left: 40px; position: absolute; top: 136px"
                            runat="server"  Width="100px" TextMode="Password" 
                            ></asp:TextBox>
                        <asp:TextBox ID="txtUserId" Style="z-index: 129; left: 40px; position: absolute;
                            top: 8px" runat="server"  Width="100px" ReadOnly="True" 
                            ></asp:TextBox>
                        <asp:Button ID="btnSub" Style="z-index: 129; left: 56px; position: absolute; top: 168px"
                            runat="server" Height="25px" Width="80px" Text="提交更新"  
                            OnClick="btnSub_Click"></asp:Button>
                        <asp:Label ID="lblUid" Style="z-index: 129; left: 0px; position: absolute; top: 8px"
                            runat="server"  Width="32px"  >帐号</asp:Label>
                        <asp:Label ID="lblRank" Style="z-index: 129; left: 0px; position: absolute; top: 104px"
                            runat="server" Height="10px" Width="32px"  >状态</asp:Label>
                        <asp:Label ID="lblPwd" Style="z-index: 129; left: 0px; position: absolute; top: 136px"
                            runat="server" Width="32px"  >密码</asp:Label>
                    </div>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblRecCount" runat="server"  
                        Width="110px" Height="12px">查询结果记录数：</asp:Label>
                    <asp:TextBox ID="txtRecCount" runat="server"  
                        Width="111px"  ReadOnly="True"></asp:TextBox></td>
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
    </form>
</body>
</html>
