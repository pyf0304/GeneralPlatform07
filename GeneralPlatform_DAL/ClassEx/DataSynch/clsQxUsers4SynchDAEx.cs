
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsers4SynchDAEx
 表名:QxUsers4Synch(00140089)
 生成代码版本:2019.03.20.1
 生成日期:2019/03/20 18:19:05
 生成者:
 生成服务器IP:101.251.68.133
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理
 模块英文名:UserManage
 框架-层名:数据处理扩展层(DALExCode)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 */
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.commexception;
using com.taishsoft.commdb;

using GeneralPlatform.Entity;

namespace GeneralPlatform.DAL
{
 /// <summary>
 /// 用户4同步(QxUsers4Synch)
 /// (AutoGCLib.DALExCode4CSharp:GeneCode)
 /// </summary>
public class clsQxUsers4SynchDAEx : clsQxUsers4SynchDA
{

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.DALExCode4CSharp:Gen_DAEx_ClassConstructor1)
        /// </summary>
        public clsQxUsers4SynchDAEx()
        {
        }

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
        /// </summary>
        /// <param name = "objQxUsers4SynchENS">源对象</param>
        /// <param name = "objQxUsers4SynchENT">目标对象</param>
        public void CopyTo(clsQxUsersEN objQxUsers4SynchENS, clsQxUsers4SynchEN objQxUsers4SynchENT)
        {
            //objQxUsers4SynchENT.mId = objQxUsers4SynchENS.mId; //流水号
            //objQxUsers4SynchENT.IpAddress = objQxUsers4SynchENS.IpAddress; //IP地址
            objQxUsers4SynchENT.UserId = objQxUsers4SynchENS.UserId; //用户ID
            objQxUsers4SynchENT.UserName = objQxUsers4SynchENS.UserName; //用户名
            objQxUsers4SynchENT.UserStateId = objQxUsers4SynchENS.UserStateId; //用户状态Id
            objQxUsers4SynchENT.OpenId = objQxUsers4SynchENS.OpenId; //微信OpenId
            objQxUsers4SynchENT.IdentityId = objQxUsers4SynchENS.IdentityId; //身份编号
            objQxUsers4SynchENT.StuTeacherId = objQxUsers4SynchENS.StuTeacherId; //学工号
            objQxUsers4SynchENT.Password = objQxUsers4SynchENS.Password; //口令
            objQxUsers4SynchENT.PhoneNumber = objQxUsers4SynchENS.PhoneNumber; //电话号码
            objQxUsers4SynchENT.DepartmentId = objQxUsers4SynchENS.DepartmentId; //部门Id
            objQxUsers4SynchENT.IdXzCollege = objQxUsers4SynchENS.IdXzCollege; //学院流水号
            //objQxUsers4SynchENT.EffectiveDate = objQxUsers4SynchENS.EffectiveDate; //有效日期
            objQxUsers4SynchENT.EffitiveBeginDate = objQxUsers4SynchENS.EffitiveBeginDate; //有效开始日期
            objQxUsers4SynchENT.EffitiveEndDate = objQxUsers4SynchENS.EffitiveEndDate; //有效结束日期
            objQxUsers4SynchENT.Email = objQxUsers4SynchENS.Email; //邮箱
            objQxUsers4SynchENT.IsArchive = objQxUsers4SynchENS.IsArchive; //是否存档
            objQxUsers4SynchENT.UpdDate = objQxUsers4SynchENS.UpdDate; //修改日期
            objQxUsers4SynchENT.UpdUser = objQxUsers4SynchENS.UpdUser; //修改用户
            objQxUsers4SynchENT.Memo = objQxUsers4SynchENS.Memo; //备注
        }


        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
        /// </summary>
        /// <param name = "objQxUsers4SynchENS">源对象</param>
        /// <param name = "objQxUsers4SynchENT">目标对象</param>
        public void CopyTo(clsQxUsers4SynchEN objQxUsers4SynchENS, clsQxUsersEN  objQxUsers4SynchENT)
        {
            //objQxUsers4SynchENT.mId = objQxUsers4SynchENS.mId; //流水号
            //objQxUsers4SynchENT.IpAddress = objQxUsers4SynchENS.IpAddress; //IP地址
            objQxUsers4SynchENT.UserId = objQxUsers4SynchENS.UserId; //用户ID
            objQxUsers4SynchENT.UserName = objQxUsers4SynchENS.UserName; //用户名
            objQxUsers4SynchENT.UserStateId = objQxUsers4SynchENS.UserStateId; //用户状态Id
            objQxUsers4SynchENT.OpenId = objQxUsers4SynchENS.OpenId; //微信OpenId
            objQxUsers4SynchENT.IdentityId = objQxUsers4SynchENS.IdentityId; //身份编号
            objQxUsers4SynchENT.StuTeacherId = objQxUsers4SynchENS.StuTeacherId; //学工号
            objQxUsers4SynchENT.Password = objQxUsers4SynchENS.Password; //口令
            objQxUsers4SynchENT.PhoneNumber = objQxUsers4SynchENS.PhoneNumber; //电话号码
            objQxUsers4SynchENT.DepartmentId = objQxUsers4SynchENS.DepartmentId; //部门Id
            objQxUsers4SynchENT.IdXzCollege = objQxUsers4SynchENS.IdXzCollege; //学院流水号
            //objQxUsers4SynchENT.EffectiveDate = objQxUsers4SynchENS.EffectiveDate; //有效日期
            objQxUsers4SynchENT.EffitiveBeginDate = objQxUsers4SynchENS.EffitiveBeginDate; //有效开始日期
            objQxUsers4SynchENT.EffitiveEndDate = objQxUsers4SynchENS.EffitiveEndDate; //有效结束日期
            objQxUsers4SynchENT.Email = objQxUsers4SynchENS.Email; //邮箱
            objQxUsers4SynchENT.IsArchive = objQxUsers4SynchENS.IsArchive; //是否存档
            objQxUsers4SynchENT.UpdDate = objQxUsers4SynchENS.UpdDate; //修改日期
            objQxUsers4SynchENT.UpdUser = objQxUsers4SynchENS.UpdUser; //修改用户
            objQxUsers4SynchENT.Memo = objQxUsers4SynchENS.Memo; //备注
        }
    }
}