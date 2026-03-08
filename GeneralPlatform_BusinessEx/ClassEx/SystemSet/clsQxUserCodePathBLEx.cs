
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxUserCodePathBLEx
表名:QxUserCodePath
生成代码版本:2017.05.08.1
生成日期:2017/05/08 11:05:49
生成者:
工程名称:统一平台
工程ID:0014
模块中文名:系统设置
模块英文名:SystemSet
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
    /// 用户生成路径(QxUserCodePath)
    /// 数据源类型:SQL表
    /// (AutoGCLib.AutoGC6Cs_Business:A_GenBusinessLogicExCode)
    /// </summary>
    public class clsQxUserCodePathBLEx : clsQxUserCodePathBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.AutoGC6Cs_Business:Gen_4BL_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxUserCodePathDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxUserCodePathDAEx QxUserCodePathDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxUserCodePathDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        public static bool CopyUserCodePathFromTemplate(string strPrjId, string strUserId)
        {
            //clsQxUserCodePathEN objUserCodePathEN = new clsQxUserCodePathEN();
            string strCurrDate = clsDateTime_Db.GetDataBaseDateTime14();
            string strCondition = string.Format("{0}='0000' And IsTemplate='1'", conQxUserCodePath.QxPrjId);
            List<clsQxUserCodePathEN> arrUserCodePathENObjLst = clsQxUserCodePathBL.GetObjLst(strCondition);
            foreach (clsQxUserCodePathEN objUserCodePathEN in arrUserCodePathENObjLst)
            {
                strCondition = string.Format("{3}='{0}'  And UserId='{2}' And QxCodeTypeId={1} ", strPrjId,
                                   objUserCodePathEN.QxCodeTypeId, strUserId, conQxUserCodePath.QxPrjId);
                if (clsQxUserCodePathBL.IsExistRecord(strCondition) == false)
                {
                    objUserCodePathEN.QxPrjId = strPrjId;
                    objUserCodePathEN.UserId = strUserId;
                    objUserCodePathEN.UpdDate = strCurrDate;
                    objUserCodePathEN.CodePath = objUserCodePathEN.CodePath.Replace("pyf", strUserId);
                    objUserCodePathEN.CodePathBackup = objUserCodePathEN.CodePathBackup.Replace("pyf", strUserId);

                    objUserCodePathEN.UpdUserId = strUserId;
                    clsQxUserCodePathBL.AddNewRecordBySql2(objUserCodePathEN);
                }
            }
            return true;
        }
        public static string GetFileFromFolder(string strFolder, string strSimpleFileName)
        {
            if (System.IO.Directory.Exists(strFolder) == false)
            {
                string strMsg = string.Format("目录：{0}不存在！请检查！", strFolder);
                throw new Exception(strMsg);
            }
            DirectoryInfo objDirectory = new DirectoryInfo(strFolder);
            FileInfo[] arrFileInfoLst = objDirectory.GetFiles();
            foreach (FileInfo objFileInfo in arrFileInfoLst)
            {
                if (objFileInfo.Name == strSimpleFileName)
                {
                    //objFileInfo.
                    return objFileInfo.FullName;
                }

            }
            DirectoryInfo[] arrDirectoryInfoLst = objDirectory.GetDirectories();
            foreach (DirectoryInfo objDirectoryInfo in arrDirectoryInfoLst)
            {
                string strFindFile = GetFileFromFolder(objDirectoryInfo, strSimpleFileName);
                if (string.IsNullOrEmpty(strFindFile) == false)
                {
                    return strFindFile;
                }
            }
            return "";
        }


        public static string GetFileFromFolder(DirectoryInfo objDirectoryP, string strSimpleFileName)
        {

            FileInfo[] arrFileInfoLst = objDirectoryP.GetFiles();
            foreach (FileInfo objFileInfo in arrFileInfoLst)
            {
                if (objFileInfo.Name == strSimpleFileName)
                {
                    //objFileInfo.
                    return objFileInfo.FullName;
                }
            }
            DirectoryInfo[] arrDirectoryInfoLst = objDirectoryP.GetDirectories();
            foreach (DirectoryInfo objDirectoryInfo in arrDirectoryInfoLst)
            {
                string strFindFile = GetFileFromFolder(objDirectoryInfo, strSimpleFileName);
                if (string.IsNullOrEmpty(strFindFile) == false)
                {
                    return strFindFile;
                }
            }
            return "";
        }

    }
}