
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCommFun4BL4QxUserGroupPotence
 表名:QxUserGroupPotence(00140008)
 生成代码版本:2021.07.30.1
 生成日期:2021/07/30 00:06:25
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:统一平台
 工程ID:0014
 相关数据库:103.116.76.183,9433MSEduSys
 PrjDataBaseId:0199
 模块中文名:用户权限管理
 模块英文名:UserPotenceMan
 框架-层名:逻辑层公共函数类扩展(CommFun4BL)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
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
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogic;

namespace GeneralPlatform.BusinessLogicEx
{
 /// <summary>
 /// 用户权限关系(QxUserGroupPotence)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4BL4CSharp:GeneCode)
 /// </summary>
public class clsCommFun4BL4QxUserGroupPotence : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4BL4CSharp:Gen_4CFBL_ReFreshCache)
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
clsQxUserGroupPotenceBL.ReFreshThisCache();
clsvQxUserGroupPotenceBL.ReFreshThisCache();
}
}
}