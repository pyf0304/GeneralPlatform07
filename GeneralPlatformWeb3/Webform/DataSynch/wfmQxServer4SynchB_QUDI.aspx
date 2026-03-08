<%@ Register TagPrefix="uc1" TagName="wucQxServer4SynchB" Src="wucQxServer4SynchB.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucQxServer4Synch4Gv" Src="wucQxServer4Synch4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmQxServer4SynchB_QUDI.aspx.cs" Inherits="GeneralPlatform.Webform.wfmQxServer4SynchB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>同步服务器维护的维护</title>
                <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link rel="stylesheet" type="text/css" href="../../css/tz_base11.css" />
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="PageTitleH1" Height="16px">同步服务器维护
                </asp:Label>
                <asp:Label ID="lblMsg_List" runat="server" CssClass="ErrMsg" Height="16px" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 80%">
                    <tr>

                        <td>
                            <asp:Label ID="lblServerId_q" Style="z-index: 104;"
                                runat="server" CssClass="NameLabel">服务器Id</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtServerId_q" Style="z-index: 105;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblServerName_q" Style="z-index: 107;"
                                runat="server" CssClass="NameLabel">服务器名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtServerName_q" Style="z-index: 108;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblIpAddress_q" Style="z-index: 110;"
                                runat="server" CssClass="NameLabel">IP地址</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtIpAddress_q" Style="z-index: 111;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblInUse_q" Style="z-index: 113;"
                                runat="server" CssClass="NameLabel">是否在用</asp:Label>
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
                            <asp:Label ID="lblQxServer4SynchList" Style="z-index: 105;" CssClass="RegionTitleH1" Width="250px" Text="同步服务器列表" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnAddNewRec4Gv" Style="z-index: 107;" CssClass="btn btn-outline-info btn-sm" Width="80px" OnClick="btnAddNewRec4Gv_Click" Text="添加记录" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnDelete4Gv" Style="z-index: 107;" CssClass="btn btn-outline-info btn-sm" Width="80px" OnClick="btnDelete4Gv_Click" Text="删除记录" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnUpdate4Gv" Style="z-index: 107;" CssClass="btn btn-outline-info btn-sm" Width="80px" OnClick="btnUpdate4Gv_Click" Text="修改记录" runat="server" />
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel4Gv" Style="z-index: 107;" CssClass="btn btn-outline-info btn-sm" Width="80px" OnClick="btnExportExcel4Gv_Click" Text="导出Excel" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List" runat="server">
                <uc2:wucQxServer4Synch4Gv runat="server" ID="wucQxServer4Synch4Gv1"
                    OnGvUpdateClick="wucQxServer4Synch4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucQxServer4Synch4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditQxServer4SynchRegion" class="tab_Edit"
                runat="server">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditQxServer4Synch" Style="z-index: 104;" runat="server"
                                    CssClass="RegionTitleH1">同步服务器编辑区域</asp:Label>
                                <asp:Label ID="lblMsg_Edit" Style="z-index: 105;" runat="server"
                                    Width="208px" Height="16px" CssClass="ErrMsg"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                    Width="80px" Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>

                                <asp:Button ID="btnCancelQxServer4SynchEdit" Style="z-index: 107;"
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelQxServer4SynchEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc1:wucQxServer4SynchB ID="wucQxServer4SynchB1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
