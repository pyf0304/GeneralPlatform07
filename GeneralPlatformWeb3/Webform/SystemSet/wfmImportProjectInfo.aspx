<%@ Page Language="c#" AutoEventWireup="true"
    Inherits="GeneralPlatform.Webform.wfmImportViewInfoFromSQL2" CodeBehind="wfmImportProjectInfo.aspx.cs"  Theme="TaiZeTheme" %>

<%@ Register Src="wucDataBaseConnect.ascx" TagName="wucDataBaseConnect" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>同步项目信息</title>
                <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
    <style type="text/css">
        .style1 {
            width: 352px;
        }
    </style>
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <table style="width: 100%; height: 222px;">
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label4" Style="z-index: 124;" runat="server" Width="272px" CssClass="PageTitleH1">表字段管理-&gt;导入工程信息</asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label5" Style="z-index: 124;" runat="server" Width="272px"
                        CssClass="RegionTitleH2">请填写源项目所在数据库的相关信息</asp:Label>
                </td>
                <td></td>
            </tr>
            <tr>
                <td colspan="2">

                    <uc1:wucDataBaseConnect ID="wucDataBaseConnect1" runat="server" />

                </td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnGetProjectInfo" Style="z-index: 134;" runat="server" Text="获取工程"
                        OnClick="btnGetProjectInfo_Click"></asp:Button>
                </td>
                <td class="style1"></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblTable" Style="z-index: 109;" runat="server" Font-Names="新宋体" Width="128px"
                        Height="12px" CssClass="RegionTitleH3">请选择工程名：</asp:Label>
                </td>
                <td class="style1">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList ID="ddlProjects" Style="z-index: 108;" runat="server" Font-Names="新宋体"
                                Width="328px" AutoPostBack="True">
                            </asp:DropDownList>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="btnGetProjectInfo" EventName="Click" />
                        </Triggers>
                    </asp:UpdatePanel>
                </td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td class="style1">
                    <asp:Button ID="btnImport" Style="z-index: 134;" runat="server" Text="确认导入"
                        OnClick="btnImport_Click"></asp:Button>
                </td>
                <td>
                    <asp:Label ID="lblMsgForOK" Style="z-index: 112;" runat="server" Width="330px" Height="21px"
                        CssClass="ErrMsg"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
