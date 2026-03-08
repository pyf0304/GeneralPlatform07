<%@ Register TagPrefix="uc1" TagName="wucQxRoleMenusB" Src="wucQxRoleMenusB.ascx" %>

<%@ Page Language="c#" AutoEventWireup="true"
    Inherits="GeneralPlatform.Webform.wfmQxRoleMenusB_QUDI" CodeBehind="wfmQxRoleMenusB_QUDI.aspx.cs" Theme="TaiZeTheme" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/tr/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>角色菜单维护的维护</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
       <style type="text/css">
        .style1 {
            FONT-SIZE: 12px;
            COLOR: #000099;
            FONT-FAMILY: Verdana;
        }

        .style2 {
            FONT-SIZE: 12px;
            COLOR: #0000ff;
            FONT-FAMILY: Verdana, Arial, Helvetica, sans-serif;
        }

        A:link {
            COLOR: #003366;
            TEXT-DECORATION: none;
        }

        A:visited {
            COLOR: #003366;
            TEXT-DECORATION: none;
        }

        A:hover {
            BACKGROUND-COLOR: #ffff99;
            TEXT-DECORATION: underline;
        }

        A:active {
            COLOR: #669966;
            TEXT-DECORATION: none;
        }

        BODY {
            BACKGROUND-COLOR: #daefdc;
        }
    </style>

    <script language="JavaScript" type="text/javascript">
<!--
    /*
    function showthis(Tid)
    {
        var c=document.getElementsByTagName("table");
        var l=c.length;
        var i;
        for(i=0;i<l;i++)
        {
            str = c[i].id;
            str = str.substr(0,4);
            if(str=="menu")
            {
                if(c[i].id==Tid)
                    if(c[i].style.display=="")
                        c[i].style.display="none";
                    else	
                        c[i].style.display="";
                else c[i].style.display="none";
            }
        }
    }
    */
    function showthis(Tid)
    {
        var c=document.getElementsByTagName("table");
        var l=c.length;
        var i;
        if (Tid.length == 8)
        {
            //alert("length == 8");
            for(i=0;i<l;i++)
            {
                str = c[i].id;		    
                if(str==Tid)
                {
                    if(c[i].style.display=="")
                        c[i].style.display="none";
                    else	
                        c[i].style.display="";
                    break;
                }
            }
        }
        else     
        {
            for(i=0;i<l;i++)
            {
                str = c[i].id;
                str = str.substr(0,4);
                if(str=="menu")
                {
                    c[i].style.display="none";
                }
            }
            showFather(Tid);
            showBrother(Tid);
            showSon(Tid);
        }
	
    }
    function showSon(Tid)
    {
        var c=document.getElementsByTagName("table");
        c[Tid].style.display="";
        var i;
        for(i=0;i<9;i++)
        {
            if(c[Tid+i]!=null)
            { 
                if( c[Tid+i].style.display="none")
                    c[Tid+i].style.display="";
            }
        }
    }
    function showFather(Tid)
    {
        var c=document.getElementsByTagName("table");
        if(Tid !="menu")
        {
            var father = Tid.substring(0,Tid.length-1);
            if( c[father]!=null)
            {  c[father].style.display="";
                showFather(father);
            }
        }
        else
            return;
    }
    function showBrother(Tid)
    {
        var c=document.getElementsByTagName("table");
        if(Tid !="menu")
        {
            var father=Tid.substring(0,Tid.length-1);
            if(c[father]!=null)
                showSon(father);
        }
    }
    -->
    </script>

</head>
<body>
    <form id="form1" runat="server">
        <table id="tabLayout" style="z-index: 105; left: 0px; position: absolute; top: 0px"
            cellspacing="2" cellpadding="2" width="100%" border="0" runat="server">
            <tr>
                <td>
                    <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                        <asp:Label ID="lblViewTitle" runat="server" CssClass="PageTitleH1">角色菜单维护
                        </asp:Label>
                        <asp:Label ID="lblMsg_List" runat="server" CssClass="ErrMsg" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                            Width="347px"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="lblPrjId_q" Style="z-index: 107;" runat="server" Width="34px" Height="20px"
                                    CssClass="NameLabel">项目</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlPrjId_q" Style="z-index: 108;" runat="server" Width="100px"
                                    Height="22px" CssClass="TextBox_Defa"
                                    OnSelectedIndexChanged="ddlPrjId_q_SelectedIndexChanged" AutoPostBack="True">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="Label3" runat="server" Width="42px" CssClass="Label_Defa">菜单集</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlPrjMenuSet" Style="z-index: 102;" runat="server" Width="116px">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="lblRoleId_q" Style="z-index: 104;" runat="server" Width="50px" Height="20px"
                                    CssClass="NameLabel">角色</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlRoleId_q" Style="z-index: 105;" runat="server" Width="100px"
                                    Height="22px" CssClass="TextBox_Defa">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="lblMenuId_q" Style="z-index: 110;" runat="server" Width="50px" Height="20px"
                                    CssClass="NameLabel">菜单</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlMenuId_q" Style="z-index: 111;" runat="server" Width="100px"
                                    Height="22px" CssClass="TextBox_Defa">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Button ID="btnQuery" Style="z-index: 113;" runat="server" Width="80px"
                                    Text="查询" CssClass="btn btn-outline-info btn-sm" OnClick="btnQuery_Click"></asp:Button>
                                <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" Style="z-index: 107;"
                                    runat="server" Width="80px" CssClass="btn btn-outline-info btn-sm" Text="导出Excel"></asp:Button>
                                <asp:Button ID="btnSetExportExcel4User" OnClick="btnSetExportExcel4User_Click" Style="z-index: 107;"
                                    CssClass="btn btn-outline-info btn-sm" runat="server" Width="100px" Text="设置导出字段"></asp:Button>
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
                    <table id="tabQxRoleMenusGridView" style="width: 100%" runat="server">
                        <tr>
                            <td>
                                <table style="width: 100%; height: 32px" id="tabGridFunction">
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblQxRoleMenusList" runat="server" Style="z-index: 105;" CssClass="RegionTitleH1"
                                                Width="250px">角色菜单列表</asp:Label>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" Style="z-index: 106;"
                                                Width="80px" CssClass="btn btn-outline-info btn-sm" Text="添加记录"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click" Style="z-index: 104;"
                                                runat="server" Width="80px" CssClass="btn btn-outline-info btn-sm" Text="删除记录"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" Style="z-index: 105;"
                                                runat="server" Width="80px" CssClass="btn btn-outline-info btn-sm" Text="修改记录"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:LinkButton ID="lbImportExcel4QxRoleMenus" runat="server" CssClass="LinkButton_Defa"
                                                OnClick="lbImportExcel4QxRoleMenus_Click">通过Excel导入角色菜单</asp:LinkButton>
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:GridView ID="gvQxRoleMenus" Style="z-index: 114;" runat="server" Width="100%"
                                    AutoGenerateColumns="False" PageSize="10" AllowPaging="true" AllowSorting="true"
                                    OnSorting="gvQxRoleMenus_Sorting" OnPageIndexChanging="gvQxRoleMenus_PageIndexChanging"
                                    OnRowCreated="gvQxRoleMenus_RowCreated" OnRowCommand="gvQxRoleMenus_RowCommand" OnRowDeleting="gvQxRoleMenus_RowDeleting"
                                    OnRowUpdating="gvQxRoleMenus_RowUpdating" BackColor="White" BorderColor="#E7E7FF"
                                    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" Height="1px"
                                    DataKeyNames="mId" CssClass="GridValue">
                                    <Columns>
                                        <asp:TemplateField HeaderText="全选">
                                            <HeaderStyle Width="30px" />
                                            <HeaderTemplate>
                                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="DgSelAll">全选</asp:LinkButton>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="mId" SortExpression="mId" HeaderText="流水号"></asp:BoundField>
                                        <asp:BoundField DataField="PrjName" SortExpression="PrjName" HeaderText="工程名"></asp:BoundField>
                                        <asp:BoundField DataField="RoleName" SortExpression="RoleName" HeaderText="角色名称"></asp:BoundField>
                                        <asp:BoundField DataField="MenuName" SortExpression="MenuName" HeaderText="菜单名"></asp:BoundField>
                                        <asp:BoundField DataField="RoleNum" SortExpression="RoleNum" HeaderText="角色数"></asp:BoundField>
                                        <asp:BoundField DataField="UpMenuName" SortExpression="UpMenuName" HeaderText="上级菜单名"></asp:BoundField>
                                        <asp:BoundField DataField="MenuSetName" SortExpression="MenuSetName" HeaderText="菜单集名称"></asp:BoundField>
                                        <asp:BoundField DataField="MenuTitle" SortExpression="MenuTitle" HeaderText="菜单标题"></asp:BoundField>
                                        <asp:BoundField DataField="PageDispModeName" SortExpression="PageDispModeName" HeaderText="页面显示模式名称"></asp:BoundField>

                                        <asp:BoundField DataField="OrderNum" SortExpression="OrderNum" HeaderText="排序号"></asp:BoundField>
                                        <asp:BoundField DataField="IsLeafNode" SortExpression="IsLeafNode" HeaderText="是否叶子"></asp:BoundField>
                                        <asp:BoundField DataField="ImgFile" SortExpression="ImgFile" HeaderText="图像文件"></asp:BoundField>
                                        <asp:BoundField DataField="LinkFile" SortExpression="LinkFile" HeaderText="链接文件"></asp:BoundField>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbUpdate" runat="Server" CommandName="Update" Text="修改"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <PagerTemplate>
                                        <span style="background-color: #c0c0c0">共有记录:</span>
                                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066"
                                            Width="22px">0</asp:Label>
                                        <span style="background-color: #c0c0c0">
                                            <div style="display: inline; width: 16px; height: 13px">
                                            </div>
                                        </span><span style="background-color: #c0c0c0">总页数:</span>
                                        <asp:Label ID="lblAllPages" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <span style="background-color: #c0c0c0">当前页:</span>
                                        <asp:Label ID="lblCurrentPage" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <asp:Button ID="btnPrevPage" runat="server" CssClass="Button_DefaInPager" Text="上一页"
                                            Width="50px" CommandArgument="Prev" CommandName="Page" /><span style="font-family: Verdana">
                                            </span>
                                        <asp:Button ID="btnNextPage" runat="server" CssClass="Button_DefaInPager" Text="下一页"
                                            Width="50px" CommandArgument="Next" CommandName="Page" />
                                        到第
                                    <asp:TextBox ID="txtJump2Page" runat="server" CssClass="TextBox_DefaInPager" Width="35px"></asp:TextBox>页
                                    <asp:Button ID="btnJumpPage" runat="server" CssClass="Button_DefaInPager" OnClick="btnJumpPage_Click"
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
                    <table id="tabEditQxRoleMenusRegion" style="z-index: 114; width: 100%" cellspacing="1"
                        cellpadding="1" width="100%" border="1" runat="server">
                        <tr>
                            <td>
                                <asp:Label ID="lblEditQxRoleMenus" Style="z-index: 104;" runat="server" CssClass="RegionTitleH1">角色菜单编辑区域</asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblMsg_Edit" Style="z-index: 105;" runat="server" Width="208px"
                                    CssClass="ErrMsg"></asp:Label>
                            </td>
                            <td>
                                <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server" Width="80px" Text="添加"
                                    OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                            </td>
                            <td>
                                <asp:Button ID="btnCancelQxRoleMenusEdit" Style="z-index: 107;" runat="server" Width="100px"
                                    CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelQxRoleMenusEdit_Click"></asp:Button>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <uc1:wucQxRoleMenusB ID="wucQxRoleMenusB1" runat="server" />
                            </td>
                        </tr>

                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="当前角色的菜单："></asp:Label></td>
                
                <td></td>
            </tr>
            <tr>
                <td colspan="1">
                    <span id="spanMenu" runat="server"></span>
                </td>
                <td colspan="2"></td>

            </tr>
        </table>
    </form>
</body>
</html>
