
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxPrjTabBLEx
表名:QxPrjTab(00140096)
生成代码版本:2019.08.02.1
生成日期:2019/08/05 00:04:22
生成者:
生成服务器IP:101.251.68.133
工程名称:统一平台
工程ID:0014
相关数据库:101.251.68.133,9433GeneralPlatformTz
PrjDataBaseId:0184
模块中文名:字段、表维护
模块英文名:Table_Field
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
    public static class clsQxPrjTabBLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objQxPrjTabENS">源对象</param>
        /// <returns>目标对象=>clsQxPrjTabEN:objQxPrjTabENT</returns>
        public static clsQxPrjTabENEx CopyToEx(this clsQxPrjTabEN objQxPrjTabENS)
        {
            try
            {
                clsQxPrjTabENEx objQxPrjTabENT = new clsQxPrjTabENEx();
                clsQxPrjTabBL.QxPrjTabDA.CopyTo(objQxPrjTabENS, objQxPrjTabENT);
                return objQxPrjTabENT;
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
        /// <param name = "objQxPrjTabENS">源对象</param>
        /// <returns>目标对象=>clsQxPrjTabEN:objQxPrjTabENT</returns>
        public static clsQxPrjTabEN CopyTo(this clsQxPrjTabENEx objQxPrjTabENS)
        {
            try
            {
                clsQxPrjTabEN objQxPrjTabENT = new clsQxPrjTabEN();
                clsQxPrjTabBL.QxPrjTabDA.CopyTo(objQxPrjTabENS, objQxPrjTabENT);
                return objQxPrjTabENT;
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
    /// 工程表(QxPrjTab)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsQxPrjTabBLEx : clsQxPrjTabBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxPrjTabDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxPrjTabDAEx QxPrjTabDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxPrjTabDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="strTabId">表关键字</param>
        /// <returns></returns>
        public static bool DelRecordEx(string strTabId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsQxPrjTabDA.GetSpecSQLObj();
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
                //删除与表:[QxPrjTab]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //conQxPrjTab.TabId,
                //strTabId);
                //        clsQxPrjTabBL.DelQxPrjTabsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsQxPrjTabBL.DelRecord(strTabId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsQxPrjTabBLEx", "DelRecordEx", objException.Message, Entity.clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                strTabId, clsStackTrace.GetCurrClassFunction());
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
        public static List<clsQxPrjTabENEx> GetObjExLst(string strCondition)
        {
            List<clsQxPrjTabEN> arrObjLst = clsQxPrjTabBL.GetObjLst(strCondition);
            List<clsQxPrjTabENEx> arrObjExLst = new List<clsQxPrjTabENEx>();
            foreach (clsQxPrjTabEN objInFor in arrObjLst)
            {
                clsQxPrjTabENEx objQxPrjTabENEx = new clsQxPrjTabENEx();
                clsQxPrjTabBL.CopyTo(objInFor, objQxPrjTabENEx);
                arrObjExLst.Add(objQxPrjTabENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "strTabId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsQxPrjTabENEx GetObjExByTabId(string strTabId)
        {
            clsQxPrjTabEN objQxPrjTabEN = clsQxPrjTabBL.GetObjByTabId(strTabId);
            clsQxPrjTabENEx objQxPrjTabENEx = new clsQxPrjTabENEx();
            clsQxPrjTabBL.CopyTo(objQxPrjTabEN, objQxPrjTabENEx);
            return objQxPrjTabENEx;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
        /// </summary>
        /// <param name = "objQxPrjTabENS">源对象</param>
        /// <param name = "objQxPrjTabENT">目标对象</param>
        public static void CopyTo(clsPrjTabEN objQxPrjTabENS, clsQxPrjTabEN objQxPrjTabENT)
        {
            objQxPrjTabENT.TabId = objQxPrjTabENS.TabId; //表ID
            objQxPrjTabENT.TabName = objQxPrjTabENS.TabName; //TabName
            objQxPrjTabENT.TabCnName = objQxPrjTabENS.TabCnName; //表中文名
            objQxPrjTabENT.QxPrjId = objQxPrjTabENS.PrjId; //项目Id
            //objQxPrjTabENT.SQLDSTypeId = objQxPrjTabENS.SQLDSTypeId; //数据源类型
            objQxPrjTabENT.TabStateId = objQxPrjTabENS.TabStateId; //表状态ID
            objQxPrjTabENT.IsParaTab = objQxPrjTabENS.IsParaTab; //是否参数表
            objQxPrjTabENT.FuncModuleAgcId = objQxPrjTabENS.FuncModuleAgcId; //功能模块Id
            objQxPrjTabENT.Owner = objQxPrjTabENS.Owner; //拥有者
            objQxPrjTabENT.Keyword = objQxPrjTabENS.Keyword; //关键字
            objQxPrjTabENT.TabTypeId = objQxPrjTabENS.TabTypeId; //表类型Id
            objQxPrjTabENT.RelaViewId = objQxPrjTabENS.RelaViewId; //RelaViewId
            //objQxPrjTabENT.PrimaryTypeId = objQxPrjTabENS.PrimaryTypeId; //主键类型ID
            //objQxPrjTabENT.PrimaryTypeName = objQxPrjTabENS.PrimaryTypeName; //主键类型名
            //objQxPrjTabENT.KeyFldId = objQxPrjTabENS.KeyFldId; //关键字段Id
            //objQxPrjTabENT.KeyFldName = objQxPrjTabENS.KeyFldName; //关键字段名
            objQxPrjTabENT.UpdUserId = objQxPrjTabENS.UpdUserId; //修改用户Id
            objQxPrjTabENT.UpdDate = objQxPrjTabENS.UpdDate; //修改日期
            objQxPrjTabENT.Memo = objQxPrjTabENS.Memo; //备注
        }
    }
}