
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenus_SubExWApi
 表名:vQxPrjMenus_Sub(00140079)
 生成代码版本:2019.03.24.1
 生成日期:2019/03/24 09:24:20
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:菜单管理
 模块英文名:MenuManage
 框架-层名:WebApi访问扩展层(WA_AccessEx)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using com.taishsoft.common;
using System.ServiceModel;
using GeneralPlatform.Entity;

using System.Collections.Generic;
using com.taishsoft.json;

namespace GP4WApi
{
 /// <summary>
 /// v子层菜单(vQxPrjMenus_Sub)
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public class clsvQxPrjMenus_SubExWApi
{
private static readonly string mstrApiControllerName = "vQxPrjMenus_SubExApi";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public static List<clsvQxPrjMenus_SubEN> arrvQxPrjMenus_SubObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
}
}