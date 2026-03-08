
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxFuncModuleBLEx
表名:QxFuncModule(00140086)
生成代码版本:2018.10.19.1
生成日期:2018/11/20 22:03:59
生成者:潘以锋
生成服务器IP:101.251.68.133
工程名称:统一平台
工程ID:0014
相关数据库:101.251.68.133,9433MSEduSys
PrjDataBaseId:0199
模块中文名:工程管理
模块英文名:PrjManage
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2018.07.27.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
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
using AGC.Entity;

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// 功能模块(QxFuncModule)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsQxFuncModuleBLEx : clsQxFuncModuleBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxFuncModuleDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxFuncModuleDAEx QxFuncModuleDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxFuncModuleDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DelRecordEx)
        /// </summary>
        /// <param name="strFuncModuleId">表关键字</param>
        /// <returns></returns>
        private static bool DelRecordEx(string strFuncModuleId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsQxFuncModuleDA.GetSpecSQLObj();
            //删除TeacherInfo本表中与当前对象有关的记录
            SqlConnection objConnection = null;
            SqlTransaction objSqlTransaction = null;
            try
            {
                //获取连接对象
                objConnection = objSQL.getConnectObj(objSQL.ConnectionString);
                //获取该连接对象中的事务
                objSqlTransaction = objConnection.BeginTransaction();
                //
                //删除与表:[QxFuncModule]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //constStudent.id_College,
                //strid_College);
                //        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsQxFuncModuleBL.DelRecord(strFuncModuleId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsQxFuncModuleBLEx", "DelRecordEx", objException.Message, Entity.clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strFuncModuleId, clsStackTrace.GetCurrClassFunction());
                clsPubVar4BLEx.objLog.WriteDebugLog(strMsg);
                if (objSqlTransaction != null)
                {
                    objSqlTransaction.Rollback();
                }
                throw new Exception(strMsg);
            }
            finally
            {
                objConnection.Close();
            }
        }

        /// <summary>
        /// 绑定基于Web的下拉框
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DdlBindFunction)
        /// </summary>
        /// <param name = "objDDL">需要绑定当前表的下拉框</param>
        public static void BindDdl_FuncModuleIdByPrjId(System.Web.UI.WebControls.DropDownList objDDL, string strPrjId)
        {
            //为数据源于表的下拉框设置内容
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("请选择[功能模块]...", "0");
            string strCondition = string.Format("1 =1  And {0}='{1}' And {2}='1' Order By {3}",
                conQxFuncModule.QxPrjId, strPrjId,
                conQxFuncModule.InUse,
                conQxFuncModule.OrderNum);
            System.Data.DataTable objDT = clsQxFuncModuleBL.GetDataTable(strCondition);
            objDDL.DataValueField = conQxFuncModule.FuncModuleId;
            objDDL.DataTextField = conQxFuncModule.FuncModuleName;
            objDDL.DataSource = objDT;
            objDDL.DataBind();
            objDDL.Items.Insert(0, li);
            objDDL.SelectedIndex = 0;
        }
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
        /// </summary>
        /// <param name = "objQxFuncModuleENS">源对象</param>
        /// <param name = "objQxFuncModuleENT">目标对象</param>
        public static void CopyTo(clsFuncModule_AgcEN objQxFuncModuleENS, clsQxFuncModuleEN objQxFuncModuleENT)
        {
            objQxFuncModuleENT.FuncModuleId = objQxFuncModuleENS.FuncModuleAgcId; //模块Id
            objQxFuncModuleENT.FuncModuleName = objQxFuncModuleENS.FuncModuleName; //模块名
            objQxFuncModuleENT.FuncModuleNameSim = objQxFuncModuleENS.FuncModuleNameSim; //模块名_Sim
            objQxFuncModuleENT.FuncModuleEnName = objQxFuncModuleENS.FuncModuleEnName; //模块英文名
            objQxFuncModuleENT.OrderNum = objQxFuncModuleENS.OrderNum; //排序号
            objQxFuncModuleENT.QxPrjId = objQxFuncModuleENS.PrjId; //项目Id
            objQxFuncModuleENT.InUse = true;// objQxFuncModuleENS.InUse; //是否在用
            objQxFuncModuleENT.UpdDate = objQxFuncModuleENS.UpdDate; //修改日期
            objQxFuncModuleENT.UpdUser = objQxFuncModuleENS.UpdUser; //修改用户
            //objQxFuncModuleENT.Memo = objQxFuncModuleENS.Memo; //备注
        }

    }
}