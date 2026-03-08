<%@ Control Language="c#" AutoEventWireup="false" 
    Inherits="GeneralPlatform.Webform.wucDepartmentInfo" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" Codebehind="wucDepartmentInfoBak.ascx.cs" %>
<meta name="vs_snapToGrid" content="false">
<meta name="vs_showGrid" content="true">
<TABLE id="tabwucDepartmentInfo" cellSpacing="1" cellPadding="1" border="0"
	style="WIDTH: 597px; HEIGHT: 174px">
	<TR>
		<TD style="WIDTH: 99px">
			<asp:Label id="lblDepartmentId" runat="server"  >部门ID</asp:Label>
		</TD>
		<TD style="WIDTH: 141px">
			<asp:TextBox id="txtDepartmentId" runat="server"   Width="160px"></asp:TextBox>
		</TD>
		<TD style="WIDTH: 57px">
			<asp:Label id="Label1"   runat="server">名称缩写</asp:Label>
		</TD>
		<TD style="WIDTH: 144px">
			<asp:TextBox id="txtDepartmentAbbrName"   runat="server"
				Width="160px"></asp:TextBox></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 99px">
			<asp:Label id="lblDepartmentName" runat="server"  >部门名称</asp:Label>
		</TD>
		<TD style="WIDTH: 141px">
			<asp:TextBox id="txtDepartmentName" runat="server"   Width="160px"></asp:TextBox>
		</TD>
		<TD style="WIDTH: 57px">
			<asp:Label id="lblUpDepartmentId"   runat="server">所属部门</asp:Label></TD>
		<TD style="WIDTH: 144px">
			<asp:DropDownList id="ddlUpDepartmentId"   runat="server" Width="160px"></asp:DropDownList></TD>
	</TR>
	<TR>
		<TD style="WIDTH: 99px">
            <asp:Label id="lblDepartMentId4Card"   runat="server">一卡通部门ID</asp:Label></TD>
		<TD style="WIDTH: 141px">
            <asp:TextBox id="txtDepartMentId4Card"   runat="server"
				Width="160px"></asp:TextBox></TD>
        <td colspan="2">
			<asp:CheckBox id="chkIsAcademy"   runat="server" Text="是否学院"
				Width="144px"></asp:CheckBox></td>
	</TR>
	<TR>
		<TD style="WIDTH: 99px; height: 79px;">
			<asp:Label id="lblMemo"   runat="server">备注</asp:Label></TD>
		<TD style="WIDTH: 141px; height: 79px;" colspan="3">
			<asp:TextBox id="txtMemo"   runat="server" Width="463px"
				Height="64px"></asp:TextBox></TD>
	</TR>
</TABLE>
<table id="tabHidden" runat="server" style="width: 406px">
    <tr>
        <td style="width: 153px">
			<asp:Label id="Label2"   runat="server">序号</asp:Label></td>
        <td>
			<asp:TextBox id="txtOrderNum"   runat="server" Width="160px">0</asp:TextBox></td>
        <td style="width: 3px">
        </td>
    </tr>
    <tr>
        <td style="width: 153px">
			<asp:CheckBox id="chkIsExam"   runat="server" Width="144px"
				Text="是否参与考核"></asp:CheckBox></td>
        <td>
        </td>
        <td style="width: 3px">
        </td>
    </tr>
    <tr>
        <td style="width: 153px">
			<asp:Label id="lblDepartmentType"   runat="server">类型</asp:Label></td>
        <td>
			<asp:TextBox id="txtDepartmentType"   runat="server" Width="160px"></asp:TextBox></td>
        <td style="width: 3px">
        </td>
    </tr>
    <tr>
        <td style="width: 153px">
			<asp:Label id="lblSubjectTypeId"   runat="server">学科类型</asp:Label></td>
        <td>
				<asp:DropDownList id="ddlSubjectTypeId"   runat="server" Width="160px"></asp:DropDownList></td>
        <td style="width: 3px">
        </td>
    </tr>
</table>
