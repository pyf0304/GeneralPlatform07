<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucUserDownLoadDetailLogB.ascx.cs"
    Inherits="GeneralPlatform.Webform.wucUserDownLoadDetailLogB" %>
<link rel="stylesheet" type="text/css" href="../../Styles/Images/style.css" />
<table width="100%" border="0" cellspacing="0" cellpadding="0" class="msgtable">
    <tr>
        <th colspan="2" align="left">
            用户下载日志细节
        </th>
    </tr>
    <tr>
        <td width="15%" align="right">
            <asp:Label ID="lblFileName" runat="server" CssClass="NameControl">文件名</asp:Label>
        </td>
         <td width="85%">
            <asp:TextBox ID="txtFileName" runat="server" CssClass="ValueControl" 
                 Enabled="false" Width="400px"></asp:TextBox>
        </td>
      
    </tr>
    <tr>
        <td align="right">
            <asp:Label ID="lblVersion" runat="server" CssClass="NameControl">版本</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtVersion" runat="server" CssClass="ValueControl" 
                Enabled="false" Width="400px"></asp:TextBox>
        </td>
      
    </tr>
    <tr>
        <td align="right">
            是否成功
        </td>
        <td><asp:CheckBox ID="chkIsSuccess" runat="server" Text="" CssClass="Check_Defa" Enabled="false">
            </asp:CheckBox>
        </td>
       
    </tr>
    <tr>
        <td align="right">
            <asp:Label ID="lblLogInfo" runat="server" CssClass="NameControl">日志信息</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtLogInfo" runat="server" CssClass="ValueControl" 
                Enabled="false" Width="400px"></asp:TextBox>
        </td>
       
    </tr>
    <tr>
        <td align="right">
            <asp:Label ID="lblMemo" runat="server" CssClass="NameControl">备注</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" CssClass="input w380 left" 
                Height="80px" Enabled="false"
                HintInfo="控制在1000个字数内，可以标注一些备忘。" HintTitle="备注" MaxLength="1000" 
                TextMode="MultiLine" Width="400px"></asp:TextBox>
        </td>
     
    </tr>
</table>
