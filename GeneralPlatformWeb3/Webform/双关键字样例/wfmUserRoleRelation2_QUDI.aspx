<%@ Register TagPrefix="uc1" TagName="wucUserRoleRelation2" Src="wucUserRoleRelation2.ascx" %>

<%@ Page Language="c#" AutoEventWireup="true"
    Inherits="GeneralPlatform.Webform.wfmUserRoleRelation2_QUDI" Codebehind="wfmUserRoleRelation2_QUDI.aspx.cs" %>

<%@ Register Src="wucUserRoleRelation2GV.ascx" TagName="wucUserRoleRelation2GV" TagPrefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/tr/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>UserRoleRelation2的维护</title>
    <link rel="stylesheet" type="text/css" href="../../Webform/css/taishweb1.css" />
    <link href="../../Webform/css/taishweb1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <table id="tabLayout" style="z-index: 105; left: 0px; position: absolute; top: 0px"
            cellspacing="2" cellpadding="2" width="300" border="0" runat="server">
            <tr>
                <td>
                    <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                        <asp:Label ID="lblViewTitle" runat="server" CssClass="PageTitleH1" Height="16px">UserRoleRelation2表的维护
                        </asp:Label>
                        <asp:Label ID="lblMsg_List" runat="server" CssClass="ErrMsg" Height="16px" Style="z-index: 105;
                            left: 54px; position: relative; top: 4px" Width="347px"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div id="divUserRoleRelation2" style="position: relative; width: 600px; height: 70px">
                        <asp:Label ID="lblUserId_q" Style="z-index: 104; left: 10px; position: absolute;
                            top: 5px" runat="server" Width="70px" Height="16px" CssClass="NameLabel">用户ID</asp:Label>
                        <asp:TextBox ID="txtUserId_q" Style="z-index: 105; left: 85px; position: absolute;
                            top: 5px" runat="server" Width="70px"  CssClass="TextBox_Defa">
                        </asp:TextBox>
                        <asp:Label ID="lblRoleId_q" Style="z-index: 107; left: 260px; position: absolute;
                            top: 5px" runat="server" Width="70px" Height="16px" CssClass="NameLabel">角色Id</asp:Label>
                        <asp:TextBox ID="txtRoleId_q" Style="z-index: 108; left: 335px; position: absolute;
                            top: 5px" runat="server" Width="70px"  CssClass="TextBox_Defa">
                        </asp:TextBox>
                        <asp:Label ID="lblPrjId_q" Style="z-index: 110; left: 10px; position: absolute; top: 35px"
                            runat="server" Width="70px" Height="16px" CssClass="NameLabel">项目编号</asp:Label>
                        <asp:DropDownList ID="ddlPrjId_q" Style="z-index: 111; left: 85px; position: absolute;
                            top: 35px" runat="server" Width="70px"  CssClass="TextBox_Defa">
                        </asp:DropDownList>
                        <asp:Label ID="lblMemo_q" Style="z-index: 113; left: 260px; position: absolute; top: 35px"
                            runat="server" Width="70px" Height="16px" CssClass="NameLabel">备注</asp:Label>
                        <asp:TextBox ID="txtMemo_q" Style="z-index: 114; left: 335px; position: absolute;
                            top: 35px" runat="server" Width="70px"  CssClass="TextBox_Defa">
                        </asp:TextBox>
                        <asp:Button ID="btnQuery" Style="z-index: 116; left: 10px; position: relative; top: 65px"
                            runat="server" Width="80px" Height="24px" Text="查询" CssClass="Button_Defa" OnClick="btnQuery_Click">
                        </asp:Button>
                    </div>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabUserRoleRelation2GridView" style="width: 552px" runat="server">
                        <tr>
                            <td>
                                <div style="width: 750px; position: relative; height: 32px" id="divGridFunction">
                                    <asp:Label ID="lblUserRoleRelation2List" runat="server" Height="8px" Style="z-index: 105;
                                        left: 0px; position: relative; top: 0px" CssClass="RegionTitleH1">用户角色关系列表</asp:Label>
                                    <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" Style="z-index: 106;
                                        left: 390px; position: absolute; top: 4px" Width="80px" CssClass="Button_Defa"
                                        Text="添加记录"></asp:Button>
                                    <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click" Style="z-index: 104; left: 475px;
                                        position: absolute; top: 4px" runat="server" Width="80px" CssClass="Button_Defa"
                                        Text="删除记录"></asp:Button>
                                    <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" Style="z-index: 105; left: 560px;
                                        position: absolute; top: 4px" runat="server" Width="80px" CssClass="Button_Defa"
                                        Text="修改记录"></asp:Button>
                                    <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" Style="z-index: 107;
                                        left: 645px; position: absolute; top: 4px" runat="server" Width="80px" CssClass="Button_Defa"
                                        Text="导出Excel"></asp:Button>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;<uc2:wucUserRoleRelation2GV ID="wucUserRoleRelation2GV1" runat="server" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabEditUserRoleRelation2Region" style="z-index: 117; width: 750px" cellspacing="1"
                        cellpadding="1" width="750" border="1" runat="server">
                        <tr>
                            <td>
                                <div style="width: 730px; position: relative; height: 32px">
                                    <asp:Label ID="lblEditUserRoleRelation2" Style="z-index: 104; left: 0px; position: relative;
                                        top: 4px" runat="server" CssClass="RegionTitleH1" Height="8px">用户角色关系编辑区域</asp:Label>
                                    <asp:Label ID="lblMsg_Edit" Style="z-index: 105; left: 54px; position: relative;
                                        top: 8px" runat="server" Width="208px" Height="16px" CssClass="ErrMsg"></asp:Label>
                                    <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 68px; position: relative; top: 4px"
                                        runat="server" Width="80px" Text="添加" OnClick="btnOKUpd_Click" CssClass="Button_Defa">
                                    </asp:Button>
                                    <asp:Button ID="btnCancelUserRoleRelation2Edit" Style="z-index: 107; left: 90px;
                                        position: relative; top: 4px" runat="server" Width="100px" CssClass="Button_Defa"
                                        Text="取消编辑" OnClick="btnCancelUserRoleRelation2Edit_Click"></asp:Button>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc1:wucUserRoleRelation2 ID="wucUserRoleRelation21" runat="server"></uc1:wucUserRoleRelation2>
                            </td>
                        </tr>
                    </table>
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
