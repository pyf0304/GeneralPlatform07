<%@ Page Language="c#" CodeBehind="SysError404.aspx.cs" AutoEventWireup="True" 
    Inherits="GeneralPlatform.Webform.SysError404"  ResponseEncoding="utf-8"  Theme="TaiZeTheme" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>系统错误显示</title>
    <link href="../Css/taishweb2.css" rel="stylesheet" />
    <link href="../css/taishweb2.css" rel="stylesheet" />
</head>
<body bgcolor="#ffffff">
    <form id="Form1" runat="server">

        <asp:Image ID="Image1" Style="z-index: 103; left: 8px; position: absolute; top: 24px" runat="server" ImageUrl="~\pic\bar1.JPG" />
         <div style="display: inline; left: 48px; width: 392px; position: absolute; top: 48px; height: 18px; background-color: transparent" class="RegionTitleH1">
            <p>
                <strong>系统出错404错误，可能由于以下原因：</strong>&nbsp;<em>&nbsp;</em>
            </p>
        </div>
        &nbsp;
        <div id="DIV1" class="PageRegionH1" style="display: inline; z-index: 102; left: 8px; width: 456px; position: absolute; top: 8px; height: 8px"
            runat="server">
            当前位置：&nbsp;系统信息 &gt;&gt;&nbsp; <strong>系统错误信息</strong>
        </div>

       
        <asp:Label ID="lblErrMsg" Style="z-index: 106; left: 72px; position: absolute; top: 88px; height: 192px; width: 693px;"
            runat="server" ForeColor="#C00000" CssClass="ErrMsg">Label</asp:Label>
        <asp:LinkButton ID="lbGoBack" Style="z-index: 107; left: 709px; position: absolute; top: 304px"
            runat="server" Width="55px" OnClick="lbGoBack_Click" Visible="False">返回</asp:LinkButton>
    </form>
</body>
</html>
