
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxFuncModule_AgcBLEx
表名:QxFuncModule_Agc(00140101)
生成代码版本:2019.08.02.1
生成日期:2019/08/05 03:10:57
生成者:
生成服务器IP:101.251.68.133
工程名称:统一平台
工程ID:0014
相关数据库:101.251.68.133,9433GeneralPlatformTz
PrjDataBaseId:0184
模块中文名:工程管理
模块英文名:PrjManage
框架-层名:业务逻辑扩展层(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
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
    public static class clsQxFuncModule_AgcBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objQxFuncModule_AgcENS">源对象</param>
        /// <returns>目标对象=>clsQxFuncModule_AgcEN:objQxFuncModule_AgcENT</returns>
        public static clsQxFuncModule_AgcENEx CopyToEx(this clsQxFuncModule_AgcEN objQxFuncModule_AgcENS)
        {
            try
            {
                clsQxFuncModule_AgcENEx objQxFuncModule_AgcENT = new clsQxFuncModule_AgcENEx();
                clsQxFuncModule_AgcBL.QxFuncModule_AgcDA.CopyTo(objQxFuncModule_AgcENS, objQxFuncModule_AgcENT);
                return objQxFuncModule_AgcENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000001)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objQxFuncModule_AgcENS">源对象</param>
        /// <returns>目标对象=>clsQxFuncModule_AgcEN:objQxFuncModule_AgcENT</returns>
        public static clsQxFuncModule_AgcEN CopyTo(this clsQxFuncModule_AgcENEx objQxFuncModule_AgcENS)
        {
            try
            {
                clsQxFuncModule_AgcEN objQxFuncModule_AgcENT = new clsQxFuncModule_AgcEN();
                clsQxFuncModule_AgcBL.QxFuncModule_AgcDA.CopyTo(objQxFuncModule_AgcENS, objQxFuncModule_AgcENT);
                return objQxFuncModule_AgcENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000002)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 功能模块_Agc(QxFuncModule_Agc)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsQxFuncModule_AgcBLEx : clsQxFuncModule_AgcBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxFuncModule_AgcDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxFuncModule_AgcDAEx QxFuncModule_AgcDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxFuncModule_AgcDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="strFuncModuleAgcId">表关键字</param>
        /// <returns></returns>
        public static bool DelRecordEx(string strFuncModuleAgcId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsQxFuncModule_AgcDA.GetSpecSQLObj();
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
                //删除与表:[QxFuncModule_Agc]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //conQxFuncModule_Agc.FuncModuleAgcId,
                //strFuncModuleAgcId);
                //        clsQxFuncModule_AgcBL.DelQxFuncModule_AgcsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsQxFuncModule_AgcBL.DelRecord(strFuncModuleAgcId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsQxFuncModule_AgcBLEx", "DelRecordEx", objException.Message, Entity.clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strFuncModuleAgcId, clsStackTrace.GetCurrClassFunction());
                Entity.clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
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
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsQxFuncModule_AgcENEx> GetObjExLst(string strCondition)
        {
            List<clsQxFuncModule_AgcEN> arrObjLst = clsQxFuncModule_AgcBL.GetObjLst(strCondition);
            List<clsQxFuncModule_AgcENEx> arrObjExLst = new List<clsQxFuncModule_AgcENEx>();
            foreach (clsQxFuncModule_AgcEN objInFor in arrObjLst)
            {
                clsQxFuncModule_AgcENEx objQxFuncModule_AgcENEx = new clsQxFuncModule_AgcENEx();
                clsQxFuncModule_AgcBL.CopyTo(objInFor, objQxFuncModule_AgcENEx);
                arrObjExLst.Add(objQxFuncModule_AgcENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strFuncModuleAgcId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsQxFuncModule_AgcENEx GetObjExByFuncModuleAgcId(string strFuncModuleAgcId)
        {
            clsQxFuncModule_AgcEN objQxFuncModule_AgcEN = clsQxFuncModule_AgcBL.GetObjByFuncModuleAgcId(strFuncModuleAgcId);
            clsQxFuncModule_AgcENEx objQxFuncModule_AgcENEx = new clsQxFuncModule_AgcENEx();
            clsQxFuncModule_AgcBL.CopyTo(objQxFuncModule_AgcEN, objQxFuncModule_AgcENEx);
            return objQxFuncModule_AgcENEx;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
        /// </summary>
        /// <param name = "objQxFuncModule_AgcENS">源对象</param>
        /// <param name = "objQxFuncModule_AgcENT">目标对象</param>
        public static void CopyTo(clsFuncModule_AgcEN objQxFuncModule_AgcENS, clsQxFuncModule_AgcEN objQxFuncModule_AgcENT)
        {
            objQxFuncModule_AgcENT.FuncModuleAgcId = objQxFuncModule_AgcENS.FuncModuleAgcId; //功能模块Id
            objQxFuncModule_AgcENT.FuncModuleName = objQxFuncModule_AgcENS.FuncModuleName; //模块名
            objQxFuncModule_AgcENT.FuncModuleEnName = objQxFuncModule_AgcENS.FuncModuleEnName; //模块英文名
            objQxFuncModule_AgcENT.FuncModuleNameSim = objQxFuncModule_AgcENS.FuncModuleNameSim; //模块名_Sim
            objQxFuncModule_AgcENT.QxPrjId = objQxFuncModule_AgcENS.PrjId; //项目Id
            objQxFuncModule_AgcENT.OrderNum = objQxFuncModule_AgcENS.OrderNum; //排序号
            objQxFuncModule_AgcENT.UseStateId = objQxFuncModule_AgcENS.UseStateId; //UseStateId
            objQxFuncModule_AgcENT.UpdUser = objQxFuncModule_AgcENS.UpdUser; //修改用户
            objQxFuncModule_AgcENT.UpdDate = objQxFuncModule_AgcENS.UpdDate; //修改日期
            objQxFuncModule_AgcENT.Memo = objQxFuncModule_AgcENS.Memo; //备注
        }
    }
}