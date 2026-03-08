<%@ Register TagPrefix="uc1" TagName="wucDepartmentInfo" Src="wucDepartmentInfo.ascx" %>

<%@ Page Language="c#" AutoEventWireup="false"
    Inherits="GeneralPlatform.Webform.wfmDepartmentInfo_QUDIBak" Codebehind="wfmDepartmentInfo_QUDIBak.aspx.cs"  Theme="TaiZeTheme" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>表QxDepartmentInfo的查询、修改、删除、添加记录</title>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
    <link href="../../css/tz_base11.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <img style="z-index: 105; left: 8px; width: 816px; position: absolute; top: 8px;
            height: 30px" height="30" alt="" src="/RSKH/pic/兰色标题.gif" width="816">
        <div style="display: inline; z-index: 106; left: 16px; width: 300px;
            color: #000066; position: absolute; top: 16px; height: 15px">
            <strong>系统参数设置&gt;&gt;部门信息维护</strong>&nbsp;
        </div>
        <div id="divDepartmentInfo" style="z-index: 119; left: 8px; width: 821px; position: absolute;
            top: 35px; height: 56px" runat="server">
            <asp:Label ID="lblDepartmentId_q" Style="z-index: 104; left: 16px; position: absolute;
                top: 8px" runat="server" Width="48px"   >
  部门ID</asp:Label>
            <asp:TextBox ID="txtDepartmentId_q" Style="z-index: 105; left: 64px; position: absolute;
                top: 0px" runat="server" Width="140px" ></asp:TextBox>
            <asp:Label ID="lblUpDepartmentId_q" Style="z-index: 107; left: 232px; position: absolute;
                top: 40px" runat="server" Width="70px"   >
  所属部门号</asp:Label>
            <asp:DropDownList ID="ddlUpDepartmentId_q" Style="z-index: 108; left: 312px; position: absolute;
                top: 32px" runat="server" Width="140px" >
            </asp:DropDownList>
            <asp:Label ID="lblDepartmentType_q" Style="z-index: 110; left: 504px; position: absolute;
                top: 40px" runat="server" Width="32px"   >
  类型</asp:Label>
            <asp:TextBox ID="txtDepartmentType_q" Style="z-index: 111; left: 536px; position: absolute;
                top: 32px" runat="server" Width="140px" ></asp:TextBox>
            <asp:Label ID="lblDepartmentName_q" Style="z-index: 113; left: 8px; position: absolute;
                top: 32px" runat="server" Width="56px"   >
  部门名称</asp:Label>
            <asp:TextBox ID="txtDepartmentName_q" Style="z-index: 114; left: 64px; position: absolute;
                top: 32px" runat="server" Width="140px" ></asp:TextBox>
            <asp:Label ID="lblDepartMentId4Card_q" Style="z-index: 116; left: 216px; position: absolute;
                top: 8px" runat="server" Width="80px"   >
  一卡通部门ID</asp:Label>
            <asp:TextBox ID="txtDepartMentId4Card_q" Style="z-index: 117; left: 312px; position: absolute;
                top: 0px" runat="server" Width="140px" ></asp:TextBox>
            <asp:Label ID="lblSubjectTypeId_q" Style="z-index: 124; left: 480px; position: absolute;
                top: 8px" runat="server" Width="70px"   >  学科类型</asp:Label>
            <asp:DropDownList ID="ddlSubjectTypeId_q" Style="z-index: 125; left: 536px; position: absolute;
                top: 0px" runat="server" Width="140px" >
            </asp:DropDownList>
            <asp:Button ID="btnQuery" Style="z-index: 127; left: 720px; position: absolute; top: 24px"
                runat="server" Width="80px"   
                Text="查询"></asp:Button>
        </div>
        <table id="tabDepartmentInfoDataGrid" style="z-index: 225; left: 8px;
            width: 552px; position: absolute; top: 96px; height: 350px" cellspacing="0" cellpadding="0"
            width="552" border="0" runat="server">
            <tr>
                <td>
                    <div style="display: inline; width: 801px; position: relative; height: 32px">
                        <asp:Label ID="lblPostExamProcessOrderList" Style="z-index: 101; left: 8px; position: absolute;
                            top: 4px" runat="server"  CssClass="RegionTitleH1">岗位考核过程排序列表</asp:Label>
                        <asp:Button ID="btnExportExcel4Dg" Style="z-index: 102; left: 384px; position: absolute;
                            top: 4px" runat="server"  Width="80px" Text="导出Excel"></asp:Button>
                        <asp:Button ID="btnUpMove" Style="z-index: 103; left: 232px; position: absolute;
                            top: 8px" runat="server"  Width="40px" Text="上移" OnClick="btnUpMove_Click1"></asp:Button>
                        <asp:Button ID="btnDownMove" Style="z-index: 104; left: 280px; position: absolute;
                            top: 8px" runat="server"  Width="40px" Text="下移"></asp:Button>
                        <asp:Button ID="btnReOrder" Style="z-index: 105; left: 336px; position: absolute;
                            top: 8px" runat="server"  Width="40px" Text="重序"></asp:Button>
                        <asp:Label ID="lblMsg1" Style="z-index: 106; left: 480px; position: absolute; top: 8px"
                            runat="server"    Width="256px"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td style="width: 739px">
                    <asp:DataGrid ID="dgDepartmentInfo" runat="server"  
                        Width="816px" AllowSorting="True" AllowPaging="True" AutoGenerateColumns="False"
                        BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" BackColor="White"
                        CellPadding="3" GridLines="Horizontal">
                        <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                        <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                        <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                        <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                        <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                        <Columns>
                            <asp:TemplateColumn HeaderText="选择">
                                <HeaderStyle Width="30px"></HeaderStyle>
                                <HeaderTemplate>
                                    <asp:LinkButton ID="lbSelAll" runat="server"  
                                        CommandName="lbSelAll">全选</asp:LinkButton>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkCheckRec" runat="server" CssClass="DgSelAll"></asp:CheckBox>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                            <asp:BoundColumn DataField="OrderNum" SortExpression="OrderNum" HeaderText="序号"></asp:BoundColumn>
                            <asp:BoundColumn DataField="DepartmentId" SortExpression="DepartmentId" HeaderText="部门ID">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="DepartmentName" SortExpression="DepartmentName" HeaderText="部门名称">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="DepartmentAbbrName" SortExpression="DepartmentAbbrName"
                                HeaderText="名称缩写"></asp:BoundColumn>
                            <asp:BoundColumn DataField="UpDepartmentName" SortExpression="UpDepartmentName" HeaderText="所属部门号">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="SubjectTypeName" SortExpression="SubjectTypeName" HeaderText="学科类型">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="IsAcademy" SortExpression="IsAcademy" HeaderText="是否学院">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="DepartmentType" SortExpression="DepartmentType" HeaderText="类型">
                            </asp:BoundColumn>
                            <asp:BoundColumn DataField="DepartMentId4Card" SortExpression="DepartMentId4Card"
                                HeaderText="一卡通部门ID"></asp:BoundColumn>
                            <asp:BoundColumn DataField="IsExam" HeaderText="是否考核"></asp:BoundColumn>
                            <asp:BoundColumn Visible="False" DataField="Memo" SortExpression="Memo" HeaderText="备注">
                            </asp:BoundColumn>
                            <asp:ButtonColumn Text="修改" CommandName="Update"></asp:ButtonColumn>
                            <asp:TemplateColumn>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                        </Columns>
                        <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages">
                        </PagerStyle>
                    </asp:DataGrid>
                </td>
            </tr>
            <tr>
                <td style="width: 739px" bgcolor="silver">
                    <table id="tabDepartmentInfoJumpPage" style="width: 816px; font-family: Verdana;
                        height: 26px" cellspacing="0" cellpadding="0" width="816" border="1" runat="server">
                        <tr>
                            <td>
                                <font face="宋体"><font style="background-color: #c0c0c0">共有记录:</font>
                                    <asp:Label ID="lblDepartmentInfoRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <font style="background-color: #c0c0c0">总页数:</font>
                                    <asp:Label ID="lblDepartmentInfoAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <font style="background-color: #c0c0c0">当前页:
                                        <asp:Label ID="lblDepartmentInfoCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <asp:Button ID="btnDepartmentInfoPrevPage" runat="server"  
                                            Width="50px" Text="上一页"></asp:Button>
                                        <asp:Button ID="btnDepartmentInfoNextPage" runat="server"  
                                            Width="50px" Text="下一页"></asp:Button>
                                        到第
                                        <asp:TextBox ID="txtDepartmentInfoJump2Page" runat="server"  
                                            Width="35px"></asp:TextBox>页
                                        <asp:Button ID="btnDepartmentInfoJumpPage" runat="server"  
                                            Width="35px" Text="确定"></asp:Button>
                                        <asp:CompareValidator ID="DepartmentInfoCompareValidator1" runat="server" ForeColor="DarkOrange"
                                            ErrorMessage="错误！" ControlToValidate="txtDepartmentInfoJump2Page" Type="Integer"
                                            Operator="DataTypeCheck"></asp:CompareValidator></font></font>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="width: 739px">
                </td>
            </tr>
            <tr>
                <td style="width: 739px">
                    <asp:Button ID="btnOKUpd" runat="server" Width="80px"  
                         Text="添加"></asp:Button>
                    <asp:Label ID="lblMsg" runat="server" Width="256px"  
                        ></asp:Label>
                    <table id="tabLayout" style="width: 373px; height: 200px" cellspacing="0" cellpadding="0"
                        width="373" border="0">
                        <tr>
                            <td valign="top">
                                <uc1:wucDepartmentInfo ID="wucDepartmentInfo1" runat="server"></uc1:wucDepartmentInfo>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
