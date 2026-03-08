<%@ Control Language="c#" AutoEventWireup="True" Inherits="GeneralPlatform.Webform.wucRelaOfPotenceAndSymbol" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" CodeBehind="wucRelaOfPotenceAndSymbol.ascx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<meta name="vs_snapToGrid" content="false">
<meta name="vs_showGrid" content="true">
<table id="tabwucRelaOfPotenceAndSymbol" cellspacing="1" cellpadding="1" border="0"
    style="width: 604px; height: 126px">
    <tr>
        <td style="width: 64px">
            <asp:Label ID="lblPrjId" runat="server" Width="34px">项目</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlPrjId" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPrjId_SelectedIndexChanged" Width="187px"></asp:DropDownList></td>
        <td style="width: 68px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 64px">
            <asp:Label ID="lblPotenceId0" runat="server"
                Width="73px">权限类型</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlPotenceTypeId" runat="server"
                Width="185px" AutoPostBack="True"
                OnSelectedIndexChanged="ddlPotenceTypeId_SelectedIndexChanged">
            </asp:DropDownList></td>
        <td style="width: 68px">
            <asp:Label ID="lblPotenceId" runat="server" Width="48px">权限</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlPotenceId" runat="server" Width="243px"></asp:DropDownList></td>
    </tr>
    <tr>
        <td style="width: 64px">
            <asp:Label ID="lblSymbolForProgramme" runat="server">编程标志</asp:Label></td>
        <td>
            <asp:TextBox ID="txtSymbolForProgramme" runat="server" Width="185px"></asp:TextBox>&nbsp;</td>
        <td style="width: 68px">
            <asp:Label ID="lblSymbolName" runat="server" Width="77px">标志名称</asp:Label></td>
        <td>
            <asp:TextBox ID="txtSymbolName" runat="server" Width="245px"></asp:TextBox></td>
    </tr>
    <tr>
        <td style="width: 64px">
            <asp:Label ID="lblMemo" runat="server">备注</asp:Label>&nbsp;</td>
        <td colspan="3">
            <asp:TextBox ID="txtMemo" runat="server" Width="518px" Height="25px"></asp:TextBox>
        </td>
    </tr>
</table>
