
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsQxUserRoleRelationENEx
表名:QxUserRoleRelation(00140013)
生成代码版本:2019.03.08.1
生成日期:2019/03/08 16:30:34
生成者:
生成服务器IP:101.251.68.133
工程名称:统一平台
工程ID:0014
相关数据库:101.251.68.133,9433MSEduSys
PrjDataBaseId:0199
模块中文名:用户管理
模块英文名:UserManage
框架-层名:实体扩展层(EntityLayerEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
*/
using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;
using com.taishsoft.datetime;

namespace GeneralPlatform.Entity
{
    /// <summary>
    /// 用户角色关系(QxUserRoleRelation)
    /// (AutoGCLib.EntityLayerEx4CSharp:GeneCode)
    /// </summary>
    [Serializable]
    public class clsQxUserRoleRelationENEx : clsQxUserRoleRelationEN
    {
        public string UserName { get; set; }
        public string DepartmentName { get; set; }
        public string UserStateName { get; set; }
        public string IdentityDesc { get; set; }
        public string RoleName { get; set; }
        public string PrjName { get; set; }


    }
}