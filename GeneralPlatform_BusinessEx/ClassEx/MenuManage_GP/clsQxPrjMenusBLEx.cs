
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxPrjMenusBLEx
表名:QxPrjMenus
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:05:23
生成者:
工程名称:统一平台
工程ID:0014
模块中文名:菜单管理
模块英文名:MenuManage
框架-层名:业务逻辑扩展层
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;

using GeneralPlatform.Entity;
using System.Data;
using System.Data.SqlClient;
using GeneralPlatform.DAL;
using GeneralPlatform.BusinessLogic;
using com.taishsoft.datetime;
using SpecData;
using System.Web.Configuration;

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// 工程菜单(QxPrjMenus)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsQxPrjMenusBLEx : clsQxPrjMenusBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxPrjMenusDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxPrjMenusDAEx QxPrjMenusDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxPrjMenusDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        public static List<clsQxPrjMenusEN> arrQxPrjMenusObjLst = null;

        public static bool DataCleaning(string strQxPrjId)
        {
            string strWhere = $"{conQxPrjMenus.QxPrjId} = '{strQxPrjId}'";
            strWhere += $" order by {conQxPrjMenus.MenuName}, {conQxPrjMenus.MenuId} asc";
            List<clsQxPrjMenusEN> arrQxPrjMenus = clsQxPrjMenusBL.GetObjLst(strWhere);
            int intLen = arrQxPrjMenus.Count;
            string strLastMenuName = arrQxPrjMenus[0].MenuName;
            string strFstMenuId = arrQxPrjMenus[0].MenuId;
            for (int i = 0; i<intLen; i++)
            {
                clsQxPrjMenusEN objQxPrjMenus = arrQxPrjMenus[i];
                string strCurrMenuName = objQxPrjMenus.MenuName;
                string strCurrMenuId = objQxPrjMenus.MenuId;
                //string strMenuSetId = objQxPrjMenus.MenuSetId;
                if (strCurrMenuName != strLastMenuName)
                {
                    strLastMenuName = strCurrMenuName;
                    strFstMenuId = strCurrMenuId;
                    continue;
                }
                //var objQxPrjMenuSet = clsQxPrjMenuSetBL.GetObjByMenuSetIdCache(strMenuSetId);
                string strWhere_RoleMenus = $"{conQxRoleMenus.MenuId} = '{strCurrMenuId}' ";
                bool bolIsExist = clsQxRoleMenusBL.IsExistRecord(strWhere_RoleMenus);
                
                if (strCurrMenuId == strFstMenuId)
                {
                    if (bolIsExist == false)
                    {
                        var objQxRoleMenus = new clsQxRoleMenusEN();
                        objQxRoleMenus.MenuId = strCurrMenuId;
                        objQxRoleMenus.QxPrjId = strQxPrjId;
                        //objQxRoleMenus.CmPrjId = objQxPrjMenus.CmPrjId;
                        //objQxRoleMenus.MenuSetId = strMenuSetId;
                        objQxRoleMenus.RoleId = $"{strQxPrjId}0000";
                        objQxRoleMenus.IsDisp = true;
                        objQxRoleMenus.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                        objQxRoleMenus.UpdUserId = "pyf";
                        var strUniCondition = objQxRoleMenus.GetUniCondStr();
                        if (clsQxRoleMenusBL.IsExistRecord(strUniCondition) == false) objQxRoleMenus.AddNewRecord();
                    }
                    continue;
                }
                else
                {
                    if (bolIsExist == false)
                    {
                        var objQxRoleMenus = new clsQxRoleMenusEN();
                        objQxRoleMenus.MenuId = strFstMenuId;
                        objQxRoleMenus.QxPrjId = strQxPrjId;
                        //objQxRoleMenus.CmPrjId = objQxPrjMenuSet.CmPrjId;
                        //objQxRoleMenus.MenuSetId = strMenuSetId;
                        objQxRoleMenus.RoleId = $"{strQxPrjId}0000";
                        objQxRoleMenus.IsDisp = true;
                        objQxRoleMenus.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                        objQxRoleMenus.UpdUserId = "pyf";
                        var strUniCondition = objQxRoleMenus.GetUniCondStr();
                        if (clsQxRoleMenusBL.IsExistRecord(strUniCondition) == false)                        objQxRoleMenus.AddNewRecord();
                    }
                    else
                    {
                        var arrQxRoleMenus = clsQxRoleMenusBL.GetObjLst(strWhere_RoleMenus);
                        foreach(var objInFor in arrQxRoleMenus)
                        {
                            objInFor.MenuId = strFstMenuId;
                            objInFor.Update();
                        }                  
                    }
                    objQxPrjMenus.Memo = "待删除";
                    objQxPrjMenus.Update();
                }

            }
            return true;

        }

        public static System.Data.DataTable GetMenuId()
        {
            //获取某学院所有专业信息
            string strSQL = "select MenuId, MenuName from QxPrjMenus ";
            clsSpecSQLforSql mySql = new clsSpecSQLforSql();
            System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
            return objDT;
        }
        public static void BindCbo_MenuId(System.Windows.Forms.ComboBox objComboBox)
        {
            //为数据源为表的下拉框设置内容
            System.Data.DataTable objDT = GetMenuId();
            clsQxPrjMenusEN objQxPrjMenus;
            //初始化一个对象列表
            ArrayList QxPrjMenusList = new ArrayList();
            //插入第0项。在第0项中插入“请选择...”，为了方便用户，与WEB方式类似。
            objQxPrjMenus = new clsQxPrjMenusEN()
            {
                MenuId = "0",
                MenuName = "请选择..."
            };
            QxPrjMenusList.Add(objQxPrjMenus);
            //把DataTable中的所有项均加到对象列表中
            foreach (DataRow objRow in objDT.Rows)
            {
                objQxPrjMenus = new clsQxPrjMenusEN();
                objQxPrjMenus.MenuId = objRow["MenuId"].ToString();
                objQxPrjMenus.MenuName = objRow["MenuName"].ToString();
                QxPrjMenusList.Add(objQxPrjMenus);
            }
            //设置下拉框的数据源、以及设置值项、显示项
            objComboBox.DataSource = QxPrjMenusList;
            objComboBox.ValueMember = "MenuId";
            objComboBox.DisplayMember = "MenuName";
            objComboBox.SelectedIndex = 0;
        }

        ///绑定下拉框的函数代码
        public static void BindDdl_MenuId(System.Web.UI.WebControls.DropDownList objDDL)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            System.Data.DataTable objDT = GetMenuId();
            objDDL.DataValueField = "MenuId";
            objDDL.DataTextField = "MenuName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_QxPrjMenus(System.Windows.Forms.ListView lvQxPrjMenus, string strWhereCond)
        {
            //操作步骤：(共4步)
            //	1、组合界面条件串；
            //	2、根据条件串获取该表满足条件的DataTable；
            //	3、设置ListView的列头信息
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            //		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviQxPrjMenus;
            List<clsQxPrjMenusEN> arrQxPrjMenusObjList;
            //	2、根据条件串获取该表满足条件的DataTable；
            arrQxPrjMenusObjList = clsQxPrjMenusBL.GetObjLst(strWhereCond);
            //	3、设置ListView的列头信息
            lvQxPrjMenus.Items.Clear();//清除原来所有Item
            lvQxPrjMenus.Columns.Clear();//清除原来所有列头信息
            lvQxPrjMenus.Columns.Add("菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxPrjMenus.Columns.Add("菜单名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxPrjMenus.Columns.Add("项目编号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxPrjMenus.Columns.Add("上级菜单Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxPrjMenus.Columns.Add("链接文件", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxPrjMenus.Columns.Add("图像文件", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxPrjMenus.Columns.Add("角色Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxPrjMenus.Columns.Add("排序号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxPrjMenus.Columns.Add("是否叶子", 100, System.Windows.Forms.HorizontalAlignment.Left);
            //lvQxPrjMenus.Columns.Add("菜单集Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxPrjMenus.Columns.Add("菜单标题", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxPrjMenus.Columns.Add("页面显示模式Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvQxPrjMenus.View = System.Windows.Forms.View.Details;
            //	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsQxPrjMenusEN objQxPrjMenus in arrQxPrjMenusObjList)
            {
                lviQxPrjMenus = new System.Windows.Forms.ListViewItem();
                lviQxPrjMenus.Tag = objQxPrjMenus.MenuId;
                lviQxPrjMenus.Text = objQxPrjMenus.MenuId.ToString();
                lviQxPrjMenus.SubItems.Add(objQxPrjMenus.MenuName);
                lviQxPrjMenus.SubItems.Add(objQxPrjMenus.QxPrjId);
                lviQxPrjMenus.SubItems.Add(objQxPrjMenus.UpMenuId);
                lviQxPrjMenus.SubItems.Add(objQxPrjMenus.LinkFile);
                lviQxPrjMenus.SubItems.Add(objQxPrjMenus.ImgFile);
                lviQxPrjMenus.SubItems.Add(objQxPrjMenus.RoleId);
                lviQxPrjMenus.SubItems.Add(objQxPrjMenus.OrderNum.ToString());
                lviQxPrjMenus.SubItems.Add(objQxPrjMenus.IsLeafNode.ToString());
                //lviQxPrjMenus.SubItems.Add(objQxPrjMenus.MenuSetId);
                lviQxPrjMenus.SubItems.Add(objQxPrjMenus.MenuTitle);
                lviQxPrjMenus.SubItems.Add(objQxPrjMenus.PageDispModeId);
                lvQxPrjMenus.Items.Add(lviQxPrjMenus);
            }
            //	4、设置记录数的状态，
            //		在本界面中是把状态显示在控件txtRecCount中。
            return arrQxPrjMenusObjList.Count;
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strMenuId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsQxPrjMenusEN GetQxPrjMenusObjByMenuId(string strMenuId)
        {
            if (arrQxPrjMenusObjLst == null)
            {
                arrQxPrjMenusObjLst = clsQxPrjMenusBL.GetObjLst("1=1");
            }
            foreach (clsQxPrjMenusEN objQxPrjMenus in arrQxPrjMenusObjLst)
            {
                if (objQxPrjMenus.MenuId == strMenuId)
                {
                    return objQxPrjMenus;
                }
            }
            return null;
        }


        /// <summary>
        /// 根据菜单名称（MenuName）获取相关对象, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strMenuId">所给的菜单名称</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsQxPrjMenusEN GetQxPrjMenusObjByMenuNameEx(string strMenuName, string strPrjId)
        {
            if (arrQxPrjMenusObjLst == null)
            {
                arrQxPrjMenusObjLst = clsQxPrjMenusBL.GetObjLst("1=1");
            }
            foreach (clsQxPrjMenusEN objQxPrjMenus in arrQxPrjMenusObjLst)
            {
                if (objQxPrjMenus.MenuName == strMenuName && objQxPrjMenus.QxPrjId == strPrjId)
                {
                    return objQxPrjMenus;
                }
            }
            return null;
        }
        /// <summary>
        /// 获取某工程的顶层菜单数
        /// </summary>
        /// <param name="strPrjId">需要计算顶层菜单数的工程号</param>
        /// <returns>工程的顶层菜单数</returns>
        public static int getTopMenuCount(string strPrjId)
        {
            int intTopMenuCount;        //顶级菜单数
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("QxPrjId='{0}' and UpMenuId = '00000000'", strPrjId); //组合条件
            intTopMenuCount = clsQxPrjMenusBL.GetRecCountByCond(strCondition.ToString());
            return intTopMenuCount;
        }
        /// <summary>
        /// 获取某工程、某顶层下的子菜单数
        /// </summary>
        /// <param name="strPrjId">需要计算顶层子菜单数的工程号</param>
        /// <param name="strUpMenuId">需要计算顶层的子菜单数的顶层菜单号</param>
        /// <returns>工程中某顶层的子菜单数</returns>
        public static int getSubMenuCount(string strPrjId, string strUpMenuId)
        {
            int intSubMenuCount;        //顶级菜单数
            StringBuilder strCondition = new StringBuilder();
            strCondition.AppendFormat("QxPrjId='{0}' and UpMenuId = '{1}'", strPrjId, strUpMenuId); //组合条件
            intSubMenuCount = clsQxPrjMenusBL.GetRecCountByCond(strCondition.ToString());
            return intSubMenuCount;
        }
        /// <summary>
        /// 获取新的子菜单的序号
        /// </summary>
        /// <param name="strPrjId"></param>
        /// <param name="strUpMenuId"></param>
        /// <returns></returns>
        public int getNewSubMenuOrderNum(string strPrjId, string strUpMenuId)
        {
            ///操作步骤：
            ///1、获取当前顶层菜单号的OrderNum
            ///2、获取当前顶层菜单的子菜单数
            ///3、计算新的子菜单的OrderNum,计算公式如下：
            ///        intNewSubMenuOrderNum = 顶层菜单的OrderNum  + 顶层菜单的子菜单数 +1
            ///4、返回intNewSubMenuOrderNum
            ///
            int intNewSubMenuOrderNum;
            int intSubMenuCount;
            int intTopMenuOrderNum;
            ///1、获取当前顶层菜单号的OrderNum
            intTopMenuOrderNum = int.Parse(clsQxPrjMenusBL.GetFldValue("OrderNum", "MenuId='" + strUpMenuId + "'")[0].ToString());
            ///2、获取当前顶层菜单的子菜单数
            intSubMenuCount = getSubMenuCount(strPrjId, strUpMenuId);
            ///3、计算新的子菜单的OrderNum,计算公式如下：
            ///        intNewSubMenuOrderNum = 顶层菜单的OrderNum  + 顶层菜单的子菜单数 +1
            intNewSubMenuOrderNum = intTopMenuOrderNum + intSubMenuCount + 1;
            ///4、返回intNewSubMenuOrderNum
            return intNewSubMenuOrderNum;
        }


        /// <summary>
        /// 功能：下降顶层菜单的序号，仅仅1步
        /// </summary>
        /// <param name="strPrjId">工程号</param>
        /// <param name="strMenuId">顶层菜单号</param>
        /// <returns>如果增1成功就返回true, 否则返回false</returns>
        public bool DownOrderByOneForTopMenu(string strPrjId, string strMenuId)
        {
            ///操作步骤：
            ///1、获取当前工程中的顶层菜单的数目(intTopMenusNum, 顶层菜单的数目)；
            ///2、获取当前菜单号的序号(intCurrOrderNums)；
            ///3、如果当前顶层菜单的序号大于或等于(intTopMenusNum, 顶层菜单的数目)记录数,就退出本过程，并返回false；
            ///4、获取下一个顶层菜单的关键字(strMenuIdForNextTopMenu)；
            ///5、修改当前顶层菜单的序号，使之增100，而且使子菜单的的序号也增加100；
            ///6、修改下一个顶层菜单的序号，使之减100，而且使子菜单的序号也减少100；
            ///7、返回TRUE；

            int intTopMenusNums; //当前工程的顶层菜单的数目
            int intCurrOrderNum;
            int intNextTopMenuOrderNum;
            string strMenuIdForNextTopMenu;   //下条记录(下一步骤序号)的关键字
            string strSQL;
            List<string> arrLst;
            ///1、获取当前工程中的顶层菜单的数目(intTopMenusNum, 顶层菜单的数目)；
            intTopMenusNums = clsQxPrjMenusBL.GetRecCountByCond("QxPrjId='" + strPrjId + "' and UpMenuId='00000000'");
            ///2、获取当前菜单号的序号(intCurrOrderNums)；
            arrLst = clsQxPrjMenusBL.GetFldValue("OrderNum", "QxPrjId='" + strPrjId + "' and MenuId='" + strMenuId + "'");
            intCurrOrderNum = int.Parse(arrLst[0].ToString());
            ///3、如果当前顶层菜单的序号大于或等于(intTopMenusNum, 顶层菜单的数目)记录数,就退出本过程，并返回false；
            if (intCurrOrderNum / 100 >= intTopMenusNums) return false;
            ///4、获取下一个顶层菜单的关键字(strMenuIdForNextTopMenu)；
            intNextTopMenuOrderNum = intCurrOrderNum + 100;

            arrLst = clsQxPrjMenusBL.GetFldValue("MenuId", "QxPrjId='" + strPrjId + "' and OrderNum=" + intNextTopMenuOrderNum.ToString());
            strMenuIdForNextTopMenu = arrLst[0].ToString();

            ///5、修改当前顶层菜单的序号，使之增100，而且使子菜单的的序号也增加100；
            clsSpecSQL objSQL = new clsSpecSQL();
            strSQL = "Update QxPrjMenus set OrderNum = OrderNum + 100 where MenuId = '" + strMenuId + "' or UpMenuId = '" + strMenuId + "'";
            objSQL.ExecSql(strSQL);
            ///6、修改下一个顶层菜单的序号，使之减100，而且使子菜单的序号也减少100；
            strSQL = "Update QxPrjMenus set OrderNum = OrderNum - 100 where  MenuId = '" + strMenuIdForNextTopMenu + "' or UpMenuId = '" + strMenuIdForNextTopMenu + "'";
            objSQL.ExecSql(strSQL);
            ///7、返回TRUE；
            return true;
        }
        /// <summary>
        /// 功能：子顶层菜单的序号，仅仅1步
        /// </summary>
        /// <param name="strPrjId">工程号</param>
        /// <param name="strMenuId">顶层菜单号</param>
        /// <returns>如果增1成功就返回true, 否则返回false</returns>
        public bool DownOrderByOneForSubMenu(string strPrjId, string strMenuId)
        {
            ///操作步骤：
            ///1、获取当前工程中的当前子菜单的父菜单的子菜单数目(intSubMenusNums, 子菜单的数目)；
            ///2、获取当前菜单号的序号(intCurrOrderNums)；
            ///3、如果当前子菜单的序号大于或等于(intSubMenusNums, 子菜单的数目)记录数,就退出本过程，并返回false；
            ///4、获取下一个子菜单的关键字(strMenuIdForNextSubMenu)；
            ///5、修改当前子菜单的序号，使之增1；
            ///6、修改下一个子菜单的序号，使之减1；
            ///7、返回TRUE；

            int intSubMenusNums; //当前工程的顶层菜单的数目
            int intCurrOrderNum;
            int intNextSubMenuOrderNum;
            string strTopMenuId;
            string strMenuIdForNextSubMenu;   //下条记录(下一步骤序号)的关键字
            string strSQL;
            List<string> arrLst;
            ///1、获取当前工程中的当前子菜单的父菜单的子菜单数目(intSubMenusNums, 子菜单的数目)；
            arrLst = clsQxPrjMenusBL.GetFldValue("UpMenuId", "QxPrjId='" + strPrjId + "' and MenuId='" + strMenuId + "'");
            strTopMenuId = arrLst[0].ToString();
            intSubMenusNums = clsQxPrjMenusBL.GetRecCountByCond("QxPrjId='" + strPrjId + "' and UpMenuId='" + strTopMenuId + "'");
            ///2、获取当前菜单号的序号(intCurrOrderNum)；
            arrLst = clsQxPrjMenusBL.GetFldValue("OrderNum", "QxPrjId='" + strPrjId + "' and MenuId='" + strMenuId + "'");
            intCurrOrderNum = int.Parse(arrLst[0].ToString());
            ///3、如果当前子菜单的序号大于或等于(intSubMenusNums, 子菜单的数目)记录数,就退出本过程，并返回false；
            if (intCurrOrderNum % 100 >= intSubMenusNums) return false;
            ///4、获取下一个子菜单的关键字(strMenuIdForNextSubMenu)；
            intNextSubMenuOrderNum = intCurrOrderNum + 1;
            arrLst = clsQxPrjMenusBL.GetFldValue("MenuId", "QxPrjId='" + strPrjId + "' and OrderNum=" + intNextSubMenuOrderNum.ToString());
            strMenuIdForNextSubMenu = arrLst[0].ToString();
            ///5、修改当前子菜单的序号，使之增1；
            clsSpecSQL objSQL = new clsSpecSQL();
            strSQL = "Update QxPrjMenus set OrderNum = OrderNum + 1 where MenuId = '" + strMenuId + "'";
            objSQL.ExecSql(strSQL);
            ///6、修改下一个子菜单的序号，使之减1；
            strSQL = "Update QxPrjMenus set OrderNum = OrderNum - 1 where  MenuId = '" + strMenuIdForNextSubMenu + "'";
            objSQL.ExecSql(strSQL);
            ///7、返回TRUE；
            return true;
        }

        /// <summary>
        /// 功能：上移顶层菜单的序号，仅仅1步
        /// </summary>
        /// <param name="strPrjId">工程号</param>
        /// <param name="strMenuId">顶层菜单号</param>
        /// <returns>如果增1成功就返回true, 否则返回false</returns>
        public bool UpOrderByOneForTopMenu(string strPrjId, string strMenuId)
        {
            ///操作步骤：
            ///1、获取当前菜单号的序号(intCurrOrderNums)；
            ///2、如果当前顶层菜单的序号等于(intTopMenusNum, 顶层菜单的数目)100,就退出本过程，并返回false；
            ///3、获取上一个顶层菜单的关键字(strMenuIdForPrevTopMenu)；
            ///4、修改当前顶层菜单的序号，使之减100，而且使子菜单的的序号也减少100；
            ///5、修改上一个顶层菜单的序号，使之增加100，而且使子菜单的序号也增加100；
            ///6、返回TRUE；

            //			int intTopMenusNums; //当前工程的顶层菜单的数目
            int intCurrOrderNum;
            int intPrevTopMenuOrderNum;
            string strMenuIdForPrevTopMenu;   //上一个顶层菜单的关键字
            string strSQL;
            List<string> arrLst;
            ///1、获取当前菜单号的序号(intCurrOrderNums)；
            arrLst = clsQxPrjMenusBL.GetFldValue("OrderNum", "QxPrjId='" + strPrjId + "' and MenuId='" + strMenuId + "'");
            intCurrOrderNum = int.Parse(arrLst[0].ToString());
            ///2、如果当前顶层菜单的序号等于(intTopMenusNum, 顶层菜单的数目)100,就退出本过程，并返回false；
            if (intCurrOrderNum == 100) return false;
            ///3、获取上一个顶层菜单的关键字(strMenuIdForPrevTopMenu)；
            intPrevTopMenuOrderNum = intCurrOrderNum - 100;
            arrLst = clsQxPrjMenusBL.GetFldValue("MenuId", "QxPrjId='" + strPrjId + "' and OrderNum=" + intPrevTopMenuOrderNum.ToString());
            strMenuIdForPrevTopMenu = arrLst[0].ToString();
            ///4、修改当前顶层菜单的序号，使之减100，而且使子菜单的的序号也减少100；
            clsSpecSQL objSQL = new clsSpecSQL();
            strSQL = "Update QxPrjMenus set OrderNum = OrderNum - 100 where MenuId = '" + strMenuId + "' or UpMenuId = '" + strMenuId + "'";
            objSQL.ExecSql(strSQL);
            ///5、修改上一个顶层菜单的序号，使之增加100，而且使子菜单的序号也增加100；
            strSQL = "Update QxPrjMenus set OrderNum = OrderNum + 100 where  MenuId = '" + strMenuIdForPrevTopMenu + "' or UpMenuId = '" + strMenuIdForPrevTopMenu + "'";
            objSQL.ExecSql(strSQL);
            ///6、返回TRUE；
            return true;
        }
        /// <summary>
        /// 功能：上移子顶层菜单的序号，仅仅1步
        /// </summary>
        /// <param name="strPrjId">工程号</param>
        /// <param name="strMenuId">子菜单号</param>
        /// <returns>如果增1成功就返回true, 否则返回false</returns>
        public bool UpOrderByOneForSubMenu(string strPrjId, string strMenuId)
        {
            ///操作步骤：
            ///1、获取当前菜单号的序号(intCurrOrderNums)；
            ///2、如果当前子菜单的序号等于1,就退出本过程，并返回false；
            ///3、获取上一个子菜单的关键字(strMenuIdForPrevSubMenu)；
            ///4、修改当前子菜单的序号，使之减1；
            ///5、修改上一个子菜单的序号，使之增加1；
            ///6、返回TRUE；

            int intCurrOrderNum;
            int intPrevSubMenuOrderNum;
            //			string strTopMenuId;
            string strMenuIdForPrevSubMenu;   //下条记录(下一步骤序号)的关键字
            string strSQL;
            List<string> arrLst;

            ///1、获取当前菜单号的序号(intCurrOrderNums)；
            arrLst = clsQxPrjMenusBL.GetFldValue("OrderNum", "QxPrjId='" + strPrjId + "' and MenuId='" + strMenuId + "'");
            intCurrOrderNum = int.Parse(arrLst[0].ToString());
            ///2、如果当前子菜单的序号等于1,就退出本过程，并返回false；
            if (intCurrOrderNum % 100 == 1) return false;
            ///3、获取上一个子菜单的关键字(strMenuIdForPrevSubMenu)；
            intPrevSubMenuOrderNum = intCurrOrderNum - 1;
            arrLst = clsQxPrjMenusBL.GetFldValue("MenuId", "QxPrjId='" + strPrjId + "' and OrderNum=" + intPrevSubMenuOrderNum.ToString());
            if (arrLst.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("在工程:{0}中,", clsQxProjectsBL.GetPrjNameByQxPrjIdCache(strPrjId));
                sbMessage.AppendFormat("没有序号{0}的菜单项,请重新整理序号.", intPrevSubMenuOrderNum);
                throw new Exception(sbMessage.ToString());
            }
            strMenuIdForPrevSubMenu = arrLst[0].ToString();
            ///4、修改当前子菜单的序号，使之减1；
            clsSpecSQL objSQL = new clsSpecSQL();
            strSQL = "Update QxPrjMenus set OrderNum = OrderNum - 1 where MenuId = '" + strMenuId + "'";
            objSQL.ExecSql(strSQL);
            ///5、修改上一个子菜单的序号，使之增加1；
            strSQL = "Update QxPrjMenus set OrderNum = OrderNum + 1 where  MenuId = '" + strMenuIdForPrevSubMenu + "'";
            objSQL.ExecSql(strSQL);
            ///6、返回TRUE；
            return true;
        }




        /// <summary>
        /// 功能：上升序号，仅仅1步
        /// </summary>
        /// <param name="strViewId">界面ID</param>
        /// <param name="intStepIndex">当前步骤序号</param>
        /// <returns>如果增1成功就返回true, 否则返回false.</returns>
        public bool UpOrderByOne(string strViewId, int intStepIndex)
        {
            ///操作步骤：
            ///1、如果当前步骤序号等于1, 就退出本过程，并返回false；
            ///2、获取当前记录(本操作序号)的关键字(bintIdForCurrStep)；
            ///3、获取下条记录(上一步骤序号)的关键字(bintIdForPrevStep)；
            ///4、修改当前步骤的序号，使之减1；
            ///5、修改上一步骤的序号，使之增1；
            ///6、返回TRUE；

            //			int intStepsNum; //操作步骤的数目
            //			long lngIdForCurrStep, lngIdForPrevStep;   //当前记录(本操作序号)的关键字,下条记录(下一步骤序号)的关键字
            //			int intPrevStepIndex;
            //			ArrayList arrLst;
            //			///1、如果当前步骤序号等于1, 就退出本过程，并返回false；
            //			if (intStepIndex == 1) return false;
            //			///2、获取当前记录(本操作序号)的关键字(lngIdForCurrStep)；
            //			arrLst = funGetFldValue("mId",  "ViewId='" + strViewId + "' and StepIndex=" + intStepIndex.ToString());
            //			lngIdForCurrStep =long.Parse(arrLst[0].ToString());
            //			///3、获取下条记录(下一步骤序号)的关键字(lngIdForNextStep)；
            //			intPrevStepIndex = intStepIndex - 1;
            //			arrLst = funGetFldValue("mId",  "ViewId='" + strViewId + "' and StepIndex=" + intPrevStepIndex.ToString());
            //			lngIdForPrevStep = long.Parse(arrLst[0].ToString());
            //			///4、修改当前步骤的序号，使之减1；
            //			funSetFldValue("StepIndex", intPrevStepIndex.ToString(), "mId=" + lngIdForCurrStep.ToString());
            //			///5、修改上一步骤的序号，使之增1；
            //			funSetFldValue("StepIndex", intStepIndex.ToString(), "mId=" + lngIdForPrevStep.ToString());
            ///7、返回TRUE；
            return true;
        }

        public static bool DelRecordForTopMenuEx(string strMenuId)
        {
            ///操作步骤：
            ///1、获取当前顶层菜单的步骤序号；
            ///2、获取当前工程号(strCurrPrjId)；
            ///3、删除当前顶层菜单以及他的子菜单；
            ///4、把后面的顶层菜单以及他们的子菜单的步骤序号都减100；
            ///5、返回TRUE；
            int intCurrOrderNum, intNextTopMenuOrderNum;
            //			string strTopMenuId;
            string strCurrPrjId;
            List<string> arrLst;

            ///1、获取当前顶层菜单的步骤序号；
            arrLst = clsQxPrjMenusBL.GetFldValue("OrderNum", "MenuId='" + strMenuId + "'");
            intCurrOrderNum = int.Parse(arrLst[0].ToString());
            ///2、获取当前工程号(strCurrPrjId)；
            arrLst = clsQxPrjMenusBL.GetFldValue("QxPrjMenus", conQxProjects.QxPrjId, "MenuId='" + strMenuId + "'");
            strCurrPrjId = arrLst[0].ToString();
            ///3、删除当前顶层菜单以及他的子菜单；
            clsQxPrjMenusBL.DelRecord(strMenuId);
            ///4、把后面的顶层菜单以及他们的子菜单的步骤序号都减100；
            string strSQL;
            clsSpecSQL objSQL = new clsSpecSQL();
            intNextTopMenuOrderNum = intCurrOrderNum + 100; //获取下一个顶层菜单的步骤序号
            strSQL = "Update QxPrjMenus set OrderNum = OrderNum - 100 where  QxPrjId = '" + strCurrPrjId + "' and OrderNum >= " + intNextTopMenuOrderNum;
            objSQL.ExecSql(strSQL);
            ///5、返回TRUE；
            return true;
        }
        public static bool DelRecordForSubMenuEx(string strMenuId)
        {
            ///操作步骤：
            ///1、获取当前子菜单的步骤序号；
            ///2、获取当前子菜单的顶层菜单(strTopMenuId);
            ///3、删除当前子菜单；
            ///4、把该子菜单后面的兄弟菜单的步骤序号都减1；
            ///5、返回TRUE；
            int intCurrOrderNum;
            string strTopMenuId;
            List<string> arrLst;
            ///1、获取当前子菜单的步骤序号；
            arrLst = clsQxPrjMenusBL.GetFldValue("QxPrjMenus", "OrderNum", "MenuId='" + strMenuId + "'");
            intCurrOrderNum = int.Parse(arrLst[0].ToString());
            ///2、获取当前子菜单的顶层菜单(strTopMenuId);
            arrLst = clsQxPrjMenusBL.GetFldValue("QxPrjMenus", "UpMenuId", "MenuId='" + strMenuId + "'");
            strTopMenuId = arrLst[0].ToString();
            ///3、删除当前子菜单；
            if (clsQxPrjMenusBL.DelRecord(strMenuId) == 0)
            {
                return false;
            };
            ///4、把该子菜单后面的兄弟菜单的步骤序号都减1；
            string strSQL;
            clsSpecSQL objSQL = new clsSpecSQL();
            strSQL = "Update QxPrjMenus set OrderNum = OrderNum - 1 where  UpMenuId = '" + strTopMenuId + "' and OrderNum > " + intCurrOrderNum;
            objSQL.ExecSql(strSQL);
            ///5、返回TRUE；
            return true;
        }

        /// <summary>
        /// 功能：获取某一条件的DataTable，其中的代码转换成相应的名称
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回已经转换代码的DataTable</returns>
        public static System.Data.DataTable GetViewOptStepsT(string strCondition, string strOrderBy)
        {
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQL objSQL = new clsSpecSQL();
            strSQL.Append("Select ViewOptSteps.* ");
            strSQL.Append(", ViewInfo.ViewName ViewInfoViewName ");
            strSQL.Append(" from ViewOptSteps ");
            strSQL.Append(" left JOIN ViewInfo on ViewOptSteps.ViewId = ViewInfo.ViewId ");
            strSQL.Append(" where " + strCondition);
            if (strOrderBy.Length > 0)
            {
                strSQL.AppendFormat(" order by {0}", strOrderBy);
            }
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }
        public DataTable GetTableEx(string strCondtion, string strOrderBy)
        {
            string strSQL;
            System.Data.DataTable objDT = null;
            clsSpecSQL objSQL = new clsSpecSQL();
            strSQL = "Select * from QxPrjMenus where " + strCondtion;
            if (strOrderBy.Length > 0)
            {
                strSQL += " order by " + strOrderBy;
            }

            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                clsGeneralTab2.LogErrorS(objException, "clsQxPrjMenusBLEx");
                throw new Exception("", objException);
            }
            finally
            {
            }
            return objDT;
        }


        public DataTable GetTableExWithRoleId(string strCondtion, string strOrderBy, string strRoleId, string strPrjId)
        {
            string strSQL;
            System.Data.DataTable objDT = null;
            clsSpecSQL objSQL = new clsSpecSQL();
            StringBuilder strCondition = new StringBuilder();
            strCondition.Append("Select QxPrjMenus.QxPrjId As QxPrjId, QxPrjMenus.MenuId AS MenuId,QxPrjMenus.UpMenuId AS UpMenuId, QxPrjMenus.MenuName AS MenuName, QxPrjMenus.OrderNum As OrderNum,QxPrjMenus.ImgFile As ImgFile,QxPrjMenus.LinkFile As LinkFile,");
            strCondition.Append("QxRoleMenus.RoleId AS QxRoleMenusRoleId ,QxRoleMenus.MenuId AS RoleMenuId, QxPrjMenus.MenuSetId as MenuSetId ");
            strCondition.AppendFormat(" FROM QxPrjMenus ");
            strCondition.AppendFormat(" LEFT OUTER JOIN QxRoleMenus ON QxPrjMenus.MenuId = QxRoleMenus.MenuId ");
            strCondition.AppendFormat(" and QxRoleMenus.RoleId = '{0}' ", strRoleId);
            strCondition.AppendFormat(" and QxRoleMenus.QxPrjId = '{0}' ", strPrjId);
            strCondition.AppendFormat(" where {0}", strCondtion);
            strSQL = strCondition.ToString();
            //			strSQL = "Select QxPrjMenus.MenuId AS MenuId,QxPrjMenus.UpMenuId AS UpMenuId, QxPrjMenus.MenuName AS MenuName, QxPrjMenus.OrderNum As OrderNum,QxRoleMenus.MenuId AS RoleMenuId FROM QxPrjMenus LEFT OUTER JOIN QxRoleMenus ON QxPrjMenus.MenuId = QxRoleMenus.MenuId where " + strCondtion;
            if (strOrderBy.Length > 0)
            {
                strSQL += " order by " + strOrderBy;
            }

            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                clsGeneralTab2.LogErrorS(objException, "clsQxPrjMenusBLEx");
                throw new Exception("", objException);
            }
            finally
            {
            }
            return objDT;
        }


        ///绑定下拉框的函数代码
        public static void BindDdl_MenuIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            //string strCondition = string.Format("QxPrjId ='{0}'", strPrjId);
            System.Data.DataTable objDT = clsQxPrjMenusDAEx.GetMenuIdEx(strPrjId);
            objDDL.DataValueField = "MenuId";
            objDDL.DataTextField = "MenuName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        ///绑定下拉框的函数代码
        public static void BindDdl_MenuId4IsLeafEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            //string strCondition = string.Format("QxPrjId ='{0}'", strPrjId);
            System.Data.DataTable objDT = clsQxPrjMenusDAEx.GetMenuId4IsLeafEx(strPrjId);
            objDDL.DataValueField = "MenuId";
            objDDL.DataTextField = "MenuName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public static void BindDdl_MenuIdByMenuSetId(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId,
            string strMenuSetId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            string strCondition = string.Format("QxPrjId ='{0}' And {1}='{2}'",
                strPrjId,
                conQxPrjMenus.MenuId, strMenuSetId);
            List<clsQxPrjMenusEN> arrQxPrjMenusObjLst = clsQxPrjMenusBL.GetObjLst(strCondition);
            foreach (clsQxPrjMenusEN objQxPrjMenusEN in arrQxPrjMenusObjLst)
            {
                if (objQxPrjMenusEN.UpMenuId == "00000000")
                {
                    objQxPrjMenusEN._IntTag = 1;
                }
            }
            foreach (clsQxPrjMenusEN objQxPrjMenusEN in arrQxPrjMenusObjLst)
            {

                if (objQxPrjMenusEN.UpMenuId == "00000000") continue;

                clsQxPrjMenusEN objQxPrjMenusEN_Parent = clsQxPrjMenusBL.GetObjByMenuIdFromList(objQxPrjMenusEN.UpMenuId, arrQxPrjMenusObjLst);
                if (objQxPrjMenusEN_Parent == null) continue;
                if (objQxPrjMenusEN_Parent._IntTag == 0) continue;
                objQxPrjMenusEN._IntTag = objQxPrjMenusEN_Parent._IntTag + 1;

            }

            foreach (clsQxPrjMenusEN objQxPrjMenusEN in arrQxPrjMenusObjLst)
            {
                if (objQxPrjMenusEN.UpMenuId == "00000000") continue;

                clsQxPrjMenusEN objQxPrjMenusEN_Parent = clsQxPrjMenusBL.GetObjByMenuIdFromList(objQxPrjMenusEN.UpMenuId, arrQxPrjMenusObjLst);
                if (objQxPrjMenusEN_Parent == null) continue;
                if (objQxPrjMenusEN_Parent._IntTag == 0) continue;
                objQxPrjMenusEN._IntTag = objQxPrjMenusEN_Parent._IntTag + 1;

            }
            foreach (clsQxPrjMenusEN objQxPrjMenusEN in arrQxPrjMenusObjLst)
            {
                objQxPrjMenusEN.MenuName = string.Format("{0}-{1}", objQxPrjMenusEN._IntTag, objQxPrjMenusEN.MenuName);
            }
            arrQxPrjMenusObjLst.Sort(
                delegate (clsQxPrjMenusEN objQxPrjMenusEN1, clsQxPrjMenusEN objQxPrjMenusEN2)
                {
                    if (objQxPrjMenusEN1.MenuName.CompareTo(objQxPrjMenusEN2.MenuName) > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                });

            objDDL.DataValueField = "MenuId";
            objDDL.DataTextField = "MenuName";
            objDDL.DataSource = arrQxPrjMenusObjLst;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }

        public static bool SetPrjMenuSet(string strMenuId, string strMenuSetId, string strUserId)
        {
            clsQxPrjMenusEN objQxPrjMenusEN = clsQxPrjMenusBL.GetObjByMenuId(strMenuId);

            //objQxPrjMenusEN.MenuSetId = strMenuSetId;
            objQxPrjMenusEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
            objQxPrjMenusEN.UpdUserId = strUserId;
            objQxPrjMenusEN.Memo = "设置菜单集";
            return clsQxPrjMenusBL.UpdateBySql2(objQxPrjMenusEN);
        }

    }
}