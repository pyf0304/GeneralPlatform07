
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUserRoleRelation4SynchDAEx
 表名:QxUserRoleRelation4Synch(00140092)
 生成代码版本:2019.03.21.1
 生成日期:2019/03/21 17:08:04
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
 /// 用户角色关系4同步(QxUserRoleRelation4Synch)
 /// (AutoGCLib.DALExCode4CSharp:GeneCode)
 /// </summary>
public class clsQxUserRoleRelation4SynchDAEx : clsQxUserRoleRelation4SynchDA
{
        //以下是属性变量

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
        /// </summary>
        /// <param name = "objQxUserRoleRelation4SynchENS">源对象</param>
        /// <param name = "objQxUserRoleRelation4SynchENT">目标对象</param>
        public void CopyTo(clsQxUserRoleRelationEN objQxUserRoleRelation4SynchENS, clsQxUserRoleRelation4SynchEN objQxUserRoleRelation4SynchENT)
        {
            objQxUserRoleRelation4SynchENT.mId = objQxUserRoleRelation4SynchENS.mId; //流水号
            //objQxUserRoleRelation4SynchENT.IpAddress = objQxUserRoleRelation4SynchENS.IpAddress; //IP地址
            objQxUserRoleRelation4SynchENT.UserId = objQxUserRoleRelation4SynchENS.UserId; //用户ID
            objQxUserRoleRelation4SynchENT.RoleId = objQxUserRoleRelation4SynchENS.RoleId; //角色Id
            objQxUserRoleRelation4SynchENT.QxPrjId = objQxUserRoleRelation4SynchENS.QxPrjId; //项目Id
            objQxUserRoleRelation4SynchENT.UpdDate = objQxUserRoleRelation4SynchENS.UpdDate; //修改日期
            objQxUserRoleRelation4SynchENT.UpdUser = objQxUserRoleRelation4SynchENS.UpdUser; //修改用户Id
            objQxUserRoleRelation4SynchENT.Memo = objQxUserRoleRelation4SynchENS.Memo; //备注
        }
    }
}