<%@ Page Language="c#" AutoEventWireup="True" Inherits="GeneralPlatform.Webform.success" Codebehind="success.aspx.cs" Theme="TaiZeTheme"  %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>success</title>
    <link href="../css/tz_base1.css" rel="stylesheet" />
    <link href="../css/tz_base1.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <hr style="z-index: 100; left: 168px; width: 450px; position: absolute; top: 288px;
            height: 25px" width="47.11%" color="#ffff99" size="25">
        <img style="z-index: 111; left: 8px; position: absolute; top: 24px" alt="" src="..\pic\bar1.JPG"/>
        <div style="display: inline; z-index: 103; left: 206px; width: 238px; position: absolute;
            top: 290px; height: 19px">
            <strong>你的操作已经成功完成！</strong></div>
        <asp:LinkButton ID="LinkButton1" Style="z-index: 104; left: 576px; position: absolute;
            top: 290px" runat="server" Width="56px"  OnClick="LinkButton1_Click">返回</asp:LinkButton>
        <img style="z-index: 106; left: 168px; position: absolute; top: 72px" alt="" src="..\pic\building.jpg"/>
        <div id="DIV1" style="display: inline; z-index: 108; left: 8px;
            width: 456px; font-family: Verdana; position: absolute; top: 8px; height: 8px"
            runat="server">
            <span >当前位置：&nbsp;系统信息 &gt;&gt;&nbsp; <strong>成功信息</strong></span></div>
    </form>
</body>
</html>
