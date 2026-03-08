
using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace GpWA.PubFun
{


    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ApiAuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        private readonly Serilog.ILogger _logger;

        public ApiAuthorizeAttribute()
        {
            _logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //var user = (User)context.HttpContext.Items["User"];
            //if (user == null)
            //{
            //    // not logged in
            //    context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
            //}

            try
            {
                var aaa = context.HttpContext.Items["auth"];
                var arrHead = context.HttpContext.Request.Headers["Authorization"];
                if (arrHead.Count == 0)
                {
                    context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
                    return;
                }
                //if (context.HttpContext.Request.Headers["Authorization"] == null)
                //{

                //}
                var token = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault().Split(" ")[1];
                //var handler = new JwtSecurityTokenHandler();
                //var jsonToken = handler.ReadToken(token);
                //var tokenS = handler.ReadToken(token) as JwtSecurityToken;


                //string[] authHeader = { "aa", "bb" };// from t in context.HttpContext.Items["auth"];//.Request.Headers where t.Key == "auth" select t.Value.FirstOrDefault();

                //var enumerable = authHeader as string[] ?? authHeader.ToArray();
                //string token = enumerable.FirstOrDefault();

                if (string.IsNullOrEmpty(token))
                {
                    context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
                }
                //return false;
                string secretKey = ConfigHelper.GetSectionValue("JwtSettings:SigningKey");// "matanzhang";//口令加密秘钥（应该写到配置文件中）
                string strUserName = GetUserNameFromToken(token, secretKey);
                // 输出调试信息

                Console.WriteLine("UserName:", strUserName);
                _logger.Information("UserName:", strUserName);
                
                byte[] key = Encoding.UTF8.GetBytes(secretKey);
                IJsonSerializer serializer = new JsonNetSerializer();
                IDateTimeProvider provider = new UtcDateTimeProvider();
                IJwtValidator validator = new JwtValidator(serializer, provider);
                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
                IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder, algorithm);
                //解密
                var authInfo = decoder.DecodeToObject<AuthInfo>(token, key, verify: true);
                if (authInfo != null)
                {
                    //判断口令过期时间
                    if (authInfo.Expires < DateTime.Now)
                    {
                        //return false;
                        context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };

                    }
                    //actionContext.RequestContext.RouteData.Values.Add("auth", authInfo);
                    //return true;
                }
                return;
            }
            catch (Exception e)
            {
                context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
            }
            //context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
            //            return false;
        }

        // 验证token并解析Payload部分
        public string GetUserNameFromToken(string token, string secretKey)
        {
            // 配置TokenValidationParameters
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero
            };

            // 验证token
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var claimsPrincipal = jwtTokenHandler.ValidateToken(token, tokenValidationParameters, out var validatedToken);

            // 从Payload部分获取用户名
            var userName = claimsPrincipal.FindFirst(ClaimTypes.Name)?.Value;

            return userName;
        }
    }
    //public class ApiAuthorizeAttribute : AuthorizeAttribute
    //{
    //    //protected override bool IsAuthorized(HttpActionContext actionContext)
    //    //{
    //    protected override bool IsAuthorized(HttpActionContext actionContext)
    //    {
    //        try
    //        {
    //            var authHeader = from t in actionContext.Request.Headers where t.Key == "auth" select t.Value.FirstOrDefault();
    //            var enumerable = authHeader as string[] ?? authHeader.ToArray();
    //            string token = enumerable.FirstOrDefault();
    //            if (string.IsNullOrEmpty(enumerable.FirstOrDefault())) return false;
    //            const string secretKey = "matanzhang";//口令加密秘钥（应该写到配置文件中）
    //            byte[] key = Encoding.UTF8.GetBytes(secretKey);
    //            IJsonSerializer serializer = new JsonNetSerializer();
    //            IDateTimeProvider provider = new UtcDateTimeProvider();
    //            IJwtValidator validator = new JwtValidator(serializer, provider);
    //            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
    //            IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
    //            IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder, algorithm);
    //            //解密
    //            var authInfo = decoder.DecodeToObject<AuthInfo>(token, key, verify: true);
    //            if (authInfo != null)
    //            {
    //                //判断口令过期时间
    //                if (authInfo.Expires < DateTime.Now)
    //                {
    //                    return false;
    //                }
    //                actionContext.RequestContext.RouteData.Values.Add("auth", authInfo);
    //                return true;
    //            }
    //        }
    //        catch (Exception e)
    //        {

    //        }
    //        return false;
    //    }
    //    /// <summary>
    //    /// 处理授权失败的请求
    //    /// </summary>
    //    /// <param name="actionContext"></param>
    //    protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
    //    {
    //        var erModel = new HttpResult()
    //        {
    //            Success = false,
    //            Message = "身份认证不正确！"
    //        };
    //        actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK, erModel, "application/json");
    //    }
    //}
}
