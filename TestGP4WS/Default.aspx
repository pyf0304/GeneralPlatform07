<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestGP4WS._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="口令"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnGetmenu" runat="server" Text="获取菜单" 
                        onclick="btnGetmenu_Click" />
                    </td>
                <td>
                    <asp:Button ID="btnLogin" runat="server" Text="登录" onclick="btnLogin_Click" />
                    <asp:Label ID="lblLoginResult" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnTestGet_PotenceLevel" runat="server" Text="测试Get_PotenceLevel" 
                        onclick="btnTestGet_PotenceLevel_Click" />
                    <asp:Button ID="btnTestWebConnect" runat="server" Text="测试主连接" 
                        onclick="btnTestWebConnect_Click" />
                    <asp:Button ID="btnTestWebConnect2" runat="server" Text="测试备用连接" 
                        onclick="btnTestWebConnect2_Click" />
                    <asp:Label ID="lblTestResult" runat="server" Text="测试结果"></asp:Label>
                    </td>
                <td>
                    <asp:Button ID="btnUpdPassword" runat="server" Text="修改口令" onclick="btnUpdPassword_Click" />
                    </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="根据用户ID获取角色相关表" />
                    </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                    </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
