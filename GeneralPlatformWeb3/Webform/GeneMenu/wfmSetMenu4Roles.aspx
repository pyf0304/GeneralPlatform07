<%@ Page Language="c#" AutoEventWireup="false"
    Inherits="GeneralPlatform.Webform.wfmSetMenu4Roles" Codebehind="wfmSetMenu4Roles.aspx.cs"  Theme="TaiZeTheme" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>wfmSetMenu4Roles</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
<script language="javascript" type="text/javascript" >
function postBackByObject()
{
   var o = window.event.srcElement;
   if (o.tagName == "INPUT" && o.type == "checkbox")
   {
      __doPostBack("","");
   } 
} 
</script>
</head>

<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="Label4" Style="z-index: 108; left: 312px; position: absolute; top: 8px"
            runat="server" Width="42px" ForeColor="#004040"  Font-Bold="True"
             >说明：</asp:Label>
        <asp:DropDownList ID="ddlPrj" Style="z-index: 110; left: 136px; position: absolute;
            top: 8px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPrj_SelectedIndexChanged"
            Width="123px">
        </asp:DropDownList>
        <asp:Label ID="Label3" Style="z-index: 107; left: 360px; position: absolute; top: 8px"
            runat="server" Width="440px" ForeColor="#004040"  Height="32px"
            >在系统中，为了安全和方便使用，各种不同的角色对象所显示的菜单是不一样，在这个界面中主要用来为不同的设置不同的菜单。</asp:Label>
        <asp:Label ID="Label2" Style="z-index: 106; left: 16px; position: absolute; top: 8px"
            runat="server" Font-Size="Medium" ForeColor="Blue">设置角色菜单</asp:Label>
        <table id="Table1" style="z-index: 109; left: 16px; width: 712px; position: absolute;
            top: 40px; height: 132px" cellspacing="1" cellpadding="1" width="712" border="0">
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Width="144px" Text="显示所选角色现有菜单" OnClick="Button1_Click"></asp:Button></td>
                <td>
                    <asp:Button ID="btnSaveMenues" runat="server" Width="80px" Text="确定菜单" 
                        onclick="btnSaveMenues_Click"></asp:Button>
                        </td>

                         <td>
                <asp:Label ID="Label5" runat="server" Width="42px" CssClass="Label_Defa">菜单集</asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlPrjMenuSet" Style="z-index: 102;" runat="server" AutoPostBack="True"
                    Width="116px" onselectedindexchanged="ddlPrjMenuSet_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                        <asp:Label
                        ID="Label1" runat="server" Width="267px"></asp:Label></td>
                <td>
                </td>
            </tr>
            <tr>
                <td valign="top">
                    <asp:TreeView ID="tvRoles" runat="server" ExpandLevel="3" Width="288px" OnSelectedNodeChanged="tvRoles_SelectedNodeChanged">
                        <SelectedNodeStyle BackColor="#8080FF" />
                    </asp:TreeView>
                </td>
                <td valign="top" colspan="4">
                    <asp:TreeView ID="tvQxPrjMenus" runat="server" ExpandLevel="2" >
                        <SelectedNodeStyle BackColor="#C0C0FF" />
                    </asp:TreeView>
                </td>
                <td valign="top">
                    <font face="宋体"></font>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
                 <td>
                </td>
                 <td>
                </td>
                 <td>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
