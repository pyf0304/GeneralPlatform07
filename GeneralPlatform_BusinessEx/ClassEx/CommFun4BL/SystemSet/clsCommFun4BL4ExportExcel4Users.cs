
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCommFun4BL4ExportExcel4Users
 表名:ExportExcel4Users
 生成代码版本:2017.05.08.1
 生成日期:2017/05/08 11:04:56
 生成者:
 工程名称:统一平台
 工程ID:0014
 模块中文名:系统设置
 模块英文名:SystemSet
 框架-层名:逻辑层的公共函数
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
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
 /// 导出Excel用户字段表(ExportExcel4Users)
 /// 数据源类型:SQL表
 /// (AutoGCLib.AutoGC6Cs_Business:A_GenCommFun4BL)
 /// </summary>
public class clsCommFun4BL4ExportExcel4Users : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.AutoGC6Cs_Business:Gen_4CFBL_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsExportExcel4UsersBL.arrExportExcel4UsersObjLst_Cache = null;
clsvExportExcel4UsersBL.arrvExportExcel4UsersObjLst_Cache = null;
}
}
}