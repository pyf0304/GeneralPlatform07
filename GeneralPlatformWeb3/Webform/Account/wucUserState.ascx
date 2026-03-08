<%@ Control Language="c#" AutoEventWireup="True" Inherits="GeneralPlatform.Webform.wucUserState" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" Codebehind="wucUserState.ascx.cs" %>
<meta content="False" name="vs_snapToGrid">
<meta content="True" name="vs_showGrid">
<TABLE id="tabwucUserState" style="WIDTH: 200px; HEIGHT: 82px" cellSpacing="1" cellPadding="1"
	width="200" border="0">
	<TR>
		<TD><asp:label id="lblUserStateId"   runat="server">用户状态编号</asp:label></TD>
		<TD><asp:textbox id="txtUserStateId"   runat="server" Width="100px"></asp:textbox></TD>
		<TD></TD>
		<TD></TD>
	</TR>
	<TR>
		<TD><asp:label id="lblUserState"   runat="server">用户状态</asp:label></TD>
		<TD><asp:textbox id="txtUserState"   runat="server" Width="100px"></asp:textbox></TD>
		<TD></TD>
		<TD></TD>
	</TR>
	<TR>
		<TD><asp:label id="lblMemo"   runat="server">备注</asp:label></TD>
		<TD><asp:textbox id="txtMemo"   runat="server" Width="100px"></asp:textbox></TD>
		<TD></TD>
		<TD><FONT face="宋体"></FONT></TD>
	</TR>
</TABLE>
