<%@ Page Language="c#" AutoEventWireup="true"
    Inherits="GeneralPlatform.Webform.wfmQxPrjMenus_EDITMenu" ValidateRequest="false" Codebehind="wfmQxPrjMenus_EDITMenu.aspx.cs"  Theme="TaiZeTheme" %>

<%@ Register TagPrefix="uc1" TagName="wucQxPrjMenus" Src="wucQxPrjMenus.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>工程菜单维护</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="Label2" Style="z-index: 100; left: 8px; position: absolute; top: 8px"
            runat="server" ForeColor="Blue" Font-Size="Medium">设置系统菜单</asp:Label>
        <table id="Table2" style="z-index: 104; left: 8px; width: 632px; position: absolute;
            top: 40px; height: 488px" cellspacing="2" cellpadding="2" width="632" border="0">
            <tr>
                <td style="width: 304px" valign="top" rowspan="2">
                    <table id="Table6" cellspacing="1" cellpadding="1" width="300" border="0">
                        <tr>
                            <td colspan="3" style="width: 318px">
                                <table id="Table1" cellspacing="0" cellpadding="0" width="304" border="0">
                                    <tr>
                                        <td>
                                            <asp:LinkButton ID="lbReNewOrderNum" runat="server"  
                                                OnClick="lbReNewOrderNum_Click">整理序号</asp:LinkButton></td>
                                        <td>
                                            <asp:LinkButton ID="lbAddUpMenu" runat="server"  
                                                OnClick="lbAddUpMenu_Click">添加顶层菜单</asp:LinkButton></td>
                                        <td>
                                            <asp:LinkButton ID="lbAddSubMenu" runat="server"  
                                                OnClick="lbAddSubMenu_Click">添加子菜单</asp:LinkButton></td>
                                        <td>
                                            <asp:LinkButton ID="lbDeleteMenu" runat="server"  
                                                OnClick="lbDeleteMenu_Click">删除菜单</asp:LinkButton></td>
                                        <td>
                                            <asp:LinkButton ID="lbUpdateMenu" runat="server"  
                                                OnClick="lbUpdateMenu_Click">修改菜单</asp:LinkButton></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" style="width: 318px">
                                <table id="Table7" cellspacing="1" cellpadding="1" width="300" border="0">
                                    <tr>
                                        <td>
                                            <asp:TreeView ID="tvQxPrjMenus" runat="server" Width="272px" Height="450px">
                                            </asp:TreeView>
                                        </td>
                                        <td>
                                            <table id="Table5" cellspacing="0" cellpadding="0" width="30" border="0">
                                                <tr>
                                                    <td>
                                                        <asp:ImageButton ID="ibUp" runat="server" Height="28px" Width="37px" ImageUrl="../../pic/Up.JPG"
                                                            OnClick="ibUp_Click"></asp:ImageButton></td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:Label ID="Label1" runat="server" Height="32px" Width="32px"></asp:Label></td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <asp:ImageButton ID="ibDown" runat="server" Height="28px" Width="37px" ImageUrl="../../pic/Down.JPG"
                                                            OnClick="ibDown_Click"></asp:ImageButton></td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" style="width: 318px">
                            </td>
                        </tr>
                    </table>
                </td>
                <td valign="top" rowspan="2">
                    <table id="Table4" cellspacing="0" cellpadding="0" width="300" border="0">
                        <tr>
                            <td>
                                <uc1:wucQxPrjMenus ID="wucQxPrjMenus1" runat="server"></uc1:wucQxPrjMenus>
                            </td>
                        </tr>
                        <tr>
                            <td align="center">
                                <asp:Button ID="btnOKUpd" runat="server" Width="83px" Height="22px" Text="添加" OnClick="btnOKUpd_Click">
                                </asp:Button></td>
                        </tr>
                        <tr>
                            <td>
                            </td>
                        </tr>
                    </table>
                </td>
                <td style="width: 3px" valign="top">
                </td>
            </tr>
            <tr>
                <td style="width: 3px">
                </td>
            </tr>
            <tr>
                <td style="width: 304px; height: 27px">
                    <asp:Label ID="lblMsg" runat="server" Width="256px" Height="27px" ForeColor="#C00000"
                         ></asp:Label></td>
                <td style="height: 27px">
                </td>
                <td style="width: 3px; height: 27px">
                </td>
            </tr>
        </table>
        <asp:Panel ID="Panel1" Style="z-index: 101; left: 917px; position: absolute; top: 40px"
            runat="server" Width="270px" Height="192px" Visible="False">
            <table id="Table3" style="width: 272px; height: 157px" cellspacing="1" cellpadding="1"
                width="272" border="1">
                <tr>
                    <td colspan="2">
                        <font color="#ff0099">有关树的相关知识点，暂且隐藏在此</font></td>
                </tr>
                <tr>
                    <td>
                        当前结点ID</td>
                    <td>
                        <input id="txtCurrNodeId" type="hidden" runat="server"></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button2" runat="server" Height="32px" Width="136px" Text="获取当前树的被选结点">
                        </asp:Button></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Height="32px" Width="128px" Text="设置当前树的结点">
                        </asp:Button></td>
                </tr>
            </table>
        </asp:Panel>
        <asp:DropDownList ID="ddlPrj" Style="z-index: 102; left: 135px; position: absolute;
            top: 8px" runat="server" AutoPostBack="True" Width="116px" OnSelectedIndexChanged="ddlPrj_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Label ID="lblMsg_tv" runat="server"  
            ForeColor="#C00000" Height="27px" Style="z-index: 105; left: 290px; position: absolute;
            top: 7px" Width="256px"></asp:Label>
    </form>
</body>
</html>
