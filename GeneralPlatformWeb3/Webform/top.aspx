<%@ Page Language="c#" AutoEventWireup="True" Inherits="GeneralPlatform.Webform.top" Codebehind="top.aspx.cs"  Theme="TaiZeTheme" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>top</title>
    <link href="../css/tz_base1.css" rel="stylesheet" />
    <link href="../css/tz_base1.css" rel="stylesheet" />
    <style type="text/css">
        .style1
        {
            height: 7px;
        }
        .style2
        {
            height: 7px;
            width: 436px;
        }
        .style3
        {
            width: 396px;
        }
    </style>
</head>
<body>
    <form id="Form1" method="post" runat="server">
    <table style="width: 100%; height: 79px; top: 0px" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td>
                <asp:Image ID="Image2" Style="z-index: 101; height: 79px" runat="server" ImageUrl="../pic/shtu.gif">
                </asp:Image>
            </td>
            <td>
                <table border="0" cellpadding="0" cellspacing="0">
                    <tr>
                        <td>
                            <div style="display: inline; font-size: 30px; z-index: 110; width: 396px; font-family: 隶书;">
                                应用系统统一管理平台 <font face="黑体" size="3">V20121012</font></div>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblApplicationName" runat="server"></asp:Label>
                        </td>
                        <td>
                        </td>
                    </tr>
                </table>
            </td>
            <td class="style1">
                <asp:Button ID="Button1" Style="z-index: 102; height: 20px; width: 49px;" runat="server"
                    Text="注销" OnClick="Button1_Click"></asp:Button>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
