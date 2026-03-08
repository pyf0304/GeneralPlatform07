
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxPrjMenusV2BLEx
表名:QxPrjMenusV2(00140112)
* 版本:2023.05.10.1(服务器:WIN-SRV103-116)
日期:2023/05/12 11:38:18
生成者:pyf
生成服务器IP:
工程名称:统一平台(0014)
CM工程:统一平台Web(变量首字母不限定)-全部函数集
相关数据库:103.116.76.183,9433GeneralPlatformTz
PrjDataBaseId:0218
模块中文名:菜单管理(MenuManage)
框架-层名:业务逻辑扩展层(CS)(BusinessLogicEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
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

using com.taishsoft.comm_db_obj;
using GeneralPlatform.Entity;
using System.Data;
using System.Data.SqlClient;
using GeneralPlatform.DAL;
using GeneralPlatform.BusinessLogic;
using System.Web.Routing;
using System.Runtime.Remoting.Messaging;

namespace GeneralPlatform.BusinessLogicEx
{
    /// <summary>
    /// /// 功能:当本表执行添加、修改、删除操作时，对相关表执行相应的操作，此处定义一个类，在外面可以扩展该类的相关函数，达到自定义操作
    /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Class_RelatedActionsEx)
    /// </summary>
    public class RelatedActions_QxPrjMenusV2Ex : RelatedActions_QxPrjMenusV2
    {
        public override bool UpdRelaTabDate(int intid, string strOpUser)
        {
            return true;
        }
    }
    public static class clsQxPrjMenusV2BLEx_Static
    {

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyToEx)
        /// </summary>
        /// <param name = "objQxPrjMenusV2ENS">源对象</param>
        /// <returns>目标对象=>clsQxPrjMenusV2EN:objQxPrjMenusV2ENT</returns>
        public static clsQxPrjMenusV2ENEx CopyToEx(this clsQxPrjMenusV2EN objQxPrjMenusV2ENS)
        {
            try
            {
                clsQxPrjMenusV2ENEx objQxPrjMenusV2ENT = new clsQxPrjMenusV2ENEx();
                clsQxPrjMenusV2BL.QxPrjMenusV2DA.CopyTo(objQxPrjMenusV2ENS, objQxPrjMenusV2ENT);
                return objQxPrjMenusV2ENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000018)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_Static_CopyTo)
        /// </summary>
        /// <param name = "objQxPrjMenusV2ENS">源对象</param>
        /// <returns>目标对象=>clsQxPrjMenusV2EN:objQxPrjMenusV2ENT</returns>
        public static clsQxPrjMenusV2EN CopyTo(this clsQxPrjMenusV2ENEx objQxPrjMenusV2ENS)
        {
            try
            {
                clsQxPrjMenusV2EN objQxPrjMenusV2ENT = new clsQxPrjMenusV2EN();
                clsQxPrjMenusV2BL.CopyTo(objQxPrjMenusV2ENS, objQxPrjMenusV2ENT);
                return objQxPrjMenusV2ENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000019)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }
    }
    /// <summary>
    /// 工程菜单V2(QxPrjMenusV2)
    /// 数据源类型:表
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsQxPrjMenusV2BLEx : clsQxPrjMenusV2BL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsQxPrjMenusV2DAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsQxPrjMenusV2DAEx QxPrjMenusV2DAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsQxPrjMenusV2DAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_CopyToEx)
        /// </summary>
        /// <param name = "objQxPrjMenusV2ENS">源对象</param>
        /// <returns>目标对象=>clsQxPrjMenusV2EN:objQxPrjMenusV2ENT</returns>
        public static clsQxPrjMenusV2ENEx CopyToEx(clsQxPrjMenusV2EN objQxPrjMenusV2ENS)
        {
            try
            {
                clsQxPrjMenusV2ENEx objQxPrjMenusV2ENT = new clsQxPrjMenusV2ENEx();
                clsQxPrjMenusV2BL.QxPrjMenusV2DA.CopyTo(objQxPrjMenusV2ENS, objQxPrjMenusV2ENT);
                return objQxPrjMenusV2ENT;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("(errid:BlEx000020)Copy表对象数据出错,{1}.({0})",
                clsStackTrace.GetCurrClassFunction(),
                objException.Message);
                throw new Exception(strMsg);
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsQxPrjMenusV2ENEx> GetObjExLst(string strCondition)
        {
            List<clsQxPrjMenusV2EN> arrObjLst = clsQxPrjMenusV2BL.GetObjLst(strCondition);
            List<clsQxPrjMenusV2ENEx> arrObjExLst = new List<clsQxPrjMenusV2ENEx>();
            foreach (clsQxPrjMenusV2EN objInFor in arrObjLst)
            {
                clsQxPrjMenusV2ENEx objQxPrjMenusV2ENEx = new clsQxPrjMenusV2ENEx();
                clsQxPrjMenusV2BL.CopyTo(objInFor, objQxPrjMenusV2ENEx);
                arrObjExLst.Add(objQxPrjMenusV2ENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "intid">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsQxPrjMenusV2ENEx GetObjExByid(int intid)
        {
            clsQxPrjMenusV2EN objQxPrjMenusV2EN = clsQxPrjMenusV2BL.GetObjByid(intid);
            clsQxPrjMenusV2ENEx objQxPrjMenusV2ENEx = new clsQxPrjMenusV2ENEx();
            clsQxPrjMenusV2BL.CopyTo(objQxPrjMenusV2EN, objQxPrjMenusV2ENEx);
            return objQxPrjMenusV2ENEx;
        }

        public static bool MovePrjMenus_UP(string strPrjId, string strMenuId)
        {
            string strCondition = $"{conQxPrjMenus.QxPrjId}='{strPrjId}' and {conQxPrjMenus.MenuId}='{strMenuId}'";
            var arrQxPrjMenus = clsQxPrjMenusBL.GetObjLst(strCondition);
            foreach (var objInfo in arrQxPrjMenus)
            {
                if (objInfo.UpMenuId != "00000000") continue;
                clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
                objQxPrjMenusV2EN.id = 1;
                objQxPrjMenusV2EN.MenuName = objInfo.MenuName;
                objQxPrjMenusV2EN.createdAt = objInfo.UpdDate;
                objQxPrjMenusV2EN.updatedAt = objInfo.UpdDate;
                //objQxPrjMenusV2EN.id= objInfo. ;
                objQxPrjMenusV2EN.parentMenuId = null;// objInfo.UpMenuId;
                objQxPrjMenusV2EN.MenuName = objInfo.MenuName;
                objQxPrjMenusV2EN.router = "";// objInfo. ;
                objQxPrjMenusV2EN.perms = null;// objInfo. ;
                objQxPrjMenusV2EN.type = 0;// objInfo. ;
                objQxPrjMenusV2EN.icon = "";// objInfo. ;
                objQxPrjMenusV2EN.OrderNum = 1;// objInfo. ;
                objQxPrjMenusV2EN.viewPath = "";// objInfo. ;
                objQxPrjMenusV2EN.keepalive = true;// objInfo. ;
                objQxPrjMenusV2EN.isShow = true;// objInfo. ;
                objQxPrjMenusV2EN.isExt = true;// objInfo. ;
                objQxPrjMenusV2EN.openMode = 1;// objInfo. ;
                objQxPrjMenusV2EN.QxPrjId = objInfo.QxPrjId;
                objQxPrjMenusV2EN.UpdUserId = objInfo.UpdUserId;
                objQxPrjMenusV2EN.Memo = objInfo.Memo;
                objQxPrjMenusV2EN.LinkFile = objInfo.LinkFile;
                objQxPrjMenusV2EN.UpdDate = objInfo.UpdDate;
                objQxPrjMenusV2EN.MenuControlName = objInfo.MenuControlName;
                objQxPrjMenusV2EN.ApplicationTypeId = objInfo.ApplicationTypeId;
                objQxPrjMenusV2EN.MenuTitle = objInfo.MenuTitle;
                objQxPrjMenusV2EN.PageDispModeId = objInfo.PageDispModeId;
                objQxPrjMenusV2EN.InUse = objInfo.InUse;
                objQxPrjMenusV2EN.qsParameters = objInfo.qsParameters;
                objQxPrjMenusV2EN.ImgFile = objInfo.ImgFile;
                objQxPrjMenusV2EN.TabId = objInfo.TabId;
                objQxPrjMenusV2EN.RoleId = objInfo.RoleId;
                objQxPrjMenusV2EN.IsLeafNode = objInfo.IsLeafNode;
                //objQxPrjMenusV2EN.MenuSetId = objInfo.MenuSetId;
                objQxPrjMenusV2EN.MenuIdOld = objInfo.MenuId;

                clsQxPrjMenusV2BL.CheckPropertyNew(objQxPrjMenusV2EN);
                clsQxPrjMenusV2BL.AddNewRecordBySql2(objQxPrjMenusV2EN);
            }
            return true;
        }

        public static bool MovePrjMenus_Sub(string strPrjId, string strMenuId)
        {
            string strCondition = $"{conQxPrjMenus.QxPrjId}='{strPrjId}' and {conQxPrjMenus.MenuId}='{strMenuId}'";
            var arrQxPrjMenus = clsQxPrjMenusBL.GetObjLst(strCondition);
            foreach (var objInfo in arrQxPrjMenus)
            {
                if (objInfo.UpMenuId == "00000000") continue;
                string strCondition_Parent = $"{conQxPrjMenus.QxPrjId}='{strPrjId}' "
                + $" and {conQxPrjMenus.MenuId}='{strMenuId}'"
                + $" and {conQxPrjMenusV2.MenuIdOld}='{objInfo.UpMenuId}'";
                var objPrent = clsQxPrjMenusV2BL.GetFirstObj_S(strCondition_Parent);
                if (objPrent == null) continue;
                clsQxPrjMenusV2EN objQxPrjMenusV2EN = new clsQxPrjMenusV2EN();
                objQxPrjMenusV2EN.id = 1;
                objQxPrjMenusV2EN.MenuName = objInfo.MenuName;
                objQxPrjMenusV2EN.createdAt = objInfo.UpdDate;
                objQxPrjMenusV2EN.updatedAt = objInfo.UpdDate;
                //objQxPrjMenusV2EN.id= objInfo. ;
                objQxPrjMenusV2EN.parentMenuId = objPrent.id;
                objQxPrjMenusV2EN.MenuName = objInfo.MenuName;
                objQxPrjMenusV2EN.router =  objInfo.LinkFile ;
                objQxPrjMenusV2EN.perms = null;// objInfo. ;
                objQxPrjMenusV2EN.type = 1;// objInfo. ;
                objQxPrjMenusV2EN.icon = "icon-wangpan";// objInfo. ;
                objQxPrjMenusV2EN.OrderNum = 2;// objInfo. ;
                objQxPrjMenusV2EN.viewPath =$"views/{objInfo.LinkFile}" ;
                objQxPrjMenusV2EN.viewPath = objQxPrjMenusV2EN.viewPath.Replace("//","/");
                objQxPrjMenusV2EN.keepalive = true;// objInfo. ;
                objQxPrjMenusV2EN.isShow = true;// objInfo. ;
                objQxPrjMenusV2EN.isExt = false;// objInfo. ;
                objQxPrjMenusV2EN.openMode = 1;// objInfo. ;
                objQxPrjMenusV2EN.QxPrjId = objInfo.QxPrjId;
                objQxPrjMenusV2EN.UpdUserId = objInfo.UpdUserId;
                objQxPrjMenusV2EN.Memo = objInfo.Memo;
                objQxPrjMenusV2EN.LinkFile = objInfo.LinkFile;
                objQxPrjMenusV2EN.UpdDate = objInfo.UpdDate;
                objQxPrjMenusV2EN.MenuControlName = objInfo.MenuControlName;
                objQxPrjMenusV2EN.ApplicationTypeId = objInfo.ApplicationTypeId;
                objQxPrjMenusV2EN.MenuTitle = objInfo.MenuTitle;
                objQxPrjMenusV2EN.PageDispModeId = objInfo.PageDispModeId;
                objQxPrjMenusV2EN.InUse = objInfo.InUse;
                objQxPrjMenusV2EN.qsParameters = objInfo.qsParameters;
                objQxPrjMenusV2EN.ImgFile = objInfo.ImgFile;
                objQxPrjMenusV2EN.TabId = objInfo.TabId;
                objQxPrjMenusV2EN.RoleId = objInfo.RoleId;
                objQxPrjMenusV2EN.IsLeafNode = objInfo.IsLeafNode;
                //objQxPrjMenusV2EN.MenuSetId = objInfo.MenuSetId;
                objQxPrjMenusV2EN.MenuIdOld = objInfo.MenuId;

                clsQxPrjMenusV2BL.CheckPropertyNew(objQxPrjMenusV2EN);
                var strCondition_Uni = objQxPrjMenusV2EN.GetUniCondStr();
                if (clsQxPrjMenusV2BL.IsExistRecord(strCondition_Uni) == true)
                {
                    objQxPrjMenusV2EN.UpdateWithCondition(strCondition_Uni);
                }
                else
                {
                    clsQxPrjMenusV2BL.AddNewRecordBySql2(objQxPrjMenusV2EN);
                }
            }
            return true;
        }

    }
}