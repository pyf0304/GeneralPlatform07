<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucPrjSite4DownLoadB.ascx.cs"
    Inherits="GeneralPlatform.Webform.wucPrjSite4DownLoadB" %>
<link rel="stylesheet" type="text/css" href="../../Styles/Images/style.css" />
<table width="100%" border="0" cellspacing="0" cellpadding="0" class="msgtable">
    <tr>
        <th colspan="2" align="left">
            文件下载站点编辑
        </th>
    </tr>
    <tr>
        <td width="15%" align="right">
            <asp:Label ID="lblPrjId" runat="server" CssClass="NameControl">项目编号</asp:Label>
        </td>
        <td width="85%">
            <asp:DropDownList ID="ddlPrjId" runat="server" CssClass="ValueControl" 
                Enabled="false" Width="400px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td align="right">
            <asp:Label ID="lblPrjSiteName" runat="server" CssClass="NameControl">工程站点名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPrjSiteName" runat="server" CssClass="ValueControl" 
                Width="400px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            <asp:Label ID="lblFtpServer" runat="server" CssClass="NameControl">Ftp服务器</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFtpServer" runat="server" CssClass="ValueControl" 
                Width="400px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            <asp:Label ID="lblFtpUserId" runat="server" CssClass="NameControl">Ftp用户Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFtpUserId" runat="server" CssClass="ValueControl" 
                Width="400px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            <asp:Label ID="lblFtpUserPassword" runat="server" CssClass="NameControl">Ftp用户口令</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFtpUserPassword" runat="server" CssClass="ValueControl" 
                Width="400px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td align="right">
            <asp:Label ID="lblMemo" runat="server" CssClass="NameControl">备注</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" CssClass="input w380 left" Height="80px"
                HintInfo="控制在1000个字数内，可以标注一些备忘。" HintTitle="备注" MaxLength="1000" 
                TextMode="MultiLine" Width="400px"></asp:TextBox>
        </td>
    </tr>
</table>
