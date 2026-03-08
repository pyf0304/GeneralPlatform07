
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxPrjMenus_LeafEN
 表名:vQxPrjMenus_Leaf(00140085)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:33:23
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
 /// 表vQxPrjMenus_Leaf的关键字(MenuIdLeaf)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_MenuIdLeaf_vQxPrjMenus_Leaf
{
private string _value = "";
/// <summary>
/// 关键字类型内面的值
/// </summary>
public string Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="strMenuIdLeaf">表关键字</param>
public K_MenuIdLeaf_vQxPrjMenus_Leaf(string strMenuIdLeaf)
{
if (IsValid(strMenuIdLeaf)) Value = strMenuIdLeaf;
else
{
Value = null;
}
}
private static bool IsValid(string strMenuIdLeaf)
{
if (string.IsNullOrEmpty(strMenuIdLeaf) == true) return false;
if (strMenuIdLeaf.Length != 8) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_MenuIdLeaf_vQxPrjMenus_Leaf]类型的对象</returns>
public static implicit operator K_MenuIdLeaf_vQxPrjMenus_Leaf(string value)
{
return new K_MenuIdLeaf_vQxPrjMenus_Leaf(value);
}
}
 /// <summary>
 /// v三层菜单(vQxPrjMenus_Leaf)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxPrjMenus_LeafEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxPrjMenus_Leaf"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "MenuIdLeaf"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 20;
public static string[] AttributeName = new string[] {"MenuIdLeaf", "MenuName", "QxPrjId", "PrjName", "UpMenuId", "LinkFile", "qsParameters", "ImgFile", "OrderNum", "IsLeafNode", "MenuSetId", "MenuSetName", "MenuTitle", "PageDispModeId", "PageDispModeName", "InUse", "UpdDate", "UpdUserId", "Memo", "MenuControlName"};

protected string mstrMenuIdLeaf;    //MenuId_Leaf
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
 public clsvQxPrjMenus_LeafEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MenuIdLeaf");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "strMenuIdLeaf">关键字:MenuId_Leaf</param>
public clsvQxPrjMenus_LeafEN(string strMenuIdLeaf)
 {
strMenuIdLeaf = strMenuIdLeaf.Replace("'", "''");
if (strMenuIdLeaf.Length > 8)
{
throw new Exception("在表:vQxPrjMenus_Leaf中,关键字长度不正确!");
}
if (string.IsNullOrEmpty(strMenuIdLeaf)  ==  true)
{
throw new Exception("在表:vQxPrjMenus_Leaf中,关键字不能为空 或 null!");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strMenuIdLeaf);
}
catch (Exception objException)
{
throw new Exception(string.Format("在关键字中含有{0},请检查!", objException.Message));
}

this.mstrMenuIdLeaf = strMenuIdLeaf;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("MenuIdLeaf");
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
if (strAttributeName  ==  convQxPrjMenus_Leaf.MenuIdLeaf)
{
return mstrMenuIdLeaf;
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.MenuName)
{
return mstrMenuName;
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.UpMenuId)
{
return mstrUpMenuId;
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.LinkFile)
{
return mstrLinkFile;
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.qsParameters)
{
return mstrqsParameters;
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.ImgFile)
{
return mstrImgFile;
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.IsLeafNode)
{
return mbolIsLeafNode;
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.MenuSetId)
{
return mstrMenuSetId;
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.MenuSetName)
{
return mstrMenuSetName;
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.MenuTitle)
{
return mstrMenuTitle;
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.PageDispModeId)
{
return mstrPageDispModeId;
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.PageDispModeName)
{
return mstrPageDispModeName;
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.MenuControlName)
{
return mstrMenuControlName;
}
return null;
}
set
{
if (strAttributeName  ==  convQxPrjMenus_Leaf.MenuIdLeaf)
{
mstrMenuIdLeaf = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.MenuIdLeaf);
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.MenuName)
{
mstrMenuName = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.MenuName);
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.QxPrjId);
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.PrjName);
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.UpMenuId)
{
mstrUpMenuId = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.UpMenuId);
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.LinkFile)
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.LinkFile);
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.qsParameters)
{
mstrqsParameters = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.qsParameters);
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.ImgFile)
{
mstrImgFile = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.ImgFile);
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPrjMenus_Leaf.OrderNum);
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.IsLeafNode)
{
mbolIsLeafNode = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjMenus_Leaf.IsLeafNode);
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.MenuSetId)
{
mstrMenuSetId = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.MenuSetId);
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.MenuSetName)
{
mstrMenuSetName = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.MenuSetName);
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.MenuTitle)
{
mstrMenuTitle = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.MenuTitle);
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.PageDispModeId)
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.PageDispModeId);
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.PageDispModeName)
{
mstrPageDispModeName = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.PageDispModeName);
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjMenus_Leaf.InUse);
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.UpdDate);
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.UpdUserId);
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.Memo);
}
else if (strAttributeName  ==  convQxPrjMenus_Leaf.MenuControlName)
{
mstrMenuControlName = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.MenuControlName);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxPrjMenus_Leaf.MenuIdLeaf  ==  AttributeName[intIndex])
{
return mstrMenuIdLeaf;
}
else if (convQxPrjMenus_Leaf.MenuName  ==  AttributeName[intIndex])
{
return mstrMenuName;
}
else if (convQxPrjMenus_Leaf.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (convQxPrjMenus_Leaf.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convQxPrjMenus_Leaf.UpMenuId  ==  AttributeName[intIndex])
{
return mstrUpMenuId;
}
else if (convQxPrjMenus_Leaf.LinkFile  ==  AttributeName[intIndex])
{
return mstrLinkFile;
}
else if (convQxPrjMenus_Leaf.qsParameters  ==  AttributeName[intIndex])
{
return mstrqsParameters;
}
else if (convQxPrjMenus_Leaf.ImgFile  ==  AttributeName[intIndex])
{
return mstrImgFile;
}
else if (convQxPrjMenus_Leaf.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convQxPrjMenus_Leaf.IsLeafNode  ==  AttributeName[intIndex])
{
return mbolIsLeafNode;
}
else if (convQxPrjMenus_Leaf.MenuSetId  ==  AttributeName[intIndex])
{
return mstrMenuSetId;
}
else if (convQxPrjMenus_Leaf.MenuSetName  ==  AttributeName[intIndex])
{
return mstrMenuSetName;
}
else if (convQxPrjMenus_Leaf.MenuTitle  ==  AttributeName[intIndex])
{
return mstrMenuTitle;
}
else if (convQxPrjMenus_Leaf.PageDispModeId  ==  AttributeName[intIndex])
{
return mstrPageDispModeId;
}
else if (convQxPrjMenus_Leaf.PageDispModeName  ==  AttributeName[intIndex])
{
return mstrPageDispModeName;
}
else if (convQxPrjMenus_Leaf.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (convQxPrjMenus_Leaf.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQxPrjMenus_Leaf.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convQxPrjMenus_Leaf.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (convQxPrjMenus_Leaf.MenuControlName  ==  AttributeName[intIndex])
{
return mstrMenuControlName;
}
return null;
}
set
{
if (convQxPrjMenus_Leaf.MenuIdLeaf  ==  AttributeName[intIndex])
{
mstrMenuIdLeaf = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.MenuIdLeaf);
}
else if (convQxPrjMenus_Leaf.MenuName  ==  AttributeName[intIndex])
{
mstrMenuName = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.MenuName);
}
else if (convQxPrjMenus_Leaf.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.QxPrjId);
}
else if (convQxPrjMenus_Leaf.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.PrjName);
}
else if (convQxPrjMenus_Leaf.UpMenuId  ==  AttributeName[intIndex])
{
mstrUpMenuId = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.UpMenuId);
}
else if (convQxPrjMenus_Leaf.LinkFile  ==  AttributeName[intIndex])
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.LinkFile);
}
else if (convQxPrjMenus_Leaf.qsParameters  ==  AttributeName[intIndex])
{
mstrqsParameters = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.qsParameters);
}
else if (convQxPrjMenus_Leaf.ImgFile  ==  AttributeName[intIndex])
{
mstrImgFile = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.ImgFile);
}
else if (convQxPrjMenus_Leaf.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxPrjMenus_Leaf.OrderNum);
}
else if (convQxPrjMenus_Leaf.IsLeafNode  ==  AttributeName[intIndex])
{
mbolIsLeafNode = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjMenus_Leaf.IsLeafNode);
}
else if (convQxPrjMenus_Leaf.MenuSetId  ==  AttributeName[intIndex])
{
mstrMenuSetId = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.MenuSetId);
}
else if (convQxPrjMenus_Leaf.MenuSetName  ==  AttributeName[intIndex])
{
mstrMenuSetName = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.MenuSetName);
}
else if (convQxPrjMenus_Leaf.MenuTitle  ==  AttributeName[intIndex])
{
mstrMenuTitle = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.MenuTitle);
}
else if (convQxPrjMenus_Leaf.PageDispModeId  ==  AttributeName[intIndex])
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.PageDispModeId);
}
else if (convQxPrjMenus_Leaf.PageDispModeName  ==  AttributeName[intIndex])
{
mstrPageDispModeName = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.PageDispModeName);
}
else if (convQxPrjMenus_Leaf.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxPrjMenus_Leaf.InUse);
}
else if (convQxPrjMenus_Leaf.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.UpdDate);
}
else if (convQxPrjMenus_Leaf.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.UpdUserId);
}
else if (convQxPrjMenus_Leaf.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.Memo);
}
else if (convQxPrjMenus_Leaf.MenuControlName  ==  AttributeName[intIndex])
{
mstrMenuControlName = value.ToString();
 AddUpdatedFld(convQxPrjMenus_Leaf.MenuControlName);
}
}
}

/// <summary>
/// MenuId_Leaf(说明:;字段类型:char;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuIdLeaf
{
get
{
return mstrMenuIdLeaf;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuIdLeaf = value;
}
else
{
 mstrMenuIdLeaf = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxPrjMenus_Leaf.MenuIdLeaf);
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
 AddUpdatedFld(convQxPrjMenus_Leaf.MenuName);
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
 AddUpdatedFld(convQxPrjMenus_Leaf.QxPrjId);
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
 AddUpdatedFld(convQxPrjMenus_Leaf.PrjName);
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
 AddUpdatedFld(convQxPrjMenus_Leaf.UpMenuId);
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
 AddUpdatedFld(convQxPrjMenus_Leaf.LinkFile);
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
 AddUpdatedFld(convQxPrjMenus_Leaf.qsParameters);
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
 AddUpdatedFld(convQxPrjMenus_Leaf.ImgFile);
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
 AddUpdatedFld(convQxPrjMenus_Leaf.OrderNum);
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
 AddUpdatedFld(convQxPrjMenus_Leaf.IsLeafNode);
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
 AddUpdatedFld(convQxPrjMenus_Leaf.MenuSetId);
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
 AddUpdatedFld(convQxPrjMenus_Leaf.MenuSetName);
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
 AddUpdatedFld(convQxPrjMenus_Leaf.MenuTitle);
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
 AddUpdatedFld(convQxPrjMenus_Leaf.PageDispModeId);
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
 AddUpdatedFld(convQxPrjMenus_Leaf.PageDispModeName);
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
 AddUpdatedFld(convQxPrjMenus_Leaf.InUse);
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
 AddUpdatedFld(convQxPrjMenus_Leaf.UpdDate);
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
 AddUpdatedFld(convQxPrjMenus_Leaf.UpdUserId);
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
 AddUpdatedFld(convQxPrjMenus_Leaf.Memo);
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
 AddUpdatedFld(convQxPrjMenus_Leaf.MenuControlName);
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
  return mstrMenuIdLeaf;
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
 /// v三层菜单(vQxPrjMenus_Leaf)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxPrjMenus_Leaf
{
public const string _CurrTabName = "vQxPrjMenus_Leaf"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "MenuIdLeaf"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"MenuIdLeaf", "MenuName", "QxPrjId", "PrjName", "UpMenuId", "LinkFile", "qsParameters", "ImgFile", "OrderNum", "IsLeafNode", "MenuSetId", "MenuSetName", "MenuTitle", "PageDispModeId", "PageDispModeName", "InUse", "UpdDate", "UpdUserId", "Memo", "MenuControlName"};
//以下是属性变量


 /// <summary>
 /// 常量:"MenuIdLeaf"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuIdLeaf = "MenuIdLeaf";    //MenuId_Leaf

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