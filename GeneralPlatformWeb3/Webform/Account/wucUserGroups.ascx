<%@ Control Language="c#" AutoEventWireup="True" Inherits="GeneralPlatform.Webform.wucUserGroups" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" Codebehind="wucUserGroups.ascx.cs" %>
<meta name="vs_snapToGrid" content="False">
<meta name="vs_showGrid" content="True">
<TABLE id="tabwucUserGroups" cellSpacing="1" cellPadding="1" width="240" border="0" style="WIDTH: 240px; HEIGHT: 107px">
	<TR>
		<TD>
			<asp:Label id="lblPrjId" runat="server"  >工程编号</asp:Label></TD>
		<TD>
			<asp:DropDownList id="ddlPrjId" runat="server"   Width="150px"
				AutoPostBack="True" onselectedindexchanged="ddlPrjId_SelectedIndexChanged"></asp:DropDownList></TD>
		<TD></TD>
		<TD></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblGroupId" runat="server"  >用户组编号</asp:Label>
		</TD>
		<TD>
			<asp:TextBox id="txtGroupId" runat="server"   Width="150px"></asp:TextBox>
		</TD>
		<TD>
		</TD>
		<TD></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblGroupName" runat="server"  >用户组</asp:Label>
		</TD>
		<TD>
			<asp:TextBox id="txtGroupName" runat="server"   Width="150px"></asp:TextBox>
		</TD>
		<TD>
		</TD>
		<TD></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblMemo" runat="server"  >备注</asp:Label>
		</TD>
		<TD>
			<asp:TextBox id="txtMemo" runat="server"   Width="150px"></asp:TextBox>
		</TD>
		<TD>
		</TD>
		<TD></TD>
	</TR>
</TABLE>
