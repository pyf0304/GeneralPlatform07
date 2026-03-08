<%@ Control Language="C#" AutoEventWireup="true"
    Inherits="Webform_SystemSet_wucDataBaseConnect" Codebehind="wucDataBaseConnect.ascx.cs" %>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link href="../../css/tz_base11.css" rel="stylesheet" />
<table style="width: 33%;">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblServerIP" Style="z-index: 104;" runat="server" Width="90px">服务器的IP</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtServer" Style="z-index: 101;" runat="server" Width="160px"></asp:TextBox>
        </td>
        <td class="ValueTD">
            &nbsp;
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDatabase" Style="z-index: 117;" runat="server" Width="79px" CssClass="NameTD">数据库名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDataBaseName" Style="z-index: 101;" runat="server" Width="160px"></asp:TextBox>
        </td>
        <td class="ValueTD">
            &nbsp;
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUserId" Style="z-index: 127;" runat="server" Width="73px">用户名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDataBaseUserId" Style="z-index: 128;" runat="server" Width="160px"></asp:TextBox>
        </td>
        <td class="ValueTD">
            &nbsp;
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPwd" Style="z-index: 129;" runat="server" Width="64px">口令</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDataBasePassword" Style="z-index: 130;" runat="server" Width="160px"
                TextMode="Password" ontextchanged="txtDataBasePassword_TextChanged"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="btnTestConnect" Style="z-index: 110;" runat="server" Width="66px"
                Text="测试连接" OnClick="btnTestConnect_Click"></asp:Button>
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:Label ID="lblMsg" Style="z-index: 129;" runat="server" Width="324px" CssClass="ErrMsg"></asp:Label>
        </td>
    </tr>
</table>
