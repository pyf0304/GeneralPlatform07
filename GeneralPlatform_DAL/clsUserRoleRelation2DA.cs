///----------------------
///生成代码版本：8.2.0.0
///生成日期：2008/11/16
///生成者：潘以锋
///注意：需要数据底层（PubDataBase.dll）的版本：08.11.16.1
///========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.common;
using com.taishsoft.commexception;
using com.taishsoft.commdb;
using GeneralPlatform.Entity;

namespace GeneralPlatform.DAL
{
    public class clsUserRoleRelation2DA
    {
        public const string CurrTabName_S = "UserRoleRelation2"; //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "UserId,RoleId"; //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 4;
        protected const string EXCEPTION_MSG = "出错："; //there was an error in the method. please see the Application Log for details.";
        protected string mstrModuleName;
        public static string[] AttributeName = new string[] { "UserId", "RoleId", "PrjId", "Memo" };
        //以下是属性变量

        //用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
        private static string m_strConnectString;
        public static string ConnectString
        {
            get { return m_strConnectString; }
            set { m_strConnectString = value; }
        }

        /// <summary>
        /// 获取SQL服务器连接对象
        /// </summary>
        /// <returns>SQL服务器连接对象</returns>
        public static clsSpecSQLforSql GetSpecSQLObj()
        {
            clsSpecSQLforSql objSQL = null;
            //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
            if (clsSysParaEN.bolIsUseConnectStrName == true)
            {
                objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
                return objSQL;
            }
            //2. 如果类所指定的连接串非空,就用该类所指定的连接串
            //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
            if (string.IsNullOrEmpty(clsUserRoleRelation2.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforSql();
            }
            else
            {
                objSQL = new clsSpecSQLforSql(clsUserRoleRelation2.ConnectString);
            }
            return objSQL;
        }


        /// <summary>
        /// 添加新记录
        /// </summary>
        /// <returns>添加是否成功?</returns>
        public bool AddNewRecord(clsUserRoleRelation2 objUserRoleRelation2)
        {
            string strSQL;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            System.Data.DataRow objRow;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            strSQL = "Select * from UserRoleRelation2 where 1=2";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "UserRoleRelation2");
            objRow = objDS.Tables["UserRoleRelation2"].NewRow();
            objRow["UserId"] = objUserRoleRelation2.UserId; //用户ID
            objRow["RoleId"] = objUserRoleRelation2.RoleId; //角色Id
            objRow["PrjId"] = objUserRoleRelation2.PrjId; //项目编号
            if (objUserRoleRelation2.Memo != "")
            {
                objRow["Memo"] = objUserRoleRelation2.Memo; //备注
            }
            objDS.Tables["UserRoleRelation2"].Rows.Add(objRow);
            try
            {
                objDA.Update(objDS, "UserRoleRelation2");
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                objDA = null;
                objDS = null;
                objCB = null;
                objRow = null;
            }
            return true;
        }



        /// <summary>
        /// 功能：通过SQL命令来插入记录
        /// 主要用于上传文件时。
        /// </summary>
        /// <returns>如果插入成功则返回TRUE，否则为FALSE</returns>
        public bool AddNewRecordBySQL(clsUserRoleRelation2 objUserRoleRelation2)
        {
            StringBuilder strSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            strSQL.AppendFormat("insert into UserRoleRelation2 (UserId, RoleId, PrjId, Memo) values ('{0}', '{1}', '{2}', '{3}')", objUserRoleRelation2.UserId, objUserRoleRelation2.RoleId, objUserRoleRelation2.PrjId, objUserRoleRelation2.Memo);
            return objSQL.ExecSql(strSQL.ToString());
        }



        /// <summary>
        /// /// 功能：通过SQL命令来插入记录,该方式是优化方式
        /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
        /// </summary>
        /// <returns>如果插入成功则返回TRUE，否则为FALSE</returns>
        public bool AddNewRecordBySQL2(clsUserRoleRelation2 objUserRoleRelation2)
        {
            StringBuilder strSQL = new StringBuilder();
            //需要插入表的字段列表
            ArrayList arrFieldListForInsert = new ArrayList();
            //需要插入表的值列表
            ArrayList arrValueListForInsert = new ArrayList();
            if (objUserRoleRelation2.UserId != null)
            {
                arrFieldListForInsert.Add("UserId");
                objUserRoleRelation2.UserId = objUserRoleRelation2.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + objUserRoleRelation2.UserId + "'");
            }
            if (objUserRoleRelation2.RoleId != null)
            {
                arrFieldListForInsert.Add("RoleId");
                objUserRoleRelation2.RoleId = objUserRoleRelation2.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + objUserRoleRelation2.RoleId + "'");
            }
            if (objUserRoleRelation2.PrjId != null)
            {
                arrFieldListForInsert.Add("PrjId");
                objUserRoleRelation2.PrjId = objUserRoleRelation2.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + objUserRoleRelation2.PrjId + "'");
            }
            if (objUserRoleRelation2.Memo != null)
            {
                arrFieldListForInsert.Add("Memo");
                objUserRoleRelation2.Memo = objUserRoleRelation2.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + objUserRoleRelation2.Memo + "'");
            }
            //组织插入记录SQL串
            string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
            string strFieldListCode = string.Join(",", sstrFieldCode);
            string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
            string strValuesListCode = string.Join(",", sstrValuesCode);
            strSQL.Append("Insert into UserRoleRelation2");
            strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            return objSQL.ExecSql(strSQL.ToString());
        }



        /// <summary>
        /// 功能：通过SQL命令来插入记录
        /// 主要用于上传文件时。
        /// </summary>
        /// <returns>如果插入成功则返回TRUE，否则为FALSE</returns>
        public bool AddNewRecordBySQL(clsUserRoleRelation2 objUserRoleRelation2, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            StringBuilder strSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            strSQL.AppendFormat("insert into UserRoleRelation2 (UserId, RoleId, PrjId, Memo) values ('{0}', '{1}', '{2}', '{3}')", objUserRoleRelation2.UserId, objUserRoleRelation2.RoleId, objUserRoleRelation2.PrjId, objUserRoleRelation2.Memo);
            return objSQL.ExecSql(strSQL.ToString(), objSqlConnect, objSqlTransaction);
        }



        /// <summary>
        /// 功能：通过SQL命令来插入记录
        /// 主要用于上传文件时。
        /// </summary>
        /// <returns>如果插入成功则返回TRUE，否则为FALSE</returns>
        public bool AddNewRecordBySQL2(clsUserRoleRelation2 objUserRoleRelation2, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            StringBuilder strSQL = new StringBuilder();
            //需要插入表的字段列表
            ArrayList arrFieldListForInsert = new ArrayList();
            //需要插入表的值列表
            ArrayList arrValueListForInsert = new ArrayList();
            if (objUserRoleRelation2.UserId != null)
            {
                arrFieldListForInsert.Add("UserId");
                objUserRoleRelation2.UserId = objUserRoleRelation2.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + objUserRoleRelation2.UserId + "'");
            }
            if (objUserRoleRelation2.RoleId != null)
            {
                arrFieldListForInsert.Add("RoleId");
                objUserRoleRelation2.RoleId = objUserRoleRelation2.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + objUserRoleRelation2.RoleId + "'");
            }
            if (objUserRoleRelation2.PrjId != null)
            {
                arrFieldListForInsert.Add("PrjId");
                objUserRoleRelation2.PrjId = objUserRoleRelation2.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + objUserRoleRelation2.PrjId + "'");
            }
            if (objUserRoleRelation2.Memo != null)
            {
                arrFieldListForInsert.Add("Memo");
                objUserRoleRelation2.Memo = objUserRoleRelation2.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                arrValueListForInsert.Add("'" + objUserRoleRelation2.Memo + "'");
            }
            //组织插入记录SQL串
            string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
            string strFieldListCode = string.Join(",", sstrFieldCode);
            string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
            string strValuesListCode = string.Join(",", sstrValuesCode);
            strSQL.Append("Insert into UserRoleRelation2");
            strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            return objSQL.ExecSql(strSQL.ToString(), objSqlConnect, objSqlTransaction);
        }


        /// <summary>
        /// 功能：通过存储过程来插入记录
        /// </summary>
        /// <param name="objUserRoleRelation2">需要添加到数据库中的对象</param>
        /// <returns>如果插入成功则返回TRUE，否则为FALSE</returns>
        public bool AddnewUserRoleRelation2BySP(clsUserRoleRelation2 objUserRoleRelation2)
        {
            //通过存储过程来
            //直接使用
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(objUserRoleRelation2.UserId);
            values.Add(objUserRoleRelation2.RoleId);
            values.Add(objUserRoleRelation2.PrjId);
            values.Add(objUserRoleRelation2.Memo);
            objSQL.ExecSP("UserRoleRelation2_Add", values);
            return true;
        }

        /// <summary>
        /// 把多条记录同时插入到表中!
        /// </summary>
        /// <param name="oDT"></param>
        /// <param name="strResult"></param>
        /// <returns></returns>
        public bool AddnewUserRoleRelation2s(System.Data.DataTable oDT, ref string strResult)
        {
            string strSQL;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            System.Data.DataRow objRow;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            strSQL = "Select * from UserRoleRelation2 where UserId='111'";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "UserRoleRelation2");
            //检查关键字的唯一性
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                string strUserId = oRow["UserId"].ToString().Trim();
                string strRoleId = oRow["RoleId"].ToString().Trim();
                if (IsExist(strUserId, strRoleId))
                {
                    strResult = "关键字变量值为：" + string.Format("UserId = {0},RoleId = {1}", strUserId, strRoleId) + "的记录已存在，不能重复插入!";
                    return false;
                }
            }
            //把多条记录插入到表中
            foreach (System.Data.DataRow oRow in oDT.Rows)
            {
                objRow = objDS.Tables["UserRoleRelation2"].NewRow();
                objRow["UserId"] = oRow["UserId"].ToString().Trim(); //用户ID
                objRow["RoleId"] = oRow["RoleId"].ToString().Trim(); //角色Id
                objRow["PrjId"] = oRow["PrjId"].ToString().Trim(); //项目编号
                objRow["Memo"] = oRow["Memo"].ToString().Trim(); //备注
                objDS.Tables["UserRoleRelation2"].Rows.Add(objRow);
            }
            try
            {
                objDA.Update(objDS, "UserRoleRelation2");
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                objDA = null;
                objDS = null;
                objCB = null;
                objRow = null;
                objSQL.SQLConnect.Close();
                objSQL = null;
            }
            return true;
        }

        /// <summary>
        /// 功能：修改记录
        /// </summary>
        /// <param name="objUserRoleRelation2">需要修改到数据库中的对象</param>
        /// <returns>如果修改成功则返回TRUE，否则为FALSE</returns>
        public bool Update(clsUserRoleRelation2 objUserRoleRelation2)
        {
            string strSQL;
            System.Data.SqlClient.SqlDataAdapter objDA;
            System.Data.DataSet objDS = new System.Data.DataSet();
            System.Data.SqlClient.SqlCommandBuilder objCB;
            System.Data.DataRow objRow;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            strSQL = "Select * from UserRoleRelation2 where UserId=" + "'" + objUserRoleRelation2.UserId + "'" + " and RoleId=" + "'" + objUserRoleRelation2.RoleId + "'";
            objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
            objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
            objDA.Fill(objDS, "UserRoleRelation2");
            if (objDS.Tables["UserRoleRelation2"].Rows.Count == 0)
            {
                //MsgBox("没有相应的ID号：UserId=" + "'"+ objUserRoleRelation2.UserId+"'" + " and RoleId=" + "'"+ objUserRoleRelation2.RoleId+"'");
                return false;
            }
            objRow = objDS.Tables["UserRoleRelation2"].Rows[0];
            if (objUserRoleRelation2.IsUpdated("PrjId"))
            {
                objRow["PrjId"] = objUserRoleRelation2.PrjId; //项目编号
            }
            if (objUserRoleRelation2.IsUpdated("Memo"))
            {
                objRow["Memo"] = objUserRoleRelation2.Memo; //备注
            }
            try
            {
                objDA.Update(objDS, "UserRoleRelation2");
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                objDA = null;
                objDS = null;
                objCB = null;
                objRow = null;
            }
            return true;
        }


        /// <summary>
        /// /// 功能：通过存储过程(StoreProcedure)来修改记录
        /// /// 缺点:1、不能支持事务处理.
        /// </summary>
        /// <returns>如果修改成功则返回TRUE，否则为FALSE</returns>
        public bool UpdateUserRoleRelation2BySP(clsUserRoleRelation2 objUserRoleRelation2)
        {
            //通过存储过程来
            //直接使用
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(objUserRoleRelation2.UserId);
            values.Add(objUserRoleRelation2.RoleId);
            values.Add(objUserRoleRelation2.PrjId);
            values.Add(objUserRoleRelation2.Memo);
            objSQL.ExecSP("UserRoleRelation2_Update", values);
            return true;
        }

        /// <summary>
        /// /// 功能：通过SQL命令来修改记录,该方式是非优化方式
        /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
        /// </summary>
        /// <returns>如果修改成功则返回TRUE，否则为FALSE</returns>
        public bool UpdateBySql(clsUserRoleRelation2 objUserRoleRelation2)
        {
            StringBuilder sbSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            sbSQL.AppendFormat("Update UserRoleRelation2 Set ");
            sbSQL.AppendFormat("PrjId = '{0}'", objUserRoleRelation2.PrjId); //项目编号
            sbSQL.AppendFormat(", Memo = '{0}'", objUserRoleRelation2.Memo); //备注
            sbSQL.AppendFormat(" Where UserId = '{0}' And RoleId = '{1}'", objUserRoleRelation2.UserId, objUserRoleRelation2.RoleId);
            try
            {
                return objSQL.ExecSql(sbSQL.ToString());
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }
        }


        /// <summary>
        /// /// 功能：通过SQL命令来修改记录,该方式是优化方式
        /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
        /// </summary>
        /// <returns>如果修改成功则返回TRUE，否则为FALSE</returns>
        public bool UpdateBySql2(clsUserRoleRelation2 objUserRoleRelation2)
        {
            StringBuilder sbSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            sbSQL.AppendFormat("Update UserRoleRelation2 Set ");
            if (objUserRoleRelation2.IsUpdated("PrjId"))
            {
                objUserRoleRelation2.PrjId = objUserRoleRelation2.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" PrjId = '{0}',", objUserRoleRelation2.PrjId); //项目编号
            }
            if (objUserRoleRelation2.IsUpdated("Memo"))
            {
                objUserRoleRelation2.Memo = objUserRoleRelation2.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" Memo = '{0}',", objUserRoleRelation2.Memo); //备注
            }
            sbSQL.Remove(sbSQL.Length - 1, 1);
            sbSQL.AppendFormat(" Where UserId = '{0}' And RoleId = '{1}'", objUserRoleRelation2.UserId, objUserRoleRelation2.RoleId);
            try
            {
                return objSQL.ExecSql(sbSQL.ToString());
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }
        }


        /// <summary>
        /// /// 功能：通过SQL命令来修改记录,支持事务处理,该方式是非优化方式
        /// /// 优点:1、支持事务处理.
        /// /// 缺点:1、不能处理字段中的单撇问题；
        /// ///      2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库;
        /// </summary>
        /// <returns>如果修改成功则返回TRUE，否则为FALSE</returns>
        public bool UpdateBySql(clsUserRoleRelation2 objUserRoleRelation2, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            StringBuilder sbSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            sbSQL.AppendFormat("Update UserRoleRelation2 Set ");
            sbSQL.AppendFormat("PrjId = '{0}'", objUserRoleRelation2.PrjId); //项目编号
            sbSQL.AppendFormat(", Memo = '{0}'", objUserRoleRelation2.Memo); //备注
            sbSQL.AppendFormat(" Where UserId = '{0}' And RoleId = '{1}'", objUserRoleRelation2.UserId, objUserRoleRelation2.RoleId);
            try
            {
                return objSQL.ExecSql(sbSQL.ToString(), objSqlConnect, objSqlTransaction);
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }
        }


        /// <summary>
        /// /// 功能：通过SQL命令来修改记录,支持事务处理,该方式是优化方式
        /// /// 优点:1、能够处理字段中的单撇问题；
        /// ///      2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
        /// ///      3、支持事务处理.
        /// </summary>
        /// <returns>如果修改成功则返回TRUE，否则为FALSE</returns>
        public bool UpdateBySql2(clsUserRoleRelation2 objUserRoleRelation2, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            StringBuilder sbSQL = new StringBuilder();
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            sbSQL.AppendFormat("Update UserRoleRelation2 Set ");
            if (objUserRoleRelation2.IsUpdated("UserId"))
            {
                objUserRoleRelation2.UserId = objUserRoleRelation2.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" UserId = '{0}',", objUserRoleRelation2.UserId); //用户ID
            }
            if (objUserRoleRelation2.IsUpdated("RoleId"))
            {
                objUserRoleRelation2.RoleId = objUserRoleRelation2.RoleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" RoleId = '{0}',", objUserRoleRelation2.RoleId); //角色Id
            }
            if (objUserRoleRelation2.IsUpdated("PrjId"))
            {
                objUserRoleRelation2.PrjId = objUserRoleRelation2.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" PrjId = '{0}',", objUserRoleRelation2.PrjId); //项目编号
            }
            if (objUserRoleRelation2.IsUpdated("Memo"))
            {
                objUserRoleRelation2.Memo = objUserRoleRelation2.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
                sbSQL.AppendFormat(" Memo = '{0}',", objUserRoleRelation2.Memo); //备注
            }
            sbSQL.Remove(sbSQL.Length - 1, 1);
            sbSQL.AppendFormat(" Where UserId = '{0}' And RoleId = '{1}'", objUserRoleRelation2.UserId, objUserRoleRelation2.RoleId);
            try
            {
                return objSQL.ExecSql(sbSQL.ToString(), objSqlConnect, objSqlTransaction);
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }
        }


        public static bool DelRecordBySP(string strUserId, string strRoleId)
        {
            //通过存储过程来
            //直接使用
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strUserId);
            values.Add(strRoleId);
            objSQL.ExecSP("UserRoleRelation2_Delete", values);
            return true;
        }

        public static bool DelRecord(string strUserId, string strRoleId, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            string strSQL = "";
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            //删除UserRoleRelation2本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from UserRoleRelation2 where UserId=" + "'" + strUserId + "'" + " and RoleId=" + "'" + strRoleId + "'";
            return objSQL.ExecSql(strSQL, objSqlConnect, objSqlTransaction);
        }


        /// <summary>
        /// 功能：同时删除多条记录
        /// </summary>
        /// <param name="lstKey">给定的关键字值列表</param>
        /// <returns>返回删除是否成功?</returns>
        public static bool DelUserRoleRelation2(ArrayList lstKey)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            string strSQL;
            string strKeyList;
            if (lstKey.Count == 0) return true;
            strKeyList = "";
            for (int i = 0; i < lstKey.Count; i++)
            {
                if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
                else strKeyList += "," + "'" + lstKey[i].ToString() + "'";
            }
            strSQL = "";
            //删除UserRoleRelation2本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from UserRoleRelation2 where UserId in (" + strKeyList + ")";
            return objSQL.ExecSql(strSQL);
        }

        /// <summary>
        /// 功能：删除关键字所指定的记录
        /// </summary>
        /// <param name="strUserId">给定的关键字值</param>
        /// <returns>如果删除成功则返回TRUE，否则为FALSE</returns>
        public static bool DelRecord(string strUserId, string strRoleId)
        {
            //删除单条记录
            string strSQL = "";
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            //删除UserRoleRelation2本表中与当前对象有关的记录
            strSQL = strSQL + "Delete from UserRoleRelation2 where UserId=" + "'" + strUserId + "'" + " and RoleId=" + "'" + strRoleId + "'";
            return objSQL.ExecSql(strSQL);
        }


        /// <summary>
        /// 功能：删除多条记录，带条件的删除
        /// </summary>
        /// <param name="strCondition">需要删除的记录条件</param>
        /// <returns>返回删除的记录0。</returns>
        public static int DelUserRoleRelation2(string strCondition)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            string strSQL;
            if (strCondition == "")
            {
                return 0;	//表示删除0条记录，实际上是不能该表的所有记录
            }
            else
            {
                strSQL = "Delete from UserRoleRelation2 where " + strCondition;
            }
            int intRecoCount = objSQL.ExecSql2(strSQL);
            return intRecoCount;
        }


        /// <summary>
        /// 获取当前关键字的记录对象,用对象的形式表示.
        /// </summary>
        /// <param name="objUserRoleRelation2">需要添加到数据库中的对象</param>
        /// <returns>是否成功</returns>
        public bool GetUserRoleRelation2(ref clsUserRoleRelation2 objUserRoleRelation2)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            strSQL = "Select * from UserRoleRelation2 where UserId=" + "'" + objUserRoleRelation2.UserId + "'" + " and RoleId=" + "'" + objUserRoleRelation2.RoleId + "'";
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return false;
            }
            objUserRoleRelation2.UserId = objDT.Rows[0]["UserId"].ToString().Trim(); //用户ID
            objUserRoleRelation2.RoleId = objDT.Rows[0]["RoleId"].ToString().Trim(); //角色Id
            objUserRoleRelation2.PrjId = objDT.Rows[0]["PrjId"].ToString().Trim(); //项目编号
            objUserRoleRelation2.Memo = objDT.Rows[0]["Memo"].ToString().Trim(); //备注
            objDT = null;
            return true;
        }

        public bool GetUserRoleRelation2OneBySP(clsUserRoleRelation2 objUserRoleRelation2)
        {
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(objUserRoleRelation2.UserId);
            objDT = objSQL.ExecSpReturnDT("UserRoleRelation2_SelectOne", values);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return false;
            }
            objUserRoleRelation2.UserId = objDT.Rows[0]["UserId"].ToString().Trim(); //用户ID
            objUserRoleRelation2.RoleId = objDT.Rows[0]["RoleId"].ToString().Trim(); //角色Id
            objUserRoleRelation2.PrjId = objDT.Rows[0]["PrjId"].ToString().Trim(); //项目编号
            objUserRoleRelation2.Memo = objDT.Rows[0]["Memo"].ToString().Trim(); //备注
            objDT = null;
            return true;
        }

        public static System.Data.DataTable GetUserRoleRelation2(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            strSQL = "Select * from UserRoleRelation2 where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;
        }

        public static System.Data.DataTable GetUserRoleRelation2ByCondBySP(string strCondition)
        {
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDT = objSQL.ExecSpReturnDT("UserRoleRelation2_SelectByCond", values);
            return objDT;
        }

        public static System.Data.DataSet GetUserRoleRelation2DataSetByCondBySP(string strCondition)
        {
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDS = objSQL.ExecSPReturnDS("UserRoleRelation2_SelectByCond", values, "UserRoleRelation2");
            return objDS;
        }

        public static System.Data.DataSet GetDataSet_UserRoleRelation2(string strCondition)
        {
            string strSQL;
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            strSQL = "Select * from UserRoleRelation2 where " + strCondition;
            objDS = objSQL.GetDataSet(strSQL, "UserRoleRelation2");
            return objDS;
        }

        public static System.Data.DataSet GetDataSet_UserRoleRelation2ByCondBySP(string strCondition)
        {
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDS = objSQL.ExecSPReturnDS("UserRoleRelation2_SelectByCond", values, "UserRoleRelation2");
            return objDS;
        }

        public static System.Data.DataSet GetDataSet_UserRoleRelation2V(string strCondition)
        {
            string strSQL;
            System.Data.DataSet objDS = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            strSQL = "Select * from vUserRoleRelation2 where " + strCondition;
            objDS = objSQL.GetDataSet(strSQL, "vUserRoleRelation2");
            return objDS;
        }

        public ArrayList GetUserRoleRelation2ObjList(string strCondition)
        {
            ArrayList arrObjList = new ArrayList();
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            strSQL = "Select * from UserRoleRelation2 where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsUserRoleRelation2 objUserRoleRelation2 = new clsUserRoleRelation2();
                objUserRoleRelation2.UserId = objRow["UserId"].ToString().Trim(); //用户ID
                objUserRoleRelation2.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
                objUserRoleRelation2.PrjId = objRow["PrjId"].ToString().Trim(); //项目编号
                objUserRoleRelation2.Memo = objRow["Memo"].ToString().Trim(); //备注
                objUserRoleRelation2.ClearUpdateState();//清除修改状态,即清除脏字段信息
                arrObjList.Add(objUserRoleRelation2);
            }
            objDT = null;
            return arrObjList;
        }

        public ArrayList GetUserRoleRelation2ObjListBySP(string strCondition)
        {
            ArrayList arrObjList = new ArrayList();
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDT = objSQL.ExecSpReturnDT("UserRoleRelation2_SelectByCond", values);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrObjList;
            }
            foreach (DataRow objRow in objDT.Rows)
            {
                clsUserRoleRelation2 objUserRoleRelation2 = new clsUserRoleRelation2();
                objUserRoleRelation2.UserId = objRow["UserId"].ToString().Trim(); //用户ID
                objUserRoleRelation2.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
                objUserRoleRelation2.PrjId = objRow["PrjId"].ToString().Trim(); //项目编号
                objUserRoleRelation2.Memo = objRow["Memo"].ToString().Trim(); //备注
                objUserRoleRelation2.ClearUpdateState();//清除修改状态,即清除脏字段信息
                arrObjList.Add(objUserRoleRelation2);
            }
            objDT = null;
            return arrObjList;
        }

        public clsUserRoleRelation2 GetFirstUserRoleRelation2(string strCondition)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            strSQL = "Select * from UserRoleRelation2 where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            DataRow objRow = objDT.Rows[0];
            clsUserRoleRelation2 objUserRoleRelation2 = new clsUserRoleRelation2();
            objUserRoleRelation2.UserId = objRow["UserId"].ToString().Trim(); //用户ID
            objUserRoleRelation2.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
            objUserRoleRelation2.PrjId = objRow["PrjId"].ToString().Trim(); //项目编号
            objUserRoleRelation2.Memo = objRow["Memo"].ToString().Trim(); //备注
            objUserRoleRelation2.ClearUpdateState();//清除修改状态,即清除脏字段信息
            objDT = null;
            return objUserRoleRelation2;
        }

        public clsUserRoleRelation2 GetFirstUserRoleRelation2BySP(string strCondition)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strCondition);
            objDT = objSQL.ExecSpReturnDT("UserRoleRelation2_SelectTop1ByCond", values);
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            DataRow objRow = objDT.Rows[0];
            clsUserRoleRelation2 objUserRoleRelation2 = new clsUserRoleRelation2();
            objUserRoleRelation2.UserId = objRow["UserId"].ToString().Trim(); //用户ID
            objUserRoleRelation2.RoleId = objRow["RoleId"].ToString().Trim(); //角色Id
            objUserRoleRelation2.PrjId = objRow["PrjId"].ToString().Trim(); //项目编号
            objUserRoleRelation2.Memo = objRow["Memo"].ToString().Trim(); //备注
            objUserRoleRelation2.ClearUpdateState();//清除修改状态,即清除脏字段信息
            objDT = null;
            return objUserRoleRelation2;
        }


        /// <summary>
        /// 功能：获取某一条件的DataTable，其中的代码转换成相应的名称
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回已经转换代码的DataTable</returns>
        public static System.Data.DataTable GetUserRoleRelation2T(string strCondition)
        {
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            strSQL.Append("Select UserRoleRelation2.* ");
            strSQL.Append(", UserRoles.RoleName UserRolesRoleName ");
            strSQL.Append(", Projects.PrjName ProjectsPrjName ");
            strSQL.Append(" from UserRoleRelation2 ");
            strSQL.Append(" left JOIN UserRoles on UserRoleRelation2.RoleId = UserRoles.RoleId ");
            strSQL.Append(" left JOIN Projects on UserRoleRelation2.PrjId = Projects.PrjId ");
            strSQL.Append(" where " + strCondition);
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }



        /// <summary>
        /// 功能：获取某一条件的相关表视图(View)
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>返回已经转换代码的DataTable</returns>
        public static System.Data.DataTable GetUserRoleRelation2V(string strCondition)
        {
            StringBuilder strSQL = new StringBuilder();
            System.Data.DataTable objDT = null;
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            strSQL.Append("Select vUserRoleRelation2.* ");
            strSQL.Append(" from vUserRoleRelation2 ");
            strSQL.Append(" where " + strCondition);
            objDT = objSQL.GetDataTable(strSQL.ToString());
            return objDT;
        }


        /// <summary>
        /// 判断当前表中是否存在给定关键字值的记录
        /// </summary>
        /// <param name="strUserId">给定的关键字值</param>
        /// <returns>返回是否存在?</returns>
        public static bool IsExist(string strUserId, string strRoleId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            if (objSQL.IsExistRecord("UserRoleRelation2", "UserId=" + "'" + strUserId + "'" + " and RoleId=" + "'" + strRoleId + "'"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsExistBySP(string strUserId, string strRoleId)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
            //			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
            ArrayList values = new ArrayList();
            values.Add(strUserId);
            values.Add(strRoleId);
            string strIsExist = "";
            values.Add(strIsExist);
            ArrayList arrReturn = objSQL.ExecSpWithOutPut("UserRoleRelation2_IsExist", values);
            if (arrReturn[0].ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 功能：判断是否存在某一条件的记录
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>如果存在就返回TRUE，否则返回FALSE</returns>
        public static bool IsExistCondRec(string strCondition)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            if (objSQL.IsExistRecord("UserRoleRelation2", strCondition))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 检查字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
        /// </summary>
        public static void CheckPropertyNew(clsUserRoleRelation2 objUserRoleRelation2)
        {
            if (Object.Equals(null, objUserRoleRelation2.UserId)
            || (!Object.Equals(null, objUserRoleRelation2.UserId) && objUserRoleRelation2.UserId.ToString() == "")
            )
            {
                throw new clsDbObjException("字段[用户ID]不能为空(NULL)!");
            }
            if (Object.Equals(null, objUserRoleRelation2.RoleId)
            || (!Object.Equals(null, objUserRoleRelation2.RoleId) && objUserRoleRelation2.RoleId.ToString() == "")
            || (!Object.Equals(null, objUserRoleRelation2.RoleId) && objUserRoleRelation2.RoleId.ToString() == "0")
            )
            {
                throw new clsDbObjException("字段[角色Id]不能为空(NULL)!");
            }
            if (Object.Equals(null, objUserRoleRelation2.PrjId)
            || (!Object.Equals(null, objUserRoleRelation2.PrjId) && objUserRoleRelation2.PrjId.ToString() == "")
            || (!Object.Equals(null, objUserRoleRelation2.PrjId) && objUserRoleRelation2.PrjId.ToString() == "0")
            )
            {
                throw new clsDbObjException("字段[项目编号]不能为空(NULL)!");
            }
            if (!Object.Equals(null, objUserRoleRelation2.UserId) && getStrLen(objUserRoleRelation2.UserId) > 18)
            {
                throw new clsDbObjException("字段[用户ID]的长度不能超过18!");
            }
            if (!Object.Equals(null, objUserRoleRelation2.RoleId) && getStrLen(objUserRoleRelation2.RoleId) > 8)
            {
                throw new clsDbObjException("字段[角色Id]的长度不能超过8!");
            }
            if (!Object.Equals(null, objUserRoleRelation2.PrjId) && getStrLen(objUserRoleRelation2.PrjId) > 4)
            {
                throw new clsDbObjException("字段[项目编号]的长度不能超过4!");
            }
            if (!Object.Equals(null, objUserRoleRelation2.Memo) && getStrLen(objUserRoleRelation2.Memo) > 1000)
            {
                throw new clsDbObjException("字段[备注]的长度不能超过1000!");
            }
        }


        /// <summary>
        /// 获取当前表满足条件的所有记录的关键字值列表
        /// </summary>
        /// <param name="strCondtion">条件串</param>
        /// <returns>返回的关键字值列表</returns>
        public ArrayList GetID(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            ArrayList arrList = new ArrayList();
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            int iRow, iCol;
            string strKeyValue;
            strSQL = "Select UserId,RoleId from UserRoleRelation2 where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }

            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            for (iRow = 0; iRow <= objDT.Rows.Count - 1; iRow++)
            {
                strKeyValue = "";
                for (iCol = 0; iCol <= objDT.Columns.Count - 1; iCol++)
                {
                    if (iCol == 0)
                    {
                        strKeyValue += objDT.Rows[iRow][iCol].ToString();
                    }
                    else
                    {
                        strKeyValue += "//" + objDT.Rows[iRow][iCol].ToString();
                    }
                }
                arrList.Add(strKeyValue);
            }
            objDT = null;
            return arrList;
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <param name="strCondtion">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        public string GetFirstID(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            ArrayList arrList = new ArrayList();
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            string strKeyValue;
            strSQL = "Select UserId,RoleId from UserRoleRelation2 where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }

            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            strKeyValue = objDT.Rows[0][0].ToString();
            objDT = null;
            return strKeyValue;
        }

        /// <summary>
        /// 获取当前表满足条件的第一条记录的关键字值
        /// </summary>
        /// <param name="strCondtion">条件串</param>
        /// <returns>返回的第一条记录的关键字值</returns>
        public static string GetFirstID_S(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            ArrayList arrList = new ArrayList();
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = clsUserRoleRelation2DA.GetSpecSQLObj();
            string strKeyValue;
            strSQL = "Select UserId,RoleId from UserRoleRelation2 where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogErrorS(objException, "clsUserRoleRelation2");
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }

            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
            }
            strKeyValue = objDT.Rows[0][0].ToString();
            objDT = null;
            return strKeyValue;
        }

        private string TransNullToStr(Object obj)
        {
            if (obj.ToString() == "")
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }

        private int TransNullToInt(Object obj)
        {
            if (obj.ToString() == "")
            {
                return 0;
            }
            else
            {
                return Int32.Parse(obj.ToString());
            }
        }

        private short TransNullToShort(Object obj)
        {
            if (obj.ToString() == "")
            {
                return 0;
            }
            else
            {
                return short.Parse(obj.ToString());
            }
        }

        private long TransNullToLong(Object obj)
        {
            if (obj.ToString() == "")
            {
                return 0;
            }
            else
            {
                return Int64.Parse(obj.ToString());
            }
        }

        private DateTime TransNullToDate(Object obj)
        {
            if (obj.ToString() == "")
            {
                return DateTime.Parse("#1/1/1900#");
            }
            else
            {
                return DateTime.Parse(obj.ToString());
            }
        }

        private float TransNullToFloat(Object obj)
        {
            if (obj.ToString() == "")
            {
                return 0.0f;
            }
            else
            {
                return float.Parse(obj.ToString());
            }
        }


        private double TransNullToDouble(Object obj)
        {
            if (obj.ToString() == "")
            {
                return 0.0;
            }
            else
            {
                return double.Parse(obj.ToString());
            }
        }


        private bool TransNullToBool(Object obj)
        {
            if (obj.ToString() == "")
            {
                return false;
            }
            else
            {
                return bool.Parse(obj.ToString());
            }
        }

        public static int getStrLen(string strTemp)
        {
            int len;
            byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
            len = sarr.Length;//will output as 3+3*2=9
            return len;
        }

        protected void LogError(Exception objException)
        {
            //Log the error information to the Application Log
            string strLogMsg;
            try
            {

                strLogMsg = "An error occurred in the following module: "
               + mstrModuleName + "Source: " + objException.Source

               + "Message: " + objException.Message
               + "Stack Trace: " + objException.StackTrace

               + "Target Site: " + objException.TargetSite.ToString();

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(mstrModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }

        protected static void LogErrorS(Exception objException, string strModuleName)
        {
            //Log the error information to the Application Log
            string strLogMsg;
            try
            {

                strLogMsg = "An error occurred in the following module: "
               + strModuleName + "Source: " + objException.Source

               + "Message: " + objException.Message
               + "Stack Trace: " + objException.StackTrace

               + "Target Site: " + objException.TargetSite.ToString();

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }
    }
}