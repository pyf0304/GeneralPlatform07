<%@ Control Language="c#" AutoEventWireup="True" Inherits="GeneralPlatform.Webform.wucQxPrjMenus"
    TargetSchema="http://schemas.microsoft.com/intellisense/ie5" CodeBehind="wucQxPrjMenus.ascx.cs" %>
        <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link href="../../css/tz_base11.css" rel="stylesheet" />
<style type="text/css">
    .style1 {
        width: 156px;
    }

    .style2 {
        height: 26px;
        width: 156px;
    }
</style>

<table id="tabwucQxPrjMenus" style="width: 513px; height: 200px; padding: 1px" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMenuId" runat="server"
                Width="66px">菜单ID</asp:Label></td>
        <td>
            <asp:TextBox ID="txtMenuId" runat="server"
                Width="550px"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMenuName" runat="server">菜单名</asp:Label></td>
        <td>
            <asp:TextBox ID="txtMenuName" runat="server"
                Width="550px"></asp:TextBox></td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjId" runat="server">工程</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlPrjId" runat="server"
                Width="550px">
            </asp:DropDownList></td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjId0" runat="server">菜单集</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlMenuSetId" runat="server"
                Width="550px" OnSelectedIndexChanged="ddlMenuSetId_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUpMenuId" runat="server">上级菜单</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlUpMenuId" runat="server"
                Width="550px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblLinkFile" runat="server">链接文件</asp:Label></td>
        <td style="height: 26px">
            <asp:TextBox ID="txtLinkFile" runat="server" Width="550px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="Label3" runat="server">qs参数</asp:Label></td>
        <td style="height: 26px">
            <asp:TextBox ID="txtqsParameters" runat="server" Width="550px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblImgFile" runat="server">图像文件</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtImgFile" runat="server" Width="550px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblOrderNum" runat="server">菜单序号</asp:Label></td>
        <td>
            <asp:TextBox ID="txtOrderNum" runat="server"
                Width="550px"></asp:TextBox></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="Label1" runat="server">叶子结点?</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlIsLeafNode" runat="server"
                Width="550px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="Label2" runat="server" Width="70px">显示方式</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlPageDispModeId" runat="server"
                Width="550px">
            </asp:DropDownList></td>
    </tr>
      <tr>
        <td class="NameTD">
            <asp:Label ID="Label4" runat="server" Width="70px">是否在用</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlInUse" runat="server" Width="550px">
            </asp:DropDownList></td>
    </tr>
</table>
