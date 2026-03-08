<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="top.aspx.cs" Inherits="EduHigh.Webform.PersonalCenter.top" %>


<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />

    <title>数字化教学平台</title>
    <link href="../../css/tz_base1.css" rel="stylesheet" />
</head>
<style type="text/css">
    * {
        margin: 0 auto;
        padding: 0;
        border: 0;
    }

    body {
        font: 12px "宋体";
        color: #FFF;
    }

    .lable {
        background: url(images/top_lable.jpg) no-repeat;
        width: 126px;
        height: 28px;
        float: left;
    }

        .lable p {
            margin-top: 4px;
        }

    .menu {
        background: url(images/top_menu.jpg) no-repeat;
        width: 348px;
        height: 28px;
        float: right;
    }

        .menu ul {
            margin: 8px 0 0 45px;
            list-style: none;
        }

        .menu li {
            display: inline;
        }

        .menu a {
            float: left;
            text-decoration: none;
            padding-left: 2px;
        }

            .menu a:hover {
                text-decoration: none;
            }

            .menu a span {
                display: block;
                padding-right: 10px;
                color: #FFF;
            }

            .menu a:hover span {
                color: #004c7e;
            }

    .menu_left {
        background: url(images/menu_left.jpg) no-repeat;
        width: 155px;
        height: 22px;
        float: left;
        margin: 3px 0 0 6px;
        text-align: center;
    }

        .menu_left p {
            margin-top: 5px;
        }

    .menu_list {
        width: 100%;
        height: 25px;
    }

        .menu_list ul {
            margin: 0;
            padding: 4px 0 0 70px;
            list-style: none;
        }

        .menu_list li {
            display: inline;
        }

        .menu_list a {
            float: left;
            text-decoration: none;
        }

            .menu_list a span {
                display: block;
                padding: 4px 10px 0 10px;
                color: #004c7e;
            }

            .menu_list a:hover span {
                color: #FFF;
                border: 1px solid #004c7e;
            }

            .menu_list a:hover {
                background: url(images/menu_list.jpg) repeat-x;
            }
</style>

<script language="javascript" type="text/javascript">
    function Ref() {
        window.parent.frames('mainFrame').frames('I2').location.reload();
        window.parent.frames('mainFrame').frames('I1').location.reload();
    }
</script>
<body>
    <form id="form1" runat="server">
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td background="images/top_bg.jpg" width="289" height="57">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td>
                                <img src="images/top_lf.jpg"></td>
                        </tr>
                    </table>
                </td>
                <td background="images/top_bg.jpg" height="56">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td height="29"></td>
                        </tr>
                        <tr>
                            <td width="20%" height="28">
                                <div class="lable">
                                    <p>个人中心</p>
                                </div>
                            </td>
                            <td>
                                <table>
                                    <tr>
                                        <td>
                                            <asp:Label ID="Label1" runat="server" Text="系统默认课程:" CssClass="content2"></asp:Label></td>
                                        <td>
                                            <asp:Label ID="lblCourseName" runat="server" Text="课程名称" CssClass="content"></asp:Label></td>
                                        <td>
                                            <asp:Button CssClass="GoStyle_White" onmouseover="this.style.cursor='hand'" ID="lbChangeCourse"
                                                runat="server" ToolTip="切换整个Mooc系统中的默认课程" Text="[切换课程]"></asp:Button></td>
                                        <td>
                                            <asp:DropDownList ID="ddlCourseId_q" CssClass="DropDown" runat="server" AutoPostBack="True" ></asp:DropDownList></td>

                                    </tr>
                                </table>
                            </td>
                            <td>
                                <div class="menu">
                                    <ul>
                                        <li>
                                            <asp:Button ID="lbReturnIndex" runat="server" OnClick="lbReturnIndex_Click" CssClass="GoStyle_White" Text="首页"></asp:Button></li>
                                        <li><a href="javascript:history.go(-1)"><span>后退</span></a></li>
                                        <li><a href="javascript:history.go(1)"><span>前进</span></a></li>
                                        <li><a href="#" onclick="Ref()" title="刷新内容和菜单"><span>刷新</span></a></li>
                                        <li>
                                            <asp:Button ID="lbQuit" runat="server" OnClick="lbQuit_Click" CssClass="GoStyle_White" Text="退出"></asp:Button></li>
                                    </ul>
                                </div>
                            </td>
                            <td style="width: 18px"></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
