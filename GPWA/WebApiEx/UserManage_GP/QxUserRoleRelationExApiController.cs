
/*-- -- -- -- -- -- -- -- -- -- --
类名:QxUserRoleRelationExApiController
表名:QxUserRoleRelation(00140013)
* 版本:2023.12.07.1(服务器:WIN-SRV103-116)
日期:2023/12/16 17:21:28
生成者:pyf
生成服务器IP:
工程名称:统一平台(0014)
CM工程:统一平台Web(变量首字母不限定)-全部函数集
相关数据库:103.116.76.183,9433GeneralPlatformTz
PrjDataBaseId:0218
模块中文名:用户管理(UserManage_GP)
框架-层名:WA_服务扩展层(CS)(WA_SrvEx)
编程语言:CSharp
注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
       2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
== == == == == == == == == == == == 
**/
using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using com.taishsoft.json;
using GeneralPlatform.Entity;
using GeneralPlatform.BusinessLogicEx;

using com.taishsoft.common;
using com.taishsoft.datetime;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json.Linq;
using Comm.WebApi;

namespace GeneralPlatform.WebApi
{
    /// <summary>
    /// QxUserRoleRelationExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class QxUserRoleRelationExApiController : ControllerBase
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public QxUserRoleRelationExApiController()
        {
        }

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改,不存在就添加
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_EditRecordEx)
        /// </summary>
        /// <param name = "objQxUserRoleRelation">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        [HttpPost("EditRecordEx")]
        public ActionResult EditRecordEx([FromBody] clsQxUserRoleRelationEN objQxUserRoleRelation)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new();
            string strQxUserRoleRelationJSONObj = clsJSON.GetJsonFromObj(objQxUserRoleRelation);
            dictParam.Add("strQxUserRoleRelationJSONObj", strQxUserRoleRelationJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            objQxUserRoleRelation._IsCheckProperty = true;
            try
            {
                bool bolResult = true;//如果要使用,解除注释---- objQxUserRoleRelation.EditRecordEx();
                return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 为用户设置角色
        /// 调用方法: Get /api/clsQxUserRoleRelationBLExApi/AddRecord?strUserId=value&strRoleId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strRoleId">角色Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("AddRecord")]
        public ActionResult AddRecord(string strUserId, string strRoleId, string strOpUser)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("strRoleId", strRoleId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsQxUserRoleRelationBLEx.AddRecord(strUserId, strRoleId, strOpUser);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 为用户删除角色
        /// 调用方法: Get /api/clsQxUserRoleRelationBLExApi/DelRecord?strUserId=value&strRoleId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strUserId">用户Id</param>
        /// <param name = "strRoleId">角色Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("DelRecord")]
        public ActionResult DelRecord(string strUserId, string strRoleId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strUserId", strUserId);
            dictParam.Add("strRoleId", strRoleId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsQxUserRoleRelationBLEx.DelRecord(strUserId, strRoleId);
                return Ok(new { errorId = 0, errorMsg = "", returnInt = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
    }
}