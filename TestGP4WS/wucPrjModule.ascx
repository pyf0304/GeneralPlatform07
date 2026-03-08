<%@ Control Language="c#" AutoEventWireup="True" Inherits="GeneralPlatform.Webform.wucPrjModule" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" Codebehind="wucPrjModule.ascx.cs" %>
<meta name="vs_snapToGrid" content="false">
<meta name="vs_showGrid" content="true">
<TABLE id="tabwucPrjModule" cellSpacing="1" cellPadding="1" width="600" border="0">
	<TR>
		<TD>
			<asp:Label id="lblModuleId" runat="server"  >模块号</asp:Label>
		</TD>
		<TD>
			<asp:TextBox id="txtModuleId" runat="server"   Width="200px"></asp:TextBox>
		</TD>
		<TD>
			<asp:Label id="lblModuleName" runat="server"  >模块名称</asp:Label>
		</TD>
		<TD>
			<asp:TextBox id="txtModuleName" runat="server"   Width="200px"></asp:TextBox></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblPrjId" runat="server"  >项目编号</asp:Label>
		</TD>
		<TD>
			<asp:DropDownList id="ddlPrjId" runat="server"   Width="200px"></asp:DropDownList>
		</TD>
		<TD>
		</TD>
		<TD></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblMemo" runat="server"  >备注</asp:Label>
		</TD>
		<TD colSpan=3>
			<asp:TextBox id="txtMemo" runat="server"   Width="496px" Height="88px" TextMode="MultiLine"></asp:TextBox>
		</TD>
	</TR>
</TABLE>
