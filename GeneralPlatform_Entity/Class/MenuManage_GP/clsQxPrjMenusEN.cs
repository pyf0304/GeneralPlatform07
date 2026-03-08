
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjMenusEN
 表名:QxPrjMenus(00140004)
 * 版本:2024.08.23.1(服务器:WIN-SRV103-116)
 日期:2024/08/29 09:31:50
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
 /// 表QxPrjMenus的关键字(MenuId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_MenuId_QxPrjMenus
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strMenuId">表关键字</param>
public K_MenuId_QxPrjMenus(string strMenuId)
{
if (IsValid(strMenuId)) Value = strMenuId;
else
{
Value = null;
}
}
private static bool IsValid(string strMenuId)
{
if (string.IsNullOrEmpty(strMenuId) == true) return false;
if (strMenuId.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_MenuId_QxPrjMenus]类型的对象</returns>
public static implicit operator K_MenuId_QxPrjMenus(string value)
{
return new K_MenuId_QxPrjMenus(value);
}
}
 /// <summary>
 /// 工程菜单(QxPrjMenus)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxPrjMenusEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxPrjMenus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "MenuId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 19;
public static string[] AttributeName = new string[] {"MenuId", "MenuName", "QxPrjId", "UpMenuId", "LinkFile", "qsParameters", "TabId", "ImgFile", "RoleId", "OrderNum", "IsLeafNode", "MenuTitle", "PageDispModeId", "InUse", "MenuControlName", "ApplicationTypeId", "UpdDate", "UpdUserId", "Memo"};

protected string mstrMenuId;    //菜单Id
protected string mstrMenuName;    //菜单名
protected string mstrQxPrjId;    //项目Id
protected string mstrUpMenuId;    //上级菜单Id
protected string mstrLinkFile;    //链接文件
protected string mstrqsParameters;    //qs参数
protected string mstrTabId;    //表ID
protected string mstrImgFile;    //图像文件
protected string mstrRoleId;    //角色Id
protected int mintOrderNum;    //排序号
protected bool mbolIsLeafNode;    //是否叶子
protected string mstrMenuTitle;    //菜单标题
protected string mstrPageDispModeId;    //页面显示模式Id
protected bool mbolInUse;    //是否在用
protected string mstrMenuControlName;    //菜单控件名
protected int mintApplicationTypeId;    //应用程序类型Id
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxPrjMenusEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MenuId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strMenuId">关键字:菜单Id</param>
public clsQxPrjMenusEN(string strMenuId)
 {
strMenuId = strMenuId.Replace("'", "''");
if (strMenuId.Length > 8)
{
throw new Exception("在表:QxPrjMenus中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strMenuId)  ==  true)
{
throw new Exception("在表:QxPrjMenus中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMenuId);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrMenuId = strMenuId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MenuId");
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
if (strAttributeName  ==  conQxPrjMenus.MenuId)
{
return mstrMenuId;
}
else if (strAttributeName  ==  conQxPrjMenus.MenuName)
{
return mstrMenuName;
}
else if (strAttributeName  ==  conQxPrjMenus.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxPrjMenus.UpMenuId)
{
return mstrUpMenuId;
}
else if (strAttributeName  ==  conQxPrjMenus.LinkFile)
{
return mstrLinkFile;
}
else if (strAttributeName  ==  conQxPrjMenus.qsParameters)
{
return mstrqsParameters;
}
else if (strAttributeName  ==  conQxPrjMenus.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conQxPrjMenus.ImgFile)
{
return mstrImgFile;
}
else if (strAttributeName  ==  conQxPrjMenus.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  conQxPrjMenus.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conQxPrjMenus.IsLeafNode)
{
return mbolIsLeafNode;
}
else if (strAttributeName  ==  conQxPrjMenus.MenuTitle)
{
return mstrMenuTitle;
}
else if (strAttributeName  ==  conQxPrjMenus.PageDispModeId)
{
return mstrPageDispModeId;
}
else if (strAttributeName  ==  conQxPrjMenus.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conQxPrjMenus.MenuControlName)
{
return mstrMenuControlName;
}
else if (strAttributeName  ==  conQxPrjMenus.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  conQxPrjMenus.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxPrjMenus.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conQxPrjMenus.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  conQxPrjMenus.MenuId)
{
mstrMenuId = value.ToString();
 AddUpdatedFld(conQxPrjMenus.MenuId);
}
else if (strAttributeName  ==  conQxPrjMenus.MenuName)
{
mstrMenuName = value.ToString();
 AddUpdatedFld(conQxPrjMenus.MenuName);
}
else if (strAttributeName  ==  conQxPrjMenus.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxPrjMenus.QxPrjId);
}
else if (strAttributeName  ==  conQxPrjMenus.UpMenuId)
{
mstrUpMenuId = value.ToString();
 AddUpdatedFld(conQxPrjMenus.UpMenuId);
}
else if (strAttributeName  ==  conQxPrjMenus.LinkFile)
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(conQxPrjMenus.LinkFile);
}
else if (strAttributeName  ==  conQxPrjMenus.qsParameters)
{
mstrqsParameters = value.ToString();
 AddUpdatedFld(conQxPrjMenus.qsParameters);
}
else if (strAttributeName  ==  conQxPrjMenus.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conQxPrjMenus.TabId);
}
else if (strAttributeName  ==  conQxPrjMenus.ImgFile)
{
mstrImgFile = value.ToString();
 AddUpdatedFld(conQxPrjMenus.ImgFile);
}
else if (strAttributeName  ==  conQxPrjMenus.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conQxPrjMenus.RoleId);
}
else if (strAttributeName  ==  conQxPrjMenus.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjMenus.OrderNum);
}
else if (strAttributeName  ==  conQxPrjMenus.IsLeafNode)
{
mbolIsLeafNode = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxPrjMenus.IsLeafNode);
}
else if (strAttributeName  ==  conQxPrjMenus.MenuTitle)
{
mstrMenuTitle = value.ToString();
 AddUpdatedFld(conQxPrjMenus.MenuTitle);
}
else if (strAttributeName  ==  conQxPrjMenus.PageDispModeId)
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(conQxPrjMenus.PageDispModeId);
}
else if (strAttributeName  ==  conQxPrjMenus.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxPrjMenus.InUse);
}
else if (strAttributeName  ==  conQxPrjMenus.MenuControlName)
{
mstrMenuControlName = value.ToString();
 AddUpdatedFld(conQxPrjMenus.MenuControlName);
}
else if (strAttributeName  ==  conQxPrjMenus.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjMenus.ApplicationTypeId);
}
else if (strAttributeName  ==  conQxPrjMenus.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxPrjMenus.UpdDate);
}
else if (strAttributeName  ==  conQxPrjMenus.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxPrjMenus.UpdUserId);
}
else if (strAttributeName  ==  conQxPrjMenus.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPrjMenus.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxPrjMenus.MenuId  ==  AttributeName[intIndex])
{
return mstrMenuId;
}
else if (conQxPrjMenus.MenuName  ==  AttributeName[intIndex])
{
return mstrMenuName;
}
else if (conQxPrjMenus.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxPrjMenus.UpMenuId  ==  AttributeName[intIndex])
{
return mstrUpMenuId;
}
else if (conQxPrjMenus.LinkFile  ==  AttributeName[intIndex])
{
return mstrLinkFile;
}
else if (conQxPrjMenus.qsParameters  ==  AttributeName[intIndex])
{
return mstrqsParameters;
}
else if (conQxPrjMenus.TabId  ==  AttributeName[intIndex])
{
return mstrTabId;
}
else if (conQxPrjMenus.ImgFile  ==  AttributeName[intIndex])
{
return mstrImgFile;
}
else if (conQxPrjMenus.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (conQxPrjMenus.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conQxPrjMenus.IsLeafNode  ==  AttributeName[intIndex])
{
return mbolIsLeafNode;
}
else if (conQxPrjMenus.MenuTitle  ==  AttributeName[intIndex])
{
return mstrMenuTitle;
}
else if (conQxPrjMenus.PageDispModeId  ==  AttributeName[intIndex])
{
return mstrPageDispModeId;
}
else if (conQxPrjMenus.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (conQxPrjMenus.MenuControlName  ==  AttributeName[intIndex])
{
return mstrMenuControlName;
}
else if (conQxPrjMenus.ApplicationTypeId  ==  AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (conQxPrjMenus.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxPrjMenus.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conQxPrjMenus.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (conQxPrjMenus.MenuId  ==  AttributeName[intIndex])
{
mstrMenuId = value.ToString();
 AddUpdatedFld(conQxPrjMenus.MenuId);
}
else if (conQxPrjMenus.MenuName  ==  AttributeName[intIndex])
{
mstrMenuName = value.ToString();
 AddUpdatedFld(conQxPrjMenus.MenuName);
}
else if (conQxPrjMenus.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxPrjMenus.QxPrjId);
}
else if (conQxPrjMenus.UpMenuId  ==  AttributeName[intIndex])
{
mstrUpMenuId = value.ToString();
 AddUpdatedFld(conQxPrjMenus.UpMenuId);
}
else if (conQxPrjMenus.LinkFile  ==  AttributeName[intIndex])
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(conQxPrjMenus.LinkFile);
}
else if (conQxPrjMenus.qsParameters  ==  AttributeName[intIndex])
{
mstrqsParameters = value.ToString();
 AddUpdatedFld(conQxPrjMenus.qsParameters);
}
else if (conQxPrjMenus.TabId  ==  AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conQxPrjMenus.TabId);
}
else if (conQxPrjMenus.ImgFile  ==  AttributeName[intIndex])
{
mstrImgFile = value.ToString();
 AddUpdatedFld(conQxPrjMenus.ImgFile);
}
else if (conQxPrjMenus.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conQxPrjMenus.RoleId);
}
else if (conQxPrjMenus.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjMenus.OrderNum);
}
else if (conQxPrjMenus.IsLeafNode  ==  AttributeName[intIndex])
{
mbolIsLeafNode = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxPrjMenus.IsLeafNode);
}
else if (conQxPrjMenus.MenuTitle  ==  AttributeName[intIndex])
{
mstrMenuTitle = value.ToString();
 AddUpdatedFld(conQxPrjMenus.MenuTitle);
}
else if (conQxPrjMenus.PageDispModeId  ==  AttributeName[intIndex])
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(conQxPrjMenus.PageDispModeId);
}
else if (conQxPrjMenus.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxPrjMenus.InUse);
}
else if (conQxPrjMenus.MenuControlName  ==  AttributeName[intIndex])
{
mstrMenuControlName = value.ToString();
 AddUpdatedFld(conQxPrjMenus.MenuControlName);
}
else if (conQxPrjMenus.ApplicationTypeId  ==  AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjMenus.ApplicationTypeId);
}
else if (conQxPrjMenus.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxPrjMenus.UpdDate);
}
else if (conQxPrjMenus.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxPrjMenus.UpdUserId);
}
else if (conQxPrjMenus.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPrjMenus.Memo);
}
}
}

/// <summary>
/// 菜单Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuId
{
get
{
return mstrMenuId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuId = value;
}
else
{
 mstrMenuId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjMenus.MenuId);
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
 AddUpdatedFld(conQxPrjMenus.MenuName);
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
 AddUpdatedFld(conQxPrjMenus.QxPrjId);
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
 AddUpdatedFld(conQxPrjMenus.UpMenuId);
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
 AddUpdatedFld(conQxPrjMenus.LinkFile);
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
 AddUpdatedFld(conQxPrjMenus.qsParameters);
}
}
/// <summary>
/// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string TabId
{
get
{
return mstrTabId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrTabId = value;
}
else
{
 mstrTabId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjMenus.TabId);
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
 AddUpdatedFld(conQxPrjMenus.ImgFile);
}
}
/// <summary>
/// 角色Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleId
{
get
{
return mstrRoleId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleId = value;
}
else
{
 mstrRoleId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjMenus.RoleId);
}
}
/// <summary>
/// 排序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
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
 AddUpdatedFld(conQxPrjMenus.OrderNum);
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
 AddUpdatedFld(conQxPrjMenus.IsLeafNode);
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
 AddUpdatedFld(conQxPrjMenus.MenuTitle);
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
 AddUpdatedFld(conQxPrjMenus.PageDispModeId);
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
 AddUpdatedFld(conQxPrjMenus.InUse);
}
}
/// <summary>
/// 菜单控件名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
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
 AddUpdatedFld(conQxPrjMenus.MenuControlName);
}
}
/// <summary>
/// 应用程序类型Id(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(conQxPrjMenus.ApplicationTypeId);
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
 AddUpdatedFld(conQxPrjMenus.UpdDate);
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
 AddUpdatedFld(conQxPrjMenus.UpdUserId);
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
 AddUpdatedFld(conQxPrjMenus.Memo);
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
  return mstrMenuId;
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
 /// 工程菜单(QxPrjMenus)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxPrjMenus
{
public const string _CurrTabName = "QxPrjMenus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "MenuId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"MenuId", "MenuName", "QxPrjId", "UpMenuId", "LinkFile", "qsParameters", "TabId", "ImgFile", "RoleId", "OrderNum", "IsLeafNode", "MenuTitle", "PageDispModeId", "InUse", "MenuControlName", "ApplicationTypeId", "UpdDate", "UpdUserId", "Memo"};
//以下是属性变量


 /// <summary>
 /// 常量:"MenuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuId = "MenuId";    //菜单Id

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
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"ImgFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ImgFile = "ImgFile";    //图像文件

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色Id

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
 /// 常量:"InUse"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string InUse = "InUse";    //是否在用

 /// <summary>
 /// 常量:"MenuControlName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuControlName = "MenuControlName";    //菜单控件名

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型Id

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
}

}