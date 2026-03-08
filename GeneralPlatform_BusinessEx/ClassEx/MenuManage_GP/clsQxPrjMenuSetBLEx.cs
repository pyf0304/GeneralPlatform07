
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxPrjMenuSetBLEx
表名:QxPrjMenuSet
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:05:26
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

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// 菜单集(QxPrjMenuSet)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsQxPrjMenuSetBLEx : clsQxPrjMenuSetBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxPrjMenuSetDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxPrjMenuSetDAEx QxPrjMenuSetDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxPrjMenuSetDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 静态的对象列表，用于缓存，针对记录较少，作为参数表可以使用
        /// </summary>
        public static List<clsQxPrjMenuSetEN> arrPrjMenuSetObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// </summary>
        private static int intFindFailCount = 0;


        ///绑定下拉框的函数代码
        public static void BindDdl_MenuSetIdEx(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择...", "0");
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" {1}='{0}'", strPrjId, conQxPrjMenuSet.QxPrjId);
            System.Data.DataTable objDT = clsQxPrjMenuSetBL.GetDataTable_QxPrjMenuSet(sbCondition.ToString());
            objDDL.DataValueField = "MenuSetId";
            objDDL.DataTextField = "MenuSetName";
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        public static string GetDefaultMenuSetIdByPrjId(string strPrjId)
        {
            string strCondition = string.Format("{1}='{0}' And IsDefault='1'", strPrjId, conQxPrjMenuSet.QxPrjId);
            List<string> arrMenuSetIdLst = clsQxPrjMenuSetBL.GetFldValueNoDistinct("MenuSetId", strCondition);
            if (arrMenuSetIdLst.Count > 0) return arrMenuSetIdLst[0];
            return "";
        }

        /// <summary>
        /// 根据关键字获取相关对象, 从缓存的对象列表中获取,使用顺序查询.
        /// </summary>
        /// <param name="strMenuSetId">所给的关键字</param>
        /// <returns>根据关键字获取的对象</returns>
        public static clsQxPrjMenuSetEN GetQxPrjMenuSetObjByMenuSetName_Cache_SeqEx(string strPrjId, string strMenuSetName)
        {
            if (string.IsNullOrEmpty(strMenuSetName) == true) return null;
            string strCondition = string.Format("{1}='{0}' order by MenuSetName", strPrjId, conQxPrjMenuSet.QxPrjId);
            if (arrPrjMenuSetObjLst_Cache == null)
            {
                arrPrjMenuSetObjLst_Cache = new clsQxPrjMenuSetDA().GetObjLst(strCondition);
            }
            foreach (clsQxPrjMenuSetEN objPrjMenuSetEN in arrPrjMenuSetObjLst_Cache)
            {
                if (objPrjMenuSetEN.MenuSetName == strMenuSetName && objPrjMenuSetEN.QxPrjId == strPrjId)
                {
                    intFindFailCount = 0;
                    return objPrjMenuSetEN;
                }
            }
            intFindFailCount++;
            // 静态的对象列表，用于缓存，针对记录较少，作为参数表可以使用
            arrPrjMenuSetObjLst_Cache = null;
            if (intFindFailCount == 1) return GetQxPrjMenuSetObjByMenuSetName_Cache_SeqEx(strPrjId, strMenuSetName);
            string strErrMsgForGetObjById = string.Format("在QxPrjMenuSet对象缓存列表中，找不到记录[MenuSetName={0}][intFindFailCount={1}](函数:GetQxPrjMenuSetObjByMenuSetName_Cache_Seq)", strMenuSetName, intFindFailCount);
            clsGeneralTab2.LogErrorS2("clsQxPrjMenuSetBLEx", "GetQxPrjMenuSetObjByMenuSetName_Cache_SeqEx", strErrMsgForGetObjById, "", "");
            throw new Exception(strErrMsgForGetObjById);
        }

    }
}