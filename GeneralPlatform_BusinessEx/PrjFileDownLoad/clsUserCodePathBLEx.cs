using System;
using System.IO;

using System.Collections.Generic;
using System.Text;
using GeneralPlatform.Entity;
using com.taishsoft.commdb;
using GeneralPlatform.BusinessLogic;

namespace GeneralPlatform.BusinessLogicEx
{
    public class clsQxUserCodePathBLEx : clsQxUserCodePathBL
    {

        public static bool CopyUserCodePathFromTemplate(string strPrjId, string strUserId)
        {
            //clsQxUserCodePathEN objUserCodePathEN = new clsQxUserCodePathEN();
            string strCurrDate = clsDateTime_Db.GetDataBaseDateTime14();
            string strCondition = string.Format("{0}='0000' And IsTemplate='1'", clsQxUserCodePathEN.con_QxPrjId);
            List<clsQxUserCodePathEN> arrUserCodePathENObjLst = clsQxUserCodePathBL.GetObjLst(strCondition);
            foreach (clsQxUserCodePathEN objUserCodePathEN in arrUserCodePathENObjLst)
            {
                strCondition = string.Format("{3}='{0}'  And UserId='{2}' And QxCodeTypeId={1} ", strPrjId,
                                   objUserCodePathEN.QxCodeTypeId, strUserId, clsQxUserCodePathEN.con_QxPrjId);
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
