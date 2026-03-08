
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjMenusV2EN
 表名:QxPrjMenusV2(00140112)
 * 版本:2023.08.19.1(服务器:WIN-SRV103-116)
 日期:2023/08/22 16:29:09
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
 /// 表QxPrjMenusV2的关键字(id)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_id_QxPrjMenusV2
{
private int _value = 0;
/// <summary>
/// 关键字类型内面的值
/// </summary>
public int Value { get { return _value; }set { _value = value;} }
/// <summary>
/// 关键字类型构造函数
/// </summary>
/// <param name="intid">表关键字</param>
public K_id_QxPrjMenusV2(int intid)
{
if (IsValid(intid)) Value = intid;
else
{
Value = 0;
}
}
private static bool IsValid(int intid)
{
if (intid == 0) return false;
if (intid == 0) return false;
return true;
}
/// <summary>
/// 实现隐式类型转换,把类型:[{0}]隐式转换成:[{1}]
/// </summary>
/// <param name="value">原类型表关键字</param>
 /// <returns>返回:[K_id_QxPrjMenusV2]类型的对象</returns>
public static implicit operator K_id_QxPrjMenusV2(int value)
{
return new K_id_QxPrjMenusV2(value);
}
}
 /// <summary>
 /// 工程菜单V2(QxPrjMenusV2)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxPrjMenusV2EN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxPrjMenusV2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "id"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 32;
public static string[] AttributeName = new string[] {"createdAt", "updatedAt", "id", "parentMenuId", "MenuName", "router", "perms", "type", "icon", "OrderNum", "viewPath", "keepalive", "isShow", "isExt", "openMode", "QxPrjId", "UpdUserId", "Memo", "LinkFile", "UpdDate", "MenuControlName", "ApplicationTypeId", "MenuTitle", "PageDispModeId", "InUse", "qsParameters", "ImgFile", "TabId", "RoleId", "IsLeafNode", "MenuSetId", "MenuIdOld"};

protected string mstrcreatedAt;    //建立时间
protected string mstrupdatedAt;    //修改时间
protected int mintid;    //id
protected int? mintparentMenuId;    //上级菜单Id
protected string mstrMenuName;    //菜单名
protected string mstrrouter;    //链接文件
protected string mstrperms;    //链接文件
protected int minttype;    //排序号
protected string mstricon;    //链接文件
protected int mintOrderNum;    //排序号
protected string mstrviewPath;    //图像文件
protected bool mbolkeepalive;    //是否在用
protected bool mbolisShow;    //是否在用
protected bool mbolisExt;    //是否在用
protected int mintopenMode;    //应用程序类型ID
protected string mstrQxPrjId;    //项目Id
protected string mstrUpdUserId;    //修改用户Id
protected string mstrMemo;    //备注
protected string mstrLinkFile;    //链接文件
protected string mstrUpdDate;    //修改日期
protected string mstrMenuControlName;    //MenuControlName
protected int? mintApplicationTypeId;    //应用程序类型ID
protected string mstrMenuTitle;    //菜单标题
protected string mstrPageDispModeId;    //页面显示模式Id
protected bool mbolInUse;    //是否在用
protected string mstrqsParameters;    //qs参数
protected string mstrImgFile;    //图像文件
protected string mstrTabId;    //表ID
protected string mstrRoleId;    //角色Id
protected bool mbolIsLeafNode;    //是否叶子
protected string mstrMenuSetId;    //菜单集Id
protected string mstrMenuIdOld;    //MenuIdOld

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxPrjMenusV2EN()
 {
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("id");
 }

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor2)
/// </summary>
/// <param name = "intid">关键字:id</param>
public clsQxPrjMenusV2EN(int intid)
 {
 if (intid  ==  0)
 {
 throw new Exception("关键字不能为0!");
 }

this.mintid = intid;
 SetInit();
 mbolIsCheckProperty = false;
 lstKeyFldNames.Add("id");
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
if (strAttributeName  ==  conQxPrjMenusV2.createdAt)
{
return mstrcreatedAt;
}
else if (strAttributeName  ==  conQxPrjMenusV2.updatedAt)
{
return mstrupdatedAt;
}
else if (strAttributeName  ==  conQxPrjMenusV2.id)
{
return mintid;
}
else if (strAttributeName  ==  conQxPrjMenusV2.parentMenuId)
{
return mintparentMenuId;
}
else if (strAttributeName  ==  conQxPrjMenusV2.MenuName)
{
return mstrMenuName;
}
else if (strAttributeName  ==  conQxPrjMenusV2.router)
{
return mstrrouter;
}
else if (strAttributeName  ==  conQxPrjMenusV2.perms)
{
return mstrperms;
}
else if (strAttributeName  ==  conQxPrjMenusV2.type)
{
return minttype;
}
else if (strAttributeName  ==  conQxPrjMenusV2.icon)
{
return mstricon;
}
else if (strAttributeName  ==  conQxPrjMenusV2.OrderNum)
{
return mintOrderNum;
}
else if (strAttributeName  ==  conQxPrjMenusV2.viewPath)
{
return mstrviewPath;
}
else if (strAttributeName  ==  conQxPrjMenusV2.keepalive)
{
return mbolkeepalive;
}
else if (strAttributeName  ==  conQxPrjMenusV2.isShow)
{
return mbolisShow;
}
else if (strAttributeName  ==  conQxPrjMenusV2.isExt)
{
return mbolisExt;
}
else if (strAttributeName  ==  conQxPrjMenusV2.openMode)
{
return mintopenMode;
}
else if (strAttributeName  ==  conQxPrjMenusV2.QxPrjId)
{
return mstrQxPrjId;
}
else if (strAttributeName  ==  conQxPrjMenusV2.UpdUserId)
{
return mstrUpdUserId;
}
else if (strAttributeName  ==  conQxPrjMenusV2.Memo)
{
return mstrMemo;
}
else if (strAttributeName  ==  conQxPrjMenusV2.LinkFile)
{
return mstrLinkFile;
}
else if (strAttributeName  ==  conQxPrjMenusV2.UpdDate)
{
return mstrUpdDate;
}
else if (strAttributeName  ==  conQxPrjMenusV2.MenuControlName)
{
return mstrMenuControlName;
}
else if (strAttributeName  ==  conQxPrjMenusV2.ApplicationTypeId)
{
return mintApplicationTypeId;
}
else if (strAttributeName  ==  conQxPrjMenusV2.MenuTitle)
{
return mstrMenuTitle;
}
else if (strAttributeName  ==  conQxPrjMenusV2.PageDispModeId)
{
return mstrPageDispModeId;
}
else if (strAttributeName  ==  conQxPrjMenusV2.InUse)
{
return mbolInUse;
}
else if (strAttributeName  ==  conQxPrjMenusV2.qsParameters)
{
return mstrqsParameters;
}
else if (strAttributeName  ==  conQxPrjMenusV2.ImgFile)
{
return mstrImgFile;
}
else if (strAttributeName  ==  conQxPrjMenusV2.TabId)
{
return mstrTabId;
}
else if (strAttributeName  ==  conQxPrjMenusV2.RoleId)
{
return mstrRoleId;
}
else if (strAttributeName  ==  conQxPrjMenusV2.IsLeafNode)
{
return mbolIsLeafNode;
}
else if (strAttributeName  ==  conQxPrjMenusV2.MenuSetId)
{
return mstrMenuSetId;
}
else if (strAttributeName  ==  conQxPrjMenusV2.MenuIdOld)
{
return mstrMenuIdOld;
}
return null;
}
set
{
if (strAttributeName  ==  conQxPrjMenusV2.createdAt)
{
mstrcreatedAt = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.createdAt);
}
else if (strAttributeName  ==  conQxPrjMenusV2.updatedAt)
{
mstrupdatedAt = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.updatedAt);
}
else if (strAttributeName  ==  conQxPrjMenusV2.id)
{
mintid = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.id);
}
else if (strAttributeName  ==  conQxPrjMenusV2.parentMenuId)
{
mintparentMenuId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.parentMenuId);
}
else if (strAttributeName  ==  conQxPrjMenusV2.MenuName)
{
mstrMenuName = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.MenuName);
}
else if (strAttributeName  ==  conQxPrjMenusV2.router)
{
mstrrouter = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.router);
}
else if (strAttributeName  ==  conQxPrjMenusV2.perms)
{
mstrperms = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.perms);
}
else if (strAttributeName  ==  conQxPrjMenusV2.type)
{
minttype = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.type);
}
else if (strAttributeName  ==  conQxPrjMenusV2.icon)
{
mstricon = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.icon);
}
else if (strAttributeName  ==  conQxPrjMenusV2.OrderNum)
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.OrderNum);
}
else if (strAttributeName  ==  conQxPrjMenusV2.viewPath)
{
mstrviewPath = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.viewPath);
}
else if (strAttributeName  ==  conQxPrjMenusV2.keepalive)
{
mbolkeepalive = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.keepalive);
}
else if (strAttributeName  ==  conQxPrjMenusV2.isShow)
{
mbolisShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.isShow);
}
else if (strAttributeName  ==  conQxPrjMenusV2.isExt)
{
mbolisExt = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.isExt);
}
else if (strAttributeName  ==  conQxPrjMenusV2.openMode)
{
mintopenMode = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.openMode);
}
else if (strAttributeName  ==  conQxPrjMenusV2.QxPrjId)
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.QxPrjId);
}
else if (strAttributeName  ==  conQxPrjMenusV2.UpdUserId)
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.UpdUserId);
}
else if (strAttributeName  ==  conQxPrjMenusV2.Memo)
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.Memo);
}
else if (strAttributeName  ==  conQxPrjMenusV2.LinkFile)
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.LinkFile);
}
else if (strAttributeName  ==  conQxPrjMenusV2.UpdDate)
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.UpdDate);
}
else if (strAttributeName  ==  conQxPrjMenusV2.MenuControlName)
{
mstrMenuControlName = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.MenuControlName);
}
else if (strAttributeName  ==  conQxPrjMenusV2.ApplicationTypeId)
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.ApplicationTypeId);
}
else if (strAttributeName  ==  conQxPrjMenusV2.MenuTitle)
{
mstrMenuTitle = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.MenuTitle);
}
else if (strAttributeName  ==  conQxPrjMenusV2.PageDispModeId)
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.PageDispModeId);
}
else if (strAttributeName  ==  conQxPrjMenusV2.InUse)
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.InUse);
}
else if (strAttributeName  ==  conQxPrjMenusV2.qsParameters)
{
mstrqsParameters = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.qsParameters);
}
else if (strAttributeName  ==  conQxPrjMenusV2.ImgFile)
{
mstrImgFile = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.ImgFile);
}
else if (strAttributeName  ==  conQxPrjMenusV2.TabId)
{
mstrTabId = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.TabId);
}
else if (strAttributeName  ==  conQxPrjMenusV2.RoleId)
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.RoleId);
}
else if (strAttributeName  ==  conQxPrjMenusV2.IsLeafNode)
{
mbolIsLeafNode = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.IsLeafNode);
}
else if (strAttributeName  ==  conQxPrjMenusV2.MenuSetId)
{
mstrMenuSetId = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.MenuSetId);
}
else if (strAttributeName  ==  conQxPrjMenusV2.MenuIdOld)
{
mstrMenuIdOld = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.MenuIdOld);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxPrjMenusV2.createdAt  ==  AttributeName[intIndex])
{
return mstrcreatedAt;
}
else if (conQxPrjMenusV2.updatedAt  ==  AttributeName[intIndex])
{
return mstrupdatedAt;
}
else if (conQxPrjMenusV2.id  ==  AttributeName[intIndex])
{
return mintid;
}
else if (conQxPrjMenusV2.parentMenuId  ==  AttributeName[intIndex])
{
return mintparentMenuId;
}
else if (conQxPrjMenusV2.MenuName  ==  AttributeName[intIndex])
{
return mstrMenuName;
}
else if (conQxPrjMenusV2.router  ==  AttributeName[intIndex])
{
return mstrrouter;
}
else if (conQxPrjMenusV2.perms  ==  AttributeName[intIndex])
{
return mstrperms;
}
else if (conQxPrjMenusV2.type  ==  AttributeName[intIndex])
{
return minttype;
}
else if (conQxPrjMenusV2.icon  ==  AttributeName[intIndex])
{
return mstricon;
}
else if (conQxPrjMenusV2.OrderNum  ==  AttributeName[intIndex])
{
return mintOrderNum;
}
else if (conQxPrjMenusV2.viewPath  ==  AttributeName[intIndex])
{
return mstrviewPath;
}
else if (conQxPrjMenusV2.keepalive  ==  AttributeName[intIndex])
{
return mbolkeepalive;
}
else if (conQxPrjMenusV2.isShow  ==  AttributeName[intIndex])
{
return mbolisShow;
}
else if (conQxPrjMenusV2.isExt  ==  AttributeName[intIndex])
{
return mbolisExt;
}
else if (conQxPrjMenusV2.openMode  ==  AttributeName[intIndex])
{
return mintopenMode;
}
else if (conQxPrjMenusV2.QxPrjId  ==  AttributeName[intIndex])
{
return mstrQxPrjId;
}
else if (conQxPrjMenusV2.UpdUserId  ==  AttributeName[intIndex])
{
return mstrUpdUserId;
}
else if (conQxPrjMenusV2.Memo  ==  AttributeName[intIndex])
{
return mstrMemo;
}
else if (conQxPrjMenusV2.LinkFile  ==  AttributeName[intIndex])
{
return mstrLinkFile;
}
else if (conQxPrjMenusV2.UpdDate  ==  AttributeName[intIndex])
{
return mstrUpdDate;
}
else if (conQxPrjMenusV2.MenuControlName  ==  AttributeName[intIndex])
{
return mstrMenuControlName;
}
else if (conQxPrjMenusV2.ApplicationTypeId  ==  AttributeName[intIndex])
{
return mintApplicationTypeId;
}
else if (conQxPrjMenusV2.MenuTitle  ==  AttributeName[intIndex])
{
return mstrMenuTitle;
}
else if (conQxPrjMenusV2.PageDispModeId  ==  AttributeName[intIndex])
{
return mstrPageDispModeId;
}
else if (conQxPrjMenusV2.InUse  ==  AttributeName[intIndex])
{
return mbolInUse;
}
else if (conQxPrjMenusV2.qsParameters  ==  AttributeName[intIndex])
{
return mstrqsParameters;
}
else if (conQxPrjMenusV2.ImgFile  ==  AttributeName[intIndex])
{
return mstrImgFile;
}
else if (conQxPrjMenusV2.TabId  ==  AttributeName[intIndex])
{
return mstrTabId;
}
else if (conQxPrjMenusV2.RoleId  ==  AttributeName[intIndex])
{
return mstrRoleId;
}
else if (conQxPrjMenusV2.IsLeafNode  ==  AttributeName[intIndex])
{
return mbolIsLeafNode;
}
else if (conQxPrjMenusV2.MenuSetId  ==  AttributeName[intIndex])
{
return mstrMenuSetId;
}
else if (conQxPrjMenusV2.MenuIdOld  ==  AttributeName[intIndex])
{
return mstrMenuIdOld;
}
return null;
}
set
{
if (conQxPrjMenusV2.createdAt  ==  AttributeName[intIndex])
{
mstrcreatedAt = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.createdAt);
}
else if (conQxPrjMenusV2.updatedAt  ==  AttributeName[intIndex])
{
mstrupdatedAt = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.updatedAt);
}
else if (conQxPrjMenusV2.id  ==  AttributeName[intIndex])
{
mintid = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.id);
}
else if (conQxPrjMenusV2.parentMenuId  ==  AttributeName[intIndex])
{
mintparentMenuId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.parentMenuId);
}
else if (conQxPrjMenusV2.MenuName  ==  AttributeName[intIndex])
{
mstrMenuName = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.MenuName);
}
else if (conQxPrjMenusV2.router  ==  AttributeName[intIndex])
{
mstrrouter = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.router);
}
else if (conQxPrjMenusV2.perms  ==  AttributeName[intIndex])
{
mstrperms = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.perms);
}
else if (conQxPrjMenusV2.type  ==  AttributeName[intIndex])
{
minttype = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.type);
}
else if (conQxPrjMenusV2.icon  ==  AttributeName[intIndex])
{
mstricon = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.icon);
}
else if (conQxPrjMenusV2.OrderNum  ==  AttributeName[intIndex])
{
mintOrderNum = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.OrderNum);
}
else if (conQxPrjMenusV2.viewPath  ==  AttributeName[intIndex])
{
mstrviewPath = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.viewPath);
}
else if (conQxPrjMenusV2.keepalive  ==  AttributeName[intIndex])
{
mbolkeepalive = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.keepalive);
}
else if (conQxPrjMenusV2.isShow  ==  AttributeName[intIndex])
{
mbolisShow = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.isShow);
}
else if (conQxPrjMenusV2.isExt  ==  AttributeName[intIndex])
{
mbolisExt = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.isExt);
}
else if (conQxPrjMenusV2.openMode  ==  AttributeName[intIndex])
{
mintopenMode = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.openMode);
}
else if (conQxPrjMenusV2.QxPrjId  ==  AttributeName[intIndex])
{
mstrQxPrjId = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.QxPrjId);
}
else if (conQxPrjMenusV2.UpdUserId  ==  AttributeName[intIndex])
{
mstrUpdUserId = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.UpdUserId);
}
else if (conQxPrjMenusV2.Memo  ==  AttributeName[intIndex])
{
mstrMemo = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.Memo);
}
else if (conQxPrjMenusV2.LinkFile  ==  AttributeName[intIndex])
{
mstrLinkFile = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.LinkFile);
}
else if (conQxPrjMenusV2.UpdDate  ==  AttributeName[intIndex])
{
mstrUpdDate = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.UpdDate);
}
else if (conQxPrjMenusV2.MenuControlName  ==  AttributeName[intIndex])
{
mstrMenuControlName = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.MenuControlName);
}
else if (conQxPrjMenusV2.ApplicationTypeId  ==  AttributeName[intIndex])
{
mintApplicationTypeId = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.ApplicationTypeId);
}
else if (conQxPrjMenusV2.MenuTitle  ==  AttributeName[intIndex])
{
mstrMenuTitle = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.MenuTitle);
}
else if (conQxPrjMenusV2.PageDispModeId  ==  AttributeName[intIndex])
{
mstrPageDispModeId = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.PageDispModeId);
}
else if (conQxPrjMenusV2.InUse  ==  AttributeName[intIndex])
{
mbolInUse = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.InUse);
}
else if (conQxPrjMenusV2.qsParameters  ==  AttributeName[intIndex])
{
mstrqsParameters = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.qsParameters);
}
else if (conQxPrjMenusV2.ImgFile  ==  AttributeName[intIndex])
{
mstrImgFile = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.ImgFile);
}
else if (conQxPrjMenusV2.TabId  ==  AttributeName[intIndex])
{
mstrTabId = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.TabId);
}
else if (conQxPrjMenusV2.RoleId  ==  AttributeName[intIndex])
{
mstrRoleId = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.RoleId);
}
else if (conQxPrjMenusV2.IsLeafNode  ==  AttributeName[intIndex])
{
mbolIsLeafNode = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxPrjMenusV2.IsLeafNode);
}
else if (conQxPrjMenusV2.MenuSetId  ==  AttributeName[intIndex])
{
mstrMenuSetId = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.MenuSetId);
}
else if (conQxPrjMenusV2.MenuIdOld  ==  AttributeName[intIndex])
{
mstrMenuIdOld = value.ToString();
 AddUpdatedFld(conQxPrjMenusV2.MenuIdOld);
}
}
}

/// <summary>
/// 建立时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string createdAt
{
get
{
return mstrcreatedAt;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrcreatedAt = value;
}
else
{
 mstrcreatedAt = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjMenusV2.createdAt);
}
}
/// <summary>
/// 修改时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string updatedAt
{
get
{
return mstrupdatedAt;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrupdatedAt = value;
}
else
{
 mstrupdatedAt = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjMenusV2.updatedAt);
}
}
/// <summary>
/// id(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int id
{
get
{
return mintid;
}
set
{
 mintid = value;
//记录修改过的字段
 AddUpdatedFld(conQxPrjMenusV2.id);
}
}
/// <summary>
/// 上级菜单Id(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? parentMenuId
{
get
{
return mintparentMenuId;
}
set
{
 mintparentMenuId = value;
//记录修改过的字段
 AddUpdatedFld(conQxPrjMenusV2.parentMenuId);
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
 AddUpdatedFld(conQxPrjMenusV2.MenuName);
}
}
/// <summary>
/// 链接文件(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string router
{
get
{
return mstrrouter;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrrouter = value;
}
else
{
 mstrrouter = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjMenusV2.router);
}
}
/// <summary>
/// 链接文件(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string perms
{
get
{
return mstrperms;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrperms = value;
}
else
{
 mstrperms = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjMenusV2.perms);
}
}
/// <summary>
/// 排序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int type
{
get
{
return minttype;
}
set
{
 minttype = value;
//记录修改过的字段
 AddUpdatedFld(conQxPrjMenusV2.type);
}
}
/// <summary>
/// 链接文件(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string icon
{
get
{
return mstricon;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstricon = value;
}
else
{
 mstricon = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjMenusV2.icon);
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
 AddUpdatedFld(conQxPrjMenusV2.OrderNum);
}
}
/// <summary>
/// 图像文件(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string viewPath
{
get
{
return mstrviewPath;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrviewPath = value;
}
else
{
 mstrviewPath = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjMenusV2.viewPath);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool keepalive
{
get
{
return mbolkeepalive;
}
set
{
 mbolkeepalive = value;
//记录修改过的字段
 AddUpdatedFld(conQxPrjMenusV2.keepalive);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool isShow
{
get
{
return mbolisShow;
}
set
{
 mbolisShow = value;
//记录修改过的字段
 AddUpdatedFld(conQxPrjMenusV2.isShow);
}
}
/// <summary>
/// 是否在用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool isExt
{
get
{
return mbolisExt;
}
set
{
 mbolisExt = value;
//记录修改过的字段
 AddUpdatedFld(conQxPrjMenusV2.isExt);
}
}
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int openMode
{
get
{
return mintopenMode;
}
set
{
 mintopenMode = value;
//记录修改过的字段
 AddUpdatedFld(conQxPrjMenusV2.openMode);
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
 AddUpdatedFld(conQxPrjMenusV2.QxPrjId);
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
 AddUpdatedFld(conQxPrjMenusV2.UpdUserId);
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
 AddUpdatedFld(conQxPrjMenusV2.Memo);
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
 AddUpdatedFld(conQxPrjMenusV2.LinkFile);
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
 AddUpdatedFld(conQxPrjMenusV2.UpdDate);
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
 AddUpdatedFld(conQxPrjMenusV2.MenuControlName);
}
}
/// <summary>
/// 应用程序类型ID(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? ApplicationTypeId
{
get
{
return mintApplicationTypeId;
}
set
{
 mintApplicationTypeId = value;
//记录修改过的字段
 AddUpdatedFld(conQxPrjMenusV2.ApplicationTypeId);
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
 AddUpdatedFld(conQxPrjMenusV2.MenuTitle);
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
 AddUpdatedFld(conQxPrjMenusV2.PageDispModeId);
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
 AddUpdatedFld(conQxPrjMenusV2.InUse);
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
 AddUpdatedFld(conQxPrjMenusV2.qsParameters);
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
 AddUpdatedFld(conQxPrjMenusV2.ImgFile);
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
 AddUpdatedFld(conQxPrjMenusV2.TabId);
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
 AddUpdatedFld(conQxPrjMenusV2.RoleId);
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
 AddUpdatedFld(conQxPrjMenusV2.IsLeafNode);
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
 AddUpdatedFld(conQxPrjMenusV2.MenuSetId);
}
}
/// <summary>
/// MenuIdOld(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string MenuIdOld
{
get
{
return mstrMenuIdOld;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrMenuIdOld = value;
}
else
{
 mstrMenuIdOld = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxPrjMenusV2.MenuIdOld);
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
  return mintid.ToString();
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
 /// 工程菜单V2(QxPrjMenusV2)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxPrjMenusV2
{
public const string _CurrTabName = "QxPrjMenusV2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "id"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"createdAt", "updatedAt", "id", "parentMenuId", "MenuName", "router", "perms", "type", "icon", "OrderNum", "viewPath", "keepalive", "isShow", "isExt", "openMode", "QxPrjId", "UpdUserId", "Memo", "LinkFile", "UpdDate", "MenuControlName", "ApplicationTypeId", "MenuTitle", "PageDispModeId", "InUse", "qsParameters", "ImgFile", "TabId", "RoleId", "IsLeafNode", "MenuSetId", "MenuIdOld"};
//以下是属性变量


 /// <summary>
 /// 常量:"createdAt"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string createdAt = "createdAt";    //建立时间

 /// <summary>
 /// 常量:"updatedAt"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string updatedAt = "updatedAt";    //修改时间

 /// <summary>
 /// 常量:"id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string id = "id";    //id

 /// <summary>
 /// 常量:"parentMenuId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string parentMenuId = "parentMenuId";    //上级菜单Id

 /// <summary>
 /// 常量:"MenuName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuName = "MenuName";    //菜单名

 /// <summary>
 /// 常量:"router"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string router = "router";    //链接文件

 /// <summary>
 /// 常量:"perms"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string perms = "perms";    //链接文件

 /// <summary>
 /// 常量:"type"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string type = "type";    //排序号

 /// <summary>
 /// 常量:"icon"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string icon = "icon";    //链接文件

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OrderNum = "OrderNum";    //排序号

 /// <summary>
 /// 常量:"viewPath"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string viewPath = "viewPath";    //图像文件

 /// <summary>
 /// 常量:"keepalive"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string keepalive = "keepalive";    //是否在用

 /// <summary>
 /// 常量:"isShow"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string isShow = "isShow";    //是否在用

 /// <summary>
 /// 常量:"isExt"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string isExt = "isExt";    //是否在用

 /// <summary>
 /// 常量:"openMode"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string openMode = "openMode";    //应用程序类型ID

 /// <summary>
 /// 常量:"QxPrjId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string QxPrjId = "QxPrjId";    //项目Id

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
 /// 常量:"LinkFile"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string LinkFile = "LinkFile";    //链接文件

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdDate = "UpdDate";    //修改日期

 /// <summary>
 /// 常量:"MenuControlName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuControlName = "MenuControlName";    //MenuControlName

 /// <summary>
 /// 常量:"ApplicationTypeId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string ApplicationTypeId = "ApplicationTypeId";    //应用程序类型ID

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
 /// 常量:"TabId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string TabId = "TabId";    //表ID

 /// <summary>
 /// 常量:"RoleId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string RoleId = "RoleId";    //角色Id

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
 /// 常量:"MenuIdOld"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string MenuIdOld = "MenuIdOld";    //MenuIdOld
}

}