
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxUsers4SynchBLEx
表名:QxUsers4Synch(00140089)
生成代码版本:2019.03.20.1
生成日期:2019/03/20 18:19:07
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
using com.taishsoft.datetime;

namespace GeneralPlatform.BusinessLogicEx
{
    public static class clsQxUsers4SynchBLEx_Static
    {

        /// <summary>
        /// 插入记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_AddRecordEx)
        /// </summary>
        /// <returns>插入记录是否成功？</returns>
        public static bool AddRecordEx2(this clsQxUsers4SynchEN objQxUsers4SynchEN)
        {
            //操作步骤:
            //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            //2、检查唯一性
            //3、检查传进去的对象属性是否合法
            //4、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
                                    //1、判断是否有相同的关键字,如果主键是标识递增型就不需要判断是否存在
            try
            {
                //2、检查传进去的对象属性是否合法
                objQxUsers4SynchEN.CheckPropertyNew();
                ///5.2、检查唯一性
                //if (objQxUsers4SynchEN.CheckQxUsers4Synch() == false)
                //{
                //    strMsg = string.Format("(IP地址(IpAddress)=[{0}])已经存在，不能重复!", objQxUsers4SynchEN.IpAddress);
                //    throw new Exception(strMsg);
                //}
                //6、把数据实体层的数据存贮到数据库中
                objQxUsers4SynchEN.AddNewRecord();
            }
            catch (Exception objException)
            {
                strMsg = "(errid:BlEx000003)添加记录不成功!" + objException.Message;
                throw new Exception(strMsg);
            }
            return true;
        }


        /// <summary>
        /// 修改记录存盘到数据表中
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_UpdateRecordEx)
        /// </summary>
        /// <param name = "objQxUsers4SynchEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool UpdateRecordEx2(this clsQxUsers4SynchEN objQxUsers4SynchEN)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
            try
            {
                //1、检查传进去的对象属性是否合法
                objQxUsers4SynchEN.CheckPropertyNew();
                //2、检查唯一性
                //if (objQxUsers4SynchEN.CheckQxUsers4SynchUniqueness() == false)
                //{
                //    strMsg = "(IP地址(IpAddress))不能重复!";
                //    throw new Exception(strMsg);
                //}
                //4、把数据实体层的数据存贮到数据库中
                objQxUsers4SynchEN.Update();
            }
            catch (Exception objException)
            {
                strMsg = "修改记录不成功!" + objException.Message;
                throw new Exception(strMsg);
            }
            return true;
        }


        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改，不存在就添加
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_EditRecordEx)
        /// </summary>
        /// <param name = "objQxUsers4SynchEN">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        public static bool EditRecordEx(this clsQxUsers4SynchEN objQxUsers4Synch)
        {
            //操作步骤:
            //1、检查传进去的对象属性是否合法
            //2、检查唯一性
            //3、把数据实体层的数据存贮到数据库中
            string strMsg;  //专门用于传递信息的变量
            string strResult = " "; //用于传递在检验对象属性时结果值的变量
            string strCondition = "";
            //发生错误：关键字类型为:[Identity]的表，一定要设置唯一性条件;
            objQxUsers4Synch._IsCheckProperty = true;
            bool bolIsExist = clsQxUsers4SynchBL.IsExistRecord(strCondition);
            if (bolIsExist)
            {
                objQxUsers4Synch.mId = clsQxUsers4SynchBL.GetFirstID_S(strCondition);
                objQxUsers4Synch.UpdateWithCondition(strCondition);
            }
            else
            {
                objQxUsers4Synch.AddNewRecord();
            }
            return true;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objQxUsers4SynchENS">源对象</param>
        /// <returns>目标对象=>clsQxUsers4SynchEN:objQxUsers4SynchENT</returns>
        public static clsQxUsers4SynchENEx CopyToEx(this clsQxUsers4SynchEN objQxUsers4SynchENS)
        {
            try
            {
                clsQxUsers4SynchENEx objQxUsers4SynchENT = new clsQxUsers4SynchENEx();
                clsQxUsers4SynchBL.QxUsers4SynchDA.CopyTo(objQxUsers4SynchENS, objQxUsers4SynchENT);
                return objQxUsers4SynchENT;
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
        /// <param name = "objQxUsers4SynchENS">源对象</param>
        /// <returns>目标对象=>clsQxUsers4SynchEN:objQxUsers4SynchENT</returns>
        public static clsQxUsers4SynchEN CopyTo(this clsQxUsers4SynchENEx objQxUsers4SynchENS)
        {
            try
            {
                clsQxUsers4SynchEN objQxUsers4SynchENT = new clsQxUsers4SynchEN();
                clsQxUsers4SynchBL.QxUsers4SynchDA.CopyTo(objQxUsers4SynchENS, objQxUsers4SynchENT);
                return objQxUsers4SynchENT;
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
    /// 用户4同步(QxUsers4Synch)
    /// 数据源类型:SQL表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsQxUsers4SynchBLEx : clsQxUsers4SynchBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxUsers4SynchDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxUsers4SynchDAEx QxUsers4SynchDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxUsers4SynchDAEx();
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
            objSQL = clsQxUsers4SynchDA.GetSpecSQLObj();
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
                //删除与表:[QxUsers4Synch]相关的表的代码，需要时去除注释，编写相关的代码
                //string strCondition = string.Format("{0} = '{1}'",
                //constStudent.id_College,
                //strid_College);
                //        clsStudentBL.DelStudentsByCondWithTransaction_S(strCondition, objConnection, objSqlTransaction);
                //
                clsQxUsers4SynchBL.DelRecord(lngmId, objConnection, objSqlTransaction);
                objSqlTransaction.Commit();
                return true;
            }
            catch (Exception objException)
            {
                ErrorInformationBL.AddInformation("clsQxUsers4SynchBLEx", "DelRecordEx", objException.Message, clsSysParaEN.strUserId);
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
        public static List<clsQxUsers4SynchENEx> GetObjExLst(string strCondition)
        {
            List<clsQxUsers4SynchEN> arrObjLst = clsQxUsers4SynchBL.GetObjLst(strCondition);
            List<clsQxUsers4SynchENEx> arrObjExLst = new List<clsQxUsers4SynchENEx>();
            foreach (clsQxUsers4SynchEN objInFor in arrObjLst)
            {
                clsQxUsers4SynchENEx objQxUsers4SynchENEx = new clsQxUsers4SynchENEx();
                clsQxUsers4SynchBL.CopyTo(objInFor, objQxUsers4SynchENEx);
                arrObjExLst.Add(objQxUsers4SynchENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsQxUsers4SynchENEx GetObjExBymId(long lngmId)
        {
            clsQxUsers4SynchEN objQxUsers4SynchEN = clsQxUsers4SynchBL.GetObjBymId(lngmId);
            clsQxUsers4SynchENEx objQxUsers4SynchENEx = new clsQxUsers4SynchENEx();
            clsQxUsers4SynchBL.CopyTo(objQxUsers4SynchEN, objQxUsers4SynchENEx);
            return objQxUsers4SynchENEx;
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
        /// </summary>
        /// <param name = "objQxUsers4SynchENS">源对象</param>
        /// <param name = "objQxUsers4SynchENT">目标对象</param>
        public static void CopyTo(clsQxUsersEN objQxUsers4SynchENS, clsQxUsers4SynchEN objQxUsers4SynchENT)
        {
            try
            {
                QxUsers4SynchDAEx.CopyTo(objQxUsers4SynchENS, objQxUsers4SynchENT);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
        /// </summary>
        /// <param name = "objQxUsers4SynchENS">源对象</param>
        /// <param name = "objQxUsers4SynchENT">目标对象</param>
        public static void CopyTo(clsQxUsers4SynchEN  objQxUsers4SynchENS, clsQxUsersEN objQxUsers4SynchENT)
        {
            try
            {
                QxUsers4SynchDAEx.CopyTo(objQxUsers4SynchENS, objQxUsers4SynchENT);
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
        /// <summary>
        /// 预处理数据
        /// </summary>
        /// <returns></returns>
        public static int PreAccessData()
        {
            string strCondition = string.Format("{0}='' or {0} is null", conQxUsers4Synch.AccessSynchDate);
            strCondition += "[Exclude]or [/Exclude]";
            List<clsQxUsers4SynchEN> arrObjLst = clsQxUsers4SynchBL.GetObjLst(strCondition);
            int intCount = 0;
            foreach(clsQxUsers4SynchEN objInFor in arrObjLst)
            {
                strCondition = string.Format("{0}='{1}'", conQxUsers.UserId, objInFor.UserId);
                clsQxUsersEN objUsers = clsQxUsersBL.GetObjByUserId(objInFor.UserId);
                if (objUsers == null)
                {
                    objInFor.IsExistUserInCurr = false;
                    objInFor.AccessSynchDate = clsDateTime.getTodayDateTimeStr(0);
                    clsQxUsers4SynchBL.UpdateBySql2(objInFor);
                    intCount++;
                }
                else
                {
                    if (objUsers.Password == objInFor.Password)
                    {
                        objInFor.IsExistUserInCurr = true;
                        objInFor.IsSamePwd = true;
                        objInFor.AccessSynchDate = clsDateTime.getTodayDateTimeStr(0);
                        clsQxUsers4SynchBL.UpdateBySql2(objInFor);
                    }
                    else
                    {
                        objInFor.IsExistUserInCurr = true;
                        objInFor.IsSamePwd = false;
                        objInFor.AccessSynchDate = clsDateTime.getTodayDateTimeStr(0);
                        clsQxUsers4SynchBL.UpdateBySql2(objInFor);
                    }
                    intCount++;
                }
            }
            return intCount;
        }


        public static int AcceptData(long lngMid, string strUserId)
        {
            //string strCondition = string.Format("{0}='{1}'", conQxUsers4Synch.AccessSynchDate);
            //strCondition += "[Exclude]or [/Exclude]";
            clsQxUsers4SynchEN objQxUsers4Synch = clsQxUsers4SynchBL.GetObjBymId(lngMid);
            if (objQxUsers4Synch == null) return 0;
            clsQxUsersEN objQxUsers = clsQxUsersBL.GetObjByUserId(objQxUsers4Synch.UserId);
            if (objQxUsers == null)
            {
                objQxUsers = new clsQxUsersEN();
                clsQxUsers4SynchBLEx.CopyTo(objQxUsers4Synch, objQxUsers);
                objQxUsers.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objQxUsers.UpdUser = strUserId;
                clsQxUsersBL.AddNewRecordBySql2(objQxUsers);
            }
            else
            {
                clsQxUsers4SynchBLEx.CopyTo(objQxUsers4Synch, objQxUsers);
                objQxUsers.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                objQxUsers.UpdUser = strUserId;
                clsQxUsersBL.UpdateBySql2(objQxUsers);
            }
            string strCondition = string.Format("{0}='{1}'", conQxPrjUserRelation4Synch.UserId, objQxUsers.UserId);
            List<clsQxPrjUserRelation4SynchEN> arrObjLst = clsQxPrjUserRelation4SynchBL.GetObjLst(strCondition);

            int intCount = 0;
            foreach (clsQxPrjUserRelation4SynchEN objInFor in arrObjLst)
            {
                strCondition = string.Format("{0}='{1}' and {2}='{3}'",
                    conQxPrjUserRelation4Synch.UserId, objInFor.UserId, conQxPrjUserRelation4Synch.QxPrjId, objInFor.QxPrjId);
                if (clsQxPrjUserRelationBL.IsExistRecord(strCondition) == false)
                {
                    clsQxPrjUserRelationEN objQxPrjUserRelationEN = new clsQxPrjUserRelationEN();
                    objQxPrjUserRelationEN.QxPrjId = objInFor.QxPrjId;
                    objQxPrjUserRelationEN.UserId = objInFor.UserId;
                    objQxPrjUserRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objQxPrjUserRelationEN.UpdUser = strUserId;
                    clsQxPrjUserRelationBL.AddNewRecordBySql2(objQxPrjUserRelationEN);
                    intCount++;
                }
            }

            List<clsQxUserRoleRelation4SynchEN> arrObjLst2 = clsQxUserRoleRelation4SynchBL.GetObjLst(strCondition);

        
            foreach (clsQxUserRoleRelation4SynchEN objInFor in arrObjLst2)
            {
                strCondition = string.Format("{0}='{1}' and {2}='{3}'",
                    conQxUserRoleRelation4Synch.UserId, objInFor.UserId, conQxUserRoleRelation4Synch.RoleId, objInFor.RoleId);
                if (clsQxUserRoleRelationBL.IsExistRecord(strCondition) == false)
                {
                    clsQxUserRoleRelationEN objQxUserRoleRelationEN = new clsQxUserRoleRelationEN();
                    objQxUserRoleRelationEN.QxPrjId = objInFor.QxPrjId;
                    objQxUserRoleRelationEN.RoleId = objInFor.RoleId;
                    objQxUserRoleRelationEN.UserId = objInFor.UserId;
                    objQxUserRoleRelationEN.UpdDate = clsDateTime.getTodayDateTimeStr(0);
                    objQxUserRoleRelationEN.UpdUser = strUserId;
                    clsQxUserRoleRelationBL.AddNewRecordBySql2(objQxUserRoleRelationEN);
                    intCount++;
                }
            }
            objQxUsers4Synch.IsAccessSynch = true;
            objQxUsers4Synch.AccessSynchDate = clsDateTime.getTodayDateTimeStr(0);
            clsQxUsers4SynchBL.UpdateBySql2(objQxUsers4Synch);
            return intCount;
        }
    }
    
 
}