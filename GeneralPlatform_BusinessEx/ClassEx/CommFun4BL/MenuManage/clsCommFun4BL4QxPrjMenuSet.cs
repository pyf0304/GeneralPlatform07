
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCommFun4BL4QxPrjMenuSet
 表名:QxPrjMenuSet
 生成代码版本:2018.03.11.1
 生成日期:2018/03/15 14:19:17
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 模块中文名:菜单管理
 模块英文名:MenuManage
 框架-层名:逻辑层的公共函数
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.11.28.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Data; 
using System.Data.SqlClient; 
using System.Linq;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.file;
using CommonTable.Entity;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;

namespace GeneralPlatform.BusinessLogicEx
{
 /// <summary>
 /// 菜单集(QxPrjMenuSet)
 /// 数据源类型:SQL表
 /// (AutoGCLib.AutoGC6Cs_Business:A_GenCommFun4BL)
 /// </summary>
public class clsCommFun4BL4QxPrjMenuSet : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.AutoGC6Cs_Business:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsQxPrjMenuSetBL.ReFreshThisCache();
clsvQxPrjMenusBL.ReFreshThisCache();
clsvQxPrjMenuSetBL.ReFreshThisCache();
clsvQxPrjPotenceBL.ReFreshThisCache();
clsvQxRoleMenusBL.ReFreshThisCache();
clsvQxRoleMenus_SimBL.ReFreshThisCache();
clsvQxUserGroupPotenceBL.ReFreshThisCache();
clsvQxRelaOfPotenceAndSymbolBL.ReFreshThisCache();
clsvQxPotenceSymbolForRoleBL.ReFreshThisCache();
}
}
}