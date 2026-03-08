<%@ Register TagPrefix="uc1" TagName="wucUsers" Src="wucUsers.ascx" %>
<%@ Register TagPrefix="uc2" TagName="wucvQxUsers4Gv" Src="../UserManage/wucvQxUsers4Gv.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmUsers_QUDI2" CodeBehind="wfmUsers_QUDI2.aspx.cs"  %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>用户信息维护</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
    <link href="../../css/General.css" rel="stylesheet" />

    <style type="text/css">
        .style1 {
            width: 582px;
        }
    </style>
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <div style="width: 100%;">
            <div style="margin-bottom:10px">
                <ul class="UlBanner">
                    <li></li>
                    <li>
                        <asp:Label ID="lblViewTitle" runat="server" Height="22px" CssClass="PageTitleH1"
                            Width="204px">用户管理->用户信息维护</asp:Label>
                    </li>
                    <li>
                        <asp:Label ID="lblUserId_q" runat="server" 
                            Width="48px" CssClass="NameLabel">用户ID</asp:Label>
                    </li>
                    <li>
                        <asp:TextBox ID="txtUserId_q" runat="server" Width="80px"></asp:TextBox>
                    </li>
                    <li>
                        <asp:Label ID="lblUserName_q" runat="server" 
                            Width="45px" CssClass="NameLabel">用户名</asp:Label>
                    </li>
                    <li>
                        <asp:TextBox ID="txtUserName_q" runat="server" Width="80px"></asp:TextBox>
                    </li>

                    <li>
                        <asp:Label ID="lblPrjId_q" runat="server" 
                            Width="31px" CssClass="NameLabel">工程</asp:Label>
                    </li>
                    <li>
                        <asp:DropDownList ID="ddlPrjId_q" runat="server" Width="80px">
                        </asp:DropDownList>
                    </li>
                    <li>
                        <asp:Label ID="Label1" runat="server" 
                            Width="58px" CssClass="NameLabel">用户状态</asp:Label>
                    </li>
                    <li>
                        <asp:DropDownList ID="ddlUserStateId" runat="server" Width="80px">
                        </asp:DropDownList>
                    </li>
                    <li>
                        <asp:Button ID="btnQuery" runat="server" 
                            OnClick="btnQuery_Click" Text="查询" Width="66px" CssClass="btn btn-outline-info btn-sm" />
                    </li>
                    <li>
                        <asp:Button ID="btnExportExcel4Dg" Style="z-index: 107;" runat="server"
                            Width="101px" Text="导出Excel" OnClick="btnExportExcel4Dg_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                    </li>
                     <li>
                                    <asp:Button ID="btnDataSynToLocalDataBase" Style="z-index: 106;" runat="server" Width="176px"
                                        Text="同步用户到本地数据库" OnClick="btnDataSynToLocalDataBase_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                </li>
                </ul>


            </div>


            <div id="tabLayout" cellspacing="2" cellpadding="2" width="100%" border="0" runat="server">
                <div>

                    <div style="width: 20%; vertical-align: top; float:left">
                        <asp:TreeView ID="tvDepartments" runat="server" CssClass="LinkButton_Defa" OnSelectedNodeChanged="tvDepartments_SelectedNodeChanged">
                            <SelectedNodeStyle BackColor="#E0E0E0" />
                        </asp:TreeView>
                    </div>
                    <div style="vertical-align: top; width:78%; float:right">

                        <div style="width: 100%">

                            <ul class="UlBanner">

                                <li>
                                    <asp:Label ID="lblUsersList" Style="z-index: 105;" runat="server" CssClass="RegionTitleH1"
                                        Width="242px">用户信息列表</asp:Label>
                                </li>
                               
                                <li></li>
                                <li>
                                    <asp:Button ID="btnAddNewRec4Dg" Style="z-index: 106;" runat="server" Width="50px"
                                        Text="添加" OnClick="btnAddNewRec4Dg_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                </li>
                                <li>
                                    <asp:Button ID="btnDelete4Dg" Style="z-index: 104;" runat="server"
                                        Width="50px" Text="删除" OnClick="btnDelete4Dg_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                </li>
                                <li>
                                    <asp:Button ID="btnUpdate4Dg" Style="z-index: 105;" runat="server"
                                        Width="50px" Text="修改" OnClick="btnUpdate4Dg_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                </li>
                                <li>                                    
                                     <asp:DropDownList ID="ddlServerId" runat="server" Width="80px">
                        </asp:DropDownList>
                                </li>
                                <li><asp:Button ID="btnSynchTo" Style="z-index: 105;" runat="server"
                                        Width="80px" Text="同步到" OnClick="btnSynchTo_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                       
                <asp:Label ID="lblMsg_List" runat="server" CssClass="ErrMsg" Height="16px" Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
                       
                                </li>
                               
                            </ul>

                        </div>

                                             <%-- 列表层 --%>
            <div id="divList" class="div_List" runat="server">
                <uc2:wucvQxUsers4Gv runat="server" id="wucvQxUsers4Gv1"
                    OnGvUpdateClick="wucvQxUsers4Gv1_GvUpdateClick"
                    OnGvDeleteClick="wucvQxUsers4Gv1_GvDeleteClick" />
            </div>
                        <div style="width:100%">
       
                           
                            <div id="tabEditUsersRegion" style="vertical-align: top; width: 100%; height: 200px; margin-top:10px"                                runat="server">
                                <div style="width: 691px; position: relative; height: 32px">
                                    <ul class="UlBanner">
                                        <li>
                                            <asp:Label ID="lblEditUsers" Style="z-index: 104; margin-right: 150px" runat="server" CssClass="RegionTitleH1">用户信息编辑区域</asp:Label>
                                        </li>
                                        
                                        <li>
                                            <asp:Button ID="btnOKUpd" Style="z-index: 106;" runat="server" Width="80px"
                                                Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button></li>
                                        <li>
                                            <asp:LinkButton ID="lbDispUsersList" Style="z-index: 107;" CssClass="LinkButton_Defa" runat="server" Width="131px"
                                                OnClick="lbDispUsersList_Click">显示用户信息列表</asp:LinkButton></li>
                                        <li></li><li>
                                            <asp:Label ID="lblMsg" Style="z-index: 105;" runat="server" Width="208px"
                                                CssClass="ErrMsg"></asp:Label></li>
                                    </ul>
                                  
                               
                                </div>

                                <div>
                                    <uc1:wucUsers ID="wucUsers1" runat="server"></uc1:wucUsers>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>

      
            </div>

        </div>


        <asp:HiddenField ID="hidUserId" runat="server" />
    </form>
</body>
</html>
