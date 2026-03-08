<%@ Page Language="c#" AutoEventWireup="True" 
    Inherits="GeneralPlatform.Webform.wfmAddUsers" CodeBehind="wfmAddUsers.aspx.cs"  Theme="TaiZeTheme" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>addacount</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <div style="display: inline; z-index: 134; left: 280px; width: 40px; font-family: Verdana; position: absolute; top: 168px; height: 17px">
            姓名:
        </div>
        <asp:TextBox ID="txtName" Style="z-index: 117; left: 320px; position: absolute; top: 168px"
            runat="server" Width="150px"></asp:TextBox>
        <div style="display: inline; z-index: 131; left: 280px; width: 40px; font-family: Verdana; position: absolute; top: 360px; height: 11px">
            状态:
        </div>
        <asp:DropDownList ID="ddlUserState" Style="z-index: 124; left: 320px; position: absolute; top: 360px"
            runat="server" Width="150px" >
        </asp:DropDownList>
        <asp:Button ID="btnSubmit" Style="z-index: 110; left: 384px; position: absolute; top: 400px"
            runat="server" Width="80px" Text="确认添加" Height="25px" OnClick="btnSubmit_Click"></asp:Button>
        <div style="display: inline; z-index: 111; left: 280px; width: 40px; font-family: Verdana; position: absolute; top: 264px; height: 17px">
            部门:
        </div>
        <div style="display: inline; z-index: 112; left: 280px; width: 40px; font-family: Verdana; position: absolute; top: 232px; height: 17px">
            角色:
        </div>
        <asp:DropDownList ID="ddlRole" Style="z-index: 113; left: 320px; position: absolute; top: 232px"
            runat="server" Width="150px">
        </asp:DropDownList>
        <asp:DropDownList ID="ddlDepartment" Style="z-index: 114; left: 320px; position: absolute; top: 264px"
            runat="server" Width="150px">
        </asp:DropDownList>
        <div style="display: inline; z-index: 115; left: 280px; width: 40px; font-family: Verdana; position: absolute; top: 136px; height: 17px">
            帐号:
        </div>
        <asp:TextBox ID="txtUserId" Style="z-index: 116; left: 320px; position: absolute; top: 136px"
            runat="server" Width="150px"></asp:TextBox>
        <div style="display: inline; z-index: 118; left: 280px; width: 40px; font-family: Verdana; position: absolute; top: 296px; height: 18px">
            密码:
        </div>
        <asp:TextBox ID="txtPwd" Style="z-index: 119; left: 320px; position: absolute; top: 296px"
            runat="server" Width="150px" TextMode="Password"></asp:TextBox>
        <div style="display: inline; z-index: 120; left: 256px; width: 84px; font-family: Verdana; position: absolute; top: 328px; height: 18px">
            确认密码:
        </div>
        <asp:TextBox ID="txtPwd2" Style="z-index: 121; left: 320px; position: absolute; top: 328px"
            runat="server" Width="150px" TextMode="Password"></asp:TextBox>
        <img style="z-index: 122; left: 8px; position: absolute; top: 24px" src="../../pic/bar1.JPG"
            alt="" />
        <div style="display: inline; z-index: 123; left: 8px; width: 304px; font-family: Verdana; position: absolute; top: 8px; height: 16px">
            <font face="宋体">当前位置：&nbsp;帐号管理 &gt;&gt;&nbsp; <strong>添加帐号</strong></font>
        </div>
        <img style="z-index: 125; left: 24px; position: absolute; top: 88px" src="../../pic/oragnebar.gif"
            alt="" />
        <div style="display: inline; font-weight: bold; font-size: x-large; z-index: 126; left: 264px; width: 336px; position: absolute; top: 56px; height: 16px">
            请输入您要添加的帐号
        </div>
        <img style="z-index: 127; left: 40px; position: absolute; top: 104px" src="../../pic/bar7.JPG"
            alt="" />
        <div style="display: inline; z-index: 129; left: 56px; width: 128px; font-family: Verdana; position: absolute; top: 112px; height: 8px">
            单个帐号添加：
        </div>
        <div style="display: inline; z-index: 132; left: 280px; width: 40px; font-family: Verdana; position: absolute; top: 200px; height: 17px">
            项目:
        </div>
        <asp:DropDownList ID="ddlPrj" Style="z-index: 133; left: 320px; position: absolute; top: 200px"
            runat="server" Width="150px" AutoPostBack="True" OnSelectedIndexChanged="ddlPrj_SelectedIndexChanged">
        </asp:DropDownList>
        <div id="DIV1" style="z-index: 135; left: 872px; width: 640px; position: absolute; top: 352px; height: 102px"
            runat="server">
            <asp:TextBox ID="txtXh1" Style="z-index: 136; left: 88px; position: absolute; top: 48px"
                runat="server" Width="150px"></asp:TextBox>
            <asp:TextBox ID="txtXh2" Style="z-index: 136; left: 280px; position: absolute; top: 48px"
                runat="server" Width="150px"></asp:TextBox>
            <div style="display: inline; z-index: 136; left: 24px; width: 64px; font-family: Verdana; position: absolute; top: 48px; height: 17px">
                帐号范围:
            </div>
            <div style="display: inline; z-index: 136; left: 248px; width: 17px; font-family: Verdana; position: absolute; top: 48px; height: 16px">
                至
            </div>
            <div style="display: inline; z-index: 136; left: 24px; width: 64px; font-family: Verdana; position: absolute; top: 80px; height: 17px">
                初始密码:
            </div>
            <div style="display: inline; z-index: 136; left: 208px; width: 64px; font-family: Verdana; position: absolute; top: 80px; height: 17px">
                确认密码:
            </div>
            <asp:TextBox ID="txtCspwd" Style="z-index: 136; left: 88px; position: absolute; top: 80px"
                runat="server" Width="100px" TextMode="Password"></asp:TextBox>
            <asp:TextBox ID="txtCspwd2" Style="z-index: 136; left: 280px; position: absolute; top: 80px"
                runat="server" Width="100px" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnPlAdd" Style="z-index: 136; left: 528px; position: absolute; top: 72px"
                runat="server" Width="80px" Text="确认添加" Height="25px" OnClick="btnPlAdd_Click"></asp:Button>
            <img style="z-index: 136; left: 0px; position: absolute; top: 16px" src="../../pic/bar7.JPG"
                alt="" />
            <div style="display: inline; z-index: 136; left: 16px; width: 128px; font-family: Verdana; position: absolute; top: 24px; height: 8px">
                批量帐号添加：
            </div>
        </div>
    </form>
</body>
</html>
