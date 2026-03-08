<%@ Page Language="c#" AutoEventWireup="false"
    Inherits="GeneralPlatform.Webform.wfmSetPotenceSymbolForRoles" Codebehind="wfmSetPotenceSymbolForRoles.aspx.cs" Theme="TaiZeTheme"  %>

<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>


<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>wfmManPotences</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../tzTreeViewWuc/cssTreeView.css" rel="stylesheet" />
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
    <table id="Table1" style="z-index: 101; left: 8px; width: 860px; position: absolute;
        top: 56px;" cellspacing="1" cellpadding="1" border="1">
        <tr>
            <td style="width: 373px; ">
                <table id="Table2" style="width: 376px; " cellspacing="0" cellpadding="0"
                    width="376" border="0" runat="server">
                    <tr>
                        <td style="width: 95px">
                            <asp:Label ID="Label1" runat="server"  Font-Names="Vrinda">用户的显示方式</asp:Label>
                        </td>
                        <td style="width: 242px">
                            <asp:RadioButtonList ID="rblDispFashion" runat="server"  
                                RepeatDirection="Horizontal" Width="254px"  AutoPostBack="True">
                                <asp:ListItem Value="所有用户" Selected="True">所有用户</asp:ListItem>
                                <asp:ListItem Value="按组显示">按组</asp:ListItem>
                                <asp:ListItem Value="按部门显示">按部门</asp:ListItem>
                                <asp:ListItem Value="按角色显示">按角色</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                    </tr>
                </table>
                <asp:DropDownList ID="ddlPrj" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
            <td style="width: 39px;">
            </td>
            <td >
                <asp:LinkButton ID="lbBrowUserGroupPotence" runat="server" OnClick="lbBrowUserGroupPotence_Click">查看被选用户/组的权限</asp:LinkButton><asp:Label
                    ID="lblMsg" runat="server"   Width="304px"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 373px; " valign="top">
             <%--   <asp:TreeView ID="tvUsers" runat="server" Width="380px" Height="350px" OnSelectedNodeChanged="tvUsers_SelectedNodeChanged"
                    OnTreeNodeCheckChanged="tvUsers_TreeNodeCheckChanged">
                    <SelectedNodeStyle BackColor="Silver" />
                </asp:TreeView>--%>
                <uc1:wucTreeView runat="server" ID="wucTreeView1"   OnafterSelect_Tz="wucTreeView1_afterSelect_Tz"  />
            </td>
            <td style="width: 39px;">
              
            </td>
            <td  valign="top">
                <asp:TreeView ID="tvPotences" runat="server" Width="450px" OnTreeNodeCheckChanged="tvPotences_TreeNodeCheckChanged">
                </asp:TreeView>
            </td>
        </tr>
        <tr>
            <td style="width: 373px;">
                <asp:CheckBox ID="chkAutoDispUserGroupPotences" runat="server" 
                     Width="214px" AutoPostBack="True" Text="自动显示所选用户组权限"></asp:CheckBox>
            </td>
            <td style="width: 39px; ">
            </td>
            <td >
                <asp:Button ID="btnSavePotences" runat="server" Width="136px" Text="确定权限"
                    OnClick="btnSavePotences_Click"></asp:Button>
            </td>
        </tr>
        <tr>
            <td style="width: 373px">
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
    </table>
    <asp:Label ID="Label2" Style="z-index: 102; left: 16px; position: absolute; top: 16px"
        runat="server" Width="160px"  ForeColor="#000040">单用户、单组权限分配</asp:Label>
    <asp:Label ID="Label3" Style="z-index: 103; left: 200px; position: absolute; top: 16px"
        runat="server"   Width="688px">用户组权限分配包括用户权限分配、用户组的权限分配。分配方式可以有按组分配、按用户分配；3、按部门分配权限。</asp:Label>
    </form>
</body>
</html>
