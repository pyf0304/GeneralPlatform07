
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsExportExcel4UsersEN
 表名:ExportExcel4Users
 生成代码版本:2017.05.08.1
 生成日期:2017/05/08 11:04:53
 生成者:
 工程名称:统一平台
 工程ID:0014
 模块中文名:系统设置
 模块英文名:SystemSet
 框架-层名:实体层
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2017.05.05.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2016.12.13.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace GeneralPlatform.Entity
{
 /// <summary>
 /// 导出Excel用户字段表(ExportExcel4Users)
 /// (AutoGCLib.AutoGC6Cs_M:A_GenEntityLayerCode)
 /// </summary>
[Serializable]
public class clsExportExcel4UsersEN : clsEntityBase2
{
public const string CurrTabName_S = "ExportExcel4Users"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"mId", "id_ExportExcel4Users", "FieldName", "FieldCnName", "IsExport", "OrderNum", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量

protected long mlngmId;    //流水号
protected string mstrid_ExportExcel4Users;    //导出Excel用户字段流水号
protected string mstrFieldName;    //字段名
protected string mstrFieldCnName;    //字段中文名称
protected bool mbolIsExport;    //是否导出
protected int mintOrderNum;    //排序号
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注


 /// <summary>
 /// 常量:"mId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_mId = "mId";    //流水号

 /// <summary>
 /// 常量:"id_ExportExcel4Users"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_ExportExcel4Users = "id_ExportExcel4Users";    //导出Excel用户字段流水号

 /// <summary>
 /// 常量:"FieldName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FieldName = "FieldName";    //字段名

 /// <summary>
 /// 常量:"FieldCnName"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FieldCnName = "FieldCnName";    //字段中文名称

 /// <summary>
 /// 常量:"IsExport"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsExport = "IsExport";    //是否导出

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_OrderNum = "OrderNum";    //排序号

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor1)
/// </summary>
 public clsExportExcel4UsersEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 CurrTabName = "ExportExcel4Users";
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.AutoGCPubFuncV6:GenClassConstructor2)
/// </summary>
/// <param name = "mlngmId">关键字:流水号</param>
public clsExportExcel4UsersEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 CurrTabName = "ExportExcel4Users";
 lstKeyFldNames.Add("mId");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_mId)
{
return mlngmId;
}
else if (strAttributeName  ==  con_id_ExportExcel4Users)
{
return mstrid_ExportExcel4Users;
}
else if (strAttributeName  ==  con_FieldName)
{
return mstrFieldName;
}
else if (strAttributeName  ==  con_FieldCnName)
{
return mstrFieldCnName;
}
else if (strAttributeName  ==  con_IsExport)
{
return mbolIsExport;
}
else if (strAttributeName  ==  con_OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  con_UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  con_UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (strAttributeName  ==  con_id_ExportExcel4Users)
{
mstrid_ExportExcel4Users = value.ToString();
 AddUpdatedFld(con_id_ExportExcel4Users);
}
else if (strAttributeName  ==  con_FieldName)
{
mstrFieldName = value.ToString();
 AddUpdatedFld(con_FieldName);
}
else if (strAttributeName  ==  con_FieldCnName)
{
mstrFieldCnName = value.ToString();
 AddUpdatedFld(con_FieldCnName);
}
else if (strAttributeName  ==  con_IsExport)
{
mbolIsExport = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsExport);
}
else if (strAttributeName  ==  con_OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
else if (strAttributeName  ==  con_UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (strAttributeName  ==  con_UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(con_UpdUserId);
}
else if (strAttributeName  ==  con_Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (con_mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (con_id_ExportExcel4Users  ==  AttributeName[intIndex])
{
return mstrid_ExportExcel4Users;
}
else if (con_FieldName  ==  AttributeName[intIndex])
{
return mstrFieldName;
}
else if (con_FieldCnName  ==  AttributeName[intIndex])
{
return mstrFieldCnName;
}
else if (con_IsExport  ==  AttributeName[intIndex])
{
return mbolIsExport;
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(con_mId);
}
else if (con_id_ExportExcel4Users  ==  AttributeName[intIndex])
{
mstrid_ExportExcel4Users = value.ToString();
 AddUpdatedFld(con_id_ExportExcel4Users);
}
else if (con_FieldName  ==  AttributeName[intIndex])
{
mstrFieldName = value.ToString();
 AddUpdatedFld(con_FieldName);
}
else if (con_FieldCnName  ==  AttributeName[intIndex])
{
mstrFieldCnName = value.ToString();
 AddUpdatedFld(con_FieldCnName);
}
else if (con_IsExport  ==  AttributeName[intIndex])
{
mbolIsExport = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsExport);
}
else if (con_OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(con_OrderNum);
}
else if (con_UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(con_UpdDate);
}
else if (con_UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(con_UpdUserId);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}

/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public long mId
{
get
{
return mlngmId;
}
set
{
 mlngmId = value;
//记录修改过的字段
 AddUpdatedFld(con_mId);
}
}
/// <summary>
/// 导出Excel用户字段流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string id_ExportExcel4Users
{
get
{
return mstrid_ExportExcel4Users;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrid_ExportExcel4Users = value;
}
else
{
 mstrid_ExportExcel4Users = value;
}
//记录修改过的字段
 AddUpdatedFld(con_id_ExportExcel4Users);
}
}
/// <summary>
/// 字段名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string FieldName
{
get
{
return mstrFieldName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldName = value;
}
else
{
 mstrFieldName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FieldName);
}
}
/// <summary>
/// 字段中文名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string FieldCnName
{
get
{
return mstrFieldCnName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFieldCnName = value;
}
else
{
 mstrFieldCnName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FieldCnName);
}
}
/// <summary>
/// 是否导出(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public bool IsExport
{
get
{
return mbolIsExport;
}
set
{
 mbolIsExport = value;
//记录修改过的字段
 AddUpdatedFld(con_IsExport);
}
}
/// <summary>
/// 排序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public int OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(con_OrderNum);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UpdDate
{
get
{
return mstrUpdDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdDate = value;
}
else
{
 mstrUpdDate = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string UpdUserId
{
get
{
return mstrUpdUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUserId = value;
}
else
{
 mstrUpdUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UpdUserId);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
/// </summary>
 public string Memo
{
get
{
return mstrMemo;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMemo = value;
}
else
{
 mstrMemo = value;
}
//记录修改过的字段
 AddUpdatedFld(con_Memo);
}
}
}
}