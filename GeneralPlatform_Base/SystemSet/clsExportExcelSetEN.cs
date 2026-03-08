
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsExportExcelSetEN
 表名:ExportExcelSet(00140065)
 生成代码版本:2019.07.11.1
 生成日期:2019/07/12 10:00:53
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置
 模块英文名:SystemSet
 框架-层名:实体层(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Text; 
using System.Collections; 
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace GeneralPlatform.Entity
{
 /// <summary>
 /// 表ExportExcelSet的关键字(id_ExportExcel4Users)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_id_ExportExcel4Users_ExportExcelSet
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strid_ExportExcel4Users">表关键字</param>
public K_id_ExportExcel4Users_ExportExcelSet(string strid_ExportExcel4Users)
{
if (IsValid(strid_ExportExcel4Users)) Value = strid_ExportExcel4Users;
else
{
Value = null;
}
}
private static bool IsValid(string strid_ExportExcel4Users)
{
if (string.IsNullOrEmpty(strid_ExportExcel4Users) == true) return false;
if (strid_ExportExcel4Users.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_id_ExportExcel4Users_ExportExcelSet]类型的对象</returns>
public static implicit operator K_id_ExportExcel4Users_ExportExcelSet(string value)
{
return new K_id_ExportExcel4Users_ExportExcelSet(value);
}
}
 /// <summary>
 /// 导出Excel设置(ExportExcelSet)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsExportExcelSetEN : clsEntityBase2
{
public const string _CurrTabName_S = "ExportExcelSet"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "id_ExportExcel4Users"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 9;
public static string[] AttributeName = new string[] {"id_ExportExcel4Users", "ViewName", "TabName", "UserId", "IsDefaultUser", "ExportFileName", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量

protected string mstrid_ExportExcel4Users;    //导出Excel用户字段流水号
protected string mstrViewName;    //界面名称
protected string mstrTabName;    //TabName
protected string mstrUserId;    //用户ID
protected bool mbolIsDefaultUser;    //是否缺省用户
protected string mstrExportFileName;    //导出文件名
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注


 /// <summary>
 /// 常量:"id_ExportExcel4Users"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_id_ExportExcel4Users = "id_ExportExcel4Users";    //导出Excel用户字段流水号

 /// <summary>
 /// 常量:"ViewName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ViewName = "ViewName";    //界面名称

 /// <summary>
 /// 常量:"TabName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_TabName = "TabName";    //TabName

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"IsDefaultUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_IsDefaultUser = "IsDefaultUser";    //是否缺省用户

 /// <summary>
 /// 常量:"ExportFileName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ExportFileName = "ExportFileName";    //导出文件名

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsExportExcelSetEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ExportExcelSet";
 lstKeyFldNames.Add("id_ExportExcel4Users");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strid_ExportExcel4Users">关键字:导出Excel用户字段流水号</param>
public clsExportExcelSetEN(string strid_ExportExcel4Users)
 {
strid_ExportExcel4Users = strid_ExportExcel4Users.Replace("'", "''");
if (strid_ExportExcel4Users.Length > 8)
{
throw new Exception("在表:ExportExcelSet中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strid_ExportExcel4Users)  ==  true)
{
throw new Exception("在表:ExportExcelSet中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strid_ExportExcel4Users);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrid_ExportExcel4Users = strid_ExportExcel4Users;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ExportExcelSet";
 lstKeyFldNames.Add("id_ExportExcel4Users");
 }

public static int AttributeCount
{
get
{
return mintAttributeCount;
}
}
public override object this[string strAttributeName]
{
get
{
if (strAttributeName  ==  con_id_ExportExcel4Users)
{
return mstrid_ExportExcel4Users;
}
else if (strAttributeName  ==  con_ViewName)
{
return mstrViewName;
}
else if (strAttributeName  ==  con_TabName)
{
return mstrTabName;
}
else if (strAttributeName  ==  con_UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  con_IsDefaultUser)
{
return mbolIsDefaultUser;
}
else if (strAttributeName  ==  con_ExportFileName)
{
return mstrExportFileName;
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
if (strAttributeName  ==  con_id_ExportExcel4Users)
{
mstrid_ExportExcel4Users = value.ToString();
 AddUpdatedFld(con_id_ExportExcel4Users);
}
else if (strAttributeName  ==  con_ViewName)
{
mstrViewName = value.ToString();
 AddUpdatedFld(con_ViewName);
}
else if (strAttributeName  ==  con_TabName)
{
mstrTabName = value.ToString();
 AddUpdatedFld(con_TabName);
}
else if (strAttributeName  ==  con_UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (strAttributeName  ==  con_IsDefaultUser)
{
mbolIsDefaultUser = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsDefaultUser);
}
else if (strAttributeName  ==  con_ExportFileName)
{
mstrExportFileName = value.ToString();
 AddUpdatedFld(con_ExportFileName);
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
if (con_id_ExportExcel4Users  ==  AttributeName[intIndex])
{
return mstrid_ExportExcel4Users;
}
else if (con_ViewName  ==  AttributeName[intIndex])
{
return mstrViewName;
}
else if (con_TabName  ==  AttributeName[intIndex])
{
return mstrTabName;
}
else if (con_UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (con_IsDefaultUser  ==  AttributeName[intIndex])
{
return mbolIsDefaultUser;
}
else if (con_ExportFileName  ==  AttributeName[intIndex])
{
return mstrExportFileName;
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
if (con_id_ExportExcel4Users  ==  AttributeName[intIndex])
{
mstrid_ExportExcel4Users = value.ToString();
 AddUpdatedFld(con_id_ExportExcel4Users);
}
else if (con_ViewName  ==  AttributeName[intIndex])
{
mstrViewName = value.ToString();
 AddUpdatedFld(con_ViewName);
}
else if (con_TabName  ==  AttributeName[intIndex])
{
mstrTabName = value.ToString();
 AddUpdatedFld(con_TabName);
}
else if (con_UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
else if (con_IsDefaultUser  ==  AttributeName[intIndex])
{
mbolIsDefaultUser = TransNullToBool(value.ToString());
 AddUpdatedFld(con_IsDefaultUser);
}
else if (con_ExportFileName  ==  AttributeName[intIndex])
{
mstrExportFileName = value.ToString();
 AddUpdatedFld(con_ExportFileName);
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
/// 导出Excel用户字段流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
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
/// 界面名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ViewName
{
get
{
return mstrViewName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrViewName = value;
}
else
{
 mstrViewName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ViewName);
}
}
/// <summary>
/// TabName(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabName
{
get
{
return mstrTabName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabName = value;
}
else
{
 mstrTabName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_TabName);
}
}
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserId
{
get
{
return mstrUserId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserId = value;
}
else
{
 mstrUserId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_UserId);
}
}
/// <summary>
/// 是否缺省用户(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDefaultUser
{
get
{
return mbolIsDefaultUser;
}
set
{
 mbolIsDefaultUser = value;
//记录修改过的字段
 AddUpdatedFld(con_IsDefaultUser);
}
}
/// <summary>
/// 导出文件名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ExportFileName
{
get
{
return mstrExportFileName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrExportFileName = value;
}
else
{
 mstrExportFileName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ExportFileName);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
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
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
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
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
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

/// <summary>
/// 获取关键字Id(KeyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrid_ExportExcel4Users;
 }
 }
}
}