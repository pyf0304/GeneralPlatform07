
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxPrjDataBaseBLEx
表名:QxPrjDataBase
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:05:17
生成者:
工程名称:统一平台
工程ID:0014
模块中文名:工程管理
模块英文名:PrjManage
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
    /// 数据库对象(QxPrjDataBase)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsQxPrjDataBaseBLEx : clsQxPrjDataBaseBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxPrjDataBaseDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxPrjDataBaseDAEx QxPrjDataBaseDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxPrjDataBaseDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        ///生成绑定ListView的代码
        /// <summary>
        /// 函数功能：根据界面上查询控件中所设置内容查询表记录，
        ///			 并显示在ListView中。
        /// </summary>
        public static int BindLv_QxPrjDataBase(System.Windows.Forms.ListView lvPrjDataBase, string strWhereCond)
        {
            ///	操作步骤：(共4步)
            ///	1、组合界面条件串；
            ///	2、根据条件串获取该表满足条件的DataTable；
            ///	3、设置ListView的列头信息
            ///	4、设置ListView的Item信息。即把所有记录显示在ListView中
            ///		在本界面中是把状态显示在控件lblRecCount中。

            System.Windows.Forms.ListViewItem lviPrjDataBase;
            List<clsQxPrjDataBaseEN> arrPrjDataBaseObjList;
            ///	2、根据条件串获取该表满足条件的DataTable；
            arrPrjDataBaseObjList = clsQxPrjDataBaseBL.GetObjLst(strWhereCond);
            ///	3、设置ListView的列头信息
            lvPrjDataBase.Items.Clear();//清除原来所有Item
            lvPrjDataBase.Columns.Clear();//清除原来所有列头信息
            lvPrjDataBase.Columns.Add("项目数据库Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("项目数据库名", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("数据库名称", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("数据库拥有者", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("数据库用户口令", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("数据库类型ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("数据库用户Id", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("IP地址", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("SID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("表空间", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("用户ID", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("UpdDate", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.Columns.Add("备注", 100, System.Windows.Forms.HorizontalAlignment.Left);
            lvPrjDataBase.View = System.Windows.Forms.View.Details;
            ///	4、设置ListView的Item信息。即把所有记录显示在ListView中
            foreach (clsQxPrjDataBaseEN objPrjDataBase in arrPrjDataBaseObjList)
            {
                lviPrjDataBase = new System.Windows.Forms.ListViewItem();
                lviPrjDataBase.Tag = objPrjDataBase.QxPrjDataBaseId;
                lviPrjDataBase.Text = objPrjDataBase.QxPrjDataBaseId.ToString();
                lviPrjDataBase.SubItems.Add(objPrjDataBase.PrjDataBaseName);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.DataBaseName);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.DatabaseOwner);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.DataBasePwd);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.DataBaseTypeId);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.DataBaseUserId);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.IpAddress);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.SID);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.TableSpace);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.UserId);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.UpdDate);
                lviPrjDataBase.SubItems.Add(objPrjDataBase.Memo);
                lvPrjDataBase.Items.Add(lviPrjDataBase);
            }
            ///	4、设置记录数的状态，
            ///		在本界面中是把状态显示在控件txtRecCount中。
            return arrPrjDataBaseObjList.Count;
        }
        public string GetConnectString_db(clsQxPrjDataBaseEN objPrjDataBaseEN)
        {

            {
                //获得连接字符串
                StringBuilder sbConnectString = new StringBuilder();
                if (objPrjDataBaseEN.DataBaseTypeId == "01" || objPrjDataBaseEN.DataBaseTypeId == "04")
                {
                    sbConnectString.AppendFormat("server={0};", objPrjDataBaseEN.IpAddress);
                    sbConnectString.AppendFormat("database={0};", objPrjDataBaseEN.DataBaseName);
                    sbConnectString.AppendFormat("uid={0};", objPrjDataBaseEN.DataBaseUserId);
                    sbConnectString.AppendFormat("pwd={0};", objPrjDataBaseEN.DataBasePwd);
                }
                else if (objPrjDataBaseEN.DataBaseTypeId == "02")
                {
                    sbConnectString.Append("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)");
                    sbConnectString.AppendFormat("(HOST={0})",
                        objPrjDataBaseEN.IpAddress);
                    sbConnectString.Append("(PORT=1521)))");
                    sbConnectString.AppendFormat("(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={0})));",
                        objPrjDataBaseEN.SID);
                    sbConnectString.AppendFormat("User Id={0};Password={1};",
                        objPrjDataBaseEN.DataBaseUserId,
                        objPrjDataBaseEN.DataBasePwd);
                }
                else
                {
                    return "";
                }
                return sbConnectString.ToString();

            }
        }

        public static string GetConnectString(clsQxPrjDataBaseEN objPrjDataBase)
        {
            if (string.IsNullOrEmpty(objPrjDataBase.DataBasePwd) == true)
            {
                throw new Exception("数据库的口令不能为空！");

            }
            ///获得连接字符串
            StringBuilder sbConnectString = new StringBuilder();
            if (objPrjDataBase.DataBaseTypeId == "01" || objPrjDataBase.DataBaseTypeId == "04")
            {
                sbConnectString.AppendFormat("server={0};", objPrjDataBase.IpAddress);
                sbConnectString.AppendFormat("database={0};", objPrjDataBase.DataBaseName);
                sbConnectString.AppendFormat("uid={0};", objPrjDataBase.DataBaseUserId);
                sbConnectString.AppendFormat("pwd={0};", objPrjDataBase.DataBasePwd);
            }
            else if (objPrjDataBase.DataBaseTypeId == "02")
            {
                sbConnectString.Append("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)");
                sbConnectString.AppendFormat("(HOST={0})",
                    objPrjDataBase.IpAddress);
                sbConnectString.Append("(PORT=1521)))");
                sbConnectString.AppendFormat("(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={0})));",
                    objPrjDataBase.SID);
                sbConnectString.AppendFormat("User Id={0};Password={1};",
                    objPrjDataBase.DataBaseUserId,
                    objPrjDataBase.DataBasePwd);
            }
            else
            {
                throw new Exception(string.Format("数据库类型:({0})不正确或者没有设置，请重新设置！", objPrjDataBase.DataBaseTypeId));
                //                return "";
            }
            return sbConnectString.ToString();
        }
        public bool GetQxPrjDataBaseForXml(ref clsQxPrjDataBaseEN objPrjDataBaseEN)
        {
            string strCondition;
            System.Data.DataRow[] objDataRow;
            strCondition = " PrjDataBaseId=" + "'" + objPrjDataBaseEN.QxPrjDataBaseId + "'";
            objDataRow = clsSysParaEN.objSpecSqlForXml.GetDataRow(clsQxPrjDataBaseEN._CurrTabName, strCondition);
            if (objDataRow.Length == 0)
            {
                objDataRow = null;
                return false;
            }
            objPrjDataBaseEN.QxPrjDataBaseId = objDataRow[0]["PrjDataBaseId"].ToString().Trim();       //项目数据库Id
            objPrjDataBaseEN.PrjDataBaseName = objDataRow[0]["PrjDataBaseName"].ToString().Trim();       //项目数据库名
            objPrjDataBaseEN.DataBaseName = objDataRow[0]["DataBaseName"].ToString().Trim();       //数据库名
            objPrjDataBaseEN.DatabaseOwner = objDataRow[0]["DatabaseOwner"].ToString().Trim();       //数据库拥有者
            objPrjDataBaseEN.DataBasePwd = objDataRow[0]["DataBasePwd"].ToString().Trim();       //数据库的用户口令
            objPrjDataBaseEN.DataBaseTypeId = objDataRow[0]["DataBaseTypeId"].ToString().Trim();       //数据库类型ID
            objPrjDataBaseEN.DataBaseUserId = objDataRow[0]["DataBaseUserId"].ToString().Trim();       //数据库的用户ID
            objPrjDataBaseEN.IpAddress = objDataRow[0]["IpAddress"].ToString().Trim();       //服务器
            objPrjDataBaseEN.SID = objDataRow[0]["SID"].ToString().Trim();       //SID
            objPrjDataBaseEN.TableSpace = objDataRow[0]["TableSpace"].ToString().Trim();       //表空间
            objPrjDataBaseEN.UserId = objDataRow[0]["UserId"].ToString().Trim();       //用户ID
            objPrjDataBaseEN.UpdDate = objDataRow[0]["UpdDate"].ToString().Trim();       //修改日期
            objPrjDataBaseEN.Memo = objDataRow[0]["Memo"].ToString().Trim();       //备注
            objDataRow = null;
            return true;
        }

    }
}