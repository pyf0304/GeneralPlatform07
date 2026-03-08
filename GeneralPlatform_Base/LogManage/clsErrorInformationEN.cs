
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsErrorInformationEN
 表名:ErrorInformation(00140050)
 生成代码版本:2019.07.11.1
 生成日期:2019/07/12 10:00:49
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日志管理
 模块英文名:LogManage
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
 /// 表ErrorInformation的关键字(ErrorID)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public struct K_ErrorID_ErrorInformation
{
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get; }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngErrorID">表关键字</param>
public K_ErrorID_ErrorInformation(long lngErrorID)
{
if (IsValid(lngErrorID)) Value = lngErrorID;
else
{
Value = 0;
}
}
private static bool IsValid(long lngErrorID)
{
if (lngErrorID == 0) return false;
if (lngErrorID == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换，把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_ErrorID_ErrorInformation]类型的对象</returns>
public static implicit operator K_ErrorID_ErrorInformation(long value)
{
return new K_ErrorID_ErrorInformation(value);
}
}
 /// <summary>
 /// 错误(ErrorInformation)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsErrorInformationEN : clsEntityBase2
{
public const string _CurrTabName_S = "ErrorInformation"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "ErrorID"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 6;
public static string[] AttributeName = new string[] {"ErrorID", "PageName", "FunctionName", "ErrorInformation", "CreateTime", "UserId"};
//以下是属性变量

protected long mlngErrorID;    //ErrorID
protected string mstrPageName;    //PageName
protected string mstrFunctionName;    //FunctionName
protected string mstrErrorInformation;    //ErrorInformation
protected DateTime mdteCreateTime;    //CreateTime
protected string mstrUserId;    //用户ID


 /// <summary>
 /// 常量:"ErrorID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ErrorID = "ErrorID";    //ErrorID

 /// <summary>
 /// 常量:"PageName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_PageName = "PageName";    //PageName

 /// <summary>
 /// 常量:"FunctionName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_FunctionName = "FunctionName";    //FunctionName

 /// <summary>
 /// 常量:"ErrorInformation"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_ErrorInformation = "ErrorInformation";    //ErrorInformation

 /// <summary>
 /// 常量:"CreateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_CreateTime = "CreateTime";    //CreateTime

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public const string con_UserId = "UserId";    //用户ID

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsErrorInformationEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ErrorInformation";
 lstKeyFldNames.Add("ErrorID");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngErrorID">关键字:ErrorID</param>
public clsErrorInformationEN(long lngErrorID)
 {
 if (lngErrorID  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngErrorID = lngErrorID;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ErrorInformation";
 lstKeyFldNames.Add("ErrorID");
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
if (strAttributeName  ==  con_ErrorID)
{
return mlngErrorID;
}
else if (strAttributeName  ==  con_PageName)
{
return mstrPageName;
}
else if (strAttributeName  ==  con_FunctionName)
{
return mstrFunctionName;
}
else if (strAttributeName  ==  con_ErrorInformation)
{
return mstrErrorInformation;
}
else if (strAttributeName  ==  con_CreateTime)
{
return mdteCreateTime;
}
else if (strAttributeName  ==  con_UserId)
{
return mstrUserId;
}
return null;
}
set
{
if (strAttributeName  ==  con_ErrorID)
{
mlngErrorID = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ErrorID);
}
else if (strAttributeName  ==  con_PageName)
{
mstrPageName = value.ToString();
 AddUpdatedFld(con_PageName);
}
else if (strAttributeName  ==  con_FunctionName)
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(con_FunctionName);
}
else if (strAttributeName  ==  con_ErrorInformation)
{
mstrErrorInformation = value.ToString();
 AddUpdatedFld(con_ErrorInformation);
}
else if (strAttributeName  ==  con_CreateTime)
{
mdteCreateTime = TransNullToDate(value.ToString());
 AddUpdatedFld(con_CreateTime);
}
else if (strAttributeName  ==  con_UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
}
}
public object this[int intIndex]
{
get
{
if (con_ErrorID  ==  AttributeName[intIndex])
{
return mlngErrorID;
}
else if (con_PageName  ==  AttributeName[intIndex])
{
return mstrPageName;
}
else if (con_FunctionName  ==  AttributeName[intIndex])
{
return mstrFunctionName;
}
else if (con_ErrorInformation  ==  AttributeName[intIndex])
{
return mstrErrorInformation;
}
else if (con_CreateTime  ==  AttributeName[intIndex])
{
return mdteCreateTime;
}
else if (con_UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
return null;
}
set
{
if (con_ErrorID  ==  AttributeName[intIndex])
{
mlngErrorID = TransNullToInt(value.ToString());
 AddUpdatedFld(con_ErrorID);
}
else if (con_PageName  ==  AttributeName[intIndex])
{
mstrPageName = value.ToString();
 AddUpdatedFld(con_PageName);
}
else if (con_FunctionName  ==  AttributeName[intIndex])
{
mstrFunctionName = value.ToString();
 AddUpdatedFld(con_FunctionName);
}
else if (con_ErrorInformation  ==  AttributeName[intIndex])
{
mstrErrorInformation = value.ToString();
 AddUpdatedFld(con_ErrorInformation);
}
else if (con_CreateTime  ==  AttributeName[intIndex])
{
mdteCreateTime = TransNullToDate(value.ToString());
 AddUpdatedFld(con_CreateTime);
}
else if (con_UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(con_UserId);
}
}
}

/// <summary>
/// ErrorID(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public long ErrorID
{
get
{
return mlngErrorID;
}
set
{
 mlngErrorID = value;
//记录修改过的字段
 AddUpdatedFld(con_ErrorID);
}
}
/// <summary>
/// PageName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PageName
{
get
{
return mstrPageName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPageName = value;
}
else
{
 mstrPageName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_PageName);
}
}
/// <summary>
/// FunctionName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string FunctionName
{
get
{
return mstrFunctionName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrFunctionName = value;
}
else
{
 mstrFunctionName = value;
}
//记录修改过的字段
 AddUpdatedFld(con_FunctionName);
}
}
/// <summary>
/// ErrorInformation(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ErrorInformation
{
get
{
return mstrErrorInformation;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrErrorInformation = value;
}
else
{
 mstrErrorInformation = value;
}
//记录修改过的字段
 AddUpdatedFld(con_ErrorInformation);
}
}
/// <summary>
/// CreateTime(说明:;字段类型:datetime;字段长度:16;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public DateTime CreateTime
{
get
{
return mdteCreateTime;
}
set
{
 mdteCreateTime = value;
//记录修改过的字段
 AddUpdatedFld(con_CreateTime);
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
/// 获取关键字Id(KeyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mlngErrorID.ToString();
 }
 }
}
}