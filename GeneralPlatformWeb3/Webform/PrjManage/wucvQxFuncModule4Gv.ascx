<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucvQxFuncModule4Gv.ascx.cs" Inherits="GeneralPlatform.Webform.wucvQxFuncModule4Gv" %>
            <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Scripts/bootstrap.js" type="text/javascript"></script>
<link rel="stylesheet" type="text/css" href="../../css/tz_base11.css" />
<%-- 列表层 --%>

<div id="divList" class="div_List"
    runat="server">
    <asp:GridView ID="gvQxFuncModule" Style="z-index: 101;" runat="server"
        Width="100%" AutoGenerateColumns="False"
        PageSize="10" AllowPaging="true"
        AllowSorting="true"
        OnSorting="gvQxFuncModule_Sorting"
        OnPageIndexChanging="gvQxFuncModule_PageIndexChanging"
        OnRowCreated="gvQxFuncModule_RowCreated"
        OnRowCommand="gvQxFuncModule_RowCommand"
        OnRowDeleting="gvQxFuncModule_RowDeleting"
        OnRowUpdating="gvQxFuncModule_RowUpdating"
        BackColor="White"
        BorderColor="#E7E7FF"
        BorderStyle="None"
        BorderWidth="1px"
        CellPadding="3"
        GridLines="Horizontal"
        Height="1px"
        DataKeyNames="FuncModuleId"
        CssClass="GridValue">
        <Columns>
            <asp:TemplateField HeaderText="全选">
                <HeaderStyle Width="30px" />
                <HeaderTemplate>
                    <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="DgSelAll" Text="全选"></asp:LinkButton>
                </HeaderTemplate>
                <ItemTemplate>
                    <a name="A_QxFuncModule<%# Eval("FuncModuleId").ToString().Trim() %>"></a>
                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="OrderNum" SortExpression="OrderNum" HeaderText="排序号"></asp:BoundField>
            <asp:BoundField DataField="FuncModuleId" SortExpression="FuncModuleId" HeaderText="模块Id"></asp:BoundField>
            <asp:BoundField DataField="FuncModuleName" SortExpression="FuncModuleName" HeaderText="模块名"></asp:BoundField>
            <asp:BoundField DataField="FuncModuleName_Sim" SortExpression="FuncModuleName_Sim" HeaderText="模块名_Sim"></asp:BoundField>
            <asp:BoundField DataField="FuncModuleEnName" SortExpression="FuncModuleEnName" HeaderText="模块英文名"></asp:BoundField>
            <asp:BoundField DataField="QxPrjId" SortExpression="QxPrjId" HeaderText="项目Id"></asp:BoundField>
            <asp:BoundField DataField="PrjName" SortExpression="PrjName" HeaderText="工程名"></asp:BoundField>
            <asp:BoundField DataField="InUse" SortExpression="InUse" HeaderText="是否在用"></asp:BoundField>
            <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期"></asp:BoundField>
            <asp:BoundField DataField="UpdUser" SortExpression="UpdUser" HeaderText="修改用户"></asp:BoundField>
            <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="备注"></asp:BoundField>
            <asp:TemplateField HeaderText="修改">
                <ItemTemplate>
                    <asp:LinkButton ID="lbUpdate" runat="Server" CommandName="Update" Text="修改" CssClass="LinkButton_DefaInGv"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="删除">
                <ItemTemplate>
                    <asp:LinkButton ID="lbDelete" runat="Server" CommandName="Delete" Text="删除" CssClass="LinkButton_DefaInGv"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <PagerTemplate>
            <span style="background-color: #c0c0c0">共有记录:</span>
            <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066" Width="36px">0</asp:Label>
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
                ErrorMessage="错误!" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
        </PagerTemplate>
        <FooterStyle CssClass="FooterStyle" />
        <RowStyle CssClass="RowStyle" />
        <EmptyDataRowStyle CssClass="EmptyDataRowStyle" />
        <SelectedRowStyle CssClass="SelectedRowStyle" />
        <PagerStyle CssClass="PagerStyle" />
        <HeaderStyle CssClass="HeaderStyle" />
        <EditRowStyle CssClass="EditRowStyle" />
        <AlternatingRowStyle CssClass="AlternatingRowStyle" />
    </asp:GridView>
</div>
