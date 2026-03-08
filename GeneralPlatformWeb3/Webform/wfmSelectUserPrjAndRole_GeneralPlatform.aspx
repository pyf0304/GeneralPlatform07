<%@ Page Language="c#"
    AutoEventWireup="True" Inherits="GeneralPlatform.Webform.wfmSelectUserPrjAndRole_GeneralPlatform" 
    Codebehind="wfmSelectUserPrjAndRole_GeneralPlatform.aspx.cs"  Theme="TaiZeTheme" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>用户权限管理统一平台--选择角色</title>
    <link href="../css/tz_base1.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <img style="z-index: 101; left: 8px; position: absolute; top: 24px" src="../pic/bar1.JPG" alt="" />
        <div style="display: inline;  z-index: 102; left: 8px; width: 304px;
            position: absolute; top: 8px; height: 8px" class="RegionTitleH1">
            <font face="宋体">当前位置：&nbsp;系统登录 &gt;&gt;&nbsp; <strong>帐号角色选择</strong></font></div>
        <img style="z-index: 103; left: 24px; position: absolute; top: 88px" src="../pic/oragnebar.gif" alt=""/>
        <div style="display: inline; font-weight: bold;  z-index: 104;
            left: 224px; width: 384px; position: absolute; top: 56px; height: 16px" class="RegionTitleH1">
            请选择您要管理的项目</div>
        <asp:DataGrid ID="Dg_QxUserRoleRelation" Style="z-index: 105; left: 80px; position: absolute;
            top: 96px" runat="server" Width="648px" AutoGenerateColumns="False" cssclass="GridValue" CellSpacing="1" CellPadding="1" BackColor="White" BorderWidth="1px"
            BorderStyle="None" BorderColor="#CCCCCC" OnSelectedIndexChanged="Dg_QxUserRoleRelation_SelectedIndexChanged">
            <FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
            <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
            <ItemStyle ForeColor="#000066"></ItemStyle>
            <HeaderStyle Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
            <Columns>
                <asp:BoundColumn DataField="mId" HeaderText="流水号"></asp:BoundColumn>
                <asp:BoundColumn DataField="UserId" HeaderText="帐号"></asp:BoundColumn>
                <asp:BoundColumn DataField="UserName" HeaderText="姓名"></asp:BoundColumn>
                <asp:BoundColumn  DataField="QxPrjId" HeaderText="项目Id">
                </asp:BoundColumn>
              
                <asp:BoundColumn DataField="PrjName" HeaderText="项目"></asp:BoundColumn>
                <asp:BoundColumn Visible="False" DataField="RoleId" HeaderText="角色号">
                </asp:BoundColumn>
                <asp:BoundColumn DataField="RoleName" HeaderText="角色"></asp:BoundColumn>
                <asp:BoundColumn DataField="Memo" HeaderText="备注"></asp:BoundColumn>
                <asp:ButtonColumn Text="选择" CommandName="Select"></asp:ButtonColumn>
            </Columns>
            <PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages">
            </PagerStyle>
        </asp:DataGrid>
    </form>
</body>
</html>
