<%@ Page Language="c#" AutoEventWireup="True" Inherits="GeneralPlatform.Webform.Index" Codebehind="Index.aspx.cs" Theme="TaiZeTheme"  %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>欢迎使用--应用系统统一管理平台</title>
    <link href="../css/tz_base1.css" rel="stylesheet" />
    <link href="../css/tz_base1.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Image ID="Image1" Style="z-index: 100; left: 112px; position: absolute; top: 240px"
            runat="server" ImageUrl="../pic/1.bmp"  Width="712px"></asp:Image>
        <asp:LinkButton ID="LinkButton2" Style="z-index: 102; left: 704px; position: absolute;
            top: 312px" runat="server"   
            OnClick="LinkButton2_Click" Visible="False">[下载说明文档]</asp:LinkButton>
        <asp:Image ID="Image6" Style="z-index: 103; left: 120px; position: absolute; top: 88px"
            runat="server" ImageUrl="../pic/logo_shnu.gif"></asp:Image>
        <asp:Image ID="Image4" Style="z-index: 104; left: 400px; position: absolute; top: 320px"
            runat="server" ImageUrl="../pic/icon_password.gif"></asp:Image>
        <asp:Image ID="Image3" Style="z-index: 105; left: 400px; position: absolute; top: 272px"
            runat="server" ImageUrl="../pic/icon_name.gif"></asp:Image>
        <asp:ImageButton ID="iBtnLogin" Style="z-index: 106; left: 600px; position: absolute;
            top: 368px" TabIndex="3" runat="server" ImageUrl="../pic/icon_re.gif" 
            Width="56px" OnClick="iBtnLogin_Click"></asp:ImageButton>
        <asp:TextBox ID="txtPassword" Style="z-index: 107; left: 512px; position: absolute;
            top: 320px" TabIndex="2" runat="server" Height="22px" Width="146" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="txtUserId" Style="z-index: 108; left: 512px; position: absolute;
            top: 272px" TabIndex="1" runat="server" Height="22" Width="146px"></asp:TextBox>
        <asp:Image ID="Image2" Style="z-index: 109; left: 112px; position: absolute; top: 416px"
            runat="server" ImageUrl="../pic/2.bmp"  Width="712px"></asp:Image>
        <div style="display: inline; font-size: xx-large; z-index: 112; left: 160px; width: 616px;
            font-family: 隶书; position: absolute; top: 168px; height: 48px">
            应用系统统一管理平台 <span style="font-size:16px" >V20121012</span></div>
        <asp:Label ID="lblApplicationName" runat="server" Style="z-index: 113; left: 784px;
            position: absolute; top: 202px" Width="295px"></asp:Label>
    </form>
</body>
</html>
