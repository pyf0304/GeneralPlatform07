
/*-- -- -- -- -- -- -- -- -- -- --
类名:QxRolePotenceRelaExApiController
表名:QxRolePotenceRela(00140123)
* 版本:2024.01.20.1(服务器:WIN-SRV103-116)
日期:2024/01/20 23:14:16
生成者:pyf
生成服务器IP:
工程名称:统一平台(0014)
CM工程:统一平台Web(变量首字母不限定)-全部函数集
相关数据库:103.116.76.183,9433GeneralPlatformTz
PrjDataBaseId:0218
模块中文名:权限管理(PotenceMan)
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
    /// QxRolePotenceRelaExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class QxRolePotenceRelaExApiController : ControllerBase
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public QxRolePotenceRelaExApiController()
        {
        }

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改,不存在就添加
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_EditRecordEx)
        /// </summary>
        /// <param name = "objQxRolePotenceRela">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        [HttpPost("EditRecordEx")]
        public ActionResult EditRecordEx([FromBody] clsQxRolePotenceRelaEN objQxRolePotenceRela)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new();
            string strQxRolePotenceRelaJSONObj = clsJSON.GetJsonFromObj(objQxRolePotenceRela);
            dictParam.Add("strQxRolePotenceRelaJSONObj", strQxRolePotenceRelaJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            objQxRolePotenceRela._IsCheckProperty = true;
            try
            {
                bool bolResult = true;//如果要使用,解除注释---- objQxRolePotenceRela.EditRecordEx();
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
        /// 删除角色权限
        /// 调用方法: Get /api/clsQxRolePotenceRelaBLExApi/Delete?strRoleId=value&strPotenceId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strRoleId">角色Id</param>
        /// <param name = "strPotenceId">权限</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("Delete")]
        public ActionResult Delete(string strRoleId, string strPotenceId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strRoleId", strRoleId);
            dictParam.Add("strPotenceId", strPotenceId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsQxRolePotenceRelaBLEx.Delete(strRoleId, strPotenceId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }

        /// <summary>
        /// 为角色设置权限
        /// 调用方法: Get /api/clsQxRolePotenceRelaBLExApi/SetRolePotence?strPrjId=value&strRoleId=value&strPotenceId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strRoleId">角色Id</param>
        /// <param name = "strPotenceId">权限</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("SetRolePotence")]
        public ActionResult SetRolePotence(string strPrjId, string strRoleId, string strPotenceId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strRoleId", strRoleId);
            dictParam.Add("strPotenceId", strPotenceId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsQxRolePotenceRelaBLEx.SetRolePotence(strPrjId, strRoleId, strPotenceId, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }
    }
}