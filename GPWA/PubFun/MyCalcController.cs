
using GpWA.PubFun;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WebApi2.Controllers
{
    public class myObject
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string JsonStr { get; set; }


    }
    public class myObject2
    {
        public string AAA { get; set; }
        public string BBB { get; set; }


    }
    [ApiController]
    [Route("[controller]")]
    public class MyCalcApiController : ControllerBase
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
       
        [HttpGet("Plus")]
        public ActionResult Plus(int a, int b)
        {
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
            return Ok(new { errorId = 0, errorMsg = "", returnFloat = intCount });
        }

        [HttpPost("TestJSON")]
        public ActionResult TestJSON([FromBody] myObject rb)
        {
            string strMsg = string.Format("firstName={0}, lastName={1}, JsonStr={2}",
                rb.firstName, rb.lastName, rb.JsonStr);
            //lblMsg1.Text = strMsg;
            myObject2 obj2 = JsonConvert.DeserializeObject<myObject2>(rb.JsonStr);
            //JsonObjectAttribute.JsonObjectAttribute("");
            JObject objJ1 = JObject.Parse(rb.JsonStr);
            string objAAA = objJ1["AAA"].ToString();
            //JSONObject Json = new JSONObject();
            //JSONArray JsonArray = new JSONArray();
            //Json.put("key", "value");//JSONObject对象中添加键值对 

            return Ok(new { errorId = 0, errorMsg = "", ReturnStr = strMsg });
        }
        [HttpPost("TestException")]
        public ActionResult TestException([FromBody] myObject rb)
        {
            string strMsg = string.Format("firstName={0}, lastName={1}, JsonStr={2}",
                rb.firstName, rb.lastName, rb.JsonStr);
            //lblMsg1.Text = strMsg;
            myObject2 obj2 = JsonConvert.DeserializeObject<myObject2>(rb.JsonStr);
            //JsonObjectAttribute.JsonObjectAttribute("");
            JObject objJ1 = JObject.Parse(rb.JsonStr);
            string objAAA = objJ1["AAA"].ToString();
            JObject jObj = new JObject();
            jObj["ErrorId"] = "0";
            jObj["ErrorMsg"] = "";
            jObj["returnStr"] = "";
            jObj["ObjStr"] = "{'AAA':'111', 'BBB':'222'}";

            string jsonText = jObj.ToString();
            //JSONObject Json = new JSONObject();
            //JSONArray JsonArray = new JSONArray();
            //Json.put("key", "value");//JSONObject对象中添加键值对 
            if (objAAA == "111")
            {
                jObj["ErrorId"] = "1";
                jObj["ErrorMsg"] = "Return TestException";
                jObj["returnStr"] = "";
                //jsonText = jObj.ToString();

                return Ok(new { errorId = 0, errorMsg = "", returnStr = "true" });
                //throw new Exception("Return TestException");
            }

            return Ok(new { errorId = 0, errorMsg = "Return TestException", returnStr = strMsg });
            //            return strMsg;
        }
    }
}