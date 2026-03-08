<%@ Page Language="c#" AutoEventWireup="True" Inherits="GeneralPlatform.Webform.ErrorMag" Codebehind="ErrorMsg.aspx.cs"  Theme="TaiZeTheme" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>error</title>
    <link href="../css/tz_base1.css" rel="stylesheet" />
    <link href="../css/tz_base1.css" rel="stylesheet" />
</head>
<body bgcolor="#ffffff" background="/GeneralPlatform/pic/bg3.gif">
    <form id="Form1" method="post" runat="server">
        <img style="z-index: 103; left: 8px; position: absolute; top: 24px" alt="" src="..\pic\bar1.JPG">
        <div style="display: inline; font-size: small; z-index: 105; left: 48px; width: 392px;
            font-family: Verdana; position: absolute; top: 56px; height: 18px; background-color: transparent">
            <p>
                <font face="幼圆"><strong>很抱歉，您的操作无法完成，可能由于以下原因：</strong></font><font face="幼圆">&nbsp;<em>&nbsp;</em></font></p>
        </div>
        &nbsp;
        <div id="DIV1" style="display: inline; z-index: 102; left: 8px;
            width: 456px; font-family: Verdana; position: absolute; top: 8px; height: 8px"
            runat="server">
            <font face="宋体">当前位置：&nbsp;系统信息 &gt;&gt;&nbsp; <strong>出错信息</strong></font></div>
        <img style="z-index: 101; left: 248px; position: absolute; top: 160px" alt="" src="..\pic\building.jpg">
        <div style="display: inline; font-size: small; z-index: 104; left: 184px; width: 400px;
            font-family: Verdana; position: absolute; top: 392px; height: 164px; background-color: transparent"
            id="DIV2" runat="server">
            <p>
                <font face="幼圆"><strong>很抱歉，您的操作无法完成，可能由于以下原因：</strong>&nbsp;&nbsp;&nbsp; </font>
            </p>
            <p>
                <font face="幼圆">&nbsp;<em> 1.您没有足够的使用权限。<br>
                    &nbsp;&nbsp;&nbsp; 2.由于很长时间没有操作了，登录超时。<br>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 3.本功能被管理员暂时关闭。<br>
                </em>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font></p>
            <p>
                <font face="幼圆"><strong>你可以点击这里</strong>
                    <asp:LinkButton ID="LinkButton1" runat="server"  Width="80px" OnClick="LinkButton1_Click">[重新登录]</asp:LinkButton><strong>，或稍候再试，谢谢！</strong></font><font
                        face="幼圆"><br>
            </p>
            </FONT></div>
        <asp:Label ID="lblErrMsg" Style="z-index: 106; left: 72px; position: absolute; top: 88px"
            runat="server" Width="368px"   ForeColor="#C00000">Label</asp:Label>
        <asp:LinkButton ID="lbGoBack" Style="z-index: 107; left: 464px; position: absolute;
            top: 120px" runat="server"   OnClick="lbGoBack_Click">返回</asp:LinkButton>
    </form>
</body>
</html>
