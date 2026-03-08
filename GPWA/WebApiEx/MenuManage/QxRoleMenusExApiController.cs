
using com.taishsoft.common;
using Comm.WebApi;
using GeneralPlatform.BusinessLogic;
using GeneralPlatform.BusinessLogicEx;
using GeneralPlatform.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralPlatform.WebApi
{
    /// <summary>
    /// QxPrjMenusExApiController 的摘要说明
    /// (AutoGCLib.WA_SrvEx4CSharp:GeneCode)
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class QxRoleMenusExApiController : ControllerBase
    {
        [HttpPost("Plus2")]
        public ActionResult Plus2([FromBody] string value)
        {
            string strA = value;// 
                                //string strB = HttpContext.Current.Request.Form[0];
            int a = 11;
            int b = 22;
            var intCount = a + b;
            return Ok(new { errorId = 0, errorMsg = "", returnInt = intCount });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [HttpGet("Plus")]
        public ActionResult Plus(int a, int b)
        {
            //调用方法：~/api/MyCalc/Plus?a=2&b=3
            var intCount = a + b;
            return Ok(new { errorId = 0, errorMsg = "", returnInt = intCount });
        }
        [HttpGet("Minus")]
        public ActionResult Minus(int a, int b)
        {
            var intCount = a - b;
            return Ok(new { errorId = 0, errorMsg = "", returnInt = intCount });
        }

        [HttpGet("Multiply")]
        public ActionResult Multiply(int a, int b)
        {
            var intCount = a * b;
            return Ok(new { errorId = 0, errorMsg = "", returnInt = intCount });
        }

        [HttpGet("Divided")]
        public ActionResult Divided(int a, int b)
        {
            var intCount = a / b;
            return Ok(new { errorId = 0, errorMsg = "", returnInt = intCount });
        }


        [HttpPost("GetObjLstEx")]
        public ActionResult GetObjLstEx([FromBody] stuRoleMenuPara objRoleMenuPara)
        {
            try
            {
                string strFunctionName = clsStackTrace.GetCurrFunction();
                Dictionary<string, string> dictParam = objRoleMenuPara.GetDictParam();
                clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
                StringBuilder sbCondition = new StringBuilder();
                sbCondition.Append(" 1=1 ");
                if (string.IsNullOrEmpty(objRoleMenuPara.RoleId) == false)
                {
                    sbCondition.AppendFormat(" And {0} = '{1}' ", conQxRoleMenus.RoleId, objRoleMenuPara.RoleId);
                }
                if (bool.Parse(objRoleMenuPara.IsUpMenuId) == true)
                {
                    sbCondition.AppendFormat(" AND {0} in (Select {0} from {1} where {2} = '00000000') ",
                        conQxRoleMenus.MenuId, conQxPrjMenus._CurrTabName, conQxPrjMenus.UpMenuId);
                }
                else
                {
                    sbCondition.AppendFormat(" AND {0} not in (Select {0} From {1} Where {2} = '00000000') ",
                        conQxRoleMenus.MenuId, conQxPrjMenus._CurrTabName, conQxPrjMenus.UpMenuId);
                }
                sbCondition.AppendFormat(" AND QxPrjId = '{0}' ",
                    objRoleMenuPara.QxPrjId);
                if (string.IsNullOrEmpty(objRoleMenuPara.MenuSetId) == false)
                {
                    sbCondition.AppendFormat(" And {0} in (select {0} From {1} where {2}='{3}')",
                        conQxRoleMenus.MenuId, conQxPrjMenus._CurrTabName, conQxRoleMenus.MenuSetId, objRoleMenuPara.MenuSetId);
                }
                //sbCondition.Append(" ORDER BY OrderNum");
                sbCondition.Append("[exclude]or [/exclude]");

                clsPubVar_WebApi.objLog.WriteDebugLog(sbCondition.ToString());
                List<clsQxRoleMenusEN> objObjLst = clsQxRoleMenusBL.GetObjLst(sbCondition.ToString());

                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = objObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("根据角色Ids获取相关菜单出错：{0}.({1})",
                    objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);

                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        [HttpPost("GetObjLstByRoleIdsEx")]
        public ActionResult GetObjLstByRoleIdsEx([FromBody] stuRoleMenuByRoleIdsPara objRoleMenuByRoleIdsPara)
        {
            try
            {
                string strFunctionName = clsStackTrace.GetCurrFunction();
                Dictionary<string, string> dictParam = objRoleMenuByRoleIdsPara.GetDictParam();
                clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);

                StringBuilder sbCondition = new StringBuilder();
                sbCondition.Append(" 1=1 ");
                if (objRoleMenuByRoleIdsPara.RoleIdLst.Count > 0)
                {
                    sbCondition.AppendFormat(" And RoleId in ({0}) ",
                        clsArray.GetSqlInStrByArray(objRoleMenuByRoleIdsPara.RoleIdLst, true));
                }
                if (bool.Parse(objRoleMenuByRoleIdsPara.IsUpMenuId) == true)
                {
                    sbCondition.AppendFormat("  AND {0} in (Select {0} from {1} where {2} = '00000000') ",
                        conQxRoleMenus.MenuId, conQxPrjMenus._CurrTabName, conQxPrjMenus.UpMenuId);
                }
                else
                {
                    sbCondition.AppendFormat("  AND {0} not in (Select {0} From {1} Where {2} <> '00000000') ",
                        conQxRoleMenus.MenuId, conQxPrjMenus._CurrTabName, conQxPrjMenus.UpMenuId);
                }
                sbCondition.AppendFormat(" AND QxPrjId = '{0}' ",
                    objRoleMenuByRoleIdsPara.QxPrjId);
                if (string.IsNullOrEmpty(objRoleMenuByRoleIdsPara.MenuSetId) == false)
                {
                    sbCondition.AppendFormat(" And {0} in (select {0} From {1} where {2}='{3}')",
                        conQxRoleMenus.MenuId, conQxPrjMenus._CurrTabName, conQxRoleMenus.MenuSetId, objRoleMenuByRoleIdsPara.MenuSetId);
                }
                sbCondition.Append(" ORDER BY OrderNum");
                sbCondition.Append("[exclude]or [/exclude]");

                clsPubVar_WebApi.objLog.WriteDebugLog(sbCondition.ToString());
                List<clsQxRoleMenusEN> objObjLst = clsQxRoleMenusBL.GetObjLst(sbCondition.ToString());

                return Ok(new { errorId = 0, errorMsg = "", returnObjLst = objObjLst });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("根据角色Ids获取相关菜单出错：{0}.({1})",
                    objException.Message, clsStackTrace.GetCurrClassFunction());
                clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 为角色设置菜单
        /// 调用方法: Get /api/clsQxRoleMenusBLExApi/SetRoleMenu?strPrjId=value&strCmPrjId=value&strMenuSetId=value&strRoleId=value&strMenuId=value&strOpUserId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strPrjId">工程Id</param>
        /// <param name = "strCmPrjId">Cm工程Id</param>
        /// <param name = "strMenuSetId">菜单集Id</param>
        /// <param name = "strRoleId">角色Id</param>
        /// <param name = "strMenuId">菜单Id</param>
        /// <param name = "strOpUserId">操作用户Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("SetRoleMenu")]
        public ActionResult SetRoleMenu(string strPrjId, string strCmPrjId, string strMenuSetId, string strRoleId, string strMenuId, string strOpUserId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strPrjId", strPrjId);
            dictParam.Add("strCmPrjId", strCmPrjId);
            dictParam.Add("strMenuSetId", strMenuSetId);
            dictParam.Add("strRoleId", strRoleId);
            dictParam.Add("strMenuId", strMenuId);
            dictParam.Add("strOpUserId", strOpUserId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsQxRoleMenusBLEx.SetRoleMenu(strPrjId, strCmPrjId, strMenuSetId, strRoleId, strMenuId, strOpUserId);
                return Ok(new { errorId = 0, errorMsg = "", returnBool = varResult });
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("{0}.(from {1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                return Ok(new { errorId = 1, errorMsg = strMsg });
            }
        }


        /// <summary>
        /// 删除角色菜单
        /// 调用方法: Get /api/clsQxRoleMenusBLExApi/Delete?strRoleId=value&strMenuSetId=value&strMenuId=value
        /// (AGC.BusinessLogicEx.clsFunction4CodeBLEx:GeneCodeV2)
        /// </summary>
        /// <param name = "strRoleId">角色Id</param>
        /// <param name = "strMenuSetId">菜单集Id</param>
        /// <param name = "strMenuId">菜单Id</param>
        /// <returns>返回是否存在?</returns>
        [HttpGet("Delete")]
        public ActionResult Delete(string strRoleId, string strMenuSetId, string strMenuId)
        {
            string strFunctionName = clsStackTrace.GetCurrFunction();
            Dictionary<string, string> dictParam = new Dictionary<string, string>();
            dictParam.Add("strRoleId", strRoleId);
            dictParam.Add("strMenuSetId", strMenuSetId);
            dictParam.Add("strMenuId", strMenuId);
            clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);
            try
            {
                var varResult = clsQxRoleMenusBLEx.Delete(strRoleId, strMenuSetId, strMenuId);
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