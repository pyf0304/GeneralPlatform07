
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenus_UpEN
 表名:vQxPrjMenus_Up(00140080)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:34:09
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:菜单管理(MenuManage_GP)
 框架-层名:实体层(CS)(EntityLayer)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 

using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System.Runtime.Serialization;

namespace GeneralPlatform.Entity
{
 /// <summary>
 /// 表vQxPrjMenus_Up的关键字(MenuIdUp)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_MenuIdUp_vQxPrjMenus_Up
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strMenuIdUp">表关键字</param>
public K_MenuIdUp_vQxPrjMenus_Up(string strMenuIdUp)
{
if (IsValid(strMenuIdUp)) Value = strMenuIdUp;
else
{
Value = null;
}
}
private static bool IsValid(string strMenuIdUp)
{
if (string.IsNullOrEmpty(strMenuIdUp) == true) return false;
if (strMenuIdUp.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_MenuIdUp_vQxPrjMenus_Up]类型的对象</returns>
public static implicit operator K_MenuIdUp_vQxPrjMenus_Up(string value)
{
return new K_MenuIdUp_vQxPrjMenus_Up(value);
}
}
 /// <summary>
 /// v顶层菜单(vQxPrjMenus_Up)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxPrjMenus_UpEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxPrjMenus_Up"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "MenuIdUp"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"MenuIdUp", "MenuName", "QxPrjId", "PrjName", "UpMenuId", "LinkFile", "qsParameters", "ImgFile", "OrderNum", "IsLeafNode", "MenuSetId", "MenuSetName", "MenuTitle", "PageDispModeId", "PageDispModeName", "InUse", "UpdDate", "UpdUserId", "Memo", "MenuControlName"};

protected string mstrMenuIdUp;    //MenuId_Up
protected string mstrMenuName;    //菜单名
protected string mstrQxPrjId;    //项目Id
protected string mstrPrjName;    //工程名
protected string mstrUpMenuId;    //上级菜单Id
protected string mstrLinkFile;    //链接文件
protected string mstrqsParameters;    //qs参数
protected string mstrImgFile;    //图像文件
protected int? mintOrderNum;    //排序号
protected bool mbolIsLeafNode;    //是否叶子
protected string mstrMenuSetId;    //菜单集Id
protected string mstrMenuSetName;    //菜单集名称
protected string mstrMenuTitle;    //菜单标题
protected string mstrPageDispModeId;    //页面显示模式Id
protected string mstrPageDispModeName;    //页面显示模式名称
protected bool mbolInUse;    //是否在用
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected string mstrMenuControlName;    //MenuControlName

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxPrjMenus_UpEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MenuIdUp");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strMenuIdUp">关键字:MenuId_Up</param>
public clsvQxPrjMenus_UpEN(string strMenuIdUp)
 {
strMenuIdUp = strMenuIdUp.Replace("'", "''");
if (strMenuIdUp.Length > 8)
{
throw new Exception("在表:vQxPrjMenus_Up中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strMenuIdUp)  ==  true)
{
throw new Exception("在表:vQxPrjMenus_Up中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMenuIdUp);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrMenuIdUp = strMenuIdUp;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MenuIdUp");
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
if (strAttributeName  ==  convQxPrjMenus_Up.MenuIdUp)
{
return mstrMenuIdUp;
}
else if (strAttributeName  ==  convQxPrjMenus_Up.MenuName)
{
return mstrMenuName;
}
else if (strAttributeName  ==  convQxPrjMenus_Up.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  convQxPrjMenus_Up.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convQxPrjMenus_Up.UpMenuId)
{
return mstrUpMenuId;
}
else if (strAttributeName  ==  convQxPrjMenus_Up.LinkFile)
{
return mstrLinkFile;
}
else if (strAttributeName  ==  convQxPrjMenus_Up.qsParameters)
{
return mstrqsParameters;
}
else if (strAttributeName  ==  convQxPrjMenus_Up.ImgFile)
{
return mstrImgFile;
}
else if (strAttributeName  ==  convQxPrjMenus_Up.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convQxPrjMenus_Up.IsLeafNode)
{
return mbolIsLeafNode;
}
else if (strAttributeName  ==  convQxPrjMenus_Up.MenuSetId)
{
return mstrMenuSetId;
}
else if (strAttributeName  ==  convQxPrjMenus_Up.MenuSetName)
{
return mstrMenuSetName;
}
else if (strAttributeName  ==  convQxPrjMenus_Up.MenuTitle)
{
return mstrMenuTitle;
}
else if (strAttributeName  ==  convQxPrjMenus_Up.PageDispModeId)
{
return mstrPageDispModeId;
}
else if (strAttributeName  ==  convQxPrjMenus_Up.PageDispModeName)
{
return mstrPageDispModeName;
}
else if (strAttributeName  ==  convQxPrjMenus_Up.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convQxPrjMenus_Up.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQxPrjMenus_Up.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convQxPrjMenus_Up.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convQxPrjMenus_Up.MenuControlName)
{
return mstrMenuControlName;
}
return null;
}
set
{
if (strAttributeName  ==  convQxPrjMenus_Up.MenuIdUp)
{
mstrMenuIdUp = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.MenuIdUp);
}
else if (strAttributeName  ==  convQxPrjMenus_Up.MenuName)
{
mstrMenuName = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.MenuName);
}
else if (strAttributeName  ==  convQxPrjMenus_Up.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.QxPrjId);
}
else if (strAttributeName  ==  convQxPrjMenus_Up.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.PrjName);
}
else if (strAttributeName  ==  convQxPrjMenus_Up.UpMenuId)
{
mstrUpMenuId = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.UpMenuId);
}
else if (strAttributeName  ==  convQxPrjMenus_Up.LinkFile)
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.LinkFile);
}
else if (strAttributeName  ==  convQxPrjMenus_Up.qsParameters)
{
mstrqsParameters = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.qsParameters);
}
else if (strAttributeName  ==  convQxPrjMenus_Up.ImgFile)
{
mstrImgFile = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.ImgFile);
}
else if (strAttributeName  ==  convQxPrjMenus_Up.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPrjMenus_Up.OrderNum);
}
else if (strAttributeName  ==  convQxPrjMenus_Up.IsLeafNode)
{
mbolIsLeafNode = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjMenus_Up.IsLeafNode);
}
else if (strAttributeName  ==  convQxPrjMenus_Up.MenuSetId)
{
mstrMenuSetId = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.MenuSetId);
}
else if (strAttributeName  ==  convQxPrjMenus_Up.MenuSetName)
{
mstrMenuSetName = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.MenuSetName);
}
else if (strAttributeName  ==  convQxPrjMenus_Up.MenuTitle)
{
mstrMenuTitle = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.MenuTitle);
}
else if (strAttributeName  ==  convQxPrjMenus_Up.PageDispModeId)
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.PageDispModeId);
}
else if (strAttributeName  ==  convQxPrjMenus_Up.PageDispModeName)
{
mstrPageDispModeName = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.PageDispModeName);
}
else if (strAttributeName  ==  convQxPrjMenus_Up.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjMenus_Up.InUse);
}
else if (strAttributeName  ==  convQxPrjMenus_Up.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.UpdDate);
}
else if (strAttributeName  ==  convQxPrjMenus_Up.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.UpdUserId);
}
else if (strAttributeName  ==  convQxPrjMenus_Up.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.Memo);
}
else if (strAttributeName  ==  convQxPrjMenus_Up.MenuControlName)
{
mstrMenuControlName = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.MenuControlName);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxPrjMenus_Up.MenuIdUp  ==  AttributeName[intIndex])
{
return mstrMenuIdUp;
}
else if (convQxPrjMenus_Up.MenuName  ==  AttributeName[intIndex])
{
return mstrMenuName;
}
else if (convQxPrjMenus_Up.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (convQxPrjMenus_Up.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convQxPrjMenus_Up.UpMenuId  ==  AttributeName[intIndex])
{
return mstrUpMenuId;
}
else if (convQxPrjMenus_Up.LinkFile  ==  AttributeName[intIndex])
{
return mstrLinkFile;
}
else if (convQxPrjMenus_Up.qsParameters  ==  AttributeName[intIndex])
{
return mstrqsParameters;
}
else if (convQxPrjMenus_Up.ImgFile  ==  AttributeName[intIndex])
{
return mstrImgFile;
}
else if (convQxPrjMenus_Up.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convQxPrjMenus_Up.IsLeafNode  ==  AttributeName[intIndex])
{
return mbolIsLeafNode;
}
else if (convQxPrjMenus_Up.MenuSetId  ==  AttributeName[intIndex])
{
return mstrMenuSetId;
}
else if (convQxPrjMenus_Up.MenuSetName  ==  AttributeName[intIndex])
{
return mstrMenuSetName;
}
else if (convQxPrjMenus_Up.MenuTitle  ==  AttributeName[intIndex])
{
return mstrMenuTitle;
}
else if (convQxPrjMenus_Up.PageDispModeId  ==  AttributeName[intIndex])
{
return mstrPageDispModeId;
}
else if (convQxPrjMenus_Up.PageDispModeName  ==  AttributeName[intIndex])
{
return mstrPageDispModeName;
}
else if (convQxPrjMenus_Up.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (convQxPrjMenus_Up.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQxPrjMenus_Up.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convQxPrjMenus_Up.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convQxPrjMenus_Up.MenuControlName  ==  AttributeName[intIndex])
{
return mstrMenuControlName;
}
return null;
}
set
{
if (convQxPrjMenus_Up.MenuIdUp  ==  AttributeName[intIndex])
{
mstrMenuIdUp = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.MenuIdUp);
}
else if (convQxPrjMenus_Up.MenuName  ==  AttributeName[intIndex])
{
mstrMenuName = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.MenuName);
}
else if (convQxPrjMenus_Up.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.QxPrjId);
}
else if (convQxPrjMenus_Up.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.PrjName);
}
else if (convQxPrjMenus_Up.UpMenuId  ==  AttributeName[intIndex])
{
mstrUpMenuId = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.UpMenuId);
}
else if (convQxPrjMenus_Up.LinkFile  ==  AttributeName[intIndex])
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.LinkFile);
}
else if (convQxPrjMenus_Up.qsParameters  ==  AttributeName[intIndex])
{
mstrqsParameters = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.qsParameters);
}
else if (convQxPrjMenus_Up.ImgFile  ==  AttributeName[intIndex])
{
mstrImgFile = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.ImgFile);
}
else if (convQxPrjMenus_Up.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPrjMenus_Up.OrderNum);
}
else if (convQxPrjMenus_Up.IsLeafNode  ==  AttributeName[intIndex])
{
mbolIsLeafNode = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjMenus_Up.IsLeafNode);
}
else if (convQxPrjMenus_Up.MenuSetId  ==  AttributeName[intIndex])
{
mstrMenuSetId = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.MenuSetId);
}
else if (convQxPrjMenus_Up.MenuSetName  ==  AttributeName[intIndex])
{
mstrMenuSetName = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.MenuSetName);
}
else if (convQxPrjMenus_Up.MenuTitle  ==  AttributeName[intIndex])
{
mstrMenuTitle = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.MenuTitle);
}
else if (convQxPrjMenus_Up.PageDispModeId  ==  AttributeName[intIndex])
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.PageDispModeId);
}
else if (convQxPrjMenus_Up.PageDispModeName  ==  AttributeName[intIndex])
{
mstrPageDispModeName = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.PageDispModeName);
}
else if (convQxPrjMenus_Up.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjMenus_Up.InUse);
}
else if (convQxPrjMenus_Up.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.UpdDate);
}
else if (convQxPrjMenus_Up.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.UpdUserId);
}
else if (convQxPrjMenus_Up.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.Memo);
}
else if (convQxPrjMenus_Up.MenuControlName  ==  AttributeName[intIndex])
{
mstrMenuControlName = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Up.MenuControlName);
}
}
}

/// <summary>
/// MenuId_Up(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuIdUp
{
get
{
return mstrMenuIdUp;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuIdUp = value;
}
else
{
 mstrMenuIdUp = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus_Up.MenuIdUp);
}
}
/// <summary>
/// 菜单名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuName
{
get
{
return mstrMenuName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuName = value;
}
else
{
 mstrMenuName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus_Up.MenuName);
}
}
/// <summary>
/// 项目Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string QxPrjId
{
get
{
return mstrQxPrjId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrQxPrjId = value;
}
else
{
 mstrQxPrjId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus_Up.QxPrjId);
}
}
/// <summary>
/// 工程名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PrjName
{
get
{
return mstrPrjName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPrjName = value;
}
else
{
 mstrPrjName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus_Up.PrjName);
}
}
/// <summary>
/// 上级菜单Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpMenuId
{
get
{
return mstrUpMenuId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpMenuId = value;
}
else
{
 mstrUpMenuId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus_Up.UpMenuId);
}
}
/// <summary>
/// 链接文件(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string LinkFile
{
get
{
return mstrLinkFile;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrLinkFile = value;
}
else
{
 mstrLinkFile = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus_Up.LinkFile);
}
}
/// <summary>
/// qs参数(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string qsParameters
{
get
{
return mstrqsParameters;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrqsParameters = value;
}
else
{
 mstrqsParameters = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus_Up.qsParameters);
}
}
/// <summary>
/// 图像文件(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string ImgFile
{
get
{
return mstrImgFile;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrImgFile = value;
}
else
{
 mstrImgFile = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus_Up.ImgFile);
}
}
/// <summary>
/// 排序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? OrderNum
{
get
{
return mintOrderNum;
}
set
{
 mintOrderNum = value;
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus_Up.OrderNum);
}
}
/// <summary>
/// 是否叶子(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsLeafNode
{
get
{
return mbolIsLeafNode;
}
set
{
 mbolIsLeafNode = value;
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus_Up.IsLeafNode);
}
}
/// <summary>
/// 菜单集Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuSetId
{
get
{
return mstrMenuSetId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuSetId = value;
}
else
{
 mstrMenuSetId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus_Up.MenuSetId);
}
}
/// <summary>
/// 菜单集名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuSetName
{
get
{
return mstrMenuSetName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuSetName = value;
}
else
{
 mstrMenuSetName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus_Up.MenuSetName);
}
}
/// <summary>
/// 菜单标题(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuTitle
{
get
{
return mstrMenuTitle;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuTitle = value;
}
else
{
 mstrMenuTitle = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus_Up.MenuTitle);
}
}
/// <summary>
/// 页面显示模式Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PageDispModeId
{
get
{
return mstrPageDispModeId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPageDispModeId = value;
}
else
{
 mstrPageDispModeId = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus_Up.PageDispModeId);
}
}
/// <summary>
/// 页面显示模式名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string PageDispModeName
{
get
{
return mstrPageDispModeName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPageDispModeName = value;
}
else
{
 mstrPageDispModeName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus_Up.PageDispModeName);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool InUse
{
get
{
return mbolInUse;
}
set
{
 mbolInUse = value;
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus_Up.InUse);
}
}
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:False)
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
 AddUpdatedFld(convQxPrjMenus_Up.UpdDate);
}
}
/// <summary>
/// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:False)
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
 AddUpdatedFld(convQxPrjMenus_Up.UpdUserId);
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
 AddUpdatedFld(convQxPrjMenus_Up.Memo);
}
}
/// <summary>
/// MenuControlName(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuControlName
{
get
{
return mstrMenuControlName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuControlName = value;
}
else
{
 mstrMenuControlName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus_Up.MenuControlName);
}
}

/// <summary>
/// 获取关键字Id(keyId)
 /// (AutoGCLib.clsGeneCodeBase:GenGetKeyId)
/// </summary>
 public override string _KeyId
 {
 get
 {
  return mstrMenuIdUp;
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
  return mstrMenuName;
 }
 }
}
 /// <summary>
 /// v顶层菜单(vQxPrjMenus_Up)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxPrjMenus_Up
{
public const string _CurrTabName = "vQxPrjMenus_Up"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "MenuIdUp"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"MenuIdUp", "MenuName", "QxPrjId", "PrjName", "UpMenuId", "LinkFile", "qsParameters", "ImgFile", "OrderNum", "IsLeafNode", "MenuSetId", "MenuSetName", "MenuTitle", "PageDispModeId", "PageDispModeName", "InUse", "UpdDate", "UpdUserId", "Memo", "MenuControlName"};
//以下是属性变量


 /// <summary>
 /// 常量:"MenuIdUp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuIdUp = "MenuIdUp";    //MenuId_Up

 /// <summary>
 /// 常量:"MenuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuName = "MenuName";    //菜单名

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

 /// <summary>
 /// 常量:"PrjName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PrjName = "PrjName";    //工程名

 /// <summary>
 /// 常量:"UpMenuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpMenuId = "UpMenuId";    //上级菜单Id

 /// <summary>
 /// 常量:"LinkFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LinkFile = "LinkFile";    //链接文件

 /// <summary>
 /// 常量:"qsParameters"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string qsParameters = "qsParameters";    //qs参数

 /// <summary>
 /// 常量:"ImgFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImgFile = "ImgFile";    //图像文件

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //排序号

 /// <summary>
 /// 常量:"IsLeafNode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsLeafNode = "IsLeafNode";    //是否叶子

 /// <summary>
 /// 常量:"MenuSetId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuSetId = "MenuSetId";    //菜单集Id

 /// <summary>
 /// 常量:"MenuSetName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuSetName = "MenuSetName";    //菜单集名称

 /// <summary>
 /// 常量:"MenuTitle"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuTitle = "MenuTitle";    //菜单标题

 /// <summary>
 /// 常量:"PageDispModeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageDispModeId = "PageDispModeId";    //页面显示模式Id

 /// <summary>
 /// 常量:"PageDispModeName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string PageDispModeName = "PageDispModeName";    //页面显示模式名称

 /// <summary>
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"UpdUserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUserId = "UpdUserId";    //修改用户Id

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Memo = "Memo";    //备注

 /// <summary>
 /// 常量:"MenuControlName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuControlName = "MenuControlName";    //MenuControlName
}

}