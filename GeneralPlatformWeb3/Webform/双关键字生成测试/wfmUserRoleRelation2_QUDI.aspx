<%@ Register TagPrefix="uc1" TagName="wucUserRoleRelation2" Src="wucUserRoleRelation2.ascx" %>
<%@ Page language="c#" AutoEventWireup="true" Inherits="GeneralPlatform.Webform.wfmUserRoleRelation2_QUDI" Codebehind="wfmUserRoleRelation2_QUDI.aspx.cs" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/tr/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title>UserRoleRelation2的维护</title>
<link rel="stylesheet" type="text/css" href="../../Webform/css/taishweb1.css"/>
</head>
<body>
<form id="form1" runat="server">
<table id="tabLayout" style="z-index: 105; left: 0px; position: absolute; top: 0px" cellspacing="2"
cellpadding="2" width="300" border="0" runat="server">
<tr>
<td>

<div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
<asp:Label ID="lblViewTitle" runat="server" CssClass="PageTitleH1" Height="16px">UserRoleRelation2表的维护
</asp:Label>
<asp:Label ID="lblMsg_List" runat="server" CssClass="ErrMsg" Height="16px" Style="z-index: 105;
left: 54px; position: relative; top: 4px" Width="347px"></asp:Label>
	</div>
</td>
</tr>
<tr>
<td>

<div id="divUserRoleRelation2" style="position: relative; width: 600px; height: 70px"> 

<asp:Label id="lblUserId_q" style="z-index: 104; left: 10px; position: absolute; top: 5px" 
runat="server" Width="70px" Height="16px" CssClass="NameLabel">用户ID</asp:Label>
<asp:TextBox id="txtUserId_q" style="z-index: 105; left: 85px; 
position: absolute; top: 5px" 
runat="server" Width="70px"  CssClass="TextBox_Defa">
</asp:TextBox>

<asp:Label id="lblRoleId_q" style="z-index: 107; left: 260px; position: absolute; top: 5px" 
runat="server" Width="70px" Height="16px" CssClass="NameLabel">角色Id</asp:Label>
<asp:TextBox id="txtRoleId_q" style="z-index: 108; left: 335px; 
position: absolute; top: 5px" 
runat="server" Width="70px"  CssClass="TextBox_Defa">
</asp:TextBox>

<asp:Label id="lblPrjId_q" style="z-index: 110; left: 10px; position: absolute; top: 35px" 
runat="server" Width="70px" Height="16px" CssClass="NameLabel">项目编号</asp:Label>
<asp:DropDownList id="ddlPrjId_q" style="z-index: 111; left: 85px; 
position: absolute; top: 35px" 
runat="server" Width="70px"  CssClass="TextBox_Defa">
</asp:DropDownList>

<asp:Label id="lblMemo_q" style="z-index: 113; left: 260px; position: absolute; top: 35px" 
runat="server" Width="70px" Height="16px" CssClass="NameLabel">备注</asp:Label>
<asp:TextBox id="txtMemo_q" style="z-index: 114; left: 335px; 
position: absolute; top: 35px" 
runat="server" Width="70px"  CssClass="TextBox_Defa">
</asp:TextBox>

<asp:Button id="btnQuery" 
 style="z-index: 116; left: 10px; 
 position: relative; top: 65px" 
runat="server" 
 Width="80px" Height="24px" 
 Text="查询" CssClass="Button_Defa" 
 OnClick="btnQuery_Click" 
></asp:Button>
</div>
</td>
<td></td>
<td></td>
</tr>
<tr>
<td></td>
<td></td>
<td></td>
</tr>
<tr>
<td>

<table id="tabUserRoleRelation2GridView" style="width: 552px" 
 runat="server">
<tr>
<td>
<div style="width: 750px; position: relative; height: 32px" id="divGridFunction" >
<asp:label id="lblUserRoleRelation2List" runat="server" Height="18px" style="z-index: 105; left: 0px; position: relative; top: 0px"  
CssClass="RegionTitleH1" >用户角色关系列表</asp:label>
<asp:button id="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" style="z-index: 106; left: 390px; position: absolute; top: 4px"
Width="80px" CssClass="Button_Defa" Text="添加记录"></asp:button>
<asp:button id="btnDelete4Gv" OnClick="btnDelete4Gv_Click" style="z-index: 104; left: 475px; position: absolute; top: 4px" runat="server"
Width="80px" CssClass="Button_Defa" Text="删除记录"></asp:button>
<asp:button id="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" style="z-index: 105; left: 560px; position: absolute; top: 4px" runat="server"
Width="80px" CssClass="Button_Defa" Text="修改记录"></asp:button>
<asp:button id="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click"  style="z-index: 107; left: 645px; position: absolute; top: 4px"
runat="server" Width="80px" CssClass="Button_Defa" Text="导出Excel"></asp:button>
</div>
</td>
</tr>
<tr>
<td>
<asp:GridView id="gvUserRoleRelation2" style="z-index: 117; position: relative;" runat="server" 
Width="800px" AutoGenerateColumns="False" 
 PageSize="10" AllowPaging="true" 
AllowSorting="true" 
OnSorting="gvUserRoleRelation2_Sorting" 
OnPageIndexChanging="gvUserRoleRelation2_PageIndexChanging" 
OnRowCreated="gvUserRoleRelation2_RowCreated"
OnRowCommand="gvUserRoleRelation2_RowCommand"
OnRowDeleting="gvUserRoleRelation2_RowDeleting" 
OnRowUpdating="gvUserRoleRelation2_RowUpdating" 
BackColor="White" 
BorderColor="#E7E7FF" 
BorderStyle="None" 
BorderWidth="1px"
cellpadding="3" 
GridLines="Horizontal" 
Height="1px" 
DataKeyNames="UserId,RoleId" 
CssClass="GridValue">
<Columns>
<asp:TemplateField HeaderText="全选">
<HeaderStyle Width="30px" />
<HeaderTemplate>
<asp:LinkButton id="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="DgSelAll" >全选</asp:LinkButton>
</HeaderTemplate>
<ItemTemplate>
<asp:CheckBox id="chkCheckRec" runat="server"></asp:CheckBox>
</ItemTemplate>
</asp:TemplateField>
<asp:BoundField DataField="UserId" SortExpression="UserId" HeaderText="用户ID"></asp:BoundField>
<asp:BoundField DataField="RoleId" SortExpression="RoleId" HeaderText="角色Id"></asp:BoundField>
<asp:BoundField DataField="PrjId" SortExpression="PrjId" HeaderText="项目编号"></asp:BoundField>
<asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="备注"></asp:BoundField>
<asp:TemplateField>
<ItemTemplate>
<asp:linkButton id="lbUpdate" runat="Server" CommandName="Update" Text="修改"></asp:linkButton>
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField>
<ItemTemplate>
<asp:linkButton id="lbDelete" runat="Server" CommandName="Delete" Text="删除"></asp:linkButton>
</ItemTemplate>
</asp:TemplateField>
</Columns>
<PagerTemplate>
<span style="background-color: #c0c0c0">共有记录:</span>
<asp:Label ID="lblRecCount" runat="server" CssClass ="Label_DefaInPager" ForeColor="#000066" Width="16px">0</asp:Label>
<span style="background-color: #c0c0c0">
<div style="display: inline; width: 16px; height: 13px">
</div>
</span><span style="background-color: #c0c0c0">总页数:</span>
<asp:Label ID="lblAllPages" runat="server" CssClass ="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
<div style="display: inline; width: 16px; height: 13px">
</div>
<span style="background-color: #c0c0c0">当前页:</span>
<asp:Label ID="lblCurrentPage" runat="server" CssClass ="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
<div style="display: inline; width: 16px; height: 13px">
</div>
<asp:Button ID="btnPrevPage" runat="server" CssClass ="Button_DefaInPager" Text="上一页"
Width="50px" CommandArgument="Prev" CommandName="Page" /><span style="font-family: Verdana">
</span>
<asp:Button ID="btnNextPage" runat="server" CssClass ="Button_DefaInPager" Text="下一页"
Width="50px" CommandArgument="Next" CommandName="Page" />
到第
<asp:TextBox ID="txtJump2Page" runat="server" CssClass ="TextBox_DefaInPager" Width="35px"></asp:TextBox>页
<asp:Button ID="btnJumpPage" runat="server" CssClass ="Button_DefaInPager" OnClick="btnJumpPage_Click"
Text="确定" Width="35px" CommandName="Page" />
<span style="background-color: #c0c0c0">页记录数:</span>
<asp:DropDownList ID="ddlPagerRecCount" runat="server" CssClass="DropDown_DefaInPager"
Width="41px" AutoPostBack="True" OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged">
<asp:ListItem>5</asp:ListItem>
<asp:ListItem>10</asp:ListItem>
<asp:ListItem>20</asp:ListItem>
<asp:ListItem>30</asp:ListItem>
<asp:ListItem>50</asp:ListItem>
<asp:ListItem>100</asp:ListItem>
<asp:ListItem>1000</asp:ListItem>
<asp:ListItem></asp:ListItem>
</asp:DropDownList>
<asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
ErrorMessage="错误！" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
</PagerTemplate>
<FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
<RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
<SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
<PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
<HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
<AlternatingRowStyle BackColor="#F7F7F7" />
</asp:GridView>
</td>
</tr>
</table>
</td>
<td></td>
<td></td>
</tr>
<tr>
<td></td>
<td></td>
<td></td>
</tr>
<tr>
<td>
<table id="tabEditUserRoleRelation2Region" style="z-index: 117;  width: 750px" 
cellspacing="1" cellpadding="1" width="750" border="1"  runat="server">
<tr>
<td>
<div style="width: 730px; position: relative; height: 32px" >
<asp:label id="lblEditUserRoleRelation2" style="z-index: 104; left: 0px; position: relative; top: 4px" runat="server"
CssClass="RegionTitleH1" Height="18px">用户角色关系编辑区域</asp:label>
<asp:Label id="lblMsg_Edit" style="z-index: 105; left: 54px; position: relative; top: 1px" runat="server" 
Width="208px" Height="16px" CssClass="ErrMsg" ></asp:Label>
<asp:Button id="btnOKUpd" style="z-index: 106; left: 68px; position: relative; top: 4px" runat="server" 
Width="80px" Text="添加" OnClick="btnOKUpd_Click" CssClass="Button_Defa"></asp:Button>
<asp:Button id="btnCancelUserRoleRelation2Edit" style="z-index: 107; left: 90px; position: relative; top: 4px"
runat="server" Width="100px" CssClass="Button_Defa" Text="取消编辑" OnClick="btnCancelUserRoleRelation2Edit_Click"></asp:Button>
</div>
</td>
</tr>
<tr>
<td>
<uc1:wucUserRoleRelation2 id="wucUserRoleRelation21" runat="server" />
</td>
</tr>
</table>
</td>
<td></td>
<td></td>
</tr>
</table>
</form>
</body>
</html>