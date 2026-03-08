<%@ Page Language="c#" AutoEventWireup="true" Inherits="GeneralPlatform.Webform.wfmPersonB_Q" Codebehind="wfmPersonB_Q.aspx.cs"  Theme="TaiZeTheme" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/tr/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Person_Q维护的维护</title>

    <link href="../../css/taishweb2.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <table id="tabLayout" style="z-index: 105; left: 4px; position: absolute; top: 32px"
        cellspacing="2" cellpadding="2" width="100%" border="0" runat="server">
        <tr>
            <td>
                <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                    <asp:Label ID="lblViewTitle" runat="server" CssClass="PageTitleH1" >Person_Q表的查询
                    </asp:Label>
                    <asp:Label ID="lblMsg_List" runat="server" CssClass="ErrMsg"  Style="z-index: 105;
                        left: 54px; position: relative; top: 4px" Width="347px"></asp:Label>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <table style="width: 790px">
                    <tr>
                        <td>
                            <asp:Label ID="lblACCOUNT_q" Style="z-index: 104;" runat="server" Width="70px" 
                                CssClass="NameLabel">明卡号</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtACCOUNT_q" Style="z-index: 105;" runat="server" Width="136px"
                                Height="20px" CssClass="TextBox_Defa"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="lblCARD_NO_q" Style="z-index: 107;" runat="server" Width="70px" 
                                CssClass="NameLabel">卡号</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtCARD_NO_q" Style="z-index: 108;" runat="server" Width="136px"
                                Height="20px" CssClass="TextBox_Defa"></asp:TextBox>
                        </td>
                    
                        <td>
                            <asp:Label ID="lblNAME_q" Style="z-index: 110;" runat="server" Width="136px" 
                                CssClass="NameLabel">姓名</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtNAME_q" Style="z-index: 111;" runat="server" Width="136px" Height="20px"
                                CssClass="TextBox_Defa"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="lblSex_q" Style="z-index: 113;" runat="server" Width="70px" 
                                CssClass="NameLabel">性别</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtSex_q" Style="z-index: 114;" runat="server" Width="136px" Height="20px"
                                CssClass="TextBox_Defa"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblSTUDENT_ID_q" Style="z-index: 116;" runat="server" Width="70px"
                                 CssClass="NameLabel">学生证号</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtSTUDENT_ID_q" Style="z-index: 117;" runat="server" Width="136px"
                                Height="20px" CssClass="TextBox_Defa"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="lblACADEMY_NO_q" Style="z-index: 119;" runat="server" Width="70px"
                                 CssClass="NameLabel">学院编号</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtACADEMY_NO_q" Style="z-index: 120;" runat="server" Width="136px"
                                Height="20px" CssClass="TextBox_Defa"></asp:TextBox>
                        </td>
                
                        <td>
                            <asp:Label ID="lblGrade_q" Style="z-index: 122;" runat="server" Width="70px" 
                                CssClass="NameLabel">年级</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtGrade_q" Style="z-index: 123;" runat="server" Width="136px" Height="20px"
                                CssClass="TextBox_Defa"></asp:TextBox>
                        </td>
                        <td></td>
                        <td>
                            <asp:Button ID="btnQuery" Style="z-index: 125;" runat="server" Width="80px" 
                                Text="查询" CssClass="Button_Defa" OnClick="btnQuery_Click"></asp:Button>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <table id="tabPersonGridView" style="width: 100%" runat="server">
                    <tr>
                        <td>
                            <table style="width: 750px; height: 32px" id="tabGridFunction">
                                <tr>
                                    <td>
                                        <asp:Label ID="lblPersonList" runat="server" Height="18px" Style="z-index: 105;"
                                            CssClass="RegionTitleH1">Person_Q列表</asp:Label>
                                    </td>
                                    <td>
                                        <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" Style="z-index: 107;"
                                            runat="server" Width="80px" CssClass="Button_Defa" Text="导出Excel"></asp:Button>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:GridView ID="gvPerson" Style="z-index: 126;" runat="server" Width="100%" 
                                AutoGenerateColumns="False" AllowPaging="True" AllowSorting="True" OnSorting="gvPerson_Sorting"
                                OnPageIndexChanging="gvPerson_PageIndexChanging" OnRowCommand="gvPerson_RowCommand"
                                BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px"
                                CellPadding="3" GridLines="Horizontal" Height="1px" DataKeyNames="ACCOUNT" 
                                CssClass="GridValue">
                                <Columns>
                                    <asp:TemplateField HeaderText="全选">
                                        <HeaderStyle Width="30px" />
                                        <HeaderTemplate>
                                            <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="DgSelAll">全选</asp:LinkButton>
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="ACCOUNT" SortExpression="ACCOUNT" HeaderText="明卡号"></asp:BoundField>
                                    <asp:BoundField DataField="CARD_NO" SortExpression="CARD_NO" HeaderText="卡号"></asp:BoundField>
                                    <asp:BoundField DataField="NAME" SortExpression="NAME" HeaderText="姓名"></asp:BoundField>
                                    <asp:BoundField DataField="Sex" SortExpression="Sex" HeaderText="性别"></asp:BoundField>
                                    <asp:BoundField DataField="ACADEMY_NO" SortExpression="ACADEMY_NO" HeaderText="学院编号">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Grade" SortExpression="Grade" HeaderText="年级"></asp:BoundField>
                                    <asp:BoundField DataField="IDEN_NO" SortExpression="IDEN_NO" HeaderText="身份标识"></asp:BoundField>
                                    <asp:BoundField DataField="NATION_NO" SortExpression="NATION_NO" HeaderText="民族">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="STUDENT_ID" SortExpression="STUDENT_ID" HeaderText="学生证号">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="TEMP_CARD_NO" SortExpression="TEMP_CARD_NO" 
                                        HeaderText="临时卡卡号" Visible="False">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="TEMP_USING" SortExpression="TEMP_USING" 
                                        HeaderText="临时卡使用标志" Visible="False">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="RECYCLE_LIMIT" SortExpression="RECYCLE_LIMIT" HeaderText="退役期">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="USEFUL_LIMIT" SortExpression="USEFUL_LIMIT" HeaderText="有效期">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="CARD_STATE" SortExpression="CARD_STATE" HeaderText="卡状态">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="CARD_KIND" SortExpression="CARD_KIND" HeaderText="卡种类">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="SCH_ID" SortExpression="SCH_ID" HeaderText="学校统一编号" 
                                        Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="BIRTH" SortExpression="BIRTH" HeaderText="出生年月"></asp:BoundField>
                                </Columns>
                                <PagerTemplate>
                                    <span style="background-color: #c0c0c0">共有记录:</span>
                                    <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066"
                                        Width="22px">0</asp:Label>
                                    <span style="background-color: #c0c0c0">
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                    </span><span style="background-color: #c0c0c0">总页数:</span>
                                    <asp:Label ID="lblAllPages" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <span style="background-color: #c0c0c0">当前页:</span>
                                    <asp:Label ID="lblCurrentPage" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                    <div style="display: inline; width: 16px; height: 13px">
                                    </div>
                                    <asp:Button ID="btnPrevPage" runat="server" CssClass="Button_DefaInPager" Text="上一页"
                                        Width="50px" CommandArgument="Prev" CommandName="Page" /><span style="font-family: Verdana">
                                        </span>
                                    <asp:Button ID="btnNextPage" runat="server" CssClass="Button_DefaInPager" Text="下一页"
                                        Width="50px" CommandArgument="Next" CommandName="Page" />
                                    到第
                                    <asp:TextBox ID="txtJump2Page" runat="server" CssClass="TextBox_DefaInPager" Width="35px"></asp:TextBox>页
                                    <asp:Button ID="btnJumpPage" runat="server" CssClass="Button_DefaInPager" OnClick="btnJumpPage_Click"
                                        Text="确定" Width="35px" CommandName="Page" />
                                    <span style="background-color: #c0c0c0">页记录数:</span>
                                    <asp:DropDownList ID="ddlPagerRecCount" runat="server" CssClass="DropDown_DefaInPager"
                                        Width="55px" AutoPostBack="True" OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged">
                                        <asp:ListItem>5</asp:ListItem>
                                        <asp:ListItem>10</asp:ListItem>
                                        <asp:ListItem>20</asp:ListItem>
                                        <asp:ListItem>30</asp:ListItem>
                                        <asp:ListItem>50</asp:ListItem>
                                        <asp:ListItem>100</asp:ListItem>
                                        <asp:ListItem>1000</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
                                        ErrorMessage="错误！" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                                </PagerTemplate>
                                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                <AlternatingRowStyle BackColor="#F7F7F7" />
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
