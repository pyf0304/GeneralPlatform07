
//----------------------
//生成代码版本:2016.05.09.1
//生成日期:2016/05/11
//生成者:潘以锋
//工程名称:统一平台
//工程ID:0014
//模块中文名:界面管理
//模块英文名:InterfaceMan
//注意:1、需要数据底层(PubDataBase.dll)的版本:2016.05.10.01
//       2、需要公共函数层(TzPubFunction.dll)的版本:2016.05.10.01
//========================
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
/// 界面类型码(ViewTypeCodeTab)
/// </summary>
[Serializable]
public class clsViewTypeCodeTabEN : clsEntityBase2
{
public const string CurrTabName_S = "ViewTypeCodeTab"; //当前表名,与该类相关的表名
public const string CurrTabKeyFldName_S = "ViewTypeCode"; //当前表中的关键字名称,与该类相关的表中关键字名
protected const int mintAttributeCount = 5;
public static string[] AttributeName = new string[] {"ViewTypeCode", "ViewTypeName", "ViewFunction", "OptProcess", "ViewDetail"};
 //以下是属性变量

protected string mstrViewTypeCode;    //界面类型码
protected string mstrViewTypeName;    //界面类型名
protected string mstrViewFunction;    //界面功能
protected string mstrOptProcess;    //操作过程
protected string mstrViewDetail;    //界面详细信息
protected int mintIntTag;    //整型Tag
protected string mstrStrTag;    //字符型标签
protected bool mbolIsCheckProperty;    //是否检查属性


  /// <summary>
   /// 常量:"ViewTypeCode"
/// </summary>
 public const string con_QxViewTypeCode = "ViewTypeCode";    //界面类型码

  /// <summary>
   /// 常量:"ViewTypeName"
/// </summary>
 public const string con_QxViewTypeName = "ViewTypeName";    //界面类型名

  /// <summary>
   /// 常量:"ViewFunction"
/// </summary>
 public const string con_QxViewFunction = "ViewFunction";    //界面功能

  /// <summary>
   /// 常量:"OptProcess"
/// </summary>
 public const string con_OptProcess = "OptProcess";    //操作过程

  /// <summary>
   /// 常量:"ViewDetail"
/// </summary>
 public const string con_QxViewDetail = "ViewDetail";    //界面详细信息

  /// <summary>
   /// 常量:"IntTag"
/// </summary>
 public const string con_IntTag = "IntTag";    //整型Tag

  /// <summary>
   /// 常量:"StrTag"
/// </summary>
 public const string con_StrTag = "StrTag";    //字符型标签

  /// <summary>
   /// 常量:"IsCheckProperty"
/// </summary>
 public const string con_IsCheckProperty = "IsCheckProperty";    //是否检查属性

//用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
private static string m_strConnectString;
/// <summary>
/// 当前所使用的连接串内容
/// </summary>
public static string ConnectString
{
get { return m_strConnectString; }
set { m_strConnectString = value; }
}

 public clsViewTypeCodeTabEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ViewTypeCodeTab";
 lstKeyFldNames.Add("ViewTypeCode");
 }

public clsViewTypeCodeTabEN(string strViewTypeCode)
 {
strViewTypeCode = strViewTypeCode.Replace("'", "''");
if (strViewTypeCode.Length > 4)
{
throw new Exception("在表:ViewTypeCodeTab中,关键字长度不正确!");
}
 if (string.IsNullOrEmpty(strViewTypeCode) == true)
{
throw new Exception("在表:ViewTypeCodeTab中,关键字不能为空 或 null!");
}
try
{
clsCommonRegular.CheckStrSQL_Weak(strViewTypeCode);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

mstrViewTypeCode=strViewTypeCode;
 SetInit();
 mbolIsCheckProperty = false;
 _CurrTabName = "ViewTypeCodeTab";
 lstKeyFldNames.Add("ViewTypeCode");
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
if (strAttributeName == con_QxViewTypeCode)
{
return mstrViewTypeCode;
}
else if (strAttributeName == con_QxViewTypeName)
{
return mstrViewTypeName;
}
else if (strAttributeName == con_QxViewFunction)
{
return mstrViewFunction;
}
else if (strAttributeName == con_OptProcess)
{
return mstrOptProcess;
}
else if (strAttributeName == con_QxViewDetail)
{
return mstrViewDetail;
}
return null;
}
set
{
if (strAttributeName == con_QxViewTypeCode)
{
mstrViewTypeCode = value.ToString();
 AddUpdatedFld(con_QxViewTypeCode);
}
else if (strAttributeName == con_QxViewTypeName)
{
mstrViewTypeName = value.ToString();
 AddUpdatedFld(con_QxViewTypeName);
}
else if (strAttributeName == con_QxViewFunction)
{
mstrViewFunction = value.ToString();
 AddUpdatedFld(con_QxViewFunction);
}
else if (strAttributeName == con_OptProcess)
{
mstrOptProcess = value.ToString();
 AddUpdatedFld(con_OptProcess);
}
else if (strAttributeName == con_QxViewDetail)
{
mstrViewDetail = value.ToString();
 AddUpdatedFld(con_QxViewDetail);
}
}
}
public object this[int intIndex]
{
get
{
if (con_QxViewTypeCode == AttributeName[intIndex])
{
return mstrViewTypeCode;
}
else if (con_QxViewTypeName == AttributeName[intIndex])
{
return mstrViewTypeName;
}
else if (con_QxViewFunction == AttributeName[intIndex])
{
return mstrViewFunction;
}
else if (con_OptProcess == AttributeName[intIndex])
{
return mstrOptProcess;
}
else if (con_QxViewDetail == AttributeName[intIndex])
{
return mstrViewDetail;
}
return null;
}
set
{
if (con_QxViewTypeCode == AttributeName[intIndex])
{
mstrViewTypeCode = value.ToString();
 AddUpdatedFld(con_QxViewTypeCode);
}
else if (con_QxViewTypeName == AttributeName[intIndex])
{
mstrViewTypeName = value.ToString();
 AddUpdatedFld(con_QxViewTypeName);
}
else if (con_QxViewFunction == AttributeName[intIndex])
{
mstrViewFunction = value.ToString();
 AddUpdatedFld(con_QxViewFunction);
}
else if (con_OptProcess == AttributeName[intIndex])
{
mstrOptProcess = value.ToString();
 AddUpdatedFld(con_OptProcess);
}
else if (con_QxViewDetail == AttributeName[intIndex])
{
mstrViewDetail = value.ToString();
 AddUpdatedFld(con_QxViewDetail);
}
}
}

/// <summary>
/// 界面类型码(说明:;字段类型:char;字段长度:4;是否可空:False)
/// </summary>
public string ViewTypeCode
{
get
{
return mstrViewTypeCode;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrViewTypeCode = value;
}
else
{
mstrViewTypeCode = value;
}
//记录修改过的字段
AddUpdatedFld(con_QxViewTypeCode);
}
}
/// <summary>
/// 界面类型名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
/// </summary>
public string ViewTypeName
{
get
{
return mstrViewTypeName;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrViewTypeName = value;
}
else
{
mstrViewTypeName = value;
}
//记录修改过的字段
AddUpdatedFld(con_QxViewTypeName);
}
}
/// <summary>
/// 界面功能(说明:;字段类型:varchar;字段长度:100;是否可空:True)
/// </summary>
public string ViewFunction
{
get
{
return mstrViewFunction;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrViewFunction = value;
}
else
{
mstrViewFunction = value;
}
//记录修改过的字段
AddUpdatedFld(con_QxViewFunction);
}
}
/// <summary>
/// 操作过程(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
/// </summary>
public string OptProcess
{
get
{
return mstrOptProcess;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrOptProcess = value;
}
else
{
mstrOptProcess = value;
}
//记录修改过的字段
AddUpdatedFld(con_OptProcess);
}
}
/// <summary>
/// 界面详细信息(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
/// </summary>
public string ViewDetail
{
get
{
return mstrViewDetail;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrViewDetail = value;
}
else
{
mstrViewDetail = value;
}
//记录修改过的字段
AddUpdatedFld(con_QxViewDetail);
}
}
/// <summary>
/// 整型Tag(说明:;字段类型:int;字段长度:4;是否可空:False)
/// </summary>
public int IntTag
{
get
{
return mintIntTag;
}
set
{
mintIntTag = value;
//记录修改过的字段
AddUpdatedFld(con_IntTag);
}
}
/// <summary>
/// 字符型标签(说明:;字段类型:string;字段长度:1000;是否可空:False)
/// </summary>
public string StrTag
{
get
{
return mstrStrTag;
}
set
{
if (value == "")
{
mintErrNo = 1;
mstrStrTag = value;
}
else
{
mstrStrTag = value;
}
//记录修改过的字段
AddUpdatedFld(con_StrTag);
}
}
/// <summary>
/// 是否检查属性(说明:;字段类型:bool;字段长度:1;是否可空:False)
/// </summary>
public bool IsCheckProperty
{
get
{
return mbolIsCheckProperty;
}
set
{
mbolIsCheckProperty = value;
//记录修改过的字段
AddUpdatedFld(con_IsCheckProperty);
}
}
}
}