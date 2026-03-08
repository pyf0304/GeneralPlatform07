<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="left.aspx.cs" Inherits="EduHigh.Webform.PersonalCenter.left" %>


<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <title>数字化教学平台</title>
    <script src="../../JS/tzPubFun.js"></script>
    <style>
        body {
            margin: 0 auto;
            padding: 0;
            border: 0;
        }

        td {
            text-align: center;
            /*height: 40px;*/
        }

        .style1 {
            font: 12px "宋体";
            color: #004C7E;
        }

        .mItem {
            height: 20px;
            margin-top: 5px;
            text-align: center;
            border-bottom: 1px dotted #004C7E;
            font: 13px "宋体";
            color: #004C7E;
            vertical-align: middle;
        }

        .mItemHead0 {
            height: 25px;
            border-bottom: 1px dotted #004C7E;
            background-image: url("images/list_task.jpg");
        }

        .backcolor {
            background-color: #BE74AF;
        }

        .mItemHead {
            height: 25px;
            margin-top: 6px;
            text-align: center;
            vertical-align: middle;
            font: 13px "宋体";
            color: #004C7E;
        }

        a {
            color: #004C7E;
            text-decoration: none;
        }

            a:hover {
                color: #FFF;
                text-decoration: underline;
            }
    </style>
    <script>
        function myPopupMenu(strTarget) {

            var strHeadMenuName = "";
            try {
                strHeadMenuName = strTarget.id;
            }
            catch (e) {
                strHeadMenuName = strTarget.attributes("id").value;
            }

            var strItemMenuName = "divItem" + strHeadMenuName.substr(7);
            var divItemMenuName = getObjByTagAndId("div", strItemMenuName);
            if (divItemMenuName == null) return;
            InitMenu();
            if (divItemMenuName) {
                if (divItemMenuName.style.visibility != "hidden") {
                    divItemMenuName.style.display = 'none';
                    divItemMenuName.style.visibility = "hidden";//隐藏    
                }
                else {
                    divItemMenuName.style.display = 'block';
                    divItemMenuName.style.visibility = "visible";//显示
                }

            }
        }
        function InitMenu() {
            var arrMenuItems = GetObjectLstByTagNameAndStartIdName("div", "divItem");
            for (var i = 0; i < arrMenuItems.length; i++) {
                var objT = arrMenuItems[i];
                objT.style.display = 'none';
                objT.style.visibility = "hidden";//隐藏    
            }
        }
    </script>
</head>
<body onload="InitMenu();">
    <form id="form1" runat="server" style="width: 100%">
        <table style="width: 166px; height: 100%; padding: 0">
            <tr>
                <td style="text-align: center; vertical-align: top; background-color: #D4ECFC">
                    <table style="width: 162px; padding: 0">
                        <tr>
                            <td style="background-image: url('images/list_top.gif'); height: 28px"></td>
                        </tr>
                        <tr>
                            <td style="height: 92px; vertical-align: top">
                                <table style="width: 100%; height: 100px; padding: 0;">

                                    <tr>
                                        <td style="height: 20px" rowspan="2"><span class="style1">
                                            <asp:Image ID="Image2" ImageUrl="~/Webform/PersonalCenter/images/ss.jpg" Width="60px" Height="80px" runat="server" />
                                        </span></td>
                                        <td><span class="style1">当前登录用户</span></td>
                                    </tr>


                                    <tr>
                                        <td>
                                            <asp:Label ID="lblUserName" class="style1" runat="server" Text="Label">Admin</asp:Label>
                                        </td>

                                    </tr>
                                </table>
                                <%--<table width="100%" height="32" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td> <div class="mItem">修改信息</span></td>
                                    <td> <div class="mItem">修改密码</span></td>
                                </tr>
                            </table>--%>
                            </td>
                        </tr>
                        <tr id="tr_MenuMan" runat="server">
                            <td>
                                <div id="div_MenuMan">
                                    <div id="divHead_MenuMan" class="mItemHead0" onclick="myPopupMenu(this);">
                                        <div class="mItemHead"><a href="#">菜单管理</a></div>
                                    </div>
                                    <%-- 教师 --%>
                                    <div id="divItem_MenuMan">

                                        <div class="mItem">
                                            <a href="../MenuMan/wfmMenuMan.aspx?FunctionName=MenuSet" target="I2">菜单设置</a>
                                        </div>
                                        <div class="mItem">
                                            <a href="../MenuMan/wfmMenuMan.aspx?FunctionName=SetRoleMenu" target="I2">设置角色菜单</a>
                                        </div>
                                        <div class="mItem">
                                            <a href="../MenuMan/wfmMenuMan.aspx?FunctionName=MenuSet-Edit" target="I2">菜单集维护</a>
                                            <%--MenuSet-Edit 菜单集维护--%>
                                        </div>
                                    </div>
                                </div>
                            </td>
                        </tr>

                        <tr id="tr_PotenceMan" runat="server">
                            <td>
                                <div id="div_PotenceMan">
                                    <div id="divHead_PotenceMan" class="mItemHead0" onclick="myPopupMenu(this);">
                                        <div class="mItemHead"><a href="#">权限管理</a></div>
                                    </div>

                                    <%--       PotenceTypeMan 权限类型管理
PotenceMan 权限管理
PotenceSymbolMan 权限标志管理
SetPotence4Role 为角色配权限 --%>
                                    <div id="divItem_PotenceMan">

                                        <div class="mItem">
                                            <a href="../PotenceMan/wfmPotenceMan.aspx?FunctionName=PotenceTypeMan" target="I2">权限类型管理</a>
                                        </div>
                                        <div class="mItem">
                                            <a href="../PotenceMan/wfmPotenceMan.aspx?FunctionName=PotenceMan" target="I2">权限管理</a>
                                        </div>
                                        <div class="mItem">
                                            <a href="../PotenceMan/wfmPotenceMan.aspx?FunctionName=PotenceSymbolMan" target="I2">权限标志管理</a>

                                        </div>
                                        <div class="mItem">
                                            <a href="../PotenceMan/wfmPotenceMan.aspx?FunctionName=SetPotence4Role" target="I2">为角色配权限</a>

                                        </div>
                                    </div>
                                </div>
                            </td>
                        </tr>

                                    <tr id="tr_QxUserMan" runat="server">
                            <td>
                                <div id="div_QxUserMan">
                                    <div id="divHead_QxUserMan" class="mItemHead0" onclick="myPopupMenu(this);">
                                        <div class="mItemHead"><a href="#">用户管理</a></div>
                                    </div>
<%--UserMan 用户管理
UserMan_All 所有用户管理
User-Disp 用户查看
User-Disp_All 所有用户查看

User_SchoolMan 用户(学校)管理
User_School-Disp 用户(学校)查看
UserRoleMan	用户角色管理
SetRole4User 为用户设置角色

SetUsers4Role 为角色配用户 
DepartmentMan 部门管理
QxPrjUserRelation-Edit 工程用户关系-维护--%>
                                    <div id="divItem_QxUserMan">

                                        <div class="mItem">
                                            <a href="../UserMan/wfmUserMan.aspx?FunctionName=UserMan" target="I2">用户管理</a>
                                        </div>
                                        <div class="mItem">
                                            <a href="../UserMan/wfmUserMan.aspx?FunctionName=UserMan_All" target="I2">所有用户管理</a>
                                        </div>
                                        <div class="mItem">
                                            <a href="../UserMan/wfmUserMan.aspx?FunctionName=User-Disp" target="I2">用户查看</a>

                                        </div>
                                        <div class="mItem">
                                            <a href="../UserMan/wfmUserMan.aspx?FunctionName=User-Disp_All" target="I2">所有用户查看</a>

                                        </div>
                                         <div class="mItem">
                                            <a href="../UserMan/wfmUserMan.aspx?FunctionName=UserRoleMan" target="I2">用户角色管理</a>

                                        </div>
                                         <div class="mItem">
                                            <a href="../UserMan/wfmUserMan.aspx?FunctionName=SetRole4User" target="I2">为用户设置角色</a>

                                        </div>
                                         <div class="mItem">
                                            <a href="../UserMan/wfmUserMan.aspx?FunctionName=SetUsers4Role" target="I2">为角色配用户</a>

                                        </div>

                                         <div class="mItem">
                                            <a href="../UserMan/wfmUserMan.aspx?FunctionName=DepartmentMan" target="I2">部门管理</a>
                                        </div>
                                         <div class="mItem">
                                            <a href="../UserMan/wfmUserMan.aspx?FunctionName=QxPrjUserRelation-Edit" target="I2">工程用户关系-维护</a>
                                        </div>


                                         <div class="mItem">
                                            <a href="../TestPotence/wfmPrjModule_QUDI.aspx" target="I2">测试权限</a>
                                        </div>
                                    </div>
                                </div>
                            </td>
                        </tr>


                    </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
