<%@ Register TagPrefix="uc2" TagName="wucvQxFuncModule_Agc4Gv" Src="wucvQxFuncModule_Agc4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="true" CodeBehind="wfmQxFuncModule_Agc_QUDI.aspx.cs" Inherits="GeneralPlatform.Webform.wfmQxFuncModule_Agc_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>功能模块维护的维护</title>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js"></script>
    <script src="../../Scripts/bootstrap.js"></script>
    <link rel="stylesheet" type="text/css" href="../../css/tz_base11.css" />
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="PageTitleH1" Height="16px">功能模块维护
                </asp:Label>
                <asp:Label ID="lblMsg_List" runat="server" CssClass="ErrMsg" Height="16px" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 80%">
                    <tr>

                        <td>
                            <asp:Label ID="lblFuncModuleName_q" Style="z-index: 104;"
                                runat="server" CssClass="NameLabel">模块名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFuncModuleName_q" Style="z-index: 105;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblFuncModuleName_Sim_q" Style="z-index: 107;"
                                runat="server" CssClass="NameLabel">模块名_Sim</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFuncModuleName_Sim_q" Style="z-index: 108;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblQxPrjId_q" Style="z-index: 110;"
                                runat="server" CssClass="NameLabel">项目</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlQxPrjId_q" Style="z-index: 111;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblInUse_q" Style="z-index: 113;"
                                runat="server" CssClass="NameLabel">在用?</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlInUse_q" Style="z-index: 114;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>

                            <asp:Button ID="btnQuery"
                                Style="z-index: 116; width: 80px; height: 24px;"
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-info btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 功能区 --%>

            <div id="divFunction" class="div_Funttion" runat="server">
                <table id="tabGridFunction" style="width: 100%; height: 32px;" class="msgtable">
                    <tr>
                        <td>
                            <asp:Label ID="lblQxFuncModule_AgcList" Style="z-index: 105;" CssClass="RegionTitleH1" Width="250px" Text="功能模块列表" runat="server" />
                        </td>
                       
                        <td>
                            <asp:Button ID="btnSynchFuncModule" OnClick="btnSynchFuncModule_Click" runat="server" Text="同步工程模块" class="btn btn-outline-info btn-sm"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnGoTop" Style="z-index: 107;" CssClass="btn btn-outline-info btn-sm" Width="48px" OnClick="btnGoTop_Click" Text="移顶" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnUpMove" Style="z-index: 107;" CssClass="btn btn-outline-info btn-sm" Width="48px" OnClick="btnUpMove_Click" Text="上移" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnDownMove" Style="z-index: 107;" CssClass="btn btn-outline-info btn-sm" Width="48px" OnClick="btnDownMove_Click" Text="下移" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnGoBottum" Style="z-index: 107;" CssClass="btn btn-outline-info btn-sm" Width="48px" OnClick="btnGoBottum_Click" Text="移底" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnReOrder" Style="z-index: 107;" CssClass="btn btn-outline-info btn-sm" Width="48px" OnClick="btnReOrder_Click" Text="重序" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel4Gv" Style="z-index: 107;" CssClass="btn btn-outline-info btn-sm" Width="80px" OnClick="btnExportExcel4Gv_Click" Text="导出Excel" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List" runat="server">
                <uc2:wucvQxFuncModule_Agc4Gv runat="server" ID="wucvQxFuncModule_Agc4Gv1" />
            </div>
          
        </div>
    </form>
</body>
</html>
