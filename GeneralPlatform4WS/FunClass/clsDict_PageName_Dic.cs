
//类名:clsDict_PageName_Dic
///----------------------
///生成代码版本:2017.02.05.1
///生成日期:2017/02/05
///生成者:潘以锋
///工程名称:统一平台
///工程ID:0014
///注意:1、需要数据底层(PubDataBase.dll)的版本:2016.12.13.01
///       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
/// ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralPlatform4WS
{
    /// <summary>
    /// 页面、目录字典
    /// </summary>
    public class clsDict_PageName_Dic
    {
        /// <summary>
        /// 页面名称
        /// </summary>
        public static List<string> arrPageName = new List<string>();
        /// <summary>
        /// 目录名称
        /// </summary>
        public static List<string> arrDir = new List<string>();
        /// <summary>
        /// 是否初始化字典
        /// </summary>
        public static bool mbolIsInitDict = false;
        /// <summary>
        /// 初始化页面、目录字典
        /// </summary>
        public static void InitDict()
        {
            if (mbolIsInitDict == true) return;
            arrPageName.Add("QxPotenceTypeService.asmx"); arrDir.Add("PotenceMan");
            arrPageName.Add("QxPrjMenusService.asmx"); arrDir.Add("MenuManage");
            arrPageName.Add("QxPrjPotenceService.asmx"); arrDir.Add("PotenceMan");
            arrPageName.Add("QxProjectsService.asmx"); arrDir.Add("PrjManage");
            arrPageName.Add("QxRoleMenusService.asmx"); arrDir.Add("MenuManage");
            arrPageName.Add("QxUserGroupPotenceService.asmx"); arrDir.Add("UserPotenceMan");
            arrPageName.Add("QxUserGroupRelationService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("QxUserGroupsService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("QxUserMenuDetailService.asmx"); arrDir.Add("MenuManage");
            arrPageName.Add("QxUserMenusService.asmx"); arrDir.Add("MenuManage");
            arrPageName.Add("QxUserRoleRelationService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("QxUserRolesService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("vQxUsersService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("QxUserStateService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("QxViewInfoService.asmx"); arrDir.Add("InterfaceMan");
            arrPageName.Add("QxViewPotenceService.asmx"); arrDir.Add("InterfaceMan");
            arrPageName.Add("QxRelaOfPotenceAndSymbolService.asmx"); arrDir.Add("PotenceMan");
            arrPageName.Add("QxPrjModuleService.asmx"); arrDir.Add("PrjManage");
            arrPageName.Add("vQxUserGroupPotenceService.asmx"); arrDir.Add("UserPotenceMan");
            arrPageName.Add("vQxUserRoleRelationService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("vQxUserRolesService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("vQxPotenceTypeService.asmx"); arrDir.Add("PotenceMan");
            arrPageName.Add("vQxPrjPotenceService.asmx"); arrDir.Add("PotenceMan");
            arrPageName.Add("vQxViewPotenceService.asmx"); arrDir.Add("InterfaceMan");
            arrPageName.Add("vQxViewInfoService.asmx"); arrDir.Add("InterfaceMan");
            arrPageName.Add("QxDepartmentInfoService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("QxPrjUserRelationService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("vQxPrjUserRelationService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("TSysParaService.asmx"); arrDir.Add("SysPara");
            arrPageName.Add("vQxRoleMenusService.asmx"); arrDir.Add("MenuManage");
            arrPageName.Add("vQxDepartmentInfoService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("SubjectTypeService.asmx"); arrDir.Add("SysPara");
            arrPageName.Add("QxDepartmentTypeService.asmx"); arrDir.Add("SysPara");
            arrPageName.Add("DataBaseTypeService.asmx"); arrDir.Add("PrjManage");
            arrPageName.Add("QxPrjDataBaseService.asmx"); arrDir.Add("PrjManage");
            arrPageName.Add("vQxPrjDataBaseService.asmx"); arrDir.Add("PrjManage");
            arrPageName.Add("QxUserIdentityService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("QxPageDispModeService.asmx"); arrDir.Add("MenuManage");
            arrPageName.Add("QxPrjMenuSetService.asmx"); arrDir.Add("MenuManage");
            arrPageName.Add("vQxPrjMenusService.asmx"); arrDir.Add("MenuManage");
            arrPageName.Add("vQxPotenceSymbolForRoleService.asmx"); arrDir.Add("PotenceMan");
            arrPageName.Add("vQxPrjModuleService.asmx"); arrDir.Add("PrjManage");
            arrPageName.Add("vQxRelaOfPotenceAndSymbolService.asmx"); arrDir.Add("PotenceMan");
            arrPageName.Add("ErrorInformationService.asmx"); arrDir.Add("LogManage");
            arrPageName.Add("QxUserLoginNameService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("SubjectRelationService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("vSubjectRelationService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("QxPrjFileRelaService.asmx"); arrDir.Add("PrjFileDownLoad");
            arrPageName.Add("QxPrjSite4DownLoadService.asmx"); arrDir.Add("PrjFileDownLoad");
            arrPageName.Add("QxUserCodePathService.asmx"); arrDir.Add("SystemSet");
            arrPageName.Add("QxCodeTypeService.asmx"); arrDir.Add("PrjFileDownLoad");
            arrPageName.Add("QxUserDownLoadLogService.asmx"); arrDir.Add("PrjFileDownLoad");
            arrPageName.Add("QxUserDownLoadDetailLogService.asmx"); arrDir.Add("PrjFileDownLoad");
            arrPageName.Add("vQxPrjFileRelaService.asmx"); arrDir.Add("PrjFileDownLoad");
            arrPageName.Add("vQxPrjSite4DownLoadService.asmx"); arrDir.Add("PrjFileDownLoad");
            arrPageName.Add("vQxUserDownLoadLogService.asmx"); arrDir.Add("PrjFileDownLoad");
            arrPageName.Add("vQxUserDownLoadDetailLogService.asmx"); arrDir.Add("PrjFileDownLoad");
            arrPageName.Add("vQxUserCodePathService.asmx"); arrDir.Add("SystemSet");
            arrPageName.Add("ExportExcelSetService.asmx"); arrDir.Add("SystemSet");
            arrPageName.Add("ExportExcel4UsersService.asmx"); arrDir.Add("SystemSet");
            arrPageName.Add("vExportExcelSetService.asmx"); arrDir.Add("SystemSet");
            arrPageName.Add("vExportExcel4UsersService.asmx"); arrDir.Add("SystemSet");
            arrPageName.Add("SetFieldVisibilityService.asmx"); arrDir.Add("SystemSet");
            arrPageName.Add("vSetFieldVisibilityService.asmx"); arrDir.Add("SystemSet");
            arrPageName.Add("XzSchoolService.asmx"); arrDir.Add("SystemSet");
            arrPageName.Add("vQxPrjMenuSetService.asmx"); arrDir.Add("MenuManage");
            arrPageName.Add("QxUsersService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("vQxRoleMenus_SimService.asmx"); arrDir.Add("MenuManage");
            arrPageName.Add("QxUsers_SchoolService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("vQxUsers_SchoolService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("vQxPrjUserRelationByRoleService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("vQxUserLoginNameService.asmx"); arrDir.Add("UserManage");
            mbolIsInitDict = true;
        }
        /// <summary>
        /// 根据页面名称获取相应的目录
        /// </summary>
        /// <param name="strPageName"></param>
        /// <returns></returns>
        public static string GetDir4PageName(string strPageName)
        {
            InitDict();
            int intCount = arrPageName.Count;
            for (int i = 0; i < intCount; i++)
            {
                if (arrPageName[i].Equals(strPageName, StringComparison.InvariantCultureIgnoreCase) == true)
                {
                    return arrDir[i];
                }
            }
            return "";
        }
    }
}