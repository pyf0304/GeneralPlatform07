<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucQxServer4SynchB.ascx.cs" Inherits="GeneralPlatform.Webform.wucQxServer4SynchB" %>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link rel="stylesheet" type="text/css" href="../../css/tz_base11.css" />
<table id="tabwucQxServer4Synch" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblServerId" runat="server" CssClass="NameControl">服务器Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtServerId" runat="server" CssClass="ValueControl" Width="150px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblServerName" runat="server" CssClass="NameControl">服务器名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtServerName" runat="server" CssClass="ValueControl" Width="150px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblIpAddress" runat="server" CssClass="NameControl">IP地址</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtIpAddress" runat="server" CssClass="ValueControl" Width="150px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblWebApiAddress" runat="server" CssClass="NameControl">WApi地址</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtWebApiAddress" runat="server" CssClass="ValueControl" Width="150px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
       <tr>
        <td>
            <asp:CheckBox ID="chkIsSelf" runat="server" Text="是否自己" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkInUse" runat="server" Text="是否在用" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
  
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="NameControl">备注</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" CssClass="ValueControl" Width="150px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
