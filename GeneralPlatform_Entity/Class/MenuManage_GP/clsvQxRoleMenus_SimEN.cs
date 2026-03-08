
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRoleMenus_SimEN
 表名:vQxRoleMenus_Sim(00140073)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:35:02
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
 /// 表vQxRoleMenus_Sim的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vQxRoleMenus_Sim
{
private long _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public long Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="lngmId">表关键字</param>
public K_mId_vQxRoleMenus_Sim(long lngmId)
{
if (IsValid(lngmId)) Value = lngmId;
else
{
Value = 0;
}
}
private static bool IsValid(long lngmId)
{
if (lngmId == 0) return false;
if (lngmId == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_mId_vQxRoleMenus_Sim]类型的对象</returns>
public static implicit operator K_mId_vQxRoleMenus_Sim(long value)
{
return new K_mId_vQxRoleMenus_Sim(value);
}
}
 /// <summary>
 /// v角色菜单_Sim(vQxRoleMenus_Sim)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxRoleMenus_SimEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxRoleMenus_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 16;
public static string[] AttributeName = new string[] {"mId", "RoleId", "QxPrjId", "MenuId", "MenuName", "UpMenuId", "LinkFile", "qsParameters", "ImgFile", "OrderNum", "IsLeafNode", "MenuSetId", "MenuTitle", "PageDispModeId", "InUse", "UpMenuName"};

protected long mlngmId;    //流水号
protected string mstrRoleId;    //角色Id
protected string mstrQxPrjId;    //项目Id
protected string mstrMenuId;    //菜单Id
protected string mstrMenuName;    //菜单名
protected string mstrUpMenuId;    //上级菜单Id
protected string mstrLinkFile;    //链接文件
protected string mstrqsParameters;    //qs参数
protected string mstrImgFile;    //图像文件
protected int? mintOrderNum;    //排序号
protected bool mbolIsLeafNode;    //是否叶子
protected string mstrMenuSetId;    //菜单集Id
protected string mstrMenuTitle;    //菜单标题
protected string mstrPageDispModeId;    //页面显示模式Id
protected bool mbolInUse;    //是否在用
protected string mstrUpMenuName;    //上级菜单名

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxRoleMenus_SimEN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "lngmId">关键字:流水号</param>
public clsvQxRoleMenus_SimEN(long lngmId)
 {
 if (lngmId  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mlngmId = lngmId;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("mId");
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
if (strAttributeName  ==  convQxRoleMenus_Sim.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.MenuId)
{
return mstrMenuId;
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.MenuName)
{
return mstrMenuName;
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.UpMenuId)
{
return mstrUpMenuId;
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.LinkFile)
{
return mstrLinkFile;
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.qsParameters)
{
return mstrqsParameters;
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.ImgFile)
{
return mstrImgFile;
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.IsLeafNode)
{
return mbolIsLeafNode;
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.MenuSetId)
{
return mstrMenuSetId;
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.MenuTitle)
{
return mstrMenuTitle;
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.PageDispModeId)
{
return mstrPageDispModeId;
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.UpMenuName)
{
return mstrUpMenuName;
}
return null;
}
set
{
if (strAttributeName  ==  convQxRoleMenus_Sim.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxRoleMenus_Sim.mId);
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.RoleId);
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.QxPrjId);
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.MenuId)
{
mstrMenuId = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.MenuId);
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.MenuName)
{
mstrMenuName = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.MenuName);
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.UpMenuId)
{
mstrUpMenuId = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.UpMenuId);
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.LinkFile)
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.LinkFile);
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.qsParameters)
{
mstrqsParameters = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.qsParameters);
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.ImgFile)
{
mstrImgFile = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.ImgFile);
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxRoleMenus_Sim.OrderNum);
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.IsLeafNode)
{
mbolIsLeafNode = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxRoleMenus_Sim.IsLeafNode);
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.MenuSetId)
{
mstrMenuSetId = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.MenuSetId);
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.MenuTitle)
{
mstrMenuTitle = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.MenuTitle);
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.PageDispModeId)
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.PageDispModeId);
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxRoleMenus_Sim.InUse);
}
else if (strAttributeName  ==  convQxRoleMenus_Sim.UpMenuName)
{
mstrUpMenuName = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.UpMenuName);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxRoleMenus_Sim.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convQxRoleMenus_Sim.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (convQxRoleMenus_Sim.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (convQxRoleMenus_Sim.MenuId  ==  AttributeName[intIndex])
{
return mstrMenuId;
}
else if (convQxRoleMenus_Sim.MenuName  ==  AttributeName[intIndex])
{
return mstrMenuName;
}
else if (convQxRoleMenus_Sim.UpMenuId  ==  AttributeName[intIndex])
{
return mstrUpMenuId;
}
else if (convQxRoleMenus_Sim.LinkFile  ==  AttributeName[intIndex])
{
return mstrLinkFile;
}
else if (convQxRoleMenus_Sim.qsParameters  ==  AttributeName[intIndex])
{
return mstrqsParameters;
}
else if (convQxRoleMenus_Sim.ImgFile  ==  AttributeName[intIndex])
{
return mstrImgFile;
}
else if (convQxRoleMenus_Sim.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convQxRoleMenus_Sim.IsLeafNode  ==  AttributeName[intIndex])
{
return mbolIsLeafNode;
}
else if (convQxRoleMenus_Sim.MenuSetId  ==  AttributeName[intIndex])
{
return mstrMenuSetId;
}
else if (convQxRoleMenus_Sim.MenuTitle  ==  AttributeName[intIndex])
{
return mstrMenuTitle;
}
else if (convQxRoleMenus_Sim.PageDispModeId  ==  AttributeName[intIndex])
{
return mstrPageDispModeId;
}
else if (convQxRoleMenus_Sim.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (convQxRoleMenus_Sim.UpMenuName  ==  AttributeName[intIndex])
{
return mstrUpMenuName;
}
return null;
}
set
{
if (convQxRoleMenus_Sim.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxRoleMenus_Sim.mId);
}
else if (convQxRoleMenus_Sim.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.RoleId);
}
else if (convQxRoleMenus_Sim.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.QxPrjId);
}
else if (convQxRoleMenus_Sim.MenuId  ==  AttributeName[intIndex])
{
mstrMenuId = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.MenuId);
}
else if (convQxRoleMenus_Sim.MenuName  ==  AttributeName[intIndex])
{
mstrMenuName = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.MenuName);
}
else if (convQxRoleMenus_Sim.UpMenuId  ==  AttributeName[intIndex])
{
mstrUpMenuId = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.UpMenuId);
}
else if (convQxRoleMenus_Sim.LinkFile  ==  AttributeName[intIndex])
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.LinkFile);
}
else if (convQxRoleMenus_Sim.qsParameters  ==  AttributeName[intIndex])
{
mstrqsParameters = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.qsParameters);
}
else if (convQxRoleMenus_Sim.ImgFile  ==  AttributeName[intIndex])
{
mstrImgFile = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.ImgFile);
}
else if (convQxRoleMenus_Sim.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxRoleMenus_Sim.OrderNum);
}
else if (convQxRoleMenus_Sim.IsLeafNode  ==  AttributeName[intIndex])
{
mbolIsLeafNode = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxRoleMenus_Sim.IsLeafNode);
}
else if (convQxRoleMenus_Sim.MenuSetId  ==  AttributeName[intIndex])
{
mstrMenuSetId = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.MenuSetId);
}
else if (convQxRoleMenus_Sim.MenuTitle  ==  AttributeName[intIndex])
{
mstrMenuTitle = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.MenuTitle);
}
else if (convQxRoleMenus_Sim.PageDispModeId  ==  AttributeName[intIndex])
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.PageDispModeId);
}
else if (convQxRoleMenus_Sim.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxRoleMenus_Sim.InUse);
}
else if (convQxRoleMenus_Sim.UpMenuName  ==  AttributeName[intIndex])
{
mstrUpMenuName = value.ToString();
 AddUpdatedFld(convQxRoleMenus_Sim.UpMenuName);
}
}
}

/// <summary>
/// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
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
 AddUpdatedFld(convQxRoleMenus_Sim.mId);
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
 AddUpdatedFld(convQxRoleMenus_Sim.RoleId);
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
 AddUpdatedFld(convQxRoleMenus_Sim.QxPrjId);
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
 AddUpdatedFld(convQxRoleMenus_Sim.MenuId);
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
 AddUpdatedFld(convQxRoleMenus_Sim.MenuName);
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
 AddUpdatedFld(convQxRoleMenus_Sim.UpMenuId);
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
 AddUpdatedFld(convQxRoleMenus_Sim.LinkFile);
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
 AddUpdatedFld(convQxRoleMenus_Sim.qsParameters);
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
 AddUpdatedFld(convQxRoleMenus_Sim.ImgFile);
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
 AddUpdatedFld(convQxRoleMenus_Sim.OrderNum);
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
 AddUpdatedFld(convQxRoleMenus_Sim.IsLeafNode);
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
 AddUpdatedFld(convQxRoleMenus_Sim.MenuSetId);
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
 AddUpdatedFld(convQxRoleMenus_Sim.MenuTitle);
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
 AddUpdatedFld(convQxRoleMenus_Sim.PageDispModeId);
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
 AddUpdatedFld(convQxRoleMenus_Sim.InUse);
}
}
/// <summary>
/// 上级菜单名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpMenuName
{
get
{
return mstrUpMenuName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpMenuName = value;
}
else
{
 mstrUpMenuName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxRoleMenus_Sim.UpMenuName);
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
  return mlngmId.ToString();
 }
 }
}
 /// <summary>
 /// v角色菜单_Sim(vQxRoleMenus_Sim)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxRoleMenus_Sim
{
public const string _CurrTabName = "vQxRoleMenus_Sim"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "RoleId", "QxPrjId", "MenuId", "MenuName", "UpMenuId", "LinkFile", "qsParameters", "ImgFile", "OrderNum", "IsLeafNode", "MenuSetId", "MenuTitle", "PageDispModeId", "InUse", "UpMenuName"};
//以下是属性变量


 /// <summary>
 /// 常量:"mId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string mId = "mId";    //流水号

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色Id

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

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
 /// 常量:"UpMenuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpMenuName = "UpMenuName";    //上级菜单名
}

}