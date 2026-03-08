
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxUserRoleRelation4SynchBLEx
表名:QxUserRoleRelation4Synch(00140092)
生成代码版本:2019.03.21.1
生成日期:2019/03/21 17:08:06
生成者:
生成服务器IP:101.251.68.133
工程名称:统一平台
工程ID:0014
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
模块中文名:用户管理
模块英文名:UserManage
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

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// 用户角色关系4同步(QxUserRoleRelation4Synch)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsQxUserRoleRelation4SynchBLEx : clsQxUserRoleRelation4SynchBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxUserRoleRelation4SynchDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxUserRoleRelation4SynchDAEx QxUserRoleRelation4SynchDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxUserRoleRelation4SynchDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 扩展删除记录，即同时删除多个表的记录，需要基于原子性的事务处理
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DelRecordEx)
        /// </summary>
        /// <param name="lngmId">表关键字</param>
        /// <returns></returns>
        private static bool DelRecordEx(long lngmId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsQxUserRoleRelation4SynchDA.GetSpecSQLObj();
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
                //删除与表:[QxUserRoleRelation4Synch]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //constStudent.id_College,
                //strid_College);
                //        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsQxUserRoleRelation4SynchBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsQxUserRoleRelation4SynchBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
                string strMsg = string.Format("扩展删除记录出错:{0}！KeyId = {1}.({2})",
                objException.Message,
                lngmId, clsStackTrace.GetCurrClassFunction());
                clsSysParaEN.objErrorLog.WriteDebugLog(strMsg);
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
        public static List<clsQxUserRoleRelation4SynchENEx> GetObjExLst(string strCondition)
        {
            List<clsQxUserRoleRelation4SynchEN> arrObjLst = clsQxUserRoleRelation4SynchBL.GetObjLst(strCondition);
            List<clsQxUserRoleRelation4SynchENEx> arrObjExLst = new List<clsQxUserRoleRelation4SynchENEx>();
            foreach (clsQxUserRoleRelation4SynchEN objInFor in arrObjLst)
            {
                clsQxUserRoleRelation4SynchENEx objQxUserRoleRelation4SynchENEx = new clsQxUserRoleRelation4SynchENEx();
                clsQxUserRoleRelation4SynchBL.CopyTo(objInFor, objQxUserRoleRelation4SynchENEx);
                arrObjExLst.Add(objQxUserRoleRelation4SynchENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsQxUserRoleRelation4SynchENEx GetObjExBymId(long lngmId)
        {
            clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = clsQxUserRoleRelation4SynchBL.GetObjBymId(lngmId);
            clsQxUserRoleRelation4SynchENEx objQxUserRoleRelation4SynchENEx = new clsQxUserRoleRelation4SynchENEx();
            clsQxUserRoleRelation4SynchBL.CopyTo(objQxUserRoleRelation4SynchEN, objQxUserRoleRelation4SynchENEx);
            return objQxUserRoleRelation4SynchENEx;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
        /// </summary>
        /// <param name = "objQxUserRoleRelation4SynchENS">源对象</param>
        /// <param name = "objQxUserRoleRelation4SynchENT">目标对象</param>
        public static void CopyTo(clsQxUserRoleRelationEN objQxUserRoleRelationENS, clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchENT)
        {
            try
            {
                QxUserRoleRelation4SynchDAEx.CopyTo(objQxUserRoleRelationENS, objQxUserRoleRelation4SynchENT);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
}