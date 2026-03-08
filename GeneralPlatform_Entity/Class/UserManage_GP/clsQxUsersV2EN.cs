
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsersV2EN
 表名:QxUsersV2(00140110)
 * 版本:2023.12.26.1(服务器:WIN-SRV103-116)
 日期:2023/12/28 19:01:18
 生成者:pyf
 生成服务器IP:
 工程名称:统一平台(0014)
 CM工程:统一平台Web(变量首字母不限定)-全部函数集
 相关数据库:103.116.76.183,9433GeneralPlatformTz
 PrjDataBaseId:0218
 模块中文名:用户管理(UserManage_GP)
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
 /// 表QxUsersV2的关键字(id)的类型定义. 以便检查类型以及操作方便.
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
public class K_id_QxUsersV2
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
public K_id_QxUsersV2(int intid)
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
 /// <returns>返回:[K_id_QxUsersV2]类型的对象</returns>
public static implicit operator K_id_QxUsersV2(int value)
{
return new K_id_QxUsersV2(value);
}
}
 /// <summary>
 /// 用户V2(QxUsersV2)
 /// (AutoGCLib.EntityLayer4CSharp:GeneCode)
 /// </summary>
[Serializable]
[DataContractAttribute]
public class clsQxUsersV2EN : clsEntityBase2
{
public static string _ConnectString = ""; //当前表名,所使用的连接,如果为空就使用系统默认的连接
public new const string _CurrTabName = "QxUsersV2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName = "id"; //当前表中的关键字名称,与该类相关的表中关键字名
public const string _WhereFormatBack = ""; //后台条件格式串
public const string _WhereFormat = ""; //前台条件格式串
protected const int mintAttributeCount = 23;
public static string[] AttributeName = new string[] {"CreateTime", "updateTime", "id", "DepartmentIdInt", "name", "UserName", "Password", "psalt", "nickName", "headImg", "Email", "phone", "remark", "status", "OpenId", "UpdUser", "IsArchive", "IdentityId", "StuTeacherId", "EffitiveBeginDate", "EffitiveEndDate", "UserId", "EffectiveDate"};

protected string mstrCreateTime;    //建立时间
protected string mstrupdateTime;    //修改时间
protected int mintid;    //id
protected int? mintDepartmentIdInt;    //部门Id
protected string mstrname;    //姓名
protected string mstrUserName;    //用户名
protected string mstrPassword;    //口令
protected string mstrpsalt;    //密码盐值
protected string mstrnickName;    //呢称
protected string mstrheadImg;    //头像
protected string mstrEmail;    //邮箱
protected string mstrphone;    //电话号码
protected string mstrremark;    //备注
protected int mintstatus;    //用户状态Id
protected string mstrOpenId;    //微信openid
protected string mstrUpdUser;    //修改用户
protected bool mbolIsArchive;    //是否存档
protected string mstrIdentityId;    //身份编号
protected string mstrStuTeacherId;    //学工号
protected string mstrEffitiveBeginDate;    //有效开始日期
protected string mstrEffitiveEndDate;    //有效结束日期
protected string mstrUserId;    //用户ID
protected string mstrEffectiveDate;    //有效日期

/// <summary>
/// 构造函数
 /// (AutoGCLib.clsGeneCodeBase:GenClassConstructor1)
/// </summary>
 public clsQxUsersV2EN()
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
public clsQxUsersV2EN(int intid)
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
if (strAttributeName  ==  conQxUsersV2.CreateTime)
{
return mstrCreateTime;
}
else if (strAttributeName  ==  conQxUsersV2.updateTime)
{
return mstrupdateTime;
}
else if (strAttributeName  ==  conQxUsersV2.id)
{
return mintid;
}
else if (strAttributeName  ==  conQxUsersV2.DepartmentIdInt)
{
return mintDepartmentIdInt;
}
else if (strAttributeName  ==  conQxUsersV2.name)
{
return mstrname;
}
else if (strAttributeName  ==  conQxUsersV2.UserName)
{
return mstrUserName;
}
else if (strAttributeName  ==  conQxUsersV2.Password)
{
return mstrPassword;
}
else if (strAttributeName  ==  conQxUsersV2.psalt)
{
return mstrpsalt;
}
else if (strAttributeName  ==  conQxUsersV2.nickName)
{
return mstrnickName;
}
else if (strAttributeName  ==  conQxUsersV2.headImg)
{
return mstrheadImg;
}
else if (strAttributeName  ==  conQxUsersV2.Email)
{
return mstrEmail;
}
else if (strAttributeName  ==  conQxUsersV2.phone)
{
return mstrphone;
}
else if (strAttributeName  ==  conQxUsersV2.remark)
{
return mstrremark;
}
else if (strAttributeName  ==  conQxUsersV2.status)
{
return mintstatus;
}
else if (strAttributeName  ==  conQxUsersV2.OpenId)
{
return mstrOpenId;
}
else if (strAttributeName  ==  conQxUsersV2.UpdUser)
{
return mstrUpdUser;
}
else if (strAttributeName  ==  conQxUsersV2.IsArchive)
{
return mbolIsArchive;
}
else if (strAttributeName  ==  conQxUsersV2.IdentityId)
{
return mstrIdentityId;
}
else if (strAttributeName  ==  conQxUsersV2.StuTeacherId)
{
return mstrStuTeacherId;
}
else if (strAttributeName  ==  conQxUsersV2.EffitiveBeginDate)
{
return mstrEffitiveBeginDate;
}
else if (strAttributeName  ==  conQxUsersV2.EffitiveEndDate)
{
return mstrEffitiveEndDate;
}
else if (strAttributeName  ==  conQxUsersV2.UserId)
{
return mstrUserId;
}
else if (strAttributeName  ==  conQxUsersV2.EffectiveDate)
{
return mstrEffectiveDate;
}
return null;
}
set
{
if (strAttributeName  ==  conQxUsersV2.CreateTime)
{
mstrCreateTime = value.ToString();
 AddUpdatedFld(conQxUsersV2.CreateTime);
}
else if (strAttributeName  ==  conQxUsersV2.updateTime)
{
mstrupdateTime = value.ToString();
 AddUpdatedFld(conQxUsersV2.updateTime);
}
else if (strAttributeName  ==  conQxUsersV2.id)
{
mintid = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUsersV2.id);
}
else if (strAttributeName  ==  conQxUsersV2.DepartmentIdInt)
{
mintDepartmentIdInt = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUsersV2.DepartmentIdInt);
}
else if (strAttributeName  ==  conQxUsersV2.name)
{
mstrname = value.ToString();
 AddUpdatedFld(conQxUsersV2.name);
}
else if (strAttributeName  ==  conQxUsersV2.UserName)
{
mstrUserName = value.ToString();
 AddUpdatedFld(conQxUsersV2.UserName);
}
else if (strAttributeName  ==  conQxUsersV2.Password)
{
mstrPassword = value.ToString();
 AddUpdatedFld(conQxUsersV2.Password);
}
else if (strAttributeName  ==  conQxUsersV2.psalt)
{
mstrpsalt = value.ToString();
 AddUpdatedFld(conQxUsersV2.psalt);
}
else if (strAttributeName  ==  conQxUsersV2.nickName)
{
mstrnickName = value.ToString();
 AddUpdatedFld(conQxUsersV2.nickName);
}
else if (strAttributeName  ==  conQxUsersV2.headImg)
{
mstrheadImg = value.ToString();
 AddUpdatedFld(conQxUsersV2.headImg);
}
else if (strAttributeName  ==  conQxUsersV2.Email)
{
mstrEmail = value.ToString();
 AddUpdatedFld(conQxUsersV2.Email);
}
else if (strAttributeName  ==  conQxUsersV2.phone)
{
mstrphone = value.ToString();
 AddUpdatedFld(conQxUsersV2.phone);
}
else if (strAttributeName  ==  conQxUsersV2.remark)
{
mstrremark = value.ToString();
 AddUpdatedFld(conQxUsersV2.remark);
}
else if (strAttributeName  ==  conQxUsersV2.status)
{
mintstatus = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUsersV2.status);
}
else if (strAttributeName  ==  conQxUsersV2.OpenId)
{
mstrOpenId = value.ToString();
 AddUpdatedFld(conQxUsersV2.OpenId);
}
else if (strAttributeName  ==  conQxUsersV2.UpdUser)
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxUsersV2.UpdUser);
}
else if (strAttributeName  ==  conQxUsersV2.IsArchive)
{
mbolIsArchive = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUsersV2.IsArchive);
}
else if (strAttributeName  ==  conQxUsersV2.IdentityId)
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(conQxUsersV2.IdentityId);
}
else if (strAttributeName  ==  conQxUsersV2.StuTeacherId)
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(conQxUsersV2.StuTeacherId);
}
else if (strAttributeName  ==  conQxUsersV2.EffitiveBeginDate)
{
mstrEffitiveBeginDate = value.ToString();
 AddUpdatedFld(conQxUsersV2.EffitiveBeginDate);
}
else if (strAttributeName  ==  conQxUsersV2.EffitiveEndDate)
{
mstrEffitiveEndDate = value.ToString();
 AddUpdatedFld(conQxUsersV2.EffitiveEndDate);
}
else if (strAttributeName  ==  conQxUsersV2.UserId)
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUsersV2.UserId);
}
else if (strAttributeName  ==  conQxUsersV2.EffectiveDate)
{
mstrEffectiveDate = value.ToString();
 AddUpdatedFld(conQxUsersV2.EffectiveDate);
}
}
}
public object this[int intIndex]
{
get
{
if (conQxUsersV2.CreateTime  ==  AttributeName[intIndex])
{
return mstrCreateTime;
}
else if (conQxUsersV2.updateTime  ==  AttributeName[intIndex])
{
return mstrupdateTime;
}
else if (conQxUsersV2.id  ==  AttributeName[intIndex])
{
return mintid;
}
else if (conQxUsersV2.DepartmentIdInt  ==  AttributeName[intIndex])
{
return mintDepartmentIdInt;
}
else if (conQxUsersV2.name  ==  AttributeName[intIndex])
{
return mstrname;
}
else if (conQxUsersV2.UserName  ==  AttributeName[intIndex])
{
return mstrUserName;
}
else if (conQxUsersV2.Password  ==  AttributeName[intIndex])
{
return mstrPassword;
}
else if (conQxUsersV2.psalt  ==  AttributeName[intIndex])
{
return mstrpsalt;
}
else if (conQxUsersV2.nickName  ==  AttributeName[intIndex])
{
return mstrnickName;
}
else if (conQxUsersV2.headImg  ==  AttributeName[intIndex])
{
return mstrheadImg;
}
else if (conQxUsersV2.Email  ==  AttributeName[intIndex])
{
return mstrEmail;
}
else if (conQxUsersV2.phone  ==  AttributeName[intIndex])
{
return mstrphone;
}
else if (conQxUsersV2.remark  ==  AttributeName[intIndex])
{
return mstrremark;
}
else if (conQxUsersV2.status  ==  AttributeName[intIndex])
{
return mintstatus;
}
else if (conQxUsersV2.OpenId  ==  AttributeName[intIndex])
{
return mstrOpenId;
}
else if (conQxUsersV2.UpdUser  ==  AttributeName[intIndex])
{
return mstrUpdUser;
}
else if (conQxUsersV2.IsArchive  ==  AttributeName[intIndex])
{
return mbolIsArchive;
}
else if (conQxUsersV2.IdentityId  ==  AttributeName[intIndex])
{
return mstrIdentityId;
}
else if (conQxUsersV2.StuTeacherId  ==  AttributeName[intIndex])
{
return mstrStuTeacherId;
}
else if (conQxUsersV2.EffitiveBeginDate  ==  AttributeName[intIndex])
{
return mstrEffitiveBeginDate;
}
else if (conQxUsersV2.EffitiveEndDate  ==  AttributeName[intIndex])
{
return mstrEffitiveEndDate;
}
else if (conQxUsersV2.UserId  ==  AttributeName[intIndex])
{
return mstrUserId;
}
else if (conQxUsersV2.EffectiveDate  ==  AttributeName[intIndex])
{
return mstrEffectiveDate;
}
return null;
}
set
{
if (conQxUsersV2.CreateTime  ==  AttributeName[intIndex])
{
mstrCreateTime = value.ToString();
 AddUpdatedFld(conQxUsersV2.CreateTime);
}
else if (conQxUsersV2.updateTime  ==  AttributeName[intIndex])
{
mstrupdateTime = value.ToString();
 AddUpdatedFld(conQxUsersV2.updateTime);
}
else if (conQxUsersV2.id  ==  AttributeName[intIndex])
{
mintid = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUsersV2.id);
}
else if (conQxUsersV2.DepartmentIdInt  ==  AttributeName[intIndex])
{
mintDepartmentIdInt = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUsersV2.DepartmentIdInt);
}
else if (conQxUsersV2.name  ==  AttributeName[intIndex])
{
mstrname = value.ToString();
 AddUpdatedFld(conQxUsersV2.name);
}
else if (conQxUsersV2.UserName  ==  AttributeName[intIndex])
{
mstrUserName = value.ToString();
 AddUpdatedFld(conQxUsersV2.UserName);
}
else if (conQxUsersV2.Password  ==  AttributeName[intIndex])
{
mstrPassword = value.ToString();
 AddUpdatedFld(conQxUsersV2.Password);
}
else if (conQxUsersV2.psalt  ==  AttributeName[intIndex])
{
mstrpsalt = value.ToString();
 AddUpdatedFld(conQxUsersV2.psalt);
}
else if (conQxUsersV2.nickName  ==  AttributeName[intIndex])
{
mstrnickName = value.ToString();
 AddUpdatedFld(conQxUsersV2.nickName);
}
else if (conQxUsersV2.headImg  ==  AttributeName[intIndex])
{
mstrheadImg = value.ToString();
 AddUpdatedFld(conQxUsersV2.headImg);
}
else if (conQxUsersV2.Email  ==  AttributeName[intIndex])
{
mstrEmail = value.ToString();
 AddUpdatedFld(conQxUsersV2.Email);
}
else if (conQxUsersV2.phone  ==  AttributeName[intIndex])
{
mstrphone = value.ToString();
 AddUpdatedFld(conQxUsersV2.phone);
}
else if (conQxUsersV2.remark  ==  AttributeName[intIndex])
{
mstrremark = value.ToString();
 AddUpdatedFld(conQxUsersV2.remark);
}
else if (conQxUsersV2.status  ==  AttributeName[intIndex])
{
mintstatus = TransNullToInt(value.ToString());
 AddUpdatedFld(conQxUsersV2.status);
}
else if (conQxUsersV2.OpenId  ==  AttributeName[intIndex])
{
mstrOpenId = value.ToString();
 AddUpdatedFld(conQxUsersV2.OpenId);
}
else if (conQxUsersV2.UpdUser  ==  AttributeName[intIndex])
{
mstrUpdUser = value.ToString();
 AddUpdatedFld(conQxUsersV2.UpdUser);
}
else if (conQxUsersV2.IsArchive  ==  AttributeName[intIndex])
{
mbolIsArchive = TransNullToBool(value.ToString());
 AddUpdatedFld(conQxUsersV2.IsArchive);
}
else if (conQxUsersV2.IdentityId  ==  AttributeName[intIndex])
{
mstrIdentityId = value.ToString();
 AddUpdatedFld(conQxUsersV2.IdentityId);
}
else if (conQxUsersV2.StuTeacherId  ==  AttributeName[intIndex])
{
mstrStuTeacherId = value.ToString();
 AddUpdatedFld(conQxUsersV2.StuTeacherId);
}
else if (conQxUsersV2.EffitiveBeginDate  ==  AttributeName[intIndex])
{
mstrEffitiveBeginDate = value.ToString();
 AddUpdatedFld(conQxUsersV2.EffitiveBeginDate);
}
else if (conQxUsersV2.EffitiveEndDate  ==  AttributeName[intIndex])
{
mstrEffitiveEndDate = value.ToString();
 AddUpdatedFld(conQxUsersV2.EffitiveEndDate);
}
else if (conQxUsersV2.UserId  ==  AttributeName[intIndex])
{
mstrUserId = value.ToString();
 AddUpdatedFld(conQxUsersV2.UserId);
}
else if (conQxUsersV2.EffectiveDate  ==  AttributeName[intIndex])
{
mstrEffectiveDate = value.ToString();
 AddUpdatedFld(conQxUsersV2.EffectiveDate);
}
}
}

/// <summary>
/// 建立时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string CreateTime
{
get
{
return mstrCreateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrCreateTime = value;
}
else
{
 mstrCreateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.CreateTime);
}
}
/// <summary>
/// 修改时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string updateTime
{
get
{
return mstrupdateTime;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrupdateTime = value;
}
else
{
 mstrupdateTime = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.updateTime);
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
 AddUpdatedFld(conQxUsersV2.id);
}
}
/// <summary>
/// 部门Id(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int? DepartmentIdInt
{
get
{
return mintDepartmentIdInt;
}
set
{
 mintDepartmentIdInt = value;
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.DepartmentIdInt);
}
}
/// <summary>
/// 姓名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string name
{
get
{
return mstrname;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrname = value;
}
else
{
 mstrname = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.name);
}
}
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UserName
{
get
{
return mstrUserName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUserName = value;
}
else
{
 mstrUserName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.UserName);
}
}
/// <summary>
/// 口令(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Password
{
get
{
return mstrPassword;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrPassword = value;
}
else
{
 mstrPassword = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.Password);
}
}
/// <summary>
/// 密码盐值(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string psalt
{
get
{
return mstrpsalt;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrpsalt = value;
}
else
{
 mstrpsalt = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.psalt);
}
}
/// <summary>
/// 呢称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string nickName
{
get
{
return mstrnickName;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrnickName = value;
}
else
{
 mstrnickName = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.nickName);
}
}
/// <summary>
/// 头像(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string headImg
{
get
{
return mstrheadImg;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrheadImg = value;
}
else
{
 mstrheadImg = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.headImg);
}
}
/// <summary>
/// 邮箱(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string Email
{
get
{
return mstrEmail;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEmail = value;
}
else
{
 mstrEmail = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.Email);
}
}
/// <summary>
/// 电话号码(说明:;字段类型:varchar;字段长度:15;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string phone
{
get
{
return mstrphone;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrphone = value;
}
else
{
 mstrphone = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.phone);
}
}
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string remark
{
get
{
return mstrremark;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrremark = value;
}
else
{
 mstrremark = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.remark);
}
}
/// <summary>
/// 用户状态Id(说明:;字段类型:int;字段长度:4;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public int status
{
get
{
return mintstatus;
}
set
{
 mintstatus = value;
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.status);
}
}
/// <summary>
/// 微信openid(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string OpenId
{
get
{
return mstrOpenId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrOpenId = value;
}
else
{
 mstrOpenId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.OpenId);
}
}
/// <summary>
/// 修改用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string UpdUser
{
get
{
return mstrUpdUser;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrUpdUser = value;
}
else
{
 mstrUpdUser = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.UpdUser);
}
}
/// <summary>
/// 是否存档(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public bool IsArchive
{
get
{
return mbolIsArchive;
}
set
{
 mbolIsArchive = value;
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.IsArchive);
}
}
/// <summary>
/// 身份编号(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string IdentityId
{
get
{
return mstrIdentityId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrIdentityId = value;
}
else
{
 mstrIdentityId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.IdentityId);
}
}
/// <summary>
/// 学工号(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string StuTeacherId
{
get
{
return mstrStuTeacherId;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrStuTeacherId = value;
}
else
{
 mstrStuTeacherId = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.StuTeacherId);
}
}
/// <summary>
/// 有效开始日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EffitiveBeginDate
{
get
{
return mstrEffitiveBeginDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEffitiveBeginDate = value;
}
else
{
 mstrEffitiveBeginDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.EffitiveBeginDate);
}
}
/// <summary>
/// 有效结束日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EffitiveEndDate
{
get
{
return mstrEffitiveEndDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEffitiveEndDate = value;
}
else
{
 mstrEffitiveEndDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.EffitiveEndDate);
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
 AddUpdatedFld(conQxUsersV2.UserId);
}
}
/// <summary>
/// 有效日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:ToStringV2)
/// </summary>
  [DataMember]//非常重要
 public string EffectiveDate
{
get
{
return mstrEffectiveDate;
}
set
{
if (value  ==  "")
{
mintErrNo = 1;
 mstrEffectiveDate = value;
}
else
{
 mstrEffectiveDate = value;
}
//记录修改过的字段
 AddUpdatedFld(conQxUsersV2.EffectiveDate);
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
  return mstrUserName;
 }
 }
}
 /// <summary>
 /// 用户V2(QxUsersV2)
 /// (AutoGCLib.TableFldConst4CSharp:GeneCode_This)
 /// </summary>
public static class conQxUsersV2
{
public const string _CurrTabName = "QxUsersV2"; //当前表名,与该类相关的表名
public const string _CurrTabKeyFldName_S = "id"; //当前表中的关键字名称,与该类相关的表中关键字名
public static string[] AttributeName = new string[] {"CreateTime", "updateTime", "id", "DepartmentIdInt", "name", "UserName", "Password", "psalt", "nickName", "headImg", "Email", "phone", "remark", "status", "OpenId", "UpdUser", "IsArchive", "IdentityId", "StuTeacherId", "EffitiveBeginDate", "EffitiveEndDate", "UserId", "EffectiveDate"};
//以下是属性变量


 /// <summary>
 /// 常量:"CreateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string CreateTime = "CreateTime";    //建立时间

 /// <summary>
 /// 常量:"updateTime"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string updateTime = "updateTime";    //修改时间

 /// <summary>
 /// 常量:"id"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string id = "id";    //id

 /// <summary>
 /// 常量:"DepartmentIdInt"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string DepartmentIdInt = "DepartmentIdInt";    //部门Id

 /// <summary>
 /// 常量:"name"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string name = "name";    //姓名

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserName = "UserName";    //用户名

 /// <summary>
 /// 常量:"Password"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Password = "Password";    //口令

 /// <summary>
 /// 常量:"psalt"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string psalt = "psalt";    //密码盐值

 /// <summary>
 /// 常量:"nickName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string nickName = "nickName";    //呢称

 /// <summary>
 /// 常量:"headImg"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string headImg = "headImg";    //头像

 /// <summary>
 /// 常量:"Email"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string Email = "Email";    //邮箱

 /// <summary>
 /// 常量:"phone"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string phone = "phone";    //电话号码

 /// <summary>
 /// 常量:"remark"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string remark = "remark";    //备注

 /// <summary>
 /// 常量:"status"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string status = "status";    //用户状态Id

 /// <summary>
 /// 常量:"OpenId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string OpenId = "OpenId";    //微信openid

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UpdUser = "UpdUser";    //修改用户

 /// <summary>
 /// 常量:"IsArchive"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IsArchive = "IsArchive";    //是否存档

 /// <summary>
 /// 常量:"IdentityId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string IdentityId = "IdentityId";    //身份编号

 /// <summary>
 /// 常量:"StuTeacherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string StuTeacherId = "StuTeacherId";    //学工号

 /// <summary>
 /// 常量:"EffitiveBeginDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EffitiveBeginDate = "EffitiveBeginDate";    //有效开始日期

 /// <summary>
 /// 常量:"EffitiveEndDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EffitiveEndDate = "EffitiveEndDate";    //有效结束日期

 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string UserId = "UserId";    //用户ID

 /// <summary>
 /// 常量:"EffectiveDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst4ConstLevel)
 /// </summary>
 public const string EffectiveDate = "EffectiveDate";    //有效日期
}

}