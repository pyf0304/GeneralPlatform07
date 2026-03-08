<%@ Register Src="~/Webform/PrjManage/wucvQxPrjTab4Gv.ascx" TagPrefix="uc2" TagName="wucvQxPrjTab4Gv" %>


<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmQxPrjTab_QUDI3.aspx.cs"
    Inherits="GeneralPlatform.Webform.wfmQxPrjTab_QUDI3" ValidateRequest="false" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width,initial-scale=1,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no" />
    <meta name="renderer" content="webkit|ie-comp|ie-stand" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta http-equiv="Cache-Control" content="no-siteapp" />
    <meta name="keywords" content="scclui框架" />
    <meta name="description" content="工程表维护" />

    <title>工程表维护</title>
    <%--<script src="../../Scripts/jquery-3.4.1.min.js"></script>--%>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />

    <script src="../../js/tzPubFun.js" type="text/javascript"></script>
    <script src="../../js/PubFun/jsPubVar.js"></script>
    <script src="../../js/PubFun/jsPubFun.js"></script>
    <script src="../../js/PubFun/jsGetElement.js"></script>
    <script src="../../js/PubFun/TzCtrlCls.js"></script>
    <script src="../../js/PubFun/jsTableObjWS4ControllerDelegate.js"></script>
    <script src="../../js/Table_Field/jsvQxPrjTab_Edit.js"></script>
    <link href="../../tzTreeViewWuc/cssTreeView.css" rel="stylesheet" />

    <script type="text/javascript">
        function GeneCode(strCodeTypeId, strTabId) {
            //返回长度超过一定数量就不能返回了，怎么办？
            $.ajax({
                type: "post",
                datatype: "json",
                data: '{"strCodeTypeId":"' + strCodeTypeId + '",' +
                    '"strTabId":"' + strTabId + '",' +
                    '"strViewId":""}',
                url: "wfmQxPrjTab_QUDI3.aspx/GeneCode",
                contentType: "application/json",
                success: function (result) {
                    ShowCode(result.d);
                }
            });
        }
        function ShowCode(strCode) {
            var txtCode = document.getElementById("txtCode");
            var objJSON = JSON.parse(strCode)
            txtCode.value = objJSON.Code;
            var txtClassName4GC = document.getElementById("txtClassName4GC");
            if (txtClassName4GC != null) {
                txtClassName4GC.value = objJSON.ClassName;
            }
            if (txtFileName4GC != null) {
                txtFileName4GC.value = objJSON.FileName;
            }
            //$('#txtCode').val(strCode);
        }

        function GenControlCode() {
            var txtCode = getObjByTagAndId("textarea", "txtCode");
            if (txtCode != null) {
                txtCode.value = "";
            }
            var txtCode_Sim = getObjByTagAndId("textarea", "txtCode_Sim");
            if (txtCode_Sim != null) {
                txtCode_Sim.value = "";
            }
            var divCode = getObjByTagAndId("div", "divCode");
            CallServer("GenControlCode|1!", divCode);
        }
        function GenCtlControlCode() {
            var txtCode = getObjByTagAndId("textarea", "txtCode");
            if (txtCode != null) {
                txtCode.value = "";
            }
            var txtCode_Sim = getObjByTagAndId("textarea", "txtCode_Sim");
            if (txtCode_Sim != null) {
                txtCode_Sim.value = "";
            }
            var divCode = getObjByTagAndId("div", "divCode");
            CallServer("GenCtlControlCode|1!", divCode);
        }
        function ClearText(txtCode) {
            var txtCode = getObjByTagAndId("textarea", "txtCode");
            if (txtCode != null) {
                txtCode.value = "";
            }
            var txtCode_Sim = getObjByTagAndId("textarea", "txtCode_Sim");
            if (txtCode_Sim != null) {
                txtCode_Sim.value = "";
            }
        }
    </script>
    <script type="text/javascript">


        function ChangeLangType(strFunName, strLangType) {
            //if (event.keyCode == 13) {
            //event.cancelBubble = true;
            //event.returnValue = false;
            var lblLangTypeName = getObjByTagAndId("span", "lblLangTypeName");
            if (lblLangTypeName != null) {
                lblLangTypeName.innerHTML = strLangType;
            }
            else {
                alert("找不到lblLangTypeName");
            }
            document.all.FunName.value = strFunName;// "enter";
            document.all.hidLangType.value = strLangType;

            document.forms[0].submit();
            //}
        }
        function ChangeDataBaseType(strFunName, strDataBaseType) {
            //if (event.keyCode == 13) {
            //event.cancelBubble = true;
            //event.returnValue = false;
            document.all.FunName.value = strFunName;// "enter";
            document.all.hidDataBaseType.value = strDataBaseType;

            document.forms[0].submit();
            //}
        }
    </script>
    <script type="text/javascript">
        //自动复制表记录
        var objvQxPrjTab_Edit = new vcvQxPrjTab_Edit();

        var tabAllQxPrjTab = new TzTable("tabAllQxPrjTab");
        var lblRecNo4AllQxPrjTab = new TzSpan("lblRecNo4AllQxPrjTab");
        var strLastTabName = "";
        var strLastTabCnName = "";
        function KeyP_TabName(v) {
            //            document.getElementById("txt").value = v.value;
            var strCurrTabName = v.value;
            if (strCurrTabName !== strLastTabName) {
                getQxPrjTab();
                strLastTabName = strCurrTabName;
            }
        }
        function KeyP_TabCnName(v) {
            //            document.getElementById("txt").value = v.value;
            var strCurrTabCnName = v.value;
            if (strCurrTabCnName !== strLastTabCnName) {
                getQxPrjTab();
                strLastTabCnName = strCurrTabCnName;
            }
        }

        //var pub_arrvQxPrjTabObjLst = null;
        function getQxPrjTab() {
            objvQxPrjTab_EditDelegate = new clsTableObjWS4ControllerDelegate();

            objvQxPrjTab_EditDelegate.GetTopRecordJSONObjLstCorrectFinished = function (returnObjectList, strClassName) {
                pub_vQxPrjTab_GetTopRecordJSONObjLstCorrectFinished(returnObjectList, strClassName);
            }
            objvQxPrjTab_Edit.btnGetTopJSONObjLst_Click();
        }
        var inArray = function (arr, item) {
            for (var i = 0; i < arr.length; i++) {
                if (arr[i] == item) {
                    return true;
                }
            }
            return false;
        };
        function DelTabDataRow() {
            var intLen = tabAllQxPrjTab.getLength();
            for (var i = intLen - 1; i > 0; i--) {
                tabAllQxPrjTab.deleteRow(i);
            }
        }
        function setRecNo(intLen) {
            var strCondition = "";
            strCondition = objvQxPrjTab_Edit.Condition;
            var strMsg = String.format("<span color='red'>条件:</span>[{0}]所获取的记录数为:[{1}].", strCondition, intLen);
            lblRecNo4AllQxPrjTab.setinnerHTML(strMsg);
        }
        function pub_vQxPrjTab_GetTopRecordJSONObjLstCorrectFinished(returnObjectList, strClassName) {
            var arrvQxPrjTabObjLst = returnObjectList;
            if (arrvQxPrjTabObjLst === null) return;
            //var strInfo = String.format("共获取对象列表数：{0}", arrvQxPrjTabObjLst.length)
            ////显示信息框
            //myAlert(strInfo);
            //删除表的数据行
            DelTabDataRow();
            var intLen = arrvQxPrjTabObjLst.length;
            setRecNo(intLen);//设置记录数
            var arrTabNameSqlDsTypeName = new Array();
            for (var i = 0; i < intLen; i++) {
                var objvQxPrjTab = arrvQxPrjTabObjLst[i];
                var strTabNameSqlDsTypeName = String.format("{0}{1}{2}{3}",
                    objvQxPrjTab.TabName,
                    objvQxPrjTab.TabCnName,
                    objvQxPrjTab.SqlDsTypeName,
                    objvQxPrjTab.FldNum);
                if (inArray(arrTabNameSqlDsTypeName, strTabNameSqlDsTypeName) === true) {
                    continue;
                }
                var objTr = tabAllQxPrjTab.insertRow();
                var objTd1 = objTr.insertCell();
                objTd1.setText(objvQxPrjTab.TabId);
                var objTd2 = objTr.insertCell();
                objTd2.setText(objvQxPrjTab.TabName);
                objTr.insertCell(objvQxPrjTab.TabCnName);
                objTr.insertCell(objvQxPrjTab.FldNum);
                objTr.insertCell(objvQxPrjTab.SqlDsTypeName);
                objTr.insertCell(objvQxPrjTab.PrjName);
                var objTd_btn = objTr.insertCell();
                var input = document.createElement("input");
                input.id = String.format("btn{0}", objvQxPrjTab.TabId);
                input.type = "button";
                input.value = "复制表";
                //var strOnClick = String.format("return InsertNewField('{0}');", objvQxPrjTab.TabId);
                //var strPara = String.format("'{0}'", objvQxPrjTab.TabId);
                input.onclick = function () {
                    InsertNewField(this);
                }
                //input.click = strOnClick;

                //input.attributes["onclick"] = strOnClick;
                console.log(input);
                var strButton = input.outerHTML;
                //strButton = String.format("<input type=\"input\" value=\"插入字段\" onclick=\"return InsertNewField('{0}');\" />", objvQxPrjTab.TabId);
                //                objTd_btn.setHTML(strButton)
                objTd_btn.appendChild(input);
                //  divButton.appendChild(input);
            }
        }
        var hidTabId = new TzHiddenField("hidTabId");
        var btnCopyQxPrjTab = new TzButton("btnCopyQxPrjTab");
        function InsertNewField(thisButton) {
            console.log(thisButton);
            var strId = thisButton.id;
            hidTabId.setValue(strId);
            btnCopyQxPrjTab.click();
        }
    </script>
    <style type="text/css">
        #btnSetFieldLst4Show {
            width: 100px;
        }
    </style>
    <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true">
        </asp:ScriptManager>
        <%-- 标题层 --%>
        <div style="position: relative; width: 100%; height: 35px; left: 0px; top: 0px;">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" Width="242px">表字段管理->项目表维护                    </asp:Label>
                    </td>

                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lblMsg_List" runat="server" CssClass="text-warning"
                            Width="263px"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>


        <%-- 查询层 --%>

        <div id="divQuery" class="div_query">
            <table id="tabQueryCondition" border="0" style="width: 848px; padding: 2px;"
                width="848" runat="server">
                <tr>
                    <td style="height: 15px; text-align: right;">
                        <asp:Label ID="lblTabName_q" runat="server" CssClass="text-secondary " Width="54px">表名</asp:Label>
                    </td>
                    <td style="height: 15px">
                        <asp:TextBox ID="txtTabName_q" runat="server" Width="260px"></asp:TextBox>
                    </td>
                    <td style="height: 15px; text-align: right;">
                        <asp:CheckBox ID="chkFuncModuleId_q" runat="server" CssClass="NameLabelRightAlign" Text="模块" Checked="true" />
                    </td>
                    <td style="height: 15px">
                        <asp:DropDownList ID="ddlFuncModuleId" runat="server"
                            Width="100px">
                        </asp:DropDownList>
                    </td>
                    <td style="height: 15px"></td>
                    <td style="height: 15px"></td>
                    <td style="width: 118px; height: 15px; text-align: right">
                        <asp:CheckBox ID="chkTabStateId_q" runat="server" CssClass="NameLabelRightAlign" Text="表状态" Checked="true" />
                    </td>
                    <td style="height: 15px">
                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                            <ContentTemplate>
                                <asp:DropDownList ID="ddlTabStateId_q" runat="server" Width="100px">
                                </asp:DropDownList>
                            </ContentTemplate>
                            <Triggers>
                                <asp:AsyncPostBackTrigger ControlID="ddlFuncModuleId" EventName="SelectedIndexChanged" />
                            </Triggers>
                        </asp:UpdatePanel>
                    </td>
                      <td style="height: 15px">
                        <asp:Label ID="Label6" runat="server" CssClass="NameLabelRightAlign" Width="46px">数据源</asp:Label>
                    </td>
                    <td style="height: 15px">
                        <asp:DropDownList ID="ddlSQLDSTypeId" runat="server" Width="100px">
                        </asp:DropDownList>
                    </td>
                     <td style="height: 15px; text-align: right">
                        <asp:Label ID="lblTabCnName_q" runat="server" CssClass="NameLabelRightAlign" Width="52px">中文名</asp:Label>
                    </td>
                    <td style="height: 15px">
                        <asp:TextBox ID="txtTabCnName_q" runat="server" Width="260px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnQuery" runat="server" OnClick="btnQuery_Click" CssClass="btn btn-outline-warning btn-sm" Text="查询" Width="63px" />
                    </td>
                    <td>&nbsp;</td>
                    <td>
                        <input id="btnSetFieldLst4Show" type="button" style="width: 110px" class="btn btn-outline-warning btn-sm" value="设置显示字段" onclick="Tz_ShowDiv('divSetFieldVisibilityB_QU');" /></td>
                </tr>

            </table>
        </div>

        <div id="divBaseOperate" runat="server">

            <ul class="nav">
                <li class="nav-item">
                    <asp:Label ID="lblFunction4CodeList" runat="server"
                        CssClass="h6" Width="250px">基本操作:</asp:Label>
                </li>
                <li class="nav-item ml-3">
                    <asp:Button ID="btnSynchPrjTab" OnClick="btnSynchPrjTab_Click" runat="server" Text="同步工程表" class="btn btn-outline-info btn-sm"></asp:Button>
                </li>
                <li class="nav-item ml-3">
                    <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" runat="server" Text="导出Excel" class="btn btn-outline-info btn-sm"></asp:Button>
                </li>
            </ul>
        </div>

        <%-- 列表层 --%>

        <div id="divList" class="div_List" runat="server">
            <uc2:wucvQxPrjTab4Gv runat="server" ID="wucvQxPrjTab4Gv1"
                ongvedittabfieldsclick="wucvQxPrjTab4Gv1_GvEditTabFieldsClick" />
        </div>

        <script src="../../Scripts/jquery-3.4.1.min.js"></script>

        <script src="../../Scripts/bootstrap.min.js"></script>
        <script type="text/javascript" src="../../js/tz_MenuButton/tz_sccl.js"></script>
        <script type="text/javascript" src="../../js/tz_MenuButton/tz_sccl-util.js"></script>
        <input type="hidden" name="FunName" />
        <input type="hidden" name="hidLangType" />
        <input type="hidden" name="hidDataBaseType" />
        <asp:HiddenField ID="hidTabId" runat="server" />
    </form>
</body>
</html>
