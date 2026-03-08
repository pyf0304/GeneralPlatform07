<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" 
    Inherits="ExamLib.Webform.Admin.login" %>

<!DOCTYPE html>

<!DOCTYPE html>
<!--[if lt IE 7 ]> <html lang="en" class="ie6 ielt8"> <![endif]-->
<!--[if IE 7 ]>    <html lang="en" class="ie7 ielt8"> <![endif]-->
<!--[if IE 8 ]>    <html lang="en" class="ie8"> <![endif]-->
<!--[if (gte IE 9)|!(IE)]><!-->
<html lang="en">
<!--<![endif]-->
<head runat="server">
    <meta charset="utf-8">
    <title>登录-上海泰泽统一平台</title>
    <link rel="stylesheet" type="text/css" href="common/css/login.css" />

</head>
<body>
    <%--<form id="form1" runat="server">--%>
        <div class="container">
            <section id="content">
                <form action="" id="form1" runat="server">
                    <h1>
                        <asp:Label ID="lblTitle" runat="server" Text="上海泰泽统一平台"></asp:Label></h1>
                    <div>
                        <table style="width:100%">
                            <tr>
                                <td style="width:60px; text-align:right"> <asp:Label ID="Label1" runat="server" Text="Label" CssClass="NameLabel_Login">账 号</asp:Label></td>
                                <td><asp:TextBox ID="txtUid" Style="z-index: 102;" TabIndex="1" runat="server" placeholder="Username" ></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td  style="width:60px; text-align:right">
                                    <asp:Label ID="Label2" runat="server" Text="Label" CssClass="NameLabel_Login">密 码</asp:Label></td>
                                <td>
                                    <asp:TextBox ID="txtPassWord" Style="z-index: 103;"
                                        TabIndex="2" runat="server" TextMode="Password"  AutoCompleteType="Disabled" AUTOCOMPLETE="off" placeholder="Password"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                       
                         
                    </div>
                  
                    <div>
                        <%--<input type="submit" value="登录"  />--%>
                        <asp:Button ID="btn_login" runat="server" Text="登录" OnClick="btn_login_Click" />
                        <%--<a href="#">修改密码</a>--%>
                        <a href="wfmRegister_JT.aspx" target="_self" style="font-size:14px;visibility:hidden">点此报名</a>
                    </div>
                </form>
                <!-- form -->
              
                <!-- button -->
            </section>
            <!-- content -->


        </div>
        <!-- container -->
        <div class="bottom">
            <a href="#">版权所有：上海泰泽信息技术有限公司 联系信箱：pyf@shnu.edu.cn 电话:021-51580822 </a>
        </div>
    <%--</form>--%>
</body>
</html>
