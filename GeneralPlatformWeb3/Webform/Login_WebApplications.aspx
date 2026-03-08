<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.Login_WebApplications" Codebehind="Login_WebApplications.aspx.cs"  Theme="TaiZeTheme" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>欢迎使用--应用系统统一管理平台</title>
    <link href="../css/tz_base1.css" rel="stylesheet" />
    <link href="../css/tz_base1.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Image ID="Image1" Style="z-index: 101; left: 112px; position: absolute; top: 240px"
            runat="server" ImageUrl="../pic/1.bmp"  Width="712px"></asp:Image>
        <asp:Image ID="Image6" Style="z-index: 108; left: 120px; position: absolute; top: 88px"
            runat="server" ImageUrl="../pic/logo_shnu.gif"></asp:Image>
        <asp:Image ID="Image4" Style="z-index: 107; left: 384px; position: absolute; top: 320px"
            runat="server" ImageUrl="../pic/icon_password.gif"></asp:Image>
        <asp:Image ID="Image3" Style="z-index: 106; left: 384px; position: absolute; top: 272px"
            runat="server" ImageUrl="../pic/icon_name.gif"></asp:Image>
        <asp:ImageButton ID="iBtnLogin" Style="z-index: 105; left: 584px; position: absolute;
            top: 368px" TabIndex="3" runat="server" ImageUrl="../pic/icon_re.gif" 
            Width="56px" onclick="iBtnLogin_Click"></asp:ImageButton>
        <asp:TextBox ID="txtPassword" Style="z-index: 104; left: 496px; position: absolute;
            top: 320px" TabIndex="2" runat="server" Height="22px" Width="146" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="txtUserId" Style="z-index: 103; left: 496px; position: absolute;
            top: 272px" TabIndex="1" runat="server" Height="22" Width="146px"></asp:TextBox>
        <asp:Image ID="Image2" Style="z-index: 102; left: 112px; position: absolute; top: 416px"
            runat="server" ImageUrl="../pic/2.bmp"  Width="712px"></asp:Image>
        <div style="display: inline; font-size: xx-large; z-index: 109; left: 160px; width: 616px;
            font-family: 隶书; position: absolute; top: 168px; height: 48px">
            应用系统统一入口&nbsp; <font face="黑体" size="5">V1.0</font></div>
    </form>
</body>
</html>
