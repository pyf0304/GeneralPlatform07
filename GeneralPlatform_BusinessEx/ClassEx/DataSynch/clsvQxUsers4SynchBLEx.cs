
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvQxUsers4SynchBLEx
表名:vQxUsers4Synch(00140090)
生成代码版本:2019.03.20.1
生成日期:2019/03/20 18:18:59
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
    /// vQxUsers4Synch(vQxUsers4Synch)
    /// 数据源类型:SQL视图
    /// (AutoGCLib.BusinessLogicEx4CSharp:GeneCode)
    /// </summary>
    public partial class clsvQxUsers4SynchBLEx : clsvQxUsers4SynchBL
    {

        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_DefineUniqueInstance4DALEx)
        /// </summary>
        private static clsvQxUsers4SynchDAEx uniqueInstanceEx = null;
        /// <summary>
        /// 单例模式:访问数据访问扩展层的单例模式，使数据访问扩展层的访问不需要多次初始化。
        /// </summary>
        private static clsvQxUsers4SynchDAEx vQxUsers4SynchDAEx
        {
            get
            {
                if (uniqueInstanceEx == null)
                {
                    uniqueInstanceEx = new clsvQxUsers4SynchDAEx();
                }
                return uniqueInstanceEx;
            }
        }

        /// <summary>
        /// 根据条件获取扩展对象列表
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExLst)
        /// </summary>
        /// <param name = "strCondition">给定条件</param>
        /// <returns>返回扩展对象列表</returns>
        public static List<clsvQxUsers4SynchENEx> GetObjExLst(string strCondition)
        {
            List<clsvQxUsers4SynchEN> arrObjLst = clsvQxUsers4SynchBL.GetObjLst(strCondition);
            List<clsvQxUsers4SynchENEx> arrObjExLst = new List<clsvQxUsers4SynchENEx>();
            foreach (clsvQxUsers4SynchEN objInFor in arrObjLst)
            {
                clsvQxUsers4SynchENEx objvQxUsers4SynchENEx = new clsvQxUsers4SynchENEx();
                clsvQxUsers4SynchBL.CopyTo(objInFor, objvQxUsers4SynchENEx);
                arrObjExLst.Add(objvQxUsers4SynchENEx);
            }
            return arrObjExLst;
        }

        /// <summary>
        /// 获取当前关键字的记录对象,用扩展对象的形式表示.
        /// (AutoGCLib.BusinessLogicEx4CSharp:Gen_4BLEx_GetObjExByKey)
        /// </summary>
        /// <param name = "lngmId">表关键字</param>
        /// <returns>表扩展对象</returns>
        public static clsvQxUsers4SynchENEx GetObjExBymId(long lngmId)
        {
            clsvQxUsers4SynchEN objvQxUsers4SynchEN = clsvQxUsers4SynchBL.GetObjBymId(lngmId);
            clsvQxUsers4SynchENEx objvQxUsers4SynchENEx = new clsvQxUsers4SynchENEx();
            clsvQxUsers4SynchBL.CopyTo(objvQxUsers4SynchEN, objvQxUsers4SynchENEx);
            return objvQxUsers4SynchENEx;
        }
    }
}