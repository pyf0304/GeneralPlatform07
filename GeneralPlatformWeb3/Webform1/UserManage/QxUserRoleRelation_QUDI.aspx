<%@ Register TagPrefix="uc1" TagName="QxUserRoleRelation" Src="QxUserRoleRelation.ascx" %>
<%@ Register TagPrefix="uc2" TagName="QxUserRoleRelation4Gv" Src="QxUserRoleRelation4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="true" CodeBehind="QxUserRoleRelation_QUDI.aspx.cs" Inherits="GeneralPlatform.Webform.QxUserRoleRelation_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>用户角色关系维护的维护</title>
    <script type="text/javascript" src="../../Scripts/jquery-3.3.1.min.js"></script>
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../JS/tzPubFun.js"></script>
</head>
<body>
    <form id="form1" runat="server" class="form-horizontal">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="col-form-label text-info">用户角色关系维护
                </asp:Label>
                <asp:Label ID="lblMsg_List" runat="server" CssClass="text-danger" Style="left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" style="margin: 10px;">
                <table id="tabEdit" style="width: 70%" class="table table-bordered table-hover table td table-sm">
                    <tr>
                        <td class="text-left">
                            <asp:Label ID="lblUserId_q" name="lblUserId_q" CssClass="col-form-label text-right" Width="90px" Text="用户ID" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlUserId_q" name="ddlUserId_q" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Label ID="lblRoleId_q" name="lblRoleId_q" CssClass="col-form-label text-right" Width="90px" Text="角色Id" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:DropDownList ID="ddlRoleId_q" name="ddlRoleId_q" CssClass="form-control" Width="200px" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Button ID="btnQuery" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnQuery_Click" Text="查询" runat="server" />
                        </td>
                        <td class="text-left">
                            <asp:Button ID="btnExportExcel" CssClass="btn btn-outline-warning text-nowrap" OnClick="btnExportExcel_Click" Text="导出Excel" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 功能区 --%>

            <div id="divFunction" class="table table-bordered table-hover">
                <ul class="nav">
                    <li class="nav-item">
                        <asp:Label ID="lblQxUserRoleRelationList" name="lblQxUserRoleRelationList" CssClass="col-form-label text-info" Width="250px" Text="用户角色关系列表" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnAddNewRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnAddNewRecord_Click" Text="添加" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnUpdateRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnUpdateRecord_Click" Text="修改" runat="server" />
                    </li>
                    <li class="nav-item ml-3">
                        <asp:Button ID="btnDelRecord" CssClass="btn btn-outline-info btn-sm text-nowrap" OnClick="btnDelRecord_Click" Text="删除" runat="server" />
                    </li>
                </ul>
            </div>
            <%-- 列表层 --%>
            <div id="divList" class="div_List mt-2" runat="server">
                <uc2:QxUserRoleRelation4Gv runat="server" ID="QxUserRoleRelation4Gv1"
                    OnGvUpdateClick="QxUserRoleRelation4Gv1_GvUpdateClick"
                    OnGvDeleteClick="QxUserRoleRelation4Gv1_GvDeleteClick" />
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditQxUserRoleRelationRegion" class="tab_Edit mt-2"
                runat="server">
                <div style="width: 60%;">
                    <ul class="nav">
                        <li class="nav-item">
                            <asp:Label ID="lblEditQxUserRoleRelation" Style="z-index: 104;" Width="200px" runat="server"
                                CssClass="col-form-label text-info">用户角色关系编辑区域</asp:Label>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server"
                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Button ID="btnCancelQxUserRoleRelationEdit"
                                runat="server" CssClass="btn btn-outline-info" Text="取消编辑" OnClick="btnCancelQxUserRoleRelationEdit_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-3">
                            <asp:Label ID="lblMsg_Edit" runat="server"
                                Width="420px" CssClass="col-form-label text-danger"></asp:Label>
                        </li>
                    </ul>
                </div>
                <div>
                    <uc1:QxUserRoleRelation id="QxUserRoleRelation1" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
