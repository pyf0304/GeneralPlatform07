<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucvQxQxPrjTab4Gv.ascx.cs" Inherits="GeneralPlatform.Webform.wucvQxPrjTab4Gv" %>
<link rel="stylesheet" type="text/css" href="../../css/tz_base1Bak.css" />
<%-- 列表层 --%>

<div id="divList" class="div_List"
    runat="server">
    <asp:GridView ID="gvQxPrjTab"  runat="server"
        Width="100%" AutoGenerateColumns="False"
        PageSize="10" AllowPaging="true"
        AllowSorting="true"
        OnSorting="gvQxPrjTab_Sorting"
        OnPageIndexChanging="gvQxPrjTab_PageIndexChanging"
        OnRowCreated="gvQxPrjTab_RowCreated"
        OnRowCommand="gvQxPrjTab_RowCommand"
        OnRowDeleting="gvQxPrjTab_RowDeleting"
        OnRowUpdating="gvQxPrjTab_RowUpdating"
        BackColor="White"
        BorderColor="#E7E7FF"
        BorderStyle="None"
        BorderWidth="1px"
        CellPadding="3"
        GridLines="Horizontal"
        Height="1px"
        DataKeyNames="TabId"
        CssClass="table table-striped table-bordered table-condensed" OnRowDataBound="gvQxPrjTab_RowDataBound">
        <Columns>
            <asp:TemplateField HeaderText="">
                <HeaderStyle Width="10px" />
                <HeaderTemplate>
                    <asp:CheckBox ID="chkSelAll" CommandName="SelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap" AutoPostBack="true" OnCheckedChanged="chkSelAll_CheckedChanged" Text=""></asp:CheckBox>
                </HeaderTemplate>
                <ItemTemplate>
                    <a name="A_QxPrjTab<%# Eval("TabId").ToString().Trim() %>"></a>
                    <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:BoundField DataField="TabId" SortExpression="TabId" HeaderText="表ID" Visible="False"></asp:BoundField>

            <asp:TemplateField HeaderText="表名" SortExpression="TabName">
                <ItemTemplate>
                    <asp:LinkButton ID="lbEditTabFields2" runat="Server" CommandName="EditTabFields2" CommandArgument='<%# Eval("TabId") %>'
                        ToolTip="综合维护-编辑表字段、约束，检查一致性等相关操作" Text='<%# Bind("TabName") %>'></asp:LinkButton>
                    <asp:HiddenField ID="hidTabName" Value='<%# Bind("TabName") %>' runat="server" />
                </ItemTemplate>
            </asp:TemplateField>


            <%--            <asp:BoundField DataField="TabName" SortExpression="TabName" HeaderText="表名">
                <HeaderStyle HorizontalAlign="Left" />
            </asp:BoundField>--%>
            <asp:BoundField DataField="TabCnName" SortExpression="TabCnName" HeaderText="中文名">
                <HeaderStyle HorizontalAlign="Left" />
            </asp:BoundField>
            <asp:BoundField DataField="FuncModuleName" SortExpression="FuncModuleName" HeaderText="模块"></asp:BoundField>

            <asp:BoundField DataField="SqlDsTypeName" SortExpression="SqlDsTypeName" HeaderText="表类型"></asp:BoundField>

            <asp:BoundField DataField="KeyFldName" SortExpression="KeyFldName" HeaderText="主键">
                <HeaderStyle HorizontalAlign="Left" />
            </asp:BoundField>
            <asp:BoundField DataField="PrimaryTypeName" SortExpression="PrimaryTypeName" HeaderText="主键类型">
                <HeaderStyle HorizontalAlign="Left" />
            </asp:BoundField>
            <asp:BoundField DataField="SQLDSTypeName" SortExpression="SQLDSTypeName" HeaderText="数据源类型">
                <HeaderStyle HorizontalAlign="Left" />
            </asp:BoundField>
            <%--<asp:BoundField DataField="ObjName" SortExpression="ObjName" HeaderText="对象"></asp:BoundField>--%>
            <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期">
                <HeaderStyle HorizontalAlign="Left" />
            </asp:BoundField>
     <%--       <asp:BoundField DataField="RelaTabName4View" SortExpression="RelaTabName4View" HeaderText="视图相关主表">
                <HeaderStyle HorizontalAlign="Left" />
            </asp:BoundField>--%>
            <asp:BoundField DataField="TabTypeName" SortExpression="TabTypeName" HeaderText="表类型">
                <HeaderStyle HorizontalAlign="Left" />
            </asp:BoundField>
            <asp:BoundField DataField="TabStateName" SortExpression="TabStateName" HeaderText="使用状态"></asp:BoundField>

            <asp:BoundField DataField="Owner" HeaderText="拥有者" SortExpression="Owner" Visible="false" />
         <%--   <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lbEditTabFields" runat="Server" CommandName="EditTabFields" CssClass="LinkButton_DefaInGv" ToolTip="为当前表编辑相关内容：表属性、表字段等。" Text="综合维护"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>--%>

        </Columns>
        <PagerTemplate>
            <span class="text-secondary">共有记录:</span>
                <span class="text-secondary">共有记录:</span>
            <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066" Width="36px">0</asp:Label>
            <span style="background-color: #c0c0c0">
                <div style="display: inline; width: 16px; height: 13px">
                </div>
            </span><span class="text-secondary">总页数:</span>
            <asp:Label ID="lblAllPages" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
            <div style="display: inline; width: 16px; height: 13px">
            </div>
            <span class="text-secondary">当前页:</span>
            <asp:Label ID="lblCurrentPage" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
            <div style="display: inline; width: 16px; height: 13px">
            </div>
            <asp:Button ID="btnPrevPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" Text="上一页"
                CommandArgument="Prev" CommandName="PrevPage" /><span style="font-family: Verdana">
                </span>
            <asp:Button ID="btnNextPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" Text="下一页"
                CommandArgument="Next" CommandName="NextPage" />
            到第
            <asp:TextBox ID="txtJump2Page" runat="server" CssClass="TextBox_DefaInPager" Width="35px"></asp:TextBox>页
            <asp:Button ID="btnJumpPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" OnClick="btnJumpPage_Click"
                Text="确定" Width="45px" CommandName="Page" />
            <span class="text-secondary">页记录数:</span>
            <asp:DropDownList ID="ddlPagerRecCount" runat="server" CssClass="DropDown_DefaInPager"
                Width="55px" AutoPostBack="True" OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged">
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
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
