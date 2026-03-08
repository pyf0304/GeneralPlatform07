
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRoleMenusEN
 表名:vQxRoleMenus(00140034)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 17:47:14
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
 /// 表vQxRoleMenus的关键字(mId)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_mId_vQxRoleMenus
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
public K_mId_vQxRoleMenus(long lngmId)
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
 /// <returns>返回:[K_mId_vQxRoleMenus]类型的对象</returns>
public static implicit operator K_mId_vQxRoleMenus(long value)
{
return new K_mId_vQxRoleMenus(value);
}
}
 /// <summary>
 /// v角色菜单(vQxRoleMenus)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsvQxRoleMenusEN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "vQxRoleMenus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 25;
public static string[] AttributeName = new string[] {"mId", "RoleId", "RoleName", "QxPrjId", "MenuId", "MenuName", "PrjName", "UpMenuId", "LinkFile", "qsParameters", "ImgFile", "OrderNum", "IsLeafNode", "MenuSetId", "MenuSetName", "MenuTitle", "PageDispModeId", "PageDispModeName", "InUse", "UpMenuName", "RoleNum", "IsDisp", "UpdDate", "UpdUserId", "Memo"};

protected long mlngmId;    //流水号
protected string mstrRoleId;    //角色Id
protected string mstrRoleName;    //角色名称
protected string mstrQxPrjId;    //项目Id
protected string mstrMenuId;    //菜单Id
protected string mstrMenuName;    //菜单名
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
protected string mstrUpMenuName;    //上级菜单名
protected int? mintRoleNum;    //角色数
protected bool mbolIsDisp;    //是否显示
protected string mstrUpdDate;    //修改日期
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsvQxRoleMenusEN()
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
public clsvQxRoleMenusEN(long lngmId)
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
if (strAttributeName  ==  convQxRoleMenus.mId)
{
return mlngmId;
}
else if (strAttributeName  ==  convQxRoleMenus.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  convQxRoleMenus.RoleName)
{
return mstrRoleName;
}
else if (strAttributeName  ==  convQxRoleMenus.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  convQxRoleMenus.MenuId)
{
return mstrMenuId;
}
else if (strAttributeName  ==  convQxRoleMenus.MenuName)
{
return mstrMenuName;
}
else if (strAttributeName  ==  convQxRoleMenus.PrjName)
{
return mstrPrjName;
}
else if (strAttributeName  ==  convQxRoleMenus.UpMenuId)
{
return mstrUpMenuId;
}
else if (strAttributeName  ==  convQxRoleMenus.LinkFile)
{
return mstrLinkFile;
}
else if (strAttributeName  ==  convQxRoleMenus.qsParameters)
{
return mstrqsParameters;
}
else if (strAttributeName  ==  convQxRoleMenus.ImgFile)
{
return mstrImgFile;
}
else if (strAttributeName  ==  convQxRoleMenus.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  convQxRoleMenus.IsLeafNode)
{
return mbolIsLeafNode;
}
else if (strAttributeName  ==  convQxRoleMenus.MenuSetId)
{
return mstrMenuSetId;
}
else if (strAttributeName  ==  convQxRoleMenus.MenuSetName)
{
return mstrMenuSetName;
}
else if (strAttributeName  ==  convQxRoleMenus.MenuTitle)
{
return mstrMenuTitle;
}
else if (strAttributeName  ==  convQxRoleMenus.PageDispModeId)
{
return mstrPageDispModeId;
}
else if (strAttributeName  ==  convQxRoleMenus.PageDispModeName)
{
return mstrPageDispModeName;
}
else if (strAttributeName  ==  convQxRoleMenus.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  convQxRoleMenus.UpMenuName)
{
return mstrUpMenuName;
}
else if (strAttributeName  ==  convQxRoleMenus.RoleNum)
{
return mintRoleNum;
}
else if (strAttributeName  ==  convQxRoleMenus.IsDisp)
{
return mbolIsDisp;
}
else if (strAttributeName  ==  convQxRoleMenus.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  convQxRoleMenus.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  convQxRoleMenus.Memo)
{
return mstrMemo;
}
return null;
}
set
{
if (strAttributeName  ==  convQxRoleMenus.mId)
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxRoleMenus.mId);
}
else if (strAttributeName  ==  convQxRoleMenus.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQxRoleMenus.RoleId);
}
else if (strAttributeName  ==  convQxRoleMenus.RoleName)
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convQxRoleMenus.RoleName);
}
else if (strAttributeName  ==  convQxRoleMenus.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxRoleMenus.QxPrjId);
}
else if (strAttributeName  ==  convQxRoleMenus.MenuId)
{
mstrMenuId = value.ToString();
 AddUpdatedFld(convQxRoleMenus.MenuId);
}
else if (strAttributeName  ==  convQxRoleMenus.MenuName)
{
mstrMenuName = value.ToString();
 AddUpdatedFld(convQxRoleMenus.MenuName);
}
else if (strAttributeName  ==  convQxRoleMenus.PrjName)
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxRoleMenus.PrjName);
}
else if (strAttributeName  ==  convQxRoleMenus.UpMenuId)
{
mstrUpMenuId = value.ToString();
 AddUpdatedFld(convQxRoleMenus.UpMenuId);
}
else if (strAttributeName  ==  convQxRoleMenus.LinkFile)
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(convQxRoleMenus.LinkFile);
}
else if (strAttributeName  ==  convQxRoleMenus.qsParameters)
{
mstrqsParameters = value.ToString();
 AddUpdatedFld(convQxRoleMenus.qsParameters);
}
else if (strAttributeName  ==  convQxRoleMenus.ImgFile)
{
mstrImgFile = value.ToString();
 AddUpdatedFld(convQxRoleMenus.ImgFile);
}
else if (strAttributeName  ==  convQxRoleMenus.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxRoleMenus.OrderNum);
}
else if (strAttributeName  ==  convQxRoleMenus.IsLeafNode)
{
mbolIsLeafNode = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxRoleMenus.IsLeafNode);
}
else if (strAttributeName  ==  convQxRoleMenus.MenuSetId)
{
mstrMenuSetId = value.ToString();
 AddUpdatedFld(convQxRoleMenus.MenuSetId);
}
else if (strAttributeName  ==  convQxRoleMenus.MenuSetName)
{
mstrMenuSetName = value.ToString();
 AddUpdatedFld(convQxRoleMenus.MenuSetName);
}
else if (strAttributeName  ==  convQxRoleMenus.MenuTitle)
{
mstrMenuTitle = value.ToString();
 AddUpdatedFld(convQxRoleMenus.MenuTitle);
}
else if (strAttributeName  ==  convQxRoleMenus.PageDispModeId)
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(convQxRoleMenus.PageDispModeId);
}
else if (strAttributeName  ==  convQxRoleMenus.PageDispModeName)
{
mstrPageDispModeName = value.ToString();
 AddUpdatedFld(convQxRoleMenus.PageDispModeName);
}
else if (strAttributeName  ==  convQxRoleMenus.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxRoleMenus.InUse);
}
else if (strAttributeName  ==  convQxRoleMenus.UpMenuName)
{
mstrUpMenuName = value.ToString();
 AddUpdatedFld(convQxRoleMenus.UpMenuName);
}
else if (strAttributeName  ==  convQxRoleMenus.RoleNum)
{
mintRoleNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxRoleMenus.RoleNum);
}
else if (strAttributeName  ==  convQxRoleMenus.IsDisp)
{
mbolIsDisp = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxRoleMenus.IsDisp);
}
else if (strAttributeName  ==  convQxRoleMenus.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxRoleMenus.UpdDate);
}
else if (strAttributeName  ==  convQxRoleMenus.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxRoleMenus.UpdUserId);
}
else if (strAttributeName  ==  convQxRoleMenus.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxRoleMenus.Memo);
}
}
}
public object this[int intIndex]
{
get
{
if (convQxRoleMenus.mId  ==  AttributeName[intIndex])
{
return mlngmId;
}
else if (convQxRoleMenus.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (convQxRoleMenus.RoleName  ==  AttributeName[intIndex])
{
return mstrRoleName;
}
else if (convQxRoleMenus.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (convQxRoleMenus.MenuId  ==  AttributeName[intIndex])
{
return mstrMenuId;
}
else if (convQxRoleMenus.MenuName  ==  AttributeName[intIndex])
{
return mstrMenuName;
}
else if (convQxRoleMenus.PrjName  ==  AttributeName[intIndex])
{
return mstrPrjName;
}
else if (convQxRoleMenus.UpMenuId  ==  AttributeName[intIndex])
{
return mstrUpMenuId;
}
else if (convQxRoleMenus.LinkFile  ==  AttributeName[intIndex])
{
return mstrLinkFile;
}
else if (convQxRoleMenus.qsParameters  ==  AttributeName[intIndex])
{
return mstrqsParameters;
}
else if (convQxRoleMenus.ImgFile  ==  AttributeName[intIndex])
{
return mstrImgFile;
}
else if (convQxRoleMenus.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (convQxRoleMenus.IsLeafNode  ==  AttributeName[intIndex])
{
return mbolIsLeafNode;
}
else if (convQxRoleMenus.MenuSetId  ==  AttributeName[intIndex])
{
return mstrMenuSetId;
}
else if (convQxRoleMenus.MenuSetName  ==  AttributeName[intIndex])
{
return mstrMenuSetName;
}
else if (convQxRoleMenus.MenuTitle  ==  AttributeName[intIndex])
{
return mstrMenuTitle;
}
else if (convQxRoleMenus.PageDispModeId  ==  AttributeName[intIndex])
{
return mstrPageDispModeId;
}
else if (convQxRoleMenus.PageDispModeName  ==  AttributeName[intIndex])
{
return mstrPageDispModeName;
}
else if (convQxRoleMenus.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (convQxRoleMenus.UpMenuName  ==  AttributeName[intIndex])
{
return mstrUpMenuName;
}
else if (convQxRoleMenus.RoleNum  ==  AttributeName[intIndex])
{
return mintRoleNum;
}
else if (convQxRoleMenus.IsDisp  ==  AttributeName[intIndex])
{
return mbolIsDisp;
}
else if (convQxRoleMenus.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (convQxRoleMenus.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (convQxRoleMenus.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
return null;
}
set
{
if (convQxRoleMenus.mId  ==  AttributeName[intIndex])
{
mlngmId = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxRoleMenus.mId);
}
else if (convQxRoleMenus.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(convQxRoleMenus.RoleId);
}
else if (convQxRoleMenus.RoleName  ==  AttributeName[intIndex])
{
mstrRoleName = value.ToString();
 AddUpdatedFld(convQxRoleMenus.RoleName);
}
else if (convQxRoleMenus.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(convQxRoleMenus.QxPrjId);
}
else if (convQxRoleMenus.MenuId  ==  AttributeName[intIndex])
{
mstrMenuId = value.ToString();
 AddUpdatedFld(convQxRoleMenus.MenuId);
}
else if (convQxRoleMenus.MenuName  ==  AttributeName[intIndex])
{
mstrMenuName = value.ToString();
 AddUpdatedFld(convQxRoleMenus.MenuName);
}
else if (convQxRoleMenus.PrjName  ==  AttributeName[intIndex])
{
mstrPrjName = value.ToString();
 AddUpdatedFld(convQxRoleMenus.PrjName);
}
else if (convQxRoleMenus.UpMenuId  ==  AttributeName[intIndex])
{
mstrUpMenuId = value.ToString();
 AddUpdatedFld(convQxRoleMenus.UpMenuId);
}
else if (convQxRoleMenus.LinkFile  ==  AttributeName[intIndex])
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(convQxRoleMenus.LinkFile);
}
else if (convQxRoleMenus.qsParameters  ==  AttributeName[intIndex])
{
mstrqsParameters = value.ToString();
 AddUpdatedFld(convQxRoleMenus.qsParameters);
}
else if (convQxRoleMenus.ImgFile  ==  AttributeName[intIndex])
{
mstrImgFile = value.ToString();
 AddUpdatedFld(convQxRoleMenus.ImgFile);
}
else if (convQxRoleMenus.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxRoleMenus.OrderNum);
}
else if (convQxRoleMenus.IsLeafNode  ==  AttributeName[intIndex])
{
mbolIsLeafNode = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxRoleMenus.IsLeafNode);
}
else if (convQxRoleMenus.MenuSetId  ==  AttributeName[intIndex])
{
mstrMenuSetId = value.ToString();
 AddUpdatedFld(convQxRoleMenus.MenuSetId);
}
else if (convQxRoleMenus.MenuSetName  ==  AttributeName[intIndex])
{
mstrMenuSetName = value.ToString();
 AddUpdatedFld(convQxRoleMenus.MenuSetName);
}
else if (convQxRoleMenus.MenuTitle  ==  AttributeName[intIndex])
{
mstrMenuTitle = value.ToString();
 AddUpdatedFld(convQxRoleMenus.MenuTitle);
}
else if (convQxRoleMenus.PageDispModeId  ==  AttributeName[intIndex])
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(convQxRoleMenus.PageDispModeId);
}
else if (convQxRoleMenus.PageDispModeName  ==  AttributeName[intIndex])
{
mstrPageDispModeName = value.ToString();
 AddUpdatedFld(convQxRoleMenus.PageDispModeName);
}
else if (convQxRoleMenus.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxRoleMenus.InUse);
}
else if (convQxRoleMenus.UpMenuName  ==  AttributeName[intIndex])
{
mstrUpMenuName = value.ToString();
 AddUpdatedFld(convQxRoleMenus.UpMenuName);
}
else if (convQxRoleMenus.RoleNum  ==  AttributeName[intIndex])
{
mintRoleNum = TransNullToInt(value.ToString());
 AddUpdatedFld(convQxRoleMenus.RoleNum);
}
else if (convQxRoleMenus.IsDisp  ==  AttributeName[intIndex])
{
mbolIsDisp = TransNullToBool(value.ToString());
 AddUpdatedFld(convQxRoleMenus.IsDisp);
}
else if (convQxRoleMenus.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(convQxRoleMenus.UpdDate);
}
else if (convQxRoleMenus.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(convQxRoleMenus.UpdUserId);
}
else if (convQxRoleMenus.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(convQxRoleMenus.Memo);
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
 AddUpdatedFld(convQxRoleMenus.mId);
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
 AddUpdatedFld(convQxRoleMenus.RoleId);
}
}
/// <summary>
/// 角色名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string RoleName
{
get
{
return mstrRoleName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrRoleName = value;
}
else
{
 mstrRoleName = value;
}
//记录修改过的字段
 AddUpdatedFld(convQxRoleMenus.RoleName);
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
 AddUpdatedFld(convQxRoleMenus.QxPrjId);
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
 AddUpdatedFld(convQxRoleMenus.MenuId);
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
 AddUpdatedFld(convQxRoleMenus.MenuName);
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
 AddUpdatedFld(convQxRoleMenus.PrjName);
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
 AddUpdatedFld(convQxRoleMenus.UpMenuId);
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
 AddUpdatedFld(convQxRoleMenus.LinkFile);
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
 AddUpdatedFld(convQxRoleMenus.qsParameters);
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
 AddUpdatedFld(convQxRoleMenus.ImgFile);
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
 AddUpdatedFld(convQxRoleMenus.OrderNum);
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
 AddUpdatedFld(convQxRoleMenus.IsLeafNode);
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
 AddUpdatedFld(convQxRoleMenus.MenuSetId);
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
 AddUpdatedFld(convQxRoleMenus.MenuSetName);
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
 AddUpdatedFld(convQxRoleMenus.MenuTitle);
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
 AddUpdatedFld(convQxRoleMenus.PageDispModeId);
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
 AddUpdatedFld(convQxRoleMenus.PageDispModeName);
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
 AddUpdatedFld(convQxRoleMenus.InUse);
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
 AddUpdatedFld(convQxRoleMenus.UpMenuName);
}
}
/// <summary>
/// 角色数(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? RoleNum
{
get
{
return mintRoleNum;
}
set
{
 mintRoleNum = value;
//记录修改过的字段
 AddUpdatedFld(convQxRoleMenus.RoleNum);
}
}
/// <summary>
/// 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsDisp
{
get
{
return mbolIsDisp;
}
set
{
 mbolIsDisp = value;
//记录修改过的字段
 AddUpdatedFld(convQxRoleMenus.IsDisp);
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
 AddUpdatedFld(convQxRoleMenus.UpdDate);
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
 AddUpdatedFld(convQxRoleMenus.UpdUserId);
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
 AddUpdatedFld(convQxRoleMenus.Memo);
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
 /// v角色菜单(vQxRoleMenus)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class convQxRoleMenus
{
public const string _CurrTabName = "vQxRoleMenus"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"mId", "RoleId", "RoleName", "QxPrjId", "MenuId", "MenuName", "PrjName", "UpMenuId", "LinkFile", "qsParameters", "ImgFile", "OrderNum", "IsLeafNode", "MenuSetId", "MenuSetName", "MenuTitle", "PageDispModeId", "PageDispModeName", "InUse", "UpMenuName", "RoleNum", "IsDisp", "UpdDate", "UpdUserId", "Memo"};
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
 /// 常量:"RoleName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleName = "RoleName";    //角色名称

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
 /// 常量:"UpMenuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpMenuName = "UpMenuName";    //上级菜单名

 /// <summary>
 /// 常量:"RoleNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleNum = "RoleNum";    //角色数

 /// <summary>
 /// 常量:"IsDisp"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsDisp = "IsDisp";    //是否显示

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