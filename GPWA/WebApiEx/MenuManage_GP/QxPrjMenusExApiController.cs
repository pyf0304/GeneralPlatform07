
/*-- -- -- -- -- -- -- -- -- -- --
类名:QxPrjMenusExApiController
表名:QxPrjMenus(00140004)
* 版本:2024.02.19.1(服务器:WIN-SRV103-116)
日期:2024/02/26 23:56:02
生成者:pyf
生成服务器IP:
工程名称:统一平台(0014)
CM工程:统一平台Web(变量首字母不限定)-全部函数集
相关数据库:103.116.76.183,9433GeneralPlatformTz
PrjDataBaseId:0218
模块中文名:菜单管理(MenuManage_GP)
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
    /// QxPrjMenusExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class QxPrjMenusExApiController : ControllerBase
    {

        /// <summary>
        /// 构造函数
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_ClassConstructor1)
        /// </summary>
        public QxPrjMenusExApiController()
        {
        }

        /// <summary>
        /// 编辑记录存盘到数据表中。如果存在相关记录就修改,不存在就添加
        /// (AutoGCLib.WA_SrvEx4CSharp:Gen_WAEx_EditRecordEx)
        /// </summary>
        /// <param name = "objQxPrjMenus">需要修改的实体对象</param>
        /// <returns>修改是否成功？</returns>
        [HttpPost("EditRecordEx")]
        public ActionResult EditRecordEx([FromBody] clsQxPrjMenusEN objQxPrjMenus)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new();
            string strQxPrjMenusJSONObj = clsJSON.GetJsonFromObj(objQxPrjMenus);
            dictParam.Add("strQxPrjMenusJSONObj", strQxPrjMenusJSONObj);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            objQxPrjMenus._IsCheckProperty = true;
            try
            {
                bool bolResult = true;//如果要使用,解除注释---- objQxPrjMenus.EditRecordEx();
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
        /// 清洗数据
        /// 调用方法: Get /api/clsQxPrjMenusBLExApi/DataCleaning?strPrjId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("DataCleaning")]
        public ActionResult DataCleaning(string strPrjId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsQxPrjMenusBLEx.DataCleaning(strPrjId);
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