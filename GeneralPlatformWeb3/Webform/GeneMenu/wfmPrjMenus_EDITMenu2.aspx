<%@ Page Language="c#" AutoEventWireup="true"
    Inherits="GeneralPlatform.Webform.wfmQxPrjMenus_EDITMenu2" ValidateRequest="false" Codebehind="wfmQxPrjMenus_EDITMenu2.aspx.cs"  Theme="TaiZeTheme" %>

<%@ Register TagPrefix="uc1" TagName="wucQxPrjMenus" Src="wucQxPrjMenus.ascx" %>
<%@ Register Src="~/tzTreeViewWuc/wucTreeView.ascx" TagPrefix="uc1" TagName="wucTreeView" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>工程菜单维护2</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
   
    <link href="../../tzTreeViewWuc/cssTreeView.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 424px;
        }
        .auto-style2 {
            height: 27px;
            width: 424px;
        }
    </style>
</head>
<body>
    <form id="Form1" method="post" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>
                <asp:Label ID="Label2" Style="z-index: 100;" runat="server" ForeColor="Blue" Font-Size="Medium">设置系统菜单</asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlPrj" Style="z-index: 102;" runat="server" AutoPostBack="True"
                    Width="116px" OnSelectedIndexChanged="ddlPrj_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" Width="42px" CssClass="Label_Defa">菜单集</asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlPrjMenuSet" Style="z-index: 102;" runat="server" AutoPostBack="True"
                    Width="116px" onselectedindexchanged="ddlPrjMenuSet_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;<asp:Label ID="lblMsg_tv" runat="server"  
                    ForeColor="#C00000" Height="27px" Style="z-index: 105;" Width="256px"></asp:Label>
                &nbsp;
            </td>
            <td>
                                        <asp:LinkButton ID="lbImportExcel4QxPrjMenus" runat="server" CssClass="LinkButton_Defa" 
                                            OnClick="lbImportExcel4QxPrjMenus_Click">通过Excel导入菜单</asp:LinkButton>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
    <table id="Table2" style="z-index: 104; left: 8px; width: 100%; position: absolute; top: 40px; height: 488px" cellspacing="2" cellpadding="2" width="632" border="0">
        <tr>
            <td valign="top" rowspan="2" class="auto-style1">
                <table id="Table6" cellspacing="1" cellpadding="1" width="400" border="0">
                    <tr>
                        <td style="width: 398px">
                            <table id="Table1" cellspacing="0" cellpadding="0" width="390" border="0">
                                <tr>
                                    <td>
                                        <asp:LinkButton ID="lbReNewOrderNum" runat="server" CssClass="LinkButton_Defa" 
                                            OnClick="lbReNewOrderNum_Click">整理序号</asp:LinkButton>
                                    </td>
                                    <td>
                                        <asp:LinkButton ID="lbAddUpMenu" runat="server" CssClass="LinkButton_Defa" 
                                            OnClick="lbAddUpMenu_Click">添加顶</asp:LinkButton>
                                    </td>
                                    <td>
                                        <asp:LinkButton ID="lbAddSubMenu" runat="server" CssClass="LinkButton_Defa" 
                                            OnClick="lbAddSubMenu_Click">添加子</asp:LinkButton>
                                    </td>
                                    <td>
                                        <asp:LinkButton ID="lbDeleteMenu" runat="server" CssClass="LinkButton_Defa" 
                                            OnClick="lbDeleteMenu_Click">删除</asp:LinkButton>
                                    </td>
                                    <td>
                                        <asp:LinkButton ID="lbUpdateMenu" runat="server" CssClass="LinkButton_Defa" 
                                            OnClick="lbUpdateMenu_Click">修改</asp:LinkButton>
                                    </td>
                                     <td>
                                        <asp:LinkButton ID="lbCopyMenu" runat="server" CssClass="LinkButton_Defa" 
                                            OnClick="lbCopyMenu_Click">复制</asp:LinkButton>
                                    </td>
                                     <td>
                                        <asp:LinkButton ID="lbReference" runat="server" CssClass="LinkButton_Defa" 
                                            OnClick="lbReference_Click">参考</asp:LinkButton>
                                    </td>
                                      <td>
                                        <asp:LinkButton ID="lbSetInUse" runat="server" CssClass="LinkButton_Defa" 
                                            OnClick="lbSetInUse_Click">设置在用</asp:LinkButton>
                                    </td>
                                    <td>
                                        <asp:LinkButton ID="lbCollapse" runat="server" CssClass="LinkButton_Defa" OnClick="lbCollapse_Click">收起</asp:LinkButton>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td  style="width: 398px">
                            <table id="Table7" cellspacing="1" cellpadding="1" width="398" border="0">
                                <tr>
                                    <td>
                                      <%--  <asp:TreeView ID="tvQxPrjMenus" runat="server" Width="372px" Height="450px" OnSelectedNodeChanged="tvQxPrjMenus_SelectedNodeChanged">
                                            <SelectedNodeStyle BackColor="#8080FF" />
                                        </asp:TreeView>--%>
                                        <uc1:wucTreeView runat="server" ID="wucTV_PrjMenu"  OnafterSelect_Tz="wucTV_PrjMenu_afterSelect_Tz"  />
                                    </td>
                                    <td>
                                        <table id="Table5" cellspacing="0" cellpadding="0" width="20" border="0">
                                            <tr>
                                                <td>
                                                    <asp:ImageButton ID="ibUp" runat="server" Height="28px" Width="37px" ImageUrl="../../pic/Up.JPG"
                                                        OnClick="ibUp_Click"></asp:ImageButton>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="Label1" runat="server" Height="32px" Width="22px"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:ImageButton ID="ibDown" runat="server" Height="28px" Width="37px" ImageUrl="../../pic/Down.JPG"
                                                        OnClick="ibDown_Click"></asp:ImageButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td  style="width: 398px">
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
                            <asp:Button ID="btnOKUpd" runat="server" CssClass="btn btn-outline-info btn-sm"  Text="添加" OnClick="btnOKUpd_Click">
                            </asp:Button>
                            <asp:Label ID="lblMsg" runat="server"   ForeColor="#C00000"
                                Height="27px" Width="256px"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                                    <asp:Label ID="lblRefRegion" runat="server"  CssClass="Region_Title1" >参考区域</asp:Label>
                                          
                        </td>
                    </tr>
                     <tr>
                        <td>
                            <uc1:wucQxPrjMenus ID="wucQxPrjMenus4Ref" runat="server"></uc1:wucQxPrjMenus>
                        </td>
                    </tr>
                      <tr>
                        <td align="center">
                            <asp:Button ID="lbHideRef" runat="server" CssClass="btn btn-outline-info btn-sm"  Text="隐藏参考" OnClick="lbHideRef_Click">
                            </asp:Button>
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
            <td class="auto-style2">
                <asp:Label ID="lblMsg4Tree" runat="server" Width="256px" Height="27px" ForeColor="#C00000"
                     ></asp:Label>
            </td>
            <td style="height: 27px">
                &nbsp;</td>
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
                    <asp:Label ID="Label4" runat="server" Width="256px" Height="27px" ForeColor="#C00000"
                         >有关树的相关知识点，暂且隐藏在此</asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    当前结点ID
                </td>
                <td>
                    <input id="txtCurrNodeId" type="hidden" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button2" runat="server" Height="32px" Width="136px" Text="获取当前树的被选结点">
                    </asp:Button>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" Height="32px" Width="128px" Text="设置当前树的结点">
                    </asp:Button>
                </td>
            </tr>
        </table>
    </asp:Panel>
    </form>
</body>
</html>
