<%@ Control Language="c#" AutoEventWireup="True" Inherits="GeneralPlatform.Webform.wucProjects" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" Codebehind="wucProjects.ascx.cs" %>
<meta name="vs_snapToGrid" content="False">
<meta name="vs_showGrid" content="True">
<TABLE id="tabwucProjects" cellSpacing="1" cellPadding="1" width="600" border="0">
	<TR>
		<TD>
			<asp:Label id="lblPrjId" runat="server"  >项目编号</asp:Label>
		</TD>
		<TD>
			<asp:TextBox id="txtPrjId" runat="server"  ></asp:TextBox>
		</TD>
		<TD>
			<asp:Label id="lblPrjName" runat="server"  >项目名称</asp:Label></TD>
		<TD>
			<asp:TextBox id="txtPrjName" runat="server"  ></asp:TextBox></TD>
	</TR>
	<TR>
		<TD>
            &nbsp;<asp:Label ID="Label1" runat="server"  >是否默认工程</asp:Label></TD>
        <td colspan="3">
            &nbsp;<asp:CheckBox ID="chkIsDefaultPrj" runat="server" /></td>
	</TR>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server"  >本地数据库</asp:Label></td>
        <td colspan="3">
            <asp:DropDownList ID="ddlPrjDataBase" runat="server" Width="163px">
            </asp:DropDownList></td>
    </tr>
	<TR>
		<TD>
			<asp:Label id="lblMemo" runat="server"  >超链接地址</asp:Label>
		</TD>
        <td colspan="3">
			<asp:TextBox id="txtMemo" runat="server"   Width="512px"></asp:TextBox>
        </td>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblPrjMainDataBase" runat="server"  
				Visible="False">PrjMainDataBase</asp:Label>
		</TD>
		<TD>
			<asp:TextBox id="txtPrjMainDataBase" runat="server"  
				Visible="False"></asp:TextBox>
		</TD>
		<TD>
		</TD>
		<TD></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblIpAddress" runat="server"   Visible="False">IpAddress</asp:Label>
		</TD>
		<TD>
			<asp:TextBox id="txtIpAddress" runat="server"   Visible="False"></asp:TextBox>
		</TD>
		<TD>
		</TD>
		<TD></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblDataBaseUserId" runat="server"   Visible="False">DataBaseUserId</asp:Label>
		</TD>
		<TD>
			<asp:TextBox id="txtDataBaseUserId" runat="server"   Visible="False"></asp:TextBox>
		</TD>
		<TD>
		</TD>
		<TD></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblDataBasePwd" runat="server"   Visible="False">DataBasePwd</asp:Label>
		</TD>
		<TD>
			<asp:TextBox id="txtDataBasePwd" runat="server"   Visible="False"></asp:TextBox>
		</TD>
		<TD>
		</TD>
		<TD></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblUserID" runat="server"   Visible="False">UserID</asp:Label>
		</TD>
		<TD>
			<asp:TextBox id="txtUserID" runat="server"   Visible="False">0</asp:TextBox>
		</TD>
		<TD>
		</TD>
		<TD></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblUpdTime" runat="server"   Visible="False">UpdTime</asp:Label>
		</TD>
		<TD>
			<asp:TextBox id="txtUpdTime" runat="server"   Visible="False"></asp:TextBox>
		</TD>
		<TD>
		</TD>
		<TD></TD>
	</TR>
	<TR>
		<TD>
			<asp:Label id="lblPrjDomain" runat="server"   Visible="False">PrjDomain</asp:Label>
		</TD>
		<TD>
			<asp:TextBox id="txtPrjDomain" runat="server"   Visible="False"></asp:TextBox>
		</TD>
		<TD>
		</TD>
		<TD></TD>
	</TR>
</TABLE>
