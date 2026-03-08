<%@ Control Language="c#" AutoEventWireup="True" Inherits="GeneralPlatform.Webform.wucViewInfo" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" Codebehind="wucViewInfo.ascx.cs" %>
<meta name="vs_snapToGrid" content="false">
<meta name="vs_showGrid" content="true">
<TABLE id="tabwucViewInfo" cellSpacing="1" cellPadding="1" width="600" border="0">
	<TR>
		<TD>
			<asp:Label id="lblPrjId"   runat="server">项目编号</asp:Label></TD>
		<TD>
			<asp:DropDownList id="ddlPrjId"   runat="server" Width="288px"></asp:DropDownList></TD>
		<TD>
			<asp:Label id="lblModuleId" runat="server"   CssClass="NameControl">模块号</asp:Label></TD>
		<TD>
			<asp:DropDownList id="ddlModuleId" runat="server"   CssClass="ValueControl"
				Width="280px"></asp:DropDownList></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblViewId" runat="server"  >界面编号</asp:Label>
		</TD>
		<TD>
			<asp:TextBox id="txtViewId" runat="server"   ReadOnly="True"
				Width="292px"></asp:TextBox>
		</TD>
		<TD>
			<asp:Label id="lblViewName" runat="server"   Width="96px">界面名称</asp:Label>
		</TD>
		<TD>
			<asp:TextBox id="txtViewName" runat="server"   Width="292px"></asp:TextBox></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblViewCnName" runat="server"   Width="88px">界面中文名称</asp:Label>
		</TD>
		<TD>
			<asp:TextBox id="txtViewCnName" runat="server"   Width="292px"></asp:TextBox></TD>
		<TD>
			<asp:Label id="lblFileName" runat="server"   Width="96px">文件名</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtFileName" runat="server"   Width="292px"></asp:TextBox></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblFilePath" runat="server"  >文件路径</asp:Label>
		</TD>
		<TD>
			<asp:TextBox id="txtFilePath" runat="server"   Width="292px"></asp:TextBox>
		</TD>
		<TD colSpan="2">
			<asp:CheckBox id="chkIsNeedTransCode" runat="server"  
				Text="是否需要Ip限制"></asp:CheckBox>
		</TD>
	</TR>
	<TR>
		<TD><FONT face="宋体"></FONT></TD>
		<TD></TD>
		<TD>
		</TD>
		<TD></TD>
	</TR>
	<TR>
		<TD>
			<asp:CheckBox id="chkIsNeedSort"   runat="server" Text="IsNeedSort"
				Visible="False"></asp:CheckBox>
		</TD>
		<TD></TD>
		<TD>
			<asp:Label id="lblDefaMenuName"   runat="server" Visible="False">DefaMenuName</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtDefaMenuName"   runat="server" Visible="False">aa</asp:TextBox></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblUserID"   runat="server" Visible="False">UserID</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtUserID"   runat="server" Visible="False">00</asp:TextBox></TD>
		<TD>
			<asp:Label id="lblViewTypeCode" runat="server"   Visible="False">ViewTypeCode</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtViewTypeCode"   runat="server" Visible="False">0001</asp:TextBox></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblViewDetail"   runat="server" Visible="False">ViewDetail</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtViewDetail"   runat="server" Visible="False">0</asp:TextBox></TD>
		<TD>
			<asp:Label id="lblDataBaseName"   runat="server" Visible="False">DataBaseName</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtDataBaseName"   runat="server" Visible="False">0</asp:TextBox></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblMainTabName" runat="server"   Visible="False">MainTabName</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtMainTabName" runat="server"   Visible="False">0</asp:TextBox></TD>
		<TD></TD>
		<TD></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblDetailTabName"   runat="server" Visible="False">DetailTabName</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtDetailTabName"   runat="server" Visible="False">0</asp:TextBox></TD>
		<TD>
			<asp:Label id="lblKeyForMainTab"   runat="server" Visible="False">KeyForMainTab</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtKeyForMainTab"   runat="server" Visible="False">0</asp:TextBox></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblKeyForDetailTab"   runat="server"
				Visible="False">KeyForDetailTab</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtKeyForDetailTab"   runat="server"
				Visible="False">0</asp:TextBox></TD>
		<TD>
			<asp:Label id="lblViewFunction"   runat="server" Visible="False">ViewFunction</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtViewFunction"   runat="server" Visible="False">0</asp:TextBox></TD>
	</TR>
</TABLE>
