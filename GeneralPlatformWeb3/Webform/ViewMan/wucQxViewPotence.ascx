<%@ Control Language="c#" AutoEventWireup="True" Inherits="GeneralPlatform.Webform.wucQxViewPotence" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" Codebehind="wucQxViewPotence.ascx.cs" %>
<meta name="vs_snapToGrid" content="false">
<meta name="vs_showGrid" content="true">
<TABLE id="tabwucQxViewPotence" cellSpacing="1" cellPadding="1" border="0" style="WIDTH: 563px; HEIGHT: 127px">
	<TR>
		<TD>
			<asp:Label id="lblPrjId"   runat="server" Height="14px" Width="31px">项目</asp:Label>
		</TD>
		<TD>
			<asp:DropDownList id="ddlPrjId"   runat="server" AutoPostBack="True" onselectedindexchanged="ddlPrjId_SelectedIndexChanged" Width="234px"></asp:DropDownList>
		</TD>
		<TD style="width: 132px">
			<asp:Label id="lblLevel"   runat="server" Visible="False">等级</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtLevel"   runat="server" Visible="False">0</asp:TextBox>
			<asp:CompareValidator id="ComValid_Level"   runat="server" EnableClientScript="false"
				Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtLevel" ErrorMessage="请输入整型数值!"></asp:CompareValidator></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblViewId"   runat="server">界面</asp:Label>
		</TD>
		<TD>
			<asp:DropDownList id="ddlViewId"   runat="server" Width="236px"></asp:DropDownList></TD>
		<TD style="width: 132px"></TD>
		<TD></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblPotenceId" runat="server"  >权限</asp:Label></TD>
		<TD>
			<asp:DropDownList id="ddlPotenceId" runat="server"   Width="234px"></asp:DropDownList>
		</TD>
		<TD style="width: 132px">
		</TD>
		<TD></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblMemo" runat="server"  >备注</asp:Label>
		</TD>
        <td colspan="3">
			<asp:TextBox id="txtMemo" runat="server"   Width="499px"></asp:TextBox></td>
	</TR>
	<TR>
		<TD>
		</TD>
		<TD></TD>
		<TD style="width: 132px"></TD>
		<TD></TD>
	</TR>
</TABLE>
