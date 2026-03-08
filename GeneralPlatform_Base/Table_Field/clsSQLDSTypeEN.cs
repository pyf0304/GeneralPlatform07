
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSQLDSTypeEN
 表名:SQLDSType(00140100)
 生成代码版本:2019.08.02.1
 生成日期:2019/08/05 00:43:04
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433GeneralPlatformTz
 PrjDataBaseId:0184
 模块中文名:字段、表维护
 模块英文名:Table_Field
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
 /// 表SQLDSType的关键字(SQLDSTypeId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_SQLDSTypeId_SQLDSType
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strSQLDSTypeId">表关键字</param>
public K_SQLDSTypeId_SQLDSType(string strSQLDSTypeId)
{
if (IsValid(strSQLDSTypeId)) Value = strSQLDSTypeId;
else
{
Value = null;
}
}
private static bool IsValid(string strSQLDSTypeId)
{
if (string.IsNullOrEmpty(strSQLDSTypeId) == true) return false;
if (strSQLDSTypeId.Length != 2) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_SQLDSTypeId_SQLDSType]类型的对象</returns>
public static implicit operator K_SQLDSTypeId_SQLDSType(string value)
{
return new K_SQLDSTypeId_SQLDSType(value);
}
}
 /// <summary>
 /// Sql数据源类型(SQLDSType)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsSQLDSTypeEN : clsEntityBase2
{
public const string _CurrTabName_S = "SQLDSType"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "SQLDSTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 4;
public static string[] AttributeName = new string[] {"SQLDSTypeId", "SqlDsTypeName", "SqlDsTypeENName", "Memo"};
//以下是属性变量

protected string mstrSQLDSTypeId;    //数据源类型
protected string mstrSqlDsTypeName;    //Sql数据源名
protected string mstrSqlDsTypeENName;    //Sql数据源英文名
protected string mstrMemo;    //备注


 /// <summary>
 /// 常量:"SQLDSTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SQLDSTypeId = "SQLDSTypeId";    //数据源类型

 /// <summary>
 /// 常量:"SqlDsTypeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SqlDsTypeName = "SqlDsTypeName";    //Sql数据源名

 /// <summary>
 /// 常量:"SqlDsTypeENName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_SqlDsTypeENName = "SqlDsTypeENName";    //Sql数据源英文名

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_Memo = "Memo";    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsSQLDSTypeEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "SQLDSType";
 lstKeyFldNames.Add("SQLDSTypeId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strSQLDSTypeId">关键字:数据源类型</param>
public clsSQLDSTypeEN(string strSQLDSTypeId)
 {
strSQLDSTypeId = strSQLDSTypeId.Replace("'", "''");
if (strSQLDSTypeId.Length > 2)
{
throw new Exception("在表:SQLDSType中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strSQLDSTypeId)  ==  true)
{
throw new Exception("在表:SQLDSType中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSQLDSTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrSQLDSTypeId = strSQLDSTypeId;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "SQLDSType";
 lstKeyFldNames.Add("SQLDSTypeId");
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
if (strAttributeName  ==  con_SQLDSTypeId)
{
return mstrSQLDSTypeId;
}
else if (strAttributeName  ==  con_SqlDsTypeName)
{
return mstrSqlDsTypeName;
}
else if (strAttributeName  ==  con_SqlDsTypeENName)
{
return mstrSqlDsTypeENName;
}
else if (strAttributeName  ==  con_Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  con_SQLDSTypeId)
{
mstrSQLDSTypeId = value.ToString();
 AddUpdatedFld(con_SQLDSTypeId);
}
else if (strAttributeName  ==  con_SqlDsTypeName)
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(con_SqlDsTypeName);
}
else if (strAttributeName  ==  con_SqlDsTypeENName)
{
mstrSqlDsTypeENName = value.ToString();
 AddUpdatedFld(con_SqlDsTypeENName);
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
if (con_SQLDSTypeId  ==  AttributeName[intIndex])
{
return mstrSQLDSTypeId;
}
else if (con_SqlDsTypeName  ==  AttributeName[intIndex])
{
return mstrSqlDsTypeName;
}
else if (con_SqlDsTypeENName  ==  AttributeName[intIndex])
{
return mstrSqlDsTypeENName;
}
else if (con_Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (con_SQLDSTypeId  ==  AttributeName[intIndex])
{
mstrSQLDSTypeId = value.ToString();
 AddUpdatedFld(con_SQLDSTypeId);
}
else if (con_SqlDsTypeName  ==  AttributeName[intIndex])
{
mstrSqlDsTypeName = value.ToString();
 AddUpdatedFld(con_SqlDsTypeName);
}
else if (con_SqlDsTypeENName  ==  AttributeName[intIndex])
{
mstrSqlDsTypeENName = value.ToString();
 AddUpdatedFld(con_SqlDsTypeENName);
}
else if (con_Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(con_Memo);
}
}
}

/// <summary>
/// 数据源类型(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SQLDSTypeId
{
get
{
return mstrSQLDSTypeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSQLDSTypeId = value;
}
else
{
 mstrSQLDSTypeId = value;
}
//记录修改过的字段
 AddUpdatedFld(con_SQLDSTypeId);
}
}
/// <summary>
/// Sql数据源名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlDsTypeName
{
get
{
return mstrSqlDsTypeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlDsTypeName = value;
}
else
{
 mstrSqlDsTypeName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_SqlDsTypeName);
}
}
/// <summary>
/// Sql数据源英文名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string SqlDsTypeENName
{
get
{
return mstrSqlDsTypeENName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrSqlDsTypeENName = value;
}
else
{
 mstrSqlDsTypeENName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_SqlDsTypeENName);
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
  return mstrSQLDSTypeId;
 }
 }

/// <summary>
/// 获取名称字段值(NameValue)
 /// (AutoGCLib.clsGeneCodeBase:GenGetNameValue)
/// </summary>
 public override string _NameValue
 {
 get
 {
  return mstrSqlDsTypeName;
 }
 }
}
}