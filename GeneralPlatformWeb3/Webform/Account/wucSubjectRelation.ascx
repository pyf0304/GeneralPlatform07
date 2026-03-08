<%@ Control Language="C#" AutoEventWireup="true"
    Inherits="GeneralPlatform.Webform.wucSubjectRelation" Codebehind="wucSubjectRelation.ascx.cs" %>
        <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link href="../../css/tz_base11.css" rel="stylesheet" />
<table id="tabwucSubjectRelation" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUserId" runat="server" CssClass="NameControl">用户ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlUserId" runat="server" CssClass="ValueControl" 
                Width="424px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblLeaderId" runat="server" CssClass="NameControl">领导Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlLeaderId" runat="server" CssClass="ValueControl" 
                Width="424px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsDirectLeader" runat="server" Text="是否直接领导" CssClass="Check_Defa">
            </asp:CheckBox>
        </td>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="NameControl">备注</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" CssClass="ValueControl" Height="64px" 
                TextMode="MultiLine" Width="427px"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
</table>
