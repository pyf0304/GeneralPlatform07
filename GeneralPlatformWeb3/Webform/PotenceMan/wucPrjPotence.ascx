<%@ Control Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wucPrjPotence" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" Codebehind="wucPrjPotence.ascx.cs" %>
        <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link href="../../css/tz_base11.css" rel="stylesheet" />
<style type="text/css">
    .auto-style1 {
        width: 15%;
        text-align: right;
        height: 29px;
    }
    .auto-style2 {
        width: 85%;
        height: 29px;
    }
</style>
<table id="tabwucPrjPotence" cellspacing="1" cellpadding="1" width="568" border="0"
    style="width: 568px; height: 186px">
   
    <tr>
        <td class="auto-style1">
            <asp:Label ID="lblPrjId" runat="server"  
                CssClass="NameControl" Width="60px">项目</asp:Label>
        </td>
        <td class="auto-style2">
            <asp:DropDownList ID="ddlPrjId" runat="server"  
                CssClass="ValueControl" Width="199px" OnSelectedIndexChanged="ddlPrjId_SelectedIndexChanged"
                AutoPostBack="True">
            </asp:DropDownList>
        </td>
        <td class="auto-style1">
            <asp:Label ID="lblPotenceTypeId" runat="server"  
                CssClass="NameControl">权限类型</asp:Label>
        </td>
        <td class="auto-style2">
            <asp:DropDownList ID="ddlPotenceTypeId" runat="server"  
                CssClass="ValueControl" Width="196px" OnSelectedIndexChanged="ddlPotenceTypeId_SelectedIndexChanged"
                AutoPostBack="True">
            </asp:DropDownList></td>
    </tr>
     <tr>
        <td class="NameTD">
            <asp:Label ID="lblPotenceId" runat="server"  
                CssClass="NameControl">权限ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPotenceId" runat="server"  
                CssClass="ValueControl" Width="200px"></asp:TextBox>
        </td>
        <td class="NameTD">
            <font face="宋体">
                <asp:Label ID="lblPotenceName" runat="server"  
                    CssClass="NameControl" Width="60px">权限名称</asp:Label></font>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPotenceName" runat="server"  
                CssClass="ValueControl" Width="192px"></asp:TextBox></td>
    </tr>
     <tr>
         <td class="NameTD">
            <asp:Label ID="Label1" runat="server"  
                CssClass="NameControl">页面菜单</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:DropDownList ID="ddlMenuId" runat="server"  
                CssClass="ValueControl" Width="488px" OnSelectedIndexChanged="ddlPotenceTypeId_SelectedIndexChanged"
                AutoPostBack="True" Height="21px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server"   CssClass="NameControl">备注</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <font face="宋体">
                <asp:TextBox ID="txtMemo" runat="server"  
                    CssClass="ValueControl" Width="487px" Height="128px" TextMode="MultiLine"></asp:TextBox></font>
        </td>
    </tr>
</table>
<input id="hidOperateMode" runat="server" type="hidden" />
