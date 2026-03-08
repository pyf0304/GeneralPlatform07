
//类名:clsDict_PageName_Dic
///----------------------
///生成代码版本:2017.02.05.1
///生成日期:2017/03/16
///生成者:潘以锋
///工程名称:简单工程样例
///工程ID:0116
///注意:1、需要数据底层(PubDataBase.dll)的版本:2017.02.21.01
///       2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
/// ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  ==  == 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GP4WApi
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
            arrPageName.Add("ChineseToPinYinService.asmx"); arrDir.Add("BaseInfo");
            arrPageName.Add("ClassRoomService.asmx"); arrDir.Add("BaseInfo");
            arrPageName.Add("CollegeService.asmx"); arrDir.Add("BaseInfo");
            arrPageName.Add("DepartmentInfoService.asmx"); arrDir.Add("BaseInfo");
            arrPageName.Add("ErrorInformationService.asmx"); arrDir.Add("LogManage");
            arrPageName.Add("ExamTypeService.asmx"); arrDir.Add("BaseInfo");
            arrPageName.Add("ExportExcel4UsersService.asmx"); arrDir.Add("SysManage");
            arrPageName.Add("ExportExcelSetService.asmx"); arrDir.Add("SysManage");
            arrPageName.Add("SchoolTermService.asmx"); arrDir.Add("BaseTab");
            arrPageName.Add("SetFieldVisibilityService.asmx"); arrDir.Add("SysManage");
            arrPageName.Add("SexService.asmx"); arrDir.Add("BaseInfo");
            arrPageName.Add("StudentService.asmx"); arrDir.Add("BaseInfo");
            arrPageName.Add("StudentInfoService.asmx"); arrDir.Add("BaseInfo");
            arrPageName.Add("teachInfoService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("UserInfoService.asmx"); arrDir.Add("UserManage");
            arrPageName.Add("UsersService.asmx"); arrDir.Add("BaseInfo");
            arrPageName.Add("UserStateService.asmx"); arrDir.Add("BaseInfo");
            arrPageName.Add("vExportExcel4UsersService.asmx"); arrDir.Add("SysManage");
            arrPageName.Add("vExportExcelSetService.asmx"); arrDir.Add("SysManage");
            arrPageName.Add("vSetFieldVisibilityService.asmx"); arrDir.Add("SysManage");
            arrPageName.Add("vUsersService.asmx"); arrDir.Add("BaseInfo");
            arrPageName.Add("XzGradeBaseService.asmx"); arrDir.Add("BaseParameter");
            arrPageName.Add("XzMajorService.asmx"); arrDir.Add("BaseInfo");
            arrPageName.Add("XzSchoolService.asmx"); arrDir.Add("SysManage");
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