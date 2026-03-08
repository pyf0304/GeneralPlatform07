
using com.taishsoft.commdb;
using com.taishsoft.datetime;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.Entity;
using GP4WApi;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// 用户(QxUsers)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public partial class clsQxUsersBLEx : clsQxUsersBL
    {

       
        public static bool SynDataToClientDatabase(string strPrjId)
        {
            clsQxProjectsEN objProjects = clsQxProjectsBL.GetObjByQxPrjIdCache(strPrjId);
            clsQxPrjDataBaseEN objPrjDataBase = clsQxPrjDataBaseBL.GetObjByQxPrjDataBaseId(objProjects.QxPrjDataBaseId);
            string strConnectString = clsQxPrjDataBaseBLEx.GetConnectString(objPrjDataBase);
            clsSpecSQLforSql objSQL = new clsSpecSQLforSql(strConnectString);
            SqlConnection objSqlConnection = objSQL.getConnectObj(strConnectString);


            StringBuilder sbCondition = new StringBuilder();
            sbCondition.AppendFormat(" UserId in (Select UserId from QxPrjUserRelation where QxPrjId = '{0}')", strPrjId);
            List<clsQxUsersEN> arrUserObjList = clsQxUsersBL.GetObjLst(sbCondition.ToString());

            foreach (clsQxUsersEN objUsers in arrUserObjList)
            {

                objUsers.Memo = clsDateTime.getTodayStr(0) + "从平台复制";

                SqlTransaction objSqlTransaction = objSqlConnection.BeginTransaction();
                try
                {
                    if (clsQxUsersBLEx.IsExistEx(objUsers.UserId, objSQL) == false)
                    {
                        objUsers.AddNewRecord(objSqlConnection, objSqlTransaction);

                    }
                    else
                    {
                        objUsers.Update(objSqlConnection, objSqlTransaction);
                    }
                    objSqlTransaction.Commit();

                }
                catch (Exception objException)
                {
                    objSqlTransaction.Rollback();
                    throw objException;
                }
                finally
                {

                }

            }
            objSqlConnection.Close();
            return true;
        }

        public static int SynDataToOtherServer(List<string> arrUserId, string strServerId)
        {

            string strCondition = string.Format("{0}='1'", conQxServer4Synch.IsSelf);
            clsQxServer4SynchEN objQxServer4Synch_Curr = clsQxServer4SynchBL.GetFirstObj_S(strCondition);
            if (objQxServer4Synch_Curr == null)
            {
                string strMsg = "当前同步服务器为空，请联系管理员！";
                throw new Exception(strMsg);
            }
            string strCurrIpAddress = objQxServer4Synch_Curr.IpAddress;

            clsQxServer4SynchEN objQxServer4SynchEN = clsQxServer4SynchBL.GetObjByServerId(strServerId);
            clsSysPara4WebApi_GP.strCurrIPAddressAndPort = objQxServer4SynchEN.IpAddress;
            clsSysPara4WebApi_GP.strCurrPrx = objQxServer4SynchEN.WebApiAddress;

            List<clsQxUsersEN> arrUserObjList = clsQxUsersBL.GetObjLstByUserIdLst(arrUserId);
            int intCount = 0;
            foreach (clsQxUsersEN objUsers in arrUserObjList)
            {
                clsQxUsers4SynchEN objQxUsers4SynchEN = new clsQxUsers4SynchEN();
                clsQxUsers4SynchBLEx.CopyTo(objUsers, objQxUsers4SynchEN);

                //objUsers.Memo = clsDateTime.getTodayStr(0) + "从平台复制";
                objQxUsers4SynchEN.IpAddress = strCurrIpAddress;

                try
                {
                    clsQxUsers4SynchExWApi.AddNewRecordEx(objQxUsers4SynchEN);
                    objUsers.IsSynch = true;
                    objUsers.SynchDate = clsDateTime.getTodayStr(0);
                    clsQxUsersBL.UpdateBySql2(objUsers);
                    {
                        List<clsQxPrjUserRelationEN> arrQxPrjUserRelationObjLst = clsQxPrjUserRelationBLEx.GetObjLstByUserId(objUsers.UserId);
                        foreach (clsQxPrjUserRelationEN objInFor in arrQxPrjUserRelationObjLst)
                        {
                            clsQxPrjUserRelation4SynchEN objQxPrjUserRelation4SynchEN = new clsQxPrjUserRelation4SynchEN();
                            clsQxPrjUserRelation4SynchBLEx.CopyTo(objInFor, objQxPrjUserRelation4SynchEN);
                            objQxPrjUserRelation4SynchEN.IpAddress = strCurrIpAddress;

                            clsQxPrjUserRelation4SynchExWApi.AddNewRecordEx(objQxPrjUserRelation4SynchEN);
                            //objQxPrjUserRelation4SynchEN.IsSynch = true;
                            //objQxPrjUserRelation4SynchEN.SynchDate = clsDateTime.getTodayStr(0);
                            //clsQxPrjUserRelationBL.UpdateBySql2(objInFor);                            
                        }
                    }
                    {
                        List<clsQxUserRoleRelationEN> arrQxUserRoleRelationObjLst = clsQxUserRoleRelationBLEx.GetObjLstByUserId(objUsers.UserId);
                        foreach (clsQxUserRoleRelationEN objInFor in arrQxUserRoleRelationObjLst)
                        {
                            clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchEN = new clsQxUserRoleRelation4SynchEN();
                            clsQxUserRoleRelation4SynchBLEx.CopyTo(objInFor, objQxUserRoleRelation4SynchEN);
                            objQxUserRoleRelation4SynchEN.IpAddress = strCurrIpAddress;

                            clsQxUserRoleRelation4SynchExWApi.AddNewRecordEx(objQxUserRoleRelation4SynchEN);
                            //objQxUserRoleRelation4SynchEN.IsSynch = true;
                            //objQxUserRoleRelation4SynchEN.SynchDate = clsDateTime.getTodayStr(0);
                            //clsQxUserRoleRelationBL.UpdateBySql2(objInFor);                            
                        }
                    }


                    intCount++;
                }
                catch (Exception objException)
                {
                    throw objException;
                }
                finally
                {

                }

            }

            return intCount;
        }
       
    }
}