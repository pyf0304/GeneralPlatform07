<%@ Register TagPrefix="uc1" TagName="wucQxUsers4SynchB" Src="wucQxUsers4SynchB.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvQxUsers4Synch4Gv" Src="wucvQxUsers4Synch4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmQxUsers4SynchB_QUDI.aspx.cs" Inherits="GeneralPlatform.Webform.wfmQxUsers4SynchB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>用户4同步维护的维护</title>
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
                <asp:Label ID="lblViewTitle" runat="server" CssClass="PageTitleH1" Height="16px">用户4同步维护
                </asp:Label>
                <asp:Label ID="lblMsg_List" runat="server" CssClass="ErrMsg" Height="16px" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="msgtable" style="width: 80%">
                    <tr>

                        <td>
                            <asp:Label ID="lblIpAddress_q" Style="z-index: 104;"
                                runat="server" CssClass="NameLabel">IP地址</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtIpAddress_q" Style="z-index: 105;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblUserId_q" Style="z-index: 107;"
                                runat="server" CssClass="NameLabel">用户ID</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlUserId_q" Style="z-index: 108;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblUserName_q" Style="z-index: 110;"
                                runat="server" CssClass="NameLabel">用户名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtUserName_q" Style="z-index: 111;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblDepartmentId_q" Style="z-index: 113;"
                                runat="server" CssClass="NameLabel">部门Id</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlDepartmentId_q" Style="z-index: 114;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblUserStateId_q" Style="z-index: 116;"
                                runat="server" CssClass="NameLabel">用户状态Id</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlUserStateId_q" Style="z-index: 117;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>


                        <td>
                            <asp:Label ID="lblIdentityID_q" Style="z-index: 119;"
                                runat="server" CssClass="NameLabel">身份编号</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIdentityID_q" Style="z-index: 120;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblIsAccessSynch_q" Style="z-index: 122;"
                                runat="server" CssClass="NameLabel">是否处理同步</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsAccessSynch_q" Style="z-index: 123;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblIsExistUserInCurr_q" Style="z-index: 125;"
                                runat="server" CssClass="NameLabel">当前是否存在用户</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsExistUserInCurr_q" Style="z-index: 126;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <asp:Label ID="lblIsSamePwd_q" Style="z-index: 128;"
                                runat="server" CssClass="NameLabel">是否相同密码</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsSamePwd_q" Style="z-index: 129;"
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                        <td>

                            <asp:Button ID="btnQuery"
                                Style="z-index: 131; width: 80px; height: 24px;"
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-info btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel4Gv" Style="z-index: 107;" CssClass="btn btn-outline-info btn-sm" Width="80px" OnClick="btnExportExcel4Gv_Click" Text="导出Excel" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 功能区 --%>

            <div id="divFunction" class="div_Funttion" runat="server">
                <table id="tabGridFunction" style="width: 100%; height: 32px;" class="msgtable">
                    <tr>
                        <td>
                            <asp:Label ID="lblQxUsers4SynchList" Style="z-index: 105;" CssClass="RegionTitleH1" Width="250px" Text="用户4同步列表" runat="server" />
                        </td>
                        <td>
                            <asp:Label ID="lblStatus4PreAccessData" Style="z-index: 105;" CssClass="ErrMsg" Text="" runat="server" />
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
                            <asp:Button ID="btnSetIsAccessed" Style="z-index: 107;" CssClass="btn btn-outline-info btn-sm" Width="80px"  Text="设置处理" runat="server" OnClick="btnSetIsAccessed_Click" />
                        </td>
                          <td>
                            <asp:Button ID="btnSetIsNotAccessed" Style="z-index: 107;" CssClass="btn btn-outline-info btn-sm" Width="90px"  Text="设置未处理" runat="server" OnClick="btnSetIsNotAccessed_Click" />
                        </td>
                         <td>
                            <asp:Button ID="btnAcceptData" Style="z-index: 107;" CssClass="btn btn-outline-info btn-sm" Width="90px"  Text="接受数据" runat="server" OnClick="btnAcceptData_Click" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List" runat="server">
                <uc2:wucvQxUsers4Synch4Gv runat="server" ID="wucvQxUsers4Synch4Gv1"
                    OnGvUpdateClick="wucvQxUsers4Synch4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucvQxUsers4Synch4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditQxUsers4SynchRegion" class="tab_Edit"
                runat="server">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditQxUsers4Synch" Style="z-index: 104;" runat="server"
                                    CssClass="RegionTitleH1">用户4同步编辑区域</asp:Label>
                                <asp:Label ID="lblMsg_Edit" Style="z-index: 105;" runat="server"
                                    Width="208px" Height="16px" CssClass="ErrMsg"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                    Width="80px" Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>

                                <asp:Button ID="btnCancelQxUsers4SynchEdit" Style="z-index: 107;"
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelQxUsers4SynchEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc1:wucQxUsers4SynchB ID="wucQxUsers4SynchB1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
