<%@ Control Language="C#" AutoEventWireup="true" Inherits="Webform_Temp_wucUserRoleRelation2GV" Codebehind="wucUserRoleRelation2GV.ascx.cs" %>
<link href="../../Webform/css/taishweb1.css" rel="stylesheet" type="text/css" />
<asp:GridView ID="gvUserRoleRelation2" runat="server" AllowPaging="true" AllowSorting="true"
    AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None"
    BorderWidth="1px" CellPadding="3" CssClass="GridValue" DataKeyNames="UserId,RoleId"
    GridLines="Horizontal" Height="1px" OnPageIndexChanging="gvUserRoleRelation2_PageIndexChanging"
    OnRowCommand="gvUserRoleRelation2_RowCommand" OnRowCreated="gvUserRoleRelation2_RowCreated"
    OnRowDeleting="gvUserRoleRelation2_RowDeleting" OnRowUpdating="gvUserRoleRelation2_RowUpdating"
    OnSorting="gvUserRoleRelation2_Sorting" PageSize="10" Style="z-index: 117; position: relative"
    Width="800px">
    <Columns>
        <asp:TemplateField HeaderText="全选">
            <HeaderStyle Width="30px" />
            <HeaderTemplate>
                <asp:LinkButton ID="lbSelAll" runat="server" CommandName="lbSelAll" CssClass="DgSelAll">全选</asp:LinkButton>
            </HeaderTemplate>
            <ItemTemplate>
                <asp:CheckBox ID="chkCheckRec" runat="server" />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="UserId" HeaderText="用户ID" SortExpression="UserId" />
        <asp:BoundField DataField="RoleId" HeaderText="角色Id" SortExpression="RoleId" />
        <asp:BoundField DataField="PrjId" HeaderText="项目编号" SortExpression="PrjId" />
        <asp:BoundField DataField="Memo" HeaderText="备注" SortExpression="Memo" />
        <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID="lbUpdate" runat="Server" CommandName="Update" Text="修改"></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID="lbDelete" runat="Server" CommandName="Delete" Text="删除"></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    <PagerTemplate>
        <span style="background-color: #c0c0c0">共有记录:</span>
        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066"
            Width="16px">0</asp:Label>
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
        <asp:Button ID="btnPrevPage" runat="server" CommandArgument="Prev" CommandName="Page"
            CssClass="Button_DefaInPager" Text="上一页" Width="50px" /><span style="font-family: Verdana">
            </span>
        <asp:Button ID="btnNextPage" runat="server" CommandArgument="Next" CommandName="Page"
            CssClass="Button_DefaInPager" Text="下一页" Width="50px" />
        到第
        <asp:TextBox ID="txtJump2Page" runat="server" CssClass="TextBox_DefaInPager" Width="35px"></asp:TextBox>页
        <asp:Button ID="btnJumpPage" runat="server" CommandName="Page" CssClass="Button_DefaInPager"
            OnClick="btnJumpPage_Click" Text="确定" Width="35px" />
        <span style="background-color: #c0c0c0">页记录数:</span>
        <asp:DropDownList ID="ddlPagerRecCount" runat="server" AutoPostBack="True" CssClass="DropDown_DefaInPager"
            OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged" Width="41px">
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>30</asp:ListItem>
            <asp:ListItem>50</asp:ListItem>
            <asp:ListItem>100</asp:ListItem>
            <asp:ListItem>1000</asp:ListItem>
            <asp:ListItem></asp:ListItem>
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
