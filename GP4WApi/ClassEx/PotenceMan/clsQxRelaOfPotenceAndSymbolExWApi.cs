
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxRelaOfPotenceAndSymbolExWApi
 表名:QxRelaOfPotenceAndSymbol(00140020)
 生成代码版本:2019.03.24.1
 生成日期:2019/03/24 09:23:46
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理
 模块英文名:PotenceMan
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
 /// 权限编程标志关系表(QxRelaOfPotenceAndSymbol)
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public class clsQxRelaOfPotenceAndSymbolExWApi
{
private static readonly string mstrApiControllerName = "QxRelaOfPotenceAndSymbolExApi";
 /// <summary>
 /// 静态的对象列表,用于缓存,针对记录较少,作为参数表可以使用
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
public static List<clsQxRelaOfPotenceAndSymbolEN> arrQxRelaOfPotenceAndSymbolObjLst_Cache = null;
 /// <summary>
 /// 从缓存中查找失败的次数
 /// (AutoGCLib.WA_AccessEx4CSharp:GeneCode)
 /// </summary>
protected static int intFindFailCount = 0;
}
}