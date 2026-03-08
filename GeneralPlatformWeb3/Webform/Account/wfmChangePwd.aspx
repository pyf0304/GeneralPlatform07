<%@ Page Language="c#" AutoEventWireup="True" 
    Inherits="GeneralPlatform.Webform.wfmChangePwd" CodeBehind="wfmChangePwd.aspx.cs" Theme="TaiZeTheme" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>修改密码</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:TextBox ID="txtOldpwd" Style="z-index: 101; left: 392px; position: absolute; top: 144px"
            runat="server" Width="100px" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="txtNewpwd" Style="z-index: 102; left: 392px; position: absolute; top: 184px"
            runat="server" Width="100px" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="txtNewpwd2" Style="z-index: 103; left: 392px; position: absolute; top: 224px"
            runat="server" Width="100px" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnSubmit" Style="z-index: 104; left: 408px; position: absolute; top: 272px"
            runat="server" Text="确认提交" Width="80px" Height="25px" OnClick="btnSubmit_Click"></asp:Button>
        <div style="display: inline; z-index: 105; left: 336px; width: 68px; font-family: Verdana; position: absolute; top: 144px; height: 18px">
            旧密码:
        </div>
        <div style="display: inline; z-index: 106; left: 336px; width: 68px; font-family: Verdana; position: absolute; top: 184px; height: 18px">
            新密码:
        </div>
        <div style="display: inline; z-index: 107; left: 312px; width: 92px; font-family: Verdana; position: absolute; top: 224px; height: 18px">
            确认新密码:
        </div>
        <img style="z-index: 125; left: 8px; position: absolute; top: 24px" src="../../pic/bar1.JPG">
        <div style="display: inline; z-index: 126; left: 8px; width: 304px; font-family: Verdana; position: absolute; top: 8px; height: 18px">
            <font face="宋体">当前位置：&nbsp;帐号管理 &gt;&gt;&nbsp; <strong>修改密码</strong></font>
        </div>
        <img style="z-index: 127; left: 24px; position: absolute; top: 88px" src="../../pic/oragnebar.gif">
        <div style="display: inline; font-weight: bold; font-size: x-large; z-index: 128; left: 192px; width: 432px; position: absolute; top: 56px; height: 16px">
            请输入您的帐号密码和新密码
        </div>
    </form>
</body>
</html>
