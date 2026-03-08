
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsTSysParaBLEx
表名:TSysPara
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:06:51
生成者:
工程名称:统一平台
工程ID:0014
模块中文名:系统参数
模块英文名:SysPara
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
    /// 系统参数(TSysPara)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsTSysParaBLEx : clsTSysParaBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsTSysParaDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsTSysParaDAEx TSysParaDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsTSysParaDAEx();
                }
                return uniqueInstanceEx;
            }
        }


        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_TSysPara(System.Windows.Forms.ListView lvTSysPara, string strWhereCond)
        {
            // 操作步骤：(共4步)
            // 1、组合界面条件串；
            // 2、根据条件串获取该表满足条件的DataTable；
            // 3、设置ListView的列头信息
            // 4、设置ListView的Item信息。即把所有记录显示在ListView中
            //  在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviTSysPara;
            List<clsTSysParaEN> arrTSysParaObjList;
            // 2、根据条件串获取该表满足条件的DataTable；
            arrTSysParaObjList = clsTSysParaBL.GetObjLst(strWhereCond);
            // 3、设置ListView的列头信息
            lvTSysPara.Items.Clear();//清除原来所有Item
            lvTSysPara.Columns.Clear();//清除原来所有列头信息
            lvTSysPara.Columns.Add("流水号", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvTSysPara.Columns.Add("系统参数名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvTSysPara.Columns.Add("系统参数值", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvTSysPara.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvTSysPara.View = System.Windows.Forms.View.Details;
            // 4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsTSysParaEN objTSysPara in arrTSysParaObjList)
            {
                lviTSysPara = new System.Windows.Forms.ListViewItem();
                lviTSysPara.Tag = objTSysPara.mId;
                lviTSysPara.Text = objTSysPara.mId.ToString();
                lviTSysPara.SubItems.Add(objTSysPara.SysParaName);
                lviTSysPara.SubItems.Add(objTSysPara.SysParaValue);
                lviTSysPara.SubItems.Add(objTSysPara.Memo);
                lvTSysPara.Items.Add(lviTSysPara);
            }
            // 4、设置记录数的状态，
            //  在本界面中是把状态显示在控件txtRecCount中。
            return arrTSysParaObjList.Count;
        }
        /// <summary>
        /// 获取公司名称
        /// </summary>
        /// <param name="strSchoolId">学校Id</param>
        /// <returns></returns>
        public static string getCompanyName(string strSchoolId)
        {
            clsTSysParaEN objTSysParaEN = clsTSysParaBL.GetFirstObj_S(string.Format("SysParaName='CompanyName' And {0}='{1}'",
                conTSysPara.SchoolId, strSchoolId));
            if (objTSysParaEN == null)
            {
                string strMsg = string.Format("在表:[{0}]中，条件为:[{1}='CompanyName']的记录不存在！",
                    clsTSysParaEN._CurrTabName, conTSysPara.SysParaName);
                throw new Exception(strMsg);
            }
            return objTSysParaEN.SysParaValue;
        }
        /// <summary>
        /// 获取应用名称
        /// </summary>
        /// <param name="strSchoolId"></param>
        /// <returns></returns>
        public static string getApplicationName(string strSchoolId)
        {
            var arrTSysPara = clsTSysParaBL.GetObjLstCache();

            clsTSysParaEN objTSysParaEN = arrTSysPara.Find(x => x.SysParaName == "ApplicationName" && x.SchoolId == strSchoolId);
            if (objTSysParaEN == null)
            {
                string strMsg = string.Format("在表:[{0}]中，条件为:[{1}='ApplicationName'],SchoolId=[{2}]的记录不存在！",
                    clsTSysParaEN._CurrTabName, conTSysPara.SysParaName, strSchoolId);
                throw new Exception(strMsg);
            }

            return objTSysParaEN.SysParaValue;
        }

        public static string getIsUseAvconPlay(string strSchoolId)
        {

            try
            {
                return clsTSysParaBL.GetFirstObj_S("SysParaName='IsUseAvconPlay'").SysParaValue;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaEx", "getIsUseAvconPlay", objException.Message, "pyf");
                return "False";
            }

        }
        /// <summary>
        /// 是否使用SilverLight播放视频
        /// </summary>
        /// <returns></returns>
        public static string getIsUseSilverLightPlay(string strSchoolId)
        {
            try
            {
                return clsTSysParaBL.GetFirstObj_S("SysParaName='IsUseSilverLightPlay' And SchoolId='" + strSchoolId + "'").SysParaValue;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaEx", "getIsUseSilverLightPlay", objException.Message, "pyf");
                return "False";
            }
        }
        /// <summary>
        /// 是否使用宽屏（WidePage)
        /// </summary>
        /// <returns></returns>
        public static string getIsUseWidePage(string strSchoolId)
        {
            try
            {
                return clsTSysParaBL.GetFirstObj_S("SysParaName='IsUseWidePage' And SchoolId='" + strSchoolId + "'").SysParaValue;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaEx", "getIsUseWidePage", objException.Message, "pyf");
                return "True";
            }
        }

        /// <summary>
        /// 微格列表－是否使用宽屏（WidePage)
        /// </summary>
        /// <returns></returns>
        public static string getIsUseWidePage4MicroList(string strSchoolId)
        {
            try
            {
                return clsTSysParaBL.GetFirstObj_S("SysParaName='IsUseWidePage4MicroList' And SchoolId='" + strSchoolId + "'").SysParaValue;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaEx", "getIsUseWidePage4MicroList", objException.Message, "pyf");
                return "True";
            }
        }

        /// <summary>
        /// 微格列表－是否使用行政班（AdminCls)
        /// </summary>
        /// <returns></returns>
        public static string getIsUseAdminCls4MicroList(string strSchoolId)
        {
            try
            {
                return clsTSysParaBL.GetFirstObj_S("SysParaName='IsUseAdminCls4MicroList' And SchoolId='" + strSchoolId + "'").SysParaValue;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaEx", "getIsUseAdminCls4MicroList", objException.Message, "pyf");
                return "True";
            }
        }

        /// <summary>
        /// 在微格编辑中是否使用Html编辑器
        /// </summary>
        /// <returns></returns>
        public static string getIsUseHtmlEditor4MicroTeachEdit(string strSchoolId)
        {
            try
            {
                return clsTSysParaBL.GetFirstObj_S("SysParaName='IsUseHtmlEditor4MicroTeachEdit' And SchoolId='" + strSchoolId + "'").SysParaValue;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaEx", "getIsUseHtmlEditor4MicroTeachEdit", objException.Message, "pyf");
                return "False";
            }
        }
        /// <summary>
        /// 是否使用学科学段
        /// </summary>
        /// <returns></returns>
        public static string getIsUseDisciplineStudyLevel(string strSchoolId)
        {
            try
            {
                return clsTSysParaBL.GetFirstObj_S("SysParaName='IsUseDisciplineStudyLevel' And SchoolId='" + strSchoolId + "'").SysParaValue;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaEx", "getIsUseDisciplineStudyLevel", objException.Message, "pyf");
                return "True";
            }
        }
        /// <summary>
        /// 根据参数名获取参数值, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strParaName">参数名称</param>
        /// <param name="strId_School">学校流水号</param>
        /// <returns>根据关键字获取的参数值</returns>
        public static string GetParaValueObjByParaNameAndId_School(string strParaName, string strId_School)
        {
            var arrTSysParaObjLst_Cache = clsTSysParaBL.GetObjLstCache();

            //if (clsTSysParaBL.arrTSysParaObjLst_Cache == null)
            //{
            //    switch(strId_School)
            //    {
            //        case enumXzSchool.JT_0009:
            //            clsTSysParaBL.arrTSysParaObjLst_Cache = new clsTSysParaDA().GetObjLstByTabName("1=1", "TSysPara_JT");
            //            break;
            //        default:
            //            clsTSysParaBL.arrTSysParaObjLst_Cache = new clsTSysParaDA().GetObjLst("1=1");
            //            break;
            //    }
            //}
            foreach (clsTSysParaEN objTSysParaEN in arrTSysParaObjLst_Cache)
            {
                if (objTSysParaEN.SysParaName.Equals(strParaName, StringComparison.InvariantCultureIgnoreCase) == true
                    && objTSysParaEN.IdSchool == strId_School
                    )
                {
                    return objTSysParaEN.SysParaValue;
                }
            }
            string strMsg = string.Format("在学校：{0}中，参数名：[{1}]不存在！", strId_School, strParaName);
            clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
            ErrorInformationBL.AddInformation("clsTSysParaEx", "GetParaValueObjByParaName", strMsg, "pyf");
            throw new Exception(strMsg);
            //            return "";
        }

        /// <summary>
        /// 获取当前学校
        /// </summary>
        /// <returns>当前学校名</returns>
        public static string GetCurrSchool()
        {
            var arrTSysParaObjLst_Cache = clsTSysParaBL.GetObjLstCache();

            foreach (clsTSysParaEN objTSysParaEN in arrTSysParaObjLst_Cache)
            {
                if (objTSysParaEN.SysParaName.Equals("School", StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    return objTSysParaEN.SysParaValue;
                }
            }
            return "";
        }
        /// <summary>
        /// 复制系统参数到新学校
        /// </summary>
        /// <param name="objTSysParaS">源系统参数对象</param>
        /// <param name="strSchoolId">新学校ID</param>
        /// <returns>是否成功？</returns>
        public static bool CopyTSysParaObjToNewSchool(clsTSysParaEN objTSysParaS, string strSchoolId)
        {
            clsTSysParaEN objTSysParaT = new clsTSysParaEN();
            clsTSysParaBL.CopyTo(objTSysParaS, objTSysParaT);
            objTSysParaT.SchoolId = strSchoolId;
            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat("SchoolId='{0}' and SysParaName='{1}'", strSchoolId, objTSysParaS.SysParaName);
            if (clsTSysParaBL.IsExistRecord(sbCondition.ToString()) == false)
            {
                return clsTSysParaBL.AddNewRecordBySql2(objTSysParaT);
            }
            return true;
        }
        /// <summary>
        /// 根据参数名获取参数值, 从缓存的对象列表中获取.
        /// </summary>
        /// <param name="strParaName">所给的参数名称</param>
        /// <param name="strId_School">学校流水号</param>
        /// <returns>根据关键字获取的参数值</returns>
        public static string GetParaValueObjByParaName(string strParaName, string strId_School)
        {
            var arrTSysParaObjLst_Cache = clsTSysParaBL.GetObjLstCache();

            foreach (clsTSysParaEN objTSysParaEN in arrTSysParaObjLst_Cache)
            {
                if (objTSysParaEN.SysParaName.Equals(strParaName, StringComparison.InvariantCultureIgnoreCase) == true
                    && objTSysParaEN.IdSchool.Equals(strId_School, StringComparison.InvariantCultureIgnoreCase) == true
                    )
                {
                    return objTSysParaEN.SysParaValue;
                }
            }
            string strSchoolName = clsXzSchoolBL.GetSchoolNameByIdSchoolCache(strId_School);
            ErrorInformationBL.AddInformation("clsTSysParaEx", "GetParaValueObjByParaName", string.Format("在学校：{0}中，参数名：{1}不存在！", strSchoolName, strParaName), "pyf");
            return "";
        }
        #region 学生照片
        /// <summary>
        /// 获取学生照片
        /// </summary>
        /// <param name="strSchoolId"></param>
        /// <returns></returns>
        public static string getStuPhoto(string strSchoolId)
        {

            try
            {
                string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).IdSchool;
                string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("学生照片", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
                return strParaValue;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaBLEx", "学生照片", objException.Message, "pyf");
                return "";
            }
        }
        #endregion 学生照片

        #region 有关排考
        /// <summary>
        /// 排考-教务处备注
        /// </summary>
        /// <param name="strSchoolId"></param>
        /// <returns></returns>
        public static string getPKaoMemoByAAO(string strSchoolId)
        {

            try
            {
                string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).IdSchool;
                string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("排考-教务处备注", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
                return strParaValue;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaBLEx", "排考-教务处备注", objException.Message, "pyf");
                return "";
            }
        }
        #endregion 有关排考

        /// <summary>
        /// 静态的对象列表，用于缓存，针对记录较少，作为参数表可以使用
        /// </summary>
        //public static List<clsTSysParaEN> arrTSysParaObjLst_Cache = null;
        /// <summary>
        /// 从缓存中查找失败的次数
        /// </summary>
        //private static int intFindFailCount = 0;



        #region 有关答疑参数设置
        /// <summary>
        /// 获取:是否可以设置答疑信息
        /// </summary>
        /// <param name="strSchoolId"></param>
        /// <returns></returns>
        public static bool getIsCanSetQAInfo(string strSchoolId)
        {

            try
            {
                string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).IdSchool;
                string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("是否可以设置答疑信息", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
                return bool.Parse(strParaValue);
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaBLEx", "是否可以设置答疑信息", objException.Message, "pyf");
                return false;
            }

        }

        /// <summary>
        /// 获取:答疑起止日期
        /// </summary>
        /// <param name="strSchoolId"></param>
        /// <returns></returns>
        public static string getQAStartAndEndDates(string strSchoolId)
        {

            try
            {
                string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).IdSchool;
                string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("答疑起止日期", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
                return strParaValue;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaBLEx", "答疑起止日期", objException.Message, "pyf");
                return "";
            }

        }

        /// <summary>
        /// 获取:答疑记录数
        /// </summary>
        /// <param name="strSchoolId"></param>
        /// <returns></returns>
        public static bool getQACountNum(string strSchoolId)
        {

            try
            {
                string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).IdSchool;
                string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("答疑记录数", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
                return bool.Parse(strParaValue);
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaBLEx", "答疑记录数", objException.Message, "pyf");
                return false;
            }

        }
        /// <summary>
        /// 获取:答疑查询有效期
        /// </summary>
        /// <param name="strSchoolId"></param>
        /// <returns></returns>
        public static bool getQAQueryValidity(string strSchoolId)
        {

            try
            {
                string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).IdSchool;
                string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("答疑查询有效期", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
                return bool.Parse(strParaValue);
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaBLEx", "答疑查询有效期", objException.Message, "pyf");
                return false;
            }
        }

        /// <summary>
        /// 获取缺省教学班流水号
        /// </summary>
        /// <param name="strSchoolId"></param>
        /// <returns></returns>
        public static bool getDefaId_CurrEduCls(string strSchoolId)
        {

            try
            {
                string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).IdSchool;
                string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("DefaId_CurrEduCls", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
                return bool.Parse(strParaValue);
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaBLEx", "答疑查询有效期", objException.Message, "pyf");
                return false;
            }
        }
        /// <summary>
        /// 获取:是否显示提交for教师
        /// </summary>
        /// <param name="strSchoolId"></param>
        /// <returns></returns>
        public static bool getIsShowSubmit4Teacher(string strSchoolId)
        {

            try
            {
                string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).IdSchool;
                string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("是否显示提交for教师", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
                return bool.Parse(strParaValue);
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaBLEx", "是否显示提交for教师", objException.Message, "pyf");
                return false;
            }
        }
        /// <summary>
        /// 获取:答疑学生显示方式
        /// </summary>
        /// <param name="strSchoolId"></param>
        /// <returns></returns>
        public static string getQAShowMode4Student(string strSchoolId)
        {

            try
            {
                string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).IdSchool;
                string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("答疑学生显示方式", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
                return strParaValue;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaBLEx", "答疑学生显示方式", objException.Message, "pyf");
                return "";
            }
        }
        #endregion
        #region 有关重修

        /// <summary>
        /// 获取:是否控制重修
        /// </summary>
        /// <param name="strSchoolId"></param>
        /// <returns></returns>
        public static bool getIsCtrlReStudy(string strSchoolId)
        {

            try
            {
                string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).IdSchool;
                string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("是否控制重修", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
                return bool.Parse(strParaValue);
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaBLEx", "是否控制重修", objException.Message, "pyf");
                return false;
            }

        }
        #endregion

        #region 有关排课
        /// <summary>
        /// 获取日时间片数
        /// </summary>
        /// <param name="strSchoolId"></param>
        /// <returns></returns>
        public static int getTimesliceNumPerDay(string strSchoolId)
        {
            try
            {
                string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).IdSchool;
                string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("日课时数", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
                return int.Parse(strParaValue);
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaBLEx", "日课时数", objException.Message, "pyf");
                return 0;
            }
        }

        /// <summary>
        /// 获取学期周数
        /// </summary>
        /// <param name="strSchoolId"></param>
        /// <returns></returns>
        public static int getWeeksNumPerSchoolTerm(string strSchoolId)
        {

            try
            {
                string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).IdSchool;

                string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("学期周数", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;

                return int.Parse(strParaValue);
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaBLEx", "学期周数", objException.Message, "pyf");
                return 0;
            }
        }

        /// <summary>
        /// 获取排课周数
        /// </summary>
        /// <param name="strSchoolId"></param>
        /// <returns></returns>
        public static int getPk2WeeksNumPerSchoolTerm(string strSchoolId)
        {
            try
            {
                string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).IdSchool;
                string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("排课周数", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
                return int.Parse(strParaValue);
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaBLEx", "排课周数", objException.Message, "pyf");
                return 0;
            }

        }
        /// <summary>
        /// 获取日常排课周数
        /// </summary>
        /// <param name="strSchoolId"></param>
        /// <returns></returns>
        public static int getCurrWeeksNumPerSchoolTerm(string strSchoolId)
        {
            try
            {
                string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).IdSchool;
                string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("日常排课周数", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
                return int.Parse(strParaValue);
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaBLEx", "日常排课周数", objException.Message, "pyf");
                return 0;
            }

        }
        /// <summary>
        /// 是否全部使用排课2
        /// </summary>
        /// <param name="strSchoolId"></param>
        /// <returns></returns>
        public static bool getIsAllUsePk2(string strSchoolId)
        {

            try
            {
                string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).IdSchool;

                string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("全部使用排课V2", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;

                return bool.Parse(strParaValue);
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaBLEx", "全部使用排课V2", objException.Message, "pyf");
                return false;
            }
        }

        #endregion 有关排课

        #region 有关成绩
        /// <summary>
        /// 获取优秀比例
        /// </summary>
        /// <param name="strSchoolId"></param>
        /// <returns></returns>
        public static int getExcellentPortion(string strSchoolId)
        {

            try
            {
                string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).IdSchool;
                string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("优秀比例", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
                return int.Parse(strParaValue);
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaBLEx", "优秀比例", objException.Message, "pyf");
                return 0;
            }
        }

        /// <summary>
        /// 获取优良比例
        /// </summary>
        /// <param name="strSchoolId"></param>
        /// <returns></returns>
        public static int getGoodPortion(string strSchoolId)
        {

            try
            {
                string strId_School = clsXzSchoolBLEx.GetXzSchoolObjBySchoolId(strSchoolId).IdSchool;
                string strParaValue = clsTSysParaBLEx.GetParaValueObjByParaName("优良比例", strId_School); //new clsTSysPara().GetFirstTSysPara("SysParaName='IsUseAvconPlay'").SysParaValue;
                return int.Parse(strParaValue);
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsTSysParaBLEx", "优良比例", objException.Message, "pyf");
                return 0;
            }
        }
        #endregion 有关成绩


    }
}