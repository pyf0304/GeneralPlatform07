<%@ Page Language="C#" AutoEventWireup="true" Inherits="TestIndex4GP" CodeBehind="TestIndex4GP.aspx.cs" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>统一平台跳转页测试首页</title>
    <script src="../js/DoingExercises.js" type="text/javascript"></script>

    <style type="text/css">
        .auto-style1 {
            width: 138px;
        }

        .auto-style2 {
            width: 609px;
        }

        .auto-style3 {
            width: 138px;
            height: 36px;
        }

        .auto-style4 {
            width: 609px;
            height: 36px;
        }

        .auto-style5 {
            height: 36px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <ajaxToolkit:ToolkitScriptManager runat="Server" EnablePartialRendering="true" ID="ScriptManager1" />
        <script type="text/javascript">
            function PanelClick(sender, e) {
                var Messages = $get('<%=Messages.ClientID%>');
                Highlight(Messages);
            }

            function ActiveTabChanged(sender, e) {
                var CurrentTab = $get('<%=CurrentTab.ClientID%>');
                CurrentTab.innerHTML = sender.get_activeTab().get_headerText();
                Highlight(CurrentTab);
            }

            var HighlightAnimations = {};
            function Highlight(el) {
                if (HighlightAnimations[el.uniqueID] == null) {
                    if (Sys.Extended.UI.Animation != undefined) {
                        HighlightAnimations[el.uniqueID] = Sys.Extended.UI.Animation.createAnimation({
                            AnimationName: "color",
                            duration: 0.5,
                            property: "style",
                            propertyKey: "backgroundColor",
                            startValue: "#FFFF90",
                            endValue: "#FFFFFF"
                        }, el);
                    }
                }
                if (el.uniqueID != undefined) {
                    if (HighlightAnimations[el.uniqueID] != undefined) {
                        HighlightAnimations[el.uniqueID].stop();
                        HighlightAnimations[el.uniqueID].play();
                    }
                }
            }

            function ToggleHidden(value) {
                $find('<%=Tabs.ClientID%>').get_tabs()[2].set_enabled(value);
               }

        </script>

        <div>
            <ajaxToolkit:TabContainer runat="server" ID="Tabs" OnClientActiveTabChanged="ActiveTabChanged" Width="100%"
                ActiveTabIndex="0" UseVerticalStripPlacement="False" Font-Size="13">
                <ajaxToolkit:TabPanel runat="server" ID="tpTeachingPlan" HeaderText="菜单模块" Font-Size="13pt" CssClass="tz_tabs_header">
                    <ContentTemplate>
                        <asp:UpdatePanel ID="updatePanel1" runat="server">
                            <ContentTemplate>
                                <div>
                                    <table>
                                        <tr>
                                            <td class="auto-style3">菜单设置</td>
                                            <td class="auto-style4">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=MenuSet&amp;QxPrjId=0150&amp;CollegeId=00000007</td>
                                            <td class="auto-style5">
                                                <asp:LinkButton ID="lbMenuSet" runat="server" OnClick="lbMenuSet_Click">菜单设置</asp:LinkButton></td>
                                            <td class="auto-style5"></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style3">设置角色菜单</td>
                                            <td class="auto-style4">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=SetRoleMenu&amp;QxPrjId=0150&amp;CollegeId=00000007</td>
                                            <td class="auto-style5">
                                                <asp:LinkButton ID="lbSetRoleMenu" runat="server" OnClick="lbSetRoleMenu_Click">设置角色菜单</asp:LinkButton></td>
                                            <td class="auto-style5"></td>
                                        </tr>
                                        <tr>
                                            <%--MenuSet-Edit 菜单集维护--%>
                                            <td class="auto-style3">菜单集维护</td>
                                            <td class="auto-style4">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=MenuSet-Edit&amp;QxPrjId=0150&amp;CollegeId=00000007</td>
                                            <td class="auto-style5">
                                                <asp:LinkButton ID="lbMenuSet_Edit" runat="server" OnClick="lbMenuSet_Edit_Click">菜单集维护</asp:LinkButton></td>
                                            <td class="auto-style5"></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style3">作业完成情况-学生</td>
                                            <td class="auto-style4">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=QueryFinishWork-Student&amp;QxPrjId=0150&amp;CollegeId=00000007</td>
                                            <td class="auto-style5">
                                                <asp:LinkButton ID="lbQueryFinishWork_Student" runat="server" OnClick="lbQueryFinishWork_Student_Click">作业完成情况-学生</asp:LinkButton></td>
                                            <td class="auto-style5"></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style3">作业完成情况-教师</td>
                                            <td class="auto-style4">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=QueryFinishWork-Teacher&amp;QxPrjId=0150&amp;CollegeId=00000007</td>
                                            <td class="auto-style5">
                                                <asp:LinkButton ID="lbQueryFinishWork_Teacher" runat="server" OnClick="lbQueryFinishWork_Teacher_Click">作业完成情况-教师</asp:LinkButton></td>
                                            <td class="auto-style5"></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style3">作业情况汇总-学生</td>
                                            <td class="auto-style4">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=QueryWorkTotal-Student&amp;QxPrjId=0150&amp;CollegeId=00000007</td>
                                            <td class="auto-style5">
                                                <asp:LinkButton ID="lbQueryWorkTotal_Student" runat="server" OnClick="lbQueryWorkTotal_Student_Click">作业情况汇总-学生</asp:LinkButton></td>
                                            <td class="auto-style5"></td>
                                            <tr>
                                                <td class="auto-style3">作业情况汇总-教师</td>
                                                <td class="auto-style4">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                    FunctionName=QueryWorkTotal-Teacher&amp;QxPrjId=0150&amp;CollegeId=00000007</td>
                                                <td class="auto-style5">
                                                    <asp:LinkButton ID="lbQueryWorkTotal_Teacher" runat="server" OnClick="lbQueryWorkTotal_Teacher_Click">作业情况汇总-教师</asp:LinkButton></td>
                                                <td class="auto-style5"></td>
                                            </tr>
                                    </table>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel runat="server" ID="TabPanel1" OnClientClick="PanelClick" HeaderText="相关案例">
                    <HeaderTemplate>权限管理</HeaderTemplate>
                    <ContentTemplate>
                        <asp:UpdatePanel ID="updatePanel2" runat="server">
                            <ContentTemplate>
                                <div>
                                    <table>
                                        <tr>
                                            <td class="auto-style3">权限类型管理</td>
                                            <td class="auto-style4">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=PotenceTypeMan&amp;QxPrjId=0150&amp;CollegeId=00000007</td>
                                            <td class="auto-style5">
                                                <asp:LinkButton ID="lbPotenceTypeMan" runat="server" OnClick="lbPotenceTypeMan_Click">权限类型管理</asp:LinkButton></td>
                                            <td class="auto-style5"></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style3">权限管理</td>
                                            <td class="auto-style4">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=PotenceMan&amp;QxPrjId=0150&amp;CollegeId=00000007</td>
                                            <td class="auto-style5">
                                                <asp:LinkButton ID="lbPotenceMan" runat="server" OnClick="lbPotenceMan_Click">权限管理</asp:LinkButton></td>
                                            <td class="auto-style5"></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style3">权限标志管理</td>
                                            <td class="auto-style4">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=PotenceSymbolMan&amp;QxPrjId=0150&amp;CollegeId=00000007</td>
                                            <td class="auto-style5">
                                                <asp:LinkButton ID="lbPotenceSymbolMan" runat="server" OnClick="lbPotenceSymbolMan_Click">权限标志管理</asp:LinkButton></td>
                                            <td class="auto-style5"></td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style3">为角色配权限</td>
                                            <td class="auto-style4">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=SetPotence4Role&amp;QxPrjId=0150&amp;CollegeId=00000007</td>
                                            <td class="auto-style5">
                                                <asp:LinkButton ID="lbSetPotence4Role" runat="server" OnClick="lbSetPotence4Role_Click">为角色配权限</asp:LinkButton></td>
                                            <td class="auto-style5"></td>
                                        </tr>
                                      
                                       
                                    </table>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel runat="server" ID="TabPanel2" OnClientClick="PanelClick" HeaderText="用户管理">
                    <HeaderTemplate>用户管理</HeaderTemplate>
                    <ContentTemplate>
                        <asp:UpdatePanel ID="updatePanel3" runat="server">
                            <ContentTemplate>
                                <div>
                                    <table>
                                        <tr>
                                            <td class="auto-style1">用户管理</td>
                                            <td class="auto-style2">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=UserMan&amp;QxPrjId=0150&amp;PrjId=00000007</td>
                                            <td>
                                                <asp:LinkButton ID="lbUserMan" runat="server" OnClick="lbUserMan_Click">用户管理</asp:LinkButton></td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style1">用户查看</td>
                                            <td class="auto-style2">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=User-Disp&amp;QxPrjId=0150&amp;PrjId=00000007</td>
                                            <td>
                                                <asp:LinkButton ID="lbUser_Disp" runat="server" OnClick="lbUser_Disp_Click">用户查看</asp:LinkButton></td>
                                            <td>&nbsp;</td>
                                        </tr>
                                         <tr>
                                             <%--UserMan_All 所有用户管理--%>
                                            <td class="auto-style1">所有用户管理</td>
                                            <td class="auto-style2">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=UserMan_All&amp;QxPrjId=0150&amp;PrjId=00000007</td>
                                            <td>
                                                <asp:LinkButton ID="lbUserMan_All" runat="server" OnClick="lbUserMan_All_Click">所有用户管理</asp:LinkButton></td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
<%--                                            User-Disp_All 所有用户查看--%>

                                            <td class="auto-style1">所有用户查看</td>
                                            <td class="auto-style2">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=User-Disp_All&amp;QxPrjId=0150&amp;PrjId=00000007</td>
                                            <td>
                                                <asp:LinkButton ID="lbUser_Disp_All" runat="server" OnClick="lbUser_Disp_All_Click">所有用户查看</asp:LinkButton></td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style1">用户(学校)管理</td>
                                            <td class="auto-style2">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=User_SchoolMan&amp;QxPrjId=0150&amp;PrjId=00000007</td>
                                            <td>
                                                <asp:LinkButton ID="lbUser_SchoolMan" runat="server" OnClick="lbUser_SchoolMan_Click">用户(学校)管理</asp:LinkButton></td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style1">用户(学校)查看</td>
                                            <td class="auto-style2">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=User_School-Disp&amp;QxPrjId=0150&amp;PrjId=00000007</td>
                                            <td>
                                                <asp:LinkButton ID="lbUser_School_Disp" runat="server" OnClick="lbUser_School_Disp_Click">用户(学校)查看</asp:LinkButton></td>
                                            <td>&nbsp;</td>
                                        </tr>

                                          <tr>
                                              <%--QxPrjUserRelation-Edit 工程用户关系-维护--%>
                                            <td class="auto-style1">工程用户关系-维护(建立维护试卷名称等)</td>
                                            <td class="auto-style2">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=QxPrjUserRelation-Edit&amp;QxPrjId=0150&amp;PrjId=00000007</td>
                                            <td>
                                                <asp:LinkButton ID="lbQxPrjUserRelation_Edit" runat="server" OnClick="lblbQxPrjUserRelation_Edit_Click">工程用户关系-维护</asp:LinkButton></td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style1">用户角色管理</td>
                                            <td class="auto-style2">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=UserRoleMan&amp;QxPrjId=0150&amp;PrjId=00000007</td>
                                            <td>
                                                <asp:LinkButton ID="lbUserRoleMan" runat="server" OnClick="lbUserRoleMan_Click">用户角色管理</asp:LinkButton></td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style1">为用户设置角色</td>
                                            <td class="auto-style2">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=SetRole4User&amp;QxPrjId=0150&amp;PrjId=00000007</td>
                                            <td>
                                                <asp:LinkButton ID="lbSetRole4User" runat="server" OnClick="lbSetRole4User_Click">为用户设置角色</asp:LinkButton></td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style1">为角色配用户</td>
                                            <td class="auto-style2">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=SetUsers4Role&amp;QxPrjId=0150&amp;PrjId=00000007</td>
                                            <td>
                                                <asp:LinkButton ID="lbSetUsers4Role" runat="server" OnClick="lbSetUsers4Role_Click">为角色配用户</asp:LinkButton></td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <%--DepartmentMan 部门管理--%>
                                            <td class="auto-style1">部门管理</td>
                                            <td class="auto-style2">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=DepartmentMan&amp;QxPrjId=0150&amp;PrjId=00000007</td>
                                            <td>
                                                <asp:LinkButton ID="lbDepartmentMan" runat="server" OnClick="lbDepartmentMan_Click">部门管理</asp:LinkButton></td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>



                <ajaxToolkit:TabPanel runat="server" ID="TabPanel7" OnClientClick="PanelClick" HeaderText="系统参数维护">
                    <HeaderTemplate>系统参数维护</HeaderTemplate>
                    <ContentTemplate>
                        <asp:UpdatePanel ID="updatePanel8" runat="server">
                            <ContentTemplate>
                                <div>
                                    <table>
                                        <tr>
                                            <td class="auto-style1">
                                                <asp:LinkButton ID="lbSetFieldVisibility" runat="server" OnClick="lbSetFieldVisibility_Click">设置字段可视性</asp:LinkButton></td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style1">
                                                <asp:LinkButton ID="lbQuestionType_Edit" runat="server" OnClick="lbQuestionType_Edit_Click">题型-编辑</asp:LinkButton></td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style1">
                                                <asp:LinkButton ID="lbSetDefaultPapersBigTopic" runat="server" OnClick="lbSetDefaultPapersBigTopic_Click">设置默认题型</asp:LinkButton></td>
                                            <td class="auto-style2">&nbsp;</td>
                                            <td>&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
                <ajaxToolkit:TabPanel runat="server" ID="TabPanel8" OnClientClick="PanelClick" HeaderText="问卷调查">
                    <HeaderTemplate>问卷调查</HeaderTemplate>
                    <ContentTemplate>
                        <asp:UpdatePanel ID="updatePanel9" runat="server">
                            <ContentTemplate>
                                <div>
                                    <table>
                                        <tr>
                                            <td class="auto-style1">问卷-显示</td>
                                            <td class="auto-style2">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=Questionnaire-Disp&amp; QxPrjId=0150&amp;PrjId=00000051</td>
                                            <td>
                                                <asp:LinkButton ID="lbQuestionnaire_Disp" runat="server" OnClick="lbQuestionnaire_Disp_Click">问卷显示</asp:LinkButton></td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style1">问卷-编辑</td>
                                            <td class="auto-style2">调用命令：~/Webform/JumpPage.aspx?UserId=00701&amp;<br />
                                                FunctionName=Questionnaire-Edit&amp; QxPrjId=0150&amp;PrjId=</td>
                                            <td>
                                                <asp:LinkButton ID="lbQuestionnaire_Edit" runat="server" OnClick="lbQuestionnaire_Edit_Click">问卷-编辑</asp:LinkButton></td>
                                            <td>&nbsp;</td>
                                        </tr>
                                    </table>
                                    <asp:Literal ID="Literal1" runat="server"></asp:Literal></div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </ContentTemplate>
                </ajaxToolkit:TabPanel>
            </ajaxToolkit:TabContainer>
            <div style="visibility: hidden">
                <br />
                <asp:CheckBox runat="server" ID="showComponents" Checked="true" Text=" Show Controls Owned" onclick="ToggleHidden(this.checked)" />
                <br />

                <br />
                Current Tab: 
                                                            <asp:Label runat="server" ID="CurrentTab" /><br />
                <asp:Label runat="server" ID="Messages" />
            </div>

        </div>


    </form>
</body>
</html>
