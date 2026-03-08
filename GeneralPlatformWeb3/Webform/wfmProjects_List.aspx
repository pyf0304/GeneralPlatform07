<%@ Page Language="c#" AutoEventWireup="True"
    Inherits="GeneralPlatform.Webform.wfmProjects_List" Codebehind="wfmProjects_List.aspx.cs" Theme="TaiZeTheme"  %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>wfmProjects_List</title>
    <link href="../css/tz_base1.css" rel="stylesheet" />
    <link href="../css/tz_base1.css" rel="stylesheet" />
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:DataList ID="DataList1" Style="z-index: 101; left: 8px; position: absolute;
            top: 24px" runat="server" CellPadding="0">
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" Target="_blank" 
                     NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.QxPrjId", "Login_WebApplications.aspx?UserPrjId={0}") %>'
                    Text='<%# DataBinder.Eval(Container, "DataItem.PrjName") %>'>
                </asp:HyperLink>
            </ItemTemplate>
        </asp:DataList>
        <asp:HyperLink ID="HyperLink2" Style="z-index: 102; left: 8px; position: absolute;
            top: 8px" runat="server" NavigateUrl="Index.aspx"  
            Target="_blank">统一平台管理系统</asp:HyperLink>
    </form>
</body>
</html>
