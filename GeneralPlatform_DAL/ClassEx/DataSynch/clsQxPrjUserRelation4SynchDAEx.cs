
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxPrjUserRelation4SynchDAEx
 表名:QxPrjUserRelation4Synch(00140093)
 生成代码版本:2019.03.21.1
 生成日期:2019/03/21 17:08:10
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
 /// 工程用户关系4同步(QxPrjUserRelation4Synch)
 /// (AutoGCLib.DALExCode4CSharp:GeneCode)
 /// </summary>
public class clsQxPrjUserRelation4SynchDAEx : clsQxPrjUserRelation4SynchDA
{
        //以下是属性变量

        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
        /// </summary>
        /// <param name = "objQxPrjUserRelation4SynchENS">源对象</param>
        /// <param name = "objQxPrjUserRelation4SynchENT">目标对象</param>
        public void CopyTo(clsQxPrjUserRelationEN objQxPrjUserRelation4SynchENS, clsQxPrjUserRelation4SynchEN objQxPrjUserRelation4SynchENT)
        {
            objQxPrjUserRelation4SynchENT.mId = objQxPrjUserRelation4SynchENS.mId; //流水号
            //objQxPrjUserRelation4SynchENT.IpAddress = objQxPrjUserRelation4SynchENS.IpAddress; //IP地址
            objQxPrjUserRelation4SynchENT.QxPrjId = objQxPrjUserRelation4SynchENS.QxPrjId; //项目Id
            objQxPrjUserRelation4SynchENT.UserId = objQxPrjUserRelation4SynchENS.UserId; //用户ID
            objQxPrjUserRelation4SynchENT.UpdDate = objQxPrjUserRelation4SynchENS.UpdDate; //修改日期
            objQxPrjUserRelation4SynchENT.UpdUserId = objQxPrjUserRelation4SynchENS.UpdUser; //修改用户Id
            objQxPrjUserRelation4SynchENT.Memo = objQxPrjUserRelation4SynchENS.Memo; //备注
        }
    }
}