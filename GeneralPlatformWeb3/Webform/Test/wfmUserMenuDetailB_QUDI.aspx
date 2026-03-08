
<%@ Register TagPrefix="uc1" TagName="wucUserMenuDetailB" Src="wucUserMenuDetailB.ascx" %>
<%@ Page language="c#" AutoEventWireup="true" CodeBehind="wfmUserMenuDetailB_QUDI.aspx.cs" Inherits="GeneralPlatform.Webform.wfmUserMenuDetailB_QUDI" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>用户菜单维护的维护</title>
                <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link rel="stylesheet" type="text/css" href="../../css/tz_base11.css"/>
 <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
</head>
<body>
<form id="form1" runat="server">
<div id="tabLayout" class="tab_layout" 
 runat="server">
              <%-- 标题层 --%>

<div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
<asp:Label ID="lblViewTitle" runat="server" CssClass="PageTitleH1" Height="16px">用户菜单维护
</asp:Label>
<asp:Label ID="lblMsg_List" runat="server" CssClass="ErrMsg" Height="16px" Style="z-index: 105;
left: 54px; position: relative; top: 4px" Width="347px"></asp:Label>
	</div>
<%-- 查询层 --%>

<div id="divQuery" class="div_query"> 
<table class="msgtable" style="width: 80%"> 
<tr>

<td>
<asp:Label id="lblmId_q" style="z-index: 104;" 
runat="server" CssClass="NameLabel">流水号</asp:Label>
</td>
<td>
<asp:TextBox id="txtmId_q" style="z-index: 105; " 
runat="server" CssClass="TextBox_Defa">
</asp:TextBox>
</td>

<td>
<asp:Label id="lblMenuId_q" style="z-index: 107;" 
runat="server" CssClass="NameLabel">菜单Id</asp:Label>
</td>
<td>
<asp:DropDownList id="ddlMenuId_q" style="z-index: 108; " 
runat="server" CssClass="TextBox_Defa">
</asp:DropDownList>
</td>
</tr>
<tr>

<td>
<asp:Label id="lblMenuName_q" style="z-index: 110;" 
runat="server" CssClass="NameLabel">菜单名</asp:Label>
</td>
<td>
<asp:TextBox id="txtMenuName_q" style="z-index: 111; " 
runat="server" CssClass="TextBox_Defa">
</asp:TextBox>
</td>

<td>
<asp:CheckBox id="chkIsDisp_q" 
 style="z-index: 113; Width:100px; Height:15px;" 
runat="server" 
 Text="是否显示"  
CssClass="Check_Defa"></asp:CheckBox>
</td>
</tr>
<tr>

<td>
<asp:Label id="lblUpMenuId_q" style="z-index: 115;" 
runat="server" CssClass="NameLabel">上级菜单Id</asp:Label>
</td>
<td>
<asp:DropDownList id="ddlUpMenuId_q" style="z-index: 116; " 
runat="server" CssClass="TextBox_Defa">
</asp:DropDownList>
</td>

<td>
<asp:Label id="lblLinkFile_q" style="z-index: 118;" 
runat="server" CssClass="NameLabel">链接文件</asp:Label>
</td>
<td>
<asp:TextBox id="txtLinkFile_q" style="z-index: 119; " 
runat="server" CssClass="TextBox_Defa">
</asp:TextBox>
</td>
</tr>
<tr>

<td>
<asp:Label id="lblImgFile_q" style="z-index: 121;" 
runat="server" CssClass="NameLabel">图像文件</asp:Label>
</td>
<td>
<asp:TextBox id="txtImgFile_q" style="z-index: 122; " 
runat="server" CssClass="TextBox_Defa">
</asp:TextBox>
</td>

<td>
<asp:CheckBox id="chkIsCustomMenu_q" 
 style="z-index: 124; Width:100px; Height:15px;" 
runat="server" 
 Text="是否定制菜单"  
CssClass="Check_Defa"></asp:CheckBox>
</td>
</tr>
<tr>

<td>
<asp:Label id="lblUserId_q" style="z-index: 126;" 
runat="server" CssClass="NameLabel">用户ID</asp:Label>
</td>
<td>
<asp:DropDownList id="ddlUserId_q" style="z-index: 127; " 
runat="server" CssClass="TextBox_Defa">
</asp:DropDownList>
</td>

<td>
<asp:Label id="lblPrjId_q" style="z-index: 129;" 
runat="server" CssClass="NameLabel">项目Id</asp:Label>
</td>
<td>
<asp:DropDownList id="ddlPrjId_q" style="z-index: 130; " 
runat="server" CssClass="TextBox_Defa">
</asp:DropDownList>
</td>
</tr>
<tr>

<td>
<asp:Label id="lblOrderNum_q" style="z-index: 132;" 
runat="server" CssClass="NameLabel">排序号</asp:Label>
</td>
<td>
<asp:TextBox id="txtOrderNum_q" style="z-index: 133; " 
runat="server" CssClass="TextBox_Defa">
</asp:TextBox>
</td>

<td>
<asp:Label id="lblMemo_q" style="z-index: 135;" 
runat="server" CssClass="NameLabel">备注</asp:Label>
</td>
<td>
<asp:TextBox id="txtMemo_q" style="z-index: 136; " 
runat="server" CssClass="TextBox_Defa">
</asp:TextBox>
</td>
</tr>
<tr>
<td>

<asp:Button id="btnQuery" 
 style="z-index: 138; Width:80px; Height:24px;" 
runat="server" 
 Text="查询" CssClass="btn btn-outline-info btn-sm" 
 OnClick="btnQuery_Click" 
></asp:Button>
</td>
</tr>
</table>
</div>
 <%-- 列表层 --%>

<div id="divList" class="div_List" 
 runat="server">
<table id="tabGridFunction" style="width: 100%; height: 32px" class="msgtable" >
<tr>
<td>
<asp:label id="lblUserMenuDetailList" runat="server"  style="z-index: 105; "  
CssClass="RegionTitleH1" Width="250px">用户菜单列表</asp:label>
</td>
<td>
<asp:button id="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" style="z-index: 106; "
Width="80px" CssClass="btn btn-outline-info btn-sm" Text="添加记录"></asp:button>
</td>
<td>
<asp:button id="btnDelete4Gv" OnClick="btnDelete4Gv_Click" style="z-index: 104; " runat="server"
Width="80px" CssClass="btn btn-outline-info btn-sm" Text="删除记录"></asp:button>
</td>
<td>
<asp:button id="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" style="z-index: 105; " runat="server"
Width="80px" CssClass="btn btn-outline-info btn-sm" Text="修改记录"></asp:button>
</td>
<td>
<asp:button id="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click"  style="z-index: 107; "
runat="server" Width="80px" CssClass="btn btn-outline-info btn-sm" Text="导出Excel"></asp:button>
</td>
<td>
<asp:button id="btnSetExportExcel4User" OnClick="btnSetExportExcel4User_Click"  style="z-index: 107; "
runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="设置导出字段"></asp:button>
</td>
</tr>
</table>
<asp:GridView id="gvUserMenuDetail" style="z-index: 139;" runat="server" 
Width="100%" AutoGenerateColumns="False" 
 PageSize="10" AllowPaging="true" 
AllowSorting="true" 
OnSorting="gvUserMenuDetail_Sorting" 
OnPageIndexChanging="gvUserMenuDetail_PageIndexChanging" 
OnRowCreated="gvUserMenuDetail_RowCreated"
OnRowCommand="gvUserMenuDetail_RowCommand"
OnRowDeleting="gvUserMenuDetail_RowDeleting" 
OnRowUpdating="gvUserMenuDetail_RowUpdating" 
BackColor="White" 
BorderColor="#E7E7FF" 
BorderStyle="None" 
BorderWidth="1px"
cellpadding="3" 
GridLines="Horizontal" 
Height="1px" 
DataKeyNames="mId" 
CssClass="GridValue">
<Columns>
<asp:TemplateField HeaderText="全选">
<HeaderStyle Width="30px" />
<HeaderTemplate>
<asp:LinkButton id="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="DgSelAll" >全选</asp:LinkButton>
</HeaderTemplate>
<ItemTemplate>
<a name="A_QxUserMenuDetail<%# Eval("mId").ToString().Trim() %>"></a>
<asp:CheckBox id="chkCheckRec" runat="server"></asp:CheckBox>
</ItemTemplate>
</asp:TemplateField>
<asp:BoundField DataField="mId" SortExpression="mId" HeaderText="流水号"></asp:BoundField>
<asp:BoundField DataField="MenuId" SortExpression="MenuId" HeaderText="菜单Id"></asp:BoundField>
<asp:BoundField DataField="MenuName" SortExpression="MenuName" HeaderText="菜单名"></asp:BoundField>
<asp:BoundField DataField="IsDisp" SortExpression="IsDisp" HeaderText="是否显示"></asp:BoundField>
<asp:BoundField DataField="UpMenuId" SortExpression="UpMenuId" HeaderText="上级菜单Id"></asp:BoundField>
<asp:BoundField DataField="LinkFile" SortExpression="LinkFile" HeaderText="链接文件"></asp:BoundField>
<asp:BoundField DataField="ImgFile" SortExpression="ImgFile" HeaderText="图像文件"></asp:BoundField>
<asp:BoundField DataField="IsCustomMenu" SortExpression="IsCustomMenu" HeaderText="是否定制菜单"></asp:BoundField>
<asp:BoundField DataField="UserId" SortExpression="UserId" HeaderText="用户ID"></asp:BoundField>
<asp:BoundField DataField="QxPrjId" SortExpression="QxPrjId" HeaderText="项目Id"></asp:BoundField>
<asp:BoundField DataField="OrderNum" SortExpression="OrderNum" HeaderText="排序号"></asp:BoundField>
<asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="备注"></asp:BoundField>
<asp:TemplateField HeaderText="修改">
<ItemTemplate>
<asp:linkButton id="lbUpdate" runat="Server" CommandName="Update" Text="修改"></asp:linkButton>
</ItemTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="删除">
<ItemTemplate>
<asp:linkButton id="lbDelete" runat="Server" CommandName="Delete" Text="删除"></asp:linkButton>
</ItemTemplate>
</asp:TemplateField>
</Columns>
<PagerTemplate>
<span style="background-color: #c0c0c0">共有记录:</span>
<asp:Label ID="lblRecCount" runat="server" CssClass ="Label_DefaInPager" ForeColor="#000066" Width="22px">0</asp:Label>
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
Width="55px" AutoPostBack="True" OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged">
<asp:ListItem>5</asp:ListItem>
<asp:ListItem>10</asp:ListItem>
<asp:ListItem>20</asp:ListItem>
<asp:ListItem>30</asp:ListItem>
<asp:ListItem>50</asp:ListItem>
<asp:ListItem>100</asp:ListItem>
<asp:ListItem>1000</asp:ListItem>
</asp:DropDownList>
<asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
ErrorMessage="错误！" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
</PagerTemplate>
<FooterStyle CssClass="FooterStyle" />
<RowStyle CssClass="RowStyle" />
<EmptyDataRowStyle CssClass="EmptyDataRowStyle" />
<SelectedRowStyle CssClass="SelectedRowStyle" />
<PagerStyle CssClass="PagerStyle" />
<HeaderStyle CssClass="HeaderStyle" />
<EditRowStyle CssClass="EditRowStyle" />
<AlternatingRowStyle CssClass="AlternatingRowStyle" />
</asp:GridView>
</div>
<%-- 编辑层 --%>
<div id="tabEditUserMenuDetailRegion" class="tab_Edit" 
 runat="server">
<div>
<table style="width: 100%;" class="msgtable">
<tr>
<th style="text-align: left">
<asp:label id="lblEditUserMenuDetail" style="z-index: 104; " runat="server"
CssClass="RegionTitleH1" >用户菜单编辑区域</asp:label>
<asp:Label id="lblMsg_Edit" style="z-index: 105; " runat="server" 
Width="208px" Height="16px" CssClass="ErrMsg" ></asp:Label>
</th>
<th style="text-align: right">
<asp:Button id="btnOKUpd" style="z-index: 106; " runat="server" 
Width="80px" Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
 &nbsp;
<asp:Button id="btnCancelUserMenuDetailEdit" style="z-index: 107; "
runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelUserMenuDetailEdit_Click"></asp:Button>
</th>
</tr>
</table>
</div>
<div>
<uc1:wucUserMenuDetailB id="wucUserMenuDetailB1" runat="server" />
</div>
</div>
</div>
</form>
</body>
</html>